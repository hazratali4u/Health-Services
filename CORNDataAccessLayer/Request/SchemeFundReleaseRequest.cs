namespace CORNDataAccessLayer.Request
{
    public class SchemeFundReleaseRequest
    {
        public SchemeFundRelease SchemeFundReleaseObject { get; set; }
        public long Id { get; set; }
        public long UserId { get; set; }
        public long SchemeId { get; set; }
        public long FinancialYearId { get; set; }
        public long COAId { get; set; }
    }
}
