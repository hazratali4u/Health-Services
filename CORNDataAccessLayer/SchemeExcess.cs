using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace CORNDataAccessLayer
{
    public class SchemeExcess
    {
        public long Id { get; set; }
        public long SchemeId { get; set; }
        public long FinancialYearId { get; set; }
        [JsonIgnore]
        public DateTime ExcessDate { get; set; }
        public string ExcessDateString
        {
            get
            {
                return ExcessDate.ToString("dd-MMM-yyyy");
            }
        }
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

        public List<SchemeExcessDetail> SchemeExcessDetailList { get; set; }
        public string SchemeTitle { get; set; }
        public string YearName { get; set; }
    }
}
