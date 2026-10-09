using System.Collections.Generic;

namespace CORNDataAccessLayer.Response
{
    public class SchemeExcessResponse
    {
        public List<SchemeExcess> SchemeExcessList { get; set; }
        public SchemeExcess SchemeExcessObject { get; set; }
        public bool Status { get; set; }
    }
}
