using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace CORNDataAccessLayer
{
    public class Scheme
    {
        public long lngSchemeCode { get; set; }
        public string strSchemeCode { get; set; }
        public string strSchemeName { get; set; }
        public int intInstituteID { get; set; }
        public int intSubSectorID { get; set; }
        public int intCategoryID { get; set; }
        public int intFCAccountHeadID { get; set; }
        public int intRFCAccountHeadID { get; set; }
        public int intBankTypeID { get; set; }
        public string strRemarks { get; set; }
        public decimal decYearlyCostPer { get; set; }
        public decimal decYearlyCostAmount { get; set; }
        [JsonIgnore]
        public DateTime dtmSchemeDate { get; set; }
        public string dtmSchemeDateString
        {
            get
            {
                return dtmSchemeDate.ToString("dd-MMM-yyyy");
            }
        }
        [JsonIgnore]
        public DateTime dtmStartDate { get; set; }
        public string dtmStartDateString
        {
            get
            {
                return dtmStartDate.ToString("dd-MMM-yyyy");
            }
        }
        [JsonIgnore]
        public DateTime dtmEndDate { get; set; }
        public string dtmEndDateString
        {
            get
            {
                return dtmEndDate.ToString("dd-MMM-yyyy");
            }
        }
        public int intUserID { get; set; }
        public bool IsActive { get; set; }
        public string IsActiveString
        {
            get
            {
                if (IsActive)
                {
                    return "Active";
                }
                else
                {
                    return "In-Active";
                }
            }
        }
        public bool IsDeleted { get; set; }
        [JsonIgnore]
        public DateTime dtmTimeStamp { get; set; }
        [JsonIgnore]
        public DateTime dtmLastM { get; set; }
        public string strCapitalCode { get; set; }
        public decimal decRevenueAmount { get; set; }
        public decimal decCapitalAmount { get; set; }
        public decimal decLastYearExpense { get; set; }
        public long PC1SchemeId { get; set; }
        public long SchemeStatusId { get; set; }
        public long ParentSchemeId { get; set; }
        public bool IsForeignFunding { get; set; }
        public long financialYearId { get; set; }

        public string SchemeStatusTitle { get; set; }
        public string strGSCode { get; set; }
        [JsonIgnore]
        public DateTime dtmFinancialYear { get; set; }
        public string dtmFinancialYearString
        {
            get
            {
                return dtmFinancialYear.ToString("dd-MMM-yyyy");
            }
        }
        public decimal ThrowForward { get; set; }
        public string Year1Code { get; set; }
        public string Year2Code { get; set; }
        public string Year3Code { get; set; }

        public long Id { get; set; }
        public string Title { get; set; }
        public string ADPNo { get; set; }
        public long CategoryId { get; set; }
        public string CategoryTitle { get; set; }
        public long InstitutionId { get; set; }
        public string InstitutionTitle { get; set; }
        public long FundId { get; set; }
        public string FundTitle { get; set; }
        public long AccountHeadId { get; set; }
        public string AccountCode { get; set; }
        public string AccountName { get; set; }
        public long MinorAccountHeadId { get; set; }
        public string MinorAccountCode { get; set; }
        public string MinorAccountName { get; set; }
        public long MajorAccountHeadId { get; set; }
        public string MajorAccountCode { get; set; }
        public string MajorAccountName { get; set; }
        public long RAccountHeadId { get; set; }
        public string RAccountName { get; set; }
        public long SubSectorId { get; set; }
        public string SubSectorTitle { get; set; }
        public long ConstituencyId { get; set; }
        public string ConstituencyTitle { get; set; }
        public long BankTypeId { get; set; }
        public string BankTypeTitle { get; set; }
        [JsonIgnore]
        public DateTime SchemeDate { get; set; }
        public string SchemeDateString
        {
            get
            {
                return SchemeDate.ToString("dd-MMM-yyyy");
            }
        }
        [JsonIgnore]
        public DateTime StartDate { get; set; }
        public string StartDateString
        {
            get
            {
                return StartDate.ToString("dd-MMM-yyyy");
            }
        }
        [JsonIgnore]
        public DateTime EndDate { get; set; }
        public string EndDateString
        {
            get
            {
                return EndDate.ToString("dd-MMM-yyyy");
            }
        }
        public long DistrictId { get; set; }
        public string DistrictTitle { get; set; }
        public string DivisionTitle { get; set; }
        public string RegionTitle { get; set; }

        public string ApprovedStatusAndDate { get; set; }
        public decimal LastApprovedCapital { get; set; }
        public decimal LastApprovedRevenue { get; set; }
        public decimal LastExpenseCapital { get; set; }
        public decimal LastExpenseRevenue { get; set; }
        public decimal CurrentADPAllocationCapital { get; set; }
        public decimal CurrentADPAllocationRevenue { get; set; }
        public decimal CurrentSupplementaryCapital { get; set; }
        public decimal CurrentSupplementaryRevenue { get; set; }
        public decimal CurrentPositiveReappropriateCapital { get; set; }
        public decimal CurrentPositiveReappropriateRevenue { get; set; }
        public decimal CurrentNegativeReappropriateCapital { get; set; }
        public decimal CurrentNegativeReappropriateRevenue { get; set; }
        public decimal CurrentExcessCapital { get; set; }
        public decimal CurrentExcessRevenue { get; set; }
        public decimal CurrentSurrenderCapital { get; set; }
        public decimal CurrentSurrenderRevenue { get; set; }
        public decimal CurrentReleaseCapital { get; set; }
        public decimal CurrentReleaseRevenue { get; set; }
        public decimal CurrentExpenseCapital { get; set; }
        public decimal CurrentExpenseRevenue { get; set; }
        public decimal TotalApprovedCapital { get; set; }
        public decimal TotalApprovedRevenue { get; set; }
        public decimal BudgetEstimate { get; set; }
        public decimal Supplementary { get; set; }
        public decimal ADPAllocation { get; set; }
        public decimal ReappPositive { get; set; }
        public decimal ReappNegative { get; set; }
        public decimal Excess { get; set; }
        public decimal Surrender { get; set; }
        public decimal Release { get; set; }
        public decimal Expenditure { get; set; }
        public string Remarks { get; set; }
        public decimal ExpenditureQtr1 { get; set; }
        public decimal ExpenditureQtr2 { get; set; }
        public decimal ExpenditureQtr3 { get; set; }
        public decimal ExpenditureQtr4 { get; set; }
        public decimal ExpenditureThird1 { get; set; }
        public decimal ExpenditureThird2 { get; set; }
        public decimal ExpenditureThird3 { get; set; }
        public string ApprovalStatus { get; set; }
        public string ApprovalForumAndDate { get; set; }

        public double latitude { get; set; }
        public double longitude { get; set; }
        public long sponsoringId { get; set; }
        public long executionId { get; set; }
        public long operationMaintenanceId { get; set; }
        public long concernedFederalMinistryId { get; set; }
        public string step4Detail { get; set; }
        public string step5Detail { get; set; }
        public string step6Detail { get; set; }
        public string step9Detail { get; set; }
        public string step10Detail { get; set; }
        public string step11Detail { get; set; }
        public string step11Detail2 { get; set; }
        public string step11Detail3 { get; set; }
        public string step11Detail4 { get; set; }
        public string step11Detail5 { get; set; }
        public string step12Detail { get; set; }
        public string step12Detail2 { get; set; }
        public string step13Detail { get; set; }
        public string step14Detail { get; set; }
        public string step15Detail { get; set; }
        public string strPreparedBy { get; set; }
        public string strCheckedBy { get; set; }
        public string strApprovedBy { get; set; }
        public List<SchemeCapitalCostEstimate> SchemeCapitalCostEstimateList { get; set; }
        public List<SchemeAnnualOperatingCost> SchemeAnnualOperatingCostList { get; set; }
        public List<SchemeFile> SchemeFileList { get; set; }
        public long SchemeId { get; set; }

        public string SponsoringTitle { get; set; }
        public string ExecutionTitle { get; set; }
        public string OperationMaintenanceTitle { get; set; }
        public string ConcernedProvincialMinistryTitle { get; set; }

        public decimal ApproveCapitalAmount { get; set; }
        public decimal ApproveRevenueAmount { get; set; }
        public decimal ApproveForignFundAmount { get; set; }
        public decimal ExpensePYJCapitalAmount { get; set; }
        public decimal ExpensePYJRevenueAmount { get; set; }
        public decimal ExpensePYJForignFundAmount { get; set; }
        public decimal AllocationCapitalAmount { get; set; }
        public decimal AllocationRevenueAmount { get; set; }
        public decimal AllocationForignFundAmount { get; set; }
        public decimal ReleaseCapitalAmount { get; set; }
        public decimal ReleaseRevenueAmount { get; set; }
        public decimal ReleaseForignFundAmount { get; set; }
        public decimal ExpenseCapitalAmount { get; set; }
        public decimal ExpenseRevenueAmount { get; set; }
        public decimal ExpenseForignFundAmount { get; set; }
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

        [JsonIgnore]
        public DateTime TransactionDate { get; set; }
        public string TransactionDateString
        {
            get
            {
                return TransactionDate.ToString("dd-MMM-yyyy");
            }
        }
        public decimal Amount { get; set; }
        public decimal BudgetAllocation { get; set; }
        public decimal ExcessSurrender { get; set; }
        public decimal FinalGrant { get; set; }
        public decimal Balance { get; set; }
        public decimal ReleaseBalance { get; set; }

        public string SchemeFY { get; set; }
    }
}
