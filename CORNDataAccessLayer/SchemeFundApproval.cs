using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace CORNDataAccessLayer
{
    public class SchemeFundApproval
    {
        public long Id { get; set; }
        public long SchemeId { get; set; }
        public int StatusId { get; set; }
        [JsonIgnore]
        public DateTime StDate { get; set; }
        public long ApprovedBy { get; set; }
        public string ReferenceNo { get; set; }
        public long UserId { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        [JsonIgnore]
        public DateTime Date { get; set; }
        public string StDateString
        {
            get
            {
                return StDate.ToString("dd-MMM-yyyy");
            }
        }
        public string DateString
        {
            get
            {
                return Date.ToString("dd-MMM-yyyy");
            }
        }

        public List<SchemeFundApprovalDetail> SchemeFundApprovalDetailList { get; set; }
        public string SchemeTitle { get; set; }
        public string StatusTitle { get; set; }

        public string ApprovedByAndDate { get; set; }
        public decimal CapitalAmount { get; set; }
        public decimal RevenueAmount { get; set; }
    }
}
