using CORNCommon;
using CORNCommon.Classes;
using CORNDataAccessLayer;
using CORNDataAccessLayer.Classes;
using CORNDataAccessLayer.Request;
using CORNDataAccessLayer.Response;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace CORNDatabaseLayer
{
    public class PC1SchemeDataAccess
    {
        public SchemeResponse SchemeGetAll(SchemeRequest request)
        {
            SchemeResponse response = new SchemeResponse();
            IDbConnection mConnection = null;

            mConnection = ProviderFactory.GetConnection(Configuration.ConnectionString, EnumProviders.SQLClient);
            mConnection.Open();

            IDbCommand command = ProviderFactory.GetCommand(EnumProviders.SQLClient);
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = DBConstants.PC1SchemeDBConstant.TBL_PC1SCHEME_GET_ALL;
            command.Connection = mConnection;

            IDataParameterCollection pparams = command.Parameters;
            IDataParameter parameter;

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@SchemeIds";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.NVarChar);
            parameter.Value = request.SchemeIds;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@CategoryId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.BigInt);
            parameter.Value = request.CategoryId;

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
                response.SchemeList = ds.Tables[0].ToList<Scheme>();
            }

            return response;
        }
        public SchemeResponse SchemeGetId(SchemeRequest request)
        {
            SchemeResponse response = new SchemeResponse();
            IDbConnection mConnection = null;

            mConnection = ProviderFactory.GetConnection(Configuration.ConnectionString, EnumProviders.SQLClient);
            mConnection.Open();

            IDbCommand command = ProviderFactory.GetCommand(EnumProviders.SQLClient);
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = DBConstants.PC1SchemeDBConstant.TBL_PC1SCHEME_GET_ID;
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
                response.SchemeObject = ds.Tables[0].ToObject<Scheme>();
                response.SchemeObject.SchemeCapitalCostEstimateList = ds.Tables[1].ToList<SchemeCapitalCostEstimate>();
                List<SchemeCapitalCostEstimateDetail> lstSchemeCapitalCostEstimateDetail = ds.Tables[2].ToList<SchemeCapitalCostEstimateDetail>();
                response.SchemeObject.SchemeAnnualOperatingCostList = ds.Tables[3].ToList<SchemeAnnualOperatingCost>();
                List<SchemeAnnualOperatingCostDetail> lstSchemeAnnualOperatingCostDetail = ds.Tables[4].ToList<SchemeAnnualOperatingCostDetail>();
                response.SchemeObject.SchemeFileList = ds.Tables[5].ToList<SchemeFile>();

                foreach (SchemeCapitalCostEstimate objSchemeCapitalCostEstimate in response.SchemeObject.SchemeCapitalCostEstimateList)
                {
                    objSchemeCapitalCostEstimate.SchemeCapitalCostEstimateDetailList = (from p in lstSchemeCapitalCostEstimateDetail
                                                                                        where p.SchemeCapitalCostEstimateId == objSchemeCapitalCostEstimate.Id
                                                                                        select p).ToList();
                }

                foreach (SchemeAnnualOperatingCost objSchemeAnnualOperatingCost in response.SchemeObject.SchemeAnnualOperatingCostList)
                {
                    objSchemeAnnualOperatingCost.SchemeAnnualOperatingCostDetailList = (from p in lstSchemeAnnualOperatingCostDetail
                                                                                        where p.SchemeAnnualOperatingCostId == objSchemeAnnualOperatingCost.Id
                                                                                        select p).ToList();
                }
            }

            return response;
        }
        public SchemeResponse SchemeAdd(SchemeRequest request)
        {
            SchemeResponse response = new SchemeResponse();
            IDbConnection mConnection = null;

            mConnection = ProviderFactory.GetConnection(Configuration.ConnectionString, EnumProviders.SQLClient);
            mConnection.Open();

            IDbCommand command = ProviderFactory.GetCommand(EnumProviders.SQLClient);
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = DBConstants.PC1SchemeDBConstant.TBL_PC1SCHEME_ADD;
            command.Connection = mConnection;

            IDataParameterCollection pparams = command.Parameters;
            IDataParameter parameter;

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@SchemeXML";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Xml);
            parameter.Value = request.SchemeObject.ToXML();

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
                response.SchemeObject = ds.Tables[0].ToObject<Scheme>();
                response.Status = true;
            }

            return response;
        }
        public SchemeResponse SchemeUpdate(SchemeRequest request)
        {
            SchemeResponse response = new SchemeResponse();
            IDbConnection mConnection = null;

            mConnection = ProviderFactory.GetConnection(Configuration.ConnectionString, EnumProviders.SQLClient);
            mConnection.Open();

            IDbCommand command = ProviderFactory.GetCommand(EnumProviders.SQLClient);
            command.CommandType = CommandType.StoredProcedure;

            switch (request.WizardStep)
            {
                case 1:
                    command.CommandText = DBConstants.PC1SchemeDBConstant.TBL_PC1SCHEME_UPDATE_STEP1;

                    break;
                case 2:
                    command.CommandText = DBConstants.PC1SchemeDBConstant.TBL_PC1SCHEME_UPDATE_STEP2;

                    break;
                case 3:
                    command.CommandText = DBConstants.PC1SchemeDBConstant.TBL_PC1SCHEME_UPDATE_STEP3;

                    break;
                case 4:
                    command.CommandText = DBConstants.PC1SchemeDBConstant.TBL_PC1SCHEME_UPDATE_STEP4;

                    break;
                case 5:
                    command.CommandText = DBConstants.PC1SchemeDBConstant.TBL_PC1SCHEME_UPDATE_STEP5;

                    break;
                case 6:
                    command.CommandText = DBConstants.PC1SchemeDBConstant.TBL_PC1SCHEME_UPDATE_STEP6;

                    break;
                case 7:
                    command.CommandText = DBConstants.PC1SchemeDBConstant.TBL_PC1SCHEME_UPDATE_STEP7;

                    break;
                case 8:
                    command.CommandText = DBConstants.PC1SchemeDBConstant.TBL_PC1SCHEME_UPDATE_STEP8;

                    break;
                case 9:
                    command.CommandText = DBConstants.PC1SchemeDBConstant.TBL_PC1SCHEME_UPDATE_STEP9;

                    break;
                case 10:
                    command.CommandText = DBConstants.PC1SchemeDBConstant.TBL_PC1SCHEME_UPDATE_STEP10;

                    break;
                case 11:
                    command.CommandText = DBConstants.PC1SchemeDBConstant.TBL_PC1SCHEME_UPDATE_STEP11;

                    break;
                case 12:
                    command.CommandText = DBConstants.PC1SchemeDBConstant.TBL_PC1SCHEME_UPDATE_STEP12;

                    break;
                case 13:
                    command.CommandText = DBConstants.PC1SchemeDBConstant.TBL_PC1SCHEME_UPDATE_STEP13;

                    break;
                case 14:
                    command.CommandText = DBConstants.PC1SchemeDBConstant.TBL_PC1SCHEME_UPDATE_STEP14;

                    break;
                case 15:
                    command.CommandText = DBConstants.PC1SchemeDBConstant.TBL_PC1SCHEME_UPDATE_STEP15;

                    break;
                case 16:
                    command.CommandText = DBConstants.PC1SchemeDBConstant.TBL_PC1SCHEME_UPDATE_STEP16;

                    break;
                default:
                    command.CommandText = DBConstants.PC1SchemeDBConstant.TBL_PC1SCHEME_UPDATE_STEP1;

                    break;
            }

            command.Connection = mConnection;

            IDataParameterCollection pparams = command.Parameters;
            IDataParameter parameter;

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@SchemeXML";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Xml);
            parameter.Value = request.SchemeObject.ToXML();

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
                if (request.WizardStep == 16)
                {
                    response.SchemeFileList = ds.Tables[0].ToList<SchemeFile>();
                }
                else
                {
                    response.SchemeObject = ds.Tables[0].ToObject<Scheme>();
                }
            }

            response.Status = true;

            return response;
        }
        public SchemeResponse SchemeGetAllFundApproval(SchemeRequest request)
        {
            SchemeResponse response = new SchemeResponse();
            IDbConnection mConnection = null;

            mConnection = ProviderFactory.GetConnection(Configuration.ConnectionString, EnumProviders.SQLClient);
            mConnection.Open();

            IDbCommand command = ProviderFactory.GetCommand(EnumProviders.SQLClient);
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = DBConstants.PC1SchemeDBConstant.TBL_PC1SCHEME_GET_ALL_FUND_APPROVAL;
            command.Connection = mConnection;

            IDataParameterCollection pparams = command.Parameters;
            IDataParameter parameter;

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@SchemeIds";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.NVarChar);
            parameter.Value = request.SchemeIds;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@CategoryId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.BigInt);
            parameter.Value = request.CategoryId;

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
                response.SchemeList = ds.Tables[0].ToList<Scheme>();
            }

            return response;
        }
    }
}
