using Newtonsoft.Json;
using System;

namespace CORNDataAccessLayer
{
    public class SchemeExcessDetail
    {
        public long Id { get; set; }
        public long SchemeExcessId { get; set; }
        public int TypeId { get; set; }
        public long COAId { get; set; }
        public decimal Amount { get; set; }
        public int AmountStatusId { get; set; }
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

        public string COAName { get; set; }
        public string AmountStatusName { get; set; }
    }
}
