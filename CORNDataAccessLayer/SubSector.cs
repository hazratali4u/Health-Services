namespace CORNDataAccessLayer
{
    public class SubSector
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public long NewSchemeCount { get; set; }
        public long OnGoingSchemeCount { get; set; }
        public long SupplementarySchemeCount { get; set; }
        public long UnfundedSchemeCount { get; set; }
        public long InstituteId { get; set; }
        public decimal BudgetEstimate { get; set; }
        public decimal Release { get; set; }
        public decimal Expenditure { get; set; }
        public decimal ADPAllocation { get; set; }
        public decimal Supplementary { get; set; }
        public decimal ReappPositive { get; set; }
        public decimal ReappNegative { get; set; }
        public decimal Excess { get; set; }
        public decimal Surrender { get; set; }
        public decimal ApproveCapitalAmount { get; set; }
        public decimal ApproveRevenueAmount { get; set; }
        public decimal ApproveForignFundAmount { get; set; }
        public decimal AllocationCapitalAmount { get; set; }
        public decimal AllocationRevenueAmount { get; set; }
        public decimal AllocationForignFundAmount { get; set; }
        public decimal ReleasePMCapitalAmount { get; set; }
        public decimal ReleasePMRevenueAmount { get; set; }
        public decimal ReleasePMForignFundAmount { get; set; }
        public decimal ReleaseMCapitalAmount { get; set; }
        public decimal ReleaseMRevenueAmount { get; set; }
        public decimal ReleaseMForignFundAmount { get; set; }
        public decimal ExpenseCapitalAmount { get; set; }
        public decimal ExpenseRevenueAmount { get; set; }
        public decimal ExpenseForignFundAmount { get; set; }
        public decimal ExpensePMCapitalAmount { get; set; }
        public decimal ExpensePMRevenueAmount { get; set; }
        public decimal ExpensePMForignFundAmount { get; set; }
        public decimal ExpenseMCapitalAmount { get; set; }
        public decimal ExpenseMRevenueAmount { get; set; }
        public decimal ExpenseMForignFundAmount { get; set; }
        public decimal ExcessCapitalAmount { get; set; }
        public decimal ExcessRevenueAmount { get; set; }
        public decimal ExcessForignFundAmount { get; set; }
        public decimal SurrenderCapitalAmount { get; set; }
        public decimal SurrenderRevenueAmount { get; set; }
        public decimal SurrenderForignFundAmount { get; set; }
        public decimal ReappPositiveCapitalAmount { get; set; }
        public decimal ReappPositiveRevenueAmount { get; set; }
        public decimal ReappPositiveForignFundAmount { get; set; }
        public decimal ReappNegativeCapitalAmount { get; set; }
        public decimal ReappNegativeRevenueAmount { get; set; }
        public decimal ReappNegativeForignFundAmount { get; set; }
        public decimal FinalCapitalGrant { get; set; }
        public decimal FinalRevenueGrant { get; set; }
        public decimal FinalForignFundGrant { get; set; }
    }
}
