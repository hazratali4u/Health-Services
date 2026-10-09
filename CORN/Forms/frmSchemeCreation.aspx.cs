using System;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;
using CORNBusinessLayer.Classes;
using CORNCommon.Classes;
using System.Web;

/// <summary>
/// From to Add, Edit Employee
/// </summary>
public partial class Forms_frmSchemeCreation : System.Web.UI.Page
{
    HealthSchemeController HealthCtl = new HealthSchemeController();
    GeoHierarchyController GControler = new GeoHierarchyController();
    DistributorRouteController RouteCtl = new DistributorRouteController();
    DataControl dc = new DataControl();
    static int UserId;

    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Cache.SetCacheability(HttpCacheability.NoCache);
        Response.Cache.SetExpires(DateTime.Now.AddSeconds(-1));
        Response.Cache.SetNoStore();
        Response.AppendHeader("pragma", "no-cache");
        if (!Page.IsPostBack)
        {
            txtStartDate.Attributes.Add("readonly", "readonly");
            txtEndDate.Attributes.Add("readonly", "readonly");
            txtSchemeDate.Attributes.Add("readonly", "readonly");
            txtStartDate.Text = Convert.ToDateTime(Session["CurrentWorkDate"]).ToString("dd-MMM-yyyy");
            txtEndDate.Text = Convert.ToDateTime(Session["CurrentWorkDate"]).ToString("dd-MMM-yyyy");
            txtSchemeDate.Text = Convert.ToDateTime(Session["CurrentWorkDate"]).ToString("dd-MMM-yyyy");

            this.LoadInstitute();
            this.LoadSchemeCategory();
            this.LoadSubSector();
            this.LoadAccountDetail();
            this.LoadGrid("");
            btnSave.Attributes.Add("onclick", "return ValidateForm()");

            int fyStartYear = DateTime.Now.Year;

            if (DateTime.Now.Month >= 7)
            {
                fyStartYear = DateTime.Now.AddYears(1).Year;
            }

            btnPromoteSchemes.Attributes.Add("onclick", "javascript:return confirm('Are you sure you want to promote the selected schemes for FY " +
                fyStartYear.ToString() + " - " + (fyStartYear + 1).ToString() +
                "?'); return false;");

            DataTable dtInstituteDetail = (DataTable)Session["dtInstituteDetail"];

            if (ddlInstitute.Items.Count > 0)
            {
                ddlInstitute.SelectedIndex = 0;
                txtDistrict.Text = dtInstituteDetail.Rows[0]["District"].ToString();
                txtTehsil.Text = dtInstituteDetail.Rows[0]["Tehsil"].ToString();
            }

            if (ddlCOA.Items.Count > 0)
            {
                ddlCOA.SelectedIndex = 0;
            }

            if (ddlRCOA.Items.Count > 0)
            {
                ddlRCOA.SelectedIndex = 0;
            }

            if (ddlSubSector.Items.Count > 0)
            {
                ddlSubSector.SelectedIndex = 0;
            }

            if (ddlCategory.Items.Count > 0)
            {
                ddlCategory.SelectedIndex = 0;
            }

            int userRoleId = Convert.ToInt32(Session["RoleID"]);

            if (userRoleId != 1)
            {
                ddlSchemeCategory.Visible = false;
                btnStatus.Visible = false;
            }

            if (userRoleId != 1 && userRoleId != 2)
            {
                btnActive.Visible = false;
            }

            if (userRoleId != 1 && userRoleId != 2 && userRoleId != 3)
            {
                gvScheme.Columns[gvScheme.Columns.Count - 1].Visible = false;
            }
        }

        Response.Expires = 0;
        Response.Cache.SetNoStore();
    }

    private void LoadGrid(string pType)
    {
        DataTable dt = new DataTable();

        dt = HealthCtl.GetScheme(Constants.IntNullValue, 3, Convert.ToInt32(Session["UserID"]));
        

        if (!string.IsNullOrEmpty(Request.QueryString["mode"]))
        {
            if (Request.QueryString["mode"] == "MPR")
            {
                DataView dv = new DataView(dt);
                string query = "dtmStartDate <= #" + DateTime.Now.ToShortDateString() + "#";

                dv.RowFilter = query;
                dt = dv.ToTable();

                btnExport.Visible = false;
            }
            else if (Request.QueryString["mode"] == "ADP")
            {
                DataView dv = new DataView(dt);
                string query = "IsActive LIKE 'Active' AND (ThrowForward > 1 OR intCategoryID = 1)";

                dv.RowFilter = query;
                dt = dv.ToTable();

                if (DateTime.Now.Month >= 7)
                {
                    hfNextFYYear.Value = DateTime.Now.AddYears(1).Year.ToString();
                }
                else
                {
                    hfNextFYYear.Value = DateTime.Now.Year.ToString();
                }

                btnExport.Visible = true;
            }
        }

        if (pType == "")
        {
            if (txtSearch.Text != "" || txtSearch.Text != string.Empty)
            {
                dt.DefaultView.RowFilter = "strSchemeName LIKE '%" + txtSearch.Text + "%'  OR strSchemeCode LIKE '%" + txtSearch.Text + "%' OR IsActive LIKE '" + txtSearch.Text + " %'";// OR strRevenueCode LIKE '%" + txtSearch.Text + "%'";
            }
            gvScheme.DataSource = dt;
            gvScheme.DataBind();
        }
        else
        {
            if (txtSearch.Text != "" || txtSearch.Text != string.Empty)
            {
                dt.DefaultView.RowFilter = "strSchemeName LIKE '%" + txtSearch.Text + "%'  OR strSchemeCode LIKE '%" + txtSearch.Text + "%' OR IsActive LIKE '" + txtSearch.Text + " %'";//  OR strRevenueCode LIKE '%" + txtSearch.Text + "%'";
            }
            if (dt.Rows.Count > 0)
            {
                gvScheme.PageIndex = 0;
            }
            gvScheme.DataSource = dt;
            gvScheme.DataBind();
        }

        int userRoleId = Convert.ToInt32(Session["RoleID"]);

        if (userRoleId == 1)
        {
            btnPromoteSchemes.Visible = true;
        }
        else
        {
            btnPromoteSchemes.Visible = false;
        }
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {

        try
        {
            if (Page.IsValid)
            {
                int id = 0;
                string errorMessage = string.Empty;

                if (string.IsNullOrEmpty(txtSchemeName.Text.Trim()))
                {
                    SaveDXState();
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "Alert", "alert('Please provide scheme name.');", true);
                    mPopUpLocation.Show();
                    return;
                }
                //if (string.IsNullOrEmpty(txtRevenueCode.Text.Trim()))
                //{
                //    SaveDXState();
                //    ScriptManager.RegisterStartupScript(this, typeof(Page), "Alert", "alert('Please provide revenue code.');", true);
                //    mPopUpLocation.Show();
                //    return;
                //}
                //if (string.IsNullOrEmpty(txtGSCode.Text.Trim()))
                //{
                //    SaveDXState();
                //    ScriptManager.RegisterStartupScript(this, typeof(Page), "Alert", "alert('Please provide gs code.');", true);
                //    mPopUpLocation.Show();
                //    return;
                //}
                //if (ddlFinancialYear.Value == null)
                //{
                //    SaveDXState();
                //    ScriptManager.RegisterStartupScript(this, typeof(Page), "Alert", "alert('Please provide financial year.');", true);
                //    mPopUpLocation.Show();
                //    return;
                //}
                else if (Convert.ToInt32(ddlCOA.Value) == 0 && Convert.ToInt32(ddlRCOA.Value) == 0)
                {
                    SaveDXState();
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "Alert", "alert('Please provide Functional Classification (Capital) or Functional Classification (Revenue).');", true);
                    mPopUpLocation.Show();
                    return;
                }

                if (Session["SchemeID"] != null)
                {
                    id = Convert.ToInt32(Session["SchemeID"]);
                }

                errorMessage = HealthCtl.CheckDuplicateScheme(id, txtSchemeName.Text.Replace("&nbsp;", "").Replace("&amp;", "").Replace("nbsp;", ""),
                    txtCapitalCode.Text.Replace("&nbsp;", "").Replace("&amp;", "").Replace("nbsp;", ""), txtRevenueCode.Text.Replace("&nbsp;", "").Replace("&amp;", "").Replace("nbsp;", ""),
                    txtGSCode.Text.Replace("&nbsp;", "").Replace("&amp;", "").Replace("nbsp;", ""), Convert.ToDateTime(ddlFinancialYear.Value.ToString() + "-" + "01" + "-01"));

                if (!string.IsNullOrEmpty(errorMessage))
                {
                    SaveDXState();
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "Alert", "alert('" + errorMessage + "');", true);
                    mPopUpLocation.Show();
                    return;
                }

                if (btnSave.Text == "Save")
                {
                    bool _result = HealthCtl.InsertScheme(txtSchemeName.Text, txtRevenueCode.Text.Replace("&nbsp;", "").Replace("&amp;", "").Replace("nbsp;", ""),
                        Convert.ToInt32(ddlInstitute.Value), Convert.ToInt32(ddlSubSector.Value), Convert.ToInt32(ddlCategory.Value),
                        Convert.ToInt32(ddlCOA.Value), Convert.ToInt32(ddlRCOA.Value), Convert.ToInt32(ddlTypeOfBank.Value), Convert.ToDecimal(dc.chkNull_0(txtRecurringCostPercent.Text)),
                        Convert.ToDecimal(dc.chkNull_0(txtRecurringCostAmount.Text.Replace("Rs.", "").Replace(" ", "").Replace(",", ""))), Convert.ToDateTime(txtSchemeDate.Text), Convert.ToDateTime(txtStartDate.Text),
                        Convert.ToDateTime(txtEndDate.Text), Convert.ToInt32(Session["UserID"]), txtRemarks.Text.Replace("&nbsp;", "").Replace("&amp;", "").Replace("nbsp;", ""),
                        txtCapitalCode.Text.Replace("&nbsp;", "").Replace("&amp;", "").Replace("nbsp;", ""), Convert.ToDecimal(dc.chkNull_0(txtRevenueAmount.Text.Replace("Rs.", "").Replace(" ", "").Replace(",", ""))),
                        Convert.ToDecimal(dc.chkNull_0(txtCapitalAmount.Text.Replace("Rs.", "").Replace(" ", "").Replace(",", ""))), Convert.ToDateTime(ddlFinancialYear.Value.ToString() + "-" + "01" + "-01"),
                        txtGSCode.Text.Replace("&nbsp;", "").Replace("&amp;", "").Replace("nbsp;", ""), Convert.ToDecimal(dc.chkNull_0(txtLastYearExpense.Text.Replace("Rs.", "").Replace(" ", "").Replace(",", ""))));
                    if (_result)
                    {
                        ClearAll();
                        SaveDXState();
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "Alert", "alert('Scheme added successfully.');", true);
                        mPopUpLocation.Show();
                    }
                }
                else if (btnSave.Text == "Update")
                {
                    bool _result = HealthCtl.UpdateScheme(Convert.ToInt64(Session["SchemeID"]), txtSchemeName.Text, txtRevenueCode.Text.Replace("&nbsp;", "").Replace("&amp;", "").Replace("nbsp;", ""),
                        Convert.ToInt32(ddlInstitute.Value), Convert.ToInt32(ddlSubSector.Value), Convert.ToInt32(ddlCategory.Value),
                        Convert.ToInt32(ddlCOA.Value), Convert.ToInt32(ddlRCOA.Value), Convert.ToInt32(ddlTypeOfBank.Value), Convert.ToDecimal(dc.chkNull_0(txtRecurringCostPercent.Text)),
                        Convert.ToDecimal(dc.chkNull_0(txtRecurringCostAmount.Text.Replace("Rs.", "").Replace(" ", "").Replace(",", ""))), Convert.ToDateTime(txtSchemeDate.Text), Convert.ToDateTime(txtStartDate.Text),
                        Convert.ToDateTime(txtEndDate.Text), Convert.ToInt32(Session["UserID"]), txtRemarks.Text.Replace("&nbsp;", "").Replace("&amp;", "").Replace("nbsp;", ""), true, false,
                        txtCapitalCode.Text.Replace("&nbsp;", "").Replace("&amp;", "").Replace("nbsp;", ""), Convert.ToDecimal(dc.chkNull_0(txtRevenueAmount.Text.Replace("Rs.", "").Replace(" ", "").Replace(",", ""))),
                        Convert.ToDecimal(dc.chkNull_0(txtCapitalAmount.Text.Replace("Rs.", "").Replace(" ", "").Replace(",", ""))), Convert.ToDateTime(ddlFinancialYear.Value.ToString() + "-" + "01" + "-01"),
                        txtGSCode.Text.Replace("&nbsp;", "").Replace("&amp;", "").Replace("nbsp;", ""), Convert.ToDecimal(dc.chkNull_0(txtLastYearExpense.Text.Replace("Rs.", "").Replace(" ", "").Replace(",", ""))));
                    if (_result)
                    {
                        ClearAll();
                        SaveDXState();
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "Alert", "alert('Scheme updated successfully.');", true);
                        mPopUpLocation.Hide();
                    }
                }
                LoadGrid("");
                btnSave.Text = "Save";
            }
            else
            {
                mPopUpLocation.Show();
            }
        }
        catch (Exception ex)
        {
            SaveDXState();
            ScriptManager.RegisterStartupScript(this, typeof(Page), "CatchMsg", "alert('" + ex.Message.ToString() + "');", true);
            mPopUpLocation.Show();
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        ClearAll();
        mPopUpLocation.Show();
    }

    protected void btnFilter_Click(object sender, EventArgs e)
    {
        this.LoadGrid("filter");
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        SaveDXState();
        ClearAll();
        mPopUpLocation.Show();
    }
    protected void btnActive_Click(object sender, EventArgs e)
    {
        bool check = false;
        try
        {
            foreach (GridViewRow dr2 in gvScheme.Rows)
            {
                var chRelized2 = (CheckBox)dr2.Cells[0].FindControl("ChbIsAssigned");
                if (chRelized2.Checked)
                {
                    check = true;
                    break;
                }
            }
            if (!check)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "msg", "alert('Please select scheme first');", true);
                return;
            }

            bool flag = false;

            foreach (GridViewRow dr in gvScheme.Rows)
            {
                var chRelized = (CheckBox)dr.Cells[0].FindControl("ChbIsAssigned");

                if (chRelized.Checked)
                {
                    if (dr.Cells[6].Text == "Active")
                    {
                        flag = HealthCtl.UpdateScheme(Convert.ToInt64(dr.Cells[1].Text), null, null, Constants.IntNullValue, Constants.IntNullValue
                          , Constants.IntNullValue, Constants.IntNullValue, Constants.IntNullValue, Constants.IntNullValue, Constants.DecimalNullValue
                          , Constants.DecimalNullValue, Constants.DateNullValue, Constants.DateNullValue, Constants.DateNullValue, Convert.ToInt32(Session["UserID"]), null, false, false, null, Constants.DecimalNullValue, Constants.DecimalNullValue, Constants.DateNullValue, null, Constants.DecimalNullValue);
                    }
                    else
                    {
                        flag = HealthCtl.UpdateScheme(Convert.ToInt64(dr.Cells[1].Text), null, null, Constants.IntNullValue, Constants.IntNullValue
                          , Constants.IntNullValue, Constants.IntNullValue, Constants.IntNullValue, Constants.IntNullValue, Constants.DecimalNullValue
                          , Constants.DecimalNullValue, Constants.DateNullValue, Constants.DateNullValue, Constants.DateNullValue, Convert.ToInt32(Session["UserID"]), null, true, false, null, Constants.DecimalNullValue, Constants.DecimalNullValue, Constants.DateNullValue, null, Constants.DecimalNullValue);
                    }
                }
            }
            if (flag)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "msg", "alert('Scheme updated successfully');", true);
            }

            LoadGrid("");
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterStartupScript(this, typeof(Page), "CatchMsg", "alert('" + ex.Message.ToString() + "');", true);
        }
    }
    protected void btnStatus_Click(object sender, EventArgs e)
    {
        bool check = false;
        try
        {
            foreach (GridViewRow dr2 in gvScheme.Rows)
            {
                var chRelized2 = (CheckBox)dr2.Cells[0].FindControl("ChbIsAssigned");
                if (chRelized2.Checked)
                {
                    check = true;
                    break;
                }
            }
            if (!check)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "msg", "alert('Please select scheme first');", true);
                return;
            }

            bool flag = false;

            foreach (GridViewRow dr in gvScheme.Rows)
            {
                var chRelized = (CheckBox)dr.Cells[0].FindControl("ChbIsAssigned");

                if (chRelized.Checked)
                {
                    bool active = false;

                    if (dr.Cells[6].Text == "Active")
                    {
                        active = true;
                    }

                    flag = HealthCtl.UpdateScheme(Convert.ToInt64(dr.Cells[1].Text), null, null, Constants.IntNullValue, Constants.IntNullValue,
                    Convert.ToInt32(ddlSchemeCategory.SelectedValue), Constants.IntNullValue, Constants.IntNullValue, Constants.IntNullValue, Constants.DecimalNullValue, Constants.DecimalNullValue,
                    Constants.DateNullValue, Constants.DateNullValue, Constants.DateNullValue, Convert.ToInt32(Session["UserID"]), null, active, false,
                    null, Constants.DecimalNullValue, Constants.DecimalNullValue, Constants.DateNullValue, null, Constants.DecimalNullValue);
                }
            }
            if (flag)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "msg", "alert('Scheme updated successfully');", true);
            }

            LoadGrid("");
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterStartupScript(this, typeof(Page), "CatchMsg", "alert('" + ex.Message.ToString() + "');", true);
        }
    }
    protected void btnPromoteSchemes_Click(object sender, EventArgs e)
    {
        string schemeIds = string.Empty;

        try
        {
            foreach (GridViewRow dr2 in gvScheme.Rows)
            {
                var chRelized2 = (CheckBox)dr2.Cells[0].FindControl("ChbIsAssigned");

                if (chRelized2.Checked)
                {
                    if (string.IsNullOrEmpty(schemeIds))
                    {
                        schemeIds = dr2.Cells[1].Text;
                    }
                    else
                    {
                        schemeIds += "," + dr2.Cells[1].Text;
                    }
                }
            }

            if (string.IsNullOrEmpty(schemeIds))
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "msg", "alert('Please select scheme first');", true);

                return;
            }

            int fyStartYear = DateTime.Now.Year;
            bool flag = false;

            if (DateTime.Now.Month >= 7)
            {
                fyStartYear = DateTime.Now.AddYears(1).Year;
            }

            flag = HealthCtl.PromoteSchemeForNextFY(schemeIds, fyStartYear);

            if (flag)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "msg", "alert('Schemes are promoted successfully');", true);
            }

            LoadGrid("");
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterStartupScript(this, typeof(Page), "CatchMsg", "alert('" + ex.Message.ToString() + "');", true);
        }
    }

    protected void Grid_users_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvScheme.PageIndex = e.NewPageIndex;
        LoadGrid("");
    }

    protected void gvScheme_RowEditing(object sender, GridViewEditEventArgs e)
    {
        try
        {
            mPopUpLocation.Show();
            GridViewRow gvr = gvScheme.Rows[e.NewEditIndex];
            Session.Add("SchemeID", Convert.ToInt32(gvr.Cells[1].Text));
            txtRevenueCode.Text = gvr.Cells[2].Text.ToString().Replace("&nbsp;", "").Replace("&amp;", "").Replace("nbsp;", "");
            txtSchemeName.Text = gvr.Cells[3].Text.ToString();
            Session.Add("Name", txtSchemeName.Text.Trim());
            if (gvr.Cells[5].Text.ToString() != "")
            {
                txtSchemeDate.Text = Convert.ToDateTime(gvr.Cells[5].Text).ToString("dd-MMM-yyyy");
            }
            ddlInstitute.Value = gvr.Cells[7].Text.ToString();
            ddlInstitute_SelectedIndexChanged(null, null);
            ddlCOA.Value = gvr.Cells[8].Text.ToString();
            string rcoa = gvr.Cells[23].Text.ToString().Replace("&nbsp;", "").Replace("&amp;", "").Replace("nbsp;", "");
            long lrcoa = 0;

            long.TryParse(rcoa, out lrcoa);

            if (rcoa != "" && lrcoa > 0)
            {
                ddlRCOA.Value = rcoa;
            }
            ddlCategory.Value = gvr.Cells[9].Text.ToString();
            txtRecurringCostPercent.Text = gvr.Cells[10].Text.ToString();
            txtRecurringCostAmount.Text = gvr.Cells[11].Text.ToString();
            if (gvr.Cells[12].Text.ToString() != "")
            {
                txtStartDate.Text = Convert.ToDateTime(gvr.Cells[12].Text).ToString("dd-MMM-yyyy");
            }
            if (gvr.Cells[13].Text.ToString() != "")
            {
                txtEndDate.Text = Convert.ToDateTime(gvr.Cells[13].Text).ToString("dd-MMM-yyyy");
            }
            ddlSubSector.Value = gvr.Cells[14].Text.ToString();
            ddlTypeOfBank.Value = gvr.Cells[15].Text.ToString();
            txtRemarks.Text = gvr.Cells[16].Text.ToString().Replace("&nbsp;", "").Replace("&amp;", "").Replace("nbsp;", "");
            txtCapitalCode.Text = gvr.Cells[17].Text.ToString().Replace("&nbsp;", "").Replace("&amp;", "").Replace("nbsp;", "");
            txtRevenueAmount.Text = gvr.Cells[18].Text.ToString();
            txtCapitalAmount.Text = gvr.Cells[19].Text.ToString();
            txtGSCode.Text = gvr.Cells[20].Text.ToString().Replace("&nbsp;", "").Replace("&amp;", "").Replace("nbsp;", "");
            if (gvr.Cells[21].Text.ToString() != "")
            {
                ddlFinancialYear.Value = Convert.ToDateTime(gvr.Cells[21].Text).ToString("yyyy").ToString();
            }
            txtLastYearExpense.Text = gvr.Cells[22].Text.ToString();
            btnSave.Text = "Update";
        }
        catch (Exception ex)
        {
            ex.Message.ToString();
        }
    }
    protected void gvScheme_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        try
        {
            if (Request.QueryString["mode"] == "ADP")
            {
                if (e.Row.RowType == DataControlRowType.DataRow)
                {
                    DataRow dr = ((DataRowView)e.Row.DataItem).Row;

                    if (Convert.ToInt32(dr["intCategoryID"]) != 1)
                    {
                        e.Row.Cells[e.Row.Cells.Count - 1].Controls[1].Visible = false;
                    }
                }
            }
            else if (Request.QueryString["mode"] == "MPR")
            {
                if (e.Row.RowType == DataControlRowType.DataRow)
                {
                    DataRow dr = ((DataRowView)e.Row.DataItem).Row;

                    if (Convert.ToInt32(dr["intCategoryID"]) != 3 && Convert.ToInt32(dr["intCategoryID"]) != 4)
                    {
                        e.Row.Cells[e.Row.Cells.Count - 1].Controls[1].Visible = false;
                    }
                }
            }
        }
        catch (Exception ex)
        {
            
        }
    }

    private void LoadInstitute()
    {
        DistributorController DController = new DistributorController();
        DataTable dt = DController.GetInstituteDetail(Constants.IntNullValue, int.Parse(Session["UserId"].ToString()), 1);
        ddlInstitute.DataSource = dt;
        ddlInstitute.ValueField = "DISTRIBUTOR_ID";
        ddlInstitute.DataBind();
        Session.Add("dtInstituteDetail", dt);
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

        ddlRCOA.DataSource = dtHead;
        ddlRCOA.ValueField = "ACCOUNT_HEAD_ID";
        ddlRCOA.DataBind();
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
        DataTable dt = new DataTable();
        dt = RouteCtl.GetSubSector(Constants.IntNullValue, 2);
        ddlSubSector.DataSource = dt;
        ddlSubSector.ValueField = "SubSector_ID";
        ddlSubSector.DataBind();
    }
    protected void ddlInstitute_SelectedIndexChanged(object sender, EventArgs e)
    {
        mPopUpLocation.Show();
        SaveDXState();

        DataTable dtInstituteDetail = (DataTable)Session["dtInstituteDetail"];
        foreach (DataRow dr in dtInstituteDetail.Rows)
        {
            if (dr["DISTRIBUTOR_ID"].ToString() == ddlInstitute.Value.ToString())
            {
                txtDistrict.Text = dr["District"].ToString();
                txtTehsil.Text = dr["Tehsil"].ToString();
                break;
            }
        }
    }
    protected void ddlFinancialYear_SelectedIndexChanged(object sender, EventArgs e)
    {
        mPopUpLocation.Show();
        SaveDXState();
        if (btnSave.Text == "Save")
        {
            txtGSCode.Text = string.Empty;
        }
        else if (btnSave.Text == "Update")
        {
            txtGSCode.Text = HealthCtl.GetSchemeGSCode(Convert.ToInt32(Session["SchemeID"]), Convert.ToDateTime(ddlFinancialYear.Value.ToString() + "-" + "01" + "-01"));
        }
    }

    private void SaveDXState()
    {
        string SelectedValue = ddlInstitute.Value.ToString();
        string SelectedValueCOA = ddlCOA.Value.ToString();
        string SelectedValueRCOA = ddlRCOA.Value.ToString();
        string SelectedValueSubSector = ddlSubSector.Value.ToString();
        string SelectedValueCategory = ddlCategory.Value.ToString();
        this.LoadInstitute();
        this.LoadSchemeCategory();
        this.LoadAccountDetail();
        this.LoadSubSector();

        ddlInstitute.Value = SelectedValue;
        ddlCOA.Value = SelectedValueCOA;
        ddlRCOA.Value = SelectedValueRCOA;
        ddlSubSector.Value = SelectedValueSubSector;
        ddlCategory.Value = SelectedValueCategory;
    }

    private void ClearAll()
    {
        Session.Remove("SchemeID");
        Session.Remove("Code");
        Session.Remove("Name");
        txtSchemeName.Text = string.Empty;
        txtRecurringCostPercent.Text = string.Empty;
        txtRecurringCostAmount.Text = string.Empty;
        txtRevenueCode.Text = string.Empty;
        txtRemarks.Text = string.Empty;
        txtCapitalCode.Text = string.Empty;
        txtRevenueAmount.Text = string.Empty;
        txtCapitalAmount.Text = string.Empty;
        txtGSCode.Text = string.Empty;
        txtLastYearExpense.Text = string.Empty;
        btnSave.Text = "Save";
    }
}