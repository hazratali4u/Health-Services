namespace CORNDatabaseLayer
{
    public static class DBConstants
    {
        public struct SchemeStageStatusDBConstant
        {
            public const string TBL_SCHEMESTAGESTATUS_GET_ALL = "tbl_SchemeStageStatus_get_all";
        }

        public struct SchemeStageDBConstant
        {
            public const string TBL_SCHEMESTAGE_GET_ALL = "tbl_SchemeStage_get_all";
            public const string TBL_SCHEMESTAGE_ADD = "tbl_SchemeStage_add";
        }

        public struct PC1SchemeStageDBConstant
        {
            public const string TBL_PC1SCHEMESTAGE_GET_ALL = "tbl_PC1SchemeStage_get_all";
            public const string TBL_PC1SCHEMESTAGE_ADD = "tbl_PC1SchemeStage_add";
        }

        public struct SchemeDocumentDBConstant
        {
            public const string TBL_SCHEMEDOCUMENT_GET_ALL = "tbl_SchemeDocument_get_all";
            public const string TBL_SCHEMEDOCUMENT_GET_ID = "tbl_SchemeDocument_get_id";
            public const string TBL_SCHEMEDOCUMENT_ADD = "tbl_SchemeDocument_add";
            public const string TBL_SCHEMEDOCUMENT_UPDATE = "tbl_SchemeDocument_update";
            public const string TBL_SCHEMEDOCUMENT_DELETE = "tbl_SchemeDocument_delete";
        }

        public struct SchemeFundApprovalDBConstant
        {
            public const string TBL_SCHEMEFUNDAPPROVAL_GET_ALL = "tbl_SchemeFundApproval_get_all";
            public const string KP_TBL_SCHEMEFUNDAPPROVAL_GET_ALL = "KP_tbl_SchemeFundApproval_get_all";
            public const string TBL_SCHEMEFUNDAPPROVAL_GET_ID = "tbl_SchemeFundApproval_get_id";
            public const string TBL_SCHEMEFUNDAPPROVAL_ADD = "tbl_SchemeFundApproval_add";
            public const string TBL_SCHEMEFUNDAPPROVAL_UPDATE = "tbl_SchemeFundApproval_update";
            public const string TBL_SCHEMEFUNDPROPOSED_GET_SCHEMEID = "tbl_SchemeFundProposed_get_schemeid";
        }

        public struct PC1SchemeFundApprovalDBConstant
        {
            public const string TBL_PC1SCHEMEFUNDAPPROVAL_GET_ALL = "tbl_PC1SchemeFundApproval_get_all";
            public const string TBL_PC1SCHEMEFUNDAPPROVAL_GET_ID = "tbl_PC1SchemeFundApproval_get_id";
            public const string TBL_PC1SCHEMEFUNDAPPROVAL_ADD = "tbl_PC1SchemeFundApproval_add";
            public const string TBL_PC1SCHEMEFUNDAPPROVAL_UPDATE = "tbl_PC1SchemeFundApproval_update";
            public const string TBL_PC1SCHEMEFUNDPROPOSED_GET_SCHEMEID = "tbl_PC1SchemeFundProposed_get_schemeid";
        }

        public struct ReportDBConstant
        {
            public const string TBL_REPORT_MONTHLY_PROGRESS = "tbl_Report_Monthly_Progress";
            public const string TBL_REPORT_FUND_WISE = "tbl_Report_Fund_Wise";
            public const string TBL_REPORT_SCHEME_BREAKUP = "tbl_Report_Scheme_Breakup";
            public const string TBL_REPORT_SUBSECTOR_WISE = "tbl_Report_SubSector_Wise";
            public const string TBL_REPORT_STATUS_WISE = "tbl_Report_Status_Wise";
            public const string TBL_REPORT_NO_RELEASE = "tbl_Report_No_Release";
            public const string TBL_REPORT_RELEASE_NO_EXPENSE = "tbl_Report_Release_No_Expense";
            public const string TBL_REPORT_FUNCTION_WISE = "tbl_Report_Function_Wise";
            public const string TBL_REPORT_OBJECT_WISE = "tbl_Report_Object_Wise";
            public const string TBL_REPORT_EXCESSSURRENDER_WISE = "tbl_Report_ExcessSurrender_Wise";
            public const string TBL_REPORT_SCHEME_DETAIL_ADP = "tbl_Report_Scheme_Detail_ADP";
            public const string TBL_REPORT_EXCESSSURRENDER_STATEMENT = "tbl_Report_ExcessSurrender_Statement";
            public const string TBL_REPORT_MONTHLY_PROGRESS_NEW = "tbl_Report_Monthly_Progress_New";
            public const string TBL_REPORT_PC1SCHEME = "tbl_Report_PC1Scheme";
            public const string TBL_REPORT_PC1SCHEMESTAGE = "tbl_Report_PC1SchemeStage";
            public const string TBL_REPORT_PC1SCHEMESTATUS = "tbl_Report_PC1SchemeStatus";
            public const string TBL_REPORT_MONTHLY_PROGRESS_SUBSECTOR_WISE = "tbl_Report_Monthly_Progress_SubSector_Wise";
            public const string KP_TBL_REPORT_MONTHLY_PROGRESS_SUBSECTOR_WISE = "KP_tbl_Report_Monthly_Progress_SubSector_Wise";
            public const string TBL_REPORT_MONTHLY_PROGRESS_OBJECT_WISE = "tbl_Report_Monthly_Progress_Object_Wise";
            public const string KP_TBL_REPORT_MONTHLY_PROGRESS_OBJECT_WISE = "KP_tbl_Report_Monthly_Progress_Object_Wise";
            public const string TBL_REPORT_MONTHLY_PROGRESS_FUNCTION_WISE = "tbl_Report_Monthly_Progress_Function_Wise";
            public const string KP_TBL_REPORT_MONTHLY_PROGRESS_FUNCTION_WISE = "KP_tbl_Report_Monthly_Progress_Function_Wise";
            public const string TBL_REPORT_MONTHLY_PROGRESS_REVIEW_SUBSECTOR_SUMMARY = "tbl_Report_Monthly_Progress_Review_SubSector_Summary";
            public const string KP_TBL_REPORT_MONTHLY_PROGRESS_REVIEW_SUBSECTOR_SUMMARY = "KP_tbl_Report_Monthly_Progress_Review_SubSector_Summary";
            public const string TBL_REPORT_MONTHLY_PROGRESS_REVIEW_CONSTITUENCY_SUMMARY = "tbl_Report_Monthly_Progress_Review_Constituency_Summary";
            public const string KP_TBL_REPORT_MONTHLY_PROGRESS_REVIEW_CONSTITUENCY_SUMMARY = "KP_tbl_Report_Monthly_Progress_Review_Constituency_Summary";
            public const string TBL_REPORT_PROJECT_LEDGER = "tbl_Report_Project_Ledger";
            public const string TBL_REPORT_ADP_SUBSECTOR_SUMMARY = "tbl_Report_ADP_SubSector_Summary";
            public const string TBL_REPORT_ADP_FUNCTION_SUMMARY = "tbl_Report_ADP_Function_Summary";
            public const string TBL_REPORT_ADP_STATUS_SUMMARY = "tbl_Report_ADP_Status_Summary";
            public const string TBL_REPORT_ADP_COMPARATIVE = "tbl_Report_ADP_Comparative";
            public const string TBL_REPORT_ADP_SUBSECTOR_HISTORICAL_TREND = "tbl_Report_ADP_SubSector_Historical_Trend";
            public const string TBL_REPORT_ADP_FUNCTION_HISTORICAL_TREND = "tbl_Report_ADP_Function_Historical_Trend";
            public const string TBL_REPORT_ADP_DETAILOBJECT_HISTORICAL_TREND = "tbl_Report_ADP_DetailObject_Historical_Trend";
            public const string TBL_REPORT_ADP_ABSTRACT = "tbl_Report_ADP_Abstract";
            public const string TBL_REPORT_ADP_SUBSECTOR_DETAIL = "tbl_Report_ADP_SubSector_Detail";
            public const string TBL_REPORT_ADP_DETAILOBJECT_DETAIL = "tbl_Report_ADP_DetailObject_Detail";
            public const string TBL_REPORT_ADP_FUNCTION_DETAIL = "tbl_Report_ADP_Function_Detail";
        }

        public struct ChartDBConstant
        {
            public const string TBL_CHART_STATUS_WISE = "tbl_Chart_Status_Wise";
            public const string TBL_CHART_FUND_WISE = "tbl_Chart_Fund_Wise";
            public const string TBL_CHART_FUNCTION_WISE = "tbl_Chart_Function_Wise";
            public const string TBL_CHART_OBJECT_WISE = "tbl_Chart_Object_Wise";
            public const string TBL_CHART_SUBSECTOR_WISE = "tbl_Chart_SubSector_Wise";
            public const string TBL_CHART_CONSTITUENCY_WISE = "tbl_Chart_Constituency_Wise";
            public const string KP_TBL_CHART_CONSTITUENCY_WISE = "KP_tbl_Chart_Constituency_Wise";
        }

        public struct ApprovedByDBConstant
        {
            public const string TBL_APPROVEDBY_GET_ALL = "tbl_ApprovedBy_get_all";
            public const string TBL_APPROVEDBY_GET_ID = "tbl_ApprovedBy_get_id";
            public const string TBL_APPROVEDBY_ADD = "tbl_ApprovedBy_add";
            public const string TBL_APPROVEDBY_UPDATE = "tbl_ApprovedBy_update";
            public const string TBL_APPROVEDBY_DELETE = "tbl_ApprovedBy_delete";
        }

        public struct SchemeExpenseBookingDBConstant
        {
            public const string TBL_SCHEMEEXPENSEBOOKING_GET_ALL = "tbl_SchemeExpenseBooking_get_all";
            public const string TBL_SCHEMEEXPENSEBOOKING_GET_ID = "tbl_SchemeExpenseBooking_get_id";
            public const string TBL_SCHEMEEXPENSEBOOKING_ADD = "tbl_SchemeExpenseBooking_add";
            public const string TBL_SCHEMEEXPENSEBOOKING_UPDATE = "tbl_SchemeExpenseBooking_update";
            public const string TBL_SCHEMEEXPENSEBOOKING_DELETE = "tbl_SchemeExpenseBooking_delete";
            public const string TBL_SCHEMEFUNDRELEASE_GET_SCHEMEID = "tbl_SchemeFundRelease_get_schemeid";
            public const string TBL_SCHEMEEXPENSEBOOKING_PAYEE_GET = "tbl_SchemeExpenseBooking_Payee_get";
        }

        public struct SchemePOReferenceNoDBConstant
        {
            public const string TBL_SCHEMEPOREFERENCENO_GET_ALL = "tbl_SchemePOReferenceNo_get_all";
        }

        public struct SchemeFundAllocationDBConstant
        {
            public const string TBL_SCHEMEFUNDALLOCATION_GET_ALL = "tbl_SchemeFundAllocation_get_all";
            public const string KP_TBL_SCHEMEFUNDALLOCATION_GET_ALL = "KP_tbl_SchemeFundAllocation_get_all";
            public const string TBL_SCHEMEFUNDALLOCATION_GET_ID = "tbl_SchemeFundAllocation_get_id";
            public const string TBL_SCHEMEFUNDALLOCATION_ADD = "tbl_SchemeFundAllocation_add";
            public const string TBL_SCHEMEFUNDALLOCATION_UPDATE = "tbl_SchemeFundAllocation_update";
            public const string TBL_SCHEMEFUNDAPPROVAL_GET_SCHEMEID = "tbl_SchemeFundApproval_get_schemeid";
        }

        public struct SchemeFundReleaseDBConstant
        {
            public const string TBL_SCHEMEFUNDRELEASE_GET_ALL = "tbl_SchemeFundRelease_get_all";
            public const string TBL_SCHEMEFUNDRELEASE_GET_ID = "tbl_SchemeFundRelease_get_id";
            public const string TBL_SCHEMEFUNDRELEASE_ADD = "tbl_SchemeFundRelease_add";
            public const string TBL_SCHEMEFUNDRELEASE_UPDATE = "tbl_SchemeFundRelease_update";
            public const string TBL_SCHEMEFUNDALLOCATION_GET_SCHEMEID = "tbl_SchemeFundAllocation_get_schemeid";
            public const string TBL_SCHEMEFUNDALLOCATION_GET_SCHEMEID_FOR_TOTAL = "tbl_SchemeFundAllocation_get_schemeid_for_total";
        }

        public struct SchemeReappropriationDBConstant
        {
            public const string TBL_SCHEMEREAPPROPRIATION_GET_ALL = "tbl_SchemeReappropriation_get_all";
            public const string TBL_SCHEMEREAPPROPRIATION_GET_ID = "tbl_SchemeReappropriation_get_id";
            public const string TBL_SCHEMEREAPPROPRIATION_ADD = "tbl_SchemeReappropriation_add";
            public const string TBL_SCHEMEREAPPROPRIATION_UPDATE = "tbl_SchemeReappropriation_update";
        }

        public struct SchemeExcessDBConstant
        {
            public const string TBL_SCHEMEEXCESS_GET_ALL = "tbl_SchemeExcess_get_all";
            public const string TBL_SCHEMEEXCESS_GET_ID = "tbl_SchemeExcess_get_id";
            public const string TBL_SCHEMEEXCESS_ADD = "tbl_SchemeExcess_add";
            public const string TBL_SCHEMEEXCESS_UPDATE = "tbl_SchemeExcess_update";
        }

        public struct FinancialYearDBConstant
        {
            public const string TBL_FINANCIALYEAR_GET_SCHEMEID = "tbl_FinancialYear_get_schemeid";
            public const string TBL_FINANCIALYEAR_GET_ALL = "tbl_FinancialYear_get_all";
            public const string TBL_FINANCIALYEAR_GET_ID = "tbl_FinancialYear_get_id";
            public const string TBL_FINANCIALYEAR_ADD = "tbl_FinancialYear_add";
            public const string TBL_FINANCIALYEAR_UPDATE = "tbl_FinancialYear_update";
            public const string TBL_FINANCIALYEAR_DELETE = "tbl_FinancialYear_delete";
        }

        public struct InstituteNatureDBConstant
        {
            public const string TBL_INSTITUTENATURE_GET_ALL = "tbl_InstituteNature_get_all";
            public const string TBL_INSTITUTENATURE_GET_ID = "tbl_InstituteNature_get_id";
            public const string TBL_INSTITUTENATURE_ADD = "tbl_InstituteNature_add";
            public const string TBL_INSTITUTENATURE_UPDATE = "tbl_InstituteNature_update";
            public const string TBL_INSTITUTENATURE_DELETE = "tbl_InstituteNature_delete";
        }

        public struct FundTypeDBConstant
        {
            public const string TBL_FUNDTYPE_GET_ALL = "tbl_FundType_get_all";
            public const string TBL_FUNDTYPE_GET_ID = "tbl_FundType_get_id";
            public const string TBL_FUNDTYPE_ADD = "tbl_FundType_add";
            public const string TBL_FUNDTYPE_UPDATE = "tbl_FundType_update";
            public const string TBL_FUNDTYPE_DELETE = "tbl_FundType_delete";
        }

        public struct SchemeDBConstant
        {
            public const string TBL_SCHEME_GET_ALL = "tbl_Scheme_get_all";
            public const string TBL_SCHEME_GET_ID = "tbl_Scheme_get_id";
            public const string TBL_SCHEME_ADD = "tbl_Scheme_add";
            public const string TBL_SCHEME_UPDATE = "tbl_Scheme_update";
            public const string TBL_SCHEME_UPDATE_STATUS = "tbl_Scheme_update_status";
            public const string TBL_SCHEME_UPDATE_ACTIVEINACTIVE = "tbl_Scheme_update_activeinactive";
            public const string TBL_SCHEME_UPDATE_PROMOTE = "tbl_Scheme_update_promote";
        }

        public struct SchemeGSCodeDBConstant
        {
            public const string TBL_SCHEMEGSCODE_GET_SCHEMEID = "tbl_SchemeGSCode_get_schemeId";
        }

        public struct GeoHierarchyDBConstant
        {
            public const string TBL_GEOHIERARCHY_GET_ALL = "tbl_GeoHierarchy_get_all";
            public const string TBL_GEOHIERARCHY_GET_ID = "tbl_GeoHierarchy_get_id";
            public const string TBL_GEOHIERARCHY_ADD = "tbl_GeoHierarchy_add";
            public const string TBL_GEOHIERARCHY_UPDATE = "tbl_GeoHierarchy_update";
            public const string TBL_GEOHIERARCHY_DELETE = "tbl_GeoHierarchy_delete";
            public const string TBL_GEOHIERARCHY_GET_TYPEID = "tbl_GeoHierarchy_get_typeid";
            public const string TBL_GEOHIERARCHY_GET_TYPEID_PARENTID = "tbl_GeoHierarchy_get_typeid_parentid";
            public const string TBL_GEOHIERARCHY_CONSTITUENCY_GET_DISTRICTID = "tbl_GeoHierarchy_constituency_get_districtid";
            public const string KP_TBL_GEOHIERARCHY_ADD = "KP_tbl_GeoHierarchy_add";
            public const string KP_TBL_GEOHIERARCHY_UPDATE = "KP_tbl_GeoHierarchy_update";
        }

        public struct PC1SchemeDBConstant
        {
            public const string TBL_PC1SCHEME_GET_ALL = "tbl_PC1Scheme_get_all";
            public const string TBL_PC1SCHEME_GET_ID = "tbl_PC1Scheme_get_id";
            public const string TBL_PC1SCHEME_ADD = "tbl_PC1Scheme_add";
            public const string TBL_PC1SCHEME_UPDATE_STEP1 = "tbl_PC1Scheme_update_step1";
            public const string TBL_PC1SCHEME_UPDATE_STEP2 = "tbl_PC1Scheme_update_step2";
            public const string TBL_PC1SCHEME_UPDATE_STEP3 = "tbl_PC1Scheme_update_step3";
            public const string TBL_PC1SCHEME_UPDATE_STEP4 = "tbl_PC1Scheme_update_step4";
            public const string TBL_PC1SCHEME_UPDATE_STEP5 = "tbl_PC1Scheme_update_step5";
            public const string TBL_PC1SCHEME_UPDATE_STEP6 = "tbl_PC1Scheme_update_step6";
            public const string TBL_PC1SCHEME_UPDATE_STEP7 = "tbl_PC1Scheme_update_step7";
            public const string TBL_PC1SCHEME_UPDATE_STEP8 = "tbl_PC1Scheme_update_step8";
            public const string TBL_PC1SCHEME_UPDATE_STEP9 = "tbl_PC1Scheme_update_step9";
            public const string TBL_PC1SCHEME_UPDATE_STEP10 = "tbl_PC1Scheme_update_step10";
            public const string TBL_PC1SCHEME_UPDATE_STEP11 = "tbl_PC1Scheme_update_step11";
            public const string TBL_PC1SCHEME_UPDATE_STEP12 = "tbl_PC1Scheme_update_step12";
            public const string TBL_PC1SCHEME_UPDATE_STEP13 = "tbl_PC1Scheme_update_step13";
            public const string TBL_PC1SCHEME_UPDATE_STEP14 = "tbl_PC1Scheme_update_step14";
            public const string TBL_PC1SCHEME_UPDATE_STEP15 = "tbl_PC1Scheme_update_step15";
            public const string TBL_PC1SCHEME_UPDATE_STEP16 = "tbl_PC1Scheme_update_step16";
            public const string TBL_PC1SCHEME_GET_ALL_FUND_APPROVAL = "tbl_PC1Scheme_get_all_fund_approval";
        }

        public struct SponsoringDBConstant
        {
            public const string TBL_SPONSORING_GET_ALL = "tbl_Sponsoring_get_all";
            public const string TBL_SPONSORING_GET_ID = "tbl_Sponsoring_get_id";
            public const string TBL_SPONSORING_ADD = "tbl_Sponsoring_add";
            public const string TBL_SPONSORING_UPDATE = "tbl_Sponsoring_update";
            public const string TBL_SPONSORING_DELETE = "tbl_Sponsoring_delete";
        }

        public struct ExecutionDBConstant
        {
            public const string TBL_EXECUTION_GET_ALL = "tbl_Execution_get_all";
            public const string TBL_EXECUTION_GET_ID = "tbl_Execution_get_id";
            public const string TBL_EXECUTION_ADD = "tbl_Execution_add";
            public const string TBL_EXECUTION_UPDATE = "tbl_Execution_update";
            public const string TBL_EXECUTION_DELETE = "tbl_Execution_delete";
        }

        public struct OperationMaintenanceDBConstant
        {
            public const string TBL_OPERATIONMAINTENANCE_GET_ALL = "tbl_OperationMaintenance_get_all";
            public const string TBL_OPERATIONMAINTENANCE_GET_ID = "tbl_OperationMaintenance_get_id";
            public const string TBL_OPERATIONMAINTENANCE_ADD = "tbl_OperationMaintenance_add";
            public const string TBL_OPERATIONMAINTENANCE_UPDATE = "tbl_OperationMaintenance_update";
            public const string TBL_OPERATIONMAINTENANCE_DELETE = "tbl_OperationMaintenance_delete";
        }

        public struct ConcernedFederalMinistryDBConstant
        {
            public const string TBL_CONCERNEDFEDERALMINISTRY_GET_ALL = "tbl_ConcernedFederalMinistry_get_all";
            public const string TBL_CONCERNEDFEDERALMINISTRY_GET_ID = "tbl_ConcernedFederalMinistry_get_id";
            public const string TBL_CONCERNEDFEDERALMINISTRY_ADD = "tbl_ConcernedFederalMinistry_add";
            public const string TBL_CONCERNEDFEDERALMINISTRY_UPDATE = "tbl_ConcernedFederalMinistry_update";
            public const string TBL_CONCERNEDFEDERALMINISTRY_DELETE = "tbl_ConcernedFederalMinistry_delete";
        }

        public struct GroupDBConstant
        {
            public const string TBL_GROUP_GET_ALL = "tbl_Group_get_all";
            public const string TBL_GROUP_GET_ID = "tbl_Group_get_id";
            public const string TBL_GROUP_ADD = "tbl_Group_add";
            public const string TBL_GROUP_UPDATE = "tbl_Group_update";
            public const string TBL_GROUP_DELETE = "tbl_Group_delete";
            public const string TBL_GROUP_GET_ALL_DETAIL = "tbl_Group_get_all_detail";
        }

        public struct AppConfigDBConstant
        {
            public const string TBL_APPCONFIG_GET_ID = "tbl_AppConfig_get_id";
        }

        public struct SchemeFundProposalDBConstant
        {
            public const string TBL_SCHEMEFUNDPROPOSAL_GET_ALL = "tbl_SchemeFundProposal_get_all";
            public const string TBL_SCHEMEFUNDPROPOSAL_GET_ID = "tbl_SchemeFundProposal_get_id";
            public const string TBL_SCHEMEFUNDPROPOSAL_ADD = "tbl_SchemeFundProposal_add";
            public const string TBL_SCHEMEFUNDPROPOSAL_UPDATE = "tbl_SchemeFundProposal_update";
        }
    }
}
