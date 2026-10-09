namespace CORNDataAccessLayer.Request
{
    public class SchemeExcessRequest
    {
        public SchemeExcess SchemeExcessObject { get; set; }
        public long Id { get; set; }
        public long UserId { get; set; }
        public long SchemeId { get; set; }
    }
}
