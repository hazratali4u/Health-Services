var RC = RC || {};

RC.FundTypeListing = {
    HandlerURL: RC.Common.RootURL + "Handler/FundTypeHandler.ashx",
    FundTypeList: [],
    FundTypeObject: null,
    FundTypeListTable: null,
    FundTypeListTableInitialized: false,
    InitializePage: function () {
        if (RC.FundTypeListing.FundTypeList != null && RC.FundTypeListing.FundTypeList != undefined && RC.FundTypeListing.FundTypeList.length > 0) {
            RC.FundTypeListing.FundTypeListTableInitialized = true;

            $('#dvFundTypeListing #tblFundTypeList').DataTable({
                "data": RC.FundTypeListing.FundTypeList,
                "columns": [
                    { "data": "Title" },
                    { "data": "ShortTitle" },
                    {
                        data: null,
                        className: "center",
                        render: function (row, type, val, meta) {
                            return "<center><a title='Edit' href='javascript:void(0)' onclick='RC.FundTypeListing.FundTypeGetId(" + row.Id + ")'>" +
                                "<i id='iedit" + row.Id + "' class='fa fa-pencil' aria-hidden='true'></i></a>&nbsp;" +
                                "<a title='Delete' href='javascript:void(0)' onclick='RC.FundTypeListing.FundTypeDelete(" + row.Id + ")'>" +
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
    ValidateFundType: function () {
        var status = true;

        if ($.trim($("#dvFundTypeDetail #txtTitle").val()) == "") {
            alert("Please provide title.");

            status = false;
        }

        return status;
    },
    PopulateFundType: function () {
        var status = RC.FundTypeListing.ValidateFundType();

        if (status) {
            var id = 0;

            if (RC.FundTypeListing.FundTypeObject != null) {
                id = RC.FundTypeListing.FundTypeObject.Id;
            }

            RC.FundTypeListing.FundTypeObject = { Id: 0, Title: '', ShortTitle: '' };
            RC.FundTypeListing.FundTypeObject.Id = id;
            RC.FundTypeListing.FundTypeObject.Title = $("#dvFundTypeDetail #txtTitle").val();
            RC.FundTypeListing.FundTypeObject.ShortTitle = $("#dvFundTypeDetail #txtShortTitle").val();
        }

        return status;
    },
    ResetFundType: function () {
        RC.FundTypeListing.FundTypeObject = null;

        $("#dvFundTypeDetail #txtTitle").val('');
        $("#dvFundTypeDetail #txtShortTitle").val('');
        $('#dvFundTypeDetail #btnSave').removeClass("disabled").text('Save');
    },
    ReloadPage: function () {
        if (RC.FundTypeListing.FundTypeListTableInitialized) {
            $('#dvFundTypeListing #tblFundTypeList').dataTable().fnClearTable();

            if (RC.FundTypeListing.FundTypeList != null && RC.FundTypeListing.FundTypeList != undefined && RC.FundTypeListing.FundTypeList.length > 0) {
                $('#dvFundTypeListing #tblFundTypeList').dataTable().fnAddData(RC.FundTypeListing.FundTypeList);
                $('#dvFundTypeListing #tblFundTypeList').dataTable().fnDraw();
            }
        }
        else {
            RC.FundTypeListing.InitializePage();
        }
    },
    LoadFundType: function () {
        $("#dvFundTypeDetail #txtTitle").val(RC.FundTypeListing.FundTypeObject.Title);
        $("#dvFundTypeDetail #txtShortTitle").val(RC.FundTypeListing.FundTypeObject.ShortTitle);
    },
    FundTypeGetId: function (id) {
        $("#iedit" + id).removeClass('fa-pencil').addClass('fa-spinner fa-spin');

        $.post(RC.FundTypeListing.HandlerURL,
            {
                method: 'FundTypeGetId',
                Id: id
            },
            function (response) {
                $("#iedit" + id).removeClass('fa-spinner fa-spin').addClass('fa-pencil');

                switch (response.Status) {
                    case RC.Common.ResponseStatus.SUCCESS:
                        RC.FundTypeListing.FundTypeObject = response.Data;

                        RC.FundTypeListing.LoadFundType();

                        $('#dvFundTypeDetail').show();
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
    SaveFundType: function () {
        if (RC.FundTypeListing.PopulateFundType()) {
            $('#dvFundTypeDetail #btnSave').addClass("disabled").text('Wait...');

            RC.FundTypeListing.AddUpdateFundType();
        }
    },
    AddUpdateFundType: function () {
        var handlerMethod = 'FundTypeAdd';

        if (RC.FundTypeListing.FundTypeObject.Id > 0) {
            handlerMethod = 'FundTypeUpdate';
        }

        $.post(RC.FundTypeListing.HandlerURL,
        {
            method: handlerMethod,
            objFundType: JSON.stringify(RC.FundTypeListing.FundTypeObject)
        },
        function (response) {
            switch (response.Status) {
                case RC.Common.ResponseStatus.SUCCESS:
                    alert(response.Message);

                    RC.FundTypeListing.RemoveFundType(RC.FundTypeListing.FundTypeObject.Id);

                    RC.FundTypeListing.FundTypeList.push(response.Data);

                    RC.FundTypeListing.ReloadPage();
                    RC.FundTypeListing.ResetFundType();

                    $('#dvFundTypeDetail #btnClose')[0].click();

                    break;
                case RC.Common.ResponseStatus.ERROR:
                    alert(response.Message);

                    $('#dvFundTypeDetail #btnSave').removeClass("disabled").text('Save');

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
    RemoveFundType: function (id) {
        if (id > 0) {
            var apprIindex = $.map(RC.FundTypeListing.FundTypeList, function (obj, index) {
                if (obj.Id == id) {
                    return index;
                }
            });

            RC.FundTypeListing.FundTypeList.splice(apprIindex, 1);
        }
    },
    FundTypeDelete: function (id) {
        var r = confirm('Do you want to proceed?');

        if (r == true) {
            $("#idel" + id).removeClass('fa-trash-o').addClass('fa-spinner fa-spin');

            $.post(RC.FundTypeListing.HandlerURL,
                {
                    method: 'FundTypeDelete',
                    Id: id
                },
                function (response) {
                    $("#idel" + id).removeClass('fa-spinner fa-spin').addClass('fa-trash-o');

                    switch (response.Status) {
                        case RC.Common.ResponseStatus.SUCCESS:
                            alert(response.Message);

                            RC.FundTypeListing.RemoveFundType(id);
                            RC.FundTypeListing.ReloadPage();

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
    RC.FundTypeListing.InitializePage();

    setTimeout(function () {
        $('#dvFundTypeListing #btnAdd')[0].click();

        setTimeout(function () {
            $('#dvFundTypeDetail #btnClose')[0].click();
        }, 50);
    }, 1000);
});