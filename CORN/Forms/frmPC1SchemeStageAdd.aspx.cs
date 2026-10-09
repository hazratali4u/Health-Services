using CORNBusinessLayer;
using CORNDataAccessLayer;
using CORNDataAccessLayer.Request;
using CORNDataAccessLayer.Response;
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;

public partial class Forms_frmPC1SchemeStageAdd : System.Web.UI.Page
{
    private void LoadScheme()
    {
        PC1SchemeManager manager = new PC1SchemeManager();
        SchemeRequest request = new SchemeRequest();

        request.CategoryId = 1;
        request.SchemeIds = string.Empty;
        request.UserId = UserCommonInfo.LoggedInUserId;

        SchemeResponse response = manager.SchemeGetAll(request);
        List<Scheme> lstScheme = response.SchemeList;
        ddlScheme.DataSource = lstScheme;
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
            ScriptManager.RegisterStartupScript(this, this.GetType(), "FormsfrmPC1SchemeStageAddPageLoad", "$(document).ready(function () { alert(\"" + ex.Message + "\"); });", true);
        }
    }
}