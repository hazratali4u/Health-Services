<%@ Page Title="" Language="C#" MasterPageFile="~/Forms/PageMaster.master" AutoEventWireup="true" CodeFile="frmSchemeFundReleaseAdd.aspx.cs" Inherits="Forms_frmSchemeFundReleaseAdd" %>

<%@ Register Assembly="DevExpress.Web.v16.1, Version=16.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphHeadPage" runat="Server">
    <style>
        .dashboard-stat {
            margin-bottom: 0px !important;
        }

            .dashboard-stat.dashboard-stat-v2 .visual {
                margin-bottom: 5px !important;
            }

            .dashboard-stat .details .number {
                padding-top: 15px !important;
                font-size: 32px !important;
            }

            .dashboard-stat .details .ocnumber {
                font-size: 20px !important;
            }
    </style>
    <script language="JavaScript" type="text/javascript">
        function calendarShown(sender, args) {
            sender._popupBehavior._element.style.zIndex = 10005;
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphPage" runat="Server">
    <div id="dvManageSchemeFundRelease">
        <div class="row">
            <div class="col-md-9">
                <label><span class="fa fa-caret-right rgt_cart"></span>Scheme Name</label>&nbsp;*
                <dx:ASPxComboBox ID="ddlScheme" runat="server" ClientInstanceName="ddlCTScheme" CssClass="form-control" TextFormatString="{0}">
                    <Columns>
                        <dx:ListBoxColumn FieldName="strSchemeName" Caption="Scheme Name" Width="28px" />
                        <dx:ListBoxColumn FieldName="DISTRIBUTOR_NAME" Caption="Spending Unit" Width="20px" />
                        <dx:ListBoxColumn FieldName="ACCOUNT_NAME" Caption="Func. Class" Width="20px" />
                        <dx:ListBoxColumn FieldName="ParentSchemeName" Caption="Parent Scheme Name" Width="20px" />
                        <dx:ListBoxColumn FieldName="IsForeignFunding" Caption="Foreign Funding" Width="12px" />
                    </Columns>
                    <ClientSideEvents SelectedIndexChanged="function(s, e) { SetFinancialYear(s); }" />
                </dx:ASPxComboBox>
            </div>
            <%--<div class="col-md-3" style="display: none;">
                <label><span class="fa fa-caret-right rgt_cart"></span>Fund Release Type</label>
                <dx:ASPxComboBox ID="ddlFundReleaseType" runat="server" ClientInstanceName="ddlCTReleaseType" CssClass="form-control" TextFormatString="{0}">
                    <Columns>
                        <dx:ListBoxColumn FieldName="Title" Caption="Title" Width="100px" />
                    </Columns>
                </dx:ASPxComboBox>
            </div>
            <div class="col-md-1" style="display: none;"></div>--%>
            <div class="col-md-3">
                <label id="lblFinancialYear"><span class="fa fa-caret-right rgt_cart"></span>Financial Year</label>&nbsp;*
                <dx:ASPxComboBox ID="ddlFY" runat="server" ClientInstanceName="ddlCTSchemeFY" CssClass="form-control" TextFormatString="{1}">
                    <Columns>
                        <dx:ListBoxColumn FieldName="Id" Caption="Code" Width="10px" />
                        <dx:ListBoxColumn FieldName="YearName" Caption="Name" Width="40px" />
                    </Columns>
                    <ClientSideEvents SelectedIndexChanged="function(s, e) { RC.ManageSchemeFundRelease.SchemeFundAllocationTotalAmountGetSchemeId(); RC.ManageSchemeFundRelease.SchemeFundAllocationSTotalAmountGetSchemeId(); }" />
                </dx:ASPxComboBox>
            </div>
        </div>
        <div class="row">
            <div class="col-md-2">
                <label><span class="fa fa-caret-right rgt_cart"></span>Scheme Release Date</label>&nbsp;*
                <asp:TextBox ID="txtReleaseDate" runat="server" ClientIDMode="Static" CssClass="form-control" MaxLength="10" onkeyup="BlockStartDateKeyPress()"></asp:TextBox>
            </div>
            <div class="col-md-1" style="margin-top: 22px">
                <asp:ImageButton ID="ibtnReleaseDate" runat="server" Width="30px" ImageUrl="~/App_Themes/Granite/Images/date.gif" />
                <cc1:CalendarExtender ID="CEtProposedDate" runat="server" Format="dd-MMM-yyyy" PopupButtonID="ibtnReleaseDate"
                    TargetControlID="txtReleaseDate" OnClientShown="calendarShown"></cc1:CalendarExtender>
            </div>
            <div class="col-md-3">
                <input type="button" id="btnLoadAllocationData" class="btn btn-primary" value="Load Data From Allocation Plan" onclick="RC.ManageSchemeFundRelease.LoadSchemeFundAllocationDetail();" style="height: 45px; width: 205px; margin-top: 15px;" />
            </div>
            <div class="col-md-6"></div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <input type="button" id="btnCapital" class="btn btn-primary" value="Capital" style="height: 45px; width: 100px;" />
                &nbsp;<input type="button" id="btnRevenue" class="btn btn-default" value="Revenue" style="height: 45px; width: 100px;" />
                &nbsp;<input type="button" id="btnForeignFunding" class="btn btn-default" value="Foreign Funding" style="display: none; height: 45px; width: 120px;" />
            </div>
        </div>
        <div class="row" style="height: 20px;">
        </div>
        <div id="dvManageSchemeFundReleaseDetail">
            <div class="emp-table">
                <asp:Panel ID="pnlSchemeFundReleaseDetail" runat="server" ClientIDMode="Static" GroupingText="Project Capital">
                    <div class="row">
                        <div id="dvCOA" class="col-md-4">
                            <label id="lblCOA"><span class="fa fa-caret-right rgt_cart"></span>Object Code</label>&nbsp;*
                            <dx:ASPxComboBox ID="ddlCOA" runat="server" ClientInstanceName="ddlCTCOA" CssClass="form-control" TextFormatString="{0} ({1})">
                                <Columns>
                                    <dx:ListBoxColumn FieldName="ACCOUNT_CODE" Caption="Code" Width="50px" />
                                    <dx:ListBoxColumn FieldName="ACCOUNT_NAME" Caption="Name" Width="250px" />
                                </Columns>
                                <ClientSideEvents SelectedIndexChanged="function(s, e) { RC.ManageSchemeFundRelease.SchemeFundAllocationTotalAmountGetSchemeId(); }" />
                            </dx:ASPxComboBox>
                        </div>
                        <div id="dvRCOA" class="col-md-4" style="display: none;">
                            <label id="lblRCOA"><span class="fa fa-caret-right rgt_cart"></span>Object Code</label>&nbsp;*
                            <dx:ASPxComboBox ID="ddlRCOA" runat="server" ClientInstanceName="ddlRCTCOA" CssClass="form-control" TextFormatString="{0} ({1})">
                                <Columns>
                                    <dx:ListBoxColumn FieldName="ACCOUNT_CODE" Caption="Code" Width="50px" />
                                    <dx:ListBoxColumn FieldName="ACCOUNT_NAME" Caption="Name" Width="250px" />
                                </Columns>
                                <ClientSideEvents SelectedIndexChanged="function(s, e) { RC.ManageSchemeFundRelease.SchemeFundAllocationTotalAmountGetSchemeId(); }" />
                            </dx:ASPxComboBox>
                        </div>
                        <div id="dvFFCOA" class="col-md-4" style="display: none;">
                            <label><span class="fa fa-caret-right rgt_cart"></span>Object Code</label>&nbsp;*
                            <dx:ASPxComboBox ID="ddlFFCOA" runat="server" ClientInstanceName="ddlFFCTCOA" CssClass="form-control" TextFormatString="{0} ({1})">
                                <Columns>
                                    <dx:ListBoxColumn FieldName="ACCOUNT_CODE" Caption="Code" Width="50px" />
                                    <dx:ListBoxColumn FieldName="ACCOUNT_NAME" Caption="Name" Width="250px" />
                                </Columns>
                                <ClientSideEvents SelectedIndexChanged="function(s, e) { RC.ManageSchemeFundRelease.SchemeFundAllocationTotalAmountGetSchemeId(); }" />
                            </dx:ASPxComboBox>
                        </div>
                        <div class="col-md-4">
                            <div id="dvTotalAmount" class="dashboard-stat dashboard-stat-v2 blue">
                                <div class="visual">
                                </div>
                                <div class="details">
                                    <i id="dvTotalAmountDetail" class="fa fa-info-circle" aria-hidden="true" style="position: absolute; margin-left: -20px; margin-top: 26px;"></i>
                                    <div class="number ocnumber">
                                        Allocated Capital (Object Code)
                                    </div>
                                    <div class="desc">Rs 0.00</div>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-4">
                            <div id="dvSTotalAmount" class="dashboard-stat dashboard-stat-v2 red">
                                <div class="visual">
                                </div>
                                <div class="details">
                                    <i id="dvSTotalAmountDetail" class="fa fa-info-circle" aria-hidden="true" style="position: absolute; margin-left: -20px; margin-top: 26px;"></i>
                                    <div class="number">
                                        Allocated Capital
                                    </div>
                                    <div class="desc">Rs 0.00</div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-2">
                            <label id="lblAmount"><span class="fa fa-caret-right rgt_cart"></span>Amount</label>&nbsp;*
                        <asp:TextBox ID="txtAmount" runat="server" ClientIDMode="Static" CssClass="form-control">
                        </asp:TextBox>
                        </div>
                        <div class="col-md-5">
                            <label id="lblDescription"><span class="fa fa-caret-right rgt_cart"></span>Description</label>
                            <asp:TextBox ID="txtDescription" runat="server" ClientIDMode="Static" CssClass="form-control">
                            </asp:TextBox>
                        </div>
                        <div class="col-md-1">
                            <br />
                            <input type="button" id="btnSaveDetail" class="btn btn-success" onclick="RC.ManageSchemeFundRelease.SchemeFundReleaseDetailSave(-1);" value="Add" style="margin-top: 4px;" />
                        </div>
                        <div class="col-md-4"></div>
                    </div>
                </asp:Panel>
            </div>
            <div class="row">
                <div class="col-md-12">
                    <table id="tblSchemeFundReleaseDetailList" class="table table-striped table-bordered" style="width: 100%;">
                        <thead>
                            <tr>
                                <th style="width: 25%;">Object Code</th>
                                <th style="width: 15%; text-align: center;">Released Amount</th>
                                <th style="width: 15%; text-align: center;">Allocated Amount</th>
                                <th style="width: 35%;">Description</th>
                                <th style="width: 10%; text-align: center;">Action</th>
                            </tr>
                        </thead>
                    </table>
                </div>
            </div>
        </div>
        <div class="row" style="height: 20px;">
        </div>
        <input type="button" id="btnSave" class="btn btn-success" onclick="RC.ManageSchemeFundRelease.SaveSchemeFundRelease();" value="Save" />
        <input type="button" id="btnCancel" class="btn btn-danger" value="Cancel" />
    </div>
    <script src="<%= Page.ResolveClientUrl("~/Script/RC.ManageSchemeFundRelease.js") %>" type="text/javascript"></script>
    <script type="text/javascript">
        function SetFinancialYear() {
            $.post(RC.Common.RootURL + "Handler/FinancialYearHandler.ashx",
            {
                method: "FinancialYearGetSchemeId",
                SchemeId: ddlCTScheme.GetSelectedItem().value,
                SchemeFetchMode: 4
            },
            function (response) {
                switch (response.Status) {
                    case RC.Common.ResponseStatus.SUCCESS:
                        ddlCTSchemeFY.ClearItems();

                        if (response.Data != null && response.Data != undefined && response.Data.length > 0) {
                            $(response.Data).each(function (index, item) {
                                ddlCTSchemeFY.AddItem(new Array(item.Id.toString(), item.YearName), item.Id.toString());
                            });

                            ddlCTSchemeFY.SetSelectedIndex(0);
                        }

                        RC.ManageSchemeFundRelease.ShowForeignFundingForScheme();

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

                RC.ManageSchemeFundRelease.SchemeFundAllocationSTotalAmountGetSchemeId();
            });

            $.post(RC.Common.RootURL + "Handler/COAHandler.ashx",
            {
                method: "COAGetParentChildSchemeId",
                SchemeId: ddlCTScheme.GetSelectedItem().value
            },
            function (response) {
                switch (response.Status) {
                    case RC.Common.ResponseStatus.SUCCESS:
                        ddlCTCOA.ClearItems();
                        ddlRCTCOA.ClearItems();
                        ddlFFCTCOA.ClearItems();

                        if (response.Data != null && response.Data != undefined && response.Data.length > 0) {
                            $(response.Data).each(function (index, item) {
                                ddlRCTCOA.AddItem(new Array(item.ACCOUNT_CODE, item.ACCOUNT_NAME), item.ACCOUNT_HEAD_ID.toString());
                                ddlFFCTCOA.AddItem(new Array(item.ACCOUNT_CODE, item.ACCOUNT_NAME), item.ACCOUNT_HEAD_ID.toString());

                                if (RC.Common.Domain == "PU") {
                                    if (item.ACCOUNT_CODE.toLowerCase().indexOf("a12") >= 0) {
                                        ddlCTCOA.AddItem(new Array(item.ACCOUNT_CODE, item.ACCOUNT_NAME), item.ACCOUNT_HEAD_ID.toString());
                                    }
                                }
                                else {
                                    ddlCTCOA.AddItem(new Array(item.ACCOUNT_CODE, item.ACCOUNT_NAME), item.ACCOUNT_HEAD_ID.toString());
                                }
                            });

                            ddlCTCOA.SetSelectedIndex(0);
                            ddlRCTCOA.SetSelectedIndex(0);
                            ddlFFCTCOA.SetSelectedIndex(0);
                        }

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

                RC.ManageSchemeFundRelease.SchemeFundAllocationTotalAmountGetSchemeId();
            });
        }
    </script>
</asp:Content>

