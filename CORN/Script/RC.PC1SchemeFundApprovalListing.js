var RC = RC || {};

RC.SchemeFundApprovalListing = {
    HandlerURL: RC.Common.RootURL + "Handler/PC1SchemeFundApprovalHandler.ashx",
    SchemeFundApprovalList: [],
    SchemeFundApprovalListTable: null,
    InitializePage: function () {
        if (RC.SchemeFundApprovalListing.SchemeFundApprovalList != null && RC.SchemeFundApprovalListing.SchemeFundApprovalList != undefined && RC.SchemeFundApprovalListing.SchemeFundApprovalList.length > 0) {
            $('#dvSchemeFundApprovalListing #tblSchemeFundApprovalList').DataTable({
                "data": RC.SchemeFundApprovalListing.SchemeFundApprovalList,
                "columns": [
                    { "data": "SchemeTitle" },
                    { "data": "ReferenceNo" },
                    {
                        data: "StatusTitle",
                        className: "center"
                    },
                    {
                        data: "StDateString",
                        className: "center",
                        orderable: false
                    },
                    {
                        data: null,
                        className: "center",
                        render: function (row, type, val, meta) {
                            return "<center><a title='Edit' href='" + RC.Common.RootURL + "Forms/frmPC1SchemeFundApprovalAdd.aspx?LevelType=3&LevelID=276&Id=" + row.Id + "'>" +
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
    RC.SchemeFundApprovalListing.InitializePage();
});