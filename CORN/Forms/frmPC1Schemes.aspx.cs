using CORNBusinessLayer;
using CORNDataAccessLayer;
using CORNDataAccessLayer.Request;
using CORNDataAccessLayer.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Web.UI;

public partial class Forms_frmPC1Schemes : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            PC1SchemeManager manager = new PC1SchemeManager();
            SchemeRequest request = new SchemeRequest();

            request.CategoryId = Convert.ToInt64(Request.QueryString["categoryId"]);
            request.SchemeIds = string.Empty;
            request.UserId = UserCommonInfo.LoggedInUserId;

            SchemeResponse response = manager.SchemeGetAll(request);
            List<Scheme> lstScheme = response.SchemeList;

            this.Page.ClientScript.RegisterStartupScript(this.GetType(),
                    "FormsfrmPC1SchemesPageLoad",
                    "RC.SchemeListing.SchemeList = " + JsonConvert.SerializeObject(lstScheme) + "; ",
                    true);
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "FormsfrmPC1SchemesPageLoad", "$(document).ready(function () { alert(\"" + ex.Message + "\"); });", true);
        }
    }
}