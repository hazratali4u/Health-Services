using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace CORNDataAccessLayer
{
    public class FinancialYear
    {
        public long Id { get; set; }
        public string ShortName { get; set; }
        public string YearName { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        [JsonIgnore]
        public DateTime StartDate { get; set; }
        public string StartDateString
        {
            get
            {
                return StartDate.ToString("dd-MMM-yyyy");
            }
        }
        public string StartDateStandardString
        {
            get
            {
                return StartDate.ToString("yyyy-MM-dd");
            }
        }
        [JsonIgnore]
        public DateTime EndDate { get; set; }
        public string EndDateString
        {
            get
            {
                return EndDate.ToString("dd-MMM-yyyy");
            }
        }
        public string EndDateStandardString
        {
            get
            {
                return EndDate.ToString("yyyy-MM-dd");
            }
        }
        public bool IsOpen { get; set; }
        public bool IsClosed { get; set; }
        public bool IsActive { get; set; }

        public List<SchemeCapitalCostEstimateDetail> SchemeCapitalCostEstimateDetailList { get; set; }
        public long SchemeCapitalCostEstimateId { get; set; }
    }
}
