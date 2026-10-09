using System;
using System.Web.UI;
using CORNBusinessLayer;
using CORNDataAccessLayer.Response;
using Newtonsoft.Json;

public partial class Forms_frmGeoHierarchy : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            GeoHierarchyManager manager = new GeoHierarchyManager();
            GeoHierarchyResponse response = manager.GeoHierarchyGetAll();

            this.Page.ClientScript.RegisterStartupScript(this.GetType(),
                "FormsfrmSchemeGeoHierarchyPageLoad",
                "RC.GeoHierarchyListing.GeoHierarchyList = " + JsonConvert.SerializeObject(response.GeoHierarchyList) + "; ",
                true);
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "FormsfrmGeoHierarchyPageLoad", "$(document).ready(function () { alert(\"" + ex.Message + "\"); });", true);
        }
    }
}