<%@ Page Title="MPR :: Scheme" Language="C#" MasterPageFile="~/Forms/PageMaster.master" AutoEventWireup="true" CodeFile="frmSchemeAdd.aspx.cs" Inherits="Forms_frmSchemeAdd" %>

<%@ Register Assembly="DevExpress.Web.v16.1, Version=16.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphHeadPage" runat="Server">
    <style type="text/css">
        .cls .dxeEditAreaSys {
            -webkit-user-select: none !important;
            -moz-user-select: none !important;
            -ms-user-select: none !important;
            user-select: none !important;
        }

        .disabledContent {
            pointer-events: none;
            opacity: 0.4;
        }
    </style>
    <script language="JavaScript" type="text/javascript">
        function calendarShown(sender, args) {
            sender._popupBehavior._element.style.zIndex = 10005;
        }
    </script>
    <asp:HiddenField ID="hfNextFYYear" runat="server" ClientIDMode="Static" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphPage" runat="Server">
    <div id="dvManageScheme">
        <div class="row">
            <div class="col-md-6">
                <label id="lblSchemeName"><span class="fa fa-caret-right rgt_cart"></span>Scheme Name</label>&nbsp;*
                <asp:TextBox ID="txtSchemeName" runat="server" CssClass="form-control" ClientIDMode="Static"></asp:TextBox>
            </div>
            <div class="col-md-3" id="dvFunctionalClassificationCapital">
                <label id="lblClassification"><span class="fa fa-caret-right rgt_cart"></span>Functional Classification</label>&nbsp;*&nbsp;&nbsp;<label style="color: firebrick; font-weight: bold;">Capital</label>
                <dx:ASPxComboBox ID="ddlCOA" runat="server" CssClass="form-control" TextFormatString="{1}" ClientInstanceName="ddlCOA">
                    <Columns>
                        <dx:ListBoxColumn FieldName="ACCOUNT_CODE" Caption="Code" Width="20px" />
                        <dx:ListBoxColumn FieldName="ACCOUNT_NAME" Caption="Name" Width="40px" />
                    </Columns>
                </dx:ASPxComboBox>
            </div>
            <div class="col-md-3" id="dvSAPCapital">
                <span class="fa fa-caret-right rgt_cart"></span>
                <label id="lblSAPCapital" runat="server" clientidmode="Static">SAP Capital Code & Cost</label>
                <table width="100%">
                    <tr>
                        <td style="width: 48%">
                            <asp:TextBox ID="txtCapitalCode" runat="server" CssClass="form-control" placeholder="Code" ClientIDMode="Static"></asp:TextBox>
                        </td>
                        <td style="width: 4%">&nbsp;</td>
                        <td style="width: 48%">
                            <asp:TextBox ID="txtCapitalAmount" runat="server" CssClass="form-control" placeholder="Amount" ClientIDMode="Static"></asp:TextBox>
                        </td>
                    </tr>
                </table>
            </div>
        </div>
        <div class="row">
            <div class="col-md-6">
                <label id="lblInstitue">
                    <span class="fa fa-caret-right rgt_cart"></span>
                    <asp:Label ID="lblSpendingUnit" runat="server" clientidmode="Static"></asp:Label></label>&nbsp;*
                <dx:ASPxComboBox ID="ddlInstitute" runat="server" CssClass="form-control" TextFormatString="{0}" ClientInstanceName="ddlInstitute">
                    <Columns>
                        <dx:ListBoxColumn FieldName="DISTRIBUTOR_NAME" Caption="Name" Width="80px" />
                        <dx:ListBoxColumn FieldName="District" Caption="District" Width="20px" />
                    </Columns>
                    <ClientSideEvents SelectedIndexChanged="function(s, e) { RC.ManageScheme.PopulateForInstitute(); }" />
                </dx:ASPxComboBox>
            </div>
            <div class="col-md-3" id="dvFunctionalClassificationRevenue">
                <label><span class="fa fa-caret-right rgt_cart"></span>Functional Classification</label>&nbsp;*&nbsp;&nbsp;<label style="color: firebrick; font-weight: bold;">Revenue</label>
                <dx:ASPxComboBox ID="ddlRCOA" runat="server" CssClass="form-control" TextFormatString="{1}" ClientInstanceName="ddlRCOA">
                    <Columns>
                        <dx:ListBoxColumn FieldName="ACCOUNT_CODE" Caption="Code" Width="20px" />
                        <dx:ListBoxColumn FieldName="ACCOUNT_NAME" Caption="Name" Width="40px" />
                    </Columns>
                </dx:ASPxComboBox>
            </div>
            <div class="col-md-3" id="dvSAPRevenue" runat="server" clientidmode="Static">
                <span class="fa fa-caret-right rgt_cart"></span>
                <label id="lblSAPRevenue" runat="server" clientidmode="Static">SAP Revenue Code & Cost</label>
                <table width="100%">
                    <tr>
                        <td style="width: 48%">
                            <asp:TextBox ID="txtRevenueCode" runat="server" CssClass="form-control" placeholder="Code" ClientIDMode="Static"></asp:TextBox>
                        </td>
                        <td style="width: 4%">&nbsp;</td>
                        <td style="width: 48%">
                            <asp:TextBox ID="txtRevenueAmount" runat="server" CssClass="form-control" placeholder="Amount" ClientIDMode="Static"></asp:TextBox>
                        </td>
                    </tr>
                </table>
            </div>
        </div>
        <div class="row">
            <div class="col-md-2" id="dvSubSector">
                <label id="lblDistrict"><span class="fa fa-caret-right rgt_cart"></span>Sub Sector</label>&nbsp;*
                <dx:ASPxComboBox ID="ddlSubSector" runat="server" CssClass="form-control" TextFormatString="{1}" ClientInstanceName="ddlSubSector">
                    <Columns>
                        <dx:ListBoxColumn FieldName="strCode" Caption="Code" Width="20px" />
                        <dx:ListBoxColumn FieldName="strName" Caption="Name" Width="40px" />
                    </Columns>
                </dx:ASPxComboBox>
            </div>
            <div class="col-md-2">
                <label id="lblTehsil">
                    <span class="fa fa-caret-right rgt_cart"></span>District-Constituency</label>
                <table width="100%">
                    <tr>
                        <td style="width: 48%">
                            <asp:TextBox ID="txtDistrict" runat="server" CssClass="form-control" Enabled="false" ClientIDMode="Static"></asp:TextBox>
                        </td>
                        <td style="width: 4%">&nbsp;</td>
                        <td style="width: 48%">
                            <asp:TextBox ID="txtTehsil" runat="server" CssClass="form-control" Enabled="false" ClientIDMode="Static"></asp:TextBox>
                        </td>
                    </tr>
                </table>
            </div>
            <div class="col-md-2">
                <label id="lblSchemeDate"><span class="fa fa-caret-right rgt_cart"></span>Scheme Date</label>&nbsp;*
                <table width="100%">
                    <tr>
                        <td style="width: 80%">
                            <asp:TextBox ID="txtSchemeDate" runat="server" CssClass="form-control" MaxLength="10" onkeyup="BlockStartDateKeyPress()" ClientIDMode="Static"></asp:TextBox>
                        </td>
                        <td style="width: 4%">&nbsp;</td>
                        <td style="width: 16%">
                            <asp:ImageButton ID="imgSchemeDate" runat="server" Width="30px" ImageUrl="~/App_Themes/Granite/Images/date.gif" Style="margin-top: -26px;" />
                            <cc1:CalendarExtender ID="CalendarExtender1" runat="server" Format="dd-MMM-yyyy" PopupButtonID="imgSchemeDate"
                                TargetControlID="txtSchemeDate" OnClientShown="calendarShown"></cc1:CalendarExtender>
                        </td>
                    </tr>
                </table>
            </div>
            <div class="col-md-3" id="dvTypeOfBand" runat="server" clientidmode="Static">
                <label id="lblTypeOfBand"><span class="fa fa-caret-right rgt_cart"></span>Type Of Bank</label>&nbsp;*
                <dx:ASPxComboBox ID="ddlTypeOfBank" runat="server" CssClass="form-control" ClientInstanceName="ddlTypeOfBank">
                    <Items>
                        <dx:ListEditItem Text="Special Drawing Account" Value="1" Selected="true" />
                        <dx:ListEditItem Text="Personal Ledger Account" Value="2" />
                        <dx:ListEditItem Text="Commercial" Value="3" />
                    </Items>
                </dx:ASPxComboBox>
            </div>
            <div class="col-md-3" id="dvYearlyCost" runat="server" clientidmode="Static">
                <label id="lblYearlyCost"><span class="fa fa-caret-right rgt_cart"></span>Yearly Recurring Cost</label>
                <table width="100%">
                    <tr>
                        <td style="width: 48%">
                            <asp:TextBox ID="txtRecurringCostPercent" runat="server" CssClass="form-control" placeholder="%" ClientIDMode="Static"></asp:TextBox>
                            <cc1:FilteredTextBoxExtender runat="server" ID="FilteredTextBoxExtender6"
                                TargetControlID="txtRecurringCostPercent" ValidChars="0987654321."></cc1:FilteredTextBoxExtender>
                        </td>
                        <td style="width: 4%">&nbsp;</td>
                        <td style="width: 48%">
                            <asp:TextBox ID="txtRecurringCostAmount" runat="server" CssClass="form-control" placeholder="Amount" ClientIDMode="Static"></asp:TextBox>
                        </td>
                    </tr>
                </table>
            </div>
        </div>
        <div class="row">
            <div class="col-md-2">
                <label id="lblCategory"><span class="fa fa-caret-right rgt_cart"></span>Category</label>&nbsp;*
                <dx:ASPxComboBox ID="ddlCategory" runat="server" CssClass="form-control" ClientInstanceName="ddlCategory">
                    <Columns>
                        <dx:ListBoxColumn FieldName="Title" Caption="Title" Width="100px" />
                    </Columns>
                </dx:ASPxComboBox>
            </div>
            <div class="col-md-2">
                <label id="lblStartDate"><span class="fa fa-caret-right rgt_cart"></span>Start Date</label>&nbsp;*
                <table width="100%">
                    <tr>
                        <td style="width: 80%">
                            <asp:TextBox ID="txtStartDate" runat="server" CssClass="form-control" onchange="RC.ManageScheme.PopulateYearWiseDate();" ClientIDMode="Static"></asp:TextBox>
                        </td>
                        <td style="width: 4%">&nbsp;</td>
                        <td style="width: 16%">
                            <asp:ImageButton ID="ibtnStartDate" runat="server" Width="30px" ImageUrl="~/App_Themes/Granite/Images/date.gif" Style="margin-top: -26px;" />
                            <cc1:CalendarExtender ID="CEStartDate" runat="server" Format="dd-MMM-yyyy" PopupButtonID="ibtnStartDate"
                                TargetControlID="txtStartDate" OnClientShown="calendarShown"></cc1:CalendarExtender>
                        </td>
                    </tr>
                </table>
            </div>
            <div class="col-md-2">
                <label id="lblEndDate"><span class="fa fa-caret-right rgt_cart"></span>End Date</label>&nbsp;*
                <table width="100%">
                    <tr>
                        <td style="width: 80%">
                            <asp:TextBox ID="txtEndDate" runat="server" CssClass="form-control" onchange="RC.ManageScheme.PopulateYearWiseDate();" ClientIDMode="Static"></asp:TextBox>
                        </td>
                        <td style="width: 4%">&nbsp;</td>
                        <td style="width: 16%">
                            <asp:ImageButton ID="ibnEndDate" runat="server" Width="30px" ImageUrl="~/App_Themes/Granite/Images/date.gif" Style="margin-top: -26px;" />
                            <cc1:CalendarExtender ID="CEEndDate" runat="server" Format="dd-MMM-yyyy" PopupButtonID="ibnEndDate"
                                TargetControlID="txtEndDate" OnClientShown="calendarShown"></cc1:CalendarExtender>
                        </td>
                    </tr>
                </table>
            </div>
            <div class="col-md-3" id="dvForeignFunding">
                <label><span class="fa fa-caret-right rgt_cart"></span>Foreign Funding</label>
                <asp:CheckBox ID="chkForeignFunding" runat="server" CssClass="form-control" ClientIDMode="Static" />
            </div>
            <div class="col-md-3" style="display: none;">
                <label id="lblExpense"><span class="fa fa-caret-right rgt_cart"></span>Last Year Expenditure</label>
                <asp:TextBox ID="txtLastYearExpense" runat="server" CssClass="form-control" ClientIDMode="Static"></asp:TextBox>
            </div>
            <div class="col-md-3">
                <span class="fa fa-caret-right rgt_cart"></span>
                <label id="lblGSCode" runat="server" clientidmode="Static">Year Wise GS Code</label>
                <table width="100%">
                    <tr>
                        <td style="width: 48%">
                            <dx:ASPxComboBox ID="ddlFinancialYear" runat="server" CssClass="form-control" ClientInstanceName="ddlFinancialYear">
                                <Columns>
                                    <dx:ListBoxColumn Caption="Title" Width="100px" />
                                </Columns>
                                <ClientSideEvents SelectedIndexChanged="function(s, e) { RC.ManageScheme.PopulateForGSCode(); }" />
                            </dx:ASPxComboBox>
                        </td>
                        <td style="width: 4%">&nbsp;</td>
                        <td style="width: 48%">
                            <asp:TextBox ID="txtGSCode" runat="server" CssClass="form-control" placeholder="GS Code" ClientIDMode="Static"></asp:TextBox>
                        </td>
                    </tr>
                </table>
            </div>
        </div>
        <div id="dvSchemeStatus" runat="server" class="row" clientidmode="Static">
            <div class="col-md-2">
                <label><span class="fa fa-caret-right rgt_cart"></span>Status</label>
                <dx:ASPxComboBox ID="ddlSchemeStatus" runat="server" CssClass="form-control" ClientInstanceName="ddlCTSchemeStatus">
                    <Items>
                        <dx:ListEditItem Text="Parent" Value="1" Selected="true" />
                        <dx:ListEditItem Text="Child" Value="2" />
                    </Items>
                    <ClientSideEvents SelectedIndexChanged="function(s, e) { SetSchemeStatus(s); }" />
                </dx:ASPxComboBox>
            </div>
            <div class="col-md-4" id="dvParentScheme" style="display: none;">
                <label><span class="fa fa-caret-right rgt_cart"></span>Parent Scheme</label>
                <dx:ASPxComboBox ID="ddlParentScheme" runat="server" ClientInstanceName="ddlCTParentScheme" CssClass="form-control" TextFormatString="{0}">
                    <Columns>
                        <dx:ListBoxColumn FieldName="strSchemeName" Caption="Scheme Name" Width="40px" />
                        <dx:ListBoxColumn FieldName="DISTRIBUTOR_NAME" Caption="Spending Unit" Width="20px" />
                        <dx:ListBoxColumn FieldName="ACCOUNT_NAME" Caption="Func. Class" Width="20px" />
                    </Columns>
                    <ClientSideEvents SelectedIndexChanged="function(s, e) { SchemeGetId(); }" />
                </dx:ASPxComboBox>
            </div>
            <div class="col-md-6">&nbsp;</div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <label id="lblRemarks"><span class="fa fa-caret-right rgt_cart"></span>Remarks</label>
                <asp:TextBox ID="txtRemarks" runat="server" CssClass="form-control" TextMode="MultiLine" Height="70" ClientIDMode="Static"></asp:TextBox>
            </div>
        </div>
        <div class="row" style="height: 20px;">
        </div>
        <input type="button" id="btnSave" class="btn btn-success" onclick="RC.ManageScheme.SaveScheme();" value="Save" />
        <input type="button" id="btnCancel" class="btn btn-danger" value="Cancel" />
    </div>
    <script src="<%= Page.ResolveClientUrl("~/Script/RC.ManageScheme.js") %>" type="text/javascript"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            SetSchemeStatus();
        });

        function SetFinancialYear() {
            $.post(RC.Common.RootURL + "Handler/FinancialYearHandler.ashx",
                {
                    method: "FinancialYearGetSchemeId",
                    SchemeId: ddlCTScheme.GetSelectedItem().value,
                    SchemeFetchMode: 2
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

            $.post(RC.Common.RootURL + "Handler/COAHandler.ashx",
                {
                    method: "COAGetSchemeId",
                    SchemeId: ddlCTScheme.GetSelectedItem().value
                },
                function (response) {
                    switch (response.Status) {
                        case RC.Common.ResponseStatus.SUCCESS:
                            ddlCTCOA.ClearItems();
                            ddlRCTCOA.ClearItems();

                            if (response.Data != null && response.Data != undefined && response.Data.length > 0) {
                                $(response.Data).each(function (index, item) {
                                    ddlRCTCOA.AddItem(new Array(item.ACCOUNT_CODE, item.ACCOUNT_NAME), item.ACCOUNT_HEAD_ID.toString());

                                    if (item.ACCOUNT_CODE.toLowerCase().indexOf("a12") >= 0) {
                                        ddlCTCOA.AddItem(new Array(item.ACCOUNT_CODE, item.ACCOUNT_NAME), item.ACCOUNT_HEAD_ID.toString());
                                    }
                                });

                                ddlCTCOA.SetSelectedIndex(0);
                                ddlRCTCOA.SetSelectedIndex(0);
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

                    RC.ManageScheme.SchemeFundApprovalTotalAmountGetSchemeId();
                });
        }

        function SchemeGetId() {
            $.post(RC.Common.RootURL + "Handler/SchemeHandler.ashx",
                {
                    method: "SchemeGetId",
                    SchemeId: ddlCTParentScheme.GetSelectedItem().value
                },
                function (response) {
                    switch (response.Status) {
                        case RC.Common.ResponseStatus.SUCCESS:
                            if (response.Data != null && response.Data != undefined) {
                                ddlSubSector.SetValue(response.Data.intSubSectorID);
                                ddlCOA.SetValue(response.Data.intFCAccountHeadID);
                                ddlRCOA.SetValue(response.Data.intRFCAccountHeadID);
                                $('#dvManageScheme #chkForeignFunding').prop('checked', response.Data.IsForeignFunding);
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
                });
        }

        function SetSchemeStatus() {
            if (ddlCTSchemeStatus.GetSelectedItem() != null && parseInt(ddlCTSchemeStatus.GetSelectedItem().value) == 2) {
                $('#dvManageScheme #dvSubSector').addClass("disabledContent");
                $('#dvManageScheme #dvFunctionalClassificationCapital').addClass("disabledContent");
                $('#dvManageScheme #dvFunctionalClassificationRevenue').addClass("disabledContent");
                $('#dvManageScheme #dvForeignFunding').addClass("disabledContent");
                $('#dvManageScheme #dvSAPCapital').hide();
                $('#dvManageScheme #dvSAPRevenue').hide();
                $('#dvManageScheme #dvTypeOfBand').hide();
                $('#dvManageScheme #dvYearlyCost').hide();
                $('#dvManageScheme #dvParentScheme').show();

                SchemeGetId();
            }
            else {
                $('#dvManageScheme #dvSubSector').removeClass("disabledContent");
                $('#dvManageScheme #dvFunctionalClassificationCapital').removeClass("disabledContent");
                $('#dvManageScheme #dvFunctionalClassificationRevenue').removeClass("disabledContent");
                $('#dvManageScheme #dvForeignFunding').removeClass("disabledContent");
                $('#dvManageScheme #dvSAPCapital').show();
                $('#dvManageScheme #dvSAPRevenue').show();
                $('#dvManageScheme #dvTypeOfBand').show();
                $('#dvManageScheme #dvYearlyCost').show();
                $('#dvManageScheme #dvParentScheme').hide();

                if (RC.ManageScheme.SchemeObject != null && RC.ManageScheme.SchemeObject.Id > 0) {
                    ddlSubSector.SetValue(RC.ManageScheme.SchemeObject.intSubSectorID);
                    ddlCOA.SetValue(RC.ManageScheme.SchemeObject.intFCAccountHeadID);
                    ddlRCOA.SetValue(RC.ManageScheme.SchemeObject.intRFCAccountHeadID);
                    $('#dvManageScheme #chkForeignFunding').prop('checked', RC.ManageScheme.SchemeObject.IsForeignFunding);
                }
                else {
                    ddlSubSector.SetSelectedIndex(0);
                    ddlCOA.SetSelectedIndex(0);
                    ddlRCOA.SetSelectedIndex(0);
                    $('#dvManageScheme #chkForeignFunding').prop('checked', false);
                }
            }
        }
    </script>
</asp:Content>

