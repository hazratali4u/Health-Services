using System;
using System.Web.UI;
using CORNBusinessLayer;
using CORNDataAccessLayer.Response;
using Newtonsoft.Json;

public partial class Forms_OperationMaintenance : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            OperationMaintenanceManager manager = new OperationMaintenanceManager();
            OperationMaintenanceResponse response = manager.OperationMaintenanceGetAll();

            this.Page.ClientScript.RegisterStartupScript(this.GetType(),
                "FormsOperationMaintenancePageLoad",
                "RC.OperationMaintenanceListing.OperationMaintenanceList = " + JsonConvert.SerializeObject(response.OperationMaintenanceList) + "; ",
                true);
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "FormsOperationMaintenancePageLoad", "$(document).ready(function () { alert(\"" + ex.Message + "\"); });", true);
        }
    }
}