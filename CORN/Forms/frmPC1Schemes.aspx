<%@ Page Title="MPR :: PC1 Scheme" Language="C#" MasterPageFile="~/Forms/PageMaster.master" AutoEventWireup="true" CodeFile="frmPC1Schemes.aspx.cs" Inherits="Forms_frmPC1Schemes" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
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
                        <asp:LinkButton CssClass="btn btn-warning" runat="server" ID="btnAdd" ClientIDMode="Static" OnClientClick="RC.SchemeListing.ResetScheme(); return false;">
                               <span class="fa fa-plus-circle"></span>Add
                        </asp:LinkButton>
                    </div>
                </div>
                <div class="col-md-12" style="clear: both;">
                    <table id="tblSchemeList" class="table table-striped table-bordered" style="width: 100%;">
                        <thead>
                            <tr>
                                <th style="width: 54%;">Scheme Name</th>
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
    <script src="<%= Page.ResolveClientUrl("~/Script/RC.PC1SchemeListing.js") %>" type="text/javascript"></script>
    <cc1:ModalPopupExtender ID="mPopUpLocation" runat="server" PopupControlID="dvSchemeDetail" TargetControlID="btnAdd" BehaviorID="ModelPopup" BackgroundCssClass="modal-background" CancelControlID="btnClose">
    </cc1:ModalPopupExtender>
    <asp:Panel ID="dvSchemeDetail" runat="server" ClientIDMode="Static" Style="display: none;">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" id="btnClose" runat="server" class="close" clientidmode="Static">
                        <span>&times;</span><span class="sr-only">Close</span></button>
                    <h1 class="modal-title" id="myModalLabel">
                        <span class="fa fa-clock-o"></span><span id="spnHeading">Manage</span> Scheme</h1>
                </div>
                <div class="modal-body">
                    <div class="row">
                        <div class="col-md-10">
                            <asp:Label ID="lblErrorMsg" runat="server" ClientIDMode="Static" ForeColor="Red" Font-Bold="True"></asp:Label>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-12">
                            <label>
                                <span class="fa fa-caret-right"></span>Title</label>
                            <asp:TextBox ID="txtTitle" runat="server" ClientIDMode="Static" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                </div>
                <div class="modal-footer">
                    <button type="button" id="btnSave" class="btn btn-success" onclick="RC.SchemeListing.SaveScheme();">Save</button>
                </div>
            </div>
        </div>
    </asp:Panel>
    <%--<div id="dvTemplates" style="display: none;">
        <div class="reportPopup">
            <ul class="list-group">
			  <li class="list-group-item pc1schemereport">PC1 Scheme Report</li>
			</ul>
        </div>
    </div>--%>
</asp:Content>

