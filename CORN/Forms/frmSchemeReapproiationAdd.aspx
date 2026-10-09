<%@ Page Title="MPR :: Reapproiation" Language="C#" MasterPageFile="~/Forms/PageMaster.master"
    AutoEventWireup="true" CodeFile="frmSchemeReapproiationAdd.aspx.cs" Inherits="Forms_frmSchemeReapproiationAdd" %>

<%@ Register Assembly="DevExpress.Web.v16.1, Version=16.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content2" ContentPlaceHolderID="cphHeadPage" runat="Server">
    <script language="JavaScript" type="text/javascript">
        function calendarShown(sender, args) {
            sender._popupBehavior._element.style.zIndex = 10005;
        }
    </script>
</asp:Content>
<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="cphPage">
    <div id="dvManageSchemeReappropriation">
        <div class="row" style="margin-bottom: 10px;">
            <div class="col-md-3">
                <label id="lblFinancialYear"><span class="fa fa-caret-right rgt_cart"></span>Financial Year</label>&nbsp;*
                <dx:ASPxComboBox ID="ddlFY" runat="server" ClientInstanceName="ddlCTSchemeFY" CssClass="form-control" TextFormatString="{1}">
                    <Columns>
                        <dx:ListBoxColumn FieldName="Id" Caption="Code" Width="10px" />
                        <dx:ListBoxColumn FieldName="YearName" Caption="Name" Width="40px" />
                    </Columns>
                </dx:ASPxComboBox>
            </div>
            <div class="col-md-3">
                <label><span class="fa fa-caret-right rgt_cart"></span>Month</label>&nbsp;*
                <dx:ASPxComboBox ID="ddlMonth" runat="server" ClientInstanceName="ddlCTMonth" CssClass="form-control" TextFormatString="{0}">
                    <Columns>
                        <dx:ListBoxColumn FieldName="Title" Caption="Title" Width="100px" />
                    </Columns>
                </dx:ASPxComboBox>
            </div>
            <div class="col-md-2">
                <label><span class="fa fa-caret-right rgt_cart"></span>Group Transaction</label>
                <asp:CheckBox ID="chkGroupTransaction" runat="server" CssClass="form-control" ClientIDMode="Static" onclick="SetTransactionAmount()" />
            </div>
            <div class="col-md-4">&nbsp;</div>
        </div>
        <div id="dvTransactionAmount" class="row" style="margin-bottom: 10px; display: none;">
            <div class="col-md-3"></div>
            <div class="col-md-4">
                <div class="dashboard-stat dashboard-stat-v2 blue">
                    <div class="visual">
                    </div>
                    <div class="details">
                        <div class="number ocnumber">
                            Transaction Amount
                        </div>
                        <div class="desc">Rs 0.00</div>
                    </div>
                </div>
            </div>
            <div class="col-md-2">
                <input type="button" id="btnResetTransactionAmount" class="btn btn-danger" onclick="ResetTransactionAmount();" value="Reset" style="margin-top: 38px;" />
            </div>
            <div class="col-md-3"></div>
        </div>
        <div id="dvManageSchemeReappropriationDetail" style="margin-bottom: 40px;">
            <div class="emp-table">
                <asp:Panel ID="pnlSchemeReappropriationDetail" runat="server" ClientIDMode="Static">
                    <div class="col-md-6">
                        <label style="font-size: 22px;"><span class="fa fa-caret-right rgt_cart"></span>From</label>
                        <div class="row" style="height: 20px;"></div>
                        <label><span class="fa fa-caret-right rgt_cart"></span>Fund Type</label>&nbsp;*
                        <dx:ASPxComboBox ID="ddlFFundType" runat="server" ClientInstanceName="ddlFCTFundType" CssClass="form-control" Width="50%">
                            <Columns>
                                <dx:ListBoxColumn FieldName="Title" Caption="Title" />
                            </Columns>
                        </dx:ASPxComboBox>
                        <label><span class="fa fa-caret-right rgt_cart"></span>Scheme Name</label>&nbsp;*
                        <dx:ASPxComboBox ID="ddlFScheme" runat="server" ClientInstanceName="ddlFCTScheme" CssClass="form-control" TextFormatString="{0}">
                            <Columns>
                                <dx:ListBoxColumn FieldName="strSchemeName" Caption="Scheme Name" Width="48px" />
                                <dx:ListBoxColumn FieldName="DISTRIBUTOR_NAME" Caption="Spending Unit" Width="20px" />
                                <dx:ListBoxColumn FieldName="ACCOUNT_NAME" Caption="Func. Class" Width="20px" />
                                <dx:ListBoxColumn FieldName="IsForeignFunding" Caption="Foreign Funding" Width="12px" />
                            </Columns>
                            <ClientSideEvents SelectedIndexChanged="function(s, e) { SetFCOA(s); }" />
                        </dx:ASPxComboBox>
                        <label><span class="fa fa-caret-right rgt_cart"></span>Object Code</label>&nbsp;*
                        <dx:ASPxComboBox ID="ddlFCOA" runat="server" ClientInstanceName="ddlFCTCOA" CssClass="form-control" TextFormatString="{0} ({1})">
                            <Columns>
                                <dx:ListBoxColumn FieldName="ACCOUNT_CODE" Caption="Code" Width="50px" />
                                <dx:ListBoxColumn FieldName="ACCOUNT_NAME" Caption="Name" Width="250px" />
                            </Columns>
                        </dx:ASPxComboBox>
                        <div class="row">
                            <div class="col-md-4">
                                <label><span class="fa fa-caret-right rgt_cart"></span>Transaction Date</label>&nbsp;*
                                <table width="100%">
                                    <tr>
                                        <td style="width: 80%">
                                            <asp:TextBox ID="txtFromTransactionDate" runat="server" CssClass="form-control" MaxLength="10" onkeyup="BlockStartDateKeyPress()" ClientIDMode="Static"></asp:TextBox>
                                        </td>
                                        <td style="width: 4%">&nbsp;</td>
                                        <td style="width: 16%">
                                            <asp:ImageButton ID="imgFromTransactionDate" runat="server" Width="30px" ImageUrl="~/App_Themes/Granite/Images/date.gif" Style="margin-top: -26px;" />
                                            <cc1:CalendarExtender ID="ceFromTransactionDate" runat="server" Format="dd-MMM-yyyy" PopupButtonID="imgFromTransactionDate"
                                                TargetControlID="txtFromTransactionDate" OnClientShown="calendarShown"></cc1:CalendarExtender>
                                        </td>
                                    </tr>
                                </table>
                            </div>
                            <div class="col-md-8">
                                <label><span class="fa fa-caret-right rgt_cart"></span>Amount</label>&nbsp;*
                                <table style="width: 70%;">
                                    <tr>
                                        <td style="width: 70%;">
                                            <asp:TextBox ID="txtFromAmount" runat="server" ClientIDMode="Static" CssClass="form-control">
                                            </asp:TextBox>
                                        </td>
                                        <td>&nbsp;&nbsp;<input type="button" id="btnFromSaveDetail" class="btn btn-success" onclick="RC.ManageSchemeReappropriation.SchemeReappropriationFromDetailSave(-1);" value="Add" style="margin-top: -24px;" />
                                        </td>
                                    </tr>
                                </table>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-6">
                        <label style="font-size: 22px;"><span class="fa fa-caret-right rgt_cart"></span>To</label>
                        <div class="row" style="height: 20px;"></div>
                        <label><span class="fa fa-caret-right rgt_cart"></span>Fund Type</label>&nbsp;*
                        <dx:ASPxComboBox ID="ddlTFundType" runat="server" ClientInstanceName="ddlTCTFundType" CssClass="form-control" Width="50%">
                            <Columns>
                                <dx:ListBoxColumn FieldName="Title" Caption="Title" />
                            </Columns>
                        </dx:ASPxComboBox>
                        <label><span class="fa fa-caret-right rgt_cart"></span>Scheme Name</label>&nbsp;*
                        <dx:ASPxComboBox ID="ddlTScheme" runat="server" ClientInstanceName="ddlTCTScheme" CssClass="form-control" TextFormatString="{0}">
                            <Columns>
                                <dx:ListBoxColumn FieldName="strSchemeName" Caption="Scheme Name" Width="48px" />
                                <dx:ListBoxColumn FieldName="DISTRIBUTOR_NAME" Caption="Spending Unit" Width="20px" />
                                <dx:ListBoxColumn FieldName="ACCOUNT_NAME" Caption="Func. Class" Width="20px" />
                                <dx:ListBoxColumn FieldName="IsForeignFunding" Caption="Foreign Funding" Width="12px" />
                            </Columns>
                            <ClientSideEvents SelectedIndexChanged="function(s, e) { SetTCOA(s); }" />
                        </dx:ASPxComboBox>
                        <label><span class="fa fa-caret-right rgt_cart"></span>Object Code</label>&nbsp;*
                        <dx:ASPxComboBox ID="ddlTCOA" runat="server" ClientInstanceName="ddlTCTCOA" CssClass="form-control" TextFormatString="{0} ({1})">
                            <Columns>
                                <dx:ListBoxColumn FieldName="ACCOUNT_CODE" Caption="Code" Width="50px" />
                                <dx:ListBoxColumn FieldName="ACCOUNT_NAME" Caption="Name" Width="250px" />
                            </Columns>
                        </dx:ASPxComboBox>
                        <div id="dvToSchemeAmount" class="row" style="display: none;">
                            <div class="col-md-4">
                                <label><span class="fa fa-caret-right rgt_cart"></span>Transaction Date</label>&nbsp;*
                                <table width="100%">
                                    <tr>
                                        <td style="width: 80%">
                                            <asp:TextBox ID="txtToTransactionDate" runat="server" CssClass="form-control" MaxLength="10" onkeyup="BlockStartDateKeyPress()" ClientIDMode="Static"></asp:TextBox>
                                        </td>
                                        <td style="width: 4%">&nbsp;</td>
                                        <td style="width: 16%">
                                            <asp:ImageButton ID="imgToTransactionDate" runat="server" Width="30px" ImageUrl="~/App_Themes/Granite/Images/date.gif" Style="margin-top: -26px;" />
                                            <cc1:CalendarExtender ID="ceToTransactionDate" runat="server" Format="dd-MMM-yyyy" PopupButtonID="imgToTransactionDate"
                                                TargetControlID="txtToTransactionDate" OnClientShown="calendarShown"></cc1:CalendarExtender>
                                        </td>
                                    </tr>
                                </table>
                            </div>
                            <div class="col-md-8">
                                <label><span class="fa fa-caret-right rgt_cart"></span>Amount</label>&nbsp;*
                                <table style="width: 70%;">
                                    <tr>
                                        <td style="width: 70%;">
                                            <asp:TextBox ID="txtToAmount" runat="server" ClientIDMode="Static" CssClass="form-control">
                                            </asp:TextBox>
                                        </td>
                                        <td>&nbsp;&nbsp;<input type="button" id="btnToSaveDetail" class="btn btn-success" onclick="RC.ManageSchemeReappropriation.SchemeReappropriationToDetailSave(-1);" value="Add" style="margin-top: -24px;" />
                                        </td>
                                    </tr>
                                </table>
                            </div>
                        </div>
                    </div>
                </asp:Panel>
            </div>
            <div class="row">
                <div class="col-md-12">
                    <table id="tblSchemeReappropriationDetailList" class="table table-striped table-bordered" style="width: 100%;">
                        <thead>
                            <tr>
                                <th style="width: 8%; text-align: center;">Date</th>
                                <th style="width: 21%;">From - Scheme</th>
                                <th style="width: 20%;">From - Object Code</th>
                                <th style="width: 21%;">To - Scheme</th>
                                <th style="width: 20%;">To - Object Code</th>
                                <th style="width: 6%; text-align: center;">Amount</th>
                                <th style="width: 4%; text-align: center;">Action</th>
                            </tr>
                        </thead>
                    </table>
                </div>
            </div>
        </div>
        <input type="button" id="btnSave" class="btn btn-success" onclick="RC.ManageSchemeReappropriation.SaveSchemeReappropriation();" value="Save" />
        <input type="button" id="btnCancel" class="btn btn-danger" value="Cancel" />
    </div>
    <script src="<%= Page.ResolveClientUrl("~/Script/RC.ManageSchemeReappropriation.js") %>" type="text/javascript"></script>
    <script type="text/javascript">
        function SetFCOA() {
            $.post(RC.Common.RootURL + "Handler/COAHandler.ashx",
            {
                method: "COAGetSchemeIdForAllocation",
                SchemeId: ddlFCTScheme.GetSelectedItem().value
            },
            function (response) {
                switch (response.Status) {
                    case RC.Common.ResponseStatus.SUCCESS:
                        ddlFCTCOA.ClearItems();

                        if (response.Data != null && response.Data != undefined && response.Data.length > 0) {
                            $(response.Data).each(function (index, item) {
                                ddlFCTCOA.AddItem(new Array(item.ACCOUNT_CODE, item.ACCOUNT_NAME), item.ACCOUNT_HEAD_ID.toString());
                            });

                            ddlFCTCOA.SetSelectedIndex(0);
                        }

                        RC.ManageSchemeReappropriation.ShowForeignFundingForFromScheme();

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

        function SetTCOA() {
            $.post(RC.Common.RootURL + "Handler/COAHandler.ashx",
            {
                method: "COAGetSchemeId",
                SchemeId: ddlTCTScheme.GetSelectedItem().value
            },
            function (response) {
                switch (response.Status) {
                    case RC.Common.ResponseStatus.SUCCESS:
                        ddlTCTCOA.ClearItems();

                        if (response.Data != null && response.Data != undefined && response.Data.length > 0) {
                            $(response.Data).each(function (index, item) {
                                ddlTCTCOA.AddItem(new Array(item.ACCOUNT_CODE, item.ACCOUNT_NAME), item.ACCOUNT_HEAD_ID.toString());
                            });

                            ddlTCTCOA.SetSelectedIndex(0);
                        }

                        RC.ManageSchemeReappropriation.ShowForeignFundingForToScheme();

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

        function SetTransactionAmount() {
            if ($('#dvManageSchemeReappropriation #chkGroupTransaction').prop('checked')) {
                $("#dvManageSchemeReappropriation #dvTransactionAmount").show();
                $("#dvManageSchemeReappropriation #dvToSchemeAmount").show();
            }
            else {
                $("#dvManageSchemeReappropriation #dvTransactionAmount").hide();
                $("#dvManageSchemeReappropriation #dvToSchemeAmount").hide();
            }
        }

        function ResetTransactionAmount() {
            $('#dvManageSchemeReappropriation #dvTransactionAmount .desc').html('Rs 0.00');
        }
    </script>
</asp:Content>
