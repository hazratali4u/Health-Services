using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace CORNDataAccessLayer
{
    public class SchemeDocument
    {
        public long Id { get; set; }
        public long SchemeId { get; set; }
        public string Title { get; set; }
        [JsonIgnore]
        public DateTime DocDate { get; set; }
        public string ReferenceNo { get; set; }
        public string Version { get; set; }
        public string Remarks { get; set; }
        public long UserId { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        [JsonIgnore]
        public DateTime Date { get; set; }
        public string DocDateString
        {
            get
            {
                return DocDate.ToString("dd-MMM-yyyy");
            }
        }
        public string DateString
        {
            get
            {
                return Date.ToString("dd-MMM-yyyy");
            }
        }

        public List<SchemeDocumentFile> SchemeDocumentFileList { get; set; }
        public string SchemeTitle { get; set; }
    }
}
