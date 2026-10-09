namespace CORNDataAccessLayer
{
    public class SchemeFundProposalDetail
    {
        public long lngPlanDetailCode { get; set; }
        public long lngPlanID { get; set; }
        public int intProposalTypeID { get; set; }
        public int intFYID { get; set; }
        public int intAccountHeadID { get; set; }
        public decimal decCostCapital { get; set; }
        public decimal decCostRevenue { get; set; }
        public decimal decCostForeignFunding { get; set; }
        public decimal decCostPC1 { get; set; }
        public string strDescription { get; set; }
        public int intCostTypeId { get; set; }

        public string YearName { get; set; }
        public string COAName { get; set; }
    }
}
