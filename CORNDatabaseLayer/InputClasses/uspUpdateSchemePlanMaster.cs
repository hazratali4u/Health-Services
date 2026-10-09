using System;
using System.Data;
using CORNCommon.Classes;
using CORNDataAccessLayer.Classes;
namespace CORNDatabaseLayer.Classes
{
	public class uspUpdateSchemePlanMaster
	{
		#region Private Members
		private string sp_Name = "uspUpdateSchemePlanMaster" ;
		private IDbConnection m_connection;
		private IDbTransaction m_transaction;
		private int m_intFCAccountHeadID;
		private int m_intProposedByID;
		private int m_intProposalTypeID;
		private int m_intUserID;
        private DateTime m_dtmProposedDate;
        private bool m_IsActive;
		private bool m_IsDeleted;
		private long m_lngPlanCode;
		private long m_lngSchemeID;
		private string m_strRemarks;
		#endregion
		#region Public Properties
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
		public int intProposedByID
		{
			set
			{
				m_intProposedByID = value ;
			}
			get
			{
				return m_intProposedByID;
			}
		}
		public int intProposalTypeID
		{
			set
			{
				m_intProposalTypeID = value ;
			}
			get
			{
				return m_intProposalTypeID;
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
        public DateTime dtmProposedDate
        {
            set
            {
                m_dtmProposedDate = value;
            }
            get
            {
                return m_dtmProposedDate;
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
		public long lngPlanCode
		{
			set
			{
				m_lngPlanCode = value ;
			}
			get
			{
				return m_lngPlanCode;
			}
		}
		public long lngSchemeID
		{
			set
			{
				m_lngSchemeID = value ;
			}
			get
			{
				return m_lngSchemeID;
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
		public uspUpdateSchemePlanMaster()
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
				m_intFCAccountHeadID= Convert.ToInt32(dr["intFCAccountHeadID"]);
				m_intProposedByID= Convert.ToInt32(dr["intProposedByID"]);
				m_intProposalTypeID= Convert.ToInt32(dr["intProposalTypeID"]);
				m_intUserID= Convert.ToInt32(dr["intUserID"]);
				m_IsActive=Convert.ToBoolean(dr["IsActive"]);
				m_IsDeleted=Convert.ToBoolean(dr["IsDeleted"]);
				m_lngPlanCode=Convert.ToInt64(dr["lngPlanCode"]);
				m_lngSchemeID=Convert.ToInt64(dr["lngSchemeID"]);
				m_strRemarks= Convert.ToString(dr["strRemarks"]);
			}
		}
		public void GetParameterCollection(ref IDbCommand cmd)
		{
			IDataParameterCollection pparams = cmd.Parameters;
			IDataParameter parameter ;
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
			parameter.ParameterName = "@intProposedByID" ; 
			parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Int);
			if(m_intProposedByID==Constants.IntNullValue)
			{
				parameter.Value = DBNull.Value;
			}
			else
			{
				parameter.Value = m_intProposedByID;
			}
			pparams.Add(parameter);


			parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
			parameter.ParameterName = "@intProposalTypeID" ; 
			parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Int);
			if(m_intProposalTypeID==Constants.IntNullValue)
			{
				parameter.Value = DBNull.Value;
			}
			else
			{
				parameter.Value = m_intProposalTypeID;
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
            parameter.ParameterName = "@dtmProposedDate";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.DateTime);
            if (m_dtmProposedDate == Constants.DateNullValue)
            {
                parameter.Value = DBNull.Value;
            }
            else
            {
                parameter.Value = m_dtmProposedDate;
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
			parameter.ParameterName = "@lngPlanCode" ; 
			parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.BigInt);
			if(m_lngPlanCode==Constants.LongNullValue)
			{
				parameter.Value = DBNull.Value;
			}
			else
			{
				parameter.Value = m_lngPlanCode;
			}
			pparams.Add(parameter);


			parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
			parameter.ParameterName = "@lngSchemeID" ; 
			parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.BigInt);
			if(m_lngSchemeID==Constants.LongNullValue)
			{
				parameter.Value = DBNull.Value;
			}
			else
			{
				parameter.Value = m_lngSchemeID;
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

		}
		#endregion
	}
}
