namespace CORNDataAccessLayer.Request
{
    public class GeoHierarchyRequest
    {
        public GeoHierarchy GeoHierarchyObject { get; set; }
        public long Id { get; set; }
        public long UserId { get; set; }
        public int TypeId { get; set; }
        public int ParentId { get; set; }
    }
}
