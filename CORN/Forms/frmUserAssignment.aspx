<%@ Page Language="C#" MasterPageFile="~/Forms/PageMaster.master" AutoEventWireup="true" CodeFile="frmUserAssignment.aspx.cs"
    Inherits="Forms_frmUserAssignment" Title="MPR :: User Assignment" %>

<%@ Register Assembly="DevExpress.Web.v16.1, Version=16.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphPage" runat="Server">
    <style type="text/css">
        .nxt {
            text-align: center !important;
        }
        .bottom .fa {
            padding-top: 10px !important;
        }
    </style>
    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
        <ContentTemplate>
            <asp:Panel ID="Panel1" runat="server">
                <div class="main-contents">
                    <div class="container user_assignment">
                        <div class="row top">
                            <div class="col-md-3">
                                <label>
                                    <span class="fa fa-caret-right rgt_cart"></span>User</label>
                                <dx:ASPxComboBox ID="ddUser" runat="server" CssClass="form-control"
                                    TabIndex="1" OnSelectedIndexChanged="ddUser_SelectedIndexChanged"
                                    AutoPostBack="True">
                                </dx:ASPxComboBox>
                            </div>
                        </div>
                        <div class="row bottom">
                            <div class="col-md-9">
                                <div class="panel panel-default">
                                    <div class="panel-heading">
                                        <span class="fa fa-caret-right rgt_cart"></span>Location Assignment
                                    </div>
                                    <div class="panel-body" style="margin-bottom: 15px;">
                                        <div class="row">
                                            <div class="col-md-5">
                                                <dx:ASPxComboBox ID="ddDistributorType" runat="server" CssClass="form-control"
                                                    OnSelectedIndexChanged="ddDistributorType_SelectedIndexChanged"
                                                    AutoPostBack="True" TabIndex="2" Width="100%">
                                                </dx:ASPxComboBox>
                                            </div>
                                            <div id="dvInstitute" runat="server" class="col-md-5">
                                                <dx:ASPxComboBox ID="ddDistrict" runat="server" CssClass="form-control"
                                                    OnSelectedIndexChanged="ddDistrict_SelectedIndexChanged"
                                                    AutoPostBack="True" TabIndex="2" Width="100%" Visible="false">
                                                </dx:ASPxComboBox>
                                            </div>
                                            <div class="col-md-2"></div>
                                        </div>
                                        <div class="module_contents">
                                            <div class="row" style="margin-bottom: 10px;">
                                                <div class="col-md-5" style="font-size: smaller;">
                                                    Click on this List and start typing to search for an entry:
                                                </div>
                                                <div class="col-md-2"></div>
                                                <div class="col-md-5" style="font-size: smaller;">
                                                    Click on this List and start typing to search for an entry:
                                                </div>
                                            </div>
                                            <div class="row">
                                                <div class="col-md-5">
                                                    <cc1:ListSearchExtender ID="lseUnAssignDistributor" runat="server" TargetControlID="lstUnAssignDistributor"></cc1:ListSearchExtender>
                                                    <asp:ListBox ID="lstUnAssignDistributor" runat="server"
                                                        Height="350px" Width="100%" CssClass="select" TabIndex="3"></asp:ListBox>
                                                </div>
                                                <div class="col-md-2">
                                                    <div class="navs navslist">
                                                        <div class="nxt arrow">
                                                            <span>
                                                                <asp:LinkButton ID="btnAssignAllLocation" CssClass="fa fa-angle-double-right" OnClick="btnAssignAllLocation_Click"
                                                                    runat="server" TabIndex="4" /></span>
                                                        </div>
                                                        <div class="nxt arrow">
                                                            <span>
                                                                <asp:LinkButton ID="btnAssignLocation" CssClass="fa fa-angle-right" OnClick="btnAssignLocation_Click"
                                                                    runat="server" TabIndex="5" /></span>
                                                        </div>
                                                        <div class="nxt arrow">
                                                            <span>
                                                                <asp:LinkButton ID="btnUnAssignLocation" CssClass="fa fa-angle-left" OnClick="btnUnAssignLocation_Click"
                                                                    runat="server" TabIndex="6" /></span>
                                                        </div>
                                                        <div class="nxt arrow">
                                                            <span>
                                                                <asp:LinkButton ID="btnUnAssignAllLocation" CssClass="fa fa-angle-double-left" OnClick="btnUnAssignAllLocation_Click"
                                                                    runat="server" TabIndex="7" /></span>
                                                        </div>
                                                    </div>
                                                </div>
                                                <div class="col-md-5">
                                                    <cc1:ListSearchExtender ID="lseAssignDistributor" runat="server" TargetControlID="lstAssignDistributor"></cc1:ListSearchExtender>
                                                    <asp:ListBox ID="lstAssignDistributor" runat="server"
                                                        Height="350px" Width="100%" CssClass="select" TabIndex="6"></asp:ListBox>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-3"></div>
                            <div class="col-md-6" style="display: none">
                                <div class="panel panel-default">
                                    <div class="panel-heading">
                                        <span class="fa fa-caret-right rgt_cart"></span>Supplier Assignment
                                    </div>
                                    <div class="panel-body">
                                        <div class="module_contents">
                                            <div class="col-md-5">
                                                <asp:ListBox ID="lstUnAssignBrand" runat="server" Height="403px" Width="200px"
                                                    CssClass="select" TabIndex="7"></asp:ListBox>
                                            </div>
                                            <div class="col-md-2">
                                                <div class="navs navslist">
                                                    <div class="nxt arrow">
                                                        <span>
                                                            <asp:LinkButton ID="btnAssignPrincipal" OnClick="btnAssignPrincipal_Click" CssClass="fa  fa-angle-right"
                                                                runat="server" TabIndex="8" /></span>
                                                    </div>
                                                    <div class="nxt arrow">
                                                        <span>
                                                            <asp:LinkButton ID="btnAssignAllPrincipal" OnClick="btnAssignAllPrincipal_Click"
                                                                CssClass="fa  fa-angle-double-right" runat="server" TabIndex="9" /></span>
                                                    </div>
                                                    <div class="nxt arrow">
                                                        <span>
                                                            <asp:LinkButton ID="btnUnAssignAllPrincipal" CssClass="fa  fa-angle-double-left"
                                                                OnClick="btnUnAssignAllPrincipal_Click" runat="server" TabIndex="10" /></span>
                                                    </div>
                                                    <div class="nxt arrow">
                                                        <span>
                                                            <asp:LinkButton ID="btnUnAssignPrincipal" OnClick="btnUnAssignPrincipal_Click" runat="server"
                                                                CssClass="fa fa-angle-left" TabIndex="11" /></span>

                                                        <asp:Button ID="btnSave" OnClick="btnSave_Click" runat="server" Visible="False" Text="Save"
                                                            CssClass="button" TabIndex="12" />
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="col-md-5">
                                                <asp:ListBox ID="lstAssignBrand" runat="server" Height="403px"
                                                    CssClass="select" RepeatLayout="Flow" TabIndex="13"></asp:ListBox>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <asp:LinkButton ID="LinkButton5" runat="server" UseSubmitBehavior="false" />
            </asp:Panel>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
