<%@ Page Language="C#" MasterPageFile="~/Forms/PageMaster.master" AutoEventWireup="true"
    CodeFile="frmGeoHierarchy.aspx.cs" Inherits="Forms_frmGeoHierarchy" Title="MPR :: Geo Hierarchy" %>

<%@ Register Assembly="DevExpress.Web.v16.1, Version=16.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="cphPage">
    <div id="dvGeoHierarchyListing" class="main-contents">
        <div class="row">
            <div class="col-md-12">
                <input type="button" id="btnRegion" class="btn btn-primary" value="Region" style="height: 45px; width: 100px;" />
                &nbsp;<input type="button" id="btnDivision" class="btn btn-default" value="Division" style="height: 45px; width: 100px;" />
                &nbsp;<input type="button" id="btnDistrict" class="btn btn-default" value="District" style="height: 45px; width: 100px;" />
                &nbsp;<input type="button" id="btnTehsil" class="btn btn-default" value="Constituency" style="height: 45px; width: 100px;" />
                &nbsp;<input type="button" id="btnConstituency" class="btn btn-default" value="Constituency" style="height: 45px; width: 100px; display: none;" />
            </div>
        </div>
        <div class="row" style="height: 20px;">
        </div>
        <div id="dvFilter" class="row">
            <div id="dvFilterRegion" class="col-md-3" style="display: none;">
                <label><span class="fa fa-caret-right rgt_cart"></span>Region</label>
                <dx:ASPxComboBox ID="ddlRegion" runat="server" ClientInstanceName="ddlCTRegion" CssClass="form-control" TextFormatString="{1}">
                    <Columns>
                        <dx:ListBoxColumn FieldName="Code" Caption="Code" Width="25%" />
                        <dx:ListBoxColumn FieldName="Name" Caption="Name" Width="75%" />
                    </Columns>
                    <ClientSideEvents SelectedIndexChanged="function(s, e) { RC.GeoHierarchyListing.FilterViewForRegion(); }" />
                </dx:ASPxComboBox>
            </div>
            <div id="dvFilterDivision" class="col-md-3" style="display: none;">
                <label><span class="fa fa-caret-right rgt_cart"></span>Division</label>
                <dx:ASPxComboBox ID="ddlDivision" runat="server" ClientInstanceName="ddlCTDivision" CssClass="form-control" TextFormatString="{1}">
                    <Columns>
                        <dx:ListBoxColumn FieldName="Code" Caption="Code" Width="25%" />
                        <dx:ListBoxColumn FieldName="Name" Caption="Name" Width="75%" />
                    </Columns>
                    <ClientSideEvents SelectedIndexChanged="function(s, e) { RC.GeoHierarchyListing.FilterViewForDivision(); }" />
                </dx:ASPxComboBox>
            </div>
            <div id="dvFilterDistrict" class="col-md-3" style="display: none;">
                <label><span class="fa fa-caret-right rgt_cart"></span>District</label>
                <dx:ASPxComboBox ID="ddlDistrict" runat="server" ClientInstanceName="ddlCTDistrict" CssClass="form-control" TextFormatString="{1}">
                    <Columns>
                        <dx:ListBoxColumn FieldName="Code" Caption="Code" Width="25%" />
                        <dx:ListBoxColumn FieldName="Name" Caption="Name" Width="75%" />
                    </Columns>
                    <ClientSideEvents SelectedIndexChanged="function(s, e) { RC.GeoHierarchyListing.FilterViewForDistrict(); }" />
                </dx:ASPxComboBox>
            </div>
            <div id="dvFilterTehsil" class="col-md-3" style="display: none;">
                <label><span class="fa fa-caret-right rgt_cart"></span>Tehsil</label>
                <dx:ASPxComboBox ID="ddlTehsil" runat="server" ClientInstanceName="ddlCTTehsil" CssClass="form-control" TextFormatString="{1}">
                    <Columns>
                        <dx:ListBoxColumn FieldName="Code" Caption="Code" Width="25%" />
                        <dx:ListBoxColumn FieldName="Name" Caption="Name" Width="75%" />
                    </Columns>
                    <ClientSideEvents SelectedIndexChanged="function(s, e) { RC.GeoHierarchyListing.FilterViewForTehsil(); }" />
                </dx:ASPxComboBox>
            </div>
        </div>
        <div class="container employee-infomation">
            <div class="row top">
                <div class="col-md-12">
                    <div class="btnlist pull-right">
                        <asp:LinkButton CssClass="btn btn-warning" runat="server" ID="btnAdd" ClientIDMode="Static" OnClientClick="RC.GeoHierarchyListing.ResetGeoHierarchy(); return false;">
                               <span class="fa fa-plus-circle"></span>Add
                        </asp:LinkButton>
                    </div>
                </div>
                <div class="col-md-12" style="clear: both;">
                    <table id="tblGeoHierarchyList" class="table table-striped table-bordered" style="width: 100%;">
                        <thead>
                            <tr>
                                <th style="width: 25%;">Code</th>
                                <th style="width: 50%;">Name</th>
                                <th style="width: 15%; text-align: center;">Active</th>
                                <th style="width: 10%; text-align: center;">Action</th>
                            </tr>
                        </thead>
                    </table>
                </div>
            </div>
        </div>
    </div>
    <script src="<%= Page.ResolveClientUrl("~/Script/RC.GeoHierarchyListing.js") %>" type="text/javascript"></script>
    <cc1:ModalPopupExtender ID="mPopUpLocation" runat="server" PopupControlID="dvGeoHierarchyDetail" TargetControlID="btnAdd" BehaviorID="ModelPopup" BackgroundCssClass="modal-background" CancelControlID="btnClose">
    </cc1:ModalPopupExtender>
    <asp:Panel ID="dvGeoHierarchyDetail" runat="server" ClientIDMode="Static" Style="display: none;">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" id="btnClose" runat="server" class="close" clientidmode="Static">
                        <span>&times;</span><span class="sr-only">Close</span></button>
                    <h1 class="modal-title" id="myModalLabel">
                        <span class="fa fa-clock-o"></span><span id="spnHeading">Manage</span> Geo Hierarchy</h1>
                </div>
                <div class="modal-body">
                    <div class="row">
                        <div class="col-md-12">
                            <asp:Label ID="lblErrorMsg" runat="server" ClientIDMode="Static" ForeColor="Red" Font-Bold="True"></asp:Label>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-2">
                            <label>
                                <span class="fa fa-caret-right"></span>Code</label>
                            <asp:TextBox ID="txtCode" runat="server" ClientIDMode="Static" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="col-md-4" id="dvName">
                            <label>
                                <span class="fa fa-caret-right"></span>Name</label>
                            <asp:TextBox ID="txtName" runat="server" ClientIDMode="Static" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="col-md-4" id="dvParent">
                            <label>
                                <span class="fa fa-caret-right"></span>Parent</label>
                            <dx:ASPxComboBox ID="ddlParent" runat="server" ClientInstanceName="ddlCTParent" CssClass="form-control" TextFormatString="{1}">
                                <Columns>
                                    <dx:ListBoxColumn FieldName="Code" Caption="Code" Width="25%" />
                                    <dx:ListBoxColumn FieldName="Name" Caption="Name" Width="75%" />
                                </Columns>
                            </dx:ASPxComboBox>
                        </div>
                        <div class="col-md-2">
                            <label>
                                <span class="fa fa-caret-right"></span>Active</label>
                            <asp:CheckBox ID="chkActive" runat="server" ClientIDMode="Static" CssClass="form-control" />
                        </div>
                    </div>
                </div>
                <div class="modal-footer" style="margin-top: 20px;">
                    <button type="button" id="btnSave" class="btn btn-success" onclick="RC.GeoHierarchyListing.SaveGeoHierarchy();">Save</button>
                </div>
            </div>
        </div>
    </asp:Panel>
</asp:Content>
