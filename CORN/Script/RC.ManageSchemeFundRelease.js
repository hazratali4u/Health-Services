var RC = RC || {};

RC.ManageSchemeFundRelease = {
    HandlerURL: RC.Common.RootURL + "Handler/SchemeFundReleaseHandler.ashx",
    SchemeFundReleaseObject: null,
    DetailTableInitialized: false,
    TotalCapitalDetail: {},
    TotalRevenueDetail: {},
    TotalForeignFundingDetail: {},
    STotalCapitalDetail: {},
    STotalRevenueDetail: {},
    STotalForeignFundingDetail: {},
    TotalCapital: 0,
    TotalRevenue: 0,
    TotalForeignFunding: 0,
    STotalCapital: 0,
    STotalRevenue: 0,
    STotalForeignFunding: 0,
    EditMode: false,
    AmountForEditMode: 0,
    InitializePage: function () {
        if (RC.ManageSchemeFundRelease.SchemeFundReleaseObject != null) {
            if (RC.ManageSchemeFundRelease.SchemeFundReleaseObject.Id > 0) {
                $("#dvManageSchemeFundRelease #btnLoadAllocationData").hide();
            }

            $("#dvManageSchemeFundRelease #txtReleaseDate").val(RC.ManageSchemeFundRelease.SchemeFundReleaseObject.FrDateString);
            RC.ManageSchemeFundRelease.PopulateSchemeFundReleaseDetailList();
        }
        else {
            RC.ManageSchemeFundRelease.SchemeFundReleaseObject = { Id: 0, SchemeId: 0, FundReleaseTypeId: 0, FinancialYearId: 0, FrDate: '', SchemeFundReleaseDetailList: [] };
        }
    },
    PopulateSchemeFundReleaseDetailList: function () {
        RC.ManageSchemeFundRelease.LoadViewForType();

        if (RC.ManageSchemeFundRelease.SchemeFundReleaseObject.SchemeFundReleaseDetailList == null ||
            RC.ManageSchemeFundRelease.SchemeFundReleaseObject.SchemeFundReleaseDetailList == undefined) {
            RC.ManageSchemeFundRelease.SchemeFundReleaseObject.SchemeFundReleaseDetailList = [];
        }

        if (RC.ManageSchemeFundRelease.SchemeFundReleaseObject.SchemeFundReleaseDetailList != null && RC.ManageSchemeFundRelease.SchemeFundReleaseObject.SchemeFundReleaseDetailList != undefined && RC.ManageSchemeFundRelease.SchemeFundReleaseObject.SchemeFundReleaseDetailList.length > 0) {
            var lstSchemeFundReleaseDetail = RC.ManageSchemeFundRelease.GetSchemeFundReleaseDetailListForType();

            if (lstSchemeFundReleaseDetail.length > 0) {
                RC.ManageSchemeFundRelease.DetailTableInitialized = true;

                $('#dvManageSchemeFundRelease #tblSchemeFundReleaseDetailList').DataTable({
                    "data": lstSchemeFundReleaseDetail,
                    "columns": [
                        { "data": "COAName" },
                        {
                            data: "Amount",
                            className: "center",
                            render: function (data, type, full, meta) {
                                return RC.Common.FormatNumber(data);
                            }
                        },
                        {
                            data: "AllocatedAmount",
                            className: "center",
                            render: function (data, type, full, meta) {
                                return RC.Common.FormatNumber(data);
                            }
                        },
                        { "data": "Description" },
                        {
                            data: null,
                            className: "center",
                            render: function (row, type, val, meta) {
                                return "<center><a title='Edit' href='javascript:void(0)' onclick='RC.ManageSchemeFundRelease.SchemeFundReleaseDetailLoad(" + meta.row + ")'>" +
                                    "<i class='fa fa-pencil' aria-hidden='true'></i></a>&nbsp;" +
                                    "<a title='Delete' href='javascript:void(0)' onclick='RC.ManageSchemeFundRelease.SchemeFundReleaseDetailDelete(" + meta.row + ")'>" +
                                    "<i class='fa fa-trash-o' aria-hidden='true'></i></a></center>";
                            },
                            orderable: false,
                            defaultContent: ""
                        }
                    ],
                    "fnDrawCallback": function (oSettings) {
                        var lstSchemeFundReleaseDetail = RC.ManageSchemeFundRelease.GetSchemeFundReleaseDetailListForType();
                        var sum = 0;

                        if (lstSchemeFundReleaseDetail.length > 0) {
                            for (var i = 0; i < lstSchemeFundReleaseDetail.length; i++) {
                                sum += parseFloat(lstSchemeFundReleaseDetail[i].Amount);
                            }
                        }

                        $('#dvManageSchemeFundRelease #tblSchemeFundReleaseDetailList')
                            .find('tbody tr:last')
                            .after('<tr id="trTotal" role="row" class="odd"><td style="text-align: right; font-weight: bolder;">Total&nbsp;</td><td class=" center">' + RC.Common.FormatNumber(sum) + '</td><td colspan="3">&nbsp;</td></tr>');
                    }
                });
            }
        }
    },
    LoadViewForType: function () {
        $('#dvManageSchemeFundRelease #pnlSchemeFundReleaseDetail legend').text('Project Capital');

        if (RC.ManageSchemeFundRelease.GetTypeForSelectedView() == RC.Common.SchemeFundType.REVENUE) {
            $('#dvManageSchemeFundRelease #pnlSchemeFundReleaseDetail legend').text('Project Revenue');
        }
        else if (RC.ManageSchemeFundRelease.GetTypeForSelectedView() == RC.Common.SchemeFundType.FOREIGNFUNDING) {
            $('#dvManageSchemeFundRelease #pnlSchemeFundReleaseDetail legend').text('Project Foreign Funding');
        }
    },
    LoadSchemeFundReleaseDetailView: function () {
        if (RC.ManageSchemeFundRelease.DetailTableInitialized) {
            $('#dvManageSchemeFundRelease #tblSchemeFundReleaseDetailList').dataTable().fnClearTable();

            var lstSchemeFundReleaseDetail = RC.ManageSchemeFundRelease.GetSchemeFundReleaseDetailListForType();

            if (lstSchemeFundReleaseDetail.length > 0) {
                $('#dvManageSchemeFundRelease #tblSchemeFundReleaseDetailList').dataTable().fnAddData(lstSchemeFundReleaseDetail);
            }

            $('#dvManageSchemeFundRelease #tblSchemeFundReleaseDetailList').dataTable().fnDraw();

            if (lstSchemeFundReleaseDetail.length <= 0) {
                $('#trTotal').remove();
            }
        }
        else {
            RC.ManageSchemeFundRelease.PopulateSchemeFundReleaseDetailList();
        }

        RC.ManageSchemeFundRelease.LoadFundAllocationTotalAmountForType();
        RC.ManageSchemeFundRelease.LoadFundAllocationSTotalAmountForType();
    },
    GetTypeForSelectedView: function () {
        var typeId = RC.Common.SchemeFundType.CAPITAL;

        if ($('#dvManageSchemeFundRelease #btnRevenue').hasClass('btn-primary')) {
            typeId = RC.Common.SchemeFundType.REVENUE;
        }
        else if ($('#dvManageSchemeFundRelease #btnForeignFunding').hasClass('btn-primary')) {
            typeId = RC.Common.SchemeFundType.FOREIGNFUNDING;
        }

        return typeId;
    },
    GetSchemeFundReleaseDetailListForType: function () {
        var lstSchemeFundReleaseDetail = [];

        $(RC.ManageSchemeFundRelease.SchemeFundReleaseObject.SchemeFundReleaseDetailList).each(function (index, item) {
            if (item.TypeId == RC.ManageSchemeFundRelease.GetTypeForSelectedView()) {
                lstSchemeFundReleaseDetail.push(item);
            }
        });

        if (RC.ManageSchemeFundRelease.SchemeFundReleaseObject.SchemeFundReleaseDetailList.length > 0) {
            ddlCTScheme.SetEnabled(false);
        }
        else {
            ddlCTScheme.SetEnabled(true);
        }

        return lstSchemeFundReleaseDetail;
    },
    GetSchemeFundReleaseDetailIndexForType: function (fadIndex) {
        var fadDelIndex = -1;
        var idx = 0;

        $(RC.ManageSchemeFundRelease.SchemeFundReleaseObject.SchemeFundReleaseDetailList).each(function (index, item) {
            if (item.TypeId == RC.ManageSchemeFundRelease.GetTypeForSelectedView()) {
                if (fadIndex == idx) {
                    fadDelIndex = index;
                }

                idx++;
            }
        });

        return fadDelIndex;
    },
    SchemeFundReleaseDetailLoad: function (index) {
        var fadIndex = RC.ManageSchemeFundRelease.GetSchemeFundReleaseDetailIndexForType(index);
        var objSchemeFundReleaseDetail = RC.ManageSchemeFundRelease.SchemeFundReleaseObject.SchemeFundReleaseDetailList[fadIndex];

        if ($('#dvManageSchemeFundRelease #btnCapital').hasClass('btn-primary')) {
            ddlCTCOA.SetValue(objSchemeFundReleaseDetail.COAId);
        }
        else if ($('#dvManageSchemeFundRelease #btnRevenue').hasClass('btn-primary')) {
            ddlRCTCOA.SetValue(objSchemeFundReleaseDetail.COAId);
        }
        else if ($('#dvManageSchemeFundRelease #btnForeignFunding').hasClass('btn-primary')) {
            ddlFFCTCOA.SetValue(objSchemeFundReleaseDetail.COAId);
        }

        $("#dvManageSchemeFundRelease #txtAmount").autoNumeric('set', objSchemeFundReleaseDetail.Amount);
        $("#dvManageSchemeFundRelease #txtDescription").val(objSchemeFundReleaseDetail.Description);
        $("#dvManageSchemeFundRelease #btnSaveDetail")
            .attr('onclick', "RC.ManageSchemeFundRelease.SchemeFundReleaseDetailSave(" + index + ");")
            .val('Update');

        RC.ManageSchemeFundRelease.EditMode = true;
        RC.ManageSchemeFundRelease.AmountForEditMode = objSchemeFundReleaseDetail.Amount;

        RC.ManageSchemeFundRelease.SchemeFundAllocationTotalAmountGetSchemeId();
        RC.ManageSchemeFundRelease.LoadFundAllocationSTotalAmountForType();

        if ($('#dvManageSchemeFundRelease #btnCapital').hasClass('btn-primary')) {
            ddlCTCOA.SetEnabled(false);
        }
        else if ($('#dvManageSchemeFundRelease #btnRevenue').hasClass('btn-primary')) {
            ddlRCTCOA.SetEnabled(false);
        }
        else if ($('#dvManageSchemeFundRelease #btnForeignFunding').hasClass('btn-primary')) {
            ddlFFCTCOA.SetEnabled(false);
        }

        $("#dvManageSchemeFundRelease #btnCapital").attr('disabled', 'disabled');
        $("#dvManageSchemeFundRelease #btnRevenue").attr('disabled', 'disabled');
        $("#dvManageSchemeFundRelease #btnForeignFunding").attr('disabled', 'disabled');
    },
    SchemeFundReleaseDetailReset: function () {
        //ddlCTCOA.SetSelectedIndex(0);
        //ddlRCTCOA.SetSelectedIndex(0);
        RC.ManageSchemeFundRelease.EditMode = false;
        RC.ManageSchemeFundRelease.AmountForEditMode = 0;

        ddlRCTCOA.SetEnabled(true);
        ddlCTCOA.SetEnabled(true);

        $("#btnCapital").removeAttr('disabled');
        $("#btnRevenue").removeAttr('disabled');

        $("#dvManageSchemeFundRelease #txtAmount").autoNumeric('set', '');
        $("#dvManageSchemeFundRelease #txtDescription").val('');
        $("#dvManageSchemeFundRelease #btnSaveDetail")
            .attr('onclick', "RC.ManageSchemeFundRelease.SchemeFundReleaseDetailSave(-1);")
            .val('Add');
    },
    SchemeFundReleaseDetailSave: function (index) {
        var status = RC.ManageSchemeFundRelease.ValidateSchemeFundReleaseDetail();

        if (status) {
            if (index >= 0) {
                var fadIndex = RC.ManageSchemeFundRelease.GetSchemeFundReleaseDetailIndexForType(index);

                RC.ManageSchemeFundRelease.SchemeFundReleaseObject.SchemeFundReleaseDetailList.splice(fadIndex, 1);
            }

            var objSchemeFundReleaseDetail = { TypeId: 0, COAId: 0, COAName: '', AllocatedAmount: 0, Amount: 0, Description: '' };
            var typeId = 0;
            var coa = 0;
            var coaText = '';

            if ($('#dvManageSchemeFundRelease #btnCapital').hasClass('btn-primary')) {
                typeId = RC.Common.SchemeFundType.CAPITAL;
                coa = ddlCTCOA.GetSelectedItem().value;
                coaText = ddlCTCOA.GetSelectedItem().text;
            }
            else if ($('#dvManageSchemeFundRelease #btnRevenue').hasClass('btn-primary')) {
                typeId = RC.Common.SchemeFundType.REVENUE;
                coa = ddlRCTCOA.GetSelectedItem().value;
                coaText = ddlRCTCOA.GetSelectedItem().text;
            }
            else if ($('#dvManageSchemeFundRelease #btnForeignFunding').hasClass('btn-primary')) {
                typeId = RC.Common.SchemeFundType.FOREIGNFUNDING;
                coa = ddlFFCTCOA.GetSelectedItem().value;
                coaText = ddlFFCTCOA.GetSelectedItem().text;
            }

            objSchemeFundReleaseDetail.TypeId = typeId;
            objSchemeFundReleaseDetail.COAId = coa;
            objSchemeFundReleaseDetail.COAName = coaText;
            objSchemeFundReleaseDetail.AllocatedAmount = parseFloat($('#dvManageSchemeFundRelease #dvTotalAmount .desc').text().replace('Rs ', '').replace(/,/g, ''));
            objSchemeFundReleaseDetail.Amount = parseFloat($("#dvManageSchemeFundRelease #txtAmount").autoNumeric('get'));
            objSchemeFundReleaseDetail.Description = $("#dvManageSchemeFundRelease #txtDescription").val();

            RC.ManageSchemeFundRelease.SchemeFundReleaseObject.SchemeFundReleaseDetailList.push(objSchemeFundReleaseDetail);

            RC.ManageSchemeFundRelease.LoadSchemeFundReleaseDetailView();
            RC.ManageSchemeFundRelease.SchemeFundReleaseDetailReset();
            RC.ManageSchemeFundRelease.LoadFundAllocationTotalAmountForType();
            RC.ManageSchemeFundRelease.LoadFundAllocationSTotalAmountForType();
        }
    },
    SchemeFundReleaseDetailDelete: function (fadIndex) {
        var fadDelIndex = RC.ManageSchemeFundRelease.GetSchemeFundReleaseDetailIndexForType(fadIndex);

        RC.ManageSchemeFundRelease.SchemeFundReleaseObject.SchemeFundReleaseDetailList.splice(fadDelIndex, 1);

        RC.ManageSchemeFundRelease.LoadSchemeFundReleaseDetailView();
        RC.ManageSchemeFundRelease.SchemeFundReleaseDetailReset();
        RC.ManageSchemeFundRelease.LoadFundAllocationTotalAmountForType();
        RC.ManageSchemeFundRelease.LoadFundAllocationSTotalAmountForType();
    },
    ValidateSchemeFundRelease: function () {
        var status = true;

        if (ddlCTScheme.GetSelectedItem() == null) {
            alert("Please provide scheme.");

            status = false;
        }
        else if (ddlCTSchemeFY.GetSelectedItem() == null) {
            alert("Please provide financial year.");

            status = false;
        }
        else if ($.trim($("#dvManageSchemeFundRelease #txtReleaseDate").val()) == "") {
            alert("Please provide date.");

            status = false;
        }

        return status;
    },
    ValidateSchemeFundReleaseDetail: function () {
        var status = true, coaId = 0;

        if ($('#dvManageSchemeFundRelease #btnCapital').hasClass('btn-primary')) {
            if (ddlCTCOA.GetSelectedItem() == null) {
                alert("Please provide object code.");

                status = false;
            }
            else {
                coaId = ddlCTCOA.GetSelectedItem().value;
            }
        }
        else if ($('#dvManageSchemeFundRelease #btnRevenue').hasClass('btn-primary')) {
            if (ddlRCTCOA.GetSelectedItem() == null) {
                alert("Please provide object code.");

                status = false;
            }
            else {
                coaId = ddlRCTCOA.GetSelectedItem().value;
            }
        }
        else if ($('#dvManageSchemeFundRelease #btnForeignFunding').hasClass('btn-primary')) {
            if (ddlFFCTCOA.GetSelectedItem() == null) {
                alert("Please provide object code.");

                status = false;
            }
            else {
                coaId = ddlFFCTCOA.GetSelectedItem().value;
            }
        }

        if (status) {
            if ($.trim($("#dvManageSchemeFundRelease #txtAmount").autoNumeric('get')) == "") {
                alert("Please provide amount.");

                status = false;
            }

            var totalCapital = 0;
            var totalRevenue = 0;
            var totalForeignFunding = 0;

            $.each(RC.ManageSchemeFundRelease.SchemeFundReleaseObject.SchemeFundReleaseDetailList, function (index, obj) {
                if (obj.COAId == coaId) {
                    if (obj.TypeId == RC.Common.SchemeFundType.CAPITAL) {
                        totalCapital += obj.Amount;
                    }
                    else if (obj.TypeId == RC.Common.SchemeFundType.REVENUE) {
                        totalRevenue += obj.Amount;
                    }
                    else if (obj.TypeId == RC.Common.SchemeFundType.FOREIGNFUNDING) {
                        totalForeignFunding += obj.Amount;
                    }
                }
            });

            if (RC.ManageSchemeFundRelease.GetTypeForSelectedView() == RC.Common.SchemeFundType.CAPITAL) {
                var allowedCapital = parseFloat(RC.ManageSchemeFundRelease.TotalCapital) - totalCapital;

                if (RC.ManageSchemeFundRelease.EditMode) {
                    allowedCapital += parseFloat(RC.ManageSchemeFundRelease.AmountForEditMode);
                }

                if (parseFloat($("#dvManageSchemeFundRelease #txtAmount").autoNumeric('get')) > allowedCapital) {
                    alert("Allowed Capital is Rs " + allowedCapital + ".");

                    status = false;
                }
            }
            else if (RC.ManageSchemeFundRelease.GetTypeForSelectedView() == RC.Common.SchemeFundType.REVENUE) {
                var allowedRevenue = parseFloat(RC.ManageSchemeFundRelease.TotalRevenue) - totalRevenue;

                if (RC.ManageSchemeFundRelease.EditMode) {
                    allowedRevenue += parseFloat(RC.ManageSchemeFundRelease.AmountForEditMode);
                }

                if (parseFloat($("#dvManageSchemeFundRelease #txtAmount").autoNumeric('get')) > allowedRevenue) {
                    alert("Allowed Revenue is Rs " + allowedRevenue + ".");

                    status = false;
                }
            }
            else if (RC.ManageSchemeFundRelease.GetTypeForSelectedView() == RC.Common.SchemeFundType.FOREIGNFUNDING) {
                var totalForeignFunding = parseFloat(RC.ManageSchemeFundRelease.TotalForeignFunding) - totalForeignFunding;

                if (RC.ManageSchemeFundRelease.EditMode) {
                    totalForeignFunding += parseFloat(RC.ManageSchemeFundRelease.AmountForEditMode);
                }

                if (parseFloat($("#dvManageSchemeFundRelease #txtAmount").autoNumeric('get')) > totalForeignFunding) {
                    alert("Allowed Foreign Funding is Rs " + totalForeignFunding + ".");

                    status = false;
                }
            }
        }

        return status;
    },
    PopulateSchemeFundRelease: function () {
        var status = RC.ManageSchemeFundRelease.ValidateSchemeFundRelease();

        if (status) {
            var id = 0;

            if (RC.ManageSchemeFundRelease.SchemeFundReleaseObject != null) {
                id = RC.ManageSchemeFundRelease.SchemeFundReleaseObject.Id;
            }

            RC.ManageSchemeFundRelease.SchemeFundReleaseObject.Id = id;
            RC.ManageSchemeFundRelease.SchemeFundReleaseObject.SchemeId = ddlCTScheme.GetSelectedItem().value;
            RC.ManageSchemeFundRelease.SchemeFundReleaseObject.FundReleaseTypeId = 1;//ddlCTReleaseType.GetSelectedItem().value;
            RC.ManageSchemeFundRelease.SchemeFundReleaseObject.FinancialYearId = ddlCTSchemeFY.GetSelectedItem().value;
            RC.ManageSchemeFundRelease.SchemeFundReleaseObject.FrDate = $("#dvManageSchemeFundRelease #txtReleaseDate").val();

            var isForeignFunding = (ddlCTScheme.GetSelectedItem().texts[4].toLowerCase() == 'true');

            if (!isForeignFunding) {
                RC.ManageSchemeFundRelease.SchemeFundReleaseObject.SchemeFundReleaseDetailList = RC.ManageSchemeFundRelease.SchemeFundReleaseObject.SchemeFundReleaseDetailList.filter(p => parseInt(p.TypeId) !== 3);
            }
        }

        return status;
    },
    SaveSchemeFundRelease: function () {
        if (RC.ManageSchemeFundRelease.PopulateSchemeFundRelease()) {
            $('#dvManageSchemeFundRelease #btnSave').addClass("disabled").val('Wait...');

            RC.ManageSchemeFundRelease.AddUpdateSchemeFundRelease();
        }
    },
    AddUpdateSchemeFundRelease: function () {
        var handlerMethod = 'SchemeFundReleaseAdd';

        if (RC.ManageSchemeFundRelease.SchemeFundReleaseObject.Id > 0) {
            handlerMethod = 'SchemeFundReleaseUpdate';
        }

        $.post(RC.ManageSchemeFundRelease.HandlerURL,
        {
            method: handlerMethod,
            objSchemeFundRelease: JSON.stringify(RC.ManageSchemeFundRelease.SchemeFundReleaseObject)
        },
        function (response) {
            switch (response.Status) {
                case RC.Common.ResponseStatus.SUCCESS:
                    alert(response.Message);

                    $('#dvManageSchemeFundRelease #btnSave').val('Its done.');

                    window.location = RC.Common.RootURL + "Forms/frmSchemeFundReleases.aspx?LevelType=" + RC.Common.GetQueryStringByName('LevelType') + "&LevelID=" + RC.Common.GetQueryStringByName('LevelID');

                    break;
                case RC.Common.ResponseStatus.ERROR:
                    alert(response.Message);

                    $('#dvManageSchemeFundRelease #btnSave').removeClass("disabled").val('Save');

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
    LoadSchemeFundAllocationDetail: function () {
        $('#dvManageSchemeFundRelease #btnLoadAllocationData').addClass("disabled").val('Wait...');

        $.post(RC.ManageSchemeFundRelease.HandlerURL,
        {
            method: "SchemeFundAllocationGetSchemeId",
            SchemeId: ddlCTScheme.GetSelectedItem().value,
            FinancialYearId: ddlCTSchemeFY.GetSelectedItem().value
        },
        function (response) {
            $('#dvManageSchemeFundRelease #btnLoadAllocationData').removeClass("disabled").val('Load Data From Allocation Plan');

            switch (response.Status) {
                case RC.Common.ResponseStatus.SUCCESS:
                    $(response.Data).each(function (index, item) {
                        item.Date = '';
                        item.AllocatedAmount = item.Amount;
                    });

                    RC.ManageSchemeFundRelease.SchemeFundReleaseObject.SchemeFundReleaseDetailList = response.Data;

                    RC.ManageSchemeFundRelease.LoadSchemeFundReleaseDetailView();

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
    SchemeFundAllocationTotalAmountGetSchemeId: function () {
        $('#dvManageSchemeFundRelease #dvTotalAmount .number').html('<i class="fa fa-spinner fa-spin" aria-hidden="true"></i>');

        var coaId = 0;

        if ($('#dvManageSchemeFundRelease #btnCapital').hasClass('btn-primary')) {
            if (ddlCTCOA.GetSelectedItem() != null) {
                coaId = ddlCTCOA.GetSelectedItem().value;
            }
        }
        else if ($('#dvManageSchemeFundRelease #btnRevenue').hasClass('btn-primary')) {
            if (ddlRCTCOA.GetSelectedItem() != null) {
                coaId = ddlRCTCOA.GetSelectedItem().value;
            }
        }
        else if ($('#dvManageSchemeFundRelease #btnForeignFunding').hasClass('btn-primary')) {
            if (ddlFFCTCOA.GetSelectedItem() != null) {
                coaId = ddlFFCTCOA.GetSelectedItem().value;
            }
        }

        if (ddlCTSchemeFY.GetSelectedItem() != null) {
            $.post(RC.ManageSchemeFundRelease.HandlerURL,
            {
                method: "SchemeFundAllocationTotalAmountGetSchemeId",
                SchemeId: ddlCTScheme.GetSelectedItem().value,
                FinancialYearId: ddlCTSchemeFY.GetSelectedItem().value,
                COAId: coaId
            },
            function (response) {
                switch (response.Status) {
                    case RC.Common.ResponseStatus.SUCCESS:
                        RC.ManageSchemeFundRelease.TotalCapital = response.Data.TotalCapital;
                        RC.ManageSchemeFundRelease.TotalRevenue = response.Data.TotalRevenue;
                        RC.ManageSchemeFundRelease.TotalForeignFunding = response.Data.TotalForeignFunding;
                        RC.ManageSchemeFundRelease.TotalCapitalDetail = response.Data.TotalCapitalDetail;
                        RC.ManageSchemeFundRelease.TotalRevenueDetail = response.Data.TotalRevenueDetail;
                        RC.ManageSchemeFundRelease.TotalForeignFundingDetail = response.Data.TotalForeignFundingDetail;

                        RC.ManageSchemeFundRelease.LoadFundAllocationTotalAmountForType();

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
            RC.ManageSchemeFundRelease.TotalCapital = 0;
            RC.ManageSchemeFundRelease.TotalRevenue = 0;
            RC.ManageSchemeFundRelease.TotalForeignFunding = 0;

            RC.ManageSchemeFundRelease.LoadFundAllocationTotalAmountForType();
        }
    },
    LoadFundAllocationTotalAmountForType: function () {
        var usedCapital = 0, remainingCapital = 0, usedRevenue = 0, remainingRevenue = 0, usedForeignFunding = 0, remainingForeignFunding = 0, coaId = 0;

        if ($('#dvManageSchemeFundRelease #btnCapital').hasClass('btn-primary')) {
            if (ddlCTCOA.GetSelectedItem() != null) {
                coaId = ddlCTCOA.GetSelectedItem().value;
            }
        }
        else if ($('#dvManageSchemeFundRelease #btnRevenue').hasClass('btn-primary')) {
            if (ddlRCTCOA.GetSelectedItem() != null) {
                coaId = ddlRCTCOA.GetSelectedItem().value;
            }
        }
        else if ($('#dvManageSchemeFundRelease #btnForeignFunding').hasClass('btn-primary')) {
            if (ddlFFCTCOA.GetSelectedItem() != null) {
                coaId = ddlFFCTCOA.GetSelectedItem().value;
            }
        }

        $(RC.ManageSchemeFundRelease.SchemeFundReleaseObject.SchemeFundReleaseDetailList).each(function (index, item) {
            if (item.COAId == coaId) {
                if (item.TypeId == RC.Common.SchemeFundType.CAPITAL) {
                    usedCapital += parseFloat(item.Amount);
                }
                else if (item.TypeId == RC.Common.SchemeFundType.REVENUE) {
                    usedRevenue += parseFloat(item.Amount);
                }
                else if (item.TypeId == RC.Common.SchemeFundType.FOREIGNFUNDING) {
                    usedForeignFunding += parseFloat(item.Amount);
                }
            }
        });

        remainingCapital = parseFloat(RC.ManageSchemeFundRelease.TotalCapital) - usedCapital;
        remainingRevenue = parseFloat(RC.ManageSchemeFundRelease.TotalRevenue) - usedRevenue;
        remainingForeignFunding = parseFloat(RC.ManageSchemeFundRelease.TotalForeignFunding) - usedForeignFunding;

        if (RC.ManageSchemeFundRelease.GetTypeForSelectedView() == RC.Common.SchemeFundType.CAPITAL) {
            if (RC.ManageSchemeFundRelease.EditMode) {
                remainingCapital += parseFloat(RC.ManageSchemeFundRelease.AmountForEditMode);
            }

            $('#dvManageSchemeFundRelease #dvTotalAmount .number').html('Allocated Capital (Object Code)');
            $('#dvManageSchemeFundRelease #dvTotalAmount .desc').html('Rs ' + remainingCapital);
        }
        else if (RC.ManageSchemeFundRelease.GetTypeForSelectedView() == RC.Common.SchemeFundType.REVENUE) {
            if (RC.ManageSchemeFundRelease.EditMode) {
                remainingRevenue += parseFloat(RC.ManageSchemeFundRelease.AmountForEditMode);
            }

            $('#dvManageSchemeFundRelease #dvTotalAmount .number').html('Allocated Revenue (Object Code)');
            $('#dvManageSchemeFundRelease #dvTotalAmount .desc').html('Rs ' + remainingRevenue);
        }
        else if (RC.ManageSchemeFundRelease.GetTypeForSelectedView() == RC.Common.SchemeFundType.FOREIGNFUNDING) {
            if (RC.ManageSchemeFundRelease.EditMode) {
                remainingForeignFunding += parseFloat(RC.ManageSchemeFundRelease.AmountForEditMode);
            }

            $('#dvManageSchemeFundRelease #dvTotalAmount .number').html('Allocated Foreign Funding (Object Code)');
            $('#dvManageSchemeFundRelease #dvTotalAmount .desc').html('Rs ' + remainingForeignFunding);
        }

        RC.ManageSchemeFundRelease.SchemeFundAllocationTotalAmountDetail();
    },
    SchemeFundAllocationSTotalAmountGetSchemeId: function () {
        $('#dvManageSchemeFundRelease #dvSTotalAmount .number').html('<i class="fa fa-spinner fa-spin" aria-hidden="true"></i>');

        if (ddlCTSchemeFY.GetSelectedItem() != null) {
            $.post(RC.ManageSchemeFundRelease.HandlerURL,
            {
                method: "SchemeFundAllocationTotalAmountGetSchemeId",
                SchemeId: ddlCTScheme.GetSelectedItem().value,
                FinancialYearId: ddlCTSchemeFY.GetSelectedItem().value,
                COAId: 0
            },
            function (response) {
                switch (response.Status) {
                    case RC.Common.ResponseStatus.SUCCESS:
                        RC.ManageSchemeFundRelease.STotalCapital = response.Data.TotalCapital;
                        RC.ManageSchemeFundRelease.STotalRevenue = response.Data.TotalRevenue;
                        RC.ManageSchemeFundRelease.STotalForeignFunding = response.Data.TotalForeignFunding;
                        RC.ManageSchemeFundRelease.STotalCapitalDetail = response.Data.TotalCapitalDetail;
                        RC.ManageSchemeFundRelease.STotalRevenueDetail = response.Data.TotalRevenueDetail;
                        RC.ManageSchemeFundRelease.STotalForeignFundingDetail = response.Data.TotalForeignFundingDetail;

                        RC.ManageSchemeFundRelease.LoadFundAllocationSTotalAmountForType();

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
            RC.ManageSchemeFundRelease.STotalCapital = 0;
            RC.ManageSchemeFundRelease.STotalRevenue = 0;
            RC.ManageSchemeFundRelease.STotalForeignFunding = 0;

            RC.ManageSchemeFundRelease.LoadFundAllocationSTotalAmountForType();
        }
    },
    LoadFundAllocationSTotalAmountForType: function () {
        var usedCapital = 0, remainingCapital = 0, usedRevenue = 0, remainingRevenue = 0, usedForeignFunding = 0, remainingForeignFunding = 0;

        $(RC.ManageSchemeFundRelease.SchemeFundReleaseObject.SchemeFundReleaseDetailList).each(function (index, item) {
            if (item.TypeId == RC.Common.SchemeFundType.CAPITAL) {
                usedCapital += parseFloat(item.Amount);
            }
            else if (item.TypeId == RC.Common.SchemeFundType.REVENUE) {
                usedRevenue += parseFloat(item.Amount);
            }
            else if (item.TypeId == RC.Common.SchemeFundType.FOREIGNFUNDING) {
                usedForeignFunding += parseFloat(item.Amount);
            }
        });

        remainingCapital = parseFloat(RC.ManageSchemeFundRelease.STotalCapital) - usedCapital;
        remainingRevenue = parseFloat(RC.ManageSchemeFundRelease.STotalRevenue) - usedRevenue;
        remainingForeignFunding = parseFloat(RC.ManageSchemeFundRelease.STotalForeignFunding) - usedForeignFunding;

        if (RC.ManageSchemeFundRelease.GetTypeForSelectedView() == RC.Common.SchemeFundType.CAPITAL) {
            if (RC.ManageSchemeFundRelease.EditMode) {
                remainingCapital += parseFloat(RC.ManageSchemeFundRelease.AmountForEditMode);
            }

            $('#dvManageSchemeFundRelease #dvSTotalAmount .number').html('Allocated Capital');
            $('#dvManageSchemeFundRelease #dvSTotalAmount .desc').html('Rs ' + remainingCapital);
        }
        else if (RC.ManageSchemeFundRelease.GetTypeForSelectedView() == RC.Common.SchemeFundType.REVENUE) {
            if (RC.ManageSchemeFundRelease.EditMode) {
                remainingRevenue += parseFloat(RC.ManageSchemeFundRelease.AmountForEditMode);
            }

            $('#dvManageSchemeFundRelease #dvSTotalAmount .number').html('Allocated Revenue');
            $('#dvManageSchemeFundRelease #dvSTotalAmount .desc').html('Rs ' + remainingRevenue);
        }
        else if (RC.ManageSchemeFundRelease.GetTypeForSelectedView() == RC.Common.SchemeFundType.FOREIGNFUNDING) {
            if (RC.ManageSchemeFundRelease.EditMode) {
                remainingForeignFunding += parseFloat(RC.ManageSchemeFundRelease.AmountForEditMode);
            }

            $('#dvManageSchemeFundRelease #dvSTotalAmount .number').html('Allocated Foreign Funding');
            $('#dvManageSchemeFundRelease #dvSTotalAmount .desc').html('Rs ' + remainingForeignFunding);
        }

        RC.ManageSchemeFundRelease.SchemeFundAllocationSTotalAmountDetail();
    },
    ShowForeignFundingForScheme: function () {
        var isForeignFunding = (ddlCTScheme.GetSelectedItem().texts[4].toLowerCase() == 'true');

        if (isForeignFunding) {
            $('#dvManageSchemeFundRelease #btnForeignFunding').show();
        }
        else {
            $('#dvManageSchemeFundRelease #btnForeignFunding').hide();
        }
    },
    SchemeFundAllocationTotalAmountDetail: function (elem) {
        var totalAmount = "";

        if (RC.ManageSchemeFundRelease.GetTypeForSelectedView() == RC.Common.SchemeFundType.CAPITAL) {
            totalAmount = RC.ManageSchemeFundRelease.TotalCapitalDetail.FundAllocation + " + " +
                RC.ManageSchemeFundRelease.TotalCapitalDetail.Supplementary + " + " +
                RC.ManageSchemeFundRelease.TotalCapitalDetail.ReappropraionTo + " - " +
                RC.ManageSchemeFundRelease.TotalCapitalDetail.ReappropriationFrom + " - " +
                RC.ManageSchemeFundRelease.TotalCapitalDetail.Surrender + " + " +
                RC.ManageSchemeFundRelease.TotalCapitalDetail.Excess + " - " +
                RC.ManageSchemeFundRelease.TotalCapitalDetail.Release;
        }
        else if (RC.ManageSchemeFundRelease.GetTypeForSelectedView() == RC.Common.SchemeFundType.REVENUE) {
            totalAmount = RC.ManageSchemeFundRelease.TotalRevenueDetail.FundAllocation + " + " +
                RC.ManageSchemeFundRelease.TotalRevenueDetail.Supplementary + " + " +
                RC.ManageSchemeFundRelease.TotalRevenueDetail.ReappropraionTo + " - " +
                RC.ManageSchemeFundRelease.TotalRevenueDetail.ReappropriationFrom + " - " +
                RC.ManageSchemeFundRelease.TotalRevenueDetail.Surrender + " + " +
                RC.ManageSchemeFundRelease.TotalRevenueDetail.Excess + " - " +
                RC.ManageSchemeFundRelease.TotalRevenueDetail.Release;
        }
        else if (RC.ManageSchemeFundRelease.GetTypeForSelectedView() == RC.Common.SchemeFundType.FOREIGNFUNDING) {
            totalAmount = RC.ManageSchemeFundRelease.TotalForeignFundingDetail.FundAllocation + " + " +
                RC.ManageSchemeFundRelease.TotalForeignFundingDetail.Supplementary + " + " +
                RC.ManageSchemeFundRelease.TotalForeignFundingDetail.ReappropraionTo + " - " +
                RC.ManageSchemeFundRelease.TotalForeignFundingDetail.ReappropriationFrom + " - " +
                RC.ManageSchemeFundRelease.TotalForeignFundingDetail.Surrender + " + " +
                RC.ManageSchemeFundRelease.TotalForeignFundingDetail.Excess + " - " +
                RC.ManageSchemeFundRelease.TotalForeignFundingDetail.Release;
        }

        $('#dvTotalAmountDetail').webuiPopover('destroy');
        $('#dvTotalAmountDetail').webuiPopover({
            title: "Fund Allocation + Supplementary + Reappropraion (To) - Reappropriation (From) - Surrender + Excess - Already Released",
            content: totalAmount,
            trigger: 'hover'
        });
    },
    SchemeFundAllocationSTotalAmountDetail: function (elem) {
        var totalAmount = "";

        if (RC.ManageSchemeFundRelease.GetTypeForSelectedView() == RC.Common.SchemeFundType.CAPITAL) {
            totalAmount = RC.ManageSchemeFundRelease.STotalCapitalDetail.FundAllocation + " + " +
                RC.ManageSchemeFundRelease.STotalCapitalDetail.Supplementary + " + " +
                RC.ManageSchemeFundRelease.STotalCapitalDetail.ReappropraionTo + " - " +
                RC.ManageSchemeFundRelease.STotalCapitalDetail.ReappropriationFrom + " - " +
                RC.ManageSchemeFundRelease.STotalCapitalDetail.Surrender + " + " +
                RC.ManageSchemeFundRelease.STotalCapitalDetail.Excess + " - " +
                RC.ManageSchemeFundRelease.STotalCapitalDetail.Release;
        }
        else if (RC.ManageSchemeFundRelease.GetTypeForSelectedView() == RC.Common.SchemeFundType.REVENUE) {
            totalAmount = RC.ManageSchemeFundRelease.STotalRevenueDetail.FundAllocation + " + " +
                RC.ManageSchemeFundRelease.STotalRevenueDetail.Supplementary + " + " +
                RC.ManageSchemeFundRelease.STotalRevenueDetail.ReappropraionTo + " - " +
                RC.ManageSchemeFundRelease.STotalRevenueDetail.ReappropriationFrom + " - " +
                RC.ManageSchemeFundRelease.STotalRevenueDetail.Surrender + " + " +
                RC.ManageSchemeFundRelease.STotalRevenueDetail.Excess + " - " +
                RC.ManageSchemeFundRelease.STotalRevenueDetail.Release;
        }
        else if (RC.ManageSchemeFundRelease.GetTypeForSelectedView() == RC.Common.SchemeFundType.FOREIGNFUNDING) {
            totalAmount = RC.ManageSchemeFundRelease.STotalForeignFundingDetail.FundAllocation + " + " +
                RC.ManageSchemeFundRelease.STotalForeignFundingDetail.Supplementary + " + " +
                RC.ManageSchemeFundRelease.STotalForeignFundingDetail.ReappropraionTo + " - " +
                RC.ManageSchemeFundRelease.STotalForeignFundingDetail.ReappropriationFrom + " - " +
                RC.ManageSchemeFundRelease.STotalForeignFundingDetail.Surrender + " + " +
                RC.ManageSchemeFundRelease.STotalForeignFundingDetail.Excess + " - " +
                RC.ManageSchemeFundRelease.STotalForeignFundingDetail.Release;
        }

        $('#dvSTotalAmountDetail').webuiPopover('destroy');
        $('#dvSTotalAmountDetail').webuiPopover({
            title: "Fund Allocation + Supplementary + Reappropraion (To) - Reappropriation (From) - Surrender + Excess - Already Released",
            content: totalAmount,
            trigger: 'hover'
        });
    }
}

$(document).ready(function () {
    RC.ManageSchemeFundRelease.InitializePage();
    RC.ManageSchemeFundRelease.SchemeFundAllocationTotalAmountGetSchemeId();
    RC.ManageSchemeFundRelease.SchemeFundAllocationSTotalAmountGetSchemeId();
    RC.ManageSchemeFundRelease.ShowForeignFundingForScheme();

    $('#txtAmount')
        .attr("data-a-sign", "Rs. ")
        .autoNumeric('init');

    $("#btnCapital").click(function () {
        $("#btnCapital")
            .removeClass('btn btn-default')
            .removeClass('btn btn-primary')
            .addClass('btn btn-primary');

        $("#btnRevenue")
            .removeClass('btn btn-primary')
            .removeClass('btn btn-default')
            .removeClass('btn btn-primary')
            .addClass('btn btn-default');

        $("#btnForeignFunding")
            .removeClass('btn btn-primary')
            .removeClass('btn btn-default')
            .removeClass('btn btn-primary')
            .addClass('btn btn-default');

        $("#dvCOA").show();
        $("#dvRCOA").hide();
        $("#dvFFCOA").hide();

        RC.ManageSchemeFundRelease.LoadSchemeFundReleaseDetailView();
        RC.ManageSchemeFundRelease.SchemeFundAllocationTotalAmountGetSchemeId();
        RC.ManageSchemeFundRelease.LoadFundAllocationSTotalAmountForType();
    });
    $("#btnRevenue").click(function () {
        $("#btnRevenue")
            .removeClass('btn btn-default')
            .removeClass('btn btn-primary')
            .addClass('btn btn-primary');

        $("#btnCapital")
            .removeClass('btn btn-primary')
            .removeClass('btn btn-default')
            .removeClass('btn btn-primary')
            .addClass('btn btn-default');

        $("#btnForeignFunding")
            .removeClass('btn btn-primary')
            .removeClass('btn btn-default')
            .removeClass('btn btn-primary')
            .addClass('btn btn-default');

        $("#dvRCOA").show();
        $("#dvCOA").hide();
        $("#dvFFCOA").hide();

        RC.ManageSchemeFundRelease.LoadSchemeFundReleaseDetailView();
        RC.ManageSchemeFundRelease.SchemeFundAllocationTotalAmountGetSchemeId();
        RC.ManageSchemeFundRelease.LoadFundAllocationSTotalAmountForType();
    });
    $("#btnForeignFunding").click(function () {
        $("#btnForeignFunding")
            .removeClass('btn btn-default')
            .removeClass('btn btn-primary')
            .addClass('btn btn-primary');

        $("#btnCapital")
            .removeClass('btn btn-primary')
            .removeClass('btn btn-default')
            .removeClass('btn btn-primary')
            .addClass('btn btn-default');

        $("#btnRevenue")
            .removeClass('btn btn-primary')
            .removeClass('btn btn-default')
            .removeClass('btn btn-primary')
            .addClass('btn btn-default');

        $("#dvFFCOA").show();
        $("#dvCOA").hide();
        $("#dvRCOA").hide();

        RC.ManageSchemeFundRelease.LoadSchemeFundReleaseDetailView();
        RC.ManageSchemeFundRelease.SchemeFundAllocationTotalAmountGetSchemeId();
        RC.ManageSchemeFundRelease.LoadFundAllocationSTotalAmountForType();
    });
    $('#btnCancel').on('click', function () {
        window.location = RC.Common.RootURL + "Forms/frmSchemeFundReleases.aspx?LevelType=" + RC.Common.GetQueryStringByName('LevelType') + "&LevelID=" + RC.Common.GetQueryStringByName('LevelID');

        return false;
    });
});