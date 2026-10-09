var RC = RC || {};

RC.ExecutionListing = {
    HandlerURL: RC.Common.RootURL + "Handler/ExecutionHandler.ashx",
    ExecutionList: [],
    ExecutionObject: null,
    ExecutionListTable: null,
    ExecutionListTableInitialized: false,
    InitializePage: function () {
        if (RC.ExecutionListing.ExecutionList != null && RC.ExecutionListing.ExecutionList != undefined && RC.ExecutionListing.ExecutionList.length > 0) {
            RC.ExecutionListing.ExecutionListTableInitialized = true;

            $('#dvExecutionListing #tblExecutionList').DataTable({
                "data": RC.ExecutionListing.ExecutionList,
                "columns": [
                    { "data": "Title" },
                    { "data": "ShortTitle" },
                    {
                        data: null,
                        className: "center",
                        render: function (row, type, val, meta) {
                            return "<center><a title='Edit' href='javascript:void(0)' onclick='RC.ExecutionListing.ExecutionGetId(" + row.Id + ")'>" +
                                "<i id='iedit" + row.Id + "' class='fa fa-pencil' aria-hidden='true'></i></a>&nbsp;" +
                                "<a title='Delete' href='javascript:void(0)' onclick='RC.ExecutionListing.ExecutionDelete(" + row.Id + ")'>" +
                                "<i id='idel" + row.Id + "' class='fa fa-trash-o' aria-hidden='true'></i></a></center>";
                        },
                        orderable: false,
                        defaultContent: ""
                    }
                ],
                aaSorting: [[1, 'asc']]
            });
        }
    },
    ValidateExecution: function () {
        var status = true;

        if ($.trim($("#dvExecutionDetail #txtTitle").val()) == "") {
            alert("Please provide title.");

            status = false;
        }

        return status;
    },
    PopulateExecution: function () {
        var status = RC.ExecutionListing.ValidateExecution();

        if (status) {
            var id = 0;

            if (RC.ExecutionListing.ExecutionObject != null) {
                id = RC.ExecutionListing.ExecutionObject.Id;
            }

            RC.ExecutionListing.ExecutionObject = { Id: 0, Title: '', ShortTitle: '' };
            RC.ExecutionListing.ExecutionObject.Id = id;
            RC.ExecutionListing.ExecutionObject.Title = $("#dvExecutionDetail #txtTitle").val();
            RC.ExecutionListing.ExecutionObject.ShortTitle = $("#dvExecutionDetail #txtShortTitle").val();
        }

        return status;
    },
    ResetExecution: function () {
        RC.ExecutionListing.ExecutionObject = null;

        $("#dvExecutionDetail #txtTitle").val('');
        $("#dvExecutionDetail #txtShortTitle").val('');
        $('#dvExecutionDetail #btnSave').removeClass("disabled").text('Save');
    },
    ReloadPage: function () {
        if (RC.ExecutionListing.ExecutionListTableInitialized) {
            $('#dvExecutionListing #tblExecutionList').dataTable().fnClearTable();

            if (RC.ExecutionListing.ExecutionList != null && RC.ExecutionListing.ExecutionList != undefined && RC.ExecutionListing.ExecutionList.length > 0) {
                $('#dvExecutionListing #tblExecutionList').dataTable().fnAddData(RC.ExecutionListing.ExecutionList);
                $('#dvExecutionListing #tblExecutionList').dataTable().fnDraw();
            }
        }
        else {
            RC.ExecutionListing.InitializePage();
        }
    },
    LoadExecution: function () {
        $("#dvExecutionDetail #txtTitle").val(RC.ExecutionListing.ExecutionObject.Title);
        $("#dvExecutionDetail #txtShortTitle").val(RC.ExecutionListing.ExecutionObject.ShortTitle);
    },
    ExecutionGetId: function (id) {
        $("#iedit" + id).removeClass('fa-pencil').addClass('fa-spinner fa-spin');

        $.post(RC.ExecutionListing.HandlerURL,
            {
                method: 'ExecutionGetId',
                Id: id
            },
            function (response) {
                $("#iedit" + id).removeClass('fa-spinner fa-spin').addClass('fa-pencil');

                switch (response.Status) {
                    case RC.Common.ResponseStatus.SUCCESS:
                        RC.ExecutionListing.ExecutionObject = response.Data;

                        RC.ExecutionListing.LoadExecution();

                        $('#dvExecutionDetail').show();
                        $('#ModelPopup_backgroundElement').show();

                        break;
                    case RC.Common.ResponseStatus.ERROR:
                        alert(response.Message);

                        break;
                    case RC.Common.ResponseStatus.SESSIONEXPIRED:
                        alert(response.Message);

                        window.location = RC.Common.GetLoginURL();

                        break;
                    default:
                        break;
                }
            });
    },
    SaveExecution: function () {
        if (RC.ExecutionListing.PopulateExecution()) {
            $('#dvExecutionDetail #btnSave').addClass("disabled").text('Wait...');

            RC.ExecutionListing.AddUpdateExecution();
        }
    },
    AddUpdateExecution: function () {
        var handlerMethod = 'ExecutionAdd';

        if (RC.ExecutionListing.ExecutionObject.Id > 0) {
            handlerMethod = 'ExecutionUpdate';
        }

        $.post(RC.ExecutionListing.HandlerURL,
        {
            method: handlerMethod,
            objExecution: JSON.stringify(RC.ExecutionListing.ExecutionObject)
        },
        function (response) {
            switch (response.Status) {
                case RC.Common.ResponseStatus.SUCCESS:
                    alert(response.Message);

                    RC.ExecutionListing.RemoveExecution(RC.ExecutionListing.ExecutionObject.Id);

                    RC.ExecutionListing.ExecutionList.push(response.Data);

                    RC.ExecutionListing.ReloadPage();
                    RC.ExecutionListing.ResetExecution();

                    $('#dvExecutionDetail #btnClose')[0].click();

                    break;
                case RC.Common.ResponseStatus.ERROR:
                    alert(response.Message);

                    $('#dvExecutionDetail #btnSave').removeClass("disabled").text('Save');

                    break;
                case RC.Common.ResponseStatus.SESSIONEXPIRED:
                    alert(response.Message);

                    window.location = RC.Common.GetLoginURL();

                    break;
                default:
                    break;
            }
        });
    },
    RemoveExecution: function (id) {
        if (id > 0) {
            var apprIindex = $.map(RC.ExecutionListing.ExecutionList, function (obj, index) {
                if (obj.Id == id) {
                    return index;
                }
            });

            RC.ExecutionListing.ExecutionList.splice(apprIindex, 1);
        }
    },
    ExecutionDelete: function (id) {
        var r = confirm('Do you want to proceed?');

        if (r == true) {
            $("#idel" + id).removeClass('fa-trash-o').addClass('fa-spinner fa-spin');

            $.post(RC.ExecutionListing.HandlerURL,
                {
                    method: 'ExecutionDelete',
                    Id: id
                },
                function (response) {
                    $("#idel" + id).removeClass('fa-spinner fa-spin').addClass('fa-trash-o');

                    switch (response.Status) {
                        case RC.Common.ResponseStatus.SUCCESS:
                            alert(response.Message);

                            RC.ExecutionListing.RemoveExecution(id);
                            RC.ExecutionListing.ReloadPage();

                            break;
                        case RC.Common.ResponseStatus.ERROR:
                            alert(response.Message);

                            break;
                        case RC.Common.ResponseStatus.SESSIONEXPIRED:
                            alert(response.Message);

                            window.location = RC.Common.GetLoginURL();

                            break;
                        default:
                            break;
                    }
                });
        }
    }
}

$(document).ready(function () {
    RC.ExecutionListing.InitializePage();

    setTimeout(function () {
        $('#dvExecutionListing #btnAdd')[0].click();

        setTimeout(function () {
            $('#dvExecutionDetail #btnClose')[0].click();
        }, 50);
    }, 1000);
});