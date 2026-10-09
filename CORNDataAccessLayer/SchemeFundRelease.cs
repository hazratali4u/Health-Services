using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace CORNDataAccessLayer
{
    public class SchemeFundRelease
    {
        public long Id { get; set; }
        public long SchemeId { get; set; }
        public long FinancialYearId { get; set; }
        public int FundReleaseTypeId { get; set; }
        [JsonIgnore]
        public DateTime FrDate { get; set; }
        public long UserId { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        [JsonIgnore]
        public DateTime Date { get; set; }
        public string FrDateString
        {
            get
            {
                return FrDate.ToString("dd-MMM-yyyy");
            }
        }
        public string DateString
        {
            get
            {
                return Date.ToString("dd-MMM-yyyy");
            }
        }

        public List<SchemeFundReleaseDetail> SchemeFundReleaseDetailList { get; set; }
        public string SchemeTitle { get; set; }
        public string YearName { get; set; }
        public string FundReleaseTypeName { get; set; }
        public decimal TotalReleases { get; set; }
    }
}
