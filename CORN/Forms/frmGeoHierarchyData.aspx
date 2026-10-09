<%@ Page Language="C#" MasterPageFile="~/Forms/PageMaster.master" AutoEventWireup="true"
    CodeFile="frmGeoHierarchyData.aspx.cs" Inherits="Forms_frmGeoHierarchyData" Title="MPR :: Geo Hierarchy" %>


<%@ Register Assembly="DevExpress.Web.v16.1, Version=16.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphPage" runat="Server">
    <script language="JavaScript" type="text/javascript">
       

        function ValidatZone() {
            var str;

            str = document.getElementById('<%=txtZoneName.ClientID%>').value;
            if (str == null || str.length == 0) {
                alert('Must enter District Name');
                return false;
            }
            return true;
        }
        function ValidateTerritory() {
            var str;
            str = document.getElementById('<%=txtTerritoryName.ClientID%>').value;
            if (str == null || str.length == 0) {
                alert('Must enter Tehsil Name');
                return false;
            }
            return true;
        }
        function ValidateTown() {
            var str;
            str = document.getElementById('<%=txtTownName.ClientID%>').value;
            if (str == null || str.length == 0) {
                alert('Must enter Constituency Name');
                return false;
            }
            return true;
        }
    </script>
    <cc1:TabContainer ID="TabContainer1" runat="server" ActiveTabIndex="0" Height="400px"
        Width="65%">
       
        <cc1:TabPanel ID="TabPanel2" runat="server" CssClass="accordion__content">
            <HeaderTemplate>
                District
            </HeaderTemplate>
            <ContentTemplate>
                <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                    <ContentTemplate>
                        <div class="row">
                            <div class="col-md-8">
                                <asp:Label ID="lblErrorZone" runat="server" ForeColor="Red" Font-Bold="True"></asp:Label>
                                <asp:HiddenField ID="HdnZoneID" runat="server" />

                               
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-2">
                                <label>
                                    <span class="fa fa-caret-right rgt_cart"></span>Code</label>
                            </div>
                            <div class="col-md-4">
                                <label>
                                    <span class="fa fa-caret-right rgt_cart"></span>Name</label>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-2">
                               
                                 <asp:TextBox ID="txtZoneCode" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                            <div class="col-md-5">
                                <asp:TextBox ID="txtZoneName" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                            <div class="col-md-3">


                                <asp:CheckBox ID="chbIsZoneActive" runat="server" Text="Is Active" Checked="True"></asp:CheckBox>

                            </div>
                            <div class="col-md-2">
                                <asp:Button ID="btnSaveZone" OnClick="btnSaveZone_Click" runat="server"
                                    Text="Save" CssClass="btn btn-success" />
                            </div>
                        </div>

                    </ContentTemplate>
                </asp:UpdatePanel>
                <div class="row">
                    <div class="col-md-12">
                        <div class="emp-table">
                            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                <ContentTemplate>
                                    <asp:Panel ID="Panel1" runat="server" ScrollBars="Vertical" Width="100%" Height="200">
                                        <asp:GridView ID="grdZoneData" runat="server" Width="100%"
                                            CssClass="table table-striped table-bordered table-hover table-condensed cf" Style="height: 50px;"
                                            AutoGenerateColumns="False" OnRowEditing="grdZoneData_RowEditing"
                                            OnRowDeleting="grdZoneData_RowDeleting" >

                                            <Columns>
                                                <asp:BoundField DataField="PARENT_GEO_ID" HeaderText="PARENT_GEO_ID" ReadOnly="true">
                                                    <HeaderStyle CssClass="HidePanel"></HeaderStyle>
                                                    <ItemStyle CssClass="HidePanel"></ItemStyle>
                                                </asp:BoundField>
                                                <asp:BoundField DataField="GEO_ID" HeaderText="GEO_ID" ReadOnly="true">
                                                    <HeaderStyle CssClass="HidePanel"></HeaderStyle>
                                                    <ItemStyle CssClass="HidePanel"></ItemStyle>
                                                </asp:BoundField>
                                                <asp:BoundField DataField="GEO_CODE" HeaderText="Code" ReadOnly="true">
                                                  
                                                </asp:BoundField>
                                                <asp:BoundField DataField="GEO_NAME" HeaderText="Name" ReadOnly="true"></asp:BoundField>
                                                <asp:BoundField DataField="ISCURRENT" HeaderText="Status" ReadOnly="true"></asp:BoundField>
                                                <asp:TemplateField>
                                                    <ItemStyle HorizontalAlign="Center"></ItemStyle>
                                                    <ItemTemplate>
                                                        <asp:LinkButton ID="btnEdit" HorizontalAlign="Center" runat="server" CommandName="Edit"
                                                            CssClass="fa fa-pencil"></asp:LinkButton>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField >
                                                    <ItemTemplate>
                                                        <asp:LinkButton ID="btnDelete" runat="server" OnClientClick="javascript:return confirm('Are you sure you want to Delete?');return false;"
                                                            CommandName="Delete" class="fa fa-trash-o"></asp:LinkButton>
                                                    </ItemTemplate>
                                                    <ItemStyle HorizontalAlign="Center"></ItemStyle>
                                                </asp:TemplateField>
                                            </Columns>
                                            <HeaderStyle CssClass="cf head" />
                                        </asp:GridView>
                                    </asp:Panel>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </div>
                    </div>
                </div>

            </ContentTemplate>
        </cc1:TabPanel>
        <cc1:TabPanel ID="TabPanel3" runat="server" CssClass="accordion__content">
            <HeaderTemplate>
                Tehsil
            </HeaderTemplate>
            <ContentTemplate>

                <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                    <ContentTemplate>
                        <div class="row">

                            <div class="col-md-7">
                                <asp:Label ID="lblErrorTerr" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
                                <asp:HiddenField ID="HdnTerritoryID" runat="server" />
                            
                            </div>
                        </div>

                        <div class="row">
                            
                            <div class="col-md-5">
                                <label>
                                    <span class="fa fa-caret-right rgt_cart"></span>District</label>
                                <dx:ASPxComboBox ID="DrpZone" runat="server" AutoPostBack="True"
                                    OnSelectedIndexChanged="DrpZone_SelectedIndexChanged" CssClass="form-control">
                                </dx:ASPxComboBox>
                            </div>
                        </div>
                        <div class="row">
                             <div class="col-md-2">
                                <label><span class="fa fa-caret-right rgt_cart"></span>Code</label>


                            </div>
                            <div class="col-md-5">
                                <label><span class="fa fa-caret-right rgt_cart"></span>Name</label>


                            </div>
                        </div>
                        <div class="row">
                              <div class="col-md-2">
                                <asp:TextBox ID="txtTerritoryCode" runat="server"
                                    CssClass="form-control"></asp:TextBox>
                                  </div>
                            <div class="col-md-5">
                                <asp:TextBox ID="txtTerritoryName" runat="server" CssClass="form-control"></asp:TextBox>


                            </div>
                            <div class="col-md-3">
                                <asp:CheckBox ID="chbIsTerritoryActive" runat="server" Checked="True" Text="Is Active" />
                            </div>
                            <div class="col-md-2">
                                <asp:Button ID="btnSaveTerritory" runat="server" OnClick="btnSaveTerritory_Click"
                                    CssClass="btn btn-success" Text="Save" />
                            </div>


                        </div>

                    </ContentTemplate>
                </asp:UpdatePanel>
                <div class="row">
                    <div class="col-md-12">
                        <div class="emp-table">
                            <asp:UpdatePanel ID="UpdatePanel11" runat="server">
                                <ContentTemplate>
                                    <asp:Panel ID="Panel2" runat="server" ScrollBars="Vertical" Width="100%" Height="150">
                                        <asp:GridView ID="grdTerritoryData" runat="server" Width="100%"
                                            CssClass="table table-striped table-bordered table-hover table-condensed cf" Style="height: 50px;"
                                            AutoGenerateColumns="False" OnRowEditing="grdTerritoryData_RowEditing" OnRowDeleting="grdTerritoryData_RowDeleting">

                                            <Columns>
                                                <asp:BoundField DataField="PARENT_GEO_ID" HeaderText="PARENT_GEO_ID">
                                                    <HeaderStyle CssClass="HidePanel" />
                                                    <ItemStyle CssClass="HidePanel" />
                                                </asp:BoundField>
                                                <asp:BoundField DataField="GEO_ID" HeaderText="GEO_ID">
                                                    <HeaderStyle CssClass="HidePanel" />
                                                    <ItemStyle CssClass="HidePanel" />
                                                </asp:BoundField>
                                                <asp:BoundField DataField="GEO_CODE" HeaderText="Code">
                                                   
                                                </asp:BoundField>
                                                <asp:BoundField DataField="GEO_NAME" HeaderText="Name"></asp:BoundField>
                                                <asp:BoundField DataField="ISCURRENT" HeaderText="Status"></asp:BoundField>
                                                <asp:TemplateField>
                                                    <ItemStyle HorizontalAlign="Center"></ItemStyle>
                                                    <ItemTemplate>
                                                        <asp:LinkButton ID="btnEdit" HorizontalAlign="Center" runat="server" CommandName="Edit"
                                                            CssClass="fa fa-pencil"></asp:LinkButton>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField >
                                                    <ItemTemplate>
                                                        <asp:LinkButton ID="btnDelete" runat="server" OnClientClick="javascript:return confirm('Are you sure you want to Delete?');return false;"
                                                            CommandName="Delete" class="fa fa-trash-o"></asp:LinkButton>
                                                    </ItemTemplate>
                                                    <ItemStyle HorizontalAlign="Center"></ItemStyle>
                                                </asp:TemplateField>
                                            </Columns>
                                            <HeaderStyle CssClass="cf head" />
                                        </asp:GridView>
                                    </asp:Panel>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </div>
                    </div>
                </div>
            </ContentTemplate>
        </cc1:TabPanel>
        <cc1:TabPanel ID="TabPanel4" runat="server" CssClass="accordion__content">
            <HeaderTemplate>
                Constituency
            </HeaderTemplate>
            <ContentTemplate>

                <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                    <ContentTemplate>
                        <div class="row">
                            <div class="col-md-8">
                                <asp:Label ID="lblErrorTown" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
                                <asp:HiddenField ID="HdntownId" runat="server" />
                                
                            </div>
                        </div>
                        <div class="row">
                           
                            <div class="col-md-6">
                                <label>
                                    <span class="fa fa-caret-right rgt_cart"></span>District</label>
                                <dx:ASPxComboBox ID="DrpTownZone" runat="server" AutoPostBack="True"
                                    OnSelectedIndexChanged="DrpTownZone_SelectedIndexChanged" CssClass="form-control">
                                </dx:ASPxComboBox>
                            </div>
                            <div class="col-md-6">
                                <label>
                                    <span class="fa fa-caret-right rgt_cart"></span>Tehsil</label>
                                <dx:ASPxComboBox ID="DrpTerritory" runat="server" AutoPostBack="True"
                                    OnSelectedIndexChanged="DrpTerritory_SelectedIndexChanged" CssClass="form-control">
                                </dx:ASPxComboBox>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-md-2">
                                <label>
                                    <span class="fa fa-caret-right rgt_cart"></span>Code</label>
                            </div>
                            <div class="col-md-5">
                                <label>
                                    <span class="fa fa-caret-right rgt_cart"></span>Name</label>
                            </div>
                        </div>
                        <div class="row">
                             <div class="col-md-2">
                                
                                <asp:TextBox ID="txtTownCode" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                            <div class="col-md-5">
                                <asp:TextBox ID="txtTownName" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                            <div class="col-md-3">
                                <asp:CheckBox ID="chbIsTownActive" runat="server" Checked="True" Text="Is Active" />
                            </div>
                            <div class="col-md-2">

                                <asp:Button ID="btnSaveTown" runat="server" OnClick="btnSaveTown_Click"
                                    CssClass="btn btn-success" Text="Save" />
                            </div>
                        </div>

                    </ContentTemplate>
                </asp:UpdatePanel>
                <div class="row">
                    <div class="col-md-12">
                        <div class="emp-table">
                            <asp:UpdatePanel ID="UpdatePanel15" runat="server">
                                <ContentTemplate>
                                    <asp:Panel ID="Panel3" runat="server" ScrollBars="Vertical" Width="100%" Height="150">
                                        <asp:GridView ID="grdTownData" runat="server" Width="100%"
                                            CssClass="table table-striped table-bordered table-hover table-condensed cf" Style="height: 50px;"
                                            AutoGenerateColumns="False" OnRowEditing="grdTownData_RowEditing"
                                            OnRowDeleting="grdTownData_RowDeleting">

                                            <Columns>
                                                <asp:BoundField DataField="PARENT_GEO_ID" HeaderText="PARENT_GEO_ID">
                                                    <HeaderStyle CssClass="HidePanel" />
                                                    <ItemStyle CssClass="HidePanel" />
                                                </asp:BoundField>
                                                <asp:BoundField DataField="GEO_ID" HeaderText="GEO_ID">
                                                    <HeaderStyle CssClass="HidePanel" />
                                                    <ItemStyle CssClass="HidePanel" />
                                                </asp:BoundField>
                                                <asp:BoundField DataField="GEO_CODE" HeaderText="Code">
                                                    
                                                </asp:BoundField>
                                                <asp:BoundField DataField="GEO_NAME" HeaderText="Name"></asp:BoundField>
                                                <asp:BoundField DataField="ISCURRENT" HeaderText="Status"></asp:BoundField>
                                                <asp:TemplateField>
                                                    <ItemStyle HorizontalAlign="Center"></ItemStyle>
                                                    <ItemTemplate>
                                                        <asp:LinkButton ID="btnEdit" HorizontalAlign="Center" runat="server" CommandName="Edit"
                                                            CssClass="fa fa-pencil"></asp:LinkButton>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField >
                                                    <ItemTemplate>
                                                        <asp:LinkButton ID="btnDelete" runat="server" OnClientClick="javascript:return confirm('Are you sure you want to Delete?');return false;"
                                                            CommandName="Delete" class="fa fa-trash-o"></asp:LinkButton>
                                                    </ItemTemplate>
                                                    <ItemStyle HorizontalAlign="Center"></ItemStyle>
                                                </asp:TemplateField>
                                            </Columns>
                                            <HeaderStyle CssClass="cf head" />
                                        </asp:GridView>
                                    </asp:Panel>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </div>
                    </div>
                </div>
            </ContentTemplate>
        </cc1:TabPanel>
    </cc1:TabContainer>
</asp:Content>
