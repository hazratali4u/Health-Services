<%@ Page Title="MPR :: Expense Booking Comment" Language="C#" MasterPageFile="~/Forms/PageMaster.master"
    AutoEventWireup="true" CodeFile="frmExpesneBookingComm.aspx.cs" Inherits="Forms_frmExpesneBookingComm" %>

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
        function Check_Click(objRef) {
            var row = objRef.parentNode.parentNode;
            var GridView = row.parentNode;
            var inputList = GridView.getElementsByTagName("input");
            for (var i = 0; i < inputList.length; i++) {
                var headerCheckBox = inputList[0];
                var checked = true;
                if (inputList[i].type == "checkbox" && inputList[i] != headerCheckBox) {
                    if (!inputList[i].checked) {
                        checked = false;
                        break;
                    }
                }
            }

            headerCheckBox.checked = checked;
        }

        function checkAll(objRef) {
            var GridView = objRef.parentNode.parentNode.parentNode;
            var inputList = GridView.getElementsByTagName("input");
            for (var i = 0; i < inputList.length; i++) {
                var row = inputList[i].parentNode.parentNode;
                if (inputList[i].type == "checkbox" && objRef != inputList[i]) {
                    if (objRef.checked) {
                        inputList[i].checked = true;
                    }
                    else {
                        inputList[i].checked = false;
                    }
                }
            }
        }
    </script>
    <div class="main-contents">
        <div class="container employee-infomation">

            <div class="row top">
                <asp:Panel ID="Panel3" runat="server" DefaultButton="btnsearch">
                    <div class="col-md-4">
                        <div class="search">
                            <asp:TextBox ID="txtSearch" runat="server" placeholder="Search" CssClass="form-control"
                                TabIndex="0"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-md-2" style="margin-left: -60px;">
                        <asp:LinkButton ID="btnsearch" OnClick="btnFilter_Click" runat="server" Text="Search"
                            CssClass="btn btn-success"><i class="fa fa-search"  style="font-size:20px;"></i></asp:LinkButton>
                    </div>
                    <asp:LinkButton ID="btndummy" runat="server" UseSubmitBehavior="false" />
                </asp:Panel>
                <div class="col-md-offset-5 col-md-3 ">
                    <div class="btnlist pull-right">
                        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                            <ContentTemplate>
                                <asp:LinkButton CssClass="btn btn-warning" runat="server" ID="btnAdd" Text="Add"
                                    OnClick="btnAdd_Click">
                               <span class="fa fa-plus-circle"></span>Add
                                </asp:LinkButton>
                                <asp:LinkButton class="btn btn-success" OnClick="btnActive_Click" ID="btnActive" runat="server"
                                    OnClientClick="javascript:return confirm('Are you sure you want to perform this action?');return false;">
                                    <span class="fa fa-check"></span>Active</asp:LinkButton>
                                <!-- POP UP MODEL-->
                                <cc1:ModalPopupExtender ID="mPopUpLocation" runat="server" PopupControlID="pnlParameters"
                                    TargetControlID="btnAdd" BehaviorID="ModelPopup" BackgroundCssClass="modal-background"
                                    CancelControlID="btnClose">
                                </cc1:ModalPopupExtender>
                                <asp:Panel ID="pnlParameters" runat="server" Style="display: none;margin:auto;" ScrollBars="Auto">
                                    <div class="modal-dialog" style="width:80%;margin: auto;">
                                        <div class="modal-content">
                                            <div class="modal-header">
                                                <button type="button" id="btnClose" runat="server" class="close">
                                                    <span>&times;</span><span class="sr-only">Close</span></button>
                                                <h1 class="modal-title" id="myModalLabel">
                                                    <span class="fa fa-clock-o"></span>Add New Expense Booking</h1>
                                            </div>
                                            <div class="modal-body">
                                                <div class="row">
                                                    <div class="col-md-10">
                                                        <asp:Label ID="lblErrorMsg" runat="server" ForeColor="Red" Font-Bold="True"></asp:Label>
                                                    </div>
                                                </div>
                                                <div class="row">
                                                    <div class="col-md-4">
                                                        <label id="lblCode"><span class="fa fa-caret-right rgt_cart"></span>Expense Voucher Code</label>
                                                        <asp:TextBox ID="txtCode" runat="server" CssClass="form-control"
                                                            Enabled="false">
                                                        </asp:TextBox>
                                                    </div>
                                                </div>
                                                <div class="row">
                                                    <div class="col-md-4">
                                                        <label id="lblInstitue"><span class="fa fa-caret-right rgt_cart"></span>Scheme Name</label>
                                                        <dx:ASPxComboBox ID="ddlScheme" runat="server" CssClass="form-control">
                                                        </dx:ASPxComboBox>
                                                    </div>
                                                    <div class="col-md-4">
                                                        <label id="lblLO"><span class="fa fa-caret-right rgt_cart"></span>LO</label>
                                                        <asp:TextBox ID="txtLO" runat="server" CssClass="form-control" placeholder="Code Capital"></asp:TextBox>
                                                    </div>
                                                    <div class="col-md-4">
                                                        <label id="lblGS"><span class="fa fa-caret-right rgt_cart"></span>GS</label>
                                                        <asp:TextBox ID="txtGS" runat="server" CssClass="form-control" placeholder="Code Capital"></asp:TextBox>
                                                    </div>
                                                </div>
                                                <div class="row">
                                                    <div class="col-md-4">
                                                        <label id="lblStartDate"><span class="fa fa-caret-right rgt_cart"></span>Comment Date</label>
                                                        <table width="100%">
                                                            <tr>
                                                                <td style="width:60%;">
                                                                    <asp:TextBox ID="txtDate" runat="server" CssClass="form-control" MaxLength="10" onkeyup="BlockStartDateKeyPress()"></asp:TextBox>
                                                                </td>
                                                                <td style="width:40%;" valign="top">
                                                                    <asp:ImageButton ID="ibtnDate" runat="server" Width="30px" ImageUrl="~/App_Themes/Granite/Images/date.gif" />
                                                                    <cc1:CalendarExtender ID="CEtDate" runat="server" Format="dd-MMM-yyyy" PopupButtonID="ibtnDate"
                                                                        TargetControlID="txtDate" OnClientShown="calendarShown"></cc1:CalendarExtender>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </div>
                                                    <div class="col-md-4">
                                                        <label id="lblCOA"><span class="fa fa-caret-right rgt_cart"></span>Expense Head</label>
                                                        <dx:ASPxComboBox ID="ddlCOA" runat="server" CssClass="form-control" TextFormatString="{1}">
                                                                <Columns>
                                                                <dx:ListBoxColumn FieldName="ACCOUNT_CODE" Caption="Code" Width="40px" />
                                                                <dx:ListBoxColumn FieldName="ACCOUNT_NAME" Caption="Name" Width="20px" />
                                                            </Columns>
                                                        </dx:ASPxComboBox>
                                                    </div>
                                                    <div class="col-md-4">
                                                        <label id="lblAmount"><span class="fa fa-caret-right rgt_cart"></span>Amount</label>
                                                        <asp:TextBox ID="txtAmount" runat="server" CssClass="form-control"></asp:TextBox>
                                                    </div>
                                                </div>

                                                <div class="row">
                                                    <div class="col-md-4">
                                                        <label>
                                                            <span class="fa fa-caret-right rgt_cart"></span>PO Ref
                                                        </label>
                                                        <asp:TextBox ID="txtPORef" runat="server" CssClass="form-control" ></asp:TextBox>
                                                    </div>
                                                    <div class="col-md-4">
                                                        <label>
                                                            <span class="fa fa-caret-right rgt_cart"></span>Document Ref
                                                        </label>
                                                        <asp:TextBox ID="txtDocRef" runat="server" CssClass="form-control" ></asp:TextBox>
                                                    </div>
                                                    <div class="col-md-4">
                                                        <label>
                                                            <span class="fa fa-caret-right rgt_cart"></span>Cheque Ref
                                                        </label>
                                                        <asp:TextBox ID="txtChequeRef" runat="server" CssClass="form-control" ></asp:TextBox>
                                                    </div>
                                                </div>

                                                <div class="row">
                                                    <div class="col-md-4">
                                                        <label>
                                                            <span class="fa fa-caret-right rgt_cart"></span>Payee/Vendor
                                                        </label>
                                                        <asp:TextBox ID="txtVender" runat="server" CssClass="form-control" ></asp:TextBox>
                                                    </div>
                                                    <div class="col-md-4">
                                                        <label>
                                                            <span class="fa fa-caret-right rgt_cart"></span>Tran. Particulars
                                                        </label>
                                                        <asp:TextBox ID="txtParticulars" runat="server" CssClass="form-control" ></asp:TextBox>
                                                    </div>
                                                    <div class="col-md-4">
                                                        <label>
                                                            <span class="fa fa-caret-right rgt_cart"></span>Status
                                                        </label>
                                                        <dx:ASPxComboBox ID="ddlSatus" runat="server" CssClass="form-control">
                                                            <Items>
                                                                <dx:ListEditItem Value="1" Text="Posted"/>
                                                                <dx:ListEditItem Value="2" Text="Unposted" Selected="true" />
                                                            </Items>
                                                        </dx:ASPxComboBox>
                                                    </div>
                                                </div>

                                                <div class="rows">
                                                    <div class="col-md-8">
                                                        <label id="lblRemarks"><span class="fa fa-caret-right rgt_cart"></span>Comments</label>
                                                        <asp:TextBox ID="txtRemarks" runat="server" CssClass="form-control" TextMode="MultiLine" Height="60"></asp:TextBox>
                                                    </div>
                                                    <div class="col-md-4">
                                                        <label><span class="fa fa-caret-right rgt_cart"></span>Commented By</label>
                                                        <dx:ASPxComboBox ID="ddlUser" runat="server" CssClass="form-control">
                                                            <Items>
                                                            </Items>
                                                        </dx:ASPxComboBox>
                                                    </div>
                                                </div>

                                            </div>
                                            <div class="modal-footer">
                                                <asp:Button ID="btnSave" runat="server" CssClass="btn btn-success" onblur="Change(this, event)"
                                                    OnClick="btnSave_Click" onfocus="Change(this, event)" Text="Save" />
                                                <asp:Button ID="btnCancel" runat="server" CssClass="btn btn-danger" onblur="Change(this, event)"
                                                    OnClick="btnCancel_Click" onfocus="Change(this, event)" Text="Cancel" />
                                                <a href="#" style="display: none; visibility: hidden;" onclick="return false" id="dummyLink1"
                                                    runat="server">dummy</a>
                                            </div>
                                        </div>
                                    </div>
                                </asp:Panel>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </div>
                </div>
            </div>
            <div class="row center">
                <div class="col-md-12">
                    <div class="emp-table">
                        <asp:UpdatePanel ID="UpdatePanelDetail" runat="server">
                            <ContentTemplate>
                                <asp:GridView ID="GridShift" runat="server" CssClass="table table-striped table-bordered table-hover table-condensed cf"
                                    HorizontalAlign="Center" OnRowEditing="GridShift_RowEditing" AutoGenerateColumns="False"
                                    EmptyDataText="No Record exist" OnPageIndexChanging="Grid_users_PageIndexChanging" PageSize="8"
                                    AllowPaging="True">
                                    <Columns>
                                        <asp:TemplateField>
                                            <HeaderTemplate>
                                                <asp:CheckBox ID="checkAll" runat="server" onclick="checkAll(this);" />
                                            </HeaderTemplate>
                                            <ItemTemplate>
                                                <asp:CheckBox ID="ChbIsAssigned" runat="server" onclick="Check_Click(this)" />
                                            </ItemTemplate>

                                            <HeaderStyle Width="5%" HorizontalAlign="Center" />
                                            <ItemStyle Width="5%" HorizontalAlign="Center" />
                                        </asp:TemplateField>
                                        <asp:BoundField DataField="SHIFT_ID" HeaderText="SHIFT_ID" ReadOnly="true">
                                            <HeaderStyle CssClass="HidePanel"></HeaderStyle>
                                            <ItemStyle CssClass="HidePanel"></ItemStyle>
                                        </asp:BoundField>
                                        <asp:BoundField DataField="DISTRIBUTOR_NAME" HeaderText="Location" ReadOnly="true">
                                            <HeaderStyle CssClass="HidePanel"></HeaderStyle>
                                            <ItemStyle CssClass="HidePanel"></ItemStyle>
                                        </asp:BoundField>
                                        <asp:BoundField DataField="SHIFT_NAME" HeaderText="Shift Name" ReadOnly="true"></asp:BoundField>
                                        <asp:BoundField DataField="SHIFT_FROM" HeaderText="Time From" ReadOnly="true"></asp:BoundField>
                                        <asp:BoundField DataField="SHIFT_TO" HeaderText="Time To" ReadOnly="true"></asp:BoundField>
                                        <asp:BoundField DataField="LOCATION_ID" ReadOnly="true">
                                            <HeaderStyle CssClass="HidePanel"></HeaderStyle>
                                            <ItemStyle CssClass="HidePanel"></ItemStyle>
                                        </asp:BoundField>
                                        <asp:BoundField DataField="IS_ACTIVE" HeaderText="Status" ReadOnly="true">
                                            <ItemStyle Width="8%" />

                                        </asp:BoundField>

                                        <asp:TemplateField>
                                            <ItemTemplate>
                                                <asp:LinkButton ID="btnEdit" runat="server" CommandName="Edit" ToolTip="Edit" class="fa fa-pencil">
                                                </asp:LinkButton>
                                            </ItemTemplate>
                                            <ItemStyle HorizontalAlign="Center" Width="5%" />
                                        </asp:TemplateField>
                                    </Columns>
                                    <HeaderStyle CssClass="cf head"></HeaderStyle>
                                    <PagerSettings PageButtonCount="10" NextPageText=">" PreviousPageText="<" />
                                    <PagerStyle CssClass="GridPager" HorizontalAlign="Right" />
                                </asp:GridView>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>


