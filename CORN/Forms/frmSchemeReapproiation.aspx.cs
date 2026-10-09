using System;
using System.Web.UI;
using CORNBusinessLayer;
using CORNDataAccessLayer.Response;
using Newtonsoft.Json;
using CORNDataAccessLayer.Request;

public partial class Forms_frmSchemeReapproiation : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            SchemeReappropriationManager manager = new SchemeReappropriationManager();
            SchemeReappropriationRequest request = new SchemeReappropriationRequest();

            request.UserId = UserCommonInfo.LoggedInUserId;

            SchemeReappropriationResponse response = manager.SchemeReappropriationGetAll(request);

            this.Page.ClientScript.RegisterStartupScript(this.GetType(),
                    "FormsfrmSchemeReappropriationsPageLoad",
                    "RC.SchemeReappropriationListing.SchemeReappropriationList = " + JsonConvert.SerializeObject(response.SchemeReappropriationList) + "; ",
                    true);
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "FormsfrmSchemeReappropriationsPageLoad", "$(document).ready(function () { alert(\"" + ex.Message + "\"); });", true);
        }
    }
}