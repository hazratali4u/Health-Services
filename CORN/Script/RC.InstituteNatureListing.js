var RC = RC || {};

RC.InstituteNatureListing = {
    HandlerURL: RC.Common.RootURL + "Handler/InstituteNatureHandler.ashx",
    InstituteNatureList: [],
    InstituteNatureObject: null,
    InstituteNatureListTable: null,
    InstituteNatureListTableInitialized: false,
    InitializePage: function () {
        if (RC.InstituteNatureListing.InstituteNatureList != null && RC.InstituteNatureListing.InstituteNatureList != undefined && RC.InstituteNatureListing.InstituteNatureList.length > 0) {
            RC.InstituteNatureListing.InstituteNatureListTableInitialized = true;

            $('#dvInstituteNatureListing #tblInstituteNatureList').DataTable({
                "data": RC.InstituteNatureListing.InstituteNatureList,
                "columns": [
                    { "data": "Title" },
                    { "data": "ShortTitle" },
                    {
                        data: null,
                        className: "center",
                        render: function (row, type, val, meta) {
                            return "<center><a title='Edit' href='javascript:void(0)' onclick='RC.InstituteNatureListing.InstituteNatureGetId(" + row.Id + ")'>" +
                                "<i id='iedit" + row.Id + "' class='fa fa-pencil' aria-hidden='true'></i></a>&nbsp;" +
                                "<a title='Delete' href='javascript:void(0)' onclick='RC.InstituteNatureListing.InstituteNatureDelete(" + row.Id + ")'>" +
                                "<i id='idel" + row.Id + "' class='fa fa-trash-o' aria-hidden='true'></i></a></center>";
                        },
                        orderable: false,
                        defaultContent: ""
                    }
                ],
                aaSorting: [[1, 'asc']]
            });
        }
    },
    ValidateInstituteNature: function () {
        var status = true;

        if ($.trim($("#dvInstituteNatureDetail #txtTitle").val()) == "") {
            alert("Please provide title.");

            status = false;
        }

        return status;
    },
    PopulateInstituteNature: function () {
        var status = RC.InstituteNatureListing.ValidateInstituteNature();

        if (status) {
            var id = 0;

            if (RC.InstituteNatureListing.InstituteNatureObject != null) {
                id = RC.InstituteNatureListing.InstituteNatureObject.Id;
            }

            RC.InstituteNatureListing.InstituteNatureObject = { Id: 0, Title: '', ShortTitle: '' };
            RC.InstituteNatureListing.InstituteNatureObject.Id = id;
            RC.InstituteNatureListing.InstituteNatureObject.Title = $("#dvInstituteNatureDetail #txtTitle").val();
            RC.InstituteNatureListing.InstituteNatureObject.ShortTitle = $("#dvInstituteNatureDetail #txtShortTitle").val();
        }

        return status;
    },
    ResetInstituteNature: function () {
        RC.InstituteNatureListing.InstituteNatureObject = null;

        $("#dvInstituteNatureDetail #txtTitle").val('');
        $("#dvInstituteNatureDetail #txtShortTitle").val('');
        $('#dvInstituteNatureDetail #btnSave').removeClass("disabled").text('Save');
    },
    ReloadPage: function () {
        if (RC.InstituteNatureListing.InstituteNatureListTableInitialized) {
            $('#dvInstituteNatureListing #tblInstituteNatureList').dataTable().fnClearTable();

            if (RC.InstituteNatureListing.InstituteNatureList != null && RC.InstituteNatureListing.InstituteNatureList != undefined && RC.InstituteNatureListing.InstituteNatureList.length > 0) {
                $('#dvInstituteNatureListing #tblInstituteNatureList').dataTable().fnAddData(RC.InstituteNatureListing.InstituteNatureList);
                $('#dvInstituteNatureListing #tblInstituteNatureList').dataTable().fnDraw();
            }
        }
        else {
            RC.InstituteNatureListing.InitializePage();
        }
    },
    LoadInstituteNature: function () {
        $("#dvInstituteNatureDetail #txtTitle").val(RC.InstituteNatureListing.InstituteNatureObject.Title);
        $("#dvInstituteNatureDetail #txtShortTitle").val(RC.InstituteNatureListing.InstituteNatureObject.ShortTitle);
    },
    InstituteNatureGetId: function (id) {
        $("#iedit" + id).removeClass('fa-pencil').addClass('fa-spinner fa-spin');

        $.post(RC.InstituteNatureListing.HandlerURL,
            {
                method: 'InstituteNatureGetId',
                Id: id
            },
            function (response) {
                $("#iedit" + id).removeClass('fa-spinner fa-spin').addClass('fa-pencil');

                switch (response.Status) {
                    case RC.Common.ResponseStatus.SUCCESS:
                        RC.InstituteNatureListing.InstituteNatureObject = response.Data;

                        RC.InstituteNatureListing.LoadInstituteNature();

                        $('#dvInstituteNatureDetail').show();
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
    SaveInstituteNature: function () {
        if (RC.InstituteNatureListing.PopulateInstituteNature()) {
            $('#dvInstituteNatureDetail #btnSave').addClass("disabled").text('Wait...');

            RC.InstituteNatureListing.AddUpdateInstituteNature();
        }
    },
    AddUpdateInstituteNature: function () {
        var handlerMethod = 'InstituteNatureAdd';

        if (RC.InstituteNatureListing.InstituteNatureObject.Id > 0) {
            handlerMethod = 'InstituteNatureUpdate';
        }

        $.post(RC.InstituteNatureListing.HandlerURL,
        {
            method: handlerMethod,
            objInstituteNature: JSON.stringify(RC.InstituteNatureListing.InstituteNatureObject)
        },
        function (response) {
            switch (response.Status) {
                case RC.Common.ResponseStatus.SUCCESS:
                    alert(response.Message);

                    RC.InstituteNatureListing.RemoveInstituteNature(RC.InstituteNatureListing.InstituteNatureObject.Id);

                    RC.InstituteNatureListing.InstituteNatureList.push(response.Data);

                    RC.InstituteNatureListing.ReloadPage();
                    RC.InstituteNatureListing.ResetInstituteNature();

                    $('#dvInstituteNatureDetail #btnClose')[0].click();

                    break;
                case RC.Common.ResponseStatus.ERROR:
                    alert(response.Message);

                    $('#dvInstituteNatureDetail #btnSave').removeClass("disabled").text('Save');

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
    RemoveInstituteNature: function (id) {
        if (id > 0) {
            var apprIindex = $.map(RC.InstituteNatureListing.InstituteNatureList, function (obj, index) {
                if (obj.Id == id) {
                    return index;
                }
            });

            RC.InstituteNatureListing.InstituteNatureList.splice(apprIindex, 1);
        }
    },
    InstituteNatureDelete: function (id) {
        var r = confirm('Do you want to proceed?');

        if (r == true) {
            $("#idel" + id).removeClass('fa-trash-o').addClass('fa-spinner fa-spin');

            $.post(RC.InstituteNatureListing.HandlerURL,
                {
                    method: 'InstituteNatureDelete',
                    Id: id
                },
                function (response) {
                    $("#idel" + id).removeClass('fa-spinner fa-spin').addClass('fa-trash-o');

                    switch (response.Status) {
                        case RC.Common.ResponseStatus.SUCCESS:
                            alert(response.Message);

                            RC.InstituteNatureListing.RemoveInstituteNature(id);
                            RC.InstituteNatureListing.ReloadPage();

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
    RC.InstituteNatureListing.InitializePage();

    setTimeout(function () {
        $('#dvInstituteNatureListing #btnAdd')[0].click();

        setTimeout(function () {
            $('#dvInstituteNatureDetail #btnClose')[0].click();
        }, 50);
    }, 1000);
});