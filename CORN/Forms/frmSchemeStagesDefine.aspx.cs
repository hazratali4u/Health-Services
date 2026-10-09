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
public partial class Forms_frmSchemeStagesDefine : System.Web.UI.Page
{
    Distributor_UserController UController = new Distributor_UserController();
    DistributorRouteController RouteCtl = new DistributorRouteController();
    HealthSchemeController HealthCtl = new HealthSchemeController();
    static int UserId;

    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Cache.SetCacheability(HttpCacheability.NoCache);
        Response.Cache.SetExpires(DateTime.Now.AddSeconds(-1));
        Response.Cache.SetNoStore();
        Response.AppendHeader("pragma", "no-cache");

        if (!Page.IsPostBack)
        {
            LoadGrid("");
            btnSave.Attributes.Add("onclick", "return ValidateForm()");
        }

        Response.Expires = 0;
        Response.Cache.SetNoStore();
    }

    private void LoadGrid(string pType)
    {
        DataTable dt = new DataTable();
        dt = HealthCtl.GetSchemeStageStatus(2);
        if (pType == "")
        {
            if (txtSearch.Text != "" || txtSearch.Text != string.Empty)
            {
                dt.DefaultView.RowFilter = "Name LIKE '%" + txtSearch.Text + "%'  OR ShortName LIKE '%" + txtSearch.Text + "%'";
            }
            GridShift.DataSource = dt;
            GridShift.DataBind();
        }
        else
        {
            if (txtSearch.Text != "" || txtSearch.Text != string.Empty)
            {
                dt.DefaultView.RowFilter = "Name LIKE '%" + txtSearch.Text + "%'  OR ShortName LIKE '%" + txtSearch.Text + "%'";
            }
            if (dt.Rows.Count > 0)
            {
                GridShift.PageIndex = 0;
            }
            GridShift.DataSource = dt;
            GridShift.DataBind();
        }
    }

    protected void ddDistributorId_SelectedIndexChanged(object sender, EventArgs e)
    {
        mPopUpLocation.Show();
        //LoadGrid("");
    }
    
    protected void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (Page.IsValid)
            {
                int id = 0;

                if (Session["SchemeStageStatusID"] != null)
                {
                    id = Convert.ToInt32(Session["SchemeStageStatusID"]);
                }

                if (HealthCtl.CheckDuplicateSchemeStageStatus(id, txtName.Text.Trim()))
                {
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "Alert", "alert('Sub Sector Already exists.');", true);
                    mPopUpLocation.Show();
                    return;
                }
                if (btnSave.Text == "Save")
                {
                    bool _result = HealthCtl.InsertSchemeStageStatus(txtName.Text,txtShortName.Text,Convert.ToInt32(Session["UserID"]));
                    if (_result)
                    {
                        txtName.Text = string.Empty;
                        txtShortName.Text = string.Empty;
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "Alert", "alert('Record added successfully.');", true);
                        mPopUpLocation.Show();
                    }
                }
                else if (btnSave.Text == "Update")
                {
                    bool _result = HealthCtl.UpdateSchemeStageStatus(Convert.ToInt32(Session["SchemeStageStatusID"]),txtName.Text, txtShortName.Text, Convert.ToInt32(Session["UserID"]),true,false);
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
                    flag = HealthCtl.UpdateSchemeStageStatus(Convert.ToInt32(dr.Cells[1].Text), dr.Cells[2].Text, dr.Cells[3].Text, Convert.ToInt32(Session["UserID"]), false, true);

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
            Session.Add("SchemeStageStatusID", Convert.ToInt32(gvr.Cells[1].Text));
            txtName.Text = gvr.Cells[2].Text.ToString();
            txtShortName.Text = gvr.Cells[3].Text.ToString();
            btnSave.Text = "Update";
        }
        catch (Exception ex)
        {
            ex.Message.ToString();
        }
    }
}