using System;
using System.Web.UI;
using CORNBusinessLayer;
using CORNDataAccessLayer.Response;
using Newtonsoft.Json;

public partial class Forms_Sponsoring : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            SponsoringManager manager = new SponsoringManager();
            SponsoringResponse response = manager.SponsoringGetAll();

            this.Page.ClientScript.RegisterStartupScript(this.GetType(),
                "FormsSponsoringPageLoad",
                "RC.SponsoringListing.SponsoringList = " + JsonConvert.SerializeObject(response.SponsoringList) + "; ",
                true);
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "FormsSponsoringPageLoad", "$(document).ready(function () { alert(\"" + ex.Message + "\"); });", true);
        }
    }
}