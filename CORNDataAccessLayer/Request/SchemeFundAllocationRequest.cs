namespace CORNDataAccessLayer.Request
{
    public class SchemeFundAllocationRequest
    {
        public SchemeFundAllocation SchemeFundAllocationObject { get; set; }
        public long Id { get; set; }
        public long UserId { get; set; }
        public long SchemeId { get; set; }
        public long FinancialYearId { get; set; }
        public long COAId { get; set; }
    }
}
