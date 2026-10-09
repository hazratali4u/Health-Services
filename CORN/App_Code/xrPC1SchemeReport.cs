using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

/// <summary>
/// Summary description for xrPC1SchemeReport
/// </summary>
public class xrPC1SchemeReport : DevExpress.XtraReports.UI.XtraReport
{
    private DevExpress.XtraReports.UI.DetailBand Detail;
    private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
    private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
    private System.Windows.Forms.BindingSource bindingSource1;
    private PageFooterBand PageFooter;
    private XRLabel xrLabel3;
    private XRLabel xrLabel1;
    private XRLabel xrLabel4;
    private XRLabel xrLabel2;
    private XRLabel xrLabel5;
    private DevExpress.XtraReports.Parameters.Parameter prModified;
    private XRLabel xrLabel6;
    private XRLabel xrLabel7;
    private XRLabel xrLabel8;
    private XRLabel xrLabel9;
    private XRLabel xrLabel10;
    private XRLabel xrLabel11;
    private XRLabel xrLabel15;
    private XRLabel xrLabel16;
    private XRLabel xrLabel12;
    private XRLabel xrLabel13;
    private XRLabel xrLabel14;
    private XRLabel xrLabel23;
    private XRLabel xrLabel24;
    private XRLabel xrLabel25;
    private XRLabel xrLabel20;
    private XRLabel xrLabel21;
    private XRLabel xrLabel22;
    private XRLabel xrLabel17;
    private XRLabel xrLabel18;
    private XRLabel xrLabel19;
    private XRLabel xrLabel26;
    private XRLabel xrLabel27;
    private XRRichText xrRichText1;
    private XRLabel xrLabel30;
    private XRLabel xrLabel31;
    private XRRichText xrRichText3;
    private XRLabel xrLabel28;
    private XRLabel xrLabel29;
    private XRRichText xrRichText2;
    private XRRichText xrRichText13;
    private XRLabel xrLabel54;
    private XRLabel xrLabel55;
    private XRLabel xrLabel56;
    private XRRichText xrRichText14;
    private XRLabel xrLabel57;
    private XRRichText xrRichText15;
    private XRLabel xrLabel58;
    private XRLabel xrLabel59;
    private XRLabel xrLabel36;
    private XRLabel xrLabel41;
    private XRLabel xrLabel44;
    private XRLabel xrLabel47;
    private XRLabel xrLabel52;
    private XRLabel xrLabel53;
    private XRRichText xrRichText11;
    private XRRichText xrRichText12;
    private XRRichText xrRichText10;
    private XRRichText xrRichText9;
    private XRRichText xrRichText8;
    private XRRichText xrRichText7;
    private XRRichText xrRichText6;
    private XRLabel xrLabel50;
    private XRLabel xrLabel51;
    private XRLabel xrLabel37;
    private XRLabel xrLabel38;
    private XRLabel xrLabel39;
    private XRLabel xrLabel40;
    private XRLabel xrLabel42;
    private XRLabel xrLabel43;
    private XRLabel xrLabel45;
    private XRLabel xrLabel46;
    private XRLabel xrLabel48;
    private XRLabel xrLabel49;
    private XRLabel xrLabel34;
    private XRLabel xrLabel35;
    private XRRichText xrRichText5;
    private XRLabel xrLabel32;
    private XRRichText xrRichText4;
    private XRLabel xrLabel33;
    private DetailReportBand DetailReport;
    private DetailBand Detail1;
    private DetailReportBand DetailReport1;
    private DetailBand Detail2;
    private DetailReportBand DetailReport2;
    private DetailBand Detail3;
    private DetailReportBand DetailReport3;
    private DetailBand Detail4;
    private DetailReportBand DetailReport4;
    private DetailBand Detail5;
    private GroupHeaderBand GroupHeader1;
    private XRLabel xrLabel60;
    private XRLabel xrLabel61;
    private XRTable xrTable1;
    private XRTableRow xrTableRow1;
    private XRTableCell xrTableCell1;
    private XRTableCell xrTableCell29;
    private XRTableCell xrTableCell30;
    private XRTable xrTable2;
    private XRTableRow xrTableRow2;
    private XRTableCell xrTableCell2;
    private XRTableCell xrTableCell3;
    private XRTableCell xrTableCell4;
    private XRTable xrTable4;
    private XRTableRow xrTableRow4;
    private XRTableCell xrTableCell8;
    private DetailReportBand DetailReport5;
    private DetailBand Detail6;
    private XRTable xrTable6;
    private XRTableRow xrTableRow6;
    private XRTableCell xrTableCell14;
    private XRTableCell xrTableCell15;
    private XRTableCell xrTableCell16;
    private XRTableCell xrTableCell17;
    private XRTableCell xrTableCell18;
    private GroupHeaderBand GroupHeader2;
    private XRTable xrTable5;
    private XRTableRow xrTableRow5;
    private XRTableCell xrTableCell9;
    private XRTableCell xrTableCell10;
    private XRTableCell xrTableCell12;
    private XRTableCell xrTableCell11;
    private XRTableCell xrTableCell13;
    private XRTable xrTable3;
    private XRTableRow xrTableRow3;
    private XRTableCell xrTableCell5;
    private XRTableCell xrTableCell6;
    private XRTableCell xrTableCell7;
    private GroupFooterBand GroupFooter1;
    private GroupHeaderBand GroupHeader3;
    private XRTable xrTable8;
    private XRTableRow xrTableRow8;
    private XRTableCell xrTableCell22;
    private XRTableCell xrTableCell23;
    private XRTableCell xrTableCell24;
    private GroupHeaderBand GroupHeader4;
    private XRTable xrTable7;
    private XRTableRow xrTableRow7;
    private XRTableCell xrTableCell19;
    private XRTableCell xrTableCell20;
    private XRTableCell xrTableCell21;
    private GroupHeaderBand GroupHeader5;
    private XRLabel xrLabel62;
    private XRLabel xrLabel63;
    private GroupFooterBand GroupFooter2;
    private XRTable xrTable9;
    private XRTableRow xrTableRow9;
    private XRTableCell xrTableCell25;
    private XRTableCell xrTableCell26;
    private XRTableCell xrTableCell27;
    private CalculatedField cfTotalCapitalCostEstimate;
    private XRTable xrTable11;
    private XRTableRow xrTableRow11;
    private XRTableCell xrTableCell32;
    private XRTableCell xrTableCell33;
    private XRTableCell xrTableCell37;
    private GroupHeaderBand GroupHeader6;
    private XRTable xrTable10;
    private XRTableRow xrTableRow10;
    private XRTableCell xrTableCell28;
    private XRTableCell xrTableCell31;
    private XRTableCell xrTableCell34;

    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public xrPC1SchemeReport()
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
        string resourceFileName = "xrPC1SchemeReport.resx";
        System.Resources.ResourceManager resources = global::Resources.xrPC1SchemeReport.ResourceManager;
        this.components = new System.ComponentModel.Container();
        DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary2 = new DevExpress.XtraReports.UI.XRSummary();
        this.Detail = new DevExpress.XtraReports.UI.DetailBand();
        this.xrRichText13 = new DevExpress.XtraReports.UI.XRRichText();
        this.xrLabel54 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel55 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel56 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrRichText14 = new DevExpress.XtraReports.UI.XRRichText();
        this.xrLabel57 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrRichText15 = new DevExpress.XtraReports.UI.XRRichText();
        this.xrLabel58 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel59 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel36 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel41 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel44 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel47 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel52 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel53 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrRichText11 = new DevExpress.XtraReports.UI.XRRichText();
        this.xrRichText12 = new DevExpress.XtraReports.UI.XRRichText();
        this.xrRichText10 = new DevExpress.XtraReports.UI.XRRichText();
        this.xrRichText9 = new DevExpress.XtraReports.UI.XRRichText();
        this.xrRichText8 = new DevExpress.XtraReports.UI.XRRichText();
        this.xrRichText7 = new DevExpress.XtraReports.UI.XRRichText();
        this.xrRichText6 = new DevExpress.XtraReports.UI.XRRichText();
        this.xrLabel50 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel51 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel37 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel38 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel39 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel40 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel42 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel43 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel45 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel46 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel48 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel49 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel34 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel35 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrRichText5 = new DevExpress.XtraReports.UI.XRRichText();
        this.xrLabel32 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrRichText4 = new DevExpress.XtraReports.UI.XRRichText();
        this.xrLabel33 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel30 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel31 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrRichText3 = new DevExpress.XtraReports.UI.XRRichText();
        this.xrLabel28 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel29 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrRichText2 = new DevExpress.XtraReports.UI.XRRichText();
        this.xrRichText1 = new DevExpress.XtraReports.UI.XRRichText();
        this.xrLabel26 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel27 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel23 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel24 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel25 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel20 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel21 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel22 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
        this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
        this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
        this.prModified = new DevExpress.XtraReports.Parameters.Parameter();
        this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
        this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
        this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
        this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
        this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
        this.DetailReport = new DevExpress.XtraReports.UI.DetailReportBand();
        this.Detail1 = new DevExpress.XtraReports.UI.DetailBand();
        this.DetailReport1 = new DevExpress.XtraReports.UI.DetailReportBand();
        this.Detail2 = new DevExpress.XtraReports.UI.DetailBand();
        this.DetailReport2 = new DevExpress.XtraReports.UI.DetailReportBand();
        this.Detail3 = new DevExpress.XtraReports.UI.DetailBand();
        this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
        this.xrLabel60 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel61 = new DevExpress.XtraReports.UI.XRLabel();
        this.DetailReport3 = new DevExpress.XtraReports.UI.DetailReportBand();
        this.Detail4 = new DevExpress.XtraReports.UI.DetailBand();
        this.DetailReport4 = new DevExpress.XtraReports.UI.DetailReportBand();
        this.Detail5 = new DevExpress.XtraReports.UI.DetailBand();
        this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell29 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell30 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTable3 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTable4 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
        this.DetailReport5 = new DevExpress.XtraReports.UI.DetailReportBand();
        this.Detail6 = new DevExpress.XtraReports.UI.DetailBand();
        this.GroupHeader2 = new DevExpress.XtraReports.UI.GroupHeaderBand();
        this.xrTable5 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow5 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell13 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTable6 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow6 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell14 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell15 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell16 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell17 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell18 = new DevExpress.XtraReports.UI.XRTableCell();
        this.GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
        this.GroupHeader3 = new DevExpress.XtraReports.UI.GroupHeaderBand();
        this.GroupHeader4 = new DevExpress.XtraReports.UI.GroupHeaderBand();
        this.GroupHeader5 = new DevExpress.XtraReports.UI.GroupHeaderBand();
        this.GroupFooter2 = new DevExpress.XtraReports.UI.GroupFooterBand();
        this.xrLabel62 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel63 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrTable7 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow7 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell19 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell20 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell21 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTable8 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow8 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell22 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell23 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell24 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTable9 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow9 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell25 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell26 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell27 = new DevExpress.XtraReports.UI.XRTableCell();
        this.cfTotalCapitalCostEstimate = new DevExpress.XtraReports.UI.CalculatedField();
        this.GroupHeader6 = new DevExpress.XtraReports.UI.GroupHeaderBand();
        this.xrTable10 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow10 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell28 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell31 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell34 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTable11 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow11 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell32 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell33 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell37 = new DevExpress.XtraReports.UI.XRTableCell();
        ((System.ComponentModel.ISupportInitialize)(this.xrRichText13)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrRichText14)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrRichText15)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrRichText11)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrRichText12)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrRichText10)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrRichText9)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrRichText8)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrRichText7)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrRichText6)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrRichText5)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrRichText4)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrRichText3)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrRichText2)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrRichText1)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable4)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable5)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable6)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable7)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable8)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable9)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable10)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable11)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
        // 
        // Detail
        // 
        this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrRichText13,
            this.xrLabel54,
            this.xrLabel55,
            this.xrLabel56,
            this.xrRichText14,
            this.xrLabel57,
            this.xrRichText15,
            this.xrLabel58,
            this.xrLabel59,
            this.xrLabel36,
            this.xrLabel41,
            this.xrLabel44,
            this.xrLabel47,
            this.xrLabel52,
            this.xrLabel53,
            this.xrRichText11,
            this.xrRichText12,
            this.xrRichText10,
            this.xrRichText9,
            this.xrRichText8,
            this.xrRichText7,
            this.xrRichText6,
            this.xrLabel50,
            this.xrLabel51,
            this.xrLabel37,
            this.xrLabel38,
            this.xrLabel39,
            this.xrLabel40,
            this.xrLabel42,
            this.xrLabel43,
            this.xrLabel45,
            this.xrLabel46,
            this.xrLabel48,
            this.xrLabel49,
            this.xrLabel34,
            this.xrLabel35,
            this.xrRichText5,
            this.xrLabel32,
            this.xrRichText4,
            this.xrLabel33,
            this.xrLabel30,
            this.xrLabel31,
            this.xrRichText3,
            this.xrLabel28,
            this.xrLabel29,
            this.xrRichText2,
            this.xrRichText1,
            this.xrLabel26,
            this.xrLabel27,
            this.xrLabel23,
            this.xrLabel24,
            this.xrLabel25,
            this.xrLabel20,
            this.xrLabel21,
            this.xrLabel22,
            this.xrLabel17,
            this.xrLabel18,
            this.xrLabel19,
            this.xrLabel15,
            this.xrLabel16,
            this.xrLabel12,
            this.xrLabel13,
            this.xrLabel14,
            this.xrLabel9,
            this.xrLabel10,
            this.xrLabel11,
            this.xrLabel8,
            this.xrLabel7,
            this.xrLabel6});
        this.Detail.Dpi = 100F;
        this.Detail.HeightF = 1586.979F;
        this.Detail.Name = "Detail";
        this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
        this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        // 
        // xrRichText13
        // 
        this.xrRichText13.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Html", null, "SchemeList.step13Detail")});
        this.xrRichText13.Dpi = 100F;
        this.xrRichText13.Font = new System.Drawing.Font("Arial", 8.75F);
        this.xrRichText13.LocationFloat = new DevExpress.Utils.PointFloat(36.49995F, 1423.187F);
        this.xrRichText13.Name = "xrRichText13";
        this.xrRichText13.SerializableRtfString = resources.GetString("xrRichText13.SerializableRtfString");
        this.xrRichText13.SizeF = new System.Drawing.SizeF(1097.5F, 23F);
        this.xrRichText13.StylePriority.UseFont = false;
        // 
        // xrLabel54
        // 
        this.xrLabel54.Dpi = 100F;
        this.xrLabel54.Font = new System.Drawing.Font("Arial", 8.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
        this.xrLabel54.LocationFloat = new DevExpress.Utils.PointFloat(36.95828F, 1391.937F);
        this.xrLabel54.Multiline = true;
        this.xrLabel54.Name = "xrLabel54";
        this.xrLabel54.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel54.SizeF = new System.Drawing.SizeF(495.8332F, 31.25F);
        this.xrLabel54.StylePriority.UseFont = false;
        this.xrLabel54.StylePriority.UseTextAlignment = false;
        this.xrLabel54.Text = "Management Structure and Manpower Requirements";
        this.xrLabel54.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrLabel55
        // 
        this.xrLabel55.Dpi = 100F;
        this.xrLabel55.Font = new System.Drawing.Font("Arial", 8.75F, System.Drawing.FontStyle.Bold);
        this.xrLabel55.LocationFloat = new DevExpress.Utils.PointFloat(9.999943F, 1391.937F);
        this.xrLabel55.Multiline = true;
        this.xrLabel55.Name = "xrLabel55";
        this.xrLabel55.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel55.SizeF = new System.Drawing.SizeF(26.04161F, 31.25F);
        this.xrLabel55.StylePriority.UseFont = false;
        this.xrLabel55.StylePriority.UseTextAlignment = false;
        this.xrLabel55.Text = "11.";
        this.xrLabel55.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrLabel56
        // 
        this.xrLabel56.Dpi = 100F;
        this.xrLabel56.Font = new System.Drawing.Font("Arial", 8.75F, System.Drawing.FontStyle.Bold);
        this.xrLabel56.LocationFloat = new DevExpress.Utils.PointFloat(10.60417F, 1456.604F);
        this.xrLabel56.Multiline = true;
        this.xrLabel56.Name = "xrLabel56";
        this.xrLabel56.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel56.SizeF = new System.Drawing.SizeF(26.04161F, 31.25F);
        this.xrLabel56.StylePriority.UseFont = false;
        this.xrLabel56.StylePriority.UseTextAlignment = false;
        this.xrLabel56.Text = "12.";
        this.xrLabel56.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrRichText14
        // 
        this.xrRichText14.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Html", null, "SchemeList.step14Detail")});
        this.xrRichText14.Dpi = 100F;
        this.xrRichText14.Font = new System.Drawing.Font("Arial", 8.75F);
        this.xrRichText14.LocationFloat = new DevExpress.Utils.PointFloat(37.10418F, 1487.854F);
        this.xrRichText14.Name = "xrRichText14";
        this.xrRichText14.SerializableRtfString = resources.GetString("xrRichText14.SerializableRtfString");
        this.xrRichText14.SizeF = new System.Drawing.SizeF(1096.896F, 23F);
        this.xrRichText14.StylePriority.UseFont = false;
        // 
        // xrLabel57
        // 
        this.xrLabel57.Dpi = 100F;
        this.xrLabel57.Font = new System.Drawing.Font("Arial", 8.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
        this.xrLabel57.LocationFloat = new DevExpress.Utils.PointFloat(37.10418F, 1456.604F);
        this.xrLabel57.Multiline = true;
        this.xrLabel57.Name = "xrLabel57";
        this.xrLabel57.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel57.SizeF = new System.Drawing.SizeF(311.4583F, 31.25F);
        this.xrLabel57.StylePriority.UseFont = false;
        this.xrLabel57.StylePriority.UseTextAlignment = false;
        this.xrLabel57.Text = "Additional Projects/Decisions Required";
        this.xrLabel57.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrRichText15
        // 
        this.xrRichText15.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Html", null, "SchemeList.step15Detail")});
        this.xrRichText15.Dpi = 100F;
        this.xrRichText15.Font = new System.Drawing.Font("Arial", 8.75F);
        this.xrRichText15.LocationFloat = new DevExpress.Utils.PointFloat(36.04161F, 1552.521F);
        this.xrRichText15.Name = "xrRichText15";
        this.xrRichText15.SerializableRtfString = resources.GetString("xrRichText15.SerializableRtfString");
        this.xrRichText15.SizeF = new System.Drawing.SizeF(1097.958F, 23F);
        this.xrRichText15.StylePriority.UseFont = false;
        // 
        // xrLabel58
        // 
        this.xrLabel58.Dpi = 100F;
        this.xrLabel58.Font = new System.Drawing.Font("Arial", 8.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
        this.xrLabel58.LocationFloat = new DevExpress.Utils.PointFloat(36.04161F, 1521.271F);
        this.xrLabel58.Multiline = true;
        this.xrLabel58.Name = "xrLabel58";
        this.xrLabel58.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel58.SizeF = new System.Drawing.SizeF(311.4583F, 31.25F);
        this.xrLabel58.StylePriority.UseFont = false;
        this.xrLabel58.StylePriority.UseTextAlignment = false;
        this.xrLabel58.Text = "Certificate";
        this.xrLabel58.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrLabel59
        // 
        this.xrLabel59.Dpi = 100F;
        this.xrLabel59.Font = new System.Drawing.Font("Arial", 8.75F, System.Drawing.FontStyle.Bold);
        this.xrLabel59.LocationFloat = new DevExpress.Utils.PointFloat(9.541607F, 1521.271F);
        this.xrLabel59.Multiline = true;
        this.xrLabel59.Name = "xrLabel59";
        this.xrLabel59.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel59.SizeF = new System.Drawing.SizeF(26.04161F, 31.25F);
        this.xrLabel59.StylePriority.UseFont = false;
        this.xrLabel59.StylePriority.UseTextAlignment = false;
        this.xrLabel59.Text = "13.";
        this.xrLabel59.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrLabel36
        // 
        this.xrLabel36.Dpi = 100F;
        this.xrLabel36.Font = new System.Drawing.Font("Arial", 8.75F, System.Drawing.FontStyle.Bold);
        this.xrLabel36.LocationFloat = new DevExpress.Utils.PointFloat(37.56252F, 1326.937F);
        this.xrLabel36.Multiline = true;
        this.xrLabel36.Name = "xrLabel36";
        this.xrLabel36.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel36.SizeF = new System.Drawing.SizeF(26.04161F, 31.25F);
        this.xrLabel36.StylePriority.UseFont = false;
        this.xrLabel36.StylePriority.UseTextAlignment = false;
        this.xrLabel36.Text = "b.";
        this.xrLabel36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrLabel41
        // 
        this.xrLabel41.Dpi = 100F;
        this.xrLabel41.Font = new System.Drawing.Font("Arial", 8.75F, System.Drawing.FontStyle.Bold);
        this.xrLabel41.LocationFloat = new DevExpress.Utils.PointFloat(64.0625F, 1326.937F);
        this.xrLabel41.Multiline = true;
        this.xrLabel41.Name = "xrLabel41";
        this.xrLabel41.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel41.SizeF = new System.Drawing.SizeF(285.4166F, 31.25F);
        this.xrLabel41.StylePriority.UseFont = false;
        this.xrLabel41.StylePriority.UseTextAlignment = false;
        this.xrLabel41.Text = "Result Based Monitoring (RBM) Indicators";
        this.xrLabel41.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrLabel44
        // 
        this.xrLabel44.Dpi = 100F;
        this.xrLabel44.Font = new System.Drawing.Font("Arial", 8.75F, System.Drawing.FontStyle.Bold);
        this.xrLabel44.LocationFloat = new DevExpress.Utils.PointFloat(37.56252F, 1253.5F);
        this.xrLabel44.Multiline = true;
        this.xrLabel44.Name = "xrLabel44";
        this.xrLabel44.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel44.SizeF = new System.Drawing.SizeF(26.04161F, 31.25F);
        this.xrLabel44.StylePriority.UseFont = false;
        this.xrLabel44.StylePriority.UseTextAlignment = false;
        this.xrLabel44.Text = "a.";
        this.xrLabel44.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrLabel47
        // 
        this.xrLabel47.Dpi = 100F;
        this.xrLabel47.Font = new System.Drawing.Font("Arial", 8.75F, System.Drawing.FontStyle.Bold);
        this.xrLabel47.LocationFloat = new DevExpress.Utils.PointFloat(63.60416F, 1253.5F);
        this.xrLabel47.Multiline = true;
        this.xrLabel47.Name = "xrLabel47";
        this.xrLabel47.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel47.SizeF = new System.Drawing.SizeF(191.6666F, 31.25F);
        this.xrLabel47.StylePriority.UseFont = false;
        this.xrLabel47.StylePriority.UseTextAlignment = false;
        this.xrLabel47.Text = "Implementation Schedule";
        this.xrLabel47.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrLabel52
        // 
        this.xrLabel52.Dpi = 100F;
        this.xrLabel52.Font = new System.Drawing.Font("Arial", 8.75F, System.Drawing.FontStyle.Bold);
        this.xrLabel52.LocationFloat = new DevExpress.Utils.PointFloat(11.37501F, 1211.834F);
        this.xrLabel52.Multiline = true;
        this.xrLabel52.Name = "xrLabel52";
        this.xrLabel52.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel52.SizeF = new System.Drawing.SizeF(26.04161F, 31.25F);
        this.xrLabel52.StylePriority.UseFont = false;
        this.xrLabel52.StylePriority.UseTextAlignment = false;
        this.xrLabel52.Text = "10.";
        this.xrLabel52.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrLabel53
        // 
        this.xrLabel53.Dpi = 100F;
        this.xrLabel53.Font = new System.Drawing.Font("Arial", 8.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
        this.xrLabel53.LocationFloat = new DevExpress.Utils.PointFloat(37.41663F, 1211.834F);
        this.xrLabel53.Multiline = true;
        this.xrLabel53.Name = "xrLabel53";
        this.xrLabel53.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel53.SizeF = new System.Drawing.SizeF(191.6666F, 31.25F);
        this.xrLabel53.StylePriority.UseFont = false;
        this.xrLabel53.StylePriority.UseTextAlignment = false;
        this.xrLabel53.Text = "Implementation of the Project";
        this.xrLabel53.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrRichText11
        // 
        this.xrRichText11.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Html", null, "SchemeList.step12Detail")});
        this.xrRichText11.Dpi = 100F;
        this.xrRichText11.Font = new System.Drawing.Font("Arial", 8.75F);
        this.xrRichText11.LocationFloat = new DevExpress.Utils.PointFloat(64.37492F, 1284.75F);
        this.xrRichText11.Name = "xrRichText11";
        this.xrRichText11.SerializableRtfString = resources.GetString("xrRichText11.SerializableRtfString");
        this.xrRichText11.SizeF = new System.Drawing.SizeF(1069.625F, 23.00012F);
        this.xrRichText11.StylePriority.UseFont = false;
        // 
        // xrRichText12
        // 
        this.xrRichText12.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Html", null, "SchemeList.step12Detail2")});
        this.xrRichText12.Dpi = 100F;
        this.xrRichText12.Font = new System.Drawing.Font("Arial", 8.75F);
        this.xrRichText12.LocationFloat = new DevExpress.Utils.PointFloat(62.85413F, 1358.187F);
        this.xrRichText12.Name = "xrRichText12";
        this.xrRichText12.SerializableRtfString = resources.GetString("xrRichText12.SerializableRtfString");
        this.xrRichText12.SizeF = new System.Drawing.SizeF(1071.146F, 23.00012F);
        this.xrRichText12.StylePriority.UseFont = false;
        // 
        // xrRichText10
        // 
        this.xrRichText10.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Html", null, "SchemeList.step11Detail5")});
        this.xrRichText10.Dpi = 100F;
        this.xrRichText10.Font = new System.Drawing.Font("Arial", 8.75F);
        this.xrRichText10.LocationFloat = new DevExpress.Utils.PointFloat(63.4583F, 1178.229F);
        this.xrRichText10.Name = "xrRichText10";
        this.xrRichText10.SerializableRtfString = resources.GetString("xrRichText10.SerializableRtfString");
        this.xrRichText10.SizeF = new System.Drawing.SizeF(1070.542F, 23F);
        this.xrRichText10.StylePriority.UseFont = false;
        // 
        // xrRichText9
        // 
        this.xrRichText9.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Html", null, "SchemeList.step11Detail4")});
        this.xrRichText9.Dpi = 100F;
        this.xrRichText9.Font = new System.Drawing.Font("Arial", 8.75F);
        this.xrRichText9.LocationFloat = new DevExpress.Utils.PointFloat(63.4583F, 1105.312F);
        this.xrRichText9.Name = "xrRichText9";
        this.xrRichText9.SerializableRtfString = resources.GetString("xrRichText9.SerializableRtfString");
        this.xrRichText9.SizeF = new System.Drawing.SizeF(1070.542F, 23F);
        this.xrRichText9.StylePriority.UseFont = false;
        // 
        // xrRichText8
        // 
        this.xrRichText8.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Html", null, "SchemeList.step11Detail3")});
        this.xrRichText8.Dpi = 100F;
        this.xrRichText8.Font = new System.Drawing.Font("Arial", 8.75F);
        this.xrRichText8.LocationFloat = new DevExpress.Utils.PointFloat(63.4583F, 1032.396F);
        this.xrRichText8.Name = "xrRichText8";
        this.xrRichText8.SerializableRtfString = resources.GetString("xrRichText8.SerializableRtfString");
        this.xrRichText8.SizeF = new System.Drawing.SizeF(1070.542F, 23.00012F);
        this.xrRichText8.StylePriority.UseFont = false;
        // 
        // xrRichText7
        // 
        this.xrRichText7.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Html", null, "SchemeList.step11Detail2")});
        this.xrRichText7.Dpi = 100F;
        this.xrRichText7.Font = new System.Drawing.Font("Arial", 8.75F);
        this.xrRichText7.LocationFloat = new DevExpress.Utils.PointFloat(63.45838F, 959.4788F);
        this.xrRichText7.Name = "xrRichText7";
        this.xrRichText7.SerializableRtfString = resources.GetString("xrRichText7.SerializableRtfString");
        this.xrRichText7.SizeF = new System.Drawing.SizeF(1070.542F, 23F);
        this.xrRichText7.StylePriority.UseFont = false;
        // 
        // xrRichText6
        // 
        this.xrRichText6.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Html", null, "SchemeList.step11Detail")});
        this.xrRichText6.Dpi = 100F;
        this.xrRichText6.Font = new System.Drawing.Font("Arial", 8.75F);
        this.xrRichText6.LocationFloat = new DevExpress.Utils.PointFloat(64.97917F, 886.0414F);
        this.xrRichText6.Name = "xrRichText6";
        this.xrRichText6.SerializableRtfString = resources.GetString("xrRichText6.SerializableRtfString");
        this.xrRichText6.SizeF = new System.Drawing.SizeF(1069.021F, 23F);
        this.xrRichText6.StylePriority.UseFont = false;
        // 
        // xrLabel50
        // 
        this.xrLabel50.Dpi = 100F;
        this.xrLabel50.Font = new System.Drawing.Font("Arial", 8.75F, System.Drawing.FontStyle.Bold);
        this.xrLabel50.LocationFloat = new DevExpress.Utils.PointFloat(38.62508F, 1146.979F);
        this.xrLabel50.Multiline = true;
        this.xrLabel50.Name = "xrLabel50";
        this.xrLabel50.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel50.SizeF = new System.Drawing.SizeF(26.04161F, 31.25F);
        this.xrLabel50.StylePriority.UseFont = false;
        this.xrLabel50.StylePriority.UseTextAlignment = false;
        this.xrLabel50.Text = "e.";
        this.xrLabel50.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrLabel51
        // 
        this.xrLabel51.Dpi = 100F;
        this.xrLabel51.Font = new System.Drawing.Font("Arial", 8.75F, System.Drawing.FontStyle.Bold);
        this.xrLabel51.LocationFloat = new DevExpress.Utils.PointFloat(65.58342F, 1146.979F);
        this.xrLabel51.Multiline = true;
        this.xrLabel51.Name = "xrLabel51";
        this.xrLabel51.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel51.SizeF = new System.Drawing.SizeF(283.8957F, 31.25F);
        this.xrLabel51.StylePriority.UseFont = false;
        this.xrLabel51.StylePriority.UseTextAlignment = false;
        this.xrLabel51.Text = "Impact of Delays on Project Cost and Viability";
        this.xrLabel51.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrLabel37
        // 
        this.xrLabel37.Dpi = 100F;
        this.xrLabel37.Font = new System.Drawing.Font("Arial", 8.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
        this.xrLabel37.LocationFloat = new DevExpress.Utils.PointFloat(38.02085F, 813.125F);
        this.xrLabel37.Multiline = true;
        this.xrLabel37.Name = "xrLabel37";
        this.xrLabel37.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel37.SizeF = new System.Drawing.SizeF(191.6666F, 31.25F);
        this.xrLabel37.StylePriority.UseFont = false;
        this.xrLabel37.StylePriority.UseTextAlignment = false;
        this.xrLabel37.Text = "Project Benefits and Analysis";
        this.xrLabel37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrLabel38
        // 
        this.xrLabel38.Dpi = 100F;
        this.xrLabel38.Font = new System.Drawing.Font("Arial", 8.75F, System.Drawing.FontStyle.Bold);
        this.xrLabel38.LocationFloat = new DevExpress.Utils.PointFloat(11.97924F, 813.125F);
        this.xrLabel38.Multiline = true;
        this.xrLabel38.Name = "xrLabel38";
        this.xrLabel38.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel38.SizeF = new System.Drawing.SizeF(26.04161F, 31.25F);
        this.xrLabel38.StylePriority.UseFont = false;
        this.xrLabel38.StylePriority.UseTextAlignment = false;
        this.xrLabel38.Text = "9.";
        this.xrLabel38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrLabel39
        // 
        this.xrLabel39.Dpi = 100F;
        this.xrLabel39.Font = new System.Drawing.Font("Arial", 8.75F, System.Drawing.FontStyle.Bold);
        this.xrLabel39.LocationFloat = new DevExpress.Utils.PointFloat(64.20841F, 854.7914F);
        this.xrLabel39.Multiline = true;
        this.xrLabel39.Name = "xrLabel39";
        this.xrLabel39.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel39.SizeF = new System.Drawing.SizeF(191.6666F, 31.25F);
        this.xrLabel39.StylePriority.UseFont = false;
        this.xrLabel39.StylePriority.UseTextAlignment = false;
        this.xrLabel39.Text = "Financial";
        this.xrLabel39.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrLabel40
        // 
        this.xrLabel40.Dpi = 100F;
        this.xrLabel40.Font = new System.Drawing.Font("Arial", 8.75F, System.Drawing.FontStyle.Bold);
        this.xrLabel40.LocationFloat = new DevExpress.Utils.PointFloat(38.16674F, 854.7914F);
        this.xrLabel40.Multiline = true;
        this.xrLabel40.Name = "xrLabel40";
        this.xrLabel40.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel40.SizeF = new System.Drawing.SizeF(26.04161F, 31.25F);
        this.xrLabel40.StylePriority.UseFont = false;
        this.xrLabel40.StylePriority.UseTextAlignment = false;
        this.xrLabel40.Text = "a.";
        this.xrLabel40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrLabel42
        // 
        this.xrLabel42.Dpi = 100F;
        this.xrLabel42.Font = new System.Drawing.Font("Arial", 8.75F, System.Drawing.FontStyle.Bold);
        this.xrLabel42.LocationFloat = new DevExpress.Utils.PointFloat(64.20841F, 928.2288F);
        this.xrLabel42.Multiline = true;
        this.xrLabel42.Name = "xrLabel42";
        this.xrLabel42.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel42.SizeF = new System.Drawing.SizeF(191.6666F, 31.25F);
        this.xrLabel42.StylePriority.UseFont = false;
        this.xrLabel42.StylePriority.UseTextAlignment = false;
        this.xrLabel42.Text = "Social Benefits with Indicators";
        this.xrLabel42.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrLabel43
        // 
        this.xrLabel43.Dpi = 100F;
        this.xrLabel43.Font = new System.Drawing.Font("Arial", 8.75F, System.Drawing.FontStyle.Bold);
        this.xrLabel43.LocationFloat = new DevExpress.Utils.PointFloat(38.16674F, 928.2288F);
        this.xrLabel43.Multiline = true;
        this.xrLabel43.Name = "xrLabel43";
        this.xrLabel43.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel43.SizeF = new System.Drawing.SizeF(26.04161F, 31.25F);
        this.xrLabel43.StylePriority.UseFont = false;
        this.xrLabel43.StylePriority.UseTextAlignment = false;
        this.xrLabel43.Text = "b.";
        this.xrLabel43.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrLabel45
        // 
        this.xrLabel45.Dpi = 100F;
        this.xrLabel45.Font = new System.Drawing.Font("Arial", 8.75F, System.Drawing.FontStyle.Bold);
        this.xrLabel45.LocationFloat = new DevExpress.Utils.PointFloat(64.66675F, 1001.146F);
        this.xrLabel45.Multiline = true;
        this.xrLabel45.Name = "xrLabel45";
        this.xrLabel45.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel45.SizeF = new System.Drawing.SizeF(284.8123F, 31.25006F);
        this.xrLabel45.StylePriority.UseFont = false;
        this.xrLabel45.StylePriority.UseTextAlignment = false;
        this.xrLabel45.Text = "Employment Generation (Direct and Indirect)";
        this.xrLabel45.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrLabel46
        // 
        this.xrLabel46.Dpi = 100F;
        this.xrLabel46.Font = new System.Drawing.Font("Arial", 8.75F, System.Drawing.FontStyle.Bold);
        this.xrLabel46.LocationFloat = new DevExpress.Utils.PointFloat(38.16676F, 1001.146F);
        this.xrLabel46.Multiline = true;
        this.xrLabel46.Name = "xrLabel46";
        this.xrLabel46.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel46.SizeF = new System.Drawing.SizeF(26.04161F, 31.25F);
        this.xrLabel46.StylePriority.UseFont = false;
        this.xrLabel46.StylePriority.UseTextAlignment = false;
        this.xrLabel46.Text = "c.";
        this.xrLabel46.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrLabel48
        // 
        this.xrLabel48.Dpi = 100F;
        this.xrLabel48.Font = new System.Drawing.Font("Arial", 8.75F, System.Drawing.FontStyle.Bold);
        this.xrLabel48.LocationFloat = new DevExpress.Utils.PointFloat(64.20841F, 1074.062F);
        this.xrLabel48.Multiline = true;
        this.xrLabel48.Name = "xrLabel48";
        this.xrLabel48.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel48.SizeF = new System.Drawing.SizeF(191.6666F, 31.25F);
        this.xrLabel48.StylePriority.UseFont = false;
        this.xrLabel48.StylePriority.UseTextAlignment = false;
        this.xrLabel48.Text = "Environmental Impact";
        this.xrLabel48.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrLabel49
        // 
        this.xrLabel49.Dpi = 100F;
        this.xrLabel49.Font = new System.Drawing.Font("Arial", 8.75F, System.Drawing.FontStyle.Bold);
        this.xrLabel49.LocationFloat = new DevExpress.Utils.PointFloat(38.16674F, 1074.062F);
        this.xrLabel49.Multiline = true;
        this.xrLabel49.Name = "xrLabel49";
        this.xrLabel49.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel49.SizeF = new System.Drawing.SizeF(26.04161F, 31.25F);
        this.xrLabel49.StylePriority.UseFont = false;
        this.xrLabel49.StylePriority.UseTextAlignment = false;
        this.xrLabel49.Text = "d.";
        this.xrLabel49.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrLabel34
        // 
        this.xrLabel34.Dpi = 100F;
        this.xrLabel34.Font = new System.Drawing.Font("Arial", 8.75F, System.Drawing.FontStyle.Bold);
        this.xrLabel34.LocationFloat = new DevExpress.Utils.PointFloat(10.45828F, 748.4581F);
        this.xrLabel34.Multiline = true;
        this.xrLabel34.Name = "xrLabel34";
        this.xrLabel34.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel34.SizeF = new System.Drawing.SizeF(26.04161F, 31.25F);
        this.xrLabel34.StylePriority.UseFont = false;
        this.xrLabel34.StylePriority.UseTextAlignment = false;
        this.xrLabel34.Text = "8.";
        this.xrLabel34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrLabel35
        // 
        this.xrLabel35.Dpi = 100F;
        this.xrLabel35.Font = new System.Drawing.Font("Arial", 8.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
        this.xrLabel35.LocationFloat = new DevExpress.Utils.PointFloat(36.95828F, 748.4581F);
        this.xrLabel35.Multiline = true;
        this.xrLabel35.Name = "xrLabel35";
        this.xrLabel35.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel35.SizeF = new System.Drawing.SizeF(311.4583F, 31.25F);
        this.xrLabel35.StylePriority.UseFont = false;
        this.xrLabel35.StylePriority.UseTextAlignment = false;
        this.xrLabel35.Text = "Financial Plan";
        this.xrLabel35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrRichText5
        // 
        this.xrRichText5.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Html", null, "SchemeList.step10Detail")});
        this.xrRichText5.Dpi = 100F;
        this.xrRichText5.Font = new System.Drawing.Font("Arial", 8.75F);
        this.xrRichText5.LocationFloat = new DevExpress.Utils.PointFloat(36.95828F, 779.7081F);
        this.xrRichText5.Name = "xrRichText5";
        this.xrRichText5.SerializableRtfString = resources.GetString("xrRichText5.SerializableRtfString");
        this.xrRichText5.SizeF = new System.Drawing.SizeF(1097.042F, 23F);
        this.xrRichText5.StylePriority.UseFont = false;
        // 
        // xrLabel32
        // 
        this.xrLabel32.Dpi = 100F;
        this.xrLabel32.Font = new System.Drawing.Font("Arial", 8.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
        this.xrLabel32.LocationFloat = new DevExpress.Utils.PointFloat(38.02085F, 683.7915F);
        this.xrLabel32.Multiline = true;
        this.xrLabel32.Name = "xrLabel32";
        this.xrLabel32.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel32.SizeF = new System.Drawing.SizeF(311.4583F, 31.25F);
        this.xrLabel32.StylePriority.UseFont = false;
        this.xrLabel32.StylePriority.UseTextAlignment = false;
        this.xrLabel32.Text = "Demand Supply Analysis";
        this.xrLabel32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrRichText4
        // 
        this.xrRichText4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Html", null, "SchemeList.step9Detail")});
        this.xrRichText4.Dpi = 100F;
        this.xrRichText4.Font = new System.Drawing.Font("Arial", 8.75F);
        this.xrRichText4.LocationFloat = new DevExpress.Utils.PointFloat(38.02085F, 715.0415F);
        this.xrRichText4.Name = "xrRichText4";
        this.xrRichText4.SerializableRtfString = resources.GetString("xrRichText4.SerializableRtfString");
        this.xrRichText4.SizeF = new System.Drawing.SizeF(1095.979F, 23F);
        this.xrRichText4.StylePriority.UseFont = false;
        // 
        // xrLabel33
        // 
        this.xrLabel33.Dpi = 100F;
        this.xrLabel33.Font = new System.Drawing.Font("Arial", 8.75F, System.Drawing.FontStyle.Bold);
        this.xrLabel33.LocationFloat = new DevExpress.Utils.PointFloat(11.52085F, 683.7915F);
        this.xrLabel33.Multiline = true;
        this.xrLabel33.Name = "xrLabel33";
        this.xrLabel33.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel33.SizeF = new System.Drawing.SizeF(26.04161F, 31.25F);
        this.xrLabel33.StylePriority.UseFont = false;
        this.xrLabel33.StylePriority.UseTextAlignment = false;
        this.xrLabel33.Text = "7.";
        this.xrLabel33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrLabel30
        // 
        this.xrLabel30.Dpi = 100F;
        this.xrLabel30.Font = new System.Drawing.Font("Arial", 8.75F, System.Drawing.FontStyle.Bold);
        this.xrLabel30.LocationFloat = new DevExpress.Utils.PointFloat(10.91661F, 619.1249F);
        this.xrLabel30.Multiline = true;
        this.xrLabel30.Name = "xrLabel30";
        this.xrLabel30.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel30.SizeF = new System.Drawing.SizeF(26.04161F, 31.25F);
        this.xrLabel30.StylePriority.UseFont = false;
        this.xrLabel30.StylePriority.UseTextAlignment = false;
        this.xrLabel30.Text = "6.";
        this.xrLabel30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrLabel31
        // 
        this.xrLabel31.Dpi = 100F;
        this.xrLabel31.Font = new System.Drawing.Font("Arial", 8.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
        this.xrLabel31.LocationFloat = new DevExpress.Utils.PointFloat(37.41662F, 619.1249F);
        this.xrLabel31.Multiline = true;
        this.xrLabel31.Name = "xrLabel31";
        this.xrLabel31.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel31.SizeF = new System.Drawing.SizeF(311.4583F, 31.25F);
        this.xrLabel31.StylePriority.UseFont = false;
        this.xrLabel31.StylePriority.UseTextAlignment = false;
        this.xrLabel31.Text = "Description and Justification of Project";
        this.xrLabel31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrRichText3
        // 
        this.xrRichText3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Html", null, "SchemeList.step6Detail")});
        this.xrRichText3.Dpi = 100F;
        this.xrRichText3.Font = new System.Drawing.Font("Arial", 8.75F);
        this.xrRichText3.LocationFloat = new DevExpress.Utils.PointFloat(37.41662F, 650.3748F);
        this.xrRichText3.Name = "xrRichText3";
        this.xrRichText3.SerializableRtfString = resources.GetString("xrRichText3.SerializableRtfString");
        this.xrRichText3.SizeF = new System.Drawing.SizeF(1096.583F, 23F);
        this.xrRichText3.StylePriority.UseFont = false;
        // 
        // xrLabel28
        // 
        this.xrLabel28.Dpi = 100F;
        this.xrLabel28.Font = new System.Drawing.Font("Arial", 8.75F, System.Drawing.FontStyle.Bold);
        this.xrLabel28.LocationFloat = new DevExpress.Utils.PointFloat(10.91661F, 554.0416F);
        this.xrLabel28.Multiline = true;
        this.xrLabel28.Name = "xrLabel28";
        this.xrLabel28.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel28.SizeF = new System.Drawing.SizeF(26.04161F, 31.25F);
        this.xrLabel28.StylePriority.UseFont = false;
        this.xrLabel28.StylePriority.UseTextAlignment = false;
        this.xrLabel28.Text = "5.";
        this.xrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrLabel29
        // 
        this.xrLabel29.Dpi = 100F;
        this.xrLabel29.Font = new System.Drawing.Font("Arial", 8.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
        this.xrLabel29.LocationFloat = new DevExpress.Utils.PointFloat(36.95828F, 554.0416F);
        this.xrLabel29.Multiline = true;
        this.xrLabel29.Name = "xrLabel29";
        this.xrLabel29.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel29.SizeF = new System.Drawing.SizeF(191.6666F, 31.25F);
        this.xrLabel29.StylePriority.UseFont = false;
        this.xrLabel29.StylePriority.UseTextAlignment = false;
        this.xrLabel29.Text = "Project Objectives";
        this.xrLabel29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrRichText2
        // 
        this.xrRichText2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Html", null, "SchemeList.step5Detail")});
        this.xrRichText2.Dpi = 100F;
        this.xrRichText2.Font = new System.Drawing.Font("Arial", 8.75F);
        this.xrRichText2.LocationFloat = new DevExpress.Utils.PointFloat(37.41662F, 585.2916F);
        this.xrRichText2.Name = "xrRichText2";
        this.xrRichText2.SerializableRtfString = resources.GetString("xrRichText2.SerializableRtfString");
        this.xrRichText2.SizeF = new System.Drawing.SizeF(1096.583F, 23F);
        this.xrRichText2.StylePriority.UseFont = false;
        // 
        // xrRichText1
        // 
        this.xrRichText1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Html", null, "SchemeList.step4Detail")});
        this.xrRichText1.Dpi = 100F;
        this.xrRichText1.Font = new System.Drawing.Font("Arial", 8.75F);
        this.xrRichText1.LocationFloat = new DevExpress.Utils.PointFloat(37.87495F, 520.8333F);
        this.xrRichText1.Name = "xrRichText1";
        this.xrRichText1.SerializableRtfString = resources.GetString("xrRichText1.SerializableRtfString");
        this.xrRichText1.SizeF = new System.Drawing.SizeF(1096.125F, 23F);
        this.xrRichText1.StylePriority.UseFont = false;
        // 
        // xrLabel26
        // 
        this.xrLabel26.Dpi = 100F;
        this.xrLabel26.Font = new System.Drawing.Font("Arial", 8.75F, System.Drawing.FontStyle.Bold);
        this.xrLabel26.LocationFloat = new DevExpress.Utils.PointFloat(11.37496F, 489.5833F);
        this.xrLabel26.Multiline = true;
        this.xrLabel26.Name = "xrLabel26";
        this.xrLabel26.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel26.SizeF = new System.Drawing.SizeF(26.04161F, 31.25F);
        this.xrLabel26.StylePriority.UseFont = false;
        this.xrLabel26.StylePriority.UseTextAlignment = false;
        this.xrLabel26.Text = "4.";
        this.xrLabel26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrLabel27
        // 
        this.xrLabel27.Dpi = 100F;
        this.xrLabel27.Font = new System.Drawing.Font("Arial", 8.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
        this.xrLabel27.LocationFloat = new DevExpress.Utils.PointFloat(37.41663F, 489.5833F);
        this.xrLabel27.Multiline = true;
        this.xrLabel27.Name = "xrLabel27";
        this.xrLabel27.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel27.SizeF = new System.Drawing.SizeF(191.6666F, 31.25F);
        this.xrLabel27.StylePriority.UseFont = false;
        this.xrLabel27.StylePriority.UseTextAlignment = false;
        this.xrLabel27.Text = "Plan Provision";
        this.xrLabel27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrLabel23
        // 
        this.xrLabel23.Dpi = 100F;
        this.xrLabel23.Font = new System.Drawing.Font("Arial", 8.75F, System.Drawing.FontStyle.Bold);
        this.xrLabel23.LocationFloat = new DevExpress.Utils.PointFloat(38.02083F, 416.6667F);
        this.xrLabel23.Multiline = true;
        this.xrLabel23.Name = "xrLabel23";
        this.xrLabel23.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel23.SizeF = new System.Drawing.SizeF(26.04161F, 31.25F);
        this.xrLabel23.StylePriority.UseFont = false;
        this.xrLabel23.StylePriority.UseTextAlignment = false;
        this.xrLabel23.Text = "d.";
        this.xrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrLabel24
        // 
        this.xrLabel24.Dpi = 100F;
        this.xrLabel24.Font = new System.Drawing.Font("Arial", 8.75F, System.Drawing.FontStyle.Bold);
        this.xrLabel24.LocationFloat = new DevExpress.Utils.PointFloat(64.0625F, 416.6667F);
        this.xrLabel24.Multiline = true;
        this.xrLabel24.Name = "xrLabel24";
        this.xrLabel24.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel24.SizeF = new System.Drawing.SizeF(191.6666F, 31.25F);
        this.xrLabel24.StylePriority.UseFont = false;
        this.xrLabel24.StylePriority.UseTextAlignment = false;
        this.xrLabel24.Text = "Concerned Provincial Ministry";
        this.xrLabel24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrLabel25
        // 
        this.xrLabel25.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ConcernedProvincialMinistryTitle")});
        this.xrLabel25.Dpi = 100F;
        this.xrLabel25.Font = new System.Drawing.Font("Arial", 8.75F);
        this.xrLabel25.LocationFloat = new DevExpress.Utils.PointFloat(64.52084F, 447.9167F);
        this.xrLabel25.Multiline = true;
        this.xrLabel25.Name = "xrLabel25";
        this.xrLabel25.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel25.SizeF = new System.Drawing.SizeF(1069.479F, 31.25F);
        this.xrLabel25.StylePriority.UseFont = false;
        this.xrLabel25.StylePriority.UseTextAlignment = false;
        this.xrLabel25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrLabel20
        // 
        this.xrLabel20.Dpi = 100F;
        this.xrLabel20.Font = new System.Drawing.Font("Arial", 8.75F, System.Drawing.FontStyle.Bold);
        this.xrLabel20.LocationFloat = new DevExpress.Utils.PointFloat(38.02085F, 343.75F);
        this.xrLabel20.Multiline = true;
        this.xrLabel20.Name = "xrLabel20";
        this.xrLabel20.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel20.SizeF = new System.Drawing.SizeF(26.04161F, 31.25F);
        this.xrLabel20.StylePriority.UseFont = false;
        this.xrLabel20.StylePriority.UseTextAlignment = false;
        this.xrLabel20.Text = "c.";
        this.xrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrLabel21
        // 
        this.xrLabel21.Dpi = 100F;
        this.xrLabel21.Font = new System.Drawing.Font("Arial", 8.75F, System.Drawing.FontStyle.Bold);
        this.xrLabel21.LocationFloat = new DevExpress.Utils.PointFloat(64.06252F, 343.75F);
        this.xrLabel21.Multiline = true;
        this.xrLabel21.Name = "xrLabel21";
        this.xrLabel21.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel21.SizeF = new System.Drawing.SizeF(191.6666F, 31.25F);
        this.xrLabel21.StylePriority.UseFont = false;
        this.xrLabel21.StylePriority.UseTextAlignment = false;
        this.xrLabel21.Text = "Operation Maintenance";
        this.xrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrLabel22
        // 
        this.xrLabel22.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.OperationMaintenanceTitle")});
        this.xrLabel22.Dpi = 100F;
        this.xrLabel22.Font = new System.Drawing.Font("Arial", 8.75F);
        this.xrLabel22.LocationFloat = new DevExpress.Utils.PointFloat(64.52085F, 375F);
        this.xrLabel22.Multiline = true;
        this.xrLabel22.Name = "xrLabel22";
        this.xrLabel22.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel22.SizeF = new System.Drawing.SizeF(1069.479F, 31.25F);
        this.xrLabel22.StylePriority.UseFont = false;
        this.xrLabel22.StylePriority.UseTextAlignment = false;
        this.xrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrLabel17
        // 
        this.xrLabel17.Dpi = 100F;
        this.xrLabel17.Font = new System.Drawing.Font("Arial", 8.75F, System.Drawing.FontStyle.Bold);
        this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(38.02083F, 270.8333F);
        this.xrLabel17.Multiline = true;
        this.xrLabel17.Name = "xrLabel17";
        this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel17.SizeF = new System.Drawing.SizeF(26.04161F, 31.25F);
        this.xrLabel17.StylePriority.UseFont = false;
        this.xrLabel17.StylePriority.UseTextAlignment = false;
        this.xrLabel17.Text = "b.";
        this.xrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrLabel18
        // 
        this.xrLabel18.Dpi = 100F;
        this.xrLabel18.Font = new System.Drawing.Font("Arial", 8.75F, System.Drawing.FontStyle.Bold);
        this.xrLabel18.LocationFloat = new DevExpress.Utils.PointFloat(64.0625F, 270.8333F);
        this.xrLabel18.Multiline = true;
        this.xrLabel18.Name = "xrLabel18";
        this.xrLabel18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel18.SizeF = new System.Drawing.SizeF(191.6666F, 31.25F);
        this.xrLabel18.StylePriority.UseFont = false;
        this.xrLabel18.StylePriority.UseTextAlignment = false;
        this.xrLabel18.Text = "Execution";
        this.xrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrLabel19
        // 
        this.xrLabel19.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.ExecutionTitle")});
        this.xrLabel19.Dpi = 100F;
        this.xrLabel19.Font = new System.Drawing.Font("Arial", 8.75F);
        this.xrLabel19.LocationFloat = new DevExpress.Utils.PointFloat(64.52084F, 302.0833F);
        this.xrLabel19.Multiline = true;
        this.xrLabel19.Name = "xrLabel19";
        this.xrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel19.SizeF = new System.Drawing.SizeF(1069.479F, 31.25F);
        this.xrLabel19.StylePriority.UseFont = false;
        this.xrLabel19.StylePriority.UseTextAlignment = false;
        this.xrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrLabel15
        // 
        this.xrLabel15.Dpi = 100F;
        this.xrLabel15.Font = new System.Drawing.Font("Arial", 8.75F, System.Drawing.FontStyle.Bold);
        this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(38.02083F, 197.3958F);
        this.xrLabel15.Multiline = true;
        this.xrLabel15.Name = "xrLabel15";
        this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel15.SizeF = new System.Drawing.SizeF(26.04161F, 31.25F);
        this.xrLabel15.StylePriority.UseFont = false;
        this.xrLabel15.StylePriority.UseTextAlignment = false;
        this.xrLabel15.Text = "a.";
        this.xrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrLabel16
        // 
        this.xrLabel16.Dpi = 100F;
        this.xrLabel16.Font = new System.Drawing.Font("Arial", 8.75F, System.Drawing.FontStyle.Bold);
        this.xrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(64.0625F, 197.3958F);
        this.xrLabel16.Multiline = true;
        this.xrLabel16.Name = "xrLabel16";
        this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel16.SizeF = new System.Drawing.SizeF(191.6666F, 31.25F);
        this.xrLabel16.StylePriority.UseFont = false;
        this.xrLabel16.StylePriority.UseTextAlignment = false;
        this.xrLabel16.Text = "Sponsoring";
        this.xrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrLabel12
        // 
        this.xrLabel12.Dpi = 100F;
        this.xrLabel12.Font = new System.Drawing.Font("Arial", 8.75F, System.Drawing.FontStyle.Bold);
        this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(11.83333F, 155.7292F);
        this.xrLabel12.Multiline = true;
        this.xrLabel12.Name = "xrLabel12";
        this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel12.SizeF = new System.Drawing.SizeF(26.04161F, 31.25F);
        this.xrLabel12.StylePriority.UseFont = false;
        this.xrLabel12.StylePriority.UseTextAlignment = false;
        this.xrLabel12.Text = "3.";
        this.xrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrLabel13
        // 
        this.xrLabel13.Dpi = 100F;
        this.xrLabel13.Font = new System.Drawing.Font("Arial", 8.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
        this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(37.87495F, 155.7292F);
        this.xrLabel13.Multiline = true;
        this.xrLabel13.Name = "xrLabel13";
        this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel13.SizeF = new System.Drawing.SizeF(191.6666F, 31.25F);
        this.xrLabel13.StylePriority.UseFont = false;
        this.xrLabel13.StylePriority.UseTextAlignment = false;
        this.xrLabel13.Text = "Authorities Responsible for";
        this.xrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrLabel14
        // 
        this.xrLabel14.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.SponsoringTitle")});
        this.xrLabel14.Dpi = 100F;
        this.xrLabel14.Font = new System.Drawing.Font("Arial", 8.75F);
        this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(64.52084F, 228.6458F);
        this.xrLabel14.Multiline = true;
        this.xrLabel14.Name = "xrLabel14";
        this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel14.SizeF = new System.Drawing.SizeF(1069.479F, 31.24998F);
        this.xrLabel14.StylePriority.UseFont = false;
        this.xrLabel14.StylePriority.UseTextAlignment = false;
        this.xrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrLabel9
        // 
        this.xrLabel9.Dpi = 100F;
        this.xrLabel9.Font = new System.Drawing.Font("Arial", 8.75F, System.Drawing.FontStyle.Bold);
        this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(11.375F, 82.8125F);
        this.xrLabel9.Multiline = true;
        this.xrLabel9.Name = "xrLabel9";
        this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel9.SizeF = new System.Drawing.SizeF(26.04161F, 31.25F);
        this.xrLabel9.StylePriority.UseFont = false;
        this.xrLabel9.StylePriority.UseTextAlignment = false;
        this.xrLabel9.Text = "2.";
        this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrLabel10
        // 
        this.xrLabel10.Dpi = 100F;
        this.xrLabel10.Font = new System.Drawing.Font("Arial", 8.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
        this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(37.41662F, 82.8125F);
        this.xrLabel10.Multiline = true;
        this.xrLabel10.Name = "xrLabel10";
        this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel10.SizeF = new System.Drawing.SizeF(191.6666F, 31.25F);
        this.xrLabel10.StylePriority.UseFont = false;
        this.xrLabel10.StylePriority.UseTextAlignment = false;
        this.xrLabel10.Text = "Location";
        this.xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrLabel11
        // 
        this.xrLabel11.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.DistrictTitle")});
        this.xrLabel11.Dpi = 100F;
        this.xrLabel11.Font = new System.Drawing.Font("Arial", 8.75F);
        this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(38.33329F, 114.0625F);
        this.xrLabel11.Multiline = true;
        this.xrLabel11.Name = "xrLabel11";
        this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel11.SizeF = new System.Drawing.SizeF(1095.667F, 31.25F);
        this.xrLabel11.StylePriority.UseFont = false;
        this.xrLabel11.StylePriority.UseTextAlignment = false;
        this.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrLabel8
        // 
        this.xrLabel8.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.strSchemeName")});
        this.xrLabel8.Dpi = 100F;
        this.xrLabel8.Font = new System.Drawing.Font("Arial", 8.75F);
        this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(37.87495F, 41.25001F);
        this.xrLabel8.Multiline = true;
        this.xrLabel8.Name = "xrLabel8";
        this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel8.SizeF = new System.Drawing.SizeF(1096.125F, 31.25F);
        this.xrLabel8.StylePriority.UseFont = false;
        this.xrLabel8.StylePriority.UseTextAlignment = false;
        this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrLabel7
        // 
        this.xrLabel7.Dpi = 100F;
        this.xrLabel7.Font = new System.Drawing.Font("Arial", 8.75F, System.Drawing.FontStyle.Bold);
        this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(10.91667F, 10.00001F);
        this.xrLabel7.Multiline = true;
        this.xrLabel7.Name = "xrLabel7";
        this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel7.SizeF = new System.Drawing.SizeF(26.04161F, 31.25F);
        this.xrLabel7.StylePriority.UseFont = false;
        this.xrLabel7.StylePriority.UseTextAlignment = false;
        this.xrLabel7.Text = "1.";
        this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrLabel6
        // 
        this.xrLabel6.Dpi = 100F;
        this.xrLabel6.Font = new System.Drawing.Font("Arial", 8.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
        this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(36.95828F, 10.00001F);
        this.xrLabel6.Multiline = true;
        this.xrLabel6.Name = "xrLabel6";
        this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel6.SizeF = new System.Drawing.SizeF(191.6666F, 31.25F);
        this.xrLabel6.StylePriority.UseFont = false;
        this.xrLabel6.StylePriority.UseTextAlignment = false;
        this.xrLabel6.Text = "Name of the Project";
        this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // TopMargin
        // 
        this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel5,
            this.xrLabel4,
            this.xrLabel2,
            this.xrLabel1});
        this.TopMargin.Dpi = 100F;
        this.TopMargin.HeightF = 234F;
        this.TopMargin.Name = "TopMargin";
        this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
        this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        // 
        // xrLabel5
        // 
        this.xrLabel5.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.prModified, "Text", "")});
        this.xrLabel5.Dpi = 100F;
        this.xrLabel5.Font = new System.Drawing.Font("Arial", 12F);
        this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(726.7086F, 10.00001F);
        this.xrLabel5.Multiline = true;
        this.xrLabel5.Name = "xrLabel5";
        this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel5.SizeF = new System.Drawing.SizeF(407.2915F, 31.25F);
        this.xrLabel5.StylePriority.UseFont = false;
        this.xrLabel5.StylePriority.UseTextAlignment = false;
        this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
        // 
        // prModified
        // 
        this.prModified.Description = "Modified";
        this.prModified.Name = "prModified";
        this.prModified.Visible = false;
        // 
        // xrLabel4
        // 
        this.xrLabel4.Dpi = 100F;
        this.xrLabel4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
        this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(275.6459F, 146.1667F);
        this.xrLabel4.Multiline = true;
        this.xrLabel4.Name = "xrLabel4";
        this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel4.SizeF = new System.Drawing.SizeF(592.7082F, 31.25F);
        this.xrLabel4.StylePriority.UseFont = false;
        this.xrLabel4.StylePriority.UseTextAlignment = false;
        this.xrLabel4.Text = "(SOCIAL SECTORS)";
        this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrLabel2
        // 
        this.xrLabel2.BackColor = System.Drawing.Color.LightGray;
        this.xrLabel2.Dpi = 100F;
        this.xrLabel2.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
        this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(500.6459F, 115.9583F);
        this.xrLabel2.Multiline = true;
        this.xrLabel2.Name = "xrLabel2";
        this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel2.SizeF = new System.Drawing.SizeF(142.7082F, 30.20833F);
        this.xrLabel2.StylePriority.UseBackColor = false;
        this.xrLabel2.StylePriority.UseFont = false;
        this.xrLabel2.StylePriority.UseTextAlignment = false;
        this.xrLabel2.Text = "PC-1 FORM";
        this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrLabel1
        // 
        this.xrLabel1.Dpi = 100F;
        this.xrLabel1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
        this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(275.6459F, 56.58334F);
        this.xrLabel1.Multiline = true;
        this.xrLabel1.Name = "xrLabel1";
        this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel1.SizeF = new System.Drawing.SizeF(592.7082F, 59.375F);
        this.xrLabel1.StylePriority.UseFont = false;
        this.xrLabel1.StylePriority.UseTextAlignment = false;
        this.xrLabel1.Text = "GOVERNMENT OF PAKISTAN\r\nPLANNING COMMISSION";
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
        this.PageFooter.HeightF = 37.5F;
        this.PageFooter.Name = "PageFooter";
        // 
        // xrLabel3
        // 
        this.xrLabel3.Dpi = 100F;
        this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(362.5F, 12.5F);
        this.xrLabel3.Name = "xrLabel3";
        this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel3.SizeF = new System.Drawing.SizeF(424.9999F, 23F);
        this.xrLabel3.StylePriority.UseTextAlignment = false;
        this.xrLabel3.Text = System.Configuration.ConfigurationManager.AppSettings["FooterText"];
        this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // DetailReport
        // 
        this.DetailReport.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail1,
            this.DetailReport1,
            this.DetailReport3});
        this.DetailReport.DataMember = "SchemeList";
        this.DetailReport.DataSource = this.bindingSource1;
        this.DetailReport.Dpi = 100F;
        this.DetailReport.Level = 0;
        this.DetailReport.Name = "DetailReport";
        // 
        // Detail1
        // 
        this.Detail1.Dpi = 100F;
        this.Detail1.Expanded = false;
        this.Detail1.HeightF = 0F;
        this.Detail1.Name = "Detail1";
        // 
        // DetailReport1
        // 
        this.DetailReport1.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail2,
            this.DetailReport2,
            this.GroupHeader1,
            this.GroupFooter1,
            this.GroupHeader3});
        this.DetailReport1.DataMember = "SchemeList.SchemeCapitalCostEstimateList";
        this.DetailReport1.DataSource = this.bindingSource1;
        this.DetailReport1.Dpi = 100F;
        this.DetailReport1.Level = 0;
        this.DetailReport1.Name = "DetailReport1";
        // 
        // Detail2
        // 
        this.Detail2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable2});
        this.Detail2.Dpi = 100F;
        this.Detail2.HeightF = 25F;
        this.Detail2.Name = "Detail2";
        // 
        // DetailReport2
        // 
        this.DetailReport2.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail3,
            this.DetailReport5});
        this.DetailReport2.DataMember = "SchemeList.SchemeCapitalCostEstimateList.FinancialYearList";
        this.DetailReport2.DataSource = this.bindingSource1;
        this.DetailReport2.Dpi = 100F;
        this.DetailReport2.Level = 0;
        this.DetailReport2.Name = "DetailReport2";
        // 
        // Detail3
        // 
        this.Detail3.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable4});
        this.Detail3.Dpi = 100F;
        this.Detail3.HeightF = 25F;
        this.Detail3.Name = "Detail3";
        // 
        // GroupHeader1
        // 
        this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel60,
            this.xrLabel61});
        this.GroupHeader1.Dpi = 100F;
        this.GroupHeader1.HeightF = 43.12499F;
        this.GroupHeader1.Level = 1;
        this.GroupHeader1.Name = "GroupHeader1";
        // 
        // xrLabel60
        // 
        this.xrLabel60.Dpi = 100F;
        this.xrLabel60.Font = new System.Drawing.Font("Arial", 8.75F, System.Drawing.FontStyle.Bold);
        this.xrLabel60.LocationFloat = new DevExpress.Utils.PointFloat(9.541638F, 0F);
        this.xrLabel60.Multiline = true;
        this.xrLabel60.Name = "xrLabel60";
        this.xrLabel60.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel60.SizeF = new System.Drawing.SizeF(26.04161F, 31.25F);
        this.xrLabel60.StylePriority.UseFont = false;
        this.xrLabel60.StylePriority.UseTextAlignment = false;
        this.xrLabel60.Text = "14.";
        this.xrLabel60.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrLabel61
        // 
        this.xrLabel61.Dpi = 100F;
        this.xrLabel61.Font = new System.Drawing.Font("Arial", 8.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
        this.xrLabel61.LocationFloat = new DevExpress.Utils.PointFloat(36.04161F, 0F);
        this.xrLabel61.Multiline = true;
        this.xrLabel61.Name = "xrLabel61";
        this.xrLabel61.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel61.SizeF = new System.Drawing.SizeF(311.4583F, 31.25F);
        this.xrLabel61.StylePriority.UseFont = false;
        this.xrLabel61.StylePriority.UseTextAlignment = false;
        this.xrLabel61.Text = "Capital Cost Estimates";
        this.xrLabel61.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // DetailReport3
        // 
        this.DetailReport3.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail4,
            this.DetailReport4,
            this.GroupHeader4,
            this.GroupHeader5,
            this.GroupFooter2});
        this.DetailReport3.DataMember = "SchemeList.SchemeAnnualOperatingCostList";
        this.DetailReport3.DataSource = this.bindingSource1;
        this.DetailReport3.Dpi = 100F;
        this.DetailReport3.Level = 1;
        this.DetailReport3.Name = "DetailReport3";
        // 
        // Detail4
        // 
        this.Detail4.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable8});
        this.Detail4.Dpi = 100F;
        this.Detail4.HeightF = 25F;
        this.Detail4.Name = "Detail4";
        // 
        // DetailReport4
        // 
        this.DetailReport4.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail5,
            this.GroupHeader6});
        this.DetailReport4.DataMember = "SchemeList.SchemeAnnualOperatingCostList.SchemeAnnualOperatingCostDetailList";
        this.DetailReport4.DataSource = this.bindingSource1;
        this.DetailReport4.Dpi = 100F;
        this.DetailReport4.Level = 0;
        this.DetailReport4.Name = "DetailReport4";
        // 
        // Detail5
        // 
        this.Detail5.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable11});
        this.Detail5.Dpi = 100F;
        this.Detail5.HeightF = 25F;
        this.Detail5.Name = "Detail5";
        // 
        // xrTable1
        // 
        this.xrTable1.BackColor = System.Drawing.Color.LightGray;
        this.xrTable1.Dpi = 100F;
        this.xrTable1.Font = new System.Drawing.Font("Arial", 8.75F, System.Drawing.FontStyle.Bold);
        this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(36.04161F, 0F);
        this.xrTable1.Name = "xrTable1";
        this.xrTable1.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
        this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
        this.xrTable1.SizeF = new System.Drawing.SizeF(1098.875F, 40F);
        this.xrTable1.StylePriority.UseBackColor = false;
        this.xrTable1.StylePriority.UseFont = false;
        this.xrTable1.StylePriority.UsePadding = false;
        this.xrTable1.StylePriority.UseTextAlignment = false;
        this.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrTableRow1
        // 
        this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell29,
            this.xrTableCell30});
        this.xrTableRow1.Dpi = 100F;
        this.xrTableRow1.Name = "xrTableRow1";
        this.xrTableRow1.Weight = 1D;
        // 
        // xrTableCell1
        // 
        this.xrTableCell1.Dpi = 100F;
        this.xrTableCell1.Name = "xrTableCell1";
        this.xrTableCell1.Text = "Title";
        this.xrTableCell1.Weight = 1.6926407548271987D;
        // 
        // xrTableCell29
        // 
        this.xrTableCell29.Dpi = 100F;
        this.xrTableCell29.Name = "xrTableCell29";
        this.xrTableCell29.StylePriority.UseTextAlignment = false;
        this.xrTableCell29.Text = "Group";
        this.xrTableCell29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        this.xrTableCell29.Weight = 1.6380394245817056D;
        // 
        // xrTableCell30
        // 
        this.xrTableCell30.Dpi = 100F;
        this.xrTableCell30.Name = "xrTableCell30";
        this.xrTableCell30.StylePriority.UseTextAlignment = false;
        this.xrTableCell30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell30.Weight = 0.669319820591096D;
        // 
        // xrTable2
        // 
        this.xrTable2.BackColor = System.Drawing.Color.White;
        this.xrTable2.Dpi = 100F;
        this.xrTable2.Font = new System.Drawing.Font("Arial", 8.75F);
        this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(36.04161F, 0F);
        this.xrTable2.Name = "xrTable2";
        this.xrTable2.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
        this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
        this.xrTable2.SizeF = new System.Drawing.SizeF(1098.875F, 25F);
        this.xrTable2.StylePriority.UseBackColor = false;
        this.xrTable2.StylePriority.UseFont = false;
        this.xrTable2.StylePriority.UsePadding = false;
        this.xrTable2.StylePriority.UseTextAlignment = false;
        this.xrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrTableRow2
        // 
        this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell2,
            this.xrTableCell3,
            this.xrTableCell4});
        this.xrTableRow2.Dpi = 100F;
        this.xrTableRow2.Name = "xrTableRow2";
        this.xrTableRow2.Weight = 1D;
        // 
        // xrTableCell2
        // 
        this.xrTableCell2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.SchemeCapitalCostEstimateList.Title")});
        this.xrTableCell2.Dpi = 100F;
        this.xrTableCell2.Name = "xrTableCell2";
        this.xrTableCell2.StylePriority.UseTextAlignment = false;
        this.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        this.xrTableCell2.Weight = 1.6899782297674368D;
        // 
        // xrTableCell3
        // 
        this.xrTableCell3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.SchemeCapitalCostEstimateList.GroupTitle")});
        this.xrTableCell3.Dpi = 100F;
        this.xrTableCell3.Name = "xrTableCell3";
        this.xrTableCell3.StylePriority.UseTextAlignment = false;
        this.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        this.xrTableCell3.Weight = 1.6365214253768639D;
        // 
        // xrTableCell4
        // 
        this.xrTableCell4.Dpi = 100F;
        this.xrTableCell4.Name = "xrTableCell4";
        this.xrTableCell4.StylePriority.UseTextAlignment = false;
        this.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell4.Weight = 0.67350034485569954D;
        // 
        // xrTable3
        // 
        this.xrTable3.BackColor = System.Drawing.Color.White;
        this.xrTable3.Dpi = 100F;
        this.xrTable3.Font = new System.Drawing.Font("Arial", 8.75F);
        this.xrTable3.LocationFloat = new DevExpress.Utils.PointFloat(36.49995F, 0F);
        this.xrTable3.Name = "xrTable3";
        this.xrTable3.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
        this.xrTable3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow3});
        this.xrTable3.SizeF = new System.Drawing.SizeF(1098.875F, 25F);
        this.xrTable3.StylePriority.UseBackColor = false;
        this.xrTable3.StylePriority.UseFont = false;
        this.xrTable3.StylePriority.UsePadding = false;
        this.xrTable3.StylePriority.UseTextAlignment = false;
        this.xrTable3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrTableRow3
        // 
        this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell5,
            this.xrTableCell6,
            this.xrTableCell7});
        this.xrTableRow3.Dpi = 100F;
        this.xrTableRow3.Name = "xrTableRow3";
        this.xrTableRow3.Weight = 1D;
        // 
        // xrTableCell5
        // 
        this.xrTableCell5.Dpi = 100F;
        this.xrTableCell5.Name = "xrTableCell5";
        this.xrTableCell5.StylePriority.UseTextAlignment = false;
        this.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        this.xrTableCell5.Weight = 1.6899782297674368D;
        // 
        // xrTableCell6
        // 
        this.xrTableCell6.Dpi = 100F;
        this.xrTableCell6.Font = new System.Drawing.Font("Arial", 8.75F, System.Drawing.FontStyle.Bold);
        this.xrTableCell6.Name = "xrTableCell6";
        this.xrTableCell6.StylePriority.UseFont = false;
        this.xrTableCell6.StylePriority.UseTextAlignment = false;
        this.xrTableCell6.Text = "Total";
        this.xrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
        this.xrTableCell6.Weight = 1.6365214253768639D;
        // 
        // xrTableCell7
        // 
        this.xrTableCell7.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.SchemeCapitalCostEstimateList.FinancialYearList.SchemeCapitalCostEstim" +
                    "ateDetailList.cfTotalCapitalCostEstimate")});
        this.xrTableCell7.Dpi = 100F;
        this.xrTableCell7.Name = "xrTableCell7";
        this.xrTableCell7.StylePriority.UseTextAlignment = false;
        xrSummary1.FormatString = "{0:#,#}";
        xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell7.Summary = xrSummary1;
        this.xrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell7.Weight = 0.67350034485569954D;
        // 
        // xrTable4
        // 
        this.xrTable4.BackColor = System.Drawing.Color.LightGray;
        this.xrTable4.Dpi = 100F;
        this.xrTable4.Font = new System.Drawing.Font("Arial", 8.75F, System.Drawing.FontStyle.Bold);
        this.xrTable4.LocationFloat = new DevExpress.Utils.PointFloat(37.41662F, 0F);
        this.xrTable4.Name = "xrTable4";
        this.xrTable4.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
        this.xrTable4.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow4});
        this.xrTable4.SizeF = new System.Drawing.SizeF(1096.583F, 25F);
        this.xrTable4.StylePriority.UseBackColor = false;
        this.xrTable4.StylePriority.UseFont = false;
        this.xrTable4.StylePriority.UsePadding = false;
        this.xrTable4.StylePriority.UseTextAlignment = false;
        this.xrTable4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrTableRow4
        // 
        this.xrTableRow4.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell8});
        this.xrTableRow4.Dpi = 100F;
        this.xrTableRow4.Name = "xrTableRow4";
        this.xrTableRow4.Weight = 1D;
        // 
        // xrTableCell8
        // 
        this.xrTableCell8.BackColor = System.Drawing.Color.AntiqueWhite;
        this.xrTableCell8.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.SchemeCapitalCostEstimateList.FinancialYearList.YearName")});
        this.xrTableCell8.Dpi = 100F;
        this.xrTableCell8.Name = "xrTableCell8";
        this.xrTableCell8.StylePriority.UseBackColor = false;
        this.xrTableCell8.Weight = 1.6899782297674368D;
        // 
        // DetailReport5
        // 
        this.DetailReport5.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail6,
            this.GroupHeader2});
        this.DetailReport5.DataMember = "SchemeList.SchemeCapitalCostEstimateList.FinancialYearList.SchemeCapitalCostEstim" +
"ateDetailList";
        this.DetailReport5.DataSource = this.bindingSource1;
        this.DetailReport5.Dpi = 100F;
        this.DetailReport5.Level = 0;
        this.DetailReport5.Name = "DetailReport5";
        // 
        // Detail6
        // 
        this.Detail6.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable6});
        this.Detail6.Dpi = 100F;
        this.Detail6.HeightF = 25F;
        this.Detail6.Name = "Detail6";
        // 
        // GroupHeader2
        // 
        this.GroupHeader2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable5});
        this.GroupHeader2.Dpi = 100F;
        this.GroupHeader2.HeightF = 25F;
        this.GroupHeader2.Name = "GroupHeader2";
        // 
        // xrTable5
        // 
        this.xrTable5.BackColor = System.Drawing.Color.WhiteSmoke;
        this.xrTable5.Dpi = 100F;
        this.xrTable5.Font = new System.Drawing.Font("Arial", 8.75F, System.Drawing.FontStyle.Bold);
        this.xrTable5.LocationFloat = new DevExpress.Utils.PointFloat(36.04161F, 0F);
        this.xrTable5.Name = "xrTable5";
        this.xrTable5.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
        this.xrTable5.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow5});
        this.xrTable5.SizeF = new System.Drawing.SizeF(1098.416F, 25F);
        this.xrTable5.StylePriority.UseBackColor = false;
        this.xrTable5.StylePriority.UseFont = false;
        this.xrTable5.StylePriority.UsePadding = false;
        this.xrTable5.StylePriority.UseTextAlignment = false;
        this.xrTable5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrTableRow5
        // 
        this.xrTableRow5.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell9,
            this.xrTableCell10,
            this.xrTableCell12,
            this.xrTableCell11,
            this.xrTableCell13});
        this.xrTableRow5.Dpi = 100F;
        this.xrTableRow5.Name = "xrTableRow5";
        this.xrTableRow5.Weight = 1D;
        // 
        // xrTableCell9
        // 
        this.xrTableCell9.Dpi = 100F;
        this.xrTableCell9.Name = "xrTableCell9";
        this.xrTableCell9.Text = "Title";
        this.xrTableCell9.Weight = 1.1322645760579493D;
        // 
        // xrTableCell10
        // 
        this.xrTableCell10.Dpi = 100F;
        this.xrTableCell10.Name = "xrTableCell10";
        this.xrTableCell10.StylePriority.UseTextAlignment = false;
        this.xrTableCell10.Text = "Object Code";
        this.xrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        this.xrTableCell10.Weight = 1.7090785902211705D;
        // 
        // xrTableCell11
        // 
        this.xrTableCell11.Dpi = 100F;
        this.xrTableCell11.Name = "xrTableCell11";
        this.xrTableCell11.StylePriority.UseTextAlignment = false;
        this.xrTableCell11.Text = "Price";
        this.xrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell11.Weight = 0.64090447433593134D;
        // 
        // xrTableCell12
        // 
        this.xrTableCell12.Dpi = 100F;
        this.xrTableCell12.Name = "xrTableCell12";
        this.xrTableCell12.StylePriority.UseTextAlignment = false;
        this.xrTableCell12.Text = "Qty";
        this.xrTableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell12.Weight = 0.42726964064531076D;
        // 
        // xrTableCell13
        // 
        this.xrTableCell13.Dpi = 100F;
        this.xrTableCell13.Name = "xrTableCell13";
        this.xrTableCell13.StylePriority.UseTextAlignment = false;
        this.xrTableCell13.Text = "Total";
        this.xrTableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell13.Weight = 0.78368253151861944D;
        // 
        // xrTable6
        // 
        this.xrTable6.BackColor = System.Drawing.Color.White;
        this.xrTable6.Dpi = 100F;
        this.xrTable6.Font = new System.Drawing.Font("Arial", 8.75F);
        this.xrTable6.LocationFloat = new DevExpress.Utils.PointFloat(36.04161F, 0F);
        this.xrTable6.Name = "xrTable6";
        this.xrTable6.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
        this.xrTable6.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow6});
        this.xrTable6.SizeF = new System.Drawing.SizeF(1098.416F, 25F);
        this.xrTable6.StylePriority.UseBackColor = false;
        this.xrTable6.StylePriority.UseFont = false;
        this.xrTable6.StylePriority.UsePadding = false;
        this.xrTable6.StylePriority.UseTextAlignment = false;
        this.xrTable6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrTableRow6
        // 
        this.xrTableRow6.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell14,
            this.xrTableCell15,
            this.xrTableCell16,
            this.xrTableCell17,
            this.xrTableCell18});
        this.xrTableRow6.Dpi = 100F;
        this.xrTableRow6.Name = "xrTableRow6";
        this.xrTableRow6.Weight = 1D;
        // 
        // xrTableCell14
        // 
        this.xrTableCell14.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.SchemeCapitalCostEstimateList.FinancialYearList.SchemeCapitalCostEstim" +
                    "ateDetailList.Title")});
        this.xrTableCell14.Dpi = 100F;
        this.xrTableCell14.Name = "xrTableCell14";
        this.xrTableCell14.Weight = 1.1322645760579493D;
        // 
        // xrTableCell15
        // 
        this.xrTableCell15.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.SchemeCapitalCostEstimateList.FinancialYearList.SchemeCapitalCostEstim" +
                    "ateDetailList.AccountHeadTitle")});
        this.xrTableCell15.Dpi = 100F;
        this.xrTableCell15.Name = "xrTableCell15";
        this.xrTableCell15.StylePriority.UseTextAlignment = false;
        this.xrTableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        this.xrTableCell15.Weight = 1.7090785902211705D;
        // 
        // xrTableCell16
        // 
        this.xrTableCell16.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.SchemeCapitalCostEstimateList.FinancialYearList.SchemeCapitalCostEstim" +
                    "ateDetailList.Quantity")});
        this.xrTableCell16.Dpi = 100F;
        this.xrTableCell16.Name = "xrTableCell16";
        this.xrTableCell16.StylePriority.UseTextAlignment = false;
        this.xrTableCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell16.Weight = 0.42726964064531076D;
        // 
        // xrTableCell17
        // 
        this.xrTableCell17.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.SchemeCapitalCostEstimateList.FinancialYearList.SchemeCapitalCostEstim" +
                    "ateDetailList.UnitPrice")});
        this.xrTableCell17.Dpi = 100F;
        this.xrTableCell17.Name = "xrTableCell17";
        this.xrTableCell17.StylePriority.UseTextAlignment = false;
        this.xrTableCell17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell17.Weight = 0.64090447433593134D;
        // 
        // xrTableCell18
        // 
        this.xrTableCell18.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.SchemeCapitalCostEstimateList.FinancialYearList.SchemeCapitalCostEstim" +
                    "ateDetailList.cfTotalCapitalCostEstimate", "{0:#,#}")});
        this.xrTableCell18.Dpi = 100F;
        this.xrTableCell18.Name = "xrTableCell18";
        this.xrTableCell18.StylePriority.UseTextAlignment = false;
        this.xrTableCell18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell18.Weight = 0.78368253151861944D;
        // 
        // GroupFooter1
        // 
        this.GroupFooter1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable3});
        this.GroupFooter1.Dpi = 100F;
        this.GroupFooter1.HeightF = 50F;
        this.GroupFooter1.Name = "GroupFooter1";
        // 
        // GroupHeader3
        // 
        this.GroupHeader3.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
        this.GroupHeader3.Dpi = 100F;
        this.GroupHeader3.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("Id", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
        this.GroupHeader3.HeightF = 40F;
        this.GroupHeader3.Name = "GroupHeader3";
        // 
        // GroupHeader4
        // 
        this.GroupHeader4.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable7});
        this.GroupHeader4.Dpi = 100F;
        this.GroupHeader4.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("Id", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
        this.GroupHeader4.HeightF = 40F;
        this.GroupHeader4.Name = "GroupHeader4";
        // 
        // GroupHeader5
        // 
        this.GroupHeader5.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel62,
            this.xrLabel63});
        this.GroupHeader5.Dpi = 100F;
        this.GroupHeader5.HeightF = 46.875F;
        this.GroupHeader5.Level = 1;
        this.GroupHeader5.Name = "GroupHeader5";
        // 
        // GroupFooter2
        // 
        this.GroupFooter2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable9});
        this.GroupFooter2.Dpi = 100F;
        this.GroupFooter2.HeightF = 50F;
        this.GroupFooter2.Name = "GroupFooter2";
        // 
        // xrLabel62
        // 
        this.xrLabel62.Dpi = 100F;
        this.xrLabel62.Font = new System.Drawing.Font("Arial", 8.75F, System.Drawing.FontStyle.Bold);
        this.xrLabel62.LocationFloat = new DevExpress.Utils.PointFloat(9.541671F, 0F);
        this.xrLabel62.Multiline = true;
        this.xrLabel62.Name = "xrLabel62";
        this.xrLabel62.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel62.SizeF = new System.Drawing.SizeF(26.04161F, 31.25F);
        this.xrLabel62.StylePriority.UseFont = false;
        this.xrLabel62.StylePriority.UseTextAlignment = false;
        this.xrLabel62.Text = "15.";
        this.xrLabel62.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrLabel63
        // 
        this.xrLabel63.Dpi = 100F;
        this.xrLabel63.Font = new System.Drawing.Font("Arial", 8.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
        this.xrLabel63.LocationFloat = new DevExpress.Utils.PointFloat(36.04161F, 0F);
        this.xrLabel63.Multiline = true;
        this.xrLabel63.Name = "xrLabel63";
        this.xrLabel63.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel63.SizeF = new System.Drawing.SizeF(311.4583F, 31.25F);
        this.xrLabel63.StylePriority.UseFont = false;
        this.xrLabel63.StylePriority.UseTextAlignment = false;
        this.xrLabel63.Text = "Annual Operating Cost";
        this.xrLabel63.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrTable7
        // 
        this.xrTable7.BackColor = System.Drawing.Color.LightGray;
        this.xrTable7.Dpi = 100F;
        this.xrTable7.Font = new System.Drawing.Font("Arial", 8.75F, System.Drawing.FontStyle.Bold);
        this.xrTable7.LocationFloat = new DevExpress.Utils.PointFloat(36.04161F, 0F);
        this.xrTable7.Name = "xrTable7";
        this.xrTable7.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
        this.xrTable7.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow7});
        this.xrTable7.SizeF = new System.Drawing.SizeF(1098.875F, 40F);
        this.xrTable7.StylePriority.UseBackColor = false;
        this.xrTable7.StylePriority.UseFont = false;
        this.xrTable7.StylePriority.UsePadding = false;
        this.xrTable7.StylePriority.UseTextAlignment = false;
        this.xrTable7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrTableRow7
        // 
        this.xrTableRow7.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell19,
            this.xrTableCell20,
            this.xrTableCell21});
        this.xrTableRow7.Dpi = 100F;
        this.xrTableRow7.Name = "xrTableRow7";
        this.xrTableRow7.Weight = 1D;
        // 
        // xrTableCell19
        // 
        this.xrTableCell19.Dpi = 100F;
        this.xrTableCell19.Name = "xrTableCell19";
        this.xrTableCell19.Text = "Title";
        this.xrTableCell19.Weight = 1.6926407548271987D;
        // 
        // xrTableCell20
        // 
        this.xrTableCell20.Dpi = 100F;
        this.xrTableCell20.Name = "xrTableCell20";
        this.xrTableCell20.StylePriority.UseTextAlignment = false;
        this.xrTableCell20.Text = "Group";
        this.xrTableCell20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        this.xrTableCell20.Weight = 1.6380394245817056D;
        // 
        // xrTableCell21
        // 
        this.xrTableCell21.Dpi = 100F;
        this.xrTableCell21.Name = "xrTableCell21";
        this.xrTableCell21.StylePriority.UseTextAlignment = false;
        this.xrTableCell21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell21.Weight = 0.669319820591096D;
        // 
        // xrTable8
        // 
        this.xrTable8.BackColor = System.Drawing.Color.White;
        this.xrTable8.Dpi = 100F;
        this.xrTable8.Font = new System.Drawing.Font("Arial", 8.75F);
        this.xrTable8.LocationFloat = new DevExpress.Utils.PointFloat(36.04161F, 0F);
        this.xrTable8.Name = "xrTable8";
        this.xrTable8.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
        this.xrTable8.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow8});
        this.xrTable8.SizeF = new System.Drawing.SizeF(1098.875F, 25F);
        this.xrTable8.StylePriority.UseBackColor = false;
        this.xrTable8.StylePriority.UseFont = false;
        this.xrTable8.StylePriority.UsePadding = false;
        this.xrTable8.StylePriority.UseTextAlignment = false;
        this.xrTable8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrTableRow8
        // 
        this.xrTableRow8.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell22,
            this.xrTableCell23,
            this.xrTableCell24});
        this.xrTableRow8.Dpi = 100F;
        this.xrTableRow8.Name = "xrTableRow8";
        this.xrTableRow8.Weight = 1D;
        // 
        // xrTableCell22
        // 
        this.xrTableCell22.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.SchemeAnnualOperatingCostList.Title")});
        this.xrTableCell22.Dpi = 100F;
        this.xrTableCell22.Name = "xrTableCell22";
        this.xrTableCell22.StylePriority.UseTextAlignment = false;
        this.xrTableCell22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        this.xrTableCell22.Weight = 1.6899782297674368D;
        // 
        // xrTableCell23
        // 
        this.xrTableCell23.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.SchemeAnnualOperatingCostList.GroupTitle")});
        this.xrTableCell23.Dpi = 100F;
        this.xrTableCell23.Name = "xrTableCell23";
        this.xrTableCell23.StylePriority.UseTextAlignment = false;
        this.xrTableCell23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        this.xrTableCell23.Weight = 1.6365214253768639D;
        // 
        // xrTableCell24
        // 
        this.xrTableCell24.Dpi = 100F;
        this.xrTableCell24.Name = "xrTableCell24";
        this.xrTableCell24.StylePriority.UseTextAlignment = false;
        this.xrTableCell24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell24.Weight = 0.67350034485569954D;
        // 
        // xrTable9
        // 
        this.xrTable9.BackColor = System.Drawing.Color.White;
        this.xrTable9.Dpi = 100F;
        this.xrTable9.Font = new System.Drawing.Font("Arial", 8.75F);
        this.xrTable9.LocationFloat = new DevExpress.Utils.PointFloat(36.04161F, 0F);
        this.xrTable9.Name = "xrTable9";
        this.xrTable9.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
        this.xrTable9.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow9});
        this.xrTable9.SizeF = new System.Drawing.SizeF(1098.875F, 25F);
        this.xrTable9.StylePriority.UseBackColor = false;
        this.xrTable9.StylePriority.UseFont = false;
        this.xrTable9.StylePriority.UsePadding = false;
        this.xrTable9.StylePriority.UseTextAlignment = false;
        this.xrTable9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrTableRow9
        // 
        this.xrTableRow9.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell25,
            this.xrTableCell26,
            this.xrTableCell27});
        this.xrTableRow9.Dpi = 100F;
        this.xrTableRow9.Name = "xrTableRow9";
        this.xrTableRow9.Weight = 1D;
        // 
        // xrTableCell25
        // 
        this.xrTableCell25.Dpi = 100F;
        this.xrTableCell25.Name = "xrTableCell25";
        this.xrTableCell25.StylePriority.UseTextAlignment = false;
        this.xrTableCell25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        this.xrTableCell25.Weight = 1.6899782297674368D;
        // 
        // xrTableCell26
        // 
        this.xrTableCell26.Dpi = 100F;
        this.xrTableCell26.Font = new System.Drawing.Font("Arial", 8.75F, System.Drawing.FontStyle.Bold);
        this.xrTableCell26.Name = "xrTableCell26";
        this.xrTableCell26.StylePriority.UseFont = false;
        this.xrTableCell26.StylePriority.UseTextAlignment = false;
        this.xrTableCell26.Text = "Total";
        this.xrTableCell26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
        this.xrTableCell26.Weight = 1.6365214253768639D;
        // 
        // xrTableCell27
        // 
        this.xrTableCell27.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.SchemeAnnualOperatingCostList.SchemeAnnualOperatingCostDetailList.Unit" +
                    "Price")});
        this.xrTableCell27.Dpi = 100F;
        this.xrTableCell27.Name = "xrTableCell27";
        this.xrTableCell27.StylePriority.UseTextAlignment = false;
        xrSummary2.FormatString = "{0:#,#}";
        xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        this.xrTableCell27.Summary = xrSummary2;
        this.xrTableCell27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell27.Weight = 0.67350034485569954D;
        // 
        // cfTotalCapitalCostEstimate
        // 
        this.cfTotalCapitalCostEstimate.DataMember = "SchemeList.SchemeCapitalCostEstimateList.FinancialYearList.SchemeCapitalCostEstim" +
"ateDetailList";
        this.cfTotalCapitalCostEstimate.Expression = "[UnitPrice] * [Quantity]";
        this.cfTotalCapitalCostEstimate.FieldType = DevExpress.XtraReports.UI.FieldType.Decimal;
        this.cfTotalCapitalCostEstimate.Name = "cfTotalCapitalCostEstimate";
        // 
        // GroupHeader6
        // 
        this.GroupHeader6.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable10});
        this.GroupHeader6.Dpi = 100F;
        this.GroupHeader6.HeightF = 25F;
        this.GroupHeader6.Name = "GroupHeader6";
        // 
        // xrTable10
        // 
        this.xrTable10.BackColor = System.Drawing.Color.WhiteSmoke;
        this.xrTable10.Dpi = 100F;
        this.xrTable10.Font = new System.Drawing.Font("Arial", 8.75F, System.Drawing.FontStyle.Bold);
        this.xrTable10.LocationFloat = new DevExpress.Utils.PointFloat(36.04161F, 0F);
        this.xrTable10.Name = "xrTable10";
        this.xrTable10.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
        this.xrTable10.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow10});
        this.xrTable10.SizeF = new System.Drawing.SizeF(1098.42F, 25F);
        this.xrTable10.StylePriority.UseBackColor = false;
        this.xrTable10.StylePriority.UseFont = false;
        this.xrTable10.StylePriority.UsePadding = false;
        this.xrTable10.StylePriority.UseTextAlignment = false;
        this.xrTable10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrTableRow10
        // 
        this.xrTableRow10.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell28,
            this.xrTableCell31,
            this.xrTableCell34});
        this.xrTableRow10.Dpi = 100F;
        this.xrTableRow10.Name = "xrTableRow10";
        this.xrTableRow10.Weight = 1D;
        // 
        // xrTableCell28
        // 
        this.xrTableCell28.Dpi = 100F;
        this.xrTableCell28.Name = "xrTableCell28";
        this.xrTableCell28.Text = "Title";
        this.xrTableCell28.Weight = 1.1322645760579493D;
        // 
        // xrTableCell31
        // 
        this.xrTableCell31.Dpi = 100F;
        this.xrTableCell31.Name = "xrTableCell31";
        this.xrTableCell31.StylePriority.UseTextAlignment = false;
        this.xrTableCell31.Text = "Object Code";
        this.xrTableCell31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        this.xrTableCell31.Weight = 2.77725267866518D;
        // 
        // xrTableCell34
        // 
        this.xrTableCell34.Dpi = 100F;
        this.xrTableCell34.Name = "xrTableCell34";
        this.xrTableCell34.StylePriority.UseTextAlignment = false;
        this.xrTableCell34.Text = "Amount";
        this.xrTableCell34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell34.Weight = 0.78369786636800587D;
        // 
        // xrTable11
        // 
        this.xrTable11.BackColor = System.Drawing.Color.White;
        this.xrTable11.Dpi = 100F;
        this.xrTable11.Font = new System.Drawing.Font("Arial", 8.75F);
        this.xrTable11.LocationFloat = new DevExpress.Utils.PointFloat(36.04161F, 0F);
        this.xrTable11.Name = "xrTable11";
        this.xrTable11.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
        this.xrTable11.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow11});
        this.xrTable11.SizeF = new System.Drawing.SizeF(1098.42F, 25F);
        this.xrTable11.StylePriority.UseBackColor = false;
        this.xrTable11.StylePriority.UseFont = false;
        this.xrTable11.StylePriority.UsePadding = false;
        this.xrTable11.StylePriority.UseTextAlignment = false;
        this.xrTable11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrTableRow11
        // 
        this.xrTableRow11.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell32,
            this.xrTableCell33,
            this.xrTableCell37});
        this.xrTableRow11.Dpi = 100F;
        this.xrTableRow11.Name = "xrTableRow11";
        this.xrTableRow11.Weight = 1D;
        // 
        // xrTableCell32
        // 
        this.xrTableCell32.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.SchemeAnnualOperatingCostList.SchemeAnnualOperatingCostDetailList.Titl" +
                    "e")});
        this.xrTableCell32.Dpi = 100F;
        this.xrTableCell32.Name = "xrTableCell32";
        this.xrTableCell32.Weight = 1.1322645760579493D;
        // 
        // xrTableCell33
        // 
        this.xrTableCell33.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.SchemeAnnualOperatingCostList.SchemeAnnualOperatingCostDetailList.Acco" +
                    "untHeadTitle")});
        this.xrTableCell33.Dpi = 100F;
        this.xrTableCell33.Name = "xrTableCell33";
        this.xrTableCell33.StylePriority.UseTextAlignment = false;
        this.xrTableCell33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        this.xrTableCell33.Weight = 2.77725267866518D;
        // 
        // xrTableCell37
        // 
        this.xrTableCell37.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SchemeList.SchemeAnnualOperatingCostList.SchemeAnnualOperatingCostDetailList.Unit" +
                    "Price", "{0:#,#}")});
        this.xrTableCell37.Dpi = 100F;
        this.xrTableCell37.Name = "xrTableCell37";
        this.xrTableCell37.StylePriority.UseTextAlignment = false;
        this.xrTableCell37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell37.Weight = 0.78369786636800587D;
        // 
        // xrPC1SchemeReport
        // 
        this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.PageFooter,
            this.DetailReport});
        this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.cfTotalCapitalCostEstimate});
        this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.bindingSource1});
        this.DataSource = this.bindingSource1;
        this.Margins = new System.Drawing.Printing.Margins(11, 14, 234, 100);
        this.PageHeight = 1654;
        this.PageWidth = 1169;
        this.PaperKind = System.Drawing.Printing.PaperKind.A3;
        this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.prModified});
        this.Version = "17.2";
        ((System.ComponentModel.ISupportInitialize)(this.xrRichText13)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrRichText14)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrRichText15)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrRichText11)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrRichText12)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrRichText10)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrRichText9)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrRichText8)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrRichText7)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrRichText6)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrRichText5)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrRichText4)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrRichText3)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrRichText2)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrRichText1)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable4)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable5)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable6)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable7)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable8)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable9)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable10)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable11)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion
}
