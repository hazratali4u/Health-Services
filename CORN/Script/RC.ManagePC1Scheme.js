var RC = RC || {};

RC.ManageScheme = {
    HandlerURL: RC.Common.RootURL + "Handler/PC1SchemeHandler.ashx",
    SchemeObject: null,
    TempSchemeObject: null,
    DistributorList: [],
    GroupList: [],
    FinancialYearList: [],
    CapitalCostEstimateList: [],
    AnnualOperatingCostList: [],
    SchemeFilesToDelete: [],
    SchemeFileTableInitialized: false,
    WizardStep: 1,
    Latitude: 31.582045,
    Longitude: 74.329376,
    CCEId: 0,
    AOCId: 0,
    InitializePage: function () {
        tinymce.init({
            selector: "#dvManageScheme textarea",
            height: 200,
            relative_urls: false,
            remove_script_host: false,
            convert_urls: true,
            toolbar: 'undo redo | bold italic | alignleft aligncenter alignright alignjustify | outdent indent',
            content_css: RC.Common.RootURL + 'css/tinymce.css'
        });

        RC.ManageScheme.InitFineUploader();
        RC.ManageScheme.SetCurrentStep(1);
        RC.ManageScheme.PopulateForInstitute();
    },
    InitFineUploader: function () {
        $('#dvManageScheme #fuFile').empty();
        $('#dvManageScheme #fuFile').fineUploader({
            template: 'qq-template-manual-trigger',
            request: {
                endpoint: RC.ManageScheme.HandlerURL + "?method=UploadSchemeFile"
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
                        RC.ManageScheme.UpdateScheme();
                    }
                    else if (failed.length > 0) {
                        $('#dvManageScheme #btnSave').removeClass("disabled").text('Save');
                    }
                }
            }
        });
    },
    SetCurrentStep: function (stepId) {
        var contentStepId = ".step" + stepId;

        $("#dvManageScheme .content").hide();
        $("#dvManageScheme #lblStep").empty();
        $("#dvManageScheme #lblStep").html("<span class='fa fa-caret-right rgt_cart'></span>");
        $(contentStepId, "#dvManageScheme").show();

        RC.ManageScheme.WizardStep = stepId;

        switch (stepId) {
            case 1:
                $("#dvManageScheme #lblStep").append(RC.Common.PC1SchemeWizardHeading.Step1);
                $("#dvManageScheme #txtSchemeName").val(RC.ManageScheme.SchemeObject.strSchemeName);
                $("#dvManageScheme #txtSchemeDate").val(RC.ManageScheme.SchemeObject.dtmSchemeDateString);
                $("#dvManageScheme #txtStartDate").val(RC.ManageScheme.SchemeObject.dtmStartDateString);
                $("#dvManageScheme #txtEndDate").val(RC.ManageScheme.SchemeObject.dtmEndDateString);
                $("#dvManageScheme #txtRemarks").val(RC.ManageScheme.SchemeObject.strRemarks);
                $("#dvManageScheme #txtPreparedBy").val(RC.ManageScheme.SchemeObject.strPreparedBy);
                $("#dvManageScheme #txtCheckedBy").val(RC.ManageScheme.SchemeObject.strCheckedBy);
                $("#dvManageScheme #txtApprovedBy").val(RC.ManageScheme.SchemeObject.strApprovedBy);

                break;
            case 2:
                $("#dvManageScheme #lblStep").append(RC.Common.PC1SchemeWizardHeading.Step2);
                $("#dvManageScheme #txtLatitude").val(RC.ManageScheme.SchemeObject.latitude);
                $("#dvManageScheme #txtLongitude").val(RC.ManageScheme.SchemeObject.longitude);
                RC.ManageScheme.LoadMapLocation(RC.ManageScheme.SchemeObject.latitude, RC.ManageScheme.SchemeObject.longitude);

                break;
            case 3:
                $("#dvManageScheme #lblStep").append(RC.Common.PC1SchemeWizardHeading.Step3);
                ddlCTSponsoring.SetValue(RC.ManageScheme.SchemeObject.sponsoringId);
                ddlCTExecution.SetValue(RC.ManageScheme.SchemeObject.executionId);
                ddlCTOperationMaintenance.SetValue(RC.ManageScheme.SchemeObject.operationMaintenanceId);
                ddlCTConcernedFederalMinistry.SetValue(RC.ManageScheme.SchemeObject.concernedFederalMinistryId);

                break;
            case 4:
                $("#dvManageScheme #lblStep").append(RC.Common.PC1SchemeWizardHeading.Step4);
                tinymce.get($("#dvManageScheme #txtStep4Detail").attr("id")).setContent(RC.ManageScheme.SchemeObject.step4Detail);

                break;
            case 5:
                $("#dvManageScheme #lblStep").append(RC.Common.PC1SchemeWizardHeading.Step5);
                tinymce.get($("#dvManageScheme #txtStep5Detail").attr("id")).setContent(RC.ManageScheme.SchemeObject.step5Detail);

                break;
            case 6:
                $("#dvManageScheme #lblStep").append(RC.Common.PC1SchemeWizardHeading.Step6);
                tinymce.get($("#dvManageScheme #txtStep6Detail").attr("id")).setContent(RC.ManageScheme.SchemeObject.step6Detail);

                break;
            case 7:
                $("#dvManageScheme #lblStep").append(RC.Common.PC1SchemeWizardHeading.Step7);
                $("#dvManageScheme #dvCapitalCostEstimate").empty();

                for (var i = 0; i < RC.ManageScheme.SchemeObject.SchemeCapitalCostEstimateList.length; i++) {
                    RC.ManageScheme.AddCapitalCostEstimate(RC.ManageScheme.SchemeObject.SchemeCapitalCostEstimateList[i]);
                }

                break;
            case 8:
                $("#dvManageScheme #lblStep").append(RC.Common.PC1SchemeWizardHeading.Step8);
                $("#dvManageScheme #dvAnnualOperatingCost").empty();

                for (var i = 0; i < RC.ManageScheme.SchemeObject.SchemeAnnualOperatingCostList.length; i++) {
                    RC.ManageScheme.AddAnnualOperatingCost(RC.ManageScheme.SchemeObject.SchemeAnnualOperatingCostList[i]);
                }

                break;
            case 9:
                $("#dvManageScheme #lblStep").append(RC.Common.PC1SchemeWizardHeading.Step9);
                tinymce.get($("#dvManageScheme #txtStep9Detail").attr("id")).setContent(RC.ManageScheme.SchemeObject.step9Detail);

                break;
            case 10:
                $("#dvManageScheme #lblStep").append(RC.Common.PC1SchemeWizardHeading.Step10);
                tinymce.get($("#dvManageScheme #txtStep10Detail").attr("id")).setContent(RC.ManageScheme.SchemeObject.step10Detail);

                break;
            case 11:
                $("#dvManageScheme #lblStep").append(RC.Common.PC1SchemeWizardHeading.Step11);
                tinymce.get($("#dvManageScheme #txtStep11Detail").attr("id")).setContent(RC.ManageScheme.SchemeObject.step11Detail);
                tinymce.get($("#dvManageScheme #txtStep11Detail2").attr("id")).setContent(RC.ManageScheme.SchemeObject.step11Detail2);
                tinymce.get($("#dvManageScheme #txtStep11Detail3").attr("id")).setContent(RC.ManageScheme.SchemeObject.step11Detail3);
                tinymce.get($("#dvManageScheme #txtStep11Detail4").attr("id")).setContent(RC.ManageScheme.SchemeObject.step11Detail4);
                tinymce.get($("#dvManageScheme #txtStep11Detail5").attr("id")).setContent(RC.ManageScheme.SchemeObject.step11Detail5);

                break;
            case 12:
                $("#dvManageScheme #lblStep").append(RC.Common.PC1SchemeWizardHeading.Step12);
                tinymce.get($("#dvManageScheme #txtStep12Detail").attr("id")).setContent(RC.ManageScheme.SchemeObject.step12Detail);
                tinymce.get($("#dvManageScheme #txtStep12Detail2").attr("id")).setContent(RC.ManageScheme.SchemeObject.step12Detail2);

                break;
            case 13:
                $("#dvManageScheme #lblStep").append(RC.Common.PC1SchemeWizardHeading.Step13);
                tinymce.get($("#dvManageScheme #txtStep13Detail").attr("id")).setContent(RC.ManageScheme.SchemeObject.step13Detail);

                break;
            case 14:
                $("#dvManageScheme #lblStep").append(RC.Common.PC1SchemeWizardHeading.Step14);
                tinymce.get($("#dvManageScheme #txtStep14Detail").attr("id")).setContent(RC.ManageScheme.SchemeObject.step14Detail);

                break;
            case 15:
                $("#dvManageScheme #lblStep").append(RC.Common.PC1SchemeWizardHeading.Step15);
                tinymce.get($("#dvManageScheme #txtStep15Detail").attr("id")).setContent(RC.ManageScheme.SchemeObject.step15Detail);

                break;
            case 16:
                $("#dvManageScheme #lblStep").append(RC.Common.PC1SchemeWizardHeading.Step16);

                if (!RC.ManageScheme.SchemeFileTableInitialized &&
                    RC.ManageScheme.SchemeObject.SchemeFileList != null &&
                    RC.ManageScheme.SchemeObject.SchemeFileList != undefined) {
                    RC.ManageScheme.SchemeFileTableInitialized = true;

                    $('#dvManageScheme #tblSchemeFileList').DataTable({
                        "data": RC.ManageScheme.SchemeObject.SchemeFileList,
                        "columns": [
                                {
                                    data: null,
                                    render: function (row, type, val, meta) {
                                        return "<input type='hidden' value='" + row.Id + "'></input><a style='text-decoration: underline;' target='_blank' href='" + RC.Common.RootURL + "UploadedFile/PC1SchemeFile/" + row.Title + "'>" + row.Title + "</a>";
                                    },
                                    defaultContent: ""
                                },
                                {
                                    data: null,
                                    className: "center",
                                    render: function (row, type, val, meta) {
                                        return "<center><a href='javascript:void(0)' onclick='RC.ManageScheme.DeleteSchemeFile(" + row.Id + ", \"" + row.Title + "\")'>" +
                                            "<i class='fa fa-trash-o' aria-hidden='true'></i></a></center>";
                                    },
                                    orderable: false,
                                    defaultContent: ""
                                }
                        ]
                    });
                }

                break;
            default:
                $("#dvManageScheme #lblStep").append("Step");

                break;
        }
    },
    ValidateScheme: function () {
        var status = true;

        switch (RC.ManageScheme.WizardStep) {
            case 1:
                if ($.trim($("#dvManageScheme #txtSchemeName").val()) == "") {
                    alert("Please provide scheme name.");

                    status = false;
                }
                else if (ddlInstitute.GetSelectedItem().value == 0) {
                    alert("Please provide spending unit.");

                    status = false;
                }
                else if (ddlCOA.GetSelectedItem().value == 0 && ddlRCOA.GetSelectedItem().value == 0) {
                    alert("Please provide at least functional classification(capital) or functional classification(revenue).");

                    status = false;
                }
                else if (ddlSubSector.GetSelectedItem().value == 0) {
                    alert("Please provide sub sector.");

                    status = false;
                }
                else if ($.trim($("#dvManageScheme #txtSchemeDate").val()) == "") {
                    alert("Please provide scheme date.");

                    status = false;
                }
                else if ($.trim($("#dvManageScheme #txtStartDate").val()) == "") {
                    alert("Please provide start date.");

                    status = false;
                }
                else if ($.trim($("#dvManageScheme #txtEndDate").val()) == "") {
                    alert("Please provide end date.");

                    status = false;
                }

                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
            case 5:
                break;
            case 6:
                break;
            case 7:
                break;
            case 8:
                break;
            case 9:
                break;
            case 10:
                break;
            case 11:
                break;
            case 12:
                break;
            case 13:
                break;
            case 14:
                break;
            case 15:
                break;
            case 16:
                break;
            default:
                break;
        }

        return status;
    },
    PopulateScheme: function () {
        var status = RC.ManageScheme.ValidateScheme();

        if (status) {
            RC.ManageScheme.TempSchemeObject = {};
            RC.ManageScheme.TempSchemeObject.lngSchemeCode = RC.ManageScheme.SchemeObject.lngSchemeCode;

            switch (RC.ManageScheme.WizardStep) {
                case 1:
                    RC.ManageScheme.TempSchemeObject.strSchemeName = $.trim($("#dvManageScheme #txtSchemeName").val());
                    RC.ManageScheme.TempSchemeObject.intInstituteID = ddlInstitute.GetSelectedItem().value;
                    RC.ManageScheme.TempSchemeObject.intSubSectorID = ddlSubSector.GetSelectedItem().value;
                    RC.ManageScheme.TempSchemeObject.intCategoryID = ddlCategory.GetSelectedItem().value;
                    RC.ManageScheme.TempSchemeObject.intFCAccountHeadID = ddlCOA.GetSelectedItem().value;
                    RC.ManageScheme.TempSchemeObject.intRFCAccountHeadID = ddlRCOA.GetSelectedItem().value;
                    RC.ManageScheme.TempSchemeObject.strRemarks = tinymce.get($("#dvManageScheme #txtRemarks").attr("id")).getContent();
                    RC.ManageScheme.TempSchemeObject.dtmSchemeDate = $.trim($("#dvManageScheme #txtSchemeDate").val());
                    RC.ManageScheme.TempSchemeObject.dtmStartDate = $.trim($("#dvManageScheme #txtStartDate").val());
                    RC.ManageScheme.TempSchemeObject.dtmEndDate = $.trim($("#dvManageScheme #txtEndDate").val());
                    RC.ManageScheme.TempSchemeObject.dtmSchemeDateString = RC.ManageScheme.TempSchemeObject.dtmSchemeDate;
                    RC.ManageScheme.TempSchemeObject.dtmStartDateString = RC.ManageScheme.TempSchemeObject.dtmStartDate;
                    RC.ManageScheme.TempSchemeObject.dtmEndDateString = RC.ManageScheme.TempSchemeObject.dtmEndDate;
                    RC.ManageScheme.TempSchemeObject.strPreparedBy = $.trim($("#dvManageScheme #txtPreparedBy").val());
                    RC.ManageScheme.TempSchemeObject.strCheckedBy = $.trim($("#dvManageScheme #txtCheckedBy").val());
                    RC.ManageScheme.TempSchemeObject.strApprovedBy = $.trim($("#dvManageScheme #txtApprovedBy").val());

                    break;
                case 2:
                    RC.ManageScheme.TempSchemeObject.latitude = parseFloat($.trim($("#dvManageScheme #txtLatitude").val()));
                    RC.ManageScheme.TempSchemeObject.longitude = parseFloat($.trim($("#dvManageScheme #txtLongitude").val()));

                    break;
                case 3:
                    RC.ManageScheme.TempSchemeObject.sponsoringId = ddlCTSponsoring.GetSelectedItem().value;
                    RC.ManageScheme.TempSchemeObject.executionId = ddlCTExecution.GetSelectedItem().value;
                    RC.ManageScheme.TempSchemeObject.operationMaintenanceId = ddlCTOperationMaintenance.GetSelectedItem().value;
                    RC.ManageScheme.TempSchemeObject.concernedFederalMinistryId = ddlCTConcernedFederalMinistry.GetSelectedItem().value;

                    break;
                case 4:
                    RC.ManageScheme.TempSchemeObject.step4Detail = tinymce.get($("#dvManageScheme #txtStep4Detail").attr("id")).getContent();

                    break;
                case 5:
                    RC.ManageScheme.TempSchemeObject.step5Detail = tinymce.get($("#dvManageScheme #txtStep5Detail").attr("id")).getContent();

                    break;
                case 6:
                    RC.ManageScheme.TempSchemeObject.step6Detail = tinymce.get($("#dvManageScheme #txtStep6Detail").attr("id")).getContent();

                    break;
                case 7:
                    RC.ManageScheme.TempSchemeObject.SchemeCapitalCostEstimateList = [];

                    $("#dvCapitalCostEstimate > div", "#dvManageScheme").each(function (index) {
                        var objSchemeCapitalCostEstimate = {};

                        objSchemeCapitalCostEstimate.Title = $.trim($("#txtCCETitle", $(this)).val());
                        objSchemeCapitalCostEstimate.GroupId = parseInt($("#ddlCCEGroup", $(this)).val());
                        objSchemeCapitalCostEstimate.SchemeCapitalCostEstimateDetailList = $(this).data("dataitem");

                        RC.ManageScheme.TempSchemeObject.SchemeCapitalCostEstimateList.push(objSchemeCapitalCostEstimate);
                    });

                    break;
                case 8:
                    RC.ManageScheme.TempSchemeObject.SchemeAnnualOperatingCostList = [];

                    $("#dvAnnualOperatingCost > div", "#dvManageScheme").each(function (index) {
                        var objSchemeAnnualOperatingCost = {};

                        objSchemeAnnualOperatingCost.Title = $.trim($("#txtAOCTitle", $(this)).val());
                        objSchemeAnnualOperatingCost.GroupId = parseInt($("#ddlAOCGroup", $(this)).val());
                        objSchemeAnnualOperatingCost.SchemeAnnualOperatingCostDetailList = $(this).data("dataitem");

                        RC.ManageScheme.TempSchemeObject.SchemeAnnualOperatingCostList.push(objSchemeAnnualOperatingCost);
                    });

                    break;
                case 9:
                    RC.ManageScheme.TempSchemeObject.step9Detail = tinymce.get($("#dvManageScheme #txtStep9Detail").attr("id")).getContent();

                    break;
                case 10:
                    RC.ManageScheme.TempSchemeObject.step10Detail = tinymce.get($("#dvManageScheme #txtStep10Detail").attr("id")).getContent();

                    break;
                case 11:
                    RC.ManageScheme.TempSchemeObject.step11Detail = tinymce.get($("#dvManageScheme #txtStep11Detail").attr("id")).getContent();
                    RC.ManageScheme.TempSchemeObject.step11Detail2 = tinymce.get($("#dvManageScheme #txtStep11Detail2").attr("id")).getContent();
                    RC.ManageScheme.TempSchemeObject.step11Detail3 = tinymce.get($("#dvManageScheme #txtStep11Detail3").attr("id")).getContent();
                    RC.ManageScheme.TempSchemeObject.step11Detail4 = tinymce.get($("#dvManageScheme #txtStep11Detail4").attr("id")).getContent();
                    RC.ManageScheme.TempSchemeObject.step11Detail5 = tinymce.get($("#dvManageScheme #txtStep11Detail5").attr("id")).getContent();

                    break;
                case 12:
                    RC.ManageScheme.TempSchemeObject.step12Detail = tinymce.get($("#dvManageScheme #txtStep12Detail").attr("id")).getContent();
                    RC.ManageScheme.TempSchemeObject.step12Detail2 = tinymce.get($("#dvManageScheme #txtStep12Detail2").attr("id")).getContent();

                    break;
                case 13:
                    RC.ManageScheme.TempSchemeObject.step13Detail = tinymce.get($("#dvManageScheme #txtStep13Detail").attr("id")).getContent();

                    break;
                case 14:
                    RC.ManageScheme.TempSchemeObject.step14Detail = tinymce.get($("#dvManageScheme #txtStep14Detail").attr("id")).getContent();

                    break;
                case 15:
                    RC.ManageScheme.TempSchemeObject.step15Detail = tinymce.get($("#dvManageScheme #txtStep15Detail").attr("id")).getContent();

                    break;
                case 16:
                    RC.ManageScheme.TempSchemeObject.SchemeFileList = [];

                    $("#dvManageScheme #tblSchemeFileList input[type='hidden']").each(function (index, item) {
                        var objSchemeFile = {
                            Id: $(item).val(),
                            Title: $(item).next().text()
                        };

                        RC.ManageScheme.TempSchemeObject.SchemeFileList.push(objSchemeFile);
                    });

                    break;
                default:
                    break;
            }
        }

        return status;
    },
    SaveScheme: function () {
        if (RC.ManageScheme.PopulateScheme()) {
            $('#dvManageScheme #btnSave').addClass("disabled").val('Wait...');

            if (RC.ManageScheme.WizardStep == 16) {
                var fuFileCount = $.grep($('#dvManageScheme #fuFile').fineUploader('getUploads'), function (n, i) { return n.status === 'submitted'; }).length;

                if (fuFileCount > 0) {
                    $('#dvManageScheme #fuFile').fineUploader('uploadStoredFiles');
                }
                else {
                    RC.ManageScheme.UpdateScheme();
                }
            }
            else {
                RC.ManageScheme.UpdateScheme();
            }
        }
    },
    UpdateScheme: function () {
        $.post(RC.ManageScheme.HandlerURL,
        {
            method: 'SchemeUpdate',
            objScheme: JSON.stringify(RC.ManageScheme.TempSchemeObject),
            schemeFilesToDelete: JSON.stringify(RC.ManageScheme.SchemeFilesToDelete),
            wizardStep: RC.ManageScheme.WizardStep
        },
        function (response) {
            alert(response.Message);
            $('#dvManageScheme #btnSave').removeClass("disabled").val('Save');

            switch (response.Status) {
                case RC.Common.ResponseStatus.SUCCESS:
                    RC.ManageScheme.UpdateSchemeObject(response.Data);

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
    },
    UpdateSchemeObject: function (responseData) {
        switch (RC.ManageScheme.WizardStep) {
            case 1:
                RC.ManageScheme.SchemeObject.strSchemeName = RC.ManageScheme.TempSchemeObject.strSchemeName;
                RC.ManageScheme.SchemeObject.intInstituteID = RC.ManageScheme.TempSchemeObject.intInstituteID;
                RC.ManageScheme.SchemeObject.intSubSectorID = RC.ManageScheme.TempSchemeObject.intSubSectorID;
                RC.ManageScheme.SchemeObject.intCategoryID = RC.ManageScheme.TempSchemeObject.intCategoryID;
                RC.ManageScheme.SchemeObject.intFCAccountHeadID = RC.ManageScheme.TempSchemeObject.intFCAccountHeadID;
                RC.ManageScheme.SchemeObject.intRFCAccountHeadID = RC.ManageScheme.TempSchemeObject.intRFCAccountHeadID;
                RC.ManageScheme.SchemeObject.strRemarks = RC.ManageScheme.TempSchemeObject.strRemarks;
                RC.ManageScheme.SchemeObject.dtmSchemeDateString = RC.ManageScheme.TempSchemeObject.dtmSchemeDateString;
                RC.ManageScheme.SchemeObject.dtmStartDateString = RC.ManageScheme.TempSchemeObject.dtmStartDateString;
                RC.ManageScheme.SchemeObject.dtmEndDateString = RC.ManageScheme.TempSchemeObject.dtmEndDateString;
                RC.ManageScheme.SchemeObject.strPreparedBy = RC.ManageScheme.TempSchemeObject.strPreparedBy;
                RC.ManageScheme.SchemeObject.strCheckedBy = RC.ManageScheme.TempSchemeObject.strCheckedBy;
                RC.ManageScheme.SchemeObject.strApprovedBy = RC.ManageScheme.TempSchemeObject.strApprovedBy;

                break;
            case 2:
                RC.ManageScheme.SchemeObject.latitude = RC.ManageScheme.TempSchemeObject.latitude;
                RC.ManageScheme.SchemeObject.longitude = RC.ManageScheme.TempSchemeObject.longitude;

                break;
            case 3:
                RC.ManageScheme.SchemeObject.sponsoringId = RC.ManageScheme.TempSchemeObject.sponsoringId;
                RC.ManageScheme.SchemeObject.executionId = RC.ManageScheme.TempSchemeObject.executionId;
                RC.ManageScheme.SchemeObject.operationMaintenanceId = RC.ManageScheme.TempSchemeObject.operationMaintenanceId;
                RC.ManageScheme.SchemeObject.concernedFederalMinistryId = RC.ManageScheme.TempSchemeObject.concernedFederalMinistryId;

                break;
            case 4:
                RC.ManageScheme.SchemeObject.step4Detail = RC.ManageScheme.TempSchemeObject.step4Detail;

                break;
            case 5:
                RC.ManageScheme.SchemeObject.step5Detail = RC.ManageScheme.TempSchemeObject.step5Detail;

                break;
            case 6:
                RC.ManageScheme.SchemeObject.step6Detail = RC.ManageScheme.TempSchemeObject.step6Detail;

                break;
            case 7:
                RC.ManageScheme.SchemeObject.SchemeCapitalCostEstimateList = RC.ManageScheme.TempSchemeObject.SchemeCapitalCostEstimateList;

                break;
            case 8:
                RC.ManageScheme.SchemeObject.SchemeAnnualOperatingCostList = RC.ManageScheme.TempSchemeObject.SchemeAnnualOperatingCostList;

                break;
            case 9:
                RC.ManageScheme.SchemeObject.step9Detail = RC.ManageScheme.TempSchemeObject.step9Detail;

                break;
            case 10:
                RC.ManageScheme.SchemeObject.step10Detail = RC.ManageScheme.TempSchemeObject.step10Detail;

                break;
            case 11:
                RC.ManageScheme.SchemeObject.step11Detail = RC.ManageScheme.TempSchemeObject.step11Detail;
                RC.ManageScheme.SchemeObject.step11Detail2 = RC.ManageScheme.TempSchemeObject.step11Detail2;
                RC.ManageScheme.SchemeObject.step11Detail3 = RC.ManageScheme.TempSchemeObject.step11Detail3;
                RC.ManageScheme.SchemeObject.step11Detail4 = RC.ManageScheme.TempSchemeObject.step11Detail4;
                RC.ManageScheme.SchemeObject.step11Detail5 = RC.ManageScheme.TempSchemeObject.step11Detail5;

                break;
            case 12:
                RC.ManageScheme.SchemeObject.step12Detail = RC.ManageScheme.TempSchemeObject.step12Detail;
                RC.ManageScheme.SchemeObject.step12Detail2 = RC.ManageScheme.TempSchemeObject.step12Detail2;

                break;
            case 13:
                RC.ManageScheme.SchemeObject.step13Detail = RC.ManageScheme.TempSchemeObject.step13Detail;

                break;
            case 14:
                RC.ManageScheme.SchemeObject.step14Detail = RC.ManageScheme.TempSchemeObject.step14Detail;

                break;
            case 15:
                RC.ManageScheme.SchemeObject.step15Detail = RC.ManageScheme.TempSchemeObject.step15Detail;

                break;
            case 16:
                RC.ManageScheme.SchemeObject.SchemeFileList = responseData;
                RC.ManageScheme.SchemeFilesToDelete = [];

                $("#dvManageScheme #tblSchemeFileList").dataTable().fnClearTable();

                if (RC.ManageScheme.SchemeObject.SchemeFileList != null &&
                    RC.ManageScheme.SchemeObject.SchemeFileList != undefined &&
                    RC.ManageScheme.SchemeObject.SchemeFileList.length > 0) {
                    $("#dvManageScheme #tblSchemeFileList").dataTable().fnAddData(RC.ManageScheme.SchemeObject.SchemeFileList);
                    $("#dvManageScheme #tblSchemeFileList").dataTable().fnDraw();
                }

                RC.ManageScheme.InitFineUploader();

                break;
            default:
                break;
        }
    },
    PopulateYearWiseDate: function () {
        var startdt = RC.ManageScheme.SchemeObject.dtmStartDateString.split('-');
        var enddt = RC.ManageScheme.SchemeObject.dtmEndDateString.split('-');
        var gsYearValue = parseInt(startdt[2]);
        var geYearValue = parseInt(enddt[2]);
        var gsMonthTitle = startdt[1].toString();
        var gsMonthValue = 0;
        var geMonthTitle = enddt[1].toString();
        var geMonthValue = 0;

        if (gsMonthTitle == 'Jan') gsMonthValue = 1
        else if (gsMonthTitle == 'Feb') gsMonthValue = 2
        else if (gsMonthTitle == 'Mar') gsMonthValue = 3
        else if (gsMonthTitle == 'Apr') gsMonthValue = 4
        else if (gsMonthTitle == 'May') gsMonthValue = 5
        else if (gsMonthTitle == 'Jun') gsMonthValue = 6
        else if (gsMonthTitle == 'Jul') gsMonthValue = 7
        else if (gsMonthTitle == 'Aug') gsMonthValue = 8
        else if (gsMonthTitle == 'Sep') gsMonthValue = 9
        else if (gsMonthTitle == 'Oct') gsMonthValue = 10
        else if (gsMonthTitle == 'Nov') gsMonthValue = 11
        else if (gsMonthTitle == 'Dec') gsMonthValue = 12

        if (geMonthTitle == 'Jan') geMonthValue = 1
        else if (geMonthTitle == 'Feb') geMonthValue = 2
        else if (geMonthTitle == 'Mar') geMonthValue = 3
        else if (geMonthTitle == 'Apr') geMonthValue = 4
        else if (geMonthTitle == 'May') geMonthValue = 5
        else if (geMonthTitle == 'Jun') geMonthValue = 6
        else if (geMonthTitle == 'Jul') geMonthValue = 7
        else if (geMonthTitle == 'Aug') geMonthValue = 8
        else if (geMonthTitle == 'Sep') geMonthValue = 9
        else if (geMonthTitle == 'Oct') geMonthValue = 10
        else if (geMonthTitle == 'Nov') geMonthValue = 11
        else if (geMonthTitle == 'Dec') geMonthValue = 12

        RC.ManageScheme.FinancialYearList = [];

        while (gsYearValue <= geYearValue) {
            if ((gsMonthValue <= 6 && gsYearValue <= geYearValue) ||
                (geYearValue == gsYearValue) ||
                (gsYearValue > parseInt(startdt[2]) && gsYearValue < geYearValue)) {
                var gsYearTitle = (gsYearValue - 1).toString();

                gsYearTitle += "-" + gsYearValue.toString();

                var objFinancialYear = { Id: gsYearValue, Title: gsYearTitle };

                RC.ManageScheme.FinancialYearList.push(objFinancialYear);
            }

            gsYearValue++;
        }
    },
    PopulateForInstitute: function () {
        var distributorId = parseInt(ddlInstitute.GetSelectedItem().value);

        for (var i = 0; i < RC.ManageScheme.DistributorList.length; i++) {
            var objDistributor = RC.ManageScheme.DistributorList[i];

            if (parseInt(objDistributor.DISTRIBUTOR_ID) == distributorId) {
                $('#dvManageScheme #txtDistrict').val(objDistributor.District);
                $('#dvManageScheme #txtTehsil').val(objDistributor.Tehsil);

                break;
            }
        }
    },
    LoadMapLocation: function (latitude, longitude) {
        $('#dvManageScheme #btnLoadMapLocation').addClass("disabled").val('Loading...');

        if (latitude > 0 && longitude > 0) {
            RC.ManageScheme.Latitude = parseFloat(latitude);
            RC.ManageScheme.Longitude = parseFloat(longitude);
        }

        $.getScript("https://maps.googleapis.com/maps/api/js?key=AIzaSyBsa5aRuJSZ58St5KHvxsSJccGRLvMbI10&callback=RC.ManageScheme.InitMap")
            .done(function (script, textStatus) {
                $('#dvManageScheme #btnLoadMapLocation').removeClass("disabled").val('Load Map Location');
            })
            .fail(function (jqxhr, settings, exception) {
                $('#dvManageScheme #btnLoadMapLocation').removeClass("disabled").val('Load Map Location');
            });
    },
    InitMap: function () {
        var uluru = { lat: RC.ManageScheme.Latitude, lng: RC.ManageScheme.Longitude };
        var map = new google.maps.Map(document.getElementById('dvLocationMap'), {
            zoom: 4,
            center: uluru
        });
        var marker = new google.maps.Marker({
            position: uluru,
            map: map
        });

        $("#dvManageScheme #txtLatitude").val(RC.ManageScheme.Latitude);
        $("#dvManageScheme #txtLongitude").val(RC.ManageScheme.Longitude);
    },
    AddCapitalCostEstimate: function (objSchemeCapitalCostEstimate) {
        var tmplCapitalCostEstimate = $("#dvTemplates #tmplCapitalCostEstimate").clone().removeAttr("id");
        var currentItem = tmplCapitalCostEstimate.clone();
        var id = $("#dvCapitalCostEstimate > div", "#dvManageScheme").length + 1;
        var lstSchemeCapitalCostEstimateDetail = [];

        $('#txtCCETotalPrice', currentItem)
            .attr("data-a-sign", "Rs. ")
            .autoNumeric('init');

        if (objSchemeCapitalCostEstimate != undefined) {
            $("#txtCCETitle", currentItem).val(objSchemeCapitalCostEstimate.Title);
            $("#ddlCCEGroup", currentItem).val(objSchemeCapitalCostEstimate.GroupId);
            lstSchemeCapitalCostEstimateDetail = objSchemeCapitalCostEstimate.SchemeCapitalCostEstimateDetailList;
        }

        var totalPrice = 0;

        for (var i = 0; i < lstSchemeCapitalCostEstimateDetail.length; i++) {
            var objSchemeCapitalCostEstimateDetail = lstSchemeCapitalCostEstimateDetail[i];

            totalPrice += (objSchemeCapitalCostEstimateDetail.Quantity * objSchemeCapitalCostEstimateDetail.UnitPrice);
        }

        $("#txtCCETotalPrice", currentItem).autoNumeric('set', totalPrice);
        $("#btnCCEAddDetail", currentItem).attr("onclick", "RC.ManageScheme.ShowCapitalCostEstimateDetail(" + id + "); return false;");
        $("#btnCCEDelete", currentItem).attr("onclick", "RC.ManageScheme.DeleteCapitalCostEstimate(" + id + "); return false;");
        $(currentItem).attr("cceid", id).data("dataitem", lstSchemeCapitalCostEstimateDetail);

        $("#dvManageScheme #dvCapitalCostEstimate").append(currentItem);
    },
    DeleteCapitalCostEstimate: function (cceid) {
        $("#dvCapitalCostEstimate > div[cceid=" + cceid + "]").remove();
    },
    ShowCapitalCostEstimateDetail: function (cceid) {
        $("#dvCCEDetail #dvCCEFinancialYear").empty();
        $("#tmplCapitalCostEstimateDetail #ddlCCEGroupAccountHead").empty();

        RC.ManageScheme.CCEId = cceid;

        var groupId = $("#dvCapitalCostEstimate > div[cceid=" + RC.ManageScheme.CCEId + "] #ddlCCEGroup").val();
        var objGroup = RC.ManageScheme.GroupList.filter(p => parseInt(p.Id) === parseInt(groupId));

        RC.ManageScheme.PopulateYearWiseDate();

        if (objGroup.length > 0) {
            for (var i = 0; i < objGroup[0].GroupAccountHeadList.length; i++) {
                var objGroupAccountHead = objGroup[0].GroupAccountHeadList[i];

                $("#tmplCapitalCostEstimateDetail #ddlCCEGroupAccountHead").append($("<option/>", {
                    value: objGroupAccountHead.AccountHeadId,
                    text: objGroupAccountHead.COAName
                }));
            }
        }

        for (var i = 0; i < RC.ManageScheme.FinancialYearList.length; i++) {
            var tmplFinancialYear = $("#dvTemplates #tmplFinancialYear").clone().removeAttr("id");
            var currentItem = tmplFinancialYear.clone();

            $(currentItem)
                .val(RC.ManageScheme.FinancialYearList[i].Title)
                .attr("fyid", RC.ManageScheme.FinancialYearList[i].Id);

            if (i == 0) {
                $(currentItem)
                    .removeClass("btn-default")
                    .addClass("btn-primary");

                RC.ManageScheme.LoadFYCapitalCostEstimateDetail(RC.ManageScheme.FinancialYearList[i].Id);
            }

            $("#dvCCEDetail #dvCCEFinancialYear").append(currentItem);
        }

        $("#dvCCEFinancialYear .btn").click(function () {
            RC.ManageScheme.SaveCurrentFYCapitalCostEstimateDetail();

            $("#dvCCEFinancialYear .btn")
                .removeClass('btn-default')
                .removeClass('btn-primary')
                .addClass('btn-default');

            $(this)
                .removeClass('btn-default')
                .addClass('btn-primary');

            RC.ManageScheme.LoadFYCapitalCostEstimateDetail($(this).attr("fyid"));
        });

        $('#dvTemplates #btnCCEAddDetail')[0].click();
    },
    LoadFYCapitalCostEstimateDetail: function (fyid) {
        $("#dvCCEDetail #dvCCEDetailSection").empty();

        var lstSchemeCapitalCostEstimateDetail = $("#dvCapitalCostEstimate > div[cceid=" + RC.ManageScheme.CCEId + "]").data("dataitem");

        if (lstSchemeCapitalCostEstimateDetail != undefined) {
            var lstFYSchemeCapitalCostEstimateDetail = lstSchemeCapitalCostEstimateDetail.filter(p => parseInt(p.FYId) === parseInt(fyid));

            for (var i = 0; i < lstFYSchemeCapitalCostEstimateDetail.length; i++) {
                RC.ManageScheme.AddCapitalCostEstimateDetail(lstFYSchemeCapitalCostEstimateDetail[i]);
            }
        }
    },
    AddCapitalCostEstimateDetail: function (objSchemeCapitalCostEstimateDetail) {
        var tmplCapitalCostEstimateDetail = $("#dvTemplates #tmplCapitalCostEstimateDetail").clone().removeAttr("id");
        var currentItem = tmplCapitalCostEstimateDetail.clone();
        var id = $("#dvCCEDetailSection > div", "#dvCCEDetail").length + 1;

        $('#txtCCEDUnitPrice', currentItem)
            .attr("data-a-sign", "Rs. ")
            .autoNumeric('init');
        $('#txtCCEDTotalPrice', currentItem)
            .attr("data-a-sign", "Rs. ")
            .autoNumeric('init');

        if (objSchemeCapitalCostEstimateDetail != undefined) {
            $("#txtCCEDTitle", currentItem).val(objSchemeCapitalCostEstimateDetail.Title);
            $("#txtCCEDQuantity", currentItem).val(objSchemeCapitalCostEstimateDetail.Quantity);
            $("#txtCCEDUnitPrice", currentItem).autoNumeric('set', objSchemeCapitalCostEstimateDetail.UnitPrice);
            $("#txtCCEDTotalPrice", currentItem).autoNumeric('set', objSchemeCapitalCostEstimateDetail.Quantity * objSchemeCapitalCostEstimateDetail.UnitPrice);
            $("#ddlCCEGroupAccountHead", currentItem).val(objSchemeCapitalCostEstimateDetail.AccountHeadId);
        }

        $("#btnCCEDDelete", currentItem).attr("onclick", "RC.ManageScheme.DeleteCapitalCostEstimateDetail(" + id + "); return false;");
        $(currentItem).attr("ccedid", id);

        $("#dvCCEDetail #dvCCEDetailSection").append(currentItem);

        $("#dvCCEDetail #dvCCEDetailSection input").keyup(function () {
            var quantity = parseInt($(this).parents('.row').find('#txtCCEDQuantity').val());
            var unitPrice = parseFloat($(this).parents('.row').find('#txtCCEDUnitPrice').autoNumeric('get'));

            $(this).parents('.row').find('#txtCCEDTotalPrice').autoNumeric('set', quantity * unitPrice);
        });
    },
    DeleteCapitalCostEstimateDetail: function (ccedid) {
        $("#dvCCEDetailSection > div[ccedid=" + ccedid + "]").remove();
    },
    SaveCurrentFYCapitalCostEstimateDetail: function () {
        var lstSchemeCapitalCostEstimateDetail = $("#dvCapitalCostEstimate > div[cceid=" + RC.ManageScheme.CCEId + "]").data("dataitem");
        var fyid = $("#dvCCEFinancialYear .btn-primary").attr("fyid");

        if (lstSchemeCapitalCostEstimateDetail != undefined) {
            lstSchemeCapitalCostEstimateDetail = lstSchemeCapitalCostEstimateDetail.filter(p => parseInt(p.FYId) !== parseInt(fyid));

            $("#dvCCEDetail #dvCCEDetailSection .row").each(function (index) {
                var objSchemeCapitalCostEstimateDetail = {};

                objSchemeCapitalCostEstimateDetail.FYId = parseInt(fyid);
                objSchemeCapitalCostEstimateDetail.Title = $.trim($("#txtCCEDTitle", $(this)).val());
                objSchemeCapitalCostEstimateDetail.Quantity = parseInt($("#txtCCEDQuantity", $(this)).val());
                objSchemeCapitalCostEstimateDetail.UnitPrice = parseFloat($("#txtCCEDUnitPrice", $(this)).autoNumeric('get'));
                objSchemeCapitalCostEstimateDetail.AccountHeadId = parseInt($("#ddlCCEGroupAccountHead", $(this)).val());

                lstSchemeCapitalCostEstimateDetail.push(objSchemeCapitalCostEstimateDetail);
            });

            $("#dvCapitalCostEstimate > div[cceid=" + RC.ManageScheme.CCEId + "]").data("dataitem", lstSchemeCapitalCostEstimateDetail);
        }
    },
    SaveSchemeCCEDetail: function () {
        RC.ManageScheme.SaveCurrentFYCapitalCostEstimateDetail();
        $('#dvCCEDetail #btnCCEClose')[0].click();

        var lstSchemeCapitalCostEstimateDetail = $("#dvCapitalCostEstimate > div[cceid=" + RC.ManageScheme.CCEId + "]").data("dataitem");
        var totalPrice = 0;

        for (var i = 0; i < lstSchemeCapitalCostEstimateDetail.length; i++) {
            var objSchemeCapitalCostEstimateDetail = lstSchemeCapitalCostEstimateDetail[i];

            totalPrice += (objSchemeCapitalCostEstimateDetail.Quantity * objSchemeCapitalCostEstimateDetail.UnitPrice);
        }

        $("#txtCCETotalPrice", $("#dvCapitalCostEstimate > div[cceid=" + RC.ManageScheme.CCEId + "]")).autoNumeric('set', totalPrice);
    },
    AddAnnualOperatingCost: function (objSchemeAnnualOperatingCost) {
        var tmplAnnualOperatingCost = $("#dvTemplates #tmplAnnualOperatingCost").clone().removeAttr("id");
        var currentItem = tmplAnnualOperatingCost.clone();
        var id = $("#dvAnnualOperatingCost > div", "#dvManageScheme").length + 1;
        var lstSchemeAnnualOperatingCostDetail = [];

        $('#txtAOCTotalPrice', currentItem)
            .attr("data-a-sign", "Rs. ")
            .autoNumeric('init');

        if (objSchemeAnnualOperatingCost != undefined) {
            $("#txtAOCTitle", currentItem).val(objSchemeAnnualOperatingCost.Title);
            $("#ddlAOCGroup", currentItem).val(objSchemeAnnualOperatingCost.GroupId);
            lstSchemeAnnualOperatingCostDetail = objSchemeAnnualOperatingCost.SchemeAnnualOperatingCostDetailList;
        }

        var totalPrice = 0;

        for (var i = 0; i < lstSchemeAnnualOperatingCostDetail.length; i++) {
            var objSchemeAnnualOperatingCostDetail = lstSchemeAnnualOperatingCostDetail[i];

            totalPrice += (objSchemeAnnualOperatingCostDetail.Quantity * objSchemeAnnualOperatingCostDetail.UnitPrice);
        }

        $("#txtAOCTotalPrice", currentItem).autoNumeric('set', totalPrice);
        $("#btnAOCAddDetail", currentItem).attr("onclick", "RC.ManageScheme.ShowAnnualOperatingCostDetail(" + id + "); return false;");
        $("#btnAOCDelete", currentItem).attr("onclick", "RC.ManageScheme.DeleteAnnualOperatingCost(" + id + "); return false;");
        $(currentItem).attr("aocid", id).data("dataitem", lstSchemeAnnualOperatingCostDetail);

        $("#dvManageScheme #dvAnnualOperatingCost").append(currentItem);
    },
    DeleteAnnualOperatingCost: function (aocid) {
        $("#dvAnnualOperatingCost > div[aocid=" + aocid + "]").remove();
    },
    ShowAnnualOperatingCostDetail: function (aocid) {
        $("#dvAOCDetail #dvAOCFinancialYear").empty();
        $("#tmplAnnualOperatingCostDetail #ddlAOCGroupAccountHead").empty();

        RC.ManageScheme.AOCId = aocid;

        var groupId = $("#dvAnnualOperatingCost > div[aocid=" + RC.ManageScheme.AOCId + "] #ddlAOCGroup").val();
        var objGroup = RC.ManageScheme.GroupList.filter(p => parseInt(p.Id) === parseInt(groupId));

        RC.ManageScheme.PopulateYearWiseDate();

        if (objGroup.length > 0) {
            for (var i = 0; i < objGroup[0].GroupAccountHeadList.length; i++) {
                var objGroupAccountHead = objGroup[0].GroupAccountHeadList[i];

                $("#tmplAnnualOperatingCostDetail #ddlAOCGroupAccountHead").append($("<option/>", {
                    value: objGroupAccountHead.AccountHeadId,
                    text: objGroupAccountHead.COAName
                }));
            }
        }

        var objFinancialYear = RC.ManageScheme.FinancialYearList[(RC.ManageScheme.FinancialYearList.length - 1)];
        var tmplFinancialYear = $("#dvTemplates #tmplFinancialYear").clone().removeAttr("id");
        var currentItem = tmplFinancialYear.clone();

        $(currentItem)
            .val(objFinancialYear.Title)
            .attr("fyid", objFinancialYear.Id);

        $(currentItem)
            .removeClass("btn-default")
            .addClass("btn-primary");

        RC.ManageScheme.LoadFYAnnualOperatingCostDetail(objFinancialYear.Id);

        $("#dvAOCDetail #dvAOCFinancialYear").append(currentItem);

        $("#dvAOCFinancialYear .btn").click(function () {
            RC.ManageScheme.SaveCurrentFYAnnualOperatingCostDetail();

            $("#dvAOCFinancialYear .btn")
                .removeClass('btn-default')
                .removeClass('btn-primary')
                .addClass('btn-default');

            $(this)
                .removeClass('btn-default')
                .addClass('btn-primary');

            RC.ManageScheme.LoadFYAnnualOperatingCostDetail($(this).attr("fyid"));
        });

        $('#dvTemplates #btnAOCAddDetail')[0].click();
    },
    LoadFYAnnualOperatingCostDetail: function (fyid) {
        $("#dvAOCDetail #dvAOCDetailSection").empty();

        var lstSchemeAnnualOperatingCostDetail = $("#dvAnnualOperatingCost > div[aocid=" + RC.ManageScheme.AOCId + "]").data("dataitem");

        if (lstSchemeAnnualOperatingCostDetail != undefined) {
            var lstFYSchemeAnnualOperatingCostDetail = lstSchemeAnnualOperatingCostDetail.filter(p => parseInt(p.FYId) === parseInt(fyid));

            for (var i = 0; i < lstFYSchemeAnnualOperatingCostDetail.length; i++) {
                RC.ManageScheme.AddAnnualOperatingCostDetail(lstFYSchemeAnnualOperatingCostDetail[i]);
            }
        }
    },
    AddAnnualOperatingCostDetail: function (objSchemeAnnualOperatingCostDetail) {
        var tmplAnnualOperatingCostDetail = $("#dvTemplates #tmplAnnualOperatingCostDetail").clone().removeAttr("id");
        var currentItem = tmplAnnualOperatingCostDetail.clone();
        var id = $("#dvAOCDetailSection > div", "#dvAOCDetail").length + 1;

        $('#txtAOCDUnitPrice', currentItem)
            .attr("data-a-sign", "Rs. ")
            .autoNumeric('init');
        $('#txtAOCDTotalPrice', currentItem)
            .attr("data-a-sign", "Rs. ")
            .autoNumeric('init');

        if (objSchemeAnnualOperatingCostDetail != undefined) {
            $("#txtAOCDTitle", currentItem).val(objSchemeAnnualOperatingCostDetail.Title);
            $("#txtAOCDQuantity", currentItem).val(objSchemeAnnualOperatingCostDetail.Quantity);
            $("#txtAOCDUnitPrice", currentItem).autoNumeric('set', objSchemeAnnualOperatingCostDetail.UnitPrice);
            $("#txtAOCDTotalPrice", currentItem).autoNumeric('set', objSchemeAnnualOperatingCostDetail.Quantity * objSchemeAnnualOperatingCostDetail.UnitPrice);
            $("#ddlAOCGroupAccountHead", currentItem).val(objSchemeAnnualOperatingCostDetail.AccountHeadId);
        }
        else {
            $("#txtAOCDQuantity", currentItem).val(1);
        }

        $("#btnAOCDDelete", currentItem).attr("onclick", "RC.ManageScheme.DeleteAnnualOperatingCostDetail(" + id + "); return false;");
        $(currentItem).attr("aocdid", id);

        $("#dvAOCDetail #dvAOCDetailSection").append(currentItem);

        $("#dvAOCDetail #dvAOCDetailSection input").keyup(function () {
            var quantity = parseInt($(this).parents('.row').find('#txtAOCDQuantity').val());
            var unitPrice = parseFloat($(this).parents('.row').find('#txtAOCDUnitPrice').autoNumeric('get'));

            $(this).parents('.row').find('#txtAOCDTotalPrice').autoNumeric('set', quantity * unitPrice);
        });
    },
    DeleteAnnualOperatingCostDetail: function (aocdid) {
        $("#dvAOCDetailSection > div[aocdid=" + aocdid + "]").remove();
    },
    SaveCurrentFYAnnualOperatingCostDetail: function () {
        var lstSchemeAnnualOperatingCostDetail = $("#dvAnnualOperatingCost > div[aocid=" + RC.ManageScheme.AOCId + "]").data("dataitem");
        var fyid = $("#dvAOCFinancialYear .btn-primary").attr("fyid");

        if (lstSchemeAnnualOperatingCostDetail != undefined) {
            lstSchemeAnnualOperatingCostDetail = lstSchemeAnnualOperatingCostDetail.filter(p => parseInt(p.FYId) !== parseInt(fyid));

            $("#dvAOCDetail #dvAOCDetailSection .row").each(function (index) {
                var objSchemeAnnualOperatingCostDetail = {};

                objSchemeAnnualOperatingCostDetail.FYId = parseInt(fyid);
                objSchemeAnnualOperatingCostDetail.Title = $.trim($("#txtAOCDTitle", $(this)).val());
                objSchemeAnnualOperatingCostDetail.Quantity = parseInt($("#txtAOCDQuantity", $(this)).val());
                objSchemeAnnualOperatingCostDetail.UnitPrice = parseFloat($("#txtAOCDUnitPrice", $(this)).autoNumeric('get'));
                objSchemeAnnualOperatingCostDetail.AccountHeadId = parseInt($("#ddlAOCGroupAccountHead", $(this)).val());

                lstSchemeAnnualOperatingCostDetail.push(objSchemeAnnualOperatingCostDetail);
            });

            $("#dvAnnualOperatingCost > div[aocid=" + RC.ManageScheme.AOCId + "]").data("dataitem", lstSchemeAnnualOperatingCostDetail);
        }
    },
    SaveSchemeAOCDetail: function () {
        RC.ManageScheme.SaveCurrentFYAnnualOperatingCostDetail();
        $('#dvAOCDetail #btnAOCClose')[0].click();

        var lstSchemeAnnualOperatingCostDetail = $("#dvAnnualOperatingCost > div[aocid=" + RC.ManageScheme.AOCId + "]").data("dataitem");
        var totalPrice = 0;

        for (var i = 0; i < lstSchemeAnnualOperatingCostDetail.length; i++) {
            var objSchemeAnnualOperatingCostDetail = lstSchemeAnnualOperatingCostDetail[i];

            totalPrice += (objSchemeAnnualOperatingCostDetail.Quantity * objSchemeAnnualOperatingCostDetail.UnitPrice);
        }

        $("#txtAOCTotalPrice", $("#dvAnnualOperatingCost > div[aocid=" + RC.ManageScheme.AOCId + "]")).autoNumeric('set', totalPrice);
    },
    DeleteSchemeFile: function (id, Title) {
        var objSchemeFile = {
            Id: id,
            Title: Title
        };

        RC.ManageScheme.SchemeFilesToDelete.push(objSchemeFile);

        var catIindex = $.map(RC.ManageScheme.SchemeObject.SchemeFileList, function (obj, index) { if (obj.Id == id) { return index; } });

        RC.ManageScheme.SchemeObject.SchemeFileList.splice(catIindex, 1);

        $("#dvManageScheme #tblSchemeFileList").dataTable().fnClearTable();

        if (RC.ManageScheme.SchemeObject.SchemeFileList != null &&
            RC.ManageScheme.SchemeObject.SchemeFileList != undefined &&
            RC.ManageScheme.SchemeObject.SchemeFileList.length > 0) {
            $("#dvManageScheme #tblSchemeFileList").dataTable().fnAddData(RC.ManageScheme.SchemeObject.SchemeFileList);
            $("#dvManageScheme #tblSchemeFileList").dataTable().fnDraw();
        }
    }
}

$(document).ready(function () {
    RC.ManageScheme.InitializePage();

    $('#btnStep1').webuiPopover({ content: RC.Common.PC1SchemeWizardHeading.Step1, trigger: 'hover' });
    $('#btnStep2').webuiPopover({ content: RC.Common.PC1SchemeWizardHeading.Step2, trigger: 'hover' });
    $('#btnStep3').webuiPopover({ content: RC.Common.PC1SchemeWizardHeading.Step3, trigger: 'hover' });
    $('#btnStep4').webuiPopover({ content: RC.Common.PC1SchemeWizardHeading.Step4, trigger: 'hover' });
    $('#btnStep5').webuiPopover({ content: RC.Common.PC1SchemeWizardHeading.Step5, trigger: 'hover' });
    $('#btnStep6').webuiPopover({ content: RC.Common.PC1SchemeWizardHeading.Step6, trigger: 'hover' });
    $('#btnStep7').webuiPopover({ content: RC.Common.PC1SchemeWizardHeading.Step7, trigger: 'hover' });
    $('#btnStep8').webuiPopover({ content: RC.Common.PC1SchemeWizardHeading.Step8, trigger: 'hover' });
    $('#btnStep9').webuiPopover({ content: RC.Common.PC1SchemeWizardHeading.Step9, trigger: 'hover' });
    $('#btnStep10').webuiPopover({ content: RC.Common.PC1SchemeWizardHeading.Step10, trigger: 'hover' });
    $('#btnStep11').webuiPopover({ content: RC.Common.PC1SchemeWizardHeading.Step11, trigger: 'hover' });
    $('#btnStep12').webuiPopover({ content: RC.Common.PC1SchemeWizardHeading.Step12, trigger: 'hover' });
    $('#btnStep13').webuiPopover({ content: RC.Common.PC1SchemeWizardHeading.Step13, trigger: 'hover' });
    $('#btnStep14').webuiPopover({ content: RC.Common.PC1SchemeWizardHeading.Step14, trigger: 'hover' });
    $('#btnStep15').webuiPopover({ content: RC.Common.PC1SchemeWizardHeading.Step15, trigger: 'hover' });
    $('#btnStep16').webuiPopover({ content: RC.Common.PC1SchemeWizardHeading.Step16, trigger: 'hover' });

    $("#dvManageScheme .step").click(function () {
        $("#dvManageScheme .step")
            .removeClass('btn-default')
            .removeClass('btn-primary')
            .addClass('btn-default');

        $(this)
            .removeClass('btn-default')
            .addClass('btn-primary');

        var stepId = parseInt($(this).attr('tabindex'));

        RC.ManageScheme.SetCurrentStep(stepId);
    });
    $("#dvManageScheme #btnLoadMapLocation").click(function () {
        RC.ManageScheme.LoadMapLocation($("#dvManageScheme #txtLatitude").val(), $("#dvManageScheme #txtLongitude").val());
    });
    $('#dvManageScheme #btnCancel').on('click', function () {
        window.location = RC.Common.RootURL + "Forms/frmPC1Schemes.aspx?categoryId=" + RC.Common.GetQueryStringByName('categoryId') + "&LevelType=" + RC.Common.GetQueryStringByName('LevelType') + "&LevelID=" + RC.Common.GetQueryStringByName('LevelID');

        return false;
    });

    //setTimeout(function () {
    //    $('#dvTemplates #btnCCEAddDetail')[0].click();
    //    $('#dvTemplates #btnAOCAddDetail')[0].click();

    //    setTimeout(function () {
    //        $('#dvCCEDetail #btnCCEClose')[0].click();
    //        $('#dvAOCDetail #btnAOCClose')[0].click();
    //    }, 50);
    //}, 1000);
});