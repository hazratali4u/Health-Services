using System;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;
using CORNBusinessLayer.Classes;
using CORNCommon.Classes;
using System.Web;

public partial class Forms_frmExpesneBookingComm : System.Web.UI.Page
{
    Distributor_UserController UController = new Distributor_UserController();
    static int UserId;

    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Cache.SetCacheability(HttpCacheability.NoCache);
        Response.Cache.SetExpires(DateTime.Now.AddSeconds(-1));
        Response.Cache.SetNoStore();
        Response.AppendHeader("pragma", "no-cache");
        txtDate.Attributes.Add("readonly", "readonly");
        if (!Page.IsPostBack)
        {
            this.LoadAccountDetail();
            this.LoadGrid("");
            //btnSave.Attributes.Add("onclick", "return ValidateForm()");
        }

        Response.Expires = 0;
        Response.Cache.SetNoStore();
    }

    private void LoadGrid(string pType)
    {

        //if (ddDistributorId.Items.Count > 0)
        //{

        DataTable dt = new DataTable();

        dt = UController.SelectShift(Constants.IntNullValue, 3);
        //if (pType == "")
        //{
        //    if (txtSearch.Text != "" || txtSearch.Text != string.Empty)
        //    {
        //        dt.DefaultView.RowFilter = "SHIFT_FROM LIKE '%" + txtSearch.Text + "%'  OR SHIFT_TO LIKE '%" + txtSearch.Text + "%' OR IS_ACTIVE LIKE '" + txtSearch.Text + " %' OR DISTRIBUTOR_NAME LIKE '%" + txtSearch.Text + "%' OR IS_ACTIVE LIKE '%" + txtSearch.Text + "%' ";
        //    }
        //    GridShift.DataSource = dt;
        //    GridShift.DataBind();
        //}
        //else
        //{
        //    if (txtSearch.Text != "" || txtSearch.Text != string.Empty)
        //    {
        //        dt.DefaultView.RowFilter = "SHIFT_FROM LIKE '%" + txtSearch.Text + "%'  OR SHIFT_TO LIKE '%" + txtSearch.Text + "%' OR IS_ACTIVE LIKE '" + txtSearch.Text + " %'  OR DISTRIBUTOR_NAME LIKE '%" + txtSearch.Text + "%' OR IS_ACTIVE LIKE '%" + txtSearch.Text + "%' ";
        //    }
        //    if (dt.Rows.Count > 0)
        //    {
        //        GridShift.PageIndex = 0;
        //    }
        //    GridShift.DataSource = dt;
        //    GridShift.DataBind();
        //}
        // }
    }

    protected void ddDistributorId_SelectedIndexChanged(object sender, EventArgs e)
    {
        //mPopUpLocation.Show();
        //LoadGrid("");
    }
    public bool DuplicateChecker()
    {
        DataTable dt = new DataTable();
        //dt = UController.SelectShift(0, 3);
        //DataRow[] dr = dt.Select("SHIFT_FROM = '" + txtTimeFrom.Text + "' AND SHIFT_TO = '" + txtTimeTo.Text + "' AND SHIFT_NAME = '" + txtShiftName.Text + "' ");
        //if (dr.Length > 0)
        //{
        //    return true;
        //}

        return false;
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (Page.IsValid)
            {
                if (DuplicateChecker())
                {
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "Alert", "alert('Shift Already exists.');", true);
                    //mPopUpLocation.Show();
                    return;
                }
                //if (btnSave.Text == "Save")
                //{
                //    bool _result = UController.InsertShift(0,txtShiftName.Text, Convert.ToDateTime(txtTimeFrom.Text), Convert.ToDateTime(txtTimeTo.Text));
                //    if (_result)
                //    {
                //        ScriptManager.RegisterStartupScript(this, typeof(Page), "Alert", "alert('Record added successfully.');", true);
                //        mPopUpLocation.Show();
                //    }
                //}
                //else if (btnSave.Text == "Update")
                //{
                //    bool _result = UController.UpdateShift(Convert.ToInt32(Session["ShiftId"]), 0, txtShiftName.Text, Convert.ToDateTime(txtTimeFrom.Text), Convert.ToDateTime(txtTimeTo.Text), true, 2);
                //    if (_result)
                //    {
                //        ScriptManager.RegisterStartupScript(this, typeof(Page), "Alert", "alert('Record updated successfully.');", true);
                //        mPopUpLocation.Hide();
                //    }
                //}
                LoadGrid("");
                //btnSave.Text = "Save";

            }
            else
            {
                //mPopUpLocation.Show();
            }
        }
        catch (Exception ex)
        {

            ScriptManager.RegisterStartupScript(this, typeof(Page), "CatchMsg", "alert('" + ex.Message.ToString() + "');", true);
            //mPopUpLocation.Show();
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

        ////  ddDistributorId.SelectedIndex = 0;
        //  txtTimeFrom.SelectedIndex = 0;
        //  txtTimeTo.SelectedIndex = 0;
        //  mPopUpLocation.Show();
    }

    protected void btnFilter_Click(object sender, EventArgs e)
    {
        this.LoadGrid("filter");
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //mPopUpLocation.Show();
    }
    protected void btnActive_Click(object sender, EventArgs e)
    {
        bool check = false;
        try
        {
            //foreach (GridViewRow dr2 in GridShift.Rows)
            //{
            //    var chRelized2 = (CheckBox)dr2.Cells[0].FindControl("ChbIsAssigned");

            //    if (chRelized2.Checked)
            //    {
            //        check = true;
            //        break;
            //    }

            //}
            //if (!check)
            //{
            //    ScriptManager.RegisterStartupScript(this, GetType(), "msg", "alert('Please select record first');", true);
            //    return;
            //}

            bool flag = false;

            //foreach (GridViewRow dr in GridShift.Rows)
            //{
            //    var chRelized = (CheckBox)dr.Cells[0].FindControl("ChbIsAssigned");

            //    if (chRelized.Checked)
            //    {
            //        flag = UController.UpdateShift(Convert.ToInt32(dr.Cells[1].Text), 0,"", Convert.ToDateTime(txtTimeFrom.Text), Convert.ToDateTime(txtTimeTo.Text), true, 1);

            //    }
            //}
            if (flag)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "msg", "alert('Record updated successfully');", true);
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
        //GridShift.PageIndex = e.NewPageIndex;
        LoadGrid("");
    }

    protected void GridShift_RowEditing(object sender, GridViewEditEventArgs e)
    {
        try
        {
            //mPopUpLocation.Show();
            //GridViewRow gvr = GridShift.Rows[e.NewEditIndex];
            //Session.Add("ShiftId", Convert.ToInt32(gvr.Cells[1].Text));
            //txtShiftName.Text = gvr.Cells[3].Text.ToString();
            //txtTimeFrom.Value = gvr.Cells[4].Text.ToString();
            //txtTimeTo.Value = gvr.Cells[5].Text.ToString();
            //btnSave.Text = "Update";
        }
        catch (Exception ex)
        {
            ex.Message.ToString();
        }
    }

    private void LoadAccountDetail()
    {
        AccountHeadController mAccountController = new AccountHeadController();
        DataTable dtHead = mAccountController.SelectAccountHead(Constants.AC_AccountHeadId, Constants.LongNullValue, 1, Constants.Account_Form_FunctionalClass);
        ddlCOA.DataSource = dtHead;
        ddlCOA.ValueField = "ACCOUNT_HEAD_ID";
        ddlCOA.DataBind();

        if (dtHead.Rows.Count > 0)
        {
            ddlCOA.SelectedIndex = 0;
        }
    }
}