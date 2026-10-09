using CORNBusinessLayer;
using CORNBusinessLayer.Classes;
using CORNCommon.Classes;
using CORNDataAccessLayer;
using CORNDataAccessLayer.Request;
using CORNDataAccessLayer.Response;
using DevExpress.Web;
using Newtonsoft.Json;
using System;
using System.Data;
using System.Web;
using System.Web.UI;

public partial class Forms_frmSchemeDocumentAdd : System.Web.UI.Page
{
    private void LoadScheme()
    {
        HealthSchemeController HealthCtl = new HealthSchemeController();
        DataTable dt = new DataTable();

        dt = HealthCtl.GetScheme(Constants.IntNullValue, 6, Constants.LongNullValue, Convert.ToInt32(Session["UserID"]));
        ddlScheme.DataSource = dt;
        ddlScheme.ValueField = "lngSchemeCode";

        ddlScheme.DataBind();

        if (ddlScheme.Items.Count > 0)
        {
            ddlScheme.SelectedIndex = 0;
        }
    }
    private void SetScheme(long schemeId)
    {
        foreach (ListEditItem item in ddlScheme.Items)
        {
            if (Convert.ToInt64(item.Value) == schemeId)
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
            txtDocumentDate.Attributes.Add("readonly", "readonly");
            UserCommonInfo.ResetDocumentInfoInSession();

            if (!Page.IsPostBack)
            {
                this.LoadScheme();

                SchemeDocumentManager manager = new SchemeDocumentManager();
                SchemeDocument objSchemeDocument = null;

                if (!string.IsNullOrEmpty(Request.QueryString["Id"]))
                {
                    SchemeDocumentRequest request = new SchemeDocumentRequest();

                    request.Id = Convert.ToInt64(Request.QueryString["Id"]);

                    SchemeDocumentResponse response = manager.DocumentGetId(request);

                    objSchemeDocument = response.SchemeDocumentObject;

                    SetScheme(objSchemeDocument.SchemeId);
                }

                this.Page.ClientScript.RegisterStartupScript(this.GetType(),
                        "FormsfrmSchemeDocumentAddPageLoad",
                        "RC.ManageSchemeDocument.SchemeDocumentObject = " + JsonConvert.SerializeObject(objSchemeDocument) + "; ",
                        true);
            }
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "FormsfrmSchemeDocumentAddPageLoad", "$(document).ready(function () { alert(\"" + ex.Message + "\"); });", true);
        }
    }
}