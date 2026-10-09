using CORNBusinessLayer;
using CORNBusinessLayer.Classes;
using CORNCommon.Classes;
using CORNDataAccessLayer;
using CORNDataAccessLayer.Request;
using CORNDataAccessLayer.Response;
using DevExpress.Web;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;

public partial class Forms_frmPC1SchemeAdd : System.Web.UI.Page
{
    List<Distributor> lstDistributor = new List<Distributor>();
    List<Group> lstGroup = new List<Group>();

    private void LoadInstitute()
    {
        DistributorController DController = new DistributorController();
        DataTable dtInstituteDetail = DController.GetInstituteDetail(Constants.IntNullValue, int.Parse(Session["UserId"].ToString()), 1);
        DataRow dr = dtInstituteDetail.NewRow();

        dr["DISTRIBUTOR_ID"] = 0;
        dr["DISTRIBUTOR_NAME"] = "None";
        dr["District"] = "None";

        dtInstituteDetail.Rows.InsertAt(dr, 0);

        ddlInstitute.DataSource = dtInstituteDetail;
        ddlInstitute.ValueField = "DISTRIBUTOR_ID";
        lstDistributor = dtInstituteDetail.ToList<Distributor>();

        ddlInstitute.DataBind();

        if (ddlInstitute.Items.Count > 0)
        {
            ddlInstitute.SelectedIndex = 0;
        }
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

        dr1[0] = 1;
        dr1[1] = "PC1 Draft";
        dr2[0] = 2;
        dr2[1] = "PC1 Revised";

        if (Convert.ToInt64(Request.QueryString["categoryId"]) == 1)
        {
            dt.Rows.Add(dr1);
        }
        else if (Convert.ToInt64(Request.QueryString["categoryId"]) == 2)
        {
            dt.Rows.Add(dr2);
        }

        DataRow dr = dt.NewRow();

        dr["Id"] = 0;
        dr["Title"] = "None";

        dt.Rows.InsertAt(dr, 0);

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
        DistributorRouteController RouteCtl = new DistributorRouteController();
        DataTable dt = RouteCtl.GetSubSector(Constants.IntNullValue, 2);
        DataRow dr = dt.NewRow();

        dr["SubSector_ID"] = 0;
        dr["strCode"] = "None";
        dr["strName"] = "None";

        dt.Rows.InsertAt(dr, 0);

        ddlSubSector.DataSource = dt;
        ddlSubSector.ValueField = "SubSector_ID";

        ddlSubSector.DataBind();

        if (ddlSubSector.Items.Count > 0)
        {
            ddlSubSector.SelectedIndex = 0;
        }
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
    }
    private void LoadSponsoring()
    {
        SponsoringManager manager = new SponsoringManager();
        SponsoringResponse response = manager.SponsoringGetAll();

        response.SponsoringList.Insert(0, new Sponsoring());

        ddlSponsoring.DataSource = response.SponsoringList;
        ddlSponsoring.ValueField = "Id";

        ddlSponsoring.DataBind();

        if (ddlSponsoring.Items.Count > 0)
        {
            ddlSponsoring.SelectedIndex = 0;
        }
    }
    private void LoadExecution()
    {
        ExecutionManager manager = new ExecutionManager();
        ExecutionResponse response = manager.ExecutionGetAll();

        response.ExecutionList.Insert(0, new Execution());

        ddlExecution.DataSource = response.ExecutionList;
        ddlExecution.ValueField = "Id";

        ddlExecution.DataBind();

        if (ddlExecution.Items.Count > 0)
        {
            ddlExecution.SelectedIndex = 0;
        }
    }
    private void LoadOperationMaintenance()
    {
        OperationMaintenanceManager manager = new OperationMaintenanceManager();
        OperationMaintenanceResponse response = manager.OperationMaintenanceGetAll();

        response.OperationMaintenanceList.Insert(0, new OperationMaintenance());

        ddlOperationMaintenance.DataSource = response.OperationMaintenanceList;
        ddlOperationMaintenance.ValueField = "Id";

        ddlOperationMaintenance.DataBind();

        if (ddlOperationMaintenance.Items.Count > 0)
        {
            ddlOperationMaintenance.SelectedIndex = 0;
        }
    }
    private void LoadConcernedFederalMinistry()
    {
        ConcernedFederalMinistryManager manager = new ConcernedFederalMinistryManager();
        ConcernedFederalMinistryResponse response = manager.ConcernedFederalMinistryGetAll();

        response.ConcernedFederalMinistryList.Insert(0, new ConcernedFederalMinistry());

        ddlConcernedFederalMinistry.DataSource = response.ConcernedFederalMinistryList;
        ddlConcernedFederalMinistry.ValueField = "Id";

        ddlConcernedFederalMinistry.DataBind();

        if (ddlConcernedFederalMinistry.Items.Count > 0)
        {
            ddlConcernedFederalMinistry.SelectedIndex = 0;
        }
    }
    private void LoadGroup()
    {
        GroupManager manager = new GroupManager();
        GroupResponse response = manager.GroupGetAllDetail();

        lstGroup = response.GroupList;
        ddlCCEGroup.DataSource = lstGroup;
        ddlCCEGroup.DataValueField = "Id";
        ddlCCEGroup.DataTextField = "Title";

        ddlCCEGroup.DataBind();

        if (ddlCCEGroup.Items.Count > 0)
        {
            ddlCCEGroup.SelectedIndex = 0;
        }

        ddlAOCGroup.DataSource = lstGroup;
        ddlAOCGroup.DataValueField = "Id";
        ddlAOCGroup.DataTextField = "Title";

        ddlAOCGroup.DataBind();

        if (ddlAOCGroup.Items.Count > 0)
        {
            ddlAOCGroup.SelectedIndex = 0;
        }
    }
    private void SetInstitute(long instituteId)
    {
        foreach (ListEditItem item in ddlInstitute.Items)
        {
            if (Convert.ToInt64(item.Value) == instituteId)
            {
                item.Selected = true;
            }
            else
            {
                item.Selected = false;
            }
        }
    }
    private void SetSchemeCategory(long categoryId)
    {
        foreach (ListEditItem item in ddlCategory.Items)
        {
            if (Convert.ToInt64(item.Value) == categoryId)
            {
                item.Selected = true;
            }
            else
            {
                item.Selected = false;
            }
        }
    }
    private void SetSubSector(long subSectorId)
    {
        foreach (ListEditItem item in ddlSubSector.Items)
        {
            if (Convert.ToInt64(item.Value) == subSectorId)
            {
                item.Selected = true;
            }
            else
            {
                item.Selected = false;
            }
        }
    }
    private void SetAccountDetail(long fcAccountHeadId, long rfcAccountHeadId)
    {
        foreach (ListEditItem item in ddlCOA.Items)
        {
            if (Convert.ToInt64(item.Value) == fcAccountHeadId)
            {
                item.Selected = true;
            }
            else
            {
                item.Selected = false;
            }
        }

        foreach (ListEditItem item in ddlRCOA.Items)
        {
            if (Convert.ToInt64(item.Value) == rfcAccountHeadId)
            {
                item.Selected = true;
            }
            else
            {
                item.Selected = false;
            }
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetExpires(DateTime.Now.AddSeconds(-1));
            Response.Cache.SetNoStore();
            Response.AppendHeader("pragma", "no-cache");
            txtStartDate.Attributes.Add("readonly", "readonly");
            txtEndDate.Attributes.Add("readonly", "readonly");
            txtSchemeDate.Attributes.Add("readonly", "readonly");
            UserCommonInfo.ResetPC1SchemeInfoInSession();

            if (!Page.IsPostBack)
            {
                long schemeId = 0;

                long.TryParse(Request.QueryString["Id"], out schemeId);

                PC1SchemeManager manager = new PC1SchemeManager();
                SchemeRequest request = new SchemeRequest();
                Scheme objScheme = null;

                if (schemeId > 0)
                {
                    request.Id = schemeId;

                    SchemeResponse response = manager.SchemeGetId(request);

                    objScheme = response.SchemeObject;
                    pnlPC1SchemeDetail.GroupingText = objScheme.strSchemeName;
                }

                this.LoadInstitute();
                this.LoadSchemeCategory();
                this.LoadSubSector();
                this.LoadAccountDetail();
                this.LoadSponsoring();
                this.LoadExecution();
                this.LoadOperationMaintenance();
                this.LoadConcernedFederalMinistry();
                this.LoadGroup();

                if (schemeId > 0)
                {
                    SetInstitute(objScheme.intInstituteID);
                    SetSchemeCategory(objScheme.intCategoryID);
                    SetSchemeCategory(objScheme.intCategoryID);
                    SetSubSector(objScheme.intSubSectorID);
                    SetAccountDetail(objScheme.intFCAccountHeadID, objScheme.intRFCAccountHeadID);
                }

                this.Page.ClientScript.RegisterStartupScript(this.GetType(),
                        "FormsfrmPC1SchemeAddPageLoad",
                        "RC.ManageScheme.SchemeObject = " + JsonConvert.SerializeObject(objScheme) + "; " +
                        "RC.ManageScheme.DistributorList = " + JsonConvert.SerializeObject(lstDistributor) + "; " +
                        "RC.ManageScheme.GroupList = " + JsonConvert.SerializeObject(lstGroup) + "; ",
                        true);
            }
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "FormsfrmPC1SchemeAddPageLoad", "$(document).ready(function () { alert(\"" + ex.Message + "\"); });", true);
        }
    }
}