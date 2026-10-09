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
public partial class Forms_frmSubSector : System.Web.UI.Page
{
    Distributor_UserController UController = new Distributor_UserController();
    DistributorRouteController RouteCtl = new DistributorRouteController();
    static int UserId;

    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Cache.SetCacheability(HttpCacheability.NoCache);
        Response.Cache.SetExpires(DateTime.Now.AddSeconds(-1));
        Response.Cache.SetNoStore();
        Response.AppendHeader("pragma", "no-cache");

        if (!Page.IsPostBack)
        {
         //   LoadDistributor();
            LoadGrid("");
            btnSave.Attributes.Add("onclick", "return ValidateForm()");
            

        }

        Response.Expires = 0;
        Response.Cache.SetNoStore();
    }

    private void LoadDistributor()
    {
        DistributorController mController = new DistributorController();
        DataTable dt = mController.SelectDistributor(Constants.IntNullValue, Constants.IntNullValue, int.Parse(Session["CompanyId"].ToString()));
        clsWebFormUtil.FillDxComboBoxList(ddDistributorId, dt, 1, 3, true);

        if (dt.Rows.Count > 0)
        {
            ddDistributorId.SelectedIndex = 0;
        }
    }

    private void LoadGrid(string pType)
    {
            DataTable dt = new DataTable();
            dt = RouteCtl.GetSubSector(Constants.IntNullValue, 3);
            if (pType == "")
            {
                if (txtSearch.Text != "" || txtSearch.Text != string.Empty)
                {
                    dt.DefaultView.RowFilter = "strCode LIKE '%" + txtSearch.Text + "%'  OR strShortName LIKE '%" + txtSearch.Text + "%' OR IS_ACTIVE LIKE '" + txtSearch.Text + " %' OR DISTRIBUTOR_NAME LIKE '%" + txtSearch.Text + "%' OR IS_ACTIVE LIKE '%" + txtSearch.Text + "%' ";
                }
                GridShift.DataSource = dt;
                GridShift.DataBind();
            }
            else
            {
                if (txtSearch.Text != "" || txtSearch.Text != string.Empty)
                {
                    dt.DefaultView.RowFilter = "strCode LIKE '%" + txtSearch.Text + "%'  OR strShortName LIKE '%" + txtSearch.Text + "%' OR IS_ACTIVE LIKE '" + txtSearch.Text + " %'  OR DISTRIBUTOR_NAME LIKE '%" + txtSearch.Text + "%' OR IS_ACTIVE LIKE '%" + txtSearch.Text + "%' ";
                }
                if (dt.Rows.Count > 0)
                {
                    GridShift.PageIndex = 0;
                }
                GridShift.DataSource = dt;
                GridShift.DataBind();
            }
       // }
    }

    protected void ddDistributorId_SelectedIndexChanged(object sender, EventArgs e)
    {
        mPopUpLocation.Show();
        //LoadGrid("");
    }
    public bool DuplicateChecker()
    {
        DataTable dt = new DataTable();
        dt = RouteCtl.GetSubSector(0, 3);
        DataRow[] dr = dt.Select("strName = '" + txtName.Text + "' AND strShortName = '" + txtShortName.Text + "' AND strCode = '" + txtCode.Text + "' ");
        if (dr.Length > 0)
        {
            return true;
        }

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
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "Alert", "alert('Sub Sector Already exists.');", true);
                    mPopUpLocation.Show();
                    return;
                }
                if (btnSave.Text == "Save")
                {
                    bool _result = RouteCtl.InsertSubSector(0,txtCode.Text,txtName.Text,txtShortName.Text,Convert.ToInt32(Session["UserID"]));
                    if (_result)
                    {
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "Alert", "alert('Record added successfully.');", true);
                        mPopUpLocation.Show();
                    }
                }
                else if (btnSave.Text == "Update")
                {
                    bool _result = RouteCtl.UpdateSubSector(Convert.ToInt32(Session["SubSectorID"]), 0,txtCode.Text,txtName.Text,txtShortName.Text,Convert.ToInt32(Session["UserID"]),2);
                    if (_result)
                    {
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "Alert", "alert('Record updated successfully.');", true);
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

            ScriptManager.RegisterStartupScript(this, typeof(Page), "CatchMsg", "alert('" + ex.Message.ToString() + "');", true);
            mPopUpLocation.Show();
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        txtName.Text = string.Empty;
        txtShortName.Text = string.Empty;
        mPopUpLocation.Show();
    }


    protected void btnFilter_Click(object sender, EventArgs e)
    {
        this.LoadGrid("filter");
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        mPopUpLocation.Show();
    }
    protected void btnActive_Click(object sender, EventArgs e)
    {
        bool check = false;
        try
        {
            foreach (GridViewRow dr2 in GridShift.Rows)
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
                ScriptManager.RegisterStartupScript(this, GetType(), "msg", "alert('Please select record first');", true);
                return;
            }

            bool flag = false;

            foreach (GridViewRow dr in GridShift.Rows)
            {
                var chRelized = (CheckBox)dr.Cells[0].FindControl("ChbIsAssigned");

                if (chRelized.Checked)
                {
                    flag = RouteCtl.UpdateSubSector(Convert.ToInt32(dr.Cells[1].Text), 0, txtCode.Text, txtName.Text, txtShortName.Text, Convert.ToInt32(Session["UserID"]),1);

                }
            }
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
        GridShift.PageIndex = e.NewPageIndex;
        LoadGrid("");
    }

    protected void GridShift_RowEditing(object sender, GridViewEditEventArgs e)
    {
        try
        {
            mPopUpLocation.Show();
            GridViewRow gvr = GridShift.Rows[e.NewEditIndex];
            Session.Add("SubSectorID", Convert.ToInt32(gvr.Cells[1].Text));
            txtCode.Text = gvr.Cells[3].Text.ToString();
            txtName.Text = gvr.Cells[4].Text.ToString();
            txtShortName.Text = gvr.Cells[5].Text.ToString();
            btnSave.Text = "Update";
        }
        catch (Exception ex)
        {
            ex.Message.ToString();
        }
    }
}
