using System.Collections.Generic;

namespace CORNDataAccessLayer.Response
{
    public class GeoHierarchyResponse
    {
        public List<GeoHierarchy> GeoHierarchyList { get; set; }
        public GeoHierarchy GeoHierarchyObject { get; set; }
        public long Id { get; set; }
        public bool Status { get; set; }
    }
}
