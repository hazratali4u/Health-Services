using CORNCommon;
using CORNCommon.Classes;
using CORNDataAccessLayer;
using CORNDataAccessLayer.Classes;
using CORNDataAccessLayer.Request;
using CORNDataAccessLayer.Response;
using System.Data;
using System.Linq;

namespace CORNDatabaseLayer
{
    public class SchemeFundProposalDataAccess
    {
        public SchemeFundProposalResponse SchemeFundProposalGetAll(SchemeFundProposalRequest request)
        {
            SchemeFundProposalResponse response = new SchemeFundProposalResponse();
            IDbConnection mConnection = null;

            mConnection = ProviderFactory.GetConnection(Configuration.ConnectionString, EnumProviders.SQLClient);
            mConnection.Open();

            IDbCommand command = ProviderFactory.GetCommand(EnumProviders.SQLClient);
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = DBConstants.SchemeFundProposalDBConstant.TBL_SCHEMEFUNDPROPOSAL_GET_ALL;
            command.Connection = mConnection;

            IDataParameterCollection pparams = command.Parameters;
            IDataParameter parameter;

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@UserId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.BigInt);
            parameter.Value = request.UserId;

            pparams.Add(parameter);

            IDbDataAdapter da = ProviderFactory.GetAdapter(EnumProviders.SQLClient);
            da.SelectCommand = command;
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables != null && ds.Tables.Count > 0)
            {
                response.SchemeFundProposalList = ds.Tables[0].ToList<SchemeFundProposal>();
            }

            return response;
        }
        public SchemeFundProposalResponse SchemeFundProposalGetId(SchemeFundProposalRequest request)
        {
            SchemeFundProposalResponse response = new SchemeFundProposalResponse();
            IDbConnection mConnection = null;

            mConnection = ProviderFactory.GetConnection(Configuration.ConnectionString, EnumProviders.SQLClient);
            mConnection.Open();

            IDbCommand command = ProviderFactory.GetCommand(EnumProviders.SQLClient);
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = DBConstants.SchemeFundProposalDBConstant.TBL_SCHEMEFUNDPROPOSAL_GET_ID;
            command.Connection = mConnection;

            IDataParameterCollection pparams = command.Parameters;
            IDataParameter parameter;

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@Id";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.BigInt);
            parameter.Value = request.Id;

            pparams.Add(parameter);

            IDbDataAdapter da = ProviderFactory.GetAdapter(EnumProviders.SQLClient);
            da.SelectCommand = command;
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables != null && ds.Tables.Count > 0)
            {
                response.SchemeFundProposalObject = ds.Tables[0].ToObject<SchemeFundProposal>();
                response.SchemeFundProposalObject.SchemeFundProposalDetailList = ds.Tables[1].ToList<SchemeFundProposalDetail>();
            }

            return response;
        }
        public SchemeFundProposalResponse SchemeFundProposalAdd(SchemeFundProposalRequest request)
        {
            SchemeFundProposalResponse response = new SchemeFundProposalResponse();
            IDbConnection mConnection = null;

            mConnection = ProviderFactory.GetConnection(Configuration.ConnectionString, EnumProviders.SQLClient);
            mConnection.Open();

            IDbCommand command = ProviderFactory.GetCommand(EnumProviders.SQLClient);
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = DBConstants.SchemeFundProposalDBConstant.TBL_SCHEMEFUNDPROPOSAL_ADD;
            command.Connection = mConnection;

            IDataParameterCollection pparams = command.Parameters;
            IDataParameter parameter;

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@SchemeFundProposalXML";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Xml);
            parameter.Value = request.SchemeFundProposalObject.ToXML();

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@UserId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.BigInt);
            parameter.Value = request.UserId;

            pparams.Add(parameter);

            command.ExecuteNonQuery();

            response.Status = true;

            return response;
        }
        public SchemeFundProposalResponse SchemeFundProposalUpdate(SchemeFundProposalRequest request)
        {
            SchemeFundProposalResponse response = new SchemeFundProposalResponse();
            IDbConnection mConnection = null;

            mConnection = ProviderFactory.GetConnection(Configuration.ConnectionString, EnumProviders.SQLClient);
            mConnection.Open();

            IDbCommand command = ProviderFactory.GetCommand(EnumProviders.SQLClient);
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = DBConstants.SchemeFundProposalDBConstant.TBL_SCHEMEFUNDPROPOSAL_UPDATE;
            command.Connection = mConnection;

            IDataParameterCollection pparams = command.Parameters;
            IDataParameter parameter;

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@SchemeFundProposalXML";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Xml);
            parameter.Value = request.SchemeFundProposalObject.ToXML();

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@UserId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.BigInt);
            parameter.Value = request.UserId;

            pparams.Add(parameter);

            command.ExecuteNonQuery();

            response.Status = true;

            return response;
        }
    }
}
