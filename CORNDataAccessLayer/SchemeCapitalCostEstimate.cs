using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace CORNDataAccessLayer
{
    public class SchemeCapitalCostEstimate
    {
        public long Id { get; set; }
        public long SchemeId { get; set; }
        public string Title { get; set; }
        public long GroupId { get; set; }
        public long UserId { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        [JsonIgnore]
        public DateTime Date { get; set; }
        public string DateString
        {
            get
            {
                return Date.ToString("dd-MMM-yyyy");
            }
        }

        public List<SchemeCapitalCostEstimateDetail> SchemeCapitalCostEstimateDetailList { get; set; }
        public List<FinancialYear> FinancialYearList { get; set; }
        public string GroupTitle { get; set; }
    }
}
