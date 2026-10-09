using System;
using System.Data;
using System.Web.UI;
using CORNBusinessLayer.Classes;
using CORNCommon.Classes;
using System.Web;
using DevExpress.Web;
using CORNBusinessLayer;
using CORNDataAccessLayer;
using CORNDataAccessLayer.Request;
using CORNDataAccessLayer.Response;
using Newtonsoft.Json;
using System.Linq;
using System.Collections.Generic;

public partial class Forms_frmSchemeReapproiationAdd : System.Web.UI.Page
{
    private void LoadScheme()
    {
        HealthSchemeController HealthCtl = new HealthSchemeController();
        DataTable dt = new DataTable();

        dt = HealthCtl.GetScheme(Constants.IntNullValue, 6, Constants.LongNullValue, Convert.ToInt32(Session["UserID"]));
        ddlFScheme.DataSource = dt;
        ddlFScheme.ValueField = "lngSchemeCode";

        ddlFScheme.DataBind();

        if (ddlFScheme.Items.Count > 0)
        {
            ddlFScheme.SelectedIndex = 0;
        }

        ddlTScheme.DataSource = dt;
        ddlTScheme.ValueField = "lngSchemeCode";

        ddlTScheme.DataBind();

        if (ddlTScheme.Items.Count > 0)
        {
            ddlTScheme.SelectedIndex = 0;
        }
    }
    private void LoadFinancialYear()
    {
        FinancialYearManager manager = new FinancialYearManager();
        FinancialYearResponse response = manager.FinancialYearGetAll();

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
    private void LoadMonth()
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
        DataRow dr5 = dt.NewRow();
        DataRow dr6 = dt.NewRow();
        DataRow dr7 = dt.NewRow();
        DataRow dr8 = dt.NewRow();
        DataRow dr9 = dt.NewRow();
        DataRow dr10 = dt.NewRow();
        DataRow dr11 = dt.NewRow();
        DataRow dr12 = dt.NewRow();

        dr1[0] = 1;
        dr1[1] = "January";
        dr2[0] = 2;
        dr2[1] = "February";
        dr3[0] = 3;
        dr3[1] = "March";
        dr4[0] = 4;
        dr4[1] = "April";
        dr5[0] = 5;
        dr5[1] = "May";
        dr6[0] = 6;
        dr6[1] = "June";
        dr7[0] = 7;
        dr7[1] = "July";
        dr8[0] = 8;
        dr8[1] = "August";
        dr9[0] = 9;
        dr9[1] = "September";
        dr10[0] = 10;
        dr10[1] = "October";
        dr11[0] = 11;
        dr11[1] = "November";
        dr12[0] = 12;
        dr12[1] = "December";

        dt.Rows.Add(dr1);
        dt.Rows.Add(dr2);
        dt.Rows.Add(dr3);
        dt.Rows.Add(dr4);
        dt.Rows.Add(dr5);
        dt.Rows.Add(dr6);
        dt.Rows.Add(dr7);
        dt.Rows.Add(dr8);
        dt.Rows.Add(dr9);
        dt.Rows.Add(dr10);
        dt.Rows.Add(dr11);
        dt.Rows.Add(dr12);

        ddlMonth.DataSource = dt;
        ddlMonth.ValueField = "Id";

        ddlMonth.DataBind();

        if (ddlMonth.Items.Count > 0)
        {
            int currentMonth = DateTime.Now.Month;

            ddlMonth.SelectedIndex = (currentMonth - 1);
        }
    }
    private void LoadToFundType()
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

        dr1[0] = 1;
        dr1[1] = "Capital";
        dr2[0] = 2;
        dr2[1] = "Revenue";
        dr3[0] = 3;
        dr3[1] = "Foreign Funding";

        dt.Rows.Add(dr1);
        dt.Rows.Add(dr2);
        dt.Rows.Add(dr3);

        ddlTFundType.DataSource = dt;
        ddlTFundType.ValueField = "Id";

        ddlTFundType.DataBind();

        if (ddlTFundType.Items.Count > 0)
        {
            ddlTFundType.SelectedIndex = 1;
        }
    }
    private void LoadAccountDetail()
    {
        if (ddlFScheme.SelectedItem != null)
        {
            AccountHeadController mAccountController = new AccountHeadController();
            DataTable dtHead = mAccountController.SelectAccountHeadNew(Constants.AC_AccountHeadId, Constants.LongNullValue, 5, Constants.Account_Form_COA, Convert.ToInt64(ddlFScheme.SelectedItem.Value));

            ddlFCOA.DataSource = dtHead;
            ddlFCOA.ValueField = "ACCOUNT_HEAD_ID";

            ddlFCOA.DataBind();

            if (ddlFCOA.Items.Count > 0)
            {
                ddlFCOA.SelectedIndex = 0;
            }
        }

        if (ddlTScheme.SelectedItem != null)
        {
            AccountHeadController mAccountController = new AccountHeadController();
            DataTable dtHead = mAccountController.SelectAccountHeadNew(Constants.AC_AccountHeadId, Constants.LongNullValue, 4, Constants.Account_Form_COA, Convert.ToInt64(ddlTScheme.SelectedItem.Value));

            ddlTCOA.DataSource = dtHead;
            ddlTCOA.ValueField = "ACCOUNT_HEAD_ID";

            ddlTCOA.DataBind();

            if (ddlTCOA.Items.Count > 0)
            {
                ddlTCOA.SelectedIndex = 0;
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
    private void SetMonth(int month)
    {
        foreach (ListEditItem item in ddlMonth.Items)
        {
            if (Convert.ToInt64(item.Value) == month)
            {
                item.Selected = true;
            }
            else
            {
                item.Selected = false;
            }
        }
    }

    private List<FundType> LoadFromFundType()
    {
        FundTypeManager manager = new FundTypeManager();
        FundTypeResponse response = manager.FundTypeGetAll();

        ddlFFundType.DataSource = response.FundTypeList;

        ddlFFundType.ValueField = "Id";
        ddlFFundType.DataBind();

        if (ddlFFundType.Items.Count > 0)
        {
            ddlFFundType.SelectedIndex = 0;
        }

        return response.FundTypeList;
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetExpires(DateTime.Now.AddSeconds(-1));
            Response.Cache.SetNoStore();
            Response.AppendHeader("pragma", "no-cache");
            txtFromTransactionDate.Attributes.Add("readonly", "readonly");
            txtToTransactionDate.Attributes.Add("readonly", "readonly");

            txtFromTransactionDate.Text = DateTime.Now.ToString("dd-MMM-yyyy");
            txtToTransactionDate.Text = DateTime.Now.ToString("dd-MMM-yyyy");

            if (!Page.IsPostBack)
            {
                this.LoadScheme();
                this.LoadFinancialYear();
                this.LoadMonth();
                this.LoadToFundType();
                this.LoadAccountDetail();

                List<FundType> lstFundType = this.LoadFromFundType();
                SchemeReappropriationManager manager = new SchemeReappropriationManager();
                SchemeReappropriation objSchemeReappropriation = null;

                if (!string.IsNullOrEmpty(Request.QueryString["Id"]))
                {
                    SchemeReappropriationRequest request = new SchemeReappropriationRequest();

                    request.Id = Convert.ToInt64(Request.QueryString["Id"]);

                    SchemeReappropriationResponse response = manager.SchemeReappropriationGetId(request);

                    objSchemeReappropriation = response.SchemeReappropriationObject;

                    SetSchemeFinancialYear(objSchemeReappropriation.FinancialYearId);
                    SetMonth(objSchemeReappropriation.Month);
                }

                this.Page.ClientScript.RegisterStartupScript(this.GetType(),
                        "FormsfrmSchemeReappropriationAddPageLoad",
                        "RC.ManageSchemeReappropriation.SchemeReappropriationObject = " + JsonConvert.SerializeObject(objSchemeReappropriation) + "; " +
                        "RC.ManageSchemeReappropriation.FundTypeList = " + JsonConvert.SerializeObject(lstFundType) + "; ",
                        true);
            }
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "FormsfrmSchemeReappropriationAddPageLoad", "$(document).ready(function () { alert(\"" + ex.Message + "\"); });", true);
        }
    }
}