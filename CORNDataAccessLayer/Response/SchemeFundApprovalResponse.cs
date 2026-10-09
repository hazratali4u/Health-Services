using System.Collections.Generic;

namespace CORNDataAccessLayer.Response
{
    public class SchemeFundApprovalResponse
    {
        public List<SchemeFundApproval> SchemeFundApprovalList { get; set; }
        public SchemeFundApproval SchemeFundApprovalObject { get; set; }
        public List<SchemeFundApprovalDetail> SchemeFundApprovalDetailList { get; set; }
        public bool Status { get; set; }
    }
}
