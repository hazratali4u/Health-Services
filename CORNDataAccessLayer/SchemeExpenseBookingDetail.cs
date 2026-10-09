using Newtonsoft.Json;
using System;

namespace CORNDataAccessLayer
{
    public class SchemeExpenseBookingDetail
    {
        public long Id { get; set; }
        public long SchemeExpenseBookingId { get; set; }
        public long COAId { get; set; }
        public int ExpenseTypeId { get; set; }
        public decimal ExpenseAmount { get; set; }
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
        public string ExpenseTypeName { get; set; }
        public int TypeId { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
    }
}
