var RC = RC || {};

RC.ManageGroup = {
    HandlerURL: RC.Common.RootURL + "Handler/GroupHandler.ashx",
    GroupObject: null,
    AccountHeadTableInitialized: false,
    InitializePage: function () {
        if (RC.ManageGroup.GroupObject != null) {
            $("#dvManageGroup #txtTitle").val(RC.ManageGroup.GroupObject.Title);
            $("#dvManageGroup #txtShortTitle").val(RC.ManageGroup.GroupObject.ShortTitle);
            RC.ManageGroup.PopulateGroupAccountHeadList();
        }
        else {
            RC.ManageGroup.GroupObject = { Id: 0, Title: '', ShortTitle: '', GroupAccountHeadList: [] };
        }
    },
    PopulateGroupAccountHeadList: function () {
        if (RC.ManageGroup.GroupObject.GroupAccountHeadList == null ||
            RC.ManageGroup.GroupObject.GroupAccountHeadList == undefined) {
            RC.ManageGroup.GroupObject.GroupAccountHeadList = [];
        }

        if (RC.ManageGroup.GroupObject.GroupAccountHeadList != null && RC.ManageGroup.GroupObject.GroupAccountHeadList != undefined && RC.ManageGroup.GroupObject.GroupAccountHeadList.length > 0) {
            RC.ManageGroup.AccountHeadTableInitialized = true;

            $('#dvManageGroup #tblGroupAccountHeadList').DataTable({
                "data": RC.ManageGroup.GroupObject.GroupAccountHeadList,
                "columns": [
                    { "data": "COAName" },
                    {
                        data: null,
                        className: "center",
                        render: function (row, type, val, meta) {
                            return "<center><a title='Edit' href='javascript:void(0)' onclick='RC.ManageGroup.GroupAccountHeadLoad(" + meta.row + ")'>" +
                                "<i class='fa fa-pencil' aria-hidden='true'></i></a>&nbsp;" +
                                "<a title='Delete' href='javascript:void(0)' onclick='RC.ManageGroup.GroupAccountHeadDelete(" + meta.row + ")'>" +
                                "<i class='fa fa-trash-o' aria-hidden='true'></i></a></center>";
                        },
                        orderable: false,
                        defaultContent: ""
                    }
                ]
            });
        }
    },
    LoadGroupAccountHeadView: function () {
        if (RC.ManageGroup.AccountHeadTableInitialized) {
            $('#dvManageGroup #tblGroupAccountHeadList').dataTable().fnClearTable();

            if (RC.ManageGroup.GroupObject.GroupAccountHeadList.length > 0) {
                $('#dvManageGroup #tblGroupAccountHeadList').dataTable().fnAddData(RC.ManageGroup.GroupObject.GroupAccountHeadList);
            }

            $('#dvManageGroup #tblGroupAccountHeadList').dataTable().fnDraw();
        }
        else {
            RC.ManageGroup.PopulateGroupAccountHeadList();
        }
    },
    GroupAccountHeadLoad: function (index) {
        var objGroupAccountHead = RC.ManageGroup.GroupObject.GroupAccountHeadList[index];

        ddlCTCOA.SetValue(objGroupAccountHead.AccountHeadId);
        $("#dvManageGroup #btnSaveAccountHead")
            .attr('onclick', "RC.ManageGroup.GroupAccountHeadSave(" + index + ");")
            .val('Update');
    },
    GroupAccountHeadReset: function () {
        $("#dvManageGroup #btnSaveAccountHead")
            .attr('onclick', "RC.ManageGroup.GroupAccountHeadSave(-1);")
            .val('Add');
    },
    GroupAccountHeadSave: function (index) {
        var status = RC.ManageGroup.ValidateGroupAccountHead(index);

        if (status) {
            if (index >= 0) {
                RC.ManageGroup.GroupObject.GroupAccountHeadList.splice(index, 1);
            }

            var objGroupAccountHead = { AccountHeadId: 0, COAName: '' };

            objGroupAccountHead.AccountHeadId = ddlCTCOA.GetSelectedItem().value;
            objGroupAccountHead.COAName = ddlCTCOA.GetSelectedItem().text;

            RC.ManageGroup.GroupObject.GroupAccountHeadList.push(objGroupAccountHead);

            RC.ManageGroup.LoadGroupAccountHeadView();
            RC.ManageGroup.GroupAccountHeadReset();
        }
    },
    GroupAccountHeadDelete: function (fadIndex) {
        RC.ManageGroup.GroupObject.GroupAccountHeadList.splice(fadIndex, 1);

        RC.ManageGroup.LoadGroupAccountHeadView();
    },
    ValidateGroup: function () {
        var status = true;

        if ($.trim($("#dvManageGroup #txtTitle").val()) == "") {
            alert("Please provide title.");

            status = false;
        }
        else if ($.trim($("#dvManageGroup #txtShortTitle").val()) == "") {
            alert("Please provide short title.");

            status = false;
        }

        return status;
    },
    ValidateGroupAccountHead: function (fadIndex) {
        var status = true;
        var coaId = 0;

        if (ddlCTCOA.GetSelectedItem() == null) {
            alert("Please provide object code.");

            status = false;
        }
        else {
            coaId = ddlCTCOA.GetSelectedItem().value;
        }

        if (status) {
            $(RC.ManageGroup.GroupObject.GroupAccountHeadList).each(function (index, item) {
                if (item.AccountHeadId == parseInt(coaId)) {
                    if (fadIndex < 0 || fadIndex != index) {
                        alert("Record already exists for selected Object Code.");

                        status = false;

                        return false;
                    }
                }
            });
        }

        return status;
    },
    PopulateGroup: function () {
        var status = RC.ManageGroup.ValidateGroup();

        if (status) {
            var id = 0;

            if (RC.ManageGroup.GroupObject != null) {
                id = RC.ManageGroup.GroupObject.Id;
            }

            RC.ManageGroup.GroupObject.Id = id;
            RC.ManageGroup.GroupObject.Title = $("#dvManageGroup #txtTitle").val();
            RC.ManageGroup.GroupObject.ShortTitle = $("#dvManageGroup #txtShortTitle").val();
        }

        return status;
    },
    SaveGroup: function () {
        if (RC.ManageGroup.PopulateGroup()) {
            $('#dvManageGroup #btnSave').addClass("disabled").val('Wait...');

            RC.ManageGroup.AddUpdateGroup();
        }
    },
    AddUpdateGroup: function () {
        var handlerMethod = 'GroupAdd';

        if (RC.ManageGroup.GroupObject.Id > 0) {
            handlerMethod = 'GroupUpdate';
        }

        $.post(RC.ManageGroup.HandlerURL,
        {
            method: handlerMethod,
            objGroup: JSON.stringify(RC.ManageGroup.GroupObject)
        },
        function (response) {
            switch (response.Status) {
                case RC.Common.ResponseStatus.SUCCESS:
                    alert(response.Message);

                    $('#dvManageGroup #btnSave').val('Its done.');

                    window.location = RC.Common.RootURL + "Forms/frmGroups.aspx?LevelType=" + RC.Common.GetQueryStringByName('LevelType') + "&LevelID=" + RC.Common.GetQueryStringByName('LevelID');

                    break;
                case RC.Common.ResponseStatus.ERROR:
                    alert(response.Message);

                    $('#dvManageGroup #btnSave').removeClass("disabled").val('Save');

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

$(document).ready(function () {
    RC.ManageGroup.InitializePage();

    $('#dvManageGroup #btnCancel').on('click', function () {
        window.location = RC.Common.RootURL + "Forms/frmGroups.aspx?LevelType=" + RC.Common.GetQueryStringByName('LevelType') + "&LevelID=" + RC.Common.GetQueryStringByName('LevelID');

        return false;
    });
});