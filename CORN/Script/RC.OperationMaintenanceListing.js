var RC = RC || {};

RC.OperationMaintenanceListing = {
    HandlerURL: RC.Common.RootURL + "Handler/OperationMaintenanceHandler.ashx",
    OperationMaintenanceList: [],
    OperationMaintenanceObject: null,
    OperationMaintenanceListTable: null,
    OperationMaintenanceListTableInitialized: false,
    InitializePage: function () {
        if (RC.OperationMaintenanceListing.OperationMaintenanceList != null && RC.OperationMaintenanceListing.OperationMaintenanceList != undefined && RC.OperationMaintenanceListing.OperationMaintenanceList.length > 0) {
            RC.OperationMaintenanceListing.OperationMaintenanceListTableInitialized = true;

            $('#dvOperationMaintenanceListing #tblOperationMaintenanceList').DataTable({
                "data": RC.OperationMaintenanceListing.OperationMaintenanceList,
                "columns": [
                    { "data": "Title" },
                    { "data": "ShortTitle" },
                    {
                        data: null,
                        className: "center",
                        render: function (row, type, val, meta) {
                            return "<center><a title='Edit' href='javascript:void(0)' onclick='RC.OperationMaintenanceListing.OperationMaintenanceGetId(" + row.Id + ")'>" +
                                "<i id='iedit" + row.Id + "' class='fa fa-pencil' aria-hidden='true'></i></a>&nbsp;" +
                                "<a title='Delete' href='javascript:void(0)' onclick='RC.OperationMaintenanceListing.OperationMaintenanceDelete(" + row.Id + ")'>" +
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
    ValidateOperationMaintenance: function () {
        var status = true;

        if ($.trim($("#dvOperationMaintenanceDetail #txtTitle").val()) == "") {
            alert("Please provide title.");

            status = false;
        }

        return status;
    },
    PopulateOperationMaintenance: function () {
        var status = RC.OperationMaintenanceListing.ValidateOperationMaintenance();

        if (status) {
            var id = 0;

            if (RC.OperationMaintenanceListing.OperationMaintenanceObject != null) {
                id = RC.OperationMaintenanceListing.OperationMaintenanceObject.Id;
            }

            RC.OperationMaintenanceListing.OperationMaintenanceObject = { Id: 0, Title: '', ShortTitle: '' };
            RC.OperationMaintenanceListing.OperationMaintenanceObject.Id = id;
            RC.OperationMaintenanceListing.OperationMaintenanceObject.Title = $("#dvOperationMaintenanceDetail #txtTitle").val();
            RC.OperationMaintenanceListing.OperationMaintenanceObject.ShortTitle = $("#dvOperationMaintenanceDetail #txtShortTitle").val();
        }

        return status;
    },
    ResetOperationMaintenance: function () {
        RC.OperationMaintenanceListing.OperationMaintenanceObject = null;

        $("#dvOperationMaintenanceDetail #txtTitle").val('');
        $("#dvOperationMaintenanceDetail #txtShortTitle").val('');
        $('#dvOperationMaintenanceDetail #btnSave').removeClass("disabled").text('Save');
    },
    ReloadPage: function () {
        if (RC.OperationMaintenanceListing.OperationMaintenanceListTableInitialized) {
            $('#dvOperationMaintenanceListing #tblOperationMaintenanceList').dataTable().fnClearTable();

            if (RC.OperationMaintenanceListing.OperationMaintenanceList != null && RC.OperationMaintenanceListing.OperationMaintenanceList != undefined && RC.OperationMaintenanceListing.OperationMaintenanceList.length > 0) {
                $('#dvOperationMaintenanceListing #tblOperationMaintenanceList').dataTable().fnAddData(RC.OperationMaintenanceListing.OperationMaintenanceList);
                $('#dvOperationMaintenanceListing #tblOperationMaintenanceList').dataTable().fnDraw();
            }
        }
        else {
            RC.OperationMaintenanceListing.InitializePage();
        }
    },
    LoadOperationMaintenance: function () {
        $("#dvOperationMaintenanceDetail #txtTitle").val(RC.OperationMaintenanceListing.OperationMaintenanceObject.Title);
        $("#dvOperationMaintenanceDetail #txtShortTitle").val(RC.OperationMaintenanceListing.OperationMaintenanceObject.ShortTitle);
    },
    OperationMaintenanceGetId: function (id) {
        $("#iedit" + id).removeClass('fa-pencil').addClass('fa-spinner fa-spin');

        $.post(RC.OperationMaintenanceListing.HandlerURL,
            {
                method: 'OperationMaintenanceGetId',
                Id: id
            },
            function (response) {
                $("#iedit" + id).removeClass('fa-spinner fa-spin').addClass('fa-pencil');

                switch (response.Status) {
                    case RC.Common.ResponseStatus.SUCCESS:
                        RC.OperationMaintenanceListing.OperationMaintenanceObject = response.Data;

                        RC.OperationMaintenanceListing.LoadOperationMaintenance();

                        $('#dvOperationMaintenanceDetail').show();
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
    SaveOperationMaintenance: function () {
        if (RC.OperationMaintenanceListing.PopulateOperationMaintenance()) {
            $('#dvOperationMaintenanceDetail #btnSave').addClass("disabled").text('Wait...');

            RC.OperationMaintenanceListing.AddUpdateOperationMaintenance();
        }
    },
    AddUpdateOperationMaintenance: function () {
        var handlerMethod = 'OperationMaintenanceAdd';

        if (RC.OperationMaintenanceListing.OperationMaintenanceObject.Id > 0) {
            handlerMethod = 'OperationMaintenanceUpdate';
        }

        $.post(RC.OperationMaintenanceListing.HandlerURL,
        {
            method: handlerMethod,
            objOperationMaintenance: JSON.stringify(RC.OperationMaintenanceListing.OperationMaintenanceObject)
        },
        function (response) {
            switch (response.Status) {
                case RC.Common.ResponseStatus.SUCCESS:
                    alert(response.Message);

                    RC.OperationMaintenanceListing.RemoveOperationMaintenance(RC.OperationMaintenanceListing.OperationMaintenanceObject.Id);

                    RC.OperationMaintenanceListing.OperationMaintenanceList.push(response.Data);

                    RC.OperationMaintenanceListing.ReloadPage();
                    RC.OperationMaintenanceListing.ResetOperationMaintenance();

                    $('#dvOperationMaintenanceDetail #btnClose')[0].click();

                    break;
                case RC.Common.ResponseStatus.ERROR:
                    alert(response.Message);

                    $('#dvOperationMaintenanceDetail #btnSave').removeClass("disabled").text('Save');

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
    RemoveOperationMaintenance: function (id) {
        if (id > 0) {
            var apprIindex = $.map(RC.OperationMaintenanceListing.OperationMaintenanceList, function (obj, index) {
                if (obj.Id == id) {
                    return index;
                }
            });

            RC.OperationMaintenanceListing.OperationMaintenanceList.splice(apprIindex, 1);
        }
    },
    OperationMaintenanceDelete: function (id) {
        var r = confirm('Do you want to proceed?');

        if (r == true) {
            $("#idel" + id).removeClass('fa-trash-o').addClass('fa-spinner fa-spin');

            $.post(RC.OperationMaintenanceListing.HandlerURL,
                {
                    method: 'OperationMaintenanceDelete',
                    Id: id
                },
                function (response) {
                    $("#idel" + id).removeClass('fa-spinner fa-spin').addClass('fa-trash-o');

                    switch (response.Status) {
                        case RC.Common.ResponseStatus.SUCCESS:
                            alert(response.Message);

                            RC.OperationMaintenanceListing.RemoveOperationMaintenance(id);
                            RC.OperationMaintenanceListing.ReloadPage();

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
    RC.OperationMaintenanceListing.InitializePage();

    setTimeout(function () {
        $('#dvOperationMaintenanceListing #btnAdd')[0].click();

        setTimeout(function () {
            $('#dvOperationMaintenanceDetail #btnClose')[0].click();
        }, 50);
    }, 1000);
});