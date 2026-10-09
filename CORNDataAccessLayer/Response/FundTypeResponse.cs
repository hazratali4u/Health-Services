using System.Collections.Generic;

namespace CORNDataAccessLayer.Response
{
    public class FundTypeResponse
    {
        public List<FundType> FundTypeList { get; set; }
        public FundType FundTypeObject { get; set; }
        public long Id { get; set; }
        public bool Status { get; set; }
    }
}
