using System.Collections.Generic;

namespace CORNDataAccessLayer.Response
{
    public class SchemeReappropriationResponse
    {
        public List<SchemeReappropriation> SchemeReappropriationList { get; set; }
        public SchemeReappropriation SchemeReappropriationObject { get; set; }
        public bool Status { get; set; }
    }
}
