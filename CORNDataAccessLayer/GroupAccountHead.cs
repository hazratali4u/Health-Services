using Newtonsoft.Json;
using System;

namespace CORNDataAccessLayer
{
    public class GroupAccountHead
    {
        public long Id { get; set; }
        public long GroupId { get; set; }
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

        public string COAName { get; set; }
    }
}
