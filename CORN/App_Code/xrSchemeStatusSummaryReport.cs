using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

/// <summary>
/// Summary description for xrSchemeStatusSummaryReport
/// </summary>
public class xrSchemeStatusSummaryReport : DevExpress.XtraReports.UI.XtraReport
{
    private DevExpress.XtraReports.UI.DetailBand Detail;
    private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
    private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
    private System.Windows.Forms.BindingSource bindingSource1;
    private XRLabel xrLabel1;
    private XRTable xrTable1;
    private XRTableRow xrTableRow1;
    private XRTableCell xrTableCell1;
    private XRTableCell xrTableCell2;
    private XRTableCell xrTableCell3;
    private XRTableCell xrTableCell4;
    private XRTableCell xrTableCell5;
    private XRTableCell xrTableCell6;
    private XRTableCell xrTableCell7;
    private XRTableCell xrTableCell8;
    private XRTableCell xrTableCell9;
    private XRTableCell xrTableCell10;
    private XRTableCell xrTableCell11;
    private DevExpress.XtraReports.Parameters.Parameter prFinancialYear;
    private CalculatedField headBudgetEstimation;
    private CalculatedField FinalGrant;
    private CalculatedField UtilizationFG;
    private CalculatedField ExcessOrSurrender;
    private XRLabel xrLabel2;
    private XRTable xrTable2;
    private XRTableRow xrTableRow2;
    private XRTableCell xrTableCell12;
    private XRTableCell xrTableCell13;
    private XRTableCell xrTableCell14;
    private XRTableCell xrTableCell15;
    private XRTableCell xrTableCell16;
    private XRTableCell xrTableCell17;
    private XRTableCell xrTableCell18;
    private XRTableCell xrTableCell19;
    private XRTableCell xrTableCell20;
    private XRTableCell xrTableCell21;
    private XRTableCell xrTableCell22;
    private XRTable xrTable3;
    private XRTableRow xrTableRow3;
    private XRTableCell xrTableCell23;
    private XRTableCell xrTableCell24;
    private XRTableCell xrTableCell25;
    private XRTableCell xrTableCell26;
    private XRTableCell xrTableCell27;
    private XRTableCell xrTableCell28;
    private XRTableCell xrTableCell29;
    private XRTableCell xrTableCell30;
    private XRTableCell xrTableCell31;
    private XRTableCell xrTableCell32;
    private XRTableCell tcUtilization;
    private PageFooterBand PageFooter;
    private XRLabel xrLabel9;
    private GroupHeaderBand GroupHeader1;
    private GroupHeaderBand GroupHeader2;
    private XRTable xrTable4;
    private XRTableRow xrTableRow4;
    private XRTableCell xrTableCell33;
    private XRTableCell xrTableCell34;
    private XRTableCell xrTableCell35;
    private XRTableCell xrTableCell36;
    private XRTableCell xrTableCell37;
    private XRTableCell xrTableCell38;
    private XRTableCell xrTableCell39;
    private XRTableCell xrTableCell40;
    private XRTableCell xrTableCell41;
    private XRTableCell xrTableCell42;
    private XRTableCell gtcUtilization;
    private GroupFooterBand GroupFooter3;
    private GroupFooterBand GroupFooter1;
    private XRTableCell xrTableCell44;
    private XRTableCell xrTableCell43;
    private XRTableCell tcUtilizationR;
    private XRTableCell gtcUtilizationR;
    private CalculatedField UtilizationR;

    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public xrSchemeStatusSummaryReport()
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
        string resourceFileName = "xrSchemeStatusSummaryReport.resx";
        this.components = new System.ComponentModel.Container();
        DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary2 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary3 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary4 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary5 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary6 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary7 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary8 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary9 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary10 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary11 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary12 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary13 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary14 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary15 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary16 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary17 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary18 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary19 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary20 = new DevExpress.XtraReports.UI.XRSummary();
        this.Detail = new DevExpress.XtraReports.UI.DetailBand();
        this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell13 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell14 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell15 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell16 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell17 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell18 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell19 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell20 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell21 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell22 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell44 = new DevExpress.XtraReports.UI.XRTableCell();
        this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
        this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell43 = new DevExpress.XtraReports.UI.XRTableCell();
        this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
        this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
        this.prFinancialYear = new DevExpress.XtraReports.Parameters.Parameter();
        this.headBudgetEstimation = new DevExpress.XtraReports.UI.CalculatedField();
        this.FinalGrant = new DevExpress.XtraReports.UI.CalculatedField();
        this.UtilizationFG = new DevExpress.XtraReports.UI.CalculatedField();
        this.ExcessOrSurrender = new DevExpress.XtraReports.UI.CalculatedField();
        this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrTable3 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell23 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell24 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell25 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell26 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell27 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell28 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell29 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell30 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell31 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell32 = new DevExpress.XtraReports.UI.XRTableCell();
        this.tcUtilization = new DevExpress.XtraReports.UI.XRTableCell();
        this.tcUtilizationR = new DevExpress.XtraReports.UI.XRTableCell();
        this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
        this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
        this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
        this.GroupHeader2 = new DevExpress.XtraReports.UI.GroupHeaderBand();
        this.xrTable4 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell33 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell34 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell35 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell36 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell37 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell38 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell39 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell40 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell41 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell42 = new DevExpress.XtraReports.UI.XRTableCell();
        this.gtcUtilization = new DevExpress.XtraReports.UI.XRTableCell();
        this.gtcUtilizationR = new DevExpress.XtraReports.UI.XRTableCell();
        this.GroupFooter3 = new DevExpress.XtraReports.UI.GroupFooterBand();
        this.GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
        this.UtilizationR = new DevExpress.XtraReports.UI.CalculatedField();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable4)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
        // 
        // Detail
        // 
        this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable2});
        this.Detail.Dpi = 100F;
        this.Detail.HeightF = 25F;
        this.Detail.Name = "Detail";
        this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
        this.Detail.SortFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("FundId", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
        this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        // 
        // xrTable2
        // 
        this.xrTable2.BorderColor = System.Drawing.Color.LightGray;
        this.xrTable2.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTable2.Dpi = 100F;
        this.xrTable2.Font = new System.Drawing.Font("Arial", 8.75F);
        this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrTable2.Name = "xrTable2";
        this.xrTable2.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
        this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
        this.xrTable2.SizeF = new System.Drawing.SizeF(1478F, 25F);
        this.xrTable2.StylePriority.UseBorderColor = false;
        this.xrTable2.StylePriority.UseBorders = false;
        this.xrTable2.StylePriority.UseFont = false;
        this.xrTable2.StylePriority.UsePadding = false;
        this.xrTable2.StylePriority.UseTextAlignment = false;
        this.xrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrTableRow2
        // 
        this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell12,
            this.xrTableCell13,
            this.xrTableCell14,
            this.xrTableCell15,
            this.xrTableCell16,
            this.xrTableCell17,
            this.xrTableCell18,
            this.xrTableCell19,
            this.xrTableCell20,
            this.xrTableCell21,
            this.xrTableCell22,
            this.xrTableCell44});
        this.xrTableRow2.Dpi = 100F;
        this.xrTableRow2.Name = "xrTableRow2";
        this.xrTableRow2.Weight = 1D;
        // 
        // xrTableCell12
        // 
        this.xrTableCell12.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.CategoryTitle")});
        this.xrTableCell12.Dpi = 100F;
        this.xrTableCell12.Name = "xrTableCell12";
        this.xrTableCell12.StylePriority.UseTextAlignment = false;
        this.xrTableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        this.xrTableCell12.Weight = 1.65420012453208D;
        // 
        // xrTableCell13
        // 
        this.xrTableCell13.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.FundTitle")});
        this.xrTableCell13.Dpi = 100F;
        this.xrTableCell13.Name = "xrTableCell13";
        this.xrTableCell13.StylePriority.UseTextAlignment = false;
        this.xrTableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        this.xrTableCell13.Weight = 0.827100087697356D;
        // 
        // xrTableCell14
        // 
        this.xrTableCell14.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.BudgetEstimate", "{0:#,#}")});
        this.xrTableCell14.Dpi = 100F;
        this.xrTableCell14.Name = "xrTableCell14";
        this.xrTableCell14.Weight = 1.16760022914634D;
        // 
        // xrTableCell15
        // 
        this.xrTableCell15.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.Supplementary", "{0:#,#}")});
        this.xrTableCell15.Dpi = 100F;
        this.xrTableCell15.Name = "xrTableCell15";
        this.xrTableCell15.Weight = 1.16760022914634D;
        // 
        // xrTableCell16
        // 
        this.xrTableCell16.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ReappPositive", "{0:#,#}")});
        this.xrTableCell16.Dpi = 100F;
        this.xrTableCell16.Name = "xrTableCell16";
        this.xrTableCell16.Weight = 1.16760022914634D;
        // 
        // xrTableCell17
        // 
        this.xrTableCell17.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ReappNegative", "{0:#,#}")});
        this.xrTableCell17.Dpi = 100F;
        this.xrTableCell17.Name = "xrTableCell17";
        this.xrTableCell17.Weight = 1.16760022914634D;
        // 
        // xrTableCell18
        // 
        this.xrTableCell18.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ExcessOrSurrender", "{0:#,#}")});
        this.xrTableCell18.Dpi = 100F;
        this.xrTableCell18.Name = "xrTableCell18";
        this.xrTableCell18.Weight = 1.16760022914634D;
        // 
        // xrTableCell19
        // 
        this.xrTableCell19.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.FinalGrant", "{0:#,#}")});
        this.xrTableCell19.Dpi = 100F;
        this.xrTableCell19.Name = "xrTableCell19";
        this.xrTableCell19.Weight = 1.16760022914634D;
        // 
        // xrTableCell20
        // 
        this.xrTableCell20.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.Release", "{0:#,#}")});
        this.xrTableCell20.Dpi = 100F;
        this.xrTableCell20.Name = "xrTableCell20";
        this.xrTableCell20.Weight = 1.16760022914634D;
        // 
        // xrTableCell21
        // 
        this.xrTableCell21.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.Expenditure", "{0:#,#}")});
        this.xrTableCell21.Dpi = 100F;
        this.xrTableCell21.Name = "xrTableCell21";
        this.xrTableCell21.Weight = 1.16760022914634D;
        // 
        // xrTableCell22
        // 
        this.xrTableCell22.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.UtilizationFG", "{0:0.00%}")});
        this.xrTableCell22.Dpi = 100F;
        this.xrTableCell22.Name = "xrTableCell22";
        this.xrTableCell22.Weight = 1.16760022914634D;
        // 
        // xrTableCell44
        // 
        this.xrTableCell44.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.UtilizationR", "{0:0.00%}")});
        this.xrTableCell44.Dpi = 100F;
        this.xrTableCell44.Name = "xrTableCell44";
        this.xrTableCell44.Weight = 1.16760022914634D;
        // 
        // TopMargin
        // 
        this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1,
            this.xrTable1});
        this.TopMargin.Dpi = 100F;
        this.TopMargin.HeightF = 180F;
        this.TopMargin.Name = "TopMargin";
        this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
        this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        // 
        // xrLabel1
        // 
        this.xrLabel1.Dpi = 100F;
        this.xrLabel1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
        this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(487.5F, 25F);
        this.xrLabel1.Name = "xrLabel1";
        this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel1.SizeF = new System.Drawing.SizeF(504.375F, 48.95834F);
        this.xrLabel1.StylePriority.UseFont = false;
        this.xrLabel1.StylePriority.UseTextAlignment = false;
        this.xrLabel1.Text = "DEVELOPMENT PROJECTS SUMMARY";
        this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrTable1
        // 
        this.xrTable1.BackColor = System.Drawing.Color.LightGray;
        this.xrTable1.Dpi = 100F;
        this.xrTable1.Font = new System.Drawing.Font("Arial", 8.75F, System.Drawing.FontStyle.Bold);
        this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 125F);
        this.xrTable1.Name = "xrTable1";
        this.xrTable1.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
        this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
        this.xrTable1.SizeF = new System.Drawing.SizeF(1478F, 55F);
        this.xrTable1.StylePriority.UseBackColor = false;
        this.xrTable1.StylePriority.UseFont = false;
        this.xrTable1.StylePriority.UsePadding = false;
        this.xrTable1.StylePriority.UseTextAlignment = false;
        this.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrTableRow1
        // 
        this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell2,
            this.xrTableCell3,
            this.xrTableCell4,
            this.xrTableCell5,
            this.xrTableCell6,
            this.xrTableCell7,
            this.xrTableCell8,
            this.xrTableCell9,
            this.xrTableCell10,
            this.xrTableCell11,
            this.xrTableCell43});
        this.xrTableRow1.Dpi = 100F;
        this.xrTableRow1.Name = "xrTableRow1";
        this.xrTableRow1.Weight = 1D;
        // 
        // xrTableCell1
        // 
        this.xrTableCell1.Dpi = 100F;
        this.xrTableCell1.Name = "xrTableCell1";
        this.xrTableCell1.StylePriority.UseTextAlignment = false;
        this.xrTableCell1.Text = "On-Going/New";
        this.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        this.xrTableCell1.Weight = 1.4357771041472D;
        // 
        // xrTableCell2
        // 
        this.xrTableCell2.Dpi = 100F;
        this.xrTableCell2.Name = "xrTableCell2";
        this.xrTableCell2.StylePriority.UseTextAlignment = false;
        this.xrTableCell2.Text = "Fund";
        this.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        this.xrTableCell2.Weight = 0.717888505014286D;
        // 
        // xrTableCell3
        // 
        this.xrTableCell3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "headBudgetEstimation")});
        this.xrTableCell3.Dpi = 100F;
        this.xrTableCell3.Name = "xrTableCell3";
        this.xrTableCell3.Weight = 1.0134896638265D;
        // 
        // xrTableCell4
        // 
        this.xrTableCell4.Dpi = 100F;
        this.xrTableCell4.Name = "xrTableCell4";
        this.xrTableCell4.Text = "Supplementary";
        this.xrTableCell4.Weight = 1.0134896638265D;
        // 
        // xrTableCell5
        // 
        this.xrTableCell5.Dpi = 100F;
        this.xrTableCell5.Name = "xrTableCell5";
        this.xrTableCell5.Text = " Reapp (+)";
        this.xrTableCell5.Weight = 1.0134896638265D;
        // 
        // xrTableCell6
        // 
        this.xrTableCell6.Dpi = 100F;
        this.xrTableCell6.Name = "xrTableCell6";
        this.xrTableCell6.Text = " Reapp (-)";
        this.xrTableCell6.Weight = 1.0134896638265D;
        // 
        // xrTableCell7
        // 
        this.xrTableCell7.Dpi = 100F;
        this.xrTableCell7.Name = "xrTableCell7";
        this.xrTableCell7.Text = "Excess / Surrender";
        this.xrTableCell7.Weight = 1.0134896638265D;
        // 
        // xrTableCell8
        // 
        this.xrTableCell8.Dpi = 100F;
        this.xrTableCell8.Name = "xrTableCell8";
        this.xrTableCell8.Text = " Final Grant";
        this.xrTableCell8.Weight = 1.0134896638265D;
        // 
        // xrTableCell9
        // 
        this.xrTableCell9.Dpi = 100F;
        this.xrTableCell9.Name = "xrTableCell9";
        this.xrTableCell9.Text = "Release";
        this.xrTableCell9.Weight = 1.0134896638265D;
        // 
        // xrTableCell10
        // 
        this.xrTableCell10.Dpi = 100F;
        this.xrTableCell10.Name = "xrTableCell10";
        this.xrTableCell10.Text = "Expenditure";
        this.xrTableCell10.Weight = 1.0134896638265D;
        // 
        // xrTableCell11
        // 
        this.xrTableCell11.Dpi = 100F;
        this.xrTableCell11.Multiline = true;
        this.xrTableCell11.Name = "xrTableCell11";
        this.xrTableCell11.Text = "%age\r\nUtilization / FG";
        this.xrTableCell11.Weight = 1.0134896638265D;
        // 
        // xrTableCell43
        // 
        this.xrTableCell43.Dpi = 100F;
        this.xrTableCell43.Multiline = true;
        this.xrTableCell43.Name = "xrTableCell43";
        this.xrTableCell43.Text = "%age\r\nUtilization / R";
        this.xrTableCell43.Weight = 1.0134896638265D;
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
        this.FinalGrant.DataMember = "SchemeList";
        this.FinalGrant.Expression = "[ADPAllocation] + [Supplementary] + [ReappPositive] - [ReappNegative] + [Excess] " +
"- [Surrender]";
        this.FinalGrant.Name = "FinalGrant";
        // 
        // UtilizationFG
        // 
        this.UtilizationFG.DataMember = "SchemeList";
        this.UtilizationFG.Expression = "[Expenditure] / [FinalGrant]";
        this.UtilizationFG.Name = "UtilizationFG";
        // 
        // ExcessOrSurrender
        // 
        this.ExcessOrSurrender.DataMember = "SchemeList";
        this.ExcessOrSurrender.Expression = "[Excess] - [Surrender]";
        this.ExcessOrSurrender.Name = "ExcessOrSurrender";
        // 
        // xrLabel2
        // 
        this.xrLabel2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.InstitutionTitle")});
        this.xrLabel2.Dpi = 100F;
        this.xrLabel2.Font = new System.Drawing.Font("Arial", 14.75F, System.Drawing.FontStyle.Bold);
        this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(87.5F, 0F);
        this.xrLabel2.Name = "xrLabel2";
        this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel2.SizeF = new System.Drawing.SizeF(1299F, 32F);
        this.xrLabel2.StylePriority.UseFont = false;
        this.xrLabel2.StylePriority.UseTextAlignment = false;
        this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
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
        this.xrTable3.SizeF = new System.Drawing.SizeF(1478F, 25F);
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
            this.xrTableCell23,
            this.xrTableCell24,
            this.xrTableCell25,
            this.xrTableCell26,
            this.xrTableCell27,
            this.xrTableCell28,
            this.xrTableCell29,
            this.xrTableCell30,
            this.xrTableCell31,
            this.xrTableCell32,
            this.tcUtilization,
            this.tcUtilizationR});
        this.xrTableRow3.Dpi = 100F;
        this.xrTableRow3.Name = "xrTableRow3";
        this.xrTableRow3.Weight = 1D;
        // 
        // xrTableCell23
        // 
        this.xrTableCell23.Dpi = 100F;
        this.xrTableCell23.Name = "xrTableCell23";
        this.xrTableCell23.StylePriority.UseTextAlignment = false;
        this.xrTableCell23.Text = "Total";
        this.xrTableCell23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        this.xrTableCell23.Weight = 1.65420012453208D;
        // 
        // xrTableCell24
        // 
        this.xrTableCell24.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell24.Dpi = 100F;
        this.xrTableCell24.Name = "xrTableCell24";
        this.xrTableCell24.StylePriority.UseBorders = false;
        this.xrTableCell24.StylePriority.UseTextAlignment = false;
        this.xrTableCell24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        this.xrTableCell24.Weight = 0.827100087697356D;
        // 
        // xrTableCell25
        // 
        this.xrTableCell25.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.BudgetEstimate")});
        this.xrTableCell25.Dpi = 100F;
        this.xrTableCell25.Name = "xrTableCell25";
        xrSummary1.FormatString = "{0:#,#}";
        xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell25.Summary = xrSummary1;
        this.xrTableCell25.Weight = 1.16760022914634D;
        // 
        // xrTableCell26
        // 
        this.xrTableCell26.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.Supplementary")});
        this.xrTableCell26.Dpi = 100F;
        this.xrTableCell26.Name = "xrTableCell26";
        xrSummary2.FormatString = "{0:#,#}";
        xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell26.Summary = xrSummary2;
        this.xrTableCell26.Weight = 1.16760022914634D;
        // 
        // xrTableCell27
        // 
        this.xrTableCell27.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ReappPositive")});
        this.xrTableCell27.Dpi = 100F;
        this.xrTableCell27.Name = "xrTableCell27";
        xrSummary3.FormatString = "{0:#,#}";
        xrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell27.Summary = xrSummary3;
        this.xrTableCell27.Weight = 1.16760022914634D;
        // 
        // xrTableCell28
        // 
        this.xrTableCell28.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ReappNegative")});
        this.xrTableCell28.Dpi = 100F;
        this.xrTableCell28.Name = "xrTableCell28";
        xrSummary4.FormatString = "{0:#,#}";
        xrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell28.Summary = xrSummary4;
        this.xrTableCell28.Weight = 1.16760022914634D;
        // 
        // xrTableCell29
        // 
        this.xrTableCell29.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ExcessOrSurrender")});
        this.xrTableCell29.Dpi = 100F;
        this.xrTableCell29.Name = "xrTableCell29";
        xrSummary5.FormatString = "{0:#,#}";
        xrSummary5.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell29.Summary = xrSummary5;
        this.xrTableCell29.Weight = 1.16760022914634D;
        // 
        // xrTableCell30
        // 
        this.xrTableCell30.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.FinalGrant")});
        this.xrTableCell30.Dpi = 100F;
        this.xrTableCell30.Name = "xrTableCell30";
        xrSummary6.FormatString = "{0:#,#}";
        xrSummary6.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell30.Summary = xrSummary6;
        this.xrTableCell30.Weight = 1.16760022914634D;
        // 
        // xrTableCell31
        // 
        this.xrTableCell31.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.Release")});
        this.xrTableCell31.Dpi = 100F;
        this.xrTableCell31.Name = "xrTableCell31";
        xrSummary7.FormatString = "{0:#,#}";
        xrSummary7.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell31.Summary = xrSummary7;
        this.xrTableCell31.Weight = 1.16760022914634D;
        // 
        // xrTableCell32
        // 
        this.xrTableCell32.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.Expenditure")});
        this.xrTableCell32.Dpi = 100F;
        this.xrTableCell32.Name = "xrTableCell32";
        xrSummary8.FormatString = "{0:#,#}";
        xrSummary8.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell32.Summary = xrSummary8;
        this.xrTableCell32.Weight = 1.16760022914634D;
        // 
        // tcUtilization
        // 
        this.tcUtilization.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.UtilizationFG")});
        this.tcUtilization.Dpi = 100F;
        this.tcUtilization.Name = "tcUtilization";
        xrSummary9.FormatString = "{0}";
        xrSummary9.Func = DevExpress.XtraReports.UI.SummaryFunc.Custom;
        xrSummary9.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.tcUtilization.Summary = xrSummary9;
        this.tcUtilization.Weight = 1.16760022914634D;
        this.tcUtilization.SummaryGetResult += new DevExpress.XtraReports.UI.SummaryGetResultHandler(this.tcUtilization_SummaryGetResult);
        this.tcUtilization.SummaryReset += new System.EventHandler(this.tcUtilization_SummaryReset);
        this.tcUtilization.SummaryRowChanged += new System.EventHandler(this.tcUtilization_SummaryRowChanged);
        // 
        // tcUtilizationR
        // 
        this.tcUtilizationR.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.UtilizationR")});
        this.tcUtilizationR.Dpi = 100F;
        this.tcUtilizationR.Name = "tcUtilizationR";
        xrSummary10.FormatString = "{0}";
        xrSummary10.Func = DevExpress.XtraReports.UI.SummaryFunc.Custom;
        xrSummary10.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.tcUtilizationR.Summary = xrSummary10;
        this.tcUtilizationR.Weight = 1.16760022914634D;
        this.tcUtilizationR.SummaryGetResult += new DevExpress.XtraReports.UI.SummaryGetResultHandler(this.tcUtilizationR_SummaryGetResult);
        this.tcUtilizationR.SummaryReset += new System.EventHandler(this.tcUtilizationR_SummaryReset);
        this.tcUtilizationR.SummaryRowChanged += new System.EventHandler(this.tcUtilizationR_SummaryRowChanged);
        // 
        // PageFooter
        // 
        this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel9});
        this.PageFooter.Dpi = 100F;
        this.PageFooter.HeightF = 35.5F;
        this.PageFooter.Name = "PageFooter";
        // 
        // xrLabel9
        // 
        this.xrLabel9.Dpi = 100F;
        this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(525F, 12.5F);
        this.xrLabel9.Name = "xrLabel9";
        this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel9.SizeF = new System.Drawing.SizeF(424.9999F, 23F);
        this.xrLabel9.StylePriority.UseTextAlignment = false;
        this.xrLabel9.Text = System.Configuration.ConfigurationManager.AppSettings["FooterText"];
        this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // GroupHeader1
        // 
        this.GroupHeader1.Dpi = 100F;
        this.GroupHeader1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("CategoryId", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
        this.GroupHeader1.HeightF = 0F;
        this.GroupHeader1.Name = "GroupHeader1";
        // 
        // GroupHeader2
        // 
        this.GroupHeader2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel2});
        this.GroupHeader2.Dpi = 100F;
        this.GroupHeader2.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("InstitutionTitle", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
        this.GroupHeader2.HeightF = 32F;
        this.GroupHeader2.Level = 1;
        this.GroupHeader2.Name = "GroupHeader2";
        // 
        // xrTable4
        // 
        this.xrTable4.BorderColor = System.Drawing.Color.LightGray;
        this.xrTable4.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTable4.Dpi = 100F;
        this.xrTable4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
        this.xrTable4.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrTable4.Name = "xrTable4";
        this.xrTable4.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
        this.xrTable4.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow4});
        this.xrTable4.SizeF = new System.Drawing.SizeF(1478F, 25F);
        this.xrTable4.StylePriority.UseBorderColor = false;
        this.xrTable4.StylePriority.UseBorders = false;
        this.xrTable4.StylePriority.UseFont = false;
        this.xrTable4.StylePriority.UsePadding = false;
        this.xrTable4.StylePriority.UseTextAlignment = false;
        this.xrTable4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrTableRow4
        // 
        this.xrTableRow4.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell33,
            this.xrTableCell34,
            this.xrTableCell35,
            this.xrTableCell36,
            this.xrTableCell37,
            this.xrTableCell38,
            this.xrTableCell39,
            this.xrTableCell40,
            this.xrTableCell41,
            this.xrTableCell42,
            this.gtcUtilization,
            this.gtcUtilizationR});
        this.xrTableRow4.Dpi = 100F;
        this.xrTableRow4.Name = "xrTableRow4";
        this.xrTableRow4.Weight = 1D;
        // 
        // xrTableCell33
        // 
        this.xrTableCell33.Dpi = 100F;
        this.xrTableCell33.Name = "xrTableCell33";
        this.xrTableCell33.StylePriority.UseTextAlignment = false;
        this.xrTableCell33.Text = "Grand Total";
        this.xrTableCell33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        this.xrTableCell33.Weight = 1.65420012453208D;
        // 
        // xrTableCell34
        // 
        this.xrTableCell34.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell34.Dpi = 100F;
        this.xrTableCell34.Name = "xrTableCell34";
        this.xrTableCell34.StylePriority.UseBorders = false;
        this.xrTableCell34.StylePriority.UseTextAlignment = false;
        this.xrTableCell34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        this.xrTableCell34.Weight = 0.827100087697356D;
        // 
        // xrTableCell35
        // 
        this.xrTableCell35.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.BudgetEstimate")});
        this.xrTableCell35.Dpi = 100F;
        this.xrTableCell35.Name = "xrTableCell35";
        xrSummary11.FormatString = "{0:#,#}";
        xrSummary11.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell35.Summary = xrSummary11;
        this.xrTableCell35.Weight = 1.16760022914634D;
        // 
        // xrTableCell36
        // 
        this.xrTableCell36.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.Supplementary")});
        this.xrTableCell36.Dpi = 100F;
        this.xrTableCell36.Name = "xrTableCell36";
        xrSummary12.FormatString = "{0:#,#}";
        xrSummary12.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell36.Summary = xrSummary12;
        this.xrTableCell36.Weight = 1.16760022914634D;
        // 
        // xrTableCell37
        // 
        this.xrTableCell37.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ReappPositive")});
        this.xrTableCell37.Dpi = 100F;
        this.xrTableCell37.Name = "xrTableCell37";
        xrSummary13.FormatString = "{0:#,#}";
        xrSummary13.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell37.Summary = xrSummary13;
        this.xrTableCell37.Weight = 1.16760022914634D;
        // 
        // xrTableCell38
        // 
        this.xrTableCell38.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ReappNegative")});
        this.xrTableCell38.Dpi = 100F;
        this.xrTableCell38.Name = "xrTableCell38";
        xrSummary14.FormatString = "{0:#,#}";
        xrSummary14.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell38.Summary = xrSummary14;
        this.xrTableCell38.Weight = 1.16760022914634D;
        // 
        // xrTableCell39
        // 
        this.xrTableCell39.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ExcessOrSurrender")});
        this.xrTableCell39.Dpi = 100F;
        this.xrTableCell39.Name = "xrTableCell39";
        xrSummary15.FormatString = "{0:#,#}";
        xrSummary15.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell39.Summary = xrSummary15;
        this.xrTableCell39.Weight = 1.16760022914634D;
        // 
        // xrTableCell40
        // 
        this.xrTableCell40.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.FinalGrant")});
        this.xrTableCell40.Dpi = 100F;
        this.xrTableCell40.Name = "xrTableCell40";
        xrSummary16.FormatString = "{0:#,#}";
        xrSummary16.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell40.Summary = xrSummary16;
        this.xrTableCell40.Weight = 1.16760022914634D;
        // 
        // xrTableCell41
        // 
        this.xrTableCell41.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.Release")});
        this.xrTableCell41.Dpi = 100F;
        this.xrTableCell41.Name = "xrTableCell41";
        xrSummary17.FormatString = "{0:#,#}";
        xrSummary17.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell41.Summary = xrSummary17;
        this.xrTableCell41.Weight = 1.16760022914634D;
        // 
        // xrTableCell42
        // 
        this.xrTableCell42.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.Expenditure")});
        this.xrTableCell42.Dpi = 100F;
        this.xrTableCell42.Name = "xrTableCell42";
        xrSummary18.FormatString = "{0:#,#}";
        xrSummary18.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell42.Summary = xrSummary18;
        this.xrTableCell42.Weight = 1.16760022914634D;
        // 
        // gtcUtilization
        // 
        this.gtcUtilization.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.UtilizationFG")});
        this.gtcUtilization.Dpi = 100F;
        this.gtcUtilization.Name = "gtcUtilization";
        xrSummary19.FormatString = "{0}";
        xrSummary19.Func = DevExpress.XtraReports.UI.SummaryFunc.Custom;
        xrSummary19.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.gtcUtilization.Summary = xrSummary19;
        this.gtcUtilization.Weight = 1.16760022914634D;
        this.gtcUtilization.SummaryGetResult += new DevExpress.XtraReports.UI.SummaryGetResultHandler(this.gtcUtilization_SummaryGetResult);
        this.gtcUtilization.SummaryReset += new System.EventHandler(this.gtcUtilization_SummaryReset);
        this.gtcUtilization.SummaryRowChanged += new System.EventHandler(this.gtcUtilization_SummaryRowChanged);
        // 
        // gtcUtilizationR
        // 
        this.gtcUtilizationR.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.UtilizationR")});
        this.gtcUtilizationR.Dpi = 100F;
        this.gtcUtilizationR.Name = "gtcUtilizationR";
        xrSummary20.FormatString = "{0}";
        xrSummary20.Func = DevExpress.XtraReports.UI.SummaryFunc.Custom;
        xrSummary20.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.gtcUtilizationR.Summary = xrSummary20;
        this.gtcUtilizationR.Weight = 1.16760022914634D;
        this.gtcUtilizationR.SummaryGetResult += new DevExpress.XtraReports.UI.SummaryGetResultHandler(this.gtcUtilizationR_SummaryGetResult);
        this.gtcUtilizationR.SummaryReset += new System.EventHandler(this.gtcUtilizationR_SummaryReset);
        this.gtcUtilizationR.SummaryRowChanged += new System.EventHandler(this.gtcUtilizationR_SummaryRowChanged);
        // 
        // GroupFooter3
        // 
        this.GroupFooter3.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable3});
        this.GroupFooter3.Dpi = 100F;
        this.GroupFooter3.HeightF = 25F;
        this.GroupFooter3.Name = "GroupFooter3";
        // 
        // GroupFooter1
        // 
        this.GroupFooter1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable4});
        this.GroupFooter1.Dpi = 100F;
        this.GroupFooter1.HeightF = 25F;
        this.GroupFooter1.Level = 1;
        this.GroupFooter1.Name = "GroupFooter1";
        // 
        // UtilizationR
        // 
        this.UtilizationR.DataMember = "SchemeList";
        this.UtilizationR.Expression = "[Expenditure] / [Release]";
        this.UtilizationR.Name = "UtilizationR";
        // 
        // xrSchemeStatusSummaryReport
        // 
        this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.PageFooter,
            this.GroupHeader1,
            this.GroupHeader2,
            this.GroupFooter3,
            this.GroupFooter1});
        this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.headBudgetEstimation,
            this.FinalGrant,
            this.UtilizationFG,
            this.UtilizationR,
            this.ExcessOrSurrender});
        this.DataMember = "SchemeList";
        this.DataSource = this.bindingSource1;
        this.Font = new System.Drawing.Font("Arial", 9.75F);
        this.Landscape = true;
        this.Margins = new System.Drawing.Printing.Margins(10, 12, 180, 100);
        this.PageHeight = 927;
        this.PageWidth = 1500;
        this.PaperKind = System.Drawing.Printing.PaperKind.LegalExtra;
        this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.prFinancialYear});
        this.Version = "16.1";
        ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable4)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion

    double fgExpenditure = 0, fgFinalGrant = 0;

    private void tcUtilization_SummaryReset(object sender, EventArgs e)
    {
        fgExpenditure = 0;
        fgFinalGrant = 0;
    }
    private void tcUtilization_SummaryRowChanged(object sender, EventArgs e)
    {
        fgExpenditure += Convert.ToDouble(GetCurrentColumnValue("Expenditure"));
        fgFinalGrant += Convert.ToDouble(GetCurrentColumnValue("FinalGrant"));
    }
    private void tcUtilization_SummaryGetResult(object sender, SummaryGetResultEventArgs e)
    {
        e.Result = fgFinalGrant == 0 ? "0.00%" : Math.Round(((fgExpenditure / fgFinalGrant) * 100), 2).ToString() + "%";
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

    double gfgExpenditure = 0, gfgFinalGrant = 0;

    private void gtcUtilization_SummaryReset(object sender, EventArgs e)
    {
        gfgExpenditure = 0;
        gfgFinalGrant = 0;
    }
    private void gtcUtilization_SummaryRowChanged(object sender, EventArgs e)
    {
        gfgExpenditure += Convert.ToDouble(GetCurrentColumnValue("Expenditure"));
        gfgFinalGrant += Convert.ToDouble(GetCurrentColumnValue("FinalGrant"));
    }
    private void gtcUtilization_SummaryGetResult(object sender, SummaryGetResultEventArgs e)
    {
        e.Result = gfgFinalGrant == 0 ? "0.00%" : Math.Round(((gfgExpenditure / gfgFinalGrant) * 100), 2).ToString() + "%";
        e.Handled = true;
    }

    double grExpenditure = 0, grRelease = 0;

    private void gtcUtilizationR_SummaryReset(object sender, EventArgs e)
    {
        grExpenditure = 0;
        grRelease = 0;
    }
    private void gtcUtilizationR_SummaryRowChanged(object sender, EventArgs e)
    {
        grExpenditure += Convert.ToDouble(GetCurrentColumnValue("Expenditure"));
        grRelease += Convert.ToDouble(GetCurrentColumnValue("Release"));
    }
    private void gtcUtilizationR_SummaryGetResult(object sender, SummaryGetResultEventArgs e)
    {
        e.Result = grRelease == 0 ? "0.00%" : Math.Round(((grExpenditure / grRelease) * 100), 2).ToString() + "%";
        e.Handled = true;
    }
}
