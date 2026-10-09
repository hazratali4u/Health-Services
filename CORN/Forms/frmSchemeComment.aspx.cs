using System;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;
using CORNBusinessLayer.Classes;
using CORNCommon.Classes;
using System.Web;

public partial class Forms_frmSchemeComment : System.Web.UI.Page
{
    Distributor_UserController UController = new Distributor_UserController();
    FinancialYearController FincialYear = new FinancialYearController();
    HealthSchemeController HealthCtl = new HealthSchemeController();
    SaleForceController mDController = new SaleForceController();
    DataControl dc = new DataControl();
    static int UserId;
    private static int _rowNo;

    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Cache.SetCacheability(HttpCacheability.NoCache);
        Response.Cache.SetExpires(DateTime.Now.AddSeconds(-1));
        Response.Cache.SetNoStore();
        Response.AppendHeader("pragma", "no-cache");
        if (!Page.IsPostBack)
        {
            this.LoadScheme();
            btnSave.Attributes.Add("onclick", "return ValidateForm()");
            divHOComments.Visible = false;
            if (Convert.ToBoolean(Session["Can_HOComments"]))
            {
                divHOComments.Visible = true;
            }

            btnLoadComments_Click(null, null);
        }
        Response.Expires = 0;
        Response.Cache.SetNoStore();
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (Page.IsValid)
            {
                if (ddlScheme.Value == null)
                {
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "CatchMsg", "alert('Please provide scheme.');", true);
                }
                else
                {
                    if (txtComments.Html.Length > 0 || txtHOComments.Html.Length > 0)
                    {
                        if (HealthCtl.InsertSchemeComment(Convert.ToInt64(ddlScheme.Value), Convert.ToDateTime(Session["CurrentWorkDate"]), Convert.ToDateTime(ddlMonth.Value.ToString() + "-" + ddlYear.Value.ToString()), Convert.ToDateTime(ddlMonth.Value.ToString() + "-" + ddlYear.Value.ToString()), txtComments.Html, txtHOComments.Html, Convert.ToInt32(Session["UserID"])))
                        {
                            ScriptManager.RegisterStartupScript(this, typeof(Page), "CatchMsg", "alert('Comments Saved Successfully.');", true);
                        }
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "CatchMsg", "alert('Please provide comment.');", true);
                    }
                }
            }

            SaveDXState();
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterStartupScript(this, typeof(Page), "CatchMsg", "alert('" + ex.Message.ToString() + "');", true);
            SaveDXState();
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {


    }

    protected void btnLoadComments_Click(object sender, EventArgs e)
    {
        try
        {
            txtComments.Html = string.Empty;
            txtHOComments.Html = string.Empty;
            DataTable dtComments = HealthCtl.GetSchemeComments(Constants.LongNullValue, Convert.ToInt64(ddlScheme.Value), Convert.ToDateTime(ddlMonth.Value.ToString() + "-" + ddlYear.Value.ToString()), Convert.ToDateTime(ddlMonth.Value.ToString() + "-" + ddlYear.Value.ToString()), Convert.ToInt32(Session["UserID"]), 1);
            if (dtComments.Rows.Count > 0)
            {
                txtComments.Html = dtComments.Rows[0]["strComments"].ToString();
                txtHOComments.Html = dtComments.Rows[0]["strHOComments"].ToString();
            }
        }
        catch (Exception ex)
        {

        }
        SaveDXState();
    }

    private void LoadScheme()
    {
        DataTable dt = new DataTable();


        dt = HealthCtl.GetScheme(Constants.IntNullValue, 6, Constants.LongNullValue, Convert.ToInt32(Session["UserID"]));
        ddlScheme.DataSource = dt;
        ddlScheme.ValueField = "lngSchemeCode";
        ddlScheme.DataBind();
        Session.Add("dtScheme", dt);

        if (ddlScheme.Items.Count > 0)
        {
            ddlScheme.SelectedIndex = 0;

            PopulateYears(Convert.ToDateTime(dt.Rows[0]["dtmStartDate"]), Convert.ToDateTime(dt.Rows[0]["dtmEndDate"]));
        }
    }

    private void LoadGrid()
    {

    }

    private void SaveDXState()
    {
        string SelectedValueScheme = string.Empty;

        if (ddlScheme.Value != null)
        {
            SelectedValueScheme = ddlScheme.Value.ToString();
        }

        this.LoadScheme();

        if (string.IsNullOrEmpty(SelectedValueScheme))
        {
            ddlScheme.Value = SelectedValueScheme;
        }
    }
    private void PopulateYears(DateTime dtStartDate, DateTime dtEndDate)
    {
        ddlYear.Items.Clear();
        int selIndex = 0;
        int i = 0;

        while (dtStartDate.Year <= dtEndDate.Year)
        {
            if (dtStartDate.Year == DateTime.Now.Year)
            {
                selIndex = i;
            }

            ddlYear.Items.Add(new DevExpress.Web.ListEditItem(dtStartDate.Year.ToString(), dtStartDate.Year));
            dtStartDate = dtStartDate.AddYears(1);

            i++;
        }

        if (ddlYear.Items.Count > 0)
        {
            ddlYear.SelectedIndex = selIndex;
        }

        ddlMonth.SelectedIndex = (DateTime.Now.Month - 1);
    }

    protected void ddlScheme_SelectedIndexChanged(object sender, EventArgs e)
    {
        SaveDXState();

        DataTable dtScheme = (DataTable)Session["dtScheme"];

        foreach (DataRow dr in dtScheme.Rows)
        {
            if (dr["lngSchemeCode"].ToString() == ddlScheme.Value.ToString())
            {
                PopulateYears(Convert.ToDateTime(dr["dtmStartDate"]), Convert.ToDateTime(dr["dtmEndDate"]));
            }
        }
    }
}