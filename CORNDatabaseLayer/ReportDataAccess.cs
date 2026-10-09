using CORNCommon;
using CORNCommon.Classes;
using CORNDataAccessLayer;
using CORNDataAccessLayer.Classes;
using CORNDataAccessLayer.Request;
using CORNDataAccessLayer.Response;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;

namespace CORNDatabaseLayer
{
    public class ReportDataAccess
    {
        public ReportResponse GenerateMonthlyProgressReport(ReportRequest request)
        {
            ReportResponse response = new ReportResponse();
            IDbConnection mConnection = null;

            mConnection = ProviderFactory.GetConnection(Configuration.ConnectionString, EnumProviders.SQLClient);
            mConnection.Open();

            IDbCommand command = ProviderFactory.GetCommand(EnumProviders.SQLClient);
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = DBConstants.ReportDBConstant.TBL_REPORT_MONTHLY_PROGRESS;
            command.Connection = mConnection;

            IDataParameterCollection pparams = command.Parameters;
            IDataParameter parameter;

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@InstituteId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Int);
            parameter.Value = request.InstituteId;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@SchemeId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Int);
            parameter.Value = request.SchemeId;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@Year";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Int);
            parameter.Value = request.Year;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@Month";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Int);
            parameter.Value = request.Month;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@SchemeStatusId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.BigInt);
            parameter.Value = request.SchemeStatusId;

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

            if (ds.Tables != null && ds.Tables.Count > 2)
            {
                response.CornReportList = new List<CornReport>();

                CornReport objCornReport = new CornReport();

                objCornReport.SchemeList = ds.Tables[0].ToList<Scheme>();

                List<SchemeFundApproval> lstSchemeFundApproval = ds.Tables[1].ToList<SchemeFundApproval>();

                foreach (Scheme objScheme in objCornReport.SchemeList)
                {
                    List<SchemeFundApproval> tmpSchemeFundApproval = lstSchemeFundApproval.FindAll(p => p.SchemeId == objScheme.Id).OrderBy(p => p.Id).ToList();

                    SchemeFundApproval lastSchemeFundApproval = tmpSchemeFundApproval.LastOrDefault();

                    if (lastSchemeFundApproval != null)
                    {
                        objScheme.LastApprovedCapital = lastSchemeFundApproval.CapitalAmount;
                        objScheme.LastApprovedRevenue = lastSchemeFundApproval.RevenueAmount;

                        string approvedStatusAndDate = string.Empty;

                        for (int i = 0; i < tmpSchemeFundApproval.Count; i++)
                        {
                            if (i == 0)
                            {
                                approvedStatusAndDate = "Approved" + Environment.NewLine + Environment.NewLine + tmpSchemeFundApproval[i].ApprovedByAndDate + Environment.NewLine;
                            }
                            else
                            {
                                if (i == 1)
                                {
                                    approvedStatusAndDate += Environment.NewLine + Environment.NewLine + "Revised" + Environment.NewLine + Environment.NewLine;
                                }

                                approvedStatusAndDate += tmpSchemeFundApproval[i].ApprovedByAndDate + Environment.NewLine;
                            }
                        }

                        objScheme.ApprovedStatusAndDate = approvedStatusAndDate;
                    }
                }

                response.CornReportList.Add(objCornReport);

                response.Month = DateTimeFormatInfo.CurrentInfo.GetMonthName(request.Month);
                response.Year = request.Year.ToString();
                response.ExpectedYear = Convert.ToString(ds.Tables[2].Rows[0][0]);
                response.FinancialYear = Convert.ToString(ds.Tables[2].Rows[0][1]);
            }

            return response;
        }
        public ReportResponse GenerateFundWiseReport(ReportRequest request)
        {
            ReportResponse response = new ReportResponse();
            IDbConnection mConnection = null;

            mConnection = ProviderFactory.GetConnection(Configuration.ConnectionString, EnumProviders.SQLClient);
            mConnection.Open();

            IDbCommand command = ProviderFactory.GetCommand(EnumProviders.SQLClient);
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = DBConstants.ReportDBConstant.TBL_REPORT_FUND_WISE;
            command.Connection = mConnection;

            IDataParameterCollection pparams = command.Parameters;
            IDataParameter parameter;

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@InstituteId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Int);
            parameter.Value = request.InstituteId;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@SchemeId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Int);
            parameter.Value = request.SchemeId;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@FinancialYearId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Int);
            parameter.Value = request.FinancialYearId;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@SchemeStatusId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.BigInt);
            parameter.Value = request.SchemeStatusId;

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

            if (ds.Tables != null && ds.Tables.Count > 1)
            {
                response.CornReportList = new List<CornReport>();

                CornReport objCornReport = new CornReport();

                objCornReport.SchemeList = ds.Tables[0].ToList<Scheme>();

                response.CornReportList.Add(objCornReport);

                response.FinancialYear = Convert.ToString(ds.Tables[1].Rows[0][0]);
            }

            return response;
        }
        public ReportResponse GenerateSchemeSummaryReport(ReportRequest request)
        {
            ReportResponse response = new ReportResponse();
            IDbConnection mConnection = null;

            mConnection = ProviderFactory.GetConnection(Configuration.ConnectionString, EnumProviders.SQLClient);
            mConnection.Open();

            IDbCommand command = ProviderFactory.GetCommand(EnumProviders.SQLClient);
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = DBConstants.ReportDBConstant.TBL_REPORT_SCHEME_BREAKUP;
            command.Connection = mConnection;

            IDataParameterCollection pparams = command.Parameters;
            IDataParameter parameter;

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@InstituteId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Int);
            parameter.Value = request.InstituteId;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@FinancialYearId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Int);
            parameter.Value = request.FinancialYearId;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@SchemeStatusId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.BigInt);
            parameter.Value = request.SchemeStatusId;

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

            if (ds.Tables != null && ds.Tables.Count > 2)
            {
                response.CornReportList = new List<CornReport>();

                CornReport objCornReport = new CornReport();

                objCornReport.InstituteList = ds.Tables[0].ToList<Institute>();

                List<SubSector> lstSubSector = ds.Tables[1].ToList<SubSector>();
                List<InstituteStats> lstInstituteStats = ds.Tables[2].ToList<InstituteStats>();

                foreach (Institute objInstitute in objCornReport.InstituteList)
                {
                    objInstitute.SubSectorList = lstSubSector.FindAll(p => p.InstituteId == objInstitute.Id);
                    objInstitute.InstituteStatsList = lstInstituteStats.FindAll(p => p.InstituteId == objInstitute.Id);
                }

                response.CornReportList.Add(objCornReport);
            }

            return response;
        }
        public ReportResponse GenerateSubSectorSummaryReport(ReportRequest request)
        {
            ReportResponse response = new ReportResponse();
            IDbConnection mConnection = null;

            mConnection = ProviderFactory.GetConnection(Configuration.ConnectionString, EnumProviders.SQLClient);
            mConnection.Open();

            IDbCommand command = ProviderFactory.GetCommand(EnumProviders.SQLClient);
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = DBConstants.ReportDBConstant.TBL_REPORT_SUBSECTOR_WISE;
            command.Connection = mConnection;

            IDataParameterCollection pparams = command.Parameters;
            IDataParameter parameter;

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@InstituteId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Int);
            parameter.Value = request.InstituteId;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@FinancialYearId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Int);
            parameter.Value = request.FinancialYearId;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@SchemeId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Int);
            parameter.Value = request.SchemeId;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@SchemeStatusId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.BigInt);
            parameter.Value = request.SchemeStatusId;

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

            if (ds.Tables != null && ds.Tables.Count > 2)
            {
                response.CornReportList = new List<CornReport>();

                CornReport objCornReport = new CornReport();

                objCornReport.InstituteList = ds.Tables[0].ToList<Institute>();

                List<SubSector> lstSubSector = ds.Tables[1].ToList<SubSector>();

                foreach (Institute objInstitute in objCornReport.InstituteList)
                {
                    objInstitute.SubSectorList = lstSubSector.FindAll(p => p.InstituteId == objInstitute.Id);
                }

                response.CornReportList.Add(objCornReport);

                response.FinancialYear = Convert.ToString(ds.Tables[2].Rows[0][0]);
            }

            return response;
        }
        public ReportResponse GenerateStatusWiseReport(ReportRequest request)
        {
            ReportResponse response = new ReportResponse();
            IDbConnection mConnection = null;

            mConnection = ProviderFactory.GetConnection(Configuration.ConnectionString, EnumProviders.SQLClient);
            mConnection.Open();

            IDbCommand command = ProviderFactory.GetCommand(EnumProviders.SQLClient);
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = DBConstants.ReportDBConstant.TBL_REPORT_STATUS_WISE;
            command.Connection = mConnection;

            IDataParameterCollection pparams = command.Parameters;
            IDataParameter parameter;

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@InstituteId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Int);
            parameter.Value = request.InstituteId;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@SchemeId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Int);
            parameter.Value = request.SchemeId;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@FinancialYearId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Int);
            parameter.Value = request.FinancialYearId;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@SchemeStatusId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.BigInt);
            parameter.Value = request.SchemeStatusId;

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

            if (ds.Tables != null && ds.Tables.Count > 1)
            {
                response.CornReportList = new List<CornReport>();

                CornReport objCornReport = new CornReport();

                objCornReport.SchemeList = ds.Tables[0].ToList<Scheme>();

                response.CornReportList.Add(objCornReport);

                response.FinancialYear = Convert.ToString(ds.Tables[1].Rows[0][0]);
            }

            return response;
        }
        public ReportResponse GenerateSchemeWithNoReleaseReport(ReportRequest request)
        {
            ReportResponse response = new ReportResponse();
            IDbConnection mConnection = null;

            mConnection = ProviderFactory.GetConnection(Configuration.ConnectionString, EnumProviders.SQLClient);
            mConnection.Open();

            IDbCommand command = ProviderFactory.GetCommand(EnumProviders.SQLClient);
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = DBConstants.ReportDBConstant.TBL_REPORT_NO_RELEASE;
            command.Connection = mConnection;

            IDataParameterCollection pparams = command.Parameters;
            IDataParameter parameter;

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@InstituteId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Int);
            parameter.Value = request.InstituteId;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@SchemeId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Int);
            parameter.Value = request.SchemeId;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@FinancialYearId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Int);
            parameter.Value = request.FinancialYearId;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@SchemeStatusId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.BigInt);
            parameter.Value = request.SchemeStatusId;

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

            if (ds.Tables != null && ds.Tables.Count > 1)
            {
                response.CornReportList = new List<CornReport>();

                CornReport objCornReport = new CornReport();

                objCornReport.SchemeList = ds.Tables[0].ToList<Scheme>();

                response.CornReportList.Add(objCornReport);

                response.FinancialYear = Convert.ToString(ds.Tables[1].Rows[0][0]);
            }

            return response;
        }
        public ReportResponse GenerateSchemeWithReleaseNoExpenseReport(ReportRequest request)
        {
            ReportResponse response = new ReportResponse();
            IDbConnection mConnection = null;

            mConnection = ProviderFactory.GetConnection(Configuration.ConnectionString, EnumProviders.SQLClient);
            mConnection.Open();

            IDbCommand command = ProviderFactory.GetCommand(EnumProviders.SQLClient);
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = DBConstants.ReportDBConstant.TBL_REPORT_RELEASE_NO_EXPENSE;
            command.Connection = mConnection;

            IDataParameterCollection pparams = command.Parameters;
            IDataParameter parameter;

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@InstituteId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Int);
            parameter.Value = request.InstituteId;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@SchemeId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Int);
            parameter.Value = request.SchemeId;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@FinancialYearId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Int);
            parameter.Value = request.FinancialYearId;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@SchemeStatusId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.BigInt);
            parameter.Value = request.SchemeStatusId;

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

            if (ds.Tables != null && ds.Tables.Count > 1)
            {
                response.CornReportList = new List<CornReport>();

                CornReport objCornReport = new CornReport();

                objCornReport.SchemeList = ds.Tables[0].ToList<Scheme>();

                response.CornReportList.Add(objCornReport);

                response.FinancialYear = Convert.ToString(ds.Tables[1].Rows[0][0]);
            }

            return response;
        }
        public ReportResponse GenerateFunctionWiseReport(ReportRequest request)
        {
            ReportResponse response = new ReportResponse();
            IDbConnection mConnection = null;

            mConnection = ProviderFactory.GetConnection(Configuration.ConnectionString, EnumProviders.SQLClient);
            mConnection.Open();

            IDbCommand command = ProviderFactory.GetCommand(EnumProviders.SQLClient);
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = DBConstants.ReportDBConstant.TBL_REPORT_FUNCTION_WISE;
            command.Connection = mConnection;

            IDataParameterCollection pparams = command.Parameters;
            IDataParameter parameter;

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@InstituteId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Int);
            parameter.Value = request.InstituteId;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@SchemeId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Int);
            parameter.Value = request.SchemeId;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@FinancialYearId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Int);
            parameter.Value = request.FinancialYearId;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@SchemeStatusId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.BigInt);
            parameter.Value = request.SchemeStatusId;

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

            if (ds.Tables != null && ds.Tables.Count > 1)
            {
                response.CornReportList = new List<CornReport>();

                CornReport objCornReport = new CornReport();

                objCornReport.SchemeList = ds.Tables[0].ToList<Scheme>();

                response.CornReportList.Add(objCornReport);

                response.FinancialYear = Convert.ToString(ds.Tables[1].Rows[0][0]);
            }

            return response;
        }
        public ReportResponse GenerateObjectWiseReport(ReportRequest request)
        {
            ReportResponse response = new ReportResponse();
            IDbConnection mConnection = null;

            mConnection = ProviderFactory.GetConnection(Configuration.ConnectionString, EnumProviders.SQLClient);
            mConnection.Open();

            IDbCommand command = ProviderFactory.GetCommand(EnumProviders.SQLClient);
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = DBConstants.ReportDBConstant.TBL_REPORT_OBJECT_WISE;
            command.Connection = mConnection;

            IDataParameterCollection pparams = command.Parameters;
            IDataParameter parameter;

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@InstituteId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Int);
            parameter.Value = request.InstituteId;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@SchemeId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Int);
            parameter.Value = request.SchemeId;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@FinancialYearId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Int);
            parameter.Value = request.FinancialYearId;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@MajorCAId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.BigInt);
            parameter.Value = request.MajorCAId;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@MinorCAId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.BigInt);
            parameter.Value = request.MinorCAId;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@SchemeStatusId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.BigInt);
            parameter.Value = request.SchemeStatusId;

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

            if (ds.Tables != null && ds.Tables.Count > 1)
            {
                response.CornReportList = new List<CornReport>();

                CornReport objCornReport = new CornReport();

                objCornReport.SchemeList = ds.Tables[0].ToList<Scheme>();

                response.CornReportList.Add(objCornReport);

                response.FinancialYear = Convert.ToString(ds.Tables[1].Rows[0][0]);
            }

            return response;
        }
        public ReportResponse GenerateExcessSurrenderReport(ReportRequest request)
        {
            ReportResponse response = new ReportResponse();
            IDbConnection mConnection = null;

            mConnection = ProviderFactory.GetConnection(Configuration.ConnectionString, EnumProviders.SQLClient);
            mConnection.Open();

            IDbCommand command = ProviderFactory.GetCommand(EnumProviders.SQLClient);
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = DBConstants.ReportDBConstant.TBL_REPORT_EXCESSSURRENDER_WISE;
            command.Connection = mConnection;

            IDataParameterCollection pparams = command.Parameters;
            IDataParameter parameter;

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@InstituteId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Int);
            parameter.Value = request.InstituteId;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@SchemeId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Int);
            parameter.Value = request.SchemeId;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@FinancialYearId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Int);
            parameter.Value = request.FinancialYearId;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@SchemeStatusId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.BigInt);
            parameter.Value = request.SchemeStatusId;

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

            if (ds.Tables != null && ds.Tables.Count > 1)
            {
                response.CornReportList = new List<CornReport>();

                CornReport objCornReport = new CornReport();

                objCornReport.SchemeList = ds.Tables[0].ToList<Scheme>();

                response.CornReportList.Add(objCornReport);

                response.FinancialYear = Convert.ToString(ds.Tables[1].Rows[0][0]);
            }

            return response;
        }
        public ReportResponse GenerateADPSchemeDetailReport(ReportRequest request)
        {
            ReportResponse response = new ReportResponse();
            IDbConnection mConnection = null;

            mConnection = ProviderFactory.GetConnection(Configuration.ConnectionString, EnumProviders.SQLClient);
            mConnection.Open();

            IDbCommand command = ProviderFactory.GetCommand(EnumProviders.SQLClient);
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = DBConstants.ReportDBConstant.TBL_REPORT_SCHEME_DETAIL_ADP;
            command.Connection = mConnection;

            IDataParameterCollection pparams = command.Parameters;
            IDataParameter parameter;

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@FinancialYearId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Int);
            parameter.Value = request.FinancialYearId;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@SchemeStatusId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.BigInt);
            parameter.Value = request.SchemeStatusId;

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
                response.CornReportList = new List<CornReport>();

                CornReport objCornReport = new CornReport();

                objCornReport.SchemeList = ds.Tables[0].ToList<Scheme>();

                response.CornReportList.Add(objCornReport);
            }

            return response;
        }
        public ReportResponse GenerateExcessSurrenderStatementReport(ReportRequest request)
        {
            ReportResponse response = new ReportResponse();
            IDbConnection mConnection = null;

            mConnection = ProviderFactory.GetConnection(Configuration.ConnectionString, EnumProviders.SQLClient);
            mConnection.Open();

            IDbCommand command = ProviderFactory.GetCommand(EnumProviders.SQLClient);
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = DBConstants.ReportDBConstant.TBL_REPORT_EXCESSSURRENDER_STATEMENT;
            command.Connection = mConnection;

            IDataParameterCollection pparams = command.Parameters;
            IDataParameter parameter;

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@InstituteId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Int);
            parameter.Value = request.InstituteId;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@SchemeId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Int);
            parameter.Value = request.SchemeId;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@FinancialYearId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Int);
            parameter.Value = request.FinancialYearId;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@SchemeStatusId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.BigInt);
            parameter.Value = request.SchemeStatusId;

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

            if (ds.Tables != null && ds.Tables.Count > 1)
            {
                response.CornReportList = new List<CornReport>();

                CornReport objCornReport = new CornReport();

                objCornReport.SchemeList = ds.Tables[0].ToList<Scheme>();

                response.CornReportList.Add(objCornReport);

                response.FinancialYear = Convert.ToString(ds.Tables[1].Rows[0][0]);
            }

            return response;
        }
        public ReportResponse GenerateNewMonthlyProgressReport(ReportRequest request)
        {
            ReportResponse response = new ReportResponse();
            IDbConnection mConnection = null;

            mConnection = ProviderFactory.GetConnection(Configuration.ConnectionString, EnumProviders.SQLClient);
            mConnection.Open();

            IDbCommand command = ProviderFactory.GetCommand(EnumProviders.SQLClient);
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = DBConstants.ReportDBConstant.TBL_REPORT_MONTHLY_PROGRESS_NEW;
            command.Connection = mConnection;

            IDataParameterCollection pparams = command.Parameters;
            IDataParameter parameter;

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@InstituteId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Int);
            parameter.Value = request.InstituteId;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@SchemeId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Int);
            parameter.Value = request.SchemeId;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@Year";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Int);
            parameter.Value = request.Year;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@Month";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Int);
            parameter.Value = request.Month;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@SchemeStatusId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.BigInt);
            parameter.Value = request.SchemeStatusId;

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

            if (ds.Tables != null && ds.Tables.Count > 2)
            {
                response.CornReportList = new List<CornReport>();

                CornReport objCornReport = new CornReport();

                objCornReport.SchemeList = ds.Tables[0].ToList<Scheme>();

                List<SchemeFundApproval> lstSchemeFundApproval = ds.Tables[1].ToList<SchemeFundApproval>();

                foreach (Scheme objScheme in objCornReport.SchemeList)
                {
                    List<SchemeFundApproval> tmpSchemeFundApproval = lstSchemeFundApproval.FindAll(p => p.SchemeId == objScheme.Id).OrderBy(p => p.Id).ToList();

                    SchemeFundApproval lastSchemeFundApproval = tmpSchemeFundApproval.LastOrDefault();

                    if (lastSchemeFundApproval != null)
                    {
                        objScheme.LastApprovedCapital = lastSchemeFundApproval.CapitalAmount;
                        objScheme.LastApprovedRevenue = lastSchemeFundApproval.RevenueAmount;

                        string approvedStatusAndDate = string.Empty;

                        for (int i = 0; i < tmpSchemeFundApproval.Count; i++)
                        {
                            //if (i == 0)
                            //{
                            //    approvedStatusAndDate = "Approved" + Environment.NewLine + Environment.NewLine + tmpSchemeFundApproval[i].ApprovedByAndDate + Environment.NewLine;
                            //}
                            //else
                            //{
                            //    if (i == 1)
                            //    {
                            //        approvedStatusAndDate += Environment.NewLine + Environment.NewLine + "Revised" + Environment.NewLine + Environment.NewLine;
                            //    }

                            //    approvedStatusAndDate += tmpSchemeFundApproval[i].ApprovedByAndDate + Environment.NewLine;
                            //}
                            objScheme.ApprovalStatus = "Approved";
                            objScheme.ApprovalForumAndDate = tmpSchemeFundApproval[i].ApprovedByAndDate;
                        }

                        //objScheme.ApprovedStatusAndDate = approvedStatusAndDate;
                    }
                }

                response.CornReportList.Add(objCornReport);

                response.Month = DateTimeFormatInfo.CurrentInfo.GetMonthName(request.Month);
                response.Year = request.Year.ToString();
                response.ExpectedYear = Convert.ToString(ds.Tables[2].Rows[0][0]);
                response.FinancialYear = Convert.ToString(ds.Tables[2].Rows[0][1]);
                response.NextFinancialYear = Convert.ToString(ds.Tables[2].Rows[0][2]);
            }

            return response;
        }
        public ReportResponse GeneratePC1SchemeReport(ReportRequest request)
        {
            ReportResponse response = new ReportResponse();
            IDbConnection mConnection = null;

            mConnection = ProviderFactory.GetConnection(Configuration.ConnectionString, EnumProviders.SQLClient);
            mConnection.Open();

            IDbCommand command = ProviderFactory.GetCommand(EnumProviders.SQLClient);
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = DBConstants.ReportDBConstant.TBL_REPORT_PC1SCHEME;
            command.Connection = mConnection;

            IDataParameterCollection pparams = command.Parameters;
            IDataParameter parameter;

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@Id";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Int);
            parameter.Value = request.SchemeId;

            pparams.Add(parameter);

            IDbDataAdapter da = ProviderFactory.GetAdapter(EnumProviders.SQLClient);
            da.SelectCommand = command;
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables != null && ds.Tables.Count > 0)
            {
                response.CornReportList = new List<CornReport>();

                CornReport objCornReport = new CornReport();

                objCornReport.SchemeList = ds.Tables[0].ToList<Scheme>();
                objCornReport.SchemeList[0].SchemeCapitalCostEstimateList = ds.Tables[1].ToList<SchemeCapitalCostEstimate>();

                List<FinancialYear> lstFinancialYear = ds.Tables[2].ToList<FinancialYear>();
                List<SchemeCapitalCostEstimateDetail> lstSchemeCapitalCostEstimateDetail = ds.Tables[3].ToList<SchemeCapitalCostEstimateDetail>();

                objCornReport.SchemeList[0].SchemeAnnualOperatingCostList = ds.Tables[4].ToList<SchemeAnnualOperatingCost>();

                List<SchemeAnnualOperatingCostDetail> lstSchemeAnnualOperatingCostDetail = ds.Tables[5].ToList<SchemeAnnualOperatingCostDetail>();

                foreach (SchemeCapitalCostEstimate objSchemeCapitalCostEstimate in objCornReport.SchemeList[0].SchemeCapitalCostEstimateList)
                {
                    objSchemeCapitalCostEstimate.FinancialYearList = (from p in lstFinancialYear
                                                                      where p.SchemeCapitalCostEstimateId == objSchemeCapitalCostEstimate.Id
                                                                      select p).ToList();

                    foreach (FinancialYear objFinancialYear in objSchemeCapitalCostEstimate.FinancialYearList)
                    {
                        objFinancialYear.SchemeCapitalCostEstimateDetailList = (from p in lstSchemeCapitalCostEstimateDetail
                                                                                where p.SchemeCapitalCostEstimateId == objFinancialYear.SchemeCapitalCostEstimateId
                                                                                && p.FYId == objFinancialYear.Id
                                                                                select p).ToList();
                    }
                }

                foreach (SchemeAnnualOperatingCost objSchemeAnnualOperatingCost in objCornReport.SchemeList[0].SchemeAnnualOperatingCostList)
                {
                    objSchemeAnnualOperatingCost.SchemeAnnualOperatingCostDetailList = (from p in lstSchemeAnnualOperatingCostDetail
                                                                                        where p.SchemeAnnualOperatingCostId == objSchemeAnnualOperatingCost.Id
                                                                                        select p).ToList();
                }

                response.CornReportList.Add(objCornReport);

                response.Date = objCornReport.SchemeList[0].dtmLastM.ToString("MMM yyyy");
            }

            return response;
        }
        public ReportResponse GeneratePC1SchemeStageReport(ReportRequest request)
        {
            ReportResponse response = new ReportResponse();
            IDbConnection mConnection = null;

            mConnection = ProviderFactory.GetConnection(Configuration.ConnectionString, EnumProviders.SQLClient);
            mConnection.Open();

            IDbCommand command = ProviderFactory.GetCommand(EnumProviders.SQLClient);
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = DBConstants.ReportDBConstant.TBL_REPORT_PC1SCHEMESTAGE;
            command.Connection = mConnection;

            IDataParameterCollection pparams = command.Parameters;
            IDataParameter parameter;

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@Id";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Int);
            parameter.Value = request.SchemeId;

            pparams.Add(parameter);

            IDbDataAdapter da = ProviderFactory.GetAdapter(EnumProviders.SQLClient);
            da.SelectCommand = command;
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables != null && ds.Tables.Count > 1)
            {
                response.CornReportList = new List<CornReport>();

                CornReport objCornReport = new CornReport();

                objCornReport.SchemeStageList = ds.Tables[0].ToList<SchemeStage>();
                response.Title = Convert.ToString(ds.Tables[1].Rows[0][0]);

                response.CornReportList.Add(objCornReport);
            }

            return response;
        }
        public ReportResponse GeneratePC1SchemeStatusReport(ReportRequest request)
        {
            ReportResponse response = new ReportResponse();
            IDbConnection mConnection = null;

            mConnection = ProviderFactory.GetConnection(Configuration.ConnectionString, EnumProviders.SQLClient);
            mConnection.Open();

            IDbCommand command = ProviderFactory.GetCommand(EnumProviders.SQLClient);
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = DBConstants.ReportDBConstant.TBL_REPORT_PC1SCHEMESTATUS;
            command.Connection = mConnection;

            IDataParameterCollection pparams = command.Parameters;
            IDataParameter parameter;

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@Id";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Int);
            parameter.Value = request.SchemeId;

            pparams.Add(parameter);

            IDbDataAdapter da = ProviderFactory.GetAdapter(EnumProviders.SQLClient);
            da.SelectCommand = command;
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables != null && ds.Tables.Count > 1)
            {
                response.CornReportList = new List<CornReport>();

                CornReport objCornReport = new CornReport();

                objCornReport.SchemeFundApprovalList = ds.Tables[0].ToList<SchemeFundApproval>();
                response.Title = Convert.ToString(ds.Tables[1].Rows[0][0]);

                response.CornReportList.Add(objCornReport);
            }

            return response;
        }
        public ReportResponse GenerateSubSectorMonthlyProgressReport(ReportRequest request)
        {
            ReportResponse response = new ReportResponse();
            IDbConnection mConnection = null;

            mConnection = ProviderFactory.GetConnection(Configuration.ConnectionString, EnumProviders.SQLClient);
            mConnection.Open();

            IDbCommand command = ProviderFactory.GetCommand(EnumProviders.SQLClient);
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = mConnection;

            if (System.Configuration.ConfigurationManager.AppSettings["Domain"] == "PU")
            {
                command.CommandText = DBConstants.ReportDBConstant.TBL_REPORT_MONTHLY_PROGRESS_SUBSECTOR_WISE;
            }
            else
            {
                command.CommandText = DBConstants.ReportDBConstant.KP_TBL_REPORT_MONTHLY_PROGRESS_SUBSECTOR_WISE;
            }

            IDataParameterCollection pparams = command.Parameters;
            IDataParameter parameter;

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@DistrictId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Int);
            parameter.Value = request.DistrictId;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@FinancialYearId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Int);
            parameter.Value = request.FinancialYearId;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@FromDateTime";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.DateTime);
            parameter.Value = request.FromDateTime;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@ToDateTime";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.DateTime);
            parameter.Value = request.ToDateTime;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@SchemeStatusId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.BigInt);
            parameter.Value = request.SchemeStatusId;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@ConstituencyId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Int);
            parameter.Value = request.ConstituencyId;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@FundTypeId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Int);
            parameter.Value = request.FundTypeId;

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

            if (ds.Tables != null && ds.Tables.Count > 1)
            {
                response.CornReportList = new List<CornReport>();

                CornReport objCornReport = new CornReport();

                objCornReport.SubSectorList = ds.Tables[0].ToList<SubSector>();

                foreach (SubSector objSubSector in objCornReport.SubSectorList)
                {
                    objSubSector.FinalCapitalGrant = (objSubSector.AllocationCapitalAmount + objSubSector.ReappPositiveCapitalAmount + objSubSector.ExcessCapitalAmount) - (objSubSector.SurrenderCapitalAmount + objSubSector.ReappNegativeCapitalAmount);
                    objSubSector.FinalRevenueGrant = (objSubSector.AllocationRevenueAmount + objSubSector.ReappPositiveRevenueAmount + objSubSector.ExcessRevenueAmount) - (objSubSector.SurrenderRevenueAmount + objSubSector.ReappNegativeRevenueAmount);
                    objSubSector.FinalForignFundGrant = (objSubSector.AllocationForignFundAmount + objSubSector.ReappPositiveForignFundAmount + objSubSector.ExcessForignFundAmount) - (objSubSector.SurrenderForignFundAmount + objSubSector.ReappNegativeForignFundAmount);
                }

                response.CornReportList.Add(objCornReport);

                response.FinancialYear = Convert.ToString(ds.Tables[1].Rows[0][0]);
                response.District = Convert.ToString(ds.Tables[1].Rows[0][1]);
                response.Constituency = Convert.ToString(ds.Tables[1].Rows[0][2]);
            }

            return response;
        }
        public ReportResponse GenerateObjectMonthlyProgressReport(ReportRequest request)
        {
            ReportResponse response = new ReportResponse();
            IDbConnection mConnection = null;

            mConnection = ProviderFactory.GetConnection(Configuration.ConnectionString, EnumProviders.SQLClient);
            mConnection.Open();

            IDbCommand command = ProviderFactory.GetCommand(EnumProviders.SQLClient);
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = mConnection;

            if (System.Configuration.ConfigurationManager.AppSettings["Domain"] == "PU")
            {
                command.CommandText = DBConstants.ReportDBConstant.TBL_REPORT_MONTHLY_PROGRESS_OBJECT_WISE;
            }
            else
            {
                command.CommandText = DBConstants.ReportDBConstant.KP_TBL_REPORT_MONTHLY_PROGRESS_OBJECT_WISE;
            }

            IDataParameterCollection pparams = command.Parameters;
            IDataParameter parameter;

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@DistrictId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Int);
            parameter.Value = request.DistrictId;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@FinancialYearId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Int);
            parameter.Value = request.FinancialYearId;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@FromDateTime";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.DateTime);
            parameter.Value = request.FromDateTime;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@ToDateTime";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.DateTime);
            parameter.Value = request.ToDateTime;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@SchemeStatusId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.BigInt);
            parameter.Value = request.SchemeStatusId;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@ConstituencyId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Int);
            parameter.Value = request.ConstituencyId;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@FundTypeId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Int);
            parameter.Value = request.FundTypeId;

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

            if (ds.Tables != null && ds.Tables.Count > 1)
            {
                response.CornReportList = new List<CornReport>();

                CornReport objCornReport = new CornReport();

                objCornReport.AccountHeadList = ds.Tables[0].ToList<AccountHead>();

                foreach (AccountHead objAccountHead in objCornReport.AccountHeadList)
                {
                    objAccountHead.FinalCapitalGrant = (objAccountHead.AllocationCapitalAmount + objAccountHead.ReappPositiveCapitalAmount + objAccountHead.ExcessCapitalAmount) - (objAccountHead.SurrenderCapitalAmount + objAccountHead.ReappNegativeCapitalAmount);
                    objAccountHead.FinalRevenueGrant = (objAccountHead.AllocationRevenueAmount + objAccountHead.ReappPositiveRevenueAmount + objAccountHead.ExcessRevenueAmount) - (objAccountHead.SurrenderRevenueAmount + objAccountHead.ReappNegativeRevenueAmount);
                    objAccountHead.FinalForignFundGrant = (objAccountHead.AllocationForignFundAmount + objAccountHead.ReappPositiveForignFundAmount + objAccountHead.ExcessForignFundAmount) - (objAccountHead.SurrenderForignFundAmount + objAccountHead.ReappNegativeForignFundAmount);
                }

                response.CornReportList.Add(objCornReport);

                response.FinancialYear = Convert.ToString(ds.Tables[1].Rows[0][0]);
                response.District = Convert.ToString(ds.Tables[1].Rows[0][1]);
                response.Constituency = Convert.ToString(ds.Tables[1].Rows[0][2]);
            }

            return response;
        }
        public ReportResponse GenerateFunctionMonthlyProgressReport(ReportRequest request)
        {
            ReportResponse response = new ReportResponse();
            IDbConnection mConnection = null;

            mConnection = ProviderFactory.GetConnection(Configuration.ConnectionString, EnumProviders.SQLClient);
            mConnection.Open();

            IDbCommand command = ProviderFactory.GetCommand(EnumProviders.SQLClient);
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = mConnection;

            if (System.Configuration.ConfigurationManager.AppSettings["Domain"] == "PU")
            {
                command.CommandText = DBConstants.ReportDBConstant.TBL_REPORT_MONTHLY_PROGRESS_FUNCTION_WISE;
            }
            else
            {
                command.CommandText = DBConstants.ReportDBConstant.KP_TBL_REPORT_MONTHLY_PROGRESS_FUNCTION_WISE;
            }

            IDataParameterCollection pparams = command.Parameters;
            IDataParameter parameter;

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@DistrictId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Int);
            parameter.Value = request.DistrictId;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@FinancialYearId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Int);
            parameter.Value = request.FinancialYearId;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@FromDateTime";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.DateTime);
            parameter.Value = request.FromDateTime;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@ToDateTime";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.DateTime);
            parameter.Value = request.ToDateTime;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@SchemeStatusId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.BigInt);
            parameter.Value = request.SchemeStatusId;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@ConstituencyId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Int);
            parameter.Value = request.ConstituencyId;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@FundTypeId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Int);
            parameter.Value = request.FundTypeId;

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

            if (ds.Tables != null && ds.Tables.Count > 1)
            {
                response.CornReportList = new List<CornReport>();

                CornReport objCornReport = new CornReport();

                objCornReport.AccountHeadList = ds.Tables[0].ToList<AccountHead>();

                foreach (AccountHead objAccountHead in objCornReport.AccountHeadList)
                {
                    objAccountHead.FinalCapitalGrant = (objAccountHead.AllocationCapitalAmount + objAccountHead.ReappPositiveCapitalAmount + objAccountHead.ExcessCapitalAmount) - (objAccountHead.SurrenderCapitalAmount + objAccountHead.ReappNegativeCapitalAmount);
                    objAccountHead.FinalRevenueGrant = (objAccountHead.AllocationRevenueAmount + objAccountHead.ReappPositiveRevenueAmount + objAccountHead.ExcessRevenueAmount) - (objAccountHead.SurrenderRevenueAmount + objAccountHead.ReappNegativeRevenueAmount);
                    objAccountHead.FinalForignFundGrant = (objAccountHead.AllocationForignFundAmount + objAccountHead.ReappPositiveForignFundAmount + objAccountHead.ExcessForignFundAmount) - (objAccountHead.SurrenderForignFundAmount + objAccountHead.ReappNegativeForignFundAmount);
                }

                response.CornReportList.Add(objCornReport);

                response.FinancialYear = Convert.ToString(ds.Tables[1].Rows[0][0]);
                response.District = Convert.ToString(ds.Tables[1].Rows[0][1]);
                response.Constituency = Convert.ToString(ds.Tables[1].Rows[0][2]);
            }

            return response;
        }
        public ReportResponse GenerateSubSectorSummaryMonthlyReviewReport(ReportRequest request)
        {
            ReportResponse response = new ReportResponse();
            IDbConnection mConnection = null;

            mConnection = ProviderFactory.GetConnection(Configuration.ConnectionString, EnumProviders.SQLClient);
            mConnection.Open();

            IDbCommand command = ProviderFactory.GetCommand(EnumProviders.SQLClient);
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = mConnection;

            if (System.Configuration.ConfigurationManager.AppSettings["Domain"] == "PU")
            {
                command.CommandText = DBConstants.ReportDBConstant.TBL_REPORT_MONTHLY_PROGRESS_REVIEW_SUBSECTOR_SUMMARY;
            }
            else
            {
                command.CommandText = DBConstants.ReportDBConstant.KP_TBL_REPORT_MONTHLY_PROGRESS_REVIEW_SUBSECTOR_SUMMARY;
            }

            IDataParameterCollection pparams = command.Parameters;
            IDataParameter parameter;

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@DistrictId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Int);
            parameter.Value = request.DistrictId;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@FromDateTime";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.DateTime);
            parameter.Value = request.FromDateTime;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@ToDateTime";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.DateTime);
            parameter.Value = request.ToDateTime;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@SchemeStatusId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.BigInt);
            parameter.Value = request.SchemeStatusId;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@ConstituencyId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Int);
            parameter.Value = request.ConstituencyId;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@FundTypeId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Int);
            parameter.Value = request.FundTypeId;

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

            if (ds.Tables != null && ds.Tables.Count > 1)
            {
                response.CornReportList = new List<CornReport>();

                CornReport objCornReport = new CornReport();

                objCornReport.SchemeList = ds.Tables[0].ToList<Scheme>();

                foreach (Scheme objScheme in objCornReport.SchemeList)
                {
                    objScheme.FinalCapitalGrant = (objScheme.AllocationCapitalAmount + objScheme.ReappPositiveCapitalAmount + objScheme.ExcessCapitalAmount) - (objScheme.SurrenderCapitalAmount + objScheme.ReappNegativeCapitalAmount);
                    objScheme.FinalRevenueGrant = (objScheme.AllocationRevenueAmount + objScheme.ReappPositiveRevenueAmount + objScheme.ExcessRevenueAmount) - (objScheme.SurrenderRevenueAmount + objScheme.ReappNegativeRevenueAmount);
                    objScheme.FinalForignFundGrant = (objScheme.AllocationForignFundAmount + objScheme.ReappPositiveForignFundAmount + objScheme.ExcessForignFundAmount) - (objScheme.SurrenderForignFundAmount + objScheme.ReappNegativeForignFundAmount);
                    objScheme.ExcessCapitalAmount = objScheme.ExcessCapitalAmount + objScheme.SurrenderCapitalAmount;
                    objScheme.ExcessRevenueAmount = objScheme.ExcessRevenueAmount + objScheme.SurrenderRevenueAmount;
                    objScheme.ExcessForignFundAmount = objScheme.ExcessForignFundAmount + objScheme.SurrenderForignFundAmount;
                }

                response.CornReportList.Add(objCornReport);

                response.District = Convert.ToString(ds.Tables[1].Rows[0][0]);
                response.Constituency = Convert.ToString(ds.Tables[1].Rows[0][1]);
            }

            return response;
        }
        public ReportResponse GenerateConstituencySummaryMonthlyReviewReport(ReportRequest request)
        {
            ReportResponse response = new ReportResponse();
            IDbConnection mConnection = null;

            mConnection = ProviderFactory.GetConnection(Configuration.ConnectionString, EnumProviders.SQLClient);
            mConnection.Open();

            IDbCommand command = ProviderFactory.GetCommand(EnumProviders.SQLClient);
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = mConnection;

            if (System.Configuration.ConfigurationManager.AppSettings["Domain"] == "PU")
            {
                command.CommandText = DBConstants.ReportDBConstant.TBL_REPORT_MONTHLY_PROGRESS_REVIEW_CONSTITUENCY_SUMMARY;
            }
            else
            {
                command.CommandText = DBConstants.ReportDBConstant.KP_TBL_REPORT_MONTHLY_PROGRESS_REVIEW_CONSTITUENCY_SUMMARY;
            }

            IDataParameterCollection pparams = command.Parameters;
            IDataParameter parameter;

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@DistrictId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Int);
            parameter.Value = request.DistrictId;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@FromDateTime";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.DateTime);
            parameter.Value = request.FromDateTime;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@ToDateTime";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.DateTime);
            parameter.Value = request.ToDateTime;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@SchemeStatusId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.BigInt);
            parameter.Value = request.SchemeStatusId;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@ConstituencyId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Int);
            parameter.Value = request.ConstituencyId;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@FundTypeId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Int);
            parameter.Value = request.FundTypeId;

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

            if (ds.Tables != null && ds.Tables.Count > 1)
            {
                response.CornReportList = new List<CornReport>();

                CornReport objCornReport = new CornReport();

                objCornReport.SchemeList = ds.Tables[0].ToList<Scheme>();

                foreach (Scheme objScheme in objCornReport.SchemeList)
                {
                    objScheme.FinalCapitalGrant = (objScheme.AllocationCapitalAmount + objScheme.ReappPositiveCapitalAmount + objScheme.ExcessCapitalAmount) - (objScheme.SurrenderCapitalAmount + objScheme.ReappNegativeCapitalAmount);
                    objScheme.FinalRevenueGrant = (objScheme.AllocationRevenueAmount + objScheme.ReappPositiveRevenueAmount + objScheme.ExcessRevenueAmount) - (objScheme.SurrenderRevenueAmount + objScheme.ReappNegativeRevenueAmount);
                    objScheme.FinalForignFundGrant = (objScheme.AllocationForignFundAmount + objScheme.ReappPositiveForignFundAmount + objScheme.ExcessForignFundAmount) - (objScheme.SurrenderForignFundAmount + objScheme.ReappNegativeForignFundAmount);
                    objScheme.ExcessCapitalAmount = objScheme.ExcessCapitalAmount + objScheme.SurrenderCapitalAmount;
                    objScheme.ExcessRevenueAmount = objScheme.ExcessRevenueAmount + objScheme.SurrenderRevenueAmount;
                    objScheme.ExcessForignFundAmount = objScheme.ExcessForignFundAmount + objScheme.SurrenderForignFundAmount;
                }

                response.CornReportList.Add(objCornReport);

                response.District = Convert.ToString(ds.Tables[1].Rows[0][0]);
                response.Constituency = Convert.ToString(ds.Tables[1].Rows[0][1]);
            }

            return response;
        }
        public ReportResponse GenerateProjectLedgerReport(ReportRequest request)
        {
            ReportResponse response = new ReportResponse();
            IDbConnection mConnection = null;

            mConnection = ProviderFactory.GetConnection(Configuration.ConnectionString, EnumProviders.SQLClient);
            mConnection.Open();

            IDbCommand command = ProviderFactory.GetCommand(EnumProviders.SQLClient);
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = DBConstants.ReportDBConstant.TBL_REPORT_PROJECT_LEDGER;
            command.Connection = mConnection;

            IDataParameterCollection pparams = command.Parameters;
            IDataParameter parameter;

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@SchemeId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Int);
            parameter.Value = request.SchemeId;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@FundTypeId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Int);
            parameter.Value = request.FundTypeId;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@FromDateTime";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.DateTime);
            parameter.Value = request.FromDateTime;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@ToDateTime";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.DateTime);
            parameter.Value = request.ToDateTime;

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

            if (ds.Tables != null && ds.Tables.Count > 1)
            {
                response.CornReportList = new List<CornReport>();

                CornReport objCornReport = new CornReport();
                decimal finalGrant = 0, balance = 0, releaseBalance = 0;

                objCornReport.SchemeList = ds.Tables[0].ToList<Scheme>();

                foreach (Scheme objScheme in objCornReport.SchemeList)
                {
                    switch (objScheme.FundId)
                    {
                        case 1:
                            objScheme.BudgetAllocation = objScheme.Amount;

                            break;
                        case 2:
                            objScheme.Supplementary = objScheme.Amount;

                            break;
                        case 3:
                            objScheme.ReappPositive = objScheme.Amount;

                            break;
                        case 4:
                            objScheme.ReappNegative = objScheme.Amount;

                            break;
                        case 5:
                            objScheme.Excess = objScheme.Amount;

                            break;
                        case 6:
                            objScheme.Surrender = objScheme.Amount;

                            break;
                        case 7:
                            objScheme.Release = objScheme.Amount;

                            break;
                        case 8:
                            objScheme.Expenditure = objScheme.Amount;

                            break;
                        default:
                            break;
                    }

                    finalGrant += (objScheme.BudgetAllocation + objScheme.Supplementary + objScheme.ReappPositive + objScheme.Excess) - (objScheme.Surrender + objScheme.ReappNegative);
                    balance += (objScheme.BudgetAllocation + objScheme.Supplementary + objScheme.ReappPositive + objScheme.Excess) - (objScheme.ReappNegative + objScheme.Surrender + objScheme.Expenditure);
                    releaseBalance += objScheme.Release - objScheme.Expenditure;

                    objScheme.Id = request.SchemeId;
                    objScheme.FinalGrant = finalGrant;
                    objScheme.Balance = balance;
                    objScheme.ReleaseBalance = releaseBalance;
                }

                response.CornReportList.Add(objCornReport);

                response.Title = Convert.ToString(ds.Tables[1].Rows[0][0]);
                response.FundType = Convert.ToString(ds.Tables[1].Rows[0][1]);
            }

            return response;
        }
        public ReportResponse GenerateADPSummaryReport(ReportRequest request)
        {
            ReportResponse response = new ReportResponse();
            IDbConnection mConnection = null;

            mConnection = ProviderFactory.GetConnection(Configuration.ConnectionString, EnumProviders.SQLClient);
            mConnection.Open();

            IDbCommand command = ProviderFactory.GetCommand(EnumProviders.SQLClient);
            command.CommandType = CommandType.StoredProcedure;

            if (request.ReportTypeId == 1)
            {
                command.CommandText = DBConstants.ReportDBConstant.TBL_REPORT_ADP_SUBSECTOR_SUMMARY;
            }
            else if (request.ReportTypeId == 2)
            {
                command.CommandText = DBConstants.ReportDBConstant.TBL_REPORT_ADP_FUNCTION_SUMMARY;
            }
            else if (request.ReportTypeId == 3)
            {
                command.CommandText = DBConstants.ReportDBConstant.TBL_REPORT_ADP_STATUS_SUMMARY;
            }

            command.Connection = mConnection;

            IDataParameterCollection pparams = command.Parameters;
            IDataParameter parameter;

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@FinancialYearId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Int);
            parameter.Value = request.FinancialYearId;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@SchemeStatusId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.BigInt);
            parameter.Value = request.SchemeStatusId;

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

            if (ds.Tables != null && ds.Tables.Count > 1)
            {
                response.CornReportList = new List<CornReport>();

                CornReport objCornReport = new CornReport();

                objCornReport.CornObjectList = ds.Tables[0].ToList<CornObject>();

                foreach (CornObject objCornObject in objCornReport.CornObjectList)
                {
                    if (request.ReportTypeId == 1)
                    {
                        objCornObject.TotalAllocationGroupBy = objCornReport.CornObjectList.Sum(p => (p.LocalAllocation + p.ForeignAllocation));
                    }
                    else if (request.ReportTypeId == 2)
                    {
                        objCornObject.TotalAllocationGroupBy = objCornReport.CornObjectList.Sum(p => (p.LocalAllocation + p.ForeignAllocation));
                    }
                    else if (request.ReportTypeId == 3)
                    {
                        objCornObject.TotalAllocationGroupBy = objCornReport.CornObjectList.Sum(p => (p.OnGoingAllocation + p.NewAllocation));
                    }
                }

                response.CornReportList.Add(objCornReport);

                response.FinancialYear = Convert.ToString(ds.Tables[1].Rows[0][0]);
                response.Year = Convert.ToString(ds.Tables[1].Rows[0][1]);
            }

            return response;
        }
        public ReportResponse GenerateADPComparativeReport(ReportRequest request)
        {
            ReportResponse response = new ReportResponse();
            IDbConnection mConnection = null;

            mConnection = ProviderFactory.GetConnection(Configuration.ConnectionString, EnumProviders.SQLClient);
            mConnection.Open();

            IDbCommand command = ProviderFactory.GetCommand(EnumProviders.SQLClient);
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = DBConstants.ReportDBConstant.TBL_REPORT_ADP_COMPARATIVE;
            command.Connection = mConnection;

            IDataParameterCollection pparams = command.Parameters;
            IDataParameter parameter;

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@FinancialYearId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Int);
            parameter.Value = request.FinancialYearId;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@SchemeStatusId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.BigInt);
            parameter.Value = request.SchemeStatusId;

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

            if (ds.Tables != null && ds.Tables.Count > 1)
            {
                response.CornReportList = new List<CornReport>();

                CornReport objCornReport = new CornReport();

                objCornReport.CornObjectList = ds.Tables[0].ToList<CornObject>();

                foreach (CornObject objCornObject in objCornReport.CornObjectList)
                {
                    objCornObject.TotalNumber = objCornReport.CornObjectList.Sum(p => (p.PreviousYearProjectCount + p.YearProjectCount));
                    objCornObject.TotalBudgetEstimateGroupBy = objCornReport.CornObjectList.Sum(p => (p.PreviousYearBudgetEstimate + p.YearBudgetEstimate));
                    objCornObject.TotalAllocationGroupBy = objCornReport.CornObjectList.Sum(p => (p.PreviousYearAllocation + p.YearAllocation));
                }

                response.CornReportList.Add(objCornReport);

                response.PreviousFinancialYear = Convert.ToString(ds.Tables[1].Rows[0][0]);
                response.FinancialYear = Convert.ToString(ds.Tables[1].Rows[0][1]);
            }

            return response;
        }
        public ReportResponse GenerateADPHistoricalTrendReport(ReportRequest request)
        {
            ReportResponse response = new ReportResponse();
            IDbConnection mConnection = null;

            mConnection = ProviderFactory.GetConnection(Configuration.ConnectionString, EnumProviders.SQLClient);
            mConnection.Open();

            IDbCommand command = ProviderFactory.GetCommand(EnumProviders.SQLClient);
            command.CommandType = CommandType.StoredProcedure;

            if (request.ReportTypeId == 1)
            {
                command.CommandText = DBConstants.ReportDBConstant.TBL_REPORT_ADP_SUBSECTOR_HISTORICAL_TREND;
            }
            else if (request.ReportTypeId == 2)
            {
                command.CommandText = DBConstants.ReportDBConstant.TBL_REPORT_ADP_FUNCTION_HISTORICAL_TREND;
            }
            else if (request.ReportTypeId == 3)
            {
                command.CommandText = DBConstants.ReportDBConstant.TBL_REPORT_ADP_DETAILOBJECT_HISTORICAL_TREND;
            }

            command.Connection = mConnection;

            IDataParameterCollection pparams = command.Parameters;
            IDataParameter parameter;

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@FinancialYearId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Int);
            parameter.Value = request.FinancialYearId;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@SchemeStatusId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.BigInt);
            parameter.Value = request.SchemeStatusId;

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

            if (ds.Tables != null && ds.Tables.Count > 1)
            {
                response.CornReportList = new List<CornReport>();

                CornReport objCornReport = new CornReport();

                objCornReport.CornObjectList = ds.Tables[0].ToList<CornObject>();

                response.CornReportList.Add(objCornReport);

                response.PreviousFinancialYear1 = Convert.ToString(ds.Tables[1].Rows[0][0]);
                response.PreviousFinancialYear2 = Convert.ToString(ds.Tables[1].Rows[0][1]);
                response.PreviousFinancialYear3 = Convert.ToString(ds.Tables[1].Rows[0][2]);
                response.PreviousFinancialYear4 = Convert.ToString(ds.Tables[1].Rows[0][3]);
                response.FinancialYear = Convert.ToString(ds.Tables[1].Rows[0][4]);
            }

            return response;
        }
        public ReportResponse GenerateADPAbstractReport(ReportRequest request)
        {
            ReportResponse response = new ReportResponse();
            IDbConnection mConnection = null;

            mConnection = ProviderFactory.GetConnection(Configuration.ConnectionString, EnumProviders.SQLClient);
            mConnection.Open();

            IDbCommand command = ProviderFactory.GetCommand(EnumProviders.SQLClient);
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = DBConstants.ReportDBConstant.TBL_REPORT_ADP_ABSTRACT;
            command.Connection = mConnection;

            IDataParameterCollection pparams = command.Parameters;
            IDataParameter parameter;

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@FinancialYearId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Int);
            parameter.Value = request.FinancialYearId;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@SchemeStatusId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.BigInt);
            parameter.Value = request.SchemeStatusId;

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

            if (ds.Tables != null && ds.Tables.Count > 1)
            {
                response.CornReportList = new List<CornReport>();

                CornReport objCornReport = new CornReport();

                objCornReport.CornObjectList = ds.Tables[0].ToList<CornObject>();

                response.CornReportList.Add(objCornReport);

                response.FinancialYear = Convert.ToString(ds.Tables[1].Rows[0][0]);
                response.Year = Convert.ToString(ds.Tables[1].Rows[0][1]);
                response.PreviousYear = Convert.ToString(ds.Tables[1].Rows[0][2]);
            }

            return response;
        }
        public ReportResponse GenerateADPDetailReport(ReportRequest request)
        {
            ReportResponse response = new ReportResponse();
            IDbConnection mConnection = null;

            mConnection = ProviderFactory.GetConnection(Configuration.ConnectionString, EnumProviders.SQLClient);
            mConnection.Open();

            IDbCommand command = ProviderFactory.GetCommand(EnumProviders.SQLClient);
            command.CommandType = CommandType.StoredProcedure;

            if (request.ReportTypeId == 1)
            {
                command.CommandText = DBConstants.ReportDBConstant.TBL_REPORT_ADP_SUBSECTOR_DETAIL;
            }
            else if (request.ReportTypeId == 2)
            {
                command.CommandText = DBConstants.ReportDBConstant.TBL_REPORT_ADP_DETAILOBJECT_DETAIL;
            }
            else if (request.ReportTypeId == 3)
            {
                command.CommandText = DBConstants.ReportDBConstant.TBL_REPORT_ADP_FUNCTION_DETAIL;
            }

            command.Connection = mConnection;

            IDataParameterCollection pparams = command.Parameters;
            IDataParameter parameter;

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@FinancialYearId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.Int);
            parameter.Value = request.FinancialYearId;

            pparams.Add(parameter);

            parameter = ProviderFactory.GetParameter(EnumProviders.SQLClient);
            parameter.ParameterName = "@SchemeStatusId";
            parameter.DbType = ProviderFactory.GetDBType(EnumProviders.SQLClient, EnumDBTypes.BigInt);
            parameter.Value = request.SchemeStatusId;

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

            if (ds.Tables != null && ds.Tables.Count > 2)
            {
                response.CornReportList = new List<CornReport>();

                CornReport objCornReport = new CornReport();

                objCornReport.CornObjectList = ds.Tables[0].ToList<CornObject>();

                List<CornObject> ChildCornObjectList = ds.Tables[1].ToList<CornObject>();

                response.FinancialYear = Convert.ToString(ds.Tables[2].Rows[0][0]);

                if (request.ReportTypeId == 1)
                {
                    foreach (CornObject objCornObject in objCornReport.CornObjectList)
                    {
                        objCornObject.Child1CornObjectList = (from p in ChildCornObjectList
                                                              where p.ParentId == objCornObject.Id
                                                              && p.CategoryId == 1
                                                              select p).ToList();
                        objCornObject.Child2CornObjectList = (from p in ChildCornObjectList
                                                              where p.ParentId == objCornObject.Id
                                                              && p.CategoryId == 2
                                                              select p).ToList();

                        objCornObject.LocalBudgetEstimate = objCornObject.Child1CornObjectList.Sum(p => p.LocalBudgetEstimate) +
                            objCornObject.Child2CornObjectList.Sum(p => p.LocalBudgetEstimate);
                        objCornObject.ForeignBudgetEstimate = objCornObject.Child1CornObjectList.Sum(p => p.ForeignBudgetEstimate) +
                            objCornObject.Child2CornObjectList.Sum(p => p.ForeignBudgetEstimate);
                        objCornObject.ExpenseUpToJune = objCornObject.Child1CornObjectList.Sum(p => p.ExpenseUpToJune) +
                            objCornObject.Child2CornObjectList.Sum(p => p.ExpenseUpToJune);
                        objCornObject.CapitalAllocation = objCornObject.Child1CornObjectList.Sum(p => p.CapitalAllocation) +
                            objCornObject.Child2CornObjectList.Sum(p => p.CapitalAllocation);
                        objCornObject.RevenueAllocation = objCornObject.Child1CornObjectList.Sum(p => p.RevenueAllocation) +
                            objCornObject.Child2CornObjectList.Sum(p => p.RevenueAllocation);
                        objCornObject.ForeignAllocation = objCornObject.Child1CornObjectList.Sum(p => p.ForeignAllocation) +
                            objCornObject.Child2CornObjectList.Sum(p => p.ForeignAllocation);
                    }

                    objCornReport.CornObjectList.RemoveAll(p => p.Child1CornObjectList.Count <= 0 && p.Child2CornObjectList.Count <= 0);

                    response.Year = Convert.ToString(ds.Tables[2].Rows[0][1]);
                    response.PreviousYear = Convert.ToString(ds.Tables[2].Rows[0][2]);
                }
                else if (request.ReportTypeId == 2 || request.ReportTypeId == 3)
                {
                    foreach (CornObject objCornObject in objCornReport.CornObjectList)
                    {
                        objCornObject.Child1CornObjectList = (from p in ChildCornObjectList
                                                              where p.ParentId == objCornObject.Id
                                                              select p).ToList();
                        objCornObject.LocalAllocation = objCornObject.Child1CornObjectList.Sum(p => p.LocalAllocation);
                        objCornObject.ForeignAllocation = objCornObject.Child1CornObjectList.Sum(p => p.ForeignAllocation);
                    }

                    foreach (CornObject objCornObject in objCornReport.CornObjectList)
                    {
                        foreach (CornObject objChild1CornObject in objCornObject.Child1CornObjectList)
                        {
                            objChild1CornObject.TotalAllocationGroupBy = objCornReport.CornObjectList.Sum(p => (p.LocalAllocation + p.ForeignAllocation));
                        }
                    }

                    objCornReport.CornObjectList.RemoveAll(p => p.LocalAllocation <= 0 && p.ForeignAllocation <= 0);
                }

                response.CornReportList.Add(objCornReport);
            }

            return response;
        }
    }
}
