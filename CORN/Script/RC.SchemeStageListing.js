var RC = RC || {};

RC.SchemeStageListing = {
    HandlerURL: RC.Common.RootURL + "Handler/CategoryHandler.ashx",
    SchemeStageList: [],
    SchemeStageListTable: null,
    InitializePage: function () {
        if (RC.SchemeStageListing.SchemeStageList != null && RC.SchemeStageListing.SchemeStageList != undefined && RC.SchemeStageListing.SchemeStageList.length > 0) {
            $('#dvSchemeStageListing #tblSchemeStageList').DataTable({
                "data": RC.SchemeStageListing.SchemeStageList,
                "columns": [
                    {
                        data: "SchemeTitle"
                    },
                    {
                        data: "SchemeStageStatusTitle"
                    },
                    {
                        data: "ReferenceNo"
                    },
                    {
                        data: "StgDateString",
                        className: "center",
                        orderable: false
                    }
                ],
                aaSorting: [[1, 'asc']]
            });
        }
    }
}

$(document).ready(function () {
    RC.SchemeStageListing.InitializePage();
});