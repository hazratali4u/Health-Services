<%@ Page Title="MPR :: Scheme / Project Stages" Language="C#" MasterPageFile="~/Forms/PageMaster.master" AutoEventWireup="true" CodeFile="frmPC1SchemeStages.aspx.cs" Inherits="Forms_frmPC1SchemeStages" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphPage" runat="Server">
    <div id="dvSchemeStageListing" class="main-contents">
        <div class="container employee-infomation">
            <div class="row top">
                <div class="col-md-12">
                    <div class="btnlist pull-right">
                        <asp:LinkButton CssClass="btn btn-warning" runat="server" ID="btnAdd" OnClientClick="window.location = 'frmPC1SchemeStageAdd.aspx?LevelType=3&LevelID=283'; return false;">
                               <span class="fa fa-plus-circle"></span>Add
                        </asp:LinkButton>
                    </div>
                </div>
                <div class="col-md-12" style="clear: both;">
                    <table id="tblSchemeStageList" class="table table-striped table-bordered" style="width: 100%;">
                        <thead>
                            <tr>
                                <th style="width: 30%;">Scheme</th>
                                <th style="width: 30%;">Status</th>
                                <th style="width: 25%;">Reference No</th>
                                <th style="width: 15%; text-align: center;">Date</th>
                            </tr>
                        </thead>
                    </table>
                </div>
            </div>
        </div>
    </div>
    <script src="<%= Page.ResolveClientUrl("~/Script/RC.PC1SchemeStageListing.js") %>" type="text/javascript"></script>
</asp:Content>

