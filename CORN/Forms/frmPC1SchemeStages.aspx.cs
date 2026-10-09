using CORNBusinessLayer;
using CORNDataAccessLayer.Request;
using CORNDataAccessLayer.Response;
using Newtonsoft.Json;
using System;
using System.Web.UI;

public partial class Forms_frmPC1SchemeStages : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            PC1SchemeStageManager manager = new PC1SchemeStageManager();
            SchemeStageRequest request = new SchemeStageRequest();

            request.UserId = UserCommonInfo.LoggedInUserId;

            SchemeStageResponse response = manager.SchemeStageGetAll(request);

            this.Page.ClientScript.RegisterStartupScript(this.GetType(),
                    "FormsfrmPC1SchemeStagesPageLoad",
                    "RC.SchemeStageListing.SchemeStageList = " + JsonConvert.SerializeObject(response.SchemeStageList) + "; ",
                    true);
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "FormsfrmPC1SchemeStagesPageLoad", "$(document).ready(function () { alert(\"" + ex.Message + "\"); });", true);
        }
    }
}