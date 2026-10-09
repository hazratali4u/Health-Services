var RC = RC || {};

RC.ManageScheme = {
    HandlerURL: RC.Common.RootURL + "Handler/SchemeHandler.ashx",
    SchemeObject: null,
    SchemeFY: '',
    DistributorList: [],
    SchemeGSCodeList: [],
    InitializePage: function () {
        if (RC.ManageScheme.SchemeObject != null) {
            $("#dvManageScheme #txtSchemeName").val(RC.ManageScheme.SchemeObject.strSchemeName);
            $("#dvManageScheme #txtCapitalCode").val(RC.ManageScheme.SchemeObject.strCapitalCode);
            $("#dvManageScheme #txtCapitalAmount").val(RC.ManageScheme.SchemeObject.decCapitalAmount);
            $("#dvManageScheme #txtRevenueCode").val(RC.ManageScheme.SchemeObject.strSchemeCode);
            $("#dvManageScheme #txtRevenueAmount").val(RC.ManageScheme.SchemeObject.decRevenueAmount);
            $("#dvManageScheme #txtSchemeDate").val(RC.ManageScheme.SchemeObject.dtmSchemeDateString);
            $("#dvManageScheme #txtRecurringCostPercent").val(RC.ManageScheme.SchemeObject.decYearlyCostPer);
            $("#dvManageScheme #txtRecurringCostAmount").val(RC.ManageScheme.SchemeObject.decYearlyCostAmount);
            $("#dvManageScheme #txtStartDate").val(RC.ManageScheme.SchemeObject.dtmStartDateString);
            $("#dvManageScheme #txtEndDate").val(RC.ManageScheme.SchemeObject.dtmEndDateString);
            $("#dvManageScheme #txtLastYearExpense").val(RC.ManageScheme.SchemeObject.decLastYearExpense);
            $("#dvManageScheme #txtRemarks").val(RC.ManageScheme.SchemeObject.strRemarks);
            $('#dvManageScheme #chkForeignFunding').prop('checked', RC.ManageScheme.SchemeObject.IsForeignFunding);

            SetSchemeStatus();

            setTimeout(function () { RC.ManageScheme.PopulateYearWiseDate(); }, 2000);
        }
        else {
            RC.ManageScheme.SchemeObject = {
                lngSchemeCode: 0, strSchemeCode: '', strSchemeName: '', intInstituteID: 0, intSubSectorID: 0, intCategoryID: 0, intFCAccountHeadID: 0,
                intRFCAccountHeadID: 0, intBankTypeID: 0, strRemarks: '', decYearlyCostPer: 0, decYearlyCostAmount: 0, dtmSchemeDateString: '', dtmStartDateString: '',
                dtmEndDateString: '', strCapitalCode: '', decRevenueAmount: 0, decCapitalAmount: 0, decLastYearExpense: 0, strGSCode: '', dtmFinancialYearString: '',
                SchemeStatusId: 0, ParentSchemeId: 0, IsForeignFunding: false, SchemeFY: ''
            };
        }

        RC.ManageScheme.PopulateForInstitute();
    },
    ValidateScheme: function () {
        var status = true;

        if ($.trim($("#dvManageScheme #txtSchemeName").val()) == "") {
            alert("Please provide scheme name.");

            status = false;
        }
        else if (ddlCOA.GetSelectedItem() == null) {
            alert("Please provide functional classification(capital).");

            status = false;
        }
        else if (ddlInstitute.GetSelectedItem() == null) {
            alert("Please provide spending unit.");

            status = false;
        }
        else if (ddlRCOA.GetSelectedItem() == null) {
            alert("Please provide functional classification(revenue).");

            status = false;
        }
        else if (ddlCOA.GetSelectedItem().value == 0 && ddlRCOA.GetSelectedItem().value == 0) {
            alert("Please provide at least functional classification(capital) or functional classification(revenue).");

            status = false;
        }
        else if (ddlSubSector.GetSelectedItem() == null) {
            alert("Please provide sub sector.");

            status = false;
        }
        else if ($.trim($("#dvManageScheme #txtSchemeDate").val()) == "") {
            alert("Please provide scheme date.");

            status = false;
        }
        else if ($('#dvTypeOfBand').is(":visible") == true && ddlTypeOfBank.GetSelectedItem() == null) {
            alert("Please provide type of bank.");

            status = false;
        }
        else if (ddlCategory.GetSelectedItem() == null) {
            alert("Please provide status.");

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
        else if (RC.Common.GetQueryStringByName('mode') == 'ADP') {
            var nextFYYearValue = parseInt(document.getElementById('hfNextFYYear').value);
            var date1 = document.getElementById("txtStartDate").value;
            var date2 = document.getElementById("txtEndDate").value;
            var startdt = date1.split('-');
            var enddt = date2.split('-');
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

            if (gsYearValue < nextFYYearValue ||
                (gsYearValue == nextFYYearValue && gsMonthValue <= 6)) {
                alert('Start Date should be greater than Jun ' + nextFYYearValue + '.');

                status = false;
            }
            else if (geYearValue < nextFYYearValue ||
                (geYearValue == nextFYYearValue && geMonthValue <= 6)) {
                alert('End Date should be greater than Jun ' + nextFYYearValue + '.');

                status = false;
            }
        }
        else if ((ddlCTSchemeStatus.GetSelectedItem() != null && ddlCTSchemeStatus.GetSelectedItem().value == 2) &&
            (ddlCTParentScheme.GetSelectedItem() == null || ddlCTParentScheme.GetSelectedItem().value == 0)) {
            alert("Please provide parent scheme.");

            status = false;
        }

        return status;
    },
    PopulateScheme: function () {
        var status = RC.ManageScheme.ValidateScheme();

        if (status) {
            var lngSchemeCode = 0;

            if (RC.ManageScheme.SchemeObject != null) {
                lngSchemeCode = RC.ManageScheme.SchemeObject.lngSchemeCode;
            }

            RC.ManageScheme.SchemeObject.lngSchemeCode = lngSchemeCode;
            RC.ManageScheme.SchemeObject.strSchemeCode = $.trim($("#dvManageScheme #txtRevenueCode").val());
            RC.ManageScheme.SchemeObject.strSchemeName = $.trim($("#dvManageScheme #txtSchemeName").val());
            RC.ManageScheme.SchemeObject.intInstituteID = ddlInstitute.GetSelectedItem().value;
            RC.ManageScheme.SchemeObject.intSubSectorID = ddlSubSector.GetSelectedItem().value;
            RC.ManageScheme.SchemeObject.intCategoryID = ddlCategory.GetSelectedItem().value;
            RC.ManageScheme.SchemeObject.intFCAccountHeadID = ddlCOA.GetSelectedItem().value;
            RC.ManageScheme.SchemeObject.intRFCAccountHeadID = ddlRCOA.GetSelectedItem().value;
            RC.ManageScheme.SchemeObject.intBankTypeID = $('#dvTypeOfBand').is(":visible") == true ? ddlTypeOfBank.GetSelectedItem().value : 0;
            RC.ManageScheme.SchemeObject.strRemarks = $.trim($("#dvManageScheme #txtRemarks").val());
            RC.ManageScheme.SchemeObject.decYearlyCostPer = $("#dvManageScheme #txtRecurringCostPercent").is(":visible") == true ? parseFloat($("#dvManageScheme #txtRecurringCostPercent").val() == "" ? 0 : $("#dvManageScheme #txtRecurringCostPercent").val()) : 0;
            RC.ManageScheme.SchemeObject.decYearlyCostAmount = $('#dvYearlyCost').is(":visible") == true ? parseFloat($("#dvManageScheme #txtRecurringCostAmount").autoNumeric('get') == "" ? 0 : $("#dvManageScheme #txtRecurringCostAmount").autoNumeric('get')) : 0;
            RC.ManageScheme.SchemeObject.dtmSchemeDate = $.trim($("#dvManageScheme #txtSchemeDate").val());
            RC.ManageScheme.SchemeObject.dtmStartDate = $.trim($("#dvManageScheme #txtStartDate").val());
            RC.ManageScheme.SchemeObject.dtmEndDate = $.trim($("#dvManageScheme #txtEndDate").val());
            RC.ManageScheme.SchemeObject.strCapitalCode = $.trim($("#dvManageScheme #txtCapitalCode").val());
            RC.ManageScheme.SchemeObject.decRevenueAmount = $('#dvSAPRevenue').is(":visible") == true ? parseFloat($("#dvManageScheme #txtRevenueAmount").autoNumeric('get') == "" ? 0 : $("#dvManageScheme #txtRevenueAmount").autoNumeric('get')) : 0;
            RC.ManageScheme.SchemeObject.decCapitalAmount = $("#dvManageScheme #txtCapitalAmount").is(":visible") == true ? parseFloat($("#dvManageScheme #txtCapitalAmount").autoNumeric('get') == "" ? 0 : $("#dvManageScheme #txtCapitalAmount").autoNumeric('get')) : 0;
            RC.ManageScheme.SchemeObject.decLastYearExpense = parseFloat($("#dvManageScheme #txtLastYearExpense").autoNumeric('get') == "" ? 0 : $("#dvManageScheme #txtLastYearExpense").autoNumeric('get'));
            RC.ManageScheme.SchemeObject.strGSCode = $.trim($("#dvManageScheme #txtGSCode").val());
            RC.ManageScheme.SchemeObject.dtmFinancialYear = ddlFinancialYear.GetSelectedItem().value + "-" + "01" + "-01";
            RC.ManageScheme.SchemeObject.SchemeStatusId = ddlCTSchemeStatus.GetSelectedItem() == null ? 0 : ddlCTSchemeStatus.GetSelectedItem().value;
            RC.ManageScheme.SchemeObject.IsForeignFunding = $('#dvManageScheme #chkForeignFunding').prop('checked');
            RC.ManageScheme.SchemeObject.SchemeFY = RC.ManageScheme.SchemeFY;

            if (RC.ManageScheme.SchemeObject.SchemeStatusId == 2) {
                RC.ManageScheme.SchemeObject.ParentSchemeId = ddlCTParentScheme.GetSelectedItem().value;
            }
            else {
                RC.ManageScheme.SchemeObject.ParentSchemeId = 0;
            }
        }

        return status;
    },
    SaveScheme: function () {
        if (RC.ManageScheme.PopulateScheme()) {
            $('#dvManageScheme #btnSave').addClass("disabled").val('Wait...');

            RC.ManageScheme.AddUpdateScheme();
        }
    },
    AddUpdateScheme: function () {
        var handlerMethod = 'SchemeAdd';

        if (RC.ManageScheme.SchemeObject.lngSchemeCode > 0) {
            handlerMethod = 'SchemeUpdate';
        }

        $.post(RC.ManageScheme.HandlerURL,
        {
            method: handlerMethod,
            objScheme: JSON.stringify(RC.ManageScheme.SchemeObject)
        },
        function (response) {
            switch (response.Status) {
                case RC.Common.ResponseStatus.SUCCESS:
                    alert(response.Message);

                    $('#dvManageScheme #btnSave').val('Its done.');

                    window.location = RC.Common.RootURL + "Forms/frmSchemes.aspx?LevelType=" + RC.Common.GetQueryStringByName('LevelType') + "&LevelID=" + RC.Common.GetQueryStringByName('LevelID') + "&mode=" + RC.Common.GetQueryStringByName('mode');

                    break;
                case RC.Common.ResponseStatus.ERROR:
                    alert(response.Message);

                    $('#dvManageScheme #btnSave').removeClass("disabled").val('Save');

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
    PopulateYearWiseDate: function () {
        var date1 = document.getElementById("txtStartDate").value;
        var date2 = document.getElementById("txtEndDate").value;
        var startdt = date1.split('-');
        var enddt = date2.split('-');
        var selValue = ddlFinancialYear.GetValue();
        var selIndex = 0;
        var index = 0;
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

        ddlFinancialYear.ClearItems();

        while (gsYearValue <= geYearValue) {
            if ((gsMonthValue <= 6 && gsYearValue <= geYearValue) ||
                (geYearValue == gsYearValue) ||
                (gsYearValue > parseInt(startdt[2]) && gsYearValue < geYearValue)) {
                var gsYearTitle = (gsYearValue - 1).toString();

                gsYearTitle += "-" + gsYearValue.toString();

                if (gsYearValue == selValue) {
                    selIndex = index;
                }
                else {
                    index++;
                }

                ddlFinancialYear.AddItem(gsYearTitle, gsYearValue);
            }

            gsYearValue++;
        }

        ddlFinancialYear.SetSelectedIndex(selIndex);

        RC.ManageScheme.PopulateForGSCode();
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
    PopulateForGSCode: function () {
        $("#dvManageScheme #txtGSCode").val('');

        var financialYearValue = parseInt(ddlFinancialYear.GetSelectedItem().value);

        for (var i = 0; i < RC.ManageScheme.SchemeGSCodeList.length; i++) {
            var objSchemeGSCode = RC.ManageScheme.SchemeGSCodeList[i];

            if (parseInt(objSchemeGSCode.dtmFinancialYearValue) == financialYearValue) {
                $("#dvManageScheme #txtGSCode").val(objSchemeGSCode.strGSCode);

                break;
            }
        }
    }
}

$(document).ready(function () {
    RC.ManageScheme.InitializePage();

    $('#txtCapitalAmount')
        .attr("data-a-sign", "Rs. ")
        .autoNumeric('init');

    $('#txtRevenueAmount')
        .attr("data-a-sign", "Rs. ")
        .autoNumeric('init');

    $('#txtRecurringCostAmount')
        .attr("data-a-sign", "Rs. ")
        .autoNumeric('init');

    $('#txtLastYearExpense')
        .attr("data-a-sign", "Rs. ")
        .autoNumeric('init');

    $('#dvManageScheme #btnCancel').on('click', function () {
        window.location = RC.Common.RootURL + "Forms/frmSchemes.aspx?LevelType=" + RC.Common.GetQueryStringByName('LevelType') + "&LevelID=" + RC.Common.GetQueryStringByName('LevelID') + "&mode=" + RC.Common.GetQueryStringByName('mode');

        return false;
    });
});