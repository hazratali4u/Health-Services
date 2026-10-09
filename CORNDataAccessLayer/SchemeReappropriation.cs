using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace CORNDataAccessLayer
{
    public class SchemeReappropriation
    {
        public long Id { get; set; }
        public long FinancialYearId { get; set; }
        public int Month { get; set; }
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

        public List<SchemeReappropriationDetail> SchemeReappropriationDetailList { get; set; }
        public string YearName { get; set; }
        public string MonthName { get; set; }
    }
}
