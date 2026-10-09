using System;
using System.Data;
using CORNDataAccessLayer.Classes;
using CORNCommon.Classes;


namespace CORNDatabaseLayer.Classes
{
	public class uspInsertSchemePlanDetail
	{
		#region Private Members
		private string sp_Name = "uspInsertSchemePlanDetail" ;
		private IDbConnection m_connection;
		private IDbTransaction m_transaction;
		private int m_intProposalTypeID;
		private int m_intFYID;
		private int m_intAccountHeadID;
        private int m_intCostTypeId;
        private decimal m_decCostCapital;
		private decimal m_decCostRevenue;
		private decimal m_decCostPC1;
		private long m_lngPlanID;
		private string m_strDescription;
		#endregion
		#region Public Properties
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
		public int intFYID
		{
			set
			{
				m_intFYID = value ;
			}
			get
			{
				return m_intFYID;
			}
		}
		public int intAccountHeadID
		{
			set
			{
				m_intAccountHeadID = value ;
			}
			get
			{
				return m_intAccountHeadID;
			}
		}
        public int intCostTypeId
        {
            set
            {
                m_intCostTypeId = value;
            }
            get
            {
                return m_intCostTypeId;
            }
        }
        public decimal decCostCapital
		{
			set
			{
				m_decCostCapital = value ;
			}
			get
			{
				return m_decCostCapital;
			}
		}
		public decimal decCostRevenue
		{
			set
			{
				m_decCostRevenue = value ;
			}
			get
			{
				return m_decCostRevenue;
			}
		}
		public decimal decCostPC1
		{
			set
			{
				m_decCostPC1 = value ;
			}
			get
			{
				return m_decCostPC1;
			}
		}
		public long lngPlanID
		{
			set
			{
				m_lngPlanID = value ;
			}
			get
			{
				return m_lngPlanID;
			}
		}
		public string strDescription
		{
			set
			{
				m_strDescription = value ;
			}
			get
			{
				return m_strDescription;
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
		public uspInsertSchemePlanDetail()
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
				m_intProposalTypeID= Convert.ToInt32(dr["intProposalTypeID"]);
				m_intFYID= Convert.ToInt32(dr["intFYID"]);
				m_intAccountHeadID= Convert.ToInt32(dr["intAccountHeadID"]);
				m_decCostCapital= Convert.ToDecimal(dr["decCostCapital"]);
				m_decCostRevenue= Convert.ToDecimal(dr["decCostRevenue"]);
				m_decCostPC1= Convert.ToDecimal(dr["decCostPC1"]);
				m_lngPlanID=Convert.ToInt64(dr["lngPlanID"]);
				m_strDescription= Convert.ToString(dr["strDescription"]);
			}
		}
		public void GetParameterCollection(ref IDbCommand cmd)
		{
			IDataParameterCollection pparams = cmd.Parameters;
			IDataParameter parameter ;
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
			parameter.ParameterName = "@intFYID" ; 
			parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Int);
			if(m_intFYID==Constants.IntNullValue)
			{
				parameter.Value = DBNull.Value;
			}
			else
			{
				parameter.Value = m_intFYID;
			}
			pparams.Add(parameter);


			parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
			parameter.ParameterName = "@intAccountHeadID" ; 
			parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Int);
			if(m_intAccountHeadID==Constants.IntNullValue)
			{
				parameter.Value = DBNull.Value;
			}
			else
			{
				parameter.Value = m_intAccountHeadID;
			}
			pparams.Add(parameter);


            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@intCostTypeId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Int);
            if (m_intCostTypeId == Constants.IntNullValue)
            {
                parameter.Value = DBNull.Value;
            }
            else
            {
                parameter.Value = m_intCostTypeId;
            }
            pparams.Add(parameter);


            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
			parameter.ParameterName = "@decCostCapital" ; 
			parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Decimal);
			if(m_decCostCapital==Constants.DecimalNullValue)
			{
				parameter.Value = DBNull.Value;
			}
			else
			{
				parameter.Value = m_decCostCapital;
			}
			pparams.Add(parameter);


			parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
			parameter.ParameterName = "@decCostRevenue" ; 
			parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Decimal);
			if(m_decCostRevenue==Constants.DecimalNullValue)
			{
				parameter.Value = DBNull.Value;
			}
			else
			{
				parameter.Value = m_decCostRevenue;
			}
			pparams.Add(parameter);


			parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
			parameter.ParameterName = "@decCostPC1" ; 
			parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Decimal);
			if(m_decCostPC1==Constants.DecimalNullValue)
			{
				parameter.Value = DBNull.Value;
			}
			else
			{
				parameter.Value = m_decCostPC1;
			}
			pparams.Add(parameter);


			parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
			parameter.ParameterName = "@lngPlanID" ; 
			parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.BigInt);
			if(m_lngPlanID==Constants.LongNullValue)
			{
				parameter.Value = DBNull.Value;
			}
			else
			{
				parameter.Value = m_lngPlanID;
			}
			pparams.Add(parameter);

            
			parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
			parameter.ParameterName = "@strDescription" ; 
			parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.NVarChar);
			if(m_strDescription== null)
			{
				parameter.Value = DBNull.Value;
			}
			else
			{
				parameter.Value = m_strDescription;
			}
			pparams.Add(parameter);

            
		}
		#endregion
	}
}
