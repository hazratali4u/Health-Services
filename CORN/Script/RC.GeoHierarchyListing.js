var RC = RC || {};

RC.GeoHierarchyListing = {
    HandlerURL: RC.Common.RootURL + "Handler/GeoHierarchyHandler.ashx",
    GeoHierarchyList: [],
    GeoHierarchyObject: null,
    GeoHierarchyListTable: null,
    GeoHierarchyListTableInitialized: false,
    LoadViewForSelectedType: function () {
        var geoHierarchyList = RC.GeoHierarchyListing.GetGeoHierarchyListForSelectedType();

        if (!RC.GeoHierarchyListing.GeoHierarchyListTableInitialized) {
            if (geoHierarchyList.length > 0) {
                RC.GeoHierarchyListing.GeoHierarchyListTableInitialized = true;

                $('#dvGeoHierarchyListing #tblGeoHierarchyList').DataTable({
                    "data": geoHierarchyList,
                    "columns": [
                        { "data": "Code" },
                        { "data": "Name" },
                        {
                            "data": "IsActive",
                            className: "center"
                        },
                        {
                            data: null,
                            className: "center",
                            render: function (row, type, val, meta) {
                                return "<center><a title='Edit' href='javascript:void(0)' onclick='RC.GeoHierarchyListing.GeoHierarchyGetId(" + row.Id + ")'>" +
                                    "<i id='iedit" + row.Id + "' class='fa fa-pencil' aria-hidden='true'></i></a>&nbsp;" +
                                    "<a title='Delete' href='javascript:void(0)' onclick='RC.GeoHierarchyListing.GeoHierarchyDelete(" + row.Id + ")'>" +
                                    "<i id='idel" + row.Id + "' class='fa fa-trash-o' aria-hidden='true'></i></a></center>";
                            },
                            orderable: false,
                            defaultContent: ""
                        }
                    ],
                    aaSorting: [[1, 'asc']]
                });
            }
        }
        else {
            $('#dvGeoHierarchyListing #tblGeoHierarchyList').dataTable().fnClearTable();

            if (geoHierarchyList.length > 0) {
                $('#dvGeoHierarchyListing #tblGeoHierarchyList').dataTable().fnAddData(geoHierarchyList);
            }

            $('#dvGeoHierarchyListing #tblGeoHierarchyList').dataTable().fnDraw();
        }
    },
    GetGeoHierarchyList: function (typeId, parentId) {
        var lstGeoHierarchy = [];

        if (RC.GeoHierarchyListing.GeoHierarchyList != null && RC.GeoHierarchyListing.GeoHierarchyList != undefined) {
            $(RC.GeoHierarchyListing.GeoHierarchyList).each(function (index, item) {
                if (item.TypeId == typeId && item.ParentId == parentId) {
                    lstGeoHierarchy.push(item);
                }
            });
        }

        return lstGeoHierarchy.sort(RC.Common.SortBy('Name', false, null));
    },
    GetGeoHierarchyListForSelectedType: function () {
        var selectedTypeId = RC.GeoHierarchyListing.GetTypeIdForSelectedView();
        var selectedParentId = RC.GeoHierarchyListing.GetParentIdForSelectedView();
        var lstGeoHierarchyForType = [];

        if (RC.GeoHierarchyListing.GeoHierarchyList != null && RC.GeoHierarchyListing.GeoHierarchyList != undefined) {
            $(RC.GeoHierarchyListing.GeoHierarchyList).each(function (index, item) {
                if (item.TypeId == selectedTypeId && item.ParentId == selectedParentId) {
                    lstGeoHierarchyForType.push(item);
                }
            });
        }

        return lstGeoHierarchyForType;
    },
    GetTypeIdForSelectedView: function () {
        var typeId = RC.Common.GeoHierarchyType.REGION;

        if ($('#dvGeoHierarchyListing #btnDivision').hasClass('btn-primary')) {
            typeId = RC.Common.GeoHierarchyType.DIVISION;
        }
        else if ($('#dvGeoHierarchyListing #btnDistrict').hasClass('btn-primary')) {
            typeId = RC.Common.GeoHierarchyType.DISTRICT;
        }
        else if ($('#dvGeoHierarchyListing #btnTehsil').hasClass('btn-primary')) {
            typeId = RC.Common.GeoHierarchyType.TEHSIL;
        }
        else if ($('#dvGeoHierarchyListing #btnConstituency').hasClass('btn-primary')) {
            typeId = RC.Common.GeoHierarchyType.CONSTITUENCY;
        }

        return typeId;
    },
    GetParentIdForSelectedView: function () {
        var selectedTypeId = RC.GeoHierarchyListing.GetTypeIdForSelectedView();
        var parentId = 0;

        if (selectedTypeId == RC.Common.GeoHierarchyType.DIVISION && ddlCTRegion.GetSelectedItem() != null) {
            parentId = parseInt(ddlCTRegion.GetSelectedItem().value);
        }
        else if (selectedTypeId == RC.Common.GeoHierarchyType.DISTRICT && ddlCTDivision.GetSelectedItem() != null) {
            parentId = parseInt(ddlCTDivision.GetSelectedItem().value);
        }
        else if (selectedTypeId == RC.Common.GeoHierarchyType.TEHSIL && ddlCTDistrict.GetSelectedItem() != null) {
            parentId = parseInt(ddlCTDistrict.GetSelectedItem().value);
        }
        else if (selectedTypeId == RC.Common.GeoHierarchyType.CONSTITUENCY && ddlCTTehsil.GetSelectedItem() != null) {
            parentId = parseInt(ddlCTTehsil.GetSelectedItem().value);
        }

        return parentId;
    },
    UpdateViewForSelectedType: function (typeId) {
        $("#btnRegion,#btnDivision,#btnDistrict,#btnTehsil,#btnConstituency")
            .removeClass('btn btn-primary')
            .removeClass('btn btn-default')
            .removeClass('btn btn-primary')
            .addClass('btn btn-default');
        $("#dvFilterRegion,#dvFilterDivision,#dvFilterDistrict,#dvFilterTehsil").hide();

        if (typeId == RC.Common.GeoHierarchyType.REGION) {
            $("#btnRegion")
                .removeClass('btn btn-default')
                .removeClass('btn btn-primary')
                .addClass('btn btn-primary');
        }
        else if (typeId == RC.Common.GeoHierarchyType.DIVISION) {
            $("#btnDivision")
                .removeClass('btn btn-default')
                .removeClass('btn btn-primary')
                .addClass('btn btn-primary');
            $("#dvFilterRegion").show();
        }
        else if (typeId == RC.Common.GeoHierarchyType.DISTRICT) {
            $("#btnDistrict")
                .removeClass('btn btn-default')
                .removeClass('btn btn-primary')
                .addClass('btn btn-primary');
            $("#dvFilterRegion,#dvFilterDivision").show();
        }
        else if (typeId == RC.Common.GeoHierarchyType.TEHSIL) {
            $("#btnTehsil")
                .removeClass('btn btn-default')
                .removeClass('btn btn-primary')
                .addClass('btn btn-primary');
            $("#dvFilterRegion,#dvFilterDivision,#dvFilterDistrict").show();
        }
        else if (typeId == RC.Common.GeoHierarchyType.CONSTITUENCY) {
            $("#btnConstituency")
                .removeClass('btn btn-default')
                .removeClass('btn btn-primary')
                .addClass('btn btn-primary');
            $("#dvFilterRegion,#dvFilterDivision,#dvFilterDistrict,#dvFilterTehsil").show();
        }

        RC.GeoHierarchyListing.PopulateFilterCriteria();
        RC.GeoHierarchyListing.LoadViewForSelectedType();
    },
    FilterViewForRegion: function () {
        RC.GeoHierarchyListing.PopulateFilterDivision();
        RC.GeoHierarchyListing.PopulateFilterDistrict();
        RC.GeoHierarchyListing.PopulateFilterTehsil();
        RC.GeoHierarchyListing.LoadViewForSelectedType();
    },
    FilterViewForDivision: function () {
        RC.GeoHierarchyListing.PopulateFilterDistrict();
        RC.GeoHierarchyListing.PopulateFilterTehsil();
        RC.GeoHierarchyListing.LoadViewForSelectedType();
    },
    FilterViewForDistrict: function () {
        RC.GeoHierarchyListing.PopulateFilterTehsil();
        RC.GeoHierarchyListing.LoadViewForSelectedType();
    },
    FilterViewForTehsil: function () {
        RC.GeoHierarchyListing.LoadViewForSelectedType();
    },
    PopulateFilterCriteria: function () {
        RC.GeoHierarchyListing.PopulateFilterRegion();
        RC.GeoHierarchyListing.PopulateFilterDivision();
        RC.GeoHierarchyListing.PopulateFilterDistrict();
        RC.GeoHierarchyListing.PopulateFilterTehsil();
    },
    PopulateFilterRegion: function () {
        if ($("#dvFilterRegion").is(":visible")) {
            var lstRegion = RC.GeoHierarchyListing.GetGeoHierarchyList(RC.Common.GeoHierarchyType.REGION, 0);
            var selIndex = (ddlCTRegion.GetSelectedIndex() <= 0 ? 0 : ddlCTRegion.GetSelectedIndex());

            ddlCTRegion.ClearItems();

            $(lstRegion).each(function (index, item) {
                ddlCTRegion.AddItem(new Array(item.Code, item.Name), item.Id.toString());
            });

            ddlCTRegion.SetSelectedIndex(selIndex);
        }
    },
    PopulateFilterDivision: function () {
        if ($("#dvFilterDivision").is(":visible")) {
            var lstDivision = RC.GeoHierarchyListing.GetGeoHierarchyList(RC.Common.GeoHierarchyType.DIVISION, (ddlCTRegion.GetSelectedItem() == null ? 0 : parseInt(ddlCTRegion.GetSelectedItem().value)));
            var selIndex = (ddlCTDivision.GetSelectedIndex() <= 0 ? 0 : ddlCTDivision.GetSelectedIndex());

            ddlCTDivision.ClearItems();

            $(lstDivision).each(function (index, item) {
                ddlCTDivision.AddItem(new Array(item.Code, item.Name), item.Id.toString());
            });

            ddlCTDivision.SetSelectedIndex(selIndex);
        }
    },
    PopulateFilterDistrict: function () {
        if ($("#dvFilterDistrict").is(":visible")) {
            var lstDistrict = RC.GeoHierarchyListing.GetGeoHierarchyList(RC.Common.GeoHierarchyType.DISTRICT, (ddlCTDivision.GetSelectedItem() == null ? 0 : parseInt(ddlCTDivision.GetSelectedItem().value)));
            var selIndex = (ddlCTDistrict.GetSelectedIndex() <= 0 ? 0 : ddlCTDistrict.GetSelectedIndex());

            ddlCTDistrict.ClearItems();

            $(lstDistrict).each(function (index, item) {
                ddlCTDistrict.AddItem(new Array(item.Code, item.Name), item.Id.toString());
            });

            ddlCTDistrict.SetSelectedIndex(selIndex);
        }
    },
    PopulateFilterTehsil: function () {
        if ($("#dvFilterTehsil").is(":visible")) {
            var lstTehsil = RC.GeoHierarchyListing.GetGeoHierarchyList(RC.Common.GeoHierarchyType.TEHSIL, (ddlCTDistrict.GetSelectedItem() == null ? 0 : parseInt(ddlCTDistrict.GetSelectedItem().value)));
            var selIndex = (ddlCTTehsil.GetSelectedIndex() <= 0 ? 0 : ddlCTTehsil.GetSelectedIndex());

            ddlCTTehsil.ClearItems();

            $(lstTehsil).each(function (index, item) {
                ddlCTTehsil.AddItem(new Array(item.Code, item.Name), item.Id.toString());
            });

            ddlCTTehsil.SetSelectedIndex(selIndex);
        }
    },
    ValidateGeoHierarchy: function () {
        var typeId = RC.GeoHierarchyListing.GetTypeIdForSelectedView();
        var status = true;

        if ($.trim($("#dvGeoHierarchyDetail #txtCode").val()) == "") {
            alert("Please provide code.");

            status = false;
        }
        else if ($.trim($("#dvGeoHierarchyDetail #txtName").val()) == "") {
            alert("Please provide name.");

            status = false;
        }
        else if (typeId != RC.Common.GeoHierarchyType.REGION && ddlCTParent.GetSelectedItem() == null) {
            alert("Please provide parent.");

            status = false;
        }

        return status;
    },
    PopulateGeoHierarchy: function () {
        var status = RC.GeoHierarchyListing.ValidateGeoHierarchy();

        if (status) {
            var typeId = RC.GeoHierarchyListing.GetTypeIdForSelectedView();
            var id = 0;

            if (RC.GeoHierarchyListing.GeoHierarchyObject != null) {
                id = RC.GeoHierarchyListing.GeoHierarchyObject.Id;
            }

            RC.GeoHierarchyListing.GeoHierarchyObject = { Id: 0, Code: '', Name: '', ParentId: 0, TypeId: 0, IsActive: false };
            RC.GeoHierarchyListing.GeoHierarchyObject.Id = id;
            RC.GeoHierarchyListing.GeoHierarchyObject.Code = $("#dvGeoHierarchyDetail #txtCode").val();
            RC.GeoHierarchyListing.GeoHierarchyObject.Name = $("#dvGeoHierarchyDetail #txtName").val();
            RC.GeoHierarchyListing.GeoHierarchyObject.TypeId = typeId;
            RC.GeoHierarchyListing.GeoHierarchyObject.ParentId = (typeId == RC.Common.GeoHierarchyType.REGION ? 0 : parseInt(ddlCTParent.GetSelectedItem().value));

            RC.GeoHierarchyListing.GeoHierarchyObject.IsActive = $('#dvGeoHierarchyDetail #chkActive').prop('checked');
        }

        return status;
    },
    ResetGeoHierarchy: function () {
        RC.GeoHierarchyListing.GeoHierarchyObject = null;

        $("#dvGeoHierarchyDetail #txtCode").val('');
        $("#dvGeoHierarchyDetail #txtName").val('');
        $('#dvGeoHierarchyDetail #chkActive').prop('checked', false);
        $('#dvGeoHierarchyDetail #btnSave').removeClass("disabled").text('Save');

        RC.GeoHierarchyListing.PopulateParent();
    },
    LoadGeoHierarchy: function () {
        $("#dvGeoHierarchyDetail #txtCode").val(RC.GeoHierarchyListing.GeoHierarchyObject.Code);
        $("#dvGeoHierarchyDetail #txtName").val(RC.GeoHierarchyListing.GeoHierarchyObject.Name);
        $('#dvGeoHierarchyDetail #chkActive').prop('checked', RC.GeoHierarchyListing.GeoHierarchyObject.IsActive);

        RC.GeoHierarchyListing.PopulateParent();
    },
    PopulateParent: function () {
        var typeId = RC.GeoHierarchyListing.GetTypeIdForSelectedView();
        var lstParent = [];
        var selIndex = 0;

        $('#dvParent').show();
        $('#dvName').attr('class', 'col-md-4');
        ddlCTParent.ClearItems();

        if (typeId == RC.Common.GeoHierarchyType.REGION) {
            $('#dvName').attr('class', 'col-md-8');
            $('#dvParent').hide();
        }
        else if (typeId == RC.Common.GeoHierarchyType.DIVISION) {
            lstParent = RC.GeoHierarchyListing.GetGeoHierarchyList(RC.Common.GeoHierarchyType.REGION, 0);
            selIndex = ddlCTRegion.GetSelectedIndex();
        }
        else if (typeId == RC.Common.GeoHierarchyType.DISTRICT) {
            lstParent = RC.GeoHierarchyListing.GetGeoHierarchyList(RC.Common.GeoHierarchyType.DIVISION, (ddlCTRegion.GetSelectedItem() == null ? 0 : parseInt(ddlCTRegion.GetSelectedItem().value)));
            selIndex = ddlCTDivision.GetSelectedIndex();
        }
        else if (typeId == RC.Common.GeoHierarchyType.TEHSIL) {
            lstParent = RC.GeoHierarchyListing.GetGeoHierarchyList(RC.Common.GeoHierarchyType.DISTRICT, (ddlCTDivision.GetSelectedItem() == null ? 0 : parseInt(ddlCTDivision.GetSelectedItem().value)));
            selIndex = ddlCTDistrict.GetSelectedIndex();
        }
        else if (typeId == RC.Common.GeoHierarchyType.CONSTITUENCY) {
            lstParent = RC.GeoHierarchyListing.GetGeoHierarchyList(RC.Common.GeoHierarchyType.TEHSIL, (ddlCTDistrict.GetSelectedItem() == null ? 0 : parseInt(ddlCTDistrict.GetSelectedItem().value)));
            selIndex = ddlCTTehsil.GetSelectedIndex();
        }

        if (lstParent.length > 0) {
            $(lstParent).each(function (index, item) {
                ddlCTParent.AddItem(new Array(item.Code, item.Name), item.Id.toString());
            });

            ddlCTParent.SetSelectedIndex(selIndex);
        }
    },
    GeoHierarchyGetId: function (id) {
        $("#iedit" + id).removeClass('fa-pencil').addClass('fa-spinner fa-spin');

        $.post(RC.GeoHierarchyListing.HandlerURL,
            {
                method: 'GeoHierarchyGetId',
                Id: id
            },
            function (response) {
                $("#iedit" + id).removeClass('fa-spinner fa-spin').addClass('fa-pencil');

                switch (response.Status) {
                    case RC.Common.ResponseStatus.SUCCESS:
                        RC.GeoHierarchyListing.GeoHierarchyObject = response.Data;

                        RC.GeoHierarchyListing.LoadGeoHierarchy();

                        $('#dvGeoHierarchyDetail').show();
                        $('#ModelPopup_backgroundElement').show();

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
    SaveGeoHierarchy: function () {
        if (RC.GeoHierarchyListing.PopulateGeoHierarchy()) {
            $('#dvGeoHierarchyDetail #btnSave').addClass("disabled").text('Wait...');

            RC.GeoHierarchyListing.AddUpdateGeoHierarchy();
        }
    },
    AddUpdateGeoHierarchy: function () {
        var handlerMethod = 'GeoHierarchyAdd';

        if (RC.GeoHierarchyListing.GeoHierarchyObject.Id > 0) {
            handlerMethod = 'GeoHierarchyUpdate';
        }

        $.post(RC.GeoHierarchyListing.HandlerURL,
        {
            method: handlerMethod,
            objGeoHierarchy: JSON.stringify(RC.GeoHierarchyListing.GeoHierarchyObject)
        },
        function (response) {
            switch (response.Status) {
                case RC.Common.ResponseStatus.SUCCESS:
                    alert(response.Message);

                    RC.GeoHierarchyListing.RemoveGeoHierarchy(RC.GeoHierarchyListing.GeoHierarchyObject.Id);

                    RC.GeoHierarchyListing.GeoHierarchyList.push(response.Data);

                    RC.GeoHierarchyListing.LoadViewForSelectedType();
                    RC.GeoHierarchyListing.ResetGeoHierarchy();

                    $('#dvGeoHierarchyDetail #btnClose')[0].click();

                    break;
                case RC.Common.ResponseStatus.ERROR:
                    alert(response.Message);

                    $('#dvGeoHierarchyDetail #btnSave').removeClass("disabled").text('Save');

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
    RemoveGeoHierarchy: function (id) {
        if (id > 0) {
            var apprIindex = $.map(RC.GeoHierarchyListing.GeoHierarchyList, function (obj, index) {
                if (obj.Id == id) {
                    return index;
                }
            });

            RC.GeoHierarchyListing.GeoHierarchyList.splice(apprIindex, 1);
        }
    },
    GeoHierarchyDelete: function (id) {
        var r = confirm('Do you want to proceed?');

        if (r == true) {
            $("#idel" + id).removeClass('fa-trash-o').addClass('fa-spinner fa-spin');

            $.post(RC.GeoHierarchyListing.HandlerURL,
                {
                    method: 'GeoHierarchyDelete',
                    Id: id
                },
                function (response) {
                    $("#idel" + id).removeClass('fa-spinner fa-spin').addClass('fa-trash-o');

                    switch (response.Status) {
                        case RC.Common.ResponseStatus.SUCCESS:
                            alert(response.Message);

                            RC.GeoHierarchyListing.RemoveGeoHierarchy(id);
                            RC.GeoHierarchyListing.LoadViewForSelectedType();

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

$(document).ready(function () {
    RC.GeoHierarchyListing.LoadViewForSelectedType();

    setTimeout(function () {
        $('#dvGeoHierarchyListing #btnAdd')[0].click();

        setTimeout(function () {
            $('#dvGeoHierarchyDetail #btnClose')[0].click();
        }, 50);
    }, 1000);

    $("#btnRegion").click(function () {
        RC.GeoHierarchyListing.UpdateViewForSelectedType(RC.Common.GeoHierarchyType.REGION);
    });
    $("#btnDivision").click(function () {
        RC.GeoHierarchyListing.UpdateViewForSelectedType(RC.Common.GeoHierarchyType.DIVISION);
    });
    $("#btnDistrict").click(function () {
        RC.GeoHierarchyListing.UpdateViewForSelectedType(RC.Common.GeoHierarchyType.DISTRICT);
    });
    $("#btnTehsil").click(function () {
        RC.GeoHierarchyListing.UpdateViewForSelectedType(RC.Common.GeoHierarchyType.TEHSIL);
    });
    $("#btnConstituency").click(function () {
        RC.GeoHierarchyListing.UpdateViewForSelectedType(RC.Common.GeoHierarchyType.CONSTITUENCY);
    });
});