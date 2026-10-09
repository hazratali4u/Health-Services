<%@ Page Title="MPR :: PC1 Scheme" Language="C#" MasterPageFile="~/Forms/PageMaster.master" AutoEventWireup="true" CodeFile="frmPC1SchemeAdd.aspx.cs" Inherits="Forms_frmPC1SchemeAdd" %>

<%@ Register Assembly="DevExpress.Web.v16.1, Version=16.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphHeadPage" runat="Server">
    <link href="../css/fine-uploader/fine-uploader-new.min.css"" rel="stylesheet" />
    <style type="text/css">
        .cls .dxeEditAreaSys {
            -webkit-user-select: none !important;
            -moz-user-select: none !important;
            -ms-user-select: none !important;
            user-select: none !important;
        }

        #dvManageScheme .step {
            margin: 5px;
            height: 40px;
            width: 85px;
        }

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

        .modal-dialog {
            width: 1024px;
        }
    </style>
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
    <script language="JavaScript" type="text/javascript">
        function calendarShown(sender, args) {
            sender._popupBehavior._element.style.zIndex = 10005;
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphPage" runat="Server">
    <div id="dvManageScheme">
        <div class="emp-table">
            <asp:Panel ID="pnlPC1SchemeDetail" runat="server" ClientIDMode="Static">
                <div class="row">
                    <div class="col-md-12">
                        <input type="button" id="btnStep1" class="btn btn-primary step" value="Step 1" tabindex="1" />
                        <input type="button" id="btnStep2" class="btn btn-default step" value="Step 2" tabindex="2" />
                        <input type="button" id="btnStep3" class="btn btn-default step" value="Step 3" tabindex="3" />
                        <input type="button" id="btnStep4" class="btn btn-default step" value="Step 4" tabindex="4" />
                        <input type="button" id="btnStep5" class="btn btn-default step" value="Step 5" tabindex="5" />
                        <input type="button" id="btnStep6" class="btn btn-default step" value="Step 6" tabindex="6" />
                        <input type="button" id="btnStep7" class="btn btn-default step" value="Step 7" tabindex="7" />
                        <input type="button" id="btnStep8" class="btn btn-default step" value="Step 8" tabindex="8" />
                        <input type="button" id="btnStep9" class="btn btn-default step" value="Step 9" tabindex="9" />
                        <input type="button" id="btnStep10" class="btn btn-default step" value="Step 10" tabindex="10" />
                        <input type="button" id="btnStep11" class="btn btn-default step" value="Step 11" tabindex="11" />
                        <input type="button" id="btnStep12" class="btn btn-default step" value="Step 12" tabindex="12" />
                        <input type="button" id="btnStep13" class="btn btn-default step" value="Step 13" tabindex="13" />
                        <input type="button" id="btnStep14" class="btn btn-default step" value="Step 14" tabindex="14" />
                        <input type="button" id="btnStep15" class="btn btn-default step" value="Step 15" tabindex="15" />
                        <input type="button" id="btnStep16" class="btn btn-default step" value="Step 16" tabindex="16" />
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-12" style="text-align: right;">
                        <input type="button" id="btnSave" class="btn btn-success" onclick="RC.ManageScheme.SaveScheme();" value="Save" />
                        <input type="button" id="btnCancel" class="btn btn-danger" value="Cancel" />
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-12">
                        <label id="lblStep" style="font-size: 20px;"></label>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-12 content step1">
                        <div class="row">
                            <div class="col-md-6">
                                <label id="lblSchemeName"><span class="fa fa-caret-right rgt_cart"></span>Scheme Name</label>&nbsp;*
                                <asp:TextBox ID="txtSchemeName" runat="server" CssClass="form-control" ClientIDMode="Static"></asp:TextBox>
                            </div>
                            <div class="col-md-3">
                                <label id="lblClassification"><span class="fa fa-caret-right rgt_cart"></span>Functional Classification</label>&nbsp;*&nbsp;&nbsp;<label style="color: firebrick; font-weight: bold;">Capital</label>
                                <dx:ASPxComboBox ID="ddlCOA" runat="server" CssClass="form-control" TextFormatString="{1}" ClientInstanceName="ddlCOA">
                                    <Columns>
                                        <dx:ListBoxColumn FieldName="ACCOUNT_CODE" Caption="Code" Width="20px" />
                                        <dx:ListBoxColumn FieldName="ACCOUNT_NAME" Caption="Name" Width="40px" />
                                    </Columns>
                                </dx:ASPxComboBox>
                            </div>
                            <div class="col-md-3"></div>
                        </div>
                        <div class="row">
                            <div class="col-md-6">
                                <label id="lblInstitue"><span class="fa fa-caret-right rgt_cart"></span>Spending Unit</label>&nbsp;*
                            <dx:ASPxComboBox ID="ddlInstitute" runat="server" CssClass="form-control" TextFormatString="{0}" ClientInstanceName="ddlInstitute">
                                <Columns>
                                    <dx:ListBoxColumn FieldName="DISTRIBUTOR_NAME" Caption="Name" Width="80px" />
                                    <dx:ListBoxColumn FieldName="District" Caption="District" Width="20px" />
                                </Columns>
                                <ClientSideEvents SelectedIndexChanged="function(s, e) { RC.ManageScheme.PopulateForInstitute(); }" />
                            </dx:ASPxComboBox>
                            </div>
                            <div class="col-md-3">
                                <label><span class="fa fa-caret-right rgt_cart"></span>Functional Classification</label>&nbsp;*&nbsp;&nbsp;<label style="color: firebrick; font-weight: bold;">Revenue</label>
                                <dx:ASPxComboBox ID="ddlRCOA" runat="server" CssClass="form-control" TextFormatString="{1}" ClientInstanceName="ddlRCOA">
                                    <Columns>
                                        <dx:ListBoxColumn FieldName="ACCOUNT_CODE" Caption="Code" Width="20px" />
                                        <dx:ListBoxColumn FieldName="ACCOUNT_NAME" Caption="Name" Width="40px" />
                                    </Columns>
                                </dx:ASPxComboBox>
                            </div>
                            <div class="col-md-3"></div>
                        </div>
                        <div class="row">
                            <div class="col-md-2">
                                <label id="lblDistrict"><span class="fa fa-caret-right rgt_cart"></span>Sub Sector</label>&nbsp;*
                            <dx:ASPxComboBox ID="ddlSubSector" runat="server" CssClass="form-control" TextFormatString="{1}" ClientInstanceName="ddlSubSector">
                                <Columns>
                                    <dx:ListBoxColumn FieldName="strCode" Caption="Code" Width="20px" />
                                    <dx:ListBoxColumn FieldName="strName" Caption="Name" Width="40px" />
                                </Columns>
                            </dx:ASPxComboBox>
                            </div>
                            <div class="col-md-2">
                                <label id="lblTehsil">
                                    <span class="fa fa-caret-right rgt_cart"></span>District-Tehsil</label>
                                <table width="100%">
                                    <tr>
                                        <td style="width: 48%">
                                            <asp:TextBox ID="txtDistrict" runat="server" CssClass="form-control" Enabled="false" ClientIDMode="Static"></asp:TextBox>
                                        </td>
                                        <td style="width: 4%">&nbsp;</td>
                                        <td style="width: 48%">
                                            <asp:TextBox ID="txtTehsil" runat="server" CssClass="form-control" Enabled="false" ClientIDMode="Static"></asp:TextBox>
                                        </td>
                                    </tr>
                                </table>
                            </div>
                            <div class="col-md-2">
                                <label id="lblSchemeDate"><span class="fa fa-caret-right rgt_cart"></span>Scheme Date</label>&nbsp;*
                            <table width="100%">
                                <tr>
                                    <td style="width: 80%">
                                        <asp:TextBox ID="txtSchemeDate" runat="server" CssClass="form-control" MaxLength="10" onkeyup="BlockStartDateKeyPress()" ClientIDMode="Static"></asp:TextBox>
                                    </td>
                                    <td style="width: 4%">&nbsp;</td>
                                    <td style="width: 16%">
                                        <asp:ImageButton ID="imgSchemeDate" runat="server" Width="30px" ImageUrl="~/App_Themes/Granite/Images/date.gif" Style="margin-top: -26px;" />
                                        <cc1:CalendarExtender ID="CalendarExtender1" runat="server" Format="dd-MMM-yyyy" PopupButtonID="imgSchemeDate"
                                            TargetControlID="txtSchemeDate" OnClientShown="calendarShown"></cc1:CalendarExtender>
                                    </td>
                                </tr>
                            </table>
                            </div>
                            <div class="col-md-3">
                                <label><span class="fa fa-caret-right rgt_cart"></span>Prepared By</label>
                                <asp:TextBox ID="txtPreparedBy" runat="server" CssClass="form-control" ClientIDMode="Static"></asp:TextBox>
                            </div>
                            <div class="col-md-3">
                                <label><span class="fa fa-caret-right rgt_cart"></span>Checked By</label>
                                <asp:TextBox ID="txtCheckedBy" runat="server" CssClass="form-control" ClientIDMode="Static"></asp:TextBox>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-2">
                                <label id="lblCategory"><span class="fa fa-caret-right rgt_cart"></span>Status</label>&nbsp;*
                            <dx:ASPxComboBox ID="ddlCategory" runat="server" CssClass="form-control" ClientInstanceName="ddlCategory">
                                <Columns>
                                    <dx:ListBoxColumn FieldName="Title" Caption="Title" Width="100px" />
                                </Columns>
                            </dx:ASPxComboBox>
                            </div>
                            <div class="col-md-2">
                                <label id="lblStartDate"><span class="fa fa-caret-right rgt_cart"></span>Start Date</label>&nbsp;*
                            <table width="100%">
                                <tr>
                                    <td style="width: 80%">
                                        <asp:TextBox ID="txtStartDate" runat="server" CssClass="form-control" ClientIDMode="Static"></asp:TextBox>
                                    </td>
                                    <td style="width: 4%">&nbsp;</td>
                                    <td style="width: 16%">
                                        <asp:ImageButton ID="ibtnStartDate" runat="server" Width="30px" ImageUrl="~/App_Themes/Granite/Images/date.gif" Style="margin-top: -26px;" />
                                        <cc1:CalendarExtender ID="CEStartDate" runat="server" Format="dd-MMM-yyyy" PopupButtonID="ibtnStartDate"
                                            TargetControlID="txtStartDate" OnClientShown="calendarShown"></cc1:CalendarExtender>
                                    </td>
                                </tr>
                            </table>
                            </div>
                            <div class="col-md-2">
                                <label id="lblEndDate"><span class="fa fa-caret-right rgt_cart"></span>End Date</label>&nbsp;*
                            <table width="100%">
                                <tr>
                                    <td style="width: 80%">
                                        <asp:TextBox ID="txtEndDate" runat="server" CssClass="form-control" ClientIDMode="Static"></asp:TextBox>
                                    </td>
                                    <td style="width: 4%">&nbsp;</td>
                                    <td style="width: 16%">
                                        <asp:ImageButton ID="ibnEndDate" runat="server" Width="30px" ImageUrl="~/App_Themes/Granite/Images/date.gif" Style="margin-top: -26px;" />
                                        <cc1:CalendarExtender ID="CEEndDate" runat="server" Format="dd-MMM-yyyy" PopupButtonID="ibnEndDate"
                                            TargetControlID="txtEndDate" OnClientShown="calendarShown"></cc1:CalendarExtender>
                                    </td>
                                </tr>
                            </table>
                            </div>
                            <div class="col-md-3">
                                <label><span class="fa fa-caret-right rgt_cart"></span>Approved By</label>
                                <asp:TextBox ID="txtApprovedBy" runat="server" CssClass="form-control" ClientIDMode="Static"></asp:TextBox>
                            </div>
                            <div class="col-md-3"></div>
                        </div>
                        <div class="row">
                            <div class="col-md-12">
                                <label id="lblRemarks"><span class="fa fa-caret-right rgt_cart"></span>Remarks</label>
                                <asp:TextBox ID="txtRemarks" runat="server" CssClass="form-control" TextMode="MultiLine" Height="70" ClientIDMode="Static"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-12 content step2" style="display: none;">
                        <div class="row">
                            <div class="col-md-4">
                                <label><span class="fa fa-caret-right rgt_cart"></span>Latitude</label>
                                <asp:TextBox ID="txtLatitude" runat="server" CssClass="form-control" ClientIDMode="Static"></asp:TextBox>
                            </div>
                            <div class="col-md-4">
                                <label><span class="fa fa-caret-right rgt_cart"></span>Longitude</label>
                                <asp:TextBox ID="txtLongitude" runat="server" CssClass="form-control" ClientIDMode="Static"></asp:TextBox>
                            </div>
                            <div class="col-md-4">
                                <label><span></span>&nbsp;</label><br />
                                <input type="button" id="btnLoadMapLocation" class="btn btn-success" value="Load Map Location" />
                            </div>
                        </div>
                        <br />
                        <div id="dvLocationMap" style="width: 100%; height: 400px; background: yellow"></div>
                    </div>
                    <div class="col-md-12 content step3" style="display: none;">
                        <div class="row">
                            <div class="col-md-3">
                                <label id="lblSponsoring"><span class="fa fa-caret-right rgt_cart"></span>Sponsoring</label>
                                <dx:ASPxComboBox ID="ddlSponsoring" runat="server" CssClass="form-control" TextFormatString="{1}" ClientInstanceName="ddlCTSponsoring">
                                    <Columns>
                                        <dx:ListBoxColumn FieldName="ShortTitle" Caption="Code" Width="20px" />
                                        <dx:ListBoxColumn FieldName="Title" Caption="Name" Width="40px" />
                                    </Columns>
                                </dx:ASPxComboBox>
                            </div>
                            <div class="col-md-3">
                                <label id="lblExecution"><span class="fa fa-caret-right rgt_cart"></span>Execution</label>
                                <dx:ASPxComboBox ID="ddlExecution" runat="server" CssClass="form-control" TextFormatString="{1}" ClientInstanceName="ddlCTExecution">
                                    <Columns>
                                        <dx:ListBoxColumn FieldName="ShortTitle" Caption="Code" Width="20px" />
                                        <dx:ListBoxColumn FieldName="Title" Caption="Name" Width="40px" />
                                    </Columns>
                                </dx:ASPxComboBox>
                            </div>
                            <div class="col-md-3">
                                <label id="lblOperationMaintenance"><span class="fa fa-caret-right rgt_cart"></span>Operation & Maintenance</label>
                                <dx:ASPxComboBox ID="ddlOperationMaintenance" runat="server" CssClass="form-control" TextFormatString="{1}" ClientInstanceName="ddlCTOperationMaintenance">
                                    <Columns>
                                        <dx:ListBoxColumn FieldName="ShortTitle" Caption="Code" Width="20px" />
                                        <dx:ListBoxColumn FieldName="Title" Caption="Name" Width="40px" />
                                    </Columns>
                                </dx:ASPxComboBox>
                            </div>
                            <div class="col-md-3">
                                <label id="lblConcernedFederalMinistry"><span class="fa fa-caret-right rgt_cart"></span>Concerned Provincial Ministry</label>
                                <dx:ASPxComboBox ID="ddlConcernedFederalMinistry" runat="server" CssClass="form-control" TextFormatString="{1}" ClientInstanceName="ddlCTConcernedFederalMinistry">
                                    <Columns>
                                        <dx:ListBoxColumn FieldName="ShortTitle" Caption="Code" Width="20px" />
                                        <dx:ListBoxColumn FieldName="Title" Caption="Name" Width="40px" />
                                    </Columns>
                                </dx:ASPxComboBox>
                            </div>
                        </div>
                        <div class="row" style="height: 75px;"></div>
                    </div>
                    <div class="col-md-12 content step4" style="display: none;">
                        <textarea id="txtStep4Detail"></textarea>
                    </div>
                    <div class="col-md-12 content step5" style="display: none;">
                        <textarea id="txtStep5Detail"></textarea>
                    </div>
                    <div class="col-md-12 content step6" style="display: none;">
                        <textarea id="txtStep6Detail"></textarea>
                    </div>
                    <div class="col-md-12 content step7" style="display: none;">
                        <div class="row">
                            <div class="col-md-12">
                                <div class="btnlist pull-right">
                                    <asp:LinkButton CssClass="btn btn-warning" runat="server" ID="btnAddCCE" ClientIDMode="Static" OnClientClick="RC.ManageScheme.AddCapitalCostEstimate(); return false;">
                                        <span class="fa fa-plus-circle"></span>Add
                                    </asp:LinkButton>
                                </div>
                            </div>
                        </div>
                        <div id="dvCapitalCostEstimate"></div>
                    </div>
                    <div class="col-md-12 content step8" style="display: none;">
                        <div class="row">
                            <div class="col-md-12">
                                <div class="btnlist pull-right">
                                    <asp:LinkButton CssClass="btn btn-warning" runat="server" ID="btnAddAOC" ClientIDMode="Static" OnClientClick="RC.ManageScheme.AddAnnualOperatingCost(); return false;">
                                        <span class="fa fa-plus-circle"></span>Add
                                    </asp:LinkButton>
                                </div>
                            </div>
                        </div>
                        <div id="dvAnnualOperatingCost"></div>
                    </div>
                    <div class="col-md-12 content step9" style="display: none;">
                        <textarea id="txtStep9Detail"></textarea>
                    </div>
                    <div class="col-md-12 content step10" style="display: none;">
                        <textarea id="txtStep10Detail"></textarea>
                    </div>
                    <div class="col-md-12 content step11" style="display: none;">
                        <span class="fa fa-caret-right rgt_cart"></span>
                        <label style="font-size: 18px;">Financial</label>
                        <textarea id="txtStep11Detail"></textarea>
                        <br />
                        <span class="fa fa-caret-right rgt_cart"></span>
                        <label style="font-size: 18px;">Social Benefits with Indicators</label>
                        <textarea id="txtStep11Detail2"></textarea>
                        <br />
                        <span class="fa fa-caret-right rgt_cart"></span>
                        <label style="font-size: 18px;">Employment Generation (Direct and Indirect)</label>
                        <textarea id="txtStep11Detail3"></textarea>
                        <br />
                        <span class="fa fa-caret-right rgt_cart"></span>
                        <label style="font-size: 18px;">Environmental Impact</label>
                        <textarea id="txtStep11Detail4"></textarea>
                        <br />
                        <span class="fa fa-caret-right rgt_cart"></span>
                        <label style="font-size: 18px;">Impact of Delays on Project Cost and Viability</label>
                        <textarea id="txtStep11Detail5"></textarea>
                    </div>
                    <div class="col-md-12 content step12" style="display: none;">
                        <span class="fa fa-caret-right rgt_cart"></span>
                        <label style="font-size: 18px;">Implementation Schedule</label>
                        <textarea id="txtStep12Detail"></textarea>
                        <br />
                        <span class="fa fa-caret-right rgt_cart"></span>
                        <label style="font-size: 18px;">Result Based Monitoring (RBM) Indicators</label>
                        <textarea id="txtStep12Detail2"></textarea>
                    </div>
                    <div class="col-md-12 content step13" style="display: none;">
                        <textarea id="txtStep13Detail"></textarea>
                    </div>
                    <div class="col-md-12 content step14" style="display: none;">
                        <textarea id="txtStep14Detail"></textarea>
                    </div>
                    <div class="col-md-12 content step15" style="display: none;">
                        <textarea id="txtStep15Detail"></textarea>
                    </div>
                    <div class="col-md-12 content step16" style="display: none;">
                        <div class="row">
                            <div class="col-md-12">
                                <label><span class="fa fa-caret-right rgt_cart"></span>Files</label>
                                <table id="tblSchemeFileList" class="table table-striped table-bordered" style="width: 100%;">
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
                    </div>
                </div>
                <div class="row" style="height: 20px;">
                </div>
            </asp:Panel>
        </div>
        <div class="row" style="height: 20px;">
        </div>
    </div>
    <cc1:ModalPopupExtender ID="mPopUpLocationCCE" runat="server" PopupControlID="dvCCEDetail" TargetControlID="btnCCEAddDetail" BehaviorID="CCEModelPopup"
        BackgroundCssClass="modal-background" CancelControlID="btnCCEClose">
    </cc1:ModalPopupExtender>
    <asp:Panel ID="dvCCEDetail" runat="server" ClientIDMode="Static" Style="display: none;">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" id="btnCCEClose" runat="server" class="close" clientidmode="Static">
                        <span>&times;</span><span class="sr-only">Close</span></button>
                    <h1 class="modal-title">
                        <span class="fa fa-clock-o"></span><span>Manage</span> Capital Cost Estimate</h1>
                </div>
                <div class="modal-body">
                    <div class="row">
                        <div id="dvCCEFinancialYear" class="col-md-12">
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-12">
                            <div class="btnlist pull-right">
                                <asp:LinkButton CssClass="btn btn-warning" runat="server" ID="btnCCEAdd" ClientIDMode="Static" OnClientClick="RC.ManageScheme.AddCapitalCostEstimateDetail(); return false;">
                                    <span class="fa fa-plus-circle"></span>Add
                                </asp:LinkButton>
                            </div>
                        </div>
                    </div>
                    <div id="dvCCEDetailSection" style="max-height: 250px; overflow-y: scroll; overflow-x: hidden;">
                    </div>
                </div>
                <div class="modal-footer">
                    <button type="button" id="btnCCESaveDetail" class="btn btn-success" onclick="RC.ManageScheme.SaveSchemeCCEDetail();">Save</button>
                </div>
            </div>
        </div>
    </asp:Panel>
    <cc1:ModalPopupExtender ID="mPopUpLocationAOC" runat="server" PopupControlID="dvAOCDetail" TargetControlID="btnAOCAddDetail" BehaviorID="AOCModelPopup"
        BackgroundCssClass="modal-background" CancelControlID="btnAOCClose">
    </cc1:ModalPopupExtender>
    <asp:Panel ID="dvAOCDetail" runat="server" ClientIDMode="Static" Style="display: none;">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" id="btnAOCClose" runat="server" class="close" clientidmode="Static">
                        <span>&times;</span><span class="sr-only">Close</span></button>
                    <h1 class="modal-title">
                        <span class="fa fa-clock-o"></span><span>Manage</span> Annual Operating Cost</h1>
                </div>
                <div class="modal-body">
                    <div class="row" style="display: none;">
                        <div id="dvAOCFinancialYear" class="col-md-12">
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-12">
                            <div class="btnlist pull-right">
                                <asp:LinkButton CssClass="btn btn-warning" runat="server" ID="btnAOCAdd" ClientIDMode="Static" OnClientClick="RC.ManageScheme.AddAnnualOperatingCostDetail(); return false;">
                                    <span class="fa fa-plus-circle"></span>Add
                                </asp:LinkButton>
                            </div>
                        </div>
                    </div>
                    <div id="dvAOCDetailSection" style="max-height: 250px; overflow-y: scroll; overflow-x: hidden;">
                    </div>
                </div>
                <div class="modal-footer">
                    <button type="button" id="btnAOCSaveDetail" class="btn btn-success" onclick="RC.ManageScheme.SaveSchemeAOCDetail();">Save</button>
                </div>
            </div>
        </div>
    </asp:Panel>
    <div id="dvTemplates" style="display: none;">
        <div id="tmplCapitalCostEstimate" class="row">
            <div class="col-md-3">
                <label><span class="fa fa-caret-right rgt_cart"></span>Title</label>
                <input id="txtCCETitle" class="form-control" type="text" />
            </div>
            <div class="col-md-3">
                <label><span class="fa fa-caret-right rgt_cart"></span>Group</label>
                <select id="ddlCCEGroup" runat="server" class="form-control" clientidmode="Static"></select>
            </div>
            <div class="col-md-2">
                <label><span class="fa fa-caret-right rgt_cart"></span>Total Capital Cost</label>
                <input id="txtCCETotalPrice" class="form-control" type="text" readonly />
            </div>
            <div class="col-md-2">
                <label><span></span>&nbsp;</label><br />
                <asp:LinkButton CssClass="btn btn-warning" runat="server" ID="btnCCEAddDetail" ClientIDMode="Static">
                    <span class="fa fa-ellipsis-h"></span>
                </asp:LinkButton>
                <asp:LinkButton CssClass="btn btn-danger" runat="server" ID="btnCCEDelete" ClientIDMode="Static">
                    <span class="fa fa-trash-o"></span>
                </asp:LinkButton>
            </div>
            <div class="col-md-2"></div>
        </div>
        <div id="tmplCapitalCostEstimateDetail" class="row">
            <div class="col-md-3">
                <label><span class="fa fa-caret-right rgt_cart"></span>Title</label>
                <input id="txtCCEDTitle" class="form-control" type="text" />
            </div>
            <div class="col-md-1">
                <label><span class="fa fa-caret-right rgt_cart"></span>Qty</label>
                <input id="txtCCEDQuantity" class="form-control" type="text" value="0" />
            </div>
            <div class="col-md-2">
                <label><span class="fa fa-caret-right rgt_cart"></span>Price</label>
                <input id="txtCCEDUnitPrice" class="form-control" type="text" value="0" />
            </div>
            <div class="col-md-2">
                <label><span class="fa fa-caret-right rgt_cart"></span>Total</label>
                <input id="txtCCEDTotalPrice" class="form-control" type="text" readonly />
            </div>
            <div class="col-md-3">
                <label><span class="fa fa-caret-right rgt_cart"></span>Object Code</label>
                <select id="ddlCCEGroupAccountHead" class="form-control"></select>
            </div>
            <div class="col-md-1">
                <label><span></span>&nbsp;</label><br />
                <asp:LinkButton CssClass="btn btn-danger" runat="server" ID="btnCCEDDelete" ClientIDMode="Static">
                    <span class="fa fa-trash-o"></span>
                </asp:LinkButton>
            </div>
        </div>
        <div id="tmplAnnualOperatingCost" class="row">
            <div class="col-md-3">
                <label><span class="fa fa-caret-right rgt_cart"></span>Title</label>
                <input id="txtAOCTitle" class="form-control" type="text" />
            </div>
            <div class="col-md-3">
                <label><span class="fa fa-caret-right rgt_cart"></span>Group</label>
                <select id="ddlAOCGroup" runat="server" class="form-control" clientidmode="Static"></select>
            </div>
            <div class="col-md-2">
                <label><span class="fa fa-caret-right rgt_cart"></span>Total Operating Cost</label>
                <input id="txtAOCTotalPrice" class="form-control" type="text" readonly />
            </div>
            <div class="col-md-2">
                <label><span></span>&nbsp;</label><br />
                <asp:LinkButton CssClass="btn btn-warning" runat="server" ID="btnAOCAddDetail" ClientIDMode="Static">
                    <span class="fa fa-ellipsis-h"></span>
                </asp:LinkButton>
                <asp:LinkButton CssClass="btn btn-danger" runat="server" ID="btnAOCDelete" ClientIDMode="Static">
                    <span class="fa fa-trash-o"></span>
                </asp:LinkButton>
            </div>
            <div class="col-md-2"></div>
        </div>
        <div id="tmplAnnualOperatingCostDetail" class="row">
            <div class="col-md-4">
                <label><span class="fa fa-caret-right rgt_cart"></span>Title</label>
                <input id="txtAOCDTitle" class="form-control" type="text" />
            </div>
            <div class="col-md-1" style="display: none;">
                <label><span class="fa fa-caret-right rgt_cart"></span>Qty</label>
                <input id="txtAOCDQuantity" class="form-control" type="text" />
            </div>
            <div class="col-md-2">
                <label><span class="fa fa-caret-right rgt_cart"></span>Amount</label>
                <input id="txtAOCDUnitPrice" class="form-control" type="text" />
            </div>
            <div class="col-md-2" style="display: none;">
                <label><span class="fa fa-caret-right rgt_cart"></span>Total</label>
                <input id="txtAOCDTotalPrice" class="form-control" type="text" readonly />
            </div>
            <div class="col-md-5">
                <label><span class="fa fa-caret-right rgt_cart"></span>Object Code</label>
                <select id="ddlAOCGroupAccountHead" class="form-control"></select>
            </div>
            <div class="col-md-1">
                <label><span></span>&nbsp;</label><br />
                <asp:LinkButton CssClass="btn btn-danger" runat="server" ID="btnAOCDDelete" ClientIDMode="Static">
                    <span class="fa fa-trash-o"></span>
                </asp:LinkButton>
            </div>
        </div>
        <input id="tmplFinancialYear" type="button" class="btn btn-default" style="height: 45px; width: 100px; margin-right: 10px;" />
    </div>
    <script src="<%= Page.ResolveClientUrl("~/Script/RC.ManagePC1Scheme.js") %>" type="text/javascript"></script>
</asp:Content>

