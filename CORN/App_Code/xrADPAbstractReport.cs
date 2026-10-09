using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

/// <summary>
/// Summary description for xrADPAbstractReport
/// </summary>
public class xrADPAbstractReport : DevExpress.XtraReports.UI.XtraReport
{
    private DevExpress.XtraReports.UI.DetailBand Detail;
    private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
    private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
    private System.Windows.Forms.BindingSource bindingSource1;
    private XRLabel xrLabel1;
    private PageFooterBand PageFooter;
    private XRLabel xrLabel3;
    private DevExpress.XtraReports.Parameters.Parameter prYear;
    private DevExpress.XtraReports.Parameters.Parameter prCYear;
    private DevExpress.XtraReports.Parameters.Parameter prPYear;
    private XRLabel xrLabel2;
    private XRLabel xrLabel4;
    private XRLabel xrLabel9;
    private XRLabel xrLabel10;
    private XRLabel xrLabel7;
    private XRLabel xrLabel8;
    private XRLabel xrLabel5;
    private XRLabel xrLabel6;
    private XRLabel xrLabel19;
    private XRLabel xrLabel20;
    private XRLabel xrLabel17;
    private XRLabel xrLabel18;
    private XRLabel xrLabel15;
    private XRLabel xrLabel16;
    private XRLabel xrLabel13;
    private XRLabel xrLabel14;
    private XRLabel xrLabel11;
    private XRLabel xrLabel12;
    private XRLabel xrLabel32;
    private XRLabel xrLabel31;
    private XRLabel xrLabel30;
    private XRPanel xrPanel1;
    private XRLabel xrLabel29;
    private XRLabel xrLabel28;
    private XRLabel xrLabel27;
    private XRLabel xrLabel26;
    private XRLabel xrLabel25;
    private XRLabel xrLabel24;
    private XRLabel xrLabel23;
    private XRLabel xrLabel22;
    private XRLabel xrLabel21;
    private CalculatedField ExpenseAllocationPercentage;
    private CalculatedField ExpenseReleasePercentage;
    private XRPanel xrPanel3;
    private XRLabel xrLabel53;
    private XRLabel xrLabel52;
    private XRLabel xrLabel51;
    private XRLabel xrLabel50;
    private XRLabel xrLabel49;
    private XRLabel xrLabel48;
    private XRLabel xrLabel47;
    private XRPanel xrPanel2;
    private XRLabel xrLabel46;
    private XRLabel xrLabel45;
    private XRLabel xrLabel44;
    private XRLabel xrLabel43;
    private XRLabel xrLabel42;
    private XRLabel xrLabel41;
    private XRLabel xrLabel40;
    private XRLabel xrLabel39;
    private XRLabel xrLabel38;
    private XRLabel xrLabel37;
    private XRLabel xrLabel36;
    private XRLabel xrLabel35;
    private XRLabel xrLabel34;
    private XRLabel xrLabel33;
    private CalculatedField headApprovedPY;
    private CalculatedField headUnapprovedY;
    private CalculatedField headApprovedY;

    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public xrADPAbstractReport()
    {
        InitializeComponent();
        //
        // TODO: Add constructor logic here
        //
    }

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        string resourceFileName = "xrADPAbstractReport.resx";
        this.components = new System.ComponentModel.Container();
        this.Detail = new DevExpress.XtraReports.UI.DetailBand();
        this.xrPanel3 = new DevExpress.XtraReports.UI.XRPanel();
        this.xrLabel53 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel52 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel51 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel50 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel49 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel48 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel47 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrPanel2 = new DevExpress.XtraReports.UI.XRPanel();
        this.xrLabel46 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel45 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel44 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel43 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel32 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel31 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel30 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrPanel1 = new DevExpress.XtraReports.UI.XRPanel();
        this.xrLabel42 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel41 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel40 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel39 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel38 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel37 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel36 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel35 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel34 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel33 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel29 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel28 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel27 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel26 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel25 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel24 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel23 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel22 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel21 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel20 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
        this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
        this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
        this.prYear = new DevExpress.XtraReports.Parameters.Parameter();
        this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
        this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
        this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
        this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
        this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
        this.prCYear = new DevExpress.XtraReports.Parameters.Parameter();
        this.prPYear = new DevExpress.XtraReports.Parameters.Parameter();
        this.ExpenseAllocationPercentage = new DevExpress.XtraReports.UI.CalculatedField();
        this.ExpenseReleasePercentage = new DevExpress.XtraReports.UI.CalculatedField();
        this.headApprovedPY = new DevExpress.XtraReports.UI.CalculatedField();
        this.headUnapprovedY = new DevExpress.XtraReports.UI.CalculatedField();
        this.headApprovedY = new DevExpress.XtraReports.UI.CalculatedField();
        ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
        // 
        // Detail
        // 
        this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPanel3,
            this.xrPanel2,
            this.xrLabel32,
            this.xrLabel31,
            this.xrLabel30,
            this.xrPanel1,
            this.xrLabel19,
            this.xrLabel20,
            this.xrLabel17,
            this.xrLabel18,
            this.xrLabel15,
            this.xrLabel16,
            this.xrLabel13,
            this.xrLabel14,
            this.xrLabel11,
            this.xrLabel12,
            this.xrLabel9,
            this.xrLabel10,
            this.xrLabel7,
            this.xrLabel8,
            this.xrLabel5,
            this.xrLabel6});
        this.Detail.Dpi = 100F;
        this.Detail.HeightF = 660.4999F;
        this.Detail.Name = "Detail";
        this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
        this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        // 
        // xrPanel3
        // 
        this.xrPanel3.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrPanel3.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel53,
            this.xrLabel52,
            this.xrLabel51,
            this.xrLabel50,
            this.xrLabel49,
            this.xrLabel48,
            this.xrLabel47});
        this.xrPanel3.Dpi = 100F;
        this.xrPanel3.LocationFloat = new DevExpress.Utils.PointFloat(1.5F, 610.4999F);
        this.xrPanel3.Name = "xrPanel3";
        this.xrPanel3.SizeF = new System.Drawing.SizeF(901.5F, 50F);
        this.xrPanel3.StylePriority.UseBorders = false;
        // 
        // xrLabel53
        // 
        this.xrLabel53.Borders = DevExpress.XtraPrinting.BorderSide.None;
        this.xrLabel53.Dpi = 100F;
        this.xrLabel53.Font = new System.Drawing.Font("Arial", 9.75F);
        this.xrLabel53.LocationFloat = new DevExpress.Utils.PointFloat(797.5417F, 2.000015F);
        this.xrLabel53.Name = "xrLabel53";
        this.xrLabel53.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
        this.xrLabel53.SizeF = new System.Drawing.SizeF(101.5831F, 22.99998F);
        this.xrLabel53.StylePriority.UseBorders = false;
        this.xrLabel53.StylePriority.UseFont = false;
        this.xrLabel53.StylePriority.UsePadding = false;
        this.xrLabel53.StylePriority.UseTextAlignment = false;
        this.xrLabel53.Text = "0";
        this.xrLabel53.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        // 
        // xrLabel52
        // 
        this.xrLabel52.Borders = DevExpress.XtraPrinting.BorderSide.None;
        this.xrLabel52.Dpi = 100F;
        this.xrLabel52.Font = new System.Drawing.Font("Arial", 9.75F);
        this.xrLabel52.LocationFloat = new DevExpress.Utils.PointFloat(648.5F, 2.000015F);
        this.xrLabel52.Name = "xrLabel52";
        this.xrLabel52.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
        this.xrLabel52.SizeF = new System.Drawing.SizeF(101.5831F, 22.99998F);
        this.xrLabel52.StylePriority.UseBorders = false;
        this.xrLabel52.StylePriority.UseFont = false;
        this.xrLabel52.StylePriority.UsePadding = false;
        this.xrLabel52.StylePriority.UseTextAlignment = false;
        this.xrLabel52.Text = "0";
        this.xrLabel52.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        // 
        // xrLabel51
        // 
        this.xrLabel51.Borders = DevExpress.XtraPrinting.BorderSide.None;
        this.xrLabel51.Dpi = 100F;
        this.xrLabel51.Font = new System.Drawing.Font("Arial", 9.75F);
        this.xrLabel51.LocationFloat = new DevExpress.Utils.PointFloat(497.4583F, 2.000015F);
        this.xrLabel51.Name = "xrLabel51";
        this.xrLabel51.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
        this.xrLabel51.SizeF = new System.Drawing.SizeF(101.5831F, 22.99998F);
        this.xrLabel51.StylePriority.UseBorders = false;
        this.xrLabel51.StylePriority.UseFont = false;
        this.xrLabel51.StylePriority.UsePadding = false;
        this.xrLabel51.StylePriority.UseTextAlignment = false;
        this.xrLabel51.Text = "0";
        this.xrLabel51.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        // 
        // xrLabel50
        // 
        this.xrLabel50.Borders = DevExpress.XtraPrinting.BorderSide.None;
        this.xrLabel50.Dpi = 100F;
        this.xrLabel50.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
        this.xrLabel50.LocationFloat = new DevExpress.Utils.PointFloat(2.000002F, 24.99998F);
        this.xrLabel50.Name = "xrLabel50";
        this.xrLabel50.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
        this.xrLabel50.SizeF = new System.Drawing.SizeF(206.9166F, 23.00002F);
        this.xrLabel50.StylePriority.UseBorders = false;
        this.xrLabel50.StylePriority.UseFont = false;
        this.xrLabel50.StylePriority.UsePadding = false;
        this.xrLabel50.Text = "Schemes";
        // 
        // xrLabel49
        // 
        this.xrLabel49.Borders = DevExpress.XtraPrinting.BorderSide.None;
        this.xrLabel49.Dpi = 100F;
        this.xrLabel49.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
        this.xrLabel49.LocationFloat = new DevExpress.Utils.PointFloat(1.50001F, 1.999982F);
        this.xrLabel49.Name = "xrLabel49";
        this.xrLabel49.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
        this.xrLabel49.SizeF = new System.Drawing.SizeF(206.9166F, 23.00002F);
        this.xrLabel49.StylePriority.UseBorders = false;
        this.xrLabel49.StylePriority.UseFont = false;
        this.xrLabel49.StylePriority.UsePadding = false;
        this.xrLabel49.Text = "Status of Due for Completion ";
        // 
        // xrLabel48
        // 
        this.xrLabel48.Borders = DevExpress.XtraPrinting.BorderSide.None;
        this.xrLabel48.Dpi = 100F;
        this.xrLabel48.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
        this.xrLabel48.LocationFloat = new DevExpress.Utils.PointFloat(224F, 25F);
        this.xrLabel48.Name = "xrLabel48";
        this.xrLabel48.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
        this.xrLabel48.SizeF = new System.Drawing.SizeF(273.4583F, 22.99999F);
        this.xrLabel48.StylePriority.UseBorders = false;
        this.xrLabel48.StylePriority.UseFont = false;
        this.xrLabel48.StylePriority.UsePadding = false;
        this.xrLabel48.Text = "Completed";
        // 
        // xrLabel47
        // 
        this.xrLabel47.Borders = DevExpress.XtraPrinting.BorderSide.None;
        this.xrLabel47.Dpi = 100F;
        this.xrLabel47.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
        this.xrLabel47.LocationFloat = new DevExpress.Utils.PointFloat(223F, 2F);
        this.xrLabel47.Name = "xrLabel47";
        this.xrLabel47.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
        this.xrLabel47.SizeF = new System.Drawing.SizeF(273.4583F, 22.99999F);
        this.xrLabel47.StylePriority.UseBorders = false;
        this.xrLabel47.StylePriority.UseFont = false;
        this.xrLabel47.StylePriority.UsePadding = false;
        this.xrLabel47.Text = "Target in ADP";
        // 
        // xrPanel2
        // 
        this.xrPanel2.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrPanel2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel46,
            this.xrLabel45,
            this.xrLabel44,
            this.xrLabel43});
        this.xrPanel2.Dpi = 100F;
        this.xrPanel2.LocationFloat = new DevExpress.Utils.PointFloat(1.499987F, 512.5F);
        this.xrPanel2.Name = "xrPanel2";
        this.xrPanel2.SizeF = new System.Drawing.SizeF(901.5F, 98F);
        this.xrPanel2.StylePriority.UseBorders = false;
        // 
        // xrLabel46
        // 
        this.xrLabel46.Borders = DevExpress.XtraPrinting.BorderSide.None;
        this.xrLabel46.Dpi = 100F;
        this.xrLabel46.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
        this.xrLabel46.LocationFloat = new DevExpress.Utils.PointFloat(223.5F, 73.95834F);
        this.xrLabel46.Name = "xrLabel46";
        this.xrLabel46.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
        this.xrLabel46.SizeF = new System.Drawing.SizeF(273.4583F, 22.99999F);
        this.xrLabel46.StylePriority.UseBorders = false;
        this.xrLabel46.StylePriority.UseFont = false;
        this.xrLabel46.StylePriority.UsePadding = false;
        this.xrLabel46.Text = "Schemes Dropped";
        // 
        // xrLabel45
        // 
        this.xrLabel45.Borders = DevExpress.XtraPrinting.BorderSide.None;
        this.xrLabel45.Dpi = 100F;
        this.xrLabel45.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
        this.xrLabel45.LocationFloat = new DevExpress.Utils.PointFloat(223.5F, 38F);
        this.xrLabel45.Name = "xrLabel45";
        this.xrLabel45.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
        this.xrLabel45.SizeF = new System.Drawing.SizeF(273.4583F, 22.99999F);
        this.xrLabel45.StylePriority.UseBorders = false;
        this.xrLabel45.StylePriority.UseFont = false;
        this.xrLabel45.StylePriority.UsePadding = false;
        this.xrLabel45.Text = "Schemes Deffered by PDWP";
        // 
        // xrLabel44
        // 
        this.xrLabel44.Borders = DevExpress.XtraPrinting.BorderSide.None;
        this.xrLabel44.Dpi = 100F;
        this.xrLabel44.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
        this.xrLabel44.LocationFloat = new DevExpress.Utils.PointFloat(223.5F, 1F);
        this.xrLabel44.Name = "xrLabel44";
        this.xrLabel44.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
        this.xrLabel44.SizeF = new System.Drawing.SizeF(273.4583F, 22.99999F);
        this.xrLabel44.StylePriority.UseBorders = false;
        this.xrLabel44.StylePriority.UseFont = false;
        this.xrLabel44.StylePriority.UsePadding = false;
        this.xrLabel44.Text = "Schemes for which PC-11 approved";
        // 
        // xrLabel43
        // 
        this.xrLabel43.Borders = DevExpress.XtraPrinting.BorderSide.None;
        this.xrLabel43.Dpi = 100F;
        this.xrLabel43.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
        this.xrLabel43.LocationFloat = new DevExpress.Utils.PointFloat(1.500018F, 37.99998F);
        this.xrLabel43.Name = "xrLabel43";
        this.xrLabel43.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
        this.xrLabel43.SizeF = new System.Drawing.SizeF(206.9166F, 23.00002F);
        this.xrLabel43.StylePriority.UseBorders = false;
        this.xrLabel43.StylePriority.UseFont = false;
        this.xrLabel43.StylePriority.UsePadding = false;
        this.xrLabel43.Text = "Status of Unapproved Schemes";
        // 
        // xrLabel32
        // 
        this.xrLabel32.Dpi = 100F;
        this.xrLabel32.Font = new System.Drawing.Font("Arial", 11.75F, System.Drawing.FontStyle.Bold);
        this.xrLabel32.LocationFloat = new DevExpress.Utils.PointFloat(799.5417F, 310F);
        this.xrLabel32.Name = "xrLabel32";
        this.xrLabel32.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
        this.xrLabel32.SizeF = new System.Drawing.SizeF(102.0832F, 23F);
        this.xrLabel32.StylePriority.UseFont = false;
        this.xrLabel32.StylePriority.UsePadding = false;
        this.xrLabel32.StylePriority.UseTextAlignment = false;
        this.xrLabel32.Text = "New";
        this.xrLabel32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        // 
        // xrLabel31
        // 
        this.xrLabel31.Dpi = 100F;
        this.xrLabel31.Font = new System.Drawing.Font("Arial", 11.75F, System.Drawing.FontStyle.Bold);
        this.xrLabel31.LocationFloat = new DevExpress.Utils.PointFloat(650F, 310F);
        this.xrLabel31.Name = "xrLabel31";
        this.xrLabel31.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
        this.xrLabel31.SizeF = new System.Drawing.SizeF(102.0832F, 23F);
        this.xrLabel31.StylePriority.UseFont = false;
        this.xrLabel31.StylePriority.UsePadding = false;
        this.xrLabel31.StylePriority.UseTextAlignment = false;
        this.xrLabel31.Text = "Ongoing";
        this.xrLabel31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        // 
        // xrLabel30
        // 
        this.xrLabel30.Dpi = 100F;
        this.xrLabel30.Font = new System.Drawing.Font("Arial", 11.75F, System.Drawing.FontStyle.Bold);
        this.xrLabel30.LocationFloat = new DevExpress.Utils.PointFloat(498.9583F, 310F);
        this.xrLabel30.Name = "xrLabel30";
        this.xrLabel30.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
        this.xrLabel30.SizeF = new System.Drawing.SizeF(102.0832F, 23F);
        this.xrLabel30.StylePriority.UseFont = false;
        this.xrLabel30.StylePriority.UsePadding = false;
        this.xrLabel30.StylePriority.UseTextAlignment = false;
        this.xrLabel30.Text = "Total";
        this.xrLabel30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        // 
        // xrPanel1
        // 
        this.xrPanel1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrPanel1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel42,
            this.xrLabel41,
            this.xrLabel40,
            this.xrLabel39,
            this.xrLabel38,
            this.xrLabel37,
            this.xrLabel36,
            this.xrLabel35,
            this.xrLabel34,
            this.xrLabel33,
            this.xrLabel29,
            this.xrLabel28,
            this.xrLabel27,
            this.xrLabel26,
            this.xrLabel25,
            this.xrLabel24,
            this.xrLabel23,
            this.xrLabel22,
            this.xrLabel21});
        this.xrPanel1.Dpi = 100F;
        this.xrPanel1.LocationFloat = new DevExpress.Utils.PointFloat(1.500003F, 337.5F);
        this.xrPanel1.Name = "xrPanel1";
        this.xrPanel1.SizeF = new System.Drawing.SizeF(901.5F, 175F);
        this.xrPanel1.StylePriority.UseBorders = false;
        // 
        // xrLabel42
        // 
        this.xrLabel42.Borders = DevExpress.XtraPrinting.BorderSide.None;
        this.xrLabel42.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CornObjectList.TotalUnApprovedProjectCount")});
        this.xrLabel42.Dpi = 100F;
        this.xrLabel42.Font = new System.Drawing.Font("Arial", 9.75F);
        this.xrLabel42.LocationFloat = new DevExpress.Utils.PointFloat(497.4584F, 150F);
        this.xrLabel42.Name = "xrLabel42";
        this.xrLabel42.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
        this.xrLabel42.SizeF = new System.Drawing.SizeF(101.5831F, 22.99998F);
        this.xrLabel42.StylePriority.UseBorders = false;
        this.xrLabel42.StylePriority.UseFont = false;
        this.xrLabel42.StylePriority.UsePadding = false;
        this.xrLabel42.StylePriority.UseTextAlignment = false;
        this.xrLabel42.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        // 
        // xrLabel41
        // 
        this.xrLabel41.Borders = DevExpress.XtraPrinting.BorderSide.None;
        this.xrLabel41.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CornObjectList.UnApprovedOnGoingProjectCount")});
        this.xrLabel41.Dpi = 100F;
        this.xrLabel41.Font = new System.Drawing.Font("Arial", 9.75F);
        this.xrLabel41.LocationFloat = new DevExpress.Utils.PointFloat(648.5F, 150F);
        this.xrLabel41.Name = "xrLabel41";
        this.xrLabel41.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
        this.xrLabel41.SizeF = new System.Drawing.SizeF(101.5831F, 22.99998F);
        this.xrLabel41.StylePriority.UseBorders = false;
        this.xrLabel41.StylePriority.UseFont = false;
        this.xrLabel41.StylePriority.UsePadding = false;
        this.xrLabel41.StylePriority.UseTextAlignment = false;
        this.xrLabel41.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        // 
        // xrLabel40
        // 
        this.xrLabel40.Borders = DevExpress.XtraPrinting.BorderSide.None;
        this.xrLabel40.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CornObjectList.UnApprovedNewProjectCount")});
        this.xrLabel40.Dpi = 100F;
        this.xrLabel40.Font = new System.Drawing.Font("Arial", 9.75F);
        this.xrLabel40.LocationFloat = new DevExpress.Utils.PointFloat(797.5418F, 150F);
        this.xrLabel40.Name = "xrLabel40";
        this.xrLabel40.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
        this.xrLabel40.SizeF = new System.Drawing.SizeF(101.5831F, 22.99998F);
        this.xrLabel40.StylePriority.UseBorders = false;
        this.xrLabel40.StylePriority.UseFont = false;
        this.xrLabel40.StylePriority.UsePadding = false;
        this.xrLabel40.StylePriority.UseTextAlignment = false;
        this.xrLabel40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        // 
        // xrLabel39
        // 
        this.xrLabel39.Borders = DevExpress.XtraPrinting.BorderSide.None;
        this.xrLabel39.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CornObjectList.ApprovedNewProjectCount")});
        this.xrLabel39.Dpi = 100F;
        this.xrLabel39.Font = new System.Drawing.Font("Arial", 9.75F);
        this.xrLabel39.LocationFloat = new DevExpress.Utils.PointFloat(797.5417F, 111.4583F);
        this.xrLabel39.Name = "xrLabel39";
        this.xrLabel39.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
        this.xrLabel39.SizeF = new System.Drawing.SizeF(101.5831F, 22.99998F);
        this.xrLabel39.StylePriority.UseBorders = false;
        this.xrLabel39.StylePriority.UseFont = false;
        this.xrLabel39.StylePriority.UsePadding = false;
        this.xrLabel39.StylePriority.UseTextAlignment = false;
        this.xrLabel39.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        // 
        // xrLabel38
        // 
        this.xrLabel38.Borders = DevExpress.XtraPrinting.BorderSide.None;
        this.xrLabel38.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CornObjectList.ApprovedOnGoingProjectCount")});
        this.xrLabel38.Dpi = 100F;
        this.xrLabel38.Font = new System.Drawing.Font("Arial", 9.75F);
        this.xrLabel38.LocationFloat = new DevExpress.Utils.PointFloat(648.5001F, 111.4584F);
        this.xrLabel38.Name = "xrLabel38";
        this.xrLabel38.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
        this.xrLabel38.SizeF = new System.Drawing.SizeF(101.5831F, 22.99998F);
        this.xrLabel38.StylePriority.UseBorders = false;
        this.xrLabel38.StylePriority.UseFont = false;
        this.xrLabel38.StylePriority.UsePadding = false;
        this.xrLabel38.StylePriority.UseTextAlignment = false;
        this.xrLabel38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        // 
        // xrLabel37
        // 
        this.xrLabel37.Borders = DevExpress.XtraPrinting.BorderSide.None;
        this.xrLabel37.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CornObjectList.TotalApprovedProjectCount")});
        this.xrLabel37.Dpi = 100F;
        this.xrLabel37.Font = new System.Drawing.Font("Arial", 9.75F);
        this.xrLabel37.LocationFloat = new DevExpress.Utils.PointFloat(497.4583F, 111.4584F);
        this.xrLabel37.Name = "xrLabel37";
        this.xrLabel37.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
        this.xrLabel37.SizeF = new System.Drawing.SizeF(101.5831F, 22.99998F);
        this.xrLabel37.StylePriority.UseBorders = false;
        this.xrLabel37.StylePriority.UseFont = false;
        this.xrLabel37.StylePriority.UsePadding = false;
        this.xrLabel37.StylePriority.UseTextAlignment = false;
        this.xrLabel37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        // 
        // xrLabel36
        // 
        this.xrLabel36.Borders = DevExpress.XtraPrinting.BorderSide.None;
        this.xrLabel36.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CornObjectList.TotalPreviousUnApprovedProjectCount")});
        this.xrLabel36.Dpi = 100F;
        this.xrLabel36.Font = new System.Drawing.Font("Arial", 9.75F);
        this.xrLabel36.LocationFloat = new DevExpress.Utils.PointFloat(497.4584F, 75.08338F);
        this.xrLabel36.Name = "xrLabel36";
        this.xrLabel36.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
        this.xrLabel36.SizeF = new System.Drawing.SizeF(101.5831F, 22.99998F);
        this.xrLabel36.StylePriority.UseBorders = false;
        this.xrLabel36.StylePriority.UseFont = false;
        this.xrLabel36.StylePriority.UsePadding = false;
        this.xrLabel36.StylePriority.UseTextAlignment = false;
        this.xrLabel36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        // 
        // xrLabel35
        // 
        this.xrLabel35.Borders = DevExpress.XtraPrinting.BorderSide.None;
        this.xrLabel35.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CornObjectList.PreviousUnApprovedOnGoingProjectCount")});
        this.xrLabel35.Dpi = 100F;
        this.xrLabel35.Font = new System.Drawing.Font("Arial", 9.75F);
        this.xrLabel35.LocationFloat = new DevExpress.Utils.PointFloat(648F, 75.08335F);
        this.xrLabel35.Name = "xrLabel35";
        this.xrLabel35.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
        this.xrLabel35.SizeF = new System.Drawing.SizeF(101.5831F, 22.99998F);
        this.xrLabel35.StylePriority.UseBorders = false;
        this.xrLabel35.StylePriority.UseFont = false;
        this.xrLabel35.StylePriority.UsePadding = false;
        this.xrLabel35.StylePriority.UseTextAlignment = false;
        this.xrLabel35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        // 
        // xrLabel34
        // 
        this.xrLabel34.Borders = DevExpress.XtraPrinting.BorderSide.None;
        this.xrLabel34.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CornObjectList.PreviousUnApprovedNewProjectCount")});
        this.xrLabel34.Dpi = 100F;
        this.xrLabel34.Font = new System.Drawing.Font("Arial", 9.75F);
        this.xrLabel34.LocationFloat = new DevExpress.Utils.PointFloat(797.5417F, 75.08335F);
        this.xrLabel34.Name = "xrLabel34";
        this.xrLabel34.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
        this.xrLabel34.SizeF = new System.Drawing.SizeF(101.5831F, 22.99998F);
        this.xrLabel34.StylePriority.UseBorders = false;
        this.xrLabel34.StylePriority.UseFont = false;
        this.xrLabel34.StylePriority.UsePadding = false;
        this.xrLabel34.StylePriority.UseTextAlignment = false;
        this.xrLabel34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        // 
        // xrLabel33
        // 
        this.xrLabel33.Borders = DevExpress.XtraPrinting.BorderSide.None;
        this.xrLabel33.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CornObjectList.TotalPreviousApprovedProjectCount")});
        this.xrLabel33.Dpi = 100F;
        this.xrLabel33.Font = new System.Drawing.Font("Arial", 9.75F);
        this.xrLabel33.LocationFloat = new DevExpress.Utils.PointFloat(497.4583F, 38.54173F);
        this.xrLabel33.Name = "xrLabel33";
        this.xrLabel33.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
        this.xrLabel33.SizeF = new System.Drawing.SizeF(101.5831F, 22.99998F);
        this.xrLabel33.StylePriority.UseBorders = false;
        this.xrLabel33.StylePriority.UseFont = false;
        this.xrLabel33.StylePriority.UsePadding = false;
        this.xrLabel33.StylePriority.UseTextAlignment = false;
        this.xrLabel33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        // 
        // xrLabel29
        // 
        this.xrLabel29.Borders = DevExpress.XtraPrinting.BorderSide.None;
        this.xrLabel29.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CornObjectList.TotalProjectCount")});
        this.xrLabel29.Dpi = 100F;
        this.xrLabel29.Font = new System.Drawing.Font("Arial", 9.75F);
        this.xrLabel29.LocationFloat = new DevExpress.Utils.PointFloat(497.4583F, 2.000046F);
        this.xrLabel29.Name = "xrLabel29";
        this.xrLabel29.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
        this.xrLabel29.SizeF = new System.Drawing.SizeF(101.5831F, 22.99998F);
        this.xrLabel29.StylePriority.UseBorders = false;
        this.xrLabel29.StylePriority.UseFont = false;
        this.xrLabel29.StylePriority.UsePadding = false;
        this.xrLabel29.StylePriority.UseTextAlignment = false;
        this.xrLabel29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        // 
        // xrLabel28
        // 
        this.xrLabel28.Borders = DevExpress.XtraPrinting.BorderSide.None;
        this.xrLabel28.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CornObjectList.OnGoingProjectCount")});
        this.xrLabel28.Dpi = 100F;
        this.xrLabel28.Font = new System.Drawing.Font("Arial", 9.75F);
        this.xrLabel28.LocationFloat = new DevExpress.Utils.PointFloat(648.5F, 2.000046F);
        this.xrLabel28.Name = "xrLabel28";
        this.xrLabel28.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
        this.xrLabel28.SizeF = new System.Drawing.SizeF(101.5831F, 22.99998F);
        this.xrLabel28.StylePriority.UseBorders = false;
        this.xrLabel28.StylePriority.UseFont = false;
        this.xrLabel28.StylePriority.UsePadding = false;
        this.xrLabel28.StylePriority.UseTextAlignment = false;
        this.xrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        // 
        // xrLabel27
        // 
        this.xrLabel27.Borders = DevExpress.XtraPrinting.BorderSide.None;
        this.xrLabel27.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CornObjectList.NewProjectCount")});
        this.xrLabel27.Dpi = 100F;
        this.xrLabel27.Font = new System.Drawing.Font("Arial", 9.75F);
        this.xrLabel27.LocationFloat = new DevExpress.Utils.PointFloat(798.0417F, 1.999982F);
        this.xrLabel27.Name = "xrLabel27";
        this.xrLabel27.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
        this.xrLabel27.SizeF = new System.Drawing.SizeF(101.5831F, 22.99998F);
        this.xrLabel27.StylePriority.UseBorders = false;
        this.xrLabel27.StylePriority.UseFont = false;
        this.xrLabel27.StylePriority.UsePadding = false;
        this.xrLabel27.StylePriority.UseTextAlignment = false;
        this.xrLabel27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        // 
        // xrLabel26
        // 
        this.xrLabel26.Borders = DevExpress.XtraPrinting.BorderSide.None;
        this.xrLabel26.Dpi = 100F;
        this.xrLabel26.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
        this.xrLabel26.LocationFloat = new DevExpress.Utils.PointFloat(222.5F, 150F);
        this.xrLabel26.Name = "xrLabel26";
        this.xrLabel26.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
        this.xrLabel26.SizeF = new System.Drawing.SizeF(273.9583F, 22.99998F);
        this.xrLabel26.StylePriority.UseBorders = false;
        this.xrLabel26.StylePriority.UseFont = false;
        this.xrLabel26.StylePriority.UsePadding = false;
        this.xrLabel26.Text = "Unapproved schemes";
        // 
        // xrLabel25
        // 
        this.xrLabel25.Borders = DevExpress.XtraPrinting.BorderSide.None;
        this.xrLabel25.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "headApprovedY")});
        this.xrLabel25.Dpi = 100F;
        this.xrLabel25.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
        this.xrLabel25.LocationFloat = new DevExpress.Utils.PointFloat(223.5F, 111.4583F);
        this.xrLabel25.Name = "xrLabel25";
        this.xrLabel25.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
        this.xrLabel25.SizeF = new System.Drawing.SizeF(272.9584F, 23.00005F);
        this.xrLabel25.StylePriority.UseBorders = false;
        this.xrLabel25.StylePriority.UseFont = false;
        this.xrLabel25.StylePriority.UsePadding = false;
        // 
        // xrLabel24
        // 
        this.xrLabel24.Borders = DevExpress.XtraPrinting.BorderSide.None;
        this.xrLabel24.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "headUnapprovedY")});
        this.xrLabel24.Dpi = 100F;
        this.xrLabel24.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
        this.xrLabel24.LocationFloat = new DevExpress.Utils.PointFloat(223F, 75.08335F);
        this.xrLabel24.Name = "xrLabel24";
        this.xrLabel24.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
        this.xrLabel24.SizeF = new System.Drawing.SizeF(273.9583F, 23.00002F);
        this.xrLabel24.StylePriority.UseBorders = false;
        this.xrLabel24.StylePriority.UseFont = false;
        this.xrLabel24.StylePriority.UsePadding = false;
        // 
        // xrLabel23
        // 
        this.xrLabel23.Borders = DevExpress.XtraPrinting.BorderSide.None;
        this.xrLabel23.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "headApprovedPY")});
        this.xrLabel23.Dpi = 100F;
        this.xrLabel23.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
        this.xrLabel23.LocationFloat = new DevExpress.Utils.PointFloat(223.5F, 38.54167F);
        this.xrLabel23.Name = "xrLabel23";
        this.xrLabel23.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
        this.xrLabel23.SizeF = new System.Drawing.SizeF(272.9584F, 23.00002F);
        this.xrLabel23.StylePriority.UseBorders = false;
        this.xrLabel23.StylePriority.UseFont = false;
        this.xrLabel23.StylePriority.UsePadding = false;
        // 
        // xrLabel22
        // 
        this.xrLabel22.Borders = DevExpress.XtraPrinting.BorderSide.None;
        this.xrLabel22.Dpi = 100F;
        this.xrLabel22.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
        this.xrLabel22.LocationFloat = new DevExpress.Utils.PointFloat(223.5F, 2.000046F);
        this.xrLabel22.Name = "xrLabel22";
        this.xrLabel22.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
        this.xrLabel22.SizeF = new System.Drawing.SizeF(273.4583F, 22.99999F);
        this.xrLabel22.StylePriority.UseBorders = false;
        this.xrLabel22.StylePriority.UseFont = false;
        this.xrLabel22.StylePriority.UsePadding = false;
        this.xrLabel22.Text = "Total Schemes";
        // 
        // xrLabel21
        // 
        this.xrLabel21.Borders = DevExpress.XtraPrinting.BorderSide.None;
        this.xrLabel21.Dpi = 100F;
        this.xrLabel21.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
        this.xrLabel21.LocationFloat = new DevExpress.Utils.PointFloat(2F, 75.08335F);
        this.xrLabel21.Name = "xrLabel21";
        this.xrLabel21.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
        this.xrLabel21.SizeF = new System.Drawing.SizeF(206.9166F, 23.00002F);
        this.xrLabel21.StylePriority.UseBorders = false;
        this.xrLabel21.StylePriority.UseFont = false;
        this.xrLabel21.StylePriority.UsePadding = false;
        this.xrLabel21.Text = "Approval Status";
        // 
        // xrLabel19
        // 
        this.xrLabel19.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CornObjectList.ExpenseReleasePercentage", "{0:0.00%}")});
        this.xrLabel19.Dpi = 100F;
        this.xrLabel19.Font = new System.Drawing.Font("Arial", 9.75F);
        this.xrLabel19.LocationFloat = new DevExpress.Utils.PointFloat(225.5F, 262.4583F);
        this.xrLabel19.Name = "xrLabel19";
        this.xrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
        this.xrLabel19.SizeF = new System.Drawing.SizeF(250F, 23.00001F);
        this.xrLabel19.StylePriority.UseFont = false;
        this.xrLabel19.StylePriority.UsePadding = false;
        // 
        // xrLabel20
        // 
        this.xrLabel20.Dpi = 100F;
        this.xrLabel20.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
        this.xrLabel20.LocationFloat = new DevExpress.Utils.PointFloat(1.000007F, 262.4583F);
        this.xrLabel20.Name = "xrLabel20";
        this.xrLabel20.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
        this.xrLabel20.SizeF = new System.Drawing.SizeF(224.5F, 23.00003F);
        this.xrLabel20.StylePriority.UseFont = false;
        this.xrLabel20.StylePriority.UsePadding = false;
        this.xrLabel20.Text = "Expenditures as % of Releases";
        // 
        // xrLabel17
        // 
        this.xrLabel17.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CornObjectList.ExpenseAllocationPercentage", "{0:0.00%}")});
        this.xrLabel17.Dpi = 100F;
        this.xrLabel17.Font = new System.Drawing.Font("Arial", 9.75F);
        this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(225.5F, 224.9584F);
        this.xrLabel17.Name = "xrLabel17";
        this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
        this.xrLabel17.SizeF = new System.Drawing.SizeF(250F, 23.00001F);
        this.xrLabel17.StylePriority.UseFont = false;
        this.xrLabel17.StylePriority.UsePadding = false;
        // 
        // xrLabel18
        // 
        this.xrLabel18.Dpi = 100F;
        this.xrLabel18.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
        this.xrLabel18.LocationFloat = new DevExpress.Utils.PointFloat(1.000007F, 224.9584F);
        this.xrLabel18.Name = "xrLabel18";
        this.xrLabel18.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
        this.xrLabel18.SizeF = new System.Drawing.SizeF(224.5F, 23.00002F);
        this.xrLabel18.StylePriority.UseFont = false;
        this.xrLabel18.StylePriority.UsePadding = false;
        this.xrLabel18.Text = "Expenditures as % of Allocation";
        // 
        // xrLabel15
        // 
        this.xrLabel15.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CornObjectList.Expense", "{0:#,#}")});
        this.xrLabel15.Dpi = 100F;
        this.xrLabel15.Font = new System.Drawing.Font("Arial", 9.75F);
        this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(225.5F, 186.4167F);
        this.xrLabel15.Name = "xrLabel15";
        this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
        this.xrLabel15.SizeF = new System.Drawing.SizeF(250F, 23.00001F);
        this.xrLabel15.StylePriority.UseFont = false;
        this.xrLabel15.StylePriority.UsePadding = false;
        // 
        // xrLabel16
        // 
        this.xrLabel16.Dpi = 100F;
        this.xrLabel16.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
        this.xrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(0.4999956F, 186.4167F);
        this.xrLabel16.Name = "xrLabel16";
        this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
        this.xrLabel16.SizeF = new System.Drawing.SizeF(225F, 23.00002F);
        this.xrLabel16.StylePriority.UseFont = false;
        this.xrLabel16.StylePriority.UsePadding = false;
        this.xrLabel16.Text = "Expenditures";
        // 
        // xrLabel13
        // 
        this.xrLabel13.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CornObjectList.ExecessSurrender", "{0:#,#}")});
        this.xrLabel13.Dpi = 100F;
        this.xrLabel13.Font = new System.Drawing.Font("Arial", 9.75F);
        this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(225.5F, 149.9584F);
        this.xrLabel13.Name = "xrLabel13";
        this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
        this.xrLabel13.SizeF = new System.Drawing.SizeF(250F, 23.00001F);
        this.xrLabel13.StylePriority.UseFont = false;
        this.xrLabel13.StylePriority.UsePadding = false;
        // 
        // xrLabel14
        // 
        this.xrLabel14.Dpi = 100F;
        this.xrLabel14.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
        this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(0.4999956F, 149.9584F);
        this.xrLabel14.Name = "xrLabel14";
        this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
        this.xrLabel14.SizeF = new System.Drawing.SizeF(225F, 23.00002F);
        this.xrLabel14.StylePriority.UseFont = false;
        this.xrLabel14.StylePriority.UsePadding = false;
        this.xrLabel14.Text = "Execess/Surrender";
        // 
        // xrLabel11
        // 
        this.xrLabel11.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CornObjectList.Revise", "{0:#,#}")});
        this.xrLabel11.Dpi = 100F;
        this.xrLabel11.Font = new System.Drawing.Font("Arial", 9.75F);
        this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(225.5F, 113.5F);
        this.xrLabel11.Name = "xrLabel11";
        this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
        this.xrLabel11.SizeF = new System.Drawing.SizeF(250F, 23.00001F);
        this.xrLabel11.StylePriority.UseFont = false;
        this.xrLabel11.StylePriority.UsePadding = false;
        // 
        // xrLabel12
        // 
        this.xrLabel12.Dpi = 100F;
        this.xrLabel12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
        this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(0.5000114F, 113.5F);
        this.xrLabel12.Name = "xrLabel12";
        this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
        this.xrLabel12.SizeF = new System.Drawing.SizeF(225F, 23.00001F);
        this.xrLabel12.StylePriority.UseFont = false;
        this.xrLabel12.StylePriority.UsePadding = false;
        this.xrLabel12.Text = "Revised";
        // 
        // xrLabel9
        // 
        this.xrLabel9.Dpi = 100F;
        this.xrLabel9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
        this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(0.4999956F, 77.04169F);
        this.xrLabel9.Name = "xrLabel9";
        this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
        this.xrLabel9.SizeF = new System.Drawing.SizeF(225F, 23.00001F);
        this.xrLabel9.StylePriority.UseFont = false;
        this.xrLabel9.StylePriority.UsePadding = false;
        this.xrLabel9.Text = "Releases";
        // 
        // xrLabel10
        // 
        this.xrLabel10.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CornObjectList.Release", "{0:#,#}")});
        this.xrLabel10.Dpi = 100F;
        this.xrLabel10.Font = new System.Drawing.Font("Arial", 9.75F);
        this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(225.5F, 77.04169F);
        this.xrLabel10.Name = "xrLabel10";
        this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
        this.xrLabel10.SizeF = new System.Drawing.SizeF(250F, 23.00001F);
        this.xrLabel10.StylePriority.UseFont = false;
        this.xrLabel10.StylePriority.UsePadding = false;
        // 
        // xrLabel7
        // 
        this.xrLabel7.Dpi = 100F;
        this.xrLabel7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
        this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(0.5000114F, 37.45835F);
        this.xrLabel7.Name = "xrLabel7";
        this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
        this.xrLabel7.SizeF = new System.Drawing.SizeF(225F, 23.00001F);
        this.xrLabel7.StylePriority.UseFont = false;
        this.xrLabel7.StylePriority.UsePadding = false;
        this.xrLabel7.Text = "Supplementary";
        // 
        // xrLabel8
        // 
        this.xrLabel8.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CornObjectList.Supplementary", "{0:#,#}")});
        this.xrLabel8.Dpi = 100F;
        this.xrLabel8.Font = new System.Drawing.Font("Arial", 9.75F);
        this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(225.5F, 37.45835F);
        this.xrLabel8.Name = "xrLabel8";
        this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
        this.xrLabel8.SizeF = new System.Drawing.SizeF(250F, 23.00001F);
        this.xrLabel8.StylePriority.UseFont = false;
        this.xrLabel8.StylePriority.UsePadding = false;
        // 
        // xrLabel5
        // 
        this.xrLabel5.Dpi = 100F;
        this.xrLabel5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
        this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(0.9999911F, 0F);
        this.xrLabel5.Name = "xrLabel5";
        this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
        this.xrLabel5.SizeF = new System.Drawing.SizeF(224.5F, 23.00001F);
        this.xrLabel5.StylePriority.UseFont = false;
        this.xrLabel5.StylePriority.UsePadding = false;
        this.xrLabel5.Text = "Allocation";
        // 
        // xrLabel6
        // 
        this.xrLabel6.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CornObjectList.Allocation", "{0:#,#}")});
        this.xrLabel6.Dpi = 100F;
        this.xrLabel6.Font = new System.Drawing.Font("Arial", 9.75F);
        this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(225.5F, 0F);
        this.xrLabel6.Name = "xrLabel6";
        this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
        this.xrLabel6.SizeF = new System.Drawing.SizeF(250F, 23.00001F);
        this.xrLabel6.StylePriority.UseFont = false;
        this.xrLabel6.StylePriority.UsePadding = false;
        // 
        // TopMargin
        // 
        this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel2,
            this.xrLabel4,
            this.xrLabel1});
        this.TopMargin.Dpi = 100F;
        this.TopMargin.HeightF = 174F;
        this.TopMargin.Name = "TopMargin";
        this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
        this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        // 
        // xrLabel2
        // 
        this.xrLabel2.Dpi = 100F;
        this.xrLabel2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
        this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 136.4167F);
        this.xrLabel2.Name = "xrLabel2";
        this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
        this.xrLabel2.SizeF = new System.Drawing.SizeF(50F, 23.00001F);
        this.xrLabel2.StylePriority.UseFont = false;
        this.xrLabel2.StylePriority.UsePadding = false;
        this.xrLabel2.Text = "Year:";
        // 
        // xrLabel4
        // 
        this.xrLabel4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.prYear, "Text", "")});
        this.xrLabel4.Dpi = 100F;
        this.xrLabel4.Font = new System.Drawing.Font("Arial", 9.75F);
        this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(50F, 136.4167F);
        this.xrLabel4.Name = "xrLabel4";
        this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
        this.xrLabel4.SizeF = new System.Drawing.SizeF(250F, 23.00001F);
        this.xrLabel4.StylePriority.UseFont = false;
        this.xrLabel4.StylePriority.UsePadding = false;
        // 
        // prYear
        // 
        this.prYear.Description = "Year";
        this.prYear.Name = "prYear";
        this.prYear.Visible = false;
        // 
        // xrLabel1
        // 
        this.xrLabel1.Dpi = 100F;
        this.xrLabel1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
        this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(62.5F, 25F);
        this.xrLabel1.Name = "xrLabel1";
        this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel1.SizeF = new System.Drawing.SizeF(779.375F, 48.95834F);
        this.xrLabel1.StylePriority.UseFont = false;
        this.xrLabel1.StylePriority.UseTextAlignment = false;
        this.xrLabel1.Text = "ADP Review - Abstract";
        this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // BottomMargin
        // 
        this.BottomMargin.Dpi = 100F;
        this.BottomMargin.HeightF = 100F;
        this.BottomMargin.Name = "BottomMargin";
        this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
        this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        // 
        // bindingSource1
        // 
        this.bindingSource1.DataMember = "CornReportList";
        this.bindingSource1.DataSource = typeof(CORNDataAccessLayer.Response.ReportResponse);
        // 
        // PageFooter
        // 
        this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel3});
        this.PageFooter.Dpi = 100F;
        this.PageFooter.HeightF = 60.5F;
        this.PageFooter.Name = "PageFooter";
        // 
        // xrLabel3
        // 
        this.xrLabel3.Dpi = 100F;
        this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(237.5F, 37.5F);
        this.xrLabel3.Name = "xrLabel3";
        this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel3.SizeF = new System.Drawing.SizeF(424.9999F, 23F);
        this.xrLabel3.StylePriority.UseTextAlignment = false;
        this.xrLabel3.Text = System.Configuration.ConfigurationManager.AppSettings["FooterText"];
        this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // prCYear
        // 
        this.prCYear.Description = "CYear";
        this.prCYear.Name = "prCYear";
        this.prCYear.Visible = false;
        // 
        // prPYear
        // 
        this.prPYear.Description = "PYear";
        this.prPYear.Name = "prPYear";
        this.prPYear.Visible = false;
        // 
        // ExpenseAllocationPercentage
        // 
        this.ExpenseAllocationPercentage.DataMember = "CornObjectList";
        this.ExpenseAllocationPercentage.Expression = "([Expense] / [Allocation])";
        this.ExpenseAllocationPercentage.Name = "ExpenseAllocationPercentage";
        // 
        // ExpenseReleasePercentage
        // 
        this.ExpenseReleasePercentage.DataMember = "CornObjectList";
        this.ExpenseReleasePercentage.Expression = "([Expense] / [Release])";
        this.ExpenseReleasePercentage.Name = "ExpenseReleasePercentage";
        // 
        // headApprovedPY
        // 
        this.headApprovedPY.Expression = "Concat(\'Approved upto \', [Parameters.prPYear])";
        this.headApprovedPY.Name = "headApprovedPY";
        // 
        // headUnapprovedY
        // 
        this.headUnapprovedY.Expression = "Concat(\'Uapproved at the start of \', [Parameters.prCYear])";
        this.headUnapprovedY.Name = "headUnapprovedY";
        // 
        // headApprovedY
        // 
        this.headApprovedY.Expression = "Concat(\'Schemes approved during \', [Parameters.prCYear])";
        this.headApprovedY.Name = "headApprovedY";
        // 
        // xrADPAbstractReport
        // 
        this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.PageFooter});
        this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.ExpenseAllocationPercentage,
            this.ExpenseReleasePercentage,
            this.headApprovedPY,
            this.headUnapprovedY,
            this.headApprovedY});
        this.DataMember = "CornObjectList";
        this.DataSource = this.bindingSource1;
        this.Margins = new System.Drawing.Printing.Margins(12, 14, 174, 100);
        this.PageHeight = 1268;
        this.PageWidth = 929;
        this.PaperKind = System.Drawing.Printing.PaperKind.A4Extra;
        this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.prYear,
            this.prCYear,
            this.prPYear});
        this.Version = "16.1";
        ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion
}
