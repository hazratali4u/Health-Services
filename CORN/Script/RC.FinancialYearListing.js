var RC = RC || {};

RC.FinancialYearListing = {
    HandlerURL: RC.Common.RootURL + "Handler/FinancialYearHandler.ashx",
    FinancialYearList: [],
    FinancialYearObject: null,
    FinancialYearListTable: null,
    FinancialYearListTableInitialized: false,
    InitializePage: function () {
        if (RC.FinancialYearListing.FinancialYearList != null && RC.FinancialYearListing.FinancialYearList != undefined && RC.FinancialYearListing.FinancialYearList.length > 0) {
            RC.FinancialYearListing.FinancialYearListTableInitialized = true;

            $('#dvFinancialYearListing #tblFinancialYearList').DataTable({
                "data": RC.FinancialYearListing.FinancialYearList,
                "columns": [
                    {
                        data: "YearName",
                        className: "center"
                    },
                    {
                        data: "StartDateString",
                        className: "center",
                        orderable: false
                    },
                    {
                        data: "EndDateString",
                        className: "center",
                        orderable: false
                    },
                    //{
                    //    data: "IsOpen",
                    //    className: "center"
                    //},
                    {
                        data: "IsClosed",
                        className: "center"
                    },
                    {
                        data: null,
                        className: "center",
                        render: function (row, type, val, meta) {
                            return "<center><a title='Edit' href='javascript:void(0)' onclick='RC.FinancialYearListing.FinancialYearGetId(" + row.Id + ")'>" +
                                "<i id='iedit" + row.Id + "' class='fa fa-pencil' aria-hidden='true'></i></a>&nbsp;" +
                                "<a title='Delete' href='javascript:void(0)' onclick='RC.FinancialYearListing.FinancialYearDelete(" + row.Id + ")'>" +
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
    ValidateFinancialYear: function () {
        var status = true;

        if ($.trim($("#dvFinancialYearDetail #txtYearName").val()) == "") {
            alert("Please provide title.");

            status = false;
        }
        else if ($.trim($("#dvFinancialYearDetail #txtStartDate").val()) == "") {
            alert("Please provide start date.");

            status = false;
        }
        else if ($.trim($("#dvFinancialYearDetail #txtEndDate").val()) == "") {
            alert("Please provide end date.");

            status = false;
        }

        return status;
    },
    PopulateFinancialYear: function () {
        var status = RC.FinancialYearListing.ValidateFinancialYear();

        if (status) {
            var id = 0;

            if (RC.FinancialYearListing.FinancialYearObject != null) {
                id = RC.FinancialYearListing.FinancialYearObject.Id;
            }

            RC.FinancialYearListing.FinancialYearObject = { Id: 0, ShortName: '', YearName: '', DisplayName: '', Description: '', StartDate: '', EndDate: '', IsOpen: false, IsClosed: false };
            RC.FinancialYearListing.FinancialYearObject.Id = id;
            RC.FinancialYearListing.FinancialYearObject.ShortName = $("#dvFinancialYearDetail #txtShortName").val();
            RC.FinancialYearListing.FinancialYearObject.YearName = $("#dvFinancialYearDetail #txtYearName").val();
            RC.FinancialYearListing.FinancialYearObject.DisplayName = $("#dvFinancialYearDetail #txtDisplayName").val();
            RC.FinancialYearListing.FinancialYearObject.Description = $("#dvFinancialYearDetail #txtDescription").val();
            RC.FinancialYearListing.FinancialYearObject.StartDate = $("#dvFinancialYearDetail #txtStartDate").val();
            RC.FinancialYearListing.FinancialYearObject.EndDate = $("#dvFinancialYearDetail #txtEndDate").val();
            RC.FinancialYearListing.FinancialYearObject.IsOpen = $("#dvFinancialYearDetail #chkOpen").is(':checked');
            RC.FinancialYearListing.FinancialYearObject.IsClosed = $("#dvFinancialYearDetail #chkClosed").is(':checked');
        }

        return status;
    },
    ResetFinancialYear: function () {
        RC.FinancialYearListing.FinancialYearObject = null;

        $("#dvFinancialYearDetail #txtShortName").val('');
        $("#dvFinancialYearDetail #txtYearName").val('');
        $("#dvFinancialYearDetail #txtDisplayName").val('');
        $("#dvFinancialYearDetail #txtDescription").val('');
        $("#dvFinancialYearDetail #txtStartDate").val('');
        $("#dvFinancialYearDetail #txtEndDate").val('');
        $("#dvFinancialYearDetail #chkOpen").prop("checked", false);
        $("#dvFinancialYearDetail #chkClosed").prop("checked", false);

        $('#dvFinancialYearDetail #btnSave').removeClass("disabled").text('Save');
    },
    ReloadPage: function () {
        if (RC.FinancialYearListing.FinancialYearListTableInitialized) {
            $('#dvFinancialYearListing #tblFinancialYearList').dataTable().fnClearTable();

            if (RC.FinancialYearListing.FinancialYearList != null && RC.FinancialYearListing.FinancialYearList != undefined && RC.FinancialYearListing.FinancialYearList.length > 0) {
                $('#dvFinancialYearListing #tblFinancialYearList').dataTable().fnAddData(RC.FinancialYearListing.FinancialYearList);
                $('#dvFinancialYearListing #tblFinancialYearList').dataTable().fnDraw();
            }
        }
        else {
            RC.FinancialYearListing.InitializePage();
        }
    },
    LoadFinancialYear: function () {
        $("#dvFinancialYearDetail #txtShortName").val(RC.FinancialYearListing.FinancialYearObject.ShortName);
        $("#dvFinancialYearDetail #txtYearName").val(RC.FinancialYearListing.FinancialYearObject.YearName);
        $("#dvFinancialYearDetail #txtDisplayName").val(RC.FinancialYearListing.FinancialYearObject.DisplayName);
        $("#dvFinancialYearDetail #txtDescription").val(RC.FinancialYearListing.FinancialYearObject.Description);
        $("#dvFinancialYearDetail #txtStartDate").val(RC.FinancialYearListing.FinancialYearObject.StartDateString);
        $("#dvFinancialYearDetail #txtEndDate").val(RC.FinancialYearListing.FinancialYearObject.EndDateString);
        $("#dvFinancialYearDetail #chkOpen").prop("checked", RC.FinancialYearListing.FinancialYearObject.IsOpen);
        $("#dvFinancialYearDetail #chkClosed").prop("checked", RC.FinancialYearListing.FinancialYearObject.IsClosed);
    },
    FinancialYearGetId: function (id) {
        $("#iedit" + id).removeClass('fa-pencil').addClass('fa-spinner fa-spin');

        $.post(RC.FinancialYearListing.HandlerURL,
            {
                method: 'FinancialYearGetId',
                Id: id
            },
            function (response) {
                $("#iedit" + id).removeClass('fa-spinner fa-spin').addClass('fa-pencil');

                switch (response.Status) {
                    case RC.Common.ResponseStatus.SUCCESS:
                        RC.FinancialYearListing.FinancialYearObject = response.Data;

                        RC.FinancialYearListing.LoadFinancialYear();

                        $('#dvFinancialYearDetail').show();
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
    SaveFinancialYear: function () {
        if (RC.FinancialYearListing.PopulateFinancialYear()) {
            $('#dvFinancialYearDetail #btnSave').addClass("disabled").text('Wait...');

            RC.FinancialYearListing.AddUpdateFinancialYear();
        }
    },
    AddUpdateFinancialYear: function () {
        var handlerMethod = 'FinancialYearAdd';

        if (RC.FinancialYearListing.FinancialYearObject.Id > 0) {
            handlerMethod = 'FinancialYearUpdate';
        }

        $.post(RC.FinancialYearListing.HandlerURL,
        {
            method: handlerMethod,
            objFinancialYear: JSON.stringify(RC.FinancialYearListing.FinancialYearObject)
        },
        function (response) {
            switch (response.Status) {
                case RC.Common.ResponseStatus.SUCCESS:
                    alert(response.Message);

                    RC.FinancialYearListing.RemoveFinancialYear(RC.FinancialYearListing.FinancialYearObject.Id);

                    RC.FinancialYearListing.FinancialYearList.push(response.Data);

                    RC.FinancialYearListing.ReloadPage();
                    RC.FinancialYearListing.ResetFinancialYear();

                    $('#dvFinancialYearDetail #btnClose')[0].click();

                    break;
                case RC.Common.ResponseStatus.ERROR:
                    alert(response.Message);

                    $('#dvFinancialYearDetail #btnSave').removeClass("disabled").text('Save');

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
    RemoveFinancialYear: function (id) {
        if (id > 0) {
            var apprIindex = $.map(RC.FinancialYearListing.FinancialYearList, function (obj, index) {
                if (obj.Id == id) {
                    return index;
                }
            });

            RC.FinancialYearListing.FinancialYearList.splice(apprIindex, 1);
        }
    },
    FinancialYearDelete: function (id) {
        var r = confirm('Do you want to proceed?');

        if (r == true) {
            $("#idel" + id).removeClass('fa-trash-o').addClass('fa-spinner fa-spin');

            $.post(RC.FinancialYearListing.HandlerURL,
                {
                    method: 'FinancialYearDelete',
                    Id: id
                },
                function (response) {
                    $("#idel" + id).removeClass('fa-spinner fa-spin').addClass('fa-trash-o');

                    switch (response.Status) {
                        case RC.Common.ResponseStatus.SUCCESS:
                            alert(response.Message);

                            RC.FinancialYearListing.RemoveFinancialYear(id);
                            RC.FinancialYearListing.ReloadPage();

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
    RC.FinancialYearListing.InitializePage();

    setTimeout(function () {
        $('#dvFinancialYearListing #btnAdd')[0].click();

        setTimeout(function () {
            $('#dvFinancialYearDetail #btnClose')[0].click();
        }, 50);
    }, 1000);
});