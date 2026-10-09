using CORNBusinessLayer;
using CORNDataAccessLayer.Response;
using Newtonsoft.Json;
using System;
using System.Web.UI;

public partial class Forms_frmGroups : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            GroupManager manager = new GroupManager();
            GroupResponse response = manager.GroupGetAll();

            this.Page.ClientScript.RegisterStartupScript(this.GetType(),
                    "FormsfrmGroupsPageLoad",
                    "RC.GroupListing.GroupList = " + JsonConvert.SerializeObject(response.GroupList) + "; ",
                    true);
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "FormsfrmGroupsPageLoad", "$(document).ready(function () { alert(\"" + ex.Message + "\"); });", true);
        }
    }
}