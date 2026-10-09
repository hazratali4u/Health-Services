using CORNBusinessLayer;
using CORNBusinessLayer.Classes;
using CORNCommon.Classes;
using CORNDataAccessLayer;
using CORNDataAccessLayer.Request;
using CORNDataAccessLayer.Response;
using DevExpress.Web;
using Newtonsoft.Json;
using System;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.UI;

public partial class Forms_frmSchemeFundAllocationAdd : System.Web.UI.Page
{
    private void LoadScheme()
    {
        HealthSchemeController HealthCtl = new HealthSchemeController();
        DataTable dt = new DataTable();

        dt = HealthCtl.GetScheme(Constants.IntNullValue, 10, Constants.LongNullValue, Convert.ToInt32(Session["UserID"]));
        ddlScheme.DataSource = dt;
        ddlScheme.ValueField = "lngSchemeCode";

        ddlScheme.DataBind();

        if (ddlScheme.Items.Count > 0)
        {
            ddlScheme.SelectedIndex = 0;
        }
    }
    private void LoadFundAllocationType()
    {
        DataTable dt = new DataTable();
        DataColumn dcId = new DataColumn();
        DataColumn dcTitle = new DataColumn();

        dcId.ColumnName = "Id";
        dcTitle.ColumnName = "Title";

        dt.Columns.Add(dcId);
        dt.Columns.Add(dcTitle);

        DataRow dr1 = dt.NewRow();
        DataRow dr2 = dt.NewRow();

        dr1[0] = 1;
        dr1[1] = "ADP Allocation";
        dr2[0] = 2;
        dr2[1] = "Supplementary";

        dt.Rows.Add(dr1);
        dt.Rows.Add(dr2);

        ddlFundAllocationType.DataSource = dt;
        ddlFundAllocationType.ValueField = "Id";

        ddlFundAllocationType.DataBind();

        if (ddlFundAllocationType.Items.Count > 0)
        {
            ddlFundAllocationType.SelectedIndex = 0;
        }
    }
    private void LoadFinancialYear()
    {
        if (ddlScheme.SelectedItem != null)
        {
            FinancialYearRequest request = new FinancialYearRequest();

            request.SchemeId = Convert.ToInt64(ddlScheme.SelectedItem.Value);
            request.SchemeFetchMode = 2;

            FinancialYearManager manager = new FinancialYearManager();
            FinancialYearResponse response = manager.FinancialYearGetSchemeId(request);

            ddlFY.DataSource = response.FinancialYearList;
            ddlFY.ValueField = "Id";
            ddlFY.DataBind();
            if (ddlFY.Items.Count > 0)
            {
                ddlFY.SelectedIndex = 0;
                ddlFY.Value = ddlFY.SelectedItem.Value;
            }
        }
    }
    private void LoadAccountDetail()
    {
        if (ddlScheme.SelectedItem != null)
        {
            AccountHeadController mAccountController = new AccountHeadController();
            DataTable dtHead = mAccountController.SelectAccountHeadNew(Constants.AC_AccountHeadId, Constants.LongNullValue, 4, Constants.Account_Form_COA, Convert.ToInt64(ddlScheme.SelectedItem.Value));

            if (ConfigurationManager.AppSettings["Domain"] == "PU")
            {
                DataView dv = new DataView(dtHead);
                string query = "ACCOUNT_CODE LIKE '%a12%'";

                dv.RowFilter = query;

                DataTable dt = dv.ToTable();

                ddlCOA.DataSource = dt;
            }
            else
            {
                ddlCOA.DataSource = dtHead;
            }

            ddlCOA.ValueField = "ACCOUNT_HEAD_ID";

            ddlCOA.DataBind();

            if (ddlCOA.Items.Count > 0)
            {
                ddlCOA.SelectedIndex = 0;
            }

            ddlRCOA.DataSource = dtHead;
            ddlRCOA.ValueField = "ACCOUNT_HEAD_ID";

            ddlRCOA.DataBind();

            if (ddlRCOA.Items.Count > 0)
            {
                ddlRCOA.SelectedIndex = 0;
            }

            ddlFFCOA.DataSource = dtHead;
            ddlFFCOA.ValueField = "ACCOUNT_HEAD_ID";

            ddlFFCOA.DataBind();

            if (ddlFFCOA.Items.Count > 0)
            {
                ddlFFCOA.SelectedIndex = 0;
            }
        }
    }
    private void SetScheme(long schemeId)
    {
        foreach (ListEditItem item in ddlScheme.Items)
        {
            if (Convert.ToInt64(item.Value) == schemeId)
            {
                item.Selected = true;
            }
            else
            {
                item.Selected = false;
            }
        }
    }
    private void SetFundAllocationType(long fundAllocationTypeId)
    {
        foreach (ListEditItem item in ddlFundAllocationType.Items)
        {
            if (Convert.ToInt64(item.Value) == fundAllocationTypeId)
            {
                item.Selected = true;
            }
            else
            {
                item.Selected = false;
            }
        }
    }
    private void SetSchemeFinancialYear(long schemeFinancialYearId)
    {
        foreach (ListEditItem item in ddlFY.Items)
        {
            if (Convert.ToInt64(item.Value) == schemeFinancialYearId)
            {
                item.Selected = true;
            }
            else
            {
                item.Selected = false;
            }
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
            txtAllocationDate.Attributes.Add("readonly", "readonly");

            if (!Page.IsPostBack)
            {
                long schemeFundAllocationId = 0;
                long schemeId = 0;

                long.TryParse(Request.QueryString["Id"], out schemeFundAllocationId);

                SchemeFundAllocationManager manager = new SchemeFundAllocationManager();
                SchemeFundAllocation objSchemeFundAllocation = null;

                if (schemeFundAllocationId > 0)
                {
                    SchemeFundAllocationRequest request = new SchemeFundAllocationRequest();

                    request.Id = schemeFundAllocationId;

                    SchemeFundAllocationResponse response = manager.SchemeFundAllocationGetId(request);

                    objSchemeFundAllocation = response.SchemeFundAllocationObject;
                    schemeId = objSchemeFundAllocation.SchemeId;
                }

                this.LoadScheme();

                if (schemeId > 0)
                {
                    SetScheme(schemeId);
                }

                this.LoadFundAllocationType();
                this.LoadFinancialYear();
                this.LoadAccountDetail();

                if (schemeFundAllocationId > 0)
                {
                    SetFundAllocationType(objSchemeFundAllocation.FundAllocationTypeId);
                    SetSchemeFinancialYear(objSchemeFundAllocation.FinancialYearId);
                }

                this.Page.ClientScript.RegisterStartupScript(this.GetType(),
                        "FormsfrmSchemeFundAllocationAddPageLoad",
                        "RC.ManageSchemeFundAllocation.SchemeFundAllocationObject = " + JsonConvert.SerializeObject(objSchemeFundAllocation) + "; ",
                        true);
            }
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "FormsfrmSchemeFundAllocationAddPageLoad", "$(document).ready(function () { alert(\"" + ex.Message + "\"); });", true);
        }
    }
}