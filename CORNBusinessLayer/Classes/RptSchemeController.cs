using System;
using System.Data;
using CORNCommon.Classes;
using CORNDataAccessLayer.Classes;
using CORNDatabaseLayer.Classes;

namespace CORNBusinessLayer.Classes
{
    /// <summary>
    /// Class For Fetching Data Of Account Reports
    /// </summary>
    public class RptSchemeController
    {
        #region Constructor

        /// <summary>
        /// Constructor for RptSchemeController
        /// </summary>
        public RptSchemeController()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        #endregion

        #region Public Methods

        public DataTable GetSchemTestReport(DateTime dtmSchemeDate)
        {
            IDbConnection mConnection = null;
            try
            {
                mConnection = ProviderFactory.GetConnection(Configuration.ConnectionString, EnumProviders.SQLClient);
                mConnection.Open();

                uspGetSchemTestReport mSchemTest = new uspGetSchemTestReport();
                mSchemTest.Connection = mConnection;

                mSchemTest.dtmSchemeDate = dtmSchemeDate;
                DataTable dtSchemeTest = mSchemTest.ExecuteTable();
                return dtSchemeTest;
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
    }
}