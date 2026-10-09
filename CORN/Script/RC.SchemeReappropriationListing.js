var RC = RC || {};

RC.SchemeReappropriationListing = {
    HandlerURL: RC.Common.RootURL + "Handler/SchemeReappropriationHandler.ashx",
    SchemeReappropriationList: [],
    SchemeReappropriationListTable: null,
    InitializePage: function () {
        if (RC.SchemeReappropriationListing.SchemeReappropriationList != null && RC.SchemeReappropriationListing.SchemeReappropriationList != undefined && RC.SchemeReappropriationListing.SchemeReappropriationList.length > 0) {
            $('#dvSchemeReappropriationListing #tblSchemeReappropriationList').DataTable({
                "data": RC.SchemeReappropriationListing.SchemeReappropriationList,
                "columns": [
                    {
                        data: "YearName",
                        className: "center"
                    },
                    {
                        data: "MonthName",
                        className: "center"
                    },
                    {
                        data: null,
                        className: "center",
                        render: function (row, type, val, meta) {
                            return "<center><a title='Edit' href='" + RC.Common.RootURL + "Forms/frmSchemeReapproiationAdd.aspx?LevelType=" +
                                RC.Common.GetQueryStringByName('LevelType') + "&LevelID=" + RC.Common.GetQueryStringByName('LevelID') + "&Id=" + row.Id + "'>" +
                                "<i class='fa fa-pencil' aria-hidden='true'></i></a></center>";
                        },
                        orderable: false,
                        defaultContent: ""
                    }
                ],
                aaSorting: [[1, 'asc']]
            });
        }
    }
}

$(document).ready(function () {
    RC.SchemeReappropriationListing.InitializePage();

    $('#dvSchemeReappropriationListing #btnAdd').on('click', function () {
        window.location = RC.Common.RootURL + "Forms/frmSchemeReapproiationAdd.aspx?LevelType=" + RC.Common.GetQueryStringByName('LevelType') + "&LevelID=" + RC.Common.GetQueryStringByName('LevelID');

        return false;
    });
});