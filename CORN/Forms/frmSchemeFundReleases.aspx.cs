using CORNBusinessLayer;
using CORNDataAccessLayer.Request;
using CORNDataAccessLayer.Response;
using Newtonsoft.Json;
using System;
using System.Web.UI;

public partial class Forms_frmSchemeFundReleases : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            SchemeFundReleaseManager manager = new SchemeFundReleaseManager();
            SchemeFundReleaseRequest request = new SchemeFundReleaseRequest();

            request.UserId = UserCommonInfo.LoggedInUserId;

            SchemeFundReleaseResponse response = manager.SchemeFundReleaseGetAll(request);

            this.Page.ClientScript.RegisterStartupScript(this.GetType(),
                    "FormsfrmSchemeFundReleasesPageLoad",
                    "RC.SchemeFundReleaseListing.SchemeFundReleaseList = " + JsonConvert.SerializeObject(response.SchemeFundReleaseList) + "; ",
                    true);
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "FormsfrmSchemeFundReleasesPageLoad", "$(document).ready(function () { alert(\"" + ex.Message + "\"); });", true);
        }
    }
}