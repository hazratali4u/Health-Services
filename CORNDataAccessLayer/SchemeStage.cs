using Newtonsoft.Json;
using System;

namespace CORNDataAccessLayer
{
    public class SchemeStage
    {
        public long Id { get; set; }
        public long SchemeId { get; set; }
        [JsonIgnore]
        public DateTime StgDate { get; set; }
        public long StageStatusId { get; set; }
        public string ReferenceNo { get; set; }
        public string Remarks { get; set; }
        public long UserId { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        [JsonIgnore]
        public DateTime Date { get; set; }
        public string StgDateString
        {
            get
            {
                return StgDate.ToString("dd-MMM-yyyy");
            }
        }
        public string DateString
        {
            get
            {
                return Date.ToString("dd-MMM-yyyy");
            }
        }

        public string SchemeTitle { get; set; }
        public string SchemeStageStatusTitle { get; set; }
    }
}
