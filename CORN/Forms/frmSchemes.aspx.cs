using CORNBusinessLayer;
using CORNDataAccessLayer;
using CORNDataAccessLayer.Request;
using CORNDataAccessLayer.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;

public partial class Forms_frmSchemes : System.Web.UI.Page
{
    private void LoadFinancialYear()
    {
        FinancialYearManager manager = new FinancialYearManager();
        FinancialYearResponse response = manager.FinancialYearGetAll();
        //FinancialYear objFinancialYear = new FinancialYear();

        //objFinancialYear.Id = 0;
        //objFinancialYear.YearName = "All";

        //response.FinancialYearList.Insert(0, objFinancialYear);

        ddlFY.DataSource = response.FinancialYearList;
        ddlFY.ValueField = "Id";

        ddlFY.DataBind();

        if (ddlFY.Items.Count > 0)
        {
            int selIndex = 0;
            var objFY = response.FinancialYearList.FirstOrDefault(p => (p.EndDate.Year == DateTime.Now.Year && DateTime.Now.Month <= 6) ||
            (p.StartDate.Year == DateTime.Now.Year && DateTime.Now.Month > 6));

            if (objFY != null)
            {
                selIndex = response.FinancialYearList.IndexOf(objFY);
            }

            ddlFY.SelectedIndex = selIndex;
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            int userRoleId = Convert.ToInt32(Session["RoleID"]);
            string allowEdit = "true";

            if (userRoleId != 1)
            {
                ddlSchemeCategory.Visible = false;
                btnStatus.Visible = false;
            }

            if (userRoleId != 1 && userRoleId != 2)
            {
                btnActive.Visible = false;
            }

            if (userRoleId != 1 && userRoleId != 2 && userRoleId != 3)
            {
                allowEdit = "false";
            }

            if (userRoleId == 1)
            {
                btnPromoteSchemes.Visible = true;
            }
            else
            {
                btnPromoteSchemes.Visible = false;
            }

            this.LoadFinancialYear();

            SchemeManager manager = new SchemeManager();
            SchemeRequest request = new SchemeRequest();

            request.SchemeIds = string.Empty;
            request.FinancialYearId = Convert.ToInt64(ddlFY.SelectedItem.Value);
            request.UserId = UserCommonInfo.LoggedInUserId;

            SchemeResponse response = manager.SchemeGetAll(request);
            List<Scheme> lstScheme = response.SchemeList;

            if (!string.IsNullOrEmpty(Request.QueryString["mode"]))
            {
                if (Request.QueryString["mode"] == "MPR")
                {
                    lstScheme = (from p in lstScheme
                                 where p.dtmStartDate <= DateTime.Now.Date
                                 select p).ToList();

                    btnExport.Visible = false;
                }
                else if (Request.QueryString["mode"] == "ADP")
                {
                    lstScheme = (from p in lstScheme
                                 where p.IsActive && (p.ThrowForward > 1 || p.intCategoryID == 1)
                                 select p).ToList();

                    btnExport.Visible = true;
                }
            }

            this.Page.ClientScript.RegisterStartupScript(this.GetType(),
                    "FormsfrmSchemePageLoad",
                    "RC.SchemeListing.SchemeList = " + JsonConvert.SerializeObject(lstScheme) + "; " +
                    "RC.SchemeListing.AllowEdit = " + allowEdit + "; ",
                    true);
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "FormsfrmSchemePageLoad", "$(document).ready(function () { alert(\"" + ex.Message + "\"); });", true);
        }
    }
}