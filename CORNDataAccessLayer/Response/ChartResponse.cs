using System.Collections.Generic;

namespace CORNDataAccessLayer.Response
{
    public class ChartResponse
    {
        public List<Scheme> SchemeList { get; set; }
        public string FinancialYear { get; set; }
    }
}
