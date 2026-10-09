using Newtonsoft.Json;
using System;

namespace CORNDataAccessLayer
{
    public class GeoHierarchy
    {
        public long Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public long ParentId { get; set; }
        public long TypeId { get; set; }
        public bool IsActive { get; set; }

        public string Division { get; set; }
        public string Region { get; set; }
    }
}
