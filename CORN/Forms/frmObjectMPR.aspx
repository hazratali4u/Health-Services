<%@ Page Title="MPR :: Object Monthly Progress Report" Language="C#" MasterPageFile="~/Forms/PageMaster.master" AutoEventWireup="true" CodeFile="frmObjectMPR.aspx.cs" Inherits="Forms_frmObjectMPR" %>

<%@ Register Assembly="DevExpress.Web.v16.1, Version=16.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphHeadPage" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphPage" runat="Server">
    <script language="JavaScript" type="text/javascript">

        function calendarShown(sender, args) {
            sender._popupBehavior._element.style.zIndex = 10005;
        }

    </script>
    <div class="row">
        <div class="col-md-4">
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
        <div class="col-md-4">
            <label><span class="fa fa-caret-right rgt_cart"></span>Constituency</label>
            <dx:ASPxComboBox ID="ddlConstituency" runat="server" CssClass="form-control" TextFormatString="{1}" ClientInstanceName="ddlConstituency">
                <Columns>
                    <dx:ListBoxColumn FieldName="Code" Caption="Code" Width="25px" />
                    <dx:ListBoxColumn FieldName="Name" Caption="Name" Width="75px" />
                </Columns>
            </dx:ASPxComboBox>
        </div>
        <div class="col-md-2">
            <label><span class="fa fa-caret-right rgt_cart"></span>Status</label>
            <dx:ASPxComboBox ID="ddlSchemeStatus" runat="server" CssClass="form-control" ClientInstanceName="ddlSchemeStatus">
                <Items>
                    <dx:ListEditItem Text="All" Value="0" Selected="true" />
                    <dx:ListEditItem Text="Parent" Value="1" />
                    <dx:ListEditItem Text="Child" Value="2" />
                </Items>
            </dx:ASPxComboBox>
        </div>
        <div class="col-md-2">
            <label><span class="fa fa-caret-right rgt_cart"></span>Fund Type</label>
            <dx:ASPxComboBox ID="ddlFundType" runat="server" ClientInstanceName="ddlFundType" CssClass="form-control">
                <Items>
                    <dx:ListEditItem Value="0" Text="All" Selected="true" />
                    <dx:ListEditItem Value="1" Text="Capital" />
                    <dx:ListEditItem Value="2" Text="Revenue" />
                    <dx:ListEditItem Value="3" Text="Foreign Funding" />
                </Items>
            </dx:ASPxComboBox>
        </div>
    </div>
    <div class="row">
        <div class="col-md-12">
            <input type="button" id="btnYear" class="btn btn-primary" value="Year" style="height: 45px; width: 100px;" />
            &nbsp;<input type="button" id="btnMonth" class="btn btn-default" value="Month" style="height: 45px; width: 100px;" />
            &nbsp;<input type="button" id="btnQuarter" class="btn btn-default" value="Quarter" style="height: 45px; width: 100px;" />
        </div>
    </div>
    <div class="row" style="height: 20px;">
    </div>
    <div class="row">
        <div id="dvYear" class="col-md-2">
            <label><span class="fa fa-caret-right rgt_cart"></span>Year</label>
            <dx:ASPxComboBox ID="ddlYear" runat="server" CssClass="form-control" ClientInstanceName="ddlYear">
            </dx:ASPxComboBox>
        </div>
        <div id="dvMonth" class="col-md-2" style="display: none;">
            <label><span class="fa fa-caret-right rgt_cart"></span>Month</label>
            <dx:ASPxComboBox ID="ddlMonth" runat="server" CssClass="form-control" ClientInstanceName="ddlMonth">
                <Items>
                    <dx:ListEditItem Selected="true" Value="1" Text="January" />
                    <dx:ListEditItem Value="2" Text="Febuary" />
                    <dx:ListEditItem Value="3" Text="March" />
                    <dx:ListEditItem Value="4" Text="April" />
                    <dx:ListEditItem Value="5" Text="May" />
                    <dx:ListEditItem Value="6" Text="June" />
                    <dx:ListEditItem Value="7" Text="July" />
                    <dx:ListEditItem Value="8" Text="August" />
                    <dx:ListEditItem Value="9" Text="September" />
                    <dx:ListEditItem Value="10" Text="October" />
                    <dx:ListEditItem Value="11" Text="November" />
                    <dx:ListEditItem Value="12" Text="December" />
                </Items>
            </dx:ASPxComboBox>
        </div>
        <div id="dvQuarter" class="col-md-2" style="display: none;">
            <label><span class="fa fa-caret-right rgt_cart"></span>Quarter</label>
            <dx:ASPxComboBox ID="ddlQuarter" runat="server" CssClass="form-control" ClientInstanceName="ddlQuarter">
                <Items>
                    <dx:ListEditItem Selected="true" Value="1" Text="1" />
                    <dx:ListEditItem Value="2" Text="2" />
                    <dx:ListEditItem Value="3" Text="3" />
                    <dx:ListEditItem Value="4" Text="4" />
                </Items>
            </dx:ASPxComboBox>
        </div>
        <div class="col-md-6">&nbsp;</div>
    </div>
    <div class="row" style="height: 155px;">
    </div>
    <div class="row">
        <div class="col-md-3">
            <input type="button" class="btn btn-success" value="Generate Report" onclick="GenerateReport()" />
        </div>
        <div class="col-md-9">&nbsp;</div>
    </div>
    <script type="text/javascript">
        var filterMode = 1;

        $(document).ready(function () {
            $("#btnYear").click(function () {
                $("#btnYear")
                    .removeClass('btn btn-default')
                    .removeClass('btn btn-primary')
                    .addClass('btn btn-primary');

                $("#btnMonth")
                    .removeClass('btn btn-primary')
                    .removeClass('btn btn-default')
                    .removeClass('btn btn-primary')
                    .addClass('btn btn-default');

                $("#btnQuarter")
                    .removeClass('btn btn-primary')
                    .removeClass('btn btn-default')
                    .removeClass('btn btn-primary')
                    .addClass('btn btn-default');

                $("#dvYear").show();
                $("#dvMonth").hide();
                $("#dvQuarter").hide();

                filterMode = 1;
            });
            $("#btnMonth").click(function () {
                $("#btnMonth")
                    .removeClass('btn btn-default')
                    .removeClass('btn btn-primary')
                    .addClass('btn btn-primary');

                $("#btnYear")
                    .removeClass('btn btn-primary')
                    .removeClass('btn btn-default')
                    .removeClass('btn btn-primary')
                    .addClass('btn btn-default');

                $("#btnQuarter")
                    .removeClass('btn btn-primary')
                    .removeClass('btn btn-default')
                    .removeClass('btn btn-primary')
                    .addClass('btn btn-default');

                $("#dvYear").show();
                $("#dvMonth").show();
                $("#dvQuarter").hide();

                filterMode = 2;
            });
            $("#btnQuarter").click(function () {
                $("#btnQuarter")
                    .removeClass('btn btn-default')
                    .removeClass('btn btn-primary')
                    .addClass('btn btn-primary');

                $("#btnYear")
                    .removeClass('btn btn-primary')
                    .removeClass('btn btn-default')
                    .removeClass('btn btn-primary')
                    .addClass('btn btn-default');

                $("#btnMonth")
                    .removeClass('btn btn-primary')
                    .removeClass('btn btn-default')
                    .removeClass('btn btn-primary')
                    .addClass('btn btn-default');

                $("#dvYear").show();
                $("#dvMonth").hide();
                $("#dvQuarter").show();

                filterMode = 3;
            });
        });

        function LoadConstituency() {
            var id = parseInt(ddlDistrict.GetSelectedItem().value);

            ddlConstituency.ClearItems();
            ddlConstituency.AddItem(new Array("All", "All"), "0");
            ddlConstituency.SetSelectedIndex(0);

            if (id > 0) {
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

        function GenerateReport() {
            window.location = RC.Common.RootURL + "Forms/frmReportViewer.aspx?report=19&DistrictId=" + ddlDistrict.GetSelectedItem().value +
                "&Year=" + ddlYear.GetSelectedItem().value +
                "&Month=" + ddlMonth.GetSelectedItem().value +
                "&Quarter=" + ddlQuarter.GetSelectedItem().value +
                "&FilterMode=" + filterMode +
                "&SchemeStatusId=" + ddlSchemeStatus.GetSelectedItem().value +
                "&ConstituencyId=" + ddlConstituency.GetSelectedItem().value +
                "&FundTypeId=" + ddlFundType.GetSelectedItem().value;

            return false;
        }
    </script>
</asp:Content>

