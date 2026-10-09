using System;
using System.Data;
using System.Web.UI;
using CORNBusinessLayer.Classes;
using CORNCommon.Classes;
using System.Web;
using CORNBusinessLayer;
using Newtonsoft.Json;
using CORNDataAccessLayer;
using CORNDataAccessLayer.Request;
using CORNDataAccessLayer.Response;
using DevExpress.Web;
using System.Configuration;

public partial class Forms_frmExpesneBookingAdd : System.Web.UI.Page
{
    private void LoadScheme()
    {
        HealthSchemeController HealthCtl = new HealthSchemeController();
        DataTable dt = new DataTable();

        dt = HealthCtl.GetScheme(Constants.IntNullValue, 11, Constants.LongNullValue, Convert.ToInt32(Session["UserID"]));
        ddlScheme.DataSource = dt;
        ddlScheme.ValueField = "lngSchemeCode";

        ddlScheme.DataBind();

        if (ddlScheme.Items.Count > 0)
        {
            ddlScheme.SelectedIndex = 0;
        }
    }
    private void LoadFundExpenseType()
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
        dr1[1] = "Capital";
        dr2[0] = 2;
        dr2[1] = "Revenue";

        dt.Rows.Add(dr1);
        dt.Rows.Add(dr2);

        ddlExpenseType.DataSource = dt;
        ddlExpenseType.ValueField = "Id";

        ddlExpenseType.DataBind();

        if (ddlExpenseType.Items.Count > 0)
        {
            ddlExpenseType.SelectedIndex = 1;
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

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetExpires(DateTime.Now.AddSeconds(-1));
            Response.Cache.SetNoStore();
            Response.AppendHeader("pragma", "no-cache");
            txtExpenseDate.Attributes.Add("readonly", "readonly");
            txtPaymentDue.Attributes.Add("readonly", "readonly");
            txtExpenseDate.Text = DateTime.Now.ToString("dd-MMM-yyyy");
            UserCommonInfo.ResetExpenseBookingInfoInSession();

            if (!Page.IsPostBack)
            {
                long schemeExpenseId = 0;
                long schemeId = 0;

                long.TryParse(Request.QueryString["Id"], out schemeExpenseId);

                SchemeExpenseBookingManager manager = new SchemeExpenseBookingManager();
                SchemeExpenseBooking objSchemeExpenseBooking = null;

                if (schemeExpenseId > 0)
                {
                    SchemeExpenseBookingRequest request = new SchemeExpenseBookingRequest();

                    request.Id = schemeExpenseId;

                    SchemeExpenseBookingResponse response = manager.SchemeExpenseBookingGetId(request);

                    objSchemeExpenseBooking = response.SchemeExpenseBookingObject;
                    schemeId = objSchemeExpenseBooking.SchemeId;

                    if (System.Configuration.ConfigurationManager.AppSettings["Domain"] == "PU")
                    {
                        dvReference.Visible = true;
                        dvPOReferenceActual.Visible = true;
                    }
                    else
                    {
                        dvReference.Visible = false;
                        dvPOReferenceActual.Visible = false;
                    }
                }
                else
                {
                    if (System.Configuration.ConfigurationManager.AppSettings["Domain"] == "PU")
                    {
                        btnCommitment.Visible = true;
                        dvReference.Visible = true;
                        dvPOReferenceActual.Visible = true;
                    }
                    else
                    {
                        btnCommitment.Visible = false;
                        dvReference.Visible = false;
                        dvPOReferenceActual.Visible = false;
                    }
                }

                this.LoadScheme();

                if (schemeId > 0)
                {
                    SetScheme(schemeId);
                }

                this.LoadFundExpenseType();
                this.LoadAccountDetail();

                SchemePOReferenceNoManager porManager = new SchemePOReferenceNoManager();
                SchemePOReferenceNoResponse porResponse = porManager.SchemeExpenseBookingGetAll();

                this.Page.ClientScript.RegisterStartupScript(this.GetType(),
                        "FormsfrmExpesneBookingAddPageLoad",
                        "RC.ManageSchemeExpenseBooking.SchemeExpenseBookingObject = " + JsonConvert.SerializeObject(objSchemeExpenseBooking) + "; " +
                        "RC.ManageSchemeExpenseBooking.SchemePOReferenceNoList = " + JsonConvert.SerializeObject(porResponse.SchemePOReferenceNoList) + "; ",
                        true);
            }
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "FormsfrmExpesneBookingAddPageLoad", "$(document).ready(function () { alert(\"" + ex.Message + "\"); });", true);
        }
    }
}