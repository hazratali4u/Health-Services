var RC = RC || {};

RC.ManageSchemeReappropriation = {
    HandlerURL: RC.Common.RootURL + "Handler/SchemeReappropriationHandler.ashx",
    SchemeReappropriationObject: null,
    FundTypeList: [],
    DetailTableInitialized: false,
    InitializePage: function () {
        if (RC.ManageSchemeReappropriation.SchemeReappropriationObject != null) {
            RC.ManageSchemeReappropriation.PopulateSchemeReappropriationDetailList();
        }
        else {
            RC.ManageSchemeReappropriation.SchemeReappropriationObject = { Id: 0, FinancialYearId: 0, Month: 0, SchemeReappropriationDetailList: [] };
        }
    },
    PopulateSchemeReappropriationDetailList: function () {
        if (RC.ManageSchemeReappropriation.SchemeReappropriationObject.SchemeReappropriationDetailList == null ||
            RC.ManageSchemeReappropriation.SchemeReappropriationObject.SchemeReappropriationDetailList == undefined) {
            RC.ManageSchemeReappropriation.SchemeReappropriationObject.SchemeReappropriationDetailList = [];
        }

        if (RC.ManageSchemeReappropriation.SchemeReappropriationObject.SchemeReappropriationDetailList != null && RC.ManageSchemeReappropriation.SchemeReappropriationObject.SchemeReappropriationDetailList != undefined && RC.ManageSchemeReappropriation.SchemeReappropriationObject.SchemeReappropriationDetailList.length > 0) {
            RC.ManageSchemeReappropriation.DetailTableInitialized = true;

            $('#dvManageSchemeReappropriation #tblSchemeReappropriationDetailList').DataTable({
                "data": RC.ManageSchemeReappropriation.SchemeReappropriationObject.SchemeReappropriationDetailList,
                "columns": [
                    {
                        data: "TransactionDateString",
                        orderable: false
                    },
                    { "data": "FromSchemeTitle" },
                    { "data": "FromCOAName" },
                    { "data": "ToSchemeTitle" },
                    { "data": "ToCOAName" },
                    {
                        data: "Amount",
                        className: "center",
                        render: function (data, type, full, meta) {
                            return RC.Common.FormatNumber(data);
                        }
                    },
                    {
                        data: null,
                        className: "center",
                        render: function (row, type, val, meta) {
                            var actionHtml = "<center>";

                            if (row.FromSchemeId > 0 && row.FromCOAId > 0 &&
                                row.ToSchemeId > 0 && row.ToCOAId > 0) {
                                actionHtml += "<a title='Edit' href='javascript:void(0)' onclick='RC.ManageSchemeReappropriation.SchemeReappropriationDetailLoad(" + meta.row + ")'>" +
                                    "<i class='fa fa-pencil' aria-hidden='true'></i></a>&nbsp;";
                            }

                            actionHtml += "<a title='Delete' href='javascript:void(0)' onclick='RC.ManageSchemeReappropriation.SchemeReappropriationDetailDelete(" + meta.row + ")'>" +
                                "<i class='fa fa-trash-o' aria-hidden='true'></i></a></center>";

                            return actionHtml;
                        },
                        orderable: false,
                        defaultContent: ""
                    }
                ],
                aaSorting: [[1, 'asc']],
                "fnDrawCallback": function (oSettings) {
                    var sum = 0;

                    if (RC.ManageSchemeReappropriation.SchemeReappropriationObject.SchemeReappropriationDetailList != null && RC.ManageSchemeReappropriation.SchemeReappropriationObject.SchemeReappropriationDetailList != undefined && RC.ManageSchemeReappropriation.SchemeReappropriationObject.SchemeReappropriationDetailList.length > 0) {
                        for (var i = 0; i < RC.ManageSchemeReappropriation.SchemeReappropriationObject.SchemeReappropriationDetailList.length; i++) {
                            sum += parseFloat(RC.ManageSchemeReappropriation.SchemeReappropriationObject.SchemeReappropriationDetailList[i].Amount);
                        }
                    }

                    $('#dvManageSchemeReappropriation #tblSchemeReappropriationDetailList')
                        .find('tbody tr:last')
                        .after('<tr id="trTotal" role="row" class="odd"><td colspan="5" style="text-align: right; font-weight: bolder;">Total&nbsp;</td><td class=" center">' + RC.Common.FormatNumber(sum) + '</td><td>&nbsp;</td></tr>');
                }
            });
        }
    },
    LoadSchemeReappropriationDetailView: function () {
        if (RC.ManageSchemeReappropriation.DetailTableInitialized) {
            $('#dvManageSchemeReappropriation #tblSchemeReappropriationDetailList').dataTable().fnClearTable();

            if (RC.ManageSchemeReappropriation.SchemeReappropriationObject.SchemeReappropriationDetailList != null && RC.ManageSchemeReappropriation.SchemeReappropriationObject.SchemeReappropriationDetailList != undefined && RC.ManageSchemeReappropriation.SchemeReappropriationObject.SchemeReappropriationDetailList.length > 0) {
                $('#dvManageSchemeReappropriation #tblSchemeReappropriationDetailList').dataTable().fnAddData(RC.ManageSchemeReappropriation.SchemeReappropriationObject.SchemeReappropriationDetailList);
            }

            $('#dvManageSchemeReappropriation #tblSchemeReappropriationDetailList').dataTable().fnDraw();

            if (RC.ManageSchemeReappropriation.SchemeReappropriationObject.SchemeReappropriationDetailList == null ||
                RC.ManageSchemeReappropriation.SchemeReappropriationObject.SchemeReappropriationDetailList == undefined ||
                RC.ManageSchemeReappropriation.SchemeReappropriationObject.SchemeReappropriationDetailList.length <= 0) {
                $('#trTotal').remove();
            }
        }
        else {
            RC.ManageSchemeReappropriation.PopulateSchemeReappropriationDetailList();
        }
    },
    SchemeReappropriationDetailLoad: function (index) {
        var objSchemeReappropriationDetail = RC.ManageSchemeReappropriation.SchemeReappropriationObject.SchemeReappropriationDetailList[index];

        ddlFCTFundType.SetValue(objSchemeReappropriationDetail.FromFundTypeId);
        ddlFCTScheme.SetValue(objSchemeReappropriationDetail.FromSchemeId);
        ddlFCTCOA.SetValue(objSchemeReappropriationDetail.FromCOAId);
        ddlTCTFundType.SetValue(objSchemeReappropriationDetail.ToFundTypeId);
        ddlTCTScheme.SetValue(objSchemeReappropriationDetail.ToSchemeId);
        ddlTCTCOA.SetValue(objSchemeReappropriationDetail.ToCOAId);

        if (objSchemeReappropriationDetail.EditMode == undefined ||
            objSchemeReappropriationDetail.EditMode == 1) {
            $("#dvManageSchemeReappropriation #txtFromAmount").autoNumeric('set', objSchemeReappropriationDetail.Amount);
            $("#dvManageSchemeReappropriation #txtFromTransactionDate").val(objSchemeReappropriationDetail.TransactionDateString);
            $("#dvManageSchemeReappropriation #btnFromSaveDetail")
                .attr('onclick', "RC.ManageSchemeReappropriation.SchemeReappropriationFromDetailSave(" + index + ");")
                .val('Update');
        }
        else {
            $("#dvManageSchemeReappropriation #txtToAmount").autoNumeric('set', objSchemeReappropriationDetail.Amount);
            $("#dvManageSchemeReappropriation #txtToTransactionDate").val(objSchemeReappropriationDetail.TransactionDateString);
            $("#dvManageSchemeReappropriation #btnToSaveDetail")
                .attr('onclick', "RC.ManageSchemeReappropriation.SchemeReappropriationToDetailSave(" + index + ");")
                .val('Update');
        }
        
    },
    SchemeReappropriationDetailReset: function () {
        $("#dvManageSchemeReappropriation #txtFromAmount").autoNumeric('set', '');
        $("#dvManageSchemeReappropriation #txtToAmount").autoNumeric('set', '');
        $("#dvManageSchemeReappropriation #btnFromSaveDetail")
            .attr('onclick', "RC.ManageSchemeReappropriation.SchemeReappropriationFromDetailSave(-1);")
            .val('Add');
        $("#dvManageSchemeReappropriation #btnToSaveDetail")
            .attr('onclick', "RC.ManageSchemeReappropriation.SchemeReappropriationToDetailSave(-1);")
            .val('Add');
    },
    SchemeReappropriationFromDetailSave: function (index) {
        var status = RC.ManageSchemeReappropriation.ValidateSchemeReappropriationDetail();

        if ($.trim($("#dvManageSchemeReappropriation #txtFromAmount").autoNumeric('get')) == "") {
            alert("Please provide amount.");

            status = false;
        }

        if (status) {
            var adjustedAmount = 0;

            if (index >= 0) {
                adjustedAmount = parseFloat(RC.ManageSchemeReappropriation.SchemeReappropriationObject.SchemeReappropriationDetailList[index].Amount);

                RC.ManageSchemeReappropriation.SchemeReappropriationObject.SchemeReappropriationDetailList.splice(index, 1);
            }

            var objSchemeReappropriationDetail = {
                FromFundTypeId: 0, FromSchemeId: 0, FromCOAId: 0, ToFundTypeId: 0, ToSchemeId: 0, ToCOAId: 0, FromSchemeTitle: '', ToSchemeTitle: '', FromCOAName: '',
                ToCOAName: '', TransactionDateString: '', Amount: 0
            };

            objSchemeReappropriationDetail.FromFundTypeId = ddlFCTFundType.GetSelectedItem().value;
            objSchemeReappropriationDetail.FromSchemeId = ddlFCTScheme.GetSelectedItem().value;
            objSchemeReappropriationDetail.FromCOAId = ddlFCTCOA.GetSelectedItem().value;
            objSchemeReappropriationDetail.FromSchemeTitle = ddlFCTScheme.GetSelectedItem().text;
            objSchemeReappropriationDetail.FromCOAName = ddlFCTCOA.GetSelectedItem().text;
            objSchemeReappropriationDetail.TransactionDate = $.trim($("#dvManageSchemeReappropriation #txtFromTransactionDate").val());
            objSchemeReappropriationDetail.Amount = parseFloat($("#dvManageSchemeReappropriation #txtFromAmount").autoNumeric('get'));
            objSchemeReappropriationDetail.TransactionDateString = objSchemeReappropriationDetail.TransactionDate;
            objSchemeReappropriationDetail.EditMode = 1;

            if (!$('#dvManageSchemeReappropriation #chkGroupTransaction').prop('checked')) {
                objSchemeReappropriationDetail.ToFundTypeId = ddlTCTFundType.GetSelectedItem().value;
                objSchemeReappropriationDetail.ToSchemeId = ddlTCTScheme.GetSelectedItem().value;
                objSchemeReappropriationDetail.ToCOAId = ddlTCTCOA.GetSelectedItem().value;
                objSchemeReappropriationDetail.ToSchemeTitle = ddlTCTScheme.GetSelectedItem().text;
                objSchemeReappropriationDetail.ToCOAName = ddlTCTCOA.GetSelectedItem().text;
            }

            var transactionAmount = parseFloat($('#dvManageSchemeReappropriation #dvTransactionAmount .desc').text().replace('Rs ', '').replace(/,/g, ''));

            transactionAmount = transactionAmount + objSchemeReappropriationDetail.Amount - adjustedAmount;

            $('#dvManageSchemeReappropriation #dvTransactionAmount .desc').html('Rs ' + transactionAmount);

            RC.ManageSchemeReappropriation.SchemeReappropriationObject.SchemeReappropriationDetailList.push(objSchemeReappropriationDetail);

            RC.ManageSchemeReappropriation.LoadSchemeReappropriationDetailView();
            RC.ManageSchemeReappropriation.SchemeReappropriationDetailReset();
        }
    },
    SchemeReappropriationToDetailSave: function (index) {
        var status = RC.ManageSchemeReappropriation.ValidateSchemeReappropriationDetail();

        if ($.trim($("#dvManageSchemeReappropriation #txtToAmount").autoNumeric('get')) == "") {
            alert("Please provide amount.");

            status = false;
        }

        if (status) {
            var adjustedAmount = 0;

            if (index >= 0) {
                adjustedAmount = parseFloat(RC.ManageSchemeReappropriation.SchemeReappropriationObject.SchemeReappropriationDetailList[index].Amount);

                RC.ManageSchemeReappropriation.SchemeReappropriationObject.SchemeReappropriationDetailList.splice(index, 1);
            }

            var objSchemeReappropriationDetail = {
                FromFundTypeId: 0, FromSchemeId: 0, FromCOAId: 0, ToFundTypeId: 0, ToSchemeId: 0, ToCOAId: 0, FromSchemeTitle: '', ToSchemeTitle: '', FromCOAName: '',
                ToCOAName: '', TransactionDateString: '', Amount: 0
            };

            objSchemeReappropriationDetail.ToFundTypeId = ddlTCTFundType.GetSelectedItem().value;
            objSchemeReappropriationDetail.ToSchemeId = ddlTCTScheme.GetSelectedItem().value;
            objSchemeReappropriationDetail.ToCOAId = ddlTCTCOA.GetSelectedItem().value;
            objSchemeReappropriationDetail.ToSchemeTitle = ddlTCTScheme.GetSelectedItem().text;
            objSchemeReappropriationDetail.ToCOAName = ddlTCTCOA.GetSelectedItem().text;
            objSchemeReappropriationDetail.TransactionDate = $.trim($("#dvManageSchemeReappropriation #txtToTransactionDate").val());
            objSchemeReappropriationDetail.Amount = parseFloat($("#dvManageSchemeReappropriation #txtToAmount").autoNumeric('get'));
            objSchemeReappropriationDetail.TransactionDateString = objSchemeReappropriationDetail.TransactionDate;
            objSchemeReappropriationDetail.EditMode = 2;

            if (!$('#dvManageSchemeReappropriation #chkGroupTransaction').prop('checked')) {
                objSchemeReappropriationDetail.FromFundTypeId = ddlFCTFundType.GetSelectedItem().value;
                objSchemeReappropriationDetail.FromSchemeId = ddlFCTScheme.GetSelectedItem().value;
                objSchemeReappropriationDetail.FromCOAId = ddlFCTCOA.GetSelectedItem().value;
                objSchemeReappropriationDetail.FromSchemeTitle = ddlFCTScheme.GetSelectedItem().text;
                objSchemeReappropriationDetail.FromCOAName = ddlFCTCOA.GetSelectedItem().text;
            }

            var transactionAmount = parseFloat($('#dvManageSchemeReappropriation #dvTransactionAmount .desc').text().replace('Rs ', '').replace(/,/g, ''));

            transactionAmount = (transactionAmount + adjustedAmount) - objSchemeReappropriationDetail.Amount;

            $('#dvManageSchemeReappropriation #dvTransactionAmount .desc').html('Rs ' + transactionAmount);

            RC.ManageSchemeReappropriation.SchemeReappropriationObject.SchemeReappropriationDetailList.push(objSchemeReappropriationDetail);

            RC.ManageSchemeReappropriation.LoadSchemeReappropriationDetailView();
            RC.ManageSchemeReappropriation.SchemeReappropriationDetailReset();
        }
    },
    SchemeReappropriationDetailDelete: function (fadIndex) {
        RC.ManageSchemeReappropriation.SchemeReappropriationObject.SchemeReappropriationDetailList.splice(fadIndex, 1);

        RC.ManageSchemeReappropriation.LoadSchemeReappropriationDetailView();
    },
    ValidateSchemeReappropriation: function () {
        var status = true;

        if (ddlCTSchemeFY.GetSelectedItem() == null) {
            alert("Please provide financial year.");

            status = false;
        }
        else if ($('#dvManageSchemeReappropriation #chkGroupTransaction').prop('checked') &&
            parseFloat($('#dvManageSchemeReappropriation #dvTransactionAmount .desc').text().replace('Rs ', '').replace(/,/g, '')) > 0) {
            alert("Transaction amount should be adjusted to zero.");

            status = false;
        }

        return status;
    },
    ValidateSchemeReappropriationDetail: function () {
        var status = true;

        if (ddlFCTScheme.GetSelectedItem() == null) {
            alert("Please provide scheme(from).");

            status = false;
        }
        else if (ddlFCTCOA.GetSelectedItem() == null) {
            alert("Please provide object code(from).");

            status = false;
        }
        else if (ddlTCTScheme.GetSelectedItem() == null) {
            alert("Please provide scheme(to).");

            status = false;
        }
        else if (ddlTCTCOA.GetSelectedItem() == null) {
            alert("Please provide object code(to).");

            status = false;
        }

        return status;
    },
    PopulateSchemeReappropriation: function () {
        var status = RC.ManageSchemeReappropriation.ValidateSchemeReappropriation();

        if (status) {
            var id = 0;

            if (RC.ManageSchemeReappropriation.SchemeReappropriationObject != null) {
                id = RC.ManageSchemeReappropriation.SchemeReappropriationObject.Id;
            }

            RC.ManageSchemeReappropriation.SchemeReappropriationObject.Id = id;
            RC.ManageSchemeReappropriation.SchemeReappropriationObject.FinancialYearId = ddlCTSchemeFY.GetSelectedItem().value;
            RC.ManageSchemeReappropriation.SchemeReappropriationObject.Month = ddlCTMonth.GetSelectedItem().value;

            for (var i = 0; i < RC.ManageSchemeReappropriation.SchemeReappropriationObject.SchemeReappropriationDetailList.length; i++) {
                var objSchemeReappropriationDetail = RC.ManageSchemeReappropriation.SchemeReappropriationObject.SchemeReappropriationDetailList[i];

                 objSchemeReappropriationDetail.TransactionDate = objSchemeReappropriationDetail.TransactionDateString;
            }
        }

        return status;
    },
    SaveSchemeReappropriation: function () {
        if (RC.ManageSchemeReappropriation.PopulateSchemeReappropriation()) {
            $('#dvManageSchemeReappropriation #btnSave').addClass("disabled").val('Wait...');

            RC.ManageSchemeReappropriation.AddUpdateSchemeReappropriation();
        }
    },
    AddUpdateSchemeReappropriation: function () {
        var handlerMethod = 'SchemeReappropriationAdd';

        if (RC.ManageSchemeReappropriation.SchemeReappropriationObject.Id > 0) {
            handlerMethod = 'SchemeReappropriationUpdate';
        }

        $.post(RC.ManageSchemeReappropriation.HandlerURL,
        {
            method: handlerMethod,
            objSchemeReappropriation: JSON.stringify(RC.ManageSchemeReappropriation.SchemeReappropriationObject)
        },
        function (response) {
            switch (response.Status) {
                case RC.Common.ResponseStatus.SUCCESS:
                    alert(response.Message);

                    $('#dvManageSchemeReappropriation #btnSave').val('Its done.');

                    window.location = RC.Common.RootURL + "Forms/frmSchemeReapproiation.aspx?LevelType=" + RC.Common.GetQueryStringByName('LevelType') + "&LevelID=" + RC.Common.GetQueryStringByName('LevelID');

                    break;
                case RC.Common.ResponseStatus.ERROR:
                    alert(response.Message);

                    $('#dvManageSchemeReappropriation #btnSave').removeClass("disabled").val('Save');

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
    ShowForeignFundingForFromScheme: function () {
        var isForeignFunding = (ddlFCTScheme.GetSelectedItem().texts[3].toLowerCase() == 'true');

        ddlFCTFundType.ClearItems();

        for (var i = 0; i < RC.ManageSchemeReappropriation.FundTypeList.length; i++) {
            var objFundType = RC.ManageSchemeReappropriation.FundTypeList[i];
            var addItem = true;

            if (!isForeignFunding) {
                if (objFundType.Title.toLowerCase() == "foreign funding") {
                    addItem = false;
                }
            }

            if (addItem) {
                ddlFCTFundType.AddItem(new Array(objFundType.Title), objFundType.Id.toString());
            }
        }

        ddlFCTFundType.SetSelectedIndex(0);
    },
    ShowForeignFundingForToScheme: function () {
        var isForeignFunding = (ddlTCTScheme.GetSelectedItem().texts[3].toLowerCase() == 'true');

        ddlTCTFundType.ClearItems();

        ddlTCTFundType.AddItem(new Array("Revenue"), "2");
        ddlTCTFundType.AddItem(new Array("Capital"), "1");

        if (isForeignFunding) {
            ddlTCTFundType.AddItem(new Array("Foreign Funding"), "3");
        }

        ddlTCTFundType.SetSelectedIndex(0);
    }
}

$(document).ready(function () {
    RC.ManageSchemeReappropriation.InitializePage();

    setTimeout(function () {
        RC.ManageSchemeReappropriation.ShowForeignFundingForFromScheme();
        RC.ManageSchemeReappropriation.ShowForeignFundingForToScheme();
    }, 1000);

    $('#dvManageSchemeReappropriation #txtFromAmount')
        .attr("data-a-sign", "Rs. ")
        .autoNumeric('init');
    $('#dvManageSchemeReappropriation #txtToAmount')
        .attr("data-a-sign", "Rs. ")
        .autoNumeric('init');

    $('#dvManageSchemeReappropriation #btnCancel').on('click', function () {
        window.location = RC.Common.RootURL + "Forms/frmSchemeReapproiation.aspx?LevelType=" + RC.Common.GetQueryStringByName('LevelType') + "&LevelID=" + RC.Common.GetQueryStringByName('LevelID');

        return false;
    });
});