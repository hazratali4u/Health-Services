var RC = RC || {};

RC.SchemeListing = {
    HandlerURL: RC.Common.RootURL + "Handler/SchemeHandler.ashx",
    SchemeList: [],
    SelectedIds: [],
    SchemeListTableInitialized: false,
    AllowEdit: true,
    InitializePage: function () {
        if (RC.SchemeListing.SchemeList != null && RC.SchemeListing.SchemeList != undefined && RC.SchemeListing.SchemeList.length > 0) {
            RC.SchemeListing.SchemeListTableInitialized = true;

            $('#dvSchemeListing #tblSchemeList').DataTable({
                "data": RC.SchemeListing.SchemeList,
                "columns": [
                    {
                        data: null,
                        className: "center",
                        orderable: false,
                        render: function (row, type, val, meta) {
                            return "<center><input type=\"checkbox\" schemeId=\"" + row.lngSchemeCode + "\" onclick=\"RC.SchemeListing.SaveSelectedScheme(this)\" /></center>";
                        },
                        defaultContent: ""
                    },
                    { "data": "strSchemeCode" },
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
                        visible: RC.SchemeListing.AllowEdit,
                        className: "center",
                        render: function (row, type, val, meta) {
                            var actionHtml = "<center><a title='Edit' href='" + RC.Common.RootURL + "Forms/frmSchemeAdd.aspx?LevelType=" + RC.Common.GetQueryStringByName('LevelType') +
                                "&LevelID=" + RC.Common.GetQueryStringByName('LevelID') + "&Id=" + row.lngSchemeCode + "&mode=" + RC.Common.GetQueryStringByName('mode') +
                                "'><i class='fa fa-pencil' aria-hidden='true'></i></a></center>";

                            if (RC.Common.GetQueryStringByName('mode') == 'ADP') {
                                if (parseInt(row.intCategoryID) != 1) {
                                    return "";
                                }
                                else {
                                    return actionHtml;
                                }
                            }
                            else if (RC.Common.GetQueryStringByName('mode') == "MPR") {
                                if (parseInt(row.intCategoryID) != 3 && parseInt(row.intCategoryID) != 4) {
                                    return "";
                                }
                                else {
                                    return actionHtml;
                                }
                            }
                            else {
                                return actionHtml;
                            }
                        },
                        orderable: false,
                        defaultContent: ""
                    }
                ],
                aaSorting: [[2, 'asc']]
            });

            $('#dvSchemeListing #tblSchemeList').on('page.dt', function () {
                $('#tblSchemeList input:checkbox[id="chkAll"]').prop('checked', false);
            });
        }
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
    SaveSelectedSchemes: function (selected) {
        $('#tblSchemeList input:checkbox').prop('checked', selected);

        $('#tblSchemeList input:checkbox').each(function (i) {
            var isChecked = $(this).prop("checked");
            var schemeId = parseInt($(this).attr("schemeId"));

            if (schemeId > 0) {
                RC.SchemeListing.SelectedIds = RC.SchemeListing.SelectedIds.filter(p => p !== schemeId);

                if (isChecked) {
                    RC.SchemeListing.SelectedIds.push(schemeId);
                }
            }
        });
    },
    SaveSelectedScheme: function (elem) {
        var isChecked = $(elem).prop("checked");
        var schemeId = parseInt($(elem).attr("schemeId"));

        if (schemeId > 0) {
            RC.SchemeListing.SelectedIds = RC.SchemeListing.SelectedIds.filter(p => p !== schemeId);

            if (isChecked) {
                RC.SchemeListing.SelectedIds.push(schemeId);
            }
        }
    },
    GetSelectedSchemes: function () {
        var schemeIds = "";

        RC.SchemeListing.SelectedIds.forEach(function (schemeId, index) {
            if (schemeIds == "") {
                schemeIds = schemeId;
            }
            else {
                schemeIds += "," + schemeId;
            }
        });

        return schemeIds;
    },
    RemoveSelectedSchemes: function () {
        for (var i = 0; i < RC.SchemeListing.SelectedIds.length; i++) {
            var schemeId = RC.SchemeListing.SelectedIds[i];

            RC.SchemeListing.SchemeList = RC.SchemeListing.SchemeList.filter(p => p.lngSchemeCode != schemeId);
        }

        RC.SchemeListing.SelectedIds = [];
    },
    SchemeUpdateStatus: function () {
        var schemeIds = RC.SchemeListing.GetSelectedSchemes();

        if (schemeIds == "") {
            alert("Please select any scheme.");
        }
        else {
            var result = confirm('Are you sure you want to perform this action?');

            if (result) {
                $("#btnStatus").addClass("disabled");
                $("#btnStatus span").removeClass('fa-check').addClass('fa-spinner fa-spin');

                $.post(RC.SchemeListing.HandlerURL,
                {
                    method: 'SchemeUpdateStatus',
                    SchemeIds: schemeIds,
                    CategoryId: $('#ddlSchemeCategory').val(),
                    FinancialYearId: ddlFY.GetSelectedItem().value
                },
                function (response) {
                    $("#btnStatus").removeClass("disabled");
                    $("#btnStatus span").removeClass('fa-spinner fa-spin').addClass('fa-check');

                    switch (response.Status) {
                        case RC.Common.ResponseStatus.SUCCESS:
                            RC.SchemeListing.RemoveSelectedSchemes();

                            for (var i = 0; i < response.Data.length; i++) {
                                var objScheme = response.Data[i];

                                RC.SchemeListing.SchemeList.push(objScheme);
                            }

                            RC.SchemeListing.ReloadPage();

                            alert(response.Message);

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
        }
    },
    SchemeUpdateActiveInActive: function () {
        var schemeIds = RC.SchemeListing.GetSelectedSchemes();

        if (schemeIds == "") {
            alert("Please select any scheme.");
        }
        else {
            var result = confirm('Are you sure you want to perform this action?');

            if (result) {
                $("#btnActive").addClass("disabled");
                $("#btnActive span").removeClass('fa-check').addClass('fa-spinner fa-spin');

                $.post(RC.SchemeListing.HandlerURL,
                {
                    method: 'SchemeUpdateActiveInActive',
                    SchemeIds: schemeIds,
                    FinancialYearId: ddlFY.GetSelectedItem().value
                },
                function (response) {
                    $("#btnActive").removeClass("disabled");
                    $("#btnActive span").removeClass('fa-spinner fa-spin').addClass('fa-check');

                    switch (response.Status) {
                        case RC.Common.ResponseStatus.SUCCESS:
                            RC.SchemeListing.RemoveSelectedSchemes();

                            for (var i = 0; i < response.Data.length; i++) {
                                var objScheme = response.Data[i];

                                RC.SchemeListing.SchemeList.push(objScheme);
                            }

                            RC.SchemeListing.ReloadPage();

                            alert(response.Message);

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
        }
    },
    SchemeUpdatePromote: function () {
        var schemeIds = RC.SchemeListing.GetSelectedSchemes();

        if (schemeIds == "") {
            alert("Please select any scheme.");
        }
        else {
            var index = ddlFY.GetSelectedIndex() + 1;
            var promotionFY = ddlFY.GetItem(index).text;
            var result = confirm('Are you sure you want to promote the selected schemes for FY ' + promotionFY + '?');

            if (result) {
                $("#btnPromoteSchemes").addClass("disabled");
                $("#btnPromoteSchemes span").removeClass('fa-check').addClass('fa-spinner fa-spin');

                $.post(RC.SchemeListing.HandlerURL,
                {
                    method: 'SchemeUpdatePromote',
                    SchemeIds: schemeIds,
                    FinancialYear: promotionFY,
                    FinancialYearId: ddlFY.GetSelectedItem().value
                },
                function (response) {
                    $("#btnPromoteSchemes").removeClass("disabled");
                    $("#btnPromoteSchemes span").removeClass('fa-spinner fa-spin').addClass('fa-check');

                    switch (response.Status) {
                        case RC.Common.ResponseStatus.SUCCESS:
                            RC.SchemeListing.RemoveSelectedSchemes();

                            for (var i = 0; i < response.Data.length; i++) {
                                var objScheme = response.Data[i];

                                RC.SchemeListing.SchemeList.push(objScheme);
                            }

                            RC.SchemeListing.ReloadPage();

                            alert(response.Message);

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
        }
    }
}

$(document).ready(function () {
    RC.SchemeListing.InitializePage();

    $("#dvSchemeListing #btnStatus").click(function () {
        RC.SchemeListing.SchemeUpdateStatus();

        return false;
    });
    $("#dvSchemeListing #btnPromoteSchemes").click(function () {
        RC.SchemeListing.SchemeUpdatePromote();

        return false;
    });
    $("#dvSchemeListing #btnActive").click(function () {
        RC.SchemeListing.SchemeUpdateActiveInActive();

        return false;
    });
    $('#dvSchemeListing #btnAdd').on('click', function () {
        window.location = RC.Common.RootURL + "Forms/frmSchemeAdd.aspx?LevelType=" + RC.Common.GetQueryStringByName('LevelType') + "&LevelID=" + RC.Common.GetQueryStringByName('LevelID') + "&mode=" + RC.Common.GetQueryStringByName('mode');

        return false;
    });
});