using CORNBusinessLayer;
using CORNBusinessLayer.Classes;
using CORNCommon.Classes;
using CORNDataAccessLayer;
using CORNDataAccessLayer.Request;
using CORNDataAccessLayer.Response;
using DevExpress.Web;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;

public partial class Forms_frmSchemeAdd : System.Web.UI.Page
{
    List<Distributor> lstDistributor = new List<Distributor>();

    private void LoadInstitute()
    {
        DistributorController DController = new DistributorController();
        DataTable dtInstituteDetail = DController.GetInstituteDetail(Constants.IntNullValue, int.Parse(Session["UserId"].ToString()), 1);

        ddlInstitute.DataSource = dtInstituteDetail;
        ddlInstitute.ValueField = "DISTRIBUTOR_ID";
        lstDistributor = dtInstituteDetail.ToList<Distributor>();

        ddlInstitute.DataBind();

        if (ddlInstitute.Items.Count > 0)
        {
            ddlInstitute.SelectedIndex = 0;
        }
    }
    private void LoadSchemeCategory()
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
        dr1[1] = "New";
        dr2[0] = 2;
        dr2[1] = "On-going";
        dr3[0] = 3;
        dr3[1] = "Supplementary";
        dr4[0] = 4;
        dr4[1] = "Unfunded";

        if (string.IsNullOrEmpty(Request.QueryString["mode"]))
        {
            dt.Rows.Add(dr1);
            dt.Rows.Add(dr2);
            dt.Rows.Add(dr3);
            dt.Rows.Add(dr4);
        }
        else if (Request.QueryString["mode"] == "MPR")
        {
            dt.Rows.Add(dr3);
            dt.Rows.Add(dr4);
        }
        else if (Request.QueryString["mode"] == "ADP")
        {
            dt.Rows.Add(dr1);
        }

        ddlCategory.DataSource = dt;
        ddlCategory.ValueField = "Id";

        ddlCategory.DataBind();

        if (ddlCategory.Items.Count > 0)
        {
            ddlCategory.SelectedIndex = 0;
        }
    }
    private void LoadSubSector()
    {
        DistributorRouteController RouteCtl = new DistributorRouteController();
        DataTable dt = new DataTable();

        dt = RouteCtl.GetSubSector(Constants.IntNullValue, 2);

        ddlSubSector.DataSource = dt;
        ddlSubSector.ValueField = "SubSector_ID";

        ddlSubSector.DataBind();

        if (ddlSubSector.Items.Count > 0)
        {
            ddlSubSector.SelectedIndex = 0;
        }
    }
    private void LoadAccountDetail()
    {
        AccountHeadController mAccountController = new AccountHeadController();
        DataTable dtHead = mAccountController.SelectAccountHead(Constants.AC_AccountHeadId, Constants.LongNullValue, 1, Constants.Account_Form_FunctionalClass);
        DataRow dr = dtHead.NewRow();

        dr["ACCOUNT_HEAD_ID"] = 0;
        dr["ACCOUNT_CODE"] = "None";
        dr["ACCOUNT_NAME"] = "None";

        dtHead.Rows.InsertAt(dr, 0);

        ddlCOA.DataSource = dtHead;
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
    }
    private void LoadParentScheme()
    {
        HealthSchemeController HealthCtl = new HealthSchemeController();
        DataTable dt = new DataTable();

        dt = HealthCtl.GetScheme(Constants.IntNullValue, 9, Convert.ToInt32(Session["UserID"]));
        ddlParentScheme.DataSource = dt;
        ddlParentScheme.ValueField = "lngSchemeCode";

        ddlParentScheme.DataBind();

        if (ddlParentScheme.Items.Count > 0)
        {
            ddlParentScheme.SelectedIndex = 0;
        }
    }
    private void SetInstitute(long instituteId)
    {
        foreach (ListEditItem item in ddlInstitute.Items)
        {
            if (Convert.ToInt64(item.Value) == instituteId)
            {
                item.Selected = true;
            }
            else
            {
                item.Selected = false;
            }
        }
    }
    private void SetSchemeCategory(long categoryId)
    {
        foreach (ListEditItem item in ddlCategory.Items)
        {
            if (Convert.ToInt64(item.Value) == categoryId)
            {
                item.Selected = true;
            }
            else
            {
                item.Selected = false;
            }
        }
    }
    private void SetSubSector(long subSectorId)
    {
        foreach (ListEditItem item in ddlSubSector.Items)
        {
            if (Convert.ToInt64(item.Value) == subSectorId)
            {
                item.Selected = true;
            }
            else
            {
                item.Selected = false;
            }
        }
    }
    private void SetAccountDetail(long fcAccountHeadId, long rfcAccountHeadId)
    {
        foreach (ListEditItem item in ddlCOA.Items)
        {
            if (Convert.ToInt64(item.Value) == fcAccountHeadId)
            {
                item.Selected = true;
            }
            else
            {
                item.Selected = false;
            }
        }

        foreach (ListEditItem item in ddlRCOA.Items)
        {
            if (Convert.ToInt64(item.Value) == rfcAccountHeadId)
            {
                item.Selected = true;
            }
            else
            {
                item.Selected = false;
            }
        }
    }
    private void SetTypeOfBank(long bankTypeId)
    {
        foreach (ListEditItem item in ddlTypeOfBank.Items)
        {
            if (Convert.ToInt64(item.Value) == bankTypeId)
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
    private void SetParentScheme(long parentSchemeId)
    {
        foreach (ListEditItem item in ddlParentScheme.Items)
        {
            if (Convert.ToInt64(item.Value) == parentSchemeId)
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
            int fyStartYear = DateTime.Now.Year;

            if (DateTime.Now.Month < 7)
            {
                fyStartYear = DateTime.Now.AddYears(-1).Year;
            }

            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetExpires(DateTime.Now.AddSeconds(-1));
            Response.Cache.SetNoStore();
            Response.AppendHeader("pragma", "no-cache");
            txtStartDate.Attributes.Add("readonly", "readonly");
            txtEndDate.Attributes.Add("readonly", "readonly");
            txtSchemeDate.Attributes.Add("readonly", "readonly");
            txtSchemeDate.Text = DateTime.Now.ToString("dd-MMM-yyyy");

            if (System.Configuration.ConfigurationManager.AppSettings["Domain"] == "PU")
            {
                lblSpendingUnit.Text = "Spending Unit";
                lblGSCode.InnerText = "Year Wise GS Code";
                lblSAPCapital.InnerText = "SAP Capital Code & Cost";
                lblSAPRevenue.InnerText = "SAP Revenue Code & Cost";
            }
            else
            {
                lblSpendingUnit.Text = "Select District / Constitutency";
                lblGSCode.InnerText = "Year Wise ADP Number";
                lblSAPCapital.InnerText = "Scheme Code";
                lblSAPRevenue.InnerText = "SAP Revenue Code";
                txtCapitalAmount.Visible = false;
                txtRevenueAmount.Visible = false;
                dvYearlyCost.Visible = false;
                dvSAPRevenue.Visible = false;
                dvTypeOfBand.Visible = false;
            }

            if (!Page.IsPostBack)
            {
                if (!string.IsNullOrEmpty(Request.QueryString["mode"]))
                {
                    if (Request.QueryString["mode"] == "ADP")
                    {
                        if (DateTime.Now.Month >= 7)
                        {
                            hfNextFYYear.Value = DateTime.Now.AddYears(1).Year.ToString();
                        }
                        else
                        {
                            hfNextFYYear.Value = DateTime.Now.Year.ToString();
                        }
                    }
                }

                long schemeId = 0;

                long.TryParse(Request.QueryString["Id"], out schemeId);

                SchemeManager manager = new SchemeManager();
                SchemeGSCodeManager gsManager = new SchemeGSCodeManager();
                SchemeRequest request = new SchemeRequest();
                SchemeGSCodeRequest gsRequest = new SchemeGSCodeRequest();
                Scheme objScheme = null;
                List<SchemeGSCode> lstSchemeGSCode = new List<SchemeGSCode>();

                if (schemeId > 0)
                {
                    request.Id = schemeId;
                    gsRequest.SchemeId = schemeId;

                    SchemeResponse response = manager.SchemeGetId(request);
                    SchemeGSCodeResponse gsResponse = gsManager.SchemeGSCodeGetSchemeId(gsRequest);

                    objScheme = response.SchemeObject;
                    lstSchemeGSCode = gsResponse.SchemeGSCodeList;
                }

                this.LoadInstitute();
                this.LoadSchemeCategory();
                this.LoadSubSector();
                this.LoadAccountDetail();
                this.LoadParentScheme();

                if (schemeId > 0)
                {
                    SetInstitute(objScheme.intInstituteID);
                    SetSchemeCategory(objScheme.intCategoryID);
                    SetSchemeCategory(objScheme.intCategoryID);
                    SetSubSector(objScheme.intSubSectorID);
                    SetAccountDetail(objScheme.intFCAccountHeadID, objScheme.intRFCAccountHeadID);
                    SetTypeOfBank(objScheme.intBankTypeID);
                    SetSchemeStatus(objScheme.SchemeStatusId);
                    SetParentScheme(objScheme.ParentSchemeId);
                }

                AppConfigRequest acRequest = new AppConfigRequest();

                acRequest.Id = 2;

                AppConfigManager acManager = new AppConfigManager();
                AppConfigResponse acResponse = acManager.AppConfigGetId(acRequest);

                if (acResponse.AppConfigObject != null)
                {
                    bool propValue = Convert.ToBoolean(acResponse.AppConfigObject.propValue);

                    if (propValue)
                    {
                        dvSchemeStatus.Visible = true;
                    }
                    else
                    {
                        dvSchemeStatus.Visible = false;
                    }
                }

                this.Page.ClientScript.RegisterStartupScript(this.GetType(),
                        "FormsfrmSchemeAddPageLoad",
                        "RC.ManageScheme.SchemeObject = " + JsonConvert.SerializeObject(objScheme) + "; " +
                        "RC.ManageScheme.SchemeFY = \"" + fyStartYear.ToString() + "-" + (fyStartYear + 1).ToString() + "\"; " +
                        "RC.ManageScheme.DistributorList = " + JsonConvert.SerializeObject(lstDistributor) + "; " +
                        "RC.ManageScheme.SchemeGSCodeList = " + JsonConvert.SerializeObject(lstSchemeGSCode) + "; ",
                        true);
            }
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "FormsfrmSchemeAddPageLoad", "$(document).ready(function () { alert(\"" + ex.Message + "\"); });", true);
        }
    }
}