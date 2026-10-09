<%@ Page Title="MPR :: Scheme" Language="C#" MasterPageFile="~/Forms/PageMaster.master" AutoEventWireup="true" CodeFile="frmSchemes.aspx.cs" Inherits="Forms_frmSchemes" %>

<%@ Register Assembly="DevExpress.Web.v16.1, Version=16.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphPage" runat="Server">
    <style type="text/css">
        .formcontrolstyle {
            height: 35px;
            padding: 6px 12px;
            font-size: 14px;
            line-height: 1.42857143;
            color: #555;
            background-color: #fff;
            background-image: none;
            border: 1px solid #ccc;
        }
    </style>
    <div id="dvSchemeListing" class="main-contents">
        <div class="container employee-infomation">
            <div class="row top">
                <div class="col-md-12">
                    <div class="btnlist pull-right">
                        <asp:DropDownList ID="ddlSchemeCategory" runat="server" CssClass="formcontrolstyle" ClientIDMode="Static">
                            <Items>
                                <asp:ListItem Value="1" Text="New" Selected="true" />
                                <asp:ListItem Value="2" Text="On-going" />
                                <asp:ListItem Value="3" Text="Supplementary" />
                                <asp:ListItem Value="4" Text="Unfunded" />
                            </Items>
                        </asp:DropDownList>
                        <asp:LinkButton CssClass="btn btn-success" runat="server" ID="btnStatus" ClientIDMode="Static">
                               <span class="fa fa-check"></span>Status
                        </asp:LinkButton>
                        <asp:LinkButton CssClass="btn btn-success" runat="server" ID="btnPromoteSchemes" ClientIDMode="Static">
                               <span class="fa fa-check"></span>Promote Schemes
                        </asp:LinkButton>
                        <asp:LinkButton CssClass="btn btn-success" runat="server" ID="btnExport" ClientIDMode="Static"
                            OnClientClick="window.location = 'frmExportSchemes.aspx?LevelType=3&LevelID=259'; return false;">
                               <span class="fa fa-check"></span>Export
                        </asp:LinkButton>
                        <asp:LinkButton class="btn btn-success" runat="server" ID="btnActive" ClientIDMode="Static">
                               <span class="fa fa-check"></span>Active | InActive
                        </asp:LinkButton>
                        <asp:LinkButton CssClass="btn btn-warning" runat="server" ID="btnAdd" ClientIDMode="Static">
                               <span class="fa fa-plus-circle"></span>Add
                        </asp:LinkButton>
                    </div>
                </div>
                <div class="col-md-12">
                    <div class="row">
                        <div class="col-md-4">
                            <label id="lblFinancialYear"><span class="fa fa-caret-right rgt_cart"></span>Financial Year</label>
                            <dx:ASPxComboBox ID="ddlFY" runat="server" ClientInstanceName="ddlFY" CssClass="form-control" TextFormatString="{1}">
                                <Columns>
                                    <dx:ListBoxColumn FieldName="Id" Caption="Code" Width="10px" />
                                    <dx:ListBoxColumn FieldName="YearName" Caption="Name" Width="40px" />
                                </Columns>
                                <ClientSideEvents SelectedIndexChanged="function(s, e) { SchemeGetAll(s); }" />
                            </dx:ASPxComboBox>
                        </div>
                        <div class="col-md-8">&nbsp;</div>
                    </div>
                </div>
                <div id="dvSchemeListProcessing" class="col-md-12" style="clear: both; text-align: center; display: none;">
                    <i class="fa fa-spinner fa-spin fa-lg" aria-hidden="true"></i>
                </div>
                <div id="dvSchemeList" class="col-md-12" style="clear: both;">
                    <table id="tblSchemeList" class="table table-striped table-bordered" style="width: 100%;">
                        <thead>
                            <tr>
                                <th style="width: 5%; text-align: center;">
                                    <input id="chkAll" type="checkbox" onclick="RC.SchemeListing.SaveSelectedSchemes(this.checked)" /></th>
                                <th style="width: 15%;">Scheme Code</th>
                                <th style="width: 34%;">Scheme Name</th>
                                <th style="width: 13%; text-align: center;">Status</th>
                                <th style="width: 13%; text-align: center;">Scheme Date</th>
                                <th style="width: 13%; text-align: center;">Record Status</th>
                                <th style="width: 7%; text-align: center;">Action</th>
                            </tr>
                        </thead>
                    </table>
                </div>
            </div>
        </div>
    </div>
    <script src="<%= Page.ResolveClientUrl("~/Script/RC.SchemeListing.js") %>" type="text/javascript"></script>
    <script type="text/javascript">
        function SchemeGetAll() {
            $('#dvSchemeListing #dvSchemeListProcessing').show();
            $('#dvSchemeListing #dvSchemeList').hide();
            ddlFY.SetEnabled(false);

            $.post(RC.Common.RootURL + "Handler/SchemeHandler.ashx",
                {
                    method: "SchemeGetAll",
                    FinancialYearId: ddlFY.GetSelectedItem().value
                },
                function (response) {
                    $('#dvSchemeListing #dvSchemeList').show();
                    $('#dvSchemeListing #dvSchemeListProcessing').hide();
                    ddlFY.SetEnabled(true);

                    switch (response.Status) {
                        case RC.Common.ResponseStatus.SUCCESS:
                            RC.SchemeListing.SchemeList = [];

                            if (response.Data != null && response.Data != undefined && response.Data.length > 0) {
                                RC.SchemeListing.SchemeList = response.Data;
                            }

                            RC.SchemeListing.ReloadPage();

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
    </script>
</asp:Content>

