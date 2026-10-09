using CORNBusinessLayer;
using CORNDataAccessLayer.Request;
using CORNDataAccessLayer.Response;
using Newtonsoft.Json;
using System;
using System.Web.UI;

public partial class Forms_frmSchemeFundProposals : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            SchemeFundProposalManager manager = new SchemeFundProposalManager();
            SchemeFundProposalRequest request = new SchemeFundProposalRequest();

            request.UserId = UserCommonInfo.LoggedInUserId;

            SchemeFundProposalResponse response = manager.SchemeFundProposalGetAll(request);

            this.Page.ClientScript.RegisterStartupScript(this.GetType(),
                    "FormsfrmSchemeFundProposalsPageLoad",
                    "RC.SchemeFundProposalListing.SchemeFundProposalList = " + JsonConvert.SerializeObject(response.SchemeFundProposalList) + "; ",
                    true);
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "FormsfrmSchemeFundProposalsPageLoad", "$(document).ready(function () { alert(\"" + ex.Message + "\"); });", true);
        }
    }
}