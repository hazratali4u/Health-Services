<%@ Page Title="MPR :: Reapproiation" Language="C#" MasterPageFile="~/Forms/PageMaster.master"
    AutoEventWireup="true" CodeFile="frmSchemeReapproiation.aspx.cs" Inherits="Forms_frmSchemeReapproiation" %>

<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="cphPage">
    <div id="dvSchemeReappropriationListing" class="main-contents">
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
                    <table id="tblSchemeReappropriationList" class="table table-striped table-bordered" style="width: 100%;">
                        <thead>
                            <tr>
                                <th style="width: 40%; text-align: center;">Year</th>
                                <th style="width: 40%; text-align: center;">Month</th>
                                <th style="width: 20%; text-align: center;">Action</th>
                            </tr>
                        </thead>
                    </table>
                </div>
            </div>
        </div>
    </div>
    <script src="<%= Page.ResolveClientUrl("~/Script/RC.SchemeReappropriationListing.js") %>" type="text/javascript"></script>
</asp:Content>
