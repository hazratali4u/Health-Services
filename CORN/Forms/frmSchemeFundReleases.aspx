<%@ Page Title="MPR :: Scheme / Project Documents" Language="C#" MasterPageFile="~/Forms/PageMaster.master" AutoEventWireup="true" CodeFile="frmSchemeFundReleases.aspx.cs" Inherits="Forms_frmSchemeFundReleases" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphPage" runat="Server">
    <div id="dvSchemeFundReleaseListing" class="main-contents">
        <div class="container employee-infomation">
            <div class="row top">
                <div class="col-md-12">
                    <div class="btnlist pull-right">
                        <asp:LinkButton CssClass="btn btn-warning" runat="server" ID="btnAdd" ClientIDMode="Static">
                            <span class="fa fa-plus-circle"></span>Add
                        </asp:LinkButton>
                    </div>
                </div>
                <div class="col-md-12" style="clear: both;">
                    <table id="tblSchemeFundReleaseList" class="table table-striped table-bordered" style="width: 100%;">
                        <thead>
                            <tr>
                                <th style="width: 45%;">Scheme</th>
                                <%--<th style="width: 15%;">Release Type</th>--%>
                                <th style="width: 10%; text-align: center;">Year</th>
                                <th style="width: 15%; text-align: center;">Date</th>
                                <th style="width: 20%; text-align: center;">Total Release</th>
                                <th style="width: 10%; text-align: center;">Action</th>
                            </tr>
                        </thead>
                    </table>
                </div>
            </div>
        </div>
    </div>
    <script src="<%= Page.ResolveClientUrl("~/Script/RC.SchemeFundReleaseListing.js") %>" type="text/javascript"></script>
</asp:Content>

