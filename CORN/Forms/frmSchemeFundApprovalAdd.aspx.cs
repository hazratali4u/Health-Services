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

public partial class Forms_frmSchemeFundApprovalAdd : System.Web.UI.Page
{
    private void LoadScheme(long schemeId)
    {
        HealthSchemeController HealthCtl = new HealthSchemeController();
        DataTable dt = new DataTable();

        if (ConfigurationManager.AppSettings["Domain"] == "PU")
        {
            dt = HealthCtl.GetScheme(Constants.IntNullValue, 14, schemeId, Convert.ToInt32(Session["UserID"]));
        }
        else
        {
            dt = HealthCtl.GetScheme(Constants.IntNullValue, 7, schemeId, Convert.ToInt32(Session["UserID"]));
        }

        ddlScheme.DataSource = dt;
        ddlScheme.ValueField = "lngSchemeCode";

        ddlScheme.DataBind();

        if (ddlScheme.Items.Count > 0)
        {
            ddlScheme.SelectedIndex = 0;
        }
    }
    private void LoadSchemeStatus()
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
        DataRow dr3 = dt.NewRow();
        DataRow dr4 = dt.NewRow();

        dr1[0] = 1;
        dr1[1] = "Approved";
        dr2[0] = 2;
        dr2[1] = "Rejected";
        dr3[0] = 3;
        dr3[1] = "Pending";
        dr4[0] = 4;
        dr4[1] = "Revision";
        dr4[0] = 5;
        dr4[1] = "Un-Approved";

        dt.Rows.Add(dr1);
        dt.Rows.Add(dr2);
        dt.Rows.Add(dr3);
        dt.Rows.Add(dr4);

        ddlSchemeStatus.DataSource = dt;
        ddlSchemeStatus.ValueField = "Id";

        ddlSchemeStatus.DataBind();

        if (ddlSchemeStatus.Items.Count > 0)
        {
            ddlSchemeStatus.SelectedIndex = 0;
        }
    }
    private void LoadEmployee()
    {
        ApprovedByManager manager = new ApprovedByManager();
        ApprovedByResponse response = manager.ApprovedByGetAll();

        ddlEmployee.DataSource = response.ApprovedByList;
        ddlEmployee.ValueField = "Id";

        ddlEmployee.DataBind();

        if (ddlEmployee.Items.Count > 0)
        {
            ddlEmployee.SelectedIndex = 0;
        }
    }
    private void LoadFinancialYear()
    {
        if (ddlScheme.SelectedItem != null)
        {
            FinancialYearRequest request = new FinancialYearRequest();

            request.SchemeId = Convert.ToInt64(ddlScheme.SelectedItem.Value);
            request.SchemeFetchMode = 1;

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
        AccountHeadController mAccountController = new AccountHeadController();
        DataTable dtHead = mAccountController.SelectAccountHead(Constants.AC_AccountHeadId, Constants.LongNullValue, 1, Constants.Account_Form_COA);

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
    private void SetSchemeStatus(long schemeStatusId)
    {
        foreach (ListEditItem item in ddlSchemeStatus.Items)
        {
            if (Convert.ToInt64(item.Value) == schemeStatusId)
            {
                item.Selected = true;
            }
            else
            {
                item.Selected = false;
            }
        }
    }
    private void SetEmployee(long employeeId)
    {
        foreach (ListEditItem item in ddlEmployee.Items)
        {
            if (Convert.ToInt64(item.Value) == employeeId)
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
            txtStatusDate.Attributes.Add("readonly", "readonly");

            if (!Page.IsPostBack)
            {
                long schemeFundApprovalId = 0;
                long schemeId = 0;

                long.TryParse(Request.QueryString["Id"], out schemeFundApprovalId);

                SchemeFundApprovalManager manager = new SchemeFundApprovalManager();
                SchemeFundApproval objSchemeFundApproval = null;

                if (schemeFundApprovalId > 0)
                {
                    SchemeFundApprovalRequest request = new SchemeFundApprovalRequest();

                    request.Id = schemeFundApprovalId;

                    SchemeFundApprovalResponse response = manager.SchemeFundApprovalGetId(request);

                    objSchemeFundApproval = response.SchemeFundApprovalObject;
                    schemeId = objSchemeFundApproval.SchemeId;
                }

                this.LoadScheme(schemeId);
                this.LoadSchemeStatus();
                this.LoadEmployee();
                this.LoadFinancialYear();
                this.LoadAccountDetail();

                if (schemeFundApprovalId > 0)
                {
                    SetScheme(objSchemeFundApproval.SchemeId);
                    SetSchemeStatus(objSchemeFundApproval.StatusId);
                    SetEmployee(objSchemeFundApproval.ApprovedBy);
                }

                this.Page.ClientScript.RegisterStartupScript(this.GetType(),
                        "FormsfrmSchemeFundApprovalAddPageLoad",
                        "RC.ManageSchemeFundApproval.SchemeFundApprovalObject = " + JsonConvert.SerializeObject(objSchemeFundApproval) + "; ",
                        true);
            }
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "FormsfrmSchemeFundApprovalAddPageLoad", "$(document).ready(function () { alert(\"" + ex.Message + "\"); });", true);
        }
    }
}