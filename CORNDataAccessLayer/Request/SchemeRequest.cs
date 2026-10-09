namespace CORNDataAccessLayer.Request
{
    public class SchemeRequest
    {
        public Scheme SchemeObject { get; set; }
        public string SchemeIds { get; set; }
        public long Id { get; set; }
        public long UserId { get; set; }
        public long CategoryId { get; set; }
        public long FYStartYear { get; set; }
        public long WizardStep { get; set; }
        public string FinancialYear { get; set; }
        public long FinancialYearId { get; set; }
    }
}
