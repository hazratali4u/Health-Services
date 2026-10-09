var RC = RC || {};

RC.ManageSchemeExpenseBooking = {
    HandlerURL: RC.Common.RootURL + "Handler/SchemeExpenseBookingHandler.ashx",
    SchemeExpenseBookingObject: null,
    SchemePOReferenceNoList: [],
    SchemeExpenseBookingFilesToDelete: [],
    PayeeList: [],
    DetailTableInitialized: false,
    TotalCapital: 0,
    TotalRevenue: 0,
    TotalForeignFunding: 0,
    STotalCapital: 0,
    STotalRevenue: 0,
    STotalForeignFunding: 0,
    EditMode: false,
    AmountForEditMode: 0,
    InitializePage: function () {
        $('#dvManageSchemeExpenseBooking #fuFile').fineUploader({
            template: 'qq-template-manual-trigger',
            request: {
                endpoint: RC.ManageSchemeExpenseBooking.HandlerURL + "?method=UploadSchemeExpenseBookingFile"
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
                        RC.ManageSchemeExpenseBooking.AddUpdateSchemeExpenseBooking();
                    }
                    else if (failed.length > 0) {
                        $('#dvManageSchemeExpenseBooking #btnSave').removeClass("disabled").text('Save');
                    }
                },
                onComplete: function (id) {
                    qq(this.getItemByFileId(id)).remove();
                }
            }
        });

        if (RC.ManageSchemeExpenseBooking.SchemeExpenseBookingObject != null) {
            $("#dvManageSchemeExpenseBooking #txtExpenseDate").val(RC.ManageSchemeExpenseBooking.SchemeExpenseBookingObject.ExpenseDateString);
            $("#dvManageSchemeExpenseBooking #txtDocumentReference").val(RC.ManageSchemeExpenseBooking.SchemeExpenseBookingObject.DocumentReferenceNo);
            $("#dvManageSchemeExpenseBooking #txtPayee").val(RC.ManageSchemeExpenseBooking.SchemeExpenseBookingObject.Payee);
            $("#dvManageSchemeExpenseBooking #txtRemarks").val(RC.ManageSchemeExpenseBooking.SchemeExpenseBookingObject.Remarks);

            if (RC.ManageSchemeExpenseBooking.SchemeExpenseBookingObject.ExpenseBookingTypeId == RC.Common.ExpenseBookingType.COMMITMENT) {
                $("#dvManageSchemeExpenseBooking #txtPaymentDue").val(RC.ManageSchemeExpenseBooking.SchemeExpenseBookingObject.PaymentDueDateString);
                $("#dvManageSchemeExpenseBooking #txtPOReference").val(RC.ManageSchemeExpenseBooking.SchemeExpenseBookingObject.POReferenceNo);
            }
            else {
                RC.ManageSchemeExpenseBooking.PopulateSchemePOReferenceNo(RC.ManageSchemeExpenseBooking.SchemeExpenseBookingObject.SchemeId);

                if (RC.ManageSchemeExpenseBooking.SchemeExpenseBookingObject.SchemePOReferenceNoId > 0) {
                    $('#dvPOReferenceActual input:radio[value=POReference]').prop('checked', true);

                    $("#dvManageSchemeExpenseBooking #ddlPOReference option")
                        .removeAttr('selected')
                        .filter('[value=' + RC.ManageSchemeExpenseBooking.SchemeExpenseBookingObject.SchemePOReferenceNoId + ']')
                        .attr('selected', true);
                }
                else {
                    $('#dvPOReferenceActual input:radio[value=Invoice]').prop('checked', true);

                    $("#dvManageSchemeExpenseBooking #txtInvoice").val(RC.ManageSchemeExpenseBooking.SchemeExpenseBookingObject.InvoiceNo);
                }
            }

            RC.ManageSchemeExpenseBooking.PopulateSchemeExpenseBookingDetailList();
            RC.ManageSchemeExpenseBooking.SetExpenseBookingTypeView(RC.ManageSchemeExpenseBooking.SchemeExpenseBookingObject.ExpenseBookingTypeId);
            RC.ManageSchemeExpenseBooking.SetExpenseBookingTypeEditView(RC.ManageSchemeExpenseBooking.SchemeExpenseBookingObject.ExpenseBookingTypeId);
        }
        else {
            RC.ManageSchemeExpenseBooking.SchemeExpenseBookingObject = { Id: 0, SchemeId: 0, ExpenseBookingTypeId: 0, ExpenseDate: '', PaymentDueDate: '', SchemePOReferenceNoId: 0, InvoiceNo: '', DocumentReferenceNo: '', Payee: '', Remarks: '', POReferenceNo: '', IsFullyPaid: false, SchemeExpenseBookingDetailList: [], SchemeExpenseBookingFileList: [] };

            if ($("#dvManageSchemeExpenseBooking #dvReference").is(':visible') == false) {
                RC.ManageSchemeExpenseBooking.SetExpenseBookingTypeView(RC.Common.ExpenseBookingType.ACTUAL);
            }
            else {
                RC.ManageSchemeExpenseBooking.SetExpenseBookingTypeView(RC.Common.ExpenseBookingType.COMMITMENT);
            }
        }

        tinymce.init({
            selector: "#dvManageSchemeExpenseBooking textarea",
            height: 200,
            relative_urls: false,
            remove_script_host: false,
            convert_urls: true,
            toolbar: 'undo redo | bold italic | alignleft aligncenter alignright alignjustify | outdent indent',
            content_css: RC.Common.RootURL + 'css/tinymce.css'
        });
    },
    PopulateSchemeExpenseBookingDetailList: function () {
        if (RC.ManageSchemeExpenseBooking.SchemeExpenseBookingObject.SchemeExpenseBookingDetailList == null ||
            RC.ManageSchemeExpenseBooking.SchemeExpenseBookingObject.SchemeExpenseBookingDetailList == undefined) {
            RC.ManageSchemeExpenseBooking.SchemeExpenseBookingObject.SchemeExpenseBookingDetailList = [];

            ddlScheme.SetEnabled(true);
        }

        if (RC.ManageSchemeExpenseBooking.SchemeExpenseBookingObject.SchemeExpenseBookingDetailList != null && RC.ManageSchemeExpenseBooking.SchemeExpenseBookingObject.SchemeExpenseBookingDetailList != undefined && RC.ManageSchemeExpenseBooking.SchemeExpenseBookingObject.SchemeExpenseBookingDetailList.length > 0) {
            RC.ManageSchemeExpenseBooking.DetailTableInitialized = true;

            ddlScheme.SetEnabled(false);

            $('#dvManageSchemeExpenseBooking #tblSchemeExpenseBookingDetailList').DataTable({
                "data": RC.ManageSchemeExpenseBooking.SchemeExpenseBookingObject.SchemeExpenseBookingDetailList,
                "columns": [
                    { "data": "COAName" },
                    {
                        data: "ExpenseTypeName",
                        className: "center"
                    },
                    {
                        data: "ExpenseAmount",
                        className: "center",
                        render: function (data, type, full, meta) {
                            return RC.Common.FormatNumber(data);
                        }
                    },
                    {
                        data: null,
                        className: "center",
                        render: function (row, type, val, meta) {
                            return "<center><a title='Edit' href='javascript:void(0)' onclick='RC.ManageSchemeExpenseBooking.SchemeExpenseBookingDetailLoad(" + meta.row + ")'>" +
                                "<i class='fa fa-pencil' aria-hidden='true'></i></a>&nbsp;" +
                                "<a title='Delete' href='javascript:void(0)' onclick='RC.ManageSchemeExpenseBooking.SchemeExpenseBookingDetailDelete(" + meta.row + ")'>" +
                                "<i class='fa fa-trash-o' aria-hidden='true'></i></a></center>";
                        },
                        orderable: false,
                        defaultContent: ""
                    }
                ],
                "fnDrawCallback": function (oSettings) {
                    var sum = 0;

                    if (RC.ManageSchemeExpenseBooking.SchemeExpenseBookingObject.SchemeExpenseBookingDetailList != null && RC.ManageSchemeExpenseBooking.SchemeExpenseBookingObject.SchemeExpenseBookingDetailList != undefined && RC.ManageSchemeExpenseBooking.SchemeExpenseBookingObject.SchemeExpenseBookingDetailList.length > 0) {
                        for (var i = 0; i < RC.ManageSchemeExpenseBooking.SchemeExpenseBookingObject.SchemeExpenseBookingDetailList.length; i++) {
                            sum += parseFloat(RC.ManageSchemeExpenseBooking.SchemeExpenseBookingObject.SchemeExpenseBookingDetailList[i].ExpenseAmount);
                        }
                    }

                    $('#dvManageSchemeExpenseBooking #tblSchemeExpenseBookingDetailList')
                        .find('tbody tr:last')
                        .after('<tr id="trTotal" role="row" class="odd"><td colspan="2" style="text-align: right; font-weight: bolder;">Total&nbsp;</td><td class=" center">' + RC.Common.FormatNumber(sum) + '</td><td>&nbsp;</td></tr>');
                }
            });
        }

        if (RC.ManageSchemeExpenseBooking.SchemeExpenseBookingObject.SchemeExpenseBookingFileList == null ||
            RC.ManageSchemeExpenseBooking.SchemeExpenseBookingObject.SchemeExpenseBookingFileList == undefined) {
            RC.ManageSchemeExpenseBooking.SchemeExpenseBookingObject.SchemeExpenseBookingFileList = [];
        }

        if (RC.ManageSchemeExpenseBooking.SchemeExpenseBookingObject.SchemeExpenseBookingFileList != null && RC.ManageSchemeExpenseBooking.SchemeExpenseBookingObject.SchemeExpenseBookingFileList != undefined && RC.ManageSchemeExpenseBooking.SchemeExpenseBookingObject.SchemeExpenseBookingFileList.length > 0) {
            RC.ManageSchemeExpenseBooking.DetailTableInitialized = true;

            $('#dvManageSchemeExpenseBooking #tblSchemeExpenseBookingFileList').DataTable({
                "data": RC.ManageSchemeExpenseBooking.SchemeExpenseBookingObject.SchemeExpenseBookingFileList,
                "columns": [
                        {
                            data: null,
                            render: function (row, type, val, meta) {
                                return "<input type='hidden' value='" + row.Id + "'></input><a style='text-decoration: underline;' target='_blank' href='" + RC.Common.RootURL + "UploadedFile/ExpenseBookingFile/" + row.Title + "'>" + row.Title + "</a>";
                            },
                            defaultContent: ""
                        },
                        {
                            data: null,
                            className: "center",
                            render: function (row, type, val, meta) {
                                return "<center><a href='javascript:void(0)' onclick='RC.ManageSchemeExpenseBooking.DeleteSchemeExpenseBookingFile(" + row.Id + ", \"" + row.Title + "\")'>" +
                                    "<i class='fa fa-trash-o' aria-hidden='true'></i></a></center>";
                            },
                            orderable: false,
                            defaultContent: ""
                        }
                ]
            });
        }
    },
    SetExpenseBookingTypeView: function (expenseBookingTypeId) {
        if (expenseBookingTypeId == RC.Common.ExpenseBookingType.COMMITMENT) {
            $('#dvManageSchemeExpenseBooking #btnCommitment')
                .removeClass('btn-default')
                .removeClass('btn-primary')
                .addClass('btn-primary');

            $('#dvManageSchemeExpenseBooking #btnActual')
                .removeClass('btn-default')
                .removeClass('btn-primary')
                .addClass('btn-default');

            $('#dvManageSchemeExpenseBooking #dvPaymentDue1').show();
            $('#dvManageSchemeExpenseBooking #dvPaymentDue2').show();
            $('#dvManageSchemeExpenseBooking #dvPOReferenceCommitment').show();
            $('#dvManageSchemeExpenseBooking #dvPOReferenceActual').hide();
        }
        else {
            $('#dvManageSchemeExpenseBooking #btnActual')
                .removeClass('btn-default')
                .removeClass('btn-primary')
                .addClass('btn-primary');

            $('#dvManageSchemeExpenseBooking #btnCommitment')
                .removeClass('btn-default')
                .removeClass('btn-primary')
                .addClass('btn-default');

            $('#dvManageSchemeExpenseBooking #dvPaymentDue1').hide();
            $('#dvManageSchemeExpenseBooking #dvPaymentDue2').hide();
            $('#dvManageSchemeExpenseBooking #dvPOReferenceCommitment').hide();
            $('#dvManageSchemeExpenseBooking #dvPOReferenceActual').show();

            if ($('#dvManageSchemeExpenseBooking input[type="radio"][name="InvoicePOReference"]:checked').val() == 'Invoice') {
                $('#dvManageSchemeExpenseBooking #txtInvoice').show();
                $('#dvManageSchemeExpenseBooking #ddlPOReference').hide();
                $('#dvManageSchemeExpenseBooking #dvFullyPaid').hide();
            }
            else {
                $('#dvManageSchemeExpenseBooking #txtInvoice').hide();
                $('#dvManageSchemeExpenseBooking #ddlPOReference').show();
                $('#dvManageSchemeExpenseBooking #dvFullyPaid').show();
            }
        }
    },
    SetExpenseBookingTypeEditView: function (expenseBookingTypeId) {
        if (expenseBookingTypeId == RC.Common.ExpenseBookingType.COMMITMENT) {
            $('#dvManageSchemeExpenseBooking #btnActual').hide();
        }
        else {
            $('#dvManageSchemeExpenseBooking #btnCommitment').hide();
        }
    },
    GetExpenseBookingTypeForSelectedView: function () {
        var typeId = RC.Common.ExpenseBookingType.COMMITMENT;

        if ($('#dvManageSchemeExpenseBooking #btnActual').hasClass('btn-primary')) {
            typeId = RC.Common.ExpenseBookingType.ACTUAL;
        }

        return typeId;
    },
    PopulateSchemePOReferenceNo: function (schemeId) {
        $("#dvManageSchemeExpenseBooking #ddlPOReference").empty();

        if (RC.ManageSchemeExpenseBooking.SchemePOReferenceNoList != null && RC.ManageSchemeExpenseBooking.SchemePOReferenceNoList != undefined && RC.ManageSchemeExpenseBooking.SchemePOReferenceNoList.length > 0) {
            $.each(RC.ManageSchemeExpenseBooking.SchemePOReferenceNoList, function (index, obj) {
                if (obj.SchemeId == schemeId && obj.IsFullyPaid == false) {
                    $("#dvManageSchemeExpenseBooking #ddlPOReference").append($("<option />").val(obj.Id).text(obj.POReferenceNo));
                }
                else if (RC.ManageSchemeExpenseBooking.SchemeExpenseBookingObject != null &&
                    RC.ManageSchemeExpenseBooking.SchemeExpenseBookingObject.SchemePOReferenceNoId == obj.Id) {
                    $("#dvManageSchemeExpenseBooking #ddlPOReference").append($("<option />").val(obj.Id).text(obj.POReferenceNo));
                }
            });
        }
    },
    LoadSchemeExpenseBookingDetailView: function () {
        if (RC.ManageSchemeExpenseBooking.DetailTableInitialized) {
            $('#dvManageSchemeExpenseBooking #tblSchemeExpenseBookingDetailList').dataTable().fnClearTable();

            if (RC.ManageSchemeExpenseBooking.SchemeExpenseBookingObject.SchemeExpenseBookingDetailList != null && RC.ManageSchemeExpenseBooking.SchemeExpenseBookingObject.SchemeExpenseBookingDetailList != undefined && RC.ManageSchemeExpenseBooking.SchemeExpenseBookingObject.SchemeExpenseBookingDetailList.length > 0) {
                $('#dvManageSchemeExpenseBooking #tblSchemeExpenseBookingDetailList').dataTable().fnAddData(RC.ManageSchemeExpenseBooking.SchemeExpenseBookingObject.SchemeExpenseBookingDetailList);
                ddlScheme.SetEnabled(false);
            }

            $('#dvManageSchemeExpenseBooking #tblSchemeExpenseBookingDetailList').dataTable().fnDraw();

            if (RC.ManageSchemeExpenseBooking.SchemeExpenseBookingObject.SchemeExpenseBookingDetailList == null ||
                RC.ManageSchemeExpenseBooking.SchemeExpenseBookingObject.SchemeExpenseBookingDetailList == undefined ||
                RC.ManageSchemeExpenseBooking.SchemeExpenseBookingObject.SchemeExpenseBookingDetailList.length <= 0) {
                $('#trTotal').remove();
                ddlScheme.SetEnabled(true);
            }
        }
        else {
            RC.ManageSchemeExpenseBooking.PopulateSchemeExpenseBookingDetailList();
        }

        RC.ManageSchemeExpenseBooking.LoadFundReleaseTotalAmountForType();
        RC.ManageSchemeExpenseBooking.LoadFundReleaseSTotalAmountForType();
    },
    SchemeExpenseBookingDetailLoad: function (index) {
        var objSchemeExpenseBookingDetail = RC.ManageSchemeExpenseBooking.SchemeExpenseBookingObject.SchemeExpenseBookingDetailList[index];

        ddlCTCOA.SetValue(objSchemeExpenseBookingDetail.COAId);
        ddlCTExpenseType.SetValue(objSchemeExpenseBookingDetail.ExpenseTypeId);
        $("#dvManageSchemeExpenseBooking #txtAmount").autoNumeric('set', objSchemeExpenseBookingDetail.ExpenseAmount);
        $("#dvManageSchemeExpenseBooking #btnSaveDetail")
            .attr('onclick', "RC.ManageSchemeExpenseBooking.SchemeExpenseBookingDetailSave(" + index + ");")
            .val('Update');

        RC.ManageSchemeExpenseBooking.EditMode = true;
        RC.ManageSchemeExpenseBooking.AmountForEditMode = objSchemeExpenseBookingDetail.ExpenseAmount;

        RC.ManageSchemeExpenseBooking.SchemeFundReleaseTotalAmountGetSchemeId();
        RC.ManageSchemeExpenseBooking.LoadFundReleaseSTotalAmountForType();

        if (ddlCTExpenseType.GetSelectedItem().value == RC.Common.SchemeFundType.CAPITAL) {
            ddlCTCOA.SetEnabled(false);
        }
        else if (ddlCTExpenseType.GetSelectedItem().value == RC.Common.SchemeFundType.REVENUE) {
            ddlRCTCOA.SetEnabled(false);
        }
        else if (ddlCTExpenseType.GetSelectedItem().value == RC.Common.SchemeFundType.FOREIGNFUNDING) {
            ddlFFCTCOA.SetEnabled(false);
        }

        ddlCTExpenseType.SetEnabled(false);
    },
    SchemeExpenseBookingDetailReset: function () {
        //ddlCTCOA.SetSelectedIndex(0);
        //ddlCTExpenseType.SetSelectedIndex(0);
        RC.ManageSchemeExpenseBooking.EditMode = false;
        RC.ManageSchemeExpenseBooking.AmountForEditMode = 0;

        ddlRCTCOA.SetEnabled(true);
        ddlCTCOA.SetEnabled(true);
        ddlFFCTCOA.SetEnabled(true);
        ddlCTExpenseType.SetEnabled(true);

        $("#dvManageSchemeExpenseBooking #txtAmount").autoNumeric('set', '');
        $("#dvManageSchemeExpenseBooking #btnSaveDetail")
            .attr('onclick', "RC.ManageSchemeExpenseBooking.SchemeExpenseBookingDetailSave(-1);")
            .val('Add');
    },
    SchemeExpenseBookingDetailSave: function (index) {
        var status = RC.ManageSchemeExpenseBooking.ValidateSchemeExpenseBookingDetail();

        if (status) {
            if (index >= 0) {
                RC.ManageSchemeExpenseBooking.SchemeExpenseBookingObject.SchemeExpenseBookingDetailList.splice(index, 1);
            }

            var objSchemeExpenseBookingDetail = { COAId: 0, ExpenseTypeId: 0, COAName: '', ExpenseTypeName: '', ExpenseAmount: 0 };
            var typeId = 0;
            var coaId = 0;
            var coaText = '';

            if (ddlCTExpenseType.GetSelectedItem().value == RC.Common.SchemeFundType.CAPITAL) {
                typeId = RC.Common.SchemeFundType.CAPITAL;
                coaId = ddlCTCOA.GetSelectedItem().value;
                coaText = ddlCTCOA.GetSelectedItem().text;
            }
            else if (ddlCTExpenseType.GetSelectedItem().value == RC.Common.SchemeFundType.REVENUE) {
                typeId = RC.Common.SchemeFundType.REVENUE;
                coaId = ddlRCTCOA.GetSelectedItem().value;
                coaText = ddlRCTCOA.GetSelectedItem().text;
            }
            else if (ddlCTExpenseType.GetSelectedItem().value == RC.Common.SchemeFundType.FOREIGNFUNDING) {
                typeId = RC.Common.SchemeFundType.FOREIGNFUNDING;
                coaId = ddlFFCTCOA.GetSelectedItem().value;
                coaText = ddlFFCTCOA.GetSelectedItem().text;
            }

            objSchemeExpenseBookingDetail.COAId = coaId;
            objSchemeExpenseBookingDetail.ExpenseTypeId = typeId;
            objSchemeExpenseBookingDetail.COAName = coaText;
            objSchemeExpenseBookingDetail.ExpenseTypeName = ddlCTExpenseType.GetSelectedItem().text;
            objSchemeExpenseBookingDetail.ExpenseAmount = parseFloat($("#dvManageSchemeExpenseBooking #txtAmount").autoNumeric('get'));

            RC.ManageSchemeExpenseBooking.SchemeExpenseBookingObject.SchemeExpenseBookingDetailList.push(objSchemeExpenseBookingDetail);

            RC.ManageSchemeExpenseBooking.LoadSchemeExpenseBookingDetailView();
            RC.ManageSchemeExpenseBooking.SchemeExpenseBookingDetailReset();
            RC.ManageSchemeExpenseBooking.SchemeFundReleaseTotalAmountGetSchemeId();
            RC.ManageSchemeExpenseBooking.SchemeFundReleaseSTotalAmountGetSchemeId();
        }
    },
    SchemeExpenseBookingDetailDelete: function (fadIndex) {
        RC.ManageSchemeExpenseBooking.SchemeExpenseBookingObject.SchemeExpenseBookingDetailList.splice(fadIndex, 1);

        RC.ManageSchemeExpenseBooking.LoadSchemeExpenseBookingDetailView();
        RC.ManageSchemeExpenseBooking.SchemeExpenseBookingDetailReset();
        RC.ManageSchemeExpenseBooking.SchemeFundReleaseTotalAmountGetSchemeId();
        RC.ManageSchemeExpenseBooking.SchemeFundReleaseSTotalAmountGetSchemeId();
    },
    ValidateSchemeExpenseBooking: function () {
        var status = true;

        if (ddlScheme.GetSelectedItem() == null) {
            alert("Please provide scheme.");

            status = false;
        }
        else if ($.trim($("#dvManageSchemeExpenseBooking #txtExpenseDate").val()) == "") {
            alert("Please provide expense date.");

            status = false;
        }
        else if ($("#dvManageSchemeExpenseBooking #dvReference").is(':visible') == true && $.trim($("#dvManageSchemeExpenseBooking #txtPayee").val()) == "") {
            alert("Please provide payee / vendor.");

            status = false;
        }
        else if (RC.ManageSchemeExpenseBooking.GetExpenseBookingTypeForSelectedView() == RC.Common.ExpenseBookingType.COMMITMENT) {
            if ($.trim($("#dvManageSchemeExpenseBooking #txtPOReference").val()) == "") {
                alert("Please provide po reference.");

                status = false;
            }
            else if ($.trim($("#dvManageSchemeExpenseBooking #txtPaymentDue").val()) == "") {
                alert("Please provide payment due date.");

                status = false;
            }
        }
        else if ($("#dvManageSchemeExpenseBooking #dvPOReferenceActual").is(':visible') == true &&
            RC.ManageSchemeExpenseBooking.GetExpenseBookingTypeForSelectedView() == RC.Common.ExpenseBookingType.ACTUAL) {
            if ($('#dvManageSchemeExpenseBooking input[type="radio"][name="InvoicePOReference"]:checked').val() == 'Invoice') {
                if ($.trim($("#dvManageSchemeExpenseBooking #txtInvoice").val()) == "") {
                    alert("Please provide invoice.");

                    status = false;
                }
            }
            else if ($('#dvManageSchemeExpenseBooking input[type="radio"][name="InvoicePOReference"]:checked').val() == 'POReference') {
                if ($("#dvManageSchemeExpenseBooking #ddlPOReference").val() == null) {
                    alert("Please provide po reference.");

                    status = false;
                }
            }
        }

        return status;
    },
    ValidateSchemeExpenseBookingDetail: function () {
        var status = true, coaId = 0;

        if (ddlCTExpenseType.GetSelectedItem().value == RC.Common.SchemeFundType.CAPITAL) {
            if (ddlCTCOA.GetSelectedItem() == null) {
                alert("Please provide object code.");

                status = false;
            }
            else {
                coaId = ddlCTCOA.GetSelectedItem().value;
            }
        }
        else if (ddlCTExpenseType.GetSelectedItem().value == RC.Common.SchemeFundType.REVENUE) {
            if (ddlRCTCOA.GetSelectedItem() == null) {
                alert("Please provide object code.");

                status = false;
            }
            else {
                coaId = ddlRCTCOA.GetSelectedItem().value;
            }
        }
        else if (ddlCTExpenseType.GetSelectedItem().value == RC.Common.SchemeFundType.FOREIGNFUNDING) {
            if (ddlFFCTCOA.GetSelectedItem() == null) {
                alert("Please provide object code.");

                status = false;
            }
            else {
                coaId = ddlFFCTCOA.GetSelectedItem().value;
            }
        }

        if (status) {
            if ($.trim($("#dvManageSchemeExpenseBooking #txtAmount").autoNumeric('get')) == "") {
                alert("Please provide amount.");

                status = false;
            }

            var totalCapital = 0;
            var totalRevenue = 0;
            var totalForeignFunding = 0;

            $.each(RC.ManageSchemeExpenseBooking.SchemeExpenseBookingObject.SchemeExpenseBookingDetailList, function (index, obj) {
                if (obj.COAId == coaId) {
                    if (obj.ExpenseTypeId == RC.Common.SchemeFundType.CAPITAL) {
                        totalCapital += obj.ExpenseAmount;
                    }
                    else if (obj.ExpenseTypeId == RC.Common.SchemeFundType.REVENUE) {
                        totalRevenue += obj.ExpenseAmount;
                    }
                    else if (obj.ExpenseTypeId == RC.Common.SchemeFundType.FOREIGNFUNDING) {
                        totalForeignFunding += obj.ExpenseAmount;
                    }
                }
            });

            if (ddlCTExpenseType.GetSelectedItem().value == RC.Common.SchemeFundType.CAPITAL) {
                var allowedCapital = parseFloat(RC.ManageSchemeExpenseBooking.TotalCapital) - totalCapital;

                if (RC.ManageSchemeExpenseBooking.EditMode) {
                    allowedCapital += parseFloat(RC.ManageSchemeExpenseBooking.AmountForEditMode);
                }

                if (parseFloat($("#dvManageSchemeExpenseBooking #txtAmount").autoNumeric('get')) > allowedCapital) {
                    alert("Allowed Capital is Rs " + allowedCapital + ".");

                    status = false;
                }
            }
            else if (ddlCTExpenseType.GetSelectedItem().value == RC.Common.SchemeFundType.REVENUE) {
                var allowedRevenue = parseFloat(RC.ManageSchemeExpenseBooking.TotalRevenue) - totalRevenue;

                if (RC.ManageSchemeExpenseBooking.EditMode) {
                    allowedRevenue += parseFloat(RC.ManageSchemeExpenseBooking.AmountForEditMode);
                }

                if (parseFloat($("#dvManageSchemeExpenseBooking #txtAmount").autoNumeric('get')) > allowedRevenue) {
                    alert("Allowed Revenue is Rs " + allowedRevenue + ".");

                    status = false;
                }
            }
            else if (ddlCTExpenseType.GetSelectedItem().value == RC.Common.SchemeFundType.FOREIGNFUNDING) {
                var allowedForeignFunding = parseFloat(RC.ManageSchemeExpenseBooking.TotalForeignFunding) - totalForeignFunding;

                if (RC.ManageSchemeExpenseBooking.EditMode) {
                    allowedForeignFunding += parseFloat(RC.ManageSchemeExpenseBooking.AmountForEditMode);
                }

                if (parseFloat($("#dvManageSchemeExpenseBooking #txtAmount").autoNumeric('get')) > allowedForeignFunding) {
                    alert("Allowed Foreign Funding is Rs " + allowedForeignFunding + ".");

                    status = false;
                }
            }
        }

        return status;
    },
    ResetSchemeExpenseBooking: function () {
        //ddlScheme.SetSelectedIndex(0);
        $("#dvManageSchemeExpenseBooking #txtExpenseDate").val('');
        $("#dvManageSchemeExpenseBooking #txtPaymentDue").val('');
        $("#dvManageSchemeExpenseBooking #txtDocumentReference").val('');
        $("#dvManageSchemeExpenseBooking #txtPayee").val('');
        $("#dvManageSchemeExpenseBooking #txtPOReference").val('');
        $('#dvPOReferenceActual input:radio[value=Invoice]').prop('checked', true);
        $("#dvManageSchemeExpenseBooking #txtInvoice").val('');
        $("#dvManageSchemeExpenseBooking #ddlPOReference").empty();
        $("#dvManageSchemeExpenseBooking #chkFullyPaid").prop('checked', false);
        tinymce.get($("#dvManageSchemeExpenseBooking #txtRemarks").attr("id")).setContent('');
        //$('#dvManageSchemeExpenseBooking #fuFile').clearStoredFiles();

        $('#dvManageSchemeExpenseBooking #btnSave').removeClass("disabled").val('Save');

        RC.ManageSchemeExpenseBooking.SchemeExpenseBookingObject = { Id: 0, SchemeId: 0, ExpenseBookingTypeId: 0, ExpenseDate: '', PaymentDueDate: '', SchemePOReferenceNoId: 0, InvoiceNo: '', DocumentReferenceNo: '', Payee: '', Remarks: '', POReferenceNo: '', IsFullyPaid: false, SchemeExpenseBookingDetailList: [], SchemeExpenseBookingFileList: [] };

        RC.ManageSchemeExpenseBooking.SchemeExpenseBookingDetailReset();
        RC.ManageSchemeExpenseBooking.LoadSchemeExpenseBookingDetailView();
        RC.ManageSchemeExpenseBooking.SetExpenseBookingTypeView(RC.ManageSchemeExpenseBooking.GetExpenseBookingTypeForSelectedView());
    },
    PopulateSchemeExpenseBooking: function () {
        var status = RC.ManageSchemeExpenseBooking.ValidateSchemeExpenseBooking();

        if (status) {
            var id = 0;
            var schemePOReferenceNoId = 0;

            if (RC.ManageSchemeExpenseBooking.SchemeExpenseBookingObject != null) {
                id = RC.ManageSchemeExpenseBooking.SchemeExpenseBookingObject.Id;
                schemePOReferenceNoId = RC.ManageSchemeExpenseBooking.SchemeExpenseBookingObject.SchemePOReferenceNoId;
            }

            RC.ManageSchemeExpenseBooking.SchemeExpenseBookingObject.Id = id;
            RC.ManageSchemeExpenseBooking.SchemeExpenseBookingObject.SchemeId = ddlScheme.GetSelectedItem().value;
            RC.ManageSchemeExpenseBooking.SchemeExpenseBookingObject.ExpenseBookingTypeId = RC.ManageSchemeExpenseBooking.GetExpenseBookingTypeForSelectedView();
            RC.ManageSchemeExpenseBooking.SchemeExpenseBookingObject.ExpenseDate = $("#dvManageSchemeExpenseBooking #txtExpenseDate").val();
            RC.ManageSchemeExpenseBooking.SchemeExpenseBookingObject.DocumentReferenceNo = $("#dvManageSchemeExpenseBooking #txtDocumentReference").val();
            RC.ManageSchemeExpenseBooking.SchemeExpenseBookingObject.Payee = $("#dvManageSchemeExpenseBooking #txtPayee").val();
            RC.ManageSchemeExpenseBooking.SchemeExpenseBookingObject.Remarks = tinymce.get($("#dvManageSchemeExpenseBooking #txtRemarks").attr("id")).getContent();

            $("#dvManageSchemeExpenseBooking #tblSchemeExpenseBookingFileList input[type='hidden']").each(function (index, item) {
                var objSchemeExpenseBookingFile = {
                    Id: $(item).val()
                };

                RC.ManageSchemeExpenseBooking.SchemeExpenseBookingObject.SchemeExpenseBookingFileList.push(objSchemeExpenseBookingFile);
            });

            if (RC.ManageSchemeExpenseBooking.SchemeExpenseBookingObject.ExpenseBookingTypeId == RC.Common.ExpenseBookingType.COMMITMENT) {
                RC.ManageSchemeExpenseBooking.SchemeExpenseBookingObject.PaymentDueDate = $("#dvManageSchemeExpenseBooking #txtPaymentDue").val();
                RC.ManageSchemeExpenseBooking.SchemeExpenseBookingObject.POReferenceNo = $("#dvManageSchemeExpenseBooking #txtPOReference").val();
                RC.ManageSchemeExpenseBooking.SchemeExpenseBookingObject.SchemePOReferenceNoId = schemePOReferenceNoId;
            }
            else {
                if ($('#dvManageSchemeExpenseBooking input[type="radio"][name="InvoicePOReference"]:checked').val() == 'Invoice') {
                    RC.ManageSchemeExpenseBooking.SchemeExpenseBookingObject.InvoiceNo = $("#dvManageSchemeExpenseBooking #txtInvoice").val();
                }
                else {
                    RC.ManageSchemeExpenseBooking.SchemeExpenseBookingObject.SchemePOReferenceNoId = $("#dvManageSchemeExpenseBooking #ddlPOReference").val();
                    RC.ManageSchemeExpenseBooking.SchemeExpenseBookingObject.IsFullyPaid = $("#dvManageSchemeExpenseBooking #chkFullyPaid").is(":checked");
                }
            }

            var isForeignFunding = (ddlScheme.GetSelectedItem().texts[3].toLowerCase() == 'true');

            if (!isForeignFunding) {
                RC.ManageSchemeExpenseBooking.SchemeExpenseBookingObject.SchemeExpenseBookingDetailList = RC.ManageSchemeExpenseBooking.SchemeExpenseBookingObject.SchemeExpenseBookingDetailList.filter(p => parseInt(p.ExpenseTypeId) !== 3);
            }

            if (RC.ManageSchemeExpenseBooking.SchemeExpenseBookingObject.DocumentReferenceNo == undefined) {
                RC.ManageSchemeExpenseBooking.SchemeExpenseBookingObject.DocumentReferenceNo = '';
            }

            if (RC.ManageSchemeExpenseBooking.SchemeExpenseBookingObject.Payee == undefined) {
                RC.ManageSchemeExpenseBooking.SchemeExpenseBookingObject.Payee = '';
            }

            if (RC.ManageSchemeExpenseBooking.SchemeExpenseBookingObject.SchemePOReferenceNoId == undefined) {
                RC.ManageSchemeExpenseBooking.SchemeExpenseBookingObject.SchemePOReferenceNoId = 0;
            }
        }

        return status;
    },
    DeleteSchemeExpenseBookingFile: function (id, Title) {
        var objSchemeExpenseBookingFile = {
            Id: id,
            Title: Title
        };

        RC.ManageSchemeExpenseBooking.SchemeExpenseBookingFilesToDelete.push(objSchemeExpenseBookingFile);

        var catIindex = $.map(RC.ManageSchemeExpenseBooking.SchemeExpenseBookingObject.SchemeExpenseBookingFileList, function (obj, index) { if (obj.Id == id) { return index; } });

        RC.ManageSchemeExpenseBooking.SchemeExpenseBookingObject.SchemeExpenseBookingFileList.splice(catIindex, 1);

        $("#dvManageSchemeExpenseBooking #tblSchemeExpenseBookingFileList").dataTable().fnClearTable();

        if (RC.ManageSchemeExpenseBooking.SchemeExpenseBookingObject.SchemeExpenseBookingFileList != null && RC.ManageSchemeExpenseBooking.SchemeExpenseBookingObject.SchemeExpenseBookingFileList != undefined && RC.ManageSchemeExpenseBooking.SchemeExpenseBookingObject.SchemeExpenseBookingFileList.length > 0) {
            $("#dvManageSchemeExpenseBooking #tblSchemeExpenseBookingFileList").dataTable().fnAddData(RC.ManageSchemeExpenseBooking.SchemeExpenseBookingObject.SchemeExpenseBookingFileList);
            $("#dvManageSchemeExpenseBooking #tblSchemeExpenseBookingFileList").dataTable().fnDraw();
        }
    },
    SaveSchemeExpenseBooking: function () {
        if (RC.ManageSchemeExpenseBooking.PopulateSchemeExpenseBooking()) {
            $('#dvManageSchemeExpenseBooking #btnSave').addClass("disabled").val('Wait...');

            var fuFileCount = $.grep($('#dvManageSchemeExpenseBooking #fuFile').fineUploader('getUploads'), function (n, i) { return n.status === 'submitted'; }).length;

            if (fuFileCount > 0) {
                $('#dvManageSchemeExpenseBooking #fuFile').fineUploader('uploadStoredFiles');
            }
            else {
                RC.ManageSchemeExpenseBooking.AddUpdateSchemeExpenseBooking();
            }
        }
    },
    AddUpdateSchemeExpenseBooking: function () {
        var handlerMethod = 'SchemeExpenseBookingAdd';

        if (RC.ManageSchemeExpenseBooking.SchemeExpenseBookingObject.Id > 0) {
            handlerMethod = 'SchemeExpenseBookingUpdate';
        }

        $.post(RC.ManageSchemeExpenseBooking.HandlerURL,
        {
            method: handlerMethod,
            objSchemeExpenseBooking: JSON.stringify(RC.ManageSchemeExpenseBooking.SchemeExpenseBookingObject),
            SchemeExpenseBookingFilesToDelete: JSON.stringify(RC.ManageSchemeExpenseBooking.SchemeExpenseBookingFilesToDelete)
        },
        function (response) {
            switch (response.Status) {
                case RC.Common.ResponseStatus.SUCCESS:
                    if (RC.ManageSchemeExpenseBooking.SchemeExpenseBookingObject.Id > 0) {
                        alert(response.Message);

                        window.location = RC.Common.RootURL + "Forms/frmExpesneBooking.aspx?LevelType=" + RC.Common.GetQueryStringByName('LevelType') + "&LevelID=" + RC.Common.GetQueryStringByName('LevelID');
                    }
                    else {
                        RC.ManageSchemeExpenseBooking.SchemeExpenseBookingPayeeGet();
                        RC.ManageSchemeExpenseBooking.LoadSchemePOReferenceNoList(response.Message);
                    }

                    break;
                case RC.Common.ResponseStatus.ERROR:
                    alert(response.Message);

                    $('#dvManageSchemeExpenseBooking #btnSave').removeClass("disabled").val('Save');

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
    LoadSchemePOReferenceNoList: function (message) {
        $.post(RC.ManageSchemeExpenseBooking.HandlerURL,
        {
            method: "LoadSchemePOReferenceNoList"
        },
        function (response) {
            switch (response.Status) {
                case RC.Common.ResponseStatus.SUCCESS:
                    alert(message);

                    RC.ManageSchemeExpenseBooking.SchemePOReferenceNoList = response.Data;

                    RC.ManageSchemeExpenseBooking.ResetSchemeExpenseBooking();
                    RC.ManageSchemeExpenseBooking.PopulateSchemePOReferenceNo(ddlScheme.GetSelectedItem().value);

                    break;
                case RC.Common.ResponseStatus.ERROR:
                    alert(response.Message);

                    $('#dvManageSchemeExpenseBooking #btnSave').removeClass("disabled").val('Save');

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
    SchemeFundReleaseTotalAmountGetSchemeId: function () {
        $('#dvManageSchemeExpenseBooking #dvTotalAmount .number').html('<i class="fa fa-spinner fa-spin" aria-hidden="true"></i>');

        var coaId = 0;

        if (ddlCTExpenseType.GetSelectedItem().value == RC.Common.SchemeFundType.CAPITAL) {
            if (ddlCTCOA.GetSelectedItem() != null) {
                coaId = ddlCTCOA.GetSelectedItem().value;
            }
        }
        else if (ddlCTExpenseType.GetSelectedItem().value == RC.Common.SchemeFundType.REVENUE) {
            if (ddlRCTCOA.GetSelectedItem() != null) {
                coaId = ddlRCTCOA.GetSelectedItem().value;
            }
        }
        else if (ddlCTExpenseType.GetSelectedItem().value == RC.Common.SchemeFundType.FOREIGNFUNDING) {
            if (ddlFFCTCOA.GetSelectedItem() != null) {
                coaId = ddlFFCTCOA.GetSelectedItem().value;
            }
        }

        if (coaId > 0) {
            $.post(RC.ManageSchemeExpenseBooking.HandlerURL,
            {
                method: "SchemeFundReleaseTotalAmountGetSchemeId",
                SchemeId: ddlScheme.GetSelectedItem().value,
                COAId: coaId
            },
            function (response) {
                switch (response.Status) {
                    case RC.Common.ResponseStatus.SUCCESS:
                        RC.ManageSchemeExpenseBooking.TotalCapital = response.Data.TotalCapital;
                        RC.ManageSchemeExpenseBooking.TotalRevenue = response.Data.TotalRevenue;
                        RC.ManageSchemeExpenseBooking.TotalForeignFunding = response.Data.TotalForeignFunding;

                        RC.ManageSchemeExpenseBooking.LoadFundReleaseTotalAmountForType();

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
        else {
            RC.ManageSchemeExpenseBooking.TotalCapital = 0;
            RC.ManageSchemeExpenseBooking.TotalRevenue = 0;
            RC.ManageSchemeExpenseBooking.TotalForeignFunding = 0;

            RC.ManageSchemeExpenseBooking.LoadFundReleaseTotalAmountForType();
        }
    },
    LoadFundReleaseTotalAmountForType: function () {
        var usedCapital = 0, remainingCapital = 0, usedRevenue = 0, remainingRevenue = 0, usedForeignFunding = 0, remainingForeignFunding = 0, coaId = 0;

        if (ddlCTExpenseType.GetSelectedItem().value == RC.Common.SchemeFundType.CAPITAL) {
            if (ddlCTCOA.GetSelectedItem() != null) {
                coaId = ddlCTCOA.GetSelectedItem().value;
            }
        }
        else if (ddlCTExpenseType.GetSelectedItem().value == RC.Common.SchemeFundType.REVENUE) {
            if (ddlRCTCOA.GetSelectedItem() != null) {
                coaId = ddlRCTCOA.GetSelectedItem().value;
            }
        }
        else if (ddlCTExpenseType.GetSelectedItem().value == RC.Common.SchemeFundType.FOREIGNFUNDING) {
            if (ddlFFCTCOA.GetSelectedItem() != null) {
                coaId = ddlFFCTCOA.GetSelectedItem().value;
            }
        }

        $(RC.ManageSchemeExpenseBooking.SchemeExpenseBookingObject.SchemeExpenseBookingDetailList).each(function (index, item) {
            if (item.COAId == coaId) {
                if (item.ExpenseTypeId == RC.Common.SchemeFundType.CAPITAL) {
                    usedCapital += parseFloat(item.ExpenseAmount);
                }
                else if (item.ExpenseTypeId == RC.Common.SchemeFundType.REVENUE) {
                    usedRevenue += parseFloat(item.ExpenseAmount);
                }
                else if (item.ExpenseTypeId == RC.Common.SchemeFundType.FOREIGNFUNDING) {
                    usedForeignFunding += parseFloat(item.ExpenseAmount);
                }
            }
        });

        remainingCapital = parseFloat(RC.ManageSchemeExpenseBooking.TotalCapital) - usedCapital;
        remainingRevenue = parseFloat(RC.ManageSchemeExpenseBooking.TotalRevenue) - usedRevenue;
        remainingForeignFunding = parseFloat(RC.ManageSchemeExpenseBooking.TotalForeignFunding) - usedForeignFunding;

        if (ddlCTExpenseType.GetSelectedItem().value == RC.Common.SchemeFundType.CAPITAL) {
            if (RC.ManageSchemeExpenseBooking.EditMode) {
                remainingCapital += parseFloat(RC.ManageSchemeExpenseBooking.AmountForEditMode);
            }

            $('#dvManageSchemeExpenseBooking #dvTotalAmount .number').html('Released Capital (Object Code)');
            $('#dvManageSchemeExpenseBooking #dvTotalAmount .desc').html('Rs ' + remainingCapital);
        }
        else if (ddlCTExpenseType.GetSelectedItem().value == RC.Common.SchemeFundType.REVENUE) {
            if (RC.ManageSchemeExpenseBooking.EditMode) {
                remainingRevenue += parseFloat(RC.ManageSchemeExpenseBooking.AmountForEditMode);
            }

            $('#dvManageSchemeExpenseBooking #dvTotalAmount .number').html('Released Revenue (Object Code)');
            $('#dvManageSchemeExpenseBooking #dvTotalAmount .desc').html('Rs ' + remainingRevenue);
        }
        else if (ddlCTExpenseType.GetSelectedItem().value == RC.Common.SchemeFundType.FOREIGNFUNDING) {
            if (RC.ManageSchemeExpenseBooking.EditMode) {
                remainingForeignFunding += parseFloat(RC.ManageSchemeExpenseBooking.AmountForEditMode);
            }

            $('#dvManageSchemeExpenseBooking #dvTotalAmount .number').html('Released Foreign Funding (Object Code)');
            $('#dvManageSchemeExpenseBooking #dvTotalAmount .desc').html('Rs ' + remainingForeignFunding);
        }
    },
    SchemeFundReleaseSTotalAmountGetSchemeId: function () {
        $('#dvManageSchemeExpenseBooking #dvSTotalAmount .number').html('<i class="fa fa-spinner fa-spin" aria-hidden="true"></i>');

        $.post(RC.ManageSchemeExpenseBooking.HandlerURL,
        {
            method: "SchemeFundReleaseTotalAmountGetSchemeId",
            SchemeId: ddlScheme.GetSelectedItem().value,
            COAId: 0
        },
        function (response) {
            switch (response.Status) {
                case RC.Common.ResponseStatus.SUCCESS:
                    RC.ManageSchemeExpenseBooking.STotalCapital = response.Data.TotalCapital;
                    RC.ManageSchemeExpenseBooking.STotalRevenue = response.Data.TotalRevenue;
                    RC.ManageSchemeExpenseBooking.STotalForeignFunding = response.Data.TotalForeignFunding;

                    RC.ManageSchemeExpenseBooking.LoadFundReleaseSTotalAmountForType();

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
    LoadFundReleaseSTotalAmountForType: function () {
        var usedCapital = 0, remainingCapital = 0, usedRevenue = 0, remainingRevenue = 0, usedForeignFunding = 0, remainingForeignFunding = 0;

        $(RC.ManageSchemeExpenseBooking.SchemeExpenseBookingObject.SchemeExpenseBookingDetailList).each(function (index, item) {
            if (item.ExpenseTypeId == RC.Common.SchemeFundType.CAPITAL) {
                usedCapital += parseFloat(item.ExpenseAmount);
            }
            else if (item.ExpenseTypeId == RC.Common.SchemeFundType.REVENUE) {
                usedRevenue += parseFloat(item.ExpenseAmount);
            }
            else if (item.ExpenseTypeId == RC.Common.SchemeFundType.FOREIGNFUNDING) {
                usedForeignFunding += parseFloat(item.ExpenseAmount);
            }
        });

        remainingCapital = parseFloat(RC.ManageSchemeExpenseBooking.STotalCapital) - usedCapital;
        remainingRevenue = parseFloat(RC.ManageSchemeExpenseBooking.STotalRevenue) - usedRevenue;
        remainingForeignFunding = parseFloat(RC.ManageSchemeExpenseBooking.STotalForeignFunding) - usedForeignFunding;

        if (ddlCTExpenseType.GetSelectedItem().value == RC.Common.SchemeFundType.CAPITAL) {
            if (RC.ManageSchemeExpenseBooking.EditMode) {
                remainingCapital += parseFloat(RC.ManageSchemeExpenseBooking.AmountForEditMode);
            }

            $('#dvManageSchemeExpenseBooking #dvSTotalAmount .number').html('Released Capital');
            $('#dvManageSchemeExpenseBooking #dvSTotalAmount .desc').html('Rs ' + remainingCapital);
        }
        else if (ddlCTExpenseType.GetSelectedItem().value == RC.Common.SchemeFundType.REVENUE) {
            if (RC.ManageSchemeExpenseBooking.EditMode) {
                remainingRevenue += parseFloat(RC.ManageSchemeExpenseBooking.AmountForEditMode);
            }

            $('#dvManageSchemeExpenseBooking #dvSTotalAmount .number').html('Released Revenue');
            $('#dvManageSchemeExpenseBooking #dvSTotalAmount .desc').html('Rs ' + remainingRevenue);
        }
        else if (ddlCTExpenseType.GetSelectedItem().value == RC.Common.SchemeFundType.FOREIGNFUNDING) {
            if (RC.ManageSchemeExpenseBooking.EditMode) {
                remainingForeignFunding += parseFloat(RC.ManageSchemeExpenseBooking.AmountForEditMode);
            }

            $('#dvManageSchemeExpenseBooking #dvSTotalAmount .number').html('Released Foreign Funding');
            $('#dvManageSchemeExpenseBooking #dvSTotalAmount .desc').html('Rs ' + remainingForeignFunding);
        }
    },
    ShowForeignFundingForScheme: function () {
        var isForeignFunding = (ddlScheme.GetSelectedItem().texts[3].toLowerCase() == 'true');

        ddlCTExpenseType.ClearItems();

        ddlCTExpenseType.AddItem(new Array("Revenue"), "2");
        ddlCTExpenseType.AddItem(new Array("Capital"), "1");

        if (isForeignFunding) {
            ddlCTExpenseType.AddItem(new Array("Foreign Funding"), "3");
        }

        ddlCTExpenseType.SetSelectedIndex(0);
    },
    SchemeExpenseBookingPayeeGet: function () {
        $.post(RC.ManageSchemeExpenseBooking.HandlerURL,
        {
            method: "SchemeExpenseBookingPayeeGet"
        },
        function (response) {
            switch (response.Status) {
                case RC.Common.ResponseStatus.SUCCESS:
                    RC.ManageSchemeExpenseBooking.PayeeList = JSON.parse(response.Data);

                    $("#dvManageSchemeExpenseBooking #txtPayee").autocomplete({
                        lookup: RC.ManageSchemeExpenseBooking.PayeeList
                    });

                    break;
                case RC.Common.ResponseStatus.ERROR:
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
    RC.ManageSchemeExpenseBooking.InitializePage();
    RC.ManageSchemeExpenseBooking.SchemeExpenseBookingPayeeGet();

    setTimeout(function () {
        RC.ManageSchemeExpenseBooking.ShowForeignFundingForScheme();
        RC.ManageSchemeExpenseBooking.SchemeFundReleaseTotalAmountGetSchemeId();
        RC.ManageSchemeExpenseBooking.SchemeFundReleaseSTotalAmountGetSchemeId();
    }, 1000);

    $('#txtAmount')
        .attr("data-a-sign", "Rs. ")
        .autoNumeric('init');

    $('#dvManageSchemeExpenseBooking #btnCancel').on('click', function () {
        window.location = RC.Common.RootURL + "Forms/frmExpesneBooking.aspx?LevelType=" + RC.Common.GetQueryStringByName('LevelType') + "&LevelID=" + RC.Common.GetQueryStringByName('LevelID');

        return false;
    });
});