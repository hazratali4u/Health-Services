using CORNBusinessLayer;
using CORNDataAccessLayer.Response;
using System;
using System.Linq;
using System.Web;
using System.Web.UI;

public partial class Forms_frmADPComparative : System.Web.UI.Page
{
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
                this.LoadFinancialYear();
            }
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Forms_frmADPComparative", "$(document).ready(function () { alert(\"" + ex.Message + "\"); });", true);
        }
    }
}