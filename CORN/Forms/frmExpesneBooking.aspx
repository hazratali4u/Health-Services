<%@ Page Title="MPR :: Expense Booking" Language="C#" MasterPageFile="~/Forms/PageMaster.master"
    AutoEventWireup="true" CodeFile="frmExpesneBooking.aspx.cs" Inherits="Forms_frmExpesneBooking" %>

<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="cphPage">
    <div id="dvSchemeExpenseBookingListing" class="main-contents">
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
                    <table id="tblSchemeExpenseBookingList" class="table table-striped table-bordered" style="width: 100%;">
                        <thead>
                            <tr>
                                <th style="width: 35%;">Scheme</th>
                                <th style="width: 18%;">PO | Invoice #</th>
                                <th style="width: 15%; text-align: center;">Booking Type</th>
                                <th style="width: 12%; text-align: center;">Total Amount</th>
                                <th style="width: 12%; text-align: center;">Date</th>
                                <th style="width: 8%; text-align: center;">Action</th>
                            </tr>
                        </thead>
                    </table>
                </div>
            </div>
        </div>
    </div>
    <script src="<%= Page.ResolveClientUrl("~/Script/RC.SchemeExpenseBookingListing.js") %>" type="text/javascript"></script>
</asp:Content>
