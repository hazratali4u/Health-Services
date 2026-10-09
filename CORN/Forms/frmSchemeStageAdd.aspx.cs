using CORNBusinessLayer;
using CORNBusinessLayer.Classes;
using CORNCommon.Classes;
using CORNDataAccessLayer.Response;
using System;
using System.Data;
using System.Web;
using System.Web.UI;

public partial class Forms_frmSchemeStageAdd : System.Web.UI.Page
{
    private void LoadScheme()
    {
        HealthSchemeController HealthCtl = new HealthSchemeController();
        DataTable dt = new DataTable();

        dt = HealthCtl.GetScheme(Constants.IntNullValue, 5, Constants.LongNullValue, Convert.ToInt32(Session["UserID"]));
        ddlScheme.DataSource = dt;
        ddlScheme.ValueField = "lngSchemeCode";

        ddlScheme.DataBind();

        if (ddlScheme.Items.Count > 0)
        {
            ddlScheme.SelectedIndex = 0;
        }
    }
    private void StageStatus()
    {
        SchemeStageStatusManager manager = new SchemeStageStatusManager();
        SchemeStageStatusResponse response = manager.SchemeStageStatusGetAll();

        ddlStageStatus.DataSource = response.SchemeStageStatusList;
        ddlStageStatus.ValueField = "Id";

        ddlStageStatus.DataBind();

        if (ddlStageStatus.Items.Count > 0)
        {
            ddlStageStatus.SelectedIndex = 0;
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
            txtStageDate.Attributes.Add("readonly", "readonly");

            if (!Page.IsPostBack)
            {
                this.LoadScheme();
                this.StageStatus();
            }
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "FormsfrmSchemeStageAddPageLoad", "$(document).ready(function () { alert(\"" + ex.Message + "\"); });", true);
        }
    }
}