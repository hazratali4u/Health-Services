using System;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;
using CORNBusinessLayer.Classes;
using CORNCommon.Classes;
using System.Web;

public partial class Forms_frmSchemePlan : System.Web.UI.Page
{
    Distributor_UserController UController = new Distributor_UserController();
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
            this.LoadGrid("");
            Session.Remove("SchemePlanID");
        }

        Response.Expires = 0;
        Response.Cache.SetNoStore();
    }

    private void LoadGrid(string pType)
    {
        DataTable dt = new DataTable();

        dt = HealthCtl.GetSchemePlan(Constants.LongNullValue, 1, Convert.ToInt32(Session["UserID"]));
        if (pType == "")
        {
            if (txtSearch.Text != "" || txtSearch.Text != string.Empty)
            {
                dt.DefaultView.RowFilter = "strSchemeName LIKE '%" + txtSearch.Text + "%'  OR CategoryName LIKE '%" + txtSearch.Text + "%'";
            }
            gvSchemePlan.DataSource = dt;
            gvSchemePlan.DataBind();
        }
        else
        {
            if (txtSearch.Text != "" || txtSearch.Text != string.Empty)
            {
                dt.DefaultView.RowFilter = "strSchemeName LIKE '%" + txtSearch.Text + "%'  OR CategoryName LIKE '%" + txtSearch.Text + "%'";
            }
            if (dt.Rows.Count > 0)
            {
                gvSchemePlan.PageIndex = 0;
            }
            gvSchemePlan.DataSource = dt;
            gvSchemePlan.DataBind();
        }
    }
    protected void btnFilter_Click(object sender, EventArgs e)
    {
        this.LoadGrid("filter");
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmSchemePlanAdd.aspx?LevelType=" + Request.QueryString["LevelType"].ToString() + "&LevelID=" + Request.QueryString["LevelID"].ToString());
    }
    protected void btnActive_Click(object sender, EventArgs e)
    {
        bool check = false;
        try
        {
            //foreach (GridViewRow dr2 in gvSchemePlan.Rows)
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

            //foreach (GridViewRow dr in gvSchemePlan.Rows)
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
    protected void gvSchemePlan_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvSchemePlan.PageIndex = e.NewPageIndex;
        LoadGrid("");
    }

    protected void gvSchemePlan_RowEditing(object sender, GridViewEditEventArgs e)
    {
        try
        {
            GridViewRow gvr = gvSchemePlan.Rows[e.NewEditIndex];
            Session.Add("SchemePlanID", gvr.Cells[1].Text);
            Response.Redirect("frmSchemePlanAdd.aspx?mode=edit&LevelType=" + Request.QueryString["LevelType"].ToString() + "&LevelID=" + Request.QueryString["LevelID"].ToString());
        }
        catch (Exception ex)
        {
            ex.Message.ToString();
        }
    }
}