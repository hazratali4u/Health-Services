<%@ Page Title="MPR :: Dashboard" Language="C#" MasterPageFile="~/Forms/PageMaster.master"
    AutoEventWireup="true" CodeFile="rptDashboard.aspx.cs" Inherits="Forms_rptDashboard" %>

<%@ Register Assembly="DevExpress.Web.v16.1, Version=16.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<asp:Content ID="cPage" ContentPlaceHolderID="cphPage" runat="Server">
    <link href="../assets/css/material-kit.css" rel="stylesheet" />
    <link rel="stylesheet" href="../css/jQueryUI/jquery-ui.css">
    <script src="../js/jquery-ui.js" type="text/javascript"></script>
    <style>
        .card {
            background: mintcream;
        }

        .form-control {
            margin-bottom: 3px !important;
        }
    </style>
    <div class="row">
        <div id="dvSRA" class="col-lg-3 col-md-3 col-sm-3 col-xs-12">
            <div class="dashboard-stat dashboard-stat-v2 yellow">
                <div class="visual">
                    <i class="fa fa-bar-chart-o"></i>
                </div>
                <div class="details">
                    <div class="number">
                        <span>0.00</span>%
                    </div>
                    <div class="desc">Release as % of Allocation</div>
                </div>
            </div>
        </div>
        <div id="dvSEA" class="col-lg-3 col-md-3 col-sm-3 col-xs-12">
            <div class="dashboard-stat dashboard-stat-v2 green">
                <div class="visual">
                    <i class="fa fa-globe"></i>
                </div>
                <div class="details">
                    <div class="number">
                        <span>0.00</span>%
                    </div>
                    <div class="desc">Expenditure as % of Allocation</div>
                </div>
            </div>
        </div>
        <div id="dvSRFG" class="col-lg-3 col-md-3 col-sm-3 col-xs-12">
            <div class="dashboard-stat dashboard-stat-v2 blue">
                <div class="visual">
                    <i class="fa fa-bar-chart-o"></i>
                </div>
                <div class="details">
                    <div class="number">
                        <span>0.00</span>%
                    </div>
                    <div class="desc">Release as % of Final Grant</div>
                </div>
            </div>
        </div>
        <div id="dvSEFG" class="col-lg-3 col-md-3 col-sm-3 col-xs-12">
            <div class="dashboard-stat dashboard-stat-v2 red">
                <div class="visual">
                    <i class="fa fa-globe"></i>
                </div>
                <div class="details">
                    <div class="number">
                        <span>0.00</span>%
                    </div>
                    <div class="desc">Expenditure as % of Final Grant</div>
                </div>
            </div>
        </div>
    </div>
    <div class="emp-table" style="margin-bottom: 25px;">
        <asp:Panel ID="pnlFilter" runat="server" ClientIDMode="Static" GroupingText="Filter Options">
            <div class="row">
                <div class="col-md-2">
                    <label><span class="fa fa-caret-right rgt_cart"></span>Date</label>
                    <input id="dtToDate" type="text" class="form-control" />
                </div>
                <div class="col-md-2">
                    <label><span class="fa fa-caret-right rgt_cart"></span>Financial Year</label>
                    <dx:ASPxComboBox ID="ddlFY" runat="server" ClientInstanceName="ddlCTSchemeFY" CssClass="form-control" TextFormatString="{2}">
                        <Columns>
                            <dx:ListBoxColumn FieldName="Id" Caption="Code" Width="20px" />
                            <dx:ListBoxColumn FieldName="StartDateStandardString" Caption="Start Date" Width="40px" />
                            <dx:ListBoxColumn FieldName="EndDateStandardString" Caption="End Date" Width="40px" />
                        </Columns>
                        <ClientSideEvents SelectedIndexChanged="function(s, e) { RC.Dashboard.SetDatePicker(); RC.Dashboard.GenerateGraph(); }" />
                    </dx:ASPxComboBox>
                </div>
                <div class="col-md-2">
                    <label><span class="fa fa-caret-right rgt_cart"></span>Show Graph</label>
                    <dx:ASPxComboBox ID="ddlShowGraph" runat="server" ClientInstanceName="ddlCTShowGraph" CssClass="form-control" TextFormatString="{0}">
                        <Columns>
                            <dx:ListBoxColumn FieldName="Title" Caption="Name" Width="100px" />
                        </Columns>
                        <ClientSideEvents SelectedIndexChanged="function(s, e) { RC.Dashboard.GenerateGraph(); }" />
                    </dx:ASPxComboBox>
                </div>
                <div id="dvDistrict" class="col-md-3" style="display: none;">
                    <label><span class="fa fa-caret-right rgt_cart"></span>District</label>
                    <dx:ASPxComboBox ID="ddlDistrict" runat="server" CssClass="form-control" TextFormatString="{0}" ClientInstanceName="ddlDistrict">
                        <Columns>
                            <dx:ListBoxColumn FieldName="Name" Caption="Name" Width="50px" />
                            <dx:ListBoxColumn FieldName="Division" Caption="Division" Width="25px" />
                            <dx:ListBoxColumn FieldName="Region" Caption="Region" Width="25px" />
                        </Columns>
                        <ClientSideEvents SelectedIndexChanged="function(s, e) { LoadConstituency(); }" />
                    </dx:ASPxComboBox>
                </div>
                <div id="dvConstituency" class="col-md-3" style="display: none;">
                    <label><span class="fa fa-caret-right rgt_cart"></span>Constituency</label>
                    <dx:ASPxComboBox ID="ddlConstituency" runat="server" CssClass="form-control" TextFormatString="{1}" ClientInstanceName="ddlConstituency">
                        <Columns>
                            <dx:ListBoxColumn FieldName="Code" Caption="Code" Width="25px" />
                            <dx:ListBoxColumn FieldName="Name" Caption="Name" Width="75px" />
                        </Columns>
                        <ClientSideEvents SelectedIndexChanged="function(s, e) { RC.Dashboard.GenerateGraph(); }" />
                    </dx:ASPxComboBox>
                </div>
            </div>
        </asp:Panel>
    </div>
    <div id="dvSGFundWise" style="display: none;">
        <div class="card card-nav-tabs">
            <div class="header header-primary">
                <!-- colors: "header-primary", "header-info", "header-success", "header-warning", "header-danger" -->
                <div class="nav-tabs-navigation">
                    <div class="nav-tabs-wrapper">
                        <ul class="nav nav-tabs" data-tabs="tabs">
                            <li>
                                <span class="fa fa-caret-right rgt_cart"></span>Fund Wise
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
            <div style="padding: 15px;">
                <div class="tab-content">
                    <div class="tab-pane active">
                        <div class="row" style="margin-top: 10px;">
                            <div class="col-md-6">
                                <div id="dvFWBudgetEstimate" style="width: 100%; height: 400px; margin: 0 auto; background-color: #fff; text-align: center;"></div>
                            </div>
                            <div class="col-md-6">
                                <div id="dvFWExpenditure" style="width: 100%; height: 400px; margin: 0 auto; background-color: #fff; text-align: center;"></div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div id="dvSGStatusWise" style="display: none;">
        <div class="card card-nav-tabs">
            <div class="header header-info">
                <!-- colors: "header-primary", "header-info", "header-success", "header-warning", "header-danger" -->
                <div class="nav-tabs-navigation">
                    <div class="nav-tabs-wrapper">
                        <ul class="nav nav-tabs" data-tabs="tabs">
                            <li>
                                <span class="fa fa-caret-right rgt_cart"></span>Scheme Status Wise
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
            <div style="padding: 15px;">
                <div class="tab-content">
                    <div class="tab-pane active">
                        <div class="row">
                            <div class="col-md-12">
                                <div id="dvSWBudgetExpenditureAnalysis" style="width: 100%; height: 400px; margin: 0 auto; background-color: #fff; text-align: center;"></div>
                            </div>
                        </div>
                        <div class="row" style="margin-top: 10px;">
                            <div class="col-md-6">
                                <div id="dvSWBudgetEstimate" style="width: 100%; height: 400px; margin: 0 auto; background-color: #fff; text-align: center;"></div>
                            </div>
                            <div class="col-md-6">
                                <div id="dvSWExpenditure" style="width: 100%; height: 400px; margin: 0 auto; background-color: #fff; text-align: center;"></div>
                            </div>
                        </div>
                        <div class="row" style="margin-top: 10px; display: none;">
                            <div class="col-md-6">
                                <div id="dvSWBudgetEstimateNO" style="width: 100%; height: 400px; margin: 0 auto; background-color: #fff; text-align: center;"></div>
                            </div>
                            <div class="col-md-6">
                                <div id="dvSWExpenditureNO" style="width: 100%; height: 400px; margin: 0 auto; background-color: #fff; text-align: center;"></div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div id="dvSGSubSectorWise" style="display: none;">
        <div class="card card-nav-tabs">
            <div class="header header-success">
                <!-- colors: "header-primary", "header-info", "header-success", "header-warning", "header-danger" -->
                <div class="nav-tabs-navigation">
                    <div class="nav-tabs-wrapper">
                        <ul class="nav nav-tabs" data-tabs="tabs">
                            <li>
                                <span class="fa fa-caret-right rgt_cart"></span>Sub Sector
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
            <div style="padding: 15px;">
                <div class="tab-content">
                    <div class="tab-pane active">
                        <div class="row">
                            <div class="col-md-12">
                                <div id="dvSSWRBudgetExpenditureAnalysis" style="width: 100%; height: 400px; margin: 0 auto; background-color: #fff; text-align: center;"></div>
                            </div>
                        </div>
                        <div class="row" style="margin-top: 10px;">
                            <div class="col-md-6">
                                <div id="dvSSWRBudgetEstimate" style="width: 100%; height: 400px; margin: 0 auto; background-color: #fff; text-align: center;"></div>
                            </div>
                            <div class="col-md-6">
                                <div id="dvSSWRExpenditure" style="width: 100%; height: 400px; margin: 0 auto; background-color: #fff; text-align: center;"></div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div id="dvSGObjectWise" style="display: none;">
        <div class="card card-nav-tabs">
            <div class="header header-warning">
                <!-- colors: "header-primary", "header-info", "header-success", "header-warning", "header-danger" -->
                <div class="nav-tabs-navigation">
                    <div class="nav-tabs-wrapper">
                        <ul class="nav nav-tabs" data-tabs="tabs">
                            <li>
                                <span class="fa fa-caret-right rgt_cart"></span>Object Wise
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
            <div style="padding: 15px;">
                <div class="tab-content">
                    <div class="tab-pane active">
                        <div class="row">
                            <div class="col-md-12">
                                <div id="dvOWRBudgetExpenditureAnalysis" style="width: 100%; height: 400px; margin: 0 auto; background-color: #fff; text-align: center;"></div>
                            </div>
                        </div>
                        <div class="row" style="margin-top: 10px;">
                            <div class="col-md-6">
                                <div id="dvOWRBudgetEstimate" style="width: 100%; height: 400px; margin: 0 auto; background-color: #fff; text-align: center;"></div>
                            </div>
                            <div class="col-md-6">
                                <div id="dvOWRExpenditure" style="width: 100%; height: 400px; margin: 0 auto; background-color: #fff; text-align: center;"></div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div id="dvSGFunctionWise" style="display: none;">
        <div class="card card-nav-tabs">
            <div class="header header-danger">
                <!-- colors: "header-primary", "header-info", "header-success", "header-warning", "header-danger" -->
                <div class="nav-tabs-navigation">
                    <div class="nav-tabs-wrapper">
                        <ul class="nav nav-tabs" data-tabs="tabs">
                            <li>
                                <span class="fa fa-caret-right rgt_cart"></span>Function Wise
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
            <div style="padding: 15px;">
                <div class="tab-content">
                    <div class="tab-pane active">
                        <div class="row">
                            <div class="col-md-12">
                                <div id="dvFWRBudgetExpenditureAnalysis" style="width: 100%; height: 400px; margin: 0 auto; background-color: #fff; text-align: center;"></div>
                            </div>
                        </div>
                        <div class="row" style="margin-top: 10px;">
                            <div class="col-md-6">
                                <div id="dvFWRBudgetEstimate" style="width: 100%; height: 400px; margin: 0 auto; background-color: #fff; text-align: center;"></div>
                            </div>
                            <div class="col-md-6">
                                <div id="dvFWRExpenditure" style="width: 100%; height: 400px; margin: 0 auto; background-color: #fff; text-align: center;"></div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div id="dvSGADPSummary" style="display: none;">
        <div class="card card-nav-tabs">
            <div class="header header-primary">
                <!-- colors: "header-primary", "header-info", "header-success", "header-warning", "header-danger" -->
                <div class="nav-tabs-navigation">
                    <div class="nav-tabs-wrapper">
                        <ul class="nav nav-tabs" data-tabs="tabs">
                            <li>
                                <span class="fa fa-caret-right rgt_cart"></span>ADP Summary
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
            <div style="padding: 15px;">
                <div class="tab-content">
                    <div class="tab-pane active">

                        <div class="row" style="margin-top: 10px;">
                            <div class="col-md-12">
                                <div id="dvADPSSummary" style="width: 100%; height: 400px; margin: 0 auto; background-color: #fff; text-align: center;"></div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div id="dvSGSubSectorSummary" style="display: none;">
        <div class="card card-nav-tabs">
            <div class="header header-info">
                <!-- colors: "header-primary", "header-info", "header-success", "header-warning", "header-danger" -->
                <div class="nav-tabs-navigation">
                    <div class="nav-tabs-wrapper">
                        <ul class="nav nav-tabs" data-tabs="tabs">
                            <li>
                                <span class="fa fa-caret-right rgt_cart"></span>Sub Sector Summary
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
            <div style="padding: 15px;">
                <div class="tab-content">
                    <div class="tab-pane active">
                        <div class="row">
                            <div class="col-md-12">
                                <div id="dvSSSSummary" style="width: 100%; height: 400px; margin: 0 auto; background-color: #fff; text-align: center;"></div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div id="dvSGConstituencyWise" style="display: none;">
        <div class="card card-nav-tabs">
            <div class="header header-success">
                <!-- colors: "header-primary", "header-info", "header-success", "header-warning", "header-danger" -->
                <div class="nav-tabs-navigation">
                    <div class="nav-tabs-wrapper">
                        <ul class="nav nav-tabs" data-tabs="tabs">
                            <li>
                                <span class="fa fa-caret-right rgt_cart"></span>Constituency Wise
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
            <div style="padding: 15px;">
                <div class="tab-content">
                    <div class="tab-pane active">
                        <div class="row">
                            <div class="col-md-12">
                                <div id="dvCWRBudgetExpenditureAnalysis" style="width: 100%; height: 500px; margin: 0 auto; background-color: #fff; text-align: center;"></div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <script src="<%= Page.ResolveClientUrl("~/js/highstock.js") %>" type="text/javascript"></script>
    <script src="<%= Page.ResolveClientUrl("~/js/exporting.js") %>" type="text/javascript"></script>
    <script src="<%= Page.ResolveClientUrl("~/js/highcharts-theme.js") %>" type="text/javascript"></script>
    <script src="<%= Page.ResolveClientUrl("~/Script/RC.Dashboard.js") %>" type="text/javascript"></script>
    <script type="text/javascript">
        function LoadConstituency() {
            var id = parseInt(ddlDistrict.GetSelectedItem().value);

            ddlConstituency.ClearItems();
            ddlConstituency.AddItem(new Array("All", "All"), "0");
            ddlConstituency.SetSelectedIndex(0);

            if (id > 0) {
                RC.Dashboard.GenerateGraph();

                $.post(RC.Common.RootURL + "Handler/GeoHierarchyHandler.ashx",
                    {
                        method: 'GeoHierarchyConstituencyGetDistrictId',
                        Id: id
                    },
                    function (response) {
                        switch (response.Status) {
                            case RC.Common.ResponseStatus.SUCCESS:
                                $(response.Data).each(function (index, item) {
                                    ddlConstituency.AddItem(new Array(item.Code, item.Name), item.Id.toString());
                                });

                                break;
                            case RC.Common.ResponseStatus.ERROR:
                                alert(response.Message);

                                break;
                            case RC.Common.ResponseStatus.SESSIONEXPIRED:
                                alert(response.Message);

                                window.location = RC.Common.GetLoginURL();

                                break;
                            default:
                                break;
                        }

                        ddlConstituency.SetSelectedIndex(0);
                    });
            }
        }
    </script>
</asp:Content>
