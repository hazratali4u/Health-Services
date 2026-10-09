using CORNCommon;
using CORNCommon.Classes;
using CORNDataAccessLayer;
using CORNDataAccessLayer.Classes;
using CORNDataAccessLayer.Request;
using CORNDataAccessLayer.Response;
using System;
using System.Data;
using System.Linq;

namespace CORNDatabaseLayer
{
    public class OperationMaintenanceDataAccess
    {
        public OperationMaintenanceResponse OperationMaintenanceGetAll()
        {
            OperationMaintenanceResponse response = new OperationMaintenanceResponse();
            IDbConnection mConnection = null;

            mConnection = ProviderFactory.GetConnection(Configuration.ConnectionString, EnumProviders.SQLClient);
            mConnection.Open();

            IDbCommand command = ProviderFactory.GetCommand(EnumProviders.SQLClient);
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = DBConstants.OperationMaintenanceDBConstant.TBL_OPERATIONMAINTENANCE_GET_ALL;
            command.Connection = mConnection;

            IDbDataAdapter da = ProviderFactory.GetAdapter(EnumProviders.SQLClient);
            da.SelectCommand = command;
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables != null && ds.Tables.Count > 0)
            {
                response.OperationMaintenanceList = ds.Tables[0].ToList<OperationMaintenance>();
            }

            return response;
        }
        public OperationMaintenanceResponse OperationMaintenanceGetId(OperationMaintenanceRequest request)
        {
            OperationMaintenanceResponse response = new OperationMaintenanceResponse();
            IDbConnection mConnection = null;

            mConnection = ProviderFactory.GetConnection(Configuration.ConnectionString, EnumProviders.SQLClient);
            mConnection.Open();

            IDbCommand command = ProviderFactory.GetCommand(EnumProviders.SQLClient);
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = DBConstants.OperationMaintenanceDBConstant.TBL_OPERATIONMAINTENANCE_GET_ID;
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
                response.OperationMaintenanceObject = ds.Tables[0].ToObject<OperationMaintenance>();
            }

            return response;
        }
        public OperationMaintenanceResponse OperationMaintenanceAdd(OperationMaintenanceRequest request)
        {
            OperationMaintenanceResponse response = new OperationMaintenanceResponse();
            IDbConnection mConnection = null;

            mConnection = ProviderFactory.GetConnection(Configuration.ConnectionString, EnumProviders.SQLClient);
            mConnection.Open();

            IDbCommand command = ProviderFactory.GetCommand(EnumProviders.SQLClient);
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = DBConstants.OperationMaintenanceDBConstant.TBL_OPERATIONMAINTENANCE_ADD;
            command.Connection = mConnection;

            IDataParameterCollection pparams = command.Parameters;
            IDataParameter parameter;

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@OperationMaintenanceXML";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Xml);
            parameter.Value = request.OperationMaintenanceObject.ToXML();

            pparams.Add(parameter);

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
                response.OperationMaintenanceObject = ds.Tables[0].ToObject<OperationMaintenance>();
            }

            return response;
        }
        public OperationMaintenanceResponse OperationMaintenanceUpdate(OperationMaintenanceRequest request)
        {
            OperationMaintenanceResponse response = new OperationMaintenanceResponse();
            IDbConnection mConnection = null;

            mConnection = ProviderFactory.GetConnection(Configuration.ConnectionString, EnumProviders.SQLClient);
            mConnection.Open();

            IDbCommand command = ProviderFactory.GetCommand(EnumProviders.SQLClient);
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = DBConstants.OperationMaintenanceDBConstant.TBL_OPERATIONMAINTENANCE_UPDATE;
            command.Connection = mConnection;

            IDataParameterCollection pparams = command.Parameters;
            IDataParameter parameter;

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@OperationMaintenanceXML";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Xml);
            parameter.Value = request.OperationMaintenanceObject.ToXML();

            pparams.Add(parameter);

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
                response.OperationMaintenanceObject = ds.Tables[0].ToObject<OperationMaintenance>();
            }

            return response;
        }
        public OperationMaintenanceResponse OperationMaintenanceDelete(OperationMaintenanceRequest request)
        {
            OperationMaintenanceResponse response = new OperationMaintenanceResponse();
            IDbConnection mConnection = null;

            mConnection = ProviderFactory.GetConnection(Configuration.ConnectionString, EnumProviders.SQLClient);
            mConnection.Open();

            IDbCommand command = ProviderFactory.GetCommand(EnumProviders.SQLClient);
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = DBConstants.OperationMaintenanceDBConstant.TBL_OPERATIONMAINTENANCE_DELETE;
            command.Connection = mConnection;

            IDataParameterCollection pparams = command.Parameters;
            IDataParameter parameter;

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@Id";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.BigInt);
            parameter.Value = request.Id;

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
