using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace CORNDataAccessLayer
{
    public class SchemeFundProposal
    {
        public long lngPlanCode { get; set; }
        public long lngSchemeID { get; set; }
        public int intFCAccountHeadID { get; set; }
        public int intProposedByID { get; set; }
        public int intProposalTypeID { get; set; }
        public string strRemarks { get; set; }
        [JsonIgnore]
        public DateTime dtmProposedDate { get; set; }
        public string dtmProposedDateString
        {
            get
            {
                return dtmProposedDate.ToString("dd-MMM-yyyy");
            }
        }
        public int intUserID { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        [JsonIgnore]
        public DateTime dtmTimeStamp { get; set; }
        public string dtmTimeStampString
        {
            get
            {
                return dtmTimeStamp.ToString("dd-MMM-yyyy");
            }
        }
        [JsonIgnore]
        public DateTime dtmLastM { get; set; }
        public string dtmLastMString
        {
            get
            {
                return dtmLastM.ToString("dd-MMM-yyyy");
            }
        }

        public List<SchemeFundProposalDetail> SchemeFundProposalDetailList { get; set; }
        public string SchemeTitle { get; set; }
        public string CategoryTitle { get; set; }
    }
}
