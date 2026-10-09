<%@ Page Title="" Language="C#" MasterPageFile="~/Forms/PageMaster.master" AutoEventWireup="true" CodeFile="frmSchemeDocumentAdd.aspx.cs" Inherits="Forms_frmSchemeDocumentAdd" %>

<%@ Register Assembly="DevExpress.Web.v16.1, Version=16.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphHeadPage" runat="Server">
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
    </style>
    <script language="JavaScript" type="text/javascript">
        function calendarShown(sender, args) {
            sender._popupBehavior._element.style.zIndex = 10005;
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphPage" runat="Server">
    <div id="dvManageSchemeDocument">
        <div class="row">
            <div class="col-md-6">
                <label><span class="fa fa-caret-right rgt_cart"></span>Scheme Name</label>&nbsp;*
                <dx:ASPxComboBox ID="ddlScheme" runat="server" ClientInstanceName="ddlCTScheme" CssClass="form-control" TextFormatString="{0}">
                    <Columns>
                        <dx:ListBoxColumn FieldName="strSchemeName" Caption="Scheme Name" Width="40px" />
                        <dx:ListBoxColumn FieldName="DISTRIBUTOR_NAME" Caption="Spending Unit" Width="20px" />
                        <dx:ListBoxColumn FieldName="ACCOUNT_NAME" Caption="Func. Class" Width="20px" />
                    </Columns>
                </dx:ASPxComboBox>
            </div>
            <div class="col-md-2">
                <label><span class="fa fa-caret-right rgt_cart"></span>Document Date</label>&nbsp;*
                <asp:TextBox ID="txtDocumentDate" runat="server" ClientIDMode="Static" CssClass="form-control" MaxLength="10" onkeyup="BlockStartDateKeyPress()"></asp:TextBox>
            </div>
            <div class="col-md-1" style="margin-top: 22px">
                <asp:ImageButton ID="ibtnDocumentDate" runat="server" Width="30px" ImageUrl="~/App_Themes/Granite/Images/date.gif" />
                <cc1:CalendarExtender ID="CEtProposedDate" runat="server" Format="dd-MMM-yyyy" PopupButtonID="ibtnDocumentDate"
                    TargetControlID="txtDocumentDate" OnClientShown="calendarShown"></cc1:CalendarExtender>
            </div>
            <div class="col-md-3">
            </div>
        </div>
        <div class="row">
            <div class="col-md-3">
                <label><span class="fa fa-caret-right rgt_cart"></span>Title</label>
                <asp:TextBox ID="txtTitle" runat="server" ClientIDMode="Static" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-md-3">
                <label><span class="fa fa-caret-right rgt_cart"></span>Reference Number</label>
                <asp:TextBox ID="txtReferenceNo" runat="server" ClientIDMode="Static" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-md-6"></div>
        </div>
        <div class="row">
            <div class="col-md-3">
                <label><span class="fa fa-caret-right rgt_cart"></span>Version</label>
                <asp:TextBox ID="txtVersion" runat="server" ClientIDMode="Static" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-md-9"></div>
        </div>
        <div class="row">
            <div class="col-md-8">
                <label><span class="fa fa-caret-right rgt_cart"></span>Remarks</label>
                <textarea id="txtRemarks"></textarea>
            </div>
            <div class="col-md-4"></div>
        </div>
        <div class="row" style="height: 20px;">
        </div>
        <div class="row">
            <div class="col-md-12">
                <label><span class="fa fa-caret-right rgt_cart"></span>Files</label>
                <table id="tblSchemeDocumentFileList" class="table table-striped table-bordered" style="width: 100%; display: none;">
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
        <asp:Button ID="btnSave" runat="server" ClientIDMode="Static" CssClass="btn btn-success" OnClientClick="RC.ManageSchemeDocument.SaveSchemeDocument(); return false;" Text="Save" />
        <asp:Button ID="btnCancel" runat="server" ClientIDMode="Static" CssClass="btn btn-danger" OnClientClick="window.location = 'frmSchemeDocuments.aspx'; return false;" Text="Cancel" />
    </div>
    <script src="<%= Page.ResolveClientUrl("~/Script/RC.ManageSchemeDocument.js") %>" type="text/javascript"></script>
</asp:Content>

