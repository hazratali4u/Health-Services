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
    public class PC1SchemeFundApprovalDataAccess
    {
        public SchemeFundApprovalResponse SchemeFundApprovalGetAll(SchemeFundApprovalRequest request)
        {
            SchemeFundApprovalResponse response = new SchemeFundApprovalResponse();
            IDbConnection mConnection = null;

            mConnection = ProviderFactory.GetConnection(Configuration.ConnectionString, EnumProviders.SQLClient);
            mConnection.Open();

            IDbCommand command = ProviderFactory.GetCommand(EnumProviders.SQLClient);
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = DBConstants.PC1SchemeFundApprovalDBConstant.TBL_PC1SCHEMEFUNDAPPROVAL_GET_ALL;
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
                response.SchemeFundApprovalList = ds.Tables[0].ToList<SchemeFundApproval>();
            }

            return response;
        }
        public SchemeFundApprovalResponse SchemeFundApprovalGetId(SchemeFundApprovalRequest request)
        {
            SchemeFundApprovalResponse response = new SchemeFundApprovalResponse();
            IDbConnection mConnection = null;

            mConnection = ProviderFactory.GetConnection(Configuration.ConnectionString, EnumProviders.SQLClient);
            mConnection.Open();

            IDbCommand command = ProviderFactory.GetCommand(EnumProviders.SQLClient);
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = DBConstants.PC1SchemeFundApprovalDBConstant.TBL_PC1SCHEMEFUNDAPPROVAL_GET_ID;
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
                response.SchemeFundApprovalObject = ds.Tables[0].ToObject<SchemeFundApproval>();
                response.SchemeFundApprovalObject.SchemeFundApprovalDetailList = ds.Tables[1].ToList<SchemeFundApprovalDetail>();
            }

            return response;
        }
        public SchemeFundApprovalResponse SchemeFundApprovalAdd(SchemeFundApprovalRequest request)
        {
            SchemeFundApprovalResponse response = new SchemeFundApprovalResponse();
            IDbConnection mConnection = null;

            mConnection = ProviderFactory.GetConnection(Configuration.ConnectionString, EnumProviders.SQLClient);
            mConnection.Open();

            IDbCommand command = ProviderFactory.GetCommand(EnumProviders.SQLClient);
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = DBConstants.PC1SchemeFundApprovalDBConstant.TBL_PC1SCHEMEFUNDAPPROVAL_ADD;
            command.Connection = mConnection;

            IDataParameterCollection pparams = command.Parameters;
            IDataParameter parameter;

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@SchemeFundApprovalXML";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Xml);
            parameter.Value = request.SchemeFundApprovalObject.ToXML();

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
        public SchemeFundApprovalResponse SchemeFundApprovalUpdate(SchemeFundApprovalRequest request)
        {
            SchemeFundApprovalResponse response = new SchemeFundApprovalResponse();
            IDbConnection mConnection = null;

            mConnection = ProviderFactory.GetConnection(Configuration.ConnectionString, EnumProviders.SQLClient);
            mConnection.Open();

            IDbCommand command = ProviderFactory.GetCommand(EnumProviders.SQLClient);
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = DBConstants.PC1SchemeFundApprovalDBConstant.TBL_PC1SCHEMEFUNDAPPROVAL_UPDATE;
            command.Connection = mConnection;

            IDataParameterCollection pparams = command.Parameters;
            IDataParameter parameter;

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@SchemeFundApprovalXML";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Xml);
            parameter.Value = request.SchemeFundApprovalObject.ToXML();

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
        public SchemeFundApprovalResponse SchemeFundProposedGetSchemeId(SchemeFundApprovalRequest request)
        {
            SchemeFundApprovalResponse response = new SchemeFundApprovalResponse();
            IDbConnection mConnection = null;

            mConnection = ProviderFactory.GetConnection(Configuration.ConnectionString, EnumProviders.SQLClient);
            mConnection.Open();

            IDbCommand command = ProviderFactory.GetCommand(EnumProviders.SQLClient);
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = DBConstants.PC1SchemeFundApprovalDBConstant.TBL_PC1SCHEMEFUNDPROPOSED_GET_SCHEMEID;
            command.Connection = mConnection;

            IDataParameterCollection pparams = command.Parameters;
            IDataParameter parameter;

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@SchemeId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.BigInt);
            parameter.Value = request.SchemeId;

            pparams.Add(parameter);

            IDbDataAdapter da = ProviderFactory.GetAdapter(EnumProviders.SQLClient);
            da.SelectCommand = command;
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables != null && ds.Tables.Count > 0)
            {
                response.SchemeFundApprovalDetailList = ds.Tables[0].ToList<SchemeFundApprovalDetail>();

                foreach (SchemeFundApprovalDetail objSchemeFundApprovalDetail in response.SchemeFundApprovalDetailList)
                {
                    if (objSchemeFundApprovalDetail.COACode.ToLower().Contains("a12"))
                    {
                        objSchemeFundApprovalDetail.TypeId = 1;
                    }
                    else
                    {
                        objSchemeFundApprovalDetail.TypeId = 2;
                    }
                }
            }

            return response;
        }
    }
}
