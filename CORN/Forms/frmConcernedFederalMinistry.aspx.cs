using System;
using System.Web.UI;
using CORNBusinessLayer;
using CORNDataAccessLayer.Response;
using Newtonsoft.Json;

public partial class Forms_ConcernedFederalMinistry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            ConcernedFederalMinistryManager manager = new ConcernedFederalMinistryManager();
            ConcernedFederalMinistryResponse response = manager.ConcernedFederalMinistryGetAll();

            this.Page.ClientScript.RegisterStartupScript(this.GetType(),
                "FormsConcernedFederalMinistryPageLoad",
                "RC.ConcernedFederalMinistryListing.ConcernedFederalMinistryList = " + JsonConvert.SerializeObject(response.ConcernedFederalMinistryList) + "; ",
                true);
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "FormsConcernedFederalMinistryPageLoad", "$(document).ready(function () { alert(\"" + ex.Message + "\"); });", true);
        }
    }
}