<%@ Page Title="MPR :: New Monthly Progress Report" Language="C#" MasterPageFile="~/Forms/PageMaster.master"
    AutoEventWireup="true" CodeFile="frmNewMPR.aspx.cs" Inherits="Forms_frmNewMPR" %>

<%@ Register Assembly="DevExpress.Web.v16.1, Version=16.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="cphPage">
    <div class="row">
        <div class="col-md-12">
            <input type="button" id="btnInstitue" runat="server" clientidmode="Static" class="btn btn-primary" value="Institue" style="height: 45px; width: 100px;" />
            &nbsp;<input type="button" id="btnScheme" class="btn btn-default" value="Scheme" style="height: 45px; width: 100px;" />
        </div>
    </div>
    <div class="row" style="height: 20px;">
    </div>
    <div class="row">
        <div id="dvInstitue" class="col-md-6">
            <span class="fa fa-caret-right rgt_cart"></span><label id="lblInstitue" runat="server" clientidmode="Static">Spending Unit</label>
            <dx:ASPxComboBox ID="ddlInstitute" runat="server" ClientInstanceName="ddlCTInstitute" CssClass="form-control" TextFormatString="{0}">
                <Columns>
                    <dx:ListBoxColumn FieldName="DISTRIBUTOR_NAME" Caption="Name" Width="40px" />
                    <dx:ListBoxColumn FieldName="TYPENAME" Caption="Type" Width="20px" />
                    <dx:ListBoxColumn FieldName="District" Caption="District" Width="20px" />
                    <dx:ListBoxColumn FieldName="Tehsil" Caption="Tehsil" Width="20px" />
                    <dx:ListBoxColumn FieldName="Constituency" Caption="Constituency" Width="20px" />
                </Columns>
            </dx:ASPxComboBox>
        </div>
        <div id="dvScheme" class="col-md-6" style="display: none;">
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
            <label id="lblMonth"><span class="fa fa-caret-right rgt_cart"></span>Month</label>
            <dx:ASPxComboBox ID="ddlMonth" runat="server" CssClass="form-control">
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
        <div class="col-md-2">
            <label id="lblYear"><span class="fa fa-caret-right rgt_cart"></span>Year</label>
            <dx:ASPxComboBox ID="ddlYear" runat="server" CssClass="form-control">
            </dx:ASPxComboBox>
        </div>
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
    </script>
</asp:Content>
