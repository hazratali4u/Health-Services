var RC = RC || {};

RC.SchemeExcessListing = {
    HandlerURL: RC.Common.RootURL + "Handler/SchemeExcessHandler.ashx",
    SchemeExcessList: [],
    SchemeExcessListTable: null,
    InitializePage: function () {
        if (RC.SchemeExcessListing.SchemeExcessList != null && RC.SchemeExcessListing.SchemeExcessList != undefined && RC.SchemeExcessListing.SchemeExcessList.length > 0) {
            $('#dvSchemeExcessListing #tblSchemeExcessList').DataTable({
                "data": RC.SchemeExcessListing.SchemeExcessList,
                "columns": [
                    { "data": "SchemeTitle" },
                    {
                        data: "YearName",
                        className: "center"
                    },
                    {
                        data: "ExcessDateString",
                        className: "center",
                        orderable: false
                    },
                    {
                        data: null,
                        className: "center",
                        render: function (row, type, val, meta) {
                            return "<center><a title='Edit' href='" + RC.Common.RootURL + "Forms/frmExpesneSurrenderAdd.aspx?LevelType=" + RC.Common.GetQueryStringByName('LevelType') +
                                "&LevelID=" + RC.Common.GetQueryStringByName('LevelID') + "&Id=" + row.Id + "'><i class='fa fa-pencil' aria-hidden='true'></i></a></center>";
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
    RC.SchemeExcessListing.InitializePage();

    $('#dvSchemeExcessListing #btnAdd').on('click', function () {
        window.location = RC.Common.RootURL + "Forms/frmExpesneSurrenderAdd.aspx?LevelType=" + RC.Common.GetQueryStringByName('LevelType') + "&LevelID=" + RC.Common.GetQueryStringByName('LevelID');

        return false;
    });
});