<%@ Page Title="Export Schemes" Language="C#" MasterPageFile="~/Forms/PageMaster.master" AutoEventWireup="true" CodeFile="frmExportSchemes.aspx.cs" Inherits="Forms_frmExportSchemes" %>

<%@ Register Assembly="DevExpress.Web.v16.1, Version=16.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphHeadPage" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphPage" runat="Server">
    <div class="row">
        <div class="col-md-5">
            <label id="lblFinancialYear"><span class="fa fa-caret-right rgt_cart"></span>Financial Year</label>
            <dx:ASPxComboBox ID="ddlFY" runat="server" ClientInstanceName="ddlFY" CssClass="form-control" TextFormatString="{1}">
                <Columns>
                    <dx:ListBoxColumn FieldName="Id" Caption="Code" Width="10px" />
                    <dx:ListBoxColumn FieldName="YearName" Caption="Name" Width="40px" />
                </Columns>
            </dx:ASPxComboBox>
        </div>
        <div class="col-md-3">
            <label><span class="fa fa-caret-right rgt_cart"></span>Status</label>
            <dx:ASPxComboBox ID="ddlSchemeStatus" runat="server" CssClass="form-control" ClientInstanceName="ddlSchemeStatus">
                <Items>
                    <dx:ListEditItem Text="All" Value="0" Selected="true" />
                    <dx:ListEditItem Text="Parent" Value="1" />
                    <dx:ListEditItem Text="Child" Value="2" />
                </Items>
            </dx:ASPxComboBox>
        </div>
        <div class="col-md-4">&nbsp;</div>
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
            window.location = RC.Common.RootURL + "Forms/frmReportViewer.aspx?" +
                "report=11" +
                "&FYId=" + ddlFY.GetSelectedItem().value +
                "&SchemeStatusId=" + ddlSchemeStatus.GetSelectedItem().value;

            return false;
        }
    </script>
</asp:Content>

