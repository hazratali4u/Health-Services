using System;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;
using CORNBusinessLayer.Classes;
using CORNCommon.Classes;
using System.Web;
using CORNDataAccessLayer.Request;
using CORNBusinessLayer;
using CORNDataAccessLayer.Response;
using System.Linq;

public partial class Forms_frmSchemePlanAdd : System.Web.UI.Page
{
    Distributor_UserController UController = new Distributor_UserController();
    FinancialYearController FincialYear = new FinancialYearController();
    HealthSchemeController HealthCtl = new HealthSchemeController();
    SaleForceController mDController = new SaleForceController();
    DataControl dc = new DataControl();
    static int UserId;
    DataTable dtCost;
    DataTable dtRCost;
    private static int _rowNo;
    private static int _rowRNo;
    private static long _schemeId;
    Decimal dcPageTotal;
    Decimal drPageTotal;

    protected void Page_Load(object sender, EventArgs e)
    {
        _schemeId = 0;
        Response.Cache.SetCacheability(HttpCacheability.NoCache);
        Response.Cache.SetExpires(DateTime.Now.AddSeconds(-1));
        Response.Cache.SetNoStore();
        Response.AppendHeader("pragma", "no-cache");
        txtProposedDate.Attributes.Add("readonly", "readonly");
        if (!Page.IsPostBack)
        {
            CreateTable();

            this.LoadEmployee();
            this.LoadAccountDetail();
            btnSave.Attributes.Add("onclick", "return ValidateForm()");
            txtProposedDate.Text = Convert.ToDateTime(Session["CurrentWorkDate"]).ToString("dd-MMM-yyyy");

            if (Request.QueryString["mode"] != null)
            {
                if (Request.QueryString["mode"].ToString() != "")
                {
                    if (Session["SchemePlanID"] != null)
                    {
                        if (Session["SchemePlanID"].ToString() != "")
                        {
                            LoadSchemePlan(Convert.ToInt64(Session["SchemePlanID"]));
                        }
                    }
                }
            }

            this.LoadScheme(_schemeId);
            this.GetFinancialYear();
            PopulateFinancialYearCapitalTotal();
            PopulateFinancialYearRevenueTotal();
        }

        Response.Expires = 0;
        Response.Cache.SetNoStore();
    }

    private void LoadSchemePlan(long SchemePlanID)
    {
        DataTable dtMaster = HealthCtl.GetSchemePlan(SchemePlanID, 2, Convert.ToInt32(Session["UserID"]));
        if (dtMaster.Rows.Count > 0)
        {
            _schemeId = Convert.ToInt64(dtMaster.Rows[0]["lngSchemeID"]);
            ddlFunctional.Value = dtMaster.Rows[0]["intFCAccountHeadID"].ToString();
            ddlEmployee.Value = dtMaster.Rows[0]["intProposedByID"].ToString();
            rblType.SelectedValue = dtMaster.Rows[0]["intProposalTypeID"].ToString();
            txtRemarks.Text = dtMaster.Rows[0]["strRemarks"].ToString();
            txtProposedDate.Text = Convert.ToDateTime(dtMaster.Rows[0]["dtmProposedDate"]).ToString("dd-MMM-yyyy");

            DataTable dtDetail = HealthCtl.GetSchemePlan(SchemePlanID, 3, Convert.ToInt32(Session["UserID"]));
            DataTable tmp1 = new DataTable();
            DataTable tmp2 = new DataTable();
            if (dtDetail.Select("intCostTypeId=1").Length > 0)
            {
                tmp1 = dtDetail.Select("intCostTypeId=1").CopyToDataTable();
                Session.Add("dtCost", tmp1);
            }
            if (dtDetail.Select("intCostTypeId=2").Length > 0)
            {
                tmp2 = dtDetail.Select("intCostTypeId=2").CopyToDataTable();
                Session.Add("dtRCost", tmp2);
            }

            this.LoadGrid();
            this.LoadRGrid();
            btnSave.Text = "Update";
        }
    }
    private void CreateTable()
    {
        dtCost = new DataTable();
        dtCost.Columns.Add("intFYID", typeof(int));
        dtCost.Columns.Add("intAccountHeadID", typeof(int));
        dtCost.Columns.Add("intCostTypeId", typeof(int));
        dtCost.Columns.Add("decCostCapital", typeof(decimal));
        dtCost.Columns.Add("decCostRevenue", typeof(decimal));
        dtCost.Columns.Add("decCostPC1", typeof(decimal));
        dtCost.Columns.Add("FYName", typeof(string));
        dtCost.Columns.Add("COAName", typeof(string));
        dtCost.Columns.Add("strDescription", typeof(string));
        Session.Add("dtCost", dtCost);

        dtRCost = new DataTable();
        dtRCost.Columns.Add("intFYID", typeof(int));
        dtRCost.Columns.Add("intAccountHeadID", typeof(int));
        dtRCost.Columns.Add("intCostTypeId", typeof(int));
        dtRCost.Columns.Add("decCostCapital", typeof(decimal));
        dtRCost.Columns.Add("decCostRevenue", typeof(decimal));
        dtRCost.Columns.Add("decCostPC1", typeof(decimal));
        dtRCost.Columns.Add("FYName", typeof(string));
        dtRCost.Columns.Add("COAName", typeof(string));
        dtRCost.Columns.Add("strDescription", typeof(string));
        Session.Add("dtRCost", dtRCost);
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (Page.IsValid)
            {
                dtCost = (DataTable)Session["dtCost"];
                dtRCost = (DataTable)Session["dtRCost"];

                if (ddlScheme.Value == null)
                {
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "Alert", "alert('Please provide scheme.');", true);
                }
                else if (string.IsNullOrEmpty(txtProposedDate.Text))
                {
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "Alert", "alert('Please provide proposed date.');", true);
                }
                else if (dtCost.Rows.Count <= 0 && dtRCost.Rows.Count <= 0)
                {
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "Alert", "alert('Please provide capital / revenue.');", true);
                }
                else
                {
                    if (btnSave.Text == "Save")
                    {
                        bool _result = HealthCtl.InsertSchemePlan(Convert.ToInt64(ddlScheme.Value), Convert.ToInt32(ddlFunctional.Value), Convert.ToInt32(ddlEmployee.Value), Convert.ToInt32(rblType.SelectedValue), txtRemarks.Text, Convert.ToDateTime(txtProposedDate.Text), Convert.ToInt32(Session["UserID"]), dtCost, dtRCost);
                        if (_result)
                        {
                            ScriptManager.RegisterStartupScript(this, typeof(Page), "Alert", "alert('Record added successfully.');", true);
                            Response.Redirect("frmSchemePlan.aspx?LevelType=" + Request.QueryString["LevelType"].ToString() + "&LevelID=" + Request.QueryString["LevelID"].ToString());
                        }
                    }
                    else if (btnSave.Text == "Update")
                    {
                        bool _result = HealthCtl.UpdateSchemePlan(Convert.ToInt64(Session["SchemePlanID"]), Convert.ToInt64(ddlScheme.Value), Convert.ToInt32(ddlFunctional.Value), Convert.ToInt32(ddlEmployee.Value), Convert.ToInt32(rblType.SelectedValue), txtRemarks.Text, Convert.ToDateTime(txtProposedDate.Text), Convert.ToInt32(Session["UserID"]), true, false, dtCost, dtRCost);
                        if (_result)
                        {
                            ScriptManager.RegisterStartupScript(this, typeof(Page), "Alert", "alert('Record updated successfully.');", true);
                            Response.Redirect("frmSchemePlan.aspx?LevelType=" + Request.QueryString["LevelType"].ToString() + "&LevelID=" + Request.QueryString["LevelID"].ToString());
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterStartupScript(this, typeof(Page), "CatchMsg", "alert('" + ex.Message.ToString() + "');", true);
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

        Response.Redirect("frmSchemePlan.aspx?LevelType=" + Request.QueryString["LevelType"].ToString() + "&LevelID=" + Request.QueryString["LevelID"].ToString());
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        gvCost.EditIndex = -1;
        dtCost = (DataTable)Session["dtCost"];

        try
        {
            if (ddlFY.Value == null)
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "Alert", "alert('Please provide financial year.');", true);
            }
            else if (ddlCOA.Value == null)
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "Alert", "alert('Please provide object code.');", true);
            }
            else if (string.IsNullOrEmpty(txtCapital.Text))
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "Alert", "alert('Please provide capital.');", true);
            }
            else
            {
                DataView dv = new DataView(dtCost);
                string query = "intFYID = " + Convert.ToString(ddlFY.Value) + " AND intAccountHeadID = " + Convert.ToString(ddlCOA.Value);

                if (btnAdd.Text == "Update")
                {
                    DataTable dt = dv.ToTable();

                    dt.Rows.RemoveAt(_rowNo);

                    dv = new DataView(dt);
                }

                dv.RowFilter = query;

                if (dv.ToTable().Rows.Count > 0)
                {
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "Alert", "alert('Record already exists for selected Financial Year and Object Code.');", true);
                }
                else
                {
                    if (btnAdd.Text == "Add")
                    {
                        DataRow dr = dtCost.NewRow();
                        dr["intFYID"] = Convert.ToInt32(ddlFY.Value);
                        dr["FYName"] = ddlFY.Text;
                        dr["intAccountHeadID"] = ddlCOA.Value;
                        dr["intCostTypeId"] = 1;
                        dr["COAName"] = ddlCOA.Text;
                        dr["decCostRevenue"] = 0;
                        dr["decCostCapital"] = Convert.ToDecimal(dc.chkNull_0(txtCapital.Text));
                        dr["decCostPC1"] = 0;
                        dr["strDescription"] = txtDescription.Text;
                        dtCost.Rows.Add(dr);
                        Session.Add("dtCost", dtCost);
                        this.LoadGrid();
                        ClearControls();
                    }
                    else
                    {
                        DataRow dr = dtCost.Rows[_rowNo];
                        dr["intFYID"] = Convert.ToInt32(ddlFY.Value);
                        dr["FYName"] = ddlFY.Text;
                        dr["intAccountHeadID"] = ddlCOA.Value;
                        dr["intCostTypeId"] = 1;
                        dr["COAName"] = ddlCOA.Text;
                        dr["decCostRevenue"] = 0;
                        dr["decCostCapital"] = Convert.ToDecimal(dc.chkNull_0(txtCapital.Text));
                        dr["decCostPC1"] = 0;
                        dr["strDescription"] = txtDescription.Text;
                        Session.Add("dtCost", dtCost);
                        this.LoadGrid();
                        ClearControls();
                    }
                }
            }
        }
        catch (Exception ex)
        {

        }
        SaveDXState();
    }
    protected void btnRAdd_Click(object sender, EventArgs e)
    {
        gvRCost.EditIndex = -1;
        dtRCost = (DataTable)Session["dtRCost"];

        try
        {
            if (ddlRFY.Value == null)
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "Alert", "alert('Please provide financial year.');", true);
            }
            else if (ddlRCOA.Value == null)
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "Alert", "alert('Please provide object code.');", true);
            }
            else if (string.IsNullOrEmpty(txtRevenue.Text))
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "Alert", "alert('Please provide revenue.');", true);
            }
            else
            {
                DataView dv = new DataView(dtRCost);
                string query = "intFYID = " + Convert.ToString(ddlRFY.Value) + " AND intAccountHeadID = " + Convert.ToString(ddlRCOA.Value);

                if (btnRAdd.Text == "Update")
                {
                    DataTable dt = dv.ToTable();

                    dt.Rows.RemoveAt(_rowNo);

                    dv = new DataView(dt);
                }

                dv.RowFilter = query;

                if (dv.ToTable().Rows.Count > 0)
                {
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "Alert", "alert('Record already exists for selected Financial Year and Object Code.');", true);
                }
                else
                {
                    if (btnRAdd.Text == "Add")
                    {
                        DataRow dr = dtRCost.NewRow();
                        dr["intFYID"] = Convert.ToInt32(ddlRFY.Value);
                        dr["FYName"] = ddlRFY.Text;
                        dr["intAccountHeadID"] = ddlRCOA.Value;
                        dr["intCostTypeId"] = 2;
                        dr["COAName"] = ddlRCOA.Text;
                        dr["decCostCapital"] = 0;
                        dr["decCostRevenue"] = Convert.ToDecimal(dc.chkNull_0(txtRevenue.Text));
                        dr["decCostPC1"] = 0;
                        dr["strDescription"] = txtRDescription.Text;
                        dtRCost.Rows.Add(dr);
                        Session.Add("dtRCost", dtRCost);
                        this.LoadRGrid();
                        ClearControls();
                    }
                    else
                    {
                        DataRow dr = dtRCost.Rows[_rowRNo];
                        dr["intFYID"] = Convert.ToInt32(ddlRFY.Value);
                        dr["FYName"] = ddlRFY.Text;
                        dr["intAccountHeadID"] = ddlRCOA.Value;
                        dr["intCostTypeId"] = 2;
                        dr["COAName"] = ddlRCOA.Text;
                        dr["decCostCapital"] = 0;
                        dr["decCostRevenue"] = Convert.ToDecimal(dc.chkNull_0(txtRevenue.Text));
                        dr["decCostPC1"] = 0;
                        dr["strDescription"] = txtRDescription.Text;
                        Session.Add("dtRCost", dtRCost);
                        this.LoadRGrid();
                        ClearControls();
                    }
                }
            }
        }
        catch (Exception ex)
        {

        }
        SaveDXState();
    }

    public void GetFinancialYear()
    {
        try
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

                ddlRFY.DataSource = response.FinancialYearList;
                ddlRFY.ValueField = "Id";
                ddlRFY.DataBind();
                if (ddlRFY.Items.Count > 0)
                {
                    ddlRFY.SelectedIndex = 0;
                    ddlRFY.Value = ddlRFY.SelectedItem.Value;
                }
            }
        }
        catch (IndexOutOfRangeException)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "msg", "alert('Please Start a financial year')", true);
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "msg", "alert('" + ex.Message.ToString() + "')", true);
        }
    }

    private void LoadAccountDetail()
    {
        AccountHeadController mAccountController = new AccountHeadController();
        DataTable dtHead = mAccountController.SelectAccountHead(Constants.AC_AccountHeadId, Constants.LongNullValue, 1, Constants.Account_Form_COA);
        DataView dv = new DataView(dtHead);
        string query = "ACCOUNT_CODE LIKE '%a12%'";

        dv.RowFilter = query;

        DataTable dt = dv.ToTable();

        ddlCOA.DataSource = dt;
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

        ddlFunctional.DataSource = dtHead;
        ddlFunctional.ValueField = "ACCOUNT_HEAD_ID";
        ddlFunctional.DataBind();

        if (ddlFunctional.Items.Count > 0)
        {
            ddlFunctional.SelectedIndex = 0;
        }
    }

    private void LoadScheme(long schemeId)
    {
        DataTable dt = new DataTable();

        if (schemeId <= 0)
        {
            dt = HealthCtl.GetScheme(Constants.IntNullValue, 4, Constants.LongNullValue, Convert.ToInt32(Session["UserID"]));

            if (dt == null || dt.Rows == null || dt.Rows.Count <= 0)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "msg", "alert('No scheme left to be planned.'); window.location = 'frmSchemePlan.aspx?LevelType=" + Request.QueryString["LevelType"].ToString() + "&LevelID=" + Request.QueryString["LevelID"].ToString() + "';", true);
            }
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

    private void LoadEmployee()
    {
        DataTable dt = mDController.SelectSaleForceAssignedArea(1, int.Parse(HttpContext.Current.Session["DISTRIBUTOR_ID"].ToString())
            , Constants.IntNullValue, int.Parse(HttpContext.Current.Session["companyId"].ToString()), Constants.IntNullValue);
        ddlEmployee.DataSource = dt;
        ddlEmployee.ValueField = "USER_ID";
        ddlEmployee.DataBind();
        if (ddlEmployee.Items.Count > 0)
        {
            ddlEmployee.SelectedIndex = 0;
        }
    }

    protected void gvCost_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        dtCost = (DataTable)Session["dtCost"];
        if (dtCost.Rows.Count > 0)
        {
            dtCost.Rows.RemoveAt(e.RowIndex);
            Session.Add("dtCost", dtCost);
            LoadGrid();
        }

        SaveDXState();
    }
    protected void gvRCost_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        dtRCost = (DataTable)Session["dtRCost"];
        if (dtRCost.Rows.Count > 0)
        {
            dtRCost.Rows.RemoveAt(e.RowIndex);
            Session.Add("dtRCost", dtRCost);
            LoadRGrid();
        }

        SaveDXState();
    }

    protected void gvCost_RowEditing(object sender, GridViewEditEventArgs e)
    {
        gvCost.EditIndex = -1;
        _rowNo = e.NewEditIndex;
        ddlFY.Value = ((Label)gvCost.Rows[e.NewEditIndex].Cells[0].FindControl("lblintFYID")).Text;
        ddlCOA.Value = ((Label)gvCost.Rows[e.NewEditIndex].Cells[1].FindControl("lblintAccountHeadID")).Text;
        txtCapital.Text = ((Label)gvCost.Rows[e.NewEditIndex].Cells[4].FindControl("lbldecCostCapital")).Text;
        txtDescription.Text = ((Label)gvCost.Rows[e.NewEditIndex].Cells[5].FindControl("lblstrDescription")).Text;
        btnAdd.Text = "Update";

        SaveDXState();
    }
    protected void gvRCost_RowEditing(object sender, GridViewEditEventArgs e)
    {
        gvRCost.EditIndex = -1;
        _rowRNo = e.NewEditIndex;
        ddlRFY.Value = ((Label)gvRCost.Rows[e.NewEditIndex].Cells[0].FindControl("lblintFYID")).Text;
        ddlRCOA.Value = ((Label)gvRCost.Rows[e.NewEditIndex].Cells[1].FindControl("lblintAccountHeadID")).Text;
        txtRevenue.Text = ((Label)gvRCost.Rows[e.NewEditIndex].Cells[4].FindControl("lbldecCostRevenue")).Text;
        txtRDescription.Text = ((Label)gvRCost.Rows[e.NewEditIndex].Cells[5].FindControl("lblstrDescription")).Text;
        btnRAdd.Text = "Update";

        SaveDXState();
    }

    private void LoadGrid()
    {
        dtCost = (DataTable)Session["dtCost"];

        if (dtCost != null)
        {
            gvCost.DataSource = dtCost;
            gvCost.DataBind();

            //decimal total = dtCost.AsEnumerable().Sum(row => row.Field<decimal>("decCostCapital"));
            //gvCost.FooterRow.Cells[1].Text = "Total";
            //gvCost.FooterRow.Cells[1].HorizontalAlign = HorizontalAlign.Right;
            //gvCost.FooterRow.Cells[2].Text = total.ToString("N2");
        }

        PopulateFinancialYearCapitalTotal();
    }
    private void LoadRGrid()
    {
        dtRCost = (DataTable)Session["dtRCost"];

        if (dtRCost != null)
        {
            gvRCost.DataSource = dtRCost;
            gvRCost.DataBind();
        }

        PopulateFinancialYearRevenueTotal();
    }

    private void SaveDXState()
    {
        string SelectedValueScheme = ddlScheme.Value.ToString();
        string SelectedValueFC = ddlFunctional.Value.ToString();
        string SelectedValueEmployee = string.Empty;

        if (ddlEmployee.Value != null)
        {
            SelectedValueEmployee = ddlEmployee.Value.ToString();
        }

        string SelectedValueFY = string.Empty;
        string SelectedValueRFY = string.Empty;
        string SelectedValueCOA = string.Empty;
        string SelectedValueRCOA = string.Empty;

        if (ddlFY.Value != null)
        {
            SelectedValueFY = ddlFY.Value.ToString();
        }

        if (ddlRFY.Value != null)
        {
            SelectedValueRFY = ddlRFY.Value.ToString();
        }

        if (ddlCOA.Value != null)
        {
            SelectedValueCOA = ddlCOA.Value.ToString();
        }

        if (ddlRCOA.Value != null)
        {
            SelectedValueRCOA = ddlRCOA.Value.ToString();
        }

        _schemeId = Convert.ToInt64(SelectedValueScheme);
        this.LoadScheme(_schemeId);
        ddlScheme.Value = SelectedValueScheme;

        this.LoadAccountDetail();
        ddlFunctional.Value = SelectedValueFC;

        if (!string.IsNullOrEmpty(SelectedValueCOA))
        {
            ddlCOA.Value = SelectedValueCOA;
        }

        if (!string.IsNullOrEmpty(SelectedValueRCOA))
        {
            ddlRCOA.Value = SelectedValueRCOA;
        }

        this.LoadEmployee();
        ddlEmployee.Value = SelectedValueEmployee;

        this.GetFinancialYear();

        if (!string.IsNullOrEmpty(SelectedValueFY))
        {
            ddlFY.Value = SelectedValueFY;
        }

        if (!string.IsNullOrEmpty(SelectedValueFY))
        {
            ddlRFY.Value = SelectedValueRFY;
        }
    }

    private void ClearControls()
    {
        txtCapital.Text = string.Empty;
        txtRevenue.Text = string.Empty;
        txtDescription.Text = string.Empty;
        txtRDescription.Text = string.Empty;
        btnAdd.Text = "Add";
        btnRAdd.Text = "Add";
        //ddlFY.SelectedIndex = 0;
        //ddlRFY.SelectedIndex = 0;
        //ddlCOA.SelectedIndex = 0;
        //ddlRCOA.SelectedIndex = 0;
    }

    private void PopulateFinancialYearCapitalTotal()
    {
        dtCost = (DataTable)Session["dtCost"];

        if (dtCost != null && ddlFY.Value != null)
        {
            DataView dv = new DataView(dtCost);
            string query = "intFYID = " + Convert.ToString(ddlFY.Value);

            dv.RowFilter = query;

            decimal totalCapital = 0;

            foreach (DataRow dr in dv.ToTable().Rows)
            {
                totalCapital += Convert.ToDecimal(dr["decCostCapital"]);
            }

            dvFYCapitalTotalAmount.InnerHtml = "Rs " + totalCapital.ToString();
        }
        else
        {
            dvFYCapitalTotalAmount.InnerHtml = "Rs 0.00";
        }
    }
    private void PopulateFinancialYearRevenueTotal()
    {
        dtRCost = (DataTable)Session["dtRCost"];

        if (dtRCost != null && ddlRFY.Value != null)
        {
            DataView dv = new DataView(dtRCost);
            string query = "intFYID = " + Convert.ToString(ddlRFY.Value);

            dv.RowFilter = query;

            decimal totalRevenue = 0;

            foreach (DataRow dr in dv.ToTable().Rows)
            {
                totalRevenue += Convert.ToDecimal(dr["decCostRevenue"]);
            }

            dvFYRevenueTotalAmount.InnerHtml = "Rs " + totalRevenue.ToString();
        }
        else
        {
            dvFYCapitalTotalAmount.InnerHtml = "Rs 0.00";
        }
    }

    protected void gvCost_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            Label lbldecCostCapital = (Label)e.Row.FindControl("lbldecCostCapital");
            dcPageTotal += Decimal.Parse(lbldecCostCapital.Text);
        }

        if (e.Row.RowType == DataControlRowType.Footer)
        {
            Label lbldecCostCapitalTotal = (Label)e.Row.FindControl("lbldecCostCapitalTotal");
            lbldecCostCapitalTotal.Text = dcPageTotal.ToString("#,##0");
        }
    }
    protected void gvRCost_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            Label lbldecCostRevenue = (Label)e.Row.FindControl("lbldecCostRevenue");
            drPageTotal += Decimal.Parse(lbldecCostRevenue.Text);
        }

        if (e.Row.RowType == DataControlRowType.Footer)
        {
            Label lbldecCostRevenueTotal = (Label)e.Row.FindControl("lbldecCostRevenueTotal");
            lbldecCostRevenueTotal.Text = drPageTotal.ToString("#,##0");
        }
    }

    protected void ddlFY_SelectedIndexChanged(object sender, EventArgs e)
    {
        PopulateFinancialYearCapitalTotal();
        SaveDXState();
    }
    protected void ddlRFY_SelectedIndexChanged(object sender, EventArgs e)
    {
        PopulateFinancialYearRevenueTotal();
        SaveDXState();
    }
}