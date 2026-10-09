using System.Collections.Generic;

namespace CORNDataAccessLayer.Response
{
    public class ConcernedFederalMinistryResponse
    {
        public List<ConcernedFederalMinistry> ConcernedFederalMinistryList { get; set; }
        public ConcernedFederalMinistry ConcernedFederalMinistryObject { get; set; }
        public long Id { get; set; }
        public bool Status { get; set; }
    }
}
