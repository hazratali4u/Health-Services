using CORNBusinessLayer;
using CORNDataAccessLayer.Request;
using CORNDataAccessLayer.Response;
using Newtonsoft.Json;
using System;
using System.Web.UI;

public partial class Forms_frmSchemeDocuments : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            SchemeDocumentManager manager = new SchemeDocumentManager();
            SchemeDocumentRequest request = new SchemeDocumentRequest();

            request.UserId = UserCommonInfo.LoggedInUserId;

            SchemeDocumentResponse response = manager.SchemeDocumentGetAll(request);

            this.Page.ClientScript.RegisterStartupScript(this.GetType(),
                    "FormsfrmSchemeDocumentsPageLoad",
                    "RC.SchemeDocumentListing.SchemeDocumentList = " + JsonConvert.SerializeObject(response.SchemeDocumentList) + "; ",
                    true);
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "FormsfrmSchemeDocumentsPageLoad", "$(document).ready(function () { alert(\"" + ex.Message + "\"); });", true);
        }
    }
}