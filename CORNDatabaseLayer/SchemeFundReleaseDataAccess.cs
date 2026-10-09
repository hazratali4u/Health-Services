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
    public class SchemeFundReleaseDataAccess
    {
        public SchemeFundReleaseResponse SchemeFundReleaseGetAll(SchemeFundReleaseRequest request)
        {
            SchemeFundReleaseResponse response = new SchemeFundReleaseResponse();
            IDbConnection mConnection = null;

            mConnection = ProviderFactory.GetConnection(Configuration.ConnectionString, EnumProviders.SQLClient);
            mConnection.Open();

            IDbCommand command = ProviderFactory.GetCommand(EnumProviders.SQLClient);
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = DBConstants.SchemeFundReleaseDBConstant.TBL_SCHEMEFUNDRELEASE_GET_ALL;
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
                response.SchemeFundReleaseList = ds.Tables[0].ToList<SchemeFundRelease>();
            }

            return response;
        }
        public SchemeFundReleaseResponse SchemeFundReleaseGetId(SchemeFundReleaseRequest request)
        {
            SchemeFundReleaseResponse response = new SchemeFundReleaseResponse();
            IDbConnection mConnection = null;

            mConnection = ProviderFactory.GetConnection(Configuration.ConnectionString, EnumProviders.SQLClient);
            mConnection.Open();

            IDbCommand command = ProviderFactory.GetCommand(EnumProviders.SQLClient);
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = DBConstants.SchemeFundReleaseDBConstant.TBL_SCHEMEFUNDRELEASE_GET_ID;
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
                response.SchemeFundReleaseObject = ds.Tables[0].ToObject<SchemeFundRelease>();
                response.SchemeFundReleaseObject.SchemeFundReleaseDetailList = ds.Tables[1].ToList<SchemeFundReleaseDetail>();
            }

            return response;
        }
        public SchemeFundReleaseResponse SchemeFundReleaseAdd(SchemeFundReleaseRequest request)
        {
            SchemeFundReleaseResponse response = new SchemeFundReleaseResponse();
            IDbConnection mConnection = null;

            mConnection = ProviderFactory.GetConnection(Configuration.ConnectionString, EnumProviders.SQLClient);
            mConnection.Open();

            IDbCommand command = ProviderFactory.GetCommand(EnumProviders.SQLClient);
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = DBConstants.SchemeFundReleaseDBConstant.TBL_SCHEMEFUNDRELEASE_ADD;
            command.Connection = mConnection;

            IDataParameterCollection pparams = command.Parameters;
            IDataParameter parameter;

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@SchemeFundReleaseXML";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Xml);
            parameter.Value = request.SchemeFundReleaseObject.ToXML();

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
        public SchemeFundReleaseResponse SchemeFundReleaseUpdate(SchemeFundReleaseRequest request)
        {
            SchemeFundReleaseResponse response = new SchemeFundReleaseResponse();
            IDbConnection mConnection = null;

            mConnection = ProviderFactory.GetConnection(Configuration.ConnectionString, EnumProviders.SQLClient);
            mConnection.Open();

            IDbCommand command = ProviderFactory.GetCommand(EnumProviders.SQLClient);
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = DBConstants.SchemeFundReleaseDBConstant.TBL_SCHEMEFUNDRELEASE_UPDATE;
            command.Connection = mConnection;

            IDataParameterCollection pparams = command.Parameters;
            IDataParameter parameter;

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@SchemeFundReleaseXML";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Xml);
            parameter.Value = request.SchemeFundReleaseObject.ToXML();

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
        public SchemeFundReleaseResponse SchemeFundAllocationGetSchemeId(SchemeFundReleaseRequest request)
        {
            SchemeFundReleaseResponse response = new SchemeFundReleaseResponse();
            IDbConnection mConnection = null;

            mConnection = ProviderFactory.GetConnection(Configuration.ConnectionString, EnumProviders.SQLClient);
            mConnection.Open();

            IDbCommand command = ProviderFactory.GetCommand(EnumProviders.SQLClient);
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = DBConstants.SchemeFundReleaseDBConstant.TBL_SCHEMEFUNDALLOCATION_GET_SCHEMEID;
            command.Connection = mConnection;

            IDataParameterCollection pparams = command.Parameters;
            IDataParameter parameter;

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@SchemeId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.BigInt);
            parameter.Value = request.SchemeId;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@FinancialYearId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.BigInt);
            parameter.Value = request.FinancialYearId;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@COAId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.BigInt);
            parameter.Value = request.COAId;

            pparams.Add(parameter);

            IDbDataAdapter da = ProviderFactory.GetAdapter(EnumProviders.SQLClient);
            da.SelectCommand = command;
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables != null && ds.Tables.Count > 0)
            {
                response.SchemeFundReleaseDetailList = ds.Tables[0].ToList<SchemeFundReleaseDetail>();
            }

            return response;
        }
        public SchemeFundReleaseResponse SchemeFundAllocationGetSchemeIdForTotal(SchemeFundReleaseRequest request)
        {
            SchemeFundReleaseResponse response = new SchemeFundReleaseResponse();
            IDbConnection mConnection = null;

            mConnection = ProviderFactory.GetConnection(Configuration.ConnectionString, EnumProviders.SQLClient);
            mConnection.Open();

            IDbCommand command = ProviderFactory.GetCommand(EnumProviders.SQLClient);
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = DBConstants.SchemeFundReleaseDBConstant.TBL_SCHEMEFUNDALLOCATION_GET_SCHEMEID_FOR_TOTAL;
            command.Connection = mConnection;

            IDataParameterCollection pparams = command.Parameters;
            IDataParameter parameter;

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@SchemeId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.BigInt);
            parameter.Value = request.SchemeId;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@FinancialYearId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.BigInt);
            parameter.Value = request.FinancialYearId;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@COAId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.BigInt);
            parameter.Value = request.COAId;

            pparams.Add(parameter);

            IDbDataAdapter da = ProviderFactory.GetAdapter(EnumProviders.SQLClient);
            da.SelectCommand = command;
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables != null && ds.Tables.Count > 0)
            {
                response.SchemeFundAllocationDetailList = ds.Tables[0].ToList<SchemeFundAllocationDetail>();
                response.SchemeReappropriationDetailList = ds.Tables[1].ToList<SchemeReappropriationDetail>();
                response.SchemeExcessDetailList = ds.Tables[2].ToList<SchemeExcessDetail>();
                response.SchemeFundReleaseDetailList = ds.Tables[3].ToList<SchemeFundReleaseDetail>();
            }

            return response;
        }
    }
}
