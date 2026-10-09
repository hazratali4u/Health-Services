var RC = RC || {};

RC.ManageSchemeExcess = {
    HandlerURL: RC.Common.RootURL + "Handler/SchemeExcessHandler.ashx",
    SchemeExcessObject: null,
    DetailTableInitialized: false,
    InitializePage: function () {
        if (RC.ManageSchemeExcess.SchemeExcessObject != null) {
            $("#dvManageSchemeExcess #txtExcessDate").val(RC.ManageSchemeExcess.SchemeExcessObject.ExcessDateString);

            RC.ManageSchemeExcess.PopulateSchemeExcessDetailList();
        }
        else {
            RC.ManageSchemeExcess.SchemeExcessObject = { Id: 0, SchemeId: 0, FinancialYearId: 0, ExcessDate: '', SchemeExcessDetailList: [] };
        }
    },
    PopulateSchemeExcessDetailList: function () {
        RC.ManageSchemeExcess.LoadViewForType();

        if (RC.ManageSchemeExcess.SchemeExcessObject.SchemeExcessDetailList == null ||
            RC.ManageSchemeExcess.SchemeExcessObject.SchemeExcessDetailList == undefined) {
            RC.ManageSchemeExcess.SchemeExcessObject.SchemeExcessDetailList = [];
        }

        if (RC.ManageSchemeExcess.SchemeExcessObject.SchemeExcessDetailList != null && RC.ManageSchemeExcess.SchemeExcessObject.SchemeExcessDetailList != undefined && RC.ManageSchemeExcess.SchemeExcessObject.SchemeExcessDetailList.length > 0) {
            var lstSchemeExcessDetail = RC.ManageSchemeExcess.GetSchemeExcessDetailListForType();

            if (lstSchemeExcessDetail.length > 0) {
                RC.ManageSchemeExcess.DetailTableInitialized = true;

                $('#dvManageSchemeExcess #tblSchemeExcessDetailList').DataTable({
                    "data": lstSchemeExcessDetail,
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
                            data: "AmountStatusName",
                            className: "center"
                        },
                        {
                            data: null,
                            className: "center",
                            render: function (row, type, val, meta) {
                                return "<center><a title='Edit' href='javascript:void(0)' onclick='RC.ManageSchemeExcess.SchemeExcessDetailLoad(" + meta.row + ")'>" +
                                    "<i class='fa fa-pencil' aria-hidden='true'></i></a>&nbsp;" +
                                    "<a title='Delete' href='javascript:void(0)' onclick='RC.ManageSchemeExcess.SchemeExcessDetailDelete(" + meta.row + ")'>" +
                                    "<i class='fa fa-trash-o' aria-hidden='true'></i></a></center>";
                            },
                            orderable: false,
                            defaultContent: ""
                        }
                    ],
                    "fnDrawCallback": function (oSettings) {
                        var lstSchemeExcessDetail = RC.ManageSchemeExcess.GetSchemeExcessDetailListForType();
                        var sum = 0;

                        if (lstSchemeExcessDetail.length > 0) {
                            for (var i = 0; i < lstSchemeExcessDetail.length; i++) {
                                sum += parseInt(lstSchemeExcessDetail[i].Amount);
                            }
                        }

                        $('#dvManageSchemeExcess #tblSchemeExcessDetailList')
                            .find('tbody tr:last')
                            .after('<tr id="trTotal" role="row" class="odd"><td style="text-align: right; font-weight: bolder;">Total&nbsp;</td><td class=" center">' + RC.Common.FormatNumber(sum) + '</td><td colspan="2">&nbsp;</td></tr>');
                    }
                });
            }
        }
    },
    LoadViewForType: function () {
        $('#dvManageSchemeExcess #pnlSchemeExcessDetail legend').text('Project Capital');

        if (RC.ManageSchemeExcess.GetTypeForSelectedView() == RC.Common.SchemeFundType.REVENUE) {
            $('#dvManageSchemeExcess #pnlSchemeExcessDetail legend').text('Project Revenue');
        }
        else if (RC.ManageSchemeExcess.GetTypeForSelectedView() == RC.Common.SchemeFundType.FOREIGNFUNDING) {
            $('#dvManageSchemeExcess #pnlSchemeExcessDetail legend').text('Project Foreign Funding');
        }
    },
    LoadSchemeExcessDetailView: function () {
        if (RC.ManageSchemeExcess.DetailTableInitialized) {
            $('#dvManageSchemeExcess #tblSchemeExcessDetailList').dataTable().fnClearTable();

            var lstSchemeExcessDetail = RC.ManageSchemeExcess.GetSchemeExcessDetailListForType();

            if (lstSchemeExcessDetail.length > 0) {
                $('#dvManageSchemeExcess #tblSchemeExcessDetailList').dataTable().fnAddData(lstSchemeExcessDetail);
            }

            $('#dvManageSchemeExcess #tblSchemeExcessDetailList').dataTable().fnDraw();

            if (lstSchemeExcessDetail.length <= 0) {
                $('#trTotal').remove();
            }
        }
        else {
            RC.ManageSchemeExcess.PopulateSchemeExcessDetailList();
        }
    },
    GetTypeForSelectedView: function () {
        var typeId = RC.Common.SchemeFundType.CAPITAL;

        if ($('#dvManageSchemeExcess #btnRevenue').hasClass('btn-primary')) {
            typeId = RC.Common.SchemeFundType.REVENUE;
        }
        else if ($('#dvManageSchemeExcess #btnForeignFunding').hasClass('btn-primary')) {
            typeId = RC.Common.SchemeFundType.FOREIGNFUNDING;
        }

        return typeId;
    },
    GetSchemeExcessDetailListForType: function () {
        var lstSchemeExcessDetail = [];

        $(RC.ManageSchemeExcess.SchemeExcessObject.SchemeExcessDetailList).each(function (index, item) {
            if (item.TypeId == RC.ManageSchemeExcess.GetTypeForSelectedView()) {
                lstSchemeExcessDetail.push(item);
            }
        });

        return lstSchemeExcessDetail
    },
    GetSchemeExcessDetailIndexForType: function (edIndex) {
        var edDelIndex = -1;
        var idx = 0;

        $(RC.ManageSchemeExcess.SchemeExcessObject.SchemeExcessDetailList).each(function (index, item) {
            if (item.TypeId == RC.ManageSchemeExcess.GetTypeForSelectedView()) {
                if (edIndex == idx) {
                    edDelIndex = index;
                }

                idx++;
            }
        });

        return edDelIndex;
    },
    SchemeExcessDetailLoad: function (index) {
        var edIndex = RC.ManageSchemeExcess.GetSchemeExcessDetailIndexForType(index);
        var objSchemeExcessDetail = RC.ManageSchemeExcess.SchemeExcessObject.SchemeExcessDetailList[edIndex];

        if ($('#dvManageSchemeExcess #btnCapital').hasClass('btn-primary')) {
            ddlCTCOA.SetValue(objSchemeExcessDetail.COAId);
        }
        else if ($('#dvManageSchemeExcess #btnRevenue').hasClass('btn-primary')) {
            ddlRCTCOA.SetValue(objSchemeExcessDetail.COAId);
        }
        else if ($('#dvManageSchemeExcess #btnForeignFunding').hasClass('btn-primary')) {
            ddlFFCTCOA.SetValue(objSchemeExcessDetail.COAId);
        }

        $("#dvManageSchemeExcess #txtAmount").autoNumeric('set', objSchemeExcessDetail.Amount);
        ddlCTAmountStatus.SetValue(objSchemeExcessDetail.AmountStatusId);
        $("#dvManageSchemeExcess #btnSaveDetail")
            .attr('onclick', "RC.ManageSchemeExcess.SchemeExcessDetailSave(" + index + ");")
            .val('Update');
    },
    SchemeExcessDetailReset: function () {
        //ddlCTCOA.SetSelectedIndex(0);
        //ddlRCTCOA.SetSelectedIndex(0);
        $("#dvManageSchemeExcess #txtAmount").autoNumeric('set', '');
        //ddlCTAmountStatus.SetSelectedIndex(0);
        $("#dvManageSchemeExcess #btnSaveDetail")
            .attr('onclick', "RC.ManageSchemeExcess.SchemeExcessDetailSave(-1);")
            .val('Add');
    },
    SchemeExcessDetailSave: function (index) {
        var status = RC.ManageSchemeExcess.ValidateSchemeExcessDetail();

        if (status) {
            if (index >= 0) {
                var edIndex = RC.ManageSchemeExcess.GetSchemeExcessDetailIndexForType(index);

                RC.ManageSchemeExcess.SchemeExcessObject.SchemeExcessDetailList.splice(edIndex, 1);
            }

            var objSchemeExcessDetail = { TypeId: 0, COAId: 0, AmountStatusId: 0, COAName: '', AmountStatusName: '', Amount: 0 };
            var typeId = 0;
            var coa = 0;
            var coaText = '';

            if ($('#dvManageSchemeExcess #btnCapital').hasClass('btn-primary')) {
                typeId = RC.Common.SchemeFundType.CAPITAL;
                coa = ddlCTCOA.GetSelectedItem().value;
                coaText = ddlCTCOA.GetSelectedItem().text;
            }
            else if ($('#dvManageSchemeExcess #btnRevenue').hasClass('btn-primary')) {
                typeId = RC.Common.SchemeFundType.REVENUE;
                coa = ddlRCTCOA.GetSelectedItem().value;
                coaText = ddlRCTCOA.GetSelectedItem().text;
            }
            else if ($('#dvManageSchemeExcess #btnForeignFunding').hasClass('btn-primary')) {
                typeId = RC.Common.SchemeFundType.FOREIGNFUNDING;
                coa = ddlFFCTCOA.GetSelectedItem().value;
                coaText = ddlFFCTCOA.GetSelectedItem().text;
            }

            objSchemeExcessDetail.TypeId = typeId;
            objSchemeExcessDetail.COAId = coa;
            objSchemeExcessDetail.COAName = coaText;
            objSchemeExcessDetail.AmountStatusId = ddlCTAmountStatus.GetSelectedItem().value;
            objSchemeExcessDetail.AmountStatusName = ddlCTAmountStatus.GetSelectedItem().text;
            objSchemeExcessDetail.Amount = parseFloat($("#dvManageSchemeExcess #txtAmount").autoNumeric('get'));

            RC.ManageSchemeExcess.SchemeExcessObject.SchemeExcessDetailList.push(objSchemeExcessDetail);

            RC.ManageSchemeExcess.LoadSchemeExcessDetailView();
            RC.ManageSchemeExcess.SchemeExcessDetailReset();
        }
    },
    SchemeExcessDetailDelete: function (edIndex) {
        var edDelIndex = RC.ManageSchemeExcess.GetSchemeExcessDetailIndexForType(edIndex);

        RC.ManageSchemeExcess.SchemeExcessObject.SchemeExcessDetailList.splice(edDelIndex, 1);

        RC.ManageSchemeExcess.LoadSchemeExcessDetailView();
    },
    ValidateSchemeExcess: function () {
        var status = true;

        if (ddlCTScheme.GetSelectedItem() == null) {
            alert("Please provide scheme.");

            status = false;
        }
        else if (ddlCTSchemeFY.GetSelectedItem() == null) {
            alert("Please provide financial year.");

            status = false;
        }
        else if ($.trim($("#dvManageSchemeExcess #txtExcessDate").val()) == "") {
            alert("Please provide excess date.");

            status = false;
        }

        return status;
    },
    ValidateSchemeExcessDetail: function () {
        var status = true;

        if ($('#dvManageSchemeExcess #btnCapital').hasClass('btn-primary')) {
            if (ddlCTCOA.GetSelectedItem() == null) {
                alert("Please provide object code.");

                status = false;
            }
        }
        else if ($('#dvManageSchemeExcess #btnRevenue').hasClass('btn-primary')) {
            if (ddlRCTCOA.GetSelectedItem() == null) {
                alert("Please provide object code.");

                status = false;
            }
        }
        else if ($('#dvManageSchemeExcess #btnForeignFunding').hasClass('btn-primary')) {
            if (ddlFFCTCOA.GetSelectedItem() == null) {
                alert("Please provide object code.");

                status = false;
            }
        }

        if (status) {
            if ($.trim($("#dvManageSchemeExcess #txtAmount").autoNumeric('get')) == "") {
                alert("Please provide amount.");

                status = false;
            }
        }

        return status;
    },
    PopulateSchemeExcess: function () {
        var status = RC.ManageSchemeExcess.ValidateSchemeExcess();

        if (status) {
            var id = 0;

            if (RC.ManageSchemeExcess.SchemeExcessObject != null) {
                id = RC.ManageSchemeExcess.SchemeExcessObject.Id;
            }

            RC.ManageSchemeExcess.SchemeExcessObject.Id = id;
            RC.ManageSchemeExcess.SchemeExcessObject.SchemeId = ddlCTScheme.GetSelectedItem().value;
            RC.ManageSchemeExcess.SchemeExcessObject.FinancialYearId = ddlCTSchemeFY.GetSelectedItem().value;
            RC.ManageSchemeExcess.SchemeExcessObject.ExcessDate = $("#dvManageSchemeExcess #txtExcessDate").val();

            var isForeignFunding = (ddlCTScheme.GetSelectedItem().texts[3].toLowerCase() == 'true');

            if (!isForeignFunding) {
                RC.ManageSchemeExcess.SchemeExcessObject.SchemeExcessDetailList = RC.ManageSchemeExcess.SchemeExcessObject.SchemeExcessDetailList.filter(p => parseInt(p.TypeId) !== 3);
            }
        }

        return status;
    },
    SaveSchemeExcess: function () {
        if (RC.ManageSchemeExcess.PopulateSchemeExcess()) {
            $('#dvManageSchemeExcess #btnSave').addClass("disabled").val('Wait...');

            RC.ManageSchemeExcess.AddUpdateSchemeExcess();
        }
    },
    AddUpdateSchemeExcess: function () {
        var handlerMethod = 'SchemeExcessAdd';

        if (RC.ManageSchemeExcess.SchemeExcessObject.Id > 0) {
            handlerMethod = 'SchemeExcessUpdate';
        }

        $.post(RC.ManageSchemeExcess.HandlerURL,
        {
            method: handlerMethod,
            objSchemeExcess: JSON.stringify(RC.ManageSchemeExcess.SchemeExcessObject)
        },
        function (response) {
            switch (response.Status) {
                case RC.Common.ResponseStatus.SUCCESS:
                    alert(response.Message);

                    $('#dvManageSchemeExcess #btnSave').val('Its done.');

                    window.location = RC.Common.RootURL + "Forms/frmExpesneSurrender.aspx?LevelType=" + RC.Common.GetQueryStringByName('LevelType') + "&LevelID=" + RC.Common.GetQueryStringByName('LevelID');

                    break;
                case RC.Common.ResponseStatus.ERROR:
                    alert(response.Message);

                    $('#dvManageSchemeExcess #btnSave').removeClass("disabled").val('Save');

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
    ShowForeignFundingForScheme: function () {
        var isForeignFunding = (ddlCTScheme.GetSelectedItem().texts[3].toLowerCase() == 'true');

        if (isForeignFunding) {
            $('#dvManageSchemeExcess #btnForeignFunding').show();
        }
        else {
            $('#dvManageSchemeExcess #btnForeignFunding').hide();
        }
    }
}

$(document).ready(function () {
    RC.ManageSchemeExcess.InitializePage();
    RC.ManageSchemeExcess.ShowForeignFundingForScheme();

    $('#txtAmount').autoNumeric('init');

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

        RC.ManageSchemeExcess.LoadSchemeExcessDetailView();
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

        RC.ManageSchemeExcess.LoadSchemeExcessDetailView();
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

        RC.ManageSchemeExcess.LoadSchemeExcessDetailView();
    });
    $('#btnCancel').on('click', function () {
        window.location = RC.Common.RootURL + "Forms/frmExpesneSurrender.aspx?LevelType=" + RC.Common.GetQueryStringByName('LevelType') + "&LevelID=" + RC.Common.GetQueryStringByName('LevelID');

        return false;
    });
});