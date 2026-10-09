using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

/// <summary>
/// Summary description for xrNewMonthlyProgressReport
/// </summary>
public class xrNewMonthlyProgressReport : DevExpress.XtraReports.UI.XtraReport
{
    private DevExpress.XtraReports.UI.DetailBand Detail;
    private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
    private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
    private System.Windows.Forms.BindingSource bindingSource1;
    private XRLabel xrLabel1;
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
    private XRTableCell xrTableCell35;
    private XRTableCell xrTableCell34;
    private XRTableCell xrTableCell33;
    private XRTableCell xrTableCell32;
    private XRTableCell xrTableCell31;
    private XRTableCell xrTableCell30;
    private XRTableCell xrTableCell29;
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
    private XRTableCell xrTableCell89;
    private XRTableCell xrTableCell90;
    private XRTableCell xrTableCell91;
    private XRTableCell xrTableCell84;
    private XRTableCell xrTableCell86;
    private XRTableCell xrTableCell87;
    private CalculatedField TotalLastApprovedCost;
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
    private CalculatedField headOrigionalAllocation;
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
    private XRLabel xrLabel3;
    private XRTableCell xrTableCell5;
    private XRTableCell xrTableCell16;
    private XRTableCell xrTableCell17;
    private XRTableCell xrTableCell18;
    private XRTableCell xrTableCell24;
    private XRTableCell xrTableCell36;
    private XRTableCell xrTableCell40;
    private XRTableCell xrTableCell41;
    private XRTableCell xrTableCell61;
    private XRTableCell xrTableCell62;
    private XRTableCell xrTableCell74;
    private XRTable xrTable4;
    private XRTableRow xrTableRow4;
    private XRTableCell xrTableCell75;
    private XRTableCell xrTableCell85;
    private CalculatedField headProjectionCurrentFY;
    private CalculatedField headProjectionNextFY;
    private CalculatedField headThrowForwardBeyond;
    private XRTable xrTable20;
    private XRTableRow xrTableRow5;
    private XRTableCell xrTableCell88;
    private XRTableCell xrTableCell93;
    private XRTableCell xrTableCell135;
    private XRTableRow xrTableRow6;
    private XRTableCell xrTableCell136;
    private XRTableCell xrTableCell137;
    private XRTableCell xrTableCell138;
    private PageHeaderBand PageHeader;
    private DevExpress.XtraReports.Parameters.Parameter prNextFinancialYear;
    private XRTable xrTable21;
    private XRTableRow xrTableRow42;
    private XRTableCell xrTableCell139;
    private XRTableCell xrTableCell140;
    private XRTableCell xrTableCell141;
    private XRTableRow xrTableRow43;
    private XRTableCell xrTableCell142;
    private XRTableCell xrTableCell143;
    private XRTableCell xrTableCell144;
    private XRTable xrTable22;
    private XRTableRow xrTableRow44;
    private XRTableCell xrTableCell145;
    private XRTableCell xrTableCell146;
    private XRTableCell xrTableCell147;
    private XRTableRow xrTableRow45;
    private XRTableCell xrTableCell148;
    private XRTableCell xrTableCell149;
    private XRTableCell xrTableCell150;
    private XRTable xrTable23;
    private XRTableRow xrTableRow46;
    private XRTableCell xrTableCell151;
    private XRTableCell xrTableCell152;
    private XRTableCell xrTableCell153;
    private XRTableRow xrTableRow47;
    private XRTableCell xrTableCell154;
    private XRTableCell xrTableCell155;
    private XRTableCell xrTableCell156;
    private XRTable xrTable24;
    private XRTableRow xrTableRow48;
    private XRTableCell xrTableCell168;
    private XRTableCell xrTableCell169;
    private XRTableCell xrTableCell170;
    private XRTableRow xrTableRow49;
    private XRTableCell xrTableCell171;
    private XRTableCell xrTableCell172;
    private XRTableCell xrTableCell173;
    private XRTableCell xrTableCell157;
    private XRTable xrTable25;
    private XRTableRow xrTableRow50;
    private XRTableCell xrTableCell174;
    private XRTableCell xrTableCell175;
    private XRTableCell xrTableCell176;
    private XRTableRow xrTableRow51;
    private XRTableCell xrTableCell177;
    private XRTableCell xrTableCell178;
    private XRTableCell xrTableCell179;
    private XRTableCell xrTableCell158;
    private XRTable xrTable26;
    private XRTableRow xrTableRow52;
    private XRTableCell xrTableCell180;
    private XRTableCell xrTableCell181;
    private XRTableCell xrTableCell182;
    private XRTableRow xrTableRow53;
    private XRTableCell xrTableCell183;
    private XRTableCell xrTableCell184;
    private XRTableCell xrTableCell185;
    private XRTableCell xrTableCell159;
    private XRTable xrTable27;
    private XRTableRow xrTableRow54;
    private XRTableCell xrTableCell186;
    private XRTableCell xrTableCell187;
    private XRTableCell xrTableCell188;
    private XRTableRow xrTableRow55;
    private XRTableCell xrTableCell189;
    private XRTableCell xrTableCell190;
    private XRTableCell xrTableCell191;
    private XRTableCell xrTableCell160;
    private XRTable xrTable28;
    private XRTableRow xrTableRow56;
    private XRTableCell xrTableCell192;
    private XRTableCell xrTableCell193;
    private XRTableCell xrTableCell194;
    private XRTableRow xrTableRow57;
    private XRTableCell xrTableCell195;
    private XRTableCell xrTableCell196;
    private XRTableCell xrTableCell197;
    private XRTableCell xrTableCell161;
    private XRTable xrTable29;
    private XRTableRow xrTableRow58;
    private XRTableCell xrTableCell198;
    private XRTableCell xrTableCell199;
    private XRTableCell xrTableCell200;
    private XRTableRow xrTableRow59;
    private XRTableCell xrTableCell201;
    private XRTableCell xrTableCell202;
    private XRTableCell xrTableCell203;
    private XRTableCell xrTableCell162;
    private XRTableCell xrTableCell163;
    private XRTableCell xrTableCell164;
    private XRTableCell xrTableCell165;
    private XRTableCell xrTableCell166;
    private XRTableCell xrTableCell167;
    private XRTable xrTable30;
    private XRTableRow xrTableRow60;
    private XRTableCell xrTableCell204;
    private XRTableCell xrTableCell205;
    private XRTableCell xrTableCell206;
    private XRTableCell xrTableCell207;
    private XRTableCell xrTableCell208;
    private XRTableCell xrTableCell209;
    private XRTableCell xrTableCell210;
    private XRTableCell xrTableCell211;
    private XRTableCell xrTableCell212;
    private XRTableCell xrTableCell213;
    private XRTableCell xrTableCell214;
    private XRTable xrTable31;
    private XRTableRow xrTableRow61;
    private XRTableCell xrTableCell215;
    private XRTableCell xrTableCell216;
    private XRTableCell xrTableCell217;
    private XRTableCell xrTableCell221;
    private XRTableCell xrTableCell228;
    private XRTableCell xrTableCell235;
    private XRTableCell xrTableCell242;
    private XRTableCell xrTableCell249;
    private XRTableCell xrTableCell256;
    private XRTableCell xrTableCell263;
    private XRTableCell xrTableCell270;
    private XRTableCell xrTableCell277;
    private XRTableCell xrTableCell284;
    private XRTableCell xrTableCell285;
    private XRTableCell xrTableCell286;
    private XRTableCell xrTableCell287;
    private XRTableCell xrTableCell288;
    private XRTableCell xrTableCell289;
    private XRTable xrTable32;
    private XRTableRow xrTableRow62;
    private XRTableCell xrTableCell218;
    private XRTableCell xrTableCell219;
    private XRTableCell xrTableCell220;
    private XRTable xrTable33;
    private XRTableRow xrTableRow63;
    private XRTableCell xrTableCell222;
    private XRTableCell xrTableCell223;
    private XRTableCell xrTableCell224;
    private XRTable xrTable34;
    private XRTableRow xrTableRow64;
    private XRTableCell xrTableCell225;
    private XRTableCell xrTableCell226;
    private XRTableCell xrTableCell227;
    private XRTable xrTable35;
    private XRTableRow xrTableRow65;
    private XRTableCell xrTableCell229;
    private XRTableCell xrTableCell230;
    private XRTableCell xrTableCell231;
    private XRTable xrTable36;
    private XRTableRow xrTableRow66;
    private XRTableCell xrTableCell232;
    private XRTableCell xrTableCell233;
    private XRTableCell xrTableCell234;
    private XRTable xrTable37;
    private XRTableRow xrTableRow67;
    private XRTableCell xrTableCell236;
    private XRTableCell xrTableCell237;
    private XRTableCell xrTableCell238;
    private XRTable xrTable38;
    private XRTableRow xrTableRow68;
    private XRTableCell xrTableCell239;
    private XRTableCell xrTableCell240;
    private XRTableCell xrTableCell241;
    private XRTable xrTable39;
    private XRTableRow xrTableRow69;
    private XRTableCell xrTableCell243;
    private XRTableCell xrTableCell244;
    private XRTableCell xrTableCell245;
    private XRTable xrTable40;
    private XRTableRow xrTableRow70;
    private XRTableCell xrTableCell246;
    private XRTableCell xrTableCell247;
    private XRTableCell xrTableCell248;
    private XRTable xrTable5;
    private XRTableRow xrTableRow7;
    private XRTableCell xrTableCell22;
    private XRTableCell xrTableCell23;
    private XRTableCell xrTableCell25;
    private XRTableCell xrTableCell26;
    private XRTableCell xrTableCell37;
    private XRTableCell xrTableCell38;
    private XRTableCell xrTableCell39;
    private XRTableCell xrTableCell42;
    private XRTableCell xrTableCell43;
    private XRTableCell xrTableCell44;
    private XRTableCell xrTableCell45;
    private XRTable xrTable6;
    private XRTableRow xrTableRow8;
    private XRTableCell xrTableCell46;
    private XRTableCell xrTableCell47;
    private XRTableCell xrTableCell48;
    private XRTableCell xrTableCell49;
    private XRTable xrTable7;
    private XRTableRow xrTableRow9;
    private XRTableCell xrTableCell50;
    private XRTableCell xrTableCell51;
    private XRTableCell xrTableCell52;
    private XRTableCell xrTableCell53;
    private XRTable xrTable9;
    private XRTableRow xrTableRow10;
    private XRTableCell xrTableCell54;
    private XRTableCell xrTableCell55;
    private XRTableCell xrTableCell56;
    private XRTableCell xrTableCell57;
    private XRTable xrTable11;
    private XRTableRow xrTableRow11;
    private XRTableCell xrTableCell58;
    private XRTableCell xrTableCell59;
    private XRTableCell xrTableCell60;
    private XRTableCell xrTableCell63;
    private XRTable xrTable12;
    private XRTableRow xrTableRow13;
    private XRTableCell xrTableCell64;
    private XRTableCell xrTableCell65;
    private XRTableCell xrTableCell66;
    private XRTableCell xrTableCell67;
    private XRTable xrTable13;
    private XRTableRow xrTableRow15;
    private XRTableCell xrTableCell68;
    private XRTableCell xrTableCell69;
    private XRTableCell xrTableCell70;
    private XRTableCell xrTableCell92;
    private XRTable xrTable14;
    private XRTableRow xrTableRow16;
    private XRTableCell xrTableCell94;
    private XRTableCell xrTableCell95;
    private XRTableCell xrTableCell96;
    private XRTableCell xrTableCell97;
    private XRTable xrTable15;
    private XRTableRow xrTableRow17;
    private XRTableCell xrTableCell98;
    private XRTableCell xrTableCell99;
    private XRTableCell xrTableCell100;
    private XRTableCell xrTableCell101;
    private XRTable xrTable16;
    private XRTableRow xrTableRow18;
    private XRTableCell xrTableCell102;
    private XRTableCell xrTableCell103;
    private XRTableCell xrTableCell104;
    private XRTableCell xrTableCell105;
    private XRTable xrTable17;
    private XRTableRow xrTableRow19;
    private XRTableCell xrTableCell106;
    private XRTableCell xrTableCell107;
    private XRTableCell xrTableCell108;
    private XRTableCell xrTableCell109;
    private XRTableCell xrTableCell110;
    private XRTableCell xrTableCell111;
    private XRTableCell xrTableCell112;
    private XRTableCell xrTableCell113;
    private XRTableCell xrTableCell114;
    private CalculatedField headTotalForCategory;
    private CalculatedField headTotalForSubSector;
    private XRTable xrTable10;
    private XRTableRow xrTableRow14;
    private XRTableCell xrTableCell71;
    private XRTableCell xrTableCell72;
    private XRTableCell xrTableCell73;
    private XRTableCell xrTableCell76;
    private XRTableCell xrTableCell77;
    private XRTableCell xrTableCell78;
    private XRTableCell xrTableCell79;
    private XRTableCell xrTableCell80;
    private XRTableCell xrTableCell81;
    private XRTableCell xrTableCell82;
    private XRTableCell xrTableCell83;
    private XRTable xrTable18;
    private XRTableRow xrTableRow20;
    private XRTableCell xrTableCell115;
    private XRTableCell xrTableCell116;
    private XRTableCell xrTableCell117;
    private XRTableCell xrTableCell118;
    private XRTable xrTable19;
    private XRTableRow xrTableRow21;
    private XRTableCell xrTableCell119;
    private XRTableCell xrTableCell120;
    private XRTableCell xrTableCell121;
    private XRTableCell xrTableCell122;
    private XRTable xrTable41;
    private XRTableRow xrTableRow22;
    private XRTableCell xrTableCell123;
    private XRTableCell xrTableCell124;
    private XRTableCell xrTableCell125;
    private XRTableCell xrTableCell126;
    private XRTable xrTable42;
    private XRTableRow xrTableRow23;
    private XRTableCell xrTableCell127;
    private XRTableCell xrTableCell128;
    private XRTableCell xrTableCell129;
    private XRTableCell xrTableCell130;
    private XRTable xrTable43;
    private XRTableRow xrTableRow24;
    private XRTableCell xrTableCell131;
    private XRTableCell xrTableCell132;
    private XRTableCell xrTableCell133;
    private XRTableCell xrTableCell134;
    private XRTable xrTable44;
    private XRTableRow xrTableRow25;
    private XRTableCell xrTableCell250;
    private XRTableCell xrTableCell251;
    private XRTableCell xrTableCell252;
    private XRTableCell xrTableCell253;
    private XRTable xrTable45;
    private XRTableRow xrTableRow26;
    private XRTableCell xrTableCell254;
    private XRTableCell xrTableCell255;
    private XRTableCell xrTableCell257;
    private XRTableCell xrTableCell258;
    private XRTable xrTable46;
    private XRTableRow xrTableRow27;
    private XRTableCell xrTableCell259;
    private XRTableCell xrTableCell260;
    private XRTableCell xrTableCell261;
    private XRTableCell xrTableCell262;
    private XRTable xrTable47;
    private XRTableRow xrTableRow28;
    private XRTableCell xrTableCell264;
    private XRTableCell xrTableCell265;
    private XRTableCell xrTableCell266;
    private XRTableCell xrTableCell267;
    private XRTable xrTable48;
    private XRTableRow xrTableRow29;
    private XRTableCell xrTableCell268;
    private XRTableCell xrTableCell269;
    private XRTableCell xrTableCell271;
    private XRTableCell xrTableCell272;
    private XRTableCell xrTableCell273;
    private XRTableCell xrTableCell274;
    private XRTableCell xrTableCell275;
    private XRTableCell xrTableCell276;
    private XRTableCell xrTableCell278;

    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public xrNewMonthlyProgressReport()
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
        string resourceFileName = "xrNewMonthlyProgressReport.resx";
        System.Resources.ResourceManager resources = global::Resources.xrNewMonthlyProgressReport.ResourceManager;
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
        DevExpress.XtraReports.UI.XRSummary xrSummary22 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary23 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary24 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary25 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary26 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary27 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary28 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary29 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary30 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary31 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary32 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary33 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary34 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary35 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary36 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary37 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary38 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary39 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary40 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary41 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary42 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary43 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary44 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary45 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary46 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary47 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary48 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary49 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary50 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary51 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary52 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary53 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary54 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary55 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary56 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary57 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary58 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary59 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary60 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary61 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary62 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary63 = new DevExpress.XtraReports.UI.XRSummary();
        this.Detail = new DevExpress.XtraReports.UI.DetailBand();
        this.xrTable30 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow60 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell204 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell205 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell206 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell207 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell208 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell209 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell210 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell211 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell212 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell213 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell214 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTable31 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow61 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell215 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell216 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell217 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell221 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTable32 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow62 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell218 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell219 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell220 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell228 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTable33 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow63 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell222 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell223 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell224 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell235 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTable34 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow64 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell225 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell226 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell227 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell242 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTable35 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow65 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell229 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell230 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell231 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell249 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTable36 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow66 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell232 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell233 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell234 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell256 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTable37 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow67 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell236 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell237 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell238 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell263 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTable38 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow68 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell239 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell240 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell241 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell270 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTable39 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow69 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell243 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell244 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell245 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell277 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTable40 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow70 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell246 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell247 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell248 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell284 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell285 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell286 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell287 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell288 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell289 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrRichText1 = new DevExpress.XtraReports.UI.XRRichText();
        this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
        this.xrTable3 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell35 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell34 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell33 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell32 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell31 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell30 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell29 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTable20 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow5 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell88 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell93 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell135 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableRow6 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell136 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell137 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell138 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTable21 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow42 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell139 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell140 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell141 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableRow43 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell142 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell143 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell144 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell89 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTable22 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow44 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell145 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell146 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell147 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableRow45 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell148 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell149 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell150 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell90 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTable23 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow46 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell151 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell152 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell153 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableRow47 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell154 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell155 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell156 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell91 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTable24 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow48 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell168 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell169 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell170 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableRow49 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell171 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell172 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell173 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell157 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTable25 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow50 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell174 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell175 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell176 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableRow51 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell177 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell178 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell179 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell158 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTable26 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow52 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell180 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell181 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell182 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableRow53 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell183 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell184 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell185 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell159 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTable27 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow54 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell186 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell187 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell188 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableRow55 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell189 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell190 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell191 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell160 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTable28 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow56 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell192 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell193 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell194 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableRow57 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell195 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell196 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell197 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell161 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTable29 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow58 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell198 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell199 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell200 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableRow59 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell201 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell202 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell203 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell162 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell163 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell164 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell165 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell166 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell167 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell84 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell16 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell17 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell18 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell24 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell36 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell86 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell87 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell15 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell19 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell20 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell21 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell27 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell28 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell40 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell41 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell61 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell62 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell74 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
        this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
        this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
        this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
        this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell13 = new DevExpress.XtraReports.UI.XRTableCell();
        this.GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
        this.xrTable5 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow7 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell22 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell23 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell25 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell26 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell37 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell38 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell39 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell42 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell43 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell44 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell45 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTable6 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow8 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell46 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell47 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell48 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell49 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTable7 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow9 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell50 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell51 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell52 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell53 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTable9 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow10 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell54 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell55 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell56 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell57 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTable11 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow11 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell58 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell59 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell60 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell63 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTable12 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow13 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell64 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell65 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell66 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell67 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTable13 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow15 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell68 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell69 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell70 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell92 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTable14 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow16 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell94 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell95 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell96 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell97 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTable15 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow17 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell98 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell99 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell100 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell101 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTable16 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow18 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell102 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell103 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell104 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell105 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTable17 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow19 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell106 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell107 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell108 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell109 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell110 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell111 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell112 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell113 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell114 = new DevExpress.XtraReports.UI.XRTableCell();
        this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
        this.xrTable4 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell75 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell85 = new DevExpress.XtraReports.UI.XRTableCell();
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
        this.xrTableCell76 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell77 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell78 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell79 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell80 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell81 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell82 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell83 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTable18 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow20 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell115 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell116 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell117 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell118 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTable19 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow21 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell119 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell120 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell121 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell122 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTable41 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow22 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell123 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell124 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell125 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell126 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTable42 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow23 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell127 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell128 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell129 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell130 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTable43 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow24 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell131 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell132 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell133 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell134 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTable44 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow25 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell250 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell251 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell252 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell253 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTable45 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow26 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell254 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell255 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell257 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell258 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTable46 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow27 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell259 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell260 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell261 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell262 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTable47 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow28 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell264 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell265 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell266 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell267 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTable48 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow29 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell268 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell269 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell271 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell272 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell273 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell274 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell275 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell276 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell278 = new DevExpress.XtraReports.UI.XRTableCell();
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
        this.headOrigionalAllocation = new DevExpress.XtraReports.UI.CalculatedField();
        this.headRevisedAllocation = new DevExpress.XtraReports.UI.CalculatedField();
        this.headFundsReleasedUpTo = new DevExpress.XtraReports.UI.CalculatedField();
        this.headFundsUtilizedTill = new DevExpress.XtraReports.UI.CalculatedField();
        this.prExpectedYear = new DevExpress.XtraReports.Parameters.Parameter();
        this.TotalCurrentADPAllocation = new DevExpress.XtraReports.UI.CalculatedField();
        this.CurrentRevisedAllocationCapital = new DevExpress.XtraReports.UI.CalculatedField();
        this.CurrentRevisedAllocationRevenue = new DevExpress.XtraReports.UI.CalculatedField();
        this.TotalCurrentRevisedAllocation = new DevExpress.XtraReports.UI.CalculatedField();
        this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
        this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
        this.headProjectionCurrentFY = new DevExpress.XtraReports.UI.CalculatedField();
        this.headProjectionNextFY = new DevExpress.XtraReports.UI.CalculatedField();
        this.headThrowForwardBeyond = new DevExpress.XtraReports.UI.CalculatedField();
        this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
        this.prNextFinancialYear = new DevExpress.XtraReports.Parameters.Parameter();
        this.headTotalForCategory = new DevExpress.XtraReports.UI.CalculatedField();
        this.headTotalForSubSector = new DevExpress.XtraReports.UI.CalculatedField();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable30)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable31)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable32)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable33)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable34)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable35)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable36)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable37)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable38)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable39)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable40)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrRichText1)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable20)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable21)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable22)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable23)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable24)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable25)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable26)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable27)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable28)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable29)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable5)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable6)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable7)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable9)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable11)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable12)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable13)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable14)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable15)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable16)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable17)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable4)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable8)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable10)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable18)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable19)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable41)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable42)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable43)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable44)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable45)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable46)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable47)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable48)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
        // 
        // Detail
        // 
        this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable30});
        this.Detail.Dpi = 100F;
        this.Detail.HeightF = 130F;
        this.Detail.Name = "Detail";
        this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
        this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        // 
        // xrTable30
        // 
        this.xrTable30.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTable30.Dpi = 100F;
        this.xrTable30.Font = new System.Drawing.Font("Arial", 8.5F);
        this.xrTable30.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrTable30.Name = "xrTable30";
        this.xrTable30.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow60});
        this.xrTable30.SizeF = new System.Drawing.SizeF(3374F, 130F);
        this.xrTable30.StylePriority.UseBorders = false;
        this.xrTable30.StylePriority.UseFont = false;
        this.xrTable30.StylePriority.UseTextAlignment = false;
        this.xrTable30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        // 
        // xrTableRow60
        // 
        this.xrTableRow60.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell204,
            this.xrTableCell205,
            this.xrTableCell206,
            this.xrTableCell207,
            this.xrTableCell208,
            this.xrTableCell209,
            this.xrTableCell210,
            this.xrTableCell211,
            this.xrTableCell212,
            this.xrTableCell213,
            this.xrTableCell214,
            this.xrTableCell221,
            this.xrTableCell228,
            this.xrTableCell235,
            this.xrTableCell242,
            this.xrTableCell249,
            this.xrTableCell256,
            this.xrTableCell263,
            this.xrTableCell270,
            this.xrTableCell277,
            this.xrTableCell284,
            this.xrTableCell285,
            this.xrTableCell286,
            this.xrTableCell287,
            this.xrTableCell288,
            this.xrTableCell289});
        this.xrTableRow60.Dpi = 100F;
        this.xrTableRow60.Name = "xrTableRow60";
        this.xrTableRow60.Weight = 1D;
        // 
        // xrTableCell204
        // 
        this.xrTableCell204.Dpi = 100F;
        this.xrTableCell204.Name = "xrTableCell204";
        this.xrTableCell204.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrTableCell204.StylePriority.UsePadding = false;
        xrSummary1.Func = DevExpress.XtraReports.UI.SummaryFunc.RecordNumber;
        xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
        this.xrTableCell204.Summary = xrSummary1;
        this.xrTableCell204.Weight = 0.0809236089163714D;
        // 
        // xrTableCell205
        // 
        this.xrTableCell205.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ADPNo")});
        this.xrTableCell205.Dpi = 100F;
        this.xrTableCell205.Name = "xrTableCell205";
        this.xrTableCell205.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrTableCell205.StylePriority.UsePadding = false;
        this.xrTableCell205.Weight = 0.175920889002736D;
        // 
        // xrTableCell206
        // 
        this.xrTableCell206.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.Title")});
        this.xrTableCell206.Dpi = 100F;
        this.xrTableCell206.Name = "xrTableCell206";
        this.xrTableCell206.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrTableCell206.StylePriority.UsePadding = false;
        this.xrTableCell206.StylePriority.UseTextAlignment = false;
        this.xrTableCell206.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        this.xrTableCell206.Weight = 0.54535473266983D;
        // 
        // xrTableCell207
        // 
        this.xrTableCell207.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.CategoryTitle")});
        this.xrTableCell207.Dpi = 100F;
        this.xrTableCell207.Name = "xrTableCell207";
        this.xrTableCell207.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrTableCell207.StylePriority.UsePadding = false;
        this.xrTableCell207.Weight = 0.211105062445105D;
        // 
        // xrTableCell208
        // 
        this.xrTableCell208.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.SubSectorTitle")});
        this.xrTableCell208.Dpi = 100F;
        this.xrTableCell208.Name = "xrTableCell208";
        this.xrTableCell208.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrTableCell208.StylePriority.UsePadding = false;
        this.xrTableCell208.Weight = 0.211105064273414D;
        // 
        // xrTableCell209
        // 
        this.xrTableCell209.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ApprovalStatus")});
        this.xrTableCell209.Dpi = 100F;
        this.xrTableCell209.Name = "xrTableCell209";
        this.xrTableCell209.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrTableCell209.StylePriority.UsePadding = false;
        this.xrTableCell209.Weight = 0.211105040251403D;
        // 
        // xrTableCell210
        // 
        this.xrTableCell210.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ApprovalForumAndDate")});
        this.xrTableCell210.Dpi = 100F;
        this.xrTableCell210.Name = "xrTableCell210";
        this.xrTableCell210.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrTableCell210.StylePriority.UsePadding = false;
        this.xrTableCell210.Weight = 0.246289228153728D;
        // 
        // xrTableCell211
        // 
        this.xrTableCell211.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.DistrictTitle")});
        this.xrTableCell211.Dpi = 100F;
        this.xrTableCell211.Name = "xrTableCell211";
        this.xrTableCell211.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrTableCell211.StylePriority.UsePadding = false;
        this.xrTableCell211.Weight = 0.211105055774498D;
        // 
        // xrTableCell212
        // 
        this.xrTableCell212.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.DivisionTitle")});
        this.xrTableCell212.Dpi = 100F;
        this.xrTableCell212.Name = "xrTableCell212";
        this.xrTableCell212.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrTableCell212.StylePriority.UsePadding = false;
        this.xrTableCell212.Weight = 0.211105049962286D;
        // 
        // xrTableCell213
        // 
        this.xrTableCell213.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.RegionTitle")});
        this.xrTableCell213.Dpi = 100F;
        this.xrTableCell213.Name = "xrTableCell213";
        this.xrTableCell213.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrTableCell213.StylePriority.UsePadding = false;
        this.xrTableCell213.Weight = 0.211105045877379D;
        // 
        // xrTableCell214
        // 
        this.xrTableCell214.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable31});
        this.xrTableCell214.Dpi = 100F;
        this.xrTableCell214.Name = "xrTableCell214";
        this.xrTableCell214.Weight = 0.387025912213494D;
        // 
        // xrTable31
        // 
        this.xrTable31.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTable31.Dpi = 100F;
        this.xrTable31.Font = new System.Drawing.Font("Arial", 8.5F);
        this.xrTable31.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrTable31.Name = "xrTable31";
        this.xrTable31.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrTable31.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow61});
        this.xrTable31.SizeF = new System.Drawing.SizeF(160F, 130F);
        this.xrTable31.StylePriority.UseBorders = false;
        this.xrTable31.StylePriority.UseFont = false;
        this.xrTable31.StylePriority.UsePadding = false;
        this.xrTable31.StylePriority.UseTextAlignment = false;
        this.xrTable31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        // 
        // xrTableRow61
        // 
        this.xrTableRow61.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell215,
            this.xrTableCell216,
            this.xrTableCell217});
        this.xrTableRow61.Dpi = 100F;
        this.xrTableRow61.Name = "xrTableRow61";
        this.xrTableRow61.Weight = 1D;
        // 
        // xrTableCell215
        // 
        this.xrTableCell215.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell215.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.LastApprovedCapital", "{0:#.000}")});
        this.xrTableCell215.Dpi = 100F;
        this.xrTableCell215.Name = "xrTableCell215";
        this.xrTableCell215.StylePriority.UseBorders = false;
        this.xrTableCell215.Weight = 1D;
        // 
        // xrTableCell216
        // 
        this.xrTableCell216.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell216.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.LastApprovedRevenue", "{0:#.000}")});
        this.xrTableCell216.Dpi = 100F;
        this.xrTableCell216.Name = "xrTableCell216";
        this.xrTableCell216.StylePriority.UseBorders = false;
        this.xrTableCell216.Weight = 1D;
        // 
        // xrTableCell217
        // 
        this.xrTableCell217.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell217.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.TotalLastApprovedCost", "{0:#.000}")});
        this.xrTableCell217.Dpi = 100F;
        this.xrTableCell217.Name = "xrTableCell217";
        this.xrTableCell217.StylePriority.UseBorders = false;
        this.xrTableCell217.Weight = 1D;
        // 
        // xrTableCell221
        // 
        this.xrTableCell221.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable32});
        this.xrTableCell221.Dpi = 100F;
        this.xrTableCell221.Name = "xrTableCell221";
        this.xrTableCell221.Weight = 0.387030131562782D;
        // 
        // xrTable32
        // 
        this.xrTable32.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTable32.Dpi = 100F;
        this.xrTable32.Font = new System.Drawing.Font("Arial", 8.5F);
        this.xrTable32.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrTable32.Name = "xrTable32";
        this.xrTable32.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrTable32.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow62});
        this.xrTable32.SizeF = new System.Drawing.SizeF(161F, 130F);
        this.xrTable32.StylePriority.UseBorders = false;
        this.xrTable32.StylePriority.UseFont = false;
        this.xrTable32.StylePriority.UsePadding = false;
        this.xrTable32.StylePriority.UseTextAlignment = false;
        this.xrTable32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        // 
        // xrTableRow62
        // 
        this.xrTableRow62.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell218,
            this.xrTableCell219,
            this.xrTableCell220});
        this.xrTableRow62.Dpi = 100F;
        this.xrTableRow62.Name = "xrTableRow62";
        this.xrTableRow62.Weight = 1D;
        // 
        // xrTableCell218
        // 
        this.xrTableCell218.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell218.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.LastExpenseCapital", "{0:#.000}")});
        this.xrTableCell218.Dpi = 100F;
        this.xrTableCell218.Name = "xrTableCell218";
        this.xrTableCell218.StylePriority.UseBorders = false;
        this.xrTableCell218.Weight = 1D;
        // 
        // xrTableCell219
        // 
        this.xrTableCell219.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell219.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.LastExpenseRevenue", "{0:#.000}")});
        this.xrTableCell219.Dpi = 100F;
        this.xrTableCell219.Name = "xrTableCell219";
        this.xrTableCell219.StylePriority.UseBorders = false;
        this.xrTableCell219.Weight = 1D;
        // 
        // xrTableCell220
        // 
        this.xrTableCell220.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell220.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.TotalLastExpenseCost", "{0:#.000}")});
        this.xrTableCell220.Dpi = 100F;
        this.xrTableCell220.Name = "xrTableCell220";
        this.xrTableCell220.StylePriority.UseBorders = false;
        this.xrTableCell220.Weight = 1D;
        // 
        // xrTableCell228
        // 
        this.xrTableCell228.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable33});
        this.xrTableCell228.Dpi = 100F;
        this.xrTableCell228.Name = "xrTableCell228";
        this.xrTableCell228.Weight = 0.387030096333807D;
        // 
        // xrTable33
        // 
        this.xrTable33.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTable33.Dpi = 100F;
        this.xrTable33.Font = new System.Drawing.Font("Arial", 8.5F);
        this.xrTable33.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrTable33.Name = "xrTable33";
        this.xrTable33.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrTable33.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow63});
        this.xrTable33.SizeF = new System.Drawing.SizeF(161F, 130F);
        this.xrTable33.StylePriority.UseBorders = false;
        this.xrTable33.StylePriority.UseFont = false;
        this.xrTable33.StylePriority.UsePadding = false;
        this.xrTable33.StylePriority.UseTextAlignment = false;
        this.xrTable33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        // 
        // xrTableRow63
        // 
        this.xrTableRow63.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell222,
            this.xrTableCell223,
            this.xrTableCell224});
        this.xrTableRow63.Dpi = 100F;
        this.xrTableRow63.Name = "xrTableRow63";
        this.xrTableRow63.Weight = 1D;
        // 
        // xrTableCell222
        // 
        this.xrTableCell222.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell222.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.CurrentADPAllocationCapital", "{0:#.000}")});
        this.xrTableCell222.Dpi = 100F;
        this.xrTableCell222.Name = "xrTableCell222";
        this.xrTableCell222.StylePriority.UseBorders = false;
        this.xrTableCell222.Weight = 1D;
        // 
        // xrTableCell223
        // 
        this.xrTableCell223.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell223.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.CurrentADPAllocationRevenue", "{0:#.000}")});
        this.xrTableCell223.Dpi = 100F;
        this.xrTableCell223.Name = "xrTableCell223";
        this.xrTableCell223.StylePriority.UseBorders = false;
        this.xrTableCell223.Weight = 1D;
        // 
        // xrTableCell224
        // 
        this.xrTableCell224.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell224.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.TotalCurrentADPAllocation", "{0:#.000}")});
        this.xrTableCell224.Dpi = 100F;
        this.xrTableCell224.Name = "xrTableCell224";
        this.xrTableCell224.StylePriority.UseBorders = false;
        this.xrTableCell224.Weight = 1D;
        // 
        // xrTableCell235
        // 
        this.xrTableCell235.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable34});
        this.xrTableCell235.Dpi = 100F;
        this.xrTableCell235.Name = "xrTableCell235";
        this.xrTableCell235.Weight = 0.387030096333808D;
        // 
        // xrTable34
        // 
        this.xrTable34.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTable34.Dpi = 100F;
        this.xrTable34.Font = new System.Drawing.Font("Arial", 8.5F);
        this.xrTable34.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrTable34.Name = "xrTable34";
        this.xrTable34.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrTable34.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow64});
        this.xrTable34.SizeF = new System.Drawing.SizeF(161F, 130F);
        this.xrTable34.StylePriority.UseBorders = false;
        this.xrTable34.StylePriority.UseFont = false;
        this.xrTable34.StylePriority.UsePadding = false;
        this.xrTable34.StylePriority.UseTextAlignment = false;
        this.xrTable34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        // 
        // xrTableRow64
        // 
        this.xrTableRow64.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell225,
            this.xrTableCell226,
            this.xrTableCell227});
        this.xrTableRow64.Dpi = 100F;
        this.xrTableRow64.Name = "xrTableRow64";
        this.xrTableRow64.Weight = 1D;
        // 
        // xrTableCell225
        // 
        this.xrTableCell225.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell225.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.CurrentRevisedAllocationCapital", "{0:#.000}")});
        this.xrTableCell225.Dpi = 100F;
        this.xrTableCell225.Name = "xrTableCell225";
        this.xrTableCell225.StylePriority.UseBorders = false;
        this.xrTableCell225.Weight = 1D;
        // 
        // xrTableCell226
        // 
        this.xrTableCell226.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell226.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.CurrentRevisedAllocationRevenue", "{0:#.000}")});
        this.xrTableCell226.Dpi = 100F;
        this.xrTableCell226.Name = "xrTableCell226";
        this.xrTableCell226.StylePriority.UseBorders = false;
        this.xrTableCell226.Weight = 1D;
        // 
        // xrTableCell227
        // 
        this.xrTableCell227.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell227.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.TotalCurrentRevisedAllocation", "{0:#.000}")});
        this.xrTableCell227.Dpi = 100F;
        this.xrTableCell227.Name = "xrTableCell227";
        this.xrTableCell227.StylePriority.UseBorders = false;
        this.xrTableCell227.Weight = 1D;
        // 
        // xrTableCell242
        // 
        this.xrTableCell242.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable35});
        this.xrTableCell242.Dpi = 100F;
        this.xrTableCell242.Name = "xrTableCell242";
        this.xrTableCell242.Weight = 0.387029574554307D;
        // 
        // xrTable35
        // 
        this.xrTable35.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTable35.Dpi = 100F;
        this.xrTable35.Font = new System.Drawing.Font("Arial", 8.5F);
        this.xrTable35.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrTable35.Name = "xrTable35";
        this.xrTable35.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrTable35.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow65});
        this.xrTable35.SizeF = new System.Drawing.SizeF(161F, 130F);
        this.xrTable35.StylePriority.UseBorders = false;
        this.xrTable35.StylePriority.UseFont = false;
        this.xrTable35.StylePriority.UsePadding = false;
        this.xrTable35.StylePriority.UseTextAlignment = false;
        this.xrTable35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        // 
        // xrTableRow65
        // 
        this.xrTableRow65.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell229,
            this.xrTableCell230,
            this.xrTableCell231});
        this.xrTableRow65.Dpi = 100F;
        this.xrTableRow65.Name = "xrTableRow65";
        this.xrTableRow65.Weight = 1D;
        // 
        // xrTableCell229
        // 
        this.xrTableCell229.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell229.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.CurrentReleaseCapital", "{0:#.000}")});
        this.xrTableCell229.Dpi = 100F;
        this.xrTableCell229.Name = "xrTableCell229";
        this.xrTableCell229.StylePriority.UseBorders = false;
        this.xrTableCell229.Weight = 1D;
        // 
        // xrTableCell230
        // 
        this.xrTableCell230.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell230.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.CurrentReleaseRevenue", "{0:#.000}")});
        this.xrTableCell230.Dpi = 100F;
        this.xrTableCell230.Name = "xrTableCell230";
        this.xrTableCell230.StylePriority.UseBorders = false;
        this.xrTableCell230.Weight = 1D;
        // 
        // xrTableCell231
        // 
        this.xrTableCell231.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell231.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.TotalCurrentRelasedCost", "{0:#.000}")});
        this.xrTableCell231.Dpi = 100F;
        this.xrTableCell231.Name = "xrTableCell231";
        this.xrTableCell231.StylePriority.UseBorders = false;
        this.xrTableCell231.Weight = 1D;
        // 
        // xrTableCell249
        // 
        this.xrTableCell249.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable36});
        this.xrTableCell249.Dpi = 100F;
        this.xrTableCell249.Name = "xrTableCell249";
        this.xrTableCell249.Weight = 0.387029574554307D;
        // 
        // xrTable36
        // 
        this.xrTable36.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTable36.Dpi = 100F;
        this.xrTable36.Font = new System.Drawing.Font("Arial", 8.5F);
        this.xrTable36.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrTable36.Name = "xrTable36";
        this.xrTable36.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrTable36.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow66});
        this.xrTable36.SizeF = new System.Drawing.SizeF(161F, 130F);
        this.xrTable36.StylePriority.UseBorders = false;
        this.xrTable36.StylePriority.UseFont = false;
        this.xrTable36.StylePriority.UsePadding = false;
        this.xrTable36.StylePriority.UseTextAlignment = false;
        this.xrTable36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        // 
        // xrTableRow66
        // 
        this.xrTableRow66.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell232,
            this.xrTableCell233,
            this.xrTableCell234});
        this.xrTableRow66.Dpi = 100F;
        this.xrTableRow66.Name = "xrTableRow66";
        this.xrTableRow66.Weight = 1D;
        // 
        // xrTableCell232
        // 
        this.xrTableCell232.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell232.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.CurrentExpenseCapital", "{0:#.000}")});
        this.xrTableCell232.Dpi = 100F;
        this.xrTableCell232.Name = "xrTableCell232";
        this.xrTableCell232.StylePriority.UseBorders = false;
        this.xrTableCell232.Weight = 1D;
        // 
        // xrTableCell233
        // 
        this.xrTableCell233.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell233.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.CurrentExcessRevenue", "{0:#.000}")});
        this.xrTableCell233.Dpi = 100F;
        this.xrTableCell233.Name = "xrTableCell233";
        this.xrTableCell233.StylePriority.UseBorders = false;
        this.xrTableCell233.Weight = 1D;
        // 
        // xrTableCell234
        // 
        this.xrTableCell234.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell234.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.TotalCurrentExpenseCost", "{0:#.000}")});
        this.xrTableCell234.Dpi = 100F;
        this.xrTableCell234.Name = "xrTableCell234";
        this.xrTableCell234.StylePriority.UseBorders = false;
        this.xrTableCell234.Weight = 1D;
        // 
        // xrTableCell256
        // 
        this.xrTableCell256.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable37});
        this.xrTableCell256.Dpi = 100F;
        this.xrTableCell256.Name = "xrTableCell256";
        this.xrTableCell256.Weight = 0.387029574554307D;
        // 
        // xrTable37
        // 
        this.xrTable37.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTable37.Dpi = 100F;
        this.xrTable37.Font = new System.Drawing.Font("Arial", 8.5F);
        this.xrTable37.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrTable37.Name = "xrTable37";
        this.xrTable37.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrTable37.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow67});
        this.xrTable37.SizeF = new System.Drawing.SizeF(161F, 130F);
        this.xrTable37.StylePriority.UseBorders = false;
        this.xrTable37.StylePriority.UseFont = false;
        this.xrTable37.StylePriority.UsePadding = false;
        this.xrTable37.StylePriority.UseTextAlignment = false;
        this.xrTable37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        // 
        // xrTableRow67
        // 
        this.xrTableRow67.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell236,
            this.xrTableCell237,
            this.xrTableCell238});
        this.xrTableRow67.Dpi = 100F;
        this.xrTableRow67.Name = "xrTableRow67";
        this.xrTableRow67.Weight = 1D;
        // 
        // xrTableCell236
        // 
        this.xrTableCell236.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell236.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.PercentUtilizedCapital", "{0:0.00%}")});
        this.xrTableCell236.Dpi = 100F;
        this.xrTableCell236.Name = "xrTableCell236";
        this.xrTableCell236.StylePriority.UseBorders = false;
        this.xrTableCell236.Weight = 1D;
        // 
        // xrTableCell237
        // 
        this.xrTableCell237.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell237.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.PercentUtilizedRevenue", "{0:0.00%}")});
        this.xrTableCell237.Dpi = 100F;
        this.xrTableCell237.Name = "xrTableCell237";
        this.xrTableCell237.StylePriority.UseBorders = false;
        this.xrTableCell237.Weight = 1D;
        // 
        // xrTableCell238
        // 
        this.xrTableCell238.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell238.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.TotalPercentUtilized", "{0:0.00%}")});
        this.xrTableCell238.Dpi = 100F;
        this.xrTableCell238.Name = "xrTableCell238";
        this.xrTableCell238.StylePriority.UseBorders = false;
        this.xrTableCell238.Weight = 1D;
        // 
        // xrTableCell263
        // 
        this.xrTableCell263.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable38});
        this.xrTableCell263.Dpi = 100F;
        this.xrTableCell263.Name = "xrTableCell263";
        this.xrTableCell263.Weight = 0.387029574554307D;
        // 
        // xrTable38
        // 
        this.xrTable38.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTable38.Dpi = 100F;
        this.xrTable38.Font = new System.Drawing.Font("Arial", 8.5F);
        this.xrTable38.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrTable38.Name = "xrTable38";
        this.xrTable38.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrTable38.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow68});
        this.xrTable38.SizeF = new System.Drawing.SizeF(161F, 130F);
        this.xrTable38.StylePriority.UseBorders = false;
        this.xrTable38.StylePriority.UseFont = false;
        this.xrTable38.StylePriority.UsePadding = false;
        this.xrTable38.StylePriority.UseTextAlignment = false;
        this.xrTable38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        // 
        // xrTableRow68
        // 
        this.xrTableRow68.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell239,
            this.xrTableCell240,
            this.xrTableCell241});
        this.xrTableRow68.Dpi = 100F;
        this.xrTableRow68.Name = "xrTableRow68";
        this.xrTableRow68.Weight = 1D;
        // 
        // xrTableCell239
        // 
        this.xrTableCell239.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell239.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.CumulativeExpCapital", "{0:#.000}")});
        this.xrTableCell239.Dpi = 100F;
        this.xrTableCell239.Name = "xrTableCell239";
        this.xrTableCell239.StylePriority.UseBorders = false;
        this.xrTableCell239.Weight = 1D;
        // 
        // xrTableCell240
        // 
        this.xrTableCell240.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell240.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.CumulativeExpRevenue", "{0:#.000}")});
        this.xrTableCell240.Dpi = 100F;
        this.xrTableCell240.Name = "xrTableCell240";
        this.xrTableCell240.StylePriority.UseBorders = false;
        this.xrTableCell240.Weight = 1D;
        // 
        // xrTableCell241
        // 
        this.xrTableCell241.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell241.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.TotalCumulativeExp", "{0:#.000}")});
        this.xrTableCell241.Dpi = 100F;
        this.xrTableCell241.Name = "xrTableCell241";
        this.xrTableCell241.StylePriority.UseBorders = false;
        this.xrTableCell241.Weight = 1D;
        // 
        // xrTableCell270
        // 
        this.xrTableCell270.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable39});
        this.xrTableCell270.Dpi = 100F;
        this.xrTableCell270.Name = "xrTableCell270";
        this.xrTableCell270.Weight = 0.387029574554307D;
        // 
        // xrTable39
        // 
        this.xrTable39.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTable39.Dpi = 100F;
        this.xrTable39.Font = new System.Drawing.Font("Arial", 8.5F);
        this.xrTable39.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrTable39.Name = "xrTable39";
        this.xrTable39.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrTable39.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow69});
        this.xrTable39.SizeF = new System.Drawing.SizeF(161F, 130F);
        this.xrTable39.StylePriority.UseBorders = false;
        this.xrTable39.StylePriority.UseFont = false;
        this.xrTable39.StylePriority.UsePadding = false;
        this.xrTable39.StylePriority.UseTextAlignment = false;
        this.xrTable39.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        // 
        // xrTableRow69
        // 
        this.xrTableRow69.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell243,
            this.xrTableCell244,
            this.xrTableCell245});
        this.xrTableRow69.Dpi = 100F;
        this.xrTableRow69.Name = "xrTableRow69";
        this.xrTableRow69.Weight = 1D;
        // 
        // xrTableCell243
        // 
        this.xrTableCell243.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell243.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.FinancialProgressCapital", "{0:0.00%}")});
        this.xrTableCell243.Dpi = 100F;
        this.xrTableCell243.Name = "xrTableCell243";
        this.xrTableCell243.StylePriority.UseBorders = false;
        this.xrTableCell243.Weight = 1D;
        // 
        // xrTableCell244
        // 
        this.xrTableCell244.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell244.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.FinancialProgressRevenue", "{0:0.00%}")});
        this.xrTableCell244.Dpi = 100F;
        this.xrTableCell244.Name = "xrTableCell244";
        this.xrTableCell244.StylePriority.UseBorders = false;
        this.xrTableCell244.Weight = 1D;
        // 
        // xrTableCell245
        // 
        this.xrTableCell245.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell245.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.TotalFinancialProgress", "{0:0.00%}")});
        this.xrTableCell245.Dpi = 100F;
        this.xrTableCell245.Name = "xrTableCell245";
        this.xrTableCell245.StylePriority.UseBorders = false;
        this.xrTableCell245.Weight = 1D;
        // 
        // xrTableCell277
        // 
        this.xrTableCell277.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable40});
        this.xrTableCell277.Dpi = 100F;
        this.xrTableCell277.Name = "xrTableCell277";
        this.xrTableCell277.Weight = 0.387029574554307D;
        // 
        // xrTable40
        // 
        this.xrTable40.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTable40.Dpi = 100F;
        this.xrTable40.Font = new System.Drawing.Font("Arial", 8.5F);
        this.xrTable40.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrTable40.Name = "xrTable40";
        this.xrTable40.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrTable40.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow70});
        this.xrTable40.SizeF = new System.Drawing.SizeF(161F, 130F);
        this.xrTable40.StylePriority.UseBorders = false;
        this.xrTable40.StylePriority.UseFont = false;
        this.xrTable40.StylePriority.UsePadding = false;
        this.xrTable40.StylePriority.UseTextAlignment = false;
        this.xrTable40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        // 
        // xrTableRow70
        // 
        this.xrTableRow70.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell246,
            this.xrTableCell247,
            this.xrTableCell248});
        this.xrTableRow70.Dpi = 100F;
        this.xrTableRow70.Name = "xrTableRow70";
        this.xrTableRow70.Weight = 1D;
        // 
        // xrTableCell246
        // 
        this.xrTableCell246.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell246.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ThrowForwardCapital", "{0:#.000}")});
        this.xrTableCell246.Dpi = 100F;
        this.xrTableCell246.Name = "xrTableCell246";
        this.xrTableCell246.StylePriority.UseBorders = false;
        this.xrTableCell246.Weight = 1D;
        // 
        // xrTableCell247
        // 
        this.xrTableCell247.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell247.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ThrowForwardRevenue", "{0:#.000}")});
        this.xrTableCell247.Dpi = 100F;
        this.xrTableCell247.Name = "xrTableCell247";
        this.xrTableCell247.StylePriority.UseBorders = false;
        this.xrTableCell247.Weight = 1D;
        // 
        // xrTableCell248
        // 
        this.xrTableCell248.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell248.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.TotalThrowForward", "{0:#.000}")});
        this.xrTableCell248.Dpi = 100F;
        this.xrTableCell248.Name = "xrTableCell248";
        this.xrTableCell248.StylePriority.UseBorders = false;
        this.xrTableCell248.Weight = 1D;
        // 
        // xrTableCell284
        // 
        this.xrTableCell284.Dpi = 100F;
        this.xrTableCell284.Name = "xrTableCell284";
        this.xrTableCell284.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrTableCell284.StylePriority.UsePadding = false;
        this.xrTableCell284.Text = "-";
        this.xrTableCell284.Weight = 0.211098765712D;
        // 
        // xrTableCell285
        // 
        this.xrTableCell285.Dpi = 100F;
        this.xrTableCell285.Name = "xrTableCell285";
        this.xrTableCell285.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrTableCell285.StylePriority.UsePadding = false;
        this.xrTableCell285.Text = "-";
        this.xrTableCell285.Weight = 0.211098765712D;
        // 
        // xrTableCell286
        // 
        this.xrTableCell286.Dpi = 100F;
        this.xrTableCell286.Name = "xrTableCell286";
        this.xrTableCell286.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrTableCell286.StylePriority.UsePadding = false;
        this.xrTableCell286.Text = "-";
        this.xrTableCell286.Weight = 0.211098765712D;
        // 
        // xrTableCell287
        // 
        this.xrTableCell287.Dpi = 100F;
        this.xrTableCell287.Name = "xrTableCell287";
        this.xrTableCell287.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrTableCell287.StylePriority.UsePadding = false;
        this.xrTableCell287.Text = "-";
        this.xrTableCell287.Weight = 0.211098765712D;
        // 
        // xrTableCell288
        // 
        this.xrTableCell288.Dpi = 100F;
        this.xrTableCell288.Name = "xrTableCell288";
        this.xrTableCell288.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrTableCell288.StylePriority.UsePadding = false;
        this.xrTableCell288.Text = "-";
        this.xrTableCell288.Weight = 0.211098765712D;
        // 
        // xrTableCell289
        // 
        this.xrTableCell289.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrRichText1});
        this.xrTableCell289.Dpi = 100F;
        this.xrTableCell289.Name = "xrTableCell289";
        this.xrTableCell289.Weight = 0.897215876511302D;
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
        this.xrRichText1.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrRichText1.SerializableRtfString = resources.GetString("xrRichText1.SerializableRtfString");
        this.xrRichText1.SizeF = new System.Drawing.SizeF(367.98F, 128F);
        this.xrRichText1.StylePriority.UseBorders = false;
        this.xrRichText1.StylePriority.UseBorderWidth = false;
        this.xrRichText1.StylePriority.UseFont = false;
        this.xrRichText1.StylePriority.UsePadding = false;
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
        this.xrTable3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 80F);
        this.xrTable3.Name = "xrTable3";
        this.xrTable3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow3});
        this.xrTable3.SizeF = new System.Drawing.SizeF(3374F, 30F);
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
            this.xrTableCell9,
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
            this.xrTableCell91,
            this.xrTableCell157,
            this.xrTableCell158,
            this.xrTableCell159,
            this.xrTableCell160,
            this.xrTableCell161,
            this.xrTableCell162,
            this.xrTableCell163,
            this.xrTableCell164,
            this.xrTableCell165,
            this.xrTableCell166,
            this.xrTableCell167});
        this.xrTableRow3.Dpi = 100F;
        this.xrTableRow3.Name = "xrTableRow3";
        this.xrTableRow3.Weight = 1D;
        // 
        // xrTableCell7
        // 
        this.xrTableCell7.Dpi = 100F;
        this.xrTableCell7.Name = "xrTableCell7";
        this.xrTableCell7.Text = "1";
        this.xrTableCell7.Weight = 0.0809236089163714D;
        // 
        // xrTableCell8
        // 
        this.xrTableCell8.Dpi = 100F;
        this.xrTableCell8.Name = "xrTableCell8";
        this.xrTableCell8.Text = "2";
        this.xrTableCell8.Weight = 0.175920889002736D;
        // 
        // xrTableCell9
        // 
        this.xrTableCell9.Dpi = 100F;
        this.xrTableCell9.Name = "xrTableCell9";
        this.xrTableCell9.Text = "3";
        this.xrTableCell9.Weight = 0.54535473266983D;
        // 
        // xrTableCell35
        // 
        this.xrTableCell35.Dpi = 100F;
        this.xrTableCell35.Name = "xrTableCell35";
        this.xrTableCell35.Text = "4";
        this.xrTableCell35.Weight = 0.211105062445105D;
        // 
        // xrTableCell34
        // 
        this.xrTableCell34.Dpi = 100F;
        this.xrTableCell34.Name = "xrTableCell34";
        this.xrTableCell34.Text = "5";
        this.xrTableCell34.Weight = 0.211105064273414D;
        // 
        // xrTableCell33
        // 
        this.xrTableCell33.Dpi = 100F;
        this.xrTableCell33.Name = "xrTableCell33";
        this.xrTableCell33.Text = "6";
        this.xrTableCell33.Weight = 0.211105040251403D;
        // 
        // xrTableCell32
        // 
        this.xrTableCell32.Dpi = 100F;
        this.xrTableCell32.Name = "xrTableCell32";
        this.xrTableCell32.Text = "7";
        this.xrTableCell32.Weight = 0.246289228153728D;
        // 
        // xrTableCell31
        // 
        this.xrTableCell31.Dpi = 100F;
        this.xrTableCell31.Name = "xrTableCell31";
        this.xrTableCell31.Text = "8";
        this.xrTableCell31.Weight = 0.211105055774498D;
        // 
        // xrTableCell30
        // 
        this.xrTableCell30.Dpi = 100F;
        this.xrTableCell30.Name = "xrTableCell30";
        this.xrTableCell30.Text = "9";
        this.xrTableCell30.Weight = 0.211105049962286D;
        // 
        // xrTableCell29
        // 
        this.xrTableCell29.Dpi = 100F;
        this.xrTableCell29.Name = "xrTableCell29";
        this.xrTableCell29.Text = "10";
        this.xrTableCell29.Weight = 0.211105045877379D;
        // 
        // xrTableCell10
        // 
        this.xrTableCell10.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable20});
        this.xrTableCell10.Dpi = 100F;
        this.xrTableCell10.Name = "xrTableCell10";
        this.xrTableCell10.Weight = 0.387025912213494D;
        // 
        // xrTable20
        // 
        this.xrTable20.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTable20.Dpi = 100F;
        this.xrTable20.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Bold);
        this.xrTable20.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrTable20.Name = "xrTable20";
        this.xrTable20.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow5,
            this.xrTableRow6});
        this.xrTable20.SizeF = new System.Drawing.SizeF(160F, 30F);
        this.xrTable20.StylePriority.UseBorders = false;
        this.xrTable20.StylePriority.UseFont = false;
        this.xrTable20.StylePriority.UseTextAlignment = false;
        this.xrTable20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrTableRow5
        // 
        this.xrTableRow5.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell88,
            this.xrTableCell93,
            this.xrTableCell135});
        this.xrTableRow5.Dpi = 100F;
        this.xrTableRow5.Name = "xrTableRow5";
        this.xrTableRow5.Weight = 1D;
        // 
        // xrTableCell88
        // 
        this.xrTableCell88.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell88.Dpi = 100F;
        this.xrTableCell88.Name = "xrTableCell88";
        this.xrTableCell88.StylePriority.UseBorders = false;
        this.xrTableCell88.Text = "Capital";
        this.xrTableCell88.Weight = 1D;
        // 
        // xrTableCell93
        // 
        this.xrTableCell93.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell93.Dpi = 100F;
        this.xrTableCell93.Name = "xrTableCell93";
        this.xrTableCell93.StylePriority.UseBorders = false;
        this.xrTableCell93.Text = "Revenue";
        this.xrTableCell93.Weight = 1D;
        // 
        // xrTableCell135
        // 
        this.xrTableCell135.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell135.Dpi = 100F;
        this.xrTableCell135.Name = "xrTableCell135";
        this.xrTableCell135.StylePriority.UseBorders = false;
        this.xrTableCell135.Text = "Total";
        this.xrTableCell135.Weight = 1D;
        // 
        // xrTableRow6
        // 
        this.xrTableRow6.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell136,
            this.xrTableCell137,
            this.xrTableCell138});
        this.xrTableRow6.Dpi = 100F;
        this.xrTableRow6.Name = "xrTableRow6";
        this.xrTableRow6.Weight = 1D;
        // 
        // xrTableCell136
        // 
        this.xrTableCell136.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell136.Dpi = 100F;
        this.xrTableCell136.Name = "xrTableCell136";
        this.xrTableCell136.StylePriority.UseBorders = false;
        this.xrTableCell136.StylePriority.UseFont = false;
        this.xrTableCell136.Text = "11";
        this.xrTableCell136.Weight = 1D;
        // 
        // xrTableCell137
        // 
        this.xrTableCell137.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell137.Dpi = 100F;
        this.xrTableCell137.Name = "xrTableCell137";
        this.xrTableCell137.StylePriority.UseBorders = false;
        this.xrTableCell137.StylePriority.UseFont = false;
        this.xrTableCell137.Text = "12";
        this.xrTableCell137.Weight = 1D;
        // 
        // xrTableCell138
        // 
        this.xrTableCell138.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell138.Dpi = 100F;
        this.xrTableCell138.Name = "xrTableCell138";
        this.xrTableCell138.StylePriority.UseBorders = false;
        this.xrTableCell138.StylePriority.UseFont = false;
        this.xrTableCell138.Text = "13";
        this.xrTableCell138.Weight = 1D;
        // 
        // xrTableCell11
        // 
        this.xrTableCell11.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable21});
        this.xrTableCell11.Dpi = 100F;
        this.xrTableCell11.Name = "xrTableCell11";
        this.xrTableCell11.Weight = 0.387030131562782D;
        // 
        // xrTable21
        // 
        this.xrTable21.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTable21.Dpi = 100F;
        this.xrTable21.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Bold);
        this.xrTable21.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrTable21.Name = "xrTable21";
        this.xrTable21.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow42,
            this.xrTableRow43});
        this.xrTable21.SizeF = new System.Drawing.SizeF(161F, 30F);
        this.xrTable21.StylePriority.UseBorders = false;
        this.xrTable21.StylePriority.UseFont = false;
        this.xrTable21.StylePriority.UseTextAlignment = false;
        this.xrTable21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrTableRow42
        // 
        this.xrTableRow42.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell139,
            this.xrTableCell140,
            this.xrTableCell141});
        this.xrTableRow42.Dpi = 100F;
        this.xrTableRow42.Name = "xrTableRow42";
        this.xrTableRow42.Weight = 1D;
        // 
        // xrTableCell139
        // 
        this.xrTableCell139.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell139.Dpi = 100F;
        this.xrTableCell139.Name = "xrTableCell139";
        this.xrTableCell139.StylePriority.UseBorders = false;
        this.xrTableCell139.Text = "Capital";
        this.xrTableCell139.Weight = 1D;
        // 
        // xrTableCell140
        // 
        this.xrTableCell140.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell140.Dpi = 100F;
        this.xrTableCell140.Name = "xrTableCell140";
        this.xrTableCell140.StylePriority.UseBorders = false;
        this.xrTableCell140.Text = "Revenue";
        this.xrTableCell140.Weight = 1D;
        // 
        // xrTableCell141
        // 
        this.xrTableCell141.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell141.Dpi = 100F;
        this.xrTableCell141.Name = "xrTableCell141";
        this.xrTableCell141.StylePriority.UseBorders = false;
        this.xrTableCell141.Text = "Total";
        this.xrTableCell141.Weight = 1D;
        // 
        // xrTableRow43
        // 
        this.xrTableRow43.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell142,
            this.xrTableCell143,
            this.xrTableCell144});
        this.xrTableRow43.Dpi = 100F;
        this.xrTableRow43.Name = "xrTableRow43";
        this.xrTableRow43.Weight = 1D;
        // 
        // xrTableCell142
        // 
        this.xrTableCell142.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell142.Dpi = 100F;
        this.xrTableCell142.Name = "xrTableCell142";
        this.xrTableCell142.StylePriority.UseBorders = false;
        this.xrTableCell142.StylePriority.UseFont = false;
        this.xrTableCell142.Text = "14";
        this.xrTableCell142.Weight = 1D;
        // 
        // xrTableCell143
        // 
        this.xrTableCell143.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell143.Dpi = 100F;
        this.xrTableCell143.Name = "xrTableCell143";
        this.xrTableCell143.StylePriority.UseBorders = false;
        this.xrTableCell143.StylePriority.UseFont = false;
        this.xrTableCell143.Text = "15";
        this.xrTableCell143.Weight = 1D;
        // 
        // xrTableCell144
        // 
        this.xrTableCell144.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell144.Dpi = 100F;
        this.xrTableCell144.Name = "xrTableCell144";
        this.xrTableCell144.StylePriority.UseBorders = false;
        this.xrTableCell144.StylePriority.UseFont = false;
        this.xrTableCell144.Text = "16";
        this.xrTableCell144.Weight = 1D;
        // 
        // xrTableCell89
        // 
        this.xrTableCell89.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable22});
        this.xrTableCell89.Dpi = 100F;
        this.xrTableCell89.Name = "xrTableCell89";
        this.xrTableCell89.Weight = 0.387030096333807D;
        // 
        // xrTable22
        // 
        this.xrTable22.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTable22.Dpi = 100F;
        this.xrTable22.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Bold);
        this.xrTable22.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrTable22.Name = "xrTable22";
        this.xrTable22.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow44,
            this.xrTableRow45});
        this.xrTable22.SizeF = new System.Drawing.SizeF(161F, 30F);
        this.xrTable22.StylePriority.UseBorders = false;
        this.xrTable22.StylePriority.UseFont = false;
        this.xrTable22.StylePriority.UseTextAlignment = false;
        this.xrTable22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrTableRow44
        // 
        this.xrTableRow44.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell145,
            this.xrTableCell146,
            this.xrTableCell147});
        this.xrTableRow44.Dpi = 100F;
        this.xrTableRow44.Name = "xrTableRow44";
        this.xrTableRow44.Weight = 1D;
        // 
        // xrTableCell145
        // 
        this.xrTableCell145.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell145.Dpi = 100F;
        this.xrTableCell145.Name = "xrTableCell145";
        this.xrTableCell145.StylePriority.UseBorders = false;
        this.xrTableCell145.Text = "Capital";
        this.xrTableCell145.Weight = 1D;
        // 
        // xrTableCell146
        // 
        this.xrTableCell146.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell146.Dpi = 100F;
        this.xrTableCell146.Name = "xrTableCell146";
        this.xrTableCell146.StylePriority.UseBorders = false;
        this.xrTableCell146.Text = "Revenue";
        this.xrTableCell146.Weight = 1D;
        // 
        // xrTableCell147
        // 
        this.xrTableCell147.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell147.Dpi = 100F;
        this.xrTableCell147.Name = "xrTableCell147";
        this.xrTableCell147.StylePriority.UseBorders = false;
        this.xrTableCell147.Text = "Total";
        this.xrTableCell147.Weight = 1D;
        // 
        // xrTableRow45
        // 
        this.xrTableRow45.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell148,
            this.xrTableCell149,
            this.xrTableCell150});
        this.xrTableRow45.Dpi = 100F;
        this.xrTableRow45.Name = "xrTableRow45";
        this.xrTableRow45.Weight = 1D;
        // 
        // xrTableCell148
        // 
        this.xrTableCell148.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell148.Dpi = 100F;
        this.xrTableCell148.Name = "xrTableCell148";
        this.xrTableCell148.StylePriority.UseBorders = false;
        this.xrTableCell148.StylePriority.UseFont = false;
        this.xrTableCell148.Text = "17";
        this.xrTableCell148.Weight = 1D;
        // 
        // xrTableCell149
        // 
        this.xrTableCell149.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell149.Dpi = 100F;
        this.xrTableCell149.Name = "xrTableCell149";
        this.xrTableCell149.StylePriority.UseBorders = false;
        this.xrTableCell149.StylePriority.UseFont = false;
        this.xrTableCell149.Text = "18";
        this.xrTableCell149.Weight = 1D;
        // 
        // xrTableCell150
        // 
        this.xrTableCell150.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell150.Dpi = 100F;
        this.xrTableCell150.Name = "xrTableCell150";
        this.xrTableCell150.StylePriority.UseBorders = false;
        this.xrTableCell150.StylePriority.UseFont = false;
        this.xrTableCell150.Text = "19";
        this.xrTableCell150.Weight = 1D;
        // 
        // xrTableCell90
        // 
        this.xrTableCell90.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable23});
        this.xrTableCell90.Dpi = 100F;
        this.xrTableCell90.Name = "xrTableCell90";
        this.xrTableCell90.Weight = 0.387030096333808D;
        // 
        // xrTable23
        // 
        this.xrTable23.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTable23.Dpi = 100F;
        this.xrTable23.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Bold);
        this.xrTable23.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrTable23.Name = "xrTable23";
        this.xrTable23.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow46,
            this.xrTableRow47});
        this.xrTable23.SizeF = new System.Drawing.SizeF(161F, 30F);
        this.xrTable23.StylePriority.UseBorders = false;
        this.xrTable23.StylePriority.UseFont = false;
        this.xrTable23.StylePriority.UseTextAlignment = false;
        this.xrTable23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrTableRow46
        // 
        this.xrTableRow46.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell151,
            this.xrTableCell152,
            this.xrTableCell153});
        this.xrTableRow46.Dpi = 100F;
        this.xrTableRow46.Name = "xrTableRow46";
        this.xrTableRow46.Weight = 1D;
        // 
        // xrTableCell151
        // 
        this.xrTableCell151.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell151.Dpi = 100F;
        this.xrTableCell151.Name = "xrTableCell151";
        this.xrTableCell151.StylePriority.UseBorders = false;
        this.xrTableCell151.Text = "Capital";
        this.xrTableCell151.Weight = 1D;
        // 
        // xrTableCell152
        // 
        this.xrTableCell152.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell152.Dpi = 100F;
        this.xrTableCell152.Name = "xrTableCell152";
        this.xrTableCell152.StylePriority.UseBorders = false;
        this.xrTableCell152.Text = "Revenue";
        this.xrTableCell152.Weight = 1D;
        // 
        // xrTableCell153
        // 
        this.xrTableCell153.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell153.Dpi = 100F;
        this.xrTableCell153.Name = "xrTableCell153";
        this.xrTableCell153.StylePriority.UseBorders = false;
        this.xrTableCell153.Text = "Total";
        this.xrTableCell153.Weight = 1D;
        // 
        // xrTableRow47
        // 
        this.xrTableRow47.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell154,
            this.xrTableCell155,
            this.xrTableCell156});
        this.xrTableRow47.Dpi = 100F;
        this.xrTableRow47.Name = "xrTableRow47";
        this.xrTableRow47.Weight = 1D;
        // 
        // xrTableCell154
        // 
        this.xrTableCell154.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell154.Dpi = 100F;
        this.xrTableCell154.Name = "xrTableCell154";
        this.xrTableCell154.StylePriority.UseBorders = false;
        this.xrTableCell154.StylePriority.UseFont = false;
        this.xrTableCell154.Text = "20";
        this.xrTableCell154.Weight = 1D;
        // 
        // xrTableCell155
        // 
        this.xrTableCell155.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell155.Dpi = 100F;
        this.xrTableCell155.Name = "xrTableCell155";
        this.xrTableCell155.StylePriority.UseBorders = false;
        this.xrTableCell155.StylePriority.UseFont = false;
        this.xrTableCell155.Text = "21";
        this.xrTableCell155.Weight = 1D;
        // 
        // xrTableCell156
        // 
        this.xrTableCell156.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell156.Dpi = 100F;
        this.xrTableCell156.Name = "xrTableCell156";
        this.xrTableCell156.StylePriority.UseBorders = false;
        this.xrTableCell156.StylePriority.UseFont = false;
        this.xrTableCell156.Text = "22";
        this.xrTableCell156.Weight = 1D;
        // 
        // xrTableCell91
        // 
        this.xrTableCell91.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable24});
        this.xrTableCell91.Dpi = 100F;
        this.xrTableCell91.Name = "xrTableCell91";
        this.xrTableCell91.Weight = 0.387029574554307D;
        // 
        // xrTable24
        // 
        this.xrTable24.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTable24.Dpi = 100F;
        this.xrTable24.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Bold);
        this.xrTable24.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrTable24.Name = "xrTable24";
        this.xrTable24.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow48,
            this.xrTableRow49});
        this.xrTable24.SizeF = new System.Drawing.SizeF(161F, 30F);
        this.xrTable24.StylePriority.UseBorders = false;
        this.xrTable24.StylePriority.UseFont = false;
        this.xrTable24.StylePriority.UseTextAlignment = false;
        this.xrTable24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrTableRow48
        // 
        this.xrTableRow48.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell168,
            this.xrTableCell169,
            this.xrTableCell170});
        this.xrTableRow48.Dpi = 100F;
        this.xrTableRow48.Name = "xrTableRow48";
        this.xrTableRow48.Weight = 1D;
        // 
        // xrTableCell168
        // 
        this.xrTableCell168.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell168.Dpi = 100F;
        this.xrTableCell168.Name = "xrTableCell168";
        this.xrTableCell168.StylePriority.UseBorders = false;
        this.xrTableCell168.Text = "Capital";
        this.xrTableCell168.Weight = 1D;
        // 
        // xrTableCell169
        // 
        this.xrTableCell169.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell169.Dpi = 100F;
        this.xrTableCell169.Name = "xrTableCell169";
        this.xrTableCell169.StylePriority.UseBorders = false;
        this.xrTableCell169.Text = "Revenue";
        this.xrTableCell169.Weight = 1D;
        // 
        // xrTableCell170
        // 
        this.xrTableCell170.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell170.Dpi = 100F;
        this.xrTableCell170.Name = "xrTableCell170";
        this.xrTableCell170.StylePriority.UseBorders = false;
        this.xrTableCell170.Text = "Total";
        this.xrTableCell170.Weight = 1D;
        // 
        // xrTableRow49
        // 
        this.xrTableRow49.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell171,
            this.xrTableCell172,
            this.xrTableCell173});
        this.xrTableRow49.Dpi = 100F;
        this.xrTableRow49.Name = "xrTableRow49";
        this.xrTableRow49.Weight = 1D;
        // 
        // xrTableCell171
        // 
        this.xrTableCell171.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell171.Dpi = 100F;
        this.xrTableCell171.Name = "xrTableCell171";
        this.xrTableCell171.StylePriority.UseBorders = false;
        this.xrTableCell171.StylePriority.UseFont = false;
        this.xrTableCell171.Text = "23";
        this.xrTableCell171.Weight = 1D;
        // 
        // xrTableCell172
        // 
        this.xrTableCell172.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell172.Dpi = 100F;
        this.xrTableCell172.Name = "xrTableCell172";
        this.xrTableCell172.StylePriority.UseBorders = false;
        this.xrTableCell172.StylePriority.UseFont = false;
        this.xrTableCell172.Text = "24";
        this.xrTableCell172.Weight = 1D;
        // 
        // xrTableCell173
        // 
        this.xrTableCell173.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell173.Dpi = 100F;
        this.xrTableCell173.Name = "xrTableCell173";
        this.xrTableCell173.StylePriority.UseBorders = false;
        this.xrTableCell173.StylePriority.UseFont = false;
        this.xrTableCell173.Text = "25";
        this.xrTableCell173.Weight = 1D;
        // 
        // xrTableCell157
        // 
        this.xrTableCell157.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable25});
        this.xrTableCell157.Dpi = 100F;
        this.xrTableCell157.Name = "xrTableCell157";
        this.xrTableCell157.Weight = 0.387029574554307D;
        // 
        // xrTable25
        // 
        this.xrTable25.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTable25.Dpi = 100F;
        this.xrTable25.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Bold);
        this.xrTable25.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrTable25.Name = "xrTable25";
        this.xrTable25.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow50,
            this.xrTableRow51});
        this.xrTable25.SizeF = new System.Drawing.SizeF(161F, 30F);
        this.xrTable25.StylePriority.UseBorders = false;
        this.xrTable25.StylePriority.UseFont = false;
        this.xrTable25.StylePriority.UseTextAlignment = false;
        this.xrTable25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrTableRow50
        // 
        this.xrTableRow50.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell174,
            this.xrTableCell175,
            this.xrTableCell176});
        this.xrTableRow50.Dpi = 100F;
        this.xrTableRow50.Name = "xrTableRow50";
        this.xrTableRow50.Weight = 1D;
        // 
        // xrTableCell174
        // 
        this.xrTableCell174.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell174.Dpi = 100F;
        this.xrTableCell174.Name = "xrTableCell174";
        this.xrTableCell174.StylePriority.UseBorders = false;
        this.xrTableCell174.Text = "Capital";
        this.xrTableCell174.Weight = 1D;
        // 
        // xrTableCell175
        // 
        this.xrTableCell175.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell175.Dpi = 100F;
        this.xrTableCell175.Name = "xrTableCell175";
        this.xrTableCell175.StylePriority.UseBorders = false;
        this.xrTableCell175.Text = "Revenue";
        this.xrTableCell175.Weight = 1D;
        // 
        // xrTableCell176
        // 
        this.xrTableCell176.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell176.Dpi = 100F;
        this.xrTableCell176.Name = "xrTableCell176";
        this.xrTableCell176.StylePriority.UseBorders = false;
        this.xrTableCell176.Text = "Total";
        this.xrTableCell176.Weight = 1D;
        // 
        // xrTableRow51
        // 
        this.xrTableRow51.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell177,
            this.xrTableCell178,
            this.xrTableCell179});
        this.xrTableRow51.Dpi = 100F;
        this.xrTableRow51.Name = "xrTableRow51";
        this.xrTableRow51.Weight = 1D;
        // 
        // xrTableCell177
        // 
        this.xrTableCell177.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell177.Dpi = 100F;
        this.xrTableCell177.Name = "xrTableCell177";
        this.xrTableCell177.StylePriority.UseBorders = false;
        this.xrTableCell177.StylePriority.UseFont = false;
        this.xrTableCell177.Text = "26";
        this.xrTableCell177.Weight = 1D;
        // 
        // xrTableCell178
        // 
        this.xrTableCell178.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell178.Dpi = 100F;
        this.xrTableCell178.Name = "xrTableCell178";
        this.xrTableCell178.StylePriority.UseBorders = false;
        this.xrTableCell178.StylePriority.UseFont = false;
        this.xrTableCell178.Text = "27";
        this.xrTableCell178.Weight = 1D;
        // 
        // xrTableCell179
        // 
        this.xrTableCell179.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell179.Dpi = 100F;
        this.xrTableCell179.Name = "xrTableCell179";
        this.xrTableCell179.StylePriority.UseBorders = false;
        this.xrTableCell179.StylePriority.UseFont = false;
        this.xrTableCell179.Text = "28";
        this.xrTableCell179.Weight = 1D;
        // 
        // xrTableCell158
        // 
        this.xrTableCell158.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable26});
        this.xrTableCell158.Dpi = 100F;
        this.xrTableCell158.Name = "xrTableCell158";
        this.xrTableCell158.Weight = 0.387029574554307D;
        // 
        // xrTable26
        // 
        this.xrTable26.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTable26.Dpi = 100F;
        this.xrTable26.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Bold);
        this.xrTable26.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrTable26.Name = "xrTable26";
        this.xrTable26.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow52,
            this.xrTableRow53});
        this.xrTable26.SizeF = new System.Drawing.SizeF(161F, 30F);
        this.xrTable26.StylePriority.UseBorders = false;
        this.xrTable26.StylePriority.UseFont = false;
        this.xrTable26.StylePriority.UseTextAlignment = false;
        this.xrTable26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrTableRow52
        // 
        this.xrTableRow52.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell180,
            this.xrTableCell181,
            this.xrTableCell182});
        this.xrTableRow52.Dpi = 100F;
        this.xrTableRow52.Name = "xrTableRow52";
        this.xrTableRow52.Weight = 1D;
        // 
        // xrTableCell180
        // 
        this.xrTableCell180.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell180.Dpi = 100F;
        this.xrTableCell180.Name = "xrTableCell180";
        this.xrTableCell180.StylePriority.UseBorders = false;
        this.xrTableCell180.Text = "Capital";
        this.xrTableCell180.Weight = 1D;
        // 
        // xrTableCell181
        // 
        this.xrTableCell181.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell181.Dpi = 100F;
        this.xrTableCell181.Name = "xrTableCell181";
        this.xrTableCell181.StylePriority.UseBorders = false;
        this.xrTableCell181.Text = "Revenue";
        this.xrTableCell181.Weight = 1D;
        // 
        // xrTableCell182
        // 
        this.xrTableCell182.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell182.Dpi = 100F;
        this.xrTableCell182.Name = "xrTableCell182";
        this.xrTableCell182.StylePriority.UseBorders = false;
        this.xrTableCell182.Text = "Total";
        this.xrTableCell182.Weight = 1D;
        // 
        // xrTableRow53
        // 
        this.xrTableRow53.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell183,
            this.xrTableCell184,
            this.xrTableCell185});
        this.xrTableRow53.Dpi = 100F;
        this.xrTableRow53.Name = "xrTableRow53";
        this.xrTableRow53.Weight = 1D;
        // 
        // xrTableCell183
        // 
        this.xrTableCell183.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell183.Dpi = 100F;
        this.xrTableCell183.Name = "xrTableCell183";
        this.xrTableCell183.StylePriority.UseBorders = false;
        this.xrTableCell183.StylePriority.UseFont = false;
        this.xrTableCell183.Text = "29";
        this.xrTableCell183.Weight = 1D;
        // 
        // xrTableCell184
        // 
        this.xrTableCell184.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell184.Dpi = 100F;
        this.xrTableCell184.Name = "xrTableCell184";
        this.xrTableCell184.StylePriority.UseBorders = false;
        this.xrTableCell184.StylePriority.UseFont = false;
        this.xrTableCell184.Text = "30";
        this.xrTableCell184.Weight = 1D;
        // 
        // xrTableCell185
        // 
        this.xrTableCell185.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell185.Dpi = 100F;
        this.xrTableCell185.Name = "xrTableCell185";
        this.xrTableCell185.StylePriority.UseBorders = false;
        this.xrTableCell185.StylePriority.UseFont = false;
        this.xrTableCell185.Text = "31";
        this.xrTableCell185.Weight = 1D;
        // 
        // xrTableCell159
        // 
        this.xrTableCell159.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable27});
        this.xrTableCell159.Dpi = 100F;
        this.xrTableCell159.Name = "xrTableCell159";
        this.xrTableCell159.Weight = 0.387029574554307D;
        // 
        // xrTable27
        // 
        this.xrTable27.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTable27.Dpi = 100F;
        this.xrTable27.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Bold);
        this.xrTable27.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrTable27.Name = "xrTable27";
        this.xrTable27.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow54,
            this.xrTableRow55});
        this.xrTable27.SizeF = new System.Drawing.SizeF(161F, 30F);
        this.xrTable27.StylePriority.UseBorders = false;
        this.xrTable27.StylePriority.UseFont = false;
        this.xrTable27.StylePriority.UseTextAlignment = false;
        this.xrTable27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrTableRow54
        // 
        this.xrTableRow54.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell186,
            this.xrTableCell187,
            this.xrTableCell188});
        this.xrTableRow54.Dpi = 100F;
        this.xrTableRow54.Name = "xrTableRow54";
        this.xrTableRow54.Weight = 1D;
        // 
        // xrTableCell186
        // 
        this.xrTableCell186.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell186.Dpi = 100F;
        this.xrTableCell186.Name = "xrTableCell186";
        this.xrTableCell186.StylePriority.UseBorders = false;
        this.xrTableCell186.Text = "Capital";
        this.xrTableCell186.Weight = 1D;
        // 
        // xrTableCell187
        // 
        this.xrTableCell187.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell187.Dpi = 100F;
        this.xrTableCell187.Name = "xrTableCell187";
        this.xrTableCell187.StylePriority.UseBorders = false;
        this.xrTableCell187.Text = "Revenue";
        this.xrTableCell187.Weight = 1D;
        // 
        // xrTableCell188
        // 
        this.xrTableCell188.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell188.Dpi = 100F;
        this.xrTableCell188.Name = "xrTableCell188";
        this.xrTableCell188.StylePriority.UseBorders = false;
        this.xrTableCell188.Text = "Total";
        this.xrTableCell188.Weight = 1D;
        // 
        // xrTableRow55
        // 
        this.xrTableRow55.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell189,
            this.xrTableCell190,
            this.xrTableCell191});
        this.xrTableRow55.Dpi = 100F;
        this.xrTableRow55.Name = "xrTableRow55";
        this.xrTableRow55.Weight = 1D;
        // 
        // xrTableCell189
        // 
        this.xrTableCell189.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell189.Dpi = 100F;
        this.xrTableCell189.Name = "xrTableCell189";
        this.xrTableCell189.StylePriority.UseBorders = false;
        this.xrTableCell189.StylePriority.UseFont = false;
        this.xrTableCell189.Text = "32";
        this.xrTableCell189.Weight = 1D;
        // 
        // xrTableCell190
        // 
        this.xrTableCell190.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell190.Dpi = 100F;
        this.xrTableCell190.Name = "xrTableCell190";
        this.xrTableCell190.StylePriority.UseBorders = false;
        this.xrTableCell190.StylePriority.UseFont = false;
        this.xrTableCell190.Text = "33";
        this.xrTableCell190.Weight = 1D;
        // 
        // xrTableCell191
        // 
        this.xrTableCell191.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell191.Dpi = 100F;
        this.xrTableCell191.Name = "xrTableCell191";
        this.xrTableCell191.StylePriority.UseBorders = false;
        this.xrTableCell191.StylePriority.UseFont = false;
        this.xrTableCell191.Text = "34";
        this.xrTableCell191.Weight = 1D;
        // 
        // xrTableCell160
        // 
        this.xrTableCell160.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable28});
        this.xrTableCell160.Dpi = 100F;
        this.xrTableCell160.Name = "xrTableCell160";
        this.xrTableCell160.Weight = 0.387029574554307D;
        // 
        // xrTable28
        // 
        this.xrTable28.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTable28.Dpi = 100F;
        this.xrTable28.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Bold);
        this.xrTable28.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrTable28.Name = "xrTable28";
        this.xrTable28.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow56,
            this.xrTableRow57});
        this.xrTable28.SizeF = new System.Drawing.SizeF(161F, 30F);
        this.xrTable28.StylePriority.UseBorders = false;
        this.xrTable28.StylePriority.UseFont = false;
        this.xrTable28.StylePriority.UseTextAlignment = false;
        this.xrTable28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrTableRow56
        // 
        this.xrTableRow56.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell192,
            this.xrTableCell193,
            this.xrTableCell194});
        this.xrTableRow56.Dpi = 100F;
        this.xrTableRow56.Name = "xrTableRow56";
        this.xrTableRow56.Weight = 1D;
        // 
        // xrTableCell192
        // 
        this.xrTableCell192.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell192.Dpi = 100F;
        this.xrTableCell192.Name = "xrTableCell192";
        this.xrTableCell192.StylePriority.UseBorders = false;
        this.xrTableCell192.Text = "Capital";
        this.xrTableCell192.Weight = 1D;
        // 
        // xrTableCell193
        // 
        this.xrTableCell193.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell193.Dpi = 100F;
        this.xrTableCell193.Name = "xrTableCell193";
        this.xrTableCell193.StylePriority.UseBorders = false;
        this.xrTableCell193.Text = "Revenue";
        this.xrTableCell193.Weight = 1D;
        // 
        // xrTableCell194
        // 
        this.xrTableCell194.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell194.Dpi = 100F;
        this.xrTableCell194.Name = "xrTableCell194";
        this.xrTableCell194.StylePriority.UseBorders = false;
        this.xrTableCell194.Text = "Total";
        this.xrTableCell194.Weight = 1D;
        // 
        // xrTableRow57
        // 
        this.xrTableRow57.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell195,
            this.xrTableCell196,
            this.xrTableCell197});
        this.xrTableRow57.Dpi = 100F;
        this.xrTableRow57.Name = "xrTableRow57";
        this.xrTableRow57.Weight = 1D;
        // 
        // xrTableCell195
        // 
        this.xrTableCell195.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell195.Dpi = 100F;
        this.xrTableCell195.Name = "xrTableCell195";
        this.xrTableCell195.StylePriority.UseBorders = false;
        this.xrTableCell195.StylePriority.UseFont = false;
        this.xrTableCell195.Text = "35";
        this.xrTableCell195.Weight = 1D;
        // 
        // xrTableCell196
        // 
        this.xrTableCell196.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell196.Dpi = 100F;
        this.xrTableCell196.Name = "xrTableCell196";
        this.xrTableCell196.StylePriority.UseBorders = false;
        this.xrTableCell196.StylePriority.UseFont = false;
        this.xrTableCell196.Text = "36";
        this.xrTableCell196.Weight = 1D;
        // 
        // xrTableCell197
        // 
        this.xrTableCell197.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell197.Dpi = 100F;
        this.xrTableCell197.Name = "xrTableCell197";
        this.xrTableCell197.StylePriority.UseBorders = false;
        this.xrTableCell197.StylePriority.UseFont = false;
        this.xrTableCell197.Text = "37";
        this.xrTableCell197.Weight = 1D;
        // 
        // xrTableCell161
        // 
        this.xrTableCell161.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable29});
        this.xrTableCell161.Dpi = 100F;
        this.xrTableCell161.Name = "xrTableCell161";
        this.xrTableCell161.Weight = 0.387029574554307D;
        // 
        // xrTable29
        // 
        this.xrTable29.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTable29.Dpi = 100F;
        this.xrTable29.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Bold);
        this.xrTable29.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrTable29.Name = "xrTable29";
        this.xrTable29.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow58,
            this.xrTableRow59});
        this.xrTable29.SizeF = new System.Drawing.SizeF(161F, 30F);
        this.xrTable29.StylePriority.UseBorders = false;
        this.xrTable29.StylePriority.UseFont = false;
        this.xrTable29.StylePriority.UseTextAlignment = false;
        this.xrTable29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrTableRow58
        // 
        this.xrTableRow58.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell198,
            this.xrTableCell199,
            this.xrTableCell200});
        this.xrTableRow58.Dpi = 100F;
        this.xrTableRow58.Name = "xrTableRow58";
        this.xrTableRow58.Weight = 1D;
        // 
        // xrTableCell198
        // 
        this.xrTableCell198.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell198.Dpi = 100F;
        this.xrTableCell198.Name = "xrTableCell198";
        this.xrTableCell198.StylePriority.UseBorders = false;
        this.xrTableCell198.Text = "Capital";
        this.xrTableCell198.Weight = 1D;
        // 
        // xrTableCell199
        // 
        this.xrTableCell199.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell199.Dpi = 100F;
        this.xrTableCell199.Name = "xrTableCell199";
        this.xrTableCell199.StylePriority.UseBorders = false;
        this.xrTableCell199.Text = "Revenue";
        this.xrTableCell199.Weight = 1D;
        // 
        // xrTableCell200
        // 
        this.xrTableCell200.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell200.Dpi = 100F;
        this.xrTableCell200.Name = "xrTableCell200";
        this.xrTableCell200.StylePriority.UseBorders = false;
        this.xrTableCell200.Text = "Total";
        this.xrTableCell200.Weight = 1D;
        // 
        // xrTableRow59
        // 
        this.xrTableRow59.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell201,
            this.xrTableCell202,
            this.xrTableCell203});
        this.xrTableRow59.Dpi = 100F;
        this.xrTableRow59.Name = "xrTableRow59";
        this.xrTableRow59.Weight = 1D;
        // 
        // xrTableCell201
        // 
        this.xrTableCell201.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell201.Dpi = 100F;
        this.xrTableCell201.Name = "xrTableCell201";
        this.xrTableCell201.StylePriority.UseBorders = false;
        this.xrTableCell201.StylePriority.UseFont = false;
        this.xrTableCell201.Text = "38";
        this.xrTableCell201.Weight = 1D;
        // 
        // xrTableCell202
        // 
        this.xrTableCell202.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell202.Dpi = 100F;
        this.xrTableCell202.Name = "xrTableCell202";
        this.xrTableCell202.StylePriority.UseBorders = false;
        this.xrTableCell202.StylePriority.UseFont = false;
        this.xrTableCell202.Text = "39";
        this.xrTableCell202.Weight = 1D;
        // 
        // xrTableCell203
        // 
        this.xrTableCell203.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell203.Dpi = 100F;
        this.xrTableCell203.Name = "xrTableCell203";
        this.xrTableCell203.StylePriority.UseBorders = false;
        this.xrTableCell203.StylePriority.UseFont = false;
        this.xrTableCell203.Text = "40";
        this.xrTableCell203.Weight = 1D;
        // 
        // xrTableCell162
        // 
        this.xrTableCell162.Dpi = 100F;
        this.xrTableCell162.Name = "xrTableCell162";
        this.xrTableCell162.Text = "41";
        this.xrTableCell162.Weight = 0.211098765712D;
        // 
        // xrTableCell163
        // 
        this.xrTableCell163.Dpi = 100F;
        this.xrTableCell163.Name = "xrTableCell163";
        this.xrTableCell163.Text = "42";
        this.xrTableCell163.Weight = 0.211098765712D;
        // 
        // xrTableCell164
        // 
        this.xrTableCell164.Dpi = 100F;
        this.xrTableCell164.Name = "xrTableCell164";
        this.xrTableCell164.Text = "43";
        this.xrTableCell164.Weight = 0.211098765712D;
        // 
        // xrTableCell165
        // 
        this.xrTableCell165.Dpi = 100F;
        this.xrTableCell165.Name = "xrTableCell165";
        this.xrTableCell165.Text = "44";
        this.xrTableCell165.Weight = 0.211098765712D;
        // 
        // xrTableCell166
        // 
        this.xrTableCell166.Dpi = 100F;
        this.xrTableCell166.Name = "xrTableCell166";
        this.xrTableCell166.Text = "45";
        this.xrTableCell166.Weight = 0.211098765712D;
        // 
        // xrTableCell167
        // 
        this.xrTableCell167.Dpi = 100F;
        this.xrTableCell167.Name = "xrTableCell167";
        this.xrTableCell167.Text = "46";
        this.xrTableCell167.Weight = 0.897215876511302D;
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
        this.xrTable2.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
        this.xrTable2.SizeF = new System.Drawing.SizeF(3374F, 80F);
        this.xrTable2.StylePriority.UseBackColor = false;
        this.xrTable2.StylePriority.UseBorders = false;
        this.xrTable2.StylePriority.UseFont = false;
        this.xrTable2.StylePriority.UsePadding = false;
        this.xrTable2.StylePriority.UseTextAlignment = false;
        this.xrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrTableRow2
        // 
        this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell84,
            this.xrTableCell2,
            this.xrTableCell3,
            this.xrTableCell4,
            this.xrTableCell1,
            this.xrTableCell5,
            this.xrTableCell16,
            this.xrTableCell17,
            this.xrTableCell18,
            this.xrTableCell24,
            this.xrTableCell36,
            this.xrTableCell86,
            this.xrTableCell87,
            this.xrTableCell12,
            this.xrTableCell15,
            this.xrTableCell19,
            this.xrTableCell20,
            this.xrTableCell21,
            this.xrTableCell27,
            this.xrTableCell28,
            this.xrTableCell40,
            this.xrTableCell41,
            this.xrTableCell61,
            this.xrTableCell62,
            this.xrTableCell74,
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
        this.xrTableCell84.Weight = 0.206943683910217D;
        // 
        // xrTableCell2
        // 
        this.xrTableCell2.BackColor = System.Drawing.Color.Transparent;
        this.xrTableCell2.Dpi = 100F;
        this.xrTableCell2.Name = "xrTableCell2";
        this.xrTableCell2.StylePriority.UseBackColor = false;
        this.xrTableCell2.Text = "ADP No.";
        this.xrTableCell2.Weight = 0.449780336626086D;
        // 
        // xrTableCell3
        // 
        this.xrTableCell3.BackColor = System.Drawing.Color.Transparent;
        this.xrTableCell3.Dpi = 100F;
        this.xrTableCell3.Name = "xrTableCell3";
        this.xrTableCell3.StylePriority.UseBackColor = false;
        this.xrTableCell3.Text = "Name of Scheme";
        this.xrTableCell3.Weight = 1.39431911305431D;
        // 
        // xrTableCell4
        // 
        this.xrTableCell4.BackColor = System.Drawing.Color.Transparent;
        this.xrTableCell4.Dpi = 100F;
        this.xrTableCell4.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Bold);
        this.xrTableCell4.Name = "xrTableCell4";
        this.xrTableCell4.StylePriority.UseBackColor = false;
        this.xrTableCell4.StylePriority.UseFont = false;
        this.xrTableCell4.Text = "Category";
        this.xrTableCell4.Weight = 0.539736413451625D;
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
        this.xrTableCell1.Text = "Facility";
        this.xrTableCell1.Weight = 0.539736409886735D;
        // 
        // xrTableCell5
        // 
        this.xrTableCell5.BackColor = System.Drawing.Color.Transparent;
        this.xrTableCell5.Dpi = 100F;
        this.xrTableCell5.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Bold);
        this.xrTableCell5.Name = "xrTableCell5";
        this.xrTableCell5.StylePriority.UseBackColor = false;
        this.xrTableCell5.StylePriority.UseFont = false;
        this.xrTableCell5.Text = "Approval Status";
        this.xrTableCell5.Weight = 0.539736409886735D;
        // 
        // xrTableCell16
        // 
        this.xrTableCell16.BackColor = System.Drawing.Color.Transparent;
        this.xrTableCell16.Dpi = 100F;
        this.xrTableCell16.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Bold);
        this.xrTableCell16.Name = "xrTableCell16";
        this.xrTableCell16.StylePriority.UseBackColor = false;
        this.xrTableCell16.StylePriority.UseFont = false;
        this.xrTableCell16.Text = "Approval Forum / Date";
        this.xrTableCell16.Weight = 0.629692504865881D;
        // 
        // xrTableCell17
        // 
        this.xrTableCell17.BackColor = System.Drawing.Color.Transparent;
        this.xrTableCell17.Dpi = 100F;
        this.xrTableCell17.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Bold);
        this.xrTableCell17.Name = "xrTableCell17";
        this.xrTableCell17.StylePriority.UseBackColor = false;
        this.xrTableCell17.StylePriority.UseFont = false;
        this.xrTableCell17.Text = "District";
        this.xrTableCell17.Weight = 0.539736409886735D;
        // 
        // xrTableCell18
        // 
        this.xrTableCell18.BackColor = System.Drawing.Color.Transparent;
        this.xrTableCell18.Dpi = 100F;
        this.xrTableCell18.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Bold);
        this.xrTableCell18.Name = "xrTableCell18";
        this.xrTableCell18.StylePriority.UseBackColor = false;
        this.xrTableCell18.StylePriority.UseFont = false;
        this.xrTableCell18.Text = "Division";
        this.xrTableCell18.Weight = 0.539736409886735D;
        // 
        // xrTableCell24
        // 
        this.xrTableCell24.BackColor = System.Drawing.Color.Transparent;
        this.xrTableCell24.Dpi = 100F;
        this.xrTableCell24.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Bold);
        this.xrTableCell24.Name = "xrTableCell24";
        this.xrTableCell24.StylePriority.UseBackColor = false;
        this.xrTableCell24.StylePriority.UseFont = false;
        this.xrTableCell24.Text = "Region";
        this.xrTableCell24.Weight = 0.539736409886735D;
        // 
        // xrTableCell36
        // 
        this.xrTableCell36.BackColor = System.Drawing.Color.Transparent;
        this.xrTableCell36.Dpi = 100F;
        this.xrTableCell36.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Bold);
        this.xrTableCell36.Name = "xrTableCell36";
        this.xrTableCell36.StylePriority.UseBackColor = false;
        this.xrTableCell36.StylePriority.UseFont = false;
        this.xrTableCell36.Text = "Approved / Estimated Cost";
        this.xrTableCell36.Weight = 0.989516745477749D;
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
        this.xrTableCell86.Weight = 0.989516745477749D;
        // 
        // xrTableCell87
        // 
        this.xrTableCell87.BackColor = System.Drawing.Color.Transparent;
        this.xrTableCell87.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "headOrigionalAllocation")});
        this.xrTableCell87.Dpi = 100F;
        this.xrTableCell87.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Bold);
        this.xrTableCell87.Name = "xrTableCell87";
        this.xrTableCell87.StylePriority.UseBackColor = false;
        this.xrTableCell87.StylePriority.UseFont = false;
        this.xrTableCell87.Weight = 0.989516745477749D;
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
        this.xrTableCell12.Weight = 0.989516754057387D;
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
        this.xrTableCell15.Weight = 0.989516732523563D;
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
        this.xrTableCell19.Weight = 0.989516742583093D;
        // 
        // xrTableCell20
        // 
        this.xrTableCell20.BackColor = System.Drawing.Color.Transparent;
        this.xrTableCell20.Dpi = 100F;
        this.xrTableCell20.Multiline = true;
        this.xrTableCell20.Name = "xrTableCell20";
        this.xrTableCell20.StylePriority.UseBackColor = false;
        this.xrTableCell20.Text = "%age Utilization on Releases        \r\n";
        this.xrTableCell20.Weight = 0.989516737695851D;
        // 
        // xrTableCell21
        // 
        this.xrTableCell21.BackColor = System.Drawing.Color.Transparent;
        this.xrTableCell21.Dpi = 100F;
        this.xrTableCell21.Multiline = true;
        this.xrTableCell21.Name = "xrTableCell21";
        this.xrTableCell21.StylePriority.UseBackColor = false;
        this.xrTableCell21.Text = "Cumulative Expenditure";
        this.xrTableCell21.Weight = 0.989516735111084D;
        // 
        // xrTableCell27
        // 
        this.xrTableCell27.BackColor = System.Drawing.Color.Transparent;
        this.xrTableCell27.Dpi = 100F;
        this.xrTableCell27.Multiline = true;
        this.xrTableCell27.Name = "xrTableCell27";
        this.xrTableCell27.StylePriority.UseBackColor = false;
        this.xrTableCell27.Text = "Financial Progress till Current Month";
        this.xrTableCell27.Weight = 0.98951673503517D;
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
        this.xrTableCell28.Text = "Throw Forward\r\n";
        this.xrTableCell28.Weight = 0.989527435779442D;
        // 
        // xrTableCell40
        // 
        this.xrTableCell40.BackColor = System.Drawing.Color.Transparent;
        this.xrTableCell40.Dpi = 100F;
        this.xrTableCell40.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Bold);
        this.xrTableCell40.Name = "xrTableCell40";
        this.xrTableCell40.StylePriority.UseBackColor = false;
        this.xrTableCell40.StylePriority.UseFont = false;
        this.xrTableCell40.Text = "Grand Total";
        this.xrTableCell40.Weight = 0.539719753831311D;
        // 
        // xrTableCell41
        // 
        this.xrTableCell41.BackColor = System.Drawing.Color.Transparent;
        this.xrTableCell41.Dpi = 100F;
        this.xrTableCell41.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Bold);
        this.xrTableCell41.Name = "xrTableCell41";
        this.xrTableCell41.StylePriority.UseBackColor = false;
        this.xrTableCell41.StylePriority.UseFont = false;
        this.xrTableCell41.Text = "Proposed";
        this.xrTableCell41.Weight = 0.539719753831311D;
        // 
        // xrTableCell61
        // 
        this.xrTableCell61.BackColor = System.Drawing.Color.Transparent;
        this.xrTableCell61.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "headProjectionCurrentFY")});
        this.xrTableCell61.Dpi = 100F;
        this.xrTableCell61.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Bold);
        this.xrTableCell61.Name = "xrTableCell61";
        this.xrTableCell61.StylePriority.UseBackColor = false;
        this.xrTableCell61.StylePriority.UseFont = false;
        this.xrTableCell61.Weight = 0.539719736677263D;
        // 
        // xrTableCell62
        // 
        this.xrTableCell62.BackColor = System.Drawing.Color.Transparent;
        this.xrTableCell62.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "headProjectionNextFY")});
        this.xrTableCell62.Dpi = 100F;
        this.xrTableCell62.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Bold);
        this.xrTableCell62.Name = "xrTableCell62";
        this.xrTableCell62.StylePriority.UseBackColor = false;
        this.xrTableCell62.StylePriority.UseFont = false;
        this.xrTableCell62.Weight = 0.539719736677263D;
        // 
        // xrTableCell74
        // 
        this.xrTableCell74.BackColor = System.Drawing.Color.Transparent;
        this.xrTableCell74.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "headThrowForwardBeyond")});
        this.xrTableCell74.Dpi = 100F;
        this.xrTableCell74.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Bold);
        this.xrTableCell74.Name = "xrTableCell74";
        this.xrTableCell74.StylePriority.UseBackColor = false;
        this.xrTableCell74.StylePriority.UseFont = false;
        this.xrTableCell74.Weight = 0.539719770992779D;
        // 
        // xrTableCell6
        // 
        this.xrTableCell6.BackColor = System.Drawing.Color.Transparent;
        this.xrTableCell6.Dpi = 100F;
        this.xrTableCell6.Multiline = true;
        this.xrTableCell6.Name = "xrTableCell6";
        this.xrTableCell6.StylePriority.UseBackColor = false;
        this.xrTableCell6.Text = "Remarks";
        this.xrTableCell6.Weight = 2.29390747352406D;
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
        this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrLabel1.Name = "xrLabel1";
        this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel1.SizeF = new System.Drawing.SizeF(3374F, 52F);
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
        this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrTable1.Name = "xrTable1";
        this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
        this.xrTable1.SizeF = new System.Drawing.SizeF(3374F, 20F);
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
        this.xrTableCell13.Weight = 1D;
        // 
        // GroupFooter1
        // 
        this.GroupFooter1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable5});
        this.GroupFooter1.Dpi = 100F;
        this.GroupFooter1.HeightF = 30F;
        this.GroupFooter1.Name = "GroupFooter1";
        // 
        // xrTable5
        // 
        this.xrTable5.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTable5.Dpi = 100F;
        this.xrTable5.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Bold);
        this.xrTable5.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrTable5.Name = "xrTable5";
        this.xrTable5.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow7});
        this.xrTable5.SizeF = new System.Drawing.SizeF(3374F, 30F);
        this.xrTable5.StylePriority.UseBorders = false;
        this.xrTable5.StylePriority.UseFont = false;
        this.xrTable5.StylePriority.UseTextAlignment = false;
        this.xrTable5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        // 
        // xrTableRow7
        // 
        this.xrTableRow7.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell22,
            this.xrTableCell23,
            this.xrTableCell25,
            this.xrTableCell26,
            this.xrTableCell37,
            this.xrTableCell38,
            this.xrTableCell39,
            this.xrTableCell42,
            this.xrTableCell43,
            this.xrTableCell44,
            this.xrTableCell45,
            this.xrTableCell49,
            this.xrTableCell53,
            this.xrTableCell57,
            this.xrTableCell63,
            this.xrTableCell67,
            this.xrTableCell92,
            this.xrTableCell97,
            this.xrTableCell101,
            this.xrTableCell105,
            this.xrTableCell109,
            this.xrTableCell110,
            this.xrTableCell111,
            this.xrTableCell112,
            this.xrTableCell113,
            this.xrTableCell114});
        this.xrTableRow7.Dpi = 100F;
        this.xrTableRow7.Name = "xrTableRow7";
        this.xrTableRow7.Weight = 1D;
        // 
        // xrTableCell22
        // 
        this.xrTableCell22.Dpi = 100F;
        this.xrTableCell22.Name = "xrTableCell22";
        this.xrTableCell22.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrTableCell22.StylePriority.UsePadding = false;
        xrSummary2.Func = DevExpress.XtraReports.UI.SummaryFunc.RecordNumber;
        this.xrTableCell22.Summary = xrSummary2;
        this.xrTableCell22.Weight = 0.0809236089163714D;
        // 
        // xrTableCell23
        // 
        this.xrTableCell23.Dpi = 100F;
        this.xrTableCell23.Name = "xrTableCell23";
        this.xrTableCell23.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrTableCell23.StylePriority.UsePadding = false;
        this.xrTableCell23.Weight = 0.175920889002736D;
        // 
        // xrTableCell25
        // 
        this.xrTableCell25.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.headTotalForSubSector")});
        this.xrTableCell25.Dpi = 100F;
        this.xrTableCell25.Name = "xrTableCell25";
        this.xrTableCell25.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrTableCell25.StylePriority.UsePadding = false;
        this.xrTableCell25.StylePriority.UseTextAlignment = false;
        this.xrTableCell25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        this.xrTableCell25.Weight = 0.54535473266983D;
        // 
        // xrTableCell26
        // 
        this.xrTableCell26.Dpi = 100F;
        this.xrTableCell26.Name = "xrTableCell26";
        this.xrTableCell26.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrTableCell26.StylePriority.UsePadding = false;
        this.xrTableCell26.Weight = 0.211105062445105D;
        // 
        // xrTableCell37
        // 
        this.xrTableCell37.Dpi = 100F;
        this.xrTableCell37.Name = "xrTableCell37";
        this.xrTableCell37.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrTableCell37.StylePriority.UsePadding = false;
        this.xrTableCell37.Weight = 0.211105064273414D;
        // 
        // xrTableCell38
        // 
        this.xrTableCell38.Dpi = 100F;
        this.xrTableCell38.Name = "xrTableCell38";
        this.xrTableCell38.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrTableCell38.StylePriority.UsePadding = false;
        this.xrTableCell38.Weight = 0.211105040251403D;
        // 
        // xrTableCell39
        // 
        this.xrTableCell39.Dpi = 100F;
        this.xrTableCell39.Name = "xrTableCell39";
        this.xrTableCell39.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrTableCell39.StylePriority.UsePadding = false;
        this.xrTableCell39.Weight = 0.246289228153728D;
        // 
        // xrTableCell42
        // 
        this.xrTableCell42.Dpi = 100F;
        this.xrTableCell42.Name = "xrTableCell42";
        this.xrTableCell42.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrTableCell42.StylePriority.UsePadding = false;
        this.xrTableCell42.Weight = 0.211105055774498D;
        // 
        // xrTableCell43
        // 
        this.xrTableCell43.Dpi = 100F;
        this.xrTableCell43.Name = "xrTableCell43";
        this.xrTableCell43.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrTableCell43.StylePriority.UsePadding = false;
        this.xrTableCell43.Weight = 0.211105049962286D;
        // 
        // xrTableCell44
        // 
        this.xrTableCell44.Dpi = 100F;
        this.xrTableCell44.Name = "xrTableCell44";
        this.xrTableCell44.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrTableCell44.StylePriority.UsePadding = false;
        this.xrTableCell44.Weight = 0.211105045877379D;
        // 
        // xrTableCell45
        // 
        this.xrTableCell45.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable6});
        this.xrTableCell45.Dpi = 100F;
        this.xrTableCell45.Name = "xrTableCell45";
        this.xrTableCell45.Weight = 0.387025912213494D;
        // 
        // xrTable6
        // 
        this.xrTable6.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTable6.Dpi = 100F;
        this.xrTable6.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Bold);
        this.xrTable6.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrTable6.Name = "xrTable6";
        this.xrTable6.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrTable6.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow8});
        this.xrTable6.SizeF = new System.Drawing.SizeF(160F, 30F);
        this.xrTable6.StylePriority.UseBorders = false;
        this.xrTable6.StylePriority.UseFont = false;
        this.xrTable6.StylePriority.UsePadding = false;
        this.xrTable6.StylePriority.UseTextAlignment = false;
        this.xrTable6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrTableRow8
        // 
        this.xrTableRow8.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell46,
            this.xrTableCell47,
            this.xrTableCell48});
        this.xrTableRow8.Dpi = 100F;
        this.xrTableRow8.Name = "xrTableRow8";
        this.xrTableRow8.Weight = 1D;
        // 
        // xrTableCell46
        // 
        this.xrTableCell46.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell46.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.LastApprovedCapital")});
        this.xrTableCell46.Dpi = 100F;
        this.xrTableCell46.Name = "xrTableCell46";
        this.xrTableCell46.StylePriority.UseBorders = false;
        xrSummary3.FormatString = "{0:#.000}";
        xrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell46.Summary = xrSummary3;
        this.xrTableCell46.Weight = 1D;
        // 
        // xrTableCell47
        // 
        this.xrTableCell47.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell47.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.LastApprovedRevenue")});
        this.xrTableCell47.Dpi = 100F;
        this.xrTableCell47.Name = "xrTableCell47";
        this.xrTableCell47.StylePriority.UseBorders = false;
        xrSummary4.FormatString = "{0:#.000}";
        xrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell47.Summary = xrSummary4;
        this.xrTableCell47.Weight = 1D;
        // 
        // xrTableCell48
        // 
        this.xrTableCell48.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell48.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.TotalLastApprovedCost")});
        this.xrTableCell48.Dpi = 100F;
        this.xrTableCell48.Name = "xrTableCell48";
        this.xrTableCell48.StylePriority.UseBorders = false;
        xrSummary5.FormatString = "{0:#.000}";
        xrSummary5.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell48.Summary = xrSummary5;
        this.xrTableCell48.Weight = 1D;
        // 
        // xrTableCell49
        // 
        this.xrTableCell49.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable7});
        this.xrTableCell49.Dpi = 100F;
        this.xrTableCell49.Name = "xrTableCell49";
        this.xrTableCell49.Weight = 0.387030131562782D;
        // 
        // xrTable7
        // 
        this.xrTable7.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTable7.Dpi = 100F;
        this.xrTable7.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Bold);
        this.xrTable7.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrTable7.Name = "xrTable7";
        this.xrTable7.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrTable7.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow9});
        this.xrTable7.SizeF = new System.Drawing.SizeF(161F, 30F);
        this.xrTable7.StylePriority.UseBorders = false;
        this.xrTable7.StylePriority.UseFont = false;
        this.xrTable7.StylePriority.UsePadding = false;
        this.xrTable7.StylePriority.UseTextAlignment = false;
        this.xrTable7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrTableRow9
        // 
        this.xrTableRow9.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell50,
            this.xrTableCell51,
            this.xrTableCell52});
        this.xrTableRow9.Dpi = 100F;
        this.xrTableRow9.Name = "xrTableRow9";
        this.xrTableRow9.Weight = 1D;
        // 
        // xrTableCell50
        // 
        this.xrTableCell50.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell50.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.LastExpenseCapital")});
        this.xrTableCell50.Dpi = 100F;
        this.xrTableCell50.Name = "xrTableCell50";
        this.xrTableCell50.StylePriority.UseBorders = false;
        xrSummary6.FormatString = "{0:#.000}";
        xrSummary6.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell50.Summary = xrSummary6;
        this.xrTableCell50.Weight = 1D;
        // 
        // xrTableCell51
        // 
        this.xrTableCell51.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell51.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.LastExpenseRevenue")});
        this.xrTableCell51.Dpi = 100F;
        this.xrTableCell51.Name = "xrTableCell51";
        this.xrTableCell51.StylePriority.UseBorders = false;
        xrSummary7.FormatString = "{0:#.000}";
        xrSummary7.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell51.Summary = xrSummary7;
        this.xrTableCell51.Weight = 1D;
        // 
        // xrTableCell52
        // 
        this.xrTableCell52.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell52.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.TotalLastExpenseCost")});
        this.xrTableCell52.Dpi = 100F;
        this.xrTableCell52.Name = "xrTableCell52";
        this.xrTableCell52.StylePriority.UseBorders = false;
        xrSummary8.FormatString = "{0:#.000}";
        xrSummary8.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell52.Summary = xrSummary8;
        this.xrTableCell52.Weight = 1D;
        // 
        // xrTableCell53
        // 
        this.xrTableCell53.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable9});
        this.xrTableCell53.Dpi = 100F;
        this.xrTableCell53.Name = "xrTableCell53";
        this.xrTableCell53.Weight = 0.387030096333807D;
        // 
        // xrTable9
        // 
        this.xrTable9.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTable9.Dpi = 100F;
        this.xrTable9.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Bold);
        this.xrTable9.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrTable9.Name = "xrTable9";
        this.xrTable9.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrTable9.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow10});
        this.xrTable9.SizeF = new System.Drawing.SizeF(161F, 30F);
        this.xrTable9.StylePriority.UseBorders = false;
        this.xrTable9.StylePriority.UseFont = false;
        this.xrTable9.StylePriority.UsePadding = false;
        this.xrTable9.StylePriority.UseTextAlignment = false;
        this.xrTable9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrTableRow10
        // 
        this.xrTableRow10.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell54,
            this.xrTableCell55,
            this.xrTableCell56});
        this.xrTableRow10.Dpi = 100F;
        this.xrTableRow10.Name = "xrTableRow10";
        this.xrTableRow10.Weight = 1D;
        // 
        // xrTableCell54
        // 
        this.xrTableCell54.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell54.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.CurrentADPAllocationCapital")});
        this.xrTableCell54.Dpi = 100F;
        this.xrTableCell54.Name = "xrTableCell54";
        this.xrTableCell54.StylePriority.UseBorders = false;
        xrSummary9.FormatString = "{0:#.000}";
        xrSummary9.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell54.Summary = xrSummary9;
        this.xrTableCell54.Weight = 1D;
        // 
        // xrTableCell55
        // 
        this.xrTableCell55.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell55.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.CurrentADPAllocationRevenue")});
        this.xrTableCell55.Dpi = 100F;
        this.xrTableCell55.Name = "xrTableCell55";
        this.xrTableCell55.StylePriority.UseBorders = false;
        xrSummary10.FormatString = "{0:#.000}";
        xrSummary10.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell55.Summary = xrSummary10;
        this.xrTableCell55.Weight = 1D;
        // 
        // xrTableCell56
        // 
        this.xrTableCell56.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell56.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.TotalCurrentADPAllocation")});
        this.xrTableCell56.Dpi = 100F;
        this.xrTableCell56.Name = "xrTableCell56";
        this.xrTableCell56.StylePriority.UseBorders = false;
        xrSummary11.FormatString = "{0:#.000}";
        xrSummary11.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell56.Summary = xrSummary11;
        this.xrTableCell56.Weight = 1D;
        // 
        // xrTableCell57
        // 
        this.xrTableCell57.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable11});
        this.xrTableCell57.Dpi = 100F;
        this.xrTableCell57.Name = "xrTableCell57";
        this.xrTableCell57.Weight = 0.387030096333808D;
        // 
        // xrTable11
        // 
        this.xrTable11.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTable11.Dpi = 100F;
        this.xrTable11.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Bold);
        this.xrTable11.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrTable11.Name = "xrTable11";
        this.xrTable11.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrTable11.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow11});
        this.xrTable11.SizeF = new System.Drawing.SizeF(161F, 30F);
        this.xrTable11.StylePriority.UseBorders = false;
        this.xrTable11.StylePriority.UseFont = false;
        this.xrTable11.StylePriority.UsePadding = false;
        this.xrTable11.StylePriority.UseTextAlignment = false;
        this.xrTable11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrTableRow11
        // 
        this.xrTableRow11.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell58,
            this.xrTableCell59,
            this.xrTableCell60});
        this.xrTableRow11.Dpi = 100F;
        this.xrTableRow11.Name = "xrTableRow11";
        this.xrTableRow11.Weight = 1D;
        // 
        // xrTableCell58
        // 
        this.xrTableCell58.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell58.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.CurrentRevisedAllocationCapital")});
        this.xrTableCell58.Dpi = 100F;
        this.xrTableCell58.Name = "xrTableCell58";
        this.xrTableCell58.StylePriority.UseBorders = false;
        xrSummary12.FormatString = "{0:#.000}";
        xrSummary12.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell58.Summary = xrSummary12;
        this.xrTableCell58.Weight = 1D;
        // 
        // xrTableCell59
        // 
        this.xrTableCell59.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell59.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.CurrentRevisedAllocationRevenue")});
        this.xrTableCell59.Dpi = 100F;
        this.xrTableCell59.Name = "xrTableCell59";
        this.xrTableCell59.StylePriority.UseBorders = false;
        xrSummary13.FormatString = "{0:#.000}";
        xrSummary13.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell59.Summary = xrSummary13;
        this.xrTableCell59.Weight = 1D;
        // 
        // xrTableCell60
        // 
        this.xrTableCell60.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell60.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.TotalCurrentRevisedAllocation")});
        this.xrTableCell60.Dpi = 100F;
        this.xrTableCell60.Name = "xrTableCell60";
        this.xrTableCell60.StylePriority.UseBorders = false;
        xrSummary14.FormatString = "{0:#.000}";
        xrSummary14.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell60.Summary = xrSummary14;
        this.xrTableCell60.Weight = 1D;
        // 
        // xrTableCell63
        // 
        this.xrTableCell63.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable12});
        this.xrTableCell63.Dpi = 100F;
        this.xrTableCell63.Name = "xrTableCell63";
        this.xrTableCell63.Weight = 0.387029574554307D;
        // 
        // xrTable12
        // 
        this.xrTable12.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTable12.Dpi = 100F;
        this.xrTable12.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Bold);
        this.xrTable12.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrTable12.Name = "xrTable12";
        this.xrTable12.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrTable12.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow13});
        this.xrTable12.SizeF = new System.Drawing.SizeF(161F, 30F);
        this.xrTable12.StylePriority.UseBorders = false;
        this.xrTable12.StylePriority.UseFont = false;
        this.xrTable12.StylePriority.UsePadding = false;
        this.xrTable12.StylePriority.UseTextAlignment = false;
        this.xrTable12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrTableRow13
        // 
        this.xrTableRow13.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell64,
            this.xrTableCell65,
            this.xrTableCell66});
        this.xrTableRow13.Dpi = 100F;
        this.xrTableRow13.Name = "xrTableRow13";
        this.xrTableRow13.Weight = 1D;
        // 
        // xrTableCell64
        // 
        this.xrTableCell64.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell64.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.CurrentReleaseCapital")});
        this.xrTableCell64.Dpi = 100F;
        this.xrTableCell64.Name = "xrTableCell64";
        this.xrTableCell64.StylePriority.UseBorders = false;
        xrSummary15.FormatString = "{0:#.000}";
        xrSummary15.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell64.Summary = xrSummary15;
        this.xrTableCell64.Weight = 1D;
        // 
        // xrTableCell65
        // 
        this.xrTableCell65.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell65.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.CurrentReleaseRevenue")});
        this.xrTableCell65.Dpi = 100F;
        this.xrTableCell65.Name = "xrTableCell65";
        this.xrTableCell65.StylePriority.UseBorders = false;
        xrSummary16.FormatString = "{0:#.000}";
        xrSummary16.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell65.Summary = xrSummary16;
        this.xrTableCell65.Weight = 1D;
        // 
        // xrTableCell66
        // 
        this.xrTableCell66.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell66.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.TotalCurrentRelasedCost")});
        this.xrTableCell66.Dpi = 100F;
        this.xrTableCell66.Name = "xrTableCell66";
        this.xrTableCell66.StylePriority.UseBorders = false;
        xrSummary17.FormatString = "{0:#.000}";
        xrSummary17.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell66.Summary = xrSummary17;
        this.xrTableCell66.Weight = 1D;
        // 
        // xrTableCell67
        // 
        this.xrTableCell67.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable13});
        this.xrTableCell67.Dpi = 100F;
        this.xrTableCell67.Name = "xrTableCell67";
        this.xrTableCell67.Weight = 0.387029574554307D;
        // 
        // xrTable13
        // 
        this.xrTable13.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTable13.Dpi = 100F;
        this.xrTable13.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Bold);
        this.xrTable13.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrTable13.Name = "xrTable13";
        this.xrTable13.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrTable13.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow15});
        this.xrTable13.SizeF = new System.Drawing.SizeF(161F, 30F);
        this.xrTable13.StylePriority.UseBorders = false;
        this.xrTable13.StylePriority.UseFont = false;
        this.xrTable13.StylePriority.UsePadding = false;
        this.xrTable13.StylePriority.UseTextAlignment = false;
        this.xrTable13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrTableRow15
        // 
        this.xrTableRow15.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell68,
            this.xrTableCell69,
            this.xrTableCell70});
        this.xrTableRow15.Dpi = 100F;
        this.xrTableRow15.Name = "xrTableRow15";
        this.xrTableRow15.Weight = 1D;
        // 
        // xrTableCell68
        // 
        this.xrTableCell68.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell68.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.CurrentExpenseCapital")});
        this.xrTableCell68.Dpi = 100F;
        this.xrTableCell68.Name = "xrTableCell68";
        this.xrTableCell68.StylePriority.UseBorders = false;
        xrSummary18.FormatString = "{0:#.000}";
        xrSummary18.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell68.Summary = xrSummary18;
        this.xrTableCell68.Weight = 1D;
        // 
        // xrTableCell69
        // 
        this.xrTableCell69.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell69.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.CurrentExcessRevenue")});
        this.xrTableCell69.Dpi = 100F;
        this.xrTableCell69.Name = "xrTableCell69";
        this.xrTableCell69.StylePriority.UseBorders = false;
        xrSummary19.FormatString = "{0:#.000}";
        xrSummary19.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell69.Summary = xrSummary19;
        this.xrTableCell69.Weight = 1D;
        // 
        // xrTableCell70
        // 
        this.xrTableCell70.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell70.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.TotalCurrentExpenseCost")});
        this.xrTableCell70.Dpi = 100F;
        this.xrTableCell70.Name = "xrTableCell70";
        this.xrTableCell70.StylePriority.UseBorders = false;
        xrSummary20.FormatString = "{0:#.000}";
        xrSummary20.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell70.Summary = xrSummary20;
        this.xrTableCell70.Weight = 1D;
        // 
        // xrTableCell92
        // 
        this.xrTableCell92.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable14});
        this.xrTableCell92.Dpi = 100F;
        this.xrTableCell92.Name = "xrTableCell92";
        this.xrTableCell92.Weight = 0.387029574554307D;
        // 
        // xrTable14
        // 
        this.xrTable14.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTable14.Dpi = 100F;
        this.xrTable14.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Bold);
        this.xrTable14.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrTable14.Name = "xrTable14";
        this.xrTable14.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrTable14.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow16});
        this.xrTable14.SizeF = new System.Drawing.SizeF(161F, 30F);
        this.xrTable14.StylePriority.UseBorders = false;
        this.xrTable14.StylePriority.UseFont = false;
        this.xrTable14.StylePriority.UsePadding = false;
        this.xrTable14.StylePriority.UseTextAlignment = false;
        this.xrTable14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrTableRow16
        // 
        this.xrTableRow16.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell94,
            this.xrTableCell95,
            this.xrTableCell96});
        this.xrTableRow16.Dpi = 100F;
        this.xrTableRow16.Name = "xrTableRow16";
        this.xrTableRow16.Weight = 1D;
        // 
        // xrTableCell94
        // 
        this.xrTableCell94.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell94.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.PercentUtilizedCapital")});
        this.xrTableCell94.Dpi = 100F;
        this.xrTableCell94.Name = "xrTableCell94";
        this.xrTableCell94.StylePriority.UseBorders = false;
        xrSummary21.FormatString = "{0:0.00%}";
        xrSummary21.Func = DevExpress.XtraReports.UI.SummaryFunc.Avg;
        xrSummary21.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell94.Summary = xrSummary21;
        this.xrTableCell94.Weight = 1D;
        // 
        // xrTableCell95
        // 
        this.xrTableCell95.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell95.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.PercentUtilizedRevenue")});
        this.xrTableCell95.Dpi = 100F;
        this.xrTableCell95.Name = "xrTableCell95";
        this.xrTableCell95.StylePriority.UseBorders = false;
        xrSummary22.FormatString = "{0:0.00%}";
        xrSummary22.Func = DevExpress.XtraReports.UI.SummaryFunc.Avg;
        xrSummary22.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell95.Summary = xrSummary22;
        this.xrTableCell95.Weight = 1D;
        // 
        // xrTableCell96
        // 
        this.xrTableCell96.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell96.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.TotalPercentUtilized")});
        this.xrTableCell96.Dpi = 100F;
        this.xrTableCell96.Name = "xrTableCell96";
        this.xrTableCell96.StylePriority.UseBorders = false;
        xrSummary23.FormatString = "{0:0.00%}";
        xrSummary23.Func = DevExpress.XtraReports.UI.SummaryFunc.Avg;
        xrSummary23.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell96.Summary = xrSummary23;
        this.xrTableCell96.Weight = 1D;
        // 
        // xrTableCell97
        // 
        this.xrTableCell97.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable15});
        this.xrTableCell97.Dpi = 100F;
        this.xrTableCell97.Name = "xrTableCell97";
        this.xrTableCell97.Weight = 0.387029574554307D;
        // 
        // xrTable15
        // 
        this.xrTable15.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTable15.Dpi = 100F;
        this.xrTable15.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Bold);
        this.xrTable15.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrTable15.Name = "xrTable15";
        this.xrTable15.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrTable15.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow17});
        this.xrTable15.SizeF = new System.Drawing.SizeF(161F, 30F);
        this.xrTable15.StylePriority.UseBorders = false;
        this.xrTable15.StylePriority.UseFont = false;
        this.xrTable15.StylePriority.UsePadding = false;
        this.xrTable15.StylePriority.UseTextAlignment = false;
        this.xrTable15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrTableRow17
        // 
        this.xrTableRow17.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell98,
            this.xrTableCell99,
            this.xrTableCell100});
        this.xrTableRow17.Dpi = 100F;
        this.xrTableRow17.Name = "xrTableRow17";
        this.xrTableRow17.Weight = 1D;
        // 
        // xrTableCell98
        // 
        this.xrTableCell98.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell98.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.CumulativeExpCapital")});
        this.xrTableCell98.Dpi = 100F;
        this.xrTableCell98.Name = "xrTableCell98";
        this.xrTableCell98.StylePriority.UseBorders = false;
        xrSummary24.FormatString = "{0:#.000}";
        xrSummary24.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell98.Summary = xrSummary24;
        this.xrTableCell98.Weight = 1D;
        // 
        // xrTableCell99
        // 
        this.xrTableCell99.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell99.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.CumulativeExpRevenue")});
        this.xrTableCell99.Dpi = 100F;
        this.xrTableCell99.Name = "xrTableCell99";
        this.xrTableCell99.StylePriority.UseBorders = false;
        xrSummary25.FormatString = "{0:#.000}";
        xrSummary25.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell99.Summary = xrSummary25;
        this.xrTableCell99.Weight = 1D;
        // 
        // xrTableCell100
        // 
        this.xrTableCell100.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell100.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.TotalCumulativeExp")});
        this.xrTableCell100.Dpi = 100F;
        this.xrTableCell100.Name = "xrTableCell100";
        this.xrTableCell100.StylePriority.UseBorders = false;
        xrSummary26.FormatString = "{0:#.000}";
        xrSummary26.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell100.Summary = xrSummary26;
        this.xrTableCell100.Weight = 1D;
        // 
        // xrTableCell101
        // 
        this.xrTableCell101.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable16});
        this.xrTableCell101.Dpi = 100F;
        this.xrTableCell101.Name = "xrTableCell101";
        this.xrTableCell101.Weight = 0.387029574554307D;
        // 
        // xrTable16
        // 
        this.xrTable16.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTable16.Dpi = 100F;
        this.xrTable16.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Bold);
        this.xrTable16.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrTable16.Name = "xrTable16";
        this.xrTable16.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrTable16.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow18});
        this.xrTable16.SizeF = new System.Drawing.SizeF(161F, 30F);
        this.xrTable16.StylePriority.UseBorders = false;
        this.xrTable16.StylePriority.UseFont = false;
        this.xrTable16.StylePriority.UsePadding = false;
        this.xrTable16.StylePriority.UseTextAlignment = false;
        this.xrTable16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrTableRow18
        // 
        this.xrTableRow18.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell102,
            this.xrTableCell103,
            this.xrTableCell104});
        this.xrTableRow18.Dpi = 100F;
        this.xrTableRow18.Name = "xrTableRow18";
        this.xrTableRow18.Weight = 1D;
        // 
        // xrTableCell102
        // 
        this.xrTableCell102.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell102.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.FinancialProgressCapital")});
        this.xrTableCell102.Dpi = 100F;
        this.xrTableCell102.Name = "xrTableCell102";
        this.xrTableCell102.StylePriority.UseBorders = false;
        xrSummary27.FormatString = "{0:0.00%}";
        xrSummary27.Func = DevExpress.XtraReports.UI.SummaryFunc.Avg;
        xrSummary27.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell102.Summary = xrSummary27;
        this.xrTableCell102.Weight = 1D;
        // 
        // xrTableCell103
        // 
        this.xrTableCell103.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell103.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.FinancialProgressRevenue")});
        this.xrTableCell103.Dpi = 100F;
        this.xrTableCell103.Name = "xrTableCell103";
        this.xrTableCell103.StylePriority.UseBorders = false;
        xrSummary28.FormatString = "{0:0.00%}";
        xrSummary28.Func = DevExpress.XtraReports.UI.SummaryFunc.Avg;
        xrSummary28.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell103.Summary = xrSummary28;
        this.xrTableCell103.Weight = 1D;
        // 
        // xrTableCell104
        // 
        this.xrTableCell104.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell104.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.TotalFinancialProgress")});
        this.xrTableCell104.Dpi = 100F;
        this.xrTableCell104.Name = "xrTableCell104";
        this.xrTableCell104.StylePriority.UseBorders = false;
        xrSummary29.FormatString = "{0:0.00%}";
        xrSummary29.Func = DevExpress.XtraReports.UI.SummaryFunc.Avg;
        xrSummary29.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell104.Summary = xrSummary29;
        this.xrTableCell104.Weight = 1D;
        // 
        // xrTableCell105
        // 
        this.xrTableCell105.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable17});
        this.xrTableCell105.Dpi = 100F;
        this.xrTableCell105.Name = "xrTableCell105";
        this.xrTableCell105.Weight = 0.387029574554307D;
        // 
        // xrTable17
        // 
        this.xrTable17.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTable17.Dpi = 100F;
        this.xrTable17.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Bold);
        this.xrTable17.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrTable17.Name = "xrTable17";
        this.xrTable17.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrTable17.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow19});
        this.xrTable17.SizeF = new System.Drawing.SizeF(161F, 30F);
        this.xrTable17.StylePriority.UseBorders = false;
        this.xrTable17.StylePriority.UseFont = false;
        this.xrTable17.StylePriority.UsePadding = false;
        this.xrTable17.StylePriority.UseTextAlignment = false;
        this.xrTable17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrTableRow19
        // 
        this.xrTableRow19.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell106,
            this.xrTableCell107,
            this.xrTableCell108});
        this.xrTableRow19.Dpi = 100F;
        this.xrTableRow19.Name = "xrTableRow19";
        this.xrTableRow19.Weight = 1D;
        // 
        // xrTableCell106
        // 
        this.xrTableCell106.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell106.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ThrowForwardCapital")});
        this.xrTableCell106.Dpi = 100F;
        this.xrTableCell106.Name = "xrTableCell106";
        this.xrTableCell106.StylePriority.UseBorders = false;
        xrSummary30.FormatString = "{0:#.000}";
        xrSummary30.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell106.Summary = xrSummary30;
        this.xrTableCell106.Weight = 1D;
        // 
        // xrTableCell107
        // 
        this.xrTableCell107.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell107.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ThrowForwardRevenue")});
        this.xrTableCell107.Dpi = 100F;
        this.xrTableCell107.Name = "xrTableCell107";
        this.xrTableCell107.StylePriority.UseBorders = false;
        xrSummary31.FormatString = "{0:#.000}";
        xrSummary31.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell107.Summary = xrSummary31;
        this.xrTableCell107.Weight = 1D;
        // 
        // xrTableCell108
        // 
        this.xrTableCell108.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell108.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.TotalThrowForward")});
        this.xrTableCell108.Dpi = 100F;
        this.xrTableCell108.Name = "xrTableCell108";
        this.xrTableCell108.StylePriority.UseBorders = false;
        xrSummary32.FormatString = "{0:#.000}";
        xrSummary32.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell108.Summary = xrSummary32;
        this.xrTableCell108.Weight = 1D;
        // 
        // xrTableCell109
        // 
        this.xrTableCell109.Dpi = 100F;
        this.xrTableCell109.Name = "xrTableCell109";
        this.xrTableCell109.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrTableCell109.StylePriority.UsePadding = false;
        this.xrTableCell109.Weight = 0.211098765712D;
        // 
        // xrTableCell110
        // 
        this.xrTableCell110.Dpi = 100F;
        this.xrTableCell110.Name = "xrTableCell110";
        this.xrTableCell110.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrTableCell110.StylePriority.UsePadding = false;
        this.xrTableCell110.Weight = 0.211098765712D;
        // 
        // xrTableCell111
        // 
        this.xrTableCell111.Dpi = 100F;
        this.xrTableCell111.Name = "xrTableCell111";
        this.xrTableCell111.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrTableCell111.StylePriority.UsePadding = false;
        this.xrTableCell111.Weight = 0.211098765712D;
        // 
        // xrTableCell112
        // 
        this.xrTableCell112.Dpi = 100F;
        this.xrTableCell112.Name = "xrTableCell112";
        this.xrTableCell112.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrTableCell112.StylePriority.UsePadding = false;
        this.xrTableCell112.Weight = 0.211098765712D;
        // 
        // xrTableCell113
        // 
        this.xrTableCell113.Dpi = 100F;
        this.xrTableCell113.Name = "xrTableCell113";
        this.xrTableCell113.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrTableCell113.StylePriority.UsePadding = false;
        this.xrTableCell113.Weight = 0.211098765712D;
        // 
        // xrTableCell114
        // 
        this.xrTableCell114.Dpi = 100F;
        this.xrTableCell114.Name = "xrTableCell114";
        this.xrTableCell114.Weight = 0.897215876511302D;
        // 
        // ReportHeader
        // 
        this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable4,
            this.xrLabel1});
        this.ReportHeader.Dpi = 100F;
        this.ReportHeader.HeightF = 70F;
        this.ReportHeader.Name = "ReportHeader";
        // 
        // xrTable4
        // 
        this.xrTable4.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTable4.Dpi = 100F;
        this.xrTable4.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Bold);
        this.xrTable4.LocationFloat = new DevExpress.Utils.PointFloat(0F, 52F);
        this.xrTable4.Name = "xrTable4";
        this.xrTable4.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrTable4.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow4});
        this.xrTable4.SizeF = new System.Drawing.SizeF(3374F, 18F);
        this.xrTable4.StylePriority.UseBorders = false;
        this.xrTable4.StylePriority.UseFont = false;
        this.xrTable4.StylePriority.UsePadding = false;
        this.xrTable4.StylePriority.UseTextAlignment = false;
        this.xrTable4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrTableRow4
        // 
        this.xrTableRow4.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell75,
            this.xrTableCell85});
        this.xrTableRow4.Dpi = 100F;
        this.xrTableRow4.Name = "xrTableRow4";
        this.xrTableRow4.Weight = 1D;
        // 
        // xrTableCell75
        // 
        this.xrTableCell75.Dpi = 100F;
        this.xrTableCell75.Name = "xrTableCell75";
        this.xrTableCell75.StylePriority.UseTextAlignment = false;
        this.xrTableCell75.Text = "(Rs. In Million)";
        this.xrTableCell75.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        this.xrTableCell75.Weight = 0.280803247861316D;
        // 
        // xrTableCell85
        // 
        this.xrTableCell85.Dpi = 100F;
        this.xrTableCell85.Name = "xrTableCell85";
        this.xrTableCell85.StylePriority.UseTextAlignment = false;
        this.xrTableCell85.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        this.xrTableCell85.Weight = 2.56787172296312D;
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
        this.xrTable8.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrTable8.Name = "xrTable8";
        this.xrTable8.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow12});
        this.xrTable8.SizeF = new System.Drawing.SizeF(3374F, 20F);
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
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.SubSectorTitle")});
        this.xrTableCell14.Dpi = 100F;
        this.xrTableCell14.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Bold);
        this.xrTableCell14.Name = "xrTableCell14";
        this.xrTableCell14.StylePriority.UseFont = false;
        this.xrTableCell14.Weight = 1D;
        // 
        // GroupFooter2
        // 
        this.GroupFooter2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable10});
        this.GroupFooter2.Dpi = 100F;
        this.GroupFooter2.HeightF = 30F;
        this.GroupFooter2.Level = 1;
        this.GroupFooter2.Name = "GroupFooter2";
        this.GroupFooter2.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand;
        // 
        // xrTable10
        // 
        this.xrTable10.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTable10.Dpi = 100F;
        this.xrTable10.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Bold);
        this.xrTable10.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrTable10.Name = "xrTable10";
        this.xrTable10.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow14});
        this.xrTable10.SizeF = new System.Drawing.SizeF(3374F, 30F);
        this.xrTable10.StylePriority.UseBorders = false;
        this.xrTable10.StylePriority.UseFont = false;
        this.xrTable10.StylePriority.UseTextAlignment = false;
        this.xrTable10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        // 
        // xrTableRow14
        // 
        this.xrTableRow14.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell71,
            this.xrTableCell72,
            this.xrTableCell73,
            this.xrTableCell76,
            this.xrTableCell77,
            this.xrTableCell78,
            this.xrTableCell79,
            this.xrTableCell80,
            this.xrTableCell81,
            this.xrTableCell82,
            this.xrTableCell83,
            this.xrTableCell118,
            this.xrTableCell122,
            this.xrTableCell126,
            this.xrTableCell130,
            this.xrTableCell134,
            this.xrTableCell253,
            this.xrTableCell258,
            this.xrTableCell262,
            this.xrTableCell267,
            this.xrTableCell272,
            this.xrTableCell273,
            this.xrTableCell274,
            this.xrTableCell275,
            this.xrTableCell276,
            this.xrTableCell278});
        this.xrTableRow14.Dpi = 100F;
        this.xrTableRow14.Name = "xrTableRow14";
        this.xrTableRow14.Weight = 1D;
        // 
        // xrTableCell71
        // 
        this.xrTableCell71.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell71.Dpi = 100F;
        this.xrTableCell71.Name = "xrTableCell71";
        this.xrTableCell71.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrTableCell71.StylePriority.UseBorders = false;
        this.xrTableCell71.StylePriority.UsePadding = false;
        xrSummary33.Func = DevExpress.XtraReports.UI.SummaryFunc.RecordNumber;
        this.xrTableCell71.Summary = xrSummary33;
        this.xrTableCell71.Weight = 0.0809236089163714D;
        // 
        // xrTableCell72
        // 
        this.xrTableCell72.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell72.Dpi = 100F;
        this.xrTableCell72.Name = "xrTableCell72";
        this.xrTableCell72.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrTableCell72.StylePriority.UseBorders = false;
        this.xrTableCell72.StylePriority.UsePadding = false;
        this.xrTableCell72.Weight = 0.175920889002736D;
        // 
        // xrTableCell73
        // 
        this.xrTableCell73.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell73.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.headTotalForCategory")});
        this.xrTableCell73.Dpi = 100F;
        this.xrTableCell73.Name = "xrTableCell73";
        this.xrTableCell73.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrTableCell73.StylePriority.UseBorders = false;
        this.xrTableCell73.StylePriority.UsePadding = false;
        this.xrTableCell73.StylePriority.UseTextAlignment = false;
        this.xrTableCell73.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        this.xrTableCell73.Weight = 0.54535473266983D;
        // 
        // xrTableCell76
        // 
        this.xrTableCell76.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell76.Dpi = 100F;
        this.xrTableCell76.Name = "xrTableCell76";
        this.xrTableCell76.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrTableCell76.StylePriority.UseBorders = false;
        this.xrTableCell76.StylePriority.UsePadding = false;
        this.xrTableCell76.Weight = 0.211105062445105D;
        // 
        // xrTableCell77
        // 
        this.xrTableCell77.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell77.Dpi = 100F;
        this.xrTableCell77.Name = "xrTableCell77";
        this.xrTableCell77.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrTableCell77.StylePriority.UseBorders = false;
        this.xrTableCell77.StylePriority.UsePadding = false;
        this.xrTableCell77.Weight = 0.211105064273414D;
        // 
        // xrTableCell78
        // 
        this.xrTableCell78.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell78.Dpi = 100F;
        this.xrTableCell78.Name = "xrTableCell78";
        this.xrTableCell78.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrTableCell78.StylePriority.UseBorders = false;
        this.xrTableCell78.StylePriority.UsePadding = false;
        this.xrTableCell78.Weight = 0.211105040251403D;
        // 
        // xrTableCell79
        // 
        this.xrTableCell79.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell79.Dpi = 100F;
        this.xrTableCell79.Name = "xrTableCell79";
        this.xrTableCell79.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrTableCell79.StylePriority.UseBorders = false;
        this.xrTableCell79.StylePriority.UsePadding = false;
        this.xrTableCell79.Weight = 0.246289228153728D;
        // 
        // xrTableCell80
        // 
        this.xrTableCell80.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell80.Dpi = 100F;
        this.xrTableCell80.Name = "xrTableCell80";
        this.xrTableCell80.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrTableCell80.StylePriority.UseBorders = false;
        this.xrTableCell80.StylePriority.UsePadding = false;
        this.xrTableCell80.Weight = 0.211105055774498D;
        // 
        // xrTableCell81
        // 
        this.xrTableCell81.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell81.Dpi = 100F;
        this.xrTableCell81.Name = "xrTableCell81";
        this.xrTableCell81.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrTableCell81.StylePriority.UseBorders = false;
        this.xrTableCell81.StylePriority.UsePadding = false;
        this.xrTableCell81.Weight = 0.211105049962286D;
        // 
        // xrTableCell82
        // 
        this.xrTableCell82.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell82.Dpi = 100F;
        this.xrTableCell82.Name = "xrTableCell82";
        this.xrTableCell82.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrTableCell82.StylePriority.UseBorders = false;
        this.xrTableCell82.StylePriority.UsePadding = false;
        this.xrTableCell82.Weight = 0.211105045877379D;
        // 
        // xrTableCell83
        // 
        this.xrTableCell83.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable18});
        this.xrTableCell83.Dpi = 100F;
        this.xrTableCell83.Name = "xrTableCell83";
        this.xrTableCell83.Weight = 0.387025912213494D;
        // 
        // xrTable18
        // 
        this.xrTable18.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTable18.Dpi = 100F;
        this.xrTable18.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Bold);
        this.xrTable18.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrTable18.Name = "xrTable18";
        this.xrTable18.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrTable18.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow20});
        this.xrTable18.SizeF = new System.Drawing.SizeF(160F, 30F);
        this.xrTable18.StylePriority.UseBorders = false;
        this.xrTable18.StylePriority.UseFont = false;
        this.xrTable18.StylePriority.UsePadding = false;
        this.xrTable18.StylePriority.UseTextAlignment = false;
        this.xrTable18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrTableRow20
        // 
        this.xrTableRow20.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell115,
            this.xrTableCell116,
            this.xrTableCell117});
        this.xrTableRow20.Dpi = 100F;
        this.xrTableRow20.Name = "xrTableRow20";
        this.xrTableRow20.Weight = 1D;
        // 
        // xrTableCell115
        // 
        this.xrTableCell115.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell115.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.LastApprovedCapital")});
        this.xrTableCell115.Dpi = 100F;
        this.xrTableCell115.Name = "xrTableCell115";
        this.xrTableCell115.StylePriority.UseBorders = false;
        xrSummary34.FormatString = "{0:#.000}";
        xrSummary34.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell115.Summary = xrSummary34;
        this.xrTableCell115.Weight = 1D;
        // 
        // xrTableCell116
        // 
        this.xrTableCell116.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell116.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.LastApprovedRevenue")});
        this.xrTableCell116.Dpi = 100F;
        this.xrTableCell116.Name = "xrTableCell116";
        this.xrTableCell116.StylePriority.UseBorders = false;
        xrSummary35.FormatString = "{0:#.000}";
        xrSummary35.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell116.Summary = xrSummary35;
        this.xrTableCell116.Weight = 1D;
        // 
        // xrTableCell117
        // 
        this.xrTableCell117.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell117.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.TotalLastApprovedCost")});
        this.xrTableCell117.Dpi = 100F;
        this.xrTableCell117.Name = "xrTableCell117";
        this.xrTableCell117.StylePriority.UseBorders = false;
        xrSummary36.FormatString = "{0:#.000}";
        xrSummary36.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell117.Summary = xrSummary36;
        this.xrTableCell117.Weight = 1D;
        // 
        // xrTableCell118
        // 
        this.xrTableCell118.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable19});
        this.xrTableCell118.Dpi = 100F;
        this.xrTableCell118.Name = "xrTableCell118";
        this.xrTableCell118.Weight = 0.387030131562782D;
        // 
        // xrTable19
        // 
        this.xrTable19.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTable19.Dpi = 100F;
        this.xrTable19.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Bold);
        this.xrTable19.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrTable19.Name = "xrTable19";
        this.xrTable19.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrTable19.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow21});
        this.xrTable19.SizeF = new System.Drawing.SizeF(161F, 30F);
        this.xrTable19.StylePriority.UseBorders = false;
        this.xrTable19.StylePriority.UseFont = false;
        this.xrTable19.StylePriority.UsePadding = false;
        this.xrTable19.StylePriority.UseTextAlignment = false;
        this.xrTable19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrTableRow21
        // 
        this.xrTableRow21.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell119,
            this.xrTableCell120,
            this.xrTableCell121});
        this.xrTableRow21.Dpi = 100F;
        this.xrTableRow21.Name = "xrTableRow21";
        this.xrTableRow21.Weight = 1D;
        // 
        // xrTableCell119
        // 
        this.xrTableCell119.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell119.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.LastExpenseCapital")});
        this.xrTableCell119.Dpi = 100F;
        this.xrTableCell119.Name = "xrTableCell119";
        this.xrTableCell119.StylePriority.UseBorders = false;
        xrSummary37.FormatString = "{0:#.000}";
        xrSummary37.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell119.Summary = xrSummary37;
        this.xrTableCell119.Weight = 1D;
        // 
        // xrTableCell120
        // 
        this.xrTableCell120.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell120.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.LastExpenseRevenue")});
        this.xrTableCell120.Dpi = 100F;
        this.xrTableCell120.Name = "xrTableCell120";
        this.xrTableCell120.StylePriority.UseBorders = false;
        xrSummary38.FormatString = "{0:#.000}";
        xrSummary38.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell120.Summary = xrSummary38;
        this.xrTableCell120.Weight = 1D;
        // 
        // xrTableCell121
        // 
        this.xrTableCell121.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell121.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.TotalLastExpenseCost")});
        this.xrTableCell121.Dpi = 100F;
        this.xrTableCell121.Name = "xrTableCell121";
        this.xrTableCell121.StylePriority.UseBorders = false;
        xrSummary39.FormatString = "{0:#.000}";
        xrSummary39.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell121.Summary = xrSummary39;
        this.xrTableCell121.Weight = 1D;
        // 
        // xrTableCell122
        // 
        this.xrTableCell122.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable41});
        this.xrTableCell122.Dpi = 100F;
        this.xrTableCell122.Name = "xrTableCell122";
        this.xrTableCell122.Weight = 0.387030096333807D;
        // 
        // xrTable41
        // 
        this.xrTable41.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTable41.Dpi = 100F;
        this.xrTable41.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Bold);
        this.xrTable41.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrTable41.Name = "xrTable41";
        this.xrTable41.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrTable41.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow22});
        this.xrTable41.SizeF = new System.Drawing.SizeF(161F, 30F);
        this.xrTable41.StylePriority.UseBorders = false;
        this.xrTable41.StylePriority.UseFont = false;
        this.xrTable41.StylePriority.UsePadding = false;
        this.xrTable41.StylePriority.UseTextAlignment = false;
        this.xrTable41.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrTableRow22
        // 
        this.xrTableRow22.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell123,
            this.xrTableCell124,
            this.xrTableCell125});
        this.xrTableRow22.Dpi = 100F;
        this.xrTableRow22.Name = "xrTableRow22";
        this.xrTableRow22.Weight = 1D;
        // 
        // xrTableCell123
        // 
        this.xrTableCell123.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell123.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.CurrentADPAllocationCapital")});
        this.xrTableCell123.Dpi = 100F;
        this.xrTableCell123.Name = "xrTableCell123";
        this.xrTableCell123.StylePriority.UseBorders = false;
        xrSummary40.FormatString = "{0:#.000}";
        xrSummary40.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell123.Summary = xrSummary40;
        this.xrTableCell123.Weight = 1D;
        // 
        // xrTableCell124
        // 
        this.xrTableCell124.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell124.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.CurrentADPAllocationRevenue")});
        this.xrTableCell124.Dpi = 100F;
        this.xrTableCell124.Name = "xrTableCell124";
        this.xrTableCell124.StylePriority.UseBorders = false;
        xrSummary41.FormatString = "{0:#.000}";
        xrSummary41.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell124.Summary = xrSummary41;
        this.xrTableCell124.Weight = 1D;
        // 
        // xrTableCell125
        // 
        this.xrTableCell125.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell125.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.TotalCurrentADPAllocation")});
        this.xrTableCell125.Dpi = 100F;
        this.xrTableCell125.Name = "xrTableCell125";
        this.xrTableCell125.StylePriority.UseBorders = false;
        xrSummary42.FormatString = "{0:#.000}";
        xrSummary42.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell125.Summary = xrSummary42;
        this.xrTableCell125.Weight = 1D;
        // 
        // xrTableCell126
        // 
        this.xrTableCell126.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable42});
        this.xrTableCell126.Dpi = 100F;
        this.xrTableCell126.Name = "xrTableCell126";
        this.xrTableCell126.Weight = 0.387030096333808D;
        // 
        // xrTable42
        // 
        this.xrTable42.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTable42.Dpi = 100F;
        this.xrTable42.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Bold);
        this.xrTable42.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrTable42.Name = "xrTable42";
        this.xrTable42.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrTable42.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow23});
        this.xrTable42.SizeF = new System.Drawing.SizeF(161F, 30F);
        this.xrTable42.StylePriority.UseBorders = false;
        this.xrTable42.StylePriority.UseFont = false;
        this.xrTable42.StylePriority.UsePadding = false;
        this.xrTable42.StylePriority.UseTextAlignment = false;
        this.xrTable42.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrTableRow23
        // 
        this.xrTableRow23.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell127,
            this.xrTableCell128,
            this.xrTableCell129});
        this.xrTableRow23.Dpi = 100F;
        this.xrTableRow23.Name = "xrTableRow23";
        this.xrTableRow23.Weight = 1D;
        // 
        // xrTableCell127
        // 
        this.xrTableCell127.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell127.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.CurrentRevisedAllocationCapital")});
        this.xrTableCell127.Dpi = 100F;
        this.xrTableCell127.Name = "xrTableCell127";
        this.xrTableCell127.StylePriority.UseBorders = false;
        xrSummary43.FormatString = "{0:#.000}";
        xrSummary43.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell127.Summary = xrSummary43;
        this.xrTableCell127.Weight = 1D;
        // 
        // xrTableCell128
        // 
        this.xrTableCell128.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell128.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.CurrentRevisedAllocationRevenue")});
        this.xrTableCell128.Dpi = 100F;
        this.xrTableCell128.Name = "xrTableCell128";
        this.xrTableCell128.StylePriority.UseBorders = false;
        xrSummary44.FormatString = "{0:#.000}";
        xrSummary44.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell128.Summary = xrSummary44;
        this.xrTableCell128.Weight = 1D;
        // 
        // xrTableCell129
        // 
        this.xrTableCell129.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell129.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.TotalCurrentRevisedAllocation")});
        this.xrTableCell129.Dpi = 100F;
        this.xrTableCell129.Name = "xrTableCell129";
        this.xrTableCell129.StylePriority.UseBorders = false;
        xrSummary45.FormatString = "{0:#.000}";
        xrSummary45.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell129.Summary = xrSummary45;
        this.xrTableCell129.Weight = 1D;
        // 
        // xrTableCell130
        // 
        this.xrTableCell130.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable43});
        this.xrTableCell130.Dpi = 100F;
        this.xrTableCell130.Name = "xrTableCell130";
        this.xrTableCell130.Weight = 0.387029574554307D;
        // 
        // xrTable43
        // 
        this.xrTable43.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTable43.Dpi = 100F;
        this.xrTable43.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Bold);
        this.xrTable43.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrTable43.Name = "xrTable43";
        this.xrTable43.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrTable43.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow24});
        this.xrTable43.SizeF = new System.Drawing.SizeF(161F, 30F);
        this.xrTable43.StylePriority.UseBorders = false;
        this.xrTable43.StylePriority.UseFont = false;
        this.xrTable43.StylePriority.UsePadding = false;
        this.xrTable43.StylePriority.UseTextAlignment = false;
        this.xrTable43.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrTableRow24
        // 
        this.xrTableRow24.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell131,
            this.xrTableCell132,
            this.xrTableCell133});
        this.xrTableRow24.Dpi = 100F;
        this.xrTableRow24.Name = "xrTableRow24";
        this.xrTableRow24.Weight = 1D;
        // 
        // xrTableCell131
        // 
        this.xrTableCell131.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell131.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.CurrentReleaseCapital")});
        this.xrTableCell131.Dpi = 100F;
        this.xrTableCell131.Name = "xrTableCell131";
        this.xrTableCell131.StylePriority.UseBorders = false;
        xrSummary46.FormatString = "{0:#.000}";
        xrSummary46.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell131.Summary = xrSummary46;
        this.xrTableCell131.Weight = 1D;
        // 
        // xrTableCell132
        // 
        this.xrTableCell132.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell132.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.CurrentReleaseRevenue")});
        this.xrTableCell132.Dpi = 100F;
        this.xrTableCell132.Name = "xrTableCell132";
        this.xrTableCell132.StylePriority.UseBorders = false;
        xrSummary47.FormatString = "{0:#.000}";
        xrSummary47.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell132.Summary = xrSummary47;
        this.xrTableCell132.Weight = 1D;
        // 
        // xrTableCell133
        // 
        this.xrTableCell133.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell133.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.TotalCurrentRelasedCost")});
        this.xrTableCell133.Dpi = 100F;
        this.xrTableCell133.Name = "xrTableCell133";
        this.xrTableCell133.StylePriority.UseBorders = false;
        xrSummary48.FormatString = "{0:#.000}";
        xrSummary48.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell133.Summary = xrSummary48;
        this.xrTableCell133.Weight = 1D;
        // 
        // xrTableCell134
        // 
        this.xrTableCell134.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable44});
        this.xrTableCell134.Dpi = 100F;
        this.xrTableCell134.Name = "xrTableCell134";
        this.xrTableCell134.Weight = 0.387029574554307D;
        // 
        // xrTable44
        // 
        this.xrTable44.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTable44.Dpi = 100F;
        this.xrTable44.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Bold);
        this.xrTable44.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrTable44.Name = "xrTable44";
        this.xrTable44.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrTable44.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow25});
        this.xrTable44.SizeF = new System.Drawing.SizeF(161F, 30F);
        this.xrTable44.StylePriority.UseBorders = false;
        this.xrTable44.StylePriority.UseFont = false;
        this.xrTable44.StylePriority.UsePadding = false;
        this.xrTable44.StylePriority.UseTextAlignment = false;
        this.xrTable44.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrTableRow25
        // 
        this.xrTableRow25.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell250,
            this.xrTableCell251,
            this.xrTableCell252});
        this.xrTableRow25.Dpi = 100F;
        this.xrTableRow25.Name = "xrTableRow25";
        this.xrTableRow25.Weight = 1D;
        // 
        // xrTableCell250
        // 
        this.xrTableCell250.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell250.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.CurrentExpenseCapital")});
        this.xrTableCell250.Dpi = 100F;
        this.xrTableCell250.Name = "xrTableCell250";
        this.xrTableCell250.StylePriority.UseBorders = false;
        xrSummary49.FormatString = "{0:#.000}";
        xrSummary49.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell250.Summary = xrSummary49;
        this.xrTableCell250.Weight = 1D;
        // 
        // xrTableCell251
        // 
        this.xrTableCell251.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell251.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.CurrentExcessRevenue")});
        this.xrTableCell251.Dpi = 100F;
        this.xrTableCell251.Name = "xrTableCell251";
        this.xrTableCell251.StylePriority.UseBorders = false;
        xrSummary50.FormatString = "{0:#.000}";
        xrSummary50.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell251.Summary = xrSummary50;
        this.xrTableCell251.Weight = 1D;
        // 
        // xrTableCell252
        // 
        this.xrTableCell252.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell252.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.TotalCurrentExpenseCost")});
        this.xrTableCell252.Dpi = 100F;
        this.xrTableCell252.Name = "xrTableCell252";
        this.xrTableCell252.StylePriority.UseBorders = false;
        xrSummary51.FormatString = "{0:#.000}";
        xrSummary51.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell252.Summary = xrSummary51;
        this.xrTableCell252.Weight = 1D;
        // 
        // xrTableCell253
        // 
        this.xrTableCell253.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable45});
        this.xrTableCell253.Dpi = 100F;
        this.xrTableCell253.Name = "xrTableCell253";
        this.xrTableCell253.Weight = 0.387029574554307D;
        // 
        // xrTable45
        // 
        this.xrTable45.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTable45.Dpi = 100F;
        this.xrTable45.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Bold);
        this.xrTable45.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrTable45.Name = "xrTable45";
        this.xrTable45.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrTable45.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow26});
        this.xrTable45.SizeF = new System.Drawing.SizeF(161F, 30F);
        this.xrTable45.StylePriority.UseBorders = false;
        this.xrTable45.StylePriority.UseFont = false;
        this.xrTable45.StylePriority.UsePadding = false;
        this.xrTable45.StylePriority.UseTextAlignment = false;
        this.xrTable45.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrTableRow26
        // 
        this.xrTableRow26.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell254,
            this.xrTableCell255,
            this.xrTableCell257});
        this.xrTableRow26.Dpi = 100F;
        this.xrTableRow26.Name = "xrTableRow26";
        this.xrTableRow26.Weight = 1D;
        // 
        // xrTableCell254
        // 
        this.xrTableCell254.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell254.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.PercentUtilizedCapital")});
        this.xrTableCell254.Dpi = 100F;
        this.xrTableCell254.Name = "xrTableCell254";
        this.xrTableCell254.StylePriority.UseBorders = false;
        xrSummary52.FormatString = "{0:0.00%}";
        xrSummary52.Func = DevExpress.XtraReports.UI.SummaryFunc.Avg;
        xrSummary52.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell254.Summary = xrSummary52;
        this.xrTableCell254.Weight = 1D;
        // 
        // xrTableCell255
        // 
        this.xrTableCell255.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell255.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.PercentUtilizedRevenue")});
        this.xrTableCell255.Dpi = 100F;
        this.xrTableCell255.Name = "xrTableCell255";
        this.xrTableCell255.StylePriority.UseBorders = false;
        xrSummary53.FormatString = "{0:0.00%}";
        xrSummary53.Func = DevExpress.XtraReports.UI.SummaryFunc.Avg;
        xrSummary53.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell255.Summary = xrSummary53;
        this.xrTableCell255.Weight = 1D;
        // 
        // xrTableCell257
        // 
        this.xrTableCell257.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell257.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.TotalPercentUtilized")});
        this.xrTableCell257.Dpi = 100F;
        this.xrTableCell257.Name = "xrTableCell257";
        this.xrTableCell257.StylePriority.UseBorders = false;
        xrSummary54.FormatString = "{0:0.00%}";
        xrSummary54.Func = DevExpress.XtraReports.UI.SummaryFunc.Avg;
        xrSummary54.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell257.Summary = xrSummary54;
        this.xrTableCell257.Weight = 1D;
        // 
        // xrTableCell258
        // 
        this.xrTableCell258.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable46});
        this.xrTableCell258.Dpi = 100F;
        this.xrTableCell258.Name = "xrTableCell258";
        this.xrTableCell258.Weight = 0.387029574554307D;
        // 
        // xrTable46
        // 
        this.xrTable46.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTable46.Dpi = 100F;
        this.xrTable46.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Bold);
        this.xrTable46.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrTable46.Name = "xrTable46";
        this.xrTable46.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrTable46.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow27});
        this.xrTable46.SizeF = new System.Drawing.SizeF(161F, 30F);
        this.xrTable46.StylePriority.UseBorders = false;
        this.xrTable46.StylePriority.UseFont = false;
        this.xrTable46.StylePriority.UsePadding = false;
        this.xrTable46.StylePriority.UseTextAlignment = false;
        this.xrTable46.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrTableRow27
        // 
        this.xrTableRow27.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell259,
            this.xrTableCell260,
            this.xrTableCell261});
        this.xrTableRow27.Dpi = 100F;
        this.xrTableRow27.Name = "xrTableRow27";
        this.xrTableRow27.Weight = 1D;
        // 
        // xrTableCell259
        // 
        this.xrTableCell259.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell259.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.CumulativeExpCapital")});
        this.xrTableCell259.Dpi = 100F;
        this.xrTableCell259.Name = "xrTableCell259";
        this.xrTableCell259.StylePriority.UseBorders = false;
        xrSummary55.FormatString = "{0:#.000}";
        xrSummary55.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell259.Summary = xrSummary55;
        this.xrTableCell259.Weight = 1D;
        // 
        // xrTableCell260
        // 
        this.xrTableCell260.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell260.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.CumulativeExpRevenue")});
        this.xrTableCell260.Dpi = 100F;
        this.xrTableCell260.Name = "xrTableCell260";
        this.xrTableCell260.StylePriority.UseBorders = false;
        xrSummary56.FormatString = "{0:#.000}";
        xrSummary56.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell260.Summary = xrSummary56;
        this.xrTableCell260.Weight = 1D;
        // 
        // xrTableCell261
        // 
        this.xrTableCell261.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell261.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.TotalCumulativeExp")});
        this.xrTableCell261.Dpi = 100F;
        this.xrTableCell261.Name = "xrTableCell261";
        this.xrTableCell261.StylePriority.UseBorders = false;
        xrSummary57.FormatString = "{0:#.000}";
        xrSummary57.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell261.Summary = xrSummary57;
        this.xrTableCell261.Weight = 1D;
        // 
        // xrTableCell262
        // 
        this.xrTableCell262.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable47});
        this.xrTableCell262.Dpi = 100F;
        this.xrTableCell262.Name = "xrTableCell262";
        this.xrTableCell262.Weight = 0.387029574554307D;
        // 
        // xrTable47
        // 
        this.xrTable47.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTable47.Dpi = 100F;
        this.xrTable47.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Bold);
        this.xrTable47.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrTable47.Name = "xrTable47";
        this.xrTable47.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrTable47.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow28});
        this.xrTable47.SizeF = new System.Drawing.SizeF(161F, 30F);
        this.xrTable47.StylePriority.UseBorders = false;
        this.xrTable47.StylePriority.UseFont = false;
        this.xrTable47.StylePriority.UsePadding = false;
        this.xrTable47.StylePriority.UseTextAlignment = false;
        this.xrTable47.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrTableRow28
        // 
        this.xrTableRow28.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell264,
            this.xrTableCell265,
            this.xrTableCell266});
        this.xrTableRow28.Dpi = 100F;
        this.xrTableRow28.Name = "xrTableRow28";
        this.xrTableRow28.Weight = 1D;
        // 
        // xrTableCell264
        // 
        this.xrTableCell264.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell264.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.FinancialProgressCapital")});
        this.xrTableCell264.Dpi = 100F;
        this.xrTableCell264.Name = "xrTableCell264";
        this.xrTableCell264.StylePriority.UseBorders = false;
        xrSummary58.FormatString = "{0:0.00%}";
        xrSummary58.Func = DevExpress.XtraReports.UI.SummaryFunc.Avg;
        xrSummary58.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell264.Summary = xrSummary58;
        this.xrTableCell264.Weight = 1D;
        // 
        // xrTableCell265
        // 
        this.xrTableCell265.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell265.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.FinancialProgressRevenue")});
        this.xrTableCell265.Dpi = 100F;
        this.xrTableCell265.Name = "xrTableCell265";
        this.xrTableCell265.StylePriority.UseBorders = false;
        xrSummary59.FormatString = "{0:0.00%}";
        xrSummary59.Func = DevExpress.XtraReports.UI.SummaryFunc.Avg;
        xrSummary59.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell265.Summary = xrSummary59;
        this.xrTableCell265.Weight = 1D;
        // 
        // xrTableCell266
        // 
        this.xrTableCell266.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell266.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.TotalFinancialProgress")});
        this.xrTableCell266.Dpi = 100F;
        this.xrTableCell266.Name = "xrTableCell266";
        this.xrTableCell266.StylePriority.UseBorders = false;
        xrSummary60.FormatString = "{0:0.00%}";
        xrSummary60.Func = DevExpress.XtraReports.UI.SummaryFunc.Avg;
        xrSummary60.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell266.Summary = xrSummary60;
        this.xrTableCell266.Weight = 1D;
        // 
        // xrTableCell267
        // 
        this.xrTableCell267.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable48});
        this.xrTableCell267.Dpi = 100F;
        this.xrTableCell267.Name = "xrTableCell267";
        this.xrTableCell267.Weight = 0.387029574554307D;
        // 
        // xrTable48
        // 
        this.xrTable48.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTable48.Dpi = 100F;
        this.xrTable48.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Bold);
        this.xrTable48.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrTable48.Name = "xrTable48";
        this.xrTable48.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrTable48.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow29});
        this.xrTable48.SizeF = new System.Drawing.SizeF(161F, 30F);
        this.xrTable48.StylePriority.UseBorders = false;
        this.xrTable48.StylePriority.UseFont = false;
        this.xrTable48.StylePriority.UsePadding = false;
        this.xrTable48.StylePriority.UseTextAlignment = false;
        this.xrTable48.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrTableRow29
        // 
        this.xrTableRow29.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell268,
            this.xrTableCell269,
            this.xrTableCell271});
        this.xrTableRow29.Dpi = 100F;
        this.xrTableRow29.Name = "xrTableRow29";
        this.xrTableRow29.Weight = 1D;
        // 
        // xrTableCell268
        // 
        this.xrTableCell268.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell268.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ThrowForwardCapital")});
        this.xrTableCell268.Dpi = 100F;
        this.xrTableCell268.Name = "xrTableCell268";
        this.xrTableCell268.StylePriority.UseBorders = false;
        xrSummary61.FormatString = "{0:#.000}";
        xrSummary61.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell268.Summary = xrSummary61;
        this.xrTableCell268.Weight = 1D;
        // 
        // xrTableCell269
        // 
        this.xrTableCell269.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell269.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ThrowForwardRevenue")});
        this.xrTableCell269.Dpi = 100F;
        this.xrTableCell269.Name = "xrTableCell269";
        this.xrTableCell269.StylePriority.UseBorders = false;
        xrSummary62.FormatString = "{0:#.000}";
        xrSummary62.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell269.Summary = xrSummary62;
        this.xrTableCell269.Weight = 1D;
        // 
        // xrTableCell271
        // 
        this.xrTableCell271.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell271.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.TotalThrowForward")});
        this.xrTableCell271.Dpi = 100F;
        this.xrTableCell271.Name = "xrTableCell271";
        this.xrTableCell271.StylePriority.UseBorders = false;
        xrSummary63.FormatString = "{0:#.000}";
        xrSummary63.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell271.Summary = xrSummary63;
        this.xrTableCell271.Weight = 1D;
        // 
        // xrTableCell272
        // 
        this.xrTableCell272.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell272.Dpi = 100F;
        this.xrTableCell272.Name = "xrTableCell272";
        this.xrTableCell272.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrTableCell272.StylePriority.UseBorders = false;
        this.xrTableCell272.StylePriority.UsePadding = false;
        this.xrTableCell272.Weight = 0.211098765712D;
        // 
        // xrTableCell273
        // 
        this.xrTableCell273.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell273.Dpi = 100F;
        this.xrTableCell273.Name = "xrTableCell273";
        this.xrTableCell273.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrTableCell273.StylePriority.UseBorders = false;
        this.xrTableCell273.StylePriority.UsePadding = false;
        this.xrTableCell273.Weight = 0.211098765712D;
        // 
        // xrTableCell274
        // 
        this.xrTableCell274.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell274.Dpi = 100F;
        this.xrTableCell274.Name = "xrTableCell274";
        this.xrTableCell274.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrTableCell274.StylePriority.UseBorders = false;
        this.xrTableCell274.StylePriority.UsePadding = false;
        this.xrTableCell274.Weight = 0.211098765712D;
        // 
        // xrTableCell275
        // 
        this.xrTableCell275.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell275.Dpi = 100F;
        this.xrTableCell275.Name = "xrTableCell275";
        this.xrTableCell275.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrTableCell275.StylePriority.UseBorders = false;
        this.xrTableCell275.StylePriority.UsePadding = false;
        this.xrTableCell275.Weight = 0.211098765712D;
        // 
        // xrTableCell276
        // 
        this.xrTableCell276.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell276.Dpi = 100F;
        this.xrTableCell276.Name = "xrTableCell276";
        this.xrTableCell276.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrTableCell276.StylePriority.UseBorders = false;
        this.xrTableCell276.StylePriority.UsePadding = false;
        this.xrTableCell276.Weight = 0.211098765712D;
        // 
        // xrTableCell278
        // 
        this.xrTableCell278.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell278.Dpi = 100F;
        this.xrTableCell278.Name = "xrTableCell278";
        this.xrTableCell278.StylePriority.UseBorders = false;
        this.xrTableCell278.Weight = 0.897215876511302D;
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
        this.headExpUpTo.Expression = "Concat(\'Exp. upto June, \', [Parameters.prExpectedYear])";
        this.headExpUpTo.Name = "headExpUpTo";
        // 
        // headOrigionalAllocation
        // 
        this.headOrigionalAllocation.Expression = "Concat(\'Origional Allocation in ADP \', [Parameters.prFinancialYear])";
        this.headOrigionalAllocation.Name = "headOrigionalAllocation";
        // 
        // headRevisedAllocation
        // 
        this.headRevisedAllocation.Expression = "Concat(\'Revised Allocation in ADP \', [Parameters.prFinancialYear])";
        this.headRevisedAllocation.Name = "headRevisedAllocation";
        // 
        // headFundsReleasedUpTo
        // 
        this.headFundsReleasedUpTo.Expression = "Concat(\'Releases upto \', [Parameters.prMonth], \', \', [Parameters.prYear])";
        this.headFundsReleasedUpTo.Name = "headFundsReleasedUpTo";
        // 
        // headFundsUtilizedTill
        // 
        this.headFundsUtilizedTill.Expression = "Concat(\'Utilization upto \', [Parameters.prMonth], \', \', [Parameters.prYear])";
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
            this.xrLabel3});
        this.PageFooter.Dpi = 100F;
        this.PageFooter.HeightF = 37.5F;
        this.PageFooter.Name = "PageFooter";
        // 
        // xrLabel3
        // 
        this.xrLabel3.Dpi = 100F;
        this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(1475F, 12.5F);
        this.xrLabel3.Name = "xrLabel3";
        this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel3.SizeF = new System.Drawing.SizeF(424.9999F, 23F);
        this.xrLabel3.StylePriority.UseTextAlignment = false;
        this.xrLabel3.Text = System.Configuration.ConfigurationManager.AppSettings["FooterText"];
        this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // headProjectionCurrentFY
        // 
        this.headProjectionCurrentFY.Expression = "Concat(\'Projection for \', [Parameters.prFinancialYear])";
        this.headProjectionCurrentFY.Name = "headProjectionCurrentFY";
        // 
        // headProjectionNextFY
        // 
        this.headProjectionNextFY.Expression = "Concat(\'Projection for \', [Parameters.prNextFinancialYear])";
        this.headProjectionNextFY.Name = "headProjectionNextFY";
        // 
        // headThrowForwardBeyond
        // 
        this.headThrowForwardBeyond.Expression = "Concat(\'Throw Forward beyond \', [Parameters.prMonth], \', \', [Parameters.prYear])";
        this.headThrowForwardBeyond.Name = "headThrowForwardBeyond";
        // 
        // PageHeader
        // 
        this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable2,
            this.xrTable3});
        this.PageHeader.Dpi = 100F;
        this.PageHeader.HeightF = 110F;
        this.PageHeader.Name = "PageHeader";
        // 
        // prNextFinancialYear
        // 
        this.prNextFinancialYear.Description = "Next Financial Year";
        this.prNextFinancialYear.Name = "prNextFinancialYear";
        this.prNextFinancialYear.Visible = false;
        // 
        // headTotalForCategory
        // 
        this.headTotalForCategory.DataMember = "SchemeList";
        this.headTotalForCategory.Expression = "Concat(\'Total: \', [CategoryTitle])";
        this.headTotalForCategory.Name = "headTotalForCategory";
        // 
        // headTotalForSubSector
        // 
        this.headTotalForSubSector.DataMember = "SchemeList";
        this.headTotalForSubSector.Expression = "Concat(\'Sub Total: \', [SubSectorTitle])";
        this.headTotalForSubSector.Name = "headTotalForSubSector";
        // 
        // xrNewMonthlyProgressReport
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
            this.headOrigionalAllocation,
            this.headRevisedAllocation,
            this.headFundsReleasedUpTo,
            this.headFundsUtilizedTill,
            this.TotalCurrentADPAllocation,
            this.CurrentRevisedAllocationCapital,
            this.CurrentRevisedAllocationRevenue,
            this.TotalCurrentRevisedAllocation,
            this.headProjectionCurrentFY,
            this.headProjectionNextFY,
            this.headThrowForwardBeyond,
            this.headTotalForCategory,
            this.headTotalForSubSector});
        this.DataMember = "SchemeList";
        this.DataSource = this.bindingSource1;
        this.Font = new System.Drawing.Font("Arial", 9.75F);
        this.Landscape = true;
        this.Margins = new System.Drawing.Printing.Margins(12, 14, 20, 14);
        this.PageHeight = 2200;
        this.PageWidth = 3400;
        this.PaperKind = System.Drawing.Printing.PaperKind.DSheet;
        this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.prMonth,
            this.prYear,
            this.prFinancialYear,
            this.prExpectedYear,
            this.prNextFinancialYear});
        this.RequestParameters = false;
        this.Version = "16.1";
        ((System.ComponentModel.ISupportInitialize)(this.xrTable30)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable31)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable32)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable33)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable34)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable35)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable36)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable37)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable38)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable39)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable40)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrRichText1)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable20)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable21)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable22)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable23)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable24)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable25)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable26)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable27)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable28)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable29)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable5)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable6)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable7)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable9)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable11)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable12)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable13)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable14)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable15)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable16)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable17)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable4)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable8)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable10)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable18)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable19)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable41)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable42)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable43)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable44)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable45)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable46)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable47)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable48)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion
}
