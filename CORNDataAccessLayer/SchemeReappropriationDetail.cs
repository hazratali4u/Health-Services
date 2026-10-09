using Newtonsoft.Json;
using System;

namespace CORNDataAccessLayer
{
    public class SchemeReappropriationDetail
    {
        public long Id { get; set; }
        public long SchemeReappropriationId { get; set; }
        public long FromFundTypeId { get; set; }
        public long FromSchemeId { get; set; }
        public long FromCOAId { get; set; }
        public long ToFundTypeId { get; set; }
        public long ToSchemeId { get; set; }
        public long ToCOAId { get; set; }
        public decimal Amount { get; set; }
        [JsonIgnore]
        public DateTime TransactionDate { get; set; }
        public string TransactionDateString
        {
            get
            {
                return TransactionDate.ToString("dd-MMM-yyyy");
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

        public string FromSchemeTitle { get; set; }
        public string ToSchemeTitle { get; set; }
        public string FromCOAName { get; set; }
        public string ToCOAName { get; set; }
    }
}
