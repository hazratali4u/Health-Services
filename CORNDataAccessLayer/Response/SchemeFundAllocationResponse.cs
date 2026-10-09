using System.Collections.Generic;

namespace CORNDataAccessLayer.Response
{
    public class SchemeFundAllocationResponse
    {
        public List<SchemeFundAllocation> SchemeFundAllocationList { get; set; }
        public SchemeFundAllocation SchemeFundAllocationObject { get; set; }
        public List<SchemeFundAllocationDetail> SchemeFundAllocationDetailList { get; set; }
        public bool Status { get; set; }
    }
}
