var RC = RC || {};

RC.SponsoringListing = {
    HandlerURL: RC.Common.RootURL + "Handler/SponsoringHandler.ashx",
    SponsoringList: [],
    SponsoringObject: null,
    SponsoringListTable: null,
    SponsoringListTableInitialized: false,
    InitializePage: function () {
        if (RC.SponsoringListing.SponsoringList != null && RC.SponsoringListing.SponsoringList != undefined && RC.SponsoringListing.SponsoringList.length > 0) {
            RC.SponsoringListing.SponsoringListTableInitialized = true;

            $('#dvSponsoringListing #tblSponsoringList').DataTable({
                "data": RC.SponsoringListing.SponsoringList,
                "columns": [
                    { "data": "Title" },
                    { "data": "ShortTitle" },
                    {
                        data: null,
                        className: "center",
                        render: function (row, type, val, meta) {
                            return "<center><a title='Edit' href='javascript:void(0)' onclick='RC.SponsoringListing.SponsoringGetId(" + row.Id + ")'>" +
                                "<i id='iedit" + row.Id + "' class='fa fa-pencil' aria-hidden='true'></i></a>&nbsp;" +
                                "<a title='Delete' href='javascript:void(0)' onclick='RC.SponsoringListing.SponsoringDelete(" + row.Id + ")'>" +
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
    ValidateSponsoring: function () {
        var status = true;

        if ($.trim($("#dvSponsoringDetail #txtTitle").val()) == "") {
            alert("Please provide title.");

            status = false;
        }

        return status;
    },
    PopulateSponsoring: function () {
        var status = RC.SponsoringListing.ValidateSponsoring();

        if (status) {
            var id = 0;

            if (RC.SponsoringListing.SponsoringObject != null) {
                id = RC.SponsoringListing.SponsoringObject.Id;
            }

            RC.SponsoringListing.SponsoringObject = { Id: 0, Title: '', ShortTitle: '' };
            RC.SponsoringListing.SponsoringObject.Id = id;
            RC.SponsoringListing.SponsoringObject.Title = $("#dvSponsoringDetail #txtTitle").val();
            RC.SponsoringListing.SponsoringObject.ShortTitle = $("#dvSponsoringDetail #txtShortTitle").val();
        }

        return status;
    },
    ResetSponsoring: function () {
        RC.SponsoringListing.SponsoringObject = null;

        $("#dvSponsoringDetail #txtTitle").val('');
        $("#dvSponsoringDetail #txtShortTitle").val('');
        $('#dvSponsoringDetail #btnSave').removeClass("disabled").text('Save');
    },
    ReloadPage: function () {
        if (RC.SponsoringListing.SponsoringListTableInitialized) {
            $('#dvSponsoringListing #tblSponsoringList').dataTable().fnClearTable();

            if (RC.SponsoringListing.SponsoringList != null && RC.SponsoringListing.SponsoringList != undefined && RC.SponsoringListing.SponsoringList.length > 0) {
                $('#dvSponsoringListing #tblSponsoringList').dataTable().fnAddData(RC.SponsoringListing.SponsoringList);
                $('#dvSponsoringListing #tblSponsoringList').dataTable().fnDraw();
            }
        }
        else {
            RC.SponsoringListing.InitializePage();
        }
    },
    LoadSponsoring: function () {
        $("#dvSponsoringDetail #txtTitle").val(RC.SponsoringListing.SponsoringObject.Title);
        $("#dvSponsoringDetail #txtShortTitle").val(RC.SponsoringListing.SponsoringObject.ShortTitle);
    },
    SponsoringGetId: function (id) {
        $("#iedit" + id).removeClass('fa-pencil').addClass('fa-spinner fa-spin');

        $.post(RC.SponsoringListing.HandlerURL,
            {
                method: 'SponsoringGetId',
                Id: id
            },
            function (response) {
                $("#iedit" + id).removeClass('fa-spinner fa-spin').addClass('fa-pencil');

                switch (response.Status) {
                    case RC.Common.ResponseStatus.SUCCESS:
                        RC.SponsoringListing.SponsoringObject = response.Data;

                        RC.SponsoringListing.LoadSponsoring();

                        $('#dvSponsoringDetail').show();
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
    SaveSponsoring: function () {
        if (RC.SponsoringListing.PopulateSponsoring()) {
            $('#dvSponsoringDetail #btnSave').addClass("disabled").text('Wait...');

            RC.SponsoringListing.AddUpdateSponsoring();
        }
    },
    AddUpdateSponsoring: function () {
        var handlerMethod = 'SponsoringAdd';

        if (RC.SponsoringListing.SponsoringObject.Id > 0) {
            handlerMethod = 'SponsoringUpdate';
        }

        $.post(RC.SponsoringListing.HandlerURL,
        {
            method: handlerMethod,
            objSponsoring: JSON.stringify(RC.SponsoringListing.SponsoringObject)
        },
        function (response) {
            switch (response.Status) {
                case RC.Common.ResponseStatus.SUCCESS:
                    alert(response.Message);

                    RC.SponsoringListing.RemoveSponsoring(RC.SponsoringListing.SponsoringObject.Id);

                    RC.SponsoringListing.SponsoringList.push(response.Data);

                    RC.SponsoringListing.ReloadPage();
                    RC.SponsoringListing.ResetSponsoring();

                    $('#dvSponsoringDetail #btnClose')[0].click();

                    break;
                case RC.Common.ResponseStatus.ERROR:
                    alert(response.Message);

                    $('#dvSponsoringDetail #btnSave').removeClass("disabled").text('Save');

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
    RemoveSponsoring: function (id) {
        if (id > 0) {
            var apprIindex = $.map(RC.SponsoringListing.SponsoringList, function (obj, index) {
                if (obj.Id == id) {
                    return index;
                }
            });

            RC.SponsoringListing.SponsoringList.splice(apprIindex, 1);
        }
    },
    SponsoringDelete: function (id) {
        var r = confirm('Do you want to proceed?');

        if (r == true) {
            $("#idel" + id).removeClass('fa-trash-o').addClass('fa-spinner fa-spin');

            $.post(RC.SponsoringListing.HandlerURL,
                {
                    method: 'SponsoringDelete',
                    Id: id
                },
                function (response) {
                    $("#idel" + id).removeClass('fa-spinner fa-spin').addClass('fa-trash-o');

                    switch (response.Status) {
                        case RC.Common.ResponseStatus.SUCCESS:
                            alert(response.Message);

                            RC.SponsoringListing.RemoveSponsoring(id);
                            RC.SponsoringListing.ReloadPage();

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
    RC.SponsoringListing.InitializePage();

    setTimeout(function () {
        $('#dvSponsoringListing #btnAdd')[0].click();

        setTimeout(function () {
            $('#dvSponsoringDetail #btnClose')[0].click();
        }, 50);
    }, 1000);
});