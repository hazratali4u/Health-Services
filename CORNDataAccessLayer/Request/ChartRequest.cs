using System;

namespace CORNDataAccessLayer.Request
{
    public class ChartRequest
    {
        public int InstituteId { get; set; }
        public int FinancialYearId { get; set; }
        public DateTime ToDate { get; set; }
        public long UserId { get; set; }
        public long DistrictId { get; set; }
        public long ConstituencyId { get; set; }
    }
}
