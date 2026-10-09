using System.Collections.Generic;

namespace CORNDataAccessLayer.Response
{
    public class ApprovedByResponse
    {
        public List<ApprovedBy> ApprovedByList { get; set; }
        public ApprovedBy ApprovedByObject { get; set; }
        public long Id { get; set; }
        public bool Status { get; set; }
    }
}
