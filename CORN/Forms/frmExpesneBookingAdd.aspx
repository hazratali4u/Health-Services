<%@ Page Title="MPR :: Expense Booking" Language="C#" MasterPageFile="~/Forms/PageMaster.master"
    AutoEventWireup="true" CodeFile="frmExpesneBookingAdd.aspx.cs" Inherits="Forms_frmExpesneBookingAdd" %>

<%@ Register Assembly="DevExpress.Web.v16.1, Version=16.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content2" ContentPlaceHolderID="cphHeadPage" runat="Server">
    <link href="../css/fine-uploader/fine-uploader-new.min.css"" rel="stylesheet" />
    <script type="text/template" id="qq-template-manual-trigger">
        <div class="qq-uploader-selector qq-uploader" qq-drop-area-text="Drop files here">
            <div class="qq-total-progress-bar-container-selector qq-total-progress-bar-container">
                <div role="progressbar" aria-valuenow="0" aria-valuemin="0" aria-valuemax="100" class="qq-total-progress-bar-selector qq-progress-bar qq-total-progress-bar"></div>
            </div>
            <div class="qq-upload-drop-area-selector qq-upload-drop-area" qq-hide-dropzone>
                <span class="qq-upload-drop-area-text-selector"></span>
            </div>
            <div class="buttons">
                <div class="qq-upload-button-selector qq-upload-button">
                    <div>Select File</div>
                </div>
            </div>
            <span class="qq-drop-processing-selector qq-drop-processing">
                <span>Processing dropped files...</span>
                <span class="qq-drop-processing-spinner-selector qq-drop-processing-spinner"></span>
            </span>
            <ul class="qq-upload-list-selector qq-upload-list" aria-live="polite" aria-relevant="additions removals">
                <li>
                    <div class="qq-progress-bar-container-selector">
                        <div role="progressbar" aria-valuenow="0" aria-valuemin="0" aria-valuemax="100" class="qq-progress-bar-selector qq-progress-bar"></div>
                    </div>
                    <span class="qq-upload-spinner-selector qq-upload-spinner"></span>
                    <img class="qq-thumbnail-selector" qq-max-size="100" qq-server-scale>
                    <span class="qq-upload-file-selector qq-upload-file"></span>
                    <span class="qq-upload-size-selector qq-upload-size"></span>
                    <button type="button" class="qq-btn qq-upload-cancel-selector qq-upload-cancel">Cancel</button>
                    <button type="button" class="qq-btn qq-upload-retry-selector qq-upload-retry">Retry</button>
                    <button type="button" class="qq-btn qq-upload-delete-selector qq-upload-delete">Delete</button>
                    <span role="status" class="qq-upload-status-text-selector qq-upload-status-text"></span>
                </li>
            </ul>

            <dialog class="qq-alert-dialog-selector">
                <div class="qq-dialog-message-selector"></div>
                <div class="qq-dialog-buttons">
                    <button type="button" class="qq-cancel-button-selector">Close</button>
                </div>
            </dialog>

            <dialog class="qq-confirm-dialog-selector">
                <div class="qq-dialog-message-selector"></div>
                <div class="qq-dialog-buttons">
                    <button type="button" class="qq-cancel-button-selector">No</button>
                    <button type="button" class="qq-ok-button-selector">Yes</button>
                </div>
            </dialog>

            <dialog class="qq-prompt-dialog-selector">
                <div class="qq-dialog-message-selector"></div>
                <input type="text">
                <div class="qq-dialog-buttons">
                    <button type="button" class="qq-cancel-button-selector">Cancel</button>
                    <button type="button" class="qq-ok-button-selector">Ok</button>
                </div>
            </dialog>
        </div>
    </script>
    <style rel="stylesheet">
        #trigger-upload {
            color: white;
            background-color: #00ABC7;
            font-size: 14px;
            padding: 7px 20px;
            background-image: none;
        }

        #fine-uploader-manual-trigger .qq-upload-button {
            margin-right: 15px;
        }

        #fine-uploader-manual-trigger .buttons {
            width: 36%;
        }

        #fine-uploader-manual-trigger .qq-uploader .qq-total-progress-bar-container {
            width: 60%;
        }

        .img-wrap {
            position: relative;
            display: inline-block;
            border: 1px red solid;
            font-size: 0;
            margin-bottom: 10px;
        }

            .img-wrap .close {
                position: absolute;
                top: 2px;
                right: 2px;
                z-index: 100;
                background-color: #FFF;
                padding: 5px 2px 2px;
                color: #000;
                font-weight: bold;
                cursor: pointer;
                opacity: .2;
                text-align: center;
                font-size: 22px;
                line-height: 10px;
                border-radius: 50%;
            }

            .img-wrap:hover .close {
                opacity: 1;
            }

        .dashboard-stat .details .number {
            font-size: 32px !important;
            padding-top: 10px !important;
        }

        .dashboard-stat .details .ocnumber {
            font-size: 20px !important;
        }

        .dashboard-stat {
            margin-bottom: 0px !important;
        }

            .dashboard-stat.dashboard-stat-v2 .visual {
                margin-bottom: 5px !important;
            }

            .dashboard-stat .visual {
                height: 65px !important;
            }
    </style>
    <script language="JavaScript" type="text/javascript">
        function calendarShown(sender, args) {
            sender._popupBehavior._element.style.zIndex = 10005;
        }
    </script>
</asp:Content>
<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="cphPage">
    <div id="dvManageSchemeExpenseBooking">
        <div class="row">
            <div class="col-md-12">
                <input type="button" id="btnCommitment" runat="server" clientidmode="Static" class="btn btn-primary" value="Commitment" onclick="RC.ManageSchemeExpenseBooking.SetExpenseBookingTypeView(RC.Common.ExpenseBookingType.COMMITMENT);" style="height: 45px; width: 100px;" />
                &nbsp;<input type="button" id="btnActual" class="btn btn-default" value="Actual" onclick="RC.ManageSchemeExpenseBooking.SetExpenseBookingTypeView(RC.Common.ExpenseBookingType.ACTUAL);" style="height: 45px; width: 100px;" />
            </div>
        </div>
        <div class="row" style="height: 20px;">
        </div>
        <div class="row">
            <div class="col-md-8">
                <label id="lblInstitue"><span class="fa fa-caret-right rgt_cart"></span>Scheme Name</label>&nbsp;*
                <dx:ASPxComboBox ID="ddlScheme" runat="server" ClientInstanceName="ddlScheme" CssClass="form-control" TextFormatString="{0}">
                    <ClientSideEvents SelectedIndexChanged="function onComboBoxSelectedIndexChanged(s, e) {
                       SetCOA(s); RC.ManageSchemeExpenseBooking.PopulateSchemePOReferenceNo(s.GetValue()); }" />
                    <Columns>
                        <dx:ListBoxColumn FieldName="strSchemeName" Caption="Scheme Name" Width="48px" />
                        <dx:ListBoxColumn FieldName="DISTRIBUTOR_NAME" Caption="Spending Unit" Width="20px" />
                        <dx:ListBoxColumn FieldName="ACCOUNT_NAME" Caption="Func. Class" Width="20px" />
                        <dx:ListBoxColumn FieldName="IsForeignFunding" Caption="Foreign Funding" Width="12px" />
                    </Columns>
                </dx:ASPxComboBox>
            </div>
            <div class="col-md-2">
                <label id="lblExpenseDate"><span class="fa fa-caret-right rgt_cart"></span>Expense Date</label>&nbsp;*
                <asp:TextBox ID="txtExpenseDate" runat="server" ClientIDMode="Static" CssClass="form-control" MaxLength="10" onkeyup="BlockStartDateKeyPress()"></asp:TextBox>
            </div>
            <div class="col-md-1" style="margin-top: 22px">
                <asp:ImageButton ID="imgSchemeDate" runat="server" Width="30px" ImageUrl="~/App_Themes/Granite/Images/date.gif" />
                <cc1:CalendarExtender ID="CalendarExtender1" runat="server" Format="dd-MMM-yyyy" PopupButtonID="imgSchemeDate"
                    TargetControlID="txtExpenseDate" OnClientShown="calendarShown"></cc1:CalendarExtender>
            </div>
            <div class="col-md-1"></div>
        </div>
        <div id="dvReference" class="row" runat="server" clientidmode="Static">
            <div class="col-md-4">
                <label id="lblIPayee"><span class="fa fa-caret-right rgt_cart"></span>Payee / Vendor</label>&nbsp;*
                <asp:TextBox ID="txtPayee" runat="server" ClientIDMode="Static" CssClass="form-control">
                </asp:TextBox>
            </div>
            <div class="col-md-4">
                <label id="lblIDocumentReference"><span class="fa fa-caret-right rgt_cart"></span>Document Reference</label>
                <asp:TextBox ID="txtDocumentReference" runat="server" ClientIDMode="Static" CssClass="form-control">
                </asp:TextBox>
            </div>
            <div class="col-md-4"></div>
        </div>
        <div id="dvPOReferenceCommitment" class="row">
            <div class="col-md-3">
                <label><span class="fa fa-caret-right rgt_cart"></span>PO Reference</label>&nbsp;*
                <asp:TextBox ID="txtPOReference" runat="server" ClientIDMode="Static" CssClass="form-control">
                </asp:TextBox>
            </div>
            <div id="dvPaymentDue1" class="col-md-2">
                <label id="lblPaymentDue"><span class="fa fa-caret-right rgt_cart"></span>Payment Due Date</label>&nbsp;*
                <asp:TextBox ID="txtPaymentDue" runat="server" ClientIDMode="Static" CssClass="form-control" MaxLength="10" onkeyup="BlockStartDateKeyPress()"></asp:TextBox>
            </div>
            <div id="dvPaymentDue2" class="col-md-1" style="margin-top: 22px">
                <asp:ImageButton ID="imgPaymentDue" runat="server" Width="30px" ImageUrl="~/App_Themes/Granite/Images/date.gif" />
                <cc1:CalendarExtender ID="CalendarExtender2" runat="server" Format="dd-MMM-yyyy" PopupButtonID="imgPaymentDue"
                    TargetControlID="txtPaymentDue" OnClientShown="calendarShown"></cc1:CalendarExtender>
            </div>
            <div class="col-md-6"></div>
        </div>
        <div id="dvPOReferenceActual" class="row" runat="server" clientidmode="Static">
            <div class="col-md-4">
                <label><span class="fa fa-caret-right rgt_cart"></span>Invoice / PO Reference</label>&nbsp;*<br />
                <input type="radio" name="InvoicePOReference" value="Invoice" checked="checked" onclick="RC.ManageSchemeExpenseBooking.SetExpenseBookingTypeView(RC.Common.ExpenseBookingType.ACTUAL);" />Invoice&nbsp;
                <input type="radio" name="InvoicePOReference" value="POReference" onclick="RC.ManageSchemeExpenseBooking.SetExpenseBookingTypeView(RC.Common.ExpenseBookingType.ACTUAL);" />PO Reference<br />
                <br />
                <asp:TextBox ID="txtInvoice" runat="server" ClientIDMode="Static" CssClass="form-control">
                </asp:TextBox>
                <select id="ddlPOReference" class="form-control"></select>
            </div>
            <div id="dvFullyPaid" class="col-md-2">
                <label>&nbsp;</label><br />
                <input id="chkFullyPaid" type="checkbox" style="margin-top: 52px;" />Fully Paid
            </div>
            <div class="col-md-6"></div>
        </div>
        <div class="row" style="height: 20px;">
        </div>
        <div id="dvManageSchemeExpenseBookingDetail">
            <div class="emp-table">
                <asp:Panel ID="pnlSchemeExpenseBookingDetail" runat="server" ClientIDMode="Static" GroupingText="Revenue / Capital">
                    <div class="row">
                        <div class="col-md-3">
                            <label id="lblCOATo"><span class="fa fa-caret-right rgt_cart"></span>Expense Type</label>&nbsp;*
                            <dx:ASPxComboBox ID="ddlExpenseType" runat="server" ClientInstanceName="ddlCTExpenseType" CssClass="form-control" TextFormatString="{0}">
                                <ClientSideEvents SelectedIndexChanged="function onComboBoxSelectedIndexChanged(s, e) {
                                    if (s.GetValue() == '1') { 
                                        $('#dvCOA').show();
                                        $('#dvRCOA').hide();
                                        $('#dvFFCOA').hide();
                                    }
                                    else if (s.GetValue() == '2') { 
                                        $('#dvCOA').hide();
                                        $('#dvRCOA').show();
                                        $('#dvFFCOA').hide();
                                    }
                                    else if (s.GetValue() == '3') { 
                                        $('#dvCOA').hide();
                                        $('#dvRCOA').hide();
                                        $('#dvFFCOA').show();
                                    }
                                    
                                    RC.ManageSchemeExpenseBooking.SchemeFundReleaseTotalAmountGetSchemeId();
                                    RC.ManageSchemeExpenseBooking.LoadFundReleaseSTotalAmountForType();
                                }" />
                                <Columns>
                                    <dx:ListBoxColumn FieldName="Title" Caption="Title" Width="250px" />
                                </Columns>
                            </dx:ASPxComboBox>
                        </div>
                        <div id="dvRCOA" class="col-md-5">
                            <label id="lblRCOA"><span class="fa fa-caret-right rgt_cart"></span>Object Code</label>&nbsp;*
                            <dx:ASPxComboBox ID="ddlRCOA" runat="server" ClientInstanceName="ddlRCTCOA" CssClass="form-control" TextFormatString="{0} ({1})">
                                <ClientSideEvents SelectedIndexChanged="function onComboBoxSelectedIndexChanged(s, e) {
                                    RC.ManageSchemeExpenseBooking.SchemeFundReleaseTotalAmountGetSchemeId(); }" />
                                <Columns>
                                    <dx:ListBoxColumn FieldName="ACCOUNT_CODE" Caption="Code" Width="50px" />
                                    <dx:ListBoxColumn FieldName="ACCOUNT_NAME" Caption="Name" Width="250px" />
                                </Columns>
                            </dx:ASPxComboBox>
                        </div>
                        <div id="dvCOA" class="col-md-5" style="display: none;">
                            <label id="lblCOAFrom"><span class="fa fa-caret-right rgt_cart"></span>Object Code</label>&nbsp;*
                            <dx:ASPxComboBox ID="ddlCOA" runat="server" ClientInstanceName="ddlCTCOA" CssClass="form-control" TextFormatString="{0} ({1})">
                                <ClientSideEvents SelectedIndexChanged="function onComboBoxSelectedIndexChanged(s, e) {
                                    RC.ManageSchemeExpenseBooking.SchemeFundReleaseTotalAmountGetSchemeId(); }" />
                                <Columns>
                                    <dx:ListBoxColumn FieldName="ACCOUNT_CODE" Caption="Code" Width="50px" />
                                    <dx:ListBoxColumn FieldName="ACCOUNT_NAME" Caption="Name" Width="250px" />
                                </Columns>
                            </dx:ASPxComboBox>
                        </div>
                        <div id="dvFFCOA" class="col-md-5" style="display: none;">
                            <label><span class="fa fa-caret-right rgt_cart"></span>Object Code</label>&nbsp;*
                            <dx:ASPxComboBox ID="ddlFFCOA" runat="server" ClientInstanceName="ddlFFCTCOA" CssClass="form-control" TextFormatString="{0} ({1})">
                                <ClientSideEvents SelectedIndexChanged="function onComboBoxSelectedIndexChanged(s, e) {
                                    RC.ManageSchemeExpenseBooking.SchemeFundReleaseTotalAmountGetSchemeId(); }" />
                                <Columns>
                                    <dx:ListBoxColumn FieldName="ACCOUNT_CODE" Caption="Code" Width="50px" />
                                    <dx:ListBoxColumn FieldName="ACCOUNT_NAME" Caption="Name" Width="250px" />
                                </Columns>
                            </dx:ASPxComboBox>
                        </div>
                        <div class="col-md-4">
                            <div id="dvTotalAmount" class="dashboard-stat dashboard-stat-v2 blue">
                                <div class="visual">
                                </div>
                                <div class="details">
                                    <div class="number ocnumber">
                                        Released Capital (Object Code)
                                    </div>
                                    <div class="desc">Rs 0.00</div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-3">
                            <label id="lblAmount"><span class="fa fa-caret-right rgt_cart"></span>Expense Amount</label>&nbsp;*
                            <asp:TextBox ID="txtAmount" runat="server" ClientIDMode="Static" CssClass="form-control">
                            </asp:TextBox>
                        </div>
                        <div class="col-md-1">
                            <br />
                            <input type="button" id="btnSaveDetail" class="btn btn-success" onclick="RC.ManageSchemeExpenseBooking.SchemeExpenseBookingDetailSave(-1);" value="Add" />
                        </div>
                        <div class="col-md-4"></div>
                        <div class="col-md-4">
                            <div id="dvSTotalAmount" class="dashboard-stat dashboard-stat-v2 red">
                                <div class="visual">
                                </div>
                                <div class="details">
                                    <div class="number">
                                        Released Capital
                                    </div>
                                    <div class="desc">Rs 0.00</div>
                                </div>
                            </div>
                        </div>
                    </div>
                </asp:Panel>
            </div>
            <div class="row" style="margin-top: 15px;">
                <div class="col-md-12">
                    <table id="tblSchemeExpenseBookingDetailList" class="table table-striped table-bordered" style="width: 100%;">
                        <thead>
                            <tr>
                                <th style="width: 50%;">Object Code</th>
                                <th style="width: 30%; text-align: center;">Type</th>
                                <th style="width: 12%; text-align: center;">Amount</th>
                                <th style="width: 8%; text-align: center;">Action</th>
                            </tr>
                        </thead>
                    </table>
                </div>
            </div>
        </div>
        <div class="row" style="height: 40px;">
        </div>
        <div class="row">
            <div class="col-md-12">
                <label><span class="fa fa-caret-right rgt_cart"></span>Remarks</label>
                <textarea id="txtRemarks"></textarea>
            </div>
        </div>
        <div class="row" style="height: 20px;">
        </div>
        <div class="row">
            <div class="col-md-12">
                <label><span class="fa fa-caret-right rgt_cart"></span>Files</label>
                <table id="tblSchemeExpenseBookingFileList" class="table table-striped table-bordered" style="width: 100%;">
                    <thead>
                        <tr>
                            <th style="width: 75%;">File</th>
                            <th style="width: 25%; text-align: center;">Action</th>
                        </tr>
                    </thead>
                </table>
                <div id="fuFile"></div>
            </div>
        </div>
        <div class="row" style="height: 20px;">
        </div>
        <asp:Button ID="btnSave" runat="server" ClientIDMode="Static" CssClass="btn btn-success" OnClientClick="RC.ManageSchemeExpenseBooking.SaveSchemeExpenseBooking(); return false;" Text="Save" />
        <asp:Button ID="btnCancel" runat="server" ClientIDMode="Static" CssClass="btn btn-danger" Text="Cancel" />
    </div>
    <script src="<%= Page.ResolveClientUrl("~/Script/RC.ManageSchemeExpenseBooking.js") %>" type="text/javascript"></script>
    <script type="text/javascript">
        function SetCOA() {
            RC.ManageSchemeExpenseBooking.SchemeFundReleaseSTotalAmountGetSchemeId();

            $.post(RC.Common.RootURL + "Handler/COAHandler.ashx",
            {
                method: "COAGetSchemeId",
                SchemeId: ddlScheme.GetSelectedItem().value
            },
            function (response) {
                switch (response.Status) {
                    case RC.Common.ResponseStatus.SUCCESS:
                        ddlCTCOA.ClearItems();
                        ddlRCTCOA.ClearItems();

                        if (response.Data != null && response.Data != undefined && response.Data.length > 0) {
                            $(response.Data).each(function (index, item) {
                                ddlRCTCOA.AddItem(new Array(item.ACCOUNT_CODE, item.ACCOUNT_NAME), item.ACCOUNT_HEAD_ID.toString());

                                if (RC.Common.Domain == "PU") {
                                    if (item.ACCOUNT_CODE.toLowerCase().indexOf("a12") >= 0) {
                                        ddlCTCOA.AddItem(new Array(item.ACCOUNT_CODE, item.ACCOUNT_NAME), item.ACCOUNT_HEAD_ID.toString());
                                    }
                                }
                                else {
                                    ddlCTCOA.AddItem(new Array(item.ACCOUNT_CODE, item.ACCOUNT_NAME), item.ACCOUNT_HEAD_ID.toString());
                                }
                            });

                            ddlCTCOA.SetSelectedIndex(0);
                            ddlRCTCOA.SetSelectedIndex(0);
                        }

                        RC.ManageSchemeExpenseBooking.ShowForeignFundingForScheme();

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

                RC.ManageSchemeExpenseBooking.SchemeFundReleaseTotalAmountGetSchemeId();
            });
        }
    </script>
</asp:Content>
