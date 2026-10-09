using CORNBusinessLayer.Classes;
using CORNCommon.Classes;
using System;
using System.Data;
using System.Web;
using System.Web.UI;

public partial class Forms_frmNewMPR : System.Web.UI.Page
{
    private void LoadInstitute()
    {
        DistributorController DController = new DistributorController();
        DataTable dt = DController.GetInstituteDetail(Constants.IntNullValue, int.Parse(Session["UserId"].ToString()), 1);
        DataRow dr = dt.NewRow();

        dr["DISTRIBUTOR_ID"] = 0;
        dr["DISTRIBUTOR_NAME"] = "All";
        dr["TYPENAME"] = "All";
        dr["District"] = "All";
        dr["Tehsil"] = "All";
        dr["Constituency"] = "All";

        dt.Rows.InsertAt(dr, 0);

        ddlInstitute.DataSource = dt;
        ddlInstitute.ValueField = "DISTRIBUTOR_ID";
        ddlInstitute.DataBind();

        if (ddlInstitute.Items.Count > 0)
        {
            ddlInstitute.SelectedIndex = 0;
        }

        int year = 2000;

        while (year <= DateTime.Now.Year)
        {
            ddlYear.Items.Add(new DevExpress.Web.ListEditItem(year.ToString(), year));
            year++;
        }

        if (ddlYear.Items.Count > 0)
        {
            ddlYear.SelectedIndex = (ddlYear.Items.Count - 1);
        }

        int currentMonth = DateTime.Now.Month;

        ddlMonth.SelectedIndex = (currentMonth - 1);
    }
    private void LoadScheme()
    {
        HealthSchemeController HealthCtl = new HealthSchemeController();
        DataTable dt = HealthCtl.GetScheme(Constants.IntNullValue, 6, Constants.LongNullValue, Convert.ToInt32(Session["UserID"]));
        DataRow dr = dt.NewRow();

        dr["lngSchemeCode"] = 0;
        dr["strSchemeName"] = "All";
        dr["DISTRIBUTOR_NAME"] = "All";
        dr["ACCOUNT_NAME"] = "All";

        dt.Rows.InsertAt(dr, 0);

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
            if (!Page.IsPostBack)
            {
                this.LoadInstitute();
                this.LoadScheme();
            }
            Response.Expires = 0;
            Response.Cache.SetNoStore();

            if (System.Configuration.ConfigurationManager.AppSettings["Domain"] == "PU")
            {
                btnInstitue.Value = "Institue";
                lblInstitue.InnerText = "Spending Unit";
            }
            else
            {
                btnInstitue.Value = "Constituency";
                lblInstitue.InnerText = "Select Constituency";
            }
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Forms_frmNewMPR", "$(document).ready(function () { alert(\"" + ex.Message + "\"); });", true);
        }
    }

    protected void btnGenerateReport_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Forms/frmReportViewer.aspx?" +
            "report=13" +
            "&LevelType=" + Request.QueryString["LevelType"] +
            "&LevelID=" + Request.QueryString["LevelID"] +
            "&InstituteId=" + ddlInstitute.Value.ToString() +
            "&SchemeId=" + ddlScheme.Value.ToString() +
            "&Year=" + ddlYear.Value.ToString() +
            "&Month=" + ddlMonth.Value.ToString() +
            "&SchemeStatusId=" + ddlSchemeStatus.Value.ToString());
    }
}