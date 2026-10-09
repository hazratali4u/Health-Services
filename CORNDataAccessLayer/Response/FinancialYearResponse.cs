using System.Collections.Generic;

namespace CORNDataAccessLayer.Response
{
    public class FinancialYearResponse
    {
        public List<FinancialYear> FinancialYearList { get; set; }
        public FinancialYear FinancialYearObject { get; set; }
        public long Id { get; set; }
        public bool Status { get; set; }
    }
}
