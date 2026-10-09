using System;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;
using CORNBusinessLayer.Classes;
using CORNCommon.Classes;
using System.Web;

/// <summary>
/// Form To Add, Edit Account Head
/// </summary>
public partial class Forms_frmAccountHead : System.Web.UI.Page
{
    #region Variables

    readonly AccountHeadController MController = new AccountHeadController();

    private static long AccountTypeId;
    private static long AccountSubTypeId;
    private static long AccountDetailTypeId;
    private static long AccountHeadId;
    private static string strCode;

    #endregion

    /// <summary>
    /// Page_Load Function Populates All Combos And Grid On The Page
    /// </summary>
    /// <param name="sender">object</param>
    /// <param name="e">EventArgs</param>
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Cache.SetCacheability(HttpCacheability.NoCache);
        Response.Cache.SetExpires(DateTime.Now.AddSeconds(-1));
        Response.Cache.SetNoStore();
        Response.AppendHeader("pragma", "no-cache");

        if (!Page.IsPostBack)
        {
            Configuration.DistributorId = 1;

            GetAccountType();
            GetSubAccountType();
            GetSubTypeForDetail();
            GetSubTypeForHead();
            GetDetailAccountType();
            GetDetailAccountTypeForHead();
            GetAccountHead();
        }
    }

    #region MainType Tab

    /// <summary>
    /// Loads All Combos And Grids On The Form
    /// </summary>
    /// <param name="sender">object</param>
    /// <param name="e">EventArgs</param>
    protected void DrpAccountCategory_SelectedIndexChanged(object sender, EventArgs e)

    {
        txtAtypeCode.Text = "";
        btnAccountType.Text = "New Account Type";
        GetAccountType();
        GetSubAccountType();
        GetSubTypeForDetail();
        GetSubTypeForDetail();
        GetSubTypeForHead();
        GetDetailAccountType();
        GetDetailAccountTypeForHead();
        GetAccountHead();
    }

    /// <summary>
    /// Loads Account Main Types To MainType Grid On MainType Tab And All MainType Combos on The Form
    /// </summary>
    private void GetAccountType()
    {
        DataTable dt = MController.SelectAccountHead(Constants.AC_MainTypeId, Constants.LongNullValue, DrpAccountCategory.SelectedIndex, 1, Constants.Account_Form_COA);
        GrdMainType.DataSource = dt;
        GrdMainType.DataBind();
        clsWebFormUtil.FillDxComboBoxList(ddAccountType1, dt, 0, 10, true);
        clsWebFormUtil.FillDxComboBoxList(ddAccountType2, dt, 0, 10, true);
        clsWebFormUtil.FillDxComboBoxList(ddAccountType3, dt, 0, 10, true);

        if (dt.Rows.Count > 0)
        {
            ddAccountType1.SelectedIndex = 0;
            ddAccountType2.SelectedIndex = 0;
            ddAccountType3.SelectedIndex = 0;
        }
    }

    /// <summary>
    /// Loads Account Sub Types To SubType Grid on SubType Tab
    /// </summary>
    /// <param name="sender">object</param>
    /// <param name="e">EventArgs</param>
    protected void ddAccountType1_SelectedIndexChanged(object sender, EventArgs e)
    {
        txtASubTypeCode.Text = "";
        btnAccountSubType.Text = "New";
        GetSubAccountType();
    }

    /// <summary>
    /// Loads Account Sub Types To SubType Combo And Detail Types To DetailType Grid on DetailType Tab
    /// </summary>
    /// <param name="sender">object</param>
    /// <param name="e">EventArgs</param>
    protected void ddAccountType2_SelectedIndexChanged(object sender, EventArgs e)
    {
        txtADetailTypeCode.Text = "";
        btnAccountDetailType.Text = "New";

        GetSubTypeForDetail();
        GetDetailAccountType();
    }

    /// <summary>
    /// Loads Account Sub Types To SubType Combo, Detail Types To DetailType Combo And Account Heads To AccountHead Grid on AccountHead Tab
    /// </summary>
    /// <param name="sender">object</param>
    /// <param name="e">EventArgs</param>
    protected void ddAccountType3_SelectedIndexChanged(object sender, EventArgs e)
    {
        txtAccountCode.Text = "";
        btnSave.Text = "New";

        GetSubTypeForHead();
        GetDetailAccountTypeForHead();
        GetAccountHead();
    }

    /// <summary>
    /// Sets Account MainType For Edit. This Function Runs When An Existing Account MainType Needs To Be Edited
    /// </summary>
    /// <param name="sender">object</param>
    /// <param name="e">GridViewEditEventArgs</param>
    protected void GrdMainType_RowEditing(object sender, GridViewEditEventArgs e)
    {
        AccountTypeId = long.Parse(GrdMainType.Rows[e.NewEditIndex].Cells[0].Text);
        txtAtypeCode.Text = GrdMainType.Rows[e.NewEditIndex].Cells[1].Text;
        txtAtypeName.Text = GrdMainType.Rows[e.NewEditIndex].Cells[2].Text.Replace("amp;", "");
        DrpAccountCategory.SelectedIndex = int.Parse(GrdMainType.Rows[e.NewEditIndex].Cells[3].Text);
        btnAccountType.Text = "Update";
    }

    /// <summary>
    /// Deletes Account MainType
    /// </summary>
    /// <param name="sender">object</param>
    /// <param name="e">GridViewEditEventArgs</param>
    protected void GrdMainType_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        DataTable dt = MController.SelectAccountHead(Constants.AC_SubTypeId, long.Parse(GrdMainType.Rows[e.RowIndex].Cells[0].Text), 2, Constants.Account_Form_COA);

        if (dt.Rows.Count == 0)
        {
            MController.UpdateAccountHead2(long.Parse(GrdMainType.Rows[e.RowIndex].Cells[0].Text), int.Parse(Session["CompanyId"].ToString()), false, DateTime.Now, CORNCommon.Classes.Configuration.DistributorId, Constants.AC_SubTypeId, Constants.LongNullValue, null, null, 0, Constants.Account_Form_COA);
            GetAccountType();
        }
        else
        {
            ScriptManager.RegisterStartupScript(this, GetType(), "msg", "alert('Transaction exists unable to delete');", true);
        }
    }

    /// <summary>
    /// Saves Or Updates Account MainType
    /// </summary>
    /// <param name="sender">object</param>
    /// <param name="e">GridViewEditEventArgs</param>
    protected void btnAccountType_Click(object sender, EventArgs e)
    {
        if (btnAccountType.Text == "New Account Type")
        {
            btnAccountType.Text = "Save Account Type";
            txtAtypeCode.Text = GetAutoCode(Constants.AC_MainTypeId, Constants.LongNullValue);
            ScriptManager.GetCurrent(Page).SetFocus(txtAtypeCode);
        }
        else if (btnAccountType.Text == "Save Account Type")
        {
            MController.InsertAccountHead2(1, true, DateTime.Now, Configuration.DistributorId, Constants.AC_MainTypeId, Constants.LongNullValue, txtAtypeName.Text, txtAtypeCode.Text, DrpAccountCategory.SelectedIndex, Constants.Account_Form_COA);
            GetAccountType();
            GetSubAccountType();
            GetSubTypeForDetail();
            GetSubTypeForHead();
            GetDetailAccountType();
            GetDetailAccountTypeForHead();
            GetAccountHead();
            ClearAll();
        }
        else if (btnAccountType.Text == "Update")
        {
            MController.UpdateAccountHead2(AccountTypeId, 1, true, DateTime.Now, Configuration.DistributorId, Constants.AC_MainTypeId, Constants.LongNullValue, txtAtypeName.Text, txtAtypeCode.Text, DrpAccountCategory.SelectedIndex, Constants.Account_Form_COA);
            GetAccountType();
            GetSubAccountType();
            GetSubTypeForDetail();
            GetSubTypeForHead();
            GetDetailAccountType();
            GetDetailAccountTypeForHead();
            GetAccountHead();
            ClearAll();
        }
    }

    #endregion

    #region SubType Tab

    /// <summary>
    /// Loads Account SubTypes To SubType
    /// </summary>
    private void GetSubAccountType()
    {
        if (ddAccountType1.Items.Count > 0)
        {
            DataTable dt = MController.SelectAccountHead(Constants.AC_SubTypeId, long.Parse(ddAccountType1.SelectedItem.Value.ToString()), DrpAccountCategory.SelectedIndex, 1, Constants.Account_Form_COA);
            GrdSubType.DataSource = dt;
            GrdSubType.DataBind();
        }
    }

    /// <summary>
    /// Sets Account SubType For Edit. This Function Runs When An Existing Account SubType Needs To Be Edited
    /// </summary>
    /// <param name="sender">object</param>
    /// <param name="e">GridViewEditEventArgs</param>
    protected void GrdSubType_RowEditing(object sender, GridViewEditEventArgs e)
    {
        AccountSubTypeId = long.Parse(GrdSubType.Rows[e.NewEditIndex].Cells[0].Text);
        txtASubTypeCode.Text = GrdSubType.Rows[e.NewEditIndex].Cells[1].Text;
        txtSubTypeName.Text = GrdSubType.Rows[e.NewEditIndex].Cells[2].Text.Replace("amp;", "");
        btnAccountSubType.Text = "Update";
    }

    /// <summary>
    /// Deletes Account SubType.
    /// </summary>
    /// <param name="sender">object</param>
    /// <param name="e">GridViewEditEventArgs</param>
    protected void GrdSubType_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        DataTable dt = MController.SelectAccountHead(Constants.AC_DetailTypeId, long.Parse(GrdSubType.Rows[e.RowIndex].Cells[0].Text), 1, Constants.Account_Form_COA);

        if (dt.Rows.Count == 0)
        {
            MController.UpdateAccountHead2(long.Parse(GrdSubType.Rows[e.RowIndex].Cells[0].Text), int.Parse(Session["CompanyId"].ToString()), false, DateTime.Now, CORNCommon.Classes.Configuration.DistributorId, Constants.AC_SubTypeId, Constants.LongNullValue, null, null, 0, Constants.Account_Form_COA);
            GetSubAccountType();
            GetSubTypeForDetail();

        }
        else
        {
            ScriptManager.RegisterStartupScript(this, GetType(), "msg", "alert('Transaction exists unable to delete');", true);
        }
    }

    /// <summary>
    /// Saves Or Updates Account SubType
    /// </summary>
    /// <param name="sender">object</param>
    /// <param name="e">GridViewEditEventArgs</param>
    protected void btnAccountSubType_Click(object sender, EventArgs e)
    {
        try
        {
            if (btnAccountSubType.Text == "New")
            {
                btnAccountSubType.Text = "Save";
                txtASubTypeCode.Text = GetAutoCode(Constants.AC_SubTypeId, long.Parse(ddAccountType1.SelectedItem.Value.ToString()));
                txtASubTypeCode.ReadOnly = false;
                txtSubTypeName.ReadOnly = false;
                ScriptManager.GetCurrent(Page).SetFocus(txtASubTypeCode);
            }
            else if (btnAccountSubType.Text == "Save")
            {
                if (ddAccountType1.Items.Count > 0)
                {
                    MController.InsertAccountHead2(1, true, DateTime.Now, Configuration.DistributorId, Constants.AC_SubTypeId, long.Parse(ddAccountType1.SelectedItem.Value.ToString()), txtSubTypeName.Text, txtASubTypeCode.Text, DrpAccountCategory.SelectedIndex, Constants.Account_Form_COA);
                }
                GetSubAccountType();
                GetSubTypeForDetail();
                GetSubTypeForHead();
                GetDetailAccountType();
                GetDetailAccountTypeForHead();
                GetAccountHead();
                ClearAll();
                txtASubTypeCode.ReadOnly = true;
                txtSubTypeName.ReadOnly = true;
            }
            else if (btnAccountSubType.Text == "Update")
            {
                MController.UpdateAccountHead2(AccountSubTypeId, 1, true, DateTime.Now, Configuration.DistributorId, Constants.AC_SubTypeId, long.Parse(ddAccountType1.SelectedItem.Value.ToString()), txtSubTypeName.Text, txtASubTypeCode.Text, DrpAccountCategory.SelectedIndex, Constants.Account_Form_COA);
                GetSubAccountType();
                GetSubTypeForDetail();
                GetSubTypeForHead();
                GetDetailAccountType();
                GetDetailAccountTypeForHead();
                GetAccountHead();
                ClearAll();
                txtASubTypeCode.ReadOnly = true;
                txtSubTypeName.ReadOnly = true;
            }
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterStartupScript(this, typeof(Page), "CatchMsg", "alert('" + ex.Message.ToString() + "');", true);
        }
    }

    #endregion

    #region DetailType Tab

    /// <summary>
    /// Loads Account SubTypes To SubType Combo
    /// </summary>
    private void GetSubTypeForDetail()
    {
        if (ddAccountType2.Items.Count > 0)
        {
            DataTable dt = MController.SelectAccountHead(Constants.AC_SubTypeId, long.Parse(ddAccountType2.SelectedItem.Value.ToString()), DrpAccountCategory.SelectedIndex, 1, Constants.Account_Form_COA);
            clsWebFormUtil.FillDxComboBoxList(ddAccountSubType1, dt, 0, 10, true);

            if (dt.Rows.Count > 0)
            {
                ddAccountSubType1.SelectedIndex = 0;
            }

        }
    }

    /// <summary>
    /// Loads Account DetailTypes To DetailType Grid
    /// </summary>
    /// <param name="sender">object</param>
    /// <param name="e">GridViewEditEventArgs</param>
    protected void ddAccountSubType1_SelectedIndexChanged(object sender, EventArgs e)
    {

        txtADetailTypeCode.Text = "";
        btnAccountDetailType.Text = "New";

        GetDetailAccountType();
    }

    /// <summary>
    /// Loads Account DetailTypes To DetailType Grid
    /// </summary>
    private void GetDetailAccountType()
    {
        if (ddAccountSubType1.Items.Count > 0)
        {
            DataTable dt = MController.SelectAccountHead(Constants.AC_DetailTypeId, long.Parse(ddAccountSubType1.SelectedItem.Value.ToString()), DrpAccountCategory.SelectedIndex, 1, Constants.Account_Form_COA);
            GrdDetailType.DataSource = dt;
            GrdDetailType.DataBind();
        }
    }

    /// <summary>
    /// Sets Account DetailType For Edit. This Function Runs When An Existing Account DetailType Needs To Be Edited
    /// </summary>
    /// <param name="sender">object</param>
    /// <param name="e">GridViewEditEventArgs</param>
    protected void GrdDetailType_RowEditing(object sender, GridViewEditEventArgs e)
    {
        AccountDetailTypeId = long.Parse(GrdDetailType.Rows[e.NewEditIndex].Cells[0].Text);
        txtADetailTypeCode.Text = GrdDetailType.Rows[e.NewEditIndex].Cells[1].Text;
        txtDetailTypeName.Text = GrdDetailType.Rows[e.NewEditIndex].Cells[2].Text.Replace("amp;", ""); ;
        btnAccountDetailType.Text = "Update";
    }

    /// <summary>
    /// Deletes Account DetailType
    /// </summary>
    /// <param name="sender">object</param>
    /// <param name="e">GridViewEditEventArgs</param>
    protected void GrdDetailType_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        DataTable dt = MController.SelectAccountHead(Constants.AC_AccountHeadId, long.Parse(GrdDetailType.Rows[e.RowIndex].Cells[0].Text), 1, Constants.Account_Form_COA);

        if (dt.Rows.Count == 0)
        {
            MController.UpdateAccountHead2(long.Parse(GrdDetailType.Rows[e.RowIndex].Cells[0].Text), int.Parse(Session["CompanyId"].ToString()), false, DateTime.Now, Configuration.DistributorId, Constants.AC_DetailTypeId, Constants.LongNullValue, null, null, 0, Constants.Account_Form_COA);
            GetDetailAccountType();
            GetDetailAccountTypeForHead();

        }
        else
        {
            ScriptManager.RegisterStartupScript(this, GetType(), "msg", "alert('Transaction exists unable to delete');", true);
        }
    }

    /// <summary>
    /// Save Or Updates Account DetailType
    /// </summary>
    /// <param name="sender">object</param>
    /// <param name="e">GridViewEditEventArgs</param>
    protected void btnAccountDetailType_Click(object sender, EventArgs e)
    {
        try
        {
            if (btnAccountDetailType.Text == "New")
            {
                btnAccountDetailType.Text = "Save";
                txtADetailTypeCode.Text = GetAutoCode(Constants.AC_DetailTypeId, long.Parse(ddAccountSubType1.SelectedItem.Value.ToString()));
                txtADetailTypeCode.ReadOnly = false;
                txtDetailTypeName.ReadOnly = false;
                ScriptManager.GetCurrent(Page).SetFocus(txtADetailTypeCode);
            }
            else if (btnAccountDetailType.Text == "Save")
            {
                if (ddAccountType2.Items.Count > 0 && ddAccountSubType1.Items.Count > 0)
                {
                    MController.InsertAccountHead2(int.Parse(Session["CompanyId"].ToString()), true, DateTime.Now, Configuration.DistributorId, Constants.AC_DetailTypeId, long.Parse(ddAccountSubType1.SelectedItem.Value.ToString()), txtDetailTypeName.Text, txtADetailTypeCode.Text, DrpAccountCategory.SelectedIndex, Constants.Account_Form_COA);
                    GetDetailAccountType();
                    GetDetailAccountTypeForHead();
                    GetAccountHead();
                    ClearAll();
                    txtADetailTypeCode.ReadOnly = true;
                    txtDetailTypeName.ReadOnly = true;
                }
            }
            else if (btnAccountDetailType.Text == "Update")
            {
                MController.UpdateAccountHead2(AccountDetailTypeId, int.Parse(Session["CompanyId"].ToString()), true, DateTime.Now, Configuration.DistributorId, Constants.AC_DetailTypeId, long.Parse(ddAccountSubType1.SelectedItem.Value.ToString()), txtDetailTypeName.Text, txtADetailTypeCode.Text, DrpAccountCategory.SelectedIndex, Constants.Account_Form_COA);
                GetDetailAccountType();
                GetDetailAccountTypeForHead();
                GetAccountHead();
                ClearAll();
                txtADetailTypeCode.ReadOnly = true;
                txtDetailTypeName.ReadOnly = true;
            }
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterStartupScript(this, typeof(Page), "CatchMsg", "alert('" + ex.Message.ToString() + "');", true);
        }
    }

    #endregion

    #region AccountHead Tab

    /// <summary>
    /// Loads Account SubTypes To SubType Combo
    /// </summary>
    private void GetSubTypeForHead()
    {
        if (ddAccountType3.Items.Count > 0)
        {
            DataTable dt = MController.SelectAccountHead(Constants.AC_SubTypeId, long.Parse(ddAccountType3.SelectedItem.Value.ToString()), DrpAccountCategory.SelectedIndex, 1, Constants.Account_Form_COA);
            clsWebFormUtil.FillDxComboBoxList(ddAccountSubType2, dt, 0, 10, true);

            if (dt.Rows.Count > 0)
            {
                ddAccountSubType2.SelectedIndex = 0;
            }

        }
    }

    /// <summary>
    /// Loads Account DetailTypes To DetailType Combo And AccountHeads To AccountHead Grid
    /// </summary>
    /// <param name="sender">object</param>
    /// <param name="e">GridViewEditEventArgs</param>
    protected void ddAccountSubType2_SelectedIndexChanged(object sender, EventArgs e)
    {
        txtAccountCode.Text = "";
        btnSave.Text = "New";

        GetDetailAccountTypeForHead();
        GetAccountHead();
    }

    /// <summary>
    /// Loads Account DetailTypes To DetailType Combo
    /// </summary>
    private void GetDetailAccountTypeForHead()
    {
        if (ddAccountSubType2.Items.Count > 0)
        {
            DataTable dt = MController.SelectAccountHead(Constants.AC_DetailTypeId, long.Parse(ddAccountSubType2.SelectedItem.Value.ToString()), DrpAccountCategory.SelectedIndex, 1, Constants.Account_Form_COA);
            clsWebFormUtil.FillDxComboBoxList(drpAccountTypeDetail, dt, 0, 10, true);

            if (dt.Rows.Count > 0)
            {
                drpAccountTypeDetail.SelectedIndex = 0;
            }

        }
    }

    /// <summary>
    /// Loads Account Heads To AccountHead Grid
    /// </summary>
    /// <param name="sender">object</param>
    /// <param name="e">GridViewEditEventArgs</param>
    protected void drpAccountTypeDetail_SelectedIndexChanged(object sender, EventArgs e)
    {
        txtAccountCode.Text = "";
        btnSave.Text = "New";
        GetAccountHead();
    }

    /// <summary>
    /// Loads Account Heads To AccountHead Grid
    /// </summary>
    private void GetAccountHead()
    {
        if (drpAccountTypeDetail.Items.Count > 0)
        {
            DataTable dt = MController.SelectAccountHead(Constants.AC_AccountHeadId, long.Parse(drpAccountTypeDetail.SelectedItem.Value.ToString()), DrpAccountCategory.SelectedIndex, 1, Constants.Account_Form_COA);
            GridAccountHead.DataSource = dt;
            GridAccountHead.DataBind();
        }
        else
        {
            GridAccountHead.DataSource = null;
            GridAccountHead.DataBind();
        }
    }

    /// <summary>
    /// Sets Account Head For Edit. This Function Runs When An Existing Account Head Needs To Be Edited
    /// </summary>
    /// <param name="sender">object</param>
    /// <param name="e">GridViewEditEventArgs</param>
    protected void GridAccountHead_RowEditing(object sender, GridViewEditEventArgs e)
    {
        AccountHeadId = long.Parse(GridAccountHead.Rows[e.NewEditIndex].Cells[0].Text);
        txtAccountCode.Text = GridAccountHead.Rows[e.NewEditIndex].Cells[1].Text.Substring(7);
        txtAccountHead.Text = GridAccountHead.Rows[e.NewEditIndex].Cells[2].Text.Replace("amp;", "");
        btnSave.Text = "Update";
    }

    /// <summary>
    /// Deletes Account Head
    /// </summary>
    /// <param name="sender">object</param>
    /// <param name="e">GridViewEditEventArgs</param>
    protected void GridAccountHead_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        DataTable dt = MController.SelectGlTranscton(long.Parse(GridAccountHead.Rows[e.RowIndex].Cells[0].Text));

        if (dt.Rows.Count == 0)
        {
            MController.UpdateAccountHead2(long.Parse(GridAccountHead.Rows[e.RowIndex].Cells[0].Text), int.Parse(Session["CompanyId"].ToString()), false, DateTime.Now, CORNCommon.Classes.Configuration.DistributorId, Constants.AC_AccountHeadId, Constants.LongNullValue, null, null, 0, Constants.Account_Form_COA);
            GetAccountHead();
        }
        else
        {
            ScriptManager.RegisterStartupScript(this, GetType(), "msg", "alert('Transaction exists unable to delete');", true);
        }
    }

    /// <summary>
    /// Saves Or Updates Account Head
    /// </summary>
    /// <param name="sender">object</param>
    /// <param name="e">GridViewEditEventArgs</param>
    protected void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (btnSave.Text == "New")
            {
                btnSave.Text = "Save";
                txtAccountCode.Text = GetAutoCode(Constants.AC_AccountHeadId, int.Parse(drpAccountTypeDetail.SelectedItem.Value.ToString()));
                txtAccountCode.ReadOnly = false;
                txtAccountHead.ReadOnly = false;
                ScriptManager.GetCurrent(Page).SetFocus(txtAccountCode);
            }
            else if (btnSave.Text == "Save")
            {
                MController.InsertAccountHead2(int.Parse(Session["CompanyId"].ToString()), true, DateTime.Now, int.Parse(Session["DISTRIBUTOR_ID"].ToString()), Constants.AC_AccountHeadId, long.Parse(drpAccountTypeDetail.SelectedItem.Value.ToString()), txtAccountHead.Text, txtAccountCode.Text, DrpAccountCategory.SelectedIndex, Constants.Account_Form_COA);
                GetAccountHead();
                ClearAll();
                txtAccountCode.ReadOnly = true;
                txtAccountHead.ReadOnly = true;
            }
            else
            {
                MController.UpdateAccountHead2(AccountHeadId, int.Parse(Session["CompanyId"].ToString()), true, System.DateTime.Now, int.Parse(Session["DISTRIBUTOR_ID"].ToString()), Constants.AC_AccountHeadId, int.Parse(drpAccountTypeDetail.SelectedItem.Value.ToString()), txtAccountHead.Text, txtAccountCode.Text, DrpAccountCategory.SelectedIndex, Constants.Account_Form_COA);
                GetAccountHead();
                ClearAll();
                txtAccountCode.ReadOnly = true;
                txtAccountHead.ReadOnly = true;
            }
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterStartupScript(this, typeof(Page), "CatchMsg", "alert('" + ex.Message.ToString() + "');", true);
        }
    }

    #endregion

    /// <summary>
    /// Gets Code For Account
    /// </summary>
    /// <param name="CodeType">Type</param>
    /// <param name="CValue">Value</param>
    /// <returns>Code as String</returns>
    private string GetAutoCode(int CodeType, long CValue)
    {
        return string.Empty;

        //DataTable dt = MController.SelectAccountHead(CodeType, CValue, DrpAccountCategory.SelectedIndex, 1, Constants.IntNullValue);
        //DataView dv = new DataView(dt);
        //dv.Sort = "ACCOUNT_CODE";
        //dt = dv.ToTable();

        //if (CodeType == Constants.AC_SubTypeId)
        //{
        //    if (dt.Rows.Count > 0)
        //    {
        //        int accountCode = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1]["ACCOUNT_CODE"].ToString().Substring(1)) + 1;

        //        if (accountCode.ToString().Length == 0)
        //        {
        //            return DrpAccountCategory.SelectedItem.Value + "01";
        //        }
        //        else if (accountCode.ToString().Length == 1)
        //        {
        //            return DrpAccountCategory.SelectedItem.Value + "0" + accountCode.ToString();
        //        }
        //        else
        //        {
        //            return DrpAccountCategory.SelectedItem.Value + accountCode.ToString();
        //        }
        //    }
        //    else
        //    {
        //        return DrpAccountCategory.SelectedItem.Value + "01";
        //    }
        //}
        //else if (CodeType == Constants.AC_DetailTypeId)
        //{
        //    string accountCodeStr = ddAccountSubType1.SelectedItem.Text.Split('-')[0];

        //    if (dt.Rows.Count > 0)
        //    {
        //        int accountCode = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1]["ACCOUNT_CODE"].ToString().Substring(1)) + 1;

        //        return DrpAccountCategory.SelectedItem.Value + accountCode.ToString();
        //    }
        //    else
        //    {
        //        return accountCodeStr + "1";
        //    }
        //}
        //else if (CodeType == Constants.AC_AccountHeadId)
        //{
        //    string accountCodeStr = ddAccountSubType2.SelectedItem.Text.Split('-')[0];
        //    string accountDetailCodeStr = drpAccountTypeDetail.SelectedItem.Text.Split('-')[0];

        //    if (dt.Rows.Count > 0)
        //    {
        //        int accountCode = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1]["ACCOUNT_CODE"].ToString().Substring(1)) + 1;

        //        return DrpAccountCategory.SelectedItem.Value + accountCode.ToString();
        //    }
        //    else
        //    {
        //        return accountCodeStr + accountDetailCodeStr.Replace(DrpAccountCategory.SelectedItem.Value.ToString(), "") + "1";
        //    }
        //}
        //else
        //{
        //    if (dt.Rows.Count > 0)
        //    {
        //        int AccountCode = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1]["ACCOUNT_CODE"].ToString().Substring(1)) + 1;

        //        //int AccountCode = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1]["ACCOUNT_CODE"].ToString().Substring(6, 4)) + 1;
        //        if (AccountCode.ToString().Length == 1)
        //        {
        //            return "000" + AccountCode.ToString();
        //        }
        //        else if (AccountCode.ToString().Length == 2)
        //        {
        //            return "00" + AccountCode.ToString();
        //        }
        //        else if (AccountCode.ToString().Length == 3)
        //        {
        //            return "0" + AccountCode.ToString();
        //        }
        //        else
        //        {
        //            return AccountCode.ToString();
        //        }
        //    }
        //    else
        //    {
        //        return "0001";
        //    }
        //}
    }

    /// <summary>
    /// Clears Form Controls
    /// </summary>
    private void ClearAll()
    {
        btnAccountType.Text = "New Account Type";
        btnAccountSubType.Text = "New";
        btnAccountDetailType.Text = "New";
        btnSave.Text = "New";
        txtAtypeName.Text = "";
        txtAtypeCode.Text = "";
        txtASubTypeCode.Text = "";
        txtSubTypeName.Text = "";
        txtADetailTypeCode.Text = "";
        txtDetailTypeName.Text = "";
        txtAccountHead.Text = "";
        txtADetailTypeCode.Text = "";
        txtAccountCode.Text = "";
    }
}
