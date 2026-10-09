using CORNBusinessLayer;
using CORNBusinessLayer.Classes;
using CORNCommon.Classes;
using CORNDataAccessLayer;
using CORNDataAccessLayer.Request;
using CORNDataAccessLayer.Response;
using Newtonsoft.Json;
using System;
using System.Data;
using System.Web;
using System.Web.UI;

public partial class Forms_frmGroupAdd : System.Web.UI.Page
{
    private void LoadAccountDetail()
    {
        AccountHeadController mAccountController = new AccountHeadController();
        DataTable dtHead = mAccountController.SelectAccountHead(Constants.AC_AccountHeadId, Constants.LongNullValue, 1, Constants.Account_Form_COA);

        ddlCOA.DataSource = dtHead;
        ddlCOA.ValueField = "ACCOUNT_HEAD_ID";

        ddlCOA.DataBind();

        if (ddlCOA.Items.Count > 0)
        {
            ddlCOA.SelectedIndex = 0;
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

            if (!Page.IsPostBack)
            {
                long groupId = 0;

                long.TryParse(Request.QueryString["Id"], out groupId);

                GroupManager manager = new GroupManager();
                Group objGroup = null;

                if (groupId > 0)
                {
                    GroupRequest request = new GroupRequest();

                    request.Id = groupId;

                    GroupResponse response = manager.GroupGetId(request);

                    objGroup = response.GroupObject;
                }

                this.LoadAccountDetail();

                this.Page.ClientScript.RegisterStartupScript(this.GetType(),
                        "FormsfrmGroupAddPageLoad",
                        "RC.ManageGroup.GroupObject = " + JsonConvert.SerializeObject(objGroup) + "; ",
                        true);
            }
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "FormsfrmGroupAddPageLoad", "$(document).ready(function () { alert(\"" + ex.Message + "\"); });", true);
        }
    }
}