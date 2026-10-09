var RC = RC || {};

RC.ConcernedFederalMinistryListing = {
    HandlerURL: RC.Common.RootURL + "Handler/ConcernedFederalMinistryHandler.ashx",
    ConcernedFederalMinistryList: [],
    ConcernedFederalMinistryObject: null,
    ConcernedFederalMinistryListTable: null,
    ConcernedFederalMinistryListTableInitialized: false,
    InitializePage: function () {
        if (RC.ConcernedFederalMinistryListing.ConcernedFederalMinistryList != null && RC.ConcernedFederalMinistryListing.ConcernedFederalMinistryList != undefined && RC.ConcernedFederalMinistryListing.ConcernedFederalMinistryList.length > 0) {
            RC.ConcernedFederalMinistryListing.ConcernedFederalMinistryListTableInitialized = true;

            $('#dvConcernedFederalMinistryListing #tblConcernedFederalMinistryList').DataTable({
                "data": RC.ConcernedFederalMinistryListing.ConcernedFederalMinistryList,
                "columns": [
                    { "data": "Title" },
                    { "data": "ShortTitle" },
                    {
                        data: null,
                        className: "center",
                        render: function (row, type, val, meta) {
                            return "<center><a title='Edit' href='javascript:void(0)' onclick='RC.ConcernedFederalMinistryListing.ConcernedFederalMinistryGetId(" + row.Id + ")'>" +
                                "<i id='iedit" + row.Id + "' class='fa fa-pencil' aria-hidden='true'></i></a>&nbsp;" +
                                "<a title='Delete' href='javascript:void(0)' onclick='RC.ConcernedFederalMinistryListing.ConcernedFederalMinistryDelete(" + row.Id + ")'>" +
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
    ValidateConcernedFederalMinistry: function () {
        var status = true;

        if ($.trim($("#dvConcernedFederalMinistryDetail #txtTitle").val()) == "") {
            alert("Please provide title.");

            status = false;
        }

        return status;
    },
    PopulateConcernedFederalMinistry: function () {
        var status = RC.ConcernedFederalMinistryListing.ValidateConcernedFederalMinistry();

        if (status) {
            var id = 0;

            if (RC.ConcernedFederalMinistryListing.ConcernedFederalMinistryObject != null) {
                id = RC.ConcernedFederalMinistryListing.ConcernedFederalMinistryObject.Id;
            }

            RC.ConcernedFederalMinistryListing.ConcernedFederalMinistryObject = { Id: 0, Title: '', ShortTitle: '' };
            RC.ConcernedFederalMinistryListing.ConcernedFederalMinistryObject.Id = id;
            RC.ConcernedFederalMinistryListing.ConcernedFederalMinistryObject.Title = $("#dvConcernedFederalMinistryDetail #txtTitle").val();
            RC.ConcernedFederalMinistryListing.ConcernedFederalMinistryObject.ShortTitle = $("#dvConcernedFederalMinistryDetail #txtShortTitle").val();
        }

        return status;
    },
    ResetConcernedFederalMinistry: function () {
        RC.ConcernedFederalMinistryListing.ConcernedFederalMinistryObject = null;

        $("#dvConcernedFederalMinistryDetail #txtTitle").val('');
        $("#dvConcernedFederalMinistryDetail #txtShortTitle").val('');
        $('#dvConcernedFederalMinistryDetail #btnSave').removeClass("disabled").text('Save');
    },
    ReloadPage: function () {
        if (RC.ConcernedFederalMinistryListing.ConcernedFederalMinistryListTableInitialized) {
            $('#dvConcernedFederalMinistryListing #tblConcernedFederalMinistryList').dataTable().fnClearTable();

            if (RC.ConcernedFederalMinistryListing.ConcernedFederalMinistryList != null && RC.ConcernedFederalMinistryListing.ConcernedFederalMinistryList != undefined && RC.ConcernedFederalMinistryListing.ConcernedFederalMinistryList.length > 0) {
                $('#dvConcernedFederalMinistryListing #tblConcernedFederalMinistryList').dataTable().fnAddData(RC.ConcernedFederalMinistryListing.ConcernedFederalMinistryList);
                $('#dvConcernedFederalMinistryListing #tblConcernedFederalMinistryList').dataTable().fnDraw();
            }
        }
        else {
            RC.ConcernedFederalMinistryListing.InitializePage();
        }
    },
    LoadConcernedFederalMinistry: function () {
        $("#dvConcernedFederalMinistryDetail #txtTitle").val(RC.ConcernedFederalMinistryListing.ConcernedFederalMinistryObject.Title);
        $("#dvConcernedFederalMinistryDetail #txtShortTitle").val(RC.ConcernedFederalMinistryListing.ConcernedFederalMinistryObject.ShortTitle);
    },
    ConcernedFederalMinistryGetId: function (id) {
        $("#iedit" + id).removeClass('fa-pencil').addClass('fa-spinner fa-spin');

        $.post(RC.ConcernedFederalMinistryListing.HandlerURL,
            {
                method: 'ConcernedFederalMinistryGetId',
                Id: id
            },
            function (response) {
                $("#iedit" + id).removeClass('fa-spinner fa-spin').addClass('fa-pencil');

                switch (response.Status) {
                    case RC.Common.ResponseStatus.SUCCESS:
                        RC.ConcernedFederalMinistryListing.ConcernedFederalMinistryObject = response.Data;

                        RC.ConcernedFederalMinistryListing.LoadConcernedFederalMinistry();

                        $('#dvConcernedFederalMinistryDetail').show();
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
    SaveConcernedFederalMinistry: function () {
        if (RC.ConcernedFederalMinistryListing.PopulateConcernedFederalMinistry()) {
            $('#dvConcernedFederalMinistryDetail #btnSave').addClass("disabled").text('Wait...');

            RC.ConcernedFederalMinistryListing.AddUpdateConcernedFederalMinistry();
        }
    },
    AddUpdateConcernedFederalMinistry: function () {
        var handlerMethod = 'ConcernedFederalMinistryAdd';

        if (RC.ConcernedFederalMinistryListing.ConcernedFederalMinistryObject.Id > 0) {
            handlerMethod = 'ConcernedFederalMinistryUpdate';
        }

        $.post(RC.ConcernedFederalMinistryListing.HandlerURL,
        {
            method: handlerMethod,
            objConcernedFederalMinistry: JSON.stringify(RC.ConcernedFederalMinistryListing.ConcernedFederalMinistryObject)
        },
        function (response) {
            switch (response.Status) {
                case RC.Common.ResponseStatus.SUCCESS:
                    alert(response.Message);

                    RC.ConcernedFederalMinistryListing.RemoveConcernedFederalMinistry(RC.ConcernedFederalMinistryListing.ConcernedFederalMinistryObject.Id);

                    RC.ConcernedFederalMinistryListing.ConcernedFederalMinistryList.push(response.Data);

                    RC.ConcernedFederalMinistryListing.ReloadPage();
                    RC.ConcernedFederalMinistryListing.ResetConcernedFederalMinistry();

                    $('#dvConcernedFederalMinistryDetail #btnClose')[0].click();

                    break;
                case RC.Common.ResponseStatus.ERROR:
                    alert(response.Message);

                    $('#dvConcernedFederalMinistryDetail #btnSave').removeClass("disabled").text('Save');

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
    RemoveConcernedFederalMinistry: function (id) {
        if (id > 0) {
            var apprIindex = $.map(RC.ConcernedFederalMinistryListing.ConcernedFederalMinistryList, function (obj, index) {
                if (obj.Id == id) {
                    return index;
                }
            });

            RC.ConcernedFederalMinistryListing.ConcernedFederalMinistryList.splice(apprIindex, 1);
        }
    },
    ConcernedFederalMinistryDelete: function (id) {
        var r = confirm('Do you want to proceed?');

        if (r == true) {
            $("#idel" + id).removeClass('fa-trash-o').addClass('fa-spinner fa-spin');

            $.post(RC.ConcernedFederalMinistryListing.HandlerURL,
                {
                    method: 'ConcernedFederalMinistryDelete',
                    Id: id
                },
                function (response) {
                    $("#idel" + id).removeClass('fa-spinner fa-spin').addClass('fa-trash-o');

                    switch (response.Status) {
                        case RC.Common.ResponseStatus.SUCCESS:
                            alert(response.Message);

                            RC.ConcernedFederalMinistryListing.RemoveConcernedFederalMinistry(id);
                            RC.ConcernedFederalMinistryListing.ReloadPage();

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
    RC.ConcernedFederalMinistryListing.InitializePage();

    setTimeout(function () {
        $('#dvConcernedFederalMinistryListing #btnAdd')[0].click();

        setTimeout(function () {
            $('#dvConcernedFederalMinistryDetail #btnClose')[0].click();
        }, 50);
    }, 1000);
});