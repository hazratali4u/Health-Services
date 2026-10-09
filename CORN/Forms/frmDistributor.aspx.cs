using System;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;
using CORNBusinessLayer.Classes;
using CORNCommon.Classes;
using System.Web;
using System.IO;
using CORNBusinessLayer;
using CORNDataAccessLayer.Response;

public partial class Forms_frmDistributor : System.Web.UI.Page
{
    readonly DistributorController mController = new DistributorController();
    readonly UserController _UserCtrl = new UserController();

    readonly GeoHierarchyController GControler = new GeoHierarchyController();
    readonly DataControl dc = new DataControl();
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Cache.SetCacheability(HttpCacheability.NoCache);
        Response.Cache.SetExpires(DateTime.Now.AddSeconds(-1));
        Response.Cache.SetNoStore();
        Response.AppendHeader("pragma", "no-cache");

        if (!Page.IsPostBack)
        {
            GetDistributorType();
            GetDistibutorNature();
            LoadGrid("");
            LoadCompany();
            LoadDistrict();
            LoadTehsil();
            LoadConstituency();
            btnSave.Attributes.Add("onclick", "return ValidateForm()");
        }
    }

    private void LoadCompany()
    {
        CompanyController mCompany = new CompanyController();
        DataTable dt = mCompany.SelectCompany(Constants.IntNullValue, Constants.IntNullValue);
        clsWebFormUtil.FillDxComboBoxList(DrpCompanyName, dt, 0, 1, true);
        DrpCompanyName.SelectedIndex = 0;
    }

    private void GetDistributorType()
    {
        DataTable dt = mController.SelectDistributorTypeInfo(2);
        clsWebFormUtil.FillDxComboBoxList(ddDistributorType, dt, 0, 2);
        ddDistributorType.SelectedIndex = 0;
    }
    private void GetDistibutorNature()
    {
        InstituteNatureManager manager = new InstituteNatureManager();
        InstituteNatureResponse response = manager.InstituteNatureGetAll();

        ddDistributorNature.DataSource = response.InstituteNatureList;
        ddDistributorNature.ValueField = "Id";

        ddDistributorNature.DataBind();

        if (ddDistributorNature.Items.Count > 0)
        {
            ddDistributorNature.SelectedIndex = 0;
        }
    }
    private void LoadGrid(string pType)
    {

        GridDistributor.DataSource = null;
        GridDistributor.DataBind();

        DataTable dt = new DataTable();

        dt = mController.SelectAllDistributors(Constants.IntNullValue, Constants.IntNullValue, Constants.IntNullValue);

        if (pType == "")
        {
            if (txtSearch.Text != "" || txtSearch.Text != string.Empty)//In case after  Filter
            {
                if (txtSearch.Text != "" || txtSearch.Text != string.Empty)

                    dt.DefaultView.RowFilter = "DISTRIBUTOR_NAME LIKE '%" + txtSearch.Text + "%'  OR TYPENAME LIKE '%" + txtSearch.Text + "%' OR ADDRESS1 LIKE '%" + txtSearch.Text + "%' OR CONTACT_PERSON LIKE '%" + txtSearch.Text + "%' OR CONTACT_NUMBER LIKE '%" + txtSearch.Text + "%' OR GST_NUMBER LIKE '%" + txtSearch.Text + "%' OR ISDELETED LIKE '" + txtSearch.Text + " %'";
            }
            GridDistributor.DataSource = dt;
            GridDistributor.DataBind();
        }
        else
        {
            if (txtSearch.Text != "" || txtSearch.Text != string.Empty)
            {
                dt.DefaultView.RowFilter = "DISTRIBUTOR_NAME LIKE '%" + txtSearch.Text + "%'  OR TYPENAME LIKE '%" + txtSearch.Text + "%' OR ADDRESS1 LIKE '%" + txtSearch.Text + "%' OR CONTACT_PERSON LIKE '%" + txtSearch.Text + "%' OR CONTACT_NUMBER LIKE '%" + txtSearch.Text + "%' OR GST_NUMBER LIKE '%" + txtSearch.Text + "%' OR ISDELETED LIKE '" + txtSearch.Text + " %'";
            }
            if (dt.Rows.Count > 0)
            {
                GridDistributor.PageIndex = 0;
            }
            GridDistributor.DataSource = dt;
            GridDistributor.DataBind();
        }
    }

    private void LoadDistrict()
    {
        DataTable dt = GControler.SelectGeoHierarchyMain(Constants.IntNullValue, Constants.IntNullValue, Constants.IntNullValue, null, null, false, Constants.IntNullValue, Constants.Zone, Constants.IntNullValue, Constants.DateNullValue, Constants.DateNullValue, int.Parse(this.Session["CompanyId"].ToString()));
        DrpDistrict.DataSource = dt;
        DrpDistrict.ValueField = "GEO_ID";
        DrpDistrict.DataBind();
        if (DrpDistrict.Items.Count > 0)
        {
            DrpDistrict.SelectedIndex = 0;
        }
    }

    private void LoadTehsil()
    {
        DrpTehsil.Items.Clear();
        if (DrpDistrict.Items.Count > 0)
        {
            DataTable dt = GControler.SelectGeoHierarchyMain(Constants.IntNullValue, Constants.IntNullValue, int.Parse(DrpDistrict.Value.ToString()), null, null, false, Constants.IntNullValue, Constants.Territory, Constants.IntNullValue, Constants.DateNullValue, Constants.DateNullValue, int.Parse(this.Session["CompanyId"].ToString()));

            DrpTehsil.DataSource = dt;
            DrpTehsil.ValueField = "GEO_ID";
            DrpTehsil.DataBind();
        }
        if (DrpTehsil.Items.Count > 0)
        {
            DrpTehsil.SelectedIndex = 0;
        }
    }
    private void LoadConstituency()
    {
        DrpConstituency.Items.Clear();
        if (DrpTehsil.Items.Count > 0)
        {
            DataTable dt = GControler.SelectGeoHierarchyMain(Constants.IntNullValue, Constants.IntNullValue, int.Parse(DrpTehsil.Value.ToString()), null, null, false, Constants.IntNullValue, Constants.Town, Constants.IntNullValue, Constants.DateNullValue, Constants.DateNullValue, int.Parse(this.Session["CompanyId"].ToString()));
            DrpConstituency.DataSource = dt;
            DrpConstituency.ValueField = "GEO_ID";
            DrpConstituency.DataBind();
        }
        if (DrpConstituency.Items.Count > 0)
        {
            DrpConstituency.SelectedIndex = 0;
        }
    }
    protected void DrpDistrict_SelectedIndexChanged(object sender, EventArgs e)
    {
        string SelectedValueDistrict = DrpDistrict.Value.ToString();
        this.LoadDistrict();
        DrpDistrict.Value = SelectedValueDistrict;
        LoadTehsil();
        LoadConstituency();
        mPopUpLocation.Show();
    }

    protected void DrpTehsil_SelectedIndexChanged(object sender, EventArgs e)
    {
        string SelectedValueDistrict = DrpDistrict.Value.ToString();
        string SelectedValueTehsil = DrpTehsil.Value.ToString();
        this.LoadDistrict();
        DrpDistrict.Value = SelectedValueDistrict;
        LoadTehsil();
        DrpTehsil.Value = SelectedValueTehsil;
        this.LoadConstituency();
        mPopUpLocation.Show();
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        int id = 0;

        if (!string.IsNullOrEmpty(hfDistributorID.Value))
        {
            id = int.Parse(hfDistributorID.Value);
        }

        if (mController.CheckDuplicateDistributor(id, txtDistributorName.Text.Trim()))
        {
            mPopUpLocation.Show();
            ScriptManager.RegisterStartupScript(this, typeof(Page), "Alert", "alert('Distributor name already exists.');", true);
            return;
        }

        if (chkService.Checked)
        {
            txtServiceTax.Text = "0";
        }

        int coverTable = 0;

        if (chkIsCoverTable.Checked)
        {
            coverTable = 1;
        }
        string fileName = null;
        if (fuPic.HasFile)
        {
            Session["haspic"] = 1;
            string path = Server.MapPath("~/Pics");
            string fExtension = "";
            FileInfo oFileInfo = new FileInfo(fuPic.PostedFile.FileName);
            fExtension = Path.GetExtension(fuPic.FileName);
            fileName = DateTime.Now.ToString("yyyyMMddHHmmss") + "pic" + fExtension;
            string fullFileName = path + "\\" + fileName;
            Session.Add("Pic", fileName);
            hfPic.Value = fileName;
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            fuPic.PostedFile.SaveAs(fullFileName);
        }

        if (Convert.ToString(hfPic.Value) == "" && chkShowLogo.Checked)
        {
            mPopUpLocation.Show();
            ScriptManager.RegisterStartupScript(this, typeof(Page), "Alert", "alert('Select Logo or Uncheck Show Logo.');", true);
            return;
        }
        long NatureID = Constants.IntNullValue;
        int DistrictID = Constants.IntNullValue;
        int TehsilID = Constants.IntNullValue;
        int ConstituencyID = Constants.IntNullValue;
        //if (ddDistributorNature.SelectedIndex > 0)
        //{
        NatureID = Convert.ToInt64(ddDistributorNature.Value);
        //}
        //if (DrpDistrict.SelectedIndex > 0)
        //{
        DistrictID = Convert.ToInt32(DrpDistrict.Value);
        //}
        //if (DrpTehsil.SelectedIndex > 0)
        //{
        TehsilID = Convert.ToInt32(DrpTehsil.Value);
        //}
        //if (DrpConstituency.SelectedIndex > 0)
        //{
        ConstituencyID = Convert.ToInt32(DrpConstituency.Value);
        //}
        if (btnSave.Text == "Save")
        {
            if (mController.InsertDistributor(int.Parse(DrpCompanyName.SelectedItem.Value.ToString()), coverTable, !chkIsActive.Checked, System.DateTime.Now, System.DateTime.Now, DistrictID, Constants.IntNullValue
                , TehsilID, ConstituencyID, int.Parse(ddDistributorType.SelectedItem.Value.ToString()), txtcontactperson.Text.Trim(), txtPhoneNo.Text.Trim(), txtgstno.Text.Trim(),
               txtpassword.Text.Trim(), txtAddress1.Text.Trim(), txtEmailAddress.Text.Trim(), txtDistributorCode.Text.Trim(), txtDistributorName.Text.Trim(), txtFacebookAddress.Text.Trim(), cbRegistered.Checked, 1, int.Parse(this.Session["UserId"].ToString())
               , Convert.ToDecimal(dc.chkNull_0(txtServiceTax.Text.Trim())), chkService.Checked, short.Parse(rdbServiceType.SelectedValue), fileName, chkShowLogo.Checked, txtLongitude.Text, txtLatitude.Text, "", null, false, NatureID) == null)
            {
                this.SaveDXState();
                mPopUpLocation.Show();
                ScriptManager.RegisterStartupScript(this, typeof(Page), "Alert", "alert('Some error occurred.');", true);
                return;
            }
            this.SaveDXState();
            mPopUpLocation.Show();
            ScriptManager.RegisterStartupScript(this, typeof(Page), "Alert", "alert('Record added successfully.');", true);
        }
        else
        {
            if (mController.UpdateDistributor(int.Parse(DrpCompanyName.SelectedItem.Value.ToString()), coverTable, !chkIsActive.Checked, Constants.DateNullValue, System.DateTime.Now, DistrictID, Constants.IntNullValue
                , TehsilID, ConstituencyID, int.Parse(ddDistributorType.SelectedItem.Value.ToString()), txtcontactperson.Text.Trim(), txtPhoneNo.Text.Trim(), txtgstno.Text.Trim(),
             txtpassword.Text.Trim(), txtAddress1.Text.Trim(), txtEmailAddress.Text.Trim(), int.Parse(hfDistributorID.Value), txtDistributorCode.Text.Trim(), txtDistributorName.Text.Trim(), txtFacebookAddress.Text.Trim(), cbRegistered.Checked
             , 1, int.Parse(this.Session["UserId"].ToString()), Convert.ToDecimal(dc.chkNull_0(txtServiceTax.Text.Trim())), chkService.Checked, short.Parse(rdbServiceType.SelectedValue), fileName, chkShowLogo.Checked, txtLongitude.Text, txtLatitude.Text, "", null, false, NatureID) == null)
            {
                this.SaveDXState();
                ScriptManager.RegisterStartupScript(this, typeof(Page), "Alert", "alert('Some error occurred.');", true);
                return;
            }
            ScriptManager.RegisterStartupScript(this, typeof(Page), "Alert", "alert('Record updated successfully.');", true);
            this.SaveDXState();
            mPopUpLocation.Hide();
        }
        ClearAll();
        LoadGrid("");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        mPopUpLocation.Show();
        this.SaveDXState();
        ClearAll();
    }

    protected void btnFilter_Click(object sender, EventArgs e)
    {
        LoadGrid("filter");
    }

    protected void btnClose_Click(object sender, EventArgs e)
    {
        this.SaveDXState();
        ddDistributorType.SelectedIndex = 0;
        DrpCompanyName.SelectedIndex = 0;
        ClearAll();
    }

    protected void GridDistributor_RowEditing(object sender, GridViewEditEventArgs e)
    {
        this.GetDistibutorNature();
        this.LoadDistrict();
        Session.Add("Pic", "");
        hfPic.Value = "";
        hfDistributorID.Value = GridDistributor.Rows[e.NewEditIndex].Cells[1].Text;
        DrpCompanyName.Value = GridDistributor.Rows[e.NewEditIndex].Cells[12].Text;
        cbRegistered.Checked = bool.Parse(GridDistributor.Rows[e.NewEditIndex].Cells[2].Text);
        txtEmailAddress.Text = GridDistributor.Rows[e.NewEditIndex].Cells[4].Text.Replace("&nbsp;", "");
        txtDistributorCode.Text = GridDistributor.Rows[e.NewEditIndex].Cells[5].Text.Replace("&nbsp;", "");
        txtDistributorName.Text = GridDistributor.Rows[e.NewEditIndex].Cells[6].Text.Replace("&nbsp;", "");
        txtAddress1.Text = GridDistributor.Rows[e.NewEditIndex].Cells[8].Text.Replace("&nbsp;", "");
        txtcontactperson.Text = GridDistributor.Rows[e.NewEditIndex].Cells[9].Text.Replace("&nbsp;", "");
        txtPhoneNo.Text = GridDistributor.Rows[e.NewEditIndex].Cells[10].Text.Replace("&nbsp;", "");
        if (GridDistributor.Rows[e.NewEditIndex].Cells[13].Text == "Active")
        {
            chkIsActive.Checked = true;
        }
        else
        {
            chkIsActive.Checked = false;
        }
        if (GridDistributor.Rows[e.NewEditIndex].Cells[11].Text == "&nbsp;")
        {
            txtgstno.Text = "";
            cbRegistered.Checked = false;
            txtgstno.Enabled = false;
        }
        else
        {
            cbRegistered.Checked = true;
            txtgstno.Text = GridDistributor.Rows[e.NewEditIndex].Cells[11].Text.Replace("&nbsp;", "");
            txtgstno.Enabled = true;
        }
        txtServiceTax.Text = GridDistributor.Rows[e.NewEditIndex].Cells[15].Text.Replace("&nbsp;", "");

        if (GridDistributor.Rows[e.NewEditIndex].Cells[16].Text == "1")
        {
            chkIsCoverTable.Checked = true;
        }
        else
        {
            chkIsCoverTable.Checked = false;
        }

        if (string.IsNullOrEmpty(GridDistributor.Rows[e.NewEditIndex].Cells[17].Text.Replace("&nbsp;", "")))
        {
            chkService.Checked = false;
        }
        else
        {
            chkService.Checked = Convert.ToBoolean(GridDistributor.Rows[e.NewEditIndex].Cells[17].Text.Replace("&nbsp;", ""));
        }
        txtFacebookAddress.Text = GridDistributor.Rows[e.NewEditIndex].Cells[18].Text.Replace("&nbsp;", "");
        rdbServiceType.SelectedValue = GridDistributor.Rows[e.NewEditIndex].Cells[19].Text;
        hfPic.Value = GridDistributor.Rows[e.NewEditIndex].Cells[20].Text.Replace("&nbsp;", "");
        ScriptManager.RegisterClientScriptBlock(this, typeof(System.Web.UI.Page), "MyJSFunction", "MyJSFunction2();", true);
        if (Convert.ToString(hfPic.Value) == "")
        {
            Session["haspic"] = 0;
        }
        else
        {
            Session["haspic"] = 1;
        }
        chkShowLogo.Checked = Convert.ToBoolean(GridDistributor.Rows[e.NewEditIndex].Cells[21].Text);
        txtLongitude.Text = GridDistributor.Rows[e.NewEditIndex].Cells[22].Text.Replace("&nbsp;", "");
        txtLatitude.Text = GridDistributor.Rows[e.NewEditIndex].Cells[23].Text.Replace("&nbsp;", "");
        txtSmsContact.Text = GridDistributor.Rows[e.NewEditIndex].Cells[26].Text.Replace("&nbsp;", "");

        if (GridDistributor.Rows[e.NewEditIndex].Cells[27].Text.Replace("&nbsp;", "") != "")
        {
            DrpDistrict.Value = GridDistributor.Rows[e.NewEditIndex].Cells[27].Text;
            LoadTehsil();
            if (GridDistributor.Rows[e.NewEditIndex].Cells[28].Text.Replace("&nbsp;", "") != "")
            {
                DrpTehsil.Value = GridDistributor.Rows[e.NewEditIndex].Cells[28].Text;
            }
            LoadConstituency();
            if (GridDistributor.Rows[e.NewEditIndex].Cells[29].Text.Replace("&nbsp;", "") != "")
            {
                DrpConstituency.Value = GridDistributor.Rows[e.NewEditIndex].Cells[29].Text;
            }
        }
        if (GridDistributor.Rows[e.NewEditIndex].Cells[30].Text.Replace("&nbsp;", "") != "")
        {
            ddDistributorNature.Value = GridDistributor.Rows[e.NewEditIndex].Cells[30].Text;
        }
        mPopUpLocation.Show();
        btnSave.Text = "Update";
    }

    private void ClearAll()
    {
        txtDistributorName.Text = "";
        txtDistributorCode.Text = "";
        txtAddress1.Text = "";
        txtEmailAddress.Text = "";
        txtcontactperson.Text = "";
        txtPhoneNo.Text = "";
        txtpassword.Text = "";
        txtgstno.Text = "";
        txtServiceTax.Text = "";
        txtSmsContact.Text = "";
        txtLongitude.Text = "";
        txtLatitude.Text = "";
        btnSave.Text = "Save";
        cbRegistered.Checked = false;
        txtgstno.Enabled = false;
        if (cbRegistered.Checked)
        {
            txtgstno.Enabled = true;
        }
        chkIsCoverTable.Checked = true;
        chkService.Checked = false;
        rdbServiceType.SelectedIndex = 0;
        txtFacebookAddress.Text = "";
        hfPic.Value = "";
    }

    protected void btnActive_Click(object sender, EventArgs e)
    {
        //btnActive.OnClientClick = string.Format("return confirm('Are you sure you want to delete?');");
        bool check = false;
        try
        {
            foreach (GridViewRow dr2 in GridDistributor.Rows)
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

            foreach (GridViewRow dr in GridDistributor.Rows)
            {

                var chRelized = (CheckBox)dr.Cells[0].FindControl("ChbIsAssigned");

                if (chRelized.Checked)
                {

                    if (Convert.ToString(dr.Cells[13].Text) == "Active")
                    {

                        _UserCtrl.ActiveInactive(false, Convert.ToInt32(dr.Cells[1].Text), int.Parse(DrpCompanyName.Value.ToString()), 8);


                        flag = true;

                    }
                    else
                    {

                        _UserCtrl.ActiveInactive(true, Convert.ToInt32(dr.Cells[1].Text), int.Parse(DrpCompanyName.Value.ToString()), 8);

                        flag = true;
                    }
                }
            }
            if (flag)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "msg", "alert('Record updated successfully');", true);
            }

            this.LoadGrid("");
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterStartupScript(this, typeof(Page), "CatchMsg", "alert('" + ex.Message.ToString() + "');", true);
        }
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        mPopUpLocation.Show();
        ClearAll();
    }

    protected void grdData_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridDistributor.PageIndex = e.NewPageIndex;
        LoadGrid("");
    }

    private void SaveDXState()
    {
        string SelectedValueDistributorNature = string.Empty;
        if (ddDistributorNature.SelectedIndex > 0)
        {
            SelectedValueDistributorNature = ddDistributorNature.Value.ToString();
        }
        string SelectedValueDistrict = string.Empty;
        if (DrpDistrict.SelectedIndex > 0)
        {
            SelectedValueDistrict = DrpDistrict.Value.ToString();
        }
        string SelectedValueTehsil = string.Empty;
        if (DrpTehsil.SelectedIndex > 0)
        {
            SelectedValueTehsil = DrpTehsil.Value.ToString();
        }

        string SelectedValueConstituency = string.Empty;
        if (DrpConstituency.SelectedIndex > 0)
        {
            SelectedValueConstituency = DrpConstituency.Value.ToString();
        }

        this.GetDistibutorNature();
        this.LoadDistrict();
        this.LoadTehsil();
        this.LoadConstituency();
        if (SelectedValueDistributorNature != "")
        {
            ddDistributorNature.Value = SelectedValueDistributorNature;
        }
        if (SelectedValueDistrict != "")
        {
            DrpDistrict.Value = SelectedValueDistrict;
        }
        if (SelectedValueTehsil != "")
        {
            DrpTehsil.Value = SelectedValueTehsil;
        }
        if (SelectedValueConstituency != "")
        {
            DrpConstituency.Value = SelectedValueConstituency;
        }
    }

}