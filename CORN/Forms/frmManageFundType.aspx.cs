using System;
using System.Web.UI;
using CORNBusinessLayer;
using CORNDataAccessLayer.Response;
using Newtonsoft.Json;

public partial class Forms_frmSchemeFundType : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            FundTypeManager manager = new FundTypeManager();
            FundTypeResponse response = manager.FundTypeGetAll();

            this.Page.ClientScript.RegisterStartupScript(this.GetType(),
                "FormsfrmSchemeFundTypePageLoad",
                "RC.FundTypeListing.FundTypeList = " + JsonConvert.SerializeObject(response.FundTypeList) + "; ",
                true);
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "FormsfrmSchemeFundTypePageLoad", "$(document).ready(function () { alert(\"" + ex.Message + "\"); });", true);
        }
    }
}