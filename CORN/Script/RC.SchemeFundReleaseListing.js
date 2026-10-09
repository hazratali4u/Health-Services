var RC = RC || {};

RC.SchemeFundReleaseListing = {
    HandlerURL: RC.Common.RootURL + "Handler/SchemeFundReleaseHandler.ashx",
    SchemeFundReleaseList: [],
    SchemeFundReleaseListTable: null,
    InitializePage: function () {
        if (RC.SchemeFundReleaseListing.SchemeFundReleaseList != null && RC.SchemeFundReleaseListing.SchemeFundReleaseList != undefined && RC.SchemeFundReleaseListing.SchemeFundReleaseList.length > 0) {
            $('#dvSchemeFundReleaseListing #tblSchemeFundReleaseList').DataTable({
                "data": RC.SchemeFundReleaseListing.SchemeFundReleaseList,
                "columns": [
                    { "data": "SchemeTitle" },
                    //{ "data": "FundReleaseTypeName" },
                    {
                        data: "YearName",
                        className: "center"
                    },
                    {
                        data: "FrDateString",
                        className: "center",
                        orderable: false
                    },
                    {
                        data: "TotalReleases",
                        className: "center",
                        render: function (data, type, full, meta) {
                            return RC.Common.FormatNumber(data);
                        }
                    },
                    {
                        data: null,
                        className: "center",
                        render: function (row, type, val, meta) {
                            return "<center><a title='Edit' href='" + RC.Common.RootURL + "Forms/frmSchemeFundReleaseAdd.aspx?LevelType=" +
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
    RC.SchemeFundReleaseListing.InitializePage();

    $('#dvSchemeFundReleaseListing #btnAdd').on('click', function () {
        window.location = RC.Common.RootURL + "Forms/frmSchemeFundReleaseAdd.aspx?LevelType=" + RC.Common.GetQueryStringByName('LevelType') + "&LevelID=" + RC.Common.GetQueryStringByName('LevelID');

        return false;
    });
});