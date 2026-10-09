var RC = RC || {};

RC.ManageSchemeFundProposal = {
    HandlerURL: RC.Common.RootURL + "Handler/SchemeFundProposalHandler.ashx",
    SchemeFundProposalObject: null,
    DetailTableInitialized: false,
    InitializePage: function () {
        if (RC.ManageSchemeFundProposal.SchemeFundProposalObject != null) {
            //if (RC.ManageSchemeFundProposal.SchemeFundProposalObject.lngPlanCode > 0) {
            //    $("#dvManageSchemeFundProposal #btnLoadProposedData").hide();
            //}

            $("#dvManageSchemeFundProposal #txtProposedDate").val(RC.ManageSchemeFundProposal.SchemeFundProposalObject.dtmProposedDateString);
            RC.ManageSchemeFundProposal.PopulateSchemeFundProposalDetailList();
        }
        else {
            RC.ManageSchemeFundProposal.SchemeFundProposalObject = { lngPlanCode: 0, lngSchemeID: 0, dtmProposedDate: '', SchemeFundProposalDetailList: [] };
        }

        RC.ManageSchemeFundProposal.LoadTotalAmountForType();
    },
    GetAmountForType: function (objSchemeFundProposalDetail) {
        var amount = 0;

        switch (objSchemeFundProposalDetail.intCostTypeId) {
            case 1:
                amount = objSchemeFundProposalDetail.decCostCapital;

                break;
            case 2:
                amount = objSchemeFundProposalDetail.decCostRevenue;

                break;
            case 3:
                amount = objSchemeFundProposalDetail.decCostForeignFunding;

                break;
        }

        return amount;
    },
    PopulateSchemeFundProposalDetailList: function () {
        RC.ManageSchemeFundProposal.LoadViewForType();

        if (RC.ManageSchemeFundProposal.SchemeFundProposalObject.SchemeFundProposalDetailList == null ||
            RC.ManageSchemeFundProposal.SchemeFundProposalObject.SchemeFundProposalDetailList == undefined) {
            RC.ManageSchemeFundProposal.SchemeFundProposalObject.SchemeFundProposalDetailList = [];
        }

        if (RC.ManageSchemeFundProposal.SchemeFundProposalObject.SchemeFundProposalDetailList != null && RC.ManageSchemeFundProposal.SchemeFundProposalObject.SchemeFundProposalDetailList != undefined && RC.ManageSchemeFundProposal.SchemeFundProposalObject.SchemeFundProposalDetailList.length > 0) {
            var lstSchemeFundProposalDetail = RC.ManageSchemeFundProposal.GetSchemeFundProposalDetailListForType();

            if (lstSchemeFundProposalDetail.length > 0) {
                RC.ManageSchemeFundProposal.DetailTableInitialized = true;

                $('#dvManageSchemeFundProposal #tblSchemeFundProposalDetailList').DataTable({
                    "data": lstSchemeFundProposalDetail,
                    "columns": [
                        {
                            data: "YearName",
                            className: "center"
                        },
                        { "data": "COAName" },
                        {
                            data: null,
                            className: "center",
                            render: function (row, type, full, meta) {
                                var amount = RC.ManageSchemeFundProposal.GetAmountForType(row);

                                return RC.Common.FormatNumber(amount);
                            }
                        },
                        { "data": "strDescription" },
                        {
                            data: null,
                            className: "center",
                            render: function (row, type, val, meta) {
                                return "<center><a title='Edit' href='javascript:void(0)' onclick='RC.ManageSchemeFundProposal.SchemeFundProposalDetailLoad(" + meta.row + ")'>" +
                                    "<i class='fa fa-pencil' aria-hidden='true'></i></a>&nbsp;" +
                                    "<a title='Delete' href='javascript:void(0)' onclick='RC.ManageSchemeFundProposal.SchemeFundProposalDetailDelete(" + meta.row + ")'>" +
                                    "<i class='fa fa-trash-o' aria-hidden='true'></i></a></center>";
                            },
                            orderable: false,
                            defaultContent: ""
                        }
                    ],
                    "fnDrawCallback": function (oSettings) {
                        var lstSchemeFundProposalDetail = RC.ManageSchemeFundProposal.GetSchemeFundProposalDetailListForType();
                        var sum = 0;

                        if (lstSchemeFundProposalDetail.length > 0) {
                            for (var i = 0; i < lstSchemeFundProposalDetail.length; i++) {
                                sum += parseFloat(RC.ManageSchemeFundProposal.GetAmountForType(lstSchemeFundProposalDetail[i]));
                            }
                        }

                        $('#dvManageSchemeFundProposal #tblSchemeFundProposalDetailList')
                            .find('tbody tr:last')
                            .after('<tr id="trTotal" role="row" class="odd"><td colspan="2" style="text-align: right; font-weight: bolder;">Total&nbsp;</td><td class=" center">' + RC.Common.FormatNumber(sum) + '</td><td colspan="2">&nbsp;</td></tr>');
                    }
                });
            }
        }
    },
    LoadViewForType: function () {
        $('#dvManageSchemeFundProposal #pnlSchemeFundProposalDetail legend').text('Project Capital');

        if (RC.ManageSchemeFundProposal.GetTypeForSelectedView() == RC.Common.SchemeFundType.REVENUE) {
            $('#dvManageSchemeFundProposal #pnlSchemeFundProposalDetail legend').text('Project Revenue');
        }
        else if (RC.ManageSchemeFundProposal.GetTypeForSelectedView() == RC.Common.SchemeFundType.FOREIGNFUNDING) {
            $('#dvManageSchemeFundProposal #pnlSchemeFundProposalDetail legend').text('Project Foreign Funding');
        }
    },
    LoadSchemeFundProposalDetailView: function () {
        if (RC.ManageSchemeFundProposal.DetailTableInitialized) {
            $('#dvManageSchemeFundProposal #tblSchemeFundProposalDetailList').dataTable().fnClearTable();

            var lstSchemeFundProposalDetail = RC.ManageSchemeFundProposal.GetSchemeFundProposalDetailListForType();

            if (lstSchemeFundProposalDetail.length > 0) {
                $('#dvManageSchemeFundProposal #tblSchemeFundProposalDetailList').dataTable().fnAddData(lstSchemeFundProposalDetail);
            }

            $('#dvManageSchemeFundProposal #tblSchemeFundProposalDetailList').dataTable().fnDraw();

            if (lstSchemeFundProposalDetail.length <= 0) {
                $('#trTotal').remove();
            }
        }
        else {
            RC.ManageSchemeFundProposal.PopulateSchemeFundProposalDetailList();
        }

        RC.ManageSchemeFundProposal.LoadTotalAmountForType();
    },
    GetTypeForSelectedView: function () {
        var typeId = RC.Common.SchemeFundType.CAPITAL;

        if ($('#dvManageSchemeFundProposal #btnRevenue').hasClass('btn-primary')) {
            typeId = RC.Common.SchemeFundType.REVENUE;
        }
        else if ($('#dvManageSchemeFundProposal #btnForeignFunding').hasClass('btn-primary')) {
            typeId = RC.Common.SchemeFundType.FOREIGNFUNDING;
        }

        return typeId;
    },
    GetSchemeFundProposalDetailListForType: function () {
        var lstSchemeFundProposalDetail = [];

        $(RC.ManageSchemeFundProposal.SchemeFundProposalObject.SchemeFundProposalDetailList).each(function (index, item) {
            if (item.intCostTypeId == RC.ManageSchemeFundProposal.GetTypeForSelectedView()) {
                lstSchemeFundProposalDetail.push(item);
            }
        });

        return lstSchemeFundProposalDetail;
    },
    GetSchemeFundProposalDetailIndexForType: function (fadIndex) {
        var fadDelIndex = -1;
        var idx = 0;

        $(RC.ManageSchemeFundProposal.SchemeFundProposalObject.SchemeFundProposalDetailList).each(function (index, item) {
            if (item.intCostTypeId == RC.ManageSchemeFundProposal.GetTypeForSelectedView()) {
                if (fadIndex == idx) {
                    fadDelIndex = index;
                }

                idx++;
            }
        });

        return fadDelIndex;
    },
    SchemeFundProposalDetailLoad: function (index) {
        var fadIndex = RC.ManageSchemeFundProposal.GetSchemeFundProposalDetailIndexForType(index);
        var objSchemeFundProposalDetail = RC.ManageSchemeFundProposal.SchemeFundProposalObject.SchemeFundProposalDetailList[fadIndex];

        if ($('#dvManageSchemeFundProposal #btnCapital').hasClass('btn-primary')) {
            ddlCTCOA.SetValue(objSchemeFundProposalDetail.intAccountHeadID);
        }
        else if ($('#dvManageSchemeFundProposal #btnRevenue').hasClass('btn-primary')) {
            ddlRCTCOA.SetValue(objSchemeFundProposalDetail.intAccountHeadID);
        }
        else if ($('#dvManageSchemeFundProposal #btnForeignFunding').hasClass('btn-primary')) {
            ddlFFCTCOA.SetValue(objSchemeFundProposalDetail.intAccountHeadID);
        }

        ddlCTFY.SetValue(objSchemeFundProposalDetail.intFYID);
        $("#dvManageSchemeFundProposal #txtAmount").autoNumeric('set', RC.ManageSchemeFundProposal.GetAmountForType(objSchemeFundProposalDetail));
        $("#dvManageSchemeFundProposal #txtDescription").val(objSchemeFundProposalDetail.strDescription);
        $("#dvManageSchemeFundProposal #btnSaveDetail")
            .attr('onclick', "RC.ManageSchemeFundProposal.SchemeFundProposalDetailSave(" + index + ");")
            .val('Update');
    },
    SchemeFundProposalDetailReset: function () {
        //ddlCTFY.SetSelectedIndex(0);
        //ddlCTCOA.SetSelectedIndex(0);
        //ddlRCTCOA.SetSelectedIndex(0);
        $("#dvManageSchemeFundProposal #txtAmount").autoNumeric('set', '');
        $("#dvManageSchemeFundProposal #txtDescription").val('');
        $("#dvManageSchemeFundProposal #btnSaveDetail")
            .attr('onclick', "RC.ManageSchemeFundProposal.SchemeFundProposalDetailSave(-1);")
            .val('Add');
    },
    SchemeFundProposalDetailSave: function (index) {
        var status = RC.ManageSchemeFundProposal.ValidateSchemeFundProposalDetail(index);

        if (status) {
            if (index >= 0) {
                var fadIndex = RC.ManageSchemeFundProposal.GetSchemeFundProposalDetailIndexForType(index);

                RC.ManageSchemeFundProposal.SchemeFundProposalObject.SchemeFundProposalDetailList.splice(fadIndex, 1);
            }

            var objSchemeFundProposalDetail = { intCostTypeId: 0, intFYID: 0, YearName: '', intAccountHeadID: 0, COAName: '', decCostCapital: 0, decCostRevenue: 0, decCostForeignFunding: 0, strDescription: '' };
            var typeId = 0;
            var coaId = 0;
            var coaText = '';

            if ($('#dvManageSchemeFundProposal #btnCapital').hasClass('btn-primary')) {
                typeId = RC.Common.SchemeFundType.CAPITAL;
                coaId = ddlCTCOA.GetSelectedItem().value;
                coaText = ddlCTCOA.GetSelectedItem().text;
            }
            else if ($('#dvManageSchemeFundProposal #btnRevenue').hasClass('btn-primary')) {
                typeId = RC.Common.SchemeFundType.REVENUE;
                coaId = ddlRCTCOA.GetSelectedItem().value;
                coaText = ddlRCTCOA.GetSelectedItem().text;
            }
            else if ($('#dvManageSchemeFundProposal #btnForeignFunding').hasClass('btn-primary')) {
                typeId = RC.Common.SchemeFundType.FOREIGNFUNDING;
                coaId = ddlFFCTCOA.GetSelectedItem().value;
                coaText = ddlFFCTCOA.GetSelectedItem().text;
            }

            objSchemeFundProposalDetail.intCostTypeId = typeId;
            objSchemeFundProposalDetail.intFYID = ddlCTFY.GetSelectedItem().value;
            objSchemeFundProposalDetail.YearName = ddlCTFY.GetSelectedItem().text;
            objSchemeFundProposalDetail.intAccountHeadID = coaId;
            objSchemeFundProposalDetail.COAName = coaText;
            objSchemeFundProposalDetail.strDescription = $("#dvManageSchemeFundProposal #txtDescription").val();

            switch (objSchemeFundProposalDetail.intCostTypeId) {
                case 1:
                    objSchemeFundProposalDetail.decCostCapital = parseFloat($("#dvManageSchemeFundProposal #txtAmount").autoNumeric('get'));

                    break;
                case 2:
                    objSchemeFundProposalDetail.decCostRevenue = parseFloat($("#dvManageSchemeFundProposal #txtAmount").autoNumeric('get'));

                    break;
                case 3:
                    objSchemeFundProposalDetail.decCostForeignFunding = parseFloat($("#dvManageSchemeFundProposal #txtAmount").autoNumeric('get'));

                    break;
            }

            RC.ManageSchemeFundProposal.SchemeFundProposalObject.SchemeFundProposalDetailList.push(objSchemeFundProposalDetail);

            RC.ManageSchemeFundProposal.LoadSchemeFundProposalDetailView();
            RC.ManageSchemeFundProposal.SchemeFundProposalDetailReset();
        }
    },
    SchemeFundProposalDetailDelete: function (fadIndex) {
        var fadDelIndex = RC.ManageSchemeFundProposal.GetSchemeFundProposalDetailIndexForType(fadIndex);

        RC.ManageSchemeFundProposal.SchemeFundProposalObject.SchemeFundProposalDetailList.splice(fadDelIndex, 1);

        RC.ManageSchemeFundProposal.LoadSchemeFundProposalDetailView();
    },
    ValidateSchemeFundProposal: function () {
        var status = true;

        if (ddlCTScheme.GetSelectedItem() == null) {
            alert("Please provide scheme.");

            status = false;
        }
        else if ($.trim($("#dvManageSchemeFundProposal #txtProposedDate").val()) == "") {
            alert("Please provide proposed date.");

            status = false;
        }

        return status;
    },
    ValidateSchemeFundProposalDetail: function (idx) {
        var fadIndex = RC.ManageSchemeFundProposal.GetSchemeFundProposalDetailIndexForType(idx);
        var typeId = 0;
        var status = true;
        var coaId = 0, fYId = 0;

        if (ddlCTFY.GetSelectedItem() == null) {
            alert("Please provide financial year.");

            status = false;
        }
        else if ($('#dvManageSchemeFundProposal #btnCapital').hasClass('btn-primary')) {
            typeId = RC.Common.SchemeFundType.CAPITAL;

            if (ddlCTCOA.GetSelectedItem() == null) {
                alert("Please provide object code.");

                status = false;
            }
            else {
                coaId = ddlCTCOA.GetSelectedItem().value;
            }
        }
        else if ($('#dvManageSchemeFundProposal #btnRevenue').hasClass('btn-primary')) {
            typeId = RC.Common.SchemeFundType.REVENUE;

            if (ddlRCTCOA.GetSelectedItem() == null) {
                alert("Please provide object code.");

                status = false;
            }
            else {
                coaId = ddlRCTCOA.GetSelectedItem().value;
            }
        }
        else if ($('#dvManageSchemeFundProposal #btnForeignFunding').hasClass('btn-primary')) {
            typeId = RC.Common.SchemeFundType.FOREIGNFUNDING;

            if (ddlFFCTCOA.GetSelectedItem() == null) {
                alert("Please provide object code.");

                status = false;
            }
            else {
                coaId = ddlFFCTCOA.GetSelectedItem().value;
            }
        }

        if (status) {
            if ($.trim($("#dvManageSchemeFundProposal #txtAmount").autoNumeric('get')) == "") {
                alert("Please provide amount.");

                status = false;
            }
            else {
                fYId = ddlCTFY.GetSelectedItem().value;

                $(RC.ManageSchemeFundProposal.SchemeFundProposalObject.SchemeFundProposalDetailList).each(function (index, item) {
                    if (item.intFYID == parseInt(fYId) && item.intAccountHeadID == parseInt(coaId) && item.intCostTypeId == typeId) {
                        if (fadIndex < 0 || fadIndex != index) {
                            alert("Record already exists for selected Financial Year and Object Code.");

                            status = false;

                            return false;
                        }
                    }
                });
            }
        }

        return status;
    },
    PopulateSchemeFundProposal: function () {
        var status = RC.ManageSchemeFundProposal.ValidateSchemeFundProposal();

        if (status) {
            var id = 0;

            if (RC.ManageSchemeFundProposal.SchemeFundProposalObject != null) {
                id = RC.ManageSchemeFundProposal.SchemeFundProposalObject.lngPlanCode;
            }

            RC.ManageSchemeFundProposal.SchemeFundProposalObject.lngPlanCode = id;
            RC.ManageSchemeFundProposal.SchemeFundProposalObject.lngSchemeID = ddlCTScheme.GetSelectedItem().value;
            RC.ManageSchemeFundProposal.SchemeFundProposalObject.dtmProposedDate = $("#dvManageSchemeFundProposal #txtProposedDate").val();

            var isForeignFunding = (ddlCTScheme.GetSelectedItem().texts[3].toLowerCase() == 'true');

            if (!isForeignFunding) {
                RC.ManageSchemeFundProposal.SchemeFundProposalObject.SchemeFundProposalDetailList = RC.ManageSchemeFundProposal.SchemeFundProposalObject.SchemeFundProposalDetailList.filter(p => parseInt(p.intCostTypeId) !== 3);
            }
        }

        return status;
    },
    SaveSchemeFundProposal: function () {
        if (RC.ManageSchemeFundProposal.PopulateSchemeFundProposal()) {
            $('#dvManageSchemeFundProposal #btnSave').addClass("disabled").val('Wait...');

            RC.ManageSchemeFundProposal.AddUpdateSchemeFundProposal();
        }
    },
    AddUpdateSchemeFundProposal: function () {
        var handlerMethod = 'SchemeFundProposalAdd';

        if (RC.ManageSchemeFundProposal.SchemeFundProposalObject.lngPlanCode > 0) {
            handlerMethod = 'SchemeFundProposalUpdate';
        }

        $.post(RC.ManageSchemeFundProposal.HandlerURL,
        {
            method: handlerMethod,
            objSchemeFundProposal: JSON.stringify(RC.ManageSchemeFundProposal.SchemeFundProposalObject)
        },
        function (response) {
            switch (response.Status) {
                case RC.Common.ResponseStatus.SUCCESS:
                    alert(response.Message);

                    $('#dvManageSchemeFundProposal #btnSave').val('Its done.');

                    window.location = RC.Common.RootURL + "Forms/frmSchemeFundProposals.aspx?LevelType=" + RC.Common.GetQueryStringByName('LevelType') + "&LevelID=" + RC.Common.GetQueryStringByName('LevelID');

                    break;
                case RC.Common.ResponseStatus.ERROR:
                    alert(response.Message);

                    $('#dvManageSchemeFundProposal #btnSave').removeClass("disabled").val('Save');

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
    LoadTotalAmountForType: function () {
        var totalCapital = 0, totalRevenue = 0, totalForeignFunding = 0;

        $(RC.ManageSchemeFundProposal.SchemeFundProposalObject.SchemeFundProposalDetailList).each(function (index, item) {
            if (item.intFYID == ddlCTFY.GetSelectedItem().value) {
                if (item.intCostTypeId == RC.Common.SchemeFundType.CAPITAL) {
                    totalCapital += RC.ManageSchemeFundProposal.GetAmountForType(item);
                }
                else if (item.intCostTypeId == RC.Common.SchemeFundType.REVENUE) {
                    totalRevenue += RC.ManageSchemeFundProposal.GetAmountForType(item);
                }
                else if (item.intCostTypeId == RC.Common.SchemeFundType.FOREIGNFUNDING) {
                    totalForeignFunding += RC.ManageSchemeFundProposal.GetAmountForType(item);
                }
            }
        });

        if (RC.ManageSchemeFundProposal.GetTypeForSelectedView() == RC.Common.SchemeFundType.CAPITAL) {
            $('#dvManageSchemeFundProposal #dvFYTotalAmount .number').html('Capital');
            $('#dvManageSchemeFundProposal #dvFYTotalAmount .desc').html('Rs ' + totalCapital);
        }
        else if (RC.ManageSchemeFundProposal.GetTypeForSelectedView() == RC.Common.SchemeFundType.REVENUE) {
            $('#dvManageSchemeFundProposal #dvFYTotalAmount .number').html('Revenue');
            $('#dvManageSchemeFundProposal #dvFYTotalAmount .desc').html('Rs ' + totalRevenue);
        }
        else if (RC.ManageSchemeFundProposal.GetTypeForSelectedView() == RC.Common.SchemeFundType.FOREIGNFUNDING) {
            $('#dvManageSchemeFundProposal #dvFYTotalAmount .number').html('Foreign Funding');
            $('#dvManageSchemeFundProposal #dvFYTotalAmount .desc').html('Rs ' + totalForeignFunding);
        }
    },
    ShowForeignFundingForScheme: function () {
        var isForeignFunding = (ddlCTScheme.GetSelectedItem().texts[3].toLowerCase() == 'true');

        if (isForeignFunding) {
            $('#dvManageSchemeFundProposal #btnForeignFunding').show();
        }
        else {
            $('#dvManageSchemeFundProposal #btnForeignFunding').hide();
        }
    }
}

$(document).ready(function () {
    RC.ManageSchemeFundProposal.InitializePage();
    RC.ManageSchemeFundProposal.ShowForeignFundingForScheme();

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

        RC.ManageSchemeFundProposal.LoadSchemeFundProposalDetailView();
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

        RC.ManageSchemeFundProposal.LoadSchemeFundProposalDetailView();
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

        RC.ManageSchemeFundProposal.LoadSchemeFundProposalDetailView();
    });
    $('#btnCancel').on('click', function () {
        window.location = RC.Common.RootURL + "Forms/frmSchemeFundProposals.aspx?LevelType=" + RC.Common.GetQueryStringByName('LevelType') + "&LevelID=" + RC.Common.GetQueryStringByName('LevelID');

        return false;
    });
});