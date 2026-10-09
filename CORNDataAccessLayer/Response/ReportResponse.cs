using System.Collections.Generic;

namespace CORNDataAccessLayer.Response
{
    public class ReportResponse
    {
        public List<CornReport> CornReportList { get; set; }
        public string Month { get; set; }
        public string Year { get; set; }
        public string PreviousYear { get; set; }
        public string ExpectedYear { get; set; }
        public string FinancialYear { get; set; }
        public string NextFinancialYear { get; set; }
        public string PreviousFinancialYear { get; set; }
        public string Date { get; set; }
        public string Title { get; set; }
        public string District { get; set; }
        public string FundType { get; set; }
        public string PreviousFinancialYear1 { get; set; }
        public string PreviousFinancialYear2 { get; set; }
        public string PreviousFinancialYear3 { get; set; }
        public string PreviousFinancialYear4 { get; set; }
        public string Constituency { get; set; }
    }
}
