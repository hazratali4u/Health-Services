using System.Collections.Generic;

namespace CORNDataAccessLayer.Response
{
    public class SponsoringResponse
    {
        public List<Sponsoring> SponsoringList { get; set; }
        public Sponsoring SponsoringObject { get; set; }
        public long Id { get; set; }
        public bool Status { get; set; }
    }
}
