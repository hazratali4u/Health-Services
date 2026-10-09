using CORNBusinessLayer;
using CORNDataAccessLayer;
using CORNDataAccessLayer.Request;
using CORNDataAccessLayer.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

public partial class Forms_frmProgressPRR : System.Web.UI.Page
{
    private void LoadDistrict()
    {
        GeoHierarchyManager manager = new GeoHierarchyManager();
        GeoHierarchyRequest request = new GeoHierarchyRequest();

        request.TypeId = 52;

        GeoHierarchyResponse response = manager.GeoHierarchyGetTypeId(request);
        GeoHierarchy objGeoHierarchy = new GeoHierarchy();

        objGeoHierarchy.Id = 0;
        objGeoHierarchy.Name = "All";
        objGeoHierarchy.Division = "All";
        objGeoHierarchy.Region = "All";

        response.GeoHierarchyList.Insert(0, objGeoHierarchy);

        ddlDistrict.DataSource = response.GeoHierarchyList;
        ddlDistrict.ValueField = "Id";

        ddlDistrict.DataBind();

        if (ddlDistrict.Items.Count > 0)
        {
            ddlDistrict.SelectedIndex = 0;
        }
    }
    private void LoadConstituency()
    {
        List<GeoHierarchy> lstGeoHierarchy = new List<GeoHierarchy>();
        GeoHierarchy objGeoHierarchy = new GeoHierarchy();

        objGeoHierarchy.Id = 0;
        objGeoHierarchy.Code = "All";
        objGeoHierarchy.Name = "All";

        lstGeoHierarchy.Insert(0, objGeoHierarchy);

        ddlConstituency.DataSource = lstGeoHierarchy;
        ddlConstituency.ValueField = "Id";

        ddlConstituency.DataBind();

        if (ddlConstituency.Items.Count > 0)
        {
            ddlConstituency.SelectedIndex = 0;
        }
    }
    private void LoadCatalogueData()
    {
        int year = 2010;

        while (year <= DateTime.Now.Year)
        {
            ddlYear.Items.Add(new DevExpress.Web.ListEditItem((year.ToString() + "-" + (year + 1).ToString()), year));
            year++;
        }

        if (ddlYear.Items.Count > 0)
        {
            ddlYear.SelectedIndex = (ddlYear.Items.Count - 1);
        }

        int currentMonth = DateTime.Now.Month;

        ddlMonth.SelectedIndex = (currentMonth - 1);
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
                this.LoadDistrict();
                this.LoadConstituency();
                this.LoadCatalogueData();
            }
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Forms_frmProgressPRRPageLoad", "$(document).ready(function () { alert(\"" + ex.Message + "\"); });", true);
        }
    }
}