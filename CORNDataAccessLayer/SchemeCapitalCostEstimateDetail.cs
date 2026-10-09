using Newtonsoft.Json;
using System;

namespace CORNDataAccessLayer
{
    public class SchemeCapitalCostEstimateDetail
    {
        public long Id { get; set; }
        public long SchemeCapitalCostEstimateId { get; set; }
        public long FYId { get; set; }
        public string Title { get; set; }
        public double Quantity { get; set; }
        public double UnitPrice { get; set; }
        public long AccountHeadId { get; set; }
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

        public string AccountHeadTitle { get; set; }
    }
}
