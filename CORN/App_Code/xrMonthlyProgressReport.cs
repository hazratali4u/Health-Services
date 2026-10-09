using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

/// <summary>
/// Summary description for xrMonthlyProgressReport
/// </summary>
public class xrMonthlyProgressReport : DevExpress.XtraReports.UI.XtraReport
{
    private DevExpress.XtraReports.UI.DetailBand Detail;
    private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
    private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
    private System.Windows.Forms.BindingSource bindingSource1;
    private XRLabel xrLabel1;
    private XRTable xrTable4;
    private XRTableRow xrTableRow4;
    private XRTableCell xrTableCell16;
    private XRTableRow xrTableRow6;
    private XRTableCell xrTableCell18;
    private XRTableRow xrTableRow5;
    private XRTableCell xrTableCell17;
    private XRTable xrTable5;
    private XRTableRow xrTableRow7;
    private XRTableCell tcTotal;
    private XRTableRow xrTableRow8;
    private XRTableCell tcCapital;
    private XRTableRow xrTableRow9;
    private XRTableCell tcRevenue;
    private XRTable xrTable3;
    private XRTableRow xrTableRow3;
    private XRTableCell xrTableCell7;
    private XRTableCell xrTableCell8;
    private XRTableCell xrTableCell9;
    private XRTableCell xrTableCell10;
    private XRTableCell xrTableCell11;
    private XRTable xrTable2;
    private XRTableRow xrTableRow2;
    private XRTableCell xrTableCell2;
    private XRTableCell xrTableCell3;
    private XRTableCell xrTableCell5;
    private XRTableCell xrTableCell4;
    private XRTableCell xrTableCell6;
    private XRTableCell xrTableCell1;
    private XRTableCell xrTableCell12;
    private XRTableCell xrTableCell15;
    private XRTableCell xrTableCell19;
    private XRTableCell xrTableCell20;
    private XRTableCell xrTableCell21;
    private XRTableCell xrTableCell27;
    private XRTableCell xrTableCell28;
    private XRTableCell xrTableCell36;
    private XRTableCell xrTableCell35;
    private XRTableCell xrTableCell34;
    private XRTableCell xrTableCell33;
    private XRTableCell xrTableCell32;
    private XRTableCell xrTableCell31;
    private XRTableCell xrTableCell30;
    private XRTableCell xrTableCell29;
    private XRTable xrTable6;
    private XRTableRow xrTableRow10;
    private XRTableCell xrTableCell22;
    private XRTableCell xrTableCell23;
    private XRTableCell xrTableCell24;
    private XRTableCell xrTableCell25;
    private XRTableCell xrTableCell26;
    private XRTableCell xrTableCell50;
    private XRTableCell xrTableCell51;
    private XRTableCell xrTableCell52;
    private XRTableCell xrTableCell53;
    private XRTableCell xrTableCell54;
    private XRTableCell xrTableCell55;
    private XRTableCell xrTableCell56;
    private XRTableCell xrTableCell57;
    private GroupHeaderBand GroupHeader1;
    private XRTable xrTable1;
    private XRTableRow xrTableRow1;
    private XRTableCell xrTableCell13;
    private GroupFooterBand GroupFooter1;
    private ReportHeaderBand ReportHeader;
    private GroupHeaderBand GroupHeader2;
    private XRTable xrTable8;
    private XRTableRow xrTableRow12;
    private XRTableCell xrTableCell14;
    private GroupFooterBand GroupFooter2;
    private XRTableCell xrTableCell92;
    private XRTableCell xrTableCell93;
    private XRTable xrTable11;
    private XRTableRow xrTableRow15;
    private XRTableCell xrTableCell96;
    private XRTableRow xrTableRow16;
    private XRTableCell xrTableCell97;
    private XRTableRow xrTableRow17;
    private XRTableCell xrTableCell98;
    private XRTable xrTable12;
    private XRTableRow xrTableRow18;
    private XRTableCell xrTableCell99;
    private XRTableRow xrTableRow19;
    private XRTableCell xrTableCell100;
    private XRTableRow xrTableRow20;
    private XRTableCell xrTableCell101;
    private XRTable xrTable13;
    private XRTableRow xrTableRow21;
    private XRTableCell xrTableCell102;
    private XRTableRow xrTableRow22;
    private XRTableCell xrTableCell103;
    private XRTableRow xrTableRow23;
    private XRTableCell xrTableCell104;
    private XRTable xrTable14;
    private XRTableRow xrTableRow24;
    private XRTableCell xrTableCell105;
    private XRTableRow xrTableRow25;
    private XRTableCell xrTableCell106;
    private XRTableRow xrTableRow26;
    private XRTableCell xrTableCell107;
    private XRTable xrTable15;
    private XRTableRow xrTableRow27;
    private XRTableCell xrTableCell108;
    private XRTableRow xrTableRow28;
    private XRTableCell xrTableCell109;
    private XRTableRow xrTableRow29;
    private XRTableCell xrTableCell110;
    private XRTable xrTable16;
    private XRTableRow xrTableRow30;
    private XRTableCell xrTableCell111;
    private XRTableRow xrTableRow31;
    private XRTableCell xrTableCell112;
    private XRTableRow xrTableRow32;
    private XRTableCell xrTableCell113;
    private XRTable xrTable17;
    private XRTableRow xrTableRow33;
    private XRTableCell xrTableCell114;
    private XRTableRow xrTableRow34;
    private XRTableCell xrTableCell115;
    private XRTableRow xrTableRow35;
    private XRTableCell xrTableCell116;
    private XRTableCell xrTableCell94;
    private XRTable xrTable18;
    private XRTableRow xrTableRow36;
    private XRTableCell xrTableCell117;
    private XRTableRow xrTableRow37;
    private XRTableCell xrTableCell118;
    private XRTableRow xrTableRow38;
    private XRTableCell xrTableCell119;
    private XRTableCell xrTableCell95;
    private XRTable xrTable19;
    private XRTableRow xrTableRow39;
    private XRTableCell xrTableCell120;
    private XRTableRow xrTableRow40;
    private XRTableCell xrTableCell121;
    private XRTableRow xrTableRow41;
    private XRTableCell xrTableCell122;
    private XRTableCell xrTableCell88;
    private XRTableCell xrTableCell89;
    private XRTableCell xrTableCell90;
    private XRTableCell xrTableCell91;
    private XRTableCell xrTableCell84;
    private XRTableCell xrTableCell85;
    private XRTableCell xrTableCell86;
    private XRTableCell xrTableCell87;
    private CalculatedField TotalLastApprovedCost;
    private XRTable xrTable7;
    private XRTableRow xrTableRow11;
    private XRTableCell xrTableCell37;
    private XRTableCell xrTableCell38;
    private XRTableCell xrTableCell39;
    private XRTableCell xrTableCell40;
    private XRTableCell xrTableCell41;
    private XRTableCell xrTableCell42;
    private XRTableCell xrTableCell43;
    private XRTableCell xrTableCell44;
    private XRTableCell xrTableCell45;
    private XRTableCell xrTableCell46;
    private XRTableCell xrTableCell47;
    private XRTableCell xrTableCell48;
    private XRTableCell xrTableCell49;
    private XRTableCell xrTableCell123;
    private XRTableCell xrTableCell124;
    private XRTableCell xrTableCell125;
    private XRTableCell xrTableCell126;
    private XRTable xrTable9;
    private XRTableRow xrTableRow13;
    private XRTableCell xrTableCell58;
    private XRTableCell xrTableCell59;
    private XRTableCell xrTableCell60;
    private XRTableCell xrTableCell61;
    private XRTableCell xrTableCell62;
    private XRTableCell xrTableCell63;
    private XRTableCell xrTableCell64;
    private XRTableCell xrTableCell65;
    private XRTableCell xrTableCell66;
    private XRTableCell xrTableCell67;
    private XRTableCell xrTableCell68;
    private XRTableCell xrTableCell69;
    private XRTableCell xrTableCell70;
    private XRTableCell xrTableCell127;
    private XRTableCell xrTableCell128;
    private XRTableCell xrTableCell129;
    private XRTableCell xrTableCell130;
    private XRTable xrTable10;
    private XRTableRow xrTableRow14;
    private XRTableCell xrTableCell71;
    private XRTableCell xrTableCell72;
    private XRTableCell xrTableCell73;
    private XRTableCell xrTableCell74;
    private XRTableCell xrTableCell75;
    private XRTableCell xrTableCell76;
    private XRTableCell xrTableCell77;
    private XRTableCell xrTableCell78;
    private XRTableCell xrTableCell79;
    private XRTableCell xrTableCell80;
    private XRTableCell xrTableCell81;
    private XRTableCell xrTableCell82;
    private XRTableCell xrTableCell83;
    private XRTableCell xrTableCell131;
    private XRTableCell xrTableCell132;
    private XRTableCell xrTableCell133;
    private XRTableCell xrTableCell134;
    private CalculatedField TotalApprovedCost;
    private CalculatedField TotalCurrentRelasedCost;
    private CalculatedField TotalCurrentExpenseCost;
    private CalculatedField TotalLastExpenseCost;
    private CalculatedField PercentUtilizedCapital;
    private CalculatedField PercentUtilizedRevenue;
    private CalculatedField TotalPercentUtilized;
    private CalculatedField CumulativeExpCapital;
    private CalculatedField CumulativeExpRevenue;
    private CalculatedField TotalCumulativeExp;
    private CalculatedField FinancialProgressCapital;
    private CalculatedField FinancialProgressRevenue;
    private CalculatedField TotalFinancialProgress;
    private CalculatedField ThrowForwardCapital;
    private CalculatedField ThrowForwardRevenue;
    private CalculatedField TotalThrowForward;
    private DevExpress.XtraReports.Parameters.Parameter prMonth;
    private DevExpress.XtraReports.Parameters.Parameter prYear;
    private DevExpress.XtraReports.Parameters.Parameter prFinancialYear;
    private CalculatedField headReport;
    private CalculatedField headExpUpTo;
    private CalculatedField headProvisionFor;
    private CalculatedField headRevisedAllocation;
    private CalculatedField headFundsReleasedUpTo;
    private CalculatedField headFundsUtilizedTill;
    private DevExpress.XtraReports.Parameters.Parameter prExpectedYear;
    private CalculatedField TotalCurrentADPAllocation;
    private XRRichText xrRichText1;
    private CalculatedField CurrentRevisedAllocationCapital;
    private CalculatedField CurrentRevisedAllocationRevenue;
    private CalculatedField TotalCurrentRevisedAllocation;
    private PageFooterBand PageFooter;
    private XRLabel xrlblFooter;
    private PageHeaderBand PageHeader;
    private XRTableCell xrTableCell138;
    private XRTableCell xrTableCell137;
    private XRTableCell xrTableCell136;
    private XRTableCell xrTableCell135;
    private XRTableCell xrTableCell139;
    private XRTableCell xrTableCell140;

    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public xrMonthlyProgressReport()
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
        string resourceFileName = "xrMonthlyProgressReport.resx";
        System.Resources.ResourceManager resources = global::Resources.xrMonthlyProgressReport.ResourceManager;
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
        DevExpress.XtraReports.UI.XRSummary xrSummary21 = new DevExpress.XtraReports.UI.XRSummary();
        this.Detail = new DevExpress.XtraReports.UI.DetailBand();
        this.xrTable7 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow11 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell37 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell38 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell39 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell40 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell41 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell42 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell43 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell44 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell45 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell46 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell47 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell48 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell49 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell123 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell124 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell125 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell126 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTable6 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow10 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell22 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell92 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell23 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell93 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell24 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTable4 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell16 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableRow6 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell18 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableRow5 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell17 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell25 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTable5 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow7 = new DevExpress.XtraReports.UI.XRTableRow();
        this.tcTotal = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableRow8 = new DevExpress.XtraReports.UI.XRTableRow();
        this.tcCapital = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableRow9 = new DevExpress.XtraReports.UI.XRTableRow();
        this.tcRevenue = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell26 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell50 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTable11 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow15 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell96 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableRow16 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell97 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableRow17 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell98 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell51 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTable12 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow18 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell99 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableRow19 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell100 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableRow20 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell101 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell52 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTable13 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow21 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell102 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableRow22 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell103 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableRow23 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell104 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell53 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTable14 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow24 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell105 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableRow25 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell106 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableRow26 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell107 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell54 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTable15 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow27 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell108 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableRow28 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell109 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableRow29 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell110 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell55 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTable16 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow30 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell111 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableRow31 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell112 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableRow32 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell113 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell56 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTable17 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow33 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell114 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableRow34 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell115 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableRow35 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell116 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell94 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTable18 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow36 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell117 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableRow37 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell118 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableRow38 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell119 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell95 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTable19 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow39 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell120 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableRow40 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell121 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableRow41 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell122 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell57 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrRichText1 = new DevExpress.XtraReports.UI.XRRichText();
        this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
        this.xrTable3 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell36 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell88 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell35 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell34 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell33 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell32 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell31 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell30 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell29 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell89 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell90 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell91 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell84 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell85 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell86 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell87 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell15 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell19 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell20 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell21 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell27 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell28 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
        this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
        this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
        this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
        this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell13 = new DevExpress.XtraReports.UI.XRTableCell();
        this.GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
        this.xrTable9 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow13 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell58 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell59 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell60 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell61 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell62 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell63 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell64 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell65 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell66 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell67 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell68 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell69 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell70 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell127 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell128 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell129 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell130 = new DevExpress.XtraReports.UI.XRTableCell();
        this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
        this.GroupHeader2 = new DevExpress.XtraReports.UI.GroupHeaderBand();
        this.xrTable8 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow12 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell14 = new DevExpress.XtraReports.UI.XRTableCell();
        this.GroupFooter2 = new DevExpress.XtraReports.UI.GroupFooterBand();
        this.xrTable10 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow14 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell71 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell72 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell73 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell74 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell75 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell76 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell77 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell78 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell79 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell80 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell81 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell82 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell83 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell131 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell132 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell133 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell134 = new DevExpress.XtraReports.UI.XRTableCell();
        this.TotalLastApprovedCost = new DevExpress.XtraReports.UI.CalculatedField();
        this.TotalApprovedCost = new DevExpress.XtraReports.UI.CalculatedField();
        this.TotalCurrentRelasedCost = new DevExpress.XtraReports.UI.CalculatedField();
        this.TotalCurrentExpenseCost = new DevExpress.XtraReports.UI.CalculatedField();
        this.TotalLastExpenseCost = new DevExpress.XtraReports.UI.CalculatedField();
        this.PercentUtilizedCapital = new DevExpress.XtraReports.UI.CalculatedField();
        this.PercentUtilizedRevenue = new DevExpress.XtraReports.UI.CalculatedField();
        this.TotalPercentUtilized = new DevExpress.XtraReports.UI.CalculatedField();
        this.CumulativeExpCapital = new DevExpress.XtraReports.UI.CalculatedField();
        this.CumulativeExpRevenue = new DevExpress.XtraReports.UI.CalculatedField();
        this.TotalCumulativeExp = new DevExpress.XtraReports.UI.CalculatedField();
        this.FinancialProgressCapital = new DevExpress.XtraReports.UI.CalculatedField();
        this.FinancialProgressRevenue = new DevExpress.XtraReports.UI.CalculatedField();
        this.TotalFinancialProgress = new DevExpress.XtraReports.UI.CalculatedField();
        this.ThrowForwardCapital = new DevExpress.XtraReports.UI.CalculatedField();
        this.ThrowForwardRevenue = new DevExpress.XtraReports.UI.CalculatedField();
        this.TotalThrowForward = new DevExpress.XtraReports.UI.CalculatedField();
        this.prMonth = new DevExpress.XtraReports.Parameters.Parameter();
        this.prYear = new DevExpress.XtraReports.Parameters.Parameter();
        this.prFinancialYear = new DevExpress.XtraReports.Parameters.Parameter();
        this.headReport = new DevExpress.XtraReports.UI.CalculatedField();
        this.headExpUpTo = new DevExpress.XtraReports.UI.CalculatedField();
        this.headProvisionFor = new DevExpress.XtraReports.UI.CalculatedField();
        this.headRevisedAllocation = new DevExpress.XtraReports.UI.CalculatedField();
        this.headFundsReleasedUpTo = new DevExpress.XtraReports.UI.CalculatedField();
        this.headFundsUtilizedTill = new DevExpress.XtraReports.UI.CalculatedField();
        this.prExpectedYear = new DevExpress.XtraReports.Parameters.Parameter();
        this.TotalCurrentADPAllocation = new DevExpress.XtraReports.UI.CalculatedField();
        this.CurrentRevisedAllocationCapital = new DevExpress.XtraReports.UI.CalculatedField();
        this.CurrentRevisedAllocationRevenue = new DevExpress.XtraReports.UI.CalculatedField();
        this.TotalCurrentRevisedAllocation = new DevExpress.XtraReports.UI.CalculatedField();
        this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
        this.xrlblFooter = new DevExpress.XtraReports.UI.XRLabel();
        this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
        this.xrTableCell135 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell136 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell137 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell138 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell139 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell140 = new DevExpress.XtraReports.UI.XRTableCell();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable7)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable6)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable4)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable5)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable11)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable12)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable13)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable14)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable15)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable16)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable17)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable18)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable19)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrRichText1)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable9)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable8)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable10)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
        // 
        // Detail
        // 
        this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable7,
            this.xrTable6});
        this.Detail.Dpi = 100F;
        this.Detail.HeightF = 140F;
        this.Detail.Name = "Detail";
        this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
        this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        // 
        // xrTable7
        // 
        this.xrTable7.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTable7.Dpi = 100F;
        this.xrTable7.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Bold);
        this.xrTable7.LocationFloat = new DevExpress.Utils.PointFloat(0F, 125F);
        this.xrTable7.Name = "xrTable7";
        this.xrTable7.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow11});
        this.xrTable7.SizeF = new System.Drawing.SizeF(1424F, 15F);
        this.xrTable7.StylePriority.UseBorders = false;
        this.xrTable7.StylePriority.UseFont = false;
        this.xrTable7.StylePriority.UseTextAlignment = false;
        this.xrTable7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrTableRow11
        // 
        this.xrTableRow11.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell37,
            this.xrTableCell38,
            this.xrTableCell138,
            this.xrTableCell39,
            this.xrTableCell40,
            this.xrTableCell41,
            this.xrTableCell42,
            this.xrTableCell43,
            this.xrTableCell44,
            this.xrTableCell45,
            this.xrTableCell46,
            this.xrTableCell47,
            this.xrTableCell48,
            this.xrTableCell49,
            this.xrTableCell123,
            this.xrTableCell124,
            this.xrTableCell125,
            this.xrTableCell126});
        this.xrTableRow11.Dpi = 100F;
        this.xrTableRow11.Name = "xrTableRow11";
        this.xrTableRow11.Weight = 1D;
        // 
        // xrTableCell37
        // 
        this.xrTableCell37.Dpi = 100F;
        this.xrTableCell37.Name = "xrTableCell37";
        this.xrTableCell37.Weight = 0.133099760895676D;
        // 
        // xrTableCell38
        // 
        this.xrTableCell38.Dpi = 100F;
        this.xrTableCell38.Name = "xrTableCell38";
        this.xrTableCell38.Weight = 0.316904227261482D;
        // 
        // xrTableCell39
        // 
        this.xrTableCell39.Dpi = 100F;
        this.xrTableCell39.Name = "xrTableCell39";
        this.xrTableCell39.Weight = 0.792260498773896D;
        // 
        // xrTableCell40
        // 
        this.xrTableCell40.Dpi = 100F;
        this.xrTableCell40.Name = "xrTableCell40";
        this.xrTableCell40.Weight = 0.475356310286402D;
        // 
        // xrTableCell41
        // 
        this.xrTableCell41.Dpi = 100F;
        this.xrTableCell41.Name = "xrTableCell41";
        this.xrTableCell41.Weight = 0.0950712690049619D;
        // 
        // xrTableCell42
        // 
        this.xrTableCell42.Dpi = 100F;
        this.xrTableCell42.Name = "xrTableCell42";
        this.xrTableCell42.Weight = 0.411975452243389D;
        // 
        // xrTableCell43
        // 
        this.xrTableCell43.Dpi = 100F;
        this.xrTableCell43.Name = "xrTableCell43";
        this.xrTableCell43.Weight = 0.411975454071698D;
        // 
        // xrTableCell44
        // 
        this.xrTableCell44.Dpi = 100F;
        this.xrTableCell44.Name = "xrTableCell44";
        this.xrTableCell44.Weight = 0.411975456893082D;
        // 
        // xrTableCell45
        // 
        this.xrTableCell45.Dpi = 100F;
        this.xrTableCell45.Name = "xrTableCell45";
        this.xrTableCell45.Weight = 0.411975469510071D;
        // 
        // xrTableCell46
        // 
        this.xrTableCell46.Dpi = 100F;
        this.xrTableCell46.Name = "xrTableCell46";
        this.xrTableCell46.Weight = 0.411975472416177D;
        // 
        // xrTableCell47
        // 
        this.xrTableCell47.Dpi = 100F;
        this.xrTableCell47.Name = "xrTableCell47";
        this.xrTableCell47.Weight = 0.411975466603965D;
        // 
        // xrTableCell48
        // 
        this.xrTableCell48.Dpi = 100F;
        this.xrTableCell48.Name = "xrTableCell48";
        this.xrTableCell48.Weight = 0.411975462519058D;
        // 
        // xrTableCell49
        // 
        this.xrTableCell49.Dpi = 100F;
        this.xrTableCell49.Name = "xrTableCell49";
        this.xrTableCell49.Weight = 0.411975452428494D;
        // 
        // xrTableCell123
        // 
        this.xrTableCell123.Dpi = 100F;
        this.xrTableCell123.Name = "xrTableCell123";
        this.xrTableCell123.Weight = 0.411975429693881D;
        // 
        // xrTableCell124
        // 
        this.xrTableCell124.Dpi = 100F;
        this.xrTableCell124.Name = "xrTableCell124";
        this.xrTableCell124.Weight = 0.411975429693881D;
        // 
        // xrTableCell125
        // 
        this.xrTableCell125.Dpi = 100F;
        this.xrTableCell125.Name = "xrTableCell125";
        this.xrTableCell125.Weight = 0.411975429693881D;
        // 
        // xrTableCell126
        // 
        this.xrTableCell126.Dpi = 100F;
        this.xrTableCell126.Name = "xrTableCell126";
        this.xrTableCell126.Weight = 2.36410528079954D;
        // 
        // xrTable6
        // 
        this.xrTable6.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTable6.Dpi = 100F;
        this.xrTable6.Font = new System.Drawing.Font("Arial", 8.5F);
        this.xrTable6.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrTable6.Name = "xrTable6";
        this.xrTable6.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow10});
        this.xrTable6.SizeF = new System.Drawing.SizeF(1424F, 125F);
        this.xrTable6.StylePriority.UseBorders = false;
        this.xrTable6.StylePriority.UseFont = false;
        this.xrTable6.StylePriority.UseTextAlignment = false;
        this.xrTable6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrTableRow10
        // 
        this.xrTableRow10.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell22,
            this.xrTableCell92,
            this.xrTableCell137,
            this.xrTableCell23,
            this.xrTableCell93,
            this.xrTableCell24,
            this.xrTableCell25,
            this.xrTableCell26,
            this.xrTableCell50,
            this.xrTableCell51,
            this.xrTableCell52,
            this.xrTableCell53,
            this.xrTableCell54,
            this.xrTableCell55,
            this.xrTableCell56,
            this.xrTableCell94,
            this.xrTableCell95,
            this.xrTableCell57});
        this.xrTableRow10.Dpi = 100F;
        this.xrTableRow10.Name = "xrTableRow10";
        this.xrTableRow10.Weight = 1D;
        // 
        // xrTableCell22
        // 
        this.xrTableCell22.Dpi = 100F;
        this.xrTableCell22.Font = new System.Drawing.Font("Times New Roman", 8.5F);
        this.xrTableCell22.Name = "xrTableCell22";
        this.xrTableCell22.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
        this.xrTableCell22.StylePriority.UseFont = false;
        this.xrTableCell22.StylePriority.UsePadding = false;
        this.xrTableCell22.StylePriority.UseTextAlignment = false;
        xrSummary1.Func = DevExpress.XtraReports.UI.SummaryFunc.RecordNumber;
        xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
        this.xrTableCell22.Summary = xrSummary1;
        this.xrTableCell22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        this.xrTableCell22.Weight = 0.133099760927469D;
        // 
        // xrTableCell92
        // 
        this.xrTableCell92.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ADPNo")});
        this.xrTableCell92.Dpi = 100F;
        this.xrTableCell92.Font = new System.Drawing.Font("Times New Roman", 8.5F);
        this.xrTableCell92.Name = "xrTableCell92";
        this.xrTableCell92.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
        this.xrTableCell92.StylePriority.UseFont = false;
        this.xrTableCell92.StylePriority.UsePadding = false;
        this.xrTableCell92.StylePriority.UseTextAlignment = false;
        this.xrTableCell92.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        this.xrTableCell92.Weight = 0.316904197272187D;
        // 
        // xrTableCell23
        // 
        this.xrTableCell23.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.Title")});
        this.xrTableCell23.Dpi = 100F;
        this.xrTableCell23.Name = "xrTableCell23";
        this.xrTableCell23.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
        this.xrTableCell23.StylePriority.UsePadding = false;
        this.xrTableCell23.StylePriority.UseTextAlignment = false;
        this.xrTableCell23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        this.xrTableCell23.Weight = 0.792260480096146D;
        // 
        // xrTableCell93
        // 
        this.xrTableCell93.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ApprovedStatusAndDate")});
        this.xrTableCell93.Dpi = 100F;
        this.xrTableCell93.Multiline = true;
        this.xrTableCell93.Name = "xrTableCell93";
        this.xrTableCell93.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
        this.xrTableCell93.StylePriority.UsePadding = false;
        this.xrTableCell93.StylePriority.UseTextAlignment = false;
        this.xrTableCell93.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        this.xrTableCell93.Weight = 0.475356278510145D;
        // 
        // xrTableCell24
        // 
        this.xrTableCell24.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable4});
        this.xrTableCell24.Dpi = 100F;
        this.xrTableCell24.Name = "xrTableCell24";
        this.xrTableCell24.Weight = 0.0950712621584072D;
        // 
        // xrTable4
        // 
        this.xrTable4.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTable4.Dpi = 100F;
        this.xrTable4.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrTable4.Name = "xrTable4";
        this.xrTable4.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow4,
            this.xrTableRow6,
            this.xrTableRow5});
        this.xrTable4.SizeF = new System.Drawing.SizeF(14F, 125F);
        this.xrTable4.StylePriority.UseBorders = false;
        this.xrTable4.StylePriority.UseTextAlignment = false;
        this.xrTable4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrTableRow4
        // 
        this.xrTableRow4.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell16});
        this.xrTableRow4.Dpi = 100F;
        this.xrTableRow4.Name = "xrTableRow4";
        this.xrTableRow4.Weight = 1D;
        // 
        // xrTableCell16
        // 
        this.xrTableCell16.Dpi = 100F;
        this.xrTableCell16.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Bold);
        this.xrTableCell16.Name = "xrTableCell16";
        this.xrTableCell16.StylePriority.UseFont = false;
        this.xrTableCell16.Text = "T";
        this.xrTableCell16.Weight = 1D;
        // 
        // xrTableRow6
        // 
        this.xrTableRow6.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell18});
        this.xrTableRow6.Dpi = 100F;
        this.xrTableRow6.Name = "xrTableRow6";
        this.xrTableRow6.Weight = 1D;
        // 
        // xrTableCell18
        // 
        this.xrTableCell18.Dpi = 100F;
        this.xrTableCell18.Font = new System.Drawing.Font("Times New Roman", 8.5F);
        this.xrTableCell18.Name = "xrTableCell18";
        this.xrTableCell18.StylePriority.UseFont = false;
        this.xrTableCell18.Text = "C";
        this.xrTableCell18.Weight = 1D;
        // 
        // xrTableRow5
        // 
        this.xrTableRow5.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell17});
        this.xrTableRow5.Dpi = 100F;
        this.xrTableRow5.Name = "xrTableRow5";
        this.xrTableRow5.Weight = 1D;
        // 
        // xrTableCell17
        // 
        this.xrTableCell17.Borders = DevExpress.XtraPrinting.BorderSide.Top;
        this.xrTableCell17.Dpi = 100F;
        this.xrTableCell17.Font = new System.Drawing.Font("Times New Roman", 8.5F);
        this.xrTableCell17.Name = "xrTableCell17";
        this.xrTableCell17.StylePriority.UseBorders = false;
        this.xrTableCell17.StylePriority.UseFont = false;
        this.xrTableCell17.Text = "R";
        this.xrTableCell17.Weight = 1D;
        // 
        // xrTableCell25
        // 
        this.xrTableCell25.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable5});
        this.xrTableCell25.Dpi = 100F;
        this.xrTableCell25.Name = "xrTableCell25";
        this.xrTableCell25.Weight = 0.411975464337985D;
        // 
        // xrTable5
        // 
        this.xrTable5.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTable5.Dpi = 100F;
        this.xrTable5.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
        this.xrTable5.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrTable5.Name = "xrTable5";
        this.xrTable5.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow7,
            this.xrTableRow8,
            this.xrTableRow9});
        this.xrTable5.SizeF = new System.Drawing.SizeF(64F, 125F);
        this.xrTable5.StylePriority.UseBorders = false;
        this.xrTable5.StylePriority.UseFont = false;
        this.xrTable5.StylePriority.UseTextAlignment = false;
        this.xrTable5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrTableRow7
        // 
        this.xrTableRow7.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tcTotal});
        this.xrTableRow7.Dpi = 100F;
        this.xrTableRow7.Name = "xrTableRow7";
        this.xrTableRow7.Weight = 1D;
        // 
        // tcTotal
        // 
        this.tcTotal.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.TotalLastApprovedCost", "{0:#,#}")});
        this.tcTotal.Dpi = 100F;
        this.tcTotal.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Bold);
        this.tcTotal.Name = "tcTotal";
        this.tcTotal.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
        this.tcTotal.StylePriority.UseFont = false;
        this.tcTotal.StylePriority.UsePadding = false;
        this.tcTotal.Weight = 1D;
        // 
        // xrTableRow8
        // 
        this.xrTableRow8.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tcCapital});
        this.xrTableRow8.Dpi = 100F;
        this.xrTableRow8.Name = "xrTableRow8";
        this.xrTableRow8.Weight = 1D;
        // 
        // tcCapital
        // 
        this.tcCapital.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.LastApprovedCapital", "{0:#,#}")});
        this.tcCapital.Dpi = 100F;
        this.tcCapital.Font = new System.Drawing.Font("Times New Roman", 8.5F);
        this.tcCapital.Name = "tcCapital";
        this.tcCapital.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
        this.tcCapital.StylePriority.UseFont = false;
        this.tcCapital.StylePriority.UsePadding = false;
        this.tcCapital.Weight = 1D;
        // 
        // xrTableRow9
        // 
        this.xrTableRow9.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tcRevenue});
        this.xrTableRow9.Dpi = 100F;
        this.xrTableRow9.Name = "xrTableRow9";
        this.xrTableRow9.Weight = 1D;
        // 
        // tcRevenue
        // 
        this.tcRevenue.Borders = DevExpress.XtraPrinting.BorderSide.Top;
        this.tcRevenue.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.LastApprovedRevenue", "{0:#,#}")});
        this.tcRevenue.Dpi = 100F;
        this.tcRevenue.Font = new System.Drawing.Font("Times New Roman", 8.5F);
        this.tcRevenue.Name = "tcRevenue";
        this.tcRevenue.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
        this.tcRevenue.StylePriority.UseBorders = false;
        this.tcRevenue.StylePriority.UseFont = false;
        this.tcRevenue.StylePriority.UsePadding = false;
        this.tcRevenue.Weight = 1D;
        // 
        // xrTableCell26
        // 
        this.xrTableCell26.Dpi = 100F;
        this.xrTableCell26.Name = "xrTableCell26";
        this.xrTableCell26.Weight = 0.411975452542569D;
        // 
        // xrTableCell50
        // 
        this.xrTableCell50.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable11});
        this.xrTableCell50.Dpi = 100F;
        this.xrTableCell50.Name = "xrTableCell50";
        this.xrTableCell50.Weight = 0.411975454019885D;
        // 
        // xrTable11
        // 
        this.xrTable11.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTable11.Dpi = 100F;
        this.xrTable11.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
        this.xrTable11.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrTable11.Name = "xrTable11";
        this.xrTable11.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow15,
            this.xrTableRow16,
            this.xrTableRow17});
        this.xrTable11.SizeF = new System.Drawing.SizeF(64F, 125F);
        this.xrTable11.StylePriority.UseBorders = false;
        this.xrTable11.StylePriority.UseFont = false;
        this.xrTable11.StylePriority.UseTextAlignment = false;
        this.xrTable11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrTableRow15
        // 
        this.xrTableRow15.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell96});
        this.xrTableRow15.Dpi = 100F;
        this.xrTableRow15.Name = "xrTableRow15";
        this.xrTableRow15.Weight = 1D;
        // 
        // xrTableCell96
        // 
        this.xrTableCell96.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.TotalLastExpenseCost", "{0:#,#}")});
        this.xrTableCell96.Dpi = 100F;
        this.xrTableCell96.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Bold);
        this.xrTableCell96.Name = "xrTableCell96";
        this.xrTableCell96.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
        this.xrTableCell96.StylePriority.UseFont = false;
        this.xrTableCell96.StylePriority.UsePadding = false;
        this.xrTableCell96.Weight = 1D;
        // 
        // xrTableRow16
        // 
        this.xrTableRow16.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell97});
        this.xrTableRow16.Dpi = 100F;
        this.xrTableRow16.Name = "xrTableRow16";
        this.xrTableRow16.Weight = 1D;
        // 
        // xrTableCell97
        // 
        this.xrTableCell97.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.LastExpenseCapital", "{0:#,#}")});
        this.xrTableCell97.Dpi = 100F;
        this.xrTableCell97.Font = new System.Drawing.Font("Times New Roman", 8.5F);
        this.xrTableCell97.Name = "xrTableCell97";
        this.xrTableCell97.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
        this.xrTableCell97.StylePriority.UseFont = false;
        this.xrTableCell97.StylePriority.UsePadding = false;
        this.xrTableCell97.Weight = 1D;
        // 
        // xrTableRow17
        // 
        this.xrTableRow17.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell98});
        this.xrTableRow17.Dpi = 100F;
        this.xrTableRow17.Name = "xrTableRow17";
        this.xrTableRow17.Weight = 1D;
        // 
        // xrTableCell98
        // 
        this.xrTableCell98.Borders = DevExpress.XtraPrinting.BorderSide.Top;
        this.xrTableCell98.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.LastExpenseRevenue", "{0:#,#}")});
        this.xrTableCell98.Dpi = 100F;
        this.xrTableCell98.Font = new System.Drawing.Font("Times New Roman", 8.5F);
        this.xrTableCell98.Name = "xrTableCell98";
        this.xrTableCell98.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
        this.xrTableCell98.StylePriority.UseBorders = false;
        this.xrTableCell98.StylePriority.UseFont = false;
        this.xrTableCell98.StylePriority.UsePadding = false;
        this.xrTableCell98.Weight = 1D;
        // 
        // xrTableCell51
        // 
        this.xrTableCell51.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable12});
        this.xrTableCell51.Dpi = 100F;
        this.xrTableCell51.Name = "xrTableCell51";
        this.xrTableCell51.Weight = 0.411975456789455D;
        // 
        // xrTable12
        // 
        this.xrTable12.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTable12.Dpi = 100F;
        this.xrTable12.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
        this.xrTable12.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrTable12.Name = "xrTable12";
        this.xrTable12.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow18,
            this.xrTableRow19,
            this.xrTableRow20});
        this.xrTable12.SizeF = new System.Drawing.SizeF(64F, 125F);
        this.xrTable12.StylePriority.UseBorders = false;
        this.xrTable12.StylePriority.UseFont = false;
        this.xrTable12.StylePriority.UseTextAlignment = false;
        this.xrTable12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrTableRow18
        // 
        this.xrTableRow18.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell99});
        this.xrTableRow18.Dpi = 100F;
        this.xrTableRow18.Name = "xrTableRow18";
        this.xrTableRow18.Weight = 1D;
        // 
        // xrTableCell99
        // 
        this.xrTableCell99.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.TotalCurrentADPAllocation", "{0:#,#}")});
        this.xrTableCell99.Dpi = 100F;
        this.xrTableCell99.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Bold);
        this.xrTableCell99.Name = "xrTableCell99";
        this.xrTableCell99.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
        this.xrTableCell99.StylePriority.UseFont = false;
        this.xrTableCell99.StylePriority.UsePadding = false;
        this.xrTableCell99.Weight = 1D;
        // 
        // xrTableRow19
        // 
        this.xrTableRow19.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell100});
        this.xrTableRow19.Dpi = 100F;
        this.xrTableRow19.Name = "xrTableRow19";
        this.xrTableRow19.Weight = 1D;
        // 
        // xrTableCell100
        // 
        this.xrTableCell100.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.CurrentADPAllocationCapital", "{0:#,#}")});
        this.xrTableCell100.Dpi = 100F;
        this.xrTableCell100.Font = new System.Drawing.Font("Times New Roman", 8.5F);
        this.xrTableCell100.Name = "xrTableCell100";
        this.xrTableCell100.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
        this.xrTableCell100.StylePriority.UseFont = false;
        this.xrTableCell100.StylePriority.UsePadding = false;
        this.xrTableCell100.Weight = 1D;
        // 
        // xrTableRow20
        // 
        this.xrTableRow20.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell101});
        this.xrTableRow20.Dpi = 100F;
        this.xrTableRow20.Name = "xrTableRow20";
        this.xrTableRow20.Weight = 1D;
        // 
        // xrTableCell101
        // 
        this.xrTableCell101.Borders = DevExpress.XtraPrinting.BorderSide.Top;
        this.xrTableCell101.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.CurrentADPAllocationRevenue", "{0:#,#}")});
        this.xrTableCell101.Dpi = 100F;
        this.xrTableCell101.Font = new System.Drawing.Font("Times New Roman", 8.5F);
        this.xrTableCell101.Name = "xrTableCell101";
        this.xrTableCell101.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
        this.xrTableCell101.StylePriority.UseBorders = false;
        this.xrTableCell101.StylePriority.UseFont = false;
        this.xrTableCell101.StylePriority.UsePadding = false;
        this.xrTableCell101.Weight = 1D;
        // 
        // xrTableCell52
        // 
        this.xrTableCell52.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable13});
        this.xrTableCell52.Dpi = 100F;
        this.xrTableCell52.Name = "xrTableCell52";
        this.xrTableCell52.Weight = 0.411975469613698D;
        // 
        // xrTable13
        // 
        this.xrTable13.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTable13.Dpi = 100F;
        this.xrTable13.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
        this.xrTable13.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrTable13.Name = "xrTable13";
        this.xrTable13.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow21,
            this.xrTableRow22,
            this.xrTableRow23});
        this.xrTable13.SizeF = new System.Drawing.SizeF(64F, 125F);
        this.xrTable13.StylePriority.UseBorders = false;
        this.xrTable13.StylePriority.UseFont = false;
        this.xrTable13.StylePriority.UseTextAlignment = false;
        this.xrTable13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrTableRow21
        // 
        this.xrTableRow21.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell102});
        this.xrTableRow21.Dpi = 100F;
        this.xrTableRow21.Name = "xrTableRow21";
        this.xrTableRow21.Weight = 1D;
        // 
        // xrTableCell102
        // 
        this.xrTableCell102.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.TotalCurrentRevisedAllocation", "{0:#,#}")});
        this.xrTableCell102.Dpi = 100F;
        this.xrTableCell102.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Bold);
        this.xrTableCell102.Name = "xrTableCell102";
        this.xrTableCell102.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
        this.xrTableCell102.StylePriority.UseFont = false;
        this.xrTableCell102.StylePriority.UsePadding = false;
        this.xrTableCell102.Weight = 1D;
        // 
        // xrTableRow22
        // 
        this.xrTableRow22.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell103});
        this.xrTableRow22.Dpi = 100F;
        this.xrTableRow22.Name = "xrTableRow22";
        this.xrTableRow22.Weight = 1D;
        // 
        // xrTableCell103
        // 
        this.xrTableCell103.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.CurrentRevisedAllocationCapital", "{0:#,#}")});
        this.xrTableCell103.Dpi = 100F;
        this.xrTableCell103.Font = new System.Drawing.Font("Times New Roman", 8.5F);
        this.xrTableCell103.Name = "xrTableCell103";
        this.xrTableCell103.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
        this.xrTableCell103.StylePriority.UseFont = false;
        this.xrTableCell103.StylePriority.UsePadding = false;
        this.xrTableCell103.Weight = 1D;
        // 
        // xrTableRow23
        // 
        this.xrTableRow23.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell104});
        this.xrTableRow23.Dpi = 100F;
        this.xrTableRow23.Name = "xrTableRow23";
        this.xrTableRow23.Weight = 1D;
        // 
        // xrTableCell104
        // 
        this.xrTableCell104.Borders = DevExpress.XtraPrinting.BorderSide.Top;
        this.xrTableCell104.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.CurrentRevisedAllocationRevenue", "{0:#,#}")});
        this.xrTableCell104.Dpi = 100F;
        this.xrTableCell104.Font = new System.Drawing.Font("Times New Roman", 8.5F);
        this.xrTableCell104.Name = "xrTableCell104";
        this.xrTableCell104.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
        this.xrTableCell104.StylePriority.UseBorders = false;
        this.xrTableCell104.StylePriority.UseFont = false;
        this.xrTableCell104.StylePriority.UsePadding = false;
        this.xrTableCell104.Weight = 1D;
        // 
        // xrTableCell53
        // 
        this.xrTableCell53.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable14});
        this.xrTableCell53.Dpi = 100F;
        this.xrTableCell53.Name = "xrTableCell53";
        this.xrTableCell53.Weight = 0.41197547246799D;
        // 
        // xrTable14
        // 
        this.xrTable14.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTable14.Dpi = 100F;
        this.xrTable14.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
        this.xrTable14.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrTable14.Name = "xrTable14";
        this.xrTable14.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow24,
            this.xrTableRow25,
            this.xrTableRow26});
        this.xrTable14.SizeF = new System.Drawing.SizeF(64F, 125F);
        this.xrTable14.StylePriority.UseBorders = false;
        this.xrTable14.StylePriority.UseFont = false;
        this.xrTable14.StylePriority.UseTextAlignment = false;
        this.xrTable14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrTableRow24
        // 
        this.xrTableRow24.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell105});
        this.xrTableRow24.Dpi = 100F;
        this.xrTableRow24.Name = "xrTableRow24";
        this.xrTableRow24.Weight = 1D;
        // 
        // xrTableCell105
        // 
        this.xrTableCell105.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.TotalCurrentRelasedCost", "{0:#,#}")});
        this.xrTableCell105.Dpi = 100F;
        this.xrTableCell105.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Bold);
        this.xrTableCell105.Name = "xrTableCell105";
        this.xrTableCell105.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
        this.xrTableCell105.StylePriority.UseFont = false;
        this.xrTableCell105.StylePriority.UsePadding = false;
        this.xrTableCell105.Weight = 1D;
        // 
        // xrTableRow25
        // 
        this.xrTableRow25.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell106});
        this.xrTableRow25.Dpi = 100F;
        this.xrTableRow25.Name = "xrTableRow25";
        this.xrTableRow25.Weight = 1D;
        // 
        // xrTableCell106
        // 
        this.xrTableCell106.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.CurrentReleaseCapital", "{0:#,#}")});
        this.xrTableCell106.Dpi = 100F;
        this.xrTableCell106.Font = new System.Drawing.Font("Times New Roman", 8.5F);
        this.xrTableCell106.Name = "xrTableCell106";
        this.xrTableCell106.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
        this.xrTableCell106.StylePriority.UseFont = false;
        this.xrTableCell106.StylePriority.UsePadding = false;
        this.xrTableCell106.Weight = 1D;
        // 
        // xrTableRow26
        // 
        this.xrTableRow26.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell107});
        this.xrTableRow26.Dpi = 100F;
        this.xrTableRow26.Name = "xrTableRow26";
        this.xrTableRow26.Weight = 1D;
        // 
        // xrTableCell107
        // 
        this.xrTableCell107.Borders = DevExpress.XtraPrinting.BorderSide.Top;
        this.xrTableCell107.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.CurrentReleaseRevenue", "{0:#,#}")});
        this.xrTableCell107.Dpi = 100F;
        this.xrTableCell107.Font = new System.Drawing.Font("Times New Roman", 8.5F);
        this.xrTableCell107.Name = "xrTableCell107";
        this.xrTableCell107.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
        this.xrTableCell107.StylePriority.UseBorders = false;
        this.xrTableCell107.StylePriority.UseFont = false;
        this.xrTableCell107.StylePriority.UsePadding = false;
        this.xrTableCell107.Weight = 1D;
        // 
        // xrTableCell54
        // 
        this.xrTableCell54.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable15});
        this.xrTableCell54.Dpi = 100F;
        this.xrTableCell54.Name = "xrTableCell54";
        this.xrTableCell54.Weight = 0.411975466759405D;
        // 
        // xrTable15
        // 
        this.xrTable15.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTable15.Dpi = 100F;
        this.xrTable15.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
        this.xrTable15.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrTable15.Name = "xrTable15";
        this.xrTable15.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow27,
            this.xrTableRow28,
            this.xrTableRow29});
        this.xrTable15.SizeF = new System.Drawing.SizeF(64F, 125F);
        this.xrTable15.StylePriority.UseBorders = false;
        this.xrTable15.StylePriority.UseFont = false;
        this.xrTable15.StylePriority.UseTextAlignment = false;
        this.xrTable15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrTableRow27
        // 
        this.xrTableRow27.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell108});
        this.xrTableRow27.Dpi = 100F;
        this.xrTableRow27.Name = "xrTableRow27";
        this.xrTableRow27.Weight = 1D;
        // 
        // xrTableCell108
        // 
        this.xrTableCell108.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.TotalCurrentExpenseCost", "{0:#,#}")});
        this.xrTableCell108.Dpi = 100F;
        this.xrTableCell108.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Bold);
        this.xrTableCell108.Name = "xrTableCell108";
        this.xrTableCell108.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
        this.xrTableCell108.StylePriority.UseFont = false;
        this.xrTableCell108.StylePriority.UsePadding = false;
        this.xrTableCell108.Weight = 1D;
        // 
        // xrTableRow28
        // 
        this.xrTableRow28.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell109});
        this.xrTableRow28.Dpi = 100F;
        this.xrTableRow28.Name = "xrTableRow28";
        this.xrTableRow28.Weight = 1D;
        // 
        // xrTableCell109
        // 
        this.xrTableCell109.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.CurrentExpenseCapital", "{0:#,#}")});
        this.xrTableCell109.Dpi = 100F;
        this.xrTableCell109.Font = new System.Drawing.Font("Times New Roman", 8.5F);
        this.xrTableCell109.Name = "xrTableCell109";
        this.xrTableCell109.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
        this.xrTableCell109.StylePriority.UseFont = false;
        this.xrTableCell109.StylePriority.UsePadding = false;
        this.xrTableCell109.Weight = 1D;
        // 
        // xrTableRow29
        // 
        this.xrTableRow29.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell110});
        this.xrTableRow29.Dpi = 100F;
        this.xrTableRow29.Name = "xrTableRow29";
        this.xrTableRow29.Weight = 1D;
        // 
        // xrTableCell110
        // 
        this.xrTableCell110.Borders = DevExpress.XtraPrinting.BorderSide.Top;
        this.xrTableCell110.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.CurrentExpenseRevenue", "{0:#,#}")});
        this.xrTableCell110.Dpi = 100F;
        this.xrTableCell110.Font = new System.Drawing.Font("Times New Roman", 8.5F);
        this.xrTableCell110.Name = "xrTableCell110";
        this.xrTableCell110.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
        this.xrTableCell110.StylePriority.UseBorders = false;
        this.xrTableCell110.StylePriority.UseFont = false;
        this.xrTableCell110.StylePriority.UsePadding = false;
        this.xrTableCell110.Weight = 1D;
        // 
        // xrTableCell55
        // 
        this.xrTableCell55.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable16});
        this.xrTableCell55.Dpi = 100F;
        this.xrTableCell55.Name = "xrTableCell55";
        this.xrTableCell55.Weight = 0.411975462664135D;
        // 
        // xrTable16
        // 
        this.xrTable16.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTable16.Dpi = 100F;
        this.xrTable16.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
        this.xrTable16.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrTable16.Name = "xrTable16";
        this.xrTable16.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow30,
            this.xrTableRow31,
            this.xrTableRow32});
        this.xrTable16.SizeF = new System.Drawing.SizeF(64F, 125F);
        this.xrTable16.StylePriority.UseBorders = false;
        this.xrTable16.StylePriority.UseFont = false;
        this.xrTable16.StylePriority.UseTextAlignment = false;
        this.xrTable16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrTableRow30
        // 
        this.xrTableRow30.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell111});
        this.xrTableRow30.Dpi = 100F;
        this.xrTableRow30.Name = "xrTableRow30";
        this.xrTableRow30.Weight = 1D;
        // 
        // xrTableCell111
        // 
        this.xrTableCell111.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.TotalPercentUtilized", "{0:0.00%}")});
        this.xrTableCell111.Dpi = 100F;
        this.xrTableCell111.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Bold);
        this.xrTableCell111.Name = "xrTableCell111";
        this.xrTableCell111.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
        this.xrTableCell111.StylePriority.UseFont = false;
        this.xrTableCell111.StylePriority.UsePadding = false;
        this.xrTableCell111.Weight = 1D;
        // 
        // xrTableRow31
        // 
        this.xrTableRow31.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell112});
        this.xrTableRow31.Dpi = 100F;
        this.xrTableRow31.Name = "xrTableRow31";
        this.xrTableRow31.Weight = 1D;
        // 
        // xrTableCell112
        // 
        this.xrTableCell112.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.PercentUtilizedCapital", "{0:0.00%}")});
        this.xrTableCell112.Dpi = 100F;
        this.xrTableCell112.Font = new System.Drawing.Font("Times New Roman", 8.5F);
        this.xrTableCell112.Name = "xrTableCell112";
        this.xrTableCell112.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
        this.xrTableCell112.StylePriority.UseFont = false;
        this.xrTableCell112.StylePriority.UsePadding = false;
        this.xrTableCell112.Weight = 1D;
        // 
        // xrTableRow32
        // 
        this.xrTableRow32.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell113});
        this.xrTableRow32.Dpi = 100F;
        this.xrTableRow32.Name = "xrTableRow32";
        this.xrTableRow32.Weight = 1D;
        // 
        // xrTableCell113
        // 
        this.xrTableCell113.Borders = DevExpress.XtraPrinting.BorderSide.Top;
        this.xrTableCell113.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.PercentUtilizedRevenue", "{0:0.00%}")});
        this.xrTableCell113.Dpi = 100F;
        this.xrTableCell113.Font = new System.Drawing.Font("Times New Roman", 8.5F);
        this.xrTableCell113.Name = "xrTableCell113";
        this.xrTableCell113.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
        this.xrTableCell113.StylePriority.UseBorders = false;
        this.xrTableCell113.StylePriority.UseFont = false;
        this.xrTableCell113.StylePriority.UsePadding = false;
        this.xrTableCell113.Weight = 1D;
        // 
        // xrTableCell56
        // 
        this.xrTableCell56.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable17});
        this.xrTableCell56.Dpi = 100F;
        this.xrTableCell56.Name = "xrTableCell56";
        this.xrTableCell56.Weight = 0.411975452625386D;
        // 
        // xrTable17
        // 
        this.xrTable17.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTable17.Dpi = 100F;
        this.xrTable17.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
        this.xrTable17.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrTable17.Name = "xrTable17";
        this.xrTable17.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow33,
            this.xrTableRow34,
            this.xrTableRow35});
        this.xrTable17.SizeF = new System.Drawing.SizeF(64F, 125F);
        this.xrTable17.StylePriority.UseBorders = false;
        this.xrTable17.StylePriority.UseFont = false;
        this.xrTable17.StylePriority.UseTextAlignment = false;
        this.xrTable17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrTableRow33
        // 
        this.xrTableRow33.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell114});
        this.xrTableRow33.Dpi = 100F;
        this.xrTableRow33.Name = "xrTableRow33";
        this.xrTableRow33.Weight = 1D;
        // 
        // xrTableCell114
        // 
        this.xrTableCell114.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.TotalCumulativeExp", "{0:#,#}")});
        this.xrTableCell114.Dpi = 100F;
        this.xrTableCell114.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Bold);
        this.xrTableCell114.Name = "xrTableCell114";
        this.xrTableCell114.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
        this.xrTableCell114.StylePriority.UseFont = false;
        this.xrTableCell114.StylePriority.UsePadding = false;
        this.xrTableCell114.Weight = 1D;
        // 
        // xrTableRow34
        // 
        this.xrTableRow34.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell115});
        this.xrTableRow34.Dpi = 100F;
        this.xrTableRow34.Name = "xrTableRow34";
        this.xrTableRow34.Weight = 1D;
        // 
        // xrTableCell115
        // 
        this.xrTableCell115.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.CumulativeExpCapital", "{0:#,#}")});
        this.xrTableCell115.Dpi = 100F;
        this.xrTableCell115.Font = new System.Drawing.Font("Times New Roman", 8.5F);
        this.xrTableCell115.Name = "xrTableCell115";
        this.xrTableCell115.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
        this.xrTableCell115.StylePriority.UseFont = false;
        this.xrTableCell115.StylePriority.UsePadding = false;
        this.xrTableCell115.Weight = 1D;
        // 
        // xrTableRow35
        // 
        this.xrTableRow35.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell116});
        this.xrTableRow35.Dpi = 100F;
        this.xrTableRow35.Name = "xrTableRow35";
        this.xrTableRow35.Weight = 1D;
        // 
        // xrTableCell116
        // 
        this.xrTableCell116.Borders = DevExpress.XtraPrinting.BorderSide.Top;
        this.xrTableCell116.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.CumulativeExpRevenue", "{0:#,#}")});
        this.xrTableCell116.Dpi = 100F;
        this.xrTableCell116.Font = new System.Drawing.Font("Times New Roman", 8.5F);
        this.xrTableCell116.Name = "xrTableCell116";
        this.xrTableCell116.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
        this.xrTableCell116.StylePriority.UseBorders = false;
        this.xrTableCell116.StylePriority.UseFont = false;
        this.xrTableCell116.StylePriority.UsePadding = false;
        this.xrTableCell116.Weight = 1D;
        // 
        // xrTableCell94
        // 
        this.xrTableCell94.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable18});
        this.xrTableCell94.Dpi = 100F;
        this.xrTableCell94.Name = "xrTableCell94";
        this.xrTableCell94.Weight = 0.411975452625386D;
        // 
        // xrTable18
        // 
        this.xrTable18.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTable18.Dpi = 100F;
        this.xrTable18.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
        this.xrTable18.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrTable18.Name = "xrTable18";
        this.xrTable18.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow36,
            this.xrTableRow37,
            this.xrTableRow38});
        this.xrTable18.SizeF = new System.Drawing.SizeF(64F, 125F);
        this.xrTable18.StylePriority.UseBorders = false;
        this.xrTable18.StylePriority.UseFont = false;
        this.xrTable18.StylePriority.UseTextAlignment = false;
        this.xrTable18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrTableRow36
        // 
        this.xrTableRow36.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell117});
        this.xrTableRow36.Dpi = 100F;
        this.xrTableRow36.Name = "xrTableRow36";
        this.xrTableRow36.Weight = 1D;
        // 
        // xrTableCell117
        // 
        this.xrTableCell117.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.TotalFinancialProgress", "{0:0.00%}")});
        this.xrTableCell117.Dpi = 100F;
        this.xrTableCell117.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Bold);
        this.xrTableCell117.Name = "xrTableCell117";
        this.xrTableCell117.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
        this.xrTableCell117.StylePriority.UseFont = false;
        this.xrTableCell117.StylePriority.UsePadding = false;
        this.xrTableCell117.Weight = 1D;
        // 
        // xrTableRow37
        // 
        this.xrTableRow37.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell118});
        this.xrTableRow37.Dpi = 100F;
        this.xrTableRow37.Name = "xrTableRow37";
        this.xrTableRow37.Weight = 1D;
        // 
        // xrTableCell118
        // 
        this.xrTableCell118.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.FinancialProgressCapital", "{0:0.00%}")});
        this.xrTableCell118.Dpi = 100F;
        this.xrTableCell118.Font = new System.Drawing.Font("Times New Roman", 8.5F);
        this.xrTableCell118.Name = "xrTableCell118";
        this.xrTableCell118.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
        this.xrTableCell118.StylePriority.UseFont = false;
        this.xrTableCell118.StylePriority.UsePadding = false;
        this.xrTableCell118.Weight = 1D;
        // 
        // xrTableRow38
        // 
        this.xrTableRow38.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell119});
        this.xrTableRow38.Dpi = 100F;
        this.xrTableRow38.Name = "xrTableRow38";
        this.xrTableRow38.Weight = 1D;
        // 
        // xrTableCell119
        // 
        this.xrTableCell119.Borders = DevExpress.XtraPrinting.BorderSide.Top;
        this.xrTableCell119.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.FinancialProgressRevenue", "{0:0.00%}")});
        this.xrTableCell119.Dpi = 100F;
        this.xrTableCell119.Font = new System.Drawing.Font("Times New Roman", 8.5F);
        this.xrTableCell119.Name = "xrTableCell119";
        this.xrTableCell119.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
        this.xrTableCell119.StylePriority.UseBorders = false;
        this.xrTableCell119.StylePriority.UseFont = false;
        this.xrTableCell119.StylePriority.UsePadding = false;
        this.xrTableCell119.Weight = 1D;
        // 
        // xrTableCell95
        // 
        this.xrTableCell95.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable19});
        this.xrTableCell95.Dpi = 100F;
        this.xrTableCell95.Name = "xrTableCell95";
        this.xrTableCell95.Weight = 0.411975452625386D;
        // 
        // xrTable19
        // 
        this.xrTable19.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTable19.Dpi = 100F;
        this.xrTable19.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
        this.xrTable19.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrTable19.Name = "xrTable19";
        this.xrTable19.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow39,
            this.xrTableRow40,
            this.xrTableRow41});
        this.xrTable19.SizeF = new System.Drawing.SizeF(64F, 125F);
        this.xrTable19.StylePriority.UseBorders = false;
        this.xrTable19.StylePriority.UseFont = false;
        this.xrTable19.StylePriority.UseTextAlignment = false;
        this.xrTable19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrTableRow39
        // 
        this.xrTableRow39.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell120});
        this.xrTableRow39.Dpi = 100F;
        this.xrTableRow39.Name = "xrTableRow39";
        this.xrTableRow39.Weight = 1D;
        // 
        // xrTableCell120
        // 
        this.xrTableCell120.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.TotalThrowForward", "{0:#,#}")});
        this.xrTableCell120.Dpi = 100F;
        this.xrTableCell120.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Bold);
        this.xrTableCell120.Name = "xrTableCell120";
        this.xrTableCell120.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
        this.xrTableCell120.StylePriority.UseFont = false;
        this.xrTableCell120.StylePriority.UsePadding = false;
        this.xrTableCell120.Weight = 1D;
        // 
        // xrTableRow40
        // 
        this.xrTableRow40.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell121});
        this.xrTableRow40.Dpi = 100F;
        this.xrTableRow40.Name = "xrTableRow40";
        this.xrTableRow40.Weight = 1D;
        // 
        // xrTableCell121
        // 
        this.xrTableCell121.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ThrowForwardCapital", "{0:#,#}")});
        this.xrTableCell121.Dpi = 100F;
        this.xrTableCell121.Font = new System.Drawing.Font("Times New Roman", 8.5F);
        this.xrTableCell121.Name = "xrTableCell121";
        this.xrTableCell121.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
        this.xrTableCell121.StylePriority.UseFont = false;
        this.xrTableCell121.StylePriority.UsePadding = false;
        this.xrTableCell121.Weight = 1D;
        // 
        // xrTableRow41
        // 
        this.xrTableRow41.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell122});
        this.xrTableRow41.Dpi = 100F;
        this.xrTableRow41.Name = "xrTableRow41";
        this.xrTableRow41.Weight = 1D;
        // 
        // xrTableCell122
        // 
        this.xrTableCell122.Borders = DevExpress.XtraPrinting.BorderSide.Top;
        this.xrTableCell122.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ThrowForwardRevenue", "{0:#,#}")});
        this.xrTableCell122.Dpi = 100F;
        this.xrTableCell122.Font = new System.Drawing.Font("Times New Roman", 8.5F);
        this.xrTableCell122.Name = "xrTableCell122";
        this.xrTableCell122.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
        this.xrTableCell122.StylePriority.UseBorders = false;
        this.xrTableCell122.StylePriority.UseFont = false;
        this.xrTableCell122.StylePriority.UsePadding = false;
        this.xrTableCell122.Weight = 1D;
        // 
        // xrTableCell57
        // 
        this.xrTableCell57.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrRichText1});
        this.xrTableCell57.Dpi = 100F;
        this.xrTableCell57.Name = "xrTableCell57";
        this.xrTableCell57.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
        this.xrTableCell57.StylePriority.UsePadding = false;
        this.xrTableCell57.StylePriority.UseTextAlignment = false;
        this.xrTableCell57.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        this.xrTableCell57.Weight = 2.36410540072086D;
        // 
        // xrRichText1
        // 
        this.xrRichText1.Borders = DevExpress.XtraPrinting.BorderSide.None;
        this.xrRichText1.BorderWidth = 0F;
        this.xrRichText1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Html", null, "SchemeList.Remarks")});
        this.xrRichText1.Dpi = 100F;
        this.xrRichText1.Font = new System.Drawing.Font("Arial", 8.5F);
        this.xrRichText1.LocationFloat = new DevExpress.Utils.PointFloat(2F, 2F);
        this.xrRichText1.Name = "xrRichText1";
        this.xrRichText1.SerializableRtfString = resources.GetString("xrRichText1.SerializableRtfString");
        this.xrRichText1.SizeF = new System.Drawing.SizeF(369F, 123F);
        this.xrRichText1.StylePriority.UseBorders = false;
        this.xrRichText1.StylePriority.UseBorderWidth = false;
        this.xrRichText1.StylePriority.UseFont = false;
        // 
        // TopMargin
        // 
        this.TopMargin.Dpi = 100F;
        this.TopMargin.HeightF = 20F;
        this.TopMargin.Name = "TopMargin";
        this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
        this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        // 
        // xrTable3
        // 
        this.xrTable3.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTable3.Dpi = 100F;
        this.xrTable3.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Bold);
        this.xrTable3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 125F);
        this.xrTable3.Name = "xrTable3";
        this.xrTable3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow3});
        this.xrTable3.SizeF = new System.Drawing.SizeF(1424F, 15F);
        this.xrTable3.StylePriority.UseBorders = false;
        this.xrTable3.StylePriority.UseFont = false;
        this.xrTable3.StylePriority.UseTextAlignment = false;
        this.xrTable3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrTableRow3
        // 
        this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell7,
            this.xrTableCell8,
            this.xrTableCell136,
            this.xrTableCell9,
            this.xrTableCell36,
            this.xrTableCell88,
            this.xrTableCell35,
            this.xrTableCell34,
            this.xrTableCell33,
            this.xrTableCell32,
            this.xrTableCell31,
            this.xrTableCell30,
            this.xrTableCell29,
            this.xrTableCell10,
            this.xrTableCell11,
            this.xrTableCell89,
            this.xrTableCell90,
            this.xrTableCell91});
        this.xrTableRow3.Dpi = 100F;
        this.xrTableRow3.Name = "xrTableRow3";
        this.xrTableRow3.Weight = 1D;
        // 
        // xrTableCell7
        // 
        this.xrTableCell7.Dpi = 100F;
        this.xrTableCell7.Name = "xrTableCell7";
        this.xrTableCell7.Text = "1";
        this.xrTableCell7.Weight = 0.133099760895676D;
        // 
        // xrTableCell8
        // 
        this.xrTableCell8.Dpi = 100F;
        this.xrTableCell8.Name = "xrTableCell8";
        this.xrTableCell8.Text = "2";
        this.xrTableCell8.Weight = 0.316904227261482D;
        // 
        // xrTableCell9
        // 
        this.xrTableCell9.Dpi = 100F;
        this.xrTableCell9.Name = "xrTableCell9";
        this.xrTableCell9.Text = "4";
        this.xrTableCell9.Weight = 0.792260498773896D;
        // 
        // xrTableCell36
        // 
        this.xrTableCell36.Dpi = 100F;
        this.xrTableCell36.Name = "xrTableCell36";
        this.xrTableCell36.Text = "5";
        this.xrTableCell36.Weight = 0.475356310286402D;
        // 
        // xrTableCell88
        // 
        this.xrTableCell88.Dpi = 100F;
        this.xrTableCell88.Name = "xrTableCell88";
        this.xrTableCell88.Weight = 0.0950712690049619D;
        // 
        // xrTableCell35
        // 
        this.xrTableCell35.Dpi = 100F;
        this.xrTableCell35.Name = "xrTableCell35";
        this.xrTableCell35.Text = "6";
        this.xrTableCell35.Weight = 0.411975452243389D;
        // 
        // xrTableCell34
        // 
        this.xrTableCell34.Dpi = 100F;
        this.xrTableCell34.Name = "xrTableCell34";
        this.xrTableCell34.Text = "7";
        this.xrTableCell34.Weight = 0.411975454071698D;
        // 
        // xrTableCell33
        // 
        this.xrTableCell33.Dpi = 100F;
        this.xrTableCell33.Name = "xrTableCell33";
        this.xrTableCell33.Text = "8";
        this.xrTableCell33.Weight = 0.411975456893082D;
        // 
        // xrTableCell32
        // 
        this.xrTableCell32.Dpi = 100F;
        this.xrTableCell32.Name = "xrTableCell32";
        this.xrTableCell32.Text = "9";
        this.xrTableCell32.Weight = 0.411975469510071D;
        // 
        // xrTableCell31
        // 
        this.xrTableCell31.Dpi = 100F;
        this.xrTableCell31.Name = "xrTableCell31";
        this.xrTableCell31.Text = "10";
        this.xrTableCell31.Weight = 0.411975472416177D;
        // 
        // xrTableCell30
        // 
        this.xrTableCell30.Dpi = 100F;
        this.xrTableCell30.Name = "xrTableCell30";
        this.xrTableCell30.Text = "11";
        this.xrTableCell30.Weight = 0.411975466603965D;
        // 
        // xrTableCell29
        // 
        this.xrTableCell29.Dpi = 100F;
        this.xrTableCell29.Name = "xrTableCell29";
        this.xrTableCell29.Text = "12";
        this.xrTableCell29.Weight = 0.411975462519058D;
        // 
        // xrTableCell10
        // 
        this.xrTableCell10.Dpi = 100F;
        this.xrTableCell10.Name = "xrTableCell10";
        this.xrTableCell10.Text = "13";
        this.xrTableCell10.Weight = 0.411975452428494D;
        // 
        // xrTableCell11
        // 
        this.xrTableCell11.Dpi = 100F;
        this.xrTableCell11.Name = "xrTableCell11";
        this.xrTableCell11.Text = "14";
        this.xrTableCell11.Weight = 0.411975429693881D;
        // 
        // xrTableCell89
        // 
        this.xrTableCell89.Dpi = 100F;
        this.xrTableCell89.Name = "xrTableCell89";
        this.xrTableCell89.Text = "15";
        this.xrTableCell89.Weight = 0.411975429693881D;
        // 
        // xrTableCell90
        // 
        this.xrTableCell90.Dpi = 100F;
        this.xrTableCell90.Name = "xrTableCell90";
        this.xrTableCell90.Text = "16";
        this.xrTableCell90.Weight = 0.411975429693881D;
        // 
        // xrTableCell91
        // 
        this.xrTableCell91.Dpi = 100F;
        this.xrTableCell91.Name = "xrTableCell91";
        this.xrTableCell91.Text = "17";
        this.xrTableCell91.Weight = 2.36410528079954D;
        // 
        // xrTable2
        // 
        this.xrTable2.BackColor = System.Drawing.Color.Yellow;
        this.xrTable2.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTable2.Dpi = 100F;
        this.xrTable2.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Bold);
        this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrTable2.Name = "xrTable2";
        this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
        this.xrTable2.SizeF = new System.Drawing.SizeF(1424F, 125F);
        this.xrTable2.StylePriority.UseBackColor = false;
        this.xrTable2.StylePriority.UseBorders = false;
        this.xrTable2.StylePriority.UseFont = false;
        this.xrTable2.StylePriority.UseTextAlignment = false;
        this.xrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrTableRow2
        // 
        this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell84,
            this.xrTableCell2,
            this.xrTableCell135,
            this.xrTableCell3,
            this.xrTableCell5,
            this.xrTableCell85,
            this.xrTableCell4,
            this.xrTableCell1,
            this.xrTableCell86,
            this.xrTableCell87,
            this.xrTableCell12,
            this.xrTableCell15,
            this.xrTableCell19,
            this.xrTableCell20,
            this.xrTableCell21,
            this.xrTableCell27,
            this.xrTableCell28,
            this.xrTableCell6});
        this.xrTableRow2.Dpi = 100F;
        this.xrTableRow2.Name = "xrTableRow2";
        this.xrTableRow2.Weight = 1D;
        // 
        // xrTableCell84
        // 
        this.xrTableCell84.BackColor = System.Drawing.Color.Transparent;
        this.xrTableCell84.Dpi = 100F;
        this.xrTableCell84.Name = "xrTableCell84";
        this.xrTableCell84.StylePriority.UseBackColor = false;
        this.xrTableCell84.Text = "Sr. No.";
        this.xrTableCell84.Weight = 0.218581098487734D;
        // 
        // xrTableCell2
        // 
        this.xrTableCell2.BackColor = System.Drawing.Color.Transparent;
        this.xrTableCell2.Dpi = 100F;
        this.xrTableCell2.Name = "xrTableCell2";
        this.xrTableCell2.StylePriority.UseBackColor = false;
        this.xrTableCell2.Text = "ADP No.";
        this.xrTableCell2.Weight = 0.520431179234693D;
        // 
        // xrTableCell3
        // 
        this.xrTableCell3.BackColor = System.Drawing.Color.Transparent;
        this.xrTableCell3.Dpi = 100F;
        this.xrTableCell3.Name = "xrTableCell3";
        this.xrTableCell3.StylePriority.UseBackColor = false;
        this.xrTableCell3.Text = "Name of the Scheme";
        this.xrTableCell3.Weight = 1.30107790890361D;
        // 
        // xrTableCell5
        // 
        this.xrTableCell5.BackColor = System.Drawing.Color.Transparent;
        this.xrTableCell5.Dpi = 100F;
        this.xrTableCell5.Name = "xrTableCell5";
        this.xrTableCell5.StylePriority.UseBackColor = false;
        this.xrTableCell5.Text = "Approved Status & Date";
        this.xrTableCell5.Weight = 0.780646760176691D;
        // 
        // xrTableCell85
        // 
        this.xrTableCell85.BackColor = System.Drawing.Color.Transparent;
        this.xrTableCell85.Dpi = 100F;
        this.xrTableCell85.Name = "xrTableCell85";
        this.xrTableCell85.StylePriority.UseBackColor = false;
        this.xrTableCell85.Weight = 0.156129348551492D;
        // 
        // xrTableCell4
        // 
        this.xrTableCell4.BackColor = System.Drawing.Color.Transparent;
        this.xrTableCell4.Dpi = 100F;
        this.xrTableCell4.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Bold);
        this.xrTableCell4.Name = "xrTableCell4";
        this.xrTableCell4.StylePriority.UseBackColor = false;
        this.xrTableCell4.StylePriority.UseFont = false;
        this.xrTableCell4.Text = "Approved Cost";
        this.xrTableCell4.Weight = 0.676560537496321D;
        // 
        // xrTableCell1
        // 
        this.xrTableCell1.BackColor = System.Drawing.Color.Transparent;
        this.xrTableCell1.Dpi = 100F;
        this.xrTableCell1.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Bold);
        this.xrTableCell1.Multiline = true;
        this.xrTableCell1.Name = "xrTableCell1";
        this.xrTableCell1.StylePriority.UseBackColor = false;
        this.xrTableCell1.StylePriority.UseFont = false;
        this.xrTableCell1.Text = "T.S. Cost";
        this.xrTableCell1.Weight = 0.676560533931431D;
        // 
        // xrTableCell86
        // 
        this.xrTableCell86.BackColor = System.Drawing.Color.Transparent;
        this.xrTableCell86.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "headExpUpTo")});
        this.xrTableCell86.Dpi = 100F;
        this.xrTableCell86.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Bold);
        this.xrTableCell86.Name = "xrTableCell86";
        this.xrTableCell86.StylePriority.UseBackColor = false;
        this.xrTableCell86.StylePriority.UseFont = false;
        this.xrTableCell86.Weight = 0.676560533867319D;
        // 
        // xrTableCell87
        // 
        this.xrTableCell87.BackColor = System.Drawing.Color.Transparent;
        this.xrTableCell87.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "headProvisionFor")});
        this.xrTableCell87.Dpi = 100F;
        this.xrTableCell87.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Bold);
        this.xrTableCell87.Name = "xrTableCell87";
        this.xrTableCell87.StylePriority.UseBackColor = false;
        this.xrTableCell87.StylePriority.UseFont = false;
        this.xrTableCell87.Weight = 0.676560533867319D;
        // 
        // xrTableCell12
        // 
        this.xrTableCell12.BackColor = System.Drawing.Color.Transparent;
        this.xrTableCell12.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "headRevisedAllocation")});
        this.xrTableCell12.Dpi = 100F;
        this.xrTableCell12.Multiline = true;
        this.xrTableCell12.Name = "xrTableCell12";
        this.xrTableCell12.StylePriority.UseBackColor = false;
        this.xrTableCell12.Weight = 0.676560542446957D;
        // 
        // xrTableCell15
        // 
        this.xrTableCell15.BackColor = System.Drawing.Color.Transparent;
        this.xrTableCell15.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "headFundsReleasedUpTo")});
        this.xrTableCell15.Dpi = 100F;
        this.xrTableCell15.Multiline = true;
        this.xrTableCell15.Name = "xrTableCell15";
        this.xrTableCell15.StylePriority.UseBackColor = false;
        this.xrTableCell15.Weight = 0.676560520913133D;
        // 
        // xrTableCell19
        // 
        this.xrTableCell19.BackColor = System.Drawing.Color.Transparent;
        this.xrTableCell19.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "headFundsUtilizedTill")});
        this.xrTableCell19.Dpi = 100F;
        this.xrTableCell19.Multiline = true;
        this.xrTableCell19.Name = "xrTableCell19";
        this.xrTableCell19.StylePriority.UseBackColor = false;
        this.xrTableCell19.Weight = 0.676560530972663D;
        // 
        // xrTableCell20
        // 
        this.xrTableCell20.BackColor = System.Drawing.Color.Transparent;
        this.xrTableCell20.Dpi = 100F;
        this.xrTableCell20.Multiline = true;
        this.xrTableCell20.Name = "xrTableCell20";
        this.xrTableCell20.StylePriority.UseBackColor = false;
        this.xrTableCell20.Text = "%age utiliz. on releases so far        \r\n";
        this.xrTableCell20.Weight = 0.676560526085421D;
        // 
        // xrTableCell21
        // 
        this.xrTableCell21.BackColor = System.Drawing.Color.Transparent;
        this.xrTableCell21.Dpi = 100F;
        this.xrTableCell21.Multiline = true;
        this.xrTableCell21.Name = "xrTableCell21";
        this.xrTableCell21.StylePriority.UseBackColor = false;
        this.xrTableCell21.Text = "Cumul-ative Exp. \r\n";
        this.xrTableCell21.Weight = 0.676560523500654D;
        // 
        // xrTableCell27
        // 
        this.xrTableCell27.BackColor = System.Drawing.Color.Transparent;
        this.xrTableCell27.Dpi = 100F;
        this.xrTableCell27.Multiline = true;
        this.xrTableCell27.Name = "xrTableCell27";
        this.xrTableCell27.StylePriority.UseBackColor = false;
        this.xrTableCell27.Text = "Finan. Prog. till Current month \r\n";
        this.xrTableCell27.Weight = 0.67656052342474D;
        // 
        // xrTableCell28
        // 
        this.xrTableCell28.BackColor = System.Drawing.Color.Transparent;
        this.xrTableCell28.Dpi = 100F;
        this.xrTableCell28.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Bold);
        this.xrTableCell28.Multiline = true;
        this.xrTableCell28.Name = "xrTableCell28";
        this.xrTableCell28.StylePriority.UseBackColor = false;
        this.xrTableCell28.StylePriority.UseFont = false;
        this.xrTableCell28.Text = "Throw-Forward\r\n";
        this.xrTableCell28.Weight = 0.676560520860398D;
        // 
        // xrTableCell6
        // 
        this.xrTableCell6.BackColor = System.Drawing.Color.Transparent;
        this.xrTableCell6.Dpi = 100F;
        this.xrTableCell6.Multiline = true;
        this.xrTableCell6.Name = "xrTableCell6";
        this.xrTableCell6.StylePriority.UseBackColor = false;
        this.xrTableCell6.Text = "Remarks\r\nFunds Released by Finance Department";
        this.xrTableCell6.Weight = 3.88241661427576D;
        // 
        // xrLabel1
        // 
        this.xrLabel1.BackColor = System.Drawing.Color.LightGray;
        this.xrLabel1.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrLabel1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "headReport")});
        this.xrLabel1.Dpi = 100F;
        this.xrLabel1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
        this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(0.5000114F, 0F);
        this.xrLabel1.Name = "xrLabel1";
        this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel1.SizeF = new System.Drawing.SizeF(1423.5F, 52F);
        this.xrLabel1.StylePriority.UseBackColor = false;
        this.xrLabel1.StylePriority.UseBorders = false;
        this.xrLabel1.StylePriority.UseFont = false;
        this.xrLabel1.StylePriority.UseTextAlignment = false;
        this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // BottomMargin
        // 
        this.BottomMargin.Dpi = 100F;
        this.BottomMargin.HeightF = 14.29164F;
        this.BottomMargin.Name = "BottomMargin";
        this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
        this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        // 
        // bindingSource1
        // 
        this.bindingSource1.DataMember = "CornReportList";
        this.bindingSource1.DataSource = typeof(CORNDataAccessLayer.Response.ReportResponse);
        // 
        // GroupHeader1
        // 
        this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
        this.GroupHeader1.Dpi = 100F;
        this.GroupHeader1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("CategoryTitle", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
        this.GroupHeader1.HeightF = 20F;
        this.GroupHeader1.Level = 1;
        this.GroupHeader1.Name = "GroupHeader1";
        // 
        // xrTable1
        // 
        this.xrTable1.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTable1.Dpi = 100F;
        this.xrTable1.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Bold);
        this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(0.5000114F, 0F);
        this.xrTable1.Name = "xrTable1";
        this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
        this.xrTable1.SizeF = new System.Drawing.SizeF(1423.5F, 20F);
        this.xrTable1.StylePriority.UseBorders = false;
        this.xrTable1.StylePriority.UseFont = false;
        this.xrTable1.StylePriority.UseTextAlignment = false;
        this.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrTableRow1
        // 
        this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell13});
        this.xrTableRow1.Dpi = 100F;
        this.xrTableRow1.Name = "xrTableRow1";
        this.xrTableRow1.Weight = 1D;
        // 
        // xrTableCell13
        // 
        this.xrTableCell13.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.CategoryTitle")});
        this.xrTableCell13.Dpi = 100F;
        this.xrTableCell13.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Bold);
        this.xrTableCell13.Name = "xrTableCell13";
        this.xrTableCell13.StylePriority.UseFont = false;
        this.xrTableCell13.Weight = 1.0364033491081179D;
        // 
        // GroupFooter1
        // 
        this.GroupFooter1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable9});
        this.GroupFooter1.Dpi = 100F;
        this.GroupFooter1.HeightF = 20F;
        this.GroupFooter1.Name = "GroupFooter1";
        // 
        // xrTable9
        // 
        this.xrTable9.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTable9.Dpi = 100F;
        this.xrTable9.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Bold);
        this.xrTable9.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrTable9.Name = "xrTable9";
        this.xrTable9.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow13});
        this.xrTable9.SizeF = new System.Drawing.SizeF(1424F, 20F);
        this.xrTable9.StylePriority.UseBorders = false;
        this.xrTable9.StylePriority.UseFont = false;
        this.xrTable9.StylePriority.UseTextAlignment = false;
        this.xrTable9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrTableRow13
        // 
        this.xrTableRow13.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell58,
            this.xrTableCell59,
            this.xrTableCell139,
            this.xrTableCell60,
            this.xrTableCell61,
            this.xrTableCell62,
            this.xrTableCell63,
            this.xrTableCell64,
            this.xrTableCell65,
            this.xrTableCell66,
            this.xrTableCell67,
            this.xrTableCell68,
            this.xrTableCell69,
            this.xrTableCell70,
            this.xrTableCell127,
            this.xrTableCell128,
            this.xrTableCell129,
            this.xrTableCell130});
        this.xrTableRow13.Dpi = 100F;
        this.xrTableRow13.Name = "xrTableRow13";
        this.xrTableRow13.Weight = 1D;
        // 
        // xrTableCell58
        // 
        this.xrTableCell58.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)));
        this.xrTableCell58.Dpi = 100F;
        this.xrTableCell58.Name = "xrTableCell58";
        this.xrTableCell58.StylePriority.UseBorders = false;
        this.xrTableCell58.Weight = 0.133099760895676D;
        // 
        // xrTableCell59
        // 
        this.xrTableCell59.Borders = DevExpress.XtraPrinting.BorderSide.Top;
        this.xrTableCell59.Dpi = 100F;
        this.xrTableCell59.Name = "xrTableCell59";
        this.xrTableCell59.StylePriority.UseBorders = false;
        this.xrTableCell59.Weight = 0.316904227261482D;
        // 
        // xrTableCell60
        // 
        this.xrTableCell60.Borders = DevExpress.XtraPrinting.BorderSide.Top;
        this.xrTableCell60.Dpi = 100F;
        this.xrTableCell60.Multiline = true;
        this.xrTableCell60.Name = "xrTableCell60";
        this.xrTableCell60.StylePriority.UseBorders = false;
        this.xrTableCell60.Weight = 0.15845210340514482D;
        // 
        // xrTableCell61
        // 
        this.xrTableCell61.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell61.Dpi = 100F;
        this.xrTableCell61.Name = "xrTableCell61";
        this.xrTableCell61.StylePriority.UseBorders = false;
        this.xrTableCell61.StylePriority.UseTextAlignment = false;
        this.xrTableCell61.Text = "Total for Spending Unit ";
        this.xrTableCell61.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
        this.xrTableCell61.Weight = 1.1091647056551532D;
        // 
        // xrTableCell62
        // 
        this.xrTableCell62.Dpi = 100F;
        this.xrTableCell62.Name = "xrTableCell62";
        this.xrTableCell62.Weight = 0.0950712690049619D;
        // 
        // xrTableCell63
        // 
        this.xrTableCell63.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.TotalLastApprovedCost")});
        this.xrTableCell63.Dpi = 100F;
        this.xrTableCell63.Name = "xrTableCell63";
        xrSummary2.FormatString = "{0:#,#}";
        xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell63.Summary = xrSummary2;
        this.xrTableCell63.Weight = 0.411975452243389D;
        // 
        // xrTableCell64
        // 
        this.xrTableCell64.Dpi = 100F;
        this.xrTableCell64.Name = "xrTableCell64";
        this.xrTableCell64.Weight = 0.411975454071698D;
        // 
        // xrTableCell65
        // 
        this.xrTableCell65.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.TotalLastExpenseCost")});
        this.xrTableCell65.Dpi = 100F;
        this.xrTableCell65.Name = "xrTableCell65";
        xrSummary3.FormatString = "{0:#,#}";
        xrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell65.Summary = xrSummary3;
        this.xrTableCell65.Weight = 0.411975456893082D;
        // 
        // xrTableCell66
        // 
        this.xrTableCell66.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.TotalCurrentADPAllocation")});
        this.xrTableCell66.Dpi = 100F;
        this.xrTableCell66.Name = "xrTableCell66";
        xrSummary4.FormatString = "{0:#,#}";
        xrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell66.Summary = xrSummary4;
        this.xrTableCell66.Weight = 0.411975469510071D;
        // 
        // xrTableCell67
        // 
        this.xrTableCell67.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.TotalCurrentRevisedAllocation")});
        this.xrTableCell67.Dpi = 100F;
        this.xrTableCell67.Name = "xrTableCell67";
        xrSummary5.FormatString = "{0:#,#}";
        xrSummary5.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell67.Summary = xrSummary5;
        this.xrTableCell67.Weight = 0.411975472416177D;
        // 
        // xrTableCell68
        // 
        this.xrTableCell68.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.TotalCurrentRelasedCost")});
        this.xrTableCell68.Dpi = 100F;
        this.xrTableCell68.Name = "xrTableCell68";
        xrSummary6.FormatString = "{0:#,#}";
        xrSummary6.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell68.Summary = xrSummary6;
        this.xrTableCell68.Weight = 0.411975466603965D;
        // 
        // xrTableCell69
        // 
        this.xrTableCell69.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.TotalCurrentExpenseCost")});
        this.xrTableCell69.Dpi = 100F;
        this.xrTableCell69.Name = "xrTableCell69";
        xrSummary7.FormatString = "{0:#,#}";
        xrSummary7.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell69.Summary = xrSummary7;
        this.xrTableCell69.Weight = 0.411975462519058D;
        // 
        // xrTableCell70
        // 
        this.xrTableCell70.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.TotalPercentUtilized")});
        this.xrTableCell70.Dpi = 100F;
        this.xrTableCell70.Name = "xrTableCell70";
        xrSummary8.FormatString = "{0:0.00%}";
        xrSummary8.Func = DevExpress.XtraReports.UI.SummaryFunc.Avg;
        xrSummary8.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell70.Summary = xrSummary8;
        this.xrTableCell70.Weight = 0.411975452428494D;
        // 
        // xrTableCell127
        // 
        this.xrTableCell127.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.TotalCumulativeExp")});
        this.xrTableCell127.Dpi = 100F;
        this.xrTableCell127.Name = "xrTableCell127";
        xrSummary9.FormatString = "{0:#,#}";
        xrSummary9.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell127.Summary = xrSummary9;
        this.xrTableCell127.Weight = 0.411975429693881D;
        // 
        // xrTableCell128
        // 
        this.xrTableCell128.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.TotalFinancialProgress")});
        this.xrTableCell128.Dpi = 100F;
        this.xrTableCell128.Name = "xrTableCell128";
        xrSummary10.FormatString = "{0:0.00%}";
        xrSummary10.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell128.Summary = xrSummary10;
        this.xrTableCell128.Weight = 0.411975429693881D;
        // 
        // xrTableCell129
        // 
        this.xrTableCell129.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.TotalThrowForward")});
        this.xrTableCell129.Dpi = 100F;
        this.xrTableCell129.Name = "xrTableCell129";
        xrSummary11.FormatString = "{0:#,#}";
        xrSummary11.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell129.Summary = xrSummary11;
        this.xrTableCell129.Weight = 0.411975429693881D;
        // 
        // xrTableCell130
        // 
        this.xrTableCell130.Dpi = 100F;
        this.xrTableCell130.Name = "xrTableCell130";
        this.xrTableCell130.Weight = 2.36410528079954D;
        // 
        // ReportHeader
        // 
        this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1});
        this.ReportHeader.Dpi = 100F;
        this.ReportHeader.HeightF = 52F;
        this.ReportHeader.Name = "ReportHeader";
        // 
        // GroupHeader2
        // 
        this.GroupHeader2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable8});
        this.GroupHeader2.Dpi = 100F;
        this.GroupHeader2.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("InstitutionTitle", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
        this.GroupHeader2.HeightF = 20F;
        this.GroupHeader2.Name = "GroupHeader2";
        // 
        // xrTable8
        // 
        this.xrTable8.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTable8.Dpi = 100F;
        this.xrTable8.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Bold);
        this.xrTable8.LocationFloat = new DevExpress.Utils.PointFloat(0.5000114F, 0F);
        this.xrTable8.Name = "xrTable8";
        this.xrTable8.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow12});
        this.xrTable8.SizeF = new System.Drawing.SizeF(1423.5F, 20F);
        this.xrTable8.StylePriority.UseBorders = false;
        this.xrTable8.StylePriority.UseFont = false;
        this.xrTable8.StylePriority.UseTextAlignment = false;
        this.xrTable8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrTableRow12
        // 
        this.xrTableRow12.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell14});
        this.xrTableRow12.Dpi = 100F;
        this.xrTableRow12.Name = "xrTableRow12";
        this.xrTableRow12.Weight = 1D;
        // 
        // xrTableCell14
        // 
        this.xrTableCell14.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.InstitutionTitle")});
        this.xrTableCell14.Dpi = 100F;
        this.xrTableCell14.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Bold);
        this.xrTableCell14.Name = "xrTableCell14";
        this.xrTableCell14.StylePriority.UseFont = false;
        this.xrTableCell14.Weight = 1.0364033491081179D;
        // 
        // GroupFooter2
        // 
        this.GroupFooter2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable10});
        this.GroupFooter2.Dpi = 100F;
        this.GroupFooter2.HeightF = 20F;
        this.GroupFooter2.Level = 1;
        this.GroupFooter2.Name = "GroupFooter2";
        this.GroupFooter2.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand;
        // 
        // xrTable10
        // 
        this.xrTable10.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTable10.Dpi = 100F;
        this.xrTable10.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Bold);
        this.xrTable10.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrTable10.Name = "xrTable10";
        this.xrTable10.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow14});
        this.xrTable10.SizeF = new System.Drawing.SizeF(1424F, 20F);
        this.xrTable10.StylePriority.UseBorders = false;
        this.xrTable10.StylePriority.UseFont = false;
        this.xrTable10.StylePriority.UseTextAlignment = false;
        this.xrTable10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrTableRow14
        // 
        this.xrTableRow14.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell71,
            this.xrTableCell72,
            this.xrTableCell140,
            this.xrTableCell73,
            this.xrTableCell74,
            this.xrTableCell75,
            this.xrTableCell76,
            this.xrTableCell77,
            this.xrTableCell78,
            this.xrTableCell79,
            this.xrTableCell80,
            this.xrTableCell81,
            this.xrTableCell82,
            this.xrTableCell83,
            this.xrTableCell131,
            this.xrTableCell132,
            this.xrTableCell133,
            this.xrTableCell134});
        this.xrTableRow14.Dpi = 100F;
        this.xrTableRow14.Name = "xrTableRow14";
        this.xrTableRow14.Weight = 1D;
        // 
        // xrTableCell71
        // 
        this.xrTableCell71.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell71.Dpi = 100F;
        this.xrTableCell71.Name = "xrTableCell71";
        this.xrTableCell71.StylePriority.UseBorders = false;
        this.xrTableCell71.Weight = 0.133099760895676D;
        // 
        // xrTableCell72
        // 
        this.xrTableCell72.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell72.Dpi = 100F;
        this.xrTableCell72.Name = "xrTableCell72";
        this.xrTableCell72.StylePriority.UseBorders = false;
        this.xrTableCell72.Weight = 0.316904227261482D;
        // 
        // xrTableCell73
        // 
        this.xrTableCell73.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell73.Dpi = 100F;
        this.xrTableCell73.Multiline = true;
        this.xrTableCell73.Name = "xrTableCell73";
        this.xrTableCell73.StylePriority.UseBorders = false;
        this.xrTableCell73.Weight = 0.15845210340514482D;
        // 
        // xrTableCell74
        // 
        this.xrTableCell74.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell74.Dpi = 100F;
        this.xrTableCell74.Name = "xrTableCell74";
        this.xrTableCell74.StylePriority.UseBorders = false;
        this.xrTableCell74.StylePriority.UseTextAlignment = false;
        this.xrTableCell74.Text = "Total for Type ";
        this.xrTableCell74.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
        this.xrTableCell74.Weight = 1.1091647056551532D;
        // 
        // xrTableCell75
        // 
        this.xrTableCell75.Dpi = 100F;
        this.xrTableCell75.Name = "xrTableCell75";
        this.xrTableCell75.Weight = 0.0950712690049619D;
        // 
        // xrTableCell76
        // 
        this.xrTableCell76.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.TotalLastApprovedCost")});
        this.xrTableCell76.Dpi = 100F;
        this.xrTableCell76.Name = "xrTableCell76";
        xrSummary12.FormatString = "{0:#,#}";
        xrSummary12.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell76.Summary = xrSummary12;
        this.xrTableCell76.Weight = 0.411975452243389D;
        // 
        // xrTableCell77
        // 
        this.xrTableCell77.Dpi = 100F;
        this.xrTableCell77.Name = "xrTableCell77";
        this.xrTableCell77.Weight = 0.411975454071698D;
        // 
        // xrTableCell78
        // 
        this.xrTableCell78.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.TotalLastExpenseCost")});
        this.xrTableCell78.Dpi = 100F;
        this.xrTableCell78.Name = "xrTableCell78";
        xrSummary13.FormatString = "{0:#,#}";
        xrSummary13.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell78.Summary = xrSummary13;
        this.xrTableCell78.Weight = 0.411975456893082D;
        // 
        // xrTableCell79
        // 
        this.xrTableCell79.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.TotalCurrentADPAllocation")});
        this.xrTableCell79.Dpi = 100F;
        this.xrTableCell79.Name = "xrTableCell79";
        xrSummary14.FormatString = "{0:#,#}";
        xrSummary14.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell79.Summary = xrSummary14;
        this.xrTableCell79.Weight = 0.411975469510071D;
        // 
        // xrTableCell80
        // 
        this.xrTableCell80.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.TotalCurrentRevisedAllocation")});
        this.xrTableCell80.Dpi = 100F;
        this.xrTableCell80.Name = "xrTableCell80";
        xrSummary15.FormatString = "{0:#,#}";
        xrSummary15.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell80.Summary = xrSummary15;
        this.xrTableCell80.Weight = 0.411975472416177D;
        // 
        // xrTableCell81
        // 
        this.xrTableCell81.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.TotalCurrentRelasedCost")});
        this.xrTableCell81.Dpi = 100F;
        this.xrTableCell81.Name = "xrTableCell81";
        xrSummary16.FormatString = "{0:#,#}";
        xrSummary16.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell81.Summary = xrSummary16;
        this.xrTableCell81.Weight = 0.411975466603965D;
        // 
        // xrTableCell82
        // 
        this.xrTableCell82.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.TotalCurrentExpenseCost")});
        this.xrTableCell82.Dpi = 100F;
        this.xrTableCell82.Name = "xrTableCell82";
        xrSummary17.FormatString = "{0:#,#}";
        xrSummary17.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell82.Summary = xrSummary17;
        this.xrTableCell82.Weight = 0.411975462519058D;
        // 
        // xrTableCell83
        // 
        this.xrTableCell83.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.TotalPercentUtilized")});
        this.xrTableCell83.Dpi = 100F;
        this.xrTableCell83.Name = "xrTableCell83";
        xrSummary18.FormatString = "{0:0.00%}";
        xrSummary18.Func = DevExpress.XtraReports.UI.SummaryFunc.Avg;
        xrSummary18.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell83.Summary = xrSummary18;
        this.xrTableCell83.Weight = 0.411975452428494D;
        // 
        // xrTableCell131
        // 
        this.xrTableCell131.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.TotalCumulativeExp")});
        this.xrTableCell131.Dpi = 100F;
        this.xrTableCell131.Name = "xrTableCell131";
        xrSummary19.FormatString = "{0:#,#}";
        xrSummary19.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell131.Summary = xrSummary19;
        this.xrTableCell131.Weight = 0.411975429693881D;
        // 
        // xrTableCell132
        // 
        this.xrTableCell132.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.TotalFinancialProgress")});
        this.xrTableCell132.Dpi = 100F;
        this.xrTableCell132.Name = "xrTableCell132";
        xrSummary20.FormatString = "{0:0.00%}";
        xrSummary20.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell132.Summary = xrSummary20;
        this.xrTableCell132.Weight = 0.411975429693881D;
        // 
        // xrTableCell133
        // 
        this.xrTableCell133.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.TotalThrowForward")});
        this.xrTableCell133.Dpi = 100F;
        this.xrTableCell133.Name = "xrTableCell133";
        xrSummary21.FormatString = "{0:#,#}";
        xrSummary21.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell133.Summary = xrSummary21;
        this.xrTableCell133.Weight = 0.411975429693881D;
        // 
        // xrTableCell134
        // 
        this.xrTableCell134.Dpi = 100F;
        this.xrTableCell134.Name = "xrTableCell134";
        this.xrTableCell134.Weight = 2.36410528079954D;
        // 
        // TotalLastApprovedCost
        // 
        this.TotalLastApprovedCost.DataMember = "SchemeList";
        this.TotalLastApprovedCost.Expression = "[LastApprovedCapital] + [LastApprovedRevenue]";
        this.TotalLastApprovedCost.Name = "TotalLastApprovedCost";
        // 
        // TotalApprovedCost
        // 
        this.TotalApprovedCost.DataMember = "SchemeList";
        this.TotalApprovedCost.Expression = "[TotalApprovedCapital] + [TotalApprovedRevenue]";
        this.TotalApprovedCost.Name = "TotalApprovedCost";
        // 
        // TotalCurrentRelasedCost
        // 
        this.TotalCurrentRelasedCost.DataMember = "SchemeList";
        this.TotalCurrentRelasedCost.Expression = "[CurrentReleaseCapital] + [CurrentReleaseRevenue]";
        this.TotalCurrentRelasedCost.Name = "TotalCurrentRelasedCost";
        // 
        // TotalCurrentExpenseCost
        // 
        this.TotalCurrentExpenseCost.DataMember = "SchemeList";
        this.TotalCurrentExpenseCost.Expression = "[CurrentExpenseCapital] + [CurrentExpenseRevenue]";
        this.TotalCurrentExpenseCost.Name = "TotalCurrentExpenseCost";
        // 
        // TotalLastExpenseCost
        // 
        this.TotalLastExpenseCost.DataMember = "SchemeList";
        this.TotalLastExpenseCost.Expression = "[LastExpenseCapital] + [LastExpenseRevenue]";
        this.TotalLastExpenseCost.Name = "TotalLastExpenseCost";
        // 
        // PercentUtilizedCapital
        // 
        this.PercentUtilizedCapital.DataMember = "SchemeList";
        this.PercentUtilizedCapital.Expression = "[TotalExpenseCapital] / [TotalReleaseCapital]";
        this.PercentUtilizedCapital.Name = "PercentUtilizedCapital";
        // 
        // PercentUtilizedRevenue
        // 
        this.PercentUtilizedRevenue.DataMember = "SchemeList";
        this.PercentUtilizedRevenue.Expression = "[TotalExpenseRevenue] / [TotalReleaseRevenue]";
        this.PercentUtilizedRevenue.Name = "PercentUtilizedRevenue";
        // 
        // TotalPercentUtilized
        // 
        this.TotalPercentUtilized.DataMember = "SchemeList";
        this.TotalPercentUtilized.Expression = "[TotalExpenseCost] / [TotalRelasedCost]";
        this.TotalPercentUtilized.Name = "TotalPercentUtilized";
        // 
        // CumulativeExpCapital
        // 
        this.CumulativeExpCapital.DataMember = "SchemeList";
        this.CumulativeExpCapital.Expression = "[LastExpenseCapital] + [CurrentExpenseCapital]";
        this.CumulativeExpCapital.Name = "CumulativeExpCapital";
        // 
        // CumulativeExpRevenue
        // 
        this.CumulativeExpRevenue.DataMember = "SchemeList";
        this.CumulativeExpRevenue.Expression = "[LastExpenseRevenue] + [CurrentExpenseRevenue]";
        this.CumulativeExpRevenue.Name = "CumulativeExpRevenue";
        // 
        // TotalCumulativeExp
        // 
        this.TotalCumulativeExp.DataMember = "SchemeList";
        this.TotalCumulativeExp.Expression = "[TotalLastExpenseCost] + [TotalCurrentExpenseCost]";
        this.TotalCumulativeExp.Name = "TotalCumulativeExp";
        // 
        // FinancialProgressCapital
        // 
        this.FinancialProgressCapital.DataMember = "SchemeList";
        this.FinancialProgressCapital.Expression = "[CumulativeExpCapital] / [LastApprovedCapital]";
        this.FinancialProgressCapital.Name = "FinancialProgressCapital";
        // 
        // FinancialProgressRevenue
        // 
        this.FinancialProgressRevenue.DataMember = "SchemeList";
        this.FinancialProgressRevenue.Expression = "[CumulativeExpRevenue] / [LastApprovedRevenue]";
        this.FinancialProgressRevenue.Name = "FinancialProgressRevenue";
        // 
        // TotalFinancialProgress
        // 
        this.TotalFinancialProgress.DataMember = "SchemeList";
        this.TotalFinancialProgress.Expression = "[TotalCumulativeExp] / [TotalLastApprovedCost]";
        this.TotalFinancialProgress.Name = "TotalFinancialProgress";
        // 
        // ThrowForwardCapital
        // 
        this.ThrowForwardCapital.DataMember = "SchemeList";
        this.ThrowForwardCapital.Expression = "[TotalApprovedCapital] - [CumulativeExpCapital]";
        this.ThrowForwardCapital.Name = "ThrowForwardCapital";
        // 
        // ThrowForwardRevenue
        // 
        this.ThrowForwardRevenue.DataMember = "SchemeList";
        this.ThrowForwardRevenue.Expression = "[TotalApprovedRevenue] - [CumulativeExpRevenue]";
        this.ThrowForwardRevenue.Name = "ThrowForwardRevenue";
        // 
        // TotalThrowForward
        // 
        this.TotalThrowForward.DataMember = "SchemeList";
        this.TotalThrowForward.Expression = "[ThrowForwardCapital] + [ThrowForwardRevenue]";
        this.TotalThrowForward.Name = "TotalThrowForward";
        // 
        // prMonth
        // 
        this.prMonth.Description = "Month";
        this.prMonth.Name = "prMonth";
        this.prMonth.Visible = false;
        // 
        // prYear
        // 
        this.prYear.Description = "Year";
        this.prYear.Name = "prYear";
        this.prYear.Visible = false;
        // 
        // prFinancialYear
        // 
        this.prFinancialYear.Description = "Financial Year";
        this.prFinancialYear.Name = "prFinancialYear";
        this.prFinancialYear.Visible = false;
        // 
        // headReport
        // 
        this.headReport.Expression = "Concat(\'MONTHLY PROGRESS REPORT OF ADP \', [Parameters.prFinancialYear], \' UPTO \'," +
" [Parameters.prMonth], \' \', [Parameters.prYear])";
        this.headReport.Name = "headReport";
        // 
        // headExpUpTo
        // 
        this.headExpUpTo.Expression = "Concat(\'Exp: upto June \', [Parameters.prExpectedYear])";
        this.headExpUpTo.Name = "headExpUpTo";
        // 
        // headProvisionFor
        // 
        this.headProvisionFor.Expression = "Concat(\'Provision for \', [Parameters.prFinancialYear])";
        this.headProvisionFor.Name = "headProvisionFor";
        // 
        // headRevisedAllocation
        // 
        this.headRevisedAllocation.Expression = "Concat(\'Revised Allocation \', [Parameters.prFinancialYear])";
        this.headRevisedAllocation.Name = "headRevisedAllocation";
        // 
        // headFundsReleasedUpTo
        // 
        this.headFundsReleasedUpTo.Expression = "Concat(\'Funds Released upto \', [Parameters.prMonth], \' \', [Parameters.prYear])";
        this.headFundsReleasedUpTo.Name = "headFundsReleasedUpTo";
        // 
        // headFundsUtilizedTill
        // 
        this.headFundsUtilizedTill.Expression = "Concat(\'Funds Utilized till \', [Parameters.prMonth], \' \', [Parameters.prYear])";
        this.headFundsUtilizedTill.Name = "headFundsUtilizedTill";
        // 
        // prExpectedYear
        // 
        this.prExpectedYear.Description = "Expected Year";
        this.prExpectedYear.Name = "prExpectedYear";
        this.prExpectedYear.Visible = false;
        // 
        // TotalCurrentADPAllocation
        // 
        this.TotalCurrentADPAllocation.DataMember = "SchemeList";
        this.TotalCurrentADPAllocation.Expression = "[CurrentADPAllocationCapital] + [CurrentADPAllocationRevenue]";
        this.TotalCurrentADPAllocation.Name = "TotalCurrentADPAllocation";
        // 
        // CurrentRevisedAllocationCapital
        // 
        this.CurrentRevisedAllocationCapital.DataMember = "SchemeList";
        this.CurrentRevisedAllocationCapital.Expression = "[CurrentADPAllocationCapital] + [CurrentSupplementaryCapital] + [CurrentPositiveR" +
"eappropriateCapital] - [CurrentNegativeReappropriateCapital] + [CurrentExcessCap" +
"ital] - [CurrentSurrenderCapital]";
        this.CurrentRevisedAllocationCapital.Name = "CurrentRevisedAllocationCapital";
        // 
        // CurrentRevisedAllocationRevenue
        // 
        this.CurrentRevisedAllocationRevenue.DataMember = "SchemeList";
        this.CurrentRevisedAllocationRevenue.Expression = "[CurrentADPAllocationRevenue] + [CurrentSupplementaryRevenue] + [CurrentPositiveR" +
"eappropriateRevenue] - [CurrentNegativeReappropriateRevenue] + [CurrentExcessRev" +
"enue] - [CurrentSurrenderRevenue]";
        this.CurrentRevisedAllocationRevenue.Name = "CurrentRevisedAllocationRevenue";
        // 
        // TotalCurrentRevisedAllocation
        // 
        this.TotalCurrentRevisedAllocation.DataMember = "SchemeList";
        this.TotalCurrentRevisedAllocation.Expression = "[CurrentRevisedAllocationCapital] + [CurrentRevisedAllocationRevenue]";
        this.TotalCurrentRevisedAllocation.Name = "TotalCurrentRevisedAllocation";
        // 
        // PageFooter
        // 
        this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrlblFooter});
        this.PageFooter.Dpi = 100F;
        this.PageFooter.HeightF = 37.5F;
        this.PageFooter.Name = "PageFooter";
        // 
        // xrlblFooter
        // 
        this.xrlblFooter.Dpi = 100F;
        this.xrlblFooter.LocationFloat = new DevExpress.Utils.PointFloat(500F, 12.5F);
        this.xrlblFooter.Name = "xrlblFooter";
        this.xrlblFooter.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrlblFooter.SizeF = new System.Drawing.SizeF(424.9999F, 23F);
        this.xrlblFooter.StylePriority.UseTextAlignment = false;
        this.xrlblFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrlblFooter.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrlblFooter_BeforePrint);
        // 
        // PageHeader
        // 
        this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable2,
            this.xrTable3});
        this.PageHeader.Dpi = 100F;
        this.PageHeader.HeightF = 140F;
        this.PageHeader.Name = "PageHeader";
        // 
        // xrTableCell135
        // 
        this.xrTableCell135.BackColor = System.Drawing.Color.Transparent;
        this.xrTableCell135.Dpi = 100F;
        this.xrTableCell135.Name = "xrTableCell135";
        this.xrTableCell135.StylePriority.UseBackColor = false;
        this.xrTableCell135.Text = "Code";
        this.xrTableCell135.Weight = 0.520431179234693D;
        // 
        // xrTableCell136
        // 
        this.xrTableCell136.Dpi = 100F;
        this.xrTableCell136.Name = "xrTableCell136";
        this.xrTableCell136.Text = "3";
        this.xrTableCell136.Weight = 0.316904227261482D;
        // 
        // xrTableCell137
        // 
        this.xrTableCell137.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.strSchemeCode")});
        this.xrTableCell137.Dpi = 100F;
        this.xrTableCell137.Font = new System.Drawing.Font("Times New Roman", 8.5F);
        this.xrTableCell137.Name = "xrTableCell137";
        this.xrTableCell137.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
        this.xrTableCell137.StylePriority.UseFont = false;
        this.xrTableCell137.StylePriority.UsePadding = false;
        this.xrTableCell137.StylePriority.UseTextAlignment = false;
        this.xrTableCell137.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        this.xrTableCell137.Weight = 0.316904197272187D;
        // 
        // xrTableCell138
        // 
        this.xrTableCell138.Dpi = 100F;
        this.xrTableCell138.Name = "xrTableCell138";
        this.xrTableCell138.Weight = 0.316904227261482D;
        // 
        // xrTableCell139
        // 
        this.xrTableCell139.Borders = DevExpress.XtraPrinting.BorderSide.Top;
        this.xrTableCell139.Dpi = 100F;
        this.xrTableCell139.Name = "xrTableCell139";
        this.xrTableCell139.StylePriority.UseBorders = false;
        this.xrTableCell139.Weight = 0.316904227261482D;
        // 
        // xrTableCell140
        // 
        this.xrTableCell140.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell140.Dpi = 100F;
        this.xrTableCell140.Name = "xrTableCell140";
        this.xrTableCell140.StylePriority.UseBorders = false;
        this.xrTableCell140.Weight = 0.316904227261482D;
        // 
        // xrMonthlyProgressReport
        // 
        this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.GroupHeader1,
            this.GroupFooter1,
            this.ReportHeader,
            this.GroupHeader2,
            this.GroupFooter2,
            this.PageFooter,
            this.PageHeader});
        this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.TotalLastApprovedCost,
            this.TotalApprovedCost,
            this.TotalCurrentRelasedCost,
            this.TotalCurrentExpenseCost,
            this.TotalLastExpenseCost,
            this.PercentUtilizedCapital,
            this.PercentUtilizedRevenue,
            this.TotalPercentUtilized,
            this.CumulativeExpCapital,
            this.CumulativeExpRevenue,
            this.TotalCumulativeExp,
            this.FinancialProgressCapital,
            this.FinancialProgressRevenue,
            this.TotalFinancialProgress,
            this.ThrowForwardCapital,
            this.ThrowForwardRevenue,
            this.TotalThrowForward,
            this.headReport,
            this.headExpUpTo,
            this.headProvisionFor,
            this.headRevisedAllocation,
            this.headFundsReleasedUpTo,
            this.headFundsUtilizedTill,
            this.TotalCurrentADPAllocation,
            this.CurrentRevisedAllocationCapital,
            this.CurrentRevisedAllocationRevenue,
            this.TotalCurrentRevisedAllocation});
        this.DataMember = "SchemeList";
        this.DataSource = this.bindingSource1;
        this.Font = new System.Drawing.Font("Arial", 9.75F);
        this.Landscape = true;
        this.Margins = new System.Drawing.Printing.Margins(12, 14, 20, 14);
        this.PageHeight = 850;
        this.PageWidth = 1450;
        this.PaperKind = System.Drawing.Printing.PaperKind.Custom;
        this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.prMonth,
            this.prYear,
            this.prFinancialYear,
            this.prExpectedYear});
        this.RequestParameters = false;
        this.Version = "16.1";
        ((System.ComponentModel.ISupportInitialize)(this.xrTable7)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable6)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable4)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable5)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable11)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable12)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable13)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable14)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable15)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable16)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable17)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable18)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable19)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrRichText1)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable9)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable8)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable10)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion

    private void xrlblFooter_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
    {
        xrlblFooter.Text = System.Configuration.ConfigurationManager.AppSettings["FooterText"];
    }
}
