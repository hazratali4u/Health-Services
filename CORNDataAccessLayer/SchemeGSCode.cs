using Newtonsoft.Json;
using System;

namespace CORNDataAccessLayer
{
    public class SchemeGSCode
    {
        public long lngSchemeID { get; set; }
        [JsonIgnore]
        public DateTime dtmFinancialYear { get; set; }
        public string dtmFinancialYearString
        {
            get
            {
                return dtmFinancialYear.ToString("dd-MMM-yyyy");
            }
        }
        public int dtmFinancialYearValue
        {
            get
            {
                return Convert.ToInt32(dtmFinancialYear.ToString("yyyy"));
            }
        }
        public string strGSCode { get; set; }
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
    }
}
