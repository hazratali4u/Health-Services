<%@ Page Title="MPR :: Home" Language="C#" MasterPageFile="~/Forms/PageMaster.master"
    AutoEventWireup="true" CodeFile="PUHome.aspx.cs" Inherits="Forms_PUHome" %>

<%@ PreviousPageType VirtualPath="~/PULogin.aspx" %>

<asp:Content ID="cPage" ContentPlaceHolderID="cphPage" runat="Server">
    <link href="../assets/css/material-kit.css" rel="stylesheet" />
    <style>
        .btn {
            padding: 0px !important;
            margin: 0px !important;
        }
    </style>
    <div class="row">
        <div class="col-md-6">
            <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
        </div>
    </div>
    <div class="row">
        <div class="col-md-6">
            <div class="card card-nav-tabs">
                <div class="header header-primary">
                    <!-- colors: "header-primary", "header-info", "header-success", "header-warning", "header-danger" -->
                    <div class="nav-tabs-navigation">
                        <div class="nav-tabs-wrapper">
                            <ul class="nav nav-tabs" data-tabs="tabs">
                                <li>
                                    <span class="fa fa-caret-right rgt_cart"></span>MPR
                                </li>
                            </ul>
                        </div>
                    </div>
                </div>
                <div style="padding: 15px;">
                    <div class="tab-content">
                        <div class="tab-pane active">
                            <span id="lnkMPRCreateModifyScheme" runat="server">
                                <a class="btn btn-simple btn-primary" href="frmSchemes.aspx?LevelType=3&LevelID=232&mode=MPR">Create / Modify Scheme</a><br />
                            </span>
                            <span id="lnkReviewEditSchemeExpense" runat="server">
                                <a class="btn btn-simple btn-primary" href="frmExpesneBooking.aspx?LevelType=3&LevelID=243">Review / Edit Scheme Expenses</a><br />
                            </span>
                            <span id="lnkAddEditComments" runat="server">
                                <a class="btn btn-simple btn-primary" href="frmSchemeComment.aspx?LevelType=3&LevelID=249">Add / Edit Comments</a><br />
                            </span>
                            <span>
                                <a class="btn btn-simple btn-primary">Review MPR</a>
                            </span>
                        </div>
                    </div>
                </div>
            </div>
            <br />
            <br />
            <br />
            <div class="card card-nav-tabs">
                <div class="header header-info">
                    <!-- colors: "header-primary", "header-info", "header-success", "header-warning", "header-danger" -->
                    <div class="nav-tabs-navigation">
                        <div class="nav-tabs-wrapper">
                            <ul class="nav nav-tabs" data-tabs="tabs">
                                <li>
                                    <span class="fa fa-caret-right rgt_cart"></span>ADP
                                </li>
                            </ul>
                        </div>
                    </div>
                </div>
                <div style="padding: 15px;">
                    <div class="tab-content">
                        <div class="tab-pane active">
                            <span id="lnkADPCreateModifyScheme" runat="server">
                                <a class="btn btn-simple btn-info" href="frmSchemes.aspx?LevelType=3&LevelID=232&mode=ADP">Create / Modify Scheme</a><br />
                            </span>
                            <span>
                                <a class="btn btn-simple btn-info">ADP Draft Review</a><br />
                            </span>
                        </div>
                    </div>
                </div>
            </div>
            <br />
            <br />
            <br />
            <div class="card card-nav-tabs">
                <div class="header header-success">
                    <!-- colors: "header-primary", "header-info", "header-success", "header-warning", "header-danger" -->
                    <div class="nav-tabs-navigation">
                        <div class="nav-tabs-wrapper">
                            <ul class="nav nav-tabs" data-tabs="tabs">
                                <li>
                                    <span class="fa fa-caret-right rgt_cart"></span>Admin
                                </li>
                            </ul>
                        </div>
                    </div>
                </div>
                <div style="padding: 15px;">
                    <div class="tab-content">
                        <div class="tab-pane active">
                            <span id="lnkDistributor" runat="server">
                                <a class="btn btn-simple btn-success" href="frmDistributor.aspx?LevelType=3&LevelID=9">Add / Modify Spending Unit</a><br />
                            </span>
                            <span id="lnkSaleForce" runat="server">
                                <a class="btn btn-simple btn-success" href="frmSaleForce.aspx?LevelType=3&LevelID=21">Create / Modify Employee</a><br />
                            </span>
                            <span id="lnkCreateUser" runat="server">
                                <a class="btn btn-simple btn-success" href="frmCreateUser.aspx?LevelType=3&LevelID=80">Create / Edit User Login</a><br />
                            </span>
                            <span id="lnkUserAssignment" runat="server">
                                <a class="btn btn-simple btn-success" href="frmUserAssignment.aspx?LevelType=3&LevelID=144">User / Spending Unit Assignment</a><br />
                            </span>
                            <span>
                                <a class="btn btn-simple btn-success" href="frmChangePassword.aspx?LevelType=3&LevelID=129">Change Password
                                </a>
                            </span>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="col-md-6">
            <div class="card card-nav-tabs">
                <div class="header header-warning">
                    <!-- colors: "header-primary", "header-info", "header-success", "header-warning", "header-danger" -->
                    <div class="nav-tabs-navigation">
                        <div class="nav-tabs-wrapper">
                            <ul class="nav nav-tabs" data-tabs="tabs">
                                <li>
                                    <span class="fa fa-caret-right rgt_cart"></span>Funds Management
                                </li>
                            </ul>
                        </div>
                    </div>
                </div>
                <div style="padding: 15px;">
                    <div class="tab-content">
                        <div class="tab-pane active">
                            <asp:Literal ID="ltrFunds" runat="server"></asp:Literal>
                        </div>
                    </div>
                </div>
            </div>
            <br />
            <br />
            <br />
            <div class="card card-nav-tabs">
                <div class="header header-danger">
                    <!-- colors: "header-primary", "header-info", "header-success", "header-warning", "header-danger" -->
                    <div class="nav-tabs-navigation">
                        <div class="nav-tabs-wrapper">
                            <ul class="nav nav-tabs" data-tabs="tabs">
                                <li>
                                    <span class="fa fa-caret-right rgt_cart"></span>Reports
                                </li>
                            </ul>
                        </div>
                    </div>
                </div>
                <div style="padding: 15px;">
                    <div class="tab-content">
                        <div class="tab-pane active">
                            <asp:Literal ID="ltrPPR" runat="server"></asp:Literal><br />
                            <asp:Literal ID="ltrMPR" runat="server"></asp:Literal><br />
                            <asp:Literal ID="ltrADPSDR" runat="server"></asp:Literal><br />
                            <asp:Literal ID="ltrOR" runat="server"></asp:Literal><br />
                            <asp:Literal ID="ltrES" runat="server"></asp:Literal>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <script type="text/javascript">
        $(document).ready(function () {
            $('a.pc1schemereports').webuiPopover();
        });

        function OpenReport(elem, levelId) {
            window.location = RC.Common.RootURL + "Forms/" + $(elem).attr("url") + "?LevelType=3&LevelID=" + levelId;
        }
    </script>
</asp:Content>
