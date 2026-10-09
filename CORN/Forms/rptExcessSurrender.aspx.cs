using CORNBusinessLayer;
using CORNBusinessLayer.Classes;
using CORNCommon.Classes;
using CORNDataAccessLayer.Response;
using System;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;

public partial class Forms_rptExcessSurrender : System.Web.UI.Page
{
    private void LoadInstitute()
    {
        DistributorController DController = new DistributorController();
        DataTable dt = DController.GetInstituteDetail(Constants.IntNullValue, int.Parse(Session["UserId"].ToString()), 1);

        ddlInstitute.DataSource = dt;
        ddlInstitute.ValueField = "DISTRIBUTOR_ID";
        ddlInstitute.DataBind();

        if (ddlInstitute.Items.Count > 0)
        {
            ddlInstitute.SelectedIndex = 0;
        }
    }
    private void LoadFinancialYear()
    {
        FinancialYearManager manager = new FinancialYearManager();
        FinancialYearResponse response = manager.FinancialYearGetAll();
        //FinancialYear objFinancialYear = new FinancialYear();

        //objFinancialYear.Id = 0;
        //objFinancialYear.YearName = "All";

        //response.FinancialYearList.Insert(0, objFinancialYear);

        ddlFY.DataSource = response.FinancialYearList;
        ddlFY.ValueField = "Id";

        ddlFY.DataBind();

        if (ddlFY.Items.Count > 0)
        {
            int selIndex = 0;
            var objFY = response.FinancialYearList.FirstOrDefault(p => (p.EndDate.Year == DateTime.Now.Year && DateTime.Now.Month <= 6) ||
            (p.StartDate.Year == DateTime.Now.Year && DateTime.Now.Month > 6));

            if (objFY != null)
            {
                selIndex = response.FinancialYearList.IndexOf(objFY);
            }

            ddlFY.SelectedIndex = selIndex;
        }
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
                this.LoadFinancialYear();
                this.LoadScheme();
            }
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Forms_rptExcessSurrender", "$(document).ready(function () { alert(\"" + ex.Message + "\"); });", true);
        }
    }

    protected void btnGenerateReport_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Forms/frmReportViewer.aspx?" +
            "report=12" +
            "&LevelType=" + Request.QueryString["LevelType"] +
            "&LevelID=" + Request.QueryString["LevelID"] +
            "&InstituteId=" + ddlInstitute.Value.ToString() +
            "&SchemeId=" + ddlScheme.Value.ToString() +
            "&FinancialYearId=" + ddlFY.Value.ToString() +
            "&SchemeStatusId=" + ddlSchemeStatus.Value.ToString());
    }
}