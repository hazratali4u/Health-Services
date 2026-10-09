using System;
using System.Web.UI;
using CORNBusinessLayer;
using CORNDataAccessLayer.Response;
using Newtonsoft.Json;

public partial class Forms_frmSchemeApprovedBy : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            ApprovedByManager manager = new ApprovedByManager();
            ApprovedByResponse response = manager.ApprovedByGetAll();

            this.Page.ClientScript.RegisterStartupScript(this.GetType(),
                "FormsfrmSchemeApprovedByPageLoad",
                "RC.ApprovedByListing.ApprovedByList = " + JsonConvert.SerializeObject(response.ApprovedByList) + "; ",
                true);
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "FormsfrmSchemeApprovedByPageLoad", "$(document).ready(function () { alert(\"" + ex.Message + "\"); });", true);
        }
    }
}