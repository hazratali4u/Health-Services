using CORNBusinessLayer.Classes;
using CORNCommon.Classes;
using System;
using System.Data;
using System.Web;
using System.Web.UI;

public partial class Forms_frmReportOptions : System.Web.UI.Page
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
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Forms_frmReportOptions", "$(document).ready(function () { alert(\"" + ex.Message + "\"); });", true);
        }
    }

    protected void btnGenerateReport_Click(object sender, EventArgs e)
    {
        if (ddlReport.SelectedIndex <= 0)
        {
            Response.Redirect("~/Forms/frmReportViewer.aspx?" +
            "report=1" +
            "&LevelType=" + Request.QueryString["LevelType"] +
            "&LevelID=" + Request.QueryString["LevelID"] +
            "&InstituteId=" + ddlInstitute.Value.ToString() +
            "&SchemeId=" + ddlScheme.Value.ToString() +
            "&Year=" + ddlYear.Value.ToString() +
            "&Month=" + ddlMonth.Value.ToString() +
            "&SchemeStatusId=" + ddlSchemeStatus.Value.ToString());
        }
        else
        {
            RptSchemeController RptSchemeCtl = new RptSchemeController();

            DataTable dt = RptSchemeCtl.GetSchemTestReport(Constants.DateNullValue);

            CORNBusinessLayer.Reports.crSchemeTest CrpReport = new CORNBusinessLayer.Reports.crSchemeTest();
            CrpReport.SetDataSource(dt);
            CrpReport.Refresh();
            this.Session.Add("CrpReport", CrpReport);
            this.Session.Add("ReportType", 0);
            string url = "'Default.aspx'";
            string script = "<script language='JavaScript' type='text/javascript'> window.open(" + url + ",\"Link\",\"toolbar=0,location=0,directories=0,status=0,menubar=0,scrollbars=1,resizable=1,width=800,height=600,left=10,top=10\");</script>";
            Type cstype = this.GetType();
            ClientScriptManager cs = Page.ClientScript;
            cs.RegisterStartupScript(cstype, "OpenWindow", script);
        }
    }

    protected void ddlReport_SelectedIndexChanged(object sender, EventArgs e)
    {
        btnGenerateReport.Enabled = true;
        divRow.Visible = true;
        if (ddlReport.SelectedIndex > 0)
        {
            btnGenerateReport.Enabled = false;
            divRow.Visible = false;
        }
    }
}