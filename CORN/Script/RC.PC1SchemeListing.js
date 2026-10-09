var RC = RC || {};

RC.SchemeListing = {
    HandlerURL: RC.Common.RootURL + "Handler/PC1SchemeHandler.ashx",
    SchemeList: [],
    SchemeListTableInitialized: false,
    InitializePage: function () {
        if (RC.SchemeListing.SchemeList != null && RC.SchemeListing.SchemeList != undefined && RC.SchemeListing.SchemeList.length > 0) {
            RC.SchemeListing.SchemeListTableInitialized = true;

            $('#dvSchemeListing #tblSchemeList').DataTable({
                "data": RC.SchemeListing.SchemeList,
                "columns": [
                    { "data": "strSchemeName" },
                    {
                        data: "CategoryTitle",
                        className: "center"
                    },
                    {
                        data: "dtmSchemeDateString",
                        className: "center",
                        orderable: false
                    },
                    {
                        data: "IsActiveString",
                        className: "center"
                    },
                    {
                        data: null,
                        className: "center",
                        render: function (row, type, val, meta) {
                            var actionHtml = "<center>";

                            if (row.SchemeId <= 0) {
                                actionHtml += "<a title='Edit' href='" + RC.Common.RootURL + "Forms/frmPC1SchemeAdd.aspx?LevelType=" +
                                    RC.Common.GetQueryStringByName('LevelType') + "&LevelID=" + RC.Common.GetQueryStringByName('LevelID') + "&Id=" + row.lngSchemeCode +
                                    "&categoryId=" + RC.Common.GetQueryStringByName('categoryId') + "'><i class='fa fa-pencil' aria-hidden='true'></i></a>&nbsp;&nbsp;";
                            }

                            actionHtml += "<a class='pc1schemereports' data-title='Reports' data-content=\"<ul class='list-group'>" +
                                "<li class='list-group-item' style='cursor: pointer;' onclick='RC.SchemeListing.OpenReport(14," + row.lngSchemeCode + ")'>PC1 Report</li>" +
                                "<li class='list-group-item' style='cursor: pointer;' onclick='RC.SchemeListing.OpenReport(15," + row.lngSchemeCode + ")'>Scheme Stage</li>" +
                                "<li class='list-group-item' style='cursor: pointer;' onclick='RC.SchemeListing.OpenReport(16," + row.lngSchemeCode + ")'>Scheme Status</li>" +
                                "<li class='list-group-item' style='cursor: pointer;' onclick='RC.SchemeListing.OpenReport(17," + row.lngSchemeCode + ")'>Scheme Revision</li>" +
                                "</ul>\" data-placement='left' data-animation='pop'><i class='fa fa-bar-chart-o' aria-hidden='true'></i></a></center>";

                            return actionHtml;
                        },
                        orderable: false,
                        defaultContent: ""
                    }
                ],
                aaSorting: [[1, 'asc']]
            });
        }
    },
    ValidateScheme: function () {
        var status = true;

        if ($.trim($("#dvSchemeDetail #txtTitle").val()) == "") {
            alert("Please provide title.");

            status = false;
        }

        return status;
    },
    PopulateScheme: function () {
        var status = RC.SchemeListing.ValidateScheme();
        var currentDateTime = new Date();
        var currentDate = currentDateTime.getDate() + '-' + currentDateTime.getShortMonthName() + '-' + currentDateTime.getFullYear();

        if (status) {
            RC.SchemeListing.SchemeObject = { Id: 0, strSchemeName: '', intCategoryID: 1, strRemarks: '' };
            RC.SchemeListing.SchemeObject.strSchemeName = $("#dvSchemeDetail #txtTitle").val();
            RC.SchemeListing.SchemeObject.dtmSchemeDate = currentDate;
            RC.SchemeListing.SchemeObject.dtmStartDate = currentDate;
            RC.SchemeListing.SchemeObject.dtmEndDate = currentDate;
        }

        return status;
    },
    ResetScheme: function () {
        RC.SchemeListing.SchemeObject = null;

        $("#dvSchemeDetail #txtTitle").val('');
        $('#dvSchemeDetail #btnSave').removeClass("disabled").text('Save');
    },
    ReloadPage: function () {
        if (RC.SchemeListing.SchemeListTableInitialized) {
            $('#dvSchemeListing #tblSchemeList').dataTable().fnClearTable();

            if (RC.SchemeListing.SchemeList != null && RC.SchemeListing.SchemeList != undefined && RC.SchemeListing.SchemeList.length > 0) {
                $('#dvSchemeListing #tblSchemeList').dataTable().fnAddData(RC.SchemeListing.SchemeList);
                $('#dvSchemeListing #tblSchemeList').dataTable().fnDraw();
            }
        }
        else {
            RC.SchemeListing.InitializePage();
        }
    },
    SaveScheme: function () {
        if (RC.SchemeListing.PopulateScheme()) {
            $('#dvSchemeDetail #btnSave').addClass("disabled").text('Wait...');

            RC.SchemeListing.AddUpdateScheme();
        }
    },
    AddUpdateScheme: function () {
        $.post(RC.SchemeListing.HandlerURL,
        {
            method: 'SchemeAdd',
            objScheme: JSON.stringify(RC.SchemeListing.SchemeObject)
        },
        function (response) {
            switch (response.Status) {
                case RC.Common.ResponseStatus.SUCCESS:
                    alert(response.Message);

                    RC.SchemeListing.SchemeList.insert(0, response.Data);

                    RC.SchemeListing.ReloadPage();
                    RC.SchemeListing.ResetScheme();

                    $('#dvSchemeDetail #btnClose')[0].click();

                    break;
                case RC.Common.ResponseStatus.ERROR:
                    alert(response.Message);

                    $('#dvSchemeDetail #btnSave').removeClass("disabled").text('Save');

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
    OpenReport: function (reportId, schemeId) {
        window.location = RC.Common.RootURL + "Forms/frmReportViewer.aspx?LevelType=" + RC.Common.GetQueryStringByName('LevelType') +
            "&LevelID=" + RC.Common.GetQueryStringByName('LevelID') + "&report=" + reportId + "&SchemeId=" + schemeId;
    }
}

$(document).ready(function () {
    RC.SchemeListing.InitializePage();

    $('a.pc1schemereports', '#dvSchemeListing #tblSchemeList').webuiPopover();

    setTimeout(function () {
        $('#dvSchemeListing #btnAdd')[0].click();

        setTimeout(function () {
            $('#dvSchemeDetail #btnClose')[0].click();
        }, 50);
    }, 1000);
});