using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

/// <summary>
/// Summary description for xrFundWiseReport
/// </summary>
public class xrFundWiseReport : DevExpress.XtraReports.UI.XtraReport
{
    private DevExpress.XtraReports.UI.DetailBand Detail;
    private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
    private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
    private XRTable xrTable1;
    private XRTableRow xrTableRow1;
    private XRTableCell xrTableCell1;
    private XRTableCell xrTableCell2;
    private XRTableCell xrTableCell3;
    private XRTableCell xrTableCell4;
    private XRTableCell xrTableCell5;
    private XRTableCell xrTableCell6;
    private XRTableCell xrTableCell7;
    private XRTableCell xrTableCell9;
    private XRTableCell xrTableCell10;
    private XRTableCell xrTableCell11;
    private XRLabel xrLabel2;
    private XRLabel xrLabel1;
    private XRTable xrTable2;
    private XRTableRow xrTableRow2;
    private XRTableCell xrTableCell12;
    private XRTableCell xrTableCell13;
    private XRTableCell xrTableCell14;
    private XRTableCell xrTableCell15;
    private XRTableCell xrTableCell16;
    private XRTableCell xrTableCell17;
    private XRTableCell xrTableCell18;
    private XRTableCell xrTableCell20;
    private XRTableCell xrTableCell21;
    private XRTableCell xrTableCell22;
    private System.Windows.Forms.BindingSource bindingSource1;
    private DevExpress.XtraReports.Parameters.Parameter prFinancialYear;
    private CalculatedField UtilizationFG;
    private CalculatedField UtilizationBE;
    private CalculatedField headBudgetEstimation;
    private XRTable xrTable3;
    private XRTableRow xrTableRow3;
    private XRTableCell xrTableCell23;
    private XRTableCell xrTableCell24;
    private XRTableCell xrTableCell25;
    private XRTableCell xrTableCell26;
    private XRTableCell xrTableCell27;
    private XRTableCell xrTableCell28;
    private XRTableCell xrTableCell29;
    private XRTableCell xrTableCell31;
    private XRTableCell tcUtilizationFG;
    private XRTableCell tcUtilizationBE;
    private GroupHeaderBand GroupHeader1;
    private GroupFooterBand GroupFooter1;
    private XRTableCell xrTableCell19;
    private XRTableCell xrTableCell8;
    private XRTableCell xrTableCell30;
    private CalculatedField ExcessOrSurrender;
    private CalculatedField FinalGrant;
    private PageFooterBand PageFooter;
    private XRLabel xrLabel3;
    private XRTableCell xrTableCell33;
    private XRTableCell xrTableCell32;
    private XRTableCell tcUtilizationBR;
    private CalculatedField UtilizationR;

    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public xrFundWiseReport()
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
        string resourceFileName = "xrFundWiseReport.resx";
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
        this.xrTableCell33 = new DevExpress.XtraReports.UI.XRTableCell();
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
        this.xrTableCell32 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
        this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
        this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
        this.prFinancialYear = new DevExpress.XtraReports.Parameters.Parameter();
        this.UtilizationFG = new DevExpress.XtraReports.UI.CalculatedField();
        this.UtilizationBE = new DevExpress.XtraReports.UI.CalculatedField();
        this.headBudgetEstimation = new DevExpress.XtraReports.UI.CalculatedField();
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
        this.tcUtilizationFG = new DevExpress.XtraReports.UI.XRTableCell();
        this.tcUtilizationBE = new DevExpress.XtraReports.UI.XRTableCell();
        this.tcUtilizationBR = new DevExpress.XtraReports.UI.XRTableCell();
        this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
        this.GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
        this.ExcessOrSurrender = new DevExpress.XtraReports.UI.CalculatedField();
        this.FinalGrant = new DevExpress.XtraReports.UI.CalculatedField();
        this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
        this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
        this.UtilizationR = new DevExpress.XtraReports.UI.CalculatedField();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
        // 
        // Detail
        // 
        this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable2});
        this.Detail.Dpi = 100F;
        this.Detail.HeightF = 28F;
        this.Detail.Name = "Detail";
        this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
        this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        // 
        // xrTable2
        // 
        this.xrTable2.BackColor = System.Drawing.Color.Empty;
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
        this.xrTable2.SizeF = new System.Drawing.SizeF(1480F, 28F);
        this.xrTable2.StylePriority.UseBackColor = false;
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
            this.xrTableCell33});
        this.xrTableRow2.Dpi = 100F;
        this.xrTableRow2.Name = "xrTableRow2";
        this.xrTableRow2.Weight = 1D;
        // 
        // xrTableCell12
        // 
        this.xrTableCell12.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.FundTitle")});
        this.xrTableCell12.Dpi = 100F;
        this.xrTableCell12.Name = "xrTableCell12";
        this.xrTableCell12.StylePriority.UseTextAlignment = false;
        this.xrTableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        this.xrTableCell12.Weight = 1D;
        // 
        // xrTableCell13
        // 
        this.xrTableCell13.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.BudgetEstimate", "{0:#,#}")});
        this.xrTableCell13.Dpi = 100F;
        this.xrTableCell13.Name = "xrTableCell13";
        this.xrTableCell13.Weight = 1D;
        // 
        // xrTableCell14
        // 
        this.xrTableCell14.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.Supplementary", "{0:#,#}")});
        this.xrTableCell14.Dpi = 100F;
        this.xrTableCell14.Name = "xrTableCell14";
        this.xrTableCell14.Weight = 1D;
        // 
        // xrTableCell15
        // 
        this.xrTableCell15.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ReappPositive", "{0:#,#}")});
        this.xrTableCell15.Dpi = 100F;
        this.xrTableCell15.Name = "xrTableCell15";
        this.xrTableCell15.Weight = 1D;
        // 
        // xrTableCell16
        // 
        this.xrTableCell16.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ReappNegative", "{0:#,#}")});
        this.xrTableCell16.Dpi = 100F;
        this.xrTableCell16.Name = "xrTableCell16";
        this.xrTableCell16.Weight = 1D;
        // 
        // xrTableCell17
        // 
        this.xrTableCell17.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ExcessOrSurrender", "{0:#,#}")});
        this.xrTableCell17.Dpi = 100F;
        this.xrTableCell17.Name = "xrTableCell17";
        this.xrTableCell17.Weight = 1D;
        // 
        // xrTableCell18
        // 
        this.xrTableCell18.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.FinalGrant", "{0:#,#}")});
        this.xrTableCell18.Dpi = 100F;
        this.xrTableCell18.Name = "xrTableCell18";
        this.xrTableCell18.Weight = 1D;
        // 
        // xrTableCell19
        // 
        this.xrTableCell19.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.Release", "{0:#,#}")});
        this.xrTableCell19.Dpi = 100F;
        this.xrTableCell19.Name = "xrTableCell19";
        this.xrTableCell19.Weight = 1D;
        // 
        // xrTableCell20
        // 
        this.xrTableCell20.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.Expenditure", "{0:#,#}")});
        this.xrTableCell20.Dpi = 100F;
        this.xrTableCell20.Name = "xrTableCell20";
        this.xrTableCell20.Weight = 1D;
        // 
        // xrTableCell21
        // 
        this.xrTableCell21.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.UtilizationFG", "{0:0.00%}")});
        this.xrTableCell21.Dpi = 100F;
        this.xrTableCell21.Multiline = true;
        this.xrTableCell21.Name = "xrTableCell21";
        this.xrTableCell21.Weight = 1D;
        // 
        // xrTableCell22
        // 
        this.xrTableCell22.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.UtilizationBE", "{0:0.00%}")});
        this.xrTableCell22.Dpi = 100F;
        this.xrTableCell22.Multiline = true;
        this.xrTableCell22.Name = "xrTableCell22";
        this.xrTableCell22.Weight = 1D;
        // 
        // xrTableCell33
        // 
        this.xrTableCell33.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.UtilizationR", "{0:0.00%}")});
        this.xrTableCell33.Dpi = 100F;
        this.xrTableCell33.Name = "xrTableCell33";
        this.xrTableCell33.Weight = 1D;
        // 
        // TopMargin
        // 
        this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1,
            this.xrTable1});
        this.TopMargin.Dpi = 100F;
        this.TopMargin.HeightF = 185F;
        this.TopMargin.Name = "TopMargin";
        this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
        this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        // 
        // xrLabel1
        // 
        this.xrLabel1.Dpi = 100F;
        this.xrLabel1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
        this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(400F, 25F);
        this.xrLabel1.Name = "xrLabel1";
        this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel1.SizeF = new System.Drawing.SizeF(670F, 48.95834F);
        this.xrLabel1.StylePriority.UseFont = false;
        this.xrLabel1.StylePriority.UseTextAlignment = false;
        this.xrLabel1.Text = "FUND WISE DEVELOPMENT PROJECTS SUMMARY";
        this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrTable1
        // 
        this.xrTable1.BackColor = System.Drawing.Color.LightGray;
        this.xrTable1.Dpi = 100F;
        this.xrTable1.Font = new System.Drawing.Font("Arial", 8.75F, System.Drawing.FontStyle.Bold);
        this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 130F);
        this.xrTable1.Name = "xrTable1";
        this.xrTable1.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
        this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
        this.xrTable1.SizeF = new System.Drawing.SizeF(1480F, 55F);
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
            this.xrTableCell32});
        this.xrTableRow1.Dpi = 100F;
        this.xrTableRow1.Name = "xrTableRow1";
        this.xrTableRow1.Weight = 1D;
        // 
        // xrTableCell1
        // 
        this.xrTableCell1.Dpi = 100F;
        this.xrTableCell1.Name = "xrTableCell1";
        this.xrTableCell1.StylePriority.UseTextAlignment = false;
        this.xrTableCell1.Text = "Fund";
        this.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        this.xrTableCell1.Weight = 1D;
        // 
        // xrTableCell2
        // 
        this.xrTableCell2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "headBudgetEstimation")});
        this.xrTableCell2.Dpi = 100F;
        this.xrTableCell2.Name = "xrTableCell2";
        this.xrTableCell2.Weight = 1D;
        // 
        // xrTableCell3
        // 
        this.xrTableCell3.Dpi = 100F;
        this.xrTableCell3.Name = "xrTableCell3";
        this.xrTableCell3.Text = "Supplementary";
        this.xrTableCell3.Weight = 1D;
        // 
        // xrTableCell4
        // 
        this.xrTableCell4.Dpi = 100F;
        this.xrTableCell4.Name = "xrTableCell4";
        this.xrTableCell4.Text = "Reapp (+)";
        this.xrTableCell4.Weight = 1D;
        // 
        // xrTableCell5
        // 
        this.xrTableCell5.Dpi = 100F;
        this.xrTableCell5.Name = "xrTableCell5";
        this.xrTableCell5.Text = "Reapp (-)";
        this.xrTableCell5.Weight = 1D;
        // 
        // xrTableCell6
        // 
        this.xrTableCell6.Dpi = 100F;
        this.xrTableCell6.Name = "xrTableCell6";
        this.xrTableCell6.Text = "Excess / Surrender";
        this.xrTableCell6.Weight = 1D;
        // 
        // xrTableCell7
        // 
        this.xrTableCell7.Dpi = 100F;
        this.xrTableCell7.Name = "xrTableCell7";
        this.xrTableCell7.Text = "Final Grant";
        this.xrTableCell7.Weight = 1D;
        // 
        // xrTableCell8
        // 
        this.xrTableCell8.Dpi = 100F;
        this.xrTableCell8.Name = "xrTableCell8";
        this.xrTableCell8.Text = "Release";
        this.xrTableCell8.Weight = 1D;
        // 
        // xrTableCell9
        // 
        this.xrTableCell9.Dpi = 100F;
        this.xrTableCell9.Name = "xrTableCell9";
        this.xrTableCell9.Text = "Expenditure";
        this.xrTableCell9.Weight = 1D;
        // 
        // xrTableCell10
        // 
        this.xrTableCell10.Dpi = 100F;
        this.xrTableCell10.Multiline = true;
        this.xrTableCell10.Name = "xrTableCell10";
        this.xrTableCell10.Text = "%age\r\nUtilization / FG";
        this.xrTableCell10.Weight = 1D;
        // 
        // xrTableCell11
        // 
        this.xrTableCell11.Dpi = 100F;
        this.xrTableCell11.Multiline = true;
        this.xrTableCell11.Name = "xrTableCell11";
        this.xrTableCell11.Text = "%age\r\nUtilization / BE";
        this.xrTableCell11.Weight = 1D;
        // 
        // xrTableCell32
        // 
        this.xrTableCell32.Dpi = 100F;
        this.xrTableCell32.Multiline = true;
        this.xrTableCell32.Name = "xrTableCell32";
        this.xrTableCell32.Text = "%age\r\nUtilization / R";
        this.xrTableCell32.Weight = 1D;
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
        this.xrLabel2.SizeF = new System.Drawing.SizeF(1305F, 32F);
        this.xrLabel2.StylePriority.UseFont = false;
        this.xrLabel2.StylePriority.UseTextAlignment = false;
        this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
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
        // UtilizationFG
        // 
        this.UtilizationFG.DataMember = "SchemeList";
        this.UtilizationFG.DisplayName = "UtilizationFG";
        this.UtilizationFG.Expression = "[Expenditure] / [FinalGrant]";
        this.UtilizationFG.FieldType = DevExpress.XtraReports.UI.FieldType.Decimal;
        this.UtilizationFG.Name = "UtilizationFG";
        // 
        // UtilizationBE
        // 
        this.UtilizationBE.DataMember = "SchemeList";
        this.UtilizationBE.DisplayName = "UtilizationBE";
        this.UtilizationBE.Expression = "[Expenditure] / [BudgetEstimate]";
        this.UtilizationBE.FieldType = DevExpress.XtraReports.UI.FieldType.Decimal;
        this.UtilizationBE.Name = "UtilizationBE";
        // 
        // headBudgetEstimation
        // 
        this.headBudgetEstimation.DisplayName = "headBudgetEstimation";
        this.headBudgetEstimation.Expression = "Concat(\'Budget Estimate \', [Parameters.prFinancialYear])";
        this.headBudgetEstimation.FieldType = DevExpress.XtraReports.UI.FieldType.String;
        this.headBudgetEstimation.Name = "headBudgetEstimation";
        // 
        // xrTable3
        // 
        this.xrTable3.BackColor = System.Drawing.Color.Empty;
        this.xrTable3.BorderColor = System.Drawing.Color.LightGray;
        this.xrTable3.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTable3.Dpi = 100F;
        this.xrTable3.Font = new System.Drawing.Font("Arial", 8.75F, System.Drawing.FontStyle.Bold);
        this.xrTable3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrTable3.Name = "xrTable3";
        this.xrTable3.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
        this.xrTable3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow3});
        this.xrTable3.SizeF = new System.Drawing.SizeF(1480F, 28F);
        this.xrTable3.StylePriority.UseBackColor = false;
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
            this.tcUtilizationFG,
            this.tcUtilizationBE,
            this.tcUtilizationBR});
        this.xrTableRow3.Dpi = 100F;
        this.xrTableRow3.Name = "xrTableRow3";
        this.xrTableRow3.Weight = 1D;
        // 
        // xrTableCell23
        // 
        this.xrTableCell23.Dpi = 100F;
        this.xrTableCell23.Name = "xrTableCell23";
        this.xrTableCell23.StylePriority.UseTextAlignment = false;
        this.xrTableCell23.Text = "Grand Total";
        this.xrTableCell23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        this.xrTableCell23.Weight = 1D;
        // 
        // xrTableCell24
        // 
        this.xrTableCell24.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.BudgetEstimate")});
        this.xrTableCell24.Dpi = 100F;
        this.xrTableCell24.Name = "xrTableCell24";
        xrSummary1.FormatString = "{0:#,#}";
        xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell24.Summary = xrSummary1;
        this.xrTableCell24.Weight = 1D;
        // 
        // xrTableCell25
        // 
        this.xrTableCell25.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.Supplementary")});
        this.xrTableCell25.Dpi = 100F;
        this.xrTableCell25.Name = "xrTableCell25";
        xrSummary2.FormatString = "{0:#,#}";
        xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell25.Summary = xrSummary2;
        this.xrTableCell25.Weight = 1D;
        // 
        // xrTableCell26
        // 
        this.xrTableCell26.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ReappPositive")});
        this.xrTableCell26.Dpi = 100F;
        this.xrTableCell26.Name = "xrTableCell26";
        xrSummary3.FormatString = "{0:#,#}";
        xrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell26.Summary = xrSummary3;
        this.xrTableCell26.Weight = 1D;
        // 
        // xrTableCell27
        // 
        this.xrTableCell27.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ReappNegative")});
        this.xrTableCell27.Dpi = 100F;
        this.xrTableCell27.Name = "xrTableCell27";
        xrSummary4.FormatString = "{0:#,#}";
        xrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell27.Summary = xrSummary4;
        this.xrTableCell27.Weight = 1D;
        // 
        // xrTableCell28
        // 
        this.xrTableCell28.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ExcessOrSurrender")});
        this.xrTableCell28.Dpi = 100F;
        this.xrTableCell28.Name = "xrTableCell28";
        xrSummary5.FormatString = "{0:#,#}";
        xrSummary5.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell28.Summary = xrSummary5;
        this.xrTableCell28.Weight = 1D;
        // 
        // xrTableCell29
        // 
        this.xrTableCell29.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.FinalGrant")});
        this.xrTableCell29.Dpi = 100F;
        this.xrTableCell29.Name = "xrTableCell29";
        xrSummary6.FormatString = "{0:#,#}";
        xrSummary6.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell29.Summary = xrSummary6;
        this.xrTableCell29.Weight = 1D;
        // 
        // xrTableCell30
        // 
        this.xrTableCell30.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.Release")});
        this.xrTableCell30.Dpi = 100F;
        this.xrTableCell30.Name = "xrTableCell30";
        xrSummary7.FormatString = "{0:#,#}";
        xrSummary7.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell30.Summary = xrSummary7;
        this.xrTableCell30.Weight = 1D;
        // 
        // xrTableCell31
        // 
        this.xrTableCell31.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.Expenditure")});
        this.xrTableCell31.Dpi = 100F;
        this.xrTableCell31.Name = "xrTableCell31";
        xrSummary8.FormatString = "{0:#,#}";
        xrSummary8.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell31.Summary = xrSummary8;
        this.xrTableCell31.Weight = 1D;
        // 
        // tcUtilizationFG
        // 
        this.tcUtilizationFG.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.UtilizationFG")});
        this.tcUtilizationFG.Dpi = 100F;
        this.tcUtilizationFG.Multiline = true;
        this.tcUtilizationFG.Name = "tcUtilizationFG";
        xrSummary9.FormatString = "{0}";
        xrSummary9.Func = DevExpress.XtraReports.UI.SummaryFunc.Custom;
        xrSummary9.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.tcUtilizationFG.Summary = xrSummary9;
        this.tcUtilizationFG.Weight = 1D;
        this.tcUtilizationFG.SummaryGetResult += new DevExpress.XtraReports.UI.SummaryGetResultHandler(this.tcUtilizationFG_SummaryGetResult);
        this.tcUtilizationFG.SummaryReset += new System.EventHandler(this.tcUtilizationFG_SummaryReset);
        this.tcUtilizationFG.SummaryRowChanged += new System.EventHandler(this.tcUtilizationFG_SummaryRowChanged);
        // 
        // tcUtilizationBE
        // 
        this.tcUtilizationBE.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.UtilizationBE")});
        this.tcUtilizationBE.Dpi = 100F;
        this.tcUtilizationBE.Multiline = true;
        this.tcUtilizationBE.Name = "tcUtilizationBE";
        xrSummary10.FormatString = "{0}";
        xrSummary10.Func = DevExpress.XtraReports.UI.SummaryFunc.Custom;
        xrSummary10.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.tcUtilizationBE.Summary = xrSummary10;
        this.tcUtilizationBE.Weight = 1D;
        this.tcUtilizationBE.SummaryGetResult += new DevExpress.XtraReports.UI.SummaryGetResultHandler(this.tcUtilizationBE_SummaryGetResult);
        this.tcUtilizationBE.SummaryReset += new System.EventHandler(this.tcUtilizationBE_SummaryReset);
        this.tcUtilizationBE.SummaryRowChanged += new System.EventHandler(this.tcUtilizationBE_SummaryRowChanged);
        // 
        // tcUtilizationBR
        // 
        this.tcUtilizationBR.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.UtilizationR")});
        this.tcUtilizationBR.Dpi = 100F;
        this.tcUtilizationBR.Name = "tcUtilizationBR";
        xrSummary11.FormatString = "{0}";
        xrSummary11.Func = DevExpress.XtraReports.UI.SummaryFunc.Custom;
        xrSummary11.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.tcUtilizationBR.Summary = xrSummary11;
        this.tcUtilizationBR.Weight = 1D;
        this.tcUtilizationBR.SummaryGetResult += new DevExpress.XtraReports.UI.SummaryGetResultHandler(this.tcUtilizationBR_SummaryGetResult);
        this.tcUtilizationBR.SummaryReset += new System.EventHandler(this.tcUtilizationBR_SummaryReset);
        this.tcUtilizationBR.SummaryRowChanged += new System.EventHandler(this.tcUtilizationBR_SummaryRowChanged);
        // 
        // GroupHeader1
        // 
        this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel2});
        this.GroupHeader1.Dpi = 100F;
        this.GroupHeader1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("InstitutionTitle", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
        this.GroupHeader1.HeightF = 32F;
        this.GroupHeader1.Name = "GroupHeader1";
        // 
        // GroupFooter1
        // 
        this.GroupFooter1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable3});
        this.GroupFooter1.Dpi = 100F;
        this.GroupFooter1.HeightF = 28F;
        this.GroupFooter1.Name = "GroupFooter1";
        // 
        // ExcessOrSurrender
        // 
        this.ExcessOrSurrender.DataMember = "SchemeList";
        this.ExcessOrSurrender.Expression = "[Excess] - [Surrender]";
        this.ExcessOrSurrender.Name = "ExcessOrSurrender";
        // 
        // FinalGrant
        // 
        this.FinalGrant.DataMember = "SchemeList";
        this.FinalGrant.Expression = "[ADPAllocation] + [Supplementary] + [ReappPositive] - [ReappNegative] + [Excess] " +
"- [Surrender]";
        this.FinalGrant.Name = "FinalGrant";
        // 
        // PageFooter
        // 
        this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel3});
        this.PageFooter.Dpi = 100F;
        this.PageFooter.HeightF = 37.5F;
        this.PageFooter.Name = "PageFooter";
        // 
        // xrLabel3
        // 
        this.xrLabel3.Dpi = 100F;
        this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(525F, 12.5F);
        this.xrLabel3.Name = "xrLabel3";
        this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel3.SizeF = new System.Drawing.SizeF(424.9999F, 23F);
        this.xrLabel3.StylePriority.UseTextAlignment = false;
        this.xrLabel3.Text = System.Configuration.ConfigurationManager.AppSettings["FooterText"];
        this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // UtilizationR
        // 
        this.UtilizationR.DataMember = "SchemeList";
        this.UtilizationR.Expression = "[Expenditure] / [Release]";
        this.UtilizationR.FieldType = DevExpress.XtraReports.UI.FieldType.Decimal;
        this.UtilizationR.Name = "UtilizationR";
        // 
        // xrFundWiseReport
        // 
        this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.GroupHeader1,
            this.GroupFooter1,
            this.PageFooter});
        this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.UtilizationFG,
            this.UtilizationBE,
            this.UtilizationR,
            this.headBudgetEstimation,
            this.ExcessOrSurrender,
            this.FinalGrant});
        this.DataMember = "SchemeList";
        this.DataSource = this.bindingSource1;
        this.Font = new System.Drawing.Font("Arial", 9.75F);
        this.Landscape = true;
        this.Margins = new System.Drawing.Printing.Margins(10, 10, 185, 100);
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

    private void tcUtilizationBR_SummaryReset(object sender, EventArgs e)
    {
        rExpenditure = 0;
        rRelease = 0;
    }
    private void tcUtilizationBR_SummaryRowChanged(object sender, EventArgs e)
    {
        rExpenditure += Convert.ToDouble(GetCurrentColumnValue("Expenditure"));
        rRelease += Convert.ToDouble(GetCurrentColumnValue("Release"));
    }
    private void tcUtilizationBR_SummaryGetResult(object sender, SummaryGetResultEventArgs e)
    {
        e.Result = rRelease == 0 ? "0.00%" : Math.Round(((rExpenditure / rRelease) * 100), 2).ToString() + "%";
        e.Handled = true;
    }
}
