<%@ Page Language="C#" MasterPageFile="~/Forms/PageMaster.master" AutoEventWireup="true"
    CodeFile="frmManageFinancialYear.aspx.cs" Inherits="Forms_frmManageFinancialYear" Title="MPR :: Define Financial Year" %>

<%@ Register Assembly="DevExpress.Web.v16.1, Version=16.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="cphPage">
    <script language="JavaScript" type="text/javascript">

        function calendarShown(sender, args) {
            sender._popupBehavior._element.style.zIndex = 10005;
        }

    </script>
    <div id="dvFinancialYearListing" class="main-contents">
        <div class="container employee-infomation">
            <div class="row top">
                <div class="col-md-12">
                    <div class="btnlist pull-right">
                        <asp:LinkButton CssClass="btn btn-warning" runat="server" ID="btnAdd" ClientIDMode="Static" OnClientClick="RC.FinancialYearListing.ResetFinancialYear(); return false;">
                               <span class="fa fa-plus-circle"></span>Add
                        </asp:LinkButton>
                    </div>
                </div>
                <div class="col-md-12" style="clear: both;">
                    <table id="tblFinancialYearList" class="table table-striped table-bordered" style="width: 100%;">
                        <thead>
                            <tr>
                                <th style="width: 25%; text-align: center;">Year Name</th>
                                <th style="width: 25%; text-align: center;">Start Date</th>
                                <th style="width: 25%; text-align: center;">End Date</th>
                                <th style="width: 15%; text-align: center; display: none;">Is Open</th>
                                <th style="width: 15%; text-align: center;">Is Close</th>
                                <th style="width: 10%; text-align: center;">Action</th>
                            </tr>
                        </thead>
                    </table>
                </div>
            </div>
        </div>
    </div>
    <script src="<%= Page.ResolveClientUrl("~/Script/RC.FinancialYearListing.js") %>" type="text/javascript"></script>
    <cc1:ModalPopupExtender ID="mPopUpLocation" runat="server" PopupControlID="dvFinancialYearDetail" TargetControlID="btnAdd" BehaviorID="ModelPopup" BackgroundCssClass="modal-background" CancelControlID="btnClose">
    </cc1:ModalPopupExtender>
    <asp:Panel ID="dvFinancialYearDetail" runat="server" ClientIDMode="Static" Style="display: none;">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" id="btnClose" runat="server" class="close" clientidmode="Static">
                        <span>&times;</span><span class="sr-only">Close</span></button>
                    <h1 class="modal-title" id="myModalLabel">
                        <span class="fa fa-clock-o"></span><span id="spnHeading">Manage</span> Financial Year</h1>
                </div>
                <div class="modal-body">
                    <div class="row">
                        <div class="col-md-10">
                            <asp:Label ID="lblErrorMsg" runat="server" ClientIDMode="Static" ForeColor="Red" Font-Bold="True"></asp:Label>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-6">
                            <label>
                                <span class="fa fa-caret-right"></span>Short Name</label>
                            <asp:TextBox ID="txtShortName" runat="server" ClientIDMode="Static" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="col-md-6">
                            <label>
                                <span class="fa fa-caret-right"></span>Year Name</label>
                            <asp:TextBox ID="txtYearName" runat="server" ClientIDMode="Static" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-6">
                            <label>
                                <span class="fa fa-caret-right"></span>Display Name</label>
                            <asp:TextBox ID="txtDisplayName" runat="server" ClientIDMode="Static" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="col-md-6">
                            <label>
                                <span class="fa fa-caret-right"></span>Description</label>
                            <asp:TextBox ID="txtDescription" runat="server" ClientIDMode="Static" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-5">
                            <label>
                                <span class="fa fa-caret-right"></span>Start Date</label>
                            <asp:TextBox ID="txtStartDate" runat="server" ClientIDMode="Static" CssClass="form-control" onkeyup="BlockStartDateKeyPress()"></asp:TextBox>
                        </div>
                        <div class="col-md-1" style="margin-top: 22px">
                            <asp:ImageButton ID="imgStartDate" runat="server" Width="30px" ImageUrl="~/App_Themes/Granite/Images/date.gif" />
                            <cc1:CalendarExtender ID="ceStartDate" runat="server" Format="dd-MMM-yyyy" PopupButtonID="imgStartDate"
                                TargetControlID="txtStartDate" OnClientShown="calendarShown"></cc1:CalendarExtender>
                        </div>
                        <div class="col-md-5">
                            <label>
                                <span class="fa fa-caret-right"></span>End Date</label>
                            <asp:TextBox ID="txtEndDate" runat="server" ClientIDMode="Static" CssClass="form-control" onkeyup="BlockStartDateKeyPress()"></asp:TextBox>
                        </div>
                        <div class="col-md-1" style="margin-top: 22px">
                            <asp:ImageButton ID="imgEndDate" runat="server" Width="30px" ImageUrl="~/App_Themes/Granite/Images/date.gif" />
                            <cc1:CalendarExtender ID="ceEndDate" runat="server" Format="dd-MMM-yyyy" PopupButtonID="imgEndDate"
                                TargetControlID="txtEndDate" OnClientShown="calendarShown"></cc1:CalendarExtender>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-6" style="display: none;">
                            <label>
                                <span class="fa fa-caret-right"></span>Is Open</label>
                            <asp:CheckBox ID="chkOpen" runat="server" ClientIDMode="Static" CssClass="form-control"></asp:CheckBox>
                        </div>
                        <div class="col-md-6">
                            <label>
                                <span class="fa fa-caret-right"></span>Is Closed</label>
                            <asp:CheckBox ID="chkClosed" runat="server" ClientIDMode="Static" CssClass="form-control"></asp:CheckBox>
                        </div>
                        <div class="col-md-6">&nbsp;</div>
                    </div>
                </div>
                <div class="modal-footer">
                    <button type="button" id="btnSave" class="btn btn-success" onclick="RC.FinancialYearListing.SaveFinancialYear();">Save</button>
                </div>
            </div>
        </div>
    </asp:Panel>
</asp:Content>
