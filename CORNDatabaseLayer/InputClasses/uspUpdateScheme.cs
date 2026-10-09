using System;
using System.Data;
using CORNCommon.Classes;
using CORNDataAccessLayer.Classes;
namespace CORNDatabaseLayer.Classes
{
	public class uspUpdateScheme
	{
		#region Private Members
		private string sp_Name = "uspUpdateScheme" ;
		private IDbConnection m_connection;
		private IDbTransaction m_transaction;
		private int m_intInstituteID;
		private int m_intSubSectorID;
		private int m_intCategoryID;
		private int m_intFCAccountHeadID;
        private int m_intRFCAccountHeadID;
        private int m_intBankTypeID;
		private int m_intUserID;
		private DateTime m_dtmSchemeDate;
		private DateTime m_dtmStartDate;
		private DateTime m_dtmEndDate;
		private bool m_IsActive;
		private bool m_IsDeleted;
		private decimal m_decYearlyCostPer;
		private decimal m_decYearlyCostAmount;
        private decimal m_decRevenueAmount;
        private decimal m_decCapitalAmount;
        private decimal m_decLastYearExpense;
        private long m_lngSchemeCode;
		private string m_strSchemeName;
        private string m_strSchemeCode;
        private string m_strRemarks;
        private string m_strCapitalCode;
        #endregion
        #region Public Properties
        public int intInstituteID
		{
			set
			{
				m_intInstituteID = value ;
			}
			get
			{
				return m_intInstituteID;
			}
		}
		public int intSubSectorID
		{
			set
			{
				m_intSubSectorID = value ;
			}
			get
			{
				return m_intSubSectorID;
			}
		}
		public int intCategoryID
		{
			set
			{
				m_intCategoryID = value ;
			}
			get
			{
				return m_intCategoryID;
			}
		}
		public int intFCAccountHeadID
		{
			set
			{
				m_intFCAccountHeadID = value ;
			}
			get
			{
				return m_intFCAccountHeadID;
			}
		}
        public int intRFCAccountHeadID
        {
            set
            {
                m_intRFCAccountHeadID = value;
            }
            get
            {
                return m_intRFCAccountHeadID;
            }
        }
        public int intBankTypeID
		{
			set
			{
				m_intBankTypeID = value ;
			}
			get
			{
				return m_intBankTypeID;
			}
		}
		public int intUserID
		{
			set
			{
				m_intUserID = value ;
			}
			get
			{
				return m_intUserID;
			}
		}
		public DateTime dtmSchemeDate
		{
			set
			{
				m_dtmSchemeDate = value ;
			}
			get
			{
				return m_dtmSchemeDate;
			}
		}
		public DateTime dtmStartDate
		{
			set
			{
				m_dtmStartDate = value ;
			}
			get
			{
				return m_dtmStartDate;
			}
		}
		public DateTime dtmEndDate
		{
			set
			{
				m_dtmEndDate = value ;
			}
			get
			{
				return m_dtmEndDate;
			}
		}
		public bool IsActive
		{
			set
			{
				m_IsActive = value ;
			}
			get
			{
				return m_IsActive;
			}
		}
		public bool IsDeleted
		{
			set
			{
				m_IsDeleted = value ;
			}
			get
			{
				return m_IsDeleted;
			}
		}
		public decimal decYearlyCostPer
		{
			set
			{
				m_decYearlyCostPer = value ;
			}
			get
			{
				return m_decYearlyCostPer;
			}
		}
		public decimal decYearlyCostAmount
		{
			set
			{
				m_decYearlyCostAmount = value ;
			}
			get
			{
				return m_decYearlyCostAmount;
			}
		}
        public decimal decRevenueAmount
        {
            set { m_decRevenueAmount = value; }
            get { return m_decRevenueAmount; }
        }
        public decimal decCapitalAmount
        {
            set { m_decCapitalAmount = value; }
            get { return m_decCapitalAmount; }
        }
        public decimal decLastYearExpense
        {
            set { m_decLastYearExpense = value; }
            get { return m_decLastYearExpense; }
        }
        public long lngSchemeCode
		{
			set
			{
				m_lngSchemeCode = value ;
			}
			get
			{
				return m_lngSchemeCode;
			}
		}
		public string strSchemeName
		{
			set
			{
				m_strSchemeName = value ;
			}
			get
			{
				return m_strSchemeName;
			}
		}
        public string strSchemeCode
        {
            set
            {
                m_strSchemeCode = value;
            }
            get
            {
                return m_strSchemeCode;
            }
        }
        public string strRemarks
		{
			set
			{
				m_strRemarks = value ;
			}
			get
			{
				return m_strRemarks;
			}
		}
        public string strCapitalCode
        {
            set { m_strCapitalCode = value; }
            get { return m_strCapitalCode; }
        }
        public IDbConnection  Connection
		{
			set
			{
				m_connection = value;
			}
			get
			{
				return m_connection;
			}
		}
		public IDbTransaction  Transaction
		{
			set
			{
				m_transaction = value;
			}
			get
			{
				return m_transaction;
			}
		}
		#endregion
		#region Constructor
		public uspUpdateScheme()
		{
		}
		#endregion
		#region public Methods
		public bool  ExecuteQuery()
		{
			try
			{
			    IDbCommand cmd = ProviderFactory.GetCommand(EnumProviders.SQLClient);
				cmd.CommandType =  CommandType.StoredProcedure;
				cmd.CommandText = sp_Name;
				cmd.Connection =   m_connection;
				if(m_transaction!=null)
				{
					cmd.Transaction = m_transaction;
				}
				GetParameterCollection(ref cmd);
				cmd.ExecuteNonQuery();
				return true;
			}
			catch(Exception e)
			{
				throw e;
			}
			finally
			{
			}
		}
		public IDataReader ExecuteReader()
		{
			try
			{
				IDbCommand command = ProviderFactory.GetCommand(EnumProviders.SQLClient);
				command.CommandType = CommandType.StoredProcedure;
				command.CommandText = sp_Name;
				command.Connection = m_connection;
				if(m_transaction!=null)
				{
					command.Transaction = m_transaction;
				}
				GetParameterCollection(ref command);
				IDataReader dr = command.ExecuteReader();
				return dr;
			}
			catch(Exception exp)
			{
				throw exp;
			}
			finally
			{
			}
		}
		public DataTable ExecuteTable()
		{
			try
			{
				IDbCommand command = ProviderFactory.GetCommand(EnumProviders.SQLClient);
				command.CommandType = CommandType.StoredProcedure;
				command.CommandText = sp_Name;
				command.Connection = m_connection;
				if(m_transaction!=null)
				{
					command.Transaction = m_transaction;
				}
				GetParameterCollection(ref command);
				IDbDataAdapter da = ProviderFactory.GetAdapter(EnumProviders.SQLClient);
				da.SelectCommand = command;
				DataSet ds = new DataSet();
				da.Fill(ds);
				return ds.Tables[0];
			}
			catch(Exception exp)
			{
				throw exp;
			}
			finally
			{
			}
		}
		public string ExecuteScalar()
		{
			try
			{
				IDbCommand command = ProviderFactory.GetCommand(EnumProviders.SQLClient);
				command.CommandType = CommandType.StoredProcedure;
				command.CommandText = sp_Name;
				command.Connection = m_connection;
				if(m_transaction!=null)
				{
					command.Transaction = m_transaction;
				}
				GetParameterCollection(ref command);
				object o;
				o = command.ExecuteScalar();


				return o.ToString();
			}
			catch(Exception exp)
			{
				throw exp;
			}
			finally
			{
			}
		}
		public void FirstReader(IDataReader dr)
		{
			if(dr.Read())
			{
				m_intInstituteID= Convert.ToInt32(dr["intInstituteID"]);
				m_intSubSectorID= Convert.ToInt32(dr["intSubSectorID"]);
				m_intCategoryID= Convert.ToInt32(dr["intCategoryID"]);
				m_intFCAccountHeadID= Convert.ToInt32(dr["intFCAccountHeadID"]);
                m_intRFCAccountHeadID = Convert.ToInt32(dr["intRFCAccountHeadID"]);
                m_intBankTypeID = Convert.ToInt32(dr["intBankTypeID"]);
				m_intUserID= Convert.ToInt32(dr["intUserID"]);
				m_dtmSchemeDate= Convert.ToDateTime(dr["dtmSchemeDate"]);
				m_dtmStartDate= Convert.ToDateTime(dr["dtmStartDate"]);
				m_dtmEndDate= Convert.ToDateTime(dr["dtmEndDate"]);
				m_IsActive=Convert.ToBoolean(dr["IsActive"]);
				m_IsDeleted=Convert.ToBoolean(dr["IsDeleted"]);
				m_decYearlyCostPer= Convert.ToDecimal(dr["decYearlyCostPer"]);
				m_decYearlyCostAmount= Convert.ToDecimal(dr["decYearlyCostAmount"]);
				m_lngSchemeCode=Convert.ToInt64(dr["lngSchemeCode"]);
				m_strSchemeName= Convert.ToString(dr["strSchemeName"]);
				m_strRemarks= Convert.ToString(dr["strRemarks"]);
			}
		}
		public void GetParameterCollection(ref IDbCommand cmd)
		{
			IDataParameterCollection pparams = cmd.Parameters;
			IDataParameter parameter ;
			parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
			parameter.ParameterName = "@intInstituteID" ; 
			parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Int);
			if(m_intInstituteID==Constants.IntNullValue)
			{
				parameter.Value = DBNull.Value;
			}
			else
			{
				parameter.Value = m_intInstituteID;
			}
			pparams.Add(parameter);


			parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
			parameter.ParameterName = "@intSubSectorID" ; 
			parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Int);
			if(m_intSubSectorID==Constants.IntNullValue)
			{
				parameter.Value = DBNull.Value;
			}
			else
			{
				parameter.Value = m_intSubSectorID;
			}
			pparams.Add(parameter);


			parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
			parameter.ParameterName = "@intCategoryID" ; 
			parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Int);
			if(m_intCategoryID==Constants.IntNullValue)
			{
				parameter.Value = DBNull.Value;
			}
			else
			{
				parameter.Value = m_intCategoryID;
			}
			pparams.Add(parameter);


			parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
			parameter.ParameterName = "@intFCAccountHeadID" ; 
			parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Int);
			if(m_intFCAccountHeadID==Constants.IntNullValue)
			{
				parameter.Value = DBNull.Value;
			}
			else
			{
				parameter.Value = m_intFCAccountHeadID;
			}
			pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@intRFCAccountHeadID";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Int);
            if (m_intRFCAccountHeadID == Constants.IntNullValue)
            {
                parameter.Value = DBNull.Value;
            }
            else
            {
                parameter.Value = m_intRFCAccountHeadID;
            }
            pparams.Add(parameter);


            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
			parameter.ParameterName = "@intBankTypeID" ; 
			parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Int);
			if(m_intBankTypeID==Constants.IntNullValue)
			{
				parameter.Value = DBNull.Value;
			}
			else
			{
				parameter.Value = m_intBankTypeID;
			}
			pparams.Add(parameter);


			parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
			parameter.ParameterName = "@intUserID" ; 
			parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Int);
			if(m_intUserID==Constants.IntNullValue)
			{
				parameter.Value = DBNull.Value;
			}
			else
			{
				parameter.Value = m_intUserID;
			}
			pparams.Add(parameter);


			parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
			parameter.ParameterName = "@dtmSchemeDate" ; 
			parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.DateTime);
			if(m_dtmSchemeDate==Constants.DateNullValue)
			{
				parameter.Value = DBNull.Value;
			}
			else
			{
				parameter.Value = m_dtmSchemeDate;
			}
			pparams.Add(parameter);


			parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
			parameter.ParameterName = "@dtmStartDate" ; 
			parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.DateTime);
			if(m_dtmStartDate==Constants.DateNullValue)
			{
				parameter.Value = DBNull.Value;
			}
			else
			{
				parameter.Value = m_dtmStartDate;
			}
			pparams.Add(parameter);


			parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
			parameter.ParameterName = "@dtmEndDate" ; 
			parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.DateTime);
			if(m_dtmEndDate==Constants.DateNullValue)
			{
				parameter.Value = DBNull.Value;
			}
			else
			{
				parameter.Value = m_dtmEndDate;
			}
			pparams.Add(parameter);


			parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
			parameter.ParameterName = "@IsActive" ; 
			parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Bit);
				parameter.Value = m_IsActive;
			pparams.Add(parameter);


			parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
			parameter.ParameterName = "@IsDeleted" ; 
			parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Bit);
				parameter.Value = m_IsDeleted;
			pparams.Add(parameter);


			parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
			parameter.ParameterName = "@decYearlyCostPer" ; 
			parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Decimal);
			if(m_decYearlyCostPer==Constants.DecimalNullValue)
			{
				parameter.Value = DBNull.Value;
			}
			else
			{
				parameter.Value = m_decYearlyCostPer;
			}
			pparams.Add(parameter);


			parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
			parameter.ParameterName = "@decYearlyCostAmount" ; 
			parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Decimal);
			if(m_decYearlyCostAmount==Constants.DecimalNullValue)
			{
				parameter.Value = DBNull.Value;
			}
			else
			{
				parameter.Value = m_decYearlyCostAmount;
			}
			pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@decRevenueAmount";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Decimal);
            if (m_decRevenueAmount == Constants.DecimalNullValue)
            {
                parameter.Value = DBNull.Value;
            }
            else
            {
                parameter.Value = m_decRevenueAmount;
            }
            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@decCapitalAmount";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Decimal);
            if (m_decCapitalAmount == Constants.DecimalNullValue)
            {
                parameter.Value = DBNull.Value;
            }
            else
            {
                parameter.Value = m_decCapitalAmount;
            }
            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@decLastYearExpense";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Decimal);
            if (m_decLastYearExpense == Constants.DecimalNullValue)
            {
                parameter.Value = DBNull.Value;
            }
            else
            {
                parameter.Value = m_decLastYearExpense;
            }
            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
			parameter.ParameterName = "@lngSchemeCode" ; 
			parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.BigInt);
			if(m_lngSchemeCode==Constants.LongNullValue)
			{
				parameter.Value = DBNull.Value;
			}
			else
			{
				parameter.Value = m_lngSchemeCode;
			}
			pparams.Add(parameter);


			parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
			parameter.ParameterName = "@strSchemeName" ; 
			parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.NVarChar);
			if(m_strSchemeName== null)
			{
				parameter.Value = DBNull.Value;
			}
			else
			{
				parameter.Value = m_strSchemeName;
			}
			pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@strSchemeCode";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.NVarChar);
            if (m_strSchemeCode == null)
            {
                parameter.Value = DBNull.Value;
            }
            else
            {
                parameter.Value = m_strSchemeCode;
            }
            pparams.Add(parameter);


            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
			parameter.ParameterName = "@strRemarks" ; 
			parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.NVarChar);
			if(m_strRemarks== null)
			{
				parameter.Value = DBNull.Value;
			}
			else
			{
				parameter.Value = m_strRemarks;
			}
			pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@strCapitalCode";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.VarChar);
            if (m_strCapitalCode == null)
            {
                parameter.Value = DBNull.Value;
            }
            else
            {
                parameter.Value = m_strCapitalCode;
            }
            pparams.Add(parameter);

        }
		#endregion
	}
}