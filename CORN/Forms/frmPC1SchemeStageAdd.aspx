<%@ Page Title="" Language="C#" MasterPageFile="~/Forms/PageMaster.master" AutoEventWireup="true" CodeFile="frmPC1SchemeStageAdd.aspx.cs" Inherits="Forms_frmPC1SchemeStageAdd" %>

<%@ Register Assembly="DevExpress.Web.v16.1, Version=16.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphHeadPage" runat="Server">
    <script language="JavaScript" type="text/javascript">
        function calendarShown(sender, args) {
            sender._popupBehavior._element.style.zIndex = 10005;
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphPage" runat="Server">
    <div id="dvManageSchemeStage">
        <div class="row">
            <div class="col-md-6">
                <label><span class="fa fa-caret-right rgt_cart"></span>Scheme Name</label>&nbsp;*
                <dx:ASPxComboBox ID="ddlScheme" runat="server" ClientInstanceName="ddlCTScheme" CssClass="form-control" TextFormatString="{0}">
                    <Columns>
                        <dx:ListBoxColumn FieldName="strSchemeName" Caption="Scheme Name" Width="100px" />
                    </Columns>
                </dx:ASPxComboBox>
            </div>
            <div class="col-md-2">
                <label><span class="fa fa-caret-right rgt_cart"></span>Scheme Stage Date</label>&nbsp;*
                <asp:TextBox ID="txtStageDate" runat="server" ClientIDMode="Static" CssClass="form-control" MaxLength="10" onkeyup="BlockStartDateKeyPress()"></asp:TextBox>
            </div>
            <div class="col-md-1" style="margin-top: 22px">
                <asp:ImageButton ID="ibtnStageDate" runat="server" Width="30px" ImageUrl="~/App_Themes/Granite/Images/date.gif" />
                <cc1:CalendarExtender ID="CEtProposedDate" runat="server" Format="dd-MMM-yyyy" PopupButtonID="ibtnStageDate"
                    TargetControlID="txtStageDate" OnClientShown="calendarShown"></cc1:CalendarExtender>
            </div>
            <div class="col-md-3">
            </div>
        </div>
        <div class="row">
            <div class="col-md-3">
                <label><span class="fa fa-caret-right rgt_cart"></span>Scheme Stage Status</label>&nbsp;*
                <dx:ASPxComboBox ID="ddlStageStatus" runat="server" ClientInstanceName="ddlCTStageStatus" CssClass="form-control" ClientIDMode="Static" TextFormatString="{0}">
                    <Columns>
                        <dx:ListBoxColumn FieldName="Title" Caption="Title" Width="100px" />
                    </Columns>
                </dx:ASPxComboBox>
            </div>
            <div class="col-md-3">
                <label><span class="fa fa-caret-right rgt_cart"></span>Reference Number</label>
                <asp:TextBox ID="txtReferenceNo" runat="server" ClientIDMode="Static" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-md-6"></div>
        </div>
        <div class="row">
            <div class="col-md-8">
                <label><span class="fa fa-caret-right rgt_cart"></span>Remarks</label>
                <textarea id="txtRemarks"></textarea>
            </div>
            <div class="col-md-4"></div>
        </div>
        <div class="row" style="height: 20px;">
        </div>
        <asp:Button ID="btnSave" runat="server" ClientIDMode="Static" CssClass="btn btn-success" OnClientClick="RC.ManageSchemeStage.SaveSchemeStage(); return false;" Text="Save" />
        <asp:Button ID="btnCancel" runat="server" ClientIDMode="Static" CssClass="btn btn-danger" OnClientClick="window.location = 'frmPC1SchemeStages.aspx?LevelType=3&LevelID=283'; return false;" Text="Cancel" />
    </div>
    <script src="<%= Page.ResolveClientUrl("~/Script/RC.ManagePC1SchemeStage.js") %>" type="text/javascript"></script>
</asp:Content>

