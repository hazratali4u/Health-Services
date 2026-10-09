var RC = RC || {};

RC.ManageSchemeDocument = {
    HandlerURL: RC.Common.RootURL + "Handler/SchemeDocumentHandler.ashx",
    SchemeDocumentFilesToDelete: [],
    SchemeDocumentObject: null,
    InitializePage: function () {
        $('#dvManageSchemeDocument #fuFile').fineUploader({
            template: 'qq-template-manual-trigger',
            request: {
                endpoint: RC.ManageSchemeDocument.HandlerURL + "?method=UploadSchemeDocumentFile"
            },
            thumbnails: {
                placeholders: {
                    waitingPath: RC.Common.RootURL + '/css/fine-uploader/placeholders/waiting-generic.png',
                    notAvailablePath: RC.Common.RootURL + '/css/fine-uploader/placeholders/not_available-generic.png'
                }
            },
            validation: {
                sizeLimit: 5242880 // 5120 kB = 5120 * 1024 bytes
            },
            autoUpload: false,
            callbacks: {
                onAllComplete: function (succeeded, failed) {
                    if (failed.length <= 0) {
                        RC.ManageSchemeDocument.AddUpdateSchemeDocument();
                    }
                    else if (failed.length > 0) {
                        $('#dvManageSchemeDocument #btnSave').removeClass("disabled").text('Save');
                    }
                }
            }
        });

        if (RC.ManageSchemeDocument.SchemeDocumentObject != null) {
            //ddlCTScheme.SetValue(RC.ManageSchemeDocument.SchemeDocumentObject.SchemeId);
            $("#dvManageSchemeDocument #txtDocumentDate").val(RC.ManageSchemeDocument.SchemeDocumentObject.DocDateString);
            $("#dvManageSchemeDocument #txtTitle").val(RC.ManageSchemeDocument.SchemeDocumentObject.Title);
            $("#dvManageSchemeDocument #txtReferenceNo").val(RC.ManageSchemeDocument.SchemeDocumentObject.ReferenceNo);
            $("#dvManageSchemeDocument #txtVersion").val(RC.ManageSchemeDocument.SchemeDocumentObject.Version);
            $("#dvManageSchemeDocument #txtRemarks").val(RC.ManageSchemeDocument.SchemeDocumentObject.Remarks);

            if (RC.ManageSchemeDocument.SchemeDocumentObject.SchemeDocumentFileList != null && RC.ManageSchemeDocument.SchemeDocumentObject.SchemeDocumentFileList != undefined && RC.ManageSchemeDocument.SchemeDocumentObject.SchemeDocumentFileList.length > 0) {
                $('#dvManageSchemeDocument #tblSchemeDocumentFileList').show();
                $('#dvManageSchemeDocument #tblSchemeDocumentFileList').DataTable({
                    "data": RC.ManageSchemeDocument.SchemeDocumentObject.SchemeDocumentFileList,
                    "columns": [
                        {
                            data: null,
                            render: function (row, type, val, meta) {
                                return "<input type='hidden' value='" + row.Id + "'></input><a style='text-decoration: underline;' target='_blank' href='" + RC.Common.RootURL + "UploadedFile/DocumentFile/" + row.Title + "'>" + row.Title + "</a>";
                            },
                            defaultContent: ""
                        },
                        {
                            data: null,
                            className: "center",
                            render: function (row, type, val, meta) {
                                return "<center><a href='javascript:void(0)' onclick='RC.ManageSchemeDocument.DeleteSchemeDocumentFile(" + row.Id + ", \"" + row.Title + "\")'>" +
                                    "<i class='fa fa-trash-o' aria-hidden='true'></i></a></center>";
                            },
                            orderable: false,
                            defaultContent: ""
                        }
                    ]
                });
            }
        }

        tinymce.init({
            selector: "#dvManageSchemeDocument textarea",
            height: 200,
            relative_urls: false,
            remove_script_host: false,
            convert_urls: true,
            toolbar: 'undo redo | bold italic | alignleft aligncenter alignright alignjustify | outdent indent',
            content_css: RC.Common.RootURL + 'css/tinymce.css'
        });
    },
    ValidateSchemeDocument: function () {
        var status = true;

        if (ddlCTScheme.GetSelectedItem() == null) {
            alert("Please provide scheme.");

            status = false;
        }
        else if ($.trim($("#dvManageSchemeDocument #txtDocumentDate").val()) == "") {
            alert("Please provide date.");

            status = false;
        }

        return status;
    },
    PopulateSchemeDocument: function () {
        var status = RC.ManageSchemeDocument.ValidateSchemeDocument();

        if (status) {
            var id = 0;

            if (RC.ManageSchemeDocument.SchemeDocumentObject != null) {
                id = RC.ManageSchemeDocument.SchemeDocumentObject.Id;
            }

            RC.ManageSchemeDocument.SchemeDocumentObject = { Id: 0, SchemeId: 0, Title: '', DocDate: '', ReferenceNo: '', Version: '', Remarks: '', SchemeDocumentFileList: [] };
            RC.ManageSchemeDocument.SchemeDocumentObject.Id = id;
            RC.ManageSchemeDocument.SchemeDocumentObject.SchemeId = ddlCTScheme.GetSelectedItem().value;
            RC.ManageSchemeDocument.SchemeDocumentObject.Title = $("#dvManageSchemeDocument #txtTitle").val();
            RC.ManageSchemeDocument.SchemeDocumentObject.DocDate = $("#dvManageSchemeDocument #txtDocumentDate").val();
            RC.ManageSchemeDocument.SchemeDocumentObject.ReferenceNo = $("#dvManageSchemeDocument #txtReferenceNo").val();
            RC.ManageSchemeDocument.SchemeDocumentObject.Version = $("#dvManageSchemeDocument #txtVersion").val();
            RC.ManageSchemeDocument.SchemeDocumentObject.Remarks = tinymce.get($("#dvManageSchemeDocument #txtRemarks").attr("id")).getContent();

            $("#dvManageSchemeDocument #tblSchemeDocumentFileList input[type='hidden']").each(function (index, item) {
                var objSchemeDocumentFile = {
                    Id: $(item).val(),
                    Title: $(item).next().text()
                };

                RC.ManageSchemeDocument.SchemeDocumentObject.SchemeDocumentFileList.push(objSchemeDocumentFile);
            });
        }

        return status;
    },
    DeleteSchemeDocumentFile: function (id, Title) {
        var objSchemeDocumentFile = {
            Id: id,
            Title: Title
        };

        RC.ManageSchemeDocument.SchemeDocumentFilesToDelete.push(objSchemeDocumentFile);

        var catIindex = $.map(RC.ManageSchemeDocument.SchemeDocumentObject.SchemeDocumentFileList, function (obj, index) { if (obj.Id == id) { return index; } });

        RC.ManageSchemeDocument.SchemeDocumentObject.SchemeDocumentFileList.splice(catIindex, 1);

        $('#dvManageSchemeDocument #tblSchemeDocumentFileList').dataTable().fnClearTable();

        if (RC.ManageSchemeDocument.SchemeDocumentObject.SchemeDocumentFileList != null && RC.ManageSchemeDocument.SchemeDocumentObject.SchemeDocumentFileList != undefined && RC.ManageSchemeDocument.SchemeDocumentObject.SchemeDocumentFileList.length > 0) {
            $('#dvManageSchemeDocument #tblSchemeDocumentFileList').dataTable().fnAddData(RC.ManageSchemeDocument.SchemeDocumentObject.SchemeDocumentFileList);
            $('#dvManageSchemeDocument #tblSchemeDocumentFileList').dataTable().fnDraw();
        }
    },
    SaveSchemeDocument: function () {
        if (RC.ManageSchemeDocument.PopulateSchemeDocument()) {
            $('#dvManageSchemeDocument #btnSave').addClass("disabled").val('Wait...');

            var fuFileCount = $.grep($('#dvManageSchemeDocument #fuFile').fineUploader('getUploads'), function (n, i) { return n.status === 'submitted'; }).length;

            if (fuFileCount > 0) {
                $('#dvManageSchemeDocument #fuFile').fineUploader('uploadStoredFiles');
            }
            else {
                RC.ManageSchemeDocument.AddUpdateSchemeDocument();
            }
        }
    },
    AddUpdateSchemeDocument: function () {
        var handlerMethod = 'SchemeDocumentAdd';

        if (RC.ManageSchemeDocument.SchemeDocumentObject.Id > 0) {
            handlerMethod = 'SchemeDocumentUpdate';
        }

        $.post(RC.ManageSchemeDocument.HandlerURL,
        {
            method: handlerMethod,
            objSchemeDocument: JSON.stringify(RC.ManageSchemeDocument.SchemeDocumentObject),
            SchemeDocumentFilesToDelete: JSON.stringify(RC.ManageSchemeDocument.SchemeDocumentFilesToDelete)
        },
        function (response) {
            switch (response.Status) {
                case RC.Common.ResponseStatus.SUCCESS:
                    alert(response.Message);

                    $('#dvManageSchemeDocument #btnSave').val('Its done.');

                    window.location = RC.Common.RootURL + "Forms/frmSchemeDocuments.aspx";

                    break;
                case RC.Common.ResponseStatus.ERROR:
                    alert(response.Message);

                    $('#dvManageSchemeDocument #btnSave').removeClass("disabled").val('Save');

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

$(document).ready(function () {
    RC.ManageSchemeDocument.InitializePage();
});