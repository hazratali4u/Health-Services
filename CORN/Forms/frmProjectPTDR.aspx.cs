using CORNBusinessLayer.Classes;
using CORNCommon.Classes;
using System;
using System.Data;
using System.Web;
using System.Web.UI;

public partial class Forms_frmProjectPTDR : System.Web.UI.Page
{
    private void LoadScheme()
    {
        HealthSchemeController HealthCtl = new HealthSchemeController();
        DataTable dt = HealthCtl.GetScheme(Constants.IntNullValue, 6, Constants.LongNullValue, Convert.ToInt32(Session["UserID"]));

        ddlScheme.DataSource = dt;
        ddlScheme.ValueField = "lngSchemeCode";

        ddlScheme.DataBind();

        if (ddlScheme.Items.Count > 0)
        {
            ddlScheme.SelectedIndex = 0;
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetExpires(DateTime.Now.AddSeconds(-1));
            Response.Cache.SetNoStore();
            Response.AppendHeader("pragma", "no-cache");
            txtStartDate.Attributes.Add("readonly", "readonly");
            txtEndDate.Attributes.Add("readonly", "readonly");
            txtStartDate.Text = DateTime.Now.ToString("dd-MMM-yyyy");
            txtEndDate.Text = DateTime.Now.ToString("dd-MMM-yyyy");

            if (!Page.IsPostBack)
            {
                this.LoadScheme();
            }
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Forms_frmProjectPTDRPageLoad", "$(document).ready(function () { alert(\"" + ex.Message + "\"); });", true);
        }
    }
}