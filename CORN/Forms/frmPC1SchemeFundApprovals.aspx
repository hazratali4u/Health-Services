<%@ Page Title="MPR :: Scheme / Project Documents" Language="C#" MasterPageFile="~/Forms/PageMaster.master" AutoEventWireup="true" CodeFile="frmPC1SchemeFundApprovals.aspx.cs" Inherits="Forms_frmPC1SchemeFundApprovals" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphPage" runat="Server">
    <div id="dvSchemeFundApprovalListing" class="main-contents">
        <div class="container employee-infomation">
            <div class="row top">
                <div class="col-md-12">
                    <div class="btnlist pull-right">
                        <asp:LinkButton CssClass="btn btn-warning" runat="server" ID="btnAdd" OnClientClick="window.location = 'frmPC1SchemeFundApprovalAdd.aspx?LevelType=3&LevelID=276'; return false;">
                               <span class="fa fa-plus-circle"></span>Add
                        </asp:LinkButton>
                    </div>
                </div>
                <div class="col-md-12" style="clear: both;">
                    <table id="tblSchemeFundApprovalList" class="table table-striped table-bordered" style="width: 100%;">
                        <thead>
                            <tr>
                                <th style="width: 25%;">Scheme</th>
                                <th style="width: 25%;">Reference No</th>
                                <th style="width: 20%; text-align: center;">Status</th>
                                <th style="width: 20%; text-align: center;">Date</th>
                                <th style="width: 10%; text-align: center;">Action</th>
                            </tr>
                        </thead>
                    </table>
                </div>
            </div>
        </div>
    </div>
    <script src="<%= Page.ResolveClientUrl("~/Script/RC.PC1SchemeFundApprovalListing.js") %>" type="text/javascript"></script>
</asp:Content>

