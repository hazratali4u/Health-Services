var RC = RC || {};

RC.SchemeFundAllocationListing = {
    HandlerURL: RC.Common.RootURL + "Handler/SchemeFundAllocationHandler.ashx",
    SchemeFundAllocationList: [],
    SchemeFundAllocationListTable: null,
    InitializePage: function () {
        if (RC.SchemeFundAllocationListing.SchemeFundAllocationList != null && RC.SchemeFundAllocationListing.SchemeFundAllocationList != undefined && RC.SchemeFundAllocationListing.SchemeFundAllocationList.length > 0) {
            $('#dvSchemeFundAllocationListing #tblSchemeFundAllocationList').DataTable({
                "data": RC.SchemeFundAllocationListing.SchemeFundAllocationList,
                "columns": [
                    { "data": "SchemeTitle" },
                    { "data": "FundAllocationTypeName" },
                    {
                        data: "YearName",
                        className: "center"
                    },
                    {
                        data: "FaDateString",
                        className: "center",
                        orderable: false
                    },
                    {
                        data: null,
                        className: "center",
                        render: function (row, type, val, meta) {
                            var actionHtml = "<center>";

                            if (row.SchemeStatusId != 2) {
                                actionHtml += "<a title='Edit' href='" + RC.Common.RootURL + "Forms/frmSchemeFundAllocationAdd.aspx?LevelType=" +
                                    RC.Common.GetQueryStringByName('LevelType') + "&LevelID=" + RC.Common.GetQueryStringByName('LevelID') + "&Id=" + row.Id + "'>" +
                                    "<i class='fa fa-pencil' aria-hidden='true'></i></a>";
                            }

                            actionHtml += "</center>";

                            return actionHtml;
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
    RC.SchemeFundAllocationListing.InitializePage();

    $('#dvSchemeFundAllocationListing #btnAdd').on('click', function () {
        window.location = RC.Common.RootURL + "Forms/frmSchemeFundAllocationAdd.aspx?LevelType=" + RC.Common.GetQueryStringByName('LevelType') + "&LevelID=" + RC.Common.GetQueryStringByName('LevelID');

        return false;
    });
});