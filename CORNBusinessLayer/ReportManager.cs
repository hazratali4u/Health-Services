using CORNDataAccessLayer.Request;
using CORNDataAccessLayer.Response;
using CORNDatabaseLayer;

namespace CORNBusinessLayer
{
    public class ReportManager
    {
        public ReportResponse GenerateMonthlyProgressReport(ReportRequest request)
        {
            ReportDataAccess dataAccess = new ReportDataAccess();

            return dataAccess.GenerateMonthlyProgressReport(request);
        }
        public ReportResponse GenerateFundWiseReport(ReportRequest request)
        {
            ReportDataAccess dataAccess = new ReportDataAccess();

            return dataAccess.GenerateFundWiseReport(request);
        }
        public ReportResponse GenerateSchemeSummaryReport(ReportRequest request)
        {
            ReportDataAccess dataAccess = new ReportDataAccess();

            return dataAccess.GenerateSchemeSummaryReport(request);
        }
        public ReportResponse GenerateSubSectorSummaryReport(ReportRequest request)
        {
            ReportDataAccess dataAccess = new ReportDataAccess();

            return dataAccess.GenerateSubSectorSummaryReport(request);
        }
        public ReportResponse GenerateStatusWiseReport(ReportRequest request)
        {
            ReportDataAccess dataAccess = new ReportDataAccess();

            return dataAccess.GenerateStatusWiseReport(request);
        }
        public ReportResponse GenerateSchemeWithNoReleaseReport(ReportRequest request)
        {
            ReportDataAccess dataAccess = new ReportDataAccess();

            return dataAccess.GenerateSchemeWithNoReleaseReport(request);
        }
        public ReportResponse GenerateSchemeWithReleaseNoExpenseReport(ReportRequest request)
        {
            ReportDataAccess dataAccess = new ReportDataAccess();

            return dataAccess.GenerateSchemeWithReleaseNoExpenseReport(request);
        }
        public ReportResponse GenerateFunctionWiseReport(ReportRequest request)
        {
            ReportDataAccess dataAccess = new ReportDataAccess();

            return dataAccess.GenerateFunctionWiseReport(request);
        }
        public ReportResponse GenerateObjectWiseReport(ReportRequest request)
        {
            ReportDataAccess dataAccess = new ReportDataAccess();

            return dataAccess.GenerateObjectWiseReport(request);
        }
        public ReportResponse GenerateExcessSurrenderReport(ReportRequest request)
        {
            ReportDataAccess dataAccess = new ReportDataAccess();

            return dataAccess.GenerateExcessSurrenderReport(request);
        }
        public ReportResponse GenerateADPSchemeDetailReport(ReportRequest request)
        {
            ReportDataAccess dataAccess = new ReportDataAccess();

            return dataAccess.GenerateADPSchemeDetailReport(request);
        }
        public ReportResponse GenerateExcessSurrenderStatementReport(ReportRequest request)
        {
            ReportDataAccess dataAccess = new ReportDataAccess();

            return dataAccess.GenerateExcessSurrenderStatementReport(request);
        }
        public ReportResponse GenerateNewMonthlyProgressReport(ReportRequest request)
        {
            ReportDataAccess dataAccess = new ReportDataAccess();

            return dataAccess.GenerateNewMonthlyProgressReport(request);
        }
        public ReportResponse GeneratePC1SchemeReport(ReportRequest request)
        {
            ReportDataAccess dataAccess = new ReportDataAccess();

            return dataAccess.GeneratePC1SchemeReport(request);
        }
        public ReportResponse GeneratePC1SchemeStageReport(ReportRequest request)
        {
            ReportDataAccess dataAccess = new ReportDataAccess();

            return dataAccess.GeneratePC1SchemeStageReport(request);
        }
        public ReportResponse GeneratePC1SchemeStatusReport(ReportRequest request)
        {
            ReportDataAccess dataAccess = new ReportDataAccess();

            return dataAccess.GeneratePC1SchemeStatusReport(request);
        }
        public ReportResponse GenerateSubSectorMonthlyProgressReport(ReportRequest request)
        {
            ReportDataAccess dataAccess = new ReportDataAccess();

            return dataAccess.GenerateSubSectorMonthlyProgressReport(request);
        }
        public ReportResponse GenerateObjectMonthlyProgressReport(ReportRequest request)
        {
            ReportDataAccess dataAccess = new ReportDataAccess();

            return dataAccess.GenerateObjectMonthlyProgressReport(request);
        }
        public ReportResponse GenerateFunctionMonthlyProgressReport(ReportRequest request)
        {
            ReportDataAccess dataAccess = new ReportDataAccess();

            return dataAccess.GenerateFunctionMonthlyProgressReport(request);
        }
        public ReportResponse GenerateSubSectorSummaryMonthlyReviewReport(ReportRequest request)
        {
            ReportDataAccess dataAccess = new ReportDataAccess();

            return dataAccess.GenerateSubSectorSummaryMonthlyReviewReport(request);
        }
        public ReportResponse GenerateConstituencySummaryMonthlyReviewReport(ReportRequest request)
        {
            ReportDataAccess dataAccess = new ReportDataAccess();

            return dataAccess.GenerateConstituencySummaryMonthlyReviewReport(request);
        }
        public ReportResponse GenerateProjectLedgerReport(ReportRequest request)
        {
            ReportDataAccess dataAccess = new ReportDataAccess();

            return dataAccess.GenerateProjectLedgerReport(request);
        }
        public ReportResponse GenerateADPSummaryReport(ReportRequest request)
        {
            ReportDataAccess dataAccess = new ReportDataAccess();

            return dataAccess.GenerateADPSummaryReport(request);
        }
        public ReportResponse GenerateADPComparativeReport(ReportRequest request)
        {
            ReportDataAccess dataAccess = new ReportDataAccess();

            return dataAccess.GenerateADPComparativeReport(request);
        }
        public ReportResponse GenerateADPHistoricalTrendReport(ReportRequest request)
        {
            ReportDataAccess dataAccess = new ReportDataAccess();

            return dataAccess.GenerateADPHistoricalTrendReport(request);
        }
        public ReportResponse GenerateADPAbstractReport(ReportRequest request)
        {
            ReportDataAccess dataAccess = new ReportDataAccess();

            return dataAccess.GenerateADPAbstractReport(request);
        }
        public ReportResponse GenerateADPDetailReport(ReportRequest request)
        {
            ReportDataAccess dataAccess = new ReportDataAccess();

            return dataAccess.GenerateADPDetailReport(request);
        }
    }
}
