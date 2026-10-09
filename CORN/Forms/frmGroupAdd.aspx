<%@ Page Title="" Language="C#" MasterPageFile="~/Forms/PageMaster.master" AutoEventWireup="true" CodeFile="frmGroupAdd.aspx.cs" Inherits="Forms_frmGroupAdd" %>

<%@ Register Assembly="DevExpress.Web.v16.1, Version=16.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphHeadPage" runat="Server">
    <style>
        .dashboard-stat {
            margin-bottom: 0px !important;
        }

            .dashboard-stat.dashboard-stat-v2 .visual {
                margin-bottom: 0px !important;
            }

            .dashboard-stat .visual {
                height: 65px !important;
            }

            .dashboard-stat .details .number {
                padding-top: 0px !important;
            }
    </style>
    <script language="JavaScript" type="text/javascript">
        function calendarShown(sender, args) {
            sender._popupBehavior._element.style.zIndex = 10005;
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphPage" runat="Server">
    <div id="dvManageGroup">
        <div class="row">
            <div class="col-md-4">
                <label><span class="fa fa-caret-right rgt_cart"></span>Title</label>
                <asp:TextBox ID="txtTitle" runat="server" ClientIDMode="Static" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-md-2">
                <label><span class="fa fa-caret-right rgt_cart"></span>Short Title</label>
                <asp:TextBox ID="txtShortTitle" runat="server" ClientIDMode="Static" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-md-6"></div>
        </div>
        <div class="row" style="height: 20px;">
        </div>
        <div id="dvManageGroupAccountHead">
            <div class="emp-table">
                <asp:Panel ID="pnlGroupAccountHead" runat="server" ClientIDMode="Static" GroupingText="Account Head">
                    <div class="row">
                        <div id="dvCOA" class="col-md-6">
                            <label id="lblCOA"><span class="fa fa-caret-right rgt_cart"></span>Object Code</label>&nbsp;*
                            <dx:ASPxComboBox ID="ddlCOA" runat="server" ClientInstanceName="ddlCTCOA" CssClass="form-control" TextFormatString="{0} ({1})">
                                <Columns>
                                    <dx:ListBoxColumn FieldName="ACCOUNT_CODE" Caption="Code" Width="50px" />
                                    <dx:ListBoxColumn FieldName="ACCOUNT_NAME" Caption="Name" Width="250px" />
                                </Columns>
                            </dx:ASPxComboBox>
                        </div>
                        <div class="col-md-2">
                            <br />
                            <input type="button" id="btnSaveAccountHead" class="btn btn-success" onclick="RC.ManageGroup.GroupAccountHeadSave(-1);" value="Add" style="margin-top: 4px;" />
                        </div>
                        <div class="col-md-4"></div>
                    </div>
                </asp:Panel>
            </div>
            <div class="row">
                <div class="col-md-12">
                    <table id="tblGroupAccountHeadList" class="table table-striped table-bordered" style="width: 100%;">
                        <thead>
                            <tr>
                                <th style="width: 90%;">Object Code</th>
                                <th style="width: 10%; text-align: center;">Action</th>
                            </tr>
                        </thead>
                    </table>
                </div>
            </div>
        </div>
        <div class="row" style="height: 100px;">
        </div>
        <input type="button" id="btnSave" class="btn btn-success" onclick="RC.ManageGroup.SaveGroup();" value="Save" />
        <input type="button" id="btnCancel" class="btn btn-danger" value="Cancel" />
    </div>
    <script src="<%= Page.ResolveClientUrl("~/Script/RC.ManageGroup.js") %>" type="text/javascript"></script>
</asp:Content>

