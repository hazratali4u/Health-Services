var RC = RC || {};

RC.SchemeFundProposalListing = {
    HandlerURL: RC.Common.RootURL + "Handler/SchemeFundProposalHandler.ashx",
    SchemeFundProposalList: [],
    SchemeFundProposalListTable: null,
    InitializePage: function () {
        if (RC.SchemeFundProposalListing.SchemeFundProposalList != null && RC.SchemeFundProposalListing.SchemeFundProposalList != undefined && RC.SchemeFundProposalListing.SchemeFundProposalList.length > 0) {
            $('#dvSchemeFundProposalListing #tblSchemeFundProposalList').DataTable({
                "data": RC.SchemeFundProposalListing.SchemeFundProposalList,
                "columns": [
                    { "data": "SchemeTitle" },
                    {
                        data: "CategoryTitle",
                        className: "center"
                    },
                    {
                        data: "dtmProposedDateString",
                        className: "center",
                        orderable: false
                    },
                    {
                        data: null,
                        className: "center",
                        render: function (row, type, val, meta) {
                            return "<center><a title='Edit' href='" + RC.Common.RootURL + "Forms/frmSchemeFundProposalAdd.aspx?LevelType=" + RC.Common.GetQueryStringByName('LevelType') +
                                "&LevelID=" + RC.Common.GetQueryStringByName('LevelID') + "&Id=" + row.lngPlanCode + "'><i class='fa fa-pencil' aria-hidden='true'></i></a></center>";
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
    RC.SchemeFundProposalListing.InitializePage();

    $('#dvSchemeFundProposalListing #btnAdd').on('click', function () {
        window.location = RC.Common.RootURL + "Forms/frmSchemeFundProposalAdd.aspx?LevelType=" + RC.Common.GetQueryStringByName('LevelType') + "&LevelID=" + RC.Common.GetQueryStringByName('LevelID');

        return false;
    });
});