using Newtonsoft.Json;
using System;

namespace CORNDataAccessLayer
{
    public class SchemePOReferenceNo
    {
        public long Id { get; set; }
        public long SchemeId { get; set; }
        public long SchemeExpenseBookingId { get; set; }
        public string POReferenceNo { get; set; }
        public bool IsFullyPaid { get; set; }
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
    }
}
