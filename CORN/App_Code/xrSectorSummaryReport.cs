using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

/// <summary>
/// Summary description for xrSectorSummaryReport
/// </summary>
public class xrSectorSummaryReport : DevExpress.XtraReports.UI.XtraReport
{
    private DevExpress.XtraReports.UI.DetailBand Detail;
    private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
    private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
    private System.Windows.Forms.BindingSource bindingSource1;
    private XRLabel xrLabel1;
    private XRLabel xrLabel2;
    private DetailReportBand DetailReport;
    private DetailBand Detail1;
    private GroupHeaderBand GroupHeader1;
    private GroupFooterBand GroupFooter1;
    private XRTable xrTable1;
    private XRTableRow xrTableRow1;
    private XRTableCell xrTableCell1;
    private XRTableCell xrTableCell2;
    private XRTableCell xrTableCell3;
    private XRTableCell xrTableCell7;
    private XRTableCell xrTableCell4;
    private XRTableCell xrTableCell5;
    private XRTableCell xrTableCell6;
    private DevExpress.XtraReports.Parameters.Parameter prFinancialYear;
    private CalculatedField headBudgetEstimation;
    private XRTable xrTable2;
    private XRTableRow xrTableRow2;
    private XRTableCell xrTableCell8;
    private XRTableCell xrTableCell9;
    private XRTableCell xrTableCell10;
    private XRTableCell xrTableCell11;
    private XRTableCell xrTableCell12;
    private XRTableCell xrTableCell13;
    private XRTableCell xrTableCell14;
    private XRTable xrTable3;
    private XRTableRow xrTableRow3;
    private XRTableCell xrTableCell15;
    private XRTableCell xrTableCell16;
    private XRTableCell xrTableCell17;
    private XRTableCell xrTableCell18;
    private XRTableCell xrTableCell19;
    private XRTableCell tcUtilizationFG;
    private XRTableCell tcUtilizationBE;
    private CalculatedField FinalGrant;
    private CalculatedField UtilizationFG;
    private CalculatedField UtilizationBE;
    private PageFooterBand PageFooter;
    private XRLabel xrLabel9;
    private XRTableCell xrTableCell21;
    private XRTableCell xrTableCell20;
    private XRTableCell tcUtilizationR;
    private CalculatedField UtilizationR;

    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public xrSectorSummaryReport()
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
        string resourceFileName = "xrSectorSummaryReport.resx";
        this.components = new System.ComponentModel.Container();
        DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary2 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary3 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary4 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary5 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary6 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary7 = new DevExpress.XtraReports.UI.XRSummary();
        this.Detail = new DevExpress.XtraReports.UI.DetailBand();
        this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
        this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
        this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
        this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
        this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
        this.DetailReport = new DevExpress.XtraReports.UI.DetailReportBand();
        this.Detail1 = new DevExpress.XtraReports.UI.DetailBand();
        this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell13 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell14 = new DevExpress.XtraReports.UI.XRTableCell();
        this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
        this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
        this.GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
        this.xrTable3 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell15 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell16 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell17 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell18 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell19 = new DevExpress.XtraReports.UI.XRTableCell();
        this.tcUtilizationFG = new DevExpress.XtraReports.UI.XRTableCell();
        this.tcUtilizationBE = new DevExpress.XtraReports.UI.XRTableCell();
        this.prFinancialYear = new DevExpress.XtraReports.Parameters.Parameter();
        this.headBudgetEstimation = new DevExpress.XtraReports.UI.CalculatedField();
        this.FinalGrant = new DevExpress.XtraReports.UI.CalculatedField();
        this.UtilizationFG = new DevExpress.XtraReports.UI.CalculatedField();
        this.UtilizationBE = new DevExpress.XtraReports.UI.CalculatedField();
        this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
        this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrTableCell20 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell21 = new DevExpress.XtraReports.UI.XRTableCell();
        this.tcUtilizationR = new DevExpress.XtraReports.UI.XRTableCell();
        this.UtilizationR = new DevExpress.XtraReports.UI.CalculatedField();
        ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
        // 
        // Detail
        // 
        this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel2});
        this.Detail.Dpi = 100F;
        this.Detail.HeightF = 32F;
        this.Detail.Name = "Detail";
        this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
        this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        // 
        // xrLabel2
        // 
        this.xrLabel2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "InstituteList.Title")});
        this.xrLabel2.Dpi = 100F;
        this.xrLabel2.Font = new System.Drawing.Font("Arial", 14.75F, System.Drawing.FontStyle.Bold);
        this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(87.5F, 0F);
        this.xrLabel2.Name = "xrLabel2";
        this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel2.SizeF = new System.Drawing.SizeF(1200F, 32F);
        this.xrLabel2.StylePriority.UseFont = false;
        this.xrLabel2.StylePriority.UseTextAlignment = false;
        this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // TopMargin
        // 
        this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1});
        this.TopMargin.Dpi = 100F;
        this.TopMargin.HeightF = 98F;
        this.TopMargin.Name = "TopMargin";
        this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
        this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        // 
        // xrLabel1
        // 
        this.xrLabel1.Dpi = 100F;
        this.xrLabel1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
        this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(312.5F, 25F);
        this.xrLabel1.Name = "xrLabel1";
        this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel1.SizeF = new System.Drawing.SizeF(744.9999F, 48.95834F);
        this.xrLabel1.StylePriority.UseFont = false;
        this.xrLabel1.StylePriority.UseTextAlignment = false;
        this.xrLabel1.Text = "SUB-SECTOR WISE DEVELOPMENT PROJECTS SUMMARY";
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
        // DetailReport
        // 
        this.DetailReport.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail1,
            this.GroupHeader1,
            this.GroupFooter1});
        this.DetailReport.DataMember = "InstituteList.SubSectorList";
        this.DetailReport.DataSource = this.bindingSource1;
        this.DetailReport.Dpi = 100F;
        this.DetailReport.Level = 0;
        this.DetailReport.Name = "DetailReport";
        // 
        // Detail1
        // 
        this.Detail1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable2});
        this.Detail1.Dpi = 100F;
        this.Detail1.HeightF = 25F;
        this.Detail1.Name = "Detail1";
        // 
        // xrTable2
        // 
        this.xrTable2.BorderColor = System.Drawing.Color.LightGray;
        this.xrTable2.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTable2.Dpi = 100F;
        this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrTable2.Name = "xrTable2";
        this.xrTable2.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
        this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
        this.xrTable2.SizeF = new System.Drawing.SizeF(1375F, 25F);
        this.xrTable2.StylePriority.UseBorderColor = false;
        this.xrTable2.StylePriority.UseBorders = false;
        this.xrTable2.StylePriority.UsePadding = false;
        this.xrTable2.StylePriority.UseTextAlignment = false;
        this.xrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrTableRow2
        // 
        this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell8,
            this.xrTableCell9,
            this.xrTableCell10,
            this.xrTableCell11,
            this.xrTableCell12,
            this.xrTableCell13,
            this.xrTableCell14,
            this.xrTableCell21});
        this.xrTableRow2.Dpi = 100F;
        this.xrTableRow2.Name = "xrTableRow2";
        this.xrTableRow2.Weight = 1D;
        // 
        // xrTableCell8
        // 
        this.xrTableCell8.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "InstituteList.SubSectorList.Title")});
        this.xrTableCell8.Dpi = 100F;
        this.xrTableCell8.Name = "xrTableCell8";
        this.xrTableCell8.StylePriority.UseTextAlignment = false;
        this.xrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        this.xrTableCell8.Weight = 1.80000005664825D;
        // 
        // xrTableCell9
        // 
        this.xrTableCell9.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "InstituteList.SubSectorList.BudgetEstimate", "{0:#,#}")});
        this.xrTableCell9.Dpi = 100F;
        this.xrTableCell9.Name = "xrTableCell9";
        this.xrTableCell9.Weight = 0.599999881553653D;
        // 
        // xrTableCell10
        // 
        this.xrTableCell10.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "InstituteList.SubSectorList.FinalGrant", "{0:#,#}")});
        this.xrTableCell10.Dpi = 100F;
        this.xrTableCell10.Name = "xrTableCell10";
        this.xrTableCell10.Weight = 0.600000061798094D;
        // 
        // xrTableCell11
        // 
        this.xrTableCell11.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "InstituteList.SubSectorList.Release", "{0:#,#}")});
        this.xrTableCell11.Dpi = 100F;
        this.xrTableCell11.Name = "xrTableCell11";
        this.xrTableCell11.Weight = 0.600000061798094D;
        // 
        // xrTableCell12
        // 
        this.xrTableCell12.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "InstituteList.SubSectorList.Expenditure", "{0:#,#}")});
        this.xrTableCell12.Dpi = 100F;
        this.xrTableCell12.Name = "xrTableCell12";
        this.xrTableCell12.Weight = 0.600000061798094D;
        // 
        // xrTableCell13
        // 
        this.xrTableCell13.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "InstituteList.SubSectorList.UtilizationFG", "{0:0.00%}")});
        this.xrTableCell13.Dpi = 100F;
        this.xrTableCell13.Name = "xrTableCell13";
        this.xrTableCell13.Weight = 0.600000061798094D;
        // 
        // xrTableCell14
        // 
        this.xrTableCell14.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "InstituteList.SubSectorList.UtilizationBE", "{0:0.00%}")});
        this.xrTableCell14.Dpi = 100F;
        this.xrTableCell14.Name = "xrTableCell14";
        this.xrTableCell14.Weight = 0.600000061798094D;
        // 
        // GroupHeader1
        // 
        this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
        this.GroupHeader1.Dpi = 100F;
        this.GroupHeader1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("InstituteId", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
        this.GroupHeader1.HeightF = 55F;
        this.GroupHeader1.Name = "GroupHeader1";
        // 
        // xrTable1
        // 
        this.xrTable1.BackColor = System.Drawing.Color.LightGray;
        this.xrTable1.Dpi = 100F;
        this.xrTable1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
        this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrTable1.Name = "xrTable1";
        this.xrTable1.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
        this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
        this.xrTable1.SizeF = new System.Drawing.SizeF(1375F, 55F);
        this.xrTable1.StylePriority.UseBackColor = false;
        this.xrTable1.StylePriority.UseFont = false;
        this.xrTable1.StylePriority.UsePadding = false;
        this.xrTable1.StylePriority.UseTextAlignment = false;
        this.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrTableRow1
        // 
        this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell7,
            this.xrTableCell1,
            this.xrTableCell2,
            this.xrTableCell4,
            this.xrTableCell3,
            this.xrTableCell5,
            this.xrTableCell6,
            this.xrTableCell20});
        this.xrTableRow1.Dpi = 100F;
        this.xrTableRow1.Name = "xrTableRow1";
        this.xrTableRow1.Weight = 1D;
        // 
        // xrTableCell7
        // 
        this.xrTableCell7.Dpi = 100F;
        this.xrTableCell7.Name = "xrTableCell7";
        this.xrTableCell7.StylePriority.UseTextAlignment = false;
        this.xrTableCell7.Text = "Sub-Sector";
        this.xrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        this.xrTableCell7.Weight = 3.00000017438618D;
        // 
        // xrTableCell1
        // 
        this.xrTableCell1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "headBudgetEstimation")});
        this.xrTableCell1.Dpi = 100F;
        this.xrTableCell1.Name = "xrTableCell1";
        this.xrTableCell1.Weight = 1D;
        // 
        // xrTableCell2
        // 
        this.xrTableCell2.Dpi = 100F;
        this.xrTableCell2.Name = "xrTableCell2";
        this.xrTableCell2.Text = "Final Grant";
        this.xrTableCell2.Weight = 1D;
        // 
        // xrTableCell4
        // 
        this.xrTableCell4.Dpi = 100F;
        this.xrTableCell4.Name = "xrTableCell4";
        this.xrTableCell4.Text = "Release";
        this.xrTableCell4.Weight = 1D;
        // 
        // xrTableCell3
        // 
        this.xrTableCell3.Dpi = 100F;
        this.xrTableCell3.Name = "xrTableCell3";
        this.xrTableCell3.Text = "Expenditure";
        this.xrTableCell3.Weight = 1D;
        // 
        // xrTableCell5
        // 
        this.xrTableCell5.Dpi = 100F;
        this.xrTableCell5.Multiline = true;
        this.xrTableCell5.Name = "xrTableCell5";
        this.xrTableCell5.Text = "%age\r\nUtilization / FG";
        this.xrTableCell5.Weight = 1D;
        // 
        // xrTableCell6
        // 
        this.xrTableCell6.Dpi = 100F;
        this.xrTableCell6.Multiline = true;
        this.xrTableCell6.Name = "xrTableCell6";
        this.xrTableCell6.Text = "%age\r\nUtilization / BE";
        this.xrTableCell6.Weight = 1D;
        // 
        // GroupFooter1
        // 
        this.GroupFooter1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable3});
        this.GroupFooter1.Dpi = 100F;
        this.GroupFooter1.HeightF = 48.95833F;
        this.GroupFooter1.Name = "GroupFooter1";
        // 
        // xrTable3
        // 
        this.xrTable3.BorderColor = System.Drawing.Color.LightGray;
        this.xrTable3.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTable3.Dpi = 100F;
        this.xrTable3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
        this.xrTable3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrTable3.Name = "xrTable3";
        this.xrTable3.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
        this.xrTable3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow3});
        this.xrTable3.SizeF = new System.Drawing.SizeF(1375F, 25F);
        this.xrTable3.StylePriority.UseBorderColor = false;
        this.xrTable3.StylePriority.UseBorders = false;
        this.xrTable3.StylePriority.UseFont = false;
        this.xrTable3.StylePriority.UsePadding = false;
        this.xrTable3.StylePriority.UseTextAlignment = false;
        this.xrTable3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrTableRow3
        // 
        this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell15,
            this.xrTableCell16,
            this.xrTableCell17,
            this.xrTableCell18,
            this.xrTableCell19,
            this.tcUtilizationFG,
            this.tcUtilizationBE,
            this.tcUtilizationR});
        this.xrTableRow3.Dpi = 100F;
        this.xrTableRow3.Name = "xrTableRow3";
        this.xrTableRow3.Weight = 1D;
        // 
        // xrTableCell15
        // 
        this.xrTableCell15.Dpi = 100F;
        this.xrTableCell15.Name = "xrTableCell15";
        this.xrTableCell15.StylePriority.UseTextAlignment = false;
        this.xrTableCell15.Text = "Grand Total";
        this.xrTableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        this.xrTableCell15.Weight = 1.80000005664825D;
        // 
        // xrTableCell16
        // 
        this.xrTableCell16.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "InstituteList.SubSectorList.BudgetEstimate")});
        this.xrTableCell16.Dpi = 100F;
        this.xrTableCell16.Name = "xrTableCell16";
        xrSummary1.FormatString = "{0:#,#}";
        xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell16.Summary = xrSummary1;
        this.xrTableCell16.Weight = 0.599999881553653D;
        // 
        // xrTableCell17
        // 
        this.xrTableCell17.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "InstituteList.SubSectorList.FinalGrant")});
        this.xrTableCell17.Dpi = 100F;
        this.xrTableCell17.Name = "xrTableCell17";
        xrSummary2.FormatString = "{0:#,#}";
        xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell17.Summary = xrSummary2;
        this.xrTableCell17.Weight = 0.600000061798094D;
        // 
        // xrTableCell18
        // 
        this.xrTableCell18.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "InstituteList.SubSectorList.Release")});
        this.xrTableCell18.Dpi = 100F;
        this.xrTableCell18.Name = "xrTableCell18";
        xrSummary3.FormatString = "{0:#,#}";
        xrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell18.Summary = xrSummary3;
        this.xrTableCell18.Weight = 0.600000061798094D;
        // 
        // xrTableCell19
        // 
        this.xrTableCell19.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "InstituteList.SubSectorList.Expenditure")});
        this.xrTableCell19.Dpi = 100F;
        this.xrTableCell19.Name = "xrTableCell19";
        xrSummary4.FormatString = "{0:#,#}";
        xrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell19.Summary = xrSummary4;
        this.xrTableCell19.Weight = 0.600000061798094D;
        // 
        // tcUtilizationFG
        // 
        this.tcUtilizationFG.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "InstituteList.SubSectorList.UtilizationFG")});
        this.tcUtilizationFG.Dpi = 100F;
        this.tcUtilizationFG.Name = "tcUtilizationFG";
        xrSummary5.FormatString = "{0}";
        xrSummary5.Func = DevExpress.XtraReports.UI.SummaryFunc.Custom;
        xrSummary5.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.tcUtilizationFG.Summary = xrSummary5;
        this.tcUtilizationFG.Weight = 0.600000061798094D;
        this.tcUtilizationFG.SummaryGetResult += new DevExpress.XtraReports.UI.SummaryGetResultHandler(this.tcUtilizationFG_SummaryGetResult);
        this.tcUtilizationFG.SummaryReset += new System.EventHandler(this.tcUtilizationFG_SummaryReset);
        this.tcUtilizationFG.SummaryRowChanged += new System.EventHandler(this.tcUtilizationFG_SummaryRowChanged);
        // 
        // tcUtilizationBE
        // 
        this.tcUtilizationBE.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "InstituteList.SubSectorList.UtilizationBE")});
        this.tcUtilizationBE.Dpi = 100F;
        this.tcUtilizationBE.Name = "tcUtilizationBE";
        xrSummary6.FormatString = "{0}";
        xrSummary6.Func = DevExpress.XtraReports.UI.SummaryFunc.Custom;
        xrSummary6.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.tcUtilizationBE.Summary = xrSummary6;
        this.tcUtilizationBE.Weight = 0.600000061798094D;
        this.tcUtilizationBE.SummaryGetResult += new DevExpress.XtraReports.UI.SummaryGetResultHandler(this.tcUtilizationBE_SummaryGetResult);
        this.tcUtilizationBE.SummaryReset += new System.EventHandler(this.tcUtilizationBE_SummaryReset);
        this.tcUtilizationBE.SummaryRowChanged += new System.EventHandler(this.tcUtilizationBE_SummaryRowChanged);
        // 
        // prFinancialYear
        // 
        this.prFinancialYear.Description = "Financial Year";
        this.prFinancialYear.Name = "prFinancialYear";
        this.prFinancialYear.Visible = false;
        // 
        // headBudgetEstimation
        // 
        this.headBudgetEstimation.Expression = "Concat(\'Budget Estimate \', [Parameters.prFinancialYear])";
        this.headBudgetEstimation.FieldType = DevExpress.XtraReports.UI.FieldType.String;
        this.headBudgetEstimation.Name = "headBudgetEstimation";
        // 
        // FinalGrant
        // 
        this.FinalGrant.DataMember = "InstituteList.SubSectorList";
        this.FinalGrant.Expression = "[ADPAllocation] + [Supplementary] + [ReappPositive] - [ReappNegative] + [Excess] " +
"- [Surrender]";
        this.FinalGrant.Name = "FinalGrant";
        // 
        // UtilizationFG
        // 
        this.UtilizationFG.DataMember = "InstituteList.SubSectorList";
        this.UtilizationFG.Expression = "[Expenditure] / [FinalGrant]";
        this.UtilizationFG.Name = "UtilizationFG";
        // 
        // UtilizationBE
        // 
        this.UtilizationBE.DataMember = "InstituteList.SubSectorList";
        this.UtilizationBE.Expression = "[Expenditure] / [BudgetEstimate]";
        this.UtilizationBE.Name = "UtilizationBE";
        // 
        // PageFooter
        // 
        this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel9});
        this.PageFooter.Dpi = 100F;
        this.PageFooter.HeightF = 37.5F;
        this.PageFooter.Name = "PageFooter";
        // 
        // xrLabel9
        // 
        this.xrLabel9.Dpi = 100F;
        this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(475F, 12.5F);
        this.xrLabel9.Name = "xrLabel9";
        this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel9.SizeF = new System.Drawing.SizeF(424.9999F, 23F);
        this.xrLabel9.StylePriority.UseTextAlignment = false;
        this.xrLabel9.Text = System.Configuration.ConfigurationManager.AppSettings["FooterText"];
        this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrTableCell20
        // 
        this.xrTableCell20.Dpi = 100F;
        this.xrTableCell20.Multiline = true;
        this.xrTableCell20.Name = "xrTableCell20";
        this.xrTableCell20.Text = "%age\r\nUtilization / R";
        this.xrTableCell20.Weight = 1D;
        // 
        // xrTableCell21
        // 
        this.xrTableCell21.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "InstituteList.SubSectorList.UtilizationR", "{0:0.00%}")});
        this.xrTableCell21.Dpi = 100F;
        this.xrTableCell21.Name = "xrTableCell21";
        this.xrTableCell21.Weight = 0.600000061798094D;
        // 
        // tcUtilizationR
        // 
        this.tcUtilizationR.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "InstituteList.SubSectorList.UtilizationR")});
        this.tcUtilizationR.Dpi = 100F;
        this.tcUtilizationR.Name = "tcUtilizationR";
        xrSummary7.FormatString = "{0}";
        xrSummary7.Func = DevExpress.XtraReports.UI.SummaryFunc.Custom;
        xrSummary7.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.tcUtilizationR.Summary = xrSummary7;
        this.tcUtilizationR.Weight = 0.600000061798094D;
        this.tcUtilizationR.SummaryGetResult += new DevExpress.XtraReports.UI.SummaryGetResultHandler(this.tcUtilizationR_SummaryGetResult);
        this.tcUtilizationR.SummaryReset += new System.EventHandler(this.tcUtilizationR_SummaryReset);
        this.tcUtilizationR.SummaryRowChanged += new System.EventHandler(this.tcUtilizationR_SummaryRowChanged);
        // 
        // UtilizationR
        // 
        this.UtilizationR.DataMember = "InstituteList.SubSectorList";
        this.UtilizationR.Expression = "[Expenditure] / [Release]";
        this.UtilizationR.Name = "UtilizationR";
        // 
        // xrSectorSummaryReport
        // 
        this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.DetailReport,
            this.PageFooter});
        this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.headBudgetEstimation,
            this.FinalGrant,
            this.UtilizationFG,
            this.UtilizationBE,
            this.UtilizationR});
        this.DataMember = "InstituteList";
        this.DataSource = this.bindingSource1;
        this.Font = new System.Drawing.Font("Arial", 8.75F);
        this.Landscape = true;
        this.Margins = new System.Drawing.Printing.Margins(11, 14, 98, 100);
        this.PageHeight = 850;
        this.PageWidth = 1400;
        this.PaperKind = System.Drawing.Printing.PaperKind.Legal;
        this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.prFinancialYear});
        this.Version = "16.1";
        ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion

    double fgExpenditure = 0, fgFinalGrant = 0;

    private void tcUtilizationFG_SummaryReset(object sender, EventArgs e)
    {
        fgExpenditure = 0;
        fgFinalGrant = 0;
    }
    private void tcUtilizationFG_SummaryRowChanged(object sender, EventArgs e)
    {
        fgExpenditure += Convert.ToDouble(GetCurrentColumnValue("Expenditure"));
        fgFinalGrant += Convert.ToDouble(GetCurrentColumnValue("FinalGrant"));
    }
    private void tcUtilizationFG_SummaryGetResult(object sender, SummaryGetResultEventArgs e)
    {
        e.Result = fgFinalGrant == 0 ? "0.00%" : Math.Round(((fgExpenditure / fgFinalGrant) * 100), 2).ToString() + "%";
        e.Handled = true;
    }

    double beExpenditure = 0, beBudgetEstimate = 0;

    private void tcUtilizationBE_SummaryReset(object sender, EventArgs e)
    {
        beExpenditure = 0;
        beBudgetEstimate = 0;
    }
    private void tcUtilizationBE_SummaryRowChanged(object sender, EventArgs e)
    {
        beExpenditure += Convert.ToDouble(GetCurrentColumnValue("Expenditure"));
        beBudgetEstimate += Convert.ToDouble(GetCurrentColumnValue("BudgetEstimate"));
    }
    private void tcUtilizationBE_SummaryGetResult(object sender, SummaryGetResultEventArgs e)
    {
        e.Result = beBudgetEstimate == 0 ? "0.00%" : Math.Round(((beExpenditure / beBudgetEstimate) * 100), 2).ToString() + "%";
        e.Handled = true;
    }

    double rExpenditure = 0, rRelease = 0;

    private void tcUtilizationR_SummaryReset(object sender, EventArgs e)
    {
        rExpenditure = 0;
        rRelease = 0;
    }
    private void tcUtilizationR_SummaryRowChanged(object sender, EventArgs e)
    {
        rExpenditure += Convert.ToDouble(GetCurrentColumnValue("Expenditure"));
        rRelease += Convert.ToDouble(GetCurrentColumnValue("Release"));
    }
    private void tcUtilizationR_SummaryGetResult(object sender, SummaryGetResultEventArgs e)
    {
        e.Result = rRelease == 0 ? "0.00%" : Math.Round(((rExpenditure / rRelease) * 100), 2).ToString() + "%";
        e.Handled = true;
    }
}
