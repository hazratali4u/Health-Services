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

public partial class Forms_frmSchemeFundProposalAdd : System.Web.UI.Page
{
    private void LoadScheme(long schemeId)
    {
        HealthSchemeController HealthCtl = new HealthSchemeController();
        DataTable dt = new DataTable();

        if (schemeId <= 0)
        {
            dt = HealthCtl.GetScheme(Constants.IntNullValue, 13, schemeId, Convert.ToInt32(Session["UserID"]));
        }
        else
        {
            dt = HealthCtl.GetScheme(Constants.IntNullValue, 2, schemeId);
        }

        ddlScheme.DataSource = dt;
        ddlScheme.ValueField = "lngSchemeCode";

        ddlScheme.DataBind();

        if (ddlScheme.Items.Count > 0)
        {
            ddlScheme.SelectedIndex = 0;
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

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetExpires(DateTime.Now.AddSeconds(-1));
            Response.Cache.SetNoStore();
            Response.AppendHeader("pragma", "no-cache");
            txtProposedDate.Attributes.Add("readonly", "readonly");

            if (!Page.IsPostBack)
            {
                long schemeFundProposalId = 0;
                long schemeId = 0;

                long.TryParse(Request.QueryString["Id"], out schemeFundProposalId);

                SchemeFundProposalManager manager = new SchemeFundProposalManager();
                SchemeFundProposal objSchemeFundProposal = null;

                if (schemeFundProposalId > 0)
                {
                    SchemeFundProposalRequest request = new SchemeFundProposalRequest();

                    request.Id = schemeFundProposalId;

                    SchemeFundProposalResponse response = manager.SchemeFundProposalGetId(request);

                    objSchemeFundProposal = response.SchemeFundProposalObject;
                    schemeId = objSchemeFundProposal.lngSchemeID;
                }

                this.LoadScheme(schemeId);
                this.LoadFinancialYear();
                this.LoadAccountDetail();

                if (schemeFundProposalId > 0)
                {
                    SetScheme(objSchemeFundProposal.lngSchemeID);
                }

                this.Page.ClientScript.RegisterStartupScript(this.GetType(),
                        "FormsfrmSchemeFundProposalAddPageLoad",
                        "RC.ManageSchemeFundProposal.SchemeFundProposalObject = " + JsonConvert.SerializeObject(objSchemeFundProposal) + "; ",
                        true);
            }
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "FormsfrmSchemeFundProposalAddPageLoad", "$(document).ready(function () { alert(\"" + ex.Message + "\"); });", true);
        }
    }
}