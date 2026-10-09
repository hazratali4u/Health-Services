<%@ Page Language="C#" MasterPageFile="~/Forms/PageMaster.master" AutoEventWireup="true"
    CodeFile="frmSchemeCreation.aspx.cs" Inherits="Forms_frmSchemeCreation" Title="MPR :: Scheme / Project Creation" %>

<%@ Register Assembly="DevExpress.Web.v16.1, Version=16.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="cphPage">
    <style type="text/css">
        .cls .dxeEditAreaSys {
            -webkit-user-select: none !important;
            -moz-user-select: none !important;
            -ms-user-select: none !important;
            user-select: none !important;
        }

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
    <script language="JavaScript" type="text/javascript">

        function calcDate() {
            var date1 = document.getElementById("ctl00_ctl00_mainCopy_cphPage_txtStartDate").value;
            var date2 = document.getElementById("ctl00_ctl00_mainCopy_cphPage_txtEndDate").value;
            var startdt = date1.split('-');
            var enddt = date2.split('-');
            var selValue = comboGSYear.GetValue();
            var selIndex = 0;
            var index = 0;
            var gsYearValue = parseInt(startdt[2]);
            var geYearValue = parseInt(enddt[2]);
            var gsMonthTitle = startdt[1].toString();
            var gsMonthValue = 0;
            var geMonthTitle = enddt[1].toString();
            var geMonthValue = 0;

            if (gsMonthTitle == 'Jan') gsMonthValue = 1
            else if (gsMonthTitle == 'Feb') gsMonthValue = 2
            else if (gsMonthTitle == 'Mar') gsMonthValue = 3
            else if (gsMonthTitle == 'Apr') gsMonthValue = 4
            else if (gsMonthTitle == 'May') gsMonthValue = 5
            else if (gsMonthTitle == 'Jun') gsMonthValue = 6
            else if (gsMonthTitle == 'Jul') gsMonthValue = 7
            else if (gsMonthTitle == 'Aug') gsMonthValue = 8
            else if (gsMonthTitle == 'Sep') gsMonthValue = 9
            else if (gsMonthTitle == 'Oct') gsMonthValue = 10
            else if (gsMonthTitle == 'Nov') gsMonthValue = 11
            else if (gsMonthTitle == 'Dec') gsMonthValue = 12

            if (geMonthTitle == 'Jan') geMonthValue = 1
            else if (geMonthTitle == 'Feb') geMonthValue = 2
            else if (geMonthTitle == 'Mar') geMonthValue = 3
            else if (geMonthTitle == 'Apr') geMonthValue = 4
            else if (geMonthTitle == 'May') geMonthValue = 5
            else if (geMonthTitle == 'Jun') geMonthValue = 6
            else if (geMonthTitle == 'Jul') geMonthValue = 7
            else if (geMonthTitle == 'Aug') geMonthValue = 8
            else if (geMonthTitle == 'Sep') geMonthValue = 9
            else if (geMonthTitle == 'Oct') geMonthValue = 10
            else if (geMonthTitle == 'Nov') geMonthValue = 11
            else if (geMonthTitle == 'Dec') geMonthValue = 12

            comboGSYear.ClearItems();

            while (gsYearValue <= geYearValue) {
                if ((gsMonthValue <= 6 && gsYearValue <= geYearValue) ||
                    (geYearValue == gsYearValue) ||
                    (gsYearValue > parseInt(startdt[2]) && gsYearValue < geYearValue)) {
                    var gsYearTitle = (gsYearValue - 1).toString();

                    gsYearTitle += "-" + gsYearValue.toString();

                    if (gsYearValue == selValue) {
                        selIndex = index;
                    }
                    else {
                        index++;
                    }

                    comboGSYear.AddItem(gsYearTitle, gsYearValue);
                }

                gsYearValue++;
            }

            comboGSYear.SetSelectedIndex(selIndex);
        }


        function pageLoad() {
            calcDate();
        }
        Sys.WebForms.PageRequestManager.getInstance().add_beginRequest(BeginRequestHandler);
        Sys.WebForms.PageRequestManager.getInstance().add_endRequest(EndRequestHandler);
        function BeginRequestHandler(sender, args) {
            var oControl = args.get_postBackElement();
            oControl.value = "Wait...";
            oControl.disabled = true;
        }
        function EndRequestHandler(sender, args) {
            InitializeAmountInputs();
        }
        function calendarShown(sender, args) {
            sender._popupBehavior._element.style.zIndex = 10005;
        }
        function ValidateForm() {
            var str;
            str = document.getElementById('<%=txtSchemeName.ClientID%>').value;

            if (str == null || str.length == 0) {
                alert('Scheme Name required.');
                return false;
            }
            if (getParameterByName('mode') == 'ADP') {
                var nextFYYearValue = parseInt(document.getElementById('<%=hfNextFYYear.ClientID%>').value);
                var date1 = document.getElementById("ctl00_ctl00_mainCopy_cphPage_txtStartDate").value;
                var date2 = document.getElementById("ctl00_ctl00_mainCopy_cphPage_txtEndDate").value;
                var startdt = date1.split('-');
                var enddt = date2.split('-');
                var gsYearValue = parseInt(startdt[2]);
                var geYearValue = parseInt(enddt[2]);
                var gsMonthTitle = startdt[1].toString();
                var gsMonthValue = 0;
                var geMonthTitle = enddt[1].toString();
                var geMonthValue = 0;

                if (gsMonthTitle == 'Jan') gsMonthValue = 1
                else if (gsMonthTitle == 'Feb') gsMonthValue = 2
                else if (gsMonthTitle == 'Mar') gsMonthValue = 3
                else if (gsMonthTitle == 'Apr') gsMonthValue = 4
                else if (gsMonthTitle == 'May') gsMonthValue = 5
                else if (gsMonthTitle == 'Jun') gsMonthValue = 6
                else if (gsMonthTitle == 'Jul') gsMonthValue = 7
                else if (gsMonthTitle == 'Aug') gsMonthValue = 8
                else if (gsMonthTitle == 'Sep') gsMonthValue = 9
                else if (gsMonthTitle == 'Oct') gsMonthValue = 10
                else if (gsMonthTitle == 'Nov') gsMonthValue = 11
                else if (gsMonthTitle == 'Dec') gsMonthValue = 12

                if (geMonthTitle == 'Jan') geMonthValue = 1
                else if (geMonthTitle == 'Feb') geMonthValue = 2
                else if (geMonthTitle == 'Mar') geMonthValue = 3
                else if (geMonthTitle == 'Apr') geMonthValue = 4
                else if (geMonthTitle == 'May') geMonthValue = 5
                else if (geMonthTitle == 'Jun') geMonthValue = 6
                else if (geMonthTitle == 'Jul') geMonthValue = 7
                else if (geMonthTitle == 'Aug') geMonthValue = 8
                else if (geMonthTitle == 'Sep') geMonthValue = 9
                else if (geMonthTitle == 'Oct') geMonthValue = 10
                else if (geMonthTitle == 'Nov') geMonthValue = 11
                else if (geMonthTitle == 'Dec') geMonthValue = 12

                if (gsYearValue < nextFYYearValue ||
                    (gsYearValue == nextFYYearValue && gsMonthValue <= 6)) {
                    alert('Start Date should be greater than Jun ' + nextFYYearValue + '.');
                    return false;
                }

                if (geYearValue < nextFYYearValue ||
                    (geYearValue == nextFYYearValue && geMonthValue <= 6)) {
                    alert('End Date should be greater than Jun ' + nextFYYearValue + '.');
                    return false;
                }
            }
            return true;
        }

        function Check_Click(objRef) {
            var row = objRef.parentNode.parentNode;
            var GridView = row.parentNode;
            var inputList = GridView.getElementsByTagName("input");
            for (var i = 0; i < inputList.length; i++) {
                var headerCheckBox = inputList[0];
                var checked = true;
                if (inputList[i].type == "checkbox" && inputList[i] != headerCheckBox) {
                    if (!inputList[i].checked) {
                        checked = false;
                        break;
                    }
                }
            }

            headerCheckBox.checked = checked;
        }

        function checkAll(objRef) {
            var GridView = objRef.parentNode.parentNode.parentNode;
            var inputList = GridView.getElementsByTagName("input");
            for (var i = 0; i < inputList.length; i++) {
                var row = inputList[i].parentNode.parentNode;
                if (inputList[i].type == "checkbox" && objRef != inputList[i]) {
                    if (objRef.checked) {
                        inputList[i].checked = true;
                    }
                    else {
                        inputList[i].checked = false;
                    }
                }
            }
        }

        function getParameterByName(name, url) {
            if (!url) url = window.location.href;
            name = name.replace(/[\[\]]/g, "\\$&");
            var regex = new RegExp("[?&]" + name + "(=([^&#]*)|&|#|$)"),
                results = regex.exec(url);
            if (!results) return null;
            if (!results[2]) return '';
            return decodeURIComponent(results[2].replace(/\+/g, " "));
        }
    </script>
    <asp:HiddenField ID="hfNextFYYear" runat="server" />
    <div class="main-contents">
        <div class="container employee-infomation">
            <div class="row top">
                <asp:Panel ID="Panel3" runat="server" DefaultButton="btnsearch">
                    <div class="col-md-4">
                        <div class="search">
                            <asp:TextBox ID="txtSearch" runat="server" placeholder="Search" CssClass="form-control"
                                TabIndex="0"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-md-2" style="margin-left: -60px;">
                        <asp:LinkButton ID="btnsearch" OnClick="btnFilter_Click" runat="server" Text="Search"
                            CssClass="btn btn-success"><i class="fa fa-search"  style="font-size:20px;"></i></asp:LinkButton>
                    </div>
                    <asp:LinkButton ID="btndummy" runat="server" UseSubmitBehavior="false" />
                </asp:Panel>
                <div class="col-md-offset-5 col-md-3 ">
                    <div class="btnlist pull-right" style="width: 600px; text-align: right;">
                        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                            <ContentTemplate>
                                <asp:LinkButton runat="server" ID="hbutton"></asp:LinkButton>
                                <asp:DropDownList ID="ddlSchemeCategory" runat="server" CssClass="formcontrolstyle">
                                    <Items>
                                        <asp:ListItem Value="1" Text="New" Selected="true" />
                                        <asp:ListItem Value="2" Text="On-going" />
                                        <asp:ListItem Value="3" Text="Supplementary" />
                                        <asp:ListItem Value="4" Text="Unfunded" />
                                    </Items>
                                </asp:DropDownList>
                                <asp:LinkButton CssClass="btn btn-success" runat="server" ID="btnStatus" Text="Status"
                                    OnClientClick="javascript:return confirm('Are you sure you want to perform this action?');return false;"
                                    OnClick="btnStatus_Click">
                               <span class="fa fa-check"></span>Status
                                </asp:LinkButton>
                                <asp:LinkButton CssClass="btn btn-success" runat="server" ID="btnPromoteSchemes" Text="Promote Schemes"
                                    OnClick="btnPromoteSchemes_Click">
                               <span class="fa fa-check"></span>Promote Schemes
                                </asp:LinkButton>
                                <asp:LinkButton CssClass="btn btn-success" runat="server" ID="btnExport" Text="Export"
                                    OnClientClick="window.location = 'frmReportViewer.aspx?report=11'; return false;">
                               <span class="fa fa-check"></span>Export
                                </asp:LinkButton>
                                <asp:LinkButton CssClass="btn btn-warning" runat="server" ID="btnAdd" Text="Add"
                                    OnClick="btnAdd_Click">
                               <span class="fa fa-plus-circle"></span>Add
                                </asp:LinkButton>
                                <asp:LinkButton class="btn btn-success" OnClick="btnActive_Click" ID="btnActive" runat="server"
                                    OnClientClick="javascript:return confirm('Are you sure you want to perform this action?');return false;">
                                    <span class="fa fa-check"></span>Active</asp:LinkButton>
                                <!-- POP UP MODEL-->
                                <cc1:ModalPopupExtender ID="mPopUpLocation" runat="server" PopupControlID="pnlParameters"
                                    TargetControlID="hbutton" BehaviorID="ModelPopup" BackgroundCssClass="modal-background"
                                    CancelControlID="btnClose">
                                </cc1:ModalPopupExtender>
                                <asp:Panel ID="pnlParameters" runat="server" Style="display: none; width: 100%;" ScrollBars="Auto">
                                    <div class="modal-dialog" style="width: 90%; margin: auto; text-align: left;">
                                        <div class="modal-content">
                                            <div class="modal-header">
                                                <button type="button" id="btnClose" runat="server" class="close">
                                                    <span>&times;</span><span class="sr-only">Close</span></button>
                                                <h1 class="modal-title" id="myModalLabel">
                                                    <span class="fa fa-clock-o"></span>Add New Scheme</h1>
                                            </div>
                                            <div class="modal-body">
                                                <div class="row">
                                                    <div class="col-md-12">
                                                        <asp:Label ID="lblErrorMsg" runat="server" ForeColor="Red" Font-Bold="True"></asp:Label>
                                                    </div>
                                                </div>
                                                <div class="row">
                                                    <div class="col-md-6">
                                                        <label id="lblSchemeName"><span class="fa fa-caret-right rgt_cart"></span>Scheme Name</label>&nbsp;*
                                                        <asp:TextBox ID="txtSchemeName" runat="server" CssClass="form-control"></asp:TextBox>
                                                    </div>
                                                    <div class="col-md-3">
                                                        <label id="lblClassification"><span class="fa fa-caret-right rgt_cart"></span>Functional Classification</label>&nbsp;*&nbsp;&nbsp;<label style="color: firebrick; font-weight: bold;">Capital</label>
                                                        <dx:ASPxComboBox ID="ddlCOA" runat="server" CssClass="form-control" TextFormatString="{1}">
                                                            <Columns>
                                                                <dx:ListBoxColumn FieldName="ACCOUNT_CODE" Caption="Code" Width="20px" />
                                                                <dx:ListBoxColumn FieldName="ACCOUNT_NAME" Caption="Name" Width="40px" />
                                                            </Columns>
                                                        </dx:ASPxComboBox>
                                                    </div>
                                                    <div class="col-md-3">
                                                        <label id="lblSAPCapital"><span class="fa fa-caret-right rgt_cart"></span>SAP Capital Code & Cost</label>
                                                        <table width="100%">
                                                            <tr>
                                                                <td style="width: 48%">
                                                                    <asp:TextBox ID="txtCapitalCode" runat="server" CssClass="form-control" placeholder="Code"></asp:TextBox>
                                                                </td>
                                                                <td style="width: 4%">&nbsp;</td>
                                                                <td style="width: 48%">
                                                                    <asp:TextBox ID="txtCapitalAmount" runat="server" CssClass="form-control" placeholder="Amount"></asp:TextBox>
                                                                </td>
                                                            </tr>
                                                        </table>

                                                    </div>
                                                </div>
                                                <div class="row">
                                                    <div class="col-md-6">
                                                        <label id="lblInstitue"><span class="fa fa-caret-right rgt_cart"></span>Spending Unit</label>&nbsp;*
                                                        <dx:ASPxComboBox ID="ddlInstitute" runat="server" CssClass="form-control"
                                                            AutoPostBack="true" OnSelectedIndexChanged="ddlInstitute_SelectedIndexChanged" TextFormatString="{0}">
                                                            <Columns>
                                                                <dx:ListBoxColumn FieldName="DISTRIBUTOR_NAME" Caption="Name" Width="80px" />
                                                                <dx:ListBoxColumn FieldName="District" Caption="District" Width="20px" />
                                                            </Columns>
                                                        </dx:ASPxComboBox>
                                                    </div>
                                                    <div class="col-md-3">
                                                        <label><span class="fa fa-caret-right rgt_cart"></span>Functional Classification</label>&nbsp;*&nbsp;&nbsp;<label style="color: firebrick; font-weight: bold;">Revenue</label>
                                                        <dx:ASPxComboBox ID="ddlRCOA" runat="server" CssClass="form-control" TextFormatString="{1}">
                                                            <Columns>
                                                                <dx:ListBoxColumn FieldName="ACCOUNT_CODE" Caption="Code" Width="20px" />
                                                                <dx:ListBoxColumn FieldName="ACCOUNT_NAME" Caption="Name" Width="40px" />
                                                            </Columns>
                                                        </dx:ASPxComboBox>
                                                    </div>
                                                    <div class="col-md-3">
                                                        <label id="lblSAPRevenue"><span class="fa fa-caret-right rgt_cart"></span>SAP Revenue Code & Cost</label>
                                                        <table width="100%">
                                                            <tr>
                                                                <td style="width: 48%">
                                                                    <asp:TextBox ID="txtRevenueCode" runat="server" CssClass="form-control" placeholder="Code"></asp:TextBox>
                                                                </td>
                                                                <td style="width: 4%">&nbsp;</td>
                                                                <td style="width: 48%">
                                                                    <asp:TextBox ID="txtRevenueAmount" runat="server" CssClass="form-control" placeholder="Amount"></asp:TextBox>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </div>
                                                </div>
                                                <div class="row">
                                                    <div class="col-md-2">
                                                        <label id="lblDistrict"><span class="fa fa-caret-right rgt_cart"></span>Sub Sector</label>&nbsp;*
                                                        <dx:ASPxComboBox ID="ddlSubSector" runat="server" CssClass="form-control" TextFormatString="{1}">
                                                            <Columns>
                                                                <dx:ListBoxColumn FieldName="strCode" Caption="Code" Width="20px" />
                                                                <dx:ListBoxColumn FieldName="strName" Caption="Name" Width="40px" />
                                                            </Columns>
                                                        </dx:ASPxComboBox>
                                                    </div>
                                                    <div class="col-md-2">
                                                        <label id="lblTehsil">
                                                            <span class="fa fa-caret-right rgt_cart"></span>District-Tehsil</label>
                                                        <table width="100%">
                                                            <tr>
                                                                <td style="width: 48%">
                                                                    <asp:TextBox ID="txtDistrict" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
                                                                </td>
                                                                <td style="width: 4%">&nbsp;</td>
                                                                <td style="width: 48%">
                                                                    <asp:TextBox ID="txtTehsil" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </div>
                                                    <div class="col-md-2">
                                                        <label id="lblSchemeDate"><span class="fa fa-caret-right rgt_cart"></span>Scheme Date</label>&nbsp;*
                                                        <table width="100%">
                                                            <tr>
                                                                <td style="width: 80%">
                                                                    <asp:TextBox ID="txtSchemeDate" runat="server" CssClass="form-control" MaxLength="10" onkeyup="BlockStartDateKeyPress()"></asp:TextBox>
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
                                                    <div class="col-md-3">
                                                        <label id="lblTypeOfBand"><span class="fa fa-caret-right rgt_cart"></span>Type Of Bank</label>&nbsp;*
                                                        <dx:ASPxComboBox ID="ddlTypeOfBank" runat="server"
                                                            CssClass="form-control">
                                                            <Items>
                                                                <dx:ListEditItem Text="Special Drawing Account" Value="1" Selected="true" />
                                                                <dx:ListEditItem Text="Personal Ledger Account" Value="2" />
                                                                <dx:ListEditItem Text="Commercial" Value="3" />
                                                            </Items>
                                                        </dx:ASPxComboBox>
                                                    </div>
                                                    <div class="col-md-3">
                                                        <label id="lblYearlyCost"><span class="fa fa-caret-right rgt_cart"></span>Yearly Recurring Cost</label>
                                                        <table width="100%">
                                                            <tr>
                                                                <td style="width: 48%">
                                                                    <asp:TextBox ID="txtRecurringCostPercent" runat="server" CssClass="form-control" placeholder="%"></asp:TextBox>
                                                                    <cc1:FilteredTextBoxExtender runat="server" ID="FilteredTextBoxExtender6"
                                                                        TargetControlID="txtRecurringCostPercent" ValidChars="0987654321."></cc1:FilteredTextBoxExtender>
                                                                </td>
                                                                <td style="width: 4%">&nbsp;</td>
                                                                <td style="width: 48%">
                                                                    <asp:TextBox ID="txtRecurringCostAmount" runat="server" CssClass="form-control" placeholder="Amount"></asp:TextBox>
                                                                </td>
                                                            </tr>
                                                        </table>

                                                    </div>
                                                </div>
                                                <div class="row">
                                                    <div class="col-md-2">
                                                        <label id="lblCategory"><span class="fa fa-caret-right rgt_cart"></span>Status</label>&nbsp;*
                                                        <dx:ASPxComboBox ID="ddlCategory" runat="server"
                                                            CssClass="form-control">
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
                                                                    <asp:TextBox ID="txtStartDate" runat="server" CssClass="form-control" onchange="calcDate();"></asp:TextBox>
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
                                                                    <asp:TextBox ID="txtEndDate" runat="server" CssClass="form-control" onchange="calcDate();"></asp:TextBox>
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
                                                    <div class="col-md-3">&nbsp;</div>
                                                    <div class="col-md-3" style="display: none;">
                                                        <label id="lblExpense"><span class="fa fa-caret-right rgt_cart"></span>Last Year Expenditure</label>
                                                        <asp:TextBox ID="txtLastYearExpense" runat="server" CssClass="form-control"></asp:TextBox>
                                                    </div>
                                                    <div class="col-md-3">
                                                        <label id="lblGSCode"><span class="fa fa-caret-right rgt_cart"></span>Year Wise GS Code</label>
                                                        <table width="100%">
                                                            <tr>
                                                                <td style="width: 48%">
                                                                    <dx:ASPxComboBox ID="ddlFinancialYear" runat="server"
                                                                        AutoPostBack="true" CssClass="form-control" ClientInstanceName="comboGSYear"
                                                                        OnSelectedIndexChanged="ddlFinancialYear_SelectedIndexChanged">
                                                                    </dx:ASPxComboBox>
                                                                </td>
                                                                <td style="width: 4%">&nbsp;</td>
                                                                <td style="width: 48%">
                                                                    <asp:TextBox ID="txtGSCode" runat="server" CssClass="form-control" placeholder="GS Code"></asp:TextBox>
                                                                </td>
                                                            </tr>
                                                        </table>

                                                    </div>
                                                </div>
                                                <div class="row">
                                                    <div class="col-md-12">
                                                        <label id="lblRemarks"><span class="fa fa-caret-right rgt_cart"></span>Remarks</label>
                                                        <asp:TextBox ID="txtRemarks" runat="server" CssClass="form-control" TextMode="MultiLine" Height="70"></asp:TextBox>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="modal-footer">
                                                <asp:Button ID="btnSave" runat="server" CssClass="btn btn-success" onblur="Change(this, event)"
                                                    OnClick="btnSave_Click" onfocus="Change(this, event)" Text="Save" />
                                                <asp:Button ID="btnCancel" runat="server" CssClass="btn btn-danger" onblur="Change(this, event)"
                                                    OnClick="btnCancel_Click" onfocus="Change(this, event)" Text="Cancel" />
                                                <a href="#" style="display: none; visibility: hidden;" onclick="return false" id="dummyLink1"
                                                    runat="server">dummy</a>
                                            </div>
                                        </div>
                                    </div>
                                </asp:Panel>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </div>
                </div>
            </div>
            <div class="row center">
                <div class="col-md-12">
                    <div class="emp-table">
                        <asp:UpdatePanel ID="UpdatePanelDetail" runat="server">
                            <ContentTemplate>
                                <asp:GridView ID="gvScheme" runat="server" CssClass="table table-striped table-bordered table-hover table-condensed cf"
                                    HorizontalAlign="Center" OnRowEditing="gvScheme_RowEditing" AutoGenerateColumns="False"
                                    EmptyDataText="No Record exist" OnPageIndexChanging="Grid_users_PageIndexChanging" PageSize="8"
                                    AllowPaging="True" OnRowDataBound="gvScheme_RowDataBound">
                                    <Columns>
                                        <asp:TemplateField>
                                            <HeaderTemplate>
                                                <asp:CheckBox ID="checkAll" runat="server" onclick="checkAll(this);" />
                                            </HeaderTemplate>
                                            <ItemTemplate>
                                                <asp:CheckBox ID="ChbIsAssigned" runat="server" onclick="Check_Click(this)" />
                                            </ItemTemplate>
                                            <HeaderStyle Width="5%" HorizontalAlign="Center" />
                                            <ItemStyle Width="5%" HorizontalAlign="Center" />
                                        </asp:TemplateField>
                                        <asp:BoundField DataField="lngSchemeCode" HeaderText="lngSchemeCode" ReadOnly="true">
                                            <HeaderStyle CssClass="HidePanel"></HeaderStyle>
                                            <ItemStyle CssClass="HidePanel"></ItemStyle>
                                        </asp:BoundField>
                                        <asp:BoundField DataField="strSchemeCode" HeaderText="Scheme Code" ReadOnly="true"></asp:BoundField>
                                        <asp:BoundField DataField="strSchemeName" HeaderText="Scheme Name" ReadOnly="true">
                                            <HeaderStyle HorizontalAlign="Left" CssClass="leftAlignedData" />
                                            <ItemStyle HorizontalAlign="Left" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="CategoryName" HeaderText="Status" ReadOnly="true">
                                            <ItemStyle Width="10%" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="dtmSchemeDate" HeaderText="Scheme Date" ReadOnly="true" DataFormatString="{0:dd-MMM-yyyy}"></asp:BoundField>
                                        <asp:BoundField DataField="IsActive" HeaderText="Record Status" ReadOnly="true">
                                            <ItemStyle Width="8%" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="intInstituteID" HeaderText="intInstituteID" ReadOnly="true">
                                            <HeaderStyle CssClass="HidePanel"></HeaderStyle>
                                            <ItemStyle CssClass="HidePanel"></ItemStyle>
                                        </asp:BoundField>
                                        <asp:BoundField DataField="intFCAccountHeadID" HeaderText="intFCAccountHeadID" ReadOnly="true">
                                            <HeaderStyle CssClass="HidePanel"></HeaderStyle>
                                            <ItemStyle CssClass="HidePanel"></ItemStyle>
                                        </asp:BoundField>
                                        <asp:BoundField DataField="intCategoryID" HeaderText="intCategoryID" ReadOnly="true">
                                            <HeaderStyle CssClass="HidePanel"></HeaderStyle>
                                            <ItemStyle CssClass="HidePanel"></ItemStyle>
                                        </asp:BoundField>
                                        <asp:BoundField DataField="decYearlyCostPer" HeaderText="decYearlyCostPer" ReadOnly="true">
                                            <HeaderStyle CssClass="HidePanel"></HeaderStyle>
                                            <ItemStyle CssClass="HidePanel"></ItemStyle>
                                        </asp:BoundField>
                                        <asp:BoundField DataField="decYearlyCostAmount" HeaderText="decYearlyCostAmount" ReadOnly="true">
                                            <HeaderStyle CssClass="HidePanel"></HeaderStyle>
                                            <ItemStyle CssClass="HidePanel"></ItemStyle>
                                        </asp:BoundField>
                                        <asp:BoundField DataField="dtmStartDate" HeaderText="dtmStartDate" ReadOnly="true">
                                            <HeaderStyle CssClass="HidePanel"></HeaderStyle>
                                            <ItemStyle CssClass="HidePanel"></ItemStyle>
                                        </asp:BoundField>
                                        <asp:BoundField DataField="dtmEndDate" HeaderText="dtmEndDate" ReadOnly="true">
                                            <HeaderStyle CssClass="HidePanel"></HeaderStyle>
                                            <ItemStyle CssClass="HidePanel"></ItemStyle>
                                        </asp:BoundField>
                                        <asp:BoundField DataField="intSubSectorID" HeaderText="intSubSectorID" ReadOnly="true">
                                            <HeaderStyle CssClass="HidePanel"></HeaderStyle>
                                            <ItemStyle CssClass="HidePanel"></ItemStyle>
                                        </asp:BoundField>
                                        <asp:BoundField DataField="intBankTypeID" HeaderText="intBankTypeID" ReadOnly="true">
                                            <HeaderStyle CssClass="HidePanel"></HeaderStyle>
                                            <ItemStyle CssClass="HidePanel"></ItemStyle>
                                        </asp:BoundField>
                                        <asp:BoundField DataField="strRemarks" HeaderText="strRemarks" ReadOnly="true">
                                            <HeaderStyle CssClass="HidePanel"></HeaderStyle>
                                            <ItemStyle CssClass="HidePanel"></ItemStyle>
                                        </asp:BoundField>
                                        <asp:BoundField DataField="strCapitalCode" HeaderText="strCapitalCode" ReadOnly="true">
                                            <HeaderStyle CssClass="HidePanel"></HeaderStyle>
                                            <ItemStyle CssClass="HidePanel"></ItemStyle>
                                        </asp:BoundField>
                                        <asp:BoundField DataField="decRevenueAmount" HeaderText="decRevenueAmount" ReadOnly="true">
                                            <HeaderStyle CssClass="HidePanel"></HeaderStyle>
                                            <ItemStyle CssClass="HidePanel"></ItemStyle>
                                        </asp:BoundField>
                                        <asp:BoundField DataField="decCapitalAmount" HeaderText="decCapitalAmount" ReadOnly="true">
                                            <HeaderStyle CssClass="HidePanel"></HeaderStyle>
                                            <ItemStyle CssClass="HidePanel"></ItemStyle>
                                        </asp:BoundField>
                                        <asp:BoundField DataField="strGSCode" HeaderText="strGSCode" ReadOnly="true">
                                            <HeaderStyle CssClass="HidePanel"></HeaderStyle>
                                            <ItemStyle CssClass="HidePanel"></ItemStyle>
                                        </asp:BoundField>
                                        <asp:BoundField DataField="dtmFinancialYear" HeaderText="dtmFinancialYear" ReadOnly="true">
                                            <HeaderStyle CssClass="HidePanel"></HeaderStyle>
                                            <ItemStyle CssClass="HidePanel"></ItemStyle>
                                        </asp:BoundField>
                                        <asp:BoundField DataField="decLastYearExpense" HeaderText="decLastYearExpense" ReadOnly="true">
                                            <HeaderStyle CssClass="HidePanel"></HeaderStyle>
                                            <ItemStyle CssClass="HidePanel"></ItemStyle>
                                        </asp:BoundField>
                                        <asp:BoundField DataField="intRFCAccountHeadID" HeaderText="intRFCAccountHeadID" ReadOnly="true">
                                            <HeaderStyle CssClass="HidePanel"></HeaderStyle>
                                            <ItemStyle CssClass="HidePanel"></ItemStyle>
                                        </asp:BoundField>
                                        <asp:TemplateField>
                                            <ItemTemplate>
                                                <asp:LinkButton ID="btnEdit" runat="server" CommandName="Edit" ToolTip="Edit" class="fa fa-pencil">
                                                </asp:LinkButton>
                                            </ItemTemplate>
                                            <ItemStyle HorizontalAlign="Center" Width="5%" />
                                        </asp:TemplateField>
                                    </Columns>
                                    <HeaderStyle CssClass="cf head"></HeaderStyle>
                                    <PagerSettings PageButtonCount="10" NextPageText=">" PreviousPageText="<" />
                                    <PagerStyle CssClass="GridPager" HorizontalAlign="Right" />
                                </asp:GridView>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <script type="text/javascript">
        $(document).ready(function () {
            InitializeAmountInputs();
        });

        function InitializeAmountInputs() {
            $('#<%= txtCapitalAmount.ClientID %>')
                .attr("data-a-sign", "Rs. ")
                .autoNumeric('init');

            $('#<%= txtRevenueAmount.ClientID %>')
                .attr("data-a-sign", "Rs. ")
                .autoNumeric('init');

            $('#<%= txtRecurringCostAmount.ClientID %>')
                .attr("data-a-sign", "Rs. ")
                .autoNumeric('init');

            $('#<%= txtLastYearExpense.ClientID %>')
                .attr("data-a-sign", "Rs. ")
                .autoNumeric('init');
        }
    </script>
</asp:Content>
