using System;

namespace CORNDataAccessLayer.Request
{
    public class ReportRequest
    {
        public int InstituteId { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int FinancialYearId { get; set; }
        public long MajorCAId { get; set; }
        public long MinorCAId { get; set; }
        public long UserId { get; set; }
        public int SchemeId { get; set; }
        public int DistrictId { get; set; }
        public DateTime FromDateTime { get; set; }
        public DateTime ToDateTime { get; set; }
        public int FundTypeId { get; set; }
        public int ReportTypeId { get; set; }
        public long SchemeStatusId { get; set; }
        public int ConstituencyId { get; set; }
    }
}
