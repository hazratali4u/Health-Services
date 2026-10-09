<%@ Page Title="MPR :: Scheme/ Project Comments" Language="C#" MasterPageFile="~/Forms/PageMaster.master"
    AutoEventWireup="true" CodeFile="frmSchemeComment.aspx.cs" Inherits="Forms_frmSchemeComment" %>

<%@ Register Assembly="DevExpress.Web.ASPxHtmlEditor.v16.1, Version=16.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxHtmlEditor" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.Web.v16.1, Version=16.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="cphPage">
    <script language="JavaScript" type="text/javascript">

        Sys.WebForms.PageRequestManager.getInstance().add_beginRequest(BeginRequestHandler);
        function BeginRequestHandler(sender, args) {
            var oControl = args.get_postBackElement();
            oControl.value = "Wait...";
            oControl.disabled = true;
        }
        function calendarShown(sender, args) {
            sender._popupBehavior._element.style.zIndex = 10005;
        }
        function ValidateForm() {
            var str;
            return true;
        }

        function pageLoad() {
        }

    </script>
    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
        <ContentTemplate>
            <div class="row">
                <div class="col-md-6">
                    <label id="lblInstitue"><span class="fa fa-caret-right rgt_cart"></span>Scheme Name</label>&nbsp;*
                    <dx:ASPxComboBox ID="ddlScheme" runat="server" CssClass="form-control" TextFormatString="{0}"
                        AutoPostBack="true" OnSelectedIndexChanged="ddlScheme_SelectedIndexChanged">
                        <Columns>
                            <dx:ListBoxColumn FieldName="strSchemeName" Caption="Scheme Name" Width="40px" />
                            <dx:ListBoxColumn FieldName="DISTRIBUTOR_NAME" Caption="Spending Unit" Width="20px" />
                            <dx:ListBoxColumn FieldName="ACCOUNT_NAME" Caption="Func. Class" Width="20px" />
                        </Columns>
                    </dx:ASPxComboBox>
                </div>
                <div class="col-md-2">
                    <label id="lblMonth"><span class="fa fa-caret-right rgt_cart"></span>Month</label>&nbsp;*
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
                    <label id="lblYear"><span class="fa fa-caret-right rgt_cart"></span>Year</label>&nbsp;*
                    <dx:ASPxComboBox ID="ddlYear" runat="server" CssClass="form-control">
                    </dx:ASPxComboBox>
                </div>
                <div class="col-md-2">
                </div>
            </div>
            <div class="row">
                <div class="col-md-2">
                    <asp:Button ID="btnLoadComments" runat="server" CssClass="btn btn-success" Text="Load Data" OnClick="btnLoadComments_Click" />
                </div>
                <div class="col-md-10">
                </div>
            </div>
            <div class="row" style="height: 20px;">
            </div>
            <div class="row">
                <div class="col-md-6">
                    <label id="lblComments"><span class="fa fa-caret-right rgt_cart"></span>Comments</label>&nbsp;*
                    <dx:ASPxHtmlEditor ID="txtComments" runat="server" Width="100%" Settings-AllowHtmlView="false" Settings-AllowPreview="false"></dx:ASPxHtmlEditor>
                </div>
                <div class="col-md-6" id="divHOComments" runat="server">
                    <label id="lblHOComments"><span class="fa fa-caret-right rgt_cart"></span>Head Office Comments</label>&nbsp;*
                    <dx:ASPxHtmlEditor ID="txtHOComments" runat="server" Width="100%" Settings-AllowHtmlView="false" Settings-AllowPreview="false"></dx:ASPxHtmlEditor>
                </div>
                <div class="col-md-6"></div>
            </div>
            <div class="row" style="height: 20px;">
            </div>
            <asp:Button ID="btnSave" runat="server" CssClass="btn btn-success" OnClick="btnSave_Click" Text="Save" />
            <asp:Button ID="btnCancel" runat="server" CssClass="btn btn-danger" onblur="Change(this, event)"
                OnClick="btnCancel_Click" onfocus="Change(this, event)" Text="Cancel" />
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
