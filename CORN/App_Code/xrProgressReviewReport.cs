using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

/// <summary>
/// Summary description for xrProgressReviewReport
/// </summary>
public class xrProgressReviewReport : DevExpress.XtraReports.UI.XtraReport
{
    private DevExpress.XtraReports.UI.DetailBand Detail;
    private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
    private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
    private System.Windows.Forms.BindingSource bindingSource1;
    private XRLabel xrLabel1;
    private XRTable xrTable1;
    private XRTableRow xrTableRow1;
    private XRTableCell xrTableCell7;
    private XRTableCell xrTableCell6;
    private XRTableCell xrTableCell1;
    private XRTableCell xrTableCell2;
    private XRTableCell xrTableCell3;
    private XRTableCell xrTableCell4;
    private XRTableCell xrTableCell5;
    private XRTableCell xrTableCell8;
    private XRTableCell xrTableCell9;
    private XRTableCell xrTableCell11;
    private XRTableCell xrTableCell21;
    private XRTableCell xrTableCell22;
    private XRTableCell xrTableCell23;
    private XRTableCell xrTableCell24;
    private XRTableCell xrTableCell25;
    private XRTableCell xrTableCell26;
    private XRTableCell xrTableCell27;
    private XRTableCell xrTableCell28;
    private XRTableCell xrTableCell29;
    private XRTableCell xrTableCell30;
    private XRTableCell xrTableCell31;
    private XRTableCell xrTableCell33;
    private XRTableCell xrTableCell34;
    private XRTableCell xrTableCell18;
    private XRTableCell xrTableCell35;
    private XRTableCell xrTableCell36;
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
    private XRTable xrTable2;
    private XRTableRow xrTableRow2;
    private XRTableCell xrTableCell10;
    private XRTableCell xrTableCell12;
    private XRTableCell xrTableCell13;
    private XRTableCell xrTableCell14;
    private XRTableCell xrTableCell15;
    private XRTableCell xrTableCell16;
    private XRTableCell xrTableCell17;
    private XRTableCell xrTableCell32;
    private XRTableCell xrTableCell19;
    private XRTableCell xrTableCell20;
    private XRTable xrTable3;
    private XRTableRow xrTableRow3;
    private XRTableCell xrTableCell48;
    private XRTableCell xrTableCell49;
    private XRTableCell xrTableCell50;
    private XRTableCell xrTableCell51;
    private XRTableCell xrTableCell52;
    private XRTableCell xrTableCell53;
    private XRTableCell xrTableCell54;
    private XRTableCell xrTableCell55;
    private XRTableCell xrTableCell56;
    private XRTableCell xrTableCell57;
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
    private XRLabel xrLabel2;
    private XRLabel xrLabel6;
    private XRLabel xrLabel8;
    private DevExpress.XtraReports.Parameters.Parameter prYear;
    private DevExpress.XtraReports.Parameters.Parameter prDateRange;
    private DevExpress.XtraReports.Parameters.Parameter prDistrict;
    private XRLabel xrLabel4;
    private XRLabel xrLabel5;
    private XRLabel xrLabel7;
    private XRLabel xrLabel9;
    private XRLabel xrLabel3;
    private XRTable xrTable4;
    private XRTableRow xrTableRow4;
    private XRTableCell xrTableCell85;
    private XRTableCell xrTableCell86;
    private XRTableCell xrTableCell87;
    private XRTableCell xrTableCell88;
    private XRTableCell xrTableCell89;
    private XRTableCell xrTableCell90;
    private XRTableCell xrTableCell91;
    private XRTableCell xrTableCell92;
    private XRTableCell xrTableCell93;
    private XRTableCell xrTableCell94;
    private XRTableCell xrTableCell95;
    private XRTableCell xrTableCell96;
    private XRTableCell xrTableCell97;
    private XRTableCell xrTableCell98;
    private XRTableCell xrTableCell99;
    private XRTableCell xrTableCell100;
    private XRTableCell xrTableCell101;
    private XRTableCell xrTableCell102;
    private XRTableCell xrTableCell103;
    private XRTableCell xrTableCell104;
    private XRTableCell xrTableCell105;
    private XRTableCell xrTableCell106;
    private XRTableCell xrTableCell107;
    private XRTableCell xrTableCell108;
    private XRTableCell xrTableCell109;
    private XRTableCell xrTableCell110;
    private XRTableCell xrTableCell111;
    private XRTableCell xrTableCell112;
    private XRTableCell xrTableCell116;
    private XRTableCell xrTableCell117;
    private XRTableCell xrTableCell118;
    private XRTableCell xrTableCell119;
    private XRTableCell xrTableCell120;
    private XRTable xrTable5;
    private XRTableRow xrTableRow5;
    private XRTableCell xrTableCell122;
    private XRTableCell xrTableCell123;
    private XRTableCell xrTableCell124;
    private XRTableCell xrTableCell125;
    private XRTableCell xrTableCell126;
    private XRTableCell xrTableCell127;
    private XRTableCell xrTableCell128;
    private XRTableCell xrTableCell129;
    private XRTableCell xrTableCell130;
    private XRTableCell xrTableCell131;
    private XRTableCell xrTableCell132;
    private XRTableCell xrTableCell133;
    private XRTableCell xrTableCell134;
    private XRTableCell xrTableCell135;
    private XRTableCell xrTableCell136;
    private XRTableCell xrTableCell137;
    private XRTableCell xrTableCell138;
    private XRTableCell xrTableCell139;
    private XRTableCell xrTableCell140;
    private XRTableCell xrTableCell141;
    private XRTableCell xrTableCell142;
    private XRTableCell xrTableCell143;
    private XRTableCell xrTableCell144;
    private XRTableCell xrTableCell145;
    private XRTableCell xrTableCell146;
    private XRTableCell xrTableCell147;
    private XRTableCell xrTableCell148;
    private XRTableCell xrTableCell149;
    private XRTableCell xrTableCell153;
    private XRTableCell xrTableCell154;
    private XRTableCell xrTableCell155;
    private XRTableCell xrTableCell156;
    private XRTableCell xrTableCell157;
    private CalculatedField ApproveLocalAmount;
    private CalculatedField ApproveTotalAmount;
    private CalculatedField AllocationLocalAmount;
    private CalculatedField AllocationTotalAmount;
    private CalculatedField ReleseLocalAmount;
    private CalculatedField ReleseTotalAmount;
    private CalculatedField ExpenseForeignAidAllocationPercentage;
    private CalculatedField ExcessLocalAmount;
    private CalculatedField ExcessTotalAmount;
    private CalculatedField ExpenseForeignAidReleasePercentage;
    private CalculatedField ExpenseTotalAllocationPercentage;
    private CalculatedField ExpenseTotalReleasePercentage;
    private CalculatedField ExpenseLocalAmount;
    private CalculatedField ExpenseTotalAmount;
    private CalculatedField ThrowForwardLocal;
    private CalculatedField ThrowForwardForignFund;
    private CalculatedField ThrowForwardTotal;
    private ReportHeaderBand ReportHeader;
    private PageHeaderBand PageHeader;
    private PageFooterBand PageFooter;
    private CalculatedField headExpenseUptoJunPY;
    private DevExpress.XtraReports.Parameters.Parameter prPYear;
    private XRTableCell xrTableCell161;
    private XRTableCell xrTableCell159;
    private XRTableCell xrTableCell160;
    private XRTableCell xrTableCell47;
    private XRTableCell xrTableCell167;
    private XRTableCell xrTableCell162;
    private XRTableCell xrTableCell166;
    private XRTableCell xrTableCell165;
    private XRTableCell xrTableCell164;
    private XRTableCell xrTableCell163;
    private XRTableCell xrTableCell168;
    private XRTableCell xrTableCell84;
    private XRTableCell xrTableCell169;
    private XRTableCell xrTableCell170;
    private XRTableCell xrTableCell171;
    private XRTableCell xrTableCell172;
    private XRTableCell xrTableCell173;
    private XRTableCell xrTableCell174;
    private XRTableCell xrTableCell175;
    private XRLabel xrlblFooter;
    private GroupHeaderBand GroupHeader2;
    private GroupFooterBand GroupFooter2;
    private XRLabel xrLabel11;
    private GroupHeaderBand GroupHeader3;
    private GroupFooterBand GroupFooter3;
    private XRTableCell xrTableCell176;
    private XRTableCell xrTableCell177;
    private XRTableCell xrTableCell178;
    private XRTableCell xrTableCell179;
    private XRTableCell xrTableCell180;
    private XRTableCell xrTableCell181;
    private XRTableCell xrTableCell182;
    private XRTableCell xrTableCell183;
    private XRTableCell xrTableCell184;
    private XRTableCell xrTableCell185;
    private CalculatedField ExpensePYJLocalAmount;
    private CalculatedField ExpensePYJTotalAmount;
    private CalculatedField ThrowForwardCapital;
    private CalculatedField ThrowForwardRevenue;
    private XRTableCell xrTableCell113;
    private XRTableCell xrTableCell114;
    private XRTableCell xrTableCell115;
    private XRTableCell xrTableCell121;
    private XRTableCell xrTableCell150;
    private XRTableCell xrTableCell151;
    private XRTableCell xrTableCell152;
    private XRTableCell xrTableCell158;
    private XRTableCell xrTableCell186;
    private XRTableCell xrTableCell187;
    private XRTableCell xrTableCell188;
    private XRTableCell xrTableCell189;
    private CalculatedField ExpenseLocalAllocationPercentage;
    private CalculatedField ExpenseLocalReleasePercentage;
    private XRTable xrTable6;
    private XRTableRow xrTableRow6;
    private XRTableCell xrTableCell190;
    private XRTableCell xrTableCell191;
    private XRTableCell xrTableCell192;
    private XRTableCell xrTableCell193;
    private XRTableCell xrTableCell194;
    private XRTableCell xrTableCell195;
    private XRTableCell xrTableCell196;
    private XRTableCell xrTableCell197;
    private XRTableCell xrTableCell198;
    private XRTableCell xrTableCell199;
    private XRTableCell xrTableCell200;
    private XRTableCell xrTableCell201;
    private XRTableCell xrTableCell202;
    private XRTableCell xrTableCell203;
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
    private XRTableCell xrTableCell215;
    private XRTableCell xrTableCell216;
    private XRTableCell xrTableCell217;
    private XRTableCell xrTableCell218;
    private XRTableCell xrTableCell219;
    private XRTableCell xrTableCell220;
    private XRTableCell xrTableCell221;
    private XRTableCell xrTableCell222;
    private XRTableCell xrTableCell223;
    private XRTableCell xrTableCell224;
    private XRTableCell xrTableCell225;
    private XRTableCell xrTableCell226;
    private XRTableCell xrTableCell227;
    private XRTableCell xrTableCell228;
    private XRTableCell xrTableCell229;
    private XRTableCell xrTableCell230;
    private XRTableCell xrTableCell231;
    private XRTableCell xrTableCell232;
    private XRTableCell xrTableCell233;
    private XRLabel xrLabel10;
    private XRLabel xrLabel12;
    private DevExpress.XtraReports.Parameters.Parameter prConstituency;
    private XRTableCell xrTableCell234;
    private XRTableCell xrTableCell235;
    private XRTableCell xrTableCell236;
    private XRTableCell xrTableCell237;
    private XRTableCell xrTableCell238;
    private XRTableCell xrTableCell239;
    private XRTableCell xrTableCell248;
    private XRTableCell xrTableCell249;
    private XRTableCell xrTableCell250;
    private XRTableCell xrTableCell251;
    private XRTableCell xrTableCell240;
    private XRTableCell xrTableCell241;
    private XRTableCell xrTableCell242;
    private XRTableCell xrTableCell243;
    private XRTableCell xrTableCell244;
    private XRTableCell xrTableCell245;
    private XRTableCell xrTableCell246;
    private XRTableCell xrTableCell247;
    private XRTableCell xrTableCell252;
    private XRTableCell xrTableCell253;
    private XRTableCell xrTableCell254;
    private XRTableCell xrTableCell255;
    private XRTableCell xrTableCell256;
    private XRTableCell xrTableCell257;
    private XRTableCell xrTableCell258;
    private XRTableCell xrTableCell259;
    private CalculatedField FinalLocalGrant;
    private CalculatedField FinalTotalGrant;
    private XRTableCell xrTableCell264;
    private XRTableCell xrTableCell265;
    private XRTableCell xrTableCell266;
    private XRTableCell xrTableCell267;
    private XRTableCell xrTableCell260;
    private XRTableCell xrTableCell261;
    private XRTableCell xrTableCell262;
    private XRTableCell xrTableCell263;
    private XRTableCell xrTableCell276;
    private XRTableCell xrTableCell277;
    private XRTableCell xrTableCell278;
    private XRTableCell xrTableCell279;
    private XRTableCell xrTableCell280;
    private XRTableCell xrTableCell281;
    private XRTableCell xrTableCell282;
    private XRTableCell xrTableCell283;
    private XRTableCell xrTableCell268;
    private XRTableCell xrTableCell269;
    private XRTableCell xrTableCell270;
    private XRTableCell xrTableCell271;
    private XRTableCell xrTableCell272;
    private XRTableCell xrTableCell273;
    private XRTableCell xrTableCell274;
    private XRTableCell xrTableCell275;

    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public xrProgressReviewReport()
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
        string resourceFileName = "xrProgressReviewReport.resx";
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
        DevExpress.XtraReports.UI.XRSummary xrSummary64 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary65 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary66 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary67 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary68 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary69 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary70 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary71 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary72 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary73 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary74 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary75 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary76 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary77 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary78 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary79 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary80 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary81 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary82 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary83 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary84 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary85 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary86 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary87 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary88 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary89 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary90 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary91 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary92 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary93 = new DevExpress.XtraReports.UI.XRSummary();
        this.Detail = new DevExpress.XtraReports.UI.DetailBand();
        this.xrTable4 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell85 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell264 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell265 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell266 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell267 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell86 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell87 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell88 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell89 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell90 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell91 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell176 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell177 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell178 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell179 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell180 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell92 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell93 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell94 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell95 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell96 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell237 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell248 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell249 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell250 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell251 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell97 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell98 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell99 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell100 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell101 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell102 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell103 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell104 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell105 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell106 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell107 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell108 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell109 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell110 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell111 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell112 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell116 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell117 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell118 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell119 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell120 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell113 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell114 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell115 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell121 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell150 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell151 = new DevExpress.XtraReports.UI.XRTableCell();
        this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
        this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
        this.prDateRange = new DevExpress.XtraReports.Parameters.Parameter();
        this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
        this.prDistrict = new DevExpress.XtraReports.Parameters.Parameter();
        this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
        this.prYear = new DevExpress.XtraReports.Parameters.Parameter();
        this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
        this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
        this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
        this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell260 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell261 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell262 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell263 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell13 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell14 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell15 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell236 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell16 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell47 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell17 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell32 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell19 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell20 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell161 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell167 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell276 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell277 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell278 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell279 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell21 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell22 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell23 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell24 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell25 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell26 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell159 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell234 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell240 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell241 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell242 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell243 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell27 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell28 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell29 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell30 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell31 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell162 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell166 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell165 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell164 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell163 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell33 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell34 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell18 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell35 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell36 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell37 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell38 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell160 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell39 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell40 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell41 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell42 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell43 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell44 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell45 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell46 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell168 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTable3 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell48 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell280 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell281 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell282 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell283 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell49 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell50 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell51 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell52 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell53 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell54 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell55 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell56 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell57 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell58 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell59 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell60 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell61 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell62 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell63 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell64 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell235 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell244 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell245 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell246 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell247 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell65 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell66 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell67 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell68 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell69 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell70 = new DevExpress.XtraReports.UI.XRTableCell();
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
        this.xrTableCell84 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell169 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell170 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell171 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell172 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell173 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell174 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell175 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTable5 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow5 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell122 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell268 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell269 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell270 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell271 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell123 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell124 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell125 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell126 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell127 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell128 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell181 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell182 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell183 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell184 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell185 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell129 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell130 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell131 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell132 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell133 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell238 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell252 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell253 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell254 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell255 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell134 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell135 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell136 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell137 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell138 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell139 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell140 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell141 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell142 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell143 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell144 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell145 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell146 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell147 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell148 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell149 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell153 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell154 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell155 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell156 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell157 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell152 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell158 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell186 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell187 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell188 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell189 = new DevExpress.XtraReports.UI.XRTableCell();
        this.ApproveLocalAmount = new DevExpress.XtraReports.UI.CalculatedField();
        this.ApproveTotalAmount = new DevExpress.XtraReports.UI.CalculatedField();
        this.AllocationLocalAmount = new DevExpress.XtraReports.UI.CalculatedField();
        this.AllocationTotalAmount = new DevExpress.XtraReports.UI.CalculatedField();
        this.ReleseLocalAmount = new DevExpress.XtraReports.UI.CalculatedField();
        this.ReleseTotalAmount = new DevExpress.XtraReports.UI.CalculatedField();
        this.ExpenseForeignAidAllocationPercentage = new DevExpress.XtraReports.UI.CalculatedField();
        this.ExcessLocalAmount = new DevExpress.XtraReports.UI.CalculatedField();
        this.ExcessTotalAmount = new DevExpress.XtraReports.UI.CalculatedField();
        this.ExpenseForeignAidReleasePercentage = new DevExpress.XtraReports.UI.CalculatedField();
        this.ExpenseTotalAllocationPercentage = new DevExpress.XtraReports.UI.CalculatedField();
        this.ExpenseTotalReleasePercentage = new DevExpress.XtraReports.UI.CalculatedField();
        this.ExpenseLocalAmount = new DevExpress.XtraReports.UI.CalculatedField();
        this.ExpenseTotalAmount = new DevExpress.XtraReports.UI.CalculatedField();
        this.ThrowForwardLocal = new DevExpress.XtraReports.UI.CalculatedField();
        this.ThrowForwardForignFund = new DevExpress.XtraReports.UI.CalculatedField();
        this.ThrowForwardTotal = new DevExpress.XtraReports.UI.CalculatedField();
        this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
        this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
        this.prConstituency = new DevExpress.XtraReports.Parameters.Parameter();
        this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
        this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
        this.xrlblFooter = new DevExpress.XtraReports.UI.XRLabel();
        this.headExpenseUptoJunPY = new DevExpress.XtraReports.UI.CalculatedField();
        this.prPYear = new DevExpress.XtraReports.Parameters.Parameter();
        this.GroupHeader2 = new DevExpress.XtraReports.UI.GroupHeaderBand();
        this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
        this.GroupFooter2 = new DevExpress.XtraReports.UI.GroupFooterBand();
        this.GroupHeader3 = new DevExpress.XtraReports.UI.GroupHeaderBand();
        this.GroupFooter3 = new DevExpress.XtraReports.UI.GroupFooterBand();
        this.xrTable6 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow6 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell190 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell272 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell273 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell274 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell275 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell191 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell192 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell193 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell194 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell195 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell196 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell197 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell198 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell199 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell200 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell201 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell202 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell203 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell204 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell205 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell206 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell239 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell256 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell257 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell258 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell259 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell207 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell208 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell209 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell210 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell211 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell212 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell213 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell214 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell215 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell216 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell217 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell218 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell219 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell220 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell221 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell222 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell223 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell224 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell225 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell226 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell227 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell228 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell229 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell230 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell231 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell232 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell233 = new DevExpress.XtraReports.UI.XRTableCell();
        this.ExpensePYJLocalAmount = new DevExpress.XtraReports.UI.CalculatedField();
        this.ExpensePYJTotalAmount = new DevExpress.XtraReports.UI.CalculatedField();
        this.ThrowForwardCapital = new DevExpress.XtraReports.UI.CalculatedField();
        this.ThrowForwardRevenue = new DevExpress.XtraReports.UI.CalculatedField();
        this.ExpenseLocalAllocationPercentage = new DevExpress.XtraReports.UI.CalculatedField();
        this.ExpenseLocalReleasePercentage = new DevExpress.XtraReports.UI.CalculatedField();
        this.FinalLocalGrant = new DevExpress.XtraReports.UI.CalculatedField();
        this.FinalTotalGrant = new DevExpress.XtraReports.UI.CalculatedField();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable4)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable5)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable6)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
        // 
        // Detail
        // 
        this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable4});
        this.Detail.Dpi = 100F;
        this.Detail.HeightF = 30F;
        this.Detail.Name = "Detail";
        this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
        this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        // 
        // xrTable4
        // 
        this.xrTable4.BackColor = System.Drawing.Color.White;
        this.xrTable4.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTable4.Dpi = 100F;
        this.xrTable4.Font = new System.Drawing.Font("Arial", 6F);
        this.xrTable4.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrTable4.Name = "xrTable4";
        this.xrTable4.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
        this.xrTable4.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow4});
        this.xrTable4.SizeF = new System.Drawing.SizeF(3599F, 30F);
        this.xrTable4.StylePriority.UseBackColor = false;
        this.xrTable4.StylePriority.UseBorders = false;
        this.xrTable4.StylePriority.UseFont = false;
        this.xrTable4.StylePriority.UsePadding = false;
        this.xrTable4.StylePriority.UseTextAlignment = false;
        this.xrTable4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrTableRow4
        // 
        this.xrTableRow4.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell85,
            this.xrTableCell264,
            this.xrTableCell265,
            this.xrTableCell266,
            this.xrTableCell267,
            this.xrTableCell86,
            this.xrTableCell87,
            this.xrTableCell88,
            this.xrTableCell89,
            this.xrTableCell90,
            this.xrTableCell91,
            this.xrTableCell176,
            this.xrTableCell177,
            this.xrTableCell178,
            this.xrTableCell179,
            this.xrTableCell180,
            this.xrTableCell92,
            this.xrTableCell93,
            this.xrTableCell94,
            this.xrTableCell95,
            this.xrTableCell96,
            this.xrTableCell237,
            this.xrTableCell248,
            this.xrTableCell249,
            this.xrTableCell250,
            this.xrTableCell251,
            this.xrTableCell97,
            this.xrTableCell98,
            this.xrTableCell99,
            this.xrTableCell100,
            this.xrTableCell101,
            this.xrTableCell102,
            this.xrTableCell103,
            this.xrTableCell104,
            this.xrTableCell105,
            this.xrTableCell106,
            this.xrTableCell107,
            this.xrTableCell108,
            this.xrTableCell109,
            this.xrTableCell110,
            this.xrTableCell111,
            this.xrTableCell112,
            this.xrTableCell116,
            this.xrTableCell117,
            this.xrTableCell118,
            this.xrTableCell119,
            this.xrTableCell120,
            this.xrTableCell113,
            this.xrTableCell114,
            this.xrTableCell115,
            this.xrTableCell121,
            this.xrTableCell150,
            this.xrTableCell151});
        this.xrTableRow4.Dpi = 100F;
        this.xrTableRow4.Name = "xrTableRow4";
        this.xrTableRow4.Weight = 1D;
        // 
        // xrTableCell85
        // 
        this.xrTableCell85.Dpi = 100F;
        this.xrTableCell85.Font = new System.Drawing.Font("Arial", 7F);
        this.xrTableCell85.Name = "xrTableCell85";
        this.xrTableCell85.StylePriority.UseFont = false;
        this.xrTableCell85.StylePriority.UseTextAlignment = false;
        xrSummary1.Func = DevExpress.XtraReports.UI.SummaryFunc.RecordNumber;
        xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
        this.xrTableCell85.Summary = xrSummary1;
        this.xrTableCell85.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell85.Weight = 0.374539509323725D;
        // 
        // xrTableCell264
        // 
        this.xrTableCell264.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.strGSCode")});
        this.xrTableCell264.Dpi = 100F;
        this.xrTableCell264.Font = new System.Drawing.Font("Arial", 7F);
        this.xrTableCell264.Name = "xrTableCell264";
        this.xrTableCell264.StylePriority.UseFont = false;
        this.xrTableCell264.StylePriority.UseTextAlignment = false;
        this.xrTableCell264.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell264.Weight = 1.1704359344182254D;
        // 
        // xrTableCell265
        // 
        this.xrTableCell265.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.strSchemeCode")});
        this.xrTableCell265.Dpi = 100F;
        this.xrTableCell265.Font = new System.Drawing.Font("Arial", 7F);
        this.xrTableCell265.Name = "xrTableCell265";
        this.xrTableCell265.StylePriority.UseFont = false;
        this.xrTableCell265.StylePriority.UseTextAlignment = false;
        this.xrTableCell265.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell265.Weight = 1.1704359344182254D;
        // 
        // xrTableCell266
        // 
        this.xrTableCell266.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.Title")});
        this.xrTableCell266.Dpi = 100F;
        this.xrTableCell266.Font = new System.Drawing.Font("Arial", 7F);
        this.xrTableCell266.Name = "xrTableCell266";
        this.xrTableCell266.StylePriority.UseFont = false;
        this.xrTableCell266.StylePriority.UseTextAlignment = false;
        this.xrTableCell266.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        this.xrTableCell266.Weight = 2.5749590777239355D;
        // 
        // xrTableCell267
        // 
        this.xrTableCell267.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.strApprovedBy")});
        this.xrTableCell267.Dpi = 100F;
        this.xrTableCell267.Font = new System.Drawing.Font("Arial", 7F);
        this.xrTableCell267.Name = "xrTableCell267";
        this.xrTableCell267.StylePriority.UseFont = false;
        this.xrTableCell267.StylePriority.UseTextAlignment = false;
        this.xrTableCell267.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell267.Weight = 1.1704359344182251D;
        // 
        // xrTableCell86
        // 
        this.xrTableCell86.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ApprovalForumAndDate")});
        this.xrTableCell86.Dpi = 100F;
        this.xrTableCell86.Font = new System.Drawing.Font("Arial", 7F);
        this.xrTableCell86.Name = "xrTableCell86";
        this.xrTableCell86.StylePriority.UseFont = false;
        this.xrTableCell86.StylePriority.UseTextAlignment = false;
        this.xrTableCell86.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell86.Weight = 1.1704359369776047D;
        // 
        // xrTableCell87
        // 
        this.xrTableCell87.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ApproveCapitalAmount", "{0:#,#}")});
        this.xrTableCell87.Dpi = 100F;
        this.xrTableCell87.Name = "xrTableCell87";
        this.xrTableCell87.StylePriority.UseFont = false;
        this.xrTableCell87.StylePriority.UseTextAlignment = false;
        this.xrTableCell87.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell87.Weight = 0.533718797860546D;
        // 
        // xrTableCell88
        // 
        this.xrTableCell88.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ApproveRevenueAmount", "{0:#,#}")});
        this.xrTableCell88.Dpi = 100F;
        this.xrTableCell88.Name = "xrTableCell88";
        this.xrTableCell88.StylePriority.UseTextAlignment = false;
        this.xrTableCell88.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell88.Weight = 0.533718790073738D;
        // 
        // xrTableCell89
        // 
        this.xrTableCell89.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ApproveLocalAmount", "{0:#,#}")});
        this.xrTableCell89.Dpi = 100F;
        this.xrTableCell89.Name = "xrTableCell89";
        this.xrTableCell89.StylePriority.UseTextAlignment = false;
        this.xrTableCell89.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell89.Weight = 0.533718768675502D;
        // 
        // xrTableCell90
        // 
        this.xrTableCell90.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ApproveForignFundAmount", "{0:#,#}")});
        this.xrTableCell90.Dpi = 100F;
        this.xrTableCell90.Name = "xrTableCell90";
        this.xrTableCell90.StylePriority.UseTextAlignment = false;
        this.xrTableCell90.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell90.Weight = 0.53371881467524D;
        // 
        // xrTableCell91
        // 
        this.xrTableCell91.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ApproveTotalAmount", "{0:#,#}")});
        this.xrTableCell91.Dpi = 100F;
        this.xrTableCell91.Multiline = true;
        this.xrTableCell91.Name = "xrTableCell91";
        this.xrTableCell91.StylePriority.UseTextAlignment = false;
        this.xrTableCell91.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell91.Weight = 0.533718790372309D;
        // 
        // xrTableCell176
        // 
        this.xrTableCell176.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ExpensePYJCapitalAmount", "{0:#,#}")});
        this.xrTableCell176.Dpi = 100F;
        this.xrTableCell176.Name = "xrTableCell176";
        this.xrTableCell176.StylePriority.UseTextAlignment = false;
        this.xrTableCell176.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell176.Weight = 0.533718790372309D;
        // 
        // xrTableCell177
        // 
        this.xrTableCell177.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ExpensePYJRevenueAmount", "{0:#,#}")});
        this.xrTableCell177.Dpi = 100F;
        this.xrTableCell177.Name = "xrTableCell177";
        this.xrTableCell177.StylePriority.UseTextAlignment = false;
        this.xrTableCell177.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell177.Weight = 0.533718790372309D;
        // 
        // xrTableCell178
        // 
        this.xrTableCell178.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ExpensePYJLocalAmount", "{0:#,#}")});
        this.xrTableCell178.Dpi = 100F;
        this.xrTableCell178.Name = "xrTableCell178";
        this.xrTableCell178.StylePriority.UseTextAlignment = false;
        this.xrTableCell178.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell178.Weight = 0.533718790372309D;
        // 
        // xrTableCell179
        // 
        this.xrTableCell179.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ExpensePYJForignFundAmount", "{0:#,#}")});
        this.xrTableCell179.Dpi = 100F;
        this.xrTableCell179.Name = "xrTableCell179";
        this.xrTableCell179.StylePriority.UseTextAlignment = false;
        this.xrTableCell179.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell179.Weight = 0.533718790372309D;
        // 
        // xrTableCell180
        // 
        this.xrTableCell180.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ExpensePYJTotalAmount", "{0:#,#}")});
        this.xrTableCell180.Dpi = 100F;
        this.xrTableCell180.Name = "xrTableCell180";
        this.xrTableCell180.StylePriority.UseTextAlignment = false;
        this.xrTableCell180.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell180.Weight = 0.533718790372309D;
        // 
        // xrTableCell92
        // 
        this.xrTableCell92.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.AllocationCapitalAmount", "{0:#,#}")});
        this.xrTableCell92.Dpi = 100F;
        this.xrTableCell92.Name = "xrTableCell92";
        this.xrTableCell92.StylePriority.UseTextAlignment = false;
        this.xrTableCell92.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell92.Weight = 0.533718784270983D;
        // 
        // xrTableCell93
        // 
        this.xrTableCell93.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.AllocationRevenueAmount", "{0:#,#}")});
        this.xrTableCell93.Dpi = 100F;
        this.xrTableCell93.Name = "xrTableCell93";
        this.xrTableCell93.StylePriority.UseTextAlignment = false;
        this.xrTableCell93.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell93.Weight = 0.533718784270983D;
        // 
        // xrTableCell94
        // 
        this.xrTableCell94.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.AllocationLocalAmount", "{0:#,#}")});
        this.xrTableCell94.Dpi = 100F;
        this.xrTableCell94.Name = "xrTableCell94";
        this.xrTableCell94.StylePriority.UseTextAlignment = false;
        this.xrTableCell94.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell94.Weight = 0.533718784270984D;
        // 
        // xrTableCell95
        // 
        this.xrTableCell95.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.AllocationForignFundAmount", "{0:#,#}")});
        this.xrTableCell95.Dpi = 100F;
        this.xrTableCell95.Name = "xrTableCell95";
        this.xrTableCell95.StylePriority.UseTextAlignment = false;
        this.xrTableCell95.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell95.Weight = 0.533718784270983D;
        // 
        // xrTableCell96
        // 
        this.xrTableCell96.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.AllocationTotalAmount", "{0:#,#}")});
        this.xrTableCell96.Dpi = 100F;
        this.xrTableCell96.Name = "xrTableCell96";
        this.xrTableCell96.StylePriority.UseTextAlignment = false;
        this.xrTableCell96.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell96.Weight = 0.533718784270983D;
        // 
        // xrTableCell237
        // 
        this.xrTableCell237.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.FinalCapitalGrant", "{0:#,#}")});
        this.xrTableCell237.Dpi = 100F;
        this.xrTableCell237.Name = "xrTableCell237";
        this.xrTableCell237.StylePriority.UseTextAlignment = false;
        this.xrTableCell237.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell237.Weight = 0.533718784270983D;
        // 
        // xrTableCell248
        // 
        this.xrTableCell248.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.FinalRevenueGrant", "{0:#,#}")});
        this.xrTableCell248.Dpi = 100F;
        this.xrTableCell248.Name = "xrTableCell248";
        this.xrTableCell248.StylePriority.UseTextAlignment = false;
        this.xrTableCell248.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell248.Weight = 0.533718784270983D;
        // 
        // xrTableCell249
        // 
        this.xrTableCell249.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.FinalLocalGrant", "{0:#,#}")});
        this.xrTableCell249.Dpi = 100F;
        this.xrTableCell249.Name = "xrTableCell249";
        this.xrTableCell249.StylePriority.UseTextAlignment = false;
        this.xrTableCell249.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell249.Weight = 0.533718784270983D;
        // 
        // xrTableCell250
        // 
        this.xrTableCell250.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.FinalForignFundGrant", "{0:#,#}")});
        this.xrTableCell250.Dpi = 100F;
        this.xrTableCell250.Name = "xrTableCell250";
        this.xrTableCell250.StylePriority.UseTextAlignment = false;
        this.xrTableCell250.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell250.Weight = 0.533718784270983D;
        // 
        // xrTableCell251
        // 
        this.xrTableCell251.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.FinalTotalGrant", "{0:#,#}")});
        this.xrTableCell251.Dpi = 100F;
        this.xrTableCell251.Name = "xrTableCell251";
        this.xrTableCell251.StylePriority.UseTextAlignment = false;
        this.xrTableCell251.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell251.Weight = 0.533718784270983D;
        // 
        // xrTableCell97
        // 
        this.xrTableCell97.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ReleaseCapitalAmount", "{0:#,#}")});
        this.xrTableCell97.Dpi = 100F;
        this.xrTableCell97.Name = "xrTableCell97";
        this.xrTableCell97.StylePriority.UseTextAlignment = false;
        this.xrTableCell97.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell97.Weight = 0.533718819989853D;
        // 
        // xrTableCell98
        // 
        this.xrTableCell98.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ReleaseRevenueAmount", "{0:#,#}")});
        this.xrTableCell98.Dpi = 100F;
        this.xrTableCell98.Name = "xrTableCell98";
        this.xrTableCell98.StylePriority.UseTextAlignment = false;
        this.xrTableCell98.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell98.Weight = 0.533718784270984D;
        // 
        // xrTableCell99
        // 
        this.xrTableCell99.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ReleseLocalAmount", "{0:#,#}")});
        this.xrTableCell99.Dpi = 100F;
        this.xrTableCell99.Name = "xrTableCell99";
        this.xrTableCell99.StylePriority.UseTextAlignment = false;
        this.xrTableCell99.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell99.Weight = 0.533718784270983D;
        // 
        // xrTableCell100
        // 
        this.xrTableCell100.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ReleaseForignFundAmount", "{0:#,#}")});
        this.xrTableCell100.Dpi = 100F;
        this.xrTableCell100.Name = "xrTableCell100";
        this.xrTableCell100.StylePriority.UseTextAlignment = false;
        this.xrTableCell100.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell100.Weight = 0.533718784270983D;
        // 
        // xrTableCell101
        // 
        this.xrTableCell101.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ReleseTotalAmount", "{0:#,#}")});
        this.xrTableCell101.Dpi = 100F;
        this.xrTableCell101.Name = "xrTableCell101";
        this.xrTableCell101.StylePriority.UseTextAlignment = false;
        this.xrTableCell101.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell101.Weight = 0.533718784270983D;
        // 
        // xrTableCell102
        // 
        this.xrTableCell102.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ExpenseCapitalAmount", "{0:#,#}")});
        this.xrTableCell102.Dpi = 100F;
        this.xrTableCell102.Name = "xrTableCell102";
        this.xrTableCell102.StylePriority.UseTextAlignment = false;
        this.xrTableCell102.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell102.Weight = 0.533718784270983D;
        // 
        // xrTableCell103
        // 
        this.xrTableCell103.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ExpenseRevenueAmount", "{0:#,#}")});
        this.xrTableCell103.Dpi = 100F;
        this.xrTableCell103.Name = "xrTableCell103";
        this.xrTableCell103.StylePriority.UseTextAlignment = false;
        this.xrTableCell103.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell103.Weight = 0.533718784270984D;
        // 
        // xrTableCell104
        // 
        this.xrTableCell104.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ExpenseLocalAmount", "{0:#,#}")});
        this.xrTableCell104.Dpi = 100F;
        this.xrTableCell104.Name = "xrTableCell104";
        this.xrTableCell104.StylePriority.UseTextAlignment = false;
        this.xrTableCell104.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell104.Weight = 0.533718784270984D;
        // 
        // xrTableCell105
        // 
        this.xrTableCell105.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ExpenseForignFundAmount", "{0:#,#}")});
        this.xrTableCell105.Dpi = 100F;
        this.xrTableCell105.Name = "xrTableCell105";
        this.xrTableCell105.StylePriority.UseTextAlignment = false;
        this.xrTableCell105.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell105.Weight = 0.533718774229001D;
        // 
        // xrTableCell106
        // 
        this.xrTableCell106.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ExpenseTotalAmount", "{0:#,#}")});
        this.xrTableCell106.Dpi = 100F;
        this.xrTableCell106.Name = "xrTableCell106";
        this.xrTableCell106.StylePriority.UseTextAlignment = false;
        this.xrTableCell106.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell106.Weight = 0.533718774229001D;
        // 
        // xrTableCell107
        // 
        this.xrTableCell107.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ExpenseLocalAllocationPercentage", "{0:0.00%}")});
        this.xrTableCell107.Dpi = 100F;
        this.xrTableCell107.Name = "xrTableCell107";
        this.xrTableCell107.StylePriority.UseTextAlignment = false;
        this.xrTableCell107.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell107.Weight = 0.533718774229D;
        // 
        // xrTableCell108
        // 
        this.xrTableCell108.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ExpenseLocalReleasePercentage", "{0:0.00%}")});
        this.xrTableCell108.Dpi = 100F;
        this.xrTableCell108.Name = "xrTableCell108";
        this.xrTableCell108.StylePriority.UseTextAlignment = false;
        this.xrTableCell108.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell108.Weight = 0.533718774229001D;
        // 
        // xrTableCell109
        // 
        this.xrTableCell109.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ExpenseForeignAidAllocationPercentage", "{0:0.00%}")});
        this.xrTableCell109.Dpi = 100F;
        this.xrTableCell109.Name = "xrTableCell109";
        this.xrTableCell109.StylePriority.UseTextAlignment = false;
        this.xrTableCell109.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell109.Weight = 0.533718774229001D;
        // 
        // xrTableCell110
        // 
        this.xrTableCell110.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ExpenseForeignAidReleasePercentage", "{0:0.00%}")});
        this.xrTableCell110.Dpi = 100F;
        this.xrTableCell110.Name = "xrTableCell110";
        this.xrTableCell110.StylePriority.UseTextAlignment = false;
        this.xrTableCell110.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell110.Weight = 0.533718774229D;
        // 
        // xrTableCell111
        // 
        this.xrTableCell111.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ExpenseTotalAllocationPercentage", "{0:0.00%}")});
        this.xrTableCell111.Dpi = 100F;
        this.xrTableCell111.Name = "xrTableCell111";
        this.xrTableCell111.StylePriority.UseTextAlignment = false;
        this.xrTableCell111.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell111.Weight = 0.533718774229D;
        // 
        // xrTableCell112
        // 
        this.xrTableCell112.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ExpenseTotalReleasePercentage", "{0:0.00%}")});
        this.xrTableCell112.Dpi = 100F;
        this.xrTableCell112.Name = "xrTableCell112";
        this.xrTableCell112.StylePriority.UseTextAlignment = false;
        this.xrTableCell112.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell112.Weight = 0.533718774229D;
        // 
        // xrTableCell116
        // 
        this.xrTableCell116.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ThrowForwardCapital", "{0:#,#}")});
        this.xrTableCell116.Dpi = 100F;
        this.xrTableCell116.Name = "xrTableCell116";
        this.xrTableCell116.StylePriority.UseTextAlignment = false;
        this.xrTableCell116.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell116.Weight = 0.53371884566674D;
        // 
        // xrTableCell117
        // 
        this.xrTableCell117.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ThrowForwardRevenue", "{0:#,#}")});
        this.xrTableCell117.Dpi = 100F;
        this.xrTableCell117.Name = "xrTableCell117";
        this.xrTableCell117.StylePriority.UseTextAlignment = false;
        this.xrTableCell117.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell117.Weight = 0.533718775071325D;
        // 
        // xrTableCell118
        // 
        this.xrTableCell118.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ThrowForwardLocal", "{0:#,#}")});
        this.xrTableCell118.Dpi = 100F;
        this.xrTableCell118.Name = "xrTableCell118";
        this.xrTableCell118.StylePriority.UseTextAlignment = false;
        this.xrTableCell118.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell118.Weight = 0.533718773386674D;
        // 
        // xrTableCell119
        // 
        this.xrTableCell119.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ThrowForwardForignFund", "{0:#,#}")});
        this.xrTableCell119.Dpi = 100F;
        this.xrTableCell119.Name = "xrTableCell119";
        this.xrTableCell119.StylePriority.UseTextAlignment = false;
        this.xrTableCell119.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell119.Weight = 0.53371884566674D;
        // 
        // xrTableCell120
        // 
        this.xrTableCell120.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ThrowForwardTotal", "{0:#,#}")});
        this.xrTableCell120.Dpi = 100F;
        this.xrTableCell120.Name = "xrTableCell120";
        this.xrTableCell120.StylePriority.UseTextAlignment = false;
        this.xrTableCell120.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell120.Weight = 0.53371884566674D;
        // 
        // xrTableCell113
        // 
        this.xrTableCell113.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ExcessCapitalAmount", "{0:#,#}")});
        this.xrTableCell113.Dpi = 100F;
        this.xrTableCell113.Name = "xrTableCell113";
        this.xrTableCell113.StylePriority.UseTextAlignment = false;
        this.xrTableCell113.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell113.Weight = 0.53371884566674D;
        // 
        // xrTableCell114
        // 
        this.xrTableCell114.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ExcessRevenueAmount", "{0:#,#}")});
        this.xrTableCell114.Dpi = 100F;
        this.xrTableCell114.Name = "xrTableCell114";
        this.xrTableCell114.StylePriority.UseTextAlignment = false;
        this.xrTableCell114.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell114.Weight = 0.53371884566674D;
        // 
        // xrTableCell115
        // 
        this.xrTableCell115.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ExcessLocalAmount", "{0:#,#}")});
        this.xrTableCell115.Dpi = 100F;
        this.xrTableCell115.Name = "xrTableCell115";
        this.xrTableCell115.StylePriority.UseTextAlignment = false;
        this.xrTableCell115.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell115.Weight = 0.53371884566674D;
        // 
        // xrTableCell121
        // 
        this.xrTableCell121.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ExcessForignFundAmount", "{0:#,#}")});
        this.xrTableCell121.Dpi = 100F;
        this.xrTableCell121.Name = "xrTableCell121";
        this.xrTableCell121.StylePriority.UseTextAlignment = false;
        this.xrTableCell121.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell121.Weight = 0.53371884566674D;
        // 
        // xrTableCell150
        // 
        this.xrTableCell150.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ExcessTotalAmount", "{0:#,#}")});
        this.xrTableCell150.Dpi = 100F;
        this.xrTableCell150.Name = "xrTableCell150";
        this.xrTableCell150.StylePriority.UseTextAlignment = false;
        this.xrTableCell150.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell150.Weight = 0.53371884566674D;
        // 
        // xrTableCell151
        // 
        this.xrTableCell151.Dpi = 100F;
        this.xrTableCell151.Name = "xrTableCell151";
        this.xrTableCell151.StylePriority.UseTextAlignment = false;
        this.xrTableCell151.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        this.xrTableCell151.Weight = 1.51688505069567D;
        // 
        // TopMargin
        // 
        this.TopMargin.Dpi = 100F;
        this.TopMargin.HeightF = 49F;
        this.TopMargin.Name = "TopMargin";
        this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
        this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        // 
        // xrLabel4
        // 
        this.xrLabel4.Dpi = 100F;
        this.xrLabel4.Font = new System.Drawing.Font("Arial", 8.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
        this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(248.5417F, 153.125F);
        this.xrLabel4.Multiline = true;
        this.xrLabel4.Name = "xrLabel4";
        this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel4.SizeF = new System.Drawing.SizeF(60F, 30F);
        this.xrLabel4.StylePriority.UseFont = false;
        this.xrLabel4.StylePriority.UseTextAlignment = false;
        this.xrLabel4.Text = "Date:";
        this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrLabel5
        // 
        this.xrLabel5.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.prDateRange, "Text", "")});
        this.xrLabel5.Dpi = 100F;
        this.xrLabel5.Font = new System.Drawing.Font("Arial", 8.75F);
        this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(308.5417F, 153.125F);
        this.xrLabel5.Multiline = true;
        this.xrLabel5.Name = "xrLabel5";
        this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel5.SizeF = new System.Drawing.SizeF(500F, 30F);
        this.xrLabel5.StylePriority.UseFont = false;
        this.xrLabel5.StylePriority.UseTextAlignment = false;
        this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // prDateRange
        // 
        this.prDateRange.Description = "DateRange";
        this.prDateRange.Name = "prDateRange";
        this.prDateRange.Visible = false;
        // 
        // xrLabel7
        // 
        this.xrLabel7.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.prDistrict, "Text", "")});
        this.xrLabel7.Dpi = 100F;
        this.xrLabel7.Font = new System.Drawing.Font("Arial", 8.75F);
        this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(98.5417F, 213.125F);
        this.xrLabel7.Multiline = true;
        this.xrLabel7.Name = "xrLabel7";
        this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel7.SizeF = new System.Drawing.SizeF(440.625F, 30F);
        this.xrLabel7.StylePriority.UseFont = false;
        this.xrLabel7.StylePriority.UseTextAlignment = false;
        this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // prDistrict
        // 
        this.prDistrict.Description = "District";
        this.prDistrict.Name = "prDistrict";
        this.prDistrict.Visible = false;
        // 
        // xrLabel9
        // 
        this.xrLabel9.Dpi = 100F;
        this.xrLabel9.Font = new System.Drawing.Font("Arial", 8.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
        this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(0F, 213.125F);
        this.xrLabel9.Multiline = true;
        this.xrLabel9.Name = "xrLabel9";
        this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel9.SizeF = new System.Drawing.SizeF(98.54167F, 30F);
        this.xrLabel9.StylePriority.UseFont = false;
        this.xrLabel9.StylePriority.UseTextAlignment = false;
        this.xrLabel9.Text = "District:";
        this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrLabel3
        // 
        this.xrLabel3.Dpi = 100F;
        this.xrLabel3.Font = new System.Drawing.Font("Arial", 8.75F);
        this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(98.5417F, 183.125F);
        this.xrLabel3.Multiline = true;
        this.xrLabel3.Name = "xrLabel3";
        this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel3.SizeF = new System.Drawing.SizeF(150F, 30F);
        this.xrLabel3.StylePriority.UseFont = false;
        this.xrLabel3.StylePriority.UseTextAlignment = false;
        this.xrLabel3.Text = "Health";
        this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrLabel8
        // 
        this.xrLabel8.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.prYear, "Text", "")});
        this.xrLabel8.Dpi = 100F;
        this.xrLabel8.Font = new System.Drawing.Font("Arial", 8.75F);
        this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(98.5417F, 153.125F);
        this.xrLabel8.Multiline = true;
        this.xrLabel8.Name = "xrLabel8";
        this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel8.SizeF = new System.Drawing.SizeF(150F, 30F);
        this.xrLabel8.StylePriority.UseFont = false;
        this.xrLabel8.StylePriority.UseTextAlignment = false;
        this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // prYear
        // 
        this.prYear.Description = "Year";
        this.prYear.Name = "prYear";
        this.prYear.Visible = false;
        // 
        // xrLabel2
        // 
        this.xrLabel2.Dpi = 100F;
        this.xrLabel2.Font = new System.Drawing.Font("Arial", 8.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
        this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 183.125F);
        this.xrLabel2.Multiline = true;
        this.xrLabel2.Name = "xrLabel2";
        this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel2.SizeF = new System.Drawing.SizeF(98.54167F, 30F);
        this.xrLabel2.StylePriority.UseFont = false;
        this.xrLabel2.StylePriority.UseTextAlignment = false;
        this.xrLabel2.Text = "Sector:";
        this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrLabel6
        // 
        this.xrLabel6.Dpi = 100F;
        this.xrLabel6.Font = new System.Drawing.Font("Arial", 8.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
        this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(0F, 153.125F);
        this.xrLabel6.Multiline = true;
        this.xrLabel6.Name = "xrLabel6";
        this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel6.SizeF = new System.Drawing.SizeF(98.54167F, 30F);
        this.xrLabel6.StylePriority.UseFont = false;
        this.xrLabel6.StylePriority.UseTextAlignment = false;
        this.xrLabel6.Text = "Year:";
        this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrLabel1
        // 
        this.xrLabel1.Dpi = 100F;
        this.xrLabel1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
        this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(1462.5F, 0F);
        this.xrLabel1.Name = "xrLabel1";
        this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel1.SizeF = new System.Drawing.SizeF(670F, 48.95834F);
        this.xrLabel1.StylePriority.UseFont = false;
        this.xrLabel1.StylePriority.UseTextAlignment = false;
        this.xrLabel1.Text = "Progress Review Report - Summary";
        this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // BottomMargin
        // 
        this.BottomMargin.Dpi = 100F;
        this.BottomMargin.HeightF = 50F;
        this.BottomMargin.Name = "BottomMargin";
        this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
        this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        // 
        // bindingSource1
        // 
        this.bindingSource1.DataMember = "CornReportList";
        this.bindingSource1.DataSource = typeof(CORNDataAccessLayer.Response.ReportResponse);
        // 
        // xrTable2
        // 
        this.xrTable2.BackColor = System.Drawing.Color.LightGray;
        this.xrTable2.Dpi = 100F;
        this.xrTable2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
        this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrTable2.Name = "xrTable2";
        this.xrTable2.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
        this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
        this.xrTable2.SizeF = new System.Drawing.SizeF(3599F, 60F);
        this.xrTable2.StylePriority.UseBackColor = false;
        this.xrTable2.StylePriority.UseFont = false;
        this.xrTable2.StylePriority.UsePadding = false;
        this.xrTable2.StylePriority.UseTextAlignment = false;
        this.xrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrTableRow2
        // 
        this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell10,
            this.xrTableCell260,
            this.xrTableCell261,
            this.xrTableCell262,
            this.xrTableCell263,
            this.xrTableCell12,
            this.xrTableCell13,
            this.xrTableCell14,
            this.xrTableCell15,
            this.xrTableCell236,
            this.xrTableCell16,
            this.xrTableCell47,
            this.xrTableCell17,
            this.xrTableCell32,
            this.xrTableCell19,
            this.xrTableCell20,
            this.xrTableCell161,
            this.xrTableCell167});
        this.xrTableRow2.Dpi = 100F;
        this.xrTableRow2.Name = "xrTableRow2";
        this.xrTableRow2.Weight = 1D;
        // 
        // xrTableCell10
        // 
        this.xrTableCell10.Dpi = 100F;
        this.xrTableCell10.Name = "xrTableCell10";
        this.xrTableCell10.StylePriority.UseTextAlignment = false;
        this.xrTableCell10.Text = "S.No.";
        this.xrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell10.Weight = 0.245082919000618D;
        // 
        // xrTableCell260
        // 
        this.xrTableCell260.Dpi = 100F;
        this.xrTableCell260.Name = "xrTableCell260";
        this.xrTableCell260.StylePriority.UseTextAlignment = false;
        this.xrTableCell260.Text = "ADP No.";
        this.xrTableCell260.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell260.Weight = 0.76588409504445021D;
        // 
        // xrTableCell261
        // 
        this.xrTableCell261.Dpi = 100F;
        this.xrTableCell261.Name = "xrTableCell261";
        this.xrTableCell261.StylePriority.UseTextAlignment = false;
        this.xrTableCell261.Text = "Code";
        this.xrTableCell261.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell261.Weight = 0.76588409504445021D;
        // 
        // xrTableCell262
        // 
        this.xrTableCell262.Dpi = 100F;
        this.xrTableCell262.Name = "xrTableCell262";
        this.xrTableCell262.Text = "Name of the Scheme";
        this.xrTableCell262.Weight = 1.6849450202125724D;
        // 
        // xrTableCell263
        // 
        this.xrTableCell263.Dpi = 100F;
        this.xrTableCell263.Name = "xrTableCell263";
        this.xrTableCell263.StylePriority.UseTextAlignment = false;
        this.xrTableCell263.Text = "Approval forum";
        this.xrTableCell263.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell263.Weight = 0.7658840950444501D;
        // 
        // xrTableCell12
        // 
        this.xrTableCell12.Dpi = 100F;
        this.xrTableCell12.Name = "xrTableCell12";
        this.xrTableCell12.StylePriority.UseTextAlignment = false;
        this.xrTableCell12.Text = "Date of Approval";
        this.xrTableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell12.Weight = 0.76588409633726773D;
        // 
        // xrTableCell13
        // 
        this.xrTableCell13.Dpi = 100F;
        this.xrTableCell13.Name = "xrTableCell13";
        this.xrTableCell13.StylePriority.UseTextAlignment = false;
        this.xrTableCell13.Text = "Approved Cost";
        this.xrTableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell13.Weight = 1.74621581964568D;
        // 
        // xrTableCell14
        // 
        this.xrTableCell14.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "headExpenseUptoJunPY")});
        this.xrTableCell14.Dpi = 100F;
        this.xrTableCell14.Name = "xrTableCell14";
        this.xrTableCell14.StylePriority.UseTextAlignment = false;
        this.xrTableCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell14.Weight = 1.74621572615397D;
        // 
        // xrTableCell15
        // 
        this.xrTableCell15.Dpi = 100F;
        this.xrTableCell15.Multiline = true;
        this.xrTableCell15.Name = "xrTableCell15";
        this.xrTableCell15.StylePriority.UseTextAlignment = false;
        this.xrTableCell15.Text = "Allocation";
        this.xrTableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell15.Weight = 1.74621572556616D;
        // 
        // xrTableCell236
        // 
        this.xrTableCell236.Dpi = 100F;
        this.xrTableCell236.Name = "xrTableCell236";
        this.xrTableCell236.StylePriority.UseTextAlignment = false;
        this.xrTableCell236.Text = "Final Grant";
        this.xrTableCell236.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell236.Weight = 1.7462157255661597D;
        // 
        // xrTableCell16
        // 
        this.xrTableCell16.Dpi = 100F;
        this.xrTableCell16.Multiline = true;
        this.xrTableCell16.Name = "xrTableCell16";
        this.xrTableCell16.StylePriority.UseTextAlignment = false;
        this.xrTableCell16.Text = "Release";
        this.xrTableCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell16.Weight = 1.7462157314352602D;
        // 
        // xrTableCell47
        // 
        this.xrTableCell47.Dpi = 100F;
        this.xrTableCell47.Name = "xrTableCell47";
        this.xrTableCell47.StylePriority.UseTextAlignment = false;
        this.xrTableCell47.Text = "Expenditure";
        this.xrTableCell47.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell47.Weight = 1.7462157314352604D;
        // 
        // xrTableCell17
        // 
        this.xrTableCell17.Dpi = 100F;
        this.xrTableCell17.Multiline = true;
        this.xrTableCell17.Name = "xrTableCell17";
        this.xrTableCell17.StylePriority.UseTextAlignment = false;
        this.xrTableCell17.Text = "% Expenditure (Local)";
        this.xrTableCell17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell17.Weight = 0.69848628770052512D;
        // 
        // xrTableCell32
        // 
        this.xrTableCell32.Dpi = 100F;
        this.xrTableCell32.Multiline = true;
        this.xrTableCell32.Name = "xrTableCell32";
        this.xrTableCell32.StylePriority.UseTextAlignment = false;
        this.xrTableCell32.Text = "% Expenditure (F.aid)";
        this.xrTableCell32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell32.Weight = 0.69848632792D;
        // 
        // xrTableCell19
        // 
        this.xrTableCell19.Dpi = 100F;
        this.xrTableCell19.Name = "xrTableCell19";
        this.xrTableCell19.StylePriority.UseTextAlignment = false;
        this.xrTableCell19.Text = "% Expenditure (Total)";
        this.xrTableCell19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell19.Weight = 0.69848632792000487D;
        // 
        // xrTableCell20
        // 
        this.xrTableCell20.Dpi = 100F;
        this.xrTableCell20.Name = "xrTableCell20";
        this.xrTableCell20.StylePriority.UseTextAlignment = false;
        this.xrTableCell20.Text = "Throw Forward";
        this.xrTableCell20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell20.Weight = 1.74621578963155D;
        // 
        // xrTableCell161
        // 
        this.xrTableCell161.Dpi = 100F;
        this.xrTableCell161.Name = "xrTableCell161";
        this.xrTableCell161.StylePriority.UseTextAlignment = false;
        this.xrTableCell161.Text = "Excess/Lapse";
        this.xrTableCell161.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell161.Weight = 1.7462157896315498D;
        // 
        // xrTableCell167
        // 
        this.xrTableCell167.Dpi = 100F;
        this.xrTableCell167.Name = "xrTableCell167";
        this.xrTableCell167.StylePriority.UseTextAlignment = false;
        this.xrTableCell167.Text = "Remarks / Comments";
        this.xrTableCell167.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        this.xrTableCell167.Weight = 0.992585827910551D;
        // 
        // xrTable1
        // 
        this.xrTable1.BackColor = System.Drawing.Color.LightGray;
        this.xrTable1.Dpi = 100F;
        this.xrTable1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
        this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 60F);
        this.xrTable1.Name = "xrTable1";
        this.xrTable1.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
        this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
        this.xrTable1.SizeF = new System.Drawing.SizeF(3599F, 30F);
        this.xrTable1.StylePriority.UseBackColor = false;
        this.xrTable1.StylePriority.UseFont = false;
        this.xrTable1.StylePriority.UsePadding = false;
        this.xrTable1.StylePriority.UseTextAlignment = false;
        this.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrTableRow1
        // 
        this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell7,
            this.xrTableCell276,
            this.xrTableCell277,
            this.xrTableCell278,
            this.xrTableCell279,
            this.xrTableCell6,
            this.xrTableCell1,
            this.xrTableCell2,
            this.xrTableCell3,
            this.xrTableCell4,
            this.xrTableCell5,
            this.xrTableCell8,
            this.xrTableCell9,
            this.xrTableCell11,
            this.xrTableCell21,
            this.xrTableCell22,
            this.xrTableCell23,
            this.xrTableCell24,
            this.xrTableCell25,
            this.xrTableCell26,
            this.xrTableCell159,
            this.xrTableCell234,
            this.xrTableCell240,
            this.xrTableCell241,
            this.xrTableCell242,
            this.xrTableCell243,
            this.xrTableCell27,
            this.xrTableCell28,
            this.xrTableCell29,
            this.xrTableCell30,
            this.xrTableCell31,
            this.xrTableCell162,
            this.xrTableCell166,
            this.xrTableCell165,
            this.xrTableCell164,
            this.xrTableCell163,
            this.xrTableCell33,
            this.xrTableCell34,
            this.xrTableCell18,
            this.xrTableCell35,
            this.xrTableCell36,
            this.xrTableCell37,
            this.xrTableCell38,
            this.xrTableCell160,
            this.xrTableCell39,
            this.xrTableCell40,
            this.xrTableCell41,
            this.xrTableCell42,
            this.xrTableCell43,
            this.xrTableCell44,
            this.xrTableCell45,
            this.xrTableCell46,
            this.xrTableCell168});
        this.xrTableRow1.Dpi = 100F;
        this.xrTableRow1.Name = "xrTableRow1";
        this.xrTableRow1.Weight = 1D;
        // 
        // xrTableCell7
        // 
        this.xrTableCell7.Dpi = 100F;
        this.xrTableCell7.Name = "xrTableCell7";
        this.xrTableCell7.StylePriority.UseTextAlignment = false;
        this.xrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell7.Weight = 0.374539509323725D;
        // 
        // xrTableCell276
        // 
        this.xrTableCell276.Dpi = 100F;
        this.xrTableCell276.Name = "xrTableCell276";
        this.xrTableCell276.StylePriority.UseTextAlignment = false;
        this.xrTableCell276.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell276.Weight = 1.1704359447683954D;
        // 
        // xrTableCell277
        // 
        this.xrTableCell277.Dpi = 100F;
        this.xrTableCell277.Name = "xrTableCell277";
        this.xrTableCell277.StylePriority.UseTextAlignment = false;
        this.xrTableCell277.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell277.Weight = 1.1704359447683954D;
        // 
        // xrTableCell278
        // 
        this.xrTableCell278.Dpi = 100F;
        this.xrTableCell278.Name = "xrTableCell278";
        this.xrTableCell278.StylePriority.UseTextAlignment = false;
        this.xrTableCell278.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell278.Weight = 2.5749590708247805D;
        // 
        // xrTableCell279
        // 
        this.xrTableCell279.Dpi = 100F;
        this.xrTableCell279.Name = "xrTableCell279";
        this.xrTableCell279.StylePriority.UseTextAlignment = false;
        this.xrTableCell279.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell279.Weight = 1.1704359447683954D;
        // 
        // xrTableCell6
        // 
        this.xrTableCell6.Dpi = 100F;
        this.xrTableCell6.Name = "xrTableCell6";
        this.xrTableCell6.StylePriority.UseTextAlignment = false;
        this.xrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell6.Weight = 1.1704359438767589D;
        // 
        // xrTableCell1
        // 
        this.xrTableCell1.Dpi = 100F;
        this.xrTableCell1.Name = "xrTableCell1";
        this.xrTableCell1.StylePriority.UseTextAlignment = false;
        this.xrTableCell1.Text = "Capital";
        this.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell1.Weight = 0.533718797860546D;
        // 
        // xrTableCell2
        // 
        this.xrTableCell2.Dpi = 100F;
        this.xrTableCell2.Name = "xrTableCell2";
        this.xrTableCell2.StylePriority.UseTextAlignment = false;
        this.xrTableCell2.Text = "Revenue";
        this.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell2.Weight = 0.533718790073738D;
        // 
        // xrTableCell3
        // 
        this.xrTableCell3.Dpi = 100F;
        this.xrTableCell3.Name = "xrTableCell3";
        this.xrTableCell3.StylePriority.UseTextAlignment = false;
        this.xrTableCell3.Text = "Local";
        this.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell3.Weight = 0.533718768675502D;
        // 
        // xrTableCell4
        // 
        this.xrTableCell4.Dpi = 100F;
        this.xrTableCell4.Name = "xrTableCell4";
        this.xrTableCell4.StylePriority.UseTextAlignment = false;
        this.xrTableCell4.Text = "F.aid";
        this.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell4.Weight = 0.53371881467524D;
        // 
        // xrTableCell5
        // 
        this.xrTableCell5.Dpi = 100F;
        this.xrTableCell5.Multiline = true;
        this.xrTableCell5.Name = "xrTableCell5";
        this.xrTableCell5.StylePriority.UseTextAlignment = false;
        this.xrTableCell5.Text = "Total";
        this.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell5.Weight = 0.533718790372309D;
        // 
        // xrTableCell8
        // 
        this.xrTableCell8.Dpi = 100F;
        this.xrTableCell8.Name = "xrTableCell8";
        this.xrTableCell8.StylePriority.UseTextAlignment = false;
        this.xrTableCell8.Text = "Capital";
        this.xrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell8.Weight = 0.533718784270983D;
        // 
        // xrTableCell9
        // 
        this.xrTableCell9.Dpi = 100F;
        this.xrTableCell9.Name = "xrTableCell9";
        this.xrTableCell9.StylePriority.UseTextAlignment = false;
        this.xrTableCell9.Text = "Revenue";
        this.xrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell9.Weight = 0.533718784270983D;
        // 
        // xrTableCell11
        // 
        this.xrTableCell11.Dpi = 100F;
        this.xrTableCell11.Name = "xrTableCell11";
        this.xrTableCell11.StylePriority.UseTextAlignment = false;
        this.xrTableCell11.Text = "Local";
        this.xrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell11.Weight = 0.533718784270984D;
        // 
        // xrTableCell21
        // 
        this.xrTableCell21.Dpi = 100F;
        this.xrTableCell21.Name = "xrTableCell21";
        this.xrTableCell21.StylePriority.UseTextAlignment = false;
        this.xrTableCell21.Text = "F.aid";
        this.xrTableCell21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell21.Weight = 0.533718784270983D;
        // 
        // xrTableCell22
        // 
        this.xrTableCell22.Dpi = 100F;
        this.xrTableCell22.Name = "xrTableCell22";
        this.xrTableCell22.StylePriority.UseTextAlignment = false;
        this.xrTableCell22.Text = "Total";
        this.xrTableCell22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell22.Weight = 0.533718784270983D;
        // 
        // xrTableCell23
        // 
        this.xrTableCell23.Dpi = 100F;
        this.xrTableCell23.Name = "xrTableCell23";
        this.xrTableCell23.StylePriority.UseTextAlignment = false;
        this.xrTableCell23.Text = "Capital";
        this.xrTableCell23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell23.Weight = 0.533718819989853D;
        // 
        // xrTableCell24
        // 
        this.xrTableCell24.Dpi = 100F;
        this.xrTableCell24.Name = "xrTableCell24";
        this.xrTableCell24.StylePriority.UseTextAlignment = false;
        this.xrTableCell24.Text = "Revenue";
        this.xrTableCell24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell24.Weight = 0.533718784270984D;
        // 
        // xrTableCell25
        // 
        this.xrTableCell25.Dpi = 100F;
        this.xrTableCell25.Name = "xrTableCell25";
        this.xrTableCell25.StylePriority.UseTextAlignment = false;
        this.xrTableCell25.Text = "Local";
        this.xrTableCell25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell25.Weight = 0.533718784270983D;
        // 
        // xrTableCell26
        // 
        this.xrTableCell26.Dpi = 100F;
        this.xrTableCell26.Name = "xrTableCell26";
        this.xrTableCell26.StylePriority.UseTextAlignment = false;
        this.xrTableCell26.Text = "F.aid";
        this.xrTableCell26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell26.Weight = 0.533718784270983D;
        // 
        // xrTableCell159
        // 
        this.xrTableCell159.Dpi = 100F;
        this.xrTableCell159.Name = "xrTableCell159";
        this.xrTableCell159.StylePriority.UseTextAlignment = false;
        this.xrTableCell159.Text = "Total";
        this.xrTableCell159.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell159.Weight = 0.533718784270983D;
        // 
        // xrTableCell234
        // 
        this.xrTableCell234.Dpi = 100F;
        this.xrTableCell234.Name = "xrTableCell234";
        this.xrTableCell234.StylePriority.UseTextAlignment = false;
        this.xrTableCell234.Text = "Capital";
        this.xrTableCell234.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell234.Weight = 0.533718784270983D;
        // 
        // xrTableCell240
        // 
        this.xrTableCell240.Dpi = 100F;
        this.xrTableCell240.Name = "xrTableCell240";
        this.xrTableCell240.StylePriority.UseTextAlignment = false;
        this.xrTableCell240.Text = "Revenue";
        this.xrTableCell240.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell240.Weight = 0.533718784270983D;
        // 
        // xrTableCell241
        // 
        this.xrTableCell241.Dpi = 100F;
        this.xrTableCell241.Name = "xrTableCell241";
        this.xrTableCell241.StylePriority.UseTextAlignment = false;
        this.xrTableCell241.Text = "Local";
        this.xrTableCell241.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell241.Weight = 0.533718784270983D;
        // 
        // xrTableCell242
        // 
        this.xrTableCell242.Dpi = 100F;
        this.xrTableCell242.Name = "xrTableCell242";
        this.xrTableCell242.StylePriority.UseTextAlignment = false;
        this.xrTableCell242.Text = "F.aid";
        this.xrTableCell242.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell242.Weight = 0.533718784270983D;
        // 
        // xrTableCell243
        // 
        this.xrTableCell243.Dpi = 100F;
        this.xrTableCell243.Name = "xrTableCell243";
        this.xrTableCell243.StylePriority.UseTextAlignment = false;
        this.xrTableCell243.Text = "Total";
        this.xrTableCell243.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell243.Weight = 0.533718784270983D;
        // 
        // xrTableCell27
        // 
        this.xrTableCell27.Dpi = 100F;
        this.xrTableCell27.Name = "xrTableCell27";
        this.xrTableCell27.StylePriority.UseTextAlignment = false;
        this.xrTableCell27.Text = "Capital";
        this.xrTableCell27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell27.Weight = 0.533718784270983D;
        // 
        // xrTableCell28
        // 
        this.xrTableCell28.Dpi = 100F;
        this.xrTableCell28.Name = "xrTableCell28";
        this.xrTableCell28.StylePriority.UseTextAlignment = false;
        this.xrTableCell28.Text = "Revenue";
        this.xrTableCell28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell28.Weight = 0.533718784270983D;
        // 
        // xrTableCell29
        // 
        this.xrTableCell29.Dpi = 100F;
        this.xrTableCell29.Name = "xrTableCell29";
        this.xrTableCell29.StylePriority.UseTextAlignment = false;
        this.xrTableCell29.Text = "Local";
        this.xrTableCell29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell29.Weight = 0.533718784270984D;
        // 
        // xrTableCell30
        // 
        this.xrTableCell30.Dpi = 100F;
        this.xrTableCell30.Name = "xrTableCell30";
        this.xrTableCell30.StylePriority.UseTextAlignment = false;
        this.xrTableCell30.Text = "F.aid";
        this.xrTableCell30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell30.Weight = 0.533718784270984D;
        // 
        // xrTableCell31
        // 
        this.xrTableCell31.Dpi = 100F;
        this.xrTableCell31.Name = "xrTableCell31";
        this.xrTableCell31.StylePriority.UseTextAlignment = false;
        this.xrTableCell31.Text = "Total";
        this.xrTableCell31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell31.Weight = 0.533718774229001D;
        // 
        // xrTableCell162
        // 
        this.xrTableCell162.Dpi = 100F;
        this.xrTableCell162.Name = "xrTableCell162";
        this.xrTableCell162.StylePriority.UseTextAlignment = false;
        this.xrTableCell162.Text = "Capital";
        this.xrTableCell162.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell162.Weight = 0.533718774229001D;
        // 
        // xrTableCell166
        // 
        this.xrTableCell166.Dpi = 100F;
        this.xrTableCell166.Name = "xrTableCell166";
        this.xrTableCell166.StylePriority.UseTextAlignment = false;
        this.xrTableCell166.Text = "Revenue";
        this.xrTableCell166.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell166.Weight = 0.533718774229001D;
        // 
        // xrTableCell165
        // 
        this.xrTableCell165.Dpi = 100F;
        this.xrTableCell165.Name = "xrTableCell165";
        this.xrTableCell165.StylePriority.UseTextAlignment = false;
        this.xrTableCell165.Text = "Local";
        this.xrTableCell165.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell165.Weight = 0.533718774229001D;
        // 
        // xrTableCell164
        // 
        this.xrTableCell164.Dpi = 100F;
        this.xrTableCell164.Name = "xrTableCell164";
        this.xrTableCell164.StylePriority.UseTextAlignment = false;
        this.xrTableCell164.Text = "F.aid";
        this.xrTableCell164.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell164.Weight = 0.533718774229001D;
        // 
        // xrTableCell163
        // 
        this.xrTableCell163.Dpi = 100F;
        this.xrTableCell163.Name = "xrTableCell163";
        this.xrTableCell163.StylePriority.UseTextAlignment = false;
        this.xrTableCell163.Text = "Total";
        this.xrTableCell163.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell163.Weight = 0.533718774229001D;
        // 
        // xrTableCell33
        // 
        this.xrTableCell33.Dpi = 100F;
        this.xrTableCell33.Name = "xrTableCell33";
        this.xrTableCell33.StylePriority.UseTextAlignment = false;
        this.xrTableCell33.Text = "Alloc";
        this.xrTableCell33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell33.Weight = 0.533718774229001D;
        // 
        // xrTableCell34
        // 
        this.xrTableCell34.Dpi = 100F;
        this.xrTableCell34.Name = "xrTableCell34";
        this.xrTableCell34.StylePriority.UseTextAlignment = false;
        this.xrTableCell34.Text = "Release";
        this.xrTableCell34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell34.Weight = 0.533718774229D;
        // 
        // xrTableCell18
        // 
        this.xrTableCell18.Dpi = 100F;
        this.xrTableCell18.Name = "xrTableCell18";
        this.xrTableCell18.StylePriority.UseTextAlignment = false;
        this.xrTableCell18.Text = "Alloc";
        this.xrTableCell18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell18.Weight = 0.533718774229001D;
        // 
        // xrTableCell35
        // 
        this.xrTableCell35.Dpi = 100F;
        this.xrTableCell35.Name = "xrTableCell35";
        this.xrTableCell35.StylePriority.UseTextAlignment = false;
        this.xrTableCell35.Text = "Release";
        this.xrTableCell35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell35.Weight = 0.533718774229001D;
        // 
        // xrTableCell36
        // 
        this.xrTableCell36.Dpi = 100F;
        this.xrTableCell36.Name = "xrTableCell36";
        this.xrTableCell36.StylePriority.UseTextAlignment = false;
        this.xrTableCell36.Text = "Alloc";
        this.xrTableCell36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell36.Weight = 0.533718774229D;
        // 
        // xrTableCell37
        // 
        this.xrTableCell37.Dpi = 100F;
        this.xrTableCell37.Name = "xrTableCell37";
        this.xrTableCell37.StylePriority.UseTextAlignment = false;
        this.xrTableCell37.Text = "Release";
        this.xrTableCell37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell37.Weight = 0.533718774229D;
        // 
        // xrTableCell38
        // 
        this.xrTableCell38.Dpi = 100F;
        this.xrTableCell38.Name = "xrTableCell38";
        this.xrTableCell38.StylePriority.UseTextAlignment = false;
        this.xrTableCell38.Text = "Capital";
        this.xrTableCell38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell38.Weight = 0.533718774229D;
        // 
        // xrTableCell160
        // 
        this.xrTableCell160.Dpi = 100F;
        this.xrTableCell160.Name = "xrTableCell160";
        this.xrTableCell160.StylePriority.UseTextAlignment = false;
        this.xrTableCell160.Text = "Revenue";
        this.xrTableCell160.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell160.Weight = 0.533718774229D;
        // 
        // xrTableCell39
        // 
        this.xrTableCell39.Dpi = 100F;
        this.xrTableCell39.Name = "xrTableCell39";
        this.xrTableCell39.StylePriority.UseTextAlignment = false;
        this.xrTableCell39.Text = "Local";
        this.xrTableCell39.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell39.Weight = 0.533718774228999D;
        // 
        // xrTableCell40
        // 
        this.xrTableCell40.Dpi = 100F;
        this.xrTableCell40.Name = "xrTableCell40";
        this.xrTableCell40.StylePriority.UseTextAlignment = false;
        this.xrTableCell40.Text = "F.aid";
        this.xrTableCell40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell40.Weight = 0.533718774229D;
        // 
        // xrTableCell41
        // 
        this.xrTableCell41.Dpi = 100F;
        this.xrTableCell41.Name = "xrTableCell41";
        this.xrTableCell41.StylePriority.UseTextAlignment = false;
        this.xrTableCell41.Text = "Total";
        this.xrTableCell41.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell41.Weight = 0.533718774229D;
        // 
        // xrTableCell42
        // 
        this.xrTableCell42.Dpi = 100F;
        this.xrTableCell42.Name = "xrTableCell42";
        this.xrTableCell42.StylePriority.UseTextAlignment = false;
        this.xrTableCell42.Text = "Capital";
        this.xrTableCell42.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell42.Weight = 0.53371884566674D;
        // 
        // xrTableCell43
        // 
        this.xrTableCell43.Dpi = 100F;
        this.xrTableCell43.Name = "xrTableCell43";
        this.xrTableCell43.StylePriority.UseTextAlignment = false;
        this.xrTableCell43.Text = "Revenue";
        this.xrTableCell43.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell43.Weight = 0.533718775071325D;
        // 
        // xrTableCell44
        // 
        this.xrTableCell44.Dpi = 100F;
        this.xrTableCell44.Name = "xrTableCell44";
        this.xrTableCell44.StylePriority.UseTextAlignment = false;
        this.xrTableCell44.Text = "Local";
        this.xrTableCell44.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell44.Weight = 0.533718773386674D;
        // 
        // xrTableCell45
        // 
        this.xrTableCell45.Dpi = 100F;
        this.xrTableCell45.Name = "xrTableCell45";
        this.xrTableCell45.StylePriority.UseTextAlignment = false;
        this.xrTableCell45.Text = "F.aid";
        this.xrTableCell45.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell45.Weight = 0.53371884566674D;
        // 
        // xrTableCell46
        // 
        this.xrTableCell46.Dpi = 100F;
        this.xrTableCell46.Name = "xrTableCell46";
        this.xrTableCell46.StylePriority.UseTextAlignment = false;
        this.xrTableCell46.Text = "Total";
        this.xrTableCell46.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell46.Weight = 0.53371884566674D;
        // 
        // xrTableCell168
        // 
        this.xrTableCell168.Dpi = 100F;
        this.xrTableCell168.Name = "xrTableCell168";
        this.xrTableCell168.StylePriority.UseTextAlignment = false;
        this.xrTableCell168.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        this.xrTableCell168.Weight = 1.51688503363962D;
        // 
        // xrTable3
        // 
        this.xrTable3.BackColor = System.Drawing.Color.LightGray;
        this.xrTable3.Dpi = 100F;
        this.xrTable3.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
        this.xrTable3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 90F);
        this.xrTable3.Name = "xrTable3";
        this.xrTable3.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
        this.xrTable3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow3});
        this.xrTable3.SizeF = new System.Drawing.SizeF(3599F, 30F);
        this.xrTable3.StylePriority.UseBackColor = false;
        this.xrTable3.StylePriority.UseFont = false;
        this.xrTable3.StylePriority.UsePadding = false;
        this.xrTable3.StylePriority.UseTextAlignment = false;
        this.xrTable3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrTableRow3
        // 
        this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell48,
            this.xrTableCell280,
            this.xrTableCell281,
            this.xrTableCell282,
            this.xrTableCell283,
            this.xrTableCell49,
            this.xrTableCell50,
            this.xrTableCell51,
            this.xrTableCell52,
            this.xrTableCell53,
            this.xrTableCell54,
            this.xrTableCell55,
            this.xrTableCell56,
            this.xrTableCell57,
            this.xrTableCell58,
            this.xrTableCell59,
            this.xrTableCell60,
            this.xrTableCell61,
            this.xrTableCell62,
            this.xrTableCell63,
            this.xrTableCell64,
            this.xrTableCell235,
            this.xrTableCell244,
            this.xrTableCell245,
            this.xrTableCell246,
            this.xrTableCell247,
            this.xrTableCell65,
            this.xrTableCell66,
            this.xrTableCell67,
            this.xrTableCell68,
            this.xrTableCell69,
            this.xrTableCell70,
            this.xrTableCell71,
            this.xrTableCell72,
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
            this.xrTableCell84,
            this.xrTableCell169,
            this.xrTableCell170,
            this.xrTableCell171,
            this.xrTableCell172,
            this.xrTableCell173,
            this.xrTableCell174,
            this.xrTableCell175});
        this.xrTableRow3.Dpi = 100F;
        this.xrTableRow3.Name = "xrTableRow3";
        this.xrTableRow3.Weight = 1D;
        // 
        // xrTableCell48
        // 
        this.xrTableCell48.Dpi = 100F;
        this.xrTableCell48.Name = "xrTableCell48";
        this.xrTableCell48.StylePriority.UseTextAlignment = false;
        this.xrTableCell48.Text = "1";
        this.xrTableCell48.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell48.Weight = 0.374539509323725D;
        // 
        // xrTableCell280
        // 
        this.xrTableCell280.Dpi = 100F;
        this.xrTableCell280.Name = "xrTableCell280";
        this.xrTableCell280.StylePriority.UseTextAlignment = false;
        this.xrTableCell280.Text = "2";
        this.xrTableCell280.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell280.Weight = 1.1704359329145779D;
        // 
        // xrTableCell281
        // 
        this.xrTableCell281.Dpi = 100F;
        this.xrTableCell281.Name = "xrTableCell281";
        this.xrTableCell281.StylePriority.UseTextAlignment = false;
        this.xrTableCell281.Text = "3";
        this.xrTableCell281.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell281.Weight = 1.1704359329145779D;
        // 
        // xrTableCell282
        // 
        this.xrTableCell282.Dpi = 100F;
        this.xrTableCell282.Name = "xrTableCell282";
        this.xrTableCell282.StylePriority.UseTextAlignment = false;
        this.xrTableCell282.Text = "4";
        this.xrTableCell282.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell282.Weight = 2.5749590787262275D;
        // 
        // xrTableCell283
        // 
        this.xrTableCell283.Dpi = 100F;
        this.xrTableCell283.Name = "xrTableCell283";
        this.xrTableCell283.StylePriority.UseTextAlignment = false;
        this.xrTableCell283.Text = "5";
        this.xrTableCell283.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell283.Weight = 1.1704359329145782D;
        // 
        // xrTableCell49
        // 
        this.xrTableCell49.Dpi = 100F;
        this.xrTableCell49.Name = "xrTableCell49";
        this.xrTableCell49.StylePriority.UseTextAlignment = false;
        this.xrTableCell49.Text = "6";
        this.xrTableCell49.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell49.Weight = 1.170435935975312D;
        // 
        // xrTableCell50
        // 
        this.xrTableCell50.Dpi = 100F;
        this.xrTableCell50.Name = "xrTableCell50";
        this.xrTableCell50.StylePriority.UseTextAlignment = false;
        this.xrTableCell50.Text = "7";
        this.xrTableCell50.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell50.Weight = 0.533718797860546D;
        // 
        // xrTableCell51
        // 
        this.xrTableCell51.Dpi = 100F;
        this.xrTableCell51.Name = "xrTableCell51";
        this.xrTableCell51.StylePriority.UseTextAlignment = false;
        this.xrTableCell51.Text = "8";
        this.xrTableCell51.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell51.Weight = 0.533718790073738D;
        // 
        // xrTableCell52
        // 
        this.xrTableCell52.Dpi = 100F;
        this.xrTableCell52.Name = "xrTableCell52";
        this.xrTableCell52.StylePriority.UseTextAlignment = false;
        this.xrTableCell52.Text = "9";
        this.xrTableCell52.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell52.Weight = 0.533718768675502D;
        // 
        // xrTableCell53
        // 
        this.xrTableCell53.Dpi = 100F;
        this.xrTableCell53.Name = "xrTableCell53";
        this.xrTableCell53.StylePriority.UseTextAlignment = false;
        this.xrTableCell53.Text = "10";
        this.xrTableCell53.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell53.Weight = 0.53371881467524D;
        // 
        // xrTableCell54
        // 
        this.xrTableCell54.Dpi = 100F;
        this.xrTableCell54.Multiline = true;
        this.xrTableCell54.Name = "xrTableCell54";
        this.xrTableCell54.StylePriority.UseTextAlignment = false;
        this.xrTableCell54.Text = "11";
        this.xrTableCell54.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell54.Weight = 0.533718790372309D;
        // 
        // xrTableCell55
        // 
        this.xrTableCell55.Dpi = 100F;
        this.xrTableCell55.Name = "xrTableCell55";
        this.xrTableCell55.StylePriority.UseTextAlignment = false;
        this.xrTableCell55.Text = "12";
        this.xrTableCell55.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell55.Weight = 0.533718784270983D;
        // 
        // xrTableCell56
        // 
        this.xrTableCell56.Dpi = 100F;
        this.xrTableCell56.Name = "xrTableCell56";
        this.xrTableCell56.StylePriority.UseTextAlignment = false;
        this.xrTableCell56.Text = "13";
        this.xrTableCell56.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell56.Weight = 0.533718784270983D;
        // 
        // xrTableCell57
        // 
        this.xrTableCell57.Dpi = 100F;
        this.xrTableCell57.Name = "xrTableCell57";
        this.xrTableCell57.StylePriority.UseTextAlignment = false;
        this.xrTableCell57.Text = "14";
        this.xrTableCell57.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell57.Weight = 0.533718784270984D;
        // 
        // xrTableCell58
        // 
        this.xrTableCell58.Dpi = 100F;
        this.xrTableCell58.Name = "xrTableCell58";
        this.xrTableCell58.StylePriority.UseTextAlignment = false;
        this.xrTableCell58.Text = "15";
        this.xrTableCell58.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell58.Weight = 0.533718784270983D;
        // 
        // xrTableCell59
        // 
        this.xrTableCell59.Dpi = 100F;
        this.xrTableCell59.Name = "xrTableCell59";
        this.xrTableCell59.StylePriority.UseTextAlignment = false;
        this.xrTableCell59.Text = "16";
        this.xrTableCell59.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell59.Weight = 0.533718784270983D;
        // 
        // xrTableCell60
        // 
        this.xrTableCell60.Dpi = 100F;
        this.xrTableCell60.Name = "xrTableCell60";
        this.xrTableCell60.StylePriority.UseTextAlignment = false;
        this.xrTableCell60.Text = "17";
        this.xrTableCell60.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell60.Weight = 0.533718819989853D;
        // 
        // xrTableCell61
        // 
        this.xrTableCell61.Dpi = 100F;
        this.xrTableCell61.Name = "xrTableCell61";
        this.xrTableCell61.StylePriority.UseTextAlignment = false;
        this.xrTableCell61.Text = "18";
        this.xrTableCell61.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell61.Weight = 0.533718784270984D;
        // 
        // xrTableCell62
        // 
        this.xrTableCell62.Dpi = 100F;
        this.xrTableCell62.Name = "xrTableCell62";
        this.xrTableCell62.StylePriority.UseTextAlignment = false;
        this.xrTableCell62.Text = "19";
        this.xrTableCell62.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell62.Weight = 0.533718784270983D;
        // 
        // xrTableCell63
        // 
        this.xrTableCell63.Dpi = 100F;
        this.xrTableCell63.Name = "xrTableCell63";
        this.xrTableCell63.StylePriority.UseTextAlignment = false;
        this.xrTableCell63.Text = "20";
        this.xrTableCell63.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell63.Weight = 0.533718784270983D;
        // 
        // xrTableCell64
        // 
        this.xrTableCell64.Dpi = 100F;
        this.xrTableCell64.Name = "xrTableCell64";
        this.xrTableCell64.StylePriority.UseTextAlignment = false;
        this.xrTableCell64.Text = "21";
        this.xrTableCell64.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell64.Weight = 0.533718784270983D;
        // 
        // xrTableCell235
        // 
        this.xrTableCell235.Dpi = 100F;
        this.xrTableCell235.Name = "xrTableCell235";
        this.xrTableCell235.StylePriority.UseTextAlignment = false;
        this.xrTableCell235.Text = "22";
        this.xrTableCell235.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell235.Weight = 0.533718784270983D;
        // 
        // xrTableCell244
        // 
        this.xrTableCell244.Dpi = 100F;
        this.xrTableCell244.Name = "xrTableCell244";
        this.xrTableCell244.StylePriority.UseTextAlignment = false;
        this.xrTableCell244.Text = "23";
        this.xrTableCell244.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell244.Weight = 0.533718784270983D;
        // 
        // xrTableCell245
        // 
        this.xrTableCell245.Dpi = 100F;
        this.xrTableCell245.Name = "xrTableCell245";
        this.xrTableCell245.StylePriority.UseTextAlignment = false;
        this.xrTableCell245.Text = "24";
        this.xrTableCell245.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell245.Weight = 0.533718784270983D;
        // 
        // xrTableCell246
        // 
        this.xrTableCell246.Dpi = 100F;
        this.xrTableCell246.Name = "xrTableCell246";
        this.xrTableCell246.StylePriority.UseTextAlignment = false;
        this.xrTableCell246.Text = "25";
        this.xrTableCell246.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell246.Weight = 0.533718784270983D;
        // 
        // xrTableCell247
        // 
        this.xrTableCell247.Dpi = 100F;
        this.xrTableCell247.Name = "xrTableCell247";
        this.xrTableCell247.StylePriority.UseTextAlignment = false;
        this.xrTableCell247.Text = "26";
        this.xrTableCell247.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell247.Weight = 0.533718784270983D;
        // 
        // xrTableCell65
        // 
        this.xrTableCell65.Dpi = 100F;
        this.xrTableCell65.Name = "xrTableCell65";
        this.xrTableCell65.StylePriority.UseTextAlignment = false;
        this.xrTableCell65.Text = "27";
        this.xrTableCell65.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell65.Weight = 0.533718784270983D;
        // 
        // xrTableCell66
        // 
        this.xrTableCell66.Dpi = 100F;
        this.xrTableCell66.Name = "xrTableCell66";
        this.xrTableCell66.StylePriority.UseTextAlignment = false;
        this.xrTableCell66.Text = "28";
        this.xrTableCell66.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell66.Weight = 0.533718784270984D;
        // 
        // xrTableCell67
        // 
        this.xrTableCell67.Dpi = 100F;
        this.xrTableCell67.Name = "xrTableCell67";
        this.xrTableCell67.StylePriority.UseTextAlignment = false;
        this.xrTableCell67.Text = "29";
        this.xrTableCell67.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell67.Weight = 0.533718784270984D;
        // 
        // xrTableCell68
        // 
        this.xrTableCell68.Dpi = 100F;
        this.xrTableCell68.Name = "xrTableCell68";
        this.xrTableCell68.StylePriority.UseTextAlignment = false;
        this.xrTableCell68.Text = "30";
        this.xrTableCell68.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell68.Weight = 0.533718774229001D;
        // 
        // xrTableCell69
        // 
        this.xrTableCell69.Dpi = 100F;
        this.xrTableCell69.Name = "xrTableCell69";
        this.xrTableCell69.StylePriority.UseTextAlignment = false;
        this.xrTableCell69.Text = "31";
        this.xrTableCell69.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell69.Weight = 0.533718774229001D;
        // 
        // xrTableCell70
        // 
        this.xrTableCell70.Dpi = 100F;
        this.xrTableCell70.Name = "xrTableCell70";
        this.xrTableCell70.StylePriority.UseTextAlignment = false;
        this.xrTableCell70.Text = "32";
        this.xrTableCell70.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell70.Weight = 0.533718774229D;
        // 
        // xrTableCell71
        // 
        this.xrTableCell71.Dpi = 100F;
        this.xrTableCell71.Name = "xrTableCell71";
        this.xrTableCell71.StylePriority.UseTextAlignment = false;
        this.xrTableCell71.Text = "33";
        this.xrTableCell71.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell71.Weight = 0.533718774229001D;
        // 
        // xrTableCell72
        // 
        this.xrTableCell72.Dpi = 100F;
        this.xrTableCell72.Name = "xrTableCell72";
        this.xrTableCell72.StylePriority.UseTextAlignment = false;
        this.xrTableCell72.Text = "34";
        this.xrTableCell72.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell72.Weight = 0.533718774229001D;
        // 
        // xrTableCell73
        // 
        this.xrTableCell73.Dpi = 100F;
        this.xrTableCell73.Name = "xrTableCell73";
        this.xrTableCell73.StylePriority.UseTextAlignment = false;
        this.xrTableCell73.Text = "35";
        this.xrTableCell73.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell73.Weight = 0.533718774229D;
        // 
        // xrTableCell74
        // 
        this.xrTableCell74.Dpi = 100F;
        this.xrTableCell74.Name = "xrTableCell74";
        this.xrTableCell74.StylePriority.UseTextAlignment = false;
        this.xrTableCell74.Text = "36";
        this.xrTableCell74.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell74.Weight = 0.533718774229D;
        // 
        // xrTableCell75
        // 
        this.xrTableCell75.Dpi = 100F;
        this.xrTableCell75.Name = "xrTableCell75";
        this.xrTableCell75.StylePriority.UseTextAlignment = false;
        this.xrTableCell75.Text = "37";
        this.xrTableCell75.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell75.Weight = 0.533718774229D;
        // 
        // xrTableCell76
        // 
        this.xrTableCell76.Dpi = 100F;
        this.xrTableCell76.Name = "xrTableCell76";
        this.xrTableCell76.StylePriority.UseTextAlignment = false;
        this.xrTableCell76.Text = "38";
        this.xrTableCell76.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell76.Weight = 0.533718774228999D;
        // 
        // xrTableCell77
        // 
        this.xrTableCell77.Dpi = 100F;
        this.xrTableCell77.Name = "xrTableCell77";
        this.xrTableCell77.StylePriority.UseTextAlignment = false;
        this.xrTableCell77.Text = "39";
        this.xrTableCell77.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell77.Weight = 0.533718774229D;
        // 
        // xrTableCell78
        // 
        this.xrTableCell78.Dpi = 100F;
        this.xrTableCell78.Name = "xrTableCell78";
        this.xrTableCell78.StylePriority.UseTextAlignment = false;
        this.xrTableCell78.Text = "40";
        this.xrTableCell78.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell78.Weight = 0.533718774229D;
        // 
        // xrTableCell79
        // 
        this.xrTableCell79.Dpi = 100F;
        this.xrTableCell79.Name = "xrTableCell79";
        this.xrTableCell79.StylePriority.UseTextAlignment = false;
        this.xrTableCell79.Text = "41";
        this.xrTableCell79.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell79.Weight = 0.53371884566674D;
        // 
        // xrTableCell80
        // 
        this.xrTableCell80.Dpi = 100F;
        this.xrTableCell80.Name = "xrTableCell80";
        this.xrTableCell80.StylePriority.UseTextAlignment = false;
        this.xrTableCell80.Text = "42";
        this.xrTableCell80.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell80.Weight = 0.533718775071325D;
        // 
        // xrTableCell81
        // 
        this.xrTableCell81.Dpi = 100F;
        this.xrTableCell81.Name = "xrTableCell81";
        this.xrTableCell81.StylePriority.UseTextAlignment = false;
        this.xrTableCell81.Text = "43";
        this.xrTableCell81.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell81.Weight = 0.533718773386674D;
        // 
        // xrTableCell82
        // 
        this.xrTableCell82.Dpi = 100F;
        this.xrTableCell82.Name = "xrTableCell82";
        this.xrTableCell82.StylePriority.UseTextAlignment = false;
        this.xrTableCell82.Text = "44";
        this.xrTableCell82.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell82.Weight = 0.53371884566674D;
        // 
        // xrTableCell83
        // 
        this.xrTableCell83.Dpi = 100F;
        this.xrTableCell83.Name = "xrTableCell83";
        this.xrTableCell83.StylePriority.UseTextAlignment = false;
        this.xrTableCell83.Text = "45";
        this.xrTableCell83.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell83.Weight = 0.53371884566674D;
        // 
        // xrTableCell84
        // 
        this.xrTableCell84.Dpi = 100F;
        this.xrTableCell84.Name = "xrTableCell84";
        this.xrTableCell84.StylePriority.UseTextAlignment = false;
        this.xrTableCell84.Text = "46";
        this.xrTableCell84.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell84.Weight = 0.53371884566674D;
        // 
        // xrTableCell169
        // 
        this.xrTableCell169.Dpi = 100F;
        this.xrTableCell169.Name = "xrTableCell169";
        this.xrTableCell169.StylePriority.UseTextAlignment = false;
        this.xrTableCell169.Text = "47";
        this.xrTableCell169.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell169.Weight = 0.53371884566674D;
        // 
        // xrTableCell170
        // 
        this.xrTableCell170.Dpi = 100F;
        this.xrTableCell170.Name = "xrTableCell170";
        this.xrTableCell170.StylePriority.UseTextAlignment = false;
        this.xrTableCell170.Text = "48";
        this.xrTableCell170.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell170.Weight = 0.53371884566674D;
        // 
        // xrTableCell171
        // 
        this.xrTableCell171.Dpi = 100F;
        this.xrTableCell171.Name = "xrTableCell171";
        this.xrTableCell171.StylePriority.UseTextAlignment = false;
        this.xrTableCell171.Text = "49";
        this.xrTableCell171.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell171.Weight = 0.53371884566674D;
        // 
        // xrTableCell172
        // 
        this.xrTableCell172.Dpi = 100F;
        this.xrTableCell172.Name = "xrTableCell172";
        this.xrTableCell172.StylePriority.UseTextAlignment = false;
        this.xrTableCell172.Text = "50";
        this.xrTableCell172.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell172.Weight = 0.53371884566674D;
        // 
        // xrTableCell173
        // 
        this.xrTableCell173.Dpi = 100F;
        this.xrTableCell173.Name = "xrTableCell173";
        this.xrTableCell173.StylePriority.UseTextAlignment = false;
        this.xrTableCell173.Text = "51";
        this.xrTableCell173.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell173.Weight = 0.53371884566674D;
        // 
        // xrTableCell174
        // 
        this.xrTableCell174.Dpi = 100F;
        this.xrTableCell174.Name = "xrTableCell174";
        this.xrTableCell174.StylePriority.UseTextAlignment = false;
        this.xrTableCell174.Text = "52";
        this.xrTableCell174.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell174.Weight = 0.53371884566674D;
        // 
        // xrTableCell175
        // 
        this.xrTableCell175.Dpi = 100F;
        this.xrTableCell175.Name = "xrTableCell175";
        this.xrTableCell175.StylePriority.UseTextAlignment = false;
        this.xrTableCell175.Text = "53";
        this.xrTableCell175.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell175.Weight = 1.51688505317353D;
        // 
        // xrTable5
        // 
        this.xrTable5.BackColor = System.Drawing.Color.White;
        this.xrTable5.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTable5.Dpi = 100F;
        this.xrTable5.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Bold);
        this.xrTable5.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrTable5.Name = "xrTable5";
        this.xrTable5.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
        this.xrTable5.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow5});
        this.xrTable5.SizeF = new System.Drawing.SizeF(3599F, 30F);
        this.xrTable5.StylePriority.UseBackColor = false;
        this.xrTable5.StylePriority.UseBorders = false;
        this.xrTable5.StylePriority.UseFont = false;
        this.xrTable5.StylePriority.UsePadding = false;
        this.xrTable5.StylePriority.UseTextAlignment = false;
        this.xrTable5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrTableRow5
        // 
        this.xrTableRow5.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell122,
            this.xrTableCell268,
            this.xrTableCell269,
            this.xrTableCell270,
            this.xrTableCell271,
            this.xrTableCell123,
            this.xrTableCell124,
            this.xrTableCell125,
            this.xrTableCell126,
            this.xrTableCell127,
            this.xrTableCell128,
            this.xrTableCell181,
            this.xrTableCell182,
            this.xrTableCell183,
            this.xrTableCell184,
            this.xrTableCell185,
            this.xrTableCell129,
            this.xrTableCell130,
            this.xrTableCell131,
            this.xrTableCell132,
            this.xrTableCell133,
            this.xrTableCell238,
            this.xrTableCell252,
            this.xrTableCell253,
            this.xrTableCell254,
            this.xrTableCell255,
            this.xrTableCell134,
            this.xrTableCell135,
            this.xrTableCell136,
            this.xrTableCell137,
            this.xrTableCell138,
            this.xrTableCell139,
            this.xrTableCell140,
            this.xrTableCell141,
            this.xrTableCell142,
            this.xrTableCell143,
            this.xrTableCell144,
            this.xrTableCell145,
            this.xrTableCell146,
            this.xrTableCell147,
            this.xrTableCell148,
            this.xrTableCell149,
            this.xrTableCell153,
            this.xrTableCell154,
            this.xrTableCell155,
            this.xrTableCell156,
            this.xrTableCell157,
            this.xrTableCell152,
            this.xrTableCell158,
            this.xrTableCell186,
            this.xrTableCell187,
            this.xrTableCell188,
            this.xrTableCell189});
        this.xrTableRow5.Dpi = 100F;
        this.xrTableRow5.Name = "xrTableRow5";
        this.xrTableRow5.Weight = 1D;
        // 
        // xrTableCell122
        // 
        this.xrTableCell122.Dpi = 100F;
        this.xrTableCell122.Name = "xrTableCell122";
        this.xrTableCell122.StylePriority.UseTextAlignment = false;
        this.xrTableCell122.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell122.Weight = 0.374539509323725D;
        // 
        // xrTableCell268
        // 
        this.xrTableCell268.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
        this.xrTableCell268.Dpi = 100F;
        this.xrTableCell268.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
        this.xrTableCell268.Name = "xrTableCell268";
        this.xrTableCell268.StylePriority.UseBorders = false;
        this.xrTableCell268.StylePriority.UseFont = false;
        this.xrTableCell268.StylePriority.UseTextAlignment = false;
        this.xrTableCell268.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
        this.xrTableCell268.Weight = 1.1704359344182254D;
        // 
        // xrTableCell269
        // 
        this.xrTableCell269.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
        this.xrTableCell269.Dpi = 100F;
        this.xrTableCell269.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
        this.xrTableCell269.Name = "xrTableCell269";
        this.xrTableCell269.StylePriority.UseBorders = false;
        this.xrTableCell269.StylePriority.UseFont = false;
        this.xrTableCell269.StylePriority.UseTextAlignment = false;
        this.xrTableCell269.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
        this.xrTableCell269.Weight = 1.1704359344182254D;
        // 
        // xrTableCell270
        // 
        this.xrTableCell270.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
        this.xrTableCell270.Dpi = 100F;
        this.xrTableCell270.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
        this.xrTableCell270.Name = "xrTableCell270";
        this.xrTableCell270.StylePriority.UseBorders = false;
        this.xrTableCell270.StylePriority.UseFont = false;
        this.xrTableCell270.StylePriority.UseTextAlignment = false;
        this.xrTableCell270.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
        this.xrTableCell270.Weight = 2.5749590777239355D;
        // 
        // xrTableCell271
        // 
        this.xrTableCell271.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
        this.xrTableCell271.Dpi = 100F;
        this.xrTableCell271.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
        this.xrTableCell271.Name = "xrTableCell271";
        this.xrTableCell271.StylePriority.UseBorders = false;
        this.xrTableCell271.StylePriority.UseFont = false;
        this.xrTableCell271.StylePriority.UseTextAlignment = false;
        this.xrTableCell271.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
        this.xrTableCell271.Weight = 1.1704359344182251D;
        // 
        // xrTableCell123
        // 
        this.xrTableCell123.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell123.Dpi = 100F;
        this.xrTableCell123.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
        this.xrTableCell123.Name = "xrTableCell123";
        this.xrTableCell123.StylePriority.UseBorders = false;
        this.xrTableCell123.StylePriority.UseFont = false;
        this.xrTableCell123.StylePriority.UseTextAlignment = false;
        this.xrTableCell123.Text = "Total";
        this.xrTableCell123.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
        this.xrTableCell123.Weight = 1.1704359369776047D;
        // 
        // xrTableCell124
        // 
        this.xrTableCell124.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ApproveCapitalAmount")});
        this.xrTableCell124.Dpi = 100F;
        this.xrTableCell124.Name = "xrTableCell124";
        this.xrTableCell124.StylePriority.UseFont = false;
        this.xrTableCell124.StylePriority.UseTextAlignment = false;
        xrSummary2.FormatString = "{0:#,#}";
        xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell124.Summary = xrSummary2;
        this.xrTableCell124.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell124.Weight = 0.533718797860546D;
        // 
        // xrTableCell125
        // 
        this.xrTableCell125.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ApproveRevenueAmount")});
        this.xrTableCell125.Dpi = 100F;
        this.xrTableCell125.Name = "xrTableCell125";
        this.xrTableCell125.StylePriority.UseTextAlignment = false;
        xrSummary3.FormatString = "{0:#,#}";
        xrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell125.Summary = xrSummary3;
        this.xrTableCell125.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell125.Weight = 0.533718790073738D;
        // 
        // xrTableCell126
        // 
        this.xrTableCell126.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ApproveLocalAmount")});
        this.xrTableCell126.Dpi = 100F;
        this.xrTableCell126.Name = "xrTableCell126";
        this.xrTableCell126.StylePriority.UseTextAlignment = false;
        xrSummary4.FormatString = "{0:#,#}";
        xrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell126.Summary = xrSummary4;
        this.xrTableCell126.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell126.Weight = 0.533718768675502D;
        // 
        // xrTableCell127
        // 
        this.xrTableCell127.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ApproveForignFundAmount")});
        this.xrTableCell127.Dpi = 100F;
        this.xrTableCell127.Name = "xrTableCell127";
        this.xrTableCell127.StylePriority.UseTextAlignment = false;
        xrSummary5.FormatString = "{0:#,#}";
        xrSummary5.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell127.Summary = xrSummary5;
        this.xrTableCell127.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell127.Weight = 0.53371881467524D;
        // 
        // xrTableCell128
        // 
        this.xrTableCell128.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ApproveTotalAmount")});
        this.xrTableCell128.Dpi = 100F;
        this.xrTableCell128.Multiline = true;
        this.xrTableCell128.Name = "xrTableCell128";
        this.xrTableCell128.StylePriority.UseTextAlignment = false;
        xrSummary6.FormatString = "{0:#,#}";
        xrSummary6.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell128.Summary = xrSummary6;
        this.xrTableCell128.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell128.Weight = 0.533718790372309D;
        // 
        // xrTableCell181
        // 
        this.xrTableCell181.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ExpensePYJCapitalAmount")});
        this.xrTableCell181.Dpi = 100F;
        this.xrTableCell181.Name = "xrTableCell181";
        this.xrTableCell181.StylePriority.UseTextAlignment = false;
        xrSummary7.FormatString = "{0:#,#}";
        xrSummary7.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell181.Summary = xrSummary7;
        this.xrTableCell181.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell181.Weight = 0.533718790372309D;
        // 
        // xrTableCell182
        // 
        this.xrTableCell182.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ExpensePYJRevenueAmount")});
        this.xrTableCell182.Dpi = 100F;
        this.xrTableCell182.Name = "xrTableCell182";
        this.xrTableCell182.StylePriority.UseTextAlignment = false;
        xrSummary8.FormatString = "{0:#,#}";
        xrSummary8.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell182.Summary = xrSummary8;
        this.xrTableCell182.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell182.Weight = 0.533718790372309D;
        // 
        // xrTableCell183
        // 
        this.xrTableCell183.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ExpensePYJLocalAmount")});
        this.xrTableCell183.Dpi = 100F;
        this.xrTableCell183.Name = "xrTableCell183";
        this.xrTableCell183.StylePriority.UseTextAlignment = false;
        xrSummary9.FormatString = "{0:#,#}";
        xrSummary9.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell183.Summary = xrSummary9;
        this.xrTableCell183.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell183.Weight = 0.533718790372309D;
        // 
        // xrTableCell184
        // 
        this.xrTableCell184.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ExpensePYJForignFundAmount")});
        this.xrTableCell184.Dpi = 100F;
        this.xrTableCell184.Name = "xrTableCell184";
        this.xrTableCell184.StylePriority.UseTextAlignment = false;
        xrSummary10.FormatString = "{0:#,#}";
        xrSummary10.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell184.Summary = xrSummary10;
        this.xrTableCell184.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell184.Weight = 0.533718790372309D;
        // 
        // xrTableCell185
        // 
        this.xrTableCell185.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ExpensePYJTotalAmount")});
        this.xrTableCell185.Dpi = 100F;
        this.xrTableCell185.Name = "xrTableCell185";
        this.xrTableCell185.StylePriority.UseTextAlignment = false;
        xrSummary11.FormatString = "{0:#,#}";
        xrSummary11.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell185.Summary = xrSummary11;
        this.xrTableCell185.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell185.Weight = 0.533718790372309D;
        // 
        // xrTableCell129
        // 
        this.xrTableCell129.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.AllocationCapitalAmount")});
        this.xrTableCell129.Dpi = 100F;
        this.xrTableCell129.Name = "xrTableCell129";
        this.xrTableCell129.StylePriority.UseTextAlignment = false;
        xrSummary12.FormatString = "{0:#,#}";
        xrSummary12.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell129.Summary = xrSummary12;
        this.xrTableCell129.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell129.Weight = 0.533718784270983D;
        // 
        // xrTableCell130
        // 
        this.xrTableCell130.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.AllocationRevenueAmount")});
        this.xrTableCell130.Dpi = 100F;
        this.xrTableCell130.Name = "xrTableCell130";
        this.xrTableCell130.StylePriority.UseTextAlignment = false;
        xrSummary13.FormatString = "{0:#,#}";
        xrSummary13.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell130.Summary = xrSummary13;
        this.xrTableCell130.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell130.Weight = 0.533718784270983D;
        // 
        // xrTableCell131
        // 
        this.xrTableCell131.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.AllocationLocalAmount")});
        this.xrTableCell131.Dpi = 100F;
        this.xrTableCell131.Name = "xrTableCell131";
        this.xrTableCell131.StylePriority.UseTextAlignment = false;
        xrSummary14.FormatString = "{0:#,#}";
        xrSummary14.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell131.Summary = xrSummary14;
        this.xrTableCell131.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell131.Weight = 0.533718784270984D;
        // 
        // xrTableCell132
        // 
        this.xrTableCell132.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.AllocationForignFundAmount")});
        this.xrTableCell132.Dpi = 100F;
        this.xrTableCell132.Name = "xrTableCell132";
        this.xrTableCell132.StylePriority.UseTextAlignment = false;
        xrSummary15.FormatString = "{0:#,#}";
        xrSummary15.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell132.Summary = xrSummary15;
        this.xrTableCell132.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell132.Weight = 0.533718784270983D;
        // 
        // xrTableCell133
        // 
        this.xrTableCell133.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.AllocationTotalAmount")});
        this.xrTableCell133.Dpi = 100F;
        this.xrTableCell133.Name = "xrTableCell133";
        this.xrTableCell133.StylePriority.UseTextAlignment = false;
        xrSummary16.FormatString = "{0:#,#}";
        xrSummary16.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell133.Summary = xrSummary16;
        this.xrTableCell133.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell133.Weight = 0.533718784270983D;
        // 
        // xrTableCell238
        // 
        this.xrTableCell238.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.FinalCapitalGrant")});
        this.xrTableCell238.Dpi = 100F;
        this.xrTableCell238.Name = "xrTableCell238";
        this.xrTableCell238.StylePriority.UseTextAlignment = false;
        xrSummary17.FormatString = "{0:#,#}";
        xrSummary17.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell238.Summary = xrSummary17;
        this.xrTableCell238.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell238.Weight = 0.533718784270983D;
        // 
        // xrTableCell252
        // 
        this.xrTableCell252.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.FinalRevenueGrant")});
        this.xrTableCell252.Dpi = 100F;
        this.xrTableCell252.Name = "xrTableCell252";
        this.xrTableCell252.StylePriority.UseTextAlignment = false;
        xrSummary18.FormatString = "{0:#,#}";
        xrSummary18.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell252.Summary = xrSummary18;
        this.xrTableCell252.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell252.Weight = 0.533718784270983D;
        // 
        // xrTableCell253
        // 
        this.xrTableCell253.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.FinalLocalGrant")});
        this.xrTableCell253.Dpi = 100F;
        this.xrTableCell253.Name = "xrTableCell253";
        this.xrTableCell253.StylePriority.UseTextAlignment = false;
        xrSummary19.FormatString = "{0:#,#}";
        xrSummary19.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell253.Summary = xrSummary19;
        this.xrTableCell253.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell253.Weight = 0.533718784270983D;
        // 
        // xrTableCell254
        // 
        this.xrTableCell254.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.FinalForignFundGrant")});
        this.xrTableCell254.Dpi = 100F;
        this.xrTableCell254.Name = "xrTableCell254";
        this.xrTableCell254.StylePriority.UseTextAlignment = false;
        xrSummary20.FormatString = "{0:#,#}";
        xrSummary20.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell254.Summary = xrSummary20;
        this.xrTableCell254.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell254.Weight = 0.533718784270983D;
        // 
        // xrTableCell255
        // 
        this.xrTableCell255.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.FinalTotalGrant")});
        this.xrTableCell255.Dpi = 100F;
        this.xrTableCell255.Name = "xrTableCell255";
        this.xrTableCell255.StylePriority.UseTextAlignment = false;
        xrSummary21.FormatString = "{0:#,#}";
        xrSummary21.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell255.Summary = xrSummary21;
        this.xrTableCell255.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell255.Weight = 0.533718784270983D;
        // 
        // xrTableCell134
        // 
        this.xrTableCell134.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ReleaseCapitalAmount")});
        this.xrTableCell134.Dpi = 100F;
        this.xrTableCell134.Name = "xrTableCell134";
        this.xrTableCell134.StylePriority.UseTextAlignment = false;
        xrSummary22.FormatString = "{0:#,#}";
        xrSummary22.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell134.Summary = xrSummary22;
        this.xrTableCell134.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell134.Weight = 0.533718819989853D;
        // 
        // xrTableCell135
        // 
        this.xrTableCell135.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ReleaseRevenueAmount")});
        this.xrTableCell135.Dpi = 100F;
        this.xrTableCell135.Name = "xrTableCell135";
        this.xrTableCell135.StylePriority.UseTextAlignment = false;
        xrSummary23.FormatString = "{0:#,#}";
        xrSummary23.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell135.Summary = xrSummary23;
        this.xrTableCell135.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell135.Weight = 0.533718784270984D;
        // 
        // xrTableCell136
        // 
        this.xrTableCell136.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ReleseLocalAmount")});
        this.xrTableCell136.Dpi = 100F;
        this.xrTableCell136.Name = "xrTableCell136";
        this.xrTableCell136.StylePriority.UseTextAlignment = false;
        xrSummary24.FormatString = "{0:#,#}";
        xrSummary24.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell136.Summary = xrSummary24;
        this.xrTableCell136.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell136.Weight = 0.533718784270983D;
        // 
        // xrTableCell137
        // 
        this.xrTableCell137.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ReleaseForignFundAmount")});
        this.xrTableCell137.Dpi = 100F;
        this.xrTableCell137.Name = "xrTableCell137";
        this.xrTableCell137.StylePriority.UseTextAlignment = false;
        xrSummary25.FormatString = "{0:#,#}";
        xrSummary25.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell137.Summary = xrSummary25;
        this.xrTableCell137.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell137.Weight = 0.533718784270983D;
        // 
        // xrTableCell138
        // 
        this.xrTableCell138.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ReleseTotalAmount")});
        this.xrTableCell138.Dpi = 100F;
        this.xrTableCell138.Name = "xrTableCell138";
        this.xrTableCell138.StylePriority.UseTextAlignment = false;
        xrSummary26.FormatString = "{0:#,#}";
        xrSummary26.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell138.Summary = xrSummary26;
        this.xrTableCell138.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell138.Weight = 0.533718784270983D;
        // 
        // xrTableCell139
        // 
        this.xrTableCell139.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ExpenseCapitalAmount")});
        this.xrTableCell139.Dpi = 100F;
        this.xrTableCell139.Name = "xrTableCell139";
        this.xrTableCell139.StylePriority.UseTextAlignment = false;
        xrSummary27.FormatString = "{0:#,#}";
        xrSummary27.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell139.Summary = xrSummary27;
        this.xrTableCell139.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell139.Weight = 0.533718784270983D;
        // 
        // xrTableCell140
        // 
        this.xrTableCell140.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ExpenseRevenueAmount")});
        this.xrTableCell140.Dpi = 100F;
        this.xrTableCell140.Name = "xrTableCell140";
        this.xrTableCell140.StylePriority.UseTextAlignment = false;
        xrSummary28.FormatString = "{0:#,#}";
        xrSummary28.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell140.Summary = xrSummary28;
        this.xrTableCell140.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell140.Weight = 0.533718784270984D;
        // 
        // xrTableCell141
        // 
        this.xrTableCell141.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ExpenseLocalAmount")});
        this.xrTableCell141.Dpi = 100F;
        this.xrTableCell141.Name = "xrTableCell141";
        this.xrTableCell141.StylePriority.UseTextAlignment = false;
        xrSummary29.FormatString = "{0:#,#}";
        xrSummary29.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell141.Summary = xrSummary29;
        this.xrTableCell141.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell141.Weight = 0.533718784270984D;
        // 
        // xrTableCell142
        // 
        this.xrTableCell142.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ExpenseForignFundAmount")});
        this.xrTableCell142.Dpi = 100F;
        this.xrTableCell142.Name = "xrTableCell142";
        this.xrTableCell142.StylePriority.UseTextAlignment = false;
        xrSummary30.FormatString = "{0:#,#}";
        xrSummary30.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell142.Summary = xrSummary30;
        this.xrTableCell142.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell142.Weight = 0.533718774229001D;
        // 
        // xrTableCell143
        // 
        this.xrTableCell143.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ExpenseTotalAmount")});
        this.xrTableCell143.Dpi = 100F;
        this.xrTableCell143.Name = "xrTableCell143";
        this.xrTableCell143.StylePriority.UseTextAlignment = false;
        xrSummary31.FormatString = "{0:#,#}";
        xrSummary31.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell143.Summary = xrSummary31;
        this.xrTableCell143.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell143.Weight = 0.533718774229001D;
        // 
        // xrTableCell144
        // 
        this.xrTableCell144.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ExpenseLocalAllocationPercentage")});
        this.xrTableCell144.Dpi = 100F;
        this.xrTableCell144.Name = "xrTableCell144";
        this.xrTableCell144.StylePriority.UseTextAlignment = false;
        xrSummary32.FormatString = "{0:0.00%}";
        xrSummary32.Func = DevExpress.XtraReports.UI.SummaryFunc.Avg;
        xrSummary32.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell144.Summary = xrSummary32;
        this.xrTableCell144.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell144.Weight = 0.533718774229D;
        // 
        // xrTableCell145
        // 
        this.xrTableCell145.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ExpenseLocalReleasePercentage")});
        this.xrTableCell145.Dpi = 100F;
        this.xrTableCell145.Name = "xrTableCell145";
        this.xrTableCell145.StylePriority.UseTextAlignment = false;
        xrSummary33.FormatString = "{0:0.00%}";
        xrSummary33.Func = DevExpress.XtraReports.UI.SummaryFunc.Avg;
        xrSummary33.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell145.Summary = xrSummary33;
        this.xrTableCell145.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell145.Weight = 0.533718774229001D;
        // 
        // xrTableCell146
        // 
        this.xrTableCell146.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ExpenseForeignAidAllocationPercentage")});
        this.xrTableCell146.Dpi = 100F;
        this.xrTableCell146.Name = "xrTableCell146";
        this.xrTableCell146.StylePriority.UseTextAlignment = false;
        xrSummary34.FormatString = "{0:0.00%}";
        xrSummary34.Func = DevExpress.XtraReports.UI.SummaryFunc.Avg;
        xrSummary34.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell146.Summary = xrSummary34;
        this.xrTableCell146.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell146.Weight = 0.533718774229001D;
        // 
        // xrTableCell147
        // 
        this.xrTableCell147.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ExpenseForeignAidReleasePercentage")});
        this.xrTableCell147.Dpi = 100F;
        this.xrTableCell147.Name = "xrTableCell147";
        this.xrTableCell147.StylePriority.UseTextAlignment = false;
        xrSummary35.FormatString = "{0:0.00%}";
        xrSummary35.Func = DevExpress.XtraReports.UI.SummaryFunc.Avg;
        xrSummary35.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell147.Summary = xrSummary35;
        this.xrTableCell147.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell147.Weight = 0.533718774229D;
        // 
        // xrTableCell148
        // 
        this.xrTableCell148.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ExpenseTotalAllocationPercentage")});
        this.xrTableCell148.Dpi = 100F;
        this.xrTableCell148.Name = "xrTableCell148";
        this.xrTableCell148.StylePriority.UseTextAlignment = false;
        xrSummary36.FormatString = "{0:0.00%}";
        xrSummary36.Func = DevExpress.XtraReports.UI.SummaryFunc.Avg;
        xrSummary36.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell148.Summary = xrSummary36;
        this.xrTableCell148.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell148.Weight = 0.533718774229D;
        // 
        // xrTableCell149
        // 
        this.xrTableCell149.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ExpenseTotalReleasePercentage")});
        this.xrTableCell149.Dpi = 100F;
        this.xrTableCell149.Name = "xrTableCell149";
        this.xrTableCell149.StylePriority.UseTextAlignment = false;
        xrSummary37.FormatString = "{0:0.00%}";
        xrSummary37.Func = DevExpress.XtraReports.UI.SummaryFunc.Avg;
        xrSummary37.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell149.Summary = xrSummary37;
        this.xrTableCell149.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell149.Weight = 0.533718774229D;
        // 
        // xrTableCell153
        // 
        this.xrTableCell153.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ThrowForwardCapital")});
        this.xrTableCell153.Dpi = 100F;
        this.xrTableCell153.Name = "xrTableCell153";
        this.xrTableCell153.StylePriority.UseTextAlignment = false;
        xrSummary38.FormatString = "{0:#,#}";
        xrSummary38.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell153.Summary = xrSummary38;
        this.xrTableCell153.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell153.Weight = 0.53371884566674D;
        // 
        // xrTableCell154
        // 
        this.xrTableCell154.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ThrowForwardRevenue")});
        this.xrTableCell154.Dpi = 100F;
        this.xrTableCell154.Name = "xrTableCell154";
        this.xrTableCell154.StylePriority.UseTextAlignment = false;
        xrSummary39.FormatString = "{0:#,#}";
        xrSummary39.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell154.Summary = xrSummary39;
        this.xrTableCell154.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell154.Weight = 0.533718775071325D;
        // 
        // xrTableCell155
        // 
        this.xrTableCell155.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ThrowForwardLocal")});
        this.xrTableCell155.Dpi = 100F;
        this.xrTableCell155.Name = "xrTableCell155";
        this.xrTableCell155.StylePriority.UseTextAlignment = false;
        xrSummary40.FormatString = "{0:#,#}";
        xrSummary40.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell155.Summary = xrSummary40;
        this.xrTableCell155.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell155.Weight = 0.533718773386674D;
        // 
        // xrTableCell156
        // 
        this.xrTableCell156.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ThrowForwardForignFund")});
        this.xrTableCell156.Dpi = 100F;
        this.xrTableCell156.Name = "xrTableCell156";
        this.xrTableCell156.StylePriority.UseTextAlignment = false;
        xrSummary41.FormatString = "{0:#,#}";
        xrSummary41.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell156.Summary = xrSummary41;
        this.xrTableCell156.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell156.Weight = 0.53371884566674D;
        // 
        // xrTableCell157
        // 
        this.xrTableCell157.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ThrowForwardTotal")});
        this.xrTableCell157.Dpi = 100F;
        this.xrTableCell157.Name = "xrTableCell157";
        this.xrTableCell157.StylePriority.UseTextAlignment = false;
        xrSummary42.FormatString = "{0:#,#}";
        xrSummary42.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell157.Summary = xrSummary42;
        this.xrTableCell157.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell157.Weight = 0.53371884566674D;
        // 
        // xrTableCell152
        // 
        this.xrTableCell152.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ExcessCapitalAmount")});
        this.xrTableCell152.Dpi = 100F;
        this.xrTableCell152.Name = "xrTableCell152";
        this.xrTableCell152.StylePriority.UseTextAlignment = false;
        xrSummary43.FormatString = "{0:#,#}";
        xrSummary43.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell152.Summary = xrSummary43;
        this.xrTableCell152.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell152.Weight = 0.53371884566674D;
        // 
        // xrTableCell158
        // 
        this.xrTableCell158.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ExcessRevenueAmount")});
        this.xrTableCell158.Dpi = 100F;
        this.xrTableCell158.Name = "xrTableCell158";
        this.xrTableCell158.StylePriority.UseTextAlignment = false;
        xrSummary44.FormatString = "{0:#,#}";
        xrSummary44.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell158.Summary = xrSummary44;
        this.xrTableCell158.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell158.Weight = 0.53371884566674D;
        // 
        // xrTableCell186
        // 
        this.xrTableCell186.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ExcessLocalAmount")});
        this.xrTableCell186.Dpi = 100F;
        this.xrTableCell186.Name = "xrTableCell186";
        this.xrTableCell186.StylePriority.UseTextAlignment = false;
        xrSummary45.FormatString = "{0:#,#}";
        xrSummary45.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell186.Summary = xrSummary45;
        this.xrTableCell186.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell186.Weight = 0.53371884566674D;
        // 
        // xrTableCell187
        // 
        this.xrTableCell187.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ExcessForignFundAmount")});
        this.xrTableCell187.Dpi = 100F;
        this.xrTableCell187.Name = "xrTableCell187";
        this.xrTableCell187.StylePriority.UseTextAlignment = false;
        xrSummary46.FormatString = "{0:#,#}";
        xrSummary46.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell187.Summary = xrSummary46;
        this.xrTableCell187.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell187.Weight = 0.53371884566674D;
        // 
        // xrTableCell188
        // 
        this.xrTableCell188.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ExcessTotalAmount")});
        this.xrTableCell188.Dpi = 100F;
        this.xrTableCell188.Name = "xrTableCell188";
        this.xrTableCell188.StylePriority.UseTextAlignment = false;
        xrSummary47.FormatString = "{0:#,#}";
        xrSummary47.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell188.Summary = xrSummary47;
        this.xrTableCell188.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell188.Weight = 0.53371884566674D;
        // 
        // xrTableCell189
        // 
        this.xrTableCell189.Dpi = 100F;
        this.xrTableCell189.Name = "xrTableCell189";
        this.xrTableCell189.StylePriority.UseTextAlignment = false;
        this.xrTableCell189.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        this.xrTableCell189.Weight = 1.51688505069567D;
        // 
        // ApproveLocalAmount
        // 
        this.ApproveLocalAmount.DataMember = "SchemeList";
        this.ApproveLocalAmount.Expression = "[ApproveCapitalAmount] + [ApproveRevenueAmount]";
        this.ApproveLocalAmount.FieldType = DevExpress.XtraReports.UI.FieldType.Decimal;
        this.ApproveLocalAmount.Name = "ApproveLocalAmount";
        // 
        // ApproveTotalAmount
        // 
        this.ApproveTotalAmount.DataMember = "SchemeList";
        this.ApproveTotalAmount.Expression = "[ApproveCapitalAmount] + [ApproveRevenueAmount] + [ApproveForignFundAmount]";
        this.ApproveTotalAmount.FieldType = DevExpress.XtraReports.UI.FieldType.Decimal;
        this.ApproveTotalAmount.Name = "ApproveTotalAmount";
        // 
        // AllocationLocalAmount
        // 
        this.AllocationLocalAmount.DataMember = "SchemeList";
        this.AllocationLocalAmount.Expression = "[AllocationCapitalAmount] + [AllocationRevenueAmount]";
        this.AllocationLocalAmount.FieldType = DevExpress.XtraReports.UI.FieldType.Decimal;
        this.AllocationLocalAmount.Name = "AllocationLocalAmount";
        // 
        // AllocationTotalAmount
        // 
        this.AllocationTotalAmount.DataMember = "SchemeList";
        this.AllocationTotalAmount.Expression = "[AllocationCapitalAmount] + [AllocationRevenueAmount] + [AllocationForignFundAmou" +
"nt]";
        this.AllocationTotalAmount.FieldType = DevExpress.XtraReports.UI.FieldType.Decimal;
        this.AllocationTotalAmount.Name = "AllocationTotalAmount";
        // 
        // ReleseLocalAmount
        // 
        this.ReleseLocalAmount.DataMember = "SchemeList";
        this.ReleseLocalAmount.Expression = "[ReleaseCapitalAmount] + [ReleaseRevenueAmount]";
        this.ReleseLocalAmount.FieldType = DevExpress.XtraReports.UI.FieldType.Decimal;
        this.ReleseLocalAmount.Name = "ReleseLocalAmount";
        // 
        // ReleseTotalAmount
        // 
        this.ReleseTotalAmount.DataMember = "SchemeList";
        this.ReleseTotalAmount.Expression = "[ReleaseCapitalAmount] + [ReleaseRevenueAmount] + [ReleaseForignFundAmount]";
        this.ReleseTotalAmount.FieldType = DevExpress.XtraReports.UI.FieldType.Decimal;
        this.ReleseTotalAmount.Name = "ReleseTotalAmount";
        // 
        // ExpenseForeignAidAllocationPercentage
        // 
        this.ExpenseForeignAidAllocationPercentage.DataMember = "SchemeList";
        this.ExpenseForeignAidAllocationPercentage.Expression = "((100 / [AllocationForignFundAmount]) * [ExpenseForignFundAmount])/100";
        this.ExpenseForeignAidAllocationPercentage.FieldType = DevExpress.XtraReports.UI.FieldType.Float;
        this.ExpenseForeignAidAllocationPercentage.Name = "ExpenseForeignAidAllocationPercentage";
        // 
        // ExcessLocalAmount
        // 
        this.ExcessLocalAmount.DataMember = "SchemeList";
        this.ExcessLocalAmount.Expression = "[ExcessCapitalAmount] + [ExcessRevenueAmount]";
        this.ExcessLocalAmount.FieldType = DevExpress.XtraReports.UI.FieldType.Decimal;
        this.ExcessLocalAmount.Name = "ExcessLocalAmount";
        // 
        // ExcessTotalAmount
        // 
        this.ExcessTotalAmount.DataMember = "SchemeList";
        this.ExcessTotalAmount.Expression = "[ExcessCapitalAmount] + [ExcessRevenueAmount] + [ExcessForignFundAmount]";
        this.ExcessTotalAmount.FieldType = DevExpress.XtraReports.UI.FieldType.Decimal;
        this.ExcessTotalAmount.Name = "ExcessTotalAmount";
        // 
        // ExpenseForeignAidReleasePercentage
        // 
        this.ExpenseForeignAidReleasePercentage.DataMember = "SchemeList";
        this.ExpenseForeignAidReleasePercentage.Expression = "((100 / [ReleaseForignFundAmount]) * [ExpenseForignFundAmount])/100";
        this.ExpenseForeignAidReleasePercentage.FieldType = DevExpress.XtraReports.UI.FieldType.Float;
        this.ExpenseForeignAidReleasePercentage.Name = "ExpenseForeignAidReleasePercentage";
        // 
        // ExpenseTotalAllocationPercentage
        // 
        this.ExpenseTotalAllocationPercentage.DataMember = "SchemeList";
        this.ExpenseTotalAllocationPercentage.Expression = "((100 / [AllocationTotalAmount]) * [ExpenseTotalAmount])/100";
        this.ExpenseTotalAllocationPercentage.FieldType = DevExpress.XtraReports.UI.FieldType.Float;
        this.ExpenseTotalAllocationPercentage.Name = "ExpenseTotalAllocationPercentage";
        // 
        // ExpenseTotalReleasePercentage
        // 
        this.ExpenseTotalReleasePercentage.DataMember = "SchemeList";
        this.ExpenseTotalReleasePercentage.Expression = "((100 / [ReleaseTotalAmount]) * [ExpenseTotalAmount])/100";
        this.ExpenseTotalReleasePercentage.FieldType = DevExpress.XtraReports.UI.FieldType.Float;
        this.ExpenseTotalReleasePercentage.Name = "ExpenseTotalReleasePercentage";
        // 
        // ExpenseLocalAmount
        // 
        this.ExpenseLocalAmount.DataMember = "SchemeList";
        this.ExpenseLocalAmount.Expression = "[ExpenseCapitalAmount] + [ExpenseRevenueAmount]";
        this.ExpenseLocalAmount.FieldType = DevExpress.XtraReports.UI.FieldType.Decimal;
        this.ExpenseLocalAmount.Name = "ExpenseLocalAmount";
        // 
        // ExpenseTotalAmount
        // 
        this.ExpenseTotalAmount.DataMember = "SchemeList";
        this.ExpenseTotalAmount.Expression = "[ExpenseCapitalAmount] + [ExpenseRevenueAmount] + [ExpenseForignFundAmount]";
        this.ExpenseTotalAmount.FieldType = DevExpress.XtraReports.UI.FieldType.Decimal;
        this.ExpenseTotalAmount.Name = "ExpenseTotalAmount";
        // 
        // ThrowForwardLocal
        // 
        this.ThrowForwardLocal.DataMember = "SchemeList";
        this.ThrowForwardLocal.Expression = "[ApproveLocalAmount] - [ExpenseLocalAmount]";
        this.ThrowForwardLocal.FieldType = DevExpress.XtraReports.UI.FieldType.Decimal;
        this.ThrowForwardLocal.Name = "ThrowForwardLocal";
        // 
        // ThrowForwardForignFund
        // 
        this.ThrowForwardForignFund.DataMember = "SchemeList";
        this.ThrowForwardForignFund.Expression = "[ApproveForignFundAmount] - [ExpenseForignFundAmount]";
        this.ThrowForwardForignFund.FieldType = DevExpress.XtraReports.UI.FieldType.Decimal;
        this.ThrowForwardForignFund.Name = "ThrowForwardForignFund";
        // 
        // ThrowForwardTotal
        // 
        this.ThrowForwardTotal.DataMember = "SchemeList";
        this.ThrowForwardTotal.Expression = "[ApproveTotalAmount] - [ExpenseTotalAmount]";
        this.ThrowForwardTotal.FieldType = DevExpress.XtraReports.UI.FieldType.Decimal;
        this.ThrowForwardTotal.Name = "ThrowForwardTotal";
        // 
        // ReportHeader
        // 
        this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel10,
            this.xrLabel12,
            this.xrLabel1,
            this.xrLabel8,
            this.xrLabel2,
            this.xrLabel6,
            this.xrLabel3,
            this.xrLabel9,
            this.xrLabel7,
            this.xrLabel5,
            this.xrLabel4});
        this.ReportHeader.Dpi = 100F;
        this.ReportHeader.HeightF = 302.0833F;
        this.ReportHeader.Name = "ReportHeader";
        // 
        // xrLabel10
        // 
        this.xrLabel10.Dpi = 100F;
        this.xrLabel10.Font = new System.Drawing.Font("Arial", 8.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
        this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(0F, 243.125F);
        this.xrLabel10.Multiline = true;
        this.xrLabel10.Name = "xrLabel10";
        this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel10.SizeF = new System.Drawing.SizeF(98.54167F, 30F);
        this.xrLabel10.StylePriority.UseFont = false;
        this.xrLabel10.StylePriority.UseTextAlignment = false;
        this.xrLabel10.Text = "Constituency:";
        this.xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrLabel12
        // 
        this.xrLabel12.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.prConstituency, "Text", "")});
        this.xrLabel12.Dpi = 100F;
        this.xrLabel12.Font = new System.Drawing.Font("Arial", 8.75F);
        this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(98.54167F, 243.125F);
        this.xrLabel12.Multiline = true;
        this.xrLabel12.Name = "xrLabel12";
        this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel12.SizeF = new System.Drawing.SizeF(440.625F, 30F);
        this.xrLabel12.StylePriority.UseFont = false;
        this.xrLabel12.StylePriority.UseTextAlignment = false;
        this.xrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // prConstituency
        // 
        this.prConstituency.Description = "Constituency";
        this.prConstituency.Name = "prConstituency";
        this.prConstituency.Visible = false;
        // 
        // PageHeader
        // 
        this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable2,
            this.xrTable1,
            this.xrTable3});
        this.PageHeader.Dpi = 100F;
        this.PageHeader.HeightF = 120F;
        this.PageHeader.Name = "PageHeader";
        // 
        // PageFooter
        // 
        this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrlblFooter});
        this.PageFooter.Dpi = 100F;
        this.PageFooter.HeightF = 35.5F;
        this.PageFooter.Name = "PageFooter";
        // 
        // xrlblFooter
        // 
        this.xrlblFooter.Dpi = 100F;
        this.xrlblFooter.LocationFloat = new DevExpress.Utils.PointFloat(1362.5F, 12.5F);
        this.xrlblFooter.Name = "xrlblFooter";
        this.xrlblFooter.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrlblFooter.SizeF = new System.Drawing.SizeF(862.4999F, 23F);
        this.xrlblFooter.StylePriority.UseTextAlignment = false;
        this.xrlblFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrlblFooter.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrlblFooter_BeforePrint);
        // 
        // headExpenseUptoJunPY
        // 
        this.headExpenseUptoJunPY.Expression = "Concat(\'Expenditure upto June \', [Parameters.prPYear])";
        this.headExpenseUptoJunPY.FieldType = DevExpress.XtraReports.UI.FieldType.String;
        this.headExpenseUptoJunPY.Name = "headExpenseUptoJunPY";
        // 
        // prPYear
        // 
        this.prPYear.Description = "PYear";
        this.prPYear.Name = "prPYear";
        this.prPYear.Visible = false;
        // 
        // GroupHeader2
        // 
        this.GroupHeader2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel11});
        this.GroupHeader2.Dpi = 100F;
        this.GroupHeader2.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("SubSectorTitle", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
        this.GroupHeader2.HeightF = 32F;
        this.GroupHeader2.Name = "GroupHeader2";
        // 
        // xrLabel11
        // 
        this.xrLabel11.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrLabel11.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.SubSectorTitle")});
        this.xrLabel11.Dpi = 100F;
        this.xrLabel11.Font = new System.Drawing.Font("Arial", 8.75F);
        this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrLabel11.Name = "xrLabel11";
        this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel11.SizeF = new System.Drawing.SizeF(3024F, 32F);
        this.xrLabel11.StylePriority.UseBorders = false;
        this.xrLabel11.StylePriority.UseFont = false;
        this.xrLabel11.StylePriority.UseTextAlignment = false;
        this.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // GroupFooter2
        // 
        this.GroupFooter2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable5});
        this.GroupFooter2.Dpi = 100F;
        this.GroupFooter2.HeightF = 30F;
        this.GroupFooter2.Name = "GroupFooter2";
        // 
        // GroupHeader3
        // 
        this.GroupHeader3.Dpi = 100F;
        this.GroupHeader3.Expanded = false;
        this.GroupHeader3.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("InstitutionTitle", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
        this.GroupHeader3.HeightF = 0F;
        this.GroupHeader3.Level = 1;
        this.GroupHeader3.Name = "GroupHeader3";
        // 
        // GroupFooter3
        // 
        this.GroupFooter3.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable6});
        this.GroupFooter3.Dpi = 100F;
        this.GroupFooter3.HeightF = 30F;
        this.GroupFooter3.Level = 1;
        this.GroupFooter3.Name = "GroupFooter3";
        // 
        // xrTable6
        // 
        this.xrTable6.BackColor = System.Drawing.Color.White;
        this.xrTable6.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTable6.Dpi = 100F;
        this.xrTable6.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Bold);
        this.xrTable6.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrTable6.Name = "xrTable6";
        this.xrTable6.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
        this.xrTable6.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow6});
        this.xrTable6.SizeF = new System.Drawing.SizeF(3599F, 30F);
        this.xrTable6.StylePriority.UseBackColor = false;
        this.xrTable6.StylePriority.UseBorders = false;
        this.xrTable6.StylePriority.UseFont = false;
        this.xrTable6.StylePriority.UsePadding = false;
        this.xrTable6.StylePriority.UseTextAlignment = false;
        this.xrTable6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrTableRow6
        // 
        this.xrTableRow6.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell190,
            this.xrTableCell272,
            this.xrTableCell273,
            this.xrTableCell274,
            this.xrTableCell275,
            this.xrTableCell191,
            this.xrTableCell192,
            this.xrTableCell193,
            this.xrTableCell194,
            this.xrTableCell195,
            this.xrTableCell196,
            this.xrTableCell197,
            this.xrTableCell198,
            this.xrTableCell199,
            this.xrTableCell200,
            this.xrTableCell201,
            this.xrTableCell202,
            this.xrTableCell203,
            this.xrTableCell204,
            this.xrTableCell205,
            this.xrTableCell206,
            this.xrTableCell239,
            this.xrTableCell256,
            this.xrTableCell257,
            this.xrTableCell258,
            this.xrTableCell259,
            this.xrTableCell207,
            this.xrTableCell208,
            this.xrTableCell209,
            this.xrTableCell210,
            this.xrTableCell211,
            this.xrTableCell212,
            this.xrTableCell213,
            this.xrTableCell214,
            this.xrTableCell215,
            this.xrTableCell216,
            this.xrTableCell217,
            this.xrTableCell218,
            this.xrTableCell219,
            this.xrTableCell220,
            this.xrTableCell221,
            this.xrTableCell222,
            this.xrTableCell223,
            this.xrTableCell224,
            this.xrTableCell225,
            this.xrTableCell226,
            this.xrTableCell227,
            this.xrTableCell228,
            this.xrTableCell229,
            this.xrTableCell230,
            this.xrTableCell231,
            this.xrTableCell232,
            this.xrTableCell233});
        this.xrTableRow6.Dpi = 100F;
        this.xrTableRow6.Name = "xrTableRow6";
        this.xrTableRow6.Weight = 1D;
        // 
        // xrTableCell190
        // 
        this.xrTableCell190.Dpi = 100F;
        this.xrTableCell190.Name = "xrTableCell190";
        this.xrTableCell190.StylePriority.UseTextAlignment = false;
        this.xrTableCell190.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell190.Weight = 0.374539509323725D;
        // 
        // xrTableCell272
        // 
        this.xrTableCell272.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
        this.xrTableCell272.Dpi = 100F;
        this.xrTableCell272.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
        this.xrTableCell272.Name = "xrTableCell272";
        this.xrTableCell272.StylePriority.UseBorders = false;
        this.xrTableCell272.StylePriority.UseFont = false;
        this.xrTableCell272.StylePriority.UseTextAlignment = false;
        this.xrTableCell272.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
        this.xrTableCell272.Weight = 1.1704359344182254D;
        // 
        // xrTableCell273
        // 
        this.xrTableCell273.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
        this.xrTableCell273.Dpi = 100F;
        this.xrTableCell273.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
        this.xrTableCell273.Name = "xrTableCell273";
        this.xrTableCell273.StylePriority.UseBorders = false;
        this.xrTableCell273.StylePriority.UseFont = false;
        this.xrTableCell273.StylePriority.UseTextAlignment = false;
        this.xrTableCell273.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
        this.xrTableCell273.Weight = 1.1704359344182254D;
        // 
        // xrTableCell274
        // 
        this.xrTableCell274.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
        this.xrTableCell274.Dpi = 100F;
        this.xrTableCell274.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
        this.xrTableCell274.Name = "xrTableCell274";
        this.xrTableCell274.StylePriority.UseBorders = false;
        this.xrTableCell274.StylePriority.UseFont = false;
        this.xrTableCell274.StylePriority.UseTextAlignment = false;
        this.xrTableCell274.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
        this.xrTableCell274.Weight = 2.5749590777239355D;
        // 
        // xrTableCell275
        // 
        this.xrTableCell275.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
        this.xrTableCell275.Dpi = 100F;
        this.xrTableCell275.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
        this.xrTableCell275.Name = "xrTableCell275";
        this.xrTableCell275.StylePriority.UseBorders = false;
        this.xrTableCell275.StylePriority.UseFont = false;
        this.xrTableCell275.StylePriority.UseTextAlignment = false;
        this.xrTableCell275.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
        this.xrTableCell275.Weight = 1.1704359344182251D;
        // 
        // xrTableCell191
        // 
        this.xrTableCell191.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell191.Dpi = 100F;
        this.xrTableCell191.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
        this.xrTableCell191.Name = "xrTableCell191";
        this.xrTableCell191.StylePriority.UseBorders = false;
        this.xrTableCell191.StylePriority.UseFont = false;
        this.xrTableCell191.StylePriority.UseTextAlignment = false;
        this.xrTableCell191.Text = "Grand Total";
        this.xrTableCell191.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
        this.xrTableCell191.Weight = 1.1704359369776047D;
        // 
        // xrTableCell192
        // 
        this.xrTableCell192.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ApproveCapitalAmount")});
        this.xrTableCell192.Dpi = 100F;
        this.xrTableCell192.Name = "xrTableCell192";
        this.xrTableCell192.StylePriority.UseFont = false;
        this.xrTableCell192.StylePriority.UseTextAlignment = false;
        xrSummary48.FormatString = "{0:#,#}";
        xrSummary48.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell192.Summary = xrSummary48;
        this.xrTableCell192.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell192.Weight = 0.533718797860546D;
        // 
        // xrTableCell193
        // 
        this.xrTableCell193.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ApproveRevenueAmount")});
        this.xrTableCell193.Dpi = 100F;
        this.xrTableCell193.Name = "xrTableCell193";
        this.xrTableCell193.StylePriority.UseTextAlignment = false;
        xrSummary49.FormatString = "{0:#,#}";
        xrSummary49.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell193.Summary = xrSummary49;
        this.xrTableCell193.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell193.Weight = 0.533718790073738D;
        // 
        // xrTableCell194
        // 
        this.xrTableCell194.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ApproveLocalAmount")});
        this.xrTableCell194.Dpi = 100F;
        this.xrTableCell194.Name = "xrTableCell194";
        this.xrTableCell194.StylePriority.UseTextAlignment = false;
        xrSummary50.FormatString = "{0:#,#}";
        xrSummary50.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell194.Summary = xrSummary50;
        this.xrTableCell194.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell194.Weight = 0.533718768675502D;
        // 
        // xrTableCell195
        // 
        this.xrTableCell195.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ApproveForignFundAmount")});
        this.xrTableCell195.Dpi = 100F;
        this.xrTableCell195.Name = "xrTableCell195";
        this.xrTableCell195.StylePriority.UseTextAlignment = false;
        xrSummary51.FormatString = "{0:#,#}";
        xrSummary51.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell195.Summary = xrSummary51;
        this.xrTableCell195.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell195.Weight = 0.53371881467524D;
        // 
        // xrTableCell196
        // 
        this.xrTableCell196.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ApproveTotalAmount")});
        this.xrTableCell196.Dpi = 100F;
        this.xrTableCell196.Multiline = true;
        this.xrTableCell196.Name = "xrTableCell196";
        this.xrTableCell196.StylePriority.UseTextAlignment = false;
        xrSummary52.FormatString = "{0:#,#}";
        xrSummary52.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell196.Summary = xrSummary52;
        this.xrTableCell196.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell196.Weight = 0.533718790372309D;
        // 
        // xrTableCell197
        // 
        this.xrTableCell197.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ExpensePYJCapitalAmount")});
        this.xrTableCell197.Dpi = 100F;
        this.xrTableCell197.Name = "xrTableCell197";
        this.xrTableCell197.StylePriority.UseTextAlignment = false;
        xrSummary53.FormatString = "{0:#,#}";
        xrSummary53.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell197.Summary = xrSummary53;
        this.xrTableCell197.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell197.Weight = 0.533718790372309D;
        // 
        // xrTableCell198
        // 
        this.xrTableCell198.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ExpensePYJRevenueAmount")});
        this.xrTableCell198.Dpi = 100F;
        this.xrTableCell198.Name = "xrTableCell198";
        this.xrTableCell198.StylePriority.UseTextAlignment = false;
        xrSummary54.FormatString = "{0:#,#}";
        xrSummary54.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell198.Summary = xrSummary54;
        this.xrTableCell198.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell198.Weight = 0.533718790372309D;
        // 
        // xrTableCell199
        // 
        this.xrTableCell199.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ExpensePYJLocalAmount")});
        this.xrTableCell199.Dpi = 100F;
        this.xrTableCell199.Name = "xrTableCell199";
        this.xrTableCell199.StylePriority.UseTextAlignment = false;
        xrSummary55.FormatString = "{0:#,#}";
        xrSummary55.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell199.Summary = xrSummary55;
        this.xrTableCell199.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell199.Weight = 0.533718790372309D;
        // 
        // xrTableCell200
        // 
        this.xrTableCell200.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ExpensePYJForignFundAmount")});
        this.xrTableCell200.Dpi = 100F;
        this.xrTableCell200.Name = "xrTableCell200";
        this.xrTableCell200.StylePriority.UseTextAlignment = false;
        xrSummary56.FormatString = "{0:#,#}";
        xrSummary56.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell200.Summary = xrSummary56;
        this.xrTableCell200.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell200.Weight = 0.533718790372309D;
        // 
        // xrTableCell201
        // 
        this.xrTableCell201.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ExpensePYJTotalAmount")});
        this.xrTableCell201.Dpi = 100F;
        this.xrTableCell201.Name = "xrTableCell201";
        this.xrTableCell201.StylePriority.UseTextAlignment = false;
        xrSummary57.FormatString = "{0:#,#}";
        xrSummary57.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell201.Summary = xrSummary57;
        this.xrTableCell201.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell201.Weight = 0.533718790372309D;
        // 
        // xrTableCell202
        // 
        this.xrTableCell202.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.AllocationCapitalAmount")});
        this.xrTableCell202.Dpi = 100F;
        this.xrTableCell202.Name = "xrTableCell202";
        this.xrTableCell202.StylePriority.UseTextAlignment = false;
        xrSummary58.FormatString = "{0:#,#}";
        xrSummary58.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell202.Summary = xrSummary58;
        this.xrTableCell202.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell202.Weight = 0.533718784270983D;
        // 
        // xrTableCell203
        // 
        this.xrTableCell203.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.AllocationRevenueAmount")});
        this.xrTableCell203.Dpi = 100F;
        this.xrTableCell203.Name = "xrTableCell203";
        this.xrTableCell203.StylePriority.UseTextAlignment = false;
        xrSummary59.FormatString = "{0:#,#}";
        xrSummary59.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell203.Summary = xrSummary59;
        this.xrTableCell203.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell203.Weight = 0.533718784270983D;
        // 
        // xrTableCell204
        // 
        this.xrTableCell204.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.AllocationLocalAmount")});
        this.xrTableCell204.Dpi = 100F;
        this.xrTableCell204.Name = "xrTableCell204";
        this.xrTableCell204.StylePriority.UseTextAlignment = false;
        xrSummary60.FormatString = "{0:#,#}";
        xrSummary60.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell204.Summary = xrSummary60;
        this.xrTableCell204.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell204.Weight = 0.533718784270984D;
        // 
        // xrTableCell205
        // 
        this.xrTableCell205.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.AllocationForignFundAmount")});
        this.xrTableCell205.Dpi = 100F;
        this.xrTableCell205.Name = "xrTableCell205";
        this.xrTableCell205.StylePriority.UseTextAlignment = false;
        xrSummary61.FormatString = "{0:#,#}";
        xrSummary61.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell205.Summary = xrSummary61;
        this.xrTableCell205.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell205.Weight = 0.533718784270983D;
        // 
        // xrTableCell206
        // 
        this.xrTableCell206.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.AllocationTotalAmount")});
        this.xrTableCell206.Dpi = 100F;
        this.xrTableCell206.Name = "xrTableCell206";
        this.xrTableCell206.StylePriority.UseTextAlignment = false;
        xrSummary62.FormatString = "{0:#,#}";
        xrSummary62.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell206.Summary = xrSummary62;
        this.xrTableCell206.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell206.Weight = 0.533718784270983D;
        // 
        // xrTableCell239
        // 
        this.xrTableCell239.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.FinalCapitalGrant")});
        this.xrTableCell239.Dpi = 100F;
        this.xrTableCell239.Name = "xrTableCell239";
        this.xrTableCell239.StylePriority.UseTextAlignment = false;
        xrSummary63.FormatString = "{0:#,#}";
        xrSummary63.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell239.Summary = xrSummary63;
        this.xrTableCell239.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell239.Weight = 0.533718784270983D;
        // 
        // xrTableCell256
        // 
        this.xrTableCell256.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.FinalRevenueGrant")});
        this.xrTableCell256.Dpi = 100F;
        this.xrTableCell256.Name = "xrTableCell256";
        this.xrTableCell256.StylePriority.UseTextAlignment = false;
        xrSummary64.FormatString = "{0:#,#}";
        xrSummary64.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell256.Summary = xrSummary64;
        this.xrTableCell256.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell256.Weight = 0.533718784270983D;
        // 
        // xrTableCell257
        // 
        this.xrTableCell257.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.FinalLocalGrant")});
        this.xrTableCell257.Dpi = 100F;
        this.xrTableCell257.Name = "xrTableCell257";
        this.xrTableCell257.StylePriority.UseTextAlignment = false;
        xrSummary65.FormatString = "{0:#,#}";
        xrSummary65.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell257.Summary = xrSummary65;
        this.xrTableCell257.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell257.Weight = 0.533718784270983D;
        // 
        // xrTableCell258
        // 
        this.xrTableCell258.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.FinalForignFundGrant")});
        this.xrTableCell258.Dpi = 100F;
        this.xrTableCell258.Name = "xrTableCell258";
        this.xrTableCell258.StylePriority.UseTextAlignment = false;
        xrSummary66.FormatString = "{0:#,#}";
        xrSummary66.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell258.Summary = xrSummary66;
        this.xrTableCell258.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell258.Weight = 0.533718784270983D;
        // 
        // xrTableCell259
        // 
        this.xrTableCell259.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.FinalTotalGrant")});
        this.xrTableCell259.Dpi = 100F;
        this.xrTableCell259.Name = "xrTableCell259";
        this.xrTableCell259.StylePriority.UseTextAlignment = false;
        xrSummary67.FormatString = "{0:#,#}";
        xrSummary67.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell259.Summary = xrSummary67;
        this.xrTableCell259.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell259.Weight = 0.533718784270983D;
        // 
        // xrTableCell207
        // 
        this.xrTableCell207.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ReleaseCapitalAmount")});
        this.xrTableCell207.Dpi = 100F;
        this.xrTableCell207.Name = "xrTableCell207";
        this.xrTableCell207.StylePriority.UseTextAlignment = false;
        xrSummary68.FormatString = "{0:#,#}";
        xrSummary68.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell207.Summary = xrSummary68;
        this.xrTableCell207.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell207.Weight = 0.533718819989853D;
        // 
        // xrTableCell208
        // 
        this.xrTableCell208.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ReleaseRevenueAmount")});
        this.xrTableCell208.Dpi = 100F;
        this.xrTableCell208.Name = "xrTableCell208";
        this.xrTableCell208.StylePriority.UseTextAlignment = false;
        xrSummary69.FormatString = "{0:#,#}";
        xrSummary69.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell208.Summary = xrSummary69;
        this.xrTableCell208.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell208.Weight = 0.533718784270984D;
        // 
        // xrTableCell209
        // 
        this.xrTableCell209.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ReleseLocalAmount")});
        this.xrTableCell209.Dpi = 100F;
        this.xrTableCell209.Name = "xrTableCell209";
        this.xrTableCell209.StylePriority.UseTextAlignment = false;
        xrSummary70.FormatString = "{0:#,#}";
        xrSummary70.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell209.Summary = xrSummary70;
        this.xrTableCell209.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell209.Weight = 0.533718784270983D;
        // 
        // xrTableCell210
        // 
        this.xrTableCell210.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ReleaseForignFundAmount")});
        this.xrTableCell210.Dpi = 100F;
        this.xrTableCell210.Name = "xrTableCell210";
        this.xrTableCell210.StylePriority.UseTextAlignment = false;
        xrSummary71.FormatString = "{0:#,#}";
        xrSummary71.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell210.Summary = xrSummary71;
        this.xrTableCell210.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell210.Weight = 0.533718784270983D;
        // 
        // xrTableCell211
        // 
        this.xrTableCell211.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ReleseTotalAmount")});
        this.xrTableCell211.Dpi = 100F;
        this.xrTableCell211.Name = "xrTableCell211";
        this.xrTableCell211.StylePriority.UseTextAlignment = false;
        xrSummary72.FormatString = "{0:#,#}";
        xrSummary72.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell211.Summary = xrSummary72;
        this.xrTableCell211.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell211.Weight = 0.533718784270983D;
        // 
        // xrTableCell212
        // 
        this.xrTableCell212.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ExpenseCapitalAmount")});
        this.xrTableCell212.Dpi = 100F;
        this.xrTableCell212.Name = "xrTableCell212";
        this.xrTableCell212.StylePriority.UseTextAlignment = false;
        xrSummary73.FormatString = "{0:#,#}";
        xrSummary73.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell212.Summary = xrSummary73;
        this.xrTableCell212.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell212.Weight = 0.533718784270983D;
        // 
        // xrTableCell213
        // 
        this.xrTableCell213.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ExpenseRevenueAmount")});
        this.xrTableCell213.Dpi = 100F;
        this.xrTableCell213.Name = "xrTableCell213";
        this.xrTableCell213.StylePriority.UseTextAlignment = false;
        xrSummary74.FormatString = "{0:#,#}";
        xrSummary74.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell213.Summary = xrSummary74;
        this.xrTableCell213.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell213.Weight = 0.533718784270984D;
        // 
        // xrTableCell214
        // 
        this.xrTableCell214.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ExpenseLocalAmount")});
        this.xrTableCell214.Dpi = 100F;
        this.xrTableCell214.Name = "xrTableCell214";
        this.xrTableCell214.StylePriority.UseTextAlignment = false;
        xrSummary75.FormatString = "{0:#,#}";
        xrSummary75.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell214.Summary = xrSummary75;
        this.xrTableCell214.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell214.Weight = 0.533718784270984D;
        // 
        // xrTableCell215
        // 
        this.xrTableCell215.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ExpenseForignFundAmount")});
        this.xrTableCell215.Dpi = 100F;
        this.xrTableCell215.Name = "xrTableCell215";
        this.xrTableCell215.StylePriority.UseTextAlignment = false;
        xrSummary76.FormatString = "{0:#,#}";
        xrSummary76.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell215.Summary = xrSummary76;
        this.xrTableCell215.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell215.Weight = 0.533718774229001D;
        // 
        // xrTableCell216
        // 
        this.xrTableCell216.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ExpenseTotalAmount")});
        this.xrTableCell216.Dpi = 100F;
        this.xrTableCell216.Name = "xrTableCell216";
        this.xrTableCell216.StylePriority.UseTextAlignment = false;
        xrSummary77.FormatString = "{0:#,#}";
        xrSummary77.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell216.Summary = xrSummary77;
        this.xrTableCell216.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell216.Weight = 0.533718774229001D;
        // 
        // xrTableCell217
        // 
        this.xrTableCell217.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ExpenseLocalAllocationPercentage")});
        this.xrTableCell217.Dpi = 100F;
        this.xrTableCell217.Name = "xrTableCell217";
        this.xrTableCell217.StylePriority.UseTextAlignment = false;
        xrSummary78.FormatString = "{0:0.00%}";
        xrSummary78.Func = DevExpress.XtraReports.UI.SummaryFunc.Avg;
        xrSummary78.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell217.Summary = xrSummary78;
        this.xrTableCell217.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell217.Weight = 0.533718774229D;
        // 
        // xrTableCell218
        // 
        this.xrTableCell218.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ExpenseLocalReleasePercentage")});
        this.xrTableCell218.Dpi = 100F;
        this.xrTableCell218.Name = "xrTableCell218";
        this.xrTableCell218.StylePriority.UseTextAlignment = false;
        xrSummary79.FormatString = "{0:0.00%}";
        xrSummary79.Func = DevExpress.XtraReports.UI.SummaryFunc.Avg;
        xrSummary79.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell218.Summary = xrSummary79;
        this.xrTableCell218.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell218.Weight = 0.533718774229001D;
        // 
        // xrTableCell219
        // 
        this.xrTableCell219.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ExpenseForeignAidAllocationPercentage")});
        this.xrTableCell219.Dpi = 100F;
        this.xrTableCell219.Name = "xrTableCell219";
        this.xrTableCell219.StylePriority.UseTextAlignment = false;
        xrSummary80.FormatString = "{0:0.00%}";
        xrSummary80.Func = DevExpress.XtraReports.UI.SummaryFunc.Avg;
        xrSummary80.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell219.Summary = xrSummary80;
        this.xrTableCell219.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell219.Weight = 0.533718774229001D;
        // 
        // xrTableCell220
        // 
        this.xrTableCell220.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ExpenseForeignAidReleasePercentage")});
        this.xrTableCell220.Dpi = 100F;
        this.xrTableCell220.Name = "xrTableCell220";
        this.xrTableCell220.StylePriority.UseTextAlignment = false;
        xrSummary81.FormatString = "{0:0.00%}";
        xrSummary81.Func = DevExpress.XtraReports.UI.SummaryFunc.Avg;
        xrSummary81.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell220.Summary = xrSummary81;
        this.xrTableCell220.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell220.Weight = 0.533718774229D;
        // 
        // xrTableCell221
        // 
        this.xrTableCell221.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ExpenseTotalAllocationPercentage")});
        this.xrTableCell221.Dpi = 100F;
        this.xrTableCell221.Name = "xrTableCell221";
        this.xrTableCell221.StylePriority.UseTextAlignment = false;
        xrSummary82.FormatString = "{0:0.00%}";
        xrSummary82.Func = DevExpress.XtraReports.UI.SummaryFunc.Avg;
        xrSummary82.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell221.Summary = xrSummary82;
        this.xrTableCell221.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell221.Weight = 0.533718774229D;
        // 
        // xrTableCell222
        // 
        this.xrTableCell222.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ExpenseTotalReleasePercentage")});
        this.xrTableCell222.Dpi = 100F;
        this.xrTableCell222.Name = "xrTableCell222";
        this.xrTableCell222.StylePriority.UseTextAlignment = false;
        xrSummary83.FormatString = "{0:0.00%}";
        xrSummary83.Func = DevExpress.XtraReports.UI.SummaryFunc.Avg;
        xrSummary83.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell222.Summary = xrSummary83;
        this.xrTableCell222.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell222.Weight = 0.533718774229D;
        // 
        // xrTableCell223
        // 
        this.xrTableCell223.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ThrowForwardCapital")});
        this.xrTableCell223.Dpi = 100F;
        this.xrTableCell223.Name = "xrTableCell223";
        this.xrTableCell223.StylePriority.UseTextAlignment = false;
        xrSummary84.FormatString = "{0:#,#}";
        xrSummary84.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell223.Summary = xrSummary84;
        this.xrTableCell223.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell223.Weight = 0.53371884566674D;
        // 
        // xrTableCell224
        // 
        this.xrTableCell224.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ThrowForwardRevenue")});
        this.xrTableCell224.Dpi = 100F;
        this.xrTableCell224.Name = "xrTableCell224";
        this.xrTableCell224.StylePriority.UseTextAlignment = false;
        xrSummary85.FormatString = "{0:#,#}";
        xrSummary85.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell224.Summary = xrSummary85;
        this.xrTableCell224.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell224.Weight = 0.533718775071325D;
        // 
        // xrTableCell225
        // 
        this.xrTableCell225.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ThrowForwardLocal")});
        this.xrTableCell225.Dpi = 100F;
        this.xrTableCell225.Name = "xrTableCell225";
        this.xrTableCell225.StylePriority.UseTextAlignment = false;
        xrSummary86.FormatString = "{0:#,#}";
        xrSummary86.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell225.Summary = xrSummary86;
        this.xrTableCell225.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell225.Weight = 0.533718773386674D;
        // 
        // xrTableCell226
        // 
        this.xrTableCell226.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ThrowForwardForignFund")});
        this.xrTableCell226.Dpi = 100F;
        this.xrTableCell226.Name = "xrTableCell226";
        this.xrTableCell226.StylePriority.UseTextAlignment = false;
        xrSummary87.FormatString = "{0:#,#}";
        xrSummary87.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell226.Summary = xrSummary87;
        this.xrTableCell226.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell226.Weight = 0.53371884566674D;
        // 
        // xrTableCell227
        // 
        this.xrTableCell227.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ThrowForwardTotal")});
        this.xrTableCell227.Dpi = 100F;
        this.xrTableCell227.Name = "xrTableCell227";
        this.xrTableCell227.StylePriority.UseTextAlignment = false;
        xrSummary88.FormatString = "{0:#,#}";
        xrSummary88.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell227.Summary = xrSummary88;
        this.xrTableCell227.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell227.Weight = 0.53371884566674D;
        // 
        // xrTableCell228
        // 
        this.xrTableCell228.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ExcessCapitalAmount")});
        this.xrTableCell228.Dpi = 100F;
        this.xrTableCell228.Name = "xrTableCell228";
        this.xrTableCell228.StylePriority.UseTextAlignment = false;
        xrSummary89.FormatString = "{0:#,#}";
        xrSummary89.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell228.Summary = xrSummary89;
        this.xrTableCell228.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell228.Weight = 0.53371884566674D;
        // 
        // xrTableCell229
        // 
        this.xrTableCell229.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ExcessRevenueAmount")});
        this.xrTableCell229.Dpi = 100F;
        this.xrTableCell229.Name = "xrTableCell229";
        this.xrTableCell229.StylePriority.UseTextAlignment = false;
        xrSummary90.FormatString = "{0:#,#}";
        xrSummary90.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell229.Summary = xrSummary90;
        this.xrTableCell229.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell229.Weight = 0.53371884566674D;
        // 
        // xrTableCell230
        // 
        this.xrTableCell230.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ExcessLocalAmount")});
        this.xrTableCell230.Dpi = 100F;
        this.xrTableCell230.Name = "xrTableCell230";
        this.xrTableCell230.StylePriority.UseTextAlignment = false;
        xrSummary91.FormatString = "{0:#,#}";
        xrSummary91.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell230.Summary = xrSummary91;
        this.xrTableCell230.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell230.Weight = 0.53371884566674D;
        // 
        // xrTableCell231
        // 
        this.xrTableCell231.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ExcessForignFundAmount")});
        this.xrTableCell231.Dpi = 100F;
        this.xrTableCell231.Name = "xrTableCell231";
        this.xrTableCell231.StylePriority.UseTextAlignment = false;
        xrSummary92.FormatString = "{0:#,#}";
        xrSummary92.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell231.Summary = xrSummary92;
        this.xrTableCell231.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell231.Weight = 0.53371884566674D;
        // 
        // xrTableCell232
        // 
        this.xrTableCell232.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ExcessTotalAmount")});
        this.xrTableCell232.Dpi = 100F;
        this.xrTableCell232.Name = "xrTableCell232";
        this.xrTableCell232.StylePriority.UseTextAlignment = false;
        xrSummary93.FormatString = "{0:#,#}";
        xrSummary93.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell232.Summary = xrSummary93;
        this.xrTableCell232.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell232.Weight = 0.53371884566674D;
        // 
        // xrTableCell233
        // 
        this.xrTableCell233.Dpi = 100F;
        this.xrTableCell233.Name = "xrTableCell233";
        this.xrTableCell233.StylePriority.UseTextAlignment = false;
        this.xrTableCell233.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        this.xrTableCell233.Weight = 1.51688505069567D;
        // 
        // ExpensePYJLocalAmount
        // 
        this.ExpensePYJLocalAmount.DataMember = "SchemeList";
        this.ExpensePYJLocalAmount.Expression = "[ExpensePYJCapitalAmount] + [ExpensePYJRevenueAmount]";
        this.ExpensePYJLocalAmount.FieldType = DevExpress.XtraReports.UI.FieldType.Decimal;
        this.ExpensePYJLocalAmount.Name = "ExpensePYJLocalAmount";
        // 
        // ExpensePYJTotalAmount
        // 
        this.ExpensePYJTotalAmount.DataMember = "SchemeList";
        this.ExpensePYJTotalAmount.Expression = "[ExpensePYJCapitalAmount] + [ExpensePYJRevenueAmount] + [ExpensePYJForignFundAmou" +
"nt]";
        this.ExpensePYJTotalAmount.FieldType = DevExpress.XtraReports.UI.FieldType.Decimal;
        this.ExpensePYJTotalAmount.Name = "ExpensePYJTotalAmount";
        // 
        // ThrowForwardCapital
        // 
        this.ThrowForwardCapital.DataMember = "SchemeList";
        this.ThrowForwardCapital.Expression = "[ApproveCapitalAmount] - [ExpenseCapitalAmount]";
        this.ThrowForwardCapital.FieldType = DevExpress.XtraReports.UI.FieldType.Decimal;
        this.ThrowForwardCapital.Name = "ThrowForwardCapital";
        // 
        // ThrowForwardRevenue
        // 
        this.ThrowForwardRevenue.DataMember = "SchemeList";
        this.ThrowForwardRevenue.Expression = "[ApproveRevenueAmount] - [ExpenseRevenueAmount]";
        this.ThrowForwardRevenue.FieldType = DevExpress.XtraReports.UI.FieldType.Decimal;
        this.ThrowForwardRevenue.Name = "ThrowForwardRevenue";
        // 
        // ExpenseLocalAllocationPercentage
        // 
        this.ExpenseLocalAllocationPercentage.DataMember = "SchemeList";
        this.ExpenseLocalAllocationPercentage.Expression = "((100 / [AllocationLocalAmount]) * [ExpenseLocalAmount])/100";
        this.ExpenseLocalAllocationPercentage.FieldType = DevExpress.XtraReports.UI.FieldType.Float;
        this.ExpenseLocalAllocationPercentage.Name = "ExpenseLocalAllocationPercentage";
        // 
        // ExpenseLocalReleasePercentage
        // 
        this.ExpenseLocalReleasePercentage.DataMember = "SchemeList";
        this.ExpenseLocalReleasePercentage.Expression = "((100 / [ReleaseLocalAmount]) * [ExpenseLocalAmount])/100";
        this.ExpenseLocalReleasePercentage.FieldType = DevExpress.XtraReports.UI.FieldType.Float;
        this.ExpenseLocalReleasePercentage.Name = "ExpenseLocalReleasePercentage";
        // 
        // FinalLocalGrant
        // 
        this.FinalLocalGrant.DataMember = "SchemeList";
        this.FinalLocalGrant.Expression = "[FinalCapitalGrant] + [FinalRevenueGrant]";
        this.FinalLocalGrant.FieldType = DevExpress.XtraReports.UI.FieldType.Decimal;
        this.FinalLocalGrant.Name = "FinalLocalGrant";
        // 
        // FinalTotalGrant
        // 
        this.FinalTotalGrant.DataMember = "SchemeList";
        this.FinalTotalGrant.Expression = "[FinalCapitalGrant] + [FinalRevenueGrant] + [FinalForignFundGrant]";
        this.FinalTotalGrant.FieldType = DevExpress.XtraReports.UI.FieldType.Decimal;
        this.FinalTotalGrant.Name = "FinalTotalGrant";
        // 
        // xrProgressReviewReport
        // 
        this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.PageHeader,
            this.PageFooter,
            this.GroupHeader2,
            this.GroupFooter2,
            this.GroupHeader3,
            this.GroupFooter3});
        this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.headExpenseUptoJunPY,
            this.ApproveLocalAmount,
            this.ApproveTotalAmount,
            this.ExpensePYJLocalAmount,
            this.ExpensePYJTotalAmount,
            this.AllocationLocalAmount,
            this.AllocationTotalAmount,
            this.ReleseLocalAmount,
            this.ReleseTotalAmount,
            this.ExpenseLocalAmount,
            this.ExpenseTotalAmount,
            this.ExpenseLocalAllocationPercentage,
            this.ExpenseLocalReleasePercentage,
            this.ExpenseForeignAidAllocationPercentage,
            this.ExpenseForeignAidReleasePercentage,
            this.ExpenseTotalAllocationPercentage,
            this.ExpenseTotalReleasePercentage,
            this.ThrowForwardCapital,
            this.ThrowForwardRevenue,
            this.ThrowForwardLocal,
            this.ThrowForwardForignFund,
            this.ThrowForwardTotal,
            this.ExcessLocalAmount,
            this.ExcessTotalAmount,
            this.FinalLocalGrant,
            this.FinalTotalGrant});
        this.DataMember = "SchemeList";
        this.DataSource = this.bindingSource1;
        this.Landscape = true;
        this.Margins = new System.Drawing.Printing.Margins(0, 0, 49, 50);
        this.PageHeight = 1654;
        this.PageWidth = 3599;
        this.PaperKind = System.Drawing.Printing.PaperKind.Custom;
        this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.prYear,
            this.prDateRange,
            this.prDistrict,
            this.prPYear,
            this.prConstituency});
        this.RequestParameters = false;
        this.Version = "16.1";
        ((System.ComponentModel.ISupportInitialize)(this.xrTable4)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable5)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable6)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion

    private void xrlblFooter_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
    {
        xrlblFooter.Text = System.Configuration.ConfigurationManager.AppSettings["FooterText"];
    }
}
