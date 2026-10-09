using System.Collections.Generic;

namespace CORNDataAccessLayer
{
    public class Institute
    {
        public long Id { get; set; }
        public string Title { get; set; }

        public List<SubSector> SubSectorList { get; set; }
        public List<InstituteStats> InstituteStatsList { get; set; }
    }
}
