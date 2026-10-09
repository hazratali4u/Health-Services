using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace CORNDataAccessLayer
{
    public class SchemeFundAllocation
    {
        public long Id { get; set; }
        public long SchemeId { get; set; }
        public long FinancialYearId { get; set; }
        public int FundAllocationTypeId { get; set; }
        [JsonIgnore]
        public DateTime FaDate { get; set; }
        public long UserId { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        [JsonIgnore]
        public DateTime Date { get; set; }
        public string FaDateString
        {
            get
            {
                return FaDate.ToString("dd-MMM-yyyy");
            }
        }
        public string DateString
        {
            get
            {
                return Date.ToString("dd-MMM-yyyy");
            }
        }

        public List<SchemeFundAllocationDetail> SchemeFundAllocationDetailList { get; set; }
        public string SchemeTitle { get; set; }
        public string YearName { get; set; }
        public string FundAllocationTypeName { get; set; }
        public long SchemeStatusId { get; set; }
    }
}
