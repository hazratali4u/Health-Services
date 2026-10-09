namespace CORNDataAccessLayer.Request
{
    public class FinancialYearRequest
    {
        public FinancialYear FinancialYearObject { get; set; }
        public long Id { get; set; }
        public long UserId { get; set; }
        public long SchemeId { get; set; }
        public int SchemeFetchMode { get; set; }
    }
}
