<%@ Page Title="Object wise Summary" Language="C#" MasterPageFile="~/Forms/PageMaster.master"
    AutoEventWireup="true" CodeFile="rptOjectSummary.aspx.cs" Inherits="Forms_rptOjectSummary" %>

<%@ Register Assembly="DevExpress.Web.v16.1, Version=16.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="cphPage">
    <div class="row">
        <div class="col-md-12">
            <input type="button" id="btnInstitue" class="btn btn-primary" value="Institue" style="height: 45px; width: 100px;" />
            &nbsp;<input type="button" id="btnScheme" class="btn btn-default" value="Scheme" style="height: 45px; width: 100px;" />
        </div>
    </div>
    <div class="row" style="height: 20px;">
    </div>
    <div class="row">
        <div id="dvInstitue" class="col-md-5">
            <label id="lblInstitue"><span class="fa fa-caret-right rgt_cart"></span>Spending Unit</label>
            <dx:ASPxComboBox ID="ddlInstitute" runat="server" CssClass="form-control" TextFormatString="{0}">
                <Columns>
                    <dx:ListBoxColumn FieldName="DISTRIBUTOR_NAME" Caption="Name" Width="40px" />
                    <dx:ListBoxColumn FieldName="TYPENAME" Caption="Type" Width="20px" />
                    <dx:ListBoxColumn FieldName="District" Caption="District" Width="20px" />
                    <dx:ListBoxColumn FieldName="Tehsil" Caption="Tehsil" Width="20px" />
                    <dx:ListBoxColumn FieldName="Constituency" Caption="Constituency" Width="20px" />
                </Columns>
            </dx:ASPxComboBox>
        </div>
        <div id="dvScheme" class="col-md-5" style="display: none;">
            <label><span class="fa fa-caret-right rgt_cart"></span>Scheme Name</label>
            <dx:ASPxComboBox ID="ddlScheme" runat="server" ClientInstanceName="ddlCTScheme" CssClass="form-control" TextFormatString="{0}">
                <Columns>
                    <dx:ListBoxColumn FieldName="strSchemeName" Caption="Scheme Name" Width="40px" />
                    <dx:ListBoxColumn FieldName="DISTRIBUTOR_NAME" Caption="Spending Unit" Width="20px" />
                    <dx:ListBoxColumn FieldName="ACCOUNT_NAME" Caption="Func. Class" Width="20px" />
                </Columns>
            </dx:ASPxComboBox>
        </div>
        <div class="col-md-2">
            <label id="lblFinancialYear"><span class="fa fa-caret-right rgt_cart"></span>Financial Year</label>
            <dx:ASPxComboBox ID="ddlFY" runat="server" ClientInstanceName="ddlCTSchemeFY" CssClass="form-control" TextFormatString="{1}">
                <Columns>
                    <dx:ListBoxColumn FieldName="Id" Caption="Code" Width="10px" />
                    <dx:ListBoxColumn FieldName="YearName" Caption="Name" Width="40px" />
                </Columns>
            </dx:ASPxComboBox>
        </div>
        <div class="col-md-3">
            <label id="lblChartofAccount"><span class="fa fa-caret-right rgt_cart"></span>Chart of Account</label>
            <dx:ASPxComboBox IncrementalFilteringMode="None" ID="ddlCAType" runat="server" CssClass="form-control">
                <Items>
                    <dx:ListEditItem Value="92" Text="Major Code" />
                    <dx:ListEditItem Value="93" Text="Minor Code" />
                    <dx:ListEditItem Value="94" Text="Detailed Code" />
                </Items>
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
    </div>
    <div class="row" style="display: none;">
        <div class="col-md-5">
            <label id="lblMajorChartofAccount"><span class="fa fa-caret-right rgt_cart"></span>Major - Chart of Account</label>
            <dx:ASPxComboBox ID="ddlMajorCA" runat="server" ClientInstanceName="ddlCMajorCA" CssClass="form-control" TextFormatString="{0} ({1})">
                <ClientSideEvents SelectedIndexChanged="function onComboBoxSelectedIndexChanged(s, e) { SetMinorCOA(s); }" />
                <Columns>
                    <dx:ListBoxColumn FieldName="ACCOUNT_CODE" Caption="Code" Width="50px" />
                    <dx:ListBoxColumn FieldName="ACCOUNT_NAME" Caption="Name" Width="250px" />
                </Columns>
            </dx:ASPxComboBox>
        </div>
        <div class="col-md-5">
            <label id="lblMinorChartofAccount"><span class="fa fa-caret-right rgt_cart"></span>Minor - Chart of Account</label>
            <dx:ASPxComboBox ID="ddlMinorCA" runat="server" ClientInstanceName="ddlCMinorCA" CssClass="form-control" TextFormatString="{0} ({1})">
                <Columns>
                    <dx:ListBoxColumn FieldName="ACCOUNT_CODE" Caption="Code" Width="50px" />
                    <dx:ListBoxColumn FieldName="ACCOUNT_NAME" Caption="Name" Width="250px" />
                </Columns>
            </dx:ASPxComboBox>
        </div>
        <div class="col-md-2">&nbsp;</div>
    </div>
    <div class="row" style="height: 155px;">
    </div>
    <div class="row">
        <div class="col-md-3">
            <asp:Button ID="btnGenerateReport" runat="server" CssClass="btn btn-success" Text="Generate Report" OnClick="btnGenerateReport_Click" />
        </div>
    </div>
    <script type="text/javascript">
        $(document).ready(function () {
            $("#btnInstitue").click(function () {
                $("#btnInstitue")
                    .removeClass('btn btn-default')
                    .removeClass('btn btn-primary')
                    .addClass('btn btn-primary');

                $("#btnScheme")
                    .removeClass('btn btn-primary')
                    .removeClass('btn btn-default')
                    .removeClass('btn btn-primary')
                    .addClass('btn btn-default');

                $("#dvInstitue").show();
                $("#dvScheme").hide();

                ddlCTInstitute.SetSelectedIndex(0);
                ddlCTScheme.SetSelectedIndex(0);
            });
            $("#btnScheme").click(function () {
                $("#btnScheme")
                    .removeClass('btn btn-default')
                    .removeClass('btn btn-primary')
                    .addClass('btn btn-primary');

                $("#btnInstitue")
                    .removeClass('btn btn-primary')
                    .removeClass('btn btn-default')
                    .removeClass('btn btn-primary')
                    .addClass('btn btn-default');

                $("#dvScheme").show();
                $("#dvInstitue").hide();

                ddlCTInstitute.SetSelectedIndex(0);
                ddlCTScheme.SetSelectedIndex(0);
            });
        });

        function SetMinorCOA() {
            $.post(RC.Common.RootURL + "Handler/COAHandler.ashx",
            {
                method: "COAGetParentId",
                ParentCOAId: ddlCMajorCA.GetSelectedItem().value
            },
            function (response) {
                switch (response.Status) {
                    case RC.Common.ResponseStatus.SUCCESS:
                        ddlCMinorCA.ClearItems();

                        if (response.Data != null && response.Data != undefined && response.Data.length > 0) {
                            $(response.Data).each(function (index, item) {
                                ddlCMinorCA.AddItem(new Array(item.ACCOUNT_CODE, item.ACCOUNT_NAME), item.ACCOUNT_HEAD_ID.toString());
                            });

                            ddlCMinorCA.SetSelectedIndex(0);
                        }

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
            });
        }
    </script>
</asp:Content>
