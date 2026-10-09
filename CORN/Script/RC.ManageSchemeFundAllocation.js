var RC = RC || {};

RC.ManageSchemeFundAllocation = {
    HandlerURL: RC.Common.RootURL + "Handler/SchemeFundAllocationHandler.ashx",
    SchemeFundAllocationObject: null,
    DetailTableInitialized: false,
    TotalCapital: '',
    TotalRevenue: '',
    TotalForeignFunding: '',
    InitializePage: function () {
        if (RC.ManageSchemeFundAllocation.SchemeFundAllocationObject != null) {
            if (RC.ManageSchemeFundAllocation.SchemeFundAllocationObject.Id > 0) {
                $("#dvManageSchemeFundAllocation #btnLoadApprovalData").hide();
            }

            $("#dvManageSchemeFundAllocation #txtAllocationDate").val(RC.ManageSchemeFundAllocation.SchemeFundAllocationObject.FaDateString);
            RC.ManageSchemeFundAllocation.PopulateSchemeFundAllocationDetailList();
        }
        else {
            RC.ManageSchemeFundAllocation.SchemeFundAllocationObject = { Id: 0, SchemeId: 0, FundAllocationTypeId: 0, FinancialYearId: 0, FaDate: '', SchemeFundAllocationDetailList: [] };
        }
    },
    PopulateSchemeFundAllocationDetailList: function () {
        RC.ManageSchemeFundAllocation.LoadViewForType();

        if (RC.ManageSchemeFundAllocation.SchemeFundAllocationObject.SchemeFundAllocationDetailList == null ||
            RC.ManageSchemeFundAllocation.SchemeFundAllocationObject.SchemeFundAllocationDetailList == undefined) {
            RC.ManageSchemeFundAllocation.SchemeFundAllocationObject.SchemeFundAllocationDetailList = [];
        }

        if (RC.ManageSchemeFundAllocation.SchemeFundAllocationObject.SchemeFundAllocationDetailList != null && RC.ManageSchemeFundAllocation.SchemeFundAllocationObject.SchemeFundAllocationDetailList != undefined && RC.ManageSchemeFundAllocation.SchemeFundAllocationObject.SchemeFundAllocationDetailList.length > 0) {
            var lstSchemeFundAllocationDetail = RC.ManageSchemeFundAllocation.GetSchemeFundAllocationDetailListForType();

            if (lstSchemeFundAllocationDetail.length > 0) {
                RC.ManageSchemeFundAllocation.DetailTableInitialized = true;

                $('#dvManageSchemeFundAllocation #tblSchemeFundAllocationDetailList').DataTable({
                    "data": lstSchemeFundAllocationDetail,
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
                            data: "ApprovedAmount",
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
                                return "<center><a title='Edit' href='javascript:void(0)' onclick='RC.ManageSchemeFundAllocation.SchemeFundAllocationDetailLoad(" + meta.row + ")'>" +
                                    "<i class='fa fa-pencil' aria-hidden='true'></i></a>&nbsp;" +
                                    "<a title='Delete' href='javascript:void(0)' onclick='RC.ManageSchemeFundAllocation.SchemeFundAllocationDetailDelete(" + meta.row + ")'>" +
                                    "<i class='fa fa-trash-o' aria-hidden='true'></i></a></center>";
                            },
                            orderable: false,
                            defaultContent: ""
                        }
                    ],
                    "fnDrawCallback": function (oSettings) {
                        var lstSchemeFundAllocationDetail = RC.ManageSchemeFundAllocation.GetSchemeFundAllocationDetailListForType();
                        var sum = 0;

                        if (lstSchemeFundAllocationDetail.length > 0) {
                            for (var i = 0; i < lstSchemeFundAllocationDetail.length; i++) {
                                sum += parseFloat(lstSchemeFundAllocationDetail[i].Amount);
                            }
                        }

                        $('#dvManageSchemeFundAllocation #tblSchemeFundAllocationDetailList')
                            .find('tbody tr:last')
                            .after('<tr id="trTotal" role="row" class="odd"><td style="text-align: right; font-weight: bolder;">Total&nbsp;</td><td class=" center">' + RC.Common.FormatNumber(sum) + '</td><td colspan="3">&nbsp;</td></tr>');
                    }
                });
            }
        }
    },
    LoadViewForType: function () {
        $('#dvManageSchemeFundAllocation #pnlSchemeFundAllocationDetail legend').text('Project Capital');

        if (RC.ManageSchemeFundAllocation.GetTypeForSelectedView() == RC.Common.SchemeFundType.REVENUE) {
            $('#dvManageSchemeFundAllocation #pnlSchemeFundAllocationDetail legend').text('Project Revenue');
        }
        else if (RC.ManageSchemeFundAllocation.GetTypeForSelectedView() == RC.Common.SchemeFundType.FOREIGNFUNDING) {
            $('#dvManageSchemeFundAllocation #pnlSchemeFundAllocationDetail legend').text('Project Foreign Funding');
        }
    },
    LoadSchemeFundAllocationDetailView: function () {
        if (RC.ManageSchemeFundAllocation.DetailTableInitialized) {
            $('#dvManageSchemeFundAllocation #tblSchemeFundAllocationDetailList').dataTable().fnClearTable();

            var lstSchemeFundAllocationDetail = RC.ManageSchemeFundAllocation.GetSchemeFundAllocationDetailListForType();

            if (lstSchemeFundAllocationDetail.length > 0) {
                $('#dvManageSchemeFundAllocation #tblSchemeFundAllocationDetailList').dataTable().fnAddData(lstSchemeFundAllocationDetail);
            }

            $('#dvManageSchemeFundAllocation #tblSchemeFundAllocationDetailList').dataTable().fnDraw();

            if (lstSchemeFundAllocationDetail.length <= 0) {
                $('#trTotal').remove();
            }
        }
        else {
            RC.ManageSchemeFundAllocation.PopulateSchemeFundAllocationDetailList();
        }

        RC.ManageSchemeFundAllocation.LoadFundApprovalTotalAmountForType();
    },
    GetTypeForSelectedView: function () {
        var typeId = RC.Common.SchemeFundType.CAPITAL;

        if ($('#dvManageSchemeFundAllocation #btnRevenue').hasClass('btn-primary')) {
            typeId = RC.Common.SchemeFundType.REVENUE;
        }
        else if ($('#dvManageSchemeFundAllocation #btnForeignFunding').hasClass('btn-primary')) {
            typeId = RC.Common.SchemeFundType.FOREIGNFUNDING;
        }

        return typeId;
    },
    GetSchemeFundAllocationDetailListForType: function () {
        var lstSchemeFundAllocationDetail = [];

        $(RC.ManageSchemeFundAllocation.SchemeFundAllocationObject.SchemeFundAllocationDetailList).each(function (index, item) {
            if (item.TypeId == RC.ManageSchemeFundAllocation.GetTypeForSelectedView()) {
                lstSchemeFundAllocationDetail.push(item);
            }
        });

        return lstSchemeFundAllocationDetail
    },
    GetSchemeFundAllocationDetailIndexForType: function (fadIndex) {
        var fadDelIndex = -1;
        var idx = 0;

        $(RC.ManageSchemeFundAllocation.SchemeFundAllocationObject.SchemeFundAllocationDetailList).each(function (index, item) {
            if (item.TypeId == RC.ManageSchemeFundAllocation.GetTypeForSelectedView()) {
                if (fadIndex == idx) {
                    fadDelIndex = index;
                }

                idx++;
            }
        });

        return fadDelIndex;
    },
    SchemeFundAllocationDetailLoad: function (index) {
        var fadIndex = RC.ManageSchemeFundAllocation.GetSchemeFundAllocationDetailIndexForType(index);
        var objSchemeFundAllocationDetail = RC.ManageSchemeFundAllocation.SchemeFundAllocationObject.SchemeFundAllocationDetailList[fadIndex];

        if ($('#dvManageSchemeFundAllocation #btnCapital').hasClass('btn-primary')) {
            ddlCTCOA.SetValue(objSchemeFundAllocationDetail.COAId);
        }
        else if ($('#dvManageSchemeFundAllocation #btnRevenue').hasClass('btn-primary')) {
            ddlRCTCOA.SetValue(objSchemeFundAllocationDetail.COAId);
        }
        else if ($('#dvManageSchemeFundAllocation #btnForeignFunding').hasClass('btn-primary')) {
            ddlFFCTCOA.SetValue(objSchemeFundAllocationDetail.COAId);
        }

        $("#dvManageSchemeFundAllocation #txtAmount").autoNumeric('set', objSchemeFundAllocationDetail.Amount);
        $("#dvManageSchemeFundAllocation #txtDescription").val(objSchemeFundAllocationDetail.Description);
        $("#dvManageSchemeFundAllocation #btnSaveDetail")
            .attr('onclick', "RC.ManageSchemeFundAllocation.SchemeFundAllocationDetailSave(" + index + ");")
            .val('Update');
    },
    SchemeFundAllocationDetailReset: function () {
        //ddlCTCOA.SetSelectedIndex(0);
        //ddlRCTCOA.SetSelectedIndex(0);
        $("#dvManageSchemeFundAllocation #txtAmount").autoNumeric('set', '');
        $("#dvManageSchemeFundAllocation #txtDescription").val('');
        $("#dvManageSchemeFundAllocation #btnSaveDetail")
            .attr('onclick', "RC.ManageSchemeFundAllocation.SchemeFundAllocationDetailSave(-1);")
            .val('Add');
    },
    SchemeFundAllocationDetailSave: function (index) {
        var status = RC.ManageSchemeFundAllocation.ValidateSchemeFundAllocationDetail();

        if (status) {
            var objSchemeFundAllocationDetail = { TypeId: 0, COAId: 0, COAName: '', ApprovedAmount: 0, Amount: 0, Description: '' };
            var approvedAmount = parseFloat($('#dvManageSchemeFundAllocation #dvTotalAmount .desc').text().replace('Rs ', '').replace(/,/g, ''));
            var typeId = 0;
            var coa = 0;
            var coaText = '';

            if (index >= 0) {
                var fadIndex = RC.ManageSchemeFundAllocation.GetSchemeFundAllocationDetailIndexForType(index);
                var objSchemeFundAllocationDetail = RC.ManageSchemeFundAllocation.SchemeFundAllocationObject.SchemeFundAllocationDetailList[fadIndex];

                approvedAmount = parseFloat(objSchemeFundAllocationDetail.ApprovedAmount);
                RC.ManageSchemeFundAllocation.SchemeFundAllocationObject.SchemeFundAllocationDetailList.splice(fadIndex, 1);
            }

            if ($('#dvManageSchemeFundAllocation #btnCapital').hasClass('btn-primary')) {
                typeId = RC.Common.SchemeFundType.CAPITAL;
                coa = ddlCTCOA.GetSelectedItem().value;
                coaText = ddlCTCOA.GetSelectedItem().text;
            }
            else if ($('#dvManageSchemeFundAllocation #btnRevenue').hasClass('btn-primary')) {
                typeId = RC.Common.SchemeFundType.REVENUE;
                coa = ddlRCTCOA.GetSelectedItem().value;
                coaText = ddlRCTCOA.GetSelectedItem().text;
            }
            else if ($('#dvManageSchemeFundAllocation #btnForeignFunding').hasClass('btn-primary')) {
                typeId = RC.Common.SchemeFundType.FOREIGNFUNDING;
                coa = ddlFFCTCOA.GetSelectedItem().value;
                coaText = ddlFFCTCOA.GetSelectedItem().text;
            }

            objSchemeFundAllocationDetail.TypeId = typeId;
            objSchemeFundAllocationDetail.COAId = coa;
            objSchemeFundAllocationDetail.COAName = coaText;
            objSchemeFundAllocationDetail.ApprovedAmount = approvedAmount;
            objSchemeFundAllocationDetail.Amount = parseFloat($("#dvManageSchemeFundAllocation #txtAmount").autoNumeric('get'));
            objSchemeFundAllocationDetail.Description = $("#dvManageSchemeFundAllocation #txtDescription").val();

            RC.ManageSchemeFundAllocation.SchemeFundAllocationObject.SchemeFundAllocationDetailList.push(objSchemeFundAllocationDetail);

            RC.ManageSchemeFundAllocation.LoadSchemeFundAllocationDetailView();
            RC.ManageSchemeFundAllocation.SchemeFundAllocationDetailReset();
        }
    },
    SchemeFundAllocationDetailDelete: function (fadIndex) {
        var fadDelIndex = RC.ManageSchemeFundAllocation.GetSchemeFundAllocationDetailIndexForType(fadIndex);

        RC.ManageSchemeFundAllocation.SchemeFundAllocationObject.SchemeFundAllocationDetailList.splice(fadDelIndex, 1);

        RC.ManageSchemeFundAllocation.LoadSchemeFundAllocationDetailView();
    },
    ValidateSchemeFundAllocation: function () {
        var status = true;

        if (ddlCTScheme.GetSelectedItem() == null) {
            alert("Please provide scheme.");

            status = false;
        }
        else if (ddlCTSchemeFY.GetSelectedItem() == null) {
            alert("Please provide financial year.");

            status = false;
        }
        else if ($.trim($("#dvManageSchemeFundAllocation #txtAllocationDate").val()) == "") {
            alert("Please provide date.");

            status = false;
        }

        return status;
    },
    ValidateSchemeFundAllocationDetail: function () {
        var status = true;

        if ($('#dvManageSchemeFundAllocation #btnCapital').hasClass('btn-primary')) {
            if (ddlCTCOA.GetSelectedItem() == null) {
                alert("Please provide object code.");

                status = false;
            }
        }
        else if ($('#dvManageSchemeFundAllocation #btnRevenue').hasClass('btn-primary')) {
            if (ddlRCTCOA.GetSelectedItem() == null) {
                alert("Please provide object code.");

                status = false;
            }
        }
        else if ($('#dvManageSchemeFundAllocation #btnForeignFunding').hasClass('btn-primary')) {
            if (ddlFFCTCOA.GetSelectedItem() == null) {
                alert("Please provide object code.");

                status = false;
            }
        }

        if (status) {
            if ($.trim($("#dvManageSchemeFundAllocation #txtAmount").autoNumeric('get')) == "") {
                alert("Please provide amount.");

                status = false;
            }
        }

        return status;
    },
    ValidateSchemeFundApprovalDetail: function () {
        var status = true;

        if (ddlCTScheme.GetSelectedItem() == null) {
            alert("Please provide scheme.");

            status = false;
        }
        else if (ddlCTSchemeFY.GetSelectedItem() == null) {
            alert("Please provide financial year.");

            status = false;
        }

        return status;
    },
    PopulateSchemeFundAllocation: function () {
        var status = RC.ManageSchemeFundAllocation.ValidateSchemeFundAllocation();

        if (status) {
            var id = 0;

            if (RC.ManageSchemeFundAllocation.SchemeFundAllocationObject != null) {
                id = RC.ManageSchemeFundAllocation.SchemeFundAllocationObject.Id;
            }

            RC.ManageSchemeFundAllocation.SchemeFundAllocationObject.Id = id;
            RC.ManageSchemeFundAllocation.SchemeFundAllocationObject.SchemeId = ddlCTScheme.GetSelectedItem().value;
            RC.ManageSchemeFundAllocation.SchemeFundAllocationObject.FundAllocationTypeId = ddlCTAllocationType.GetSelectedItem().value;
            RC.ManageSchemeFundAllocation.SchemeFundAllocationObject.FinancialYearId = ddlCTSchemeFY.GetSelectedItem().value;
            RC.ManageSchemeFundAllocation.SchemeFundAllocationObject.FaDate = $("#dvManageSchemeFundAllocation #txtAllocationDate").val();

            var isForeignFunding = (ddlCTScheme.GetSelectedItem().texts[3].toLowerCase() == 'true');

            if (!isForeignFunding) {
                RC.ManageSchemeFundAllocation.SchemeFundAllocationObject.SchemeFundAllocationDetailList = RC.ManageSchemeFundAllocation.SchemeFundAllocationObject.SchemeFundAllocationDetailList.filter(p => parseInt(p.TypeId) !== 3);
            }
        }

        return status;
    },
    SaveSchemeFundAllocation: function () {
        if (RC.ManageSchemeFundAllocation.PopulateSchemeFundAllocation()) {
            $('#dvManageSchemeFundAllocation #btnSave').addClass("disabled").val('Wait...');

            RC.ManageSchemeFundAllocation.AddUpdateSchemeFundAllocation();
        }
    },
    AddUpdateSchemeFundAllocation: function () {
        var handlerMethod = 'SchemeFundAllocationAdd';

        if (RC.ManageSchemeFundAllocation.SchemeFundAllocationObject.Id > 0) {
            handlerMethod = 'SchemeFundAllocationUpdate';
        }

        $.post(RC.ManageSchemeFundAllocation.HandlerURL,
        {
            method: handlerMethod,
            objSchemeFundAllocation: JSON.stringify(RC.ManageSchemeFundAllocation.SchemeFundAllocationObject)
        },
        function (response) {
            switch (response.Status) {
                case RC.Common.ResponseStatus.SUCCESS:
                    alert(response.Message);

                    $('#dvManageSchemeFundAllocation #btnSave').val('Its done.');

                    window.location = RC.Common.RootURL + "Forms/frmSchemeFundAllocations.aspx?LevelType=" + RC.Common.GetQueryStringByName('LevelType') + "&LevelID=" + RC.Common.GetQueryStringByName('LevelID');

                    break;
                case RC.Common.ResponseStatus.ERROR:
                    alert(response.Message);

                    $('#dvManageSchemeFundAllocation #btnSave').removeClass("disabled").val('Save');

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
    LoadSchemeFundApprovalDetail: function () {
        var status = RC.ManageSchemeFundAllocation.ValidateSchemeFundApprovalDetail();

        if (status) {
            $('#dvManageSchemeFundAllocation #btnLoadApprovalData').addClass("disabled").val('Wait...');

            $.post(RC.ManageSchemeFundAllocation.HandlerURL,
            {
                method: "SchemeFundApprovalGetSchemeId",
                SchemeId: ddlCTScheme.GetSelectedItem().value,
                FinancialYearId: ddlCTSchemeFY.GetSelectedItem().value
            },
            function (response) {
                $('#dvManageSchemeFundAllocation #btnLoadApprovalData').removeClass("disabled").val('Load Data From Approval Plan');

                switch (response.Status) {
                    case RC.Common.ResponseStatus.SUCCESS:
                        $(response.Data).each(function (index, item) {
                            item.Date = '';
                            item.ApprovedAmount = item.Amount;
                        });

                        RC.ManageSchemeFundAllocation.SchemeFundAllocationObject.SchemeFundAllocationDetailList = response.Data;

                        RC.ManageSchemeFundAllocation.LoadSchemeFundAllocationDetailView();

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
    },
    SchemeFundApprovalTotalAmountGetSchemeId: function () {
        $('#dvManageSchemeFundAllocation #dvTotalAmount .number').html('<i class="fa fa-spinner fa-spin" aria-hidden="true"></i>');

        var coaId = 0;

        if ($('#dvManageSchemeFundAllocation #btnCapital').hasClass('btn-primary')) {
            if (ddlCTCOA.GetSelectedItem() != null) {
                coaId = ddlCTCOA.GetSelectedItem().value;
            }
        }
        else if ($('#dvManageSchemeFundAllocation #btnRevenue').hasClass('btn-primary')) {
            if (ddlRCTCOA.GetSelectedItem() != null) {
                coaId = ddlRCTCOA.GetSelectedItem().value;
            }
        }
        else if ($('#dvManageSchemeFundAllocation #btnForeignFunding').hasClass('btn-primary')) {
            if (ddlFFCTCOA.GetSelectedItem() != null) {
                coaId = ddlFFCTCOA.GetSelectedItem().value;
            }
        }

        if (ddlCTSchemeFY.GetSelectedItem() != null && coaId > 0) {
            $.post(RC.ManageSchemeFundAllocation.HandlerURL,
            {
                method: "SchemeFundApprovalTotalAmountGetSchemeId",
                SchemeId: ddlCTScheme.GetSelectedItem().value,
                FinancialYearId: ddlCTSchemeFY.GetSelectedItem().value,
                COAId: coaId
            },
            function (response) {
                switch (response.Status) {
                    case RC.Common.ResponseStatus.SUCCESS:
                        RC.ManageSchemeFundAllocation.TotalCapital = response.Data.TotalCapital;
                        RC.ManageSchemeFundAllocation.TotalRevenue = response.Data.TotalRevenue;
                        RC.ManageSchemeFundAllocation.TotalForeignFunding = response.Data.TotalForeignFunding;

                        RC.ManageSchemeFundAllocation.LoadFundApprovalTotalAmountForType();

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
            RC.ManageSchemeFundAllocation.TotalCapital = 'Rs 0.00';
            RC.ManageSchemeFundAllocation.TotalRevenue = 'Rs 0.00';
            RC.ManageSchemeFundAllocation.TotalForeignFunding = 'Rs 0.00';

            RC.ManageSchemeFundAllocation.LoadFundApprovalTotalAmountForType();
        }
    },
    LoadFundApprovalTotalAmountForType: function () {
        if (RC.ManageSchemeFundAllocation.GetTypeForSelectedView() == RC.Common.SchemeFundType.CAPITAL) {
            $('#dvManageSchemeFundAllocation #dvTotalAmount .number').html('Approved Capital');
            $('#dvManageSchemeFundAllocation #dvTotalAmount .desc').html(RC.ManageSchemeFundAllocation.TotalCapital);
        }
        else if (RC.ManageSchemeFundAllocation.GetTypeForSelectedView() == RC.Common.SchemeFundType.REVENUE) {
            $('#dvManageSchemeFundAllocation #dvTotalAmount .number').html('Approved Revenue');
            $('#dvManageSchemeFundAllocation #dvTotalAmount .desc').html(RC.ManageSchemeFundAllocation.TotalRevenue);
        }
        else if (RC.ManageSchemeFundAllocation.GetTypeForSelectedView() == RC.Common.SchemeFundType.FOREIGNFUNDING) {
            $('#dvManageSchemeFundAllocation #dvTotalAmount .number').html('Approved Foreign Funding');
            $('#dvManageSchemeFundAllocation #dvTotalAmount .desc').html(RC.ManageSchemeFundAllocation.TotalForeignFunding);
        }
    },
    ShowForeignFundingForScheme: function () {
        var isForeignFunding = (ddlCTScheme.GetSelectedItem().texts[3].toLowerCase() == 'true');

        if (isForeignFunding) {
            $('#dvManageSchemeFundAllocation #btnForeignFunding').show();
        }
        else {
            $('#dvManageSchemeFundAllocation #btnForeignFunding').hide();
        }
    }
}

$(document).ready(function () {
    RC.ManageSchemeFundAllocation.InitializePage();
    RC.ManageSchemeFundAllocation.SchemeFundApprovalTotalAmountGetSchemeId();
    RC.ManageSchemeFundAllocation.ShowForeignFundingForScheme();

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

        RC.ManageSchemeFundAllocation.LoadSchemeFundAllocationDetailView();
        RC.ManageSchemeFundAllocation.SchemeFundApprovalTotalAmountGetSchemeId();
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

        RC.ManageSchemeFundAllocation.LoadSchemeFundAllocationDetailView();
        RC.ManageSchemeFundAllocation.SchemeFundApprovalTotalAmountGetSchemeId();
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

        RC.ManageSchemeFundAllocation.LoadSchemeFundAllocationDetailView();
        RC.ManageSchemeFundAllocation.SchemeFundApprovalTotalAmountGetSchemeId();
    });
    $('#btnCancel').on('click', function () {
        window.location = RC.Common.RootURL + "Forms/frmSchemeFundAllocations.aspx?LevelType=" + RC.Common.GetQueryStringByName('LevelType') + "&LevelID=" + RC.Common.GetQueryStringByName('LevelID');

        return false;
    });
});