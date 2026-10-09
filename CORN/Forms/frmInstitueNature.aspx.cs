using System;
using System.Web.UI;
using CORNBusinessLayer;
using CORNDataAccessLayer.Response;
using Newtonsoft.Json;

public partial class Forms_frmSchemeInstituteNature : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            InstituteNatureManager manager = new InstituteNatureManager();
            InstituteNatureResponse response = manager.InstituteNatureGetAll();

            this.Page.ClientScript.RegisterStartupScript(this.GetType(),
                "FormsfrmSchemeInstituteNaturePageLoad",
                "RC.InstituteNatureListing.InstituteNatureList = " + JsonConvert.SerializeObject(response.InstituteNatureList) + "; ",
                true);
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "FormsfrmSchemeInstituteNaturePageLoad", "$(document).ready(function () { alert(\"" + ex.Message + "\"); });", true);
        }
    }
}