var RC = RC || {};

RC.ManageSchemeFundApproval = {
    HandlerURL: RC.Common.RootURL + "Handler/PC1SchemeFundApprovalHandler.ashx",
    SchemeFundApprovalObject: null,
    DetailTableInitialized: false,
    InitializePage: function () {
        if (RC.ManageSchemeFundApproval.SchemeFundApprovalObject != null) {
            //if (RC.ManageSchemeFundApproval.SchemeFundApprovalObject.Id > 0) {
            //    $("#dvManageSchemeFundApproval #btnLoadProposedData").hide();
            //}

            $("#dvManageSchemeFundApproval #txtStatusDate").val(RC.ManageSchemeFundApproval.SchemeFundApprovalObject.StDateString);
            $("#dvManageSchemeFundApproval #txtReferenceNo").val(RC.ManageSchemeFundApproval.SchemeFundApprovalObject.ReferenceNo);
            RC.ManageSchemeFundApproval.PopulateSchemeFundApprovalDetailList();
        }
        else {
            RC.ManageSchemeFundApproval.SchemeFundApprovalObject = { Id: 0, SchemeId: 0, StatusId: 0, StDate: '', ApprovedBy: 0, ReferenceNo: '', SchemeFundApprovalDetailList: [] };
        }
    },
    PopulateSchemeFundApprovalDetailList: function () {
        RC.ManageSchemeFundApproval.LoadViewForType();

        if (RC.ManageSchemeFundApproval.SchemeFundApprovalObject.SchemeFundApprovalDetailList == null ||
            RC.ManageSchemeFundApproval.SchemeFundApprovalObject.SchemeFundApprovalDetailList == undefined) {
            RC.ManageSchemeFundApproval.SchemeFundApprovalObject.SchemeFundApprovalDetailList = [];
        }

        if (RC.ManageSchemeFundApproval.SchemeFundApprovalObject.SchemeFundApprovalDetailList != null && RC.ManageSchemeFundApproval.SchemeFundApprovalObject.SchemeFundApprovalDetailList != undefined && RC.ManageSchemeFundApproval.SchemeFundApprovalObject.SchemeFundApprovalDetailList.length > 0) {
            var lstSchemeFundApprovalDetail = RC.ManageSchemeFundApproval.GetSchemeFundApprovalDetailListForType();

            if (lstSchemeFundApprovalDetail.length > 0) {
                RC.ManageSchemeFundApproval.DetailTableInitialized = true;

                $('#dvManageSchemeFundApproval #tblSchemeFundApprovalDetailList').DataTable({
                    "data": lstSchemeFundApprovalDetail,
                    "columns": [
                        {
                            data: "YearName",
                            className: "center"
                        },
                        { "data": "COAName" },
                        {
                            data: "Amount",
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
                                return "<center><a title='Edit' href='javascript:void(0)' onclick='RC.ManageSchemeFundApproval.SchemeFundApprovalDetailLoad(" + meta.row + ")'>" +
                                    "<i class='fa fa-pencil' aria-hidden='true'></i></a>&nbsp;" +
                                    "<a title='Delete' href='javascript:void(0)' onclick='RC.ManageSchemeFundApproval.SchemeFundApprovalDetailDelete(" + meta.row + ")'>" +
                                    "<i class='fa fa-trash-o' aria-hidden='true'></i></a></center>";
                            },
                            orderable: false,
                            defaultContent: ""
                        }
                    ],
                    "fnDrawCallback": function (oSettings) {
                        var lstSchemeFundApprovalDetail = RC.ManageSchemeFundApproval.GetSchemeFundApprovalDetailListForType();
                        var sum = 0;

                        if (lstSchemeFundApprovalDetail.length > 0) {
                            for (var i = 0; i < lstSchemeFundApprovalDetail.length; i++) {
                                sum += parseFloat(lstSchemeFundApprovalDetail[i].Amount);
                            }
                        }

                        $('#dvManageSchemeFundApproval #tblSchemeFundApprovalDetailList')
                            .find('tbody tr:last')
                            .after('<tr id="trTotal" role="row" class="odd"><td colspan="2" style="text-align: right; font-weight: bolder;">Total&nbsp;</td><td class=" center">' + RC.Common.FormatNumber(sum) + '</td><td colspan="2">&nbsp;</td></tr>');
                    }
                });
            }
        }
    },
    LoadViewForType: function () {
        $('#dvManageSchemeFundApproval #pnlSchemeFundApprovalDetail legend').text('Project Capital');

        if (RC.ManageSchemeFundApproval.GetTypeForSelectedView() == RC.Common.SchemeFundType.REVENUE) {
            $('#dvManageSchemeFundApproval #pnlSchemeFundApprovalDetail legend').text('Project Revenue');
        }
    },
    LoadSchemeFundApprovalDetailView: function () {
        if (RC.ManageSchemeFundApproval.DetailTableInitialized) {
            $('#dvManageSchemeFundApproval #tblSchemeFundApprovalDetailList').dataTable().fnClearTable();

            var lstSchemeFundApprovalDetail = RC.ManageSchemeFundApproval.GetSchemeFundApprovalDetailListForType();

            if (lstSchemeFundApprovalDetail.length > 0) {
                $('#dvManageSchemeFundApproval #tblSchemeFundApprovalDetailList').dataTable().fnAddData(lstSchemeFundApprovalDetail);
            }

            $('#dvManageSchemeFundApproval #tblSchemeFundApprovalDetailList').dataTable().fnDraw();

            if (lstSchemeFundApprovalDetail.length <= 0) {
                $('#trTotal').remove();
            }
        }
        else {
            RC.ManageSchemeFundApproval.PopulateSchemeFundApprovalDetailList();
        }

        RC.ManageSchemeFundApproval.LoadTotalAmountForType();
    },
    GetTypeForSelectedView: function () {
        var typeId = RC.Common.SchemeFundType.CAPITAL;

        if ($('#dvManageSchemeFundApproval #btnRevenue').hasClass('btn-primary')) {
            typeId = RC.Common.SchemeFundType.REVENUE;
        }

        return typeId;
    },
    GetSchemeFundApprovalDetailListForType: function () {
        var lstSchemeFundApprovalDetail = [];

        $(RC.ManageSchemeFundApproval.SchemeFundApprovalObject.SchemeFundApprovalDetailList).each(function (index, item) {
            if (item.TypeId == RC.ManageSchemeFundApproval.GetTypeForSelectedView()) {
                lstSchemeFundApprovalDetail.push(item);
            }
        });

        return lstSchemeFundApprovalDetail;
    },
    GetSchemeFundApprovalDetailIndexForType: function (fadIndex) {
        var fadDelIndex = -1;
        var idx = 0;

        $(RC.ManageSchemeFundApproval.SchemeFundApprovalObject.SchemeFundApprovalDetailList).each(function (index, item) {
            if (item.TypeId == RC.ManageSchemeFundApproval.GetTypeForSelectedView()) {
                if (fadIndex == idx) {
                    fadDelIndex = index;
                }

                idx++;
            }
        });

        return fadDelIndex;
    },
    SchemeFundApprovalDetailLoad: function (index) {
        var fadIndex = RC.ManageSchemeFundApproval.GetSchemeFundApprovalDetailIndexForType(index);
        var objSchemeFundApprovalDetail = RC.ManageSchemeFundApproval.SchemeFundApprovalObject.SchemeFundApprovalDetailList[fadIndex];

        if ($('#dvManageSchemeFundApproval #btnRevenue').hasClass('btn-primary')) {
            ddlRCTCOA.SetValue(objSchemeFundApprovalDetail.COAId);
        }
        else {
            ddlCTCOA.SetValue(objSchemeFundApprovalDetail.COAId);
        }

        ddlCTFY.SetValue(objSchemeFundApprovalDetail.FinancialYearId);
        $("#dvManageSchemeFundApproval #txtAmount").autoNumeric('set', objSchemeFundApprovalDetail.Amount);
        $("#dvManageSchemeFundApproval #txtDescription").val(objSchemeFundApprovalDetail.Description);
        $("#dvManageSchemeFundApproval #btnSaveDetail")
            .attr('onclick', "RC.ManageSchemeFundApproval.SchemeFundApprovalDetailSave(" + index + ");")
            .val('Update');
    },
    SchemeFundApprovalDetailReset: function () {
        //ddlCTFY.SetSelectedIndex(0);
        //ddlCTCOA.SetSelectedIndex(0);
        //ddlRCTCOA.SetSelectedIndex(0);
        $("#dvManageSchemeFundApproval #txtAmount").autoNumeric('set', '');
        $("#dvManageSchemeFundApproval #txtDescription").val('');
        $("#dvManageSchemeFundApproval #btnSaveDetail")
            .attr('onclick', "RC.ManageSchemeFundApproval.SchemeFundApprovalDetailSave(-1);")
            .val('Add');
    },
    SchemeFundApprovalDetailSave: function (index) {
        var status = RC.ManageSchemeFundApproval.ValidateSchemeFundApprovalDetail(index);

        if (status) {
            if (index >= 0) {
                var fadIndex = RC.ManageSchemeFundApproval.GetSchemeFundApprovalDetailIndexForType(index);

                RC.ManageSchemeFundApproval.SchemeFundApprovalObject.SchemeFundApprovalDetailList.splice(fadIndex, 1);
            }

            var objSchemeFundApprovalDetail = { TypeId: 0, FinancialYearId: 0, YearName: '', COAId: 0, COAName: '', Amount: 0, Description: '' };
            var typeId = RC.Common.SchemeFundType.CAPITAL;
            var coaId = 0;
            var coaText = '';

            if ($('#dvManageSchemeFundApproval #btnRevenue').hasClass('btn-primary')) {
                typeId = RC.Common.SchemeFundType.REVENUE;
                coaId = ddlRCTCOA.GetSelectedItem().value;
                coaText = ddlRCTCOA.GetSelectedItem().text;
            }
            else {
                coaId = ddlCTCOA.GetSelectedItem().value;
                coaText = ddlCTCOA.GetSelectedItem().text;
            }

            objSchemeFundApprovalDetail.TypeId = typeId;
            objSchemeFundApprovalDetail.FinancialYearId = ddlCTFY.GetSelectedItem().value;
            objSchemeFundApprovalDetail.YearName = ddlCTFY.GetSelectedItem().text;
            objSchemeFundApprovalDetail.COAId = coaId;
            objSchemeFundApprovalDetail.COAName = coaText;
            objSchemeFundApprovalDetail.Amount = parseFloat($("#dvManageSchemeFundApproval #txtAmount").autoNumeric('get'));
            objSchemeFundApprovalDetail.Description = $("#dvManageSchemeFundApproval #txtDescription").val();

            RC.ManageSchemeFundApproval.SchemeFundApprovalObject.SchemeFundApprovalDetailList.push(objSchemeFundApprovalDetail);

            RC.ManageSchemeFundApproval.LoadSchemeFundApprovalDetailView();
            RC.ManageSchemeFundApproval.SchemeFundApprovalDetailReset();
        }
    },
    SchemeFundApprovalDetailDelete: function (fadIndex) {
        var fadDelIndex = RC.ManageSchemeFundApproval.GetSchemeFundApprovalDetailIndexForType(fadIndex);

        RC.ManageSchemeFundApproval.SchemeFundApprovalObject.SchemeFundApprovalDetailList.splice(fadDelIndex, 1);

        RC.ManageSchemeFundApproval.LoadSchemeFundApprovalDetailView();
    },
    ValidateSchemeFundApproval: function () {
        var status = true;

        if (ddlCTScheme.GetSelectedItem() == null) {
            alert("Please provide scheme.");

            status = false;
        }
        else if ($.trim($("#dvManageSchemeFundApproval #txtStatusDate").val()) == "") {
            alert("Please provide status date.");

            status = false;
        }
        else if (ddlCTEmployee.GetSelectedItem() == null) {
            alert("Please provide approved by.");

            status = false;
        }

        return status;
    },
    ValidateSchemeFundApprovalDetail: function (idx) {
        var fadIndex = RC.ManageSchemeFundApproval.GetSchemeFundApprovalDetailIndexForType(idx);
        var typeId = RC.Common.SchemeFundType.CAPITAL;
        var status = true;
        var coaId = 0, fYId = 0;

        if (ddlCTFY.GetSelectedItem() == null) {
            alert("Please provide financial year.");

            status = false;
        }
        else if ($('#dvManageSchemeFundApproval #btnRevenue').hasClass('btn-primary')) {
            typeId = RC.Common.SchemeFundType.REVENUE;

            if (ddlRCTCOA.GetSelectedItem() == null) {
                alert("Please provide object code.");

                status = false;
            }
            else {
                coaId = ddlRCTCOA.GetSelectedItem().value;
            }
        }
        else {
            if (ddlCTCOA.GetSelectedItem() == null) {
                alert("Please provide object code.");

                status = false;
            }
            else {
                coaId = ddlCTCOA.GetSelectedItem().value;
            }
        }

        if (status) {
            if ($.trim($("#dvManageSchemeFundApproval #txtAmount").autoNumeric('get')) == "") {
                alert("Please provide amount.");

                status = false;
            }
            else {
                fYId = ddlCTFY.GetSelectedItem().value;

                $(RC.ManageSchemeFundApproval.SchemeFundApprovalObject.SchemeFundApprovalDetailList).each(function (index, item) {
                    if (item.FinancialYearId == parseInt(fYId) && item.COAId == parseInt(coaId) && item.TypeId == typeId) {
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
    PopulateSchemeFundApproval: function () {
        var status = RC.ManageSchemeFundApproval.ValidateSchemeFundApproval();

        if (status) {
            var id = 0;

            if (RC.ManageSchemeFundApproval.SchemeFundApprovalObject != null) {
                id = RC.ManageSchemeFundApproval.SchemeFundApprovalObject.Id;
            }

            RC.ManageSchemeFundApproval.SchemeFundApprovalObject.Id = id;
            RC.ManageSchemeFundApproval.SchemeFundApprovalObject.SchemeId = ddlCTScheme.GetSelectedItem().value;
            RC.ManageSchemeFundApproval.SchemeFundApprovalObject.StatusId = ddlCTSchemeStatus.GetSelectedItem().value;
            RC.ManageSchemeFundApproval.SchemeFundApprovalObject.StDate = $("#dvManageSchemeFundApproval #txtStatusDate").val();
            RC.ManageSchemeFundApproval.SchemeFundApprovalObject.ApprovedBy = ddlCTEmployee.GetSelectedItem().value;
            RC.ManageSchemeFundApproval.SchemeFundApprovalObject.ReferenceNo = $("#dvManageSchemeFundApproval #txtReferenceNo").val();
        }

        return status;
    },
    SaveSchemeFundApproval: function () {
        if (RC.ManageSchemeFundApproval.PopulateSchemeFundApproval()) {
            $('#dvManageSchemeFundApproval #btnSave').addClass("disabled").val('Wait...');

            RC.ManageSchemeFundApproval.AddUpdateSchemeFundApproval();
        }
    },
    AddUpdateSchemeFundApproval: function () {
        var handlerMethod = 'SchemeFundApprovalAdd';

        if (RC.ManageSchemeFundApproval.SchemeFundApprovalObject.Id > 0) {
            handlerMethod = 'SchemeFundApprovalUpdate';
        }

        $.post(RC.ManageSchemeFundApproval.HandlerURL,
        {
            method: handlerMethod,
            objSchemeFundApproval: JSON.stringify(RC.ManageSchemeFundApproval.SchemeFundApprovalObject)
        },
        function (response) {
            switch (response.Status) {
                case RC.Common.ResponseStatus.SUCCESS:
                    alert(response.Message);

                    $('#dvManageSchemeFundApproval #btnSave').val('Its done.');

                    window.location = RC.Common.RootURL + "Forms/frmPC1SchemeFundApprovals.aspx?LevelType=3&LevelID=276";

                    break;
                case RC.Common.ResponseStatus.ERROR:
                    alert(response.Message);

                    $('#dvManageSchemeFundApproval #btnSave').removeClass("disabled").val('Save');

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
    LoadSchemeFundProposedDetail: function () {
        if (ddlCTScheme.GetSelectedItem() == null) {
            alert("Please provide scheme.");
        }
        else {
            $('#dvManageSchemeFundApproval #btnLoadProposedData').addClass("disabled").val('Wait...');

            $.post(RC.ManageSchemeFundApproval.HandlerURL,
            {
                method: "SchemeFundProposedGetSchemeId",
                SchemeId: ddlCTScheme.GetSelectedItem().value
            },
            function (response) {
                $('#dvManageSchemeFundApproval #btnLoadProposedData').removeClass("disabled").val('Load Data From Proposed Plan');

                switch (response.Status) {
                    case RC.Common.ResponseStatus.SUCCESS:
                        $(response.Data).each(function (index, item) {
                            item.Date = '';
                        });

                        RC.ManageSchemeFundApproval.SchemeFundApprovalObject.SchemeFundApprovalDetailList = response.Data;

                        RC.ManageSchemeFundApproval.LoadSchemeFundApprovalDetailView();

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
    LoadTotalAmountForType: function () {
        var totalCapital = 0, totalRevenue = 0;

        $(RC.ManageSchemeFundApproval.SchemeFundApprovalObject.SchemeFundApprovalDetailList).each(function (index, item) {
            if (item.FinancialYearId == ddlCTFY.GetSelectedItem().value) {
                if (item.TypeId == RC.Common.SchemeFundType.CAPITAL) {
                    totalCapital += item.Amount;
                }
                else if (item.TypeId == RC.Common.SchemeFundType.REVENUE) {
                    totalRevenue += item.Amount;
                }
            }
        });

        if (RC.ManageSchemeFundApproval.GetTypeForSelectedView() == RC.Common.SchemeFundType.CAPITAL) {
            $('#dvManageSchemeFundApproval #dvFYTotalAmount .number').html('Capital');
            $('#dvManageSchemeFundApproval #dvFYTotalAmount .desc').html('Rs ' + totalCapital);
        }
        else if (RC.ManageSchemeFundApproval.GetTypeForSelectedView() == RC.Common.SchemeFundType.REVENUE) {
            $('#dvManageSchemeFundApproval #dvFYTotalAmount .number').html('Revenue');
            $('#dvManageSchemeFundApproval #dvFYTotalAmount .desc').html('Rs ' + totalRevenue);
        }
    }
}

$(document).ready(function () {
    RC.ManageSchemeFundApproval.InitializePage();

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

        $("#dvCOA").show();
        $("#dvRCOA").hide();

        RC.ManageSchemeFundApproval.LoadSchemeFundApprovalDetailView();
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

        $("#dvRCOA").show();
        $("#dvCOA").hide();

        RC.ManageSchemeFundApproval.LoadSchemeFundApprovalDetailView();
    });
});