var RC = RC || {};

RC.ManageSchemeStage = {
    HandlerURL: RC.Common.RootURL + "Handler/SchemeStageHandler.ashx",
    SchemeStageObject: null,
    InitializePage: function () {
        tinymce.init({
            selector: "#dvManageSchemeStage textarea",
            height: 200,
            relative_urls: false,
            remove_script_host: false,
            convert_urls: true,
            toolbar: 'undo redo | bold italic | alignleft aligncenter alignright alignjustify | outdent indent',
            content_css: RC.Common.RootURL + 'css/tinymce.css'
        });
    },
    ValidateSchemeStage: function () {
        var status = true;

        if (ddlCTScheme.GetSelectedItem() == null) {
            alert("Please provide scheme.");

            status = false;
        }
        else if ($.trim($("#dvManageSchemeStage #txtStageDate").val()) == "") {
            alert("Please provide date.");

            status = false;
        }

        return status;
    },
    PopulateSchemeStage: function () {
        var status = RC.ManageSchemeStage.ValidateSchemeStage();

        if (status) {
            RC.ManageSchemeStage.SchemeStageObject = { Id: 0, SchemeId: 0, StgDate: '', StageStatusId: 0, ReferenceNo: '', Remarks: '' };
            RC.ManageSchemeStage.SchemeStageObject.SchemeId = ddlCTScheme.GetSelectedItem().value;
            RC.ManageSchemeStage.SchemeStageObject.StgDate = $("#dvManageSchemeStage #txtStageDate").val();
            RC.ManageSchemeStage.SchemeStageObject.StageStatusId = ddlCTStageStatus.GetSelectedItem().value;
            RC.ManageSchemeStage.SchemeStageObject.ReferenceNo = $("#dvManageSchemeStage #txtReferenceNo").val();
            RC.ManageSchemeStage.SchemeStageObject.Remarks = tinymce.get($("#dvManageSchemeStage #txtRemarks").attr("id")).getContent();
        }

        return status;
    },
    SaveSchemeStage: function () {
        if (RC.ManageSchemeStage.PopulateSchemeStage()) {
            $('#dvManageSchemeStage #btnSave').addClass("disabled").val('Wait...');

            RC.ManageSchemeStage.AddUpdateSchemeStage();
        }
    },
    AddUpdateSchemeStage: function () {
        var handlerMethod = 'SchemeStageAdd';

        $.post(RC.ManageSchemeStage.HandlerURL,
        {
            method: handlerMethod,
            objSchemeStage: JSON.stringify(RC.ManageSchemeStage.SchemeStageObject)
        },
        function (response) {
            switch (response.Status) {
                case RC.Common.ResponseStatus.SUCCESS:
                    alert(response.Message);
                    $('#dvManageSchemeStage #btnSave').val('Its done.');

                    window.location = RC.Common.RootURL + "Forms/frmSchemeStages.aspx?LevelType=3&LevelID=234";

                    break;
                case RC.Common.ResponseStatus.ERROR:
                    alert(response.Message);

                    $('#dvManageSchemeStage #btnSave').removeClass("disabled").val('Save');

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
    RC.ManageSchemeStage.InitializePage();
});