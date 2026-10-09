var RC = RC || {};

RC.GroupListing = {
    HandlerURL: RC.Common.RootURL + "Handler/GroupHandler.ashx",
    GroupList: [],
    GroupListTable: null,
    InitializePage: function () {
        if (RC.GroupListing.GroupList != null && RC.GroupListing.GroupList != undefined && RC.GroupListing.GroupList.length > 0) {
            $('#dvGroupListing #tblGroupList').DataTable({
                "data": RC.GroupListing.GroupList,
                "columns": [
                    { "data": "Title" },
                    { "data": "ShortTitle" },
                    {
                        data: null,
                        className: "center",
                        render: function (row, type, val, meta) {
                            return "<center><a title='Edit' href='" + RC.Common.RootURL + "Forms/frmGroupAdd.aspx?LevelType=" +
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
    RC.GroupListing.InitializePage();

    $('#dvGroupListing #btnAdd').on('click', function () {
        window.location = RC.Common.RootURL + "Forms/frmGroupAdd.aspx?LevelType=" + RC.Common.GetQueryStringByName('LevelType') + "&LevelID=" + RC.Common.GetQueryStringByName('LevelID');

        return false;
    });
});