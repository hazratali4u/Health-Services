using CORNBusinessLayer;
using CORNDataAccessLayer.Request;
using CORNDataAccessLayer.Response;
using Newtonsoft.Json;
using System;
using System.Web.UI;

public partial class Forms_frmSchemeFundAllocations : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            SchemeFundAllocationManager manager = new SchemeFundAllocationManager();
            SchemeFundAllocationRequest request = new SchemeFundAllocationRequest();

            request.UserId = UserCommonInfo.LoggedInUserId;

            SchemeFundAllocationResponse response = manager.SchemeFundAllocationGetAll(request);

            this.Page.ClientScript.RegisterStartupScript(this.GetType(),
                    "FormsfrmSchemeFundAllocationsPageLoad",
                    "RC.SchemeFundAllocationListing.SchemeFundAllocationList = " + JsonConvert.SerializeObject(response.SchemeFundAllocationList) + "; ",
                    true);
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "FormsfrmSchemeFundAllocationsPageLoad", "$(document).ready(function () { alert(\"" + ex.Message + "\"); });", true);
        }
    }
}