using System;
using System.Data;
using CORNCommon.Classes;
using CORNDataAccessLayer.Classes;
using CORNDatabaseLayer.Classes;
using System.IO;
 
namespace CORNBusinessLayer.Classes
{
    /// <summary>
    /// Class For Ledger And GL Related Tasks
    /// <example>
    /// <list type="bullet">
    /// <item>
    /// Insert Ledger Data And GL Data
    /// </item>
    /// <term>
    /// Update Ledger Data And GL Data
    /// </term>
    /// <item>
    /// Get Ledger Data And GL Data
    /// </item>
    /// </list>
    /// </example>
    /// </summary>
	public class HealthSchemeController
    {
        #region Constuctor

        /// <summary>
        /// Constructor for HealthSchemeController
        /// </summary>
        public HealthSchemeController()
		{
			//
			// TODO: Add constructor logic here
			//
        }

        #endregion

        #region Public Methods

        #region Select
        public DataTable GetScheme(int p_location_ID, int p_TYPEID, int p_userID)
        {
            IDbConnection mConnection = null;
            try
            {
                mConnection = ProviderFactory.GetConnection(Configuration.ConnectionString, EnumProviders.SQLClient);
                mConnection.Open();
                uspGetScheme mSCheme = new uspGetScheme();
                mSCheme.Connection = mConnection;
                mSCheme.LOCATION_ID = p_location_ID;
                mSCheme.TYPEID = p_TYPEID;
                mSCheme.USER_ID = p_userID;
                DataTable dt = mSCheme.ExecuteTable();
                return dt;
            }
            catch (Exception exp)
            {
                ExceptionPublisher.PublishException(exp);
                return null;
            }
            finally
            {
                if (mConnection != null && mConnection.State == ConnectionState.Open)
                {
                    mConnection.Close();
                }
            }

        }

        public DataTable GetScheme(int p_location_ID, int p_TYPEID,long lngSchemeCode)
        {
            IDbConnection mConnection = null;
            try
            {
                mConnection = ProviderFactory.GetConnection(Configuration.ConnectionString, EnumProviders.SQLClient);
                mConnection.Open();
                uspGetScheme mSCheme = new uspGetScheme();
                mSCheme.Connection = mConnection;
                mSCheme.LOCATION_ID = p_location_ID;
                mSCheme.TYPEID = p_TYPEID;
                mSCheme.lngSchemeCode = lngSchemeCode;
                DataTable dt = mSCheme.ExecuteTable();
                return dt;
            }
            catch (Exception exp)
            {
                ExceptionPublisher.PublishException(exp);
                return null;
            }
            finally
            {
                if (mConnection != null && mConnection.State == ConnectionState.Open)
                {
                    mConnection.Close();
                }
            }

        }

        public DataTable GetScheme(int p_location_ID, int p_TYPEID, long lngSchemeCode, int p_USER_ID)
        {
            IDbConnection mConnection = null;
            try
            {
                mConnection = ProviderFactory.GetConnection(Configuration.ConnectionString, EnumProviders.SQLClient);
                mConnection.Open();
                uspGetScheme mSCheme = new uspGetScheme();
                mSCheme.Connection = mConnection;
                mSCheme.LOCATION_ID = p_location_ID;
                mSCheme.TYPEID = p_TYPEID;
                mSCheme.USER_ID = p_USER_ID;
                mSCheme.lngSchemeCode = lngSchemeCode;
                DataTable dt = mSCheme.ExecuteTable();
                return dt;
            }
            catch (Exception exp)
            {
                ExceptionPublisher.PublishException(exp);
                return null;
            }
            finally
            {
                if (mConnection != null && mConnection.State == ConnectionState.Open)
                {
                    mConnection.Close();
                }
            }

        }

        public DataTable GetSchemePlan(long lngPlanCode, int p_TYPEID, int p_userID)
        {
            IDbConnection mConnection = null;
            try
            {
                mConnection = ProviderFactory.GetConnection(Configuration.ConnectionString, EnumProviders.SQLClient);
                mConnection.Open();
                uspGetSchemePlan mSCheme = new uspGetSchemePlan();
                mSCheme.Connection = mConnection;
                mSCheme.lngPlanCode = lngPlanCode;
                mSCheme.TYPEID = p_TYPEID;
                mSCheme.USER_ID = p_userID;
                DataTable dt = mSCheme.ExecuteTable();
                return dt;
            }
            catch (Exception exp)
            {
                ExceptionPublisher.PublishException(exp);
                return null;
            }
            finally
            {
                if (mConnection != null && mConnection.State == ConnectionState.Open)
                {
                    mConnection.Close();
                }
            }

        }

        public DataTable GetSchemeComments(long lngSchemeCommentsCode,long lngSchemeID,DateTime dtmCommentMonth,DateTime dtmCommentYear,int p_USER_ID, int p_TYPEID)
        {
            IDbConnection mConnection = null;
            try
            {
                mConnection = ProviderFactory.GetConnection(Configuration.ConnectionString, EnumProviders.SQLClient);
                mConnection.Open();
                uspGetSchemeComments mSCheme = new uspGetSchemeComments();
                mSCheme.Connection = mConnection;
                mSCheme.lngSchemeCommentsCode = lngSchemeCommentsCode;
                mSCheme.lngSchemeID = lngSchemeID;
                mSCheme.dtmCommentMonth = dtmCommentMonth;
                mSCheme.dtmCommentYear = dtmCommentYear;
                mSCheme.USER_ID = p_USER_ID;
                mSCheme.TYPEID = p_TYPEID;
                DataTable dt = mSCheme.ExecuteTable();
                return dt;
            }
            catch (Exception exp)
            {
                ExceptionPublisher.PublishException(exp);
                return null;
            }
            finally
            {
                if (mConnection != null && mConnection.State == ConnectionState.Open)
                {
                    mConnection.Close();
                }
            }

        }

        public DataTable GetSchemeStageStatus(int p_TYPEID)
        {
            IDbConnection mConnection = null;
            try
            {
                mConnection = ProviderFactory.GetConnection(Configuration.ConnectionString, EnumProviders.SQLClient);
                mConnection.Open();
                uspGetSchemeStageStatus m_Shift = new uspGetSchemeStageStatus();
                m_Shift.Connection = mConnection;
                m_Shift.TYPEID = p_TYPEID;

                DataTable dt = m_Shift.ExecuteTable();
                return dt;
            }
            catch (Exception exp)
            {
                ExceptionPublisher.PublishException(exp);
                return null;
            }
            finally
            {
                if (mConnection != null && mConnection.State == ConnectionState.Open)
                {
                    mConnection.Close();
                }
            }

        }

        #endregion

        #region Insert, Update, Delete;
        public bool InsertScheme(string strSchemeName,string strSchemeCode, int intInstituteID, int intSubSectorID,int intCategoryID,int intFCAccountHeadID, int intRFCAccountHeadID, int intBankTypeID
            , decimal decYearlyCostPer,decimal decYearlyCostAmount,DateTime dtmSchemeDate,DateTime dtmStartDate,DateTime dtmEndDate,int intUserID,string strRemarks
            ,string strCapitalCode,decimal decRevenueAmount,decimal decCapitalAmount,DateTime dtmFinancialYear,string strGSCode,decimal decLastYearExpense)
        {

            IDbConnection mConnection = null;
            IDbTransaction mTransaction = null;
            try
            {
                mConnection = ProviderFactory.GetConnection(Configuration.ConnectionString, EnumProviders.SQLClient);
                mConnection.Open();
                mTransaction = ProviderFactory.GetTransaction(mConnection);

                uspInsertScheme mScheme = new uspInsertScheme();
                mScheme.Connection = mConnection;
                mScheme.Transaction = mTransaction;
                mScheme.strSchemeName = strSchemeName;
                mScheme.strSchemeCode = strSchemeCode;
                mScheme.intInstituteID = intInstituteID;
                mScheme.intSubSectorID = intSubSectorID;
                mScheme.intCategoryID = intCategoryID;
                mScheme.intFCAccountHeadID = intFCAccountHeadID;
                mScheme.intRFCAccountHeadID = intRFCAccountHeadID;
                mScheme.intBankTypeID = intBankTypeID;
                mScheme.decYearlyCostPer = decYearlyCostPer;
                mScheme.decYearlyCostAmount = decYearlyCostAmount;
                mScheme.dtmSchemeDate = dtmSchemeDate;
                mScheme.dtmStartDate = dtmStartDate;
                mScheme.dtmEndDate = dtmEndDate;
                mScheme.intUserID = intUserID;
                mScheme.IsActive = true;
                mScheme.IsDeleted = false;
                mScheme.strRemarks = strRemarks;
                mScheme.strCapitalCode = strCapitalCode;
                mScheme.decRevenueAmount = decRevenueAmount;
                mScheme.decCapitalAmount = decCapitalAmount;
                mScheme.decLastYearExpense = decLastYearExpense;
                mScheme.ExecuteQuery();

                if (strGSCode != "")
                {
                    uspInsertSchemeGSCode mSchemeGSCode = new uspInsertSchemeGSCode();
                    mSchemeGSCode.Connection = mConnection;
                    mSchemeGSCode.Transaction = mTransaction;
                    mSchemeGSCode.lngSchemeID = mScheme.lngSchemeCode;
                    mSchemeGSCode.dtmFinancialYear = dtmFinancialYear;
                    mSchemeGSCode.strGSCode = strGSCode;
                    mSchemeGSCode.intUserID = intUserID;
                    mSchemeGSCode.ExecuteQuery();
                }
                mTransaction.Commit();
                return true;
            }
            catch (Exception exp)
            {
                ExceptionPublisher.PublishException(exp);
                return false;// exp.Message;
            }
            finally
            {
                if (mConnection != null && mConnection.State == ConnectionState.Open)
                {
                    mConnection.Close();
                }
            }
            return true;
        }

        public bool UpdateScheme(long lngSchemeCode,string strSchemeName,string strSchemeCode, int intInstituteID, int intSubSectorID, int intCategoryID, int intFCAccountHeadID, int intRFCAccountHeadID
            , int intBankTypeID, decimal decYearlyCostPer, decimal decYearlyCostAmount, DateTime dtmSchemeDate, DateTime dtmStartDate, DateTime dtmEndDate, int intUserID, string strRemarks,bool p_IsActive,bool p_IsDeleted
            , string strCapitalCode, decimal decRevenueAmount, decimal decCapitalAmount, DateTime dtmFinancialYear, string strGSCode,decimal decLastYearExpense)
        {

            IDbConnection mConnection = null;
            IDbTransaction mTransaction = null;
            try
            {
                mConnection = ProviderFactory.GetConnection(Configuration.ConnectionString, EnumProviders.SQLClient);
                mConnection.Open();
                mTransaction = ProviderFactory.GetTransaction(mConnection);

                uspUpdateScheme mScheme = new uspUpdateScheme();
                mScheme.Connection = mConnection;
                mScheme.Transaction = mTransaction;
                mScheme.lngSchemeCode = lngSchemeCode;
                mScheme.strSchemeName = strSchemeName;
                mScheme.strSchemeCode = strSchemeCode;
                mScheme.intInstituteID = intInstituteID;
                mScheme.intSubSectorID = intSubSectorID;
                mScheme.intCategoryID = intCategoryID;
                mScheme.intFCAccountHeadID = intFCAccountHeadID;
                mScheme.intRFCAccountHeadID = intRFCAccountHeadID;
                mScheme.intBankTypeID = intBankTypeID;
                mScheme.decYearlyCostPer = decYearlyCostPer;
                mScheme.decYearlyCostAmount = decYearlyCostAmount;
                mScheme.dtmSchemeDate = dtmSchemeDate;
                mScheme.dtmStartDate = dtmStartDate;
                mScheme.dtmEndDate = dtmEndDate;
                mScheme.intUserID = intUserID;
                mScheme.IsActive = p_IsActive;
                mScheme.IsDeleted = p_IsDeleted;
                mScheme.strRemarks = strRemarks;
                mScheme.strCapitalCode = strCapitalCode;
                mScheme.decRevenueAmount = decRevenueAmount;
                mScheme.decCapitalAmount = decCapitalAmount;
                mScheme.decLastYearExpense = decLastYearExpense;
                mScheme.ExecuteQuery();

                if (!string.IsNullOrEmpty(strGSCode))
                {
                    uspInsertSchemeGSCode mSchemeGSCode = new uspInsertSchemeGSCode();
                    mSchemeGSCode.Connection = mConnection;
                    mSchemeGSCode.Transaction = mTransaction;
                    mSchemeGSCode.lngSchemeID = mScheme.lngSchemeCode;
                    mSchemeGSCode.dtmFinancialYear = dtmFinancialYear;
                    mSchemeGSCode.strGSCode = strGSCode;
                    mSchemeGSCode.intUserID = intUserID;
                    mSchemeGSCode.ExecuteQuery();
                }

                mTransaction.Commit();
                return true;
            }
            catch (Exception exp)
            {
                ExceptionPublisher.PublishException(exp);
                return false;// exp.Message;
            }
            finally
            {
                if (mConnection != null && mConnection.State == ConnectionState.Open)
                {
                    mConnection.Close();
                }
            }
            return true;
        }

        public bool InsertSchemePlan(long lngSchemeID,int intFCAccountHeadID, int intProposedByID, int intProposalTypeID,string strRemarks,DateTime dtmProposedDate,int intUserID,DataTable dtPlanDetail1, DataTable dtPlanDetail2)
        {

            IDbConnection mConnection = null;
            IDbTransaction mTransaction = null;
            try
            {
                mConnection = ProviderFactory.GetConnection(Configuration.ConnectionString, EnumProviders.SQLClient);
                mConnection.Open();
                mTransaction = ProviderFactory.GetTransaction(mConnection);

                uspInsertSchemePlanMaster mScheme = new uspInsertSchemePlanMaster();
                mScheme.Connection = mConnection;
                mScheme.Transaction = mTransaction;

                mScheme.lngSchemeID = lngSchemeID;
                mScheme.intFCAccountHeadID = intFCAccountHeadID;
                mScheme.intProposalTypeID = intProposalTypeID;
                mScheme.intProposedByID = intProposedByID;
                mScheme.strRemarks = strRemarks;
                mScheme.dtmProposedDate = dtmProposedDate;
                mScheme.intUserID = intUserID;
                mScheme.ExecuteQuery();

                uspInsertSchemePlanDetail mSchemeDetail1 = new uspInsertSchemePlanDetail();
                mSchemeDetail1.Connection = mConnection;
                mSchemeDetail1.Transaction = mTransaction;

                foreach(DataRow dr in dtPlanDetail1.Rows)
                {
                    mSchemeDetail1.lngPlanID = mScheme.lngPlanCode;
                    mSchemeDetail1.intProposalTypeID = intProposalTypeID;
                    mSchemeDetail1.intFYID = Convert.ToInt32(dr["intFYID"]);
                    mSchemeDetail1.intAccountHeadID = Convert.ToInt32(dr["intAccountHeadID"]);
                    mSchemeDetail1.intCostTypeId = Convert.ToInt32(dr["intCostTypeId"]);
                    mSchemeDetail1.decCostCapital = Convert.ToDecimal(dr["decCostCapital"]);
                    mSchemeDetail1.decCostRevenue = Convert.ToDecimal(dr["decCostRevenue"]);
                    mSchemeDetail1.decCostPC1 = Convert.ToDecimal(dr["decCostPC1"]);
                    mSchemeDetail1.strDescription = dr["strDescription"].ToString();
                    mSchemeDetail1.ExecuteQuery();
                }

                uspInsertSchemePlanDetail mSchemeDetail2 = new uspInsertSchemePlanDetail();
                mSchemeDetail2.Connection = mConnection;
                mSchemeDetail2.Transaction = mTransaction;

                foreach (DataRow dr in dtPlanDetail2.Rows)
                {
                    mSchemeDetail2.lngPlanID = mScheme.lngPlanCode;
                    mSchemeDetail2.intProposalTypeID = intProposalTypeID;
                    mSchemeDetail2.intFYID = Convert.ToInt32(dr["intFYID"]);
                    mSchemeDetail2.intAccountHeadID = Convert.ToInt32(dr["intAccountHeadID"]);
                    mSchemeDetail2.intCostTypeId = Convert.ToInt32(dr["intCostTypeId"]);
                    mSchemeDetail2.decCostCapital = Convert.ToDecimal(dr["decCostCapital"]);
                    mSchemeDetail2.decCostRevenue = Convert.ToDecimal(dr["decCostRevenue"]);
                    mSchemeDetail2.decCostPC1 = Convert.ToDecimal(dr["decCostPC1"]);
                    mSchemeDetail2.strDescription = dr["strDescription"].ToString();
                    mSchemeDetail2.ExecuteQuery();
                }

                mTransaction.Commit();
                return true;
            }
            catch (Exception exp)
            {
                ExceptionPublisher.PublishException(exp);
                return false;// exp.Message;
            }
            finally
            {
                if (mConnection != null && mConnection.State == ConnectionState.Open)
                {
                    mConnection.Close();
                }
            }
            return true;
        }

        public bool UpdateSchemePlan(long lngPlanCode, long lngSchemeID, int intFCAccountHeadID, int intProposedByID, int intProposalTypeID, string strRemarks, DateTime dtmProposedDate, int intUserID,bool IsActive,bool IsDeleted, DataTable dtPlanDetail1, DataTable dtPlanDetail2)
        {

            IDbConnection mConnection = null;
            IDbTransaction mTransaction = null;
            try
            {
                mConnection = ProviderFactory.GetConnection(Configuration.ConnectionString, EnumProviders.SQLClient);
                mConnection.Open();
                mTransaction = ProviderFactory.GetTransaction(mConnection);

                uspUpdateSchemePlanMaster mScheme = new uspUpdateSchemePlanMaster();
                mScheme.Connection = mConnection;
                mScheme.Transaction = mTransaction;

                mScheme.lngPlanCode = lngPlanCode;
                mScheme.lngSchemeID = lngSchemeID;
                mScheme.intFCAccountHeadID = intFCAccountHeadID;
                mScheme.intProposalTypeID = intProposalTypeID;
                mScheme.intProposedByID = intProposedByID;
                mScheme.strRemarks = strRemarks;
                mScheme.dtmProposedDate = dtmProposedDate;
                mScheme.intUserID = intUserID;
                mScheme.IsActive = IsActive;
                mScheme.IsDeleted = IsDeleted;
                mScheme.ExecuteQuery();

                uspInsertSchemePlanDetail mSchemeDetail1 = new uspInsertSchemePlanDetail();
                mSchemeDetail1.Connection = mConnection;
                mSchemeDetail1.Transaction = mTransaction;

                foreach (DataRow dr in dtPlanDetail1.Rows)
                {
                    mSchemeDetail1.lngPlanID = mScheme.lngPlanCode;
                    mSchemeDetail1.intProposalTypeID = intProposalTypeID;
                    mSchemeDetail1.intFYID = Convert.ToInt32(dr["intFYID"]);
                    mSchemeDetail1.intAccountHeadID = Convert.ToInt32(dr["intAccountHeadID"]);
                    mSchemeDetail1.intCostTypeId = Convert.ToInt32(dr["intCostTypeId"]);
                    mSchemeDetail1.decCostCapital = Convert.ToDecimal(dr["decCostCapital"]);
                    mSchemeDetail1.decCostRevenue = Convert.ToDecimal(dr["decCostRevenue"]);
                    mSchemeDetail1.decCostPC1 = Convert.ToDecimal(dr["decCostPC1"]);
                    mSchemeDetail1.strDescription = dr["strDescription"].ToString();
                    mSchemeDetail1.ExecuteQuery();
                }

                uspInsertSchemePlanDetail mSchemeDetail2 = new uspInsertSchemePlanDetail();
                mSchemeDetail2.Connection = mConnection;
                mSchemeDetail2.Transaction = mTransaction;

                foreach (DataRow dr in dtPlanDetail2.Rows)
                {
                    mSchemeDetail2.lngPlanID = mScheme.lngPlanCode;
                    mSchemeDetail2.intProposalTypeID = intProposalTypeID;
                    mSchemeDetail2.intFYID = Convert.ToInt32(dr["intFYID"]);
                    mSchemeDetail2.intAccountHeadID = Convert.ToInt32(dr["intAccountHeadID"]);
                    mSchemeDetail2.intCostTypeId = Convert.ToInt32(dr["intCostTypeId"]);
                    mSchemeDetail2.decCostCapital = Convert.ToDecimal(dr["decCostCapital"]);
                    mSchemeDetail2.decCostRevenue = Convert.ToDecimal(dr["decCostRevenue"]);
                    mSchemeDetail2.decCostPC1 = Convert.ToDecimal(dr["decCostPC1"]);
                    mSchemeDetail2.strDescription = dr["strDescription"].ToString();
                    mSchemeDetail2.ExecuteQuery();
                }

                mTransaction.Commit();
                return true;
            }
            catch (Exception exp)
            {
                ExceptionPublisher.PublishException(exp);
                return false;// exp.Message;
            }
            finally
            {
                if (mConnection != null && mConnection.State == ConnectionState.Open)
                {
                    mConnection.Close();
                }
            }
            return true;
        }

        public bool InsertSchemeComment(long lngSchemeID, DateTime dtmDocumentDate, DateTime dtmCommentMonth, DateTime dtmCommentYear, string strComments, string strHOComments, int intUserID)
        {

            IDbConnection mConnection = null;
            IDbTransaction mTransaction = null;
            try
            {
                mConnection = ProviderFactory.GetConnection(Configuration.ConnectionString, EnumProviders.SQLClient);
                mConnection.Open();
                mTransaction = ProviderFactory.GetTransaction(mConnection);

                uspInsertSchemeComments mScheme = new uspInsertSchemeComments();
                mScheme.Connection = mConnection;
                mScheme.Transaction = mTransaction;
                mScheme.lngSchemeID = lngSchemeID;
                mScheme.dtmDocumentDate = dtmDocumentDate;
                mScheme.dtmCommentMonth = dtmCommentMonth;
                mScheme.dtmCommentYear = dtmCommentYear;
                mScheme.strComments = strComments;
                mScheme.strHOComments = strHOComments;
                mScheme.intUserID = intUserID;
                mScheme.ExecuteQuery();

                mTransaction.Commit();
                return true;
            }
            catch (Exception exp)
            {
                ExceptionPublisher.PublishException(exp);
                return false;// exp.Message;
            }
            finally
            {
                if (mConnection != null && mConnection.State == ConnectionState.Open)
                {
                    mConnection.Close();
                }
            }
            return true;
        }

        public bool InsertSchemeStageStatus(string P_Name, string p_ShortName, int p_USER_ID)
        {

            IDbConnection mConnection = null;
            IDbTransaction mTransaction = null;
            try
            {
                mConnection = ProviderFactory.GetConnection(Configuration.ConnectionString, EnumProviders.SQLClient);
                mConnection.Open();
                mTransaction = ProviderFactory.GetTransaction(mConnection);

                uspInsertSchemeStageStatus mSchemeStages = new uspInsertSchemeStageStatus();

                mSchemeStages.Connection = mConnection;
                mSchemeStages.Transaction = mTransaction;
                mSchemeStages.Name = P_Name;
                mSchemeStages.ShortName = p_ShortName;
                mSchemeStages.USER_ID = p_USER_ID;
                mSchemeStages.ExecuteQuery();
                mTransaction.Commit();
                return true;
            }
            catch (Exception exp)
            {
                ExceptionPublisher.PublishException(exp);
                return false;// exp.Message;
            }
            finally
            {
                if (mConnection != null && mConnection.State == ConnectionState.Open)
                {
                    mConnection.Close();
                }
            }
            return true;
        }

        public bool UpdateSchemeStageStatus(int intSchemeStageStatusCode,string P_Name, string p_ShortName, int p_USER_ID,bool IsActive,bool IsDeleted)
        {

            IDbConnection mConnection = null;
            IDbTransaction mTransaction = null;
            try
            {
                mConnection = ProviderFactory.GetConnection(Configuration.ConnectionString, EnumProviders.SQLClient);
                mConnection.Open();
                mTransaction = ProviderFactory.GetTransaction(mConnection);

                uspUpdateSchemeStageStatus mSchemeStages = new uspUpdateSchemeStageStatus();

                mSchemeStages.Connection = mConnection;
                mSchemeStages.Transaction = mTransaction;
                mSchemeStages.intSchemeStageStatusCode = intSchemeStageStatusCode;
                mSchemeStages.Name = P_Name;
                mSchemeStages.ShortName = p_ShortName;
                mSchemeStages.USER_ID = p_USER_ID;
                mSchemeStages.IsActive = IsActive;
                mSchemeStages.IsDeleted = IsDeleted;
                mSchemeStages.ExecuteQuery();
                mTransaction.Commit();
                return true;
            }
            catch (Exception exp)
            {
                ExceptionPublisher.PublishException(exp);
                return false;// exp.Message;
            }
            finally
            {
                if (mConnection != null && mConnection.State == ConnectionState.Open)
                {
                    mConnection.Close();
                }
            }
            return true;
        }
        #endregion

        public bool CheckDuplicateSchemeStageStatus(int id, string schemeStageStatusName)
        {
            IDbConnection mConnection = null;
            bool nameAlreadyExists = false;

            mConnection = ProviderFactory.GetConnection(Configuration.ConnectionString, EnumProviders.SQLClient);
            mConnection.Open();

            IDbCommand command = ProviderFactory.GetCommand(EnumProviders.SQLClient);
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "uspCheckDuplicateSchemeStageStatus";
            command.Connection = mConnection;

            IDataParameterCollection pparams = command.Parameters;
            IDataParameter parameter;

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@Id";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Int);
            parameter.Value = id;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@SchemeStageStatusName";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.VarChar);
            parameter.Value = schemeStageStatusName;

            pparams.Add(parameter);

            IDbDataAdapter da = ProviderFactory.GetAdapter(EnumProviders.SQLClient);
            da.SelectCommand = command;
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                nameAlreadyExists = Convert.ToBoolean(ds.Tables[0].Rows[0][0]);
            }

            return nameAlreadyExists;
        }

        public string CheckDuplicateScheme(int id, string schemeName, string capitalCode, string revenueCode, string gsCode, DateTime dtmFinancialYear)
        {
            IDbConnection mConnection = null;
            string errorMessage = string.Empty;

            mConnection = ProviderFactory.GetConnection(Configuration.ConnectionString, EnumProviders.SQLClient);
            mConnection.Open();

            IDbCommand command = ProviderFactory.GetCommand(EnumProviders.SQLClient);
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "uspCheckDuplicateScheme";
            command.Connection = mConnection;

            IDataParameterCollection pparams = command.Parameters;
            IDataParameter parameter;

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@Id";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Int);
            parameter.Value = id;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@SchemeName";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.NVarChar);
            parameter.Value = schemeName;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@CapitalCode";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.VarChar);
            parameter.Value = capitalCode;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@RevenueCode";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.NVarChar);
            parameter.Value = revenueCode;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@GSCode";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.NVarChar);
            parameter.Value = gsCode;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@dtmFinancialYear";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.DateTime);
            parameter.Value = dtmFinancialYear;

            pparams.Add(parameter);

            IDbDataAdapter da = ProviderFactory.GetAdapter(EnumProviders.SQLClient);
            da.SelectCommand = command;
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                errorMessage = Convert.ToString(ds.Tables[0].Rows[0][0]);
            }

            return errorMessage;
        }

        public string GetSchemeGSCode(int id, DateTime dtmFinancialYear)
        {
            IDbConnection mConnection = null;
            string gscode = string.Empty;

            mConnection = ProviderFactory.GetConnection(Configuration.ConnectionString, EnumProviders.SQLClient);
            mConnection.Open();

            IDbCommand command = ProviderFactory.GetCommand(EnumProviders.SQLClient);
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "uspGetSchemeGSCode";
            command.Connection = mConnection;

            IDataParameterCollection pparams = command.Parameters;
            IDataParameter parameter;

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@SchemeId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Int);
            parameter.Value = id;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@dtmFinancialYear";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.DateTime);
            parameter.Value = dtmFinancialYear;

            pparams.Add(parameter);

            IDbDataAdapter da = ProviderFactory.GetAdapter(EnumProviders.SQLClient);
            da.SelectCommand = command;
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                gscode = Convert.ToString(ds.Tables[0].Rows[0][0]);
            }

            return gscode;
        }

        public bool PromoteSchemeForNextFY(string schemeIds, int fyStartYear)
        {
            IDbConnection mConnection = null;
            bool status = false;

            mConnection = ProviderFactory.GetConnection(Configuration.ConnectionString, EnumProviders.SQLClient);
            mConnection.Open();

            IDbCommand command = ProviderFactory.GetCommand(EnumProviders.SQLClient);
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "tbl_Promote_Scheme_ADP";
            command.Connection = mConnection;

            IDataParameterCollection pparams = command.Parameters;
            IDataParameter parameter;

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@SchemeIds";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.NVarChar);
            parameter.Value = schemeIds;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@StartYear";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Int);
            parameter.Value = fyStartYear;

            pparams.Add(parameter);

            command.ExecuteNonQuery();

            status = true;

            return status;
        }

        #endregion
    }
}