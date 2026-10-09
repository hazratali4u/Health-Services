using System.Collections.Generic;

namespace CORNDataAccessLayer.Response
{
    public class SchemeFundReleaseResponse
    {
        public List<SchemeFundRelease> SchemeFundReleaseList { get; set; }
        public SchemeFundRelease SchemeFundReleaseObject { get; set; }
        public List<SchemeFundReleaseDetail> SchemeFundReleaseDetailList { get; set; }
        public List<SchemeFundAllocationDetail> SchemeFundAllocationDetailList { get; set; }
        public List<SchemeReappropriationDetail> SchemeReappropriationDetailList { get; set; }
        public List<SchemeExcessDetail> SchemeExcessDetailList { get; set; }
        public bool Status { get; set; }
    }
}
