var RC = RC || {};

RC.SchemeDocumentListing = {
    HandlerURL: RC.Common.RootURL + "Handler/SchemeDocumentHandler.ashx",
    SchemeDocumentList: [],
    SchemeDocumentListTable: null,
    InitializePage: function () {
        if (RC.SchemeDocumentListing.SchemeDocumentList != null && RC.SchemeDocumentListing.SchemeDocumentList != undefined && RC.SchemeDocumentListing.SchemeDocumentList.length > 0) {
            $('#dvSchemeDocumentListing #tblSchemeDocumentList').DataTable({
                "data": RC.SchemeDocumentListing.SchemeDocumentList,
                "columns": [
                    { "data": "SchemeTitle" },
                    { "data": "Title" },
                    { "data": "Version" },
                    {
                        data: "DocDateString",
                        className: "center",
                        orderable: false
                    },
                    {
                        data: null,
                        className: "center",
                        render: function (row, type, val, meta) {
                            return "<center><a title='Edit' href='" + RC.Common.RootURL + "Forms/frmSchemeDocumentAdd.aspx?LevelType=3&LevelID=248&Id=" + row.Id + "'>" +
                                "<i class='fa fa-pencil' aria-hidden='true'></i></a>&nbsp;" +
                                "<a title='Delete' href='javascript:void(0)' onclick='RC.SchemeDocumentListing.DocumentDelete(" + row.Id + ")'>" +
                                "<i class='fa fa-trash-o' aria-hidden='true'></i></a></center>";
                        },
                        orderable: false,
                        defaultContent: ""
                    }
                ],
                aaSorting: [[1, 'asc']]
            });
        }
    },
    DocumentDelete: function (DocumentId) {
        var r = confirm('Do you want to proceed?');

        if (r == true) {
            $.post(RC.SchemeDocumentListing.HandlerURL,
                {
                    method: 'DocumentDelete',
                    DocumentId: DocumentId
                },
                function (response) {
                    switch (response.Status) {
                        case RC.Common.ResponseStatus.SUCCESS:
                            var prodIindex = $.map(RC.SchemeDocumentListing.SchemeDocumentList, function (obj, index) {
                                if (obj.Id == DocumentId) {
                                    return index;
                                }
                            });

                            RC.SchemeDocumentListing.SchemeDocumentList.splice(prodIindex, 1);

                            alert(response.Message);

                            $('#dvSchemeDocumentListing #tblSchemeDocumentList').dataTable().fnClearTable();

                            if (RC.SchemeDocumentListing.SchemeDocumentList != null && RC.SchemeDocumentListing.SchemeDocumentList != undefined && RC.SchemeDocumentListing.SchemeDocumentList.length > 0) {
                                $('#dvSchemeDocumentListing #tblSchemeDocumentList').dataTable().fnAddData(RC.SchemeDocumentListing.SchemeDocumentList);
                                $('#dvSchemeDocumentListing #tblSchemeDocumentList').dataTable().fnDraw();
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
    RC.SchemeDocumentListing.InitializePage();
});