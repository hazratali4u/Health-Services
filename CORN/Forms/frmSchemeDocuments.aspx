<%@ Page Title="MPR :: Scheme / Project Documents" Language="C#" MasterPageFile="~/Forms/PageMaster.master" AutoEventWireup="true" CodeFile="frmSchemeDocuments.aspx.cs" Inherits="Forms_frmSchemeDocuments" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphPage" runat="Server">
    <div id="dvSchemeDocumentListing" class="main-contents">
        <div class="container employee-infomation">
            <div class="row top">
                <div class="col-md-12">
                    <div class="btnlist pull-right">
                        <asp:LinkButton CssClass="btn btn-warning" runat="server" ID="btnAdd" OnClientClick="window.location = 'frmSchemeDocumentAdd.aspx?LevelType=3&LevelID=248'; return false;">
                               <span class="fa fa-plus-circle"></span>Add
                        </asp:LinkButton>
                    </div>
                </div>
                <div class="col-md-12" style="clear: both;">
                    <table id="tblSchemeDocumentList" class="table table-striped table-bordered" style="width: 100%;">
                        <thead>
                            <tr>
                                <th style="width: 25%;">Scheme</th>
                                <th style="width: 25%;">Title</th>
                                <th style="width: 15%;">Version</th>
                                <th style="width: 25%; text-align: center;">Date</th>
                                <th style="width: 10%; text-align: center;">Action</th>
                            </tr>
                        </thead>
                    </table>
                </div>
            </div>
        </div>
    </div>
    <script src="<%= Page.ResolveClientUrl("~/Script/RC.SchemeDocumentListing.js") %>" type="text/javascript"></script>
</asp:Content>

