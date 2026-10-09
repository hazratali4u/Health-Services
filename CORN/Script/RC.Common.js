var RC = RC || {};

RC.Common = {
    RootURL: "",
    DashboardHandlerURL: "Handler/DashboardHandler.ashx",
    LoginPath: "",
    Domain: "",
    GetLoginURL: function () {
        return RC.Common.RootURL + RC.Common.LoginPath;
    },
    ResponseStatus: {
        ERROR: "Error",
        SUCCESS: "Success",
        SESSIONEXPIRED: "SessionExpired"
    },
    SchemeFundType: {
        CAPITAL: 1,
        REVENUE: 2,
        FOREIGNFUNDING: 3
    },
    ExpenseBookingType: {
        COMMITMENT: 1,
        ACTUAL: 2
    },
    GeoHierarchyType: {
        REGION: 50,
        DIVISION: 51,
        DISTRICT: 52,
        TEHSIL: 53,
        CONSTITUENCY: 54
    },
    PC1SchemeWizardHeading: {
        Step1: "Project Detail",
        Step2: "Location",
        Step3: "Authorities Responsible for",
        Step4: "Plan Provision",
        Step5: "Project Objectives",
        Step6: "Description and Justification of Project",
        Step7: "Capital Cost Estimates",
        Step8: "Annual Operating Cost",
        Step9: "Demand Supply Analysis",
        Step10: "Financial Plan",
        Step11: "Project Benefits and Analysis",
        Step12: "Implementation of the Project",
        Step13: "Management Structure and Manpower Requirements",
        Step14: "Additional Projects/Decisions Required",
        Step15: "Certificate",
        Step16: "Document"
    },
    FormatNumber: function (val) {
        while (/(\d+)(\d{3})/.test(val.toString())) {
            val = val.toString().replace(/(\d+)(\d{3})/, '$1' + ',' + '$2');
        }

        return val;
    },
    SignOut: function () {
        $.post(RC.Common.RootURL + RC.Common.DashboardHandlerURL,
        {
            method: 'SignOut'
        },
        function (response) {
            switch (response.Status) {
                case RC.Common.ResponseStatus.SUCCESS:
                    window.location = RC.Common.GetLoginURL();

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
    KeepSessionAlive: function () {
        $.post(RC.Common.RootURL + RC.Common.DashboardHandlerURL,
        {
            method: 'KeepSessionAlive'
        },
        function (response) {
            switch (response.Status) {
                case RC.Common.ResponseStatus.SUCCESS:
                    setTimeout(function () { RC.Common.KeepSessionAlive(); }, 10000);

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
    GetQueryStringByName: function (name, url) {
        if (!url) url = window.location.href;
        name = name.replace(/[\[\]]/g, "\\$&");
        var regex = new RegExp("[?&]" + name + "(=([^&#]*)|&|#|$)"),
            results = regex.exec(url);
        if (!results) return '';
        if (!results[2]) return '';
        return decodeURIComponent(results[2].replace(/\+/g, " "));
    },
    SortBy: function (field, reverse, primer) {
        var key = primer ?
            function (x) { return primer(x[field]) } :
            function (x) { return x[field] };

        reverse = !reverse ? 1 : -1;

        return function (a, b) {
            return a = key(a), b = key(b), reverse * ((a > b) - (b > a));
        }
    }
}

Date.prototype.monthNames = [
    "January", "February", "March",
    "April", "May", "June",
    "July", "August", "September",
    "October", "November", "December"
];
Date.prototype.getMonthName = function () {
    return this.monthNames[this.getMonth()];
};
Date.prototype.getShortMonthName = function () {
    return this.getMonthName().substr(0, 3);
};
Array.prototype.insert = function (index, item) {
    this.splice(index, 0, item);
};