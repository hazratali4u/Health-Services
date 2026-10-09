using System.Collections.Generic;

namespace CORNDataAccessLayer.Response
{
    public class SchemeDocumentResponse
    {
        public List<SchemeDocument> SchemeDocumentList { get; set; }
        public SchemeDocument SchemeDocumentObject { get; set; }
        public bool Status { get; set; }
    }
}
