using System;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;
using CORNBusinessLayer.Classes;
using CORNCommon.Classes;


public partial class Forms_frmGeoHierarchyData : Page
{
    GeoHierarchyController GControler = new GeoHierarchyController();
   
     
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            this.LoadZone();
            this.LoadTerritoryZone();
            this.LoadTerritory();
            this.LoadTownZone();
            this.LoadTownTerritory();
            this.LoadTown();

            btnSaveZone.Attributes.Add("onclick", "return ValidatZone()");
            btnSaveTerritory.Attributes.Add("onclick", "return ValidateTerritory()");
            btnSaveTown.Attributes.Add("onclick", "return ValidateTown()");

        }
    }
    

    #region District Tab
    
    protected void LoadZone()
    {
       
            DataTable dt = GControler.SelectGeoHierarchyMain(Constants.IntNullValue, Constants.IntNullValue, Constants.IntNullValue, null, null, false, Constants.IntNullValue, Constants.Zone, Constants.IntNullValue, Constants.DateNullValue, Constants.DateNullValue, int.Parse(this.Session["CompanyId"].ToString()));
            grdZoneData.DataSource = dt;
            grdZoneData.DataBind();
        
    }
    
    protected void grdZoneData_RowEditing(object sender, GridViewEditEventArgs e)
    {
        HdnZoneID.Value = int.Parse(grdZoneData.Rows[e.NewEditIndex].Cells[1].Text).ToString();
        btnSaveZone.Text = "Update";
        txtZoneCode.Text = grdZoneData.Rows[e.NewEditIndex].Cells[2].Text;
        txtZoneName.Text = grdZoneData.Rows[e.NewEditIndex].Cells[3].Text;
        chbIsZoneActive.Checked = bool.Parse(grdZoneData.Rows[e.NewEditIndex].Cells[4].Text);

    }

    protected void grdZoneData_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        DataTable dt = GControler.SelectDistributorHierachyWithType(2, Constants.IntNullValue, null, int.Parse(grdZoneData.Rows[e.RowIndex].Cells[1].Text), Constants.IntNullValue);

        if (dt.Rows.Count > 0)
        {
            lblErrorZone.Text = "Active Territory(s) Exists...";
        }
        else
        {
            if (GControler.UpdateHierarchy(int.Parse(grdZoneData.Rows[e.RowIndex].Cells[1].Text), Constants.IntNullValue, grdZoneData.Rows[e.RowIndex].Cells[2].Text, grdZoneData.Rows[e.RowIndex].Cells[3].Text, false, true, Constants.IntNullValue, int.Parse(this.Session["CompanyId"].ToString()), Constants.Zone, int.Parse(this.Session["UserId"].ToString()), int.Parse(this.Session["DISTRIBUTOR_ID"].ToString()), null))
            {
                this.LoadZone();
                this.LoadTerritoryZone();
                this.LoadTownZone();
                txtZoneCode.Text = "";
                txtZoneName.Text = "";
                btnSaveZone.Text = "Save";
                lblErrorZone.Text = "";
                HdnZoneID.Value = "";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "msg", "alert('Zone deleted successfully !')", true);
            }
        }
    }

    protected void btnSaveZone_Click(object sender, EventArgs e)
    {
        int id = 0;

        if (!string.IsNullOrEmpty(HdnZoneID.Value))
        {
            id = int.Parse(HdnZoneID.Value);
        }

        if (GControler.CheckDuplicateGEOHierarchy(id, txtZoneName.Text.Trim(), Constants.Zone))
        {
            lblErrorZone.Text = "District already exists.";
            return;
        }

        bool InsertValue = false;
        if (btnSaveZone.Text == "Save")
        {
            InsertValue = GControler.InsertHierarchy(Constants.IntNullValue, txtZoneCode.Text, txtZoneName.Text, true, false, Constants.IntNullValue, int.Parse(this.Session["CompanyId"].ToString()), Constants.Zone, int.Parse(this.Session["UserId"].ToString()), int.Parse(this.Session["DISTRIBUTOR_ID"].ToString()), null);
        }
        else
        {
            if (chbIsZoneActive.Checked == false)
            {
                DataTable dt = GControler.SelectDistributorHierachyWithType(2, Constants.IntNullValue, null, int.Parse(HdnZoneID.Value), Constants.IntNullValue);
                if (dt.Rows.Count > 0)
                {
                    lblErrorZone.Text = "An Active Tehsil Exists...";
                    return;
                }
            }
            InsertValue = GControler.UpdateHierarchy(int.Parse(HdnZoneID.Value), Constants.IntNullValue, txtZoneCode.Text, txtZoneName.Text, chbIsZoneActive.Checked, false, Constants.IntNullValue, int.Parse(this.Session["CompanyId"].ToString()), Constants.Zone, int.Parse(this.Session["UserId"].ToString()), int.Parse(this.Session["DISTRIBUTOR_ID"].ToString()), null);
        }
        if (InsertValue)
        {
            LoadZone();
            LoadTerritoryZone();
            LoadTownZone();
            txtZoneCode.Text = "";
            txtZoneName.Text = "";
            btnSaveZone.Text = "Save";
            lblErrorZone.Text = "";
            HdnZoneID.Value = "";
            ScriptManager.RegisterStartupScript(this, this.GetType(), "msg", "alert('Record Updated !')", true);
        }
        else
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "msg", "alert('Please Try Again !')", true);
        }
    }

    #endregion

    #region Tehsil Tab

    protected void LoadTerritory()
    {
        if (DrpZone.Items.Count > 0)
        {
            DataTable dt = GControler.SelectGeoHierarchyMain(Constants.IntNullValue, Constants.IntNullValue, int.Parse(DrpZone.SelectedItem.Value.ToString()), null, null, false, Constants.IntNullValue, Constants.Territory, Constants.IntNullValue, Constants.DateNullValue, Constants.DateNullValue, int.Parse(this.Session["CompanyId"].ToString()));
            grdTerritoryData.DataSource = dt;
            grdTerritoryData.DataBind();
        }
    }

   
    private void LoadTerritoryZone()
    {

        DataTable dt = GControler.SelectGeoHierarchyMain(Constants.IntNullValue, Constants.IntNullValue, Constants.IntNullValue, null, null, false, Constants.IntNullValue, Constants.Zone, Constants.IntNullValue, Constants.DateNullValue, Constants.DateNullValue, int.Parse(this.Session["CompanyId"].ToString()));
        clsWebFormUtil.FillDxComboBoxList(DrpZone, dt, 0, 4, true);
        if (dt.Rows.Count > 0)
        {
            DrpZone.SelectedIndex = 0;
        }
    }
    
    protected void DrpZone_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.LoadTerritory();
    }

    
    protected void grdTerritoryData_RowEditing(object sender, GridViewEditEventArgs e)
    {
        HdnTerritoryID.Value = int.Parse(grdTerritoryData.Rows[e.NewEditIndex].Cells[1].Text).ToString();
        btnSaveTerritory.Text = "Update";
        txtTerritoryCode.Text = grdTerritoryData.Rows[e.NewEditIndex].Cells[2].Text;
        txtTerritoryName.Text = grdTerritoryData.Rows[e.NewEditIndex].Cells[3].Text;
        chbIsTerritoryActive.Checked = bool.Parse(grdTerritoryData.Rows[e.NewEditIndex].Cells[4].Text);

    }

    protected void grdTerritoryData_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        DataTable dt = GControler.SelectDistributorHierachyWithType(3, Constants.IntNullValue, null, Constants.IntNullValue, int.Parse(grdTerritoryData.Rows[e.RowIndex].Cells[1].Text));
        if (dt.Rows.Count > 0)
        {
            lblErrorTerr.Text = "Active Constituency(s) Exists...";
        }
        else
        {
            if (GControler.UpdateHierarchy(int.Parse(grdTerritoryData.Rows[e.RowIndex].Cells[1].Text), Constants.IntNullValue
                , grdTerritoryData.Rows[e.RowIndex].Cells[2].Text, grdTerritoryData.Rows[e.RowIndex].Cells[3].Text, false, true
                , Constants.IntNullValue, int.Parse(this.Session["CompanyId"].ToString()), Constants.Territory, int.Parse(this.Session["UserId"].ToString())
                , int.Parse(this.Session["DISTRIBUTOR_ID"].ToString()), null))
            {
                this.LoadTerritory();
                this.LoadTownTerritory();
                txtTerritoryCode.Text = "";
                txtTerritoryName.Text = "";
                btnSaveTerritory.Text = "Save";
                lblErrorTerr.Text = "";
                HdnTerritoryID.Value = "";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "msg", "alert('Tehsil deleted successfully !')", true);
            }
        }
    }

    protected void btnSaveTerritory_Click(object sender, EventArgs e)
    {
        int id = 0;

        if (!string.IsNullOrEmpty(HdnTerritoryID.Value))
        {
            id = int.Parse(HdnTerritoryID.Value);
        }

        if (GControler.CheckDuplicateGEOHierarchy(id, txtTerritoryName.Text.Trim(), Constants.Territory))
        {
            lblErrorTerr.Text = "Territory already exists.";
            return;
        }

        bool InsertValue = false;
        if (btnSaveTerritory.Text == "Save")
        {
            InsertValue = GControler.InsertHierarchy(int.Parse(DrpZone.SelectedItem.Value.ToString()), txtTerritoryCode.Text, txtTerritoryName.Text, true, false, Constants.IntNullValue, int.Parse(this.Session["CompanyId"].ToString()), Constants.Territory, int.Parse(this.Session["UserId"].ToString()), int.Parse(this.Session["DISTRIBUTOR_ID"].ToString()), null);
        }
        else
        {
            if (chbIsTerritoryActive.Checked == false)
            {
                DataTable dt = GControler.SelectDistributorHierachyWithType(3, Constants.IntNullValue, null, Constants.IntNullValue, int.Parse(HdnTerritoryID.Value));
                if (dt.Rows.Count > 0)
                {
                    lblErrorTerr.Text = "An Active Town Exists...";
                    return;
                }
            }
            InsertValue = GControler.UpdateHierarchy(int.Parse(HdnTerritoryID.Value), int.Parse(DrpZone.SelectedItem.Value.ToString()), txtTerritoryCode.Text, txtTerritoryName.Text, chbIsTerritoryActive.Checked, false, Constants.IntNullValue, int.Parse(this.Session["CompanyId"].ToString()), Constants.Territory, int.Parse(this.Session["UserId"].ToString()), int.Parse(this.Session["DISTRIBUTOR_ID"].ToString()), null);
        }
        if (InsertValue)
        {
            this.LoadTerritory();
            this.LoadTownTerritory();
            txtTerritoryCode.Text = "";
            txtTerritoryName.Text = "";
            btnSaveTerritory.Text = "Save";
            lblErrorTerr.Text = "";
            HdnTerritoryID.Value = "";
            ScriptManager.RegisterStartupScript(this, this.GetType(), "msg", "alert('Record Updated !')", true);
        }
        else
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "msg", "alert('Please Try Again !')", true);
        }
    }
    #endregion

    #region Town Tab

    
    protected void LoadTown()
    {
        if (DrpTerritory.Items.Count > 0)
        {
            DataTable dt = GControler.SelectGeoHierarchyMain(Constants.IntNullValue, Constants.IntNullValue, int.Parse(DrpTerritory.SelectedItem.Value.ToString()), null, null, false, Constants.IntNullValue, Constants.Town, Constants.IntNullValue, Constants.DateNullValue, Constants.DateNullValue, int.Parse(this.Session["CompanyId"].ToString()));
            grdTownData.DataSource = dt;
            grdTownData.DataBind();
        }
    }

    private void LoadTownZone()
    {
        
            DataTable dt = GControler.SelectGeoHierarchyMain(Constants.IntNullValue, Constants.IntNullValue, Constants.IntNullValue, null, null, false, Constants.IntNullValue, Constants.Zone, Constants.IntNullValue, Constants.DateNullValue, Constants.DateNullValue, int.Parse(this.Session["CompanyId"].ToString()));
            clsWebFormUtil.FillDxComboBoxList(this.DrpTownZone, dt, 0, 4, true);
            if (dt.Rows.Count > 0)
            {
                DrpTownZone.SelectedIndex = 0;
               
            }
    }

    
    private void LoadTownTerritory()
    {
        if (DrpTownZone.Items.Count > 0)
        {
            DataTable dt = GControler.SelectGeoHierarchyMain(Constants.IntNullValue, Constants.IntNullValue, int.Parse(DrpTownZone.SelectedItem.Value.ToString()), null, null, false, Constants.IntNullValue, Constants.Territory, Constants.IntNullValue, Constants.DateNullValue, Constants.DateNullValue, int.Parse(this.Session["CompanyId"].ToString()));
            clsWebFormUtil.FillDxComboBoxList(this.DrpTerritory, dt, 0, 4, true);
            if (dt.Rows.Count > 0)
            {
                DrpTerritory.SelectedIndex = 0;
            }
        }
    }

    protected void DrpTownZone_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.LoadTownTerritory();
        this.LoadTown();
    }
    
    protected void DrpTerritory_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.LoadTown();
    }

    
    protected void grdTownData_RowEditing(object sender, GridViewEditEventArgs e)
    {
        HdntownId.Value = int.Parse(grdTownData.Rows[e.NewEditIndex].Cells[1].Text).ToString();
        btnSaveTown.Text = "Update";
        txtTownCode.Text = grdTownData.Rows[e.NewEditIndex].Cells[2].Text;
        txtTownName.Text = grdTownData.Rows[e.NewEditIndex].Cells[3].Text;
        chbIsTownActive.Checked = bool.Parse(grdTownData.Rows[e.NewEditIndex].Cells[4].Text);

    }

    protected void grdTownData_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        DataTable dt = GControler.SelectDistributorHierachyWithType(9, int.Parse(grdTownData.Rows[e.RowIndex].Cells[1].Text), null);
        if (dt.Rows.Count > 0)
        {
            lblErrorTown.Visible = true;
            lblErrorTown.Text = "This Town is assigned...";
        }
        else
        {
            if (GControler.UpdateHierarchy(int.Parse(grdTownData.Rows[e.RowIndex].Cells[1].Text), Constants.IntNullValue, grdTownData.Rows[e.RowIndex].Cells[2].Text, grdTownData.Rows[e.RowIndex].Cells[3].Text, false, true, Constants.IntNullValue, int.Parse(this.Session["CompanyId"].ToString()), Constants.Town, int.Parse(this.Session["UserId"].ToString()), int.Parse(this.Session["DISTRIBUTOR_ID"].ToString()), null))
            {
                this.LoadTown();
                txtTownCode.Text = "";
                txtTownName.Text = "";
                btnSaveTown.Text = "Save";
                lblErrorTown.Text = "";
                HdntownId.Value = "";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "msg", "alert('Town deleted successfully !')", true);
            }
        }
    }

   
    protected void btnSaveTown_Click(object sender, EventArgs e)
    {
        int id = 0;

        if (!string.IsNullOrEmpty(HdntownId.Value))
        {
            id = int.Parse(HdntownId.Value);
        }

        if (GControler.CheckDuplicateGEOHierarchy(id, txtTownName.Text.Trim(), Constants.Town))
        {
            lblErrorTown.Text = "Constituency already exists.";
            return;
        }

        bool InsertValue = false;
        if (btnSaveTown.Text == "Save")
        {
            InsertValue = GControler.InsertHierarchy(int.Parse(DrpTerritory.SelectedItem.Value.ToString()), txtTownCode.Text, txtTownName.Text, true, false, Constants.IntNullValue, int.Parse(this.Session["CompanyId"].ToString()), Constants.Town, int.Parse(this.Session["UserId"].ToString()), int.Parse(this.Session["DISTRIBUTOR_ID"].ToString()), null);
        }
        else
        {
            if (chbIsTownActive.Checked == false)
            {
                DataTable dt = GControler.SelectDistributorHierachyWithType(9, int.Parse(HdntownId.Value), null);
                if (dt.Rows.Count > 0)
                {
                    lblErrorTown.Text = "This Constituency is Assigned...";
                    return;
                }
            }
            InsertValue = GControler.UpdateHierarchy(int.Parse(HdntownId.Value), int.Parse(DrpTerritory.SelectedItem.Value.ToString()), txtTownCode.Text, txtTownName.Text, chbIsTownActive.Checked, false, Constants.IntNullValue, int.Parse(this.Session["CompanyId"].ToString()), Constants.Town, int.Parse(this.Session["UserId"].ToString()), int.Parse(this.Session["DISTRIBUTOR_ID"].ToString()), null);
        }
        if (InsertValue)
        {
            this.LoadTown();
            txtTownCode.Text = "";
            txtTownName.Text = "";
            btnSaveTown.Text = "Save";
            lblErrorTown.Text = "";
            HdntownId.Value = "";
            ScriptManager.RegisterStartupScript(this, this.GetType(), "msg", "alert('Record Updated !')", true);
        }
        else
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "msg", "alert('Please Try Again !')", true);
        }
    }

    #endregion                
}