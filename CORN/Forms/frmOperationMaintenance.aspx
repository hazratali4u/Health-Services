<%@ Page Language="C#" MasterPageFile="~/Forms/PageMaster.master" AutoEventWireup="true"
    CodeFile="frmOperationMaintenance.aspx.cs" Inherits="Forms_OperationMaintenance" Title="MPR :: Define Operation Maintenance" %>

<%@ Register Assembly="DevExpress.Web.v16.1, Version=16.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="cphPage">
    <div id="dvOperationMaintenanceListing" class="main-contents">
        <div class="container employee-infomation">
            <div class="row top">
                <div class="col-md-12">
                    <div class="btnlist pull-right">
                        <asp:LinkButton CssClass="btn btn-warning" runat="server" ID="btnAdd" ClientIDMode="Static" OnClientClick="RC.OperationMaintenanceListing.ResetOperationMaintenance(); return false;">
                               <span class="fa fa-plus-circle"></span>Add
                        </asp:LinkButton>
                    </div>
                </div>
                <div class="col-md-12" style="clear: both;">
                    <table id="tblOperationMaintenanceList" class="table table-striped table-bordered" style="width: 100%;">
                        <thead>
                            <tr>
                                <th style="width: 60%;">Title</th>
                                <th style="width: 30%;">Short Title</th>
                                <th style="width: 10%; text-align: center;">Action</th>
                            </tr>
                        </thead>
                    </table>
                </div>
            </div>
        </div>
    </div>
    <script src="<%= Page.ResolveClientUrl("~/Script/RC.OperationMaintenanceListing.js") %>" type="text/javascript"></script>
    <cc1:ModalPopupExtender ID="mPopUpLocation" runat="server" PopupControlID="dvOperationMaintenanceDetail" TargetControlID="btnAdd" BehaviorID="ModelPopup" BackgroundCssClass="modal-background" CancelControlID="btnClose">
    </cc1:ModalPopupExtender>
    <asp:Panel ID="dvOperationMaintenanceDetail" runat="server" ClientIDMode="Static" Style="display: none;">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" id="btnClose" runat="server" class="close" clientidmode="Static">
                        <span>&times;</span><span class="sr-only">Close</span></button>
                    <h1 class="modal-title" id="myModalLabel">
                        <span class="fa fa-clock-o"></span><span id="spnHeading">Manage</span> Operation Maintenance</h1>
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
                                <span class="fa fa-caret-right"></span>Title</label>
                            <asp:TextBox ID="txtTitle" runat="server" ClientIDMode="Static" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="col-md-4">
                            <label>
                                <span class="fa fa-caret-right"></span>Short Title</label>
                            <asp:TextBox ID="txtShortTitle" runat="server" ClientIDMode="Static" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>

                </div>
                <div class="modal-footer">
                    <button type="button" id="btnSave" class="btn btn-success" onclick="RC.OperationMaintenanceListing.SaveOperationMaintenance();">Save</button>
                </div>
            </div>
        </div>
    </asp:Panel>
</asp:Content>
