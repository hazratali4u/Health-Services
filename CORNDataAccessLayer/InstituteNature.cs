using Newtonsoft.Json;
using System;

namespace CORNDataAccessLayer
{
    public class InstituteNature
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string ShortTitle { get; set; }
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
