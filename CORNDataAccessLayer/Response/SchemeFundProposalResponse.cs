using System.Collections.Generic;

namespace CORNDataAccessLayer.Response
{
    public class SchemeFundProposalResponse
    {
        public List<SchemeFundProposal> SchemeFundProposalList { get; set; }
        public SchemeFundProposal SchemeFundProposalObject { get; set; }
        public bool Status { get; set; }
    }
}
