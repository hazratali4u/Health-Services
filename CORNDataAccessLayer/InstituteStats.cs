namespace CORNDataAccessLayer
{
    public class InstituteStats
    {
        public long Id { get; set; }
        public string Title { get; set; }

        public long InstituteId { get; set; }
        public long StatusDetailId { get; set; }
        public string StatusDetailTitle { get; set; }
        public long NewSchemeCount { get; set; }
        public long OnGoingSchemeCount { get; set; }
        public long SupplementarySchemeCount { get; set; }
        public long UnfundedSchemeCount { get; set; }
    }
}
