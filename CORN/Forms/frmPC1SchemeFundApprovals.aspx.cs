using CORNBusinessLayer;
using CORNDataAccessLayer.Request;
using CORNDataAccessLayer.Response;
using Newtonsoft.Json;
using System;
using System.Web.UI;

public partial class Forms_frmPC1SchemeFundApprovals : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            PC1SchemeFundApprovalManager manager = new PC1SchemeFundApprovalManager();
            SchemeFundApprovalRequest request = new SchemeFundApprovalRequest();

            request.UserId = UserCommonInfo.LoggedInUserId;

            SchemeFundApprovalResponse response = manager.SchemeFundApprovalGetAll(request);

            this.Page.ClientScript.RegisterStartupScript(this.GetType(),
                    "FormsfrmPC1SchemeFundApprovalsPageLoad",
                    "RC.SchemeFundApprovalListing.SchemeFundApprovalList = " + JsonConvert.SerializeObject(response.SchemeFundApprovalList) + "; ",
                    true);
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "FormsfrmPC1SchemeFundApprovalsPageLoad", "$(document).ready(function () { alert(\"" + ex.Message + "\"); });", true);
        }
    }
}