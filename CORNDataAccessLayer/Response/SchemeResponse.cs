using System.Collections.Generic;

namespace CORNDataAccessLayer.Response
{
    public class SchemeResponse
    {
        public List<Scheme> SchemeList { get; set; }
        public List<SchemeFile> SchemeFileList { get; set; }
        public Scheme SchemeObject { get; set; }
        public long Id { get; set; }
        public bool Status { get; set; }
    }
}
