using System;
using System.Web.UI;
using CORNBusinessLayer;
using CORNDataAccessLayer.Response;
using Newtonsoft.Json;
using CORNDataAccessLayer.Request;

public partial class Forms_frmExpesneSurrender : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            SchemeExcessManager manager = new SchemeExcessManager();
            SchemeExcessRequest request = new SchemeExcessRequest();

            request.UserId = UserCommonInfo.LoggedInUserId;

            SchemeExcessResponse response = manager.SchemeExcessGetAll(request);

            this.Page.ClientScript.RegisterStartupScript(this.GetType(),
                    "FormsfrmSchemeExcesssPageLoad",
                    "RC.SchemeExcessListing.SchemeExcessList = " + JsonConvert.SerializeObject(response.SchemeExcessList) + "; ",
                    true);
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "FormsfrmSchemeExcesssPageLoad", "$(document).ready(function () { alert(\"" + ex.Message + "\"); });", true);
        }
    }
}