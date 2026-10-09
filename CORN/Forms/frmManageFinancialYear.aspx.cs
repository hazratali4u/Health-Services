using CORNBusinessLayer;
using CORNDataAccessLayer.Response;
using Newtonsoft.Json;
using System;
using System.Web.UI;

public partial class Forms_frmManageFinancialYear : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            txtStartDate.Attributes.Add("readonly", "readonly");
            txtEndDate.Attributes.Add("readonly", "readonly");

            FinancialYearManager manager = new FinancialYearManager();
            FinancialYearResponse response = manager.FinancialYearGetAll();

            this.Page.ClientScript.RegisterStartupScript(this.GetType(),
                "FormsfrmManageFinancialYearPageLoad",
                "RC.FinancialYearListing.FinancialYearList = " + JsonConvert.SerializeObject(response.FinancialYearList) + "; ",
                true);
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "FormsfrmManageFinancialYearPageLoad", "$(document).ready(function () { alert(\"" + ex.Message + "\"); });", true);
        }
    }
}