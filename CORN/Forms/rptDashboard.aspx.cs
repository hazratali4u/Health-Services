using CORNBusinessLayer;
using CORNDataAccessLayer;
using CORNDataAccessLayer.Request;
using CORNDataAccessLayer.Response;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.UI;

public partial class Forms_rptDashboard : System.Web.UI.Page
{
    private void LoadFinancialYear()
    {
        FinancialYearManager manager = new FinancialYearManager();
        FinancialYearResponse response = manager.FinancialYearGetAll();

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
    private void LoadShowGraph()
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
        DataRow dr3 = dt.NewRow();
        DataRow dr4 = dt.NewRow();
        DataRow dr5 = dt.NewRow();
        DataRow dr6 = dt.NewRow();
        DataRow dr7 = dt.NewRow();
        DataRow dr8 = dt.NewRow();

        dr1[0] = 1;
        dr1[1] = "Fund Wise";
        dr2[0] = 2;
        dr2[1] = "Scheme Status Wise";
        dr3[0] = 3;
        dr3[1] = "Sub Sector Wise";
        dr4[0] = 4;
        dr4[1] = "Object Wise";
        dr5[0] = 5;
        dr5[1] = "Function Wise";
        dr6[0] = 6;
        dr6[1] = "ADP Summary";
        dr7[0] = 7;
        dr7[1] = "Sub-Sector Summary";
        dr8[0] = 8;
        dr8[1] = "Constituency Wise";

        dt.Rows.Add(dr1);
        dt.Rows.Add(dr2);
        dt.Rows.Add(dr3);
        dt.Rows.Add(dr4);
        dt.Rows.Add(dr5);
        dt.Rows.Add(dr6);
        dt.Rows.Add(dr7);
        dt.Rows.Add(dr8);

        ddlShowGraph.DataSource = dt;
        ddlShowGraph.ValueField = "Id";

        ddlShowGraph.DataBind();

        if (ddlShowGraph.Items.Count > 0)
        {
            ddlShowGraph.SelectedIndex = 0;
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            LoadFinancialYear();
            LoadDistrict();
            LoadConstituency();
            LoadShowGraph();
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Forms_rptDashboardPageLoad", "$(document).ready(function () { alert(\"" + ex.Message + "\"); });", true);
        }
    }
}