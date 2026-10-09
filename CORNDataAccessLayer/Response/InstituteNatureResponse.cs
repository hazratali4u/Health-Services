using System.Collections.Generic;

namespace CORNDataAccessLayer.Response
{
    public class InstituteNatureResponse
    {
        public List<InstituteNature> InstituteNatureList { get; set; }
        public InstituteNature InstituteNatureObject { get; set; }
        public long Id { get; set; }
        public bool Status { get; set; }
    }
}
