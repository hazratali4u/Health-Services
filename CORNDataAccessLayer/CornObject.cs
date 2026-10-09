using System.Collections.Generic;

namespace CORNDataAccessLayer
{
    public class CornObject
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }

        public long LocalProjectCount { get; set; }
        public long ForeignProjectCount { get; set; }
        public decimal LocalBudgetEstimate { get; set; }
        public decimal ForeignBudgetEstimate { get; set; }
        public decimal ExpenseUpToJune { get; set; }
        public decimal LocalAllocation { get; set; }
        public decimal ForeignAllocation { get; set; }

        public long NewProjectCount { get; set; }
        public long OnGoingProjectCount { get; set; }
        public decimal NewBudgetEstimate { get; set; }
        public decimal OnGoingBudgetEstimate { get; set; }
        public decimal NewAllocation { get; set; }
        public decimal OnGoingAllocation { get; set; }

        public decimal PreviousYearProjectCount { get; set; }
        public decimal YearProjectCount { get; set; }
        public decimal PreviousYearBudgetEstimate { get; set; }
        public decimal YearBudgetEstimate { get; set; }
        public decimal PreviousYearAllocation { get; set; }
        public decimal YearAllocation { get; set; }

        public decimal PreviousLocalAllocation1 { get; set; }
        public decimal PreviousForeignAllocation1 { get; set; }
        public decimal PreviousLocalAllocation2 { get; set; }
        public decimal PreviousForeignAllocation2 { get; set; }
        public decimal PreviousLocalAllocation3 { get; set; }
        public decimal PreviousForeignAllocation3 { get; set; }
        public decimal PreviousLocalAllocation4 { get; set; }
        public decimal PreviousForeignAllocation4 { get; set; }

        public long MinorAccountHeadId { get; set; }
        public string MinorAccountHeadTitle { get; set; }
        public string MinorAccountHeadCode { get; set; }
        public long MajorAccountHeadId { get; set; }
        public string MajorAccountHeadTitle { get; set; }
        public string MajorAccountHeadCode { get; set; }

        public string GroupBy { get; set; }
        public decimal TotalNumber { get; set; }
        public decimal TotalBudgetEstimateGroupBy { get; set; }
        public decimal TotalAllocationGroupBy { get; set; }

        public decimal Allocation { get; set; }
        public decimal Supplementary { get; set; }
        public decimal Release { get; set; }
        public decimal Revise { get; set; }
        public decimal ExecessSurrender { get; set; }
        public decimal Expense { get; set; }
        public long TotalProjectCount { get; set; }
        public long TotalPreviousApprovedProjectCount { get; set; }
        public long PreviousApprovedNewProjectCount { get; set; }
        public long PreviousApprovedOnGoingProjectCount { get; set; }
        public long TotalPreviousUnApprovedProjectCount { get; set; }
        public long PreviousUnApprovedNewProjectCount { get; set; }
        public long PreviousUnApprovedOnGoingProjectCount { get; set; }
        public long TotalApprovedProjectCount { get; set; }
        public long ApprovedNewProjectCount { get; set; }
        public long ApprovedOnGoingProjectCount { get; set; }
        public long TotalUnApprovedProjectCount { get; set; }
        public long UnApprovedNewProjectCount { get; set; }
        public long UnApprovedOnGoingProjectCount { get; set; }

        public long ParentId { get; set; }
        public long CategoryId { get; set; }
        public decimal CapitalAllocation { get; set; }
        public decimal RevenueAllocation { get; set; }
        public List<CornObject> Child1CornObjectList { get; set; }
        public List<CornObject> Child2CornObjectList { get; set; }
    }
}
