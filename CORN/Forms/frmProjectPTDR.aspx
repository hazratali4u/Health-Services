<%@ Page Title="" Language="C#" MasterPageFile="~/Forms/PageMaster.master" AutoEventWireup="true" CodeFile="frmProjectPTDR.aspx.cs" Inherits="Forms_frmProjectPTDR" %>

<%@ Register Assembly="DevExpress.Web.v16.1, Version=16.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphHeadPage" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphPage" runat="Server">
    <script language="JavaScript" type="text/javascript">

        function calendarShown(sender, args) {
            sender._popupBehavior._element.style.zIndex = 10005;
        }

    </script>
    <div class="row">
        <div class="col-md-8">
            <label><span class="fa fa-caret-right rgt_cart"></span>Scheme Name</label>
            <dx:ASPxComboBox ID="ddlScheme" runat="server" ClientInstanceName="ddlScheme" CssClass="form-control" TextFormatString="{0}">
                <Columns>
                    <dx:ListBoxColumn FieldName="strSchemeName" Caption="Scheme Name" Width="40px" />
                    <dx:ListBoxColumn FieldName="DISTRIBUTOR_NAME" Caption="Spending Unit" Width="20px" />
                    <dx:ListBoxColumn FieldName="ACCOUNT_NAME" Caption="Func. Class" Width="20px" />
                </Columns>
            </dx:ASPxComboBox>
        </div>
        <div class="col-md-4">
            <label id="lblInstitue"><span class="fa fa-caret-right rgt_cart"></span>Fund Type</label>
            <dx:ASPxComboBox ID="ddlFundType" runat="server" ClientInstanceName="ddlFundType" CssClass="form-control">
                <Items>
                    <dx:ListEditItem Selected="true" Value="1" Text="Capital" />
                    <dx:ListEditItem Value="2" Text="Revenue" />
                    <dx:ListEditItem Value="3" Text="Foreign Funding" />
                    <dx:ListEditItem Value="4" Text="Capital + Revenue" />
                </Items>
            </dx:ASPxComboBox>
        </div>
    </div>
    <div class="row">
        <div class="col-md-2">
            <label><span class="fa fa-caret-right rgt_cart"></span>Start Date</label>
            <asp:TextBox ID="txtStartDate" runat="server" ClientIDMode="Static" CssClass="form-control" onkeyup="BlockStartDateKeyPress()"></asp:TextBox>
        </div>
        <div class="col-md-1" style="margin-top: 22px">
            <asp:ImageButton ID="imgStartDate" runat="server" Width="30px" ImageUrl="~/App_Themes/Granite/Images/date.gif" />
            <cc1:CalendarExtender ID="ceStartDate" runat="server" Format="dd-MMM-yyyy" PopupButtonID="imgStartDate"
                TargetControlID="txtStartDate" OnClientShown="calendarShown"></cc1:CalendarExtender>
        </div>
        <div class="col-md-2">
            <label><span class="fa fa-caret-right rgt_cart"></span>End Date</label>
            <asp:TextBox ID="txtEndDate" runat="server" ClientIDMode="Static" CssClass="form-control" onkeyup="BlockStartDateKeyPress()"></asp:TextBox>
        </div>
        <div class="col-md-1" style="margin-top: 22px">
            <asp:ImageButton ID="imgEndDate" runat="server" Width="30px" ImageUrl="~/App_Themes/Granite/Images/date.gif" />
            <cc1:CalendarExtender ID="ceEndDate" runat="server" Format="dd-MMM-yyyy" PopupButtonID="imgEndDate"
                TargetControlID="txtEndDate" OnClientShown="calendarShown"></cc1:CalendarExtender>
        </div>
        <div class="col-md-6">&nbsp;</div>
    </div>
    <div class="row" style="height: 155px;">
    </div>
    <div class="row">
        <div class="col-md-3">
            <input type="button" class="btn btn-success" value="Generate Report" onclick="GenerateReport()" />
        </div>
        <div class="col-md-9">&nbsp;</div>
    </div>
    <script type="text/javascript">
        function GenerateReport() {
            window.location = RC.Common.RootURL + "Forms/frmReportViewer.aspx?report=22&SchemeId=" + ddlScheme.GetSelectedItem().value +
                "&FundTypeId=" + ddlFundType.GetSelectedItem().value +
                "&FromDateTime=" + $.trim($("#txtStartDate").val()) +
                "&ToDateTime=" + $.trim($("#txtEndDate").val());

            return false;
        }
    </script>
</asp:Content>

