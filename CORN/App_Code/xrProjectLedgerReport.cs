using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

/// <summary>
/// Summary description for xrProjectLedgerReport
/// </summary>
public class xrProjectLedgerReport : DevExpress.XtraReports.UI.XtraReport
{
    private DevExpress.XtraReports.UI.DetailBand Detail;
    private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
    private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
    private System.Windows.Forms.BindingSource bindingSource1;
    private XRLabel xrLabel1;
    private XRLabel xrLabel2;
    private XRLabel xrLabel6;
    private XRLabel xrLabel8;
    private DevExpress.XtraReports.Parameters.Parameter prProjectTitle;
    private DevExpress.XtraReports.Parameters.Parameter prFundType;
    private DevExpress.XtraReports.Parameters.Parameter prDateRange;
    private XRLabel xrLabel7;
    private XRLabel xrLabel9;
    private XRLabel xrLabel3;
    private CalculatedField ApproveLocalAmount;
    private CalculatedField ApproveTotalAmount;
    private CalculatedField AllocationLocalAmount;
    private CalculatedField AllocationTotalAmount;
    private CalculatedField RelesePMLocalAmount;
    private CalculatedField RelesePMTotalAmount;
    private CalculatedField ReleaseAllocationPercentage;
    private CalculatedField ExpensePMLocalAmount;
    private CalculatedField ExpensePMTotalAmount;
    private CalculatedField ExpensePMAllocationPercentage;
    private CalculatedField ExpensePMReleasePMPercentage;
    private CalculatedField ReleseMLocalAmount;
    private CalculatedField ReleseMTotalAmount;
    private CalculatedField ExpenseMLocalAmount;
    private CalculatedField ExpenseMTotalAmount;
    private CalculatedField ExpenseMAllocationPercentage;
    private CalculatedField ExpenseMReleaseMPercentage;
    private CalculatedField ExpenseLocalAmount;
    private CalculatedField ExpenseTotalAmount;
    private CalculatedField ThrowForwardLocal;
    private CalculatedField ThrowForwardForignFund;
    private CalculatedField ThrowForwardTotal;
    private XRTable xrTable1;
    private XRTableRow xrTableRow1;
    private XRTableCell xrTableCell1;
    private XRTableCell xrTableCell2;
    private XRTableCell xrTableCell5;
    private XRTableCell xrTableCell6;
    private XRTableCell xrTableCell7;
    private XRTableCell xrTableCell8;
    private XRTableCell xrTableCell9;
    private XRTableCell xrTableCell10;
    private XRTableCell xrTableCell15;
    private XRTableCell xrTableCell3;
    private XRTableCell xrTableCell4;
    private GroupHeaderBand GroupHeader1;
    private GroupFooterBand GroupFooter1;
    private XRTable xrTable2;
    private XRTableRow xrTableRow2;
    private XRTableCell xrTableCell16;
    private XRTableCell xrTableCell17;
    private XRTableCell xrTableCell18;
    private XRTableCell xrTableCell19;
    private XRTableCell xrTableCell20;
    private XRTableCell xrTableCell21;
    private XRTableCell xrTableCell22;
    private XRTableCell xrTableCell23;
    private XRTableCell xrTableCell24;
    private XRTableCell xrTableCell25;
    private XRTableCell xrTableCell30;
    private XRTable xrTable3;
    private XRTableRow xrTableRow3;
    private XRTableCell xrTableCell31;
    private XRTableCell xrTableCell32;
    private XRTableCell xrTableCell33;
    private XRTableCell xrTableCell34;
    private XRTableCell xrTableCell35;
    private XRTableCell xrTableCell36;
    private XRTableCell xrTableCell37;
    private XRTableCell xrTableCell38;
    private XRTableCell xrTableCell39;
    private XRTableCell xrTableCell40;
    private XRTableCell tcUtilization;
    private PageFooterBand PageFooter;
    private XRLabel xrLabel4;
    private ReportHeaderBand ReportHeader;
    private PageHeaderBand PageHeader;
    private XRTableCell xrTableCell14;
    private XRTableCell xrTableCell13;
    private XRTableCell xrTableCell11;
    private XRTableCell xrTableCell12;
    private XRTableCell xrTableCell27;
    private XRTableCell xrTableCell26;

    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public xrProjectLedgerReport()
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
        string resourceFileName = "xrProjectLedgerReport.resx";
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
        this.Detail = new DevExpress.XtraReports.UI.DetailBand();
        this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell16 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell17 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell18 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell19 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell20 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell21 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell22 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell14 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell13 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell23 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell24 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell25 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell30 = new DevExpress.XtraReports.UI.XRTableCell();
        this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
        this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
        this.prDateRange = new DevExpress.XtraReports.Parameters.Parameter();
        this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
        this.prFundType = new DevExpress.XtraReports.Parameters.Parameter();
        this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
        this.prProjectTitle = new DevExpress.XtraReports.Parameters.Parameter();
        this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
        this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
        this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
        this.ApproveLocalAmount = new DevExpress.XtraReports.UI.CalculatedField();
        this.ApproveTotalAmount = new DevExpress.XtraReports.UI.CalculatedField();
        this.AllocationLocalAmount = new DevExpress.XtraReports.UI.CalculatedField();
        this.AllocationTotalAmount = new DevExpress.XtraReports.UI.CalculatedField();
        this.RelesePMLocalAmount = new DevExpress.XtraReports.UI.CalculatedField();
        this.RelesePMTotalAmount = new DevExpress.XtraReports.UI.CalculatedField();
        this.ReleaseAllocationPercentage = new DevExpress.XtraReports.UI.CalculatedField();
        this.ExpensePMLocalAmount = new DevExpress.XtraReports.UI.CalculatedField();
        this.ExpensePMTotalAmount = new DevExpress.XtraReports.UI.CalculatedField();
        this.ExpensePMAllocationPercentage = new DevExpress.XtraReports.UI.CalculatedField();
        this.ExpensePMReleasePMPercentage = new DevExpress.XtraReports.UI.CalculatedField();
        this.ReleseMLocalAmount = new DevExpress.XtraReports.UI.CalculatedField();
        this.ReleseMTotalAmount = new DevExpress.XtraReports.UI.CalculatedField();
        this.ExpenseMLocalAmount = new DevExpress.XtraReports.UI.CalculatedField();
        this.ExpenseMTotalAmount = new DevExpress.XtraReports.UI.CalculatedField();
        this.ExpenseMAllocationPercentage = new DevExpress.XtraReports.UI.CalculatedField();
        this.ExpenseMReleaseMPercentage = new DevExpress.XtraReports.UI.CalculatedField();
        this.ExpenseLocalAmount = new DevExpress.XtraReports.UI.CalculatedField();
        this.ExpenseTotalAmount = new DevExpress.XtraReports.UI.CalculatedField();
        this.ThrowForwardLocal = new DevExpress.XtraReports.UI.CalculatedField();
        this.ThrowForwardForignFund = new DevExpress.XtraReports.UI.CalculatedField();
        this.ThrowForwardTotal = new DevExpress.XtraReports.UI.CalculatedField();
        this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell15 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
        this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
        this.GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
        this.xrTable3 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell31 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell32 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell33 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell34 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell35 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell36 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell37 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell27 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell26 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell38 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell39 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell40 = new DevExpress.XtraReports.UI.XRTableCell();
        this.tcUtilization = new DevExpress.XtraReports.UI.XRTableCell();
        this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
        this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
        this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
        this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).BeginInit();
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
        this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        // 
        // xrTable2
        // 
        this.xrTable2.BorderColor = System.Drawing.Color.LightGray;
        this.xrTable2.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTable2.Dpi = 100F;
        this.xrTable2.Font = new System.Drawing.Font("Arial", 8.5F);
        this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(0.4166603F, 0F);
        this.xrTable2.Name = "xrTable2";
        this.xrTable2.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
        this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
        this.xrTable2.SizeF = new System.Drawing.SizeF(1632.583F, 25F);
        this.xrTable2.StylePriority.UseBackColor = false;
        this.xrTable2.StylePriority.UseBorderColor = false;
        this.xrTable2.StylePriority.UseBorders = false;
        this.xrTable2.StylePriority.UseFont = false;
        this.xrTable2.StylePriority.UsePadding = false;
        this.xrTable2.StylePriority.UseTextAlignment = false;
        this.xrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        // 
        // xrTableRow2
        // 
        this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell16,
            this.xrTableCell17,
            this.xrTableCell18,
            this.xrTableCell19,
            this.xrTableCell20,
            this.xrTableCell21,
            this.xrTableCell22,
            this.xrTableCell14,
            this.xrTableCell13,
            this.xrTableCell23,
            this.xrTableCell24,
            this.xrTableCell25,
            this.xrTableCell30});
        this.xrTableRow2.Dpi = 100F;
        this.xrTableRow2.Name = "xrTableRow2";
        this.xrTableRow2.Weight = 1D;
        // 
        // xrTableCell16
        // 
        this.xrTableCell16.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.TransactionDateString")});
        this.xrTableCell16.Dpi = 100F;
        this.xrTableCell16.Name = "xrTableCell16";
        this.xrTableCell16.StylePriority.UseTextAlignment = false;
        this.xrTableCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        this.xrTableCell16.Weight = 0.604234404246488D;
        // 
        // xrTableCell17
        // 
        this.xrTableCell17.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.FundTitle")});
        this.xrTableCell17.Dpi = 100F;
        this.xrTableCell17.Name = "xrTableCell17";
        this.xrTableCell17.StylePriority.UseTextAlignment = false;
        this.xrTableCell17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        this.xrTableCell17.Weight = 1.56261814174047D;
        // 
        // xrTableCell18
        // 
        this.xrTableCell18.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.BudgetAllocation", "{0:#,#}")});
        this.xrTableCell18.Dpi = 100F;
        this.xrTableCell18.Name = "xrTableCell18";
        this.xrTableCell18.Weight = 0.664687422986737D;
        // 
        // xrTableCell19
        // 
        this.xrTableCell19.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.Supplementary", "{0:#,#}")});
        this.xrTableCell19.Dpi = 100F;
        this.xrTableCell19.Name = "xrTableCell19";
        this.xrTableCell19.Weight = 0.664687441058632D;
        // 
        // xrTableCell20
        // 
        this.xrTableCell20.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ReappPositive", "{0:#,#}")});
        this.xrTableCell20.Dpi = 100F;
        this.xrTableCell20.Name = "xrTableCell20";
        this.xrTableCell20.Weight = 0.664687432626652D;
        // 
        // xrTableCell21
        // 
        this.xrTableCell21.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ReappNegative", "{0:#,#}")});
        this.xrTableCell21.Dpi = 100F;
        this.xrTableCell21.Name = "xrTableCell21";
        this.xrTableCell21.Weight = 0.664687432626652D;
        // 
        // xrTableCell22
        // 
        this.xrTableCell22.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.Excess", "{0:#,#}")});
        this.xrTableCell22.Dpi = 100F;
        this.xrTableCell22.Name = "xrTableCell22";
        this.xrTableCell22.Weight = 0.664687432626652D;
        // 
        // xrTableCell14
        // 
        this.xrTableCell14.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.Surrender", "{0:#,#}")});
        this.xrTableCell14.Dpi = 100F;
        this.xrTableCell14.Name = "xrTableCell14";
        this.xrTableCell14.Weight = 0.664687432626652D;
        // 
        // xrTableCell13
        // 
        this.xrTableCell13.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.FinalGrant", "{0:#,#}")});
        this.xrTableCell13.Dpi = 100F;
        this.xrTableCell13.Name = "xrTableCell13";
        this.xrTableCell13.Weight = 0.664687432626652D;
        // 
        // xrTableCell23
        // 
        this.xrTableCell23.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.Release", "{0:#,#}")});
        this.xrTableCell23.Dpi = 100F;
        this.xrTableCell23.Name = "xrTableCell23";
        this.xrTableCell23.Weight = 0.664687432626652D;
        // 
        // xrTableCell24
        // 
        this.xrTableCell24.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.Expenditure", "{0:#,#}")});
        this.xrTableCell24.Dpi = 100F;
        this.xrTableCell24.Name = "xrTableCell24";
        this.xrTableCell24.Weight = 0.664687432626652D;
        // 
        // xrTableCell25
        // 
        this.xrTableCell25.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.Balance", "{0:#,#}")});
        this.xrTableCell25.Dpi = 100F;
        this.xrTableCell25.Name = "xrTableCell25";
        this.xrTableCell25.Weight = 0.664687432626652D;
        // 
        // xrTableCell30
        // 
        this.xrTableCell30.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ReleaseBalance", "{0:#,#}")});
        this.xrTableCell30.Dpi = 100F;
        this.xrTableCell30.Name = "xrTableCell30";
        this.xrTableCell30.Weight = 0.664686666181398D;
        // 
        // TopMargin
        // 
        this.TopMargin.Dpi = 100F;
        this.TopMargin.HeightF = 48.74999F;
        this.TopMargin.Name = "TopMargin";
        this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
        this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        // 
        // xrLabel7
        // 
        this.xrLabel7.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.prDateRange, "Text", "")});
        this.xrLabel7.Dpi = 100F;
        this.xrLabel7.Font = new System.Drawing.Font("Arial", 8.75F);
        this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(102.2539F, 229.5834F);
        this.xrLabel7.Multiline = true;
        this.xrLabel7.Name = "xrLabel7";
        this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel7.SizeF = new System.Drawing.SizeF(298.9583F, 30F);
        this.xrLabel7.StylePriority.UseFont = false;
        this.xrLabel7.StylePriority.UseTextAlignment = false;
        this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // prDateRange
        // 
        this.prDateRange.Description = "DateRange";
        this.prDateRange.Name = "prDateRange";
        this.prDateRange.Visible = false;
        // 
        // xrLabel9
        // 
        this.xrLabel9.Dpi = 100F;
        this.xrLabel9.Font = new System.Drawing.Font("Arial", 8.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
        this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(1.420546F, 229.5834F);
        this.xrLabel9.Multiline = true;
        this.xrLabel9.Name = "xrLabel9";
        this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel9.SizeF = new System.Drawing.SizeF(100F, 30F);
        this.xrLabel9.StylePriority.UseFont = false;
        this.xrLabel9.StylePriority.UseTextAlignment = false;
        this.xrLabel9.Text = "Date:";
        this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrLabel3
        // 
        this.xrLabel3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.prFundType, "Text", "")});
        this.xrLabel3.Dpi = 100F;
        this.xrLabel3.Font = new System.Drawing.Font("Arial", 8.75F);
        this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(102.2539F, 189.375F);
        this.xrLabel3.Multiline = true;
        this.xrLabel3.Name = "xrLabel3";
        this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel3.SizeF = new System.Drawing.SizeF(298.9583F, 30.00002F);
        this.xrLabel3.StylePriority.UseFont = false;
        this.xrLabel3.StylePriority.UseTextAlignment = false;
        this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // prFundType
        // 
        this.prFundType.Description = "FundType";
        this.prFundType.Name = "prFundType";
        this.prFundType.Visible = false;
        // 
        // xrLabel8
        // 
        this.xrLabel8.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.prProjectTitle, "Text", "")});
        this.xrLabel8.Dpi = 100F;
        this.xrLabel8.Font = new System.Drawing.Font("Arial", 8.75F);
        this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(102.2539F, 148.9583F);
        this.xrLabel8.Multiline = true;
        this.xrLabel8.Name = "xrLabel8";
        this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel8.SizeF = new System.Drawing.SizeF(448.9584F, 30F);
        this.xrLabel8.StylePriority.UseFont = false;
        this.xrLabel8.StylePriority.UseTextAlignment = false;
        this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // prProjectTitle
        // 
        this.prProjectTitle.Description = "ProjectTitle";
        this.prProjectTitle.Name = "prProjectTitle";
        this.prProjectTitle.Visible = false;
        // 
        // xrLabel2
        // 
        this.xrLabel2.Dpi = 100F;
        this.xrLabel2.Font = new System.Drawing.Font("Arial", 8.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
        this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(1.420546F, 189.375F);
        this.xrLabel2.Multiline = true;
        this.xrLabel2.Name = "xrLabel2";
        this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel2.SizeF = new System.Drawing.SizeF(100F, 30F);
        this.xrLabel2.StylePriority.UseFont = false;
        this.xrLabel2.StylePriority.UseTextAlignment = false;
        this.xrLabel2.Text = "Fund Type:";
        this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrLabel6
        // 
        this.xrLabel6.Dpi = 100F;
        this.xrLabel6.Font = new System.Drawing.Font("Arial", 8.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
        this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(1.420538F, 148.9583F);
        this.xrLabel6.Multiline = true;
        this.xrLabel6.Name = "xrLabel6";
        this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel6.SizeF = new System.Drawing.SizeF(100F, 30F);
        this.xrLabel6.StylePriority.UseFont = false;
        this.xrLabel6.StylePriority.UseTextAlignment = false;
        this.xrLabel6.Text = "Project Name:";
        this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrLabel1
        // 
        this.xrLabel1.Dpi = 100F;
        this.xrLabel1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
        this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(487.5F, 0F);
        this.xrLabel1.Multiline = true;
        this.xrLabel1.Name = "xrLabel1";
        this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel1.SizeF = new System.Drawing.SizeF(670F, 48.95834F);
        this.xrLabel1.StylePriority.UseFont = false;
        this.xrLabel1.StylePriority.UseTextAlignment = false;
        this.xrLabel1.Text = "Project Transaction Detail Report";
        this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // BottomMargin
        // 
        this.BottomMargin.Dpi = 100F;
        this.BottomMargin.HeightF = 48.87498F;
        this.BottomMargin.Name = "BottomMargin";
        this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
        this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        // 
        // bindingSource1
        // 
        this.bindingSource1.DataMember = "CornReportList";
        this.bindingSource1.DataSource = typeof(CORNDataAccessLayer.Response.ReportResponse);
        // 
        // ApproveLocalAmount
        // 
        this.ApproveLocalAmount.DataMember = "SubSectorList";
        this.ApproveLocalAmount.Expression = "[ApproveCapitalAmount] + [ApproveRevenueAmount]";
        this.ApproveLocalAmount.FieldType = DevExpress.XtraReports.UI.FieldType.Decimal;
        this.ApproveLocalAmount.Name = "ApproveLocalAmount";
        // 
        // ApproveTotalAmount
        // 
        this.ApproveTotalAmount.DataMember = "SubSectorList";
        this.ApproveTotalAmount.Expression = "[ApproveCapitalAmount] + [ApproveRevenueAmount] + [ApproveForignFundAmount]";
        this.ApproveTotalAmount.FieldType = DevExpress.XtraReports.UI.FieldType.Decimal;
        this.ApproveTotalAmount.Name = "ApproveTotalAmount";
        // 
        // AllocationLocalAmount
        // 
        this.AllocationLocalAmount.DataMember = "SubSectorList";
        this.AllocationLocalAmount.Expression = "[AllocationCapitalAmount] + [AllocationRevenueAmount]";
        this.AllocationLocalAmount.FieldType = DevExpress.XtraReports.UI.FieldType.Decimal;
        this.AllocationLocalAmount.Name = "AllocationLocalAmount";
        // 
        // AllocationTotalAmount
        // 
        this.AllocationTotalAmount.DataMember = "SubSectorList";
        this.AllocationTotalAmount.Expression = "[AllocationCapitalAmount] + [AllocationRevenueAmount] + [AllocationForignFundAmou" +
"nt]";
        this.AllocationTotalAmount.FieldType = DevExpress.XtraReports.UI.FieldType.Decimal;
        this.AllocationTotalAmount.Name = "AllocationTotalAmount";
        // 
        // RelesePMLocalAmount
        // 
        this.RelesePMLocalAmount.DataMember = "SubSectorList";
        this.RelesePMLocalAmount.Expression = "[ReleasePMCapitalAmount] + [ReleasePMRevenueAmount]";
        this.RelesePMLocalAmount.FieldType = DevExpress.XtraReports.UI.FieldType.Decimal;
        this.RelesePMLocalAmount.Name = "RelesePMLocalAmount";
        // 
        // RelesePMTotalAmount
        // 
        this.RelesePMTotalAmount.DataMember = "SubSectorList";
        this.RelesePMTotalAmount.Expression = "[ReleasePMCapitalAmount] + [ReleasePMRevenueAmount] + [ReleasePMForignFundAmount]" +
"";
        this.RelesePMTotalAmount.FieldType = DevExpress.XtraReports.UI.FieldType.Decimal;
        this.RelesePMTotalAmount.Name = "RelesePMTotalAmount";
        // 
        // ReleaseAllocationPercentage
        // 
        this.ReleaseAllocationPercentage.DataMember = "SubSectorList";
        this.ReleaseAllocationPercentage.Expression = "((100 / [AllocationTotalAmount]) * [RelesePMTotalAmount])/100";
        this.ReleaseAllocationPercentage.FieldType = DevExpress.XtraReports.UI.FieldType.Float;
        this.ReleaseAllocationPercentage.Name = "ReleaseAllocationPercentage";
        // 
        // ExpensePMLocalAmount
        // 
        this.ExpensePMLocalAmount.DataMember = "SubSectorList";
        this.ExpensePMLocalAmount.Expression = "[ExpensePMCapitalAmount] + [ExpensePMRevenueAmount]";
        this.ExpensePMLocalAmount.FieldType = DevExpress.XtraReports.UI.FieldType.Decimal;
        this.ExpensePMLocalAmount.Name = "ExpensePMLocalAmount";
        // 
        // ExpensePMTotalAmount
        // 
        this.ExpensePMTotalAmount.DataMember = "SubSectorList";
        this.ExpensePMTotalAmount.Expression = "[ExpensePMCapitalAmount] + [ExpensePMRevenueAmount] + [ExpensePMForignFundAmount]" +
"";
        this.ExpensePMTotalAmount.FieldType = DevExpress.XtraReports.UI.FieldType.Decimal;
        this.ExpensePMTotalAmount.Name = "ExpensePMTotalAmount";
        // 
        // ExpensePMAllocationPercentage
        // 
        this.ExpensePMAllocationPercentage.DataMember = "SubSectorList";
        this.ExpensePMAllocationPercentage.Expression = "((100 / [AllocationTotalAmount]) * [ExpensePMTotalAmount])/100";
        this.ExpensePMAllocationPercentage.FieldType = DevExpress.XtraReports.UI.FieldType.Float;
        this.ExpensePMAllocationPercentage.Name = "ExpensePMAllocationPercentage";
        // 
        // ExpensePMReleasePMPercentage
        // 
        this.ExpensePMReleasePMPercentage.DataMember = "SubSectorList";
        this.ExpensePMReleasePMPercentage.Expression = "((100 / [RelesePMTotalAmount]) * [ExpensePMTotalAmount])/100";
        this.ExpensePMReleasePMPercentage.FieldType = DevExpress.XtraReports.UI.FieldType.Float;
        this.ExpensePMReleasePMPercentage.Name = "ExpensePMReleasePMPercentage";
        // 
        // ReleseMLocalAmount
        // 
        this.ReleseMLocalAmount.DataMember = "SubSectorList";
        this.ReleseMLocalAmount.Expression = "[ReleaseMCapitalAmount] + [ReleaseMRevenueAmount]";
        this.ReleseMLocalAmount.FieldType = DevExpress.XtraReports.UI.FieldType.Decimal;
        this.ReleseMLocalAmount.Name = "ReleseMLocalAmount";
        // 
        // ReleseMTotalAmount
        // 
        this.ReleseMTotalAmount.DataMember = "SubSectorList";
        this.ReleseMTotalAmount.Expression = "[ReleaseMCapitalAmount] + [ReleaseMRevenueAmount] + [ReleaseMForignFundAmount]";
        this.ReleseMTotalAmount.FieldType = DevExpress.XtraReports.UI.FieldType.Decimal;
        this.ReleseMTotalAmount.Name = "ReleseMTotalAmount";
        // 
        // ExpenseMLocalAmount
        // 
        this.ExpenseMLocalAmount.DataMember = "SubSectorList";
        this.ExpenseMLocalAmount.Expression = "[ExpenseMCapitalAmount] + [ExpenseMRevenueAmount]";
        this.ExpenseMLocalAmount.FieldType = DevExpress.XtraReports.UI.FieldType.Decimal;
        this.ExpenseMLocalAmount.Name = "ExpenseMLocalAmount";
        // 
        // ExpenseMTotalAmount
        // 
        this.ExpenseMTotalAmount.DataMember = "SubSectorList";
        this.ExpenseMTotalAmount.Expression = "[ExpenseMCapitalAmount] + [ExpenseMRevenueAmount] + [ExpenseMForignFundAmount]";
        this.ExpenseMTotalAmount.FieldType = DevExpress.XtraReports.UI.FieldType.Decimal;
        this.ExpenseMTotalAmount.Name = "ExpenseMTotalAmount";
        // 
        // ExpenseMAllocationPercentage
        // 
        this.ExpenseMAllocationPercentage.DataMember = "SubSectorList";
        this.ExpenseMAllocationPercentage.Expression = "((100 / [AllocationTotalAmount]) * [ExpenseMTotalAmount])/100";
        this.ExpenseMAllocationPercentage.FieldType = DevExpress.XtraReports.UI.FieldType.Float;
        this.ExpenseMAllocationPercentage.Name = "ExpenseMAllocationPercentage";
        // 
        // ExpenseMReleaseMPercentage
        // 
        this.ExpenseMReleaseMPercentage.DataMember = "SubSectorList";
        this.ExpenseMReleaseMPercentage.Expression = "((100 / [ReleseMTotalAmount]) * [ExpenseMTotalAmount])/100";
        this.ExpenseMReleaseMPercentage.FieldType = DevExpress.XtraReports.UI.FieldType.Float;
        this.ExpenseMReleaseMPercentage.Name = "ExpenseMReleaseMPercentage";
        // 
        // ExpenseLocalAmount
        // 
        this.ExpenseLocalAmount.DataMember = "SubSectorList";
        this.ExpenseLocalAmount.Expression = "[ExpenseCapitalAmount] + [ExpenseRevenueAmount]";
        this.ExpenseLocalAmount.FieldType = DevExpress.XtraReports.UI.FieldType.Decimal;
        this.ExpenseLocalAmount.Name = "ExpenseLocalAmount";
        // 
        // ExpenseTotalAmount
        // 
        this.ExpenseTotalAmount.DataMember = "SubSectorList";
        this.ExpenseTotalAmount.Expression = "[ExpenseCapitalAmount] + [ExpenseRevenueAmount] + [ExpenseForignFundAmount]";
        this.ExpenseTotalAmount.FieldType = DevExpress.XtraReports.UI.FieldType.Decimal;
        this.ExpenseTotalAmount.Name = "ExpenseTotalAmount";
        // 
        // ThrowForwardLocal
        // 
        this.ThrowForwardLocal.DataMember = "SubSectorList";
        this.ThrowForwardLocal.Expression = "[ApproveLocalAmount] - [ExpenseLocalAmount]";
        this.ThrowForwardLocal.FieldType = DevExpress.XtraReports.UI.FieldType.Decimal;
        this.ThrowForwardLocal.Name = "ThrowForwardLocal";
        // 
        // ThrowForwardForignFund
        // 
        this.ThrowForwardForignFund.DataMember = "SubSectorList";
        this.ThrowForwardForignFund.Expression = "[ApproveForignFundAmount] - [ExpenseForignFundAmount]";
        this.ThrowForwardForignFund.FieldType = DevExpress.XtraReports.UI.FieldType.Decimal;
        this.ThrowForwardForignFund.Name = "ThrowForwardForignFund";
        // 
        // ThrowForwardTotal
        // 
        this.ThrowForwardTotal.DataMember = "SubSectorList";
        this.ThrowForwardTotal.Expression = "[ApproveTotalAmount] - [ExpenseTotalAmount]";
        this.ThrowForwardTotal.FieldType = DevExpress.XtraReports.UI.FieldType.Decimal;
        this.ThrowForwardTotal.Name = "ThrowForwardTotal";
        // 
        // xrTable1
        // 
        this.xrTable1.BackColor = System.Drawing.Color.LightGray;
        this.xrTable1.Dpi = 100F;
        this.xrTable1.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Bold);
        this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(0.4166603F, 0F);
        this.xrTable1.Name = "xrTable1";
        this.xrTable1.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
        this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
        this.xrTable1.SizeF = new System.Drawing.SizeF(1632.583F, 65F);
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
            this.xrTableCell5,
            this.xrTableCell6,
            this.xrTableCell7,
            this.xrTableCell8,
            this.xrTableCell9,
            this.xrTableCell11,
            this.xrTableCell12,
            this.xrTableCell10,
            this.xrTableCell15,
            this.xrTableCell3,
            this.xrTableCell4});
        this.xrTableRow1.Dpi = 100F;
        this.xrTableRow1.Name = "xrTableRow1";
        this.xrTableRow1.Weight = 1D;
        // 
        // xrTableCell1
        // 
        this.xrTableCell1.Dpi = 100F;
        this.xrTableCell1.Name = "xrTableCell1";
        this.xrTableCell1.StylePriority.UseTextAlignment = false;
        this.xrTableCell1.Text = "Date";
        this.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell1.Weight = 0.581818185579927D;
        // 
        // xrTableCell2
        // 
        this.xrTableCell2.Dpi = 100F;
        this.xrTableCell2.Name = "xrTableCell2";
        this.xrTableCell2.StylePriority.UseTextAlignment = false;
        this.xrTableCell2.Text = "Nature of Transaction";
        this.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        this.xrTableCell2.Weight = 1.50460736129507D;
        // 
        // xrTableCell5
        // 
        this.xrTableCell5.Dpi = 100F;
        this.xrTableCell5.Name = "xrTableCell5";
        this.xrTableCell5.Text = "Budget Allocation";
        this.xrTableCell5.Weight = 0.64D;
        // 
        // xrTableCell6
        // 
        this.xrTableCell6.Dpi = 100F;
        this.xrTableCell6.Name = "xrTableCell6";
        this.xrTableCell6.Text = "Supplementary";
        this.xrTableCell6.Weight = 0.64D;
        // 
        // xrTableCell7
        // 
        this.xrTableCell7.Dpi = 100F;
        this.xrTableCell7.Name = "xrTableCell7";
        this.xrTableCell7.Text = "Reapp. (+)";
        this.xrTableCell7.Weight = 0.64D;
        // 
        // xrTableCell8
        // 
        this.xrTableCell8.Dpi = 100F;
        this.xrTableCell8.Name = "xrTableCell8";
        this.xrTableCell8.Text = "Reapp. (-)";
        this.xrTableCell8.Weight = 0.64D;
        // 
        // xrTableCell9
        // 
        this.xrTableCell9.Dpi = 100F;
        this.xrTableCell9.Name = "xrTableCell9";
        this.xrTableCell9.Text = "Excess";
        this.xrTableCell9.Weight = 0.64D;
        // 
        // xrTableCell11
        // 
        this.xrTableCell11.Dpi = 100F;
        this.xrTableCell11.Name = "xrTableCell11";
        this.xrTableCell11.Text = "Surrender";
        this.xrTableCell11.Weight = 0.64D;
        // 
        // xrTableCell12
        // 
        this.xrTableCell12.Dpi = 100F;
        this.xrTableCell12.Name = "xrTableCell12";
        this.xrTableCell12.Text = "Final Grant";
        this.xrTableCell12.Weight = 0.64D;
        // 
        // xrTableCell10
        // 
        this.xrTableCell10.Dpi = 100F;
        this.xrTableCell10.Name = "xrTableCell10";
        this.xrTableCell10.Text = "Release";
        this.xrTableCell10.Weight = 0.64D;
        // 
        // xrTableCell15
        // 
        this.xrTableCell15.Dpi = 100F;
        this.xrTableCell15.Name = "xrTableCell15";
        this.xrTableCell15.Text = "Expenditure";
        this.xrTableCell15.Weight = 0.64D;
        // 
        // xrTableCell3
        // 
        this.xrTableCell3.Dpi = 100F;
        this.xrTableCell3.Name = "xrTableCell3";
        this.xrTableCell3.Text = "Balance";
        this.xrTableCell3.Weight = 0.64D;
        // 
        // xrTableCell4
        // 
        this.xrTableCell4.Dpi = 100F;
        this.xrTableCell4.Name = "xrTableCell4";
        this.xrTableCell4.Text = "Release Balance";
        this.xrTableCell4.Weight = 0.64D;
        // 
        // GroupHeader1
        // 
        this.GroupHeader1.Dpi = 100F;
        this.GroupHeader1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("Id", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
        this.GroupHeader1.HeightF = 0F;
        this.GroupHeader1.Name = "GroupHeader1";
        // 
        // GroupFooter1
        // 
        this.GroupFooter1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable3});
        this.GroupFooter1.Dpi = 100F;
        this.GroupFooter1.HeightF = 25F;
        this.GroupFooter1.Name = "GroupFooter1";
        // 
        // xrTable3
        // 
        this.xrTable3.BorderColor = System.Drawing.Color.LightGray;
        this.xrTable3.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTable3.Dpi = 100F;
        this.xrTable3.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Bold);
        this.xrTable3.LocationFloat = new DevExpress.Utils.PointFloat(0.4166603F, 0F);
        this.xrTable3.Name = "xrTable3";
        this.xrTable3.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
        this.xrTable3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow3});
        this.xrTable3.SizeF = new System.Drawing.SizeF(1632.583F, 25F);
        this.xrTable3.StylePriority.UseBackColor = false;
        this.xrTable3.StylePriority.UseBorderColor = false;
        this.xrTable3.StylePriority.UseBorders = false;
        this.xrTable3.StylePriority.UseFont = false;
        this.xrTable3.StylePriority.UsePadding = false;
        this.xrTable3.StylePriority.UseTextAlignment = false;
        this.xrTable3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        // 
        // xrTableRow3
        // 
        this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell31,
            this.xrTableCell32,
            this.xrTableCell33,
            this.xrTableCell34,
            this.xrTableCell35,
            this.xrTableCell36,
            this.xrTableCell37,
            this.xrTableCell27,
            this.xrTableCell26,
            this.xrTableCell38,
            this.xrTableCell39,
            this.xrTableCell40,
            this.tcUtilization});
        this.xrTableRow3.Dpi = 100F;
        this.xrTableRow3.Name = "xrTableRow3";
        this.xrTableRow3.Weight = 1D;
        // 
        // xrTableCell31
        // 
        this.xrTableCell31.Dpi = 100F;
        this.xrTableCell31.Name = "xrTableCell31";
        this.xrTableCell31.StylePriority.UseTextAlignment = false;
        this.xrTableCell31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        this.xrTableCell31.Weight = 0.604234404246488D;
        // 
        // xrTableCell32
        // 
        this.xrTableCell32.Dpi = 100F;
        this.xrTableCell32.Name = "xrTableCell32";
        this.xrTableCell32.StylePriority.UseTextAlignment = false;
        this.xrTableCell32.Text = "TOTAL";
        this.xrTableCell32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        this.xrTableCell32.Weight = 1.56261814174047D;
        // 
        // xrTableCell33
        // 
        this.xrTableCell33.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.BudgetAllocation")});
        this.xrTableCell33.Dpi = 100F;
        this.xrTableCell33.Name = "xrTableCell33";
        xrSummary1.FormatString = "{0:#,#}";
        xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell33.Summary = xrSummary1;
        this.xrTableCell33.Weight = 0.664687422986737D;
        // 
        // xrTableCell34
        // 
        this.xrTableCell34.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.Supplementary")});
        this.xrTableCell34.Dpi = 100F;
        this.xrTableCell34.Name = "xrTableCell34";
        xrSummary2.FormatString = "{0:#,#}";
        xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell34.Summary = xrSummary2;
        this.xrTableCell34.Weight = 0.664687441058632D;
        // 
        // xrTableCell35
        // 
        this.xrTableCell35.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ReappPositive")});
        this.xrTableCell35.Dpi = 100F;
        this.xrTableCell35.Name = "xrTableCell35";
        xrSummary3.FormatString = "{0:#,#}";
        xrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell35.Summary = xrSummary3;
        this.xrTableCell35.Weight = 0.664687432626652D;
        // 
        // xrTableCell36
        // 
        this.xrTableCell36.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ReappNegative")});
        this.xrTableCell36.Dpi = 100F;
        this.xrTableCell36.Name = "xrTableCell36";
        xrSummary4.FormatString = "{0:#,#}";
        xrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell36.Summary = xrSummary4;
        this.xrTableCell36.Weight = 0.664687432626652D;
        // 
        // xrTableCell37
        // 
        this.xrTableCell37.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.Excess")});
        this.xrTableCell37.Dpi = 100F;
        this.xrTableCell37.Name = "xrTableCell37";
        xrSummary5.FormatString = "{0:#,#}";
        xrSummary5.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell37.Summary = xrSummary5;
        this.xrTableCell37.Weight = 0.664687432626652D;
        // 
        // xrTableCell27
        // 
        this.xrTableCell27.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.Surrender")});
        this.xrTableCell27.Dpi = 100F;
        this.xrTableCell27.Name = "xrTableCell27";
        xrSummary6.FormatString = "{0:#,#}";
        xrSummary6.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell27.Summary = xrSummary6;
        this.xrTableCell27.Weight = 0.664687432626652D;
        // 
        // xrTableCell26
        // 
        this.xrTableCell26.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.FinalGrant", "{0:#,#}")});
        this.xrTableCell26.Dpi = 100F;
        this.xrTableCell26.Name = "xrTableCell26";
        this.xrTableCell26.Weight = 0.664687432626652D;
        // 
        // xrTableCell38
        // 
        this.xrTableCell38.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.Release")});
        this.xrTableCell38.Dpi = 100F;
        this.xrTableCell38.Name = "xrTableCell38";
        xrSummary7.FormatString = "{0:#,#}";
        xrSummary7.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell38.Summary = xrSummary7;
        this.xrTableCell38.Weight = 0.664687432626652D;
        // 
        // xrTableCell39
        // 
        this.xrTableCell39.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.Expenditure")});
        this.xrTableCell39.Dpi = 100F;
        this.xrTableCell39.Name = "xrTableCell39";
        xrSummary8.FormatString = "{0:#,#}";
        xrSummary8.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell39.Summary = xrSummary8;
        this.xrTableCell39.Weight = 0.664687432626652D;
        // 
        // xrTableCell40
        // 
        this.xrTableCell40.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.Balance", "{0:#,#}")});
        this.xrTableCell40.Dpi = 100F;
        this.xrTableCell40.Name = "xrTableCell40";
        xrSummary9.FormatString = "{0:#,#}";
        this.xrTableCell40.Summary = xrSummary9;
        this.xrTableCell40.Weight = 0.664687432626652D;
        // 
        // tcUtilization
        // 
        this.tcUtilization.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ReleaseBalance", "{0:#,#}")});
        this.tcUtilization.Dpi = 100F;
        this.tcUtilization.Name = "tcUtilization";
        xrSummary10.FormatString = "{0:#,#}";
        this.tcUtilization.Summary = xrSummary10;
        this.tcUtilization.Weight = 0.664686666181398D;
        // 
        // PageFooter
        // 
        this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel4});
        this.PageFooter.Dpi = 100F;
        this.PageFooter.HeightF = 35.5F;
        this.PageFooter.Name = "PageFooter";
        // 
        // xrLabel4
        // 
        this.xrLabel4.Dpi = 100F;
        this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(600F, 12.5F);
        this.xrLabel4.Name = "xrLabel4";
        this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel4.SizeF = new System.Drawing.SizeF(424.9999F, 23F);
        this.xrLabel4.StylePriority.UseTextAlignment = false;
        this.xrLabel4.Text = System.Configuration.ConfigurationManager.AppSettings["FooterText"];
        this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // ReportHeader
        // 
        this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1,
            this.xrLabel8,
            this.xrLabel9,
            this.xrLabel3,
            this.xrLabel7,
            this.xrLabel2,
            this.xrLabel6});
        this.ReportHeader.Dpi = 100F;
        this.ReportHeader.HeightF = 288.5417F;
        this.ReportHeader.Name = "ReportHeader";
        // 
        // PageHeader
        // 
        this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
        this.PageHeader.Dpi = 100F;
        this.PageHeader.HeightF = 65F;
        this.PageHeader.Name = "PageHeader";
        // 
        // xrProjectLedgerReport
        // 
        this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.GroupHeader1,
            this.GroupFooter1,
            this.PageFooter,
            this.ReportHeader,
            this.PageHeader});
        this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.ApproveLocalAmount,
            this.ApproveTotalAmount,
            this.AllocationLocalAmount,
            this.AllocationTotalAmount,
            this.RelesePMLocalAmount,
            this.RelesePMTotalAmount,
            this.ReleaseAllocationPercentage,
            this.ExpensePMLocalAmount,
            this.ExpensePMTotalAmount,
            this.ExpensePMAllocationPercentage,
            this.ExpensePMReleasePMPercentage,
            this.ReleseMLocalAmount,
            this.ReleseMTotalAmount,
            this.ExpenseMLocalAmount,
            this.ExpenseMTotalAmount,
            this.ExpenseMAllocationPercentage,
            this.ExpenseMReleaseMPercentage,
            this.ExpenseLocalAmount,
            this.ExpenseTotalAmount,
            this.ThrowForwardLocal,
            this.ThrowForwardForignFund,
            this.ThrowForwardTotal});
        this.DataMember = "SchemeList";
        this.DataSource = this.bindingSource1;
        this.Landscape = true;
        this.Margins = new System.Drawing.Printing.Margins(10, 11, 49, 49);
        this.PageHeight = 1169;
        this.PageWidth = 1654;
        this.PaperKind = System.Drawing.Printing.PaperKind.A3;
        this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.prProjectTitle,
            this.prFundType,
            this.prDateRange});
        this.RequestParameters = false;
        this.Version = "16.1";
        ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion
}
