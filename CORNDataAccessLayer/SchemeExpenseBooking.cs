using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace CORNDataAccessLayer
{
    public class SchemeExpenseBooking
    {
        public long Id { get; set; }
        public long SchemeId { get; set; }
        public int ExpenseBookingTypeId { get; set; }
        [JsonIgnore]
        public DateTime ExpenseDate { get; set; }
        [JsonIgnore]
        public DateTime? PaymentDueDate { get; set; }
        public long SchemePOReferenceNoId { get; set; }
        public string InvoiceNo { get; set; }
        public string DocumentReferenceNo { get; set; }
        public string Payee { get; set; }
        public string Remarks { get; set; }
        public long UserId { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        [JsonIgnore]
        public DateTime Date { get; set; }
        public string ExpenseDateString
        {
            get
            {
                return ExpenseDate.ToString("dd-MMM-yyyy");
            }
        }
        public string PaymentDueDateString
        {
            get
            {
                if (PaymentDueDate.HasValue)
                {
                    return PaymentDueDate.Value.ToString("dd-MMM-yyyy");
                }
                else
                {
                    return "-";
                }
            }
        }
        public string DateString
        {
            get
            {
                return Date.ToString("dd-MMM-yyyy");
            }
        }

        public List<SchemeExpenseBookingDetail> SchemeExpenseBookingDetailList { get; set; }
        public List<SchemeExpenseBookingFile> SchemeExpenseBookingFileList { get; set; }
        public string SchemeTitle { get; set; }
        public string BookingTypeTitle { get; set; }
        public string POReferenceNo { get; set; }
        public bool IsFullyPaid { get; set; }

        public string POReferenceOrInvoiceNo { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
