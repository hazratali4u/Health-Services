using CORNBusinessLayer;
using CORNDataAccessLayer.Request;
using CORNDataAccessLayer.Response;
using System;

public partial class Forms_frmReportViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int report = Convert.ToInt32(Request.QueryString["report"]);
        ReportManager manager = new ReportManager();
        ReportRequest request = new ReportRequest();
        ReportResponse response = new ReportResponse();

        switch (report)
        {
            case 1:
                request.InstituteId = Convert.ToInt32(Request.QueryString["InstituteId"]);
                request.SchemeId = Convert.ToInt32(Request.QueryString["SchemeId"]);
                request.Year = Convert.ToInt32(Request.QueryString["Year"]);
                request.Month = Convert.ToInt32(Request.QueryString["Month"]);
                request.Month = Convert.ToInt32(Request.QueryString["Month"]);
                request.SchemeStatusId = Convert.ToInt64(Request.QueryString["SchemeStatusId"]);
                request.UserId = UserCommonInfo.LoggedInUserId;
                response = manager.GenerateMonthlyProgressReport(request);

                xrMonthlyProgressReport mprReport = new xrMonthlyProgressReport();

                mprReport.Parameters["prMonth"].Value = response.Month;
                mprReport.Parameters["prYear"].Value = response.Year;
                mprReport.Parameters["prExpectedYear"].Value = response.ExpectedYear;
                mprReport.Parameters["prFinancialYear"].Value = response.FinancialYear;
                mprReport.DataSource = response.CornReportList;

                mprReport.CreateDocument();

                dvReport.Report = mprReport;

                dvReport.DataBind();

                break;
            case 2:
                request.InstituteId = Convert.ToInt32(Request.QueryString["InstituteId"]);
                request.SchemeId = Convert.ToInt32(Request.QueryString["SchemeId"]);
                request.FinancialYearId = Convert.ToInt32(Request.QueryString["FinancialYearId"]);
                request.SchemeStatusId = Convert.ToInt64(Request.QueryString["SchemeStatusId"]);
                request.UserId = UserCommonInfo.LoggedInUserId;
                response = manager.GenerateFundWiseReport(request);

                xrFundWiseReport fwrReport = new xrFundWiseReport();

                fwrReport.Parameters["prFinancialYear"].Value = response.FinancialYear;
                fwrReport.DataSource = response.CornReportList;

                fwrReport.CreateDocument();

                dvReport.Report = fwrReport;

                dvReport.DataBind();

                break;
            case 3:
                request.InstituteId = Convert.ToInt32(Request.QueryString["InstituteId"]);
                request.FinancialYearId = Convert.ToInt32(Request.QueryString["FinancialYearId"]);
                request.SchemeStatusId = Convert.ToInt64(Request.QueryString["SchemeStatusId"]);
                request.UserId = UserCommonInfo.LoggedInUserId;
                response = manager.GenerateSchemeSummaryReport(request);

                xrSchemeSummaryReport ssrReport = new xrSchemeSummaryReport();

                ssrReport.DataSource = response.CornReportList;

                ssrReport.CreateDocument();

                dvReport.Report = ssrReport;

                dvReport.DataBind();

                break;
            case 4:
                request.InstituteId = Convert.ToInt32(Request.QueryString["InstituteId"]);
                request.SchemeId = Convert.ToInt32(Request.QueryString["SchemeId"]);
                request.FinancialYearId = Convert.ToInt32(Request.QueryString["FinancialYearId"]);
                request.SchemeStatusId = Convert.ToInt64(Request.QueryString["SchemeStatusId"]);
                request.UserId = UserCommonInfo.LoggedInUserId;
                response = manager.GenerateSubSectorSummaryReport(request);

                xrSectorSummaryReport sssrReport = new xrSectorSummaryReport();

                sssrReport.Parameters["prFinancialYear"].Value = response.FinancialYear;
                sssrReport.DataSource = response.CornReportList;

                sssrReport.CreateDocument();

                dvReport.Report = sssrReport;

                dvReport.DataBind();

                break;
            case 5:
                request.InstituteId = Convert.ToInt32(Request.QueryString["InstituteId"]);
                request.SchemeId = Convert.ToInt32(Request.QueryString["SchemeId"]);
                request.FinancialYearId = Convert.ToInt32(Request.QueryString["FinancialYearId"]);
                request.SchemeStatusId = Convert.ToInt64(Request.QueryString["SchemeStatusId"]);
                request.UserId = UserCommonInfo.LoggedInUserId;
                response = manager.GenerateStatusWiseReport(request);

                xrSchemeStatusSummaryReport scssrReport = new xrSchemeStatusSummaryReport();

                scssrReport.Parameters["prFinancialYear"].Value = response.FinancialYear;
                scssrReport.DataSource = response.CornReportList;

                scssrReport.CreateDocument();

                dvReport.Report = scssrReport;

                dvReport.DataBind();

                break;
            case 6:
                request.InstituteId = Convert.ToInt32(Request.QueryString["InstituteId"]);
                request.SchemeId = Convert.ToInt32(Request.QueryString["SchemeId"]);
                request.FinancialYearId = Convert.ToInt32(Request.QueryString["FinancialYearId"]);
                request.SchemeStatusId = Convert.ToInt64(Request.QueryString["SchemeStatusId"]);
                request.UserId = UserCommonInfo.LoggedInUserId;
                response = manager.GenerateSchemeWithNoReleaseReport(request);

                xrSchemeNoReleaseReport snrReport = new xrSchemeNoReleaseReport();

                snrReport.Parameters["prFinancialYear"].Value = response.FinancialYear;
                snrReport.DataSource = response.CornReportList;

                snrReport.CreateDocument();

                dvReport.Report = snrReport;

                dvReport.DataBind();

                break;
            case 7:
                request.InstituteId = Convert.ToInt32(Request.QueryString["InstituteId"]);
                request.SchemeId = Convert.ToInt32(Request.QueryString["SchemeId"]);
                request.FinancialYearId = Convert.ToInt32(Request.QueryString["FinancialYearId"]);
                request.SchemeStatusId = Convert.ToInt64(Request.QueryString["SchemeStatusId"]);
                request.UserId = UserCommonInfo.LoggedInUserId;
                response = manager.GenerateSchemeWithReleaseNoExpenseReport(request);

                xrSchemeReleaseNoExpenseReport srneReport = new xrSchemeReleaseNoExpenseReport();

                srneReport.Parameters["prFinancialYear"].Value = response.FinancialYear;
                srneReport.DataSource = response.CornReportList;

                srneReport.CreateDocument();

                dvReport.Report = srneReport;

                dvReport.DataBind();

                break;
            case 8:
                request.InstituteId = Convert.ToInt32(Request.QueryString["InstituteId"]);
                request.SchemeId = Convert.ToInt32(Request.QueryString["SchemeId"]);
                request.FinancialYearId = Convert.ToInt32(Request.QueryString["FinancialYearId"]);
                request.SchemeStatusId = Convert.ToInt64(Request.QueryString["SchemeStatusId"]);
                request.UserId = UserCommonInfo.LoggedInUserId;
                response = manager.GenerateFunctionWiseReport(request);

                xrFunctionWiseReport fnwrReport = new xrFunctionWiseReport();

                fnwrReport.Parameters["prFinancialYear"].Value = response.FinancialYear;
                fnwrReport.DataSource = response.CornReportList;

                fnwrReport.CreateDocument();

                dvReport.Report = fnwrReport;

                dvReport.DataBind();

                break;
            case 9:
                long CATypeId = Convert.ToInt64(Request.QueryString["CATypeId"]);

                request.InstituteId = Convert.ToInt32(Request.QueryString["InstituteId"]);
                request.SchemeId = Convert.ToInt32(Request.QueryString["SchemeId"]);
                request.FinancialYearId = Convert.ToInt32(Request.QueryString["FinancialYearId"]);
                request.MajorCAId = Convert.ToInt64(Request.QueryString["MajorCAId"]);
                request.MinorCAId = Convert.ToInt64(Request.QueryString["MinorCAId"]);
                request.SchemeStatusId = Convert.ToInt64(Request.QueryString["SchemeStatusId"]);
                request.UserId = UserCommonInfo.LoggedInUserId;
                response = manager.GenerateObjectWiseReport(request);

                DevExpress.XtraReports.UI.XtraReport owrReport = new DevExpress.XtraReports.UI.XtraReport();

                switch (CATypeId)
                {
                    case 92:
                        owrReport = new xrMajorObjectWiseReport();

                        break;
                    case 93:
                        owrReport = new xrMinorObjectWiseReport();

                        break;
                    case 94:
                        owrReport = new xrDetailObjectWiseReport();

                        break;
                    default:
                        break;
                }

                owrReport.Parameters["prFinancialYear"].Value = response.FinancialYear;
                owrReport.DataSource = response.CornReportList;

                owrReport.CreateDocument();

                dvReport.Report = owrReport;

                dvReport.DataBind();

                break;
            case 10:
                request.InstituteId = Convert.ToInt32(Request.QueryString["InstituteId"]);
                request.SchemeId = Convert.ToInt32(Request.QueryString["SchemeId"]);
                request.FinancialYearId = Convert.ToInt32(Request.QueryString["FinancialYearId"]);
                request.SchemeStatusId = Convert.ToInt64(Request.QueryString["SchemeStatusId"]);
                request.UserId = UserCommonInfo.LoggedInUserId;
                response = manager.GenerateExcessSurrenderReport(request);

                xrSchemeExcessSurrenderReport sesReport = new xrSchemeExcessSurrenderReport();

                sesReport.Parameters["prFinancialYear"].Value = response.FinancialYear;
                sesReport.DataSource = response.CornReportList;

                sesReport.CreateDocument();

                dvReport.Report = sesReport;

                dvReport.DataBind();

                break;
            case 11:
                request.FinancialYearId = Convert.ToInt32(Request.QueryString["FYId"]);
                request.SchemeStatusId = Convert.ToInt64(Request.QueryString["SchemeStatusId"]);
                request.UserId = UserCommonInfo.LoggedInUserId;
                response = manager.GenerateADPSchemeDetailReport(request);

                xrADPSchemeDetailReport adpsdReport = new xrADPSchemeDetailReport();

                adpsdReport.DataSource = response.CornReportList;

                adpsdReport.CreateDocument();

                dvReport.Report = adpsdReport;

                dvReport.DataBind();

                break;
            case 12:
                request.InstituteId = Convert.ToInt32(Request.QueryString["InstituteId"]);
                request.SchemeId = Convert.ToInt32(Request.QueryString["SchemeId"]);
                request.FinancialYearId = Convert.ToInt32(Request.QueryString["FinancialYearId"]);
                request.SchemeStatusId = Convert.ToInt64(Request.QueryString["SchemeStatusId"]);
                request.UserId = UserCommonInfo.LoggedInUserId;
                response = manager.GenerateExcessSurrenderStatementReport(request);

                xrSchemeExcessSurrenderStatementReport sessReport = new xrSchemeExcessSurrenderStatementReport();

                sessReport.Parameters["prFinancialYear"].Value = response.FinancialYear;
                sessReport.DataSource = response.CornReportList;

                sessReport.CreateDocument();

                dvReport.Report = sessReport;

                dvReport.DataBind();

                break;
            case 13:
                request.InstituteId = Convert.ToInt32(Request.QueryString["InstituteId"]);
                request.SchemeId = Convert.ToInt32(Request.QueryString["SchemeId"]);
                request.Year = Convert.ToInt32(Request.QueryString["Year"]);
                request.Month = Convert.ToInt32(Request.QueryString["Month"]);
                request.SchemeStatusId = Convert.ToInt64(Request.QueryString["SchemeStatusId"]);
                request.UserId = UserCommonInfo.LoggedInUserId;
                response = manager.GenerateNewMonthlyProgressReport(request);

                xrNewMonthlyProgressReport nmprReport = new xrNewMonthlyProgressReport();

                nmprReport.Parameters["prMonth"].Value = response.Month;
                nmprReport.Parameters["prYear"].Value = response.Year;
                nmprReport.Parameters["prExpectedYear"].Value = response.ExpectedYear;
                nmprReport.Parameters["prFinancialYear"].Value = response.FinancialYear;
                nmprReport.Parameters["prNextFinancialYear"].Value = response.NextFinancialYear;
                nmprReport.DataSource = response.CornReportList;

                nmprReport.CreateDocument();

                dvReport.Report = nmprReport;

                dvReport.DataBind();

                break;
            case 14:
                request.SchemeId = Convert.ToInt32(Request.QueryString["SchemeId"]);
                request.UserId = UserCommonInfo.LoggedInUserId;
                response = manager.GeneratePC1SchemeReport(request);

                xrPC1SchemeReport pc1sReport = new xrPC1SchemeReport();

                pc1sReport.Parameters["prModified"].Value = "Modified: " + response.Date;
                pc1sReport.DataSource = response.CornReportList;

                pc1sReport.CreateDocument();

                dvReport.Report = pc1sReport;

                dvReport.DataBind();

                break;
            case 15:
                request.SchemeId = Convert.ToInt32(Request.QueryString["SchemeId"]);
                request.UserId = UserCommonInfo.LoggedInUserId;
                response = manager.GeneratePC1SchemeStageReport(request);

                xrPC1SchemeStageReport pc1stReport = new xrPC1SchemeStageReport();

                pc1stReport.Parameters["prScheme"].Value = response.Title;
                pc1stReport.DataSource = response.CornReportList;

                pc1stReport.CreateDocument();

                dvReport.Report = pc1stReport;

                dvReport.DataBind();

                break;
            case 16:
                request.SchemeId = Convert.ToInt32(Request.QueryString["SchemeId"]);
                request.UserId = UserCommonInfo.LoggedInUserId;
                response = manager.GeneratePC1SchemeStatusReport(request);

                xrPC1SchemeStatusReport pc1ssReport = new xrPC1SchemeStatusReport();

                pc1ssReport.Parameters["prScheme"].Value = response.Title;
                pc1ssReport.DataSource = response.CornReportList;

                pc1ssReport.CreateDocument();

                dvReport.Report = pc1ssReport;

                dvReport.DataBind();

                break;
            case 17:
                //request.SchemeId = Convert.ToInt32(Request.QueryString["SchemeId"]);
                //request.UserId = UserCommonInfo.LoggedInUserId;
                //response = manager.GeneratePC1SchemeReport(request);

                //xrPC1SchemeReport pc1sReport = new xrPC1SchemeReport();

                //pc1sReport.Parameters["prModified"].Value = "Modified: " + response.Date;
                //pc1sReport.DataSource = response.CornReportList;

                //pc1sReport.CreateDocument();

                //dvReport.Report = pc1sReport;

                //dvReport.DataBind();

                break;
            case 18:
                int filterMode = Convert.ToInt32(Request.QueryString["FilterMode"]);
                int year = Convert.ToInt32(Request.QueryString["Year"]);
                int month = Convert.ToInt32(Request.QueryString["Month"]);
                int quarter = Convert.ToInt32(Request.QueryString["Quarter"]);
                DateTime fromDate = DateTime.Now;
                DateTime toDate = DateTime.Now;

                switch (filterMode)
                {
                    case 1:
                        //fromDate = new DateTime(year, 1, 1);
                        //toDate = new DateTime(year, 12, 31);
                        fromDate = new DateTime(year, 7, 31);
                        toDate = new DateTime((year + 1), 6, 30);

                        break;
                    case 2:
                        //fromDate = new DateTime(year, month, 1);
                        //toDate = new DateTime(year, month, DateTime.DaysInMonth(year, month));

                        if (month <= 6)
                        {
                            fromDate = new DateTime((year + 1), month, 1);
                        }
                        else
                        {
                            fromDate = new DateTime(year, month, 1);
                        }

                        toDate = new DateTime((year + 1), 6, 30);

                        break;
                    case 3:
                        switch (quarter)
                        {
                            case 1:
                                //fromDate = new DateTime(year, 1, 1);
                                //toDate = new DateTime(year, 4, 30);
                                fromDate = new DateTime((year + 1), 1, 1);
                                toDate = new DateTime((year + 1), 3, 31);

                                break;
                            case 2:
                                //fromDate = new DateTime(year, 5, 1);
                                //toDate = new DateTime(year, 8, 31);
                                fromDate = new DateTime((year + 1), 4, 1);
                                toDate = new DateTime((year + 1), 6, 30);

                                break;
                            case 3:
                                //fromDate = new DateTime(year, 9, 1);
                                //toDate = new DateTime(year, 12, 31);
                                fromDate = new DateTime(year, 7, 1);
                                toDate = new DateTime(year, 9, 30);

                                break;
                            case 4:
                                //fromDate = new DateTime(year, 9, 1);
                                //toDate = new DateTime(year, 12, 31);
                                fromDate = new DateTime(year, 10, 1);
                                toDate = new DateTime(year, 12, 31);

                                break;
                            default:
                                break;
                        }

                        break;
                    default:
                        break;
                }

                request.DistrictId = Convert.ToInt32(Request.QueryString["DistrictId"]);
                //request.FinancialYearId = Convert.ToInt32(Request.QueryString["FinancialYearId"]);
                request.FromDateTime = fromDate;
                request.ToDateTime = toDate;
                request.SchemeStatusId = Convert.ToInt64(Request.QueryString["SchemeStatusId"]);
                request.ConstituencyId = Convert.ToInt32(Request.QueryString["ConstituencyId"]);
                request.FundTypeId = Convert.ToInt32(Request.QueryString["FundTypeId"]);
                request.UserId = UserCommonInfo.LoggedInUserId;
                response = manager.GenerateSubSectorMonthlyProgressReport(request);

                xrSubSectorMonthlyProgressReport ssmpReport = new xrSubSectorMonthlyProgressReport();

                ssmpReport.Parameters["prYear"].Value = year.ToString() + "-" + (year + 1).ToString();
                ssmpReport.Parameters["prMonth"].Value = request.FromDateTime.ToString("dd MMM yyyy") + " - " + request.ToDateTime.ToString("dd MMM yyyy");
                ssmpReport.Parameters["prDistrict"].Value = response.District;
                ssmpReport.Parameters["prConstituency"].Value = response.Constituency;
                ssmpReport.DataSource = response.CornReportList;

                ssmpReport.CreateDocument();

                dvReport.Report = ssmpReport;

                dvReport.DataBind();

                break;
            case 19:
                filterMode = Convert.ToInt32(Request.QueryString["FilterMode"]);
                year = Convert.ToInt32(Request.QueryString["Year"]);
                month = Convert.ToInt32(Request.QueryString["Month"]);
                quarter = Convert.ToInt32(Request.QueryString["Quarter"]);
                fromDate = DateTime.Now;
                toDate = DateTime.Now;

                switch (filterMode)
                {
                    case 1:
                        //fromDate = new DateTime(year, 1, 1);
                        //toDate = new DateTime(year, 12, 31);
                        fromDate = new DateTime(year, 7, 31);
                        toDate = new DateTime((year + 1), 6, 30);

                        break;
                    case 2:
                        //fromDate = new DateTime(year, month, 1);
                        //toDate = new DateTime(year, month, DateTime.DaysInMonth(year, month));

                        if (month <= 6)
                        {
                            fromDate = new DateTime((year + 1), month, 1);
                        }
                        else
                        {
                            fromDate = new DateTime(year, month, 1);
                        }

                        toDate = new DateTime((year + 1), 6, 30);

                        break;
                    case 3:
                        switch (quarter)
                        {
                            case 1:
                                //fromDate = new DateTime(year, 1, 1);
                                //toDate = new DateTime(year, 4, 30);
                                fromDate = new DateTime((year + 1), 1, 1);
                                toDate = new DateTime((year + 1), 3, 31);

                                break;
                            case 2:
                                //fromDate = new DateTime(year, 5, 1);
                                //toDate = new DateTime(year, 8, 31);
                                fromDate = new DateTime((year + 1), 4, 1);
                                toDate = new DateTime((year + 1), 6, 30);

                                break;
                            case 3:
                                //fromDate = new DateTime(year, 9, 1);
                                //toDate = new DateTime(year, 12, 31);
                                fromDate = new DateTime(year, 7, 1);
                                toDate = new DateTime(year, 9, 30);

                                break;
                            case 4:
                                //fromDate = new DateTime(year, 9, 1);
                                //toDate = new DateTime(year, 12, 31);
                                fromDate = new DateTime(year, 10, 1);
                                toDate = new DateTime(year, 12, 31);

                                break;
                            default:
                                break;
                        }

                        break;
                    default:
                        break;
                }

                request.DistrictId = Convert.ToInt32(Request.QueryString["DistrictId"]);
                //request.FinancialYearId = Convert.ToInt32(Request.QueryString["FinancialYearId"]);
                request.FromDateTime = fromDate;
                request.ToDateTime = toDate;
                request.SchemeStatusId = Convert.ToInt64(Request.QueryString["SchemeStatusId"]);
                request.ConstituencyId = Convert.ToInt32(Request.QueryString["ConstituencyId"]);
                request.FundTypeId = Convert.ToInt32(Request.QueryString["FundTypeId"]);
                request.UserId = UserCommonInfo.LoggedInUserId;
                response = manager.GenerateObjectMonthlyProgressReport(request);

                xrObjectMonthlyProgressReport ompReport = new xrObjectMonthlyProgressReport();

                ompReport.Parameters["prYear"].Value = year.ToString() + "-" + (year + 1).ToString();
                ompReport.Parameters["prMonth"].Value = request.FromDateTime.ToString("dd MMM yyyy") + " - " + request.ToDateTime.ToString("dd MMM yyyy");
                ompReport.Parameters["prDistrict"].Value = response.District;
                ompReport.Parameters["prConstituency"].Value = response.Constituency;
                ompReport.DataSource = response.CornReportList;

                ompReport.CreateDocument();

                dvReport.Report = ompReport;

                dvReport.DataBind();

                break;
            case 20:
                filterMode = Convert.ToInt32(Request.QueryString["FilterMode"]);
                year = Convert.ToInt32(Request.QueryString["Year"]);
                month = Convert.ToInt32(Request.QueryString["Month"]);
                quarter = Convert.ToInt32(Request.QueryString["Quarter"]);
                fromDate = DateTime.Now;
                toDate = DateTime.Now;

                switch (filterMode)
                {
                    case 1:
                        //fromDate = new DateTime(year, 1, 1);
                        //toDate = new DateTime(year, 12, 31);
                        fromDate = new DateTime(year, 7, 31);
                        toDate = new DateTime((year + 1), 6, 30);

                        break;
                    case 2:
                        //fromDate = new DateTime(year, month, 1);
                        //toDate = new DateTime(year, month, DateTime.DaysInMonth(year, month));

                        if (month <= 6)
                        {
                            fromDate = new DateTime((year + 1), month, 1);
                        }
                        else
                        {
                            fromDate = new DateTime(year, month, 1);
                        }

                        toDate = new DateTime((year + 1), 6, 30);

                        break;
                    case 3:
                        switch (quarter)
                        {
                            case 1:
                                //fromDate = new DateTime(year, 1, 1);
                                //toDate = new DateTime(year, 4, 30);
                                fromDate = new DateTime((year + 1), 1, 1);
                                toDate = new DateTime((year + 1), 3, 31);

                                break;
                            case 2:
                                //fromDate = new DateTime(year, 5, 1);
                                //toDate = new DateTime(year, 8, 31);
                                fromDate = new DateTime((year + 1), 4, 1);
                                toDate = new DateTime((year + 1), 6, 30);

                                break;
                            case 3:
                                //fromDate = new DateTime(year, 9, 1);
                                //toDate = new DateTime(year, 12, 31);
                                fromDate = new DateTime(year, 7, 1);
                                toDate = new DateTime(year, 9, 30);

                                break;
                            case 4:
                                //fromDate = new DateTime(year, 9, 1);
                                //toDate = new DateTime(year, 12, 31);
                                fromDate = new DateTime(year, 10, 1);
                                toDate = new DateTime(year, 12, 31);

                                break;
                            default:
                                break;
                        }

                        break;
                    default:
                        break;
                }

                request.DistrictId = Convert.ToInt32(Request.QueryString["DistrictId"]);
                //request.FinancialYearId = Convert.ToInt32(Request.QueryString["FinancialYearId"]);
                request.FromDateTime = fromDate;
                request.ToDateTime = toDate;
                request.SchemeStatusId = Convert.ToInt64(Request.QueryString["SchemeStatusId"]);
                request.ConstituencyId = Convert.ToInt32(Request.QueryString["ConstituencyId"]);
                request.FundTypeId = Convert.ToInt32(Request.QueryString["FundTypeId"]);
                request.UserId = UserCommonInfo.LoggedInUserId;
                response = manager.GenerateFunctionMonthlyProgressReport(request);

                xrFunctionMonthlyProgressReport fmpReport = new xrFunctionMonthlyProgressReport();

                fmpReport.Parameters["prYear"].Value = year.ToString() + "-" + (year + 1).ToString();
                fmpReport.Parameters["prMonth"].Value = request.FromDateTime.ToString("dd MMM yyyy") + " - " + request.ToDateTime.ToString("dd MMM yyyy");
                fmpReport.Parameters["prDistrict"].Value = response.District;
                fmpReport.Parameters["prConstituency"].Value = response.Constituency;
                fmpReport.DataSource = response.CornReportList;

                fmpReport.CreateDocument();

                dvReport.Report = fmpReport;

                dvReport.DataBind();

                break;
            case 21:
                filterMode = Convert.ToInt32(Request.QueryString["FilterMode"]);
                year = Convert.ToInt32(Request.QueryString["Year"]);
                month = Convert.ToInt32(Request.QueryString["Month"]);
                quarter = Convert.ToInt32(Request.QueryString["Quarter"]);
                fromDate = new DateTime(year, 7, 1);
                toDate = DateTime.Now;

                switch (filterMode)
                {
                    case 1:
                        toDate = new DateTime((year + 1), 6, 30);

                        break;
                    case 2:
                        if (month <= 6)
                        {
                            toDate = new DateTime((year + 1), month, DateTime.DaysInMonth((year + 1), month));
                        }
                        else
                        {
                            toDate = new DateTime(year, month, DateTime.DaysInMonth(year, month));
                        }

                        break;
                    case 3:
                        switch (quarter)
                        {
                            case 1:
                                toDate = new DateTime(year, 9, 30);

                                break;
                            case 2:
                                toDate = new DateTime(year, 12, 31);

                                break;
                            case 3:
                                toDate = new DateTime((year + 1), 3, 31);

                                break;
                            case 4:
                                toDate = new DateTime((year + 1), 6, 30);

                                break;
                            default:
                                break;
                        }

                        break;
                    default:
                        break;
                }

                request.DistrictId = Convert.ToInt32(Request.QueryString["DistrictId"]);
                request.FromDateTime = fromDate;
                request.ToDateTime = toDate;
                request.SchemeStatusId = Convert.ToInt64(Request.QueryString["SchemeStatusId"]);
                request.ConstituencyId = Convert.ToInt32(Request.QueryString["ConstituencyId"]);
                request.FundTypeId = Convert.ToInt32(Request.QueryString["FundTypeId"]);
                request.UserId = UserCommonInfo.LoggedInUserId;

                if (Convert.ToInt32(Request.QueryString["GroupBy"]) == 1)
                {
                    response = manager.GenerateSubSectorSummaryMonthlyReviewReport(request);

                    xrProgressReviewReport prReport = new xrProgressReviewReport();

                    prReport.Parameters["prYear"].Value = year.ToString() + "-" + (year + 1).ToString();
                    prReport.Parameters["prDateRange"].Value = request.FromDateTime.ToString("dd MMM yyyy") + " - " + request.ToDateTime.ToString("dd MMM yyyy");
                    prReport.Parameters["prDistrict"].Value = response.District;
                    prReport.Parameters["prConstituency"].Value = response.Constituency;
                    prReport.Parameters["prPYear"].Value = Convert.ToString(year);
                    prReport.DataSource = response.CornReportList;

                    prReport.CreateDocument();

                    dvReport.Report = prReport;
                }
                else
                {
                    response = manager.GenerateConstituencySummaryMonthlyReviewReport(request);

                    xrCProgressReviewReport cprReport = new xrCProgressReviewReport();

                    cprReport.Parameters["prYear"].Value = year.ToString() + "-" + (year + 1).ToString();
                    cprReport.Parameters["prDateRange"].Value = request.FromDateTime.ToString("dd MMM yyyy") + " - " + request.ToDateTime.ToString("dd MMM yyyy");
                    cprReport.Parameters["prDistrict"].Value = response.District;
                    cprReport.Parameters["prConstituency"].Value = response.Constituency;
                    cprReport.Parameters["prPYear"].Value = Convert.ToString(year);
                    cprReport.DataSource = response.CornReportList;

                    cprReport.CreateDocument();

                    dvReport.Report = cprReport;
                }

                dvReport.DataBind();

                break;
            case 22:
                request.SchemeId = Convert.ToInt32(Request.QueryString["SchemeId"]);
                request.FundTypeId = Convert.ToInt32(Request.QueryString["FundTypeId"]);
                request.FromDateTime = Convert.ToDateTime(Request.QueryString["FromDateTime"]);
                request.ToDateTime = Convert.ToDateTime(Request.QueryString["ToDateTime"]);
                request.UserId = UserCommonInfo.LoggedInUserId;
                response = manager.GenerateProjectLedgerReport(request);

                xrProjectLedgerReport plReport = new xrProjectLedgerReport();

                plReport.Parameters["prProjectTitle"].Value = response.Title;
                plReport.Parameters["prFundType"].Value = response.FundType;
                plReport.Parameters["prDateRange"].Value = "From " + request.FromDateTime.ToString("dd MMM yyyy") + " to " + request.ToDateTime.ToString("dd MMM yyyy");
                plReport.DataSource = response.CornReportList;

                plReport.CreateDocument();

                dvReport.Report = plReport;

                dvReport.DataBind();

                break;
            case 23:
                request.FinancialYearId = Convert.ToInt32(Request.QueryString["FYId"]);
                request.ReportTypeId = Convert.ToInt32(Request.QueryString["RType"]);
                request.SchemeStatusId = Convert.ToInt64(Request.QueryString["SchemeStatusId"]);
                request.UserId = UserCommonInfo.LoggedInUserId;
                response = manager.GenerateADPSummaryReport(request);

                if (request.ReportTypeId == 1)
                {
                    xrADPSubSectorSummaryReport adpsssReport = new xrADPSubSectorSummaryReport();

                    adpsssReport.Parameters["prYear"].Value = response.FinancialYear;
                    adpsssReport.Parameters["prCYear"].Value = response.Year;
                    adpsssReport.DataSource = response.CornReportList;

                    adpsssReport.CreateDocument();

                    dvReport.Report = adpsssReport;
                }
                else if (request.ReportTypeId == 2)
                {
                    xrADPFunctionSummaryReport adpfsReport = new xrADPFunctionSummaryReport();

                    adpfsReport.Parameters["prYear"].Value = response.FinancialYear;
                    adpfsReport.Parameters["prCYear"].Value = response.Year;
                    adpfsReport.DataSource = response.CornReportList;

                    adpfsReport.CreateDocument();

                    dvReport.Report = adpfsReport;
                }
                else if (request.ReportTypeId == 3)
                {
                    xrADPStatusSummaryReport adpssReport = new xrADPStatusSummaryReport();

                    adpssReport.Parameters["prYear"].Value = response.FinancialYear;
                    adpssReport.Parameters["prCYear"].Value = response.Year;
                    adpssReport.DataSource = response.CornReportList;

                    adpssReport.CreateDocument();

                    dvReport.Report = adpssReport;
                }

                dvReport.DataBind();

                break;
            case 24:
                request.FinancialYearId = Convert.ToInt32(Request.QueryString["FYId"]);
                request.SchemeStatusId = Convert.ToInt64(Request.QueryString["SchemeStatusId"]);
                request.UserId = UserCommonInfo.LoggedInUserId;
                response = manager.GenerateADPComparativeReport(request);

                xrADPComparativeReport adpcReport = new xrADPComparativeReport();

                adpcReport.Parameters["prYear"].Value = response.FinancialYear;
                adpcReport.Parameters["prPYear"].Value = response.PreviousFinancialYear;
                adpcReport.DataSource = response.CornReportList;

                adpcReport.CreateDocument();

                dvReport.Report = adpcReport;

                dvReport.DataBind();

                break;
            case 25:
                request.FinancialYearId = Convert.ToInt32(Request.QueryString["FYId"]);
                request.ReportTypeId = Convert.ToInt32(Request.QueryString["RType"]);
                request.SchemeStatusId = Convert.ToInt64(Request.QueryString["SchemeStatusId"]);
                request.UserId = UserCommonInfo.LoggedInUserId;
                response = manager.GenerateADPHistoricalTrendReport(request);

                if (request.ReportTypeId == 1)
                {
                    xrADPSubSectorHistoricalTrendReport adpsshtReport = new xrADPSubSectorHistoricalTrendReport();

                    adpsshtReport.Parameters["prYear"].Value = response.FinancialYear;
                    adpsshtReport.Parameters["prPYear1"].Value = response.PreviousFinancialYear1;
                    adpsshtReport.Parameters["prPYear2"].Value = response.PreviousFinancialYear2;
                    adpsshtReport.Parameters["prPYear3"].Value = response.PreviousFinancialYear3;
                    adpsshtReport.Parameters["prPYear4"].Value = response.PreviousFinancialYear4;

                    adpsshtReport.DataSource = response.CornReportList;

                    adpsshtReport.CreateDocument();

                    dvReport.Report = adpsshtReport;
                }
                else if (request.ReportTypeId == 2)
                {
                    xrADPFunctionHistoricalTrendReport adpfhtReport = new xrADPFunctionHistoricalTrendReport();

                    adpfhtReport.Parameters["prYear"].Value = response.FinancialYear;
                    adpfhtReport.Parameters["prPYear1"].Value = response.PreviousFinancialYear1;
                    adpfhtReport.Parameters["prPYear2"].Value = response.PreviousFinancialYear2;
                    adpfhtReport.Parameters["prPYear3"].Value = response.PreviousFinancialYear3;
                    adpfhtReport.Parameters["prPYear4"].Value = response.PreviousFinancialYear4;
                    adpfhtReport.DataSource = response.CornReportList;

                    adpfhtReport.CreateDocument();

                    dvReport.Report = adpfhtReport;
                }
                else if (request.ReportTypeId == 3)
                {
                    xrADPDetailObjectHistoricalTrendReport adpdohtReport = new xrADPDetailObjectHistoricalTrendReport();

                    adpdohtReport.Parameters["prYear"].Value = response.FinancialYear;
                    adpdohtReport.Parameters["prPYear1"].Value = response.PreviousFinancialYear1;
                    adpdohtReport.Parameters["prPYear2"].Value = response.PreviousFinancialYear2;
                    adpdohtReport.Parameters["prPYear3"].Value = response.PreviousFinancialYear3;
                    adpdohtReport.Parameters["prPYear4"].Value = response.PreviousFinancialYear4;
                    adpdohtReport.DataSource = response.CornReportList;

                    adpdohtReport.CreateDocument();

                    dvReport.Report = adpdohtReport;
                }

                dvReport.DataBind();

                break;
            case 26:
                request.FinancialYearId = Convert.ToInt32(Request.QueryString["FYId"]);
                request.SchemeStatusId = Convert.ToInt64(Request.QueryString["SchemeStatusId"]);
                request.UserId = UserCommonInfo.LoggedInUserId;
                response = manager.GenerateADPAbstractReport(request);

                xrADPAbstractReport adpaReport = new xrADPAbstractReport();

                adpaReport.Parameters["prYear"].Value = response.FinancialYear;
                adpaReport.Parameters["prCYear"].Value = response.Year;
                adpaReport.Parameters["prPYear"].Value = response.PreviousYear;
                adpaReport.DataSource = response.CornReportList;

                adpaReport.CreateDocument();

                dvReport.Report = adpaReport;

                dvReport.DataBind();

                break;
            case 27:
                request.FinancialYearId = Convert.ToInt32(Request.QueryString["FYId"]);
                request.ReportTypeId = Convert.ToInt32(Request.QueryString["RType"]);
                request.SchemeStatusId = Convert.ToInt64(Request.QueryString["SchemeStatusId"]);
                request.UserId = UserCommonInfo.LoggedInUserId;
                response = manager.GenerateADPDetailReport(request);

                if (request.ReportTypeId == 1)
                {
                    xrADPSubSectorDetailReport adpssdReport = new xrADPSubSectorDetailReport();

                    adpssdReport.Parameters["prYear"].Value = response.FinancialYear;
                    adpssdReport.Parameters["prCYear"].Value = response.Year;
                    adpssdReport.Parameters["prPYear"].Value = response.PreviousYear;
                    adpssdReport.DataSource = response.CornReportList;

                    adpssdReport.CreateDocument();

                    dvReport.Report = adpssdReport;
                }
                else if (request.ReportTypeId == 2)
                {
                    xrADPDetailObjectDetailReport adpdodReport = new xrADPDetailObjectDetailReport();

                    adpdodReport.Parameters["prYear"].Value = response.FinancialYear;
                    adpdodReport.DataSource = response.CornReportList;

                    adpdodReport.CreateDocument();

                    dvReport.Report = adpdodReport;
                }
                else if (request.ReportTypeId == 3)
                {
                    xrADPFunctionDetailReport adpfdReport = new xrADPFunctionDetailReport();

                    adpfdReport.Parameters["prYear"].Value = response.FinancialYear;
                    adpfdReport.DataSource = response.CornReportList;

                    adpfdReport.CreateDocument();

                    dvReport.Report = adpfdReport;
                }

                dvReport.DataBind();

                break;
            default:
                break;
        }
    }
}