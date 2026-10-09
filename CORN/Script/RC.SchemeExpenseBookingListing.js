var RC = RC || {};

RC.SchemeExpenseBookingListing = {
    HandlerURL: RC.Common.RootURL + "Handler/SchemeExpenseBookingHandler.ashx",
    SchemeExpenseBookingList: [],
    SchemeExpenseBookingListTable: null,
    InitializePage: function () {
        if (RC.SchemeExpenseBookingListing.SchemeExpenseBookingList != null && RC.SchemeExpenseBookingListing.SchemeExpenseBookingList != undefined && RC.SchemeExpenseBookingListing.SchemeExpenseBookingList.length > 0) {
            $('#dvSchemeExpenseBookingListing #tblSchemeExpenseBookingList').DataTable({
                "data": RC.SchemeExpenseBookingListing.SchemeExpenseBookingList,
                "columns": [
                    { "data": "SchemeTitle" },
                    { "data": "POReferenceOrInvoiceNo" },
                    {
                        "data": "BookingTypeTitle",
                        className: "center"
                    },
                    {
                        "data": "TotalAmount",
                        className: "center",
                        render: function (data, type, full, meta) {
                            return RC.Common.FormatNumber(data);
                        }
                    },
                    {
                        data: "ExpenseDateString",
                        className: "center",
                        orderable: false
                    },
                    {
                        data: null,
                        className: "center",
                        render: function (row, type, val, meta) {
                            return "<center><a title='Edit' href='" + RC.Common.RootURL + "Forms/frmExpesneBookingAdd.aspx?LevelType=" +
                                RC.Common.GetQueryStringByName('LevelType') + "&LevelID=" + RC.Common.GetQueryStringByName('LevelID') + "&Id=" + row.Id + "'>" +
                                "<i class='fa fa-pencil' aria-hidden='true'></i></a>&nbsp;" +
                                "<a title='Delete' href='javascript:void(0)' onclick='RC.SchemeExpenseBookingListing.SchemeExpenseBookingDelete(" + row.Id + ")'>" +
                                "<i class='fa fa-trash-o' aria-hidden='true'></i></a></center>";
                        },
                        orderable: false,
                        defaultContent: ""
                    }
                ]
            });
        }
    },
    SchemeExpenseBookingDelete: function (Id) {
        var r = confirm('Do you want to proceed?');

        if (r == true) {
            $.post(RC.SchemeExpenseBookingListing.HandlerURL,
                {
                    method: 'SchemeExpenseBookingDelete',
                    Id: Id
                },
                function (response) {
                    switch (response.Status) {
                        case RC.Common.ResponseStatus.SUCCESS:
                            var prodIindex = $.map(RC.SchemeExpenseBookingListing.SchemeExpenseBookingList, function (obj, index) {
                                if (obj.Id == Id) {
                                    return index;
                                }
                            });

                            RC.SchemeExpenseBookingListing.SchemeExpenseBookingList.splice(prodIindex, 1);

                            alert(response.Message);

                            $('#dvSchemeExpenseBookingListing #tblSchemeExpenseBookingList').dataTable().fnClearTable();

                            if (RC.SchemeExpenseBookingListing.SchemeExpenseBookingList != null && RC.SchemeExpenseBookingListing.SchemeExpenseBookingList != undefined && RC.SchemeExpenseBookingListing.SchemeExpenseBookingList.length > 0) {
                                $('#dvSchemeExpenseBookingListing #tblSchemeExpenseBookingList').dataTable().fnAddData(RC.SchemeExpenseBookingListing.SchemeExpenseBookingList);
                                $('#dvSchemeExpenseBookingListing #tblSchemeExpenseBookingList').dataTable().fnDraw();
                            }

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
    RC.SchemeExpenseBookingListing.InitializePage();

    $('#dvSchemeExpenseBookingListing #btnAdd').on('click', function () {
        window.location = RC.Common.RootURL + "Forms/frmExpesneBookingAdd.aspx?LevelType=" + RC.Common.GetQueryStringByName('LevelType') + "&LevelID=" + RC.Common.GetQueryStringByName('LevelID');

        return false;
    });
});