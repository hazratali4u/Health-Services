var RC = RC || {};

RC.ApprovedByListing = {
    HandlerURL: RC.Common.RootURL + "Handler/ApprovedByHandler.ashx",
    ApprovedByList: [],
    ApprovedByObject: null,
    ApprovedByListTable: null,
    ApprovedByListTableInitialized: false,
    InitializePage: function () {
        if (RC.ApprovedByListing.ApprovedByList != null && RC.ApprovedByListing.ApprovedByList != undefined && RC.ApprovedByListing.ApprovedByList.length > 0) {
            RC.ApprovedByListing.ApprovedByListTableInitialized = true;

            $('#dvApprovedByListing #tblApprovedByList').DataTable({
                "data": RC.ApprovedByListing.ApprovedByList,
                "columns": [
                    { "data": "Title" },
                    { "data": "ShortTitle" },
                    {
                        data: null,
                        className: "center",
                        render: function (row, type, val, meta) {
                            return "<center><a title='Edit' href='javascript:void(0)' onclick='RC.ApprovedByListing.ApprovedByGetId(" + row.Id + ")'>" +
                                "<i id='iedit" + row.Id + "' class='fa fa-pencil' aria-hidden='true'></i></a>&nbsp;" +
                                "<a title='Delete' href='javascript:void(0)' onclick='RC.ApprovedByListing.ApprovedByDelete(" + row.Id + ")'>" +
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
    ValidateApprovedBy: function () {
        var status = true;

        if ($.trim($("#dvApprovedByDetail #txtTitle").val()) == "") {
            alert("Please provide title.");

            status = false;
        }

        return status;
    },
    PopulateApprovedBy: function () {
        var status = RC.ApprovedByListing.ValidateApprovedBy();

        if (status) {
            var id = 0;

            if (RC.ApprovedByListing.ApprovedByObject != null) {
                id = RC.ApprovedByListing.ApprovedByObject.Id;
            }

            RC.ApprovedByListing.ApprovedByObject = { Id: 0, Title: '', ShortTitle: '' };
            RC.ApprovedByListing.ApprovedByObject.Id = id;
            RC.ApprovedByListing.ApprovedByObject.Title = $("#dvApprovedByDetail #txtTitle").val();
            RC.ApprovedByListing.ApprovedByObject.ShortTitle = $("#dvApprovedByDetail #txtShortTitle").val();
        }

        return status;
    },
    ResetApprovedBy: function () {
        RC.ApprovedByListing.ApprovedByObject = null;

        $("#dvApprovedByDetail #txtTitle").val('');
        $("#dvApprovedByDetail #txtShortTitle").val('');
        $('#dvApprovedByDetail #btnSave').removeClass("disabled").text('Save');
    },
    ReloadPage: function () {
        if (RC.ApprovedByListing.ApprovedByListTableInitialized) {
            $('#dvApprovedByListing #tblApprovedByList').dataTable().fnClearTable();

            if (RC.ApprovedByListing.ApprovedByList != null && RC.ApprovedByListing.ApprovedByList != undefined && RC.ApprovedByListing.ApprovedByList.length > 0) {
                $('#dvApprovedByListing #tblApprovedByList').dataTable().fnAddData(RC.ApprovedByListing.ApprovedByList);
                $('#dvApprovedByListing #tblApprovedByList').dataTable().fnDraw();
            }
        }
        else {
            RC.ApprovedByListing.InitializePage();
        }
    },
    LoadApprovedBy: function () {
        $("#dvApprovedByDetail #txtTitle").val(RC.ApprovedByListing.ApprovedByObject.Title);
        $("#dvApprovedByDetail #txtShortTitle").val(RC.ApprovedByListing.ApprovedByObject.ShortTitle);
    },
    ApprovedByGetId: function (id) {
        $("#iedit" + id).removeClass('fa-pencil').addClass('fa-spinner fa-spin');

        $.post(RC.ApprovedByListing.HandlerURL,
            {
                method: 'ApprovedByGetId',
                Id: id
            },
            function (response) {
                $("#iedit" + id).removeClass('fa-spinner fa-spin').addClass('fa-pencil');

                switch (response.Status) {
                    case RC.Common.ResponseStatus.SUCCESS:
                        RC.ApprovedByListing.ApprovedByObject = response.Data;

                        RC.ApprovedByListing.LoadApprovedBy();

                        $('#dvApprovedByDetail').show();
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
    SaveApprovedBy: function () {
        if (RC.ApprovedByListing.PopulateApprovedBy()) {
            $('#dvApprovedByDetail #btnSave').addClass("disabled").text('Wait...');

            RC.ApprovedByListing.AddUpdateApprovedBy();
        }
    },
    AddUpdateApprovedBy: function () {
        var handlerMethod = 'ApprovedByAdd';

        if (RC.ApprovedByListing.ApprovedByObject.Id > 0) {
            handlerMethod = 'ApprovedByUpdate';
        }

        $.post(RC.ApprovedByListing.HandlerURL,
        {
            method: handlerMethod,
            objApprovedBy: JSON.stringify(RC.ApprovedByListing.ApprovedByObject)
        },
        function (response) {
            switch (response.Status) {
                case RC.Common.ResponseStatus.SUCCESS:
                    alert(response.Message);

                    RC.ApprovedByListing.RemoveApprovedBy(RC.ApprovedByListing.ApprovedByObject.Id);

                    RC.ApprovedByListing.ApprovedByList.push(response.Data);

                    RC.ApprovedByListing.ReloadPage();
                    RC.ApprovedByListing.ResetApprovedBy();

                    $('#dvApprovedByDetail #btnClose')[0].click();

                    break;
                case RC.Common.ResponseStatus.ERROR:
                    alert(response.Message);

                    $('#dvApprovedByDetail #btnSave').removeClass("disabled").text('Save');

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
    RemoveApprovedBy: function (id) {
        if (id > 0) {
            var apprIindex = $.map(RC.ApprovedByListing.ApprovedByList, function (obj, index) {
                if (obj.Id == id) {
                    return index;
                }
            });

            RC.ApprovedByListing.ApprovedByList.splice(apprIindex, 1);
        }
    },
    ApprovedByDelete: function (id) {
        var r = confirm('Do you want to proceed?');

        if (r == true) {
            $("#idel" + id).removeClass('fa-trash-o').addClass('fa-spinner fa-spin');

            $.post(RC.ApprovedByListing.HandlerURL,
                {
                    method: 'ApprovedByDelete',
                    Id: id
                },
                function (response) {
                    $("#idel" + id).removeClass('fa-spinner fa-spin').addClass('fa-trash-o');

                    switch (response.Status) {
                        case RC.Common.ResponseStatus.SUCCESS:
                            alert(response.Message);

                            RC.ApprovedByListing.RemoveApprovedBy(id);
                            RC.ApprovedByListing.ReloadPage();

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
    RC.ApprovedByListing.InitializePage();

    setTimeout(function () {
        $('#dvApprovedByListing #btnAdd')[0].click();

        setTimeout(function () {
            $('#dvApprovedByDetail #btnClose')[0].click();
        }, 50);
    }, 1000);
});