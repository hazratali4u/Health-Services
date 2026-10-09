using System;
using System.Web.UI;
using CORNBusinessLayer;
using CORNDataAccessLayer.Response;
using Newtonsoft.Json;

public partial class Forms_Execution : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            ExecutionManager manager = new ExecutionManager();
            ExecutionResponse response = manager.ExecutionGetAll();

            this.Page.ClientScript.RegisterStartupScript(this.GetType(),
                "FormsExecutionPageLoad",
                "RC.ExecutionListing.ExecutionList = " + JsonConvert.SerializeObject(response.ExecutionList) + "; ",
                true);
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "FormsExecutionPageLoad", "$(document).ready(function () { alert(\"" + ex.Message + "\"); });", true);
        }
    }
}