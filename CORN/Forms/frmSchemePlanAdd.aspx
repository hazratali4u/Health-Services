<%@ Page Title="MPR :: Scheme/ Project Status" Language="C#" MasterPageFile="~/Forms/PageMaster.master"
    AutoEventWireup="true" CodeFile="frmSchemePlanAdd.aspx.cs" Inherits="Forms_frmSchemePlanAdd" %>

<%@ Register Assembly="DevExpress.Web.v16.1, Version=16.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="cphPage">
    <style>
        .dashboard-stat {
            margin-bottom: 0px !important;
        }

            .dashboard-stat.dashboard-stat-v2 .visual {
                margin-bottom: 0px !important;
            }

            .dashboard-stat .visual {
                height: 65px !important;
            }

            .dashboard-stat .details .number {
                padding-top: 0px !important;
            }
    </style>
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
            var rbvalue = $("input[name='<%=rblType.UniqueID%>']:radio:checked").val();
            if (rbvalue == 2) {
                document.getElementById('divFY').style.display = 'none';
            }
            else {
                document.getElementById('divFY').style.display = 'block';
            }

            $("#<%=rblType.ClientID%>").change(function () {
                var rbvalue = $("input[name='<%=rblType.UniqueID%>']:radio:checked").val();
                if (rbvalue == 2) {
                    document.getElementById('divFY').style.display = 'none';
                }
                else {
                    document.getElementById('divFY').style.display = 'block';
                }
            });

            if (document.getElementById('hdnSelectedCostView').value == '1') {
                ShowCapitalView();
            }
            else if (document.getElementById('hdnSelectedCostView').value == '2') {
                ShowRevenueView();
            }

            $("#btnCapital").click(function () {
                ShowCapitalView();
            });

            $("#btnRevenue").click(function () {
                ShowRevenueView();
            });
        }

        function ShowCapitalView() {
            document.getElementById('btnCapital').className = 'btn btn-primary';
            document.getElementById('btnRevenue').className = 'btn btn-default';
            document.getElementById('dvCapital').style.display = 'block';
            document.getElementById('dvRevenue').style.display = 'none';
            document.getElementById('hdnSelectedCostView').value = '1';
        }

        function ShowRevenueView() {
            document.getElementById('btnRevenue').className = 'btn btn-primary';
            document.getElementById('btnCapital').className = 'btn btn-default';
            document.getElementById('dvRevenue').style.display = 'block';
            document.getElementById('dvCapital').style.display = 'none';
            document.getElementById('hdnSelectedCostView').value = '2';
        }

    </script>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div class="row">
                <div class="col-md-6">
                    <label id="lblInstitue"><span class="fa fa-caret-right rgt_cart"></span>Scheme Name</label>&nbsp;*
                    <dx:ASPxComboBox ID="ddlScheme" runat="server" ClientInstanceName="ddlCTScheme" CssClass="form-control" TextFormatString="{0}">
                        <Columns>
                            <dx:ListBoxColumn FieldName="strSchemeName" Caption="Scheme Name" Width="40%" />
                            <dx:ListBoxColumn FieldName="DISTRIBUTOR_NAME" Caption="Spending Unit" Width="30%" />
                            <dx:ListBoxColumn FieldName="ACCOUNT_NAME" Caption="Func. Class" Width="30%" />
                        </Columns>
                        <ClientSideEvents SelectedIndexChanged="function(s, e) { SetFinancialYear(s); }" />
                    </dx:ASPxComboBox>
                </div>
                <div class="col-md-2">
                    <label id="lblProposedDate"><span class="fa fa-caret-right rgt_cart"></span>Proposed Date</label>&nbsp;*
                    <asp:TextBox ID="txtProposedDate" runat="server" CssClass="form-control" MaxLength="10" onkeyup="BlockStartDateKeyPress()"></asp:TextBox>
                </div>
                <div class="col-md-1" style="margin-top: 22px">
                    <label>&nbsp;</label>
                    <asp:ImageButton ID="ibtnProposedDate" runat="server" Width="30px" ImageUrl="~/App_Themes/Granite/Images/date.gif" />
                    <cc1:CalendarExtender ID="CEtProposedDate" runat="server" Format="dd-MMM-yyyy" PopupButtonID="ibtnProposedDate"
                        TargetControlID="txtProposedDate" OnClientShown="calendarShown"></cc1:CalendarExtender>
                </div>
                <div class="col-md-3"></div>
            </div>
            <div class="row" style="display: none;">
                <div class="col-md-3">
                    <label id="lblFunctional"><span class="fa fa-caret-right rgt_cart"></span>Functional Classification</label>
                    <dx:ASPxComboBox ID="ddlFunctional" runat="server" CssClass="form-control" TextFormatString="{1}">
                        <Columns>
                            <dx:ListBoxColumn FieldName="ACCOUNT_CODE" Caption="Code" Width="40px" />
                            <dx:ListBoxColumn FieldName="ACCOUNT_NAME" Caption="Name" Width="20px" />
                        </Columns>
                    </dx:ASPxComboBox>
                </div>
                <div class="col-md-1">
                </div>
                <div class="col-md-3">
                    <label id="lblUser"><span class="fa fa-caret-right rgt_cart"></span>Proposed By</label>
                    <dx:ASPxComboBox ID="ddlEmployee" runat="server" CssClass="form-control" TextFormatString="{1}">
                        <Columns>
                            <dx:ListBoxColumn FieldName="USER_CODE" Caption="Code" Width="20px" />
                            <dx:ListBoxColumn FieldName="USER_NAME" Caption="Name" Width="40px" />
                            <dx:ListBoxColumn FieldName="Designation" Caption="Designation" Width="40px" />
                        </Columns>
                    </dx:ASPxComboBox>
                </div>
            </div>
            <div class="row" style="display: none;">
                <div class="col-md-10">
                    <label id="lblRemarks"><span class="fa fa-caret-right rgt_cart"></span>Remarks</label>
                    <asp:TextBox ID="txtRemarks" runat="server" CssClass="form-control" TextMode="MultiLine" Height="60"></asp:TextBox>
                </div>
            </div>
            <div class="row" style="display: none;">
                <div class="col-md-12">
                    <asp:RadioButtonList ID="rblType" runat="server" RepeatDirection="Horizontal" Width="40%">
                        <asp:ListItem Value="1" Selected="True" Text="Financial Year Wise"></asp:ListItem>
                    </asp:RadioButtonList>
                </div>
            </div>
            <div class="row" style="height: 20px;">
            </div>
            <div class="row">
                <div class="col-md-2" id="divFY">
                </div>
                <div class="col-md-2">
                </div>
            </div>
            <div class="row">
                <div class="col-md-12">
                    <input type="button" id="btnCapital" class="btn btn-primary" value="Capital" style="height: 45px; width: 100px;" />
                    &nbsp;<input type="button" id="btnRevenue" class="btn btn-default" value="Revenue" style="height: 45px; width: 100px;" />
                </div>
            </div>
            <div class="row" style="height: 20px;">
            </div>
            <div id="dvCapital">
                <div class="emp-table">
                    <asp:Panel ID="pnlCapital" runat="server" GroupingText="Proposed / Project Capital">
                        <div class="row">
                            <div class="col-md-3">
                                <label id="lblFinancialYear"><span class="fa fa-caret-right rgt_cart"></span>Financial Year</label>&nbsp;*
                            <dx:ASPxComboBox ID="ddlFY" runat="server" AutoPostBack="true" ClientInstanceName="ddlCTFY" CssClass="form-control" TextFormatString="{1}" OnSelectedIndexChanged="ddlFY_SelectedIndexChanged">
                                <Columns>
                                    <dx:ListBoxColumn FieldName="Id" Caption="Code" Width="25%" />
                                    <dx:ListBoxColumn FieldName="YearName" Caption="Name" Width="75%" />
                                </Columns>
                            </dx:ASPxComboBox>
                            </div>
                            <div class="col-md-3">
                                <div class="dashboard-stat dashboard-stat-v2 red">
                                    <div class="visual">
                                    </div>
                                    <div class="details">
                                        <div class="number">
                                            <span>Capital</span>
                                        </div>
                                        <div id="dvFYCapitalTotalAmount" runat="server" class="desc">Rs 0.00</div>
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-6"></div>
                        </div>
                        <div class="row">
                            <div class="col-md-5">
                                <label id="lblCOA"><span class="fa fa-caret-right rgt_cart"></span>Object Code</label>&nbsp;*
                            <dx:ASPxComboBox ID="ddlCOA" runat="server" CssClass="form-control" TextFormatString="{0} ({1})">
                                <Columns>
                                    <dx:ListBoxColumn FieldName="ACCOUNT_CODE" Caption="Code" Width="20%" />
                                    <dx:ListBoxColumn FieldName="ACCOUNT_NAME" Caption="Name" Width="80%" />
                                </Columns>
                            </dx:ASPxComboBox>
                            </div>
                            <div class="col-md-2">
                                <label id="lblCapital"><span class="fa fa-caret-right rgt_cart"></span>Capital</label>&nbsp;*
                            <asp:TextBox ID="txtCapital" runat="server" CssClass="form-control">
                            </asp:TextBox>
                                <cc1:FilteredTextBoxExtender runat="server" ID="FilteredTextBoxExtender1" TargetControlID="txtCapital" ValidChars="0987654321."></cc1:FilteredTextBoxExtender>
                            </div>
                            <div class="col-md-4">
                                <label id="lblDescription"><span class="fa fa-caret-right rgt_cart"></span>Description</label>
                                <asp:TextBox ID="txtDescription" runat="server" CssClass="form-control">
                                </asp:TextBox>
                            </div>
                            <div class="col-md-1">
                                <br />
                                <asp:Button ID="btnAdd" runat="server" CssClass="btn btn-success" Text="Add" OnClick="btnAdd_Click" Style="margin-top: 4px;" />
                            </div>
                        </div>
                    </asp:Panel>
                    <div class="row" style="height: 20px;">
                    </div>
                    <asp:Panel ID="pnlGrid" runat="server" Height="150" Width="100%" ScrollBars="Vertical">
                        <asp:GridView ID="gvCost" runat="server" CssClass="table table-striped table-bordered table-hover table-condensed cf"
                            HorizontalAlign="Center" AutoGenerateColumns="False" EmptyDataText="No Record exist" OnRowDeleting="gvCost_RowDeleting"
                            OnRowEditing="gvCost_RowEditing" ShowFooter="true" OnRowDataBound="gvCost_RowDataBound">
                            <Columns>
                                <asp:TemplateField HeaderText="intFYID" Visible="false">
                                    <ItemTemplate>
                                        <asp:Label ID="lblintFYID" runat="server" Text='<%#Eval("intFYID")%>' />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="intAccountHeadID" Visible="false">
                                    <ItemTemplate>
                                        <asp:Label ID="lblintAccountHeadID" runat="server" Text='<%#Eval("intAccountHeadID")%>' />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Financial Year">
                                    <ItemTemplate><%#Eval("FYName")%></ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Object Code">
                                    <ItemTemplate><%#Eval("COAName")%></ItemTemplate>
                                    <FooterTemplate>
                                        <div style="padding: 5px; text-align: right;">
                                            Total
                                        </div>
                                    </FooterTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Capital" HeaderStyle-HorizontalAlign="Center">
                                    <ItemTemplate>
                                        <asp:Label ID="lbldecCostCapital" runat="server" Text='<%# Convert.ToInt64(Eval("decCostCapital")).ToString("#,##0") %>' />
                                    </ItemTemplate>
                                    <FooterTemplate>
                                        <div style="padding: 5px">
                                            <asp:Label ID="lbldecCostCapitalTotal" runat="server" />
                                        </div>
                                    </FooterTemplate>
                                    <HeaderStyle HorizontalAlign="Center" />
                                    <ItemStyle HorizontalAlign="Center" />
                                    <FooterStyle HorizontalAlign="Center" />
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Description" Visible="false">
                                    <ItemTemplate>
                                        <asp:Label ID="lblstrDescription" runat="server" Text='<%#Eval("strDescription")%>' />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:LinkButton ID="btnEdit" runat="server" CommandName="Edit" ToolTip="Edit" class="fa fa-pencil">
                                        </asp:LinkButton>
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Center" Width="5%" />
                                </asp:TemplateField>
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:LinkButton ID="btnDelete" runat="server" CommandName="Delete" OnClientClick="javascript:return confirm('Are you sure you want to Delete?');return false;"
                                            CssClass=" fa fa-trash-o"></asp:LinkButton>
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Center" Width="50px" />
                                </asp:TemplateField>
                            </Columns>
                            <HeaderStyle CssClass="cf head"></HeaderStyle>
                            <PagerSettings PageButtonCount="10" NextPageText=">" PreviousPageText="<" />
                            <PagerStyle CssClass="GridPager" HorizontalAlign="Right" />
                        </asp:GridView>
                    </asp:Panel>
                </div>
            </div>
            <div id="dvRevenue" style="display: none;">
                <div class="emp-table">
                    <asp:Panel ID="pnlRevenue" runat="server" GroupingText="Proposed / Project Revenue">
                        <div class="row">
                            <div class="col-md-3">
                                <label id="lblRFinancialYear"><span class="fa fa-caret-right rgt_cart"></span>Financial Year</label>&nbsp;*
                            <dx:ASPxComboBox ID="ddlRFY" runat="server" AutoPostBack="true" ClientInstanceName="ddlCTRFY" CssClass="form-control" TextFormatString="{1}" OnSelectedIndexChanged="ddlRFY_SelectedIndexChanged">
                                <Columns>
                                    <dx:ListBoxColumn FieldName="Id" Caption="Code" Width="25%" />
                                    <dx:ListBoxColumn FieldName="YearName" Caption="Name" Width="75%" />
                                </Columns>
                            </dx:ASPxComboBox>
                            </div>
                            <div class="col-md-3">
                                <div class="dashboard-stat dashboard-stat-v2 red">
                                    <div class="visual">
                                    </div>
                                    <div class="details">
                                        <div class="number">
                                            <span>Revenue</span>
                                        </div>
                                        <div id="dvFYRevenueTotalAmount" runat="server" class="desc">Rs 0.00</div>
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-6"></div>
                        </div>
                        <div class="row">
                            <div class="col-md-5">
                                <label id="lblRCOA"><span class="fa fa-caret-right rgt_cart"></span>Object Code</label>&nbsp;*
                            <dx:ASPxComboBox ID="ddlRCOA" runat="server" CssClass="form-control" TextFormatString="{0} ({1})">
                                <Columns>
                                    <dx:ListBoxColumn FieldName="ACCOUNT_CODE" Caption="Code" Width="20%" />
                                    <dx:ListBoxColumn FieldName="ACCOUNT_NAME" Caption="Name" Width="80%" />
                                </Columns>
                            </dx:ASPxComboBox>
                            </div>
                            <div class="col-md-2">
                                <label id="lblRevenue"><span class="fa fa-caret-right rgt_cart"></span>Revenue</label>&nbsp;*
                            <asp:TextBox ID="txtRevenue" runat="server" CssClass="form-control">
                            </asp:TextBox>
                                <cc1:FilteredTextBoxExtender runat="server" ID="FilteredTextBoxExtender2" TargetControlID="txtRevenue" ValidChars="0987654321."></cc1:FilteredTextBoxExtender>
                            </div>
                            <div class="col-md-4">
                                <label id="lblRDescription"><span class="fa fa-caret-right rgt_cart"></span>Description</label>
                                <asp:TextBox ID="txtRDescription" runat="server" CssClass="form-control">
                                </asp:TextBox>
                            </div>
                            <div class="col-md-1">
                                <br />
                                <asp:Button ID="btnRAdd" runat="server" CssClass="btn btn-success" Text="Add" OnClick="btnRAdd_Click" Style="margin-top: 4px;" />
                            </div>
                        </div>
                    </asp:Panel>
                    <div class="row" style="height: 20px;">
                    </div>
                    <asp:Panel ID="pnlRGrid" runat="server" Height="150" Width="100%" ScrollBars="Vertical">
                        <asp:GridView ID="gvRCost" runat="server" CssClass="table table-striped table-bordered table-hover table-condensed cf"
                            HorizontalAlign="Center" AutoGenerateColumns="False" EmptyDataText="No Record exist" OnRowDeleting="gvRCost_RowDeleting"
                            OnRowEditing="gvRCost_RowEditing" ShowFooter="true" OnRowDataBound="gvRCost_RowDataBound">
                            <Columns>
                                <asp:TemplateField HeaderText="intFYID" Visible="false">
                                    <ItemTemplate>
                                        <asp:Label ID="lblintFYID" runat="server" Text='<%#Eval("intFYID")%>' />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="intAccountHeadID" Visible="false">
                                    <ItemTemplate>
                                        <asp:Label ID="lblintAccountHeadID" runat="server" Text='<%#Eval("intAccountHeadID")%>' />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Financial Year">
                                    <ItemTemplate><%#Eval("FYName")%></ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Object Code">
                                    <ItemTemplate><%#Eval("COAName")%></ItemTemplate>
                                    <FooterTemplate>
                                        <div style="padding: 5px; text-align: right;">
                                            Total
                                        </div>
                                    </FooterTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Revenue" HeaderStyle-HorizontalAlign="Center">
                                    <ItemTemplate>
                                        <asp:Label ID="lbldecCostRevenue" runat="server" Text='<%# Convert.ToInt64(Eval("decCostRevenue")).ToString("#,##0") %>' />
                                    </ItemTemplate>
                                    <FooterTemplate>
                                        <div style="padding: 5px">
                                            <asp:Label ID="lbldecCostRevenueTotal" runat="server" />
                                        </div>
                                    </FooterTemplate>
                                    <HeaderStyle HorizontalAlign="Center" />
                                    <ItemStyle HorizontalAlign="Center" />
                                    <FooterStyle HorizontalAlign="Center" />
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Description" Visible="false">
                                    <ItemTemplate>
                                        <asp:Label ID="lblstrDescription" runat="server" Text='<%#Eval("strDescription")%>' />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:LinkButton ID="btnEdit" runat="server" CommandName="Edit" ToolTip="Edit" class="fa fa-pencil">
                                        </asp:LinkButton>
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Center" Width="5%" />
                                </asp:TemplateField>
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:LinkButton ID="btnDelete" runat="server" CommandName="Delete" OnClientClick="javascript:return confirm('Are you sure you want to Delete?');return false;"
                                            CssClass=" fa fa-trash-o"></asp:LinkButton>
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Center" Width="50px" />
                                </asp:TemplateField>
                            </Columns>
                            <HeaderStyle CssClass="cf head"></HeaderStyle>
                            <PagerSettings PageButtonCount="10" NextPageText=">" PreviousPageText="<" />
                            <PagerStyle CssClass="GridPager" HorizontalAlign="Right" />
                        </asp:GridView>
                    </asp:Panel>
                </div>
            </div>
            <asp:Button ID="btnSave" runat="server" CssClass="btn btn-success" OnClick="btnSave_Click" Text="Save" />
            <asp:Button ID="btnCancel" runat="server" CssClass="btn btn-danger" onblur="Change(this, event)"
                OnClick="btnCancel_Click" onfocus="Change(this, event)" Text="Cancel" />
            <asp:HiddenField ID="hdnSelectedCostView" runat="server" ClientIDMode="Static" Value="1" />
        </ContentTemplate>
    </asp:UpdatePanel>
    <script type="text/javascript">
        function SetFinancialYear() {
            $.post(RC.Common.RootURL + "Handler/FinancialYearHandler.ashx",
            {
                method: "FinancialYearGetSchemeId",
                SchemeId: ddlCTScheme.GetSelectedItem().value,
                SchemeFetchMode: 1
            },
            function (response) {
                switch (response.Status) {
                    case RC.Common.ResponseStatus.SUCCESS:
                        ddlCTFY.ClearItems();
                        ddlCTRFY.ClearItems();

                        if (response.Data != null && response.Data != undefined && response.Data.length > 0) {
                            $(response.Data).each(function (index, item) {
                                ddlCTFY.AddItem(new Array(item.Id.toString(), item.YearName), item.Id.toString());
                                ddlCTRFY.AddItem(new Array(item.Id.toString(), item.YearName), item.Id.toString());
                            });

                            ddlCTFY.SetSelectedIndex(0);
                            ddlCTRFY.SetSelectedIndex(0);
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
