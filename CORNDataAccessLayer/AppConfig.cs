using System;

namespace CORNDataAccessLayer
{
    public class AppConfig
    {
        public long Id { get; set; }
        public string propTitle { get; set; }
        public string propValue { get; set; }
        public bool isActive { get; set; }
        public bool isDeleted { get; set; }
        public DateTime createdDate { get; set; }
    }
}
