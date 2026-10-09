<%@ WebHandler Language="C#" Class="DashboardHandler" %>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.SessionState;
using System.Web.Script.Serialization;
using CORNCommon;
using CORNBusinessLayer;
using CORNDataAccessLayer.Request;
using CORNDataAccessLayer.Response;
using CORNDataAccessLayer;

public class DashboardHandler : IHttpHandler, IRequiresSessionState
{
    public HttpApplication HttpApplicationInstance { get; private set; }
    public HttpRequest Request { get; set; }
    public HttpResponse Response { get; set; }
    public JavaScriptSerializer JSONSerializer { get; set; }
    public ResponseData ServerResponse { get; set; }
    protected HttpSessionState HttpSession { get; set; }

    public bool IsReusable
    {
        get
        {
            return false;
        }
    }

    public void ProcessRequest(HttpContext context)
    {
        try
        {
            HttpApplicationInstance = context.ApplicationInstance;
            HttpSession = context.Session;
            Request = context.Request;
            Response = context.Response;
            Response.ContentType = "application/json";
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            JSONSerializer = new JavaScriptSerializer();
            JSONSerializer.MaxJsonLength = 2147483647;
            ServerResponse = new ResponseData();

            string status = Enums.ResponseStatusEnum.SessionExpired.ToString();
            string message = "User session is expired.";
            string data = string.Empty;
            bool exceptionExists = true;

            if (UserCommonInfo.SessionExists)
            {
                MethodInfo method = this.GetType().GetMethod(Request["method"]);

                if (method != null)
                {
                    exceptionExists = false;

                    method.Invoke(this, new object[] { });
                }
                else
                {
                    status = Enums.ResponseStatusEnum.Error.ToString();
                    message = "Invalid request.";
                }
            }

            if (exceptionExists)
            {
                Response.Write(GetResponse(status, message, data));
                HttpApplicationInstance.CompleteRequest();
            }
        }
        catch (Exception ex)
        {
            Response.Write(GetResponse(Enums.ResponseStatusEnum.Error.ToString(), ex.Message));
            HttpApplicationInstance.CompleteRequest();
        }
    }
    public string GetResponse(string status, string message)
    {
        ServerResponse.Status = status;
        ServerResponse.Message = message;

        return JSONSerializer.Serialize(ServerResponse);
    }
    public string GetResponse(string status, string message, object data)
    {
        ServerResponse.Status = status;
        ServerResponse.Message = message;
        ServerResponse.Data = data;

        return JSONSerializer.Serialize(ServerResponse);
    }

    public void GenerateFundWiseChart()
    {
        try
        {
            ChartRequest request = new ChartRequest();
            ChartManager manager = new ChartManager();

            request.InstituteId = 0;
            request.FinancialYearId = Convert.ToInt32(Request.Form["FYId"]);
            request.ToDate = Convert.ToDateTime(Request.Form["ToDate"]);
            request.UserId = Convert.ToInt64(HttpSession["UserId"]);

            ChartResponse response = manager.GenerateFundWiseChart(request);
            string status = Enums.ResponseStatusEnum.Success.ToString();
            string message = "Fund Chart is generated successfully.";
            List<object> lstBEChart = new List<object>();
            List<object> lstEChart = new List<object>();
            Scheme objCapital = response.SchemeList.FirstOrDefault(p => p.FundId == 1);
            Scheme objRevenue = response.SchemeList.FirstOrDefault(p => p.FundId == 2);
            decimal totalBudgetEstimate = objCapital.BudgetEstimate + objRevenue.BudgetEstimate;
            decimal totalExpenditure = objCapital.Expenditure + objRevenue.Expenditure;

            lstBEChart.Add(
                new
                {
                    name = objCapital.FundTitle,
                    y = totalBudgetEstimate <= 0 ? 0 : Convert.ToSingle(((100 / totalBudgetEstimate) * objCapital.BudgetEstimate))
                });
            lstBEChart.Add(
                new
                {
                    name = objRevenue.FundTitle,
                    y = totalBudgetEstimate <= 0 ? 0 : Convert.ToSingle(((100 / totalBudgetEstimate) * objRevenue.BudgetEstimate))
                });

            lstEChart.Add(
                new
                {
                    name = objCapital.FundTitle,
                    y = totalExpenditure <= 0 ? 0 : Convert.ToSingle(((100 / totalExpenditure) * objCapital.Expenditure))
                });
            lstEChart.Add(
                new
                {
                    name = objRevenue.FundTitle,
                    y = totalExpenditure <= 0 ? 0 : Convert.ToSingle(((100 / totalExpenditure) * objRevenue.Expenditure))
                });

            decimal release = response.SchemeList.Sum(p => p.Release);
            decimal expenditure = response.SchemeList.Sum(p => p.Expenditure);
            decimal allocation = response.SchemeList.Sum(p => p.ADPAllocation) + response.SchemeList.Sum(p => p.Supplementary);
            decimal finalGrant = allocation + response.SchemeList.Sum(p => p.ReappPositive) - response.SchemeList.Sum(p => p.ReappNegative) +
                    response.SchemeList.Sum(p => p.Excess);
            float perRA = Convert.ToSingle(allocation <= 0 ? 0 : ((release / allocation) * 100));
            float perEA = Convert.ToSingle(allocation <= 0 ? 0 : ((expenditure / allocation) * 100));
            float perRFG = Convert.ToSingle(finalGrant <= 0 ? 0 : ((release / finalGrant) * 100));
            float perEFG = Convert.ToSingle(finalGrant <= 0 ? 0 : ((expenditure / finalGrant) * 100));

            var result = new
            {
                fyTitle = response.FinancialYear,
                dataBE = lstBEChart,
                dataE = lstEChart,
                perRA = perRA.ToString("0.00"),
                perEA = perEA.ToString("0.00"),
                perRFG = perRFG.ToString("0.00"),
                perEFG = perEFG.ToString("0.00")
            };

            Response.Write(GetResponse(status, message, result));
        }
        catch (Exception ex)
        {
            Response.Write(GetResponse(Enums.ResponseStatusEnum.Error.ToString(), ex.Message));
        }
        finally
        {
            HttpApplicationInstance.CompleteRequest();
        }
    }
    public void GenerateStatusWiseChart()
    {
        try
        {
            ChartRequest request = new ChartRequest();
            ChartManager manager = new ChartManager();

            request.InstituteId = 0;
            request.FinancialYearId = Convert.ToInt32(Request.Form["FYId"]);
            request.ToDate = Convert.ToDateTime(Request.Form["ToDate"]);
            request.UserId = Convert.ToInt64(HttpSession["UserId"]);

            ChartResponse response = manager.GenerateStatusWiseChart(request);
            string status = Enums.ResponseStatusEnum.Success.ToString();
            string message = "Scheme Status Chart is generated successfully.";
            List<object> lstObject = new List<object>();
            List<string> lstCategory = new List<string>();
            List<object> lstBEChart = new List<object>();
            List<object> lstEChart = new List<object>();
            List<object> lstBENOChart = new List<object>();
            List<object> lstENOChart = new List<object>();
            decimal totalBudgetEstimate = response.SchemeList.Sum(p => p.BudgetEstimate);
            decimal totalExpenditure = response.SchemeList.Sum(p => p.Expenditure);

            foreach (Scheme objScheme in response.SchemeList)
            {
                lstCategory.Add(objScheme.CategoryTitle);

                var objBEChart = new
                {
                    name = objScheme.CategoryTitle,
                    y = totalBudgetEstimate <= 0 ? 0 : Convert.ToSingle(((100 / totalBudgetEstimate) * objScheme.BudgetEstimate))
                };

                var objEChart = new
                {
                    name = objScheme.CategoryTitle,
                    y = totalExpenditure <= 0 ? 0 : Convert.ToSingle(((100 / totalExpenditure) * objScheme.Expenditure))
                };

                lstBEChart.Add(objBEChart);
                lstEChart.Add(objEChart);

                if (objScheme.CategoryId == 1 || objScheme.CategoryId == 2)
                {
                    lstBENOChart.Add(objBEChart);
                    lstENOChart.Add(objEChart);
                }
            }

            for (int i = 1; i <= 6; i++)
            {
                switch (i)
                {
                    case 1:
                        var BudgetEstimate = new
                        {
                            type = "column",
                            name = "Budget Estimate " + response.FinancialYear,
                            data = new List<decimal>(),
                            tooltip = new { valueSuffix = " Millions" }
                        };

                        foreach (string category in lstCategory)
                        {
                            Scheme objScheme = response.SchemeList.FirstOrDefault(p => p.CategoryTitle == category);

                            BudgetEstimate.data.Add((objScheme.BudgetEstimate / 1000000));
                        }

                        lstObject.Add(BudgetEstimate);

                        break;
                    case 2:
                        var FinalGrant = new
                        {
                            type = "column",
                            name = "Final Grant",
                            data = new List<decimal>(),
                            tooltip = new { valueSuffix = " Millions" }
                        };

                        foreach (string category in lstCategory)
                        {
                            Scheme objScheme = response.SchemeList.FirstOrDefault(p => p.CategoryTitle == category);
                            decimal fg = objScheme.ADPAllocation + objScheme.Supplementary + objScheme.ReappPositive - objScheme.ReappNegative + objScheme.Excess;

                            FinalGrant.data.Add((fg / 1000000));
                        }

                        lstObject.Add(FinalGrant);

                        break;
                    case 3:
                        var Release = new
                        {
                            type = "column",
                            name = "Release",
                            data = new List<decimal>(),
                            tooltip = new { valueSuffix = " Millions" }
                        };

                        foreach (string category in lstCategory)
                        {
                            Scheme objScheme = response.SchemeList.FirstOrDefault(p => p.CategoryTitle == category);

                            Release.data.Add((objScheme.Release / 1000000));
                        }

                        lstObject.Add(Release);

                        break;
                    case 4:
                        var Expenditure = new
                        {
                            type = "column",
                            name = "Expenditure",
                            data = new List<decimal>(),
                            tooltip = new { valueSuffix = " Millions" }
                        };

                        foreach (string category in lstCategory)
                        {
                            Scheme objScheme = response.SchemeList.FirstOrDefault(p => p.CategoryTitle == category);

                            Expenditure.data.Add((objScheme.Expenditure / 1000000));
                        }

                        lstObject.Add(Expenditure);

                        break;
                    case 5:
                        var UtilizationFG = new
                        {
                            type = "spline",
                            yAxis = 1,
                            name = "%age Utilization/FG",
                            data = new List<float>(),
                            marker = new { lineWidth = 2 },
                            tooltip = new { valueSuffix = "%" }
                        };

                        foreach (string category in lstCategory)
                        {
                            Scheme objScheme = response.SchemeList.FirstOrDefault(p => p.CategoryTitle == category);
                            decimal fg = objScheme.ADPAllocation + objScheme.Supplementary + objScheme.ReappPositive - objScheme.ReappNegative + objScheme.Excess;

                            UtilizationFG.data.Add(Convert.ToSingle(fg <= 0 ? 0 : (objScheme.Expenditure / fg)));
                        }

                        lstObject.Add(UtilizationFG);

                        break;
                    case 6:
                        var UtilizationBE = new
                        {
                            type = "spline",
                            yAxis = 1,
                            name = "%age Utilization/BE",
                            data = new List<float>(),
                            marker = new { lineWidth = 2 },
                            tooltip = new { valueSuffix = "%" }
                        };

                        foreach (string category in lstCategory)
                        {
                            Scheme objScheme = response.SchemeList.FirstOrDefault(p => p.CategoryTitle == category);

                            UtilizationBE.data.Add(Convert.ToSingle(objScheme.BudgetEstimate <= 0 ? 0 : (objScheme.Expenditure / objScheme.BudgetEstimate)));
                        }

                        lstObject.Add(UtilizationBE);

                        break;
                    default:
                        break;
                }
            }

            decimal release = response.SchemeList.Sum(p => p.Release);
            decimal expenditure = response.SchemeList.Sum(p => p.Expenditure);
            decimal allocation = response.SchemeList.Sum(p => p.ADPAllocation) + response.SchemeList.Sum(p => p.Supplementary);
            decimal finalGrant = allocation + response.SchemeList.Sum(p => p.ReappPositive) - response.SchemeList.Sum(p => p.ReappNegative) +
                    response.SchemeList.Sum(p => p.Excess);
            float perRA = Convert.ToSingle(allocation <= 0 ? 0 : ((release / allocation) * 100));
            float perEA = Convert.ToSingle(allocation <= 0 ? 0 : ((expenditure / allocation) * 100));
            float perRFG = Convert.ToSingle(finalGrant <= 0 ? 0 : ((release / finalGrant) * 100));
            float perEFG = Convert.ToSingle(finalGrant <= 0 ? 0 : ((expenditure / finalGrant) * 100));

            var result = new
            {
                fyTitle = response.FinancialYear,
                categories = lstCategory,
                series = lstObject,
                dataBE = lstBEChart,
                dataE = lstEChart,
                dataBENO = lstBENOChart,
                dataENO = lstENOChart,
                perRA = perRA.ToString("0.00"),
                perEA = perEA.ToString("0.00"),
                perRFG = perRFG.ToString("0.00"),
                perEFG = perEFG.ToString("0.00")
            };

            Response.Write(GetResponse(status, message, result));
        }
        catch (Exception ex)
        {
            Response.Write(GetResponse(Enums.ResponseStatusEnum.Error.ToString(), ex.Message));
        }
        finally
        {
            HttpApplicationInstance.CompleteRequest();
        }
    }
    public void GenerateSubSectorWiseChart()
    {
        try
        {
            ChartRequest request = new ChartRequest();
            ChartManager manager = new ChartManager();

            request.InstituteId = 0;
            request.FinancialYearId = Convert.ToInt32(Request.Form["FYId"]);
            request.ToDate = Convert.ToDateTime(Request.Form["ToDate"]);
            request.UserId = Convert.ToInt64(HttpSession["UserId"]);

            ChartResponse response = manager.GenerateSubSectorWiseChart(request);
            string status = Enums.ResponseStatusEnum.Success.ToString();
            string message = "Sub Sector Chart is generated successfully.";
            List<object> lstObject = new List<object>();
            List<string> lstSubSectorWise = new List<string>();
            List<object> lstBEChart = new List<object>();
            List<object> lstEChart = new List<object>();
            decimal totalBudgetEstimate = response.SchemeList.Sum(p => p.BudgetEstimate);
            decimal totalExpenditure = response.SchemeList.Sum(p => p.Expenditure);

            foreach (Scheme objScheme in response.SchemeList)
            {
                lstSubSectorWise.Add(objScheme.Title);

                var objBEChart = new
                {
                    name = objScheme.Title,
                    y = totalBudgetEstimate <= 0 ? 0 : Convert.ToSingle(((100 / totalBudgetEstimate) * objScheme.BudgetEstimate))
                };

                var objEChart = new
                {
                    name = objScheme.Title,
                    y = totalExpenditure <= 0 ? 0 : Convert.ToSingle(((100 / totalExpenditure) * objScheme.Expenditure))
                };

                lstBEChart.Add(objBEChart);
                lstEChart.Add(objEChart);
            }

            for (int i = 1; i <= 6; i++)
            {
                switch (i)
                {
                    case 1:
                        var BudgetEstimate = new
                        {
                            type = "column",
                            name = "Budget Estimate " + response.FinancialYear,
                            data = new List<decimal>(),
                            tooltip = new { valueSuffix = " Millions" }
                        };

                        foreach (string subSector in lstSubSectorWise)
                        {
                            Scheme objScheme = response.SchemeList.FirstOrDefault(p => p.Title == subSector);

                            BudgetEstimate.data.Add((objScheme.BudgetEstimate / 1000000));
                        }

                        lstObject.Add(BudgetEstimate);

                        break;
                    case 2:
                        var FinalGrant = new
                        {
                            type = "column",
                            name = "Final Grant",
                            data = new List<decimal>(),
                            tooltip = new { valueSuffix = " Millions" }
                        };

                        foreach (string subSector in lstSubSectorWise)
                        {
                            Scheme objScheme = response.SchemeList.FirstOrDefault(p => p.Title == subSector);
                            decimal fg = objScheme.ADPAllocation + objScheme.Supplementary + objScheme.ReappPositive - objScheme.ReappNegative + objScheme.Excess;

                            FinalGrant.data.Add((fg / 1000000));
                        }

                        lstObject.Add(FinalGrant);

                        break;
                    case 3:
                        var Release = new
                        {
                            type = "column",
                            name = "Release",
                            data = new List<decimal>(),
                            tooltip = new { valueSuffix = " Millions" }
                        };

                        foreach (string subSector in lstSubSectorWise)
                        {
                            Scheme objScheme = response.SchemeList.FirstOrDefault(p => p.Title == subSector);

                            Release.data.Add((objScheme.Release / 1000000));
                        }

                        lstObject.Add(Release);

                        break;
                    case 4:
                        var Expenditure = new
                        {
                            type = "column",
                            name = "Expenditure",
                            data = new List<decimal>(),
                            tooltip = new { valueSuffix = " Millions" }
                        };

                        foreach (string subSector in lstSubSectorWise)
                        {
                            Scheme objScheme = response.SchemeList.FirstOrDefault(p => p.Title == subSector);

                            Expenditure.data.Add((objScheme.Expenditure / 1000000));
                        }

                        lstObject.Add(Expenditure);

                        break;
                    case 5:
                        var UtilizationFG = new
                        {
                            type = "spline",
                            yAxis = 1,
                            name = "%age Utilization/FG",
                            data = new List<float>(),
                            marker = new { lineWidth = 2 },
                            tooltip = new { valueSuffix = "%" }
                        };

                        foreach (string subSector in lstSubSectorWise)
                        {
                            Scheme objScheme = response.SchemeList.FirstOrDefault(p => p.Title == subSector);
                            decimal fg = objScheme.ADPAllocation + objScheme.Supplementary + objScheme.ReappPositive - objScheme.ReappNegative + objScheme.Excess;

                            UtilizationFG.data.Add(Convert.ToSingle(fg <= 0 ? 0 : (objScheme.Expenditure / fg)));
                        }

                        lstObject.Add(UtilizationFG);

                        break;
                    case 6:
                        var UtilizationBE = new
                        {
                            type = "spline",
                            yAxis = 1,
                            name = "%age Utilization/BE",
                            data = new List<float>(),
                            marker = new { lineWidth = 2 },
                            tooltip = new { valueSuffix = "%" }
                        };

                        foreach (string subSector in lstSubSectorWise)
                        {
                            Scheme objScheme = response.SchemeList.FirstOrDefault(p => p.Title == subSector);

                            UtilizationBE.data.Add(Convert.ToSingle(objScheme.BudgetEstimate <= 0 ? 0 : (objScheme.Expenditure / objScheme.BudgetEstimate)));
                        }

                        lstObject.Add(UtilizationBE);

                        break;
                    default:
                        break;
                }
            }

            decimal release = response.SchemeList.Sum(p => p.Release);
            decimal expenditure = response.SchemeList.Sum(p => p.Expenditure);
            decimal allocation = response.SchemeList.Sum(p => p.ADPAllocation) + response.SchemeList.Sum(p => p.Supplementary);
            decimal finalGrant = allocation + response.SchemeList.Sum(p => p.ReappPositive) - response.SchemeList.Sum(p => p.ReappNegative) +
                    response.SchemeList.Sum(p => p.Excess);
            float perRA = Convert.ToSingle(allocation <= 0 ? 0 : ((release / allocation) * 100));
            float perEA = Convert.ToSingle(allocation <= 0 ? 0 : ((expenditure / allocation) * 100));
            float perRFG = Convert.ToSingle(finalGrant <= 0 ? 0 : ((release / finalGrant) * 100));
            float perEFG = Convert.ToSingle(finalGrant <= 0 ? 0 : ((expenditure / finalGrant) * 100));

            var result = new
            {
                fyTitle = response.FinancialYear,
                categories = lstSubSectorWise,
                series = lstObject,
                dataBE = lstBEChart,
                dataE = lstEChart,
                perRA = perRA.ToString("0.00"),
                perEA = perEA.ToString("0.00"),
                perRFG = perRFG.ToString("0.00"),
                perEFG = perEFG.ToString("0.00")
            };

            Response.Write(GetResponse(status, message, result));
        }
        catch (Exception ex)
        {
            Response.Write(GetResponse(Enums.ResponseStatusEnum.Error.ToString(), ex.Message));
        }
        finally
        {
            HttpApplicationInstance.CompleteRequest();
        }
    }
    public void GenerateObjectWiseChart()
    {
        try
        {
            ChartRequest request = new ChartRequest();
            ChartManager manager = new ChartManager();

            request.InstituteId = 0;
            request.FinancialYearId = Convert.ToInt32(Request.Form["FYId"]);
            request.ToDate = Convert.ToDateTime(Request.Form["ToDate"]);
            request.UserId = Convert.ToInt64(HttpSession["UserId"]);

            ChartResponse response = manager.GenerateObjectWiseChart(request);
            string status = Enums.ResponseStatusEnum.Success.ToString();
            string message = "Object Chart is generated successfully.";
            List<object> lstRObject = new List<object>();
            List<string> lstRObjectWise = new List<string>();
            List<object> lstRBEChart = new List<object>();
            List<object> lstREChart = new List<object>();
            decimal totalRBudgetEstimate = response.SchemeList.Where(p => p.FundId == 2).Sum(p => p.BudgetEstimate);
            decimal totalRExpenditure = response.SchemeList.Where(p => p.FundId == 2).Sum(p => p.Expenditure);

            foreach (Scheme objScheme in response.SchemeList.Where(p => p.FundId == 2))
            {
                lstRObjectWise.Add(objScheme.AccountName);

                var objBEChart = new
                {
                    name = objScheme.AccountName,
                    y = totalRBudgetEstimate <= 0 ? 0 : Convert.ToSingle(((100 / totalRBudgetEstimate) * objScheme.BudgetEstimate))
                };

                var objEChart = new
                {
                    name = objScheme.AccountName,
                    y = totalRExpenditure <= 0 ? 0 : Convert.ToSingle(((100 / totalRExpenditure) * objScheme.Expenditure))
                };

                lstRBEChart.Add(objBEChart);
                lstREChart.Add(objEChart);
            }

            for (int i = 1; i <= 6; i++)
            {
                switch (i)
                {
                    case 1:
                        var BudgetEstimate = new
                        {
                            type = "column",
                            name = "Budget Estimate " + response.FinancialYear,
                            data = new List<decimal>(),
                            tooltip = new { valueSuffix = " Millions" }
                        };

                        foreach (string objectWise in lstRObjectWise)
                        {
                            Scheme objScheme = response.SchemeList.FirstOrDefault(p => p.AccountName == objectWise && p.FundId == 2);

                            BudgetEstimate.data.Add((objScheme.BudgetEstimate / 1000000));
                        }

                        lstRObject.Add(BudgetEstimate);

                        break;
                    case 2:
                        var FinalGrant = new
                        {
                            type = "column",
                            name = "Final Grant",
                            data = new List<decimal>(),
                            tooltip = new { valueSuffix = " Millions" }
                        };

                        foreach (string objectWise in lstRObjectWise)
                        {
                            Scheme objScheme = response.SchemeList.FirstOrDefault(p => p.AccountName == objectWise && p.FundId == 2);
                            decimal fg = objScheme.ADPAllocation + objScheme.Supplementary + objScheme.ReappPositive - objScheme.ReappNegative + objScheme.Excess;

                            FinalGrant.data.Add((fg / 1000000));
                        }

                        lstRObject.Add(FinalGrant);

                        break;
                    case 3:
                        var Release = new
                        {
                            type = "column",
                            name = "Release",
                            data = new List<decimal>(),
                            tooltip = new { valueSuffix = " Millions" }
                        };

                        foreach (string objectWise in lstRObjectWise)
                        {
                            Scheme objScheme = response.SchemeList.FirstOrDefault(p => p.AccountName == objectWise && p.FundId == 2);

                            Release.data.Add((objScheme.Release / 1000000));
                        }

                        lstRObject.Add(Release);

                        break;
                    case 4:
                        var Expenditure = new
                        {
                            type = "column",
                            name = "Expenditure",
                            data = new List<decimal>(),
                            tooltip = new { valueSuffix = " Millions" }
                        };

                        foreach (string objectWise in lstRObjectWise)
                        {
                            Scheme objScheme = response.SchemeList.FirstOrDefault(p => p.AccountName == objectWise && p.FundId == 2);

                            Expenditure.data.Add((objScheme.Expenditure / 1000000));
                        }

                        lstRObject.Add(Expenditure);

                        break;
                    case 5:
                        var UtilizationFG = new
                        {
                            type = "spline",
                            yAxis = 1,
                            name = "%age Utilization/FG",
                            data = new List<float>(),
                            marker = new { lineWidth = 2 },
                            tooltip = new { valueSuffix = "%" }
                        };

                        foreach (string objectWise in lstRObjectWise)
                        {
                            Scheme objScheme = response.SchemeList.FirstOrDefault(p => p.AccountName == objectWise && p.FundId == 2);
                            decimal fg = objScheme.ADPAllocation + objScheme.Supplementary + objScheme.ReappPositive - objScheme.ReappNegative + objScheme.Excess;

                            UtilizationFG.data.Add(Convert.ToSingle(fg <= 0 ? 0 : (objScheme.Expenditure / fg)));
                        }

                        lstRObject.Add(UtilizationFG);

                        break;
                    case 6:
                        var UtilizationBE = new
                        {
                            type = "spline",
                            yAxis = 1,
                            name = "%age Utilization/BE",
                            data = new List<float>(),
                            marker = new { lineWidth = 2 },
                            tooltip = new { valueSuffix = "%" }
                        };

                        foreach (string objectWise in lstRObjectWise)
                        {
                            Scheme objScheme = response.SchemeList.FirstOrDefault(p => p.AccountName == objectWise && p.FundId == 2);

                            UtilizationBE.data.Add(Convert.ToSingle(objScheme.BudgetEstimate <= 0 ? 0 : (objScheme.Expenditure / objScheme.BudgetEstimate)));
                        }

                        lstRObject.Add(UtilizationBE);

                        break;
                    default:
                        break;
                }
            }

            decimal release = response.SchemeList.Sum(p => p.Release);
            decimal expenditure = response.SchemeList.Sum(p => p.Expenditure);
            decimal allocation = response.SchemeList.Sum(p => p.ADPAllocation) + response.SchemeList.Sum(p => p.Supplementary);
            decimal finalGrant = allocation + response.SchemeList.Sum(p => p.ReappPositive) - response.SchemeList.Sum(p => p.ReappNegative) +
                    response.SchemeList.Sum(p => p.Excess);
            float perRA = Convert.ToSingle(allocation <= 0 ? 0 : ((release / allocation) * 100));
            float perEA = Convert.ToSingle(allocation <= 0 ? 0 : ((expenditure / allocation) * 100));
            float perRFG = Convert.ToSingle(finalGrant <= 0 ? 0 : ((release / finalGrant) * 100));
            float perEFG = Convert.ToSingle(finalGrant <= 0 ? 0 : ((expenditure / finalGrant) * 100));

            var result = new
            {
                fyTitle = response.FinancialYear,
                categories = lstRObjectWise,
                series = lstRObject,
                dataBE = lstRBEChart,
                dataE = lstREChart,
                perRA = perRA.ToString("0.00"),
                perEA = perEA.ToString("0.00"),
                perRFG = perRFG.ToString("0.00"),
                perEFG = perEFG.ToString("0.00")
            };

            Response.Write(GetResponse(status, message, result));
        }
        catch (Exception ex)
        {
            Response.Write(GetResponse(Enums.ResponseStatusEnum.Error.ToString(), ex.Message));
        }
        finally
        {
            HttpApplicationInstance.CompleteRequest();
        }
    }
    public void GenerateFunctionWiseChart()
    {
        try
        {
            ChartRequest request = new ChartRequest();
            ChartManager manager = new ChartManager();

            request.InstituteId = 0;
            request.FinancialYearId = Convert.ToInt32(Request.Form["FYId"]);
            request.ToDate = Convert.ToDateTime(Request.Form["ToDate"]);
            request.UserId = Convert.ToInt64(HttpSession["UserId"]);

            ChartResponse response = manager.GenerateFunctionWiseChart(request);
            string status = Enums.ResponseStatusEnum.Success.ToString();
            string message = "Function Chart is generated successfully.";
            List<object> lstRObject = new List<object>();
            List<string> lstRObjectWise = new List<string>();
            List<object> lstRBEChart = new List<object>();
            List<object> lstREChart = new List<object>();
            decimal totalRBudgetEstimate = response.SchemeList.Where(p => p.FundId == 2).Sum(p => p.BudgetEstimate);
            decimal totalRExpenditure = response.SchemeList.Where(p => p.FundId == 2).Sum(p => p.Expenditure);

            foreach (Scheme objScheme in response.SchemeList.Where(p => p.FundId == 2))
            {
                lstRObjectWise.Add(objScheme.AccountName);

                var objBEChart = new
                {
                    name = objScheme.AccountName,
                    y = totalRBudgetEstimate <= 0 ? 0 : Convert.ToSingle(((100 / totalRBudgetEstimate) * objScheme.BudgetEstimate))
                };

                var objEChart = new
                {
                    name = objScheme.AccountName,
                    y = totalRExpenditure <= 0 ? 0 : Convert.ToSingle(((100 / totalRExpenditure) * objScheme.Expenditure))
                };

                lstRBEChart.Add(objBEChart);
                lstREChart.Add(objEChart);
            }

            for (int i = 1; i <= 6; i++)
            {
                switch (i)
                {
                    case 1:
                        var BudgetEstimate = new
                        {
                            type = "column",
                            name = "Budget Estimate " + response.FinancialYear,
                            data = new List<decimal>(),
                            tooltip = new { valueSuffix = " Millions" }
                        };

                        foreach (string objectWise in lstRObjectWise)
                        {
                            Scheme objScheme = response.SchemeList.FirstOrDefault(p => p.AccountName == objectWise && p.FundId == 2);

                            BudgetEstimate.data.Add((objScheme.BudgetEstimate / 1000000));
                        }

                        lstRObject.Add(BudgetEstimate);

                        break;
                    case 2:
                        var FinalGrant = new
                        {
                            type = "column",
                            name = "Final Grant",
                            data = new List<decimal>(),
                            tooltip = new { valueSuffix = " Millions" }
                        };

                        foreach (string objectWise in lstRObjectWise)
                        {
                            Scheme objScheme = response.SchemeList.FirstOrDefault(p => p.AccountName == objectWise && p.FundId == 2);
                            decimal fg = objScheme.ADPAllocation + objScheme.Supplementary + objScheme.ReappPositive - objScheme.ReappNegative + objScheme.Excess;

                            FinalGrant.data.Add((fg / 1000000));
                        }

                        lstRObject.Add(FinalGrant);

                        break;
                    case 3:
                        var Release = new
                        {
                            type = "column",
                            name = "Release",
                            data = new List<decimal>(),
                            tooltip = new { valueSuffix = " Millions" }
                        };

                        foreach (string objectWise in lstRObjectWise)
                        {
                            Scheme objScheme = response.SchemeList.FirstOrDefault(p => p.AccountName == objectWise && p.FundId == 2);

                            Release.data.Add((objScheme.Release / 1000000));
                        }

                        lstRObject.Add(Release);

                        break;
                    case 4:
                        var Expenditure = new
                        {
                            type = "column",
                            name = "Expenditure",
                            data = new List<decimal>(),
                            tooltip = new { valueSuffix = " Millions" }
                        };

                        foreach (string objectWise in lstRObjectWise)
                        {
                            Scheme objScheme = response.SchemeList.FirstOrDefault(p => p.AccountName == objectWise && p.FundId == 2);

                            Expenditure.data.Add((objScheme.Expenditure / 1000000));
                        }

                        lstRObject.Add(Expenditure);

                        break;
                    case 5:
                        var UtilizationFG = new
                        {
                            type = "spline",
                            yAxis = 1,
                            name = "%age Utilization/FG",
                            data = new List<float>(),
                            marker = new { lineWidth = 2 },
                            tooltip = new { valueSuffix = "%" }
                        };

                        foreach (string objectWise in lstRObjectWise)
                        {
                            Scheme objScheme = response.SchemeList.FirstOrDefault(p => p.AccountName == objectWise && p.FundId == 2);
                            decimal fg = objScheme.ADPAllocation + objScheme.Supplementary + objScheme.ReappPositive - objScheme.ReappNegative + objScheme.Excess;

                            UtilizationFG.data.Add(Convert.ToSingle(fg <= 0 ? 0 : (objScheme.Expenditure / fg)));
                        }

                        lstRObject.Add(UtilizationFG);

                        break;
                    case 6:
                        var UtilizationBE = new
                        {
                            type = "spline",
                            yAxis = 1,
                            name = "%age Utilization/BE",
                            data = new List<float>(),
                            marker = new { lineWidth = 2 },
                            tooltip = new { valueSuffix = "%" }
                        };

                        foreach (string objectWise in lstRObjectWise)
                        {
                            Scheme objScheme = response.SchemeList.FirstOrDefault(p => p.AccountName == objectWise && p.FundId == 2);

                            UtilizationBE.data.Add(Convert.ToSingle(objScheme.BudgetEstimate <= 0 ? 0 : (objScheme.Expenditure / objScheme.BudgetEstimate)));
                        }

                        lstRObject.Add(UtilizationBE);

                        break;
                    default:
                        break;
                }
            }

            decimal release = response.SchemeList.Sum(p => p.Release);
            decimal expenditure = response.SchemeList.Sum(p => p.Expenditure);
            decimal allocation = response.SchemeList.Sum(p => p.ADPAllocation) + response.SchemeList.Sum(p => p.Supplementary);
            decimal finalGrant = allocation + response.SchemeList.Sum(p => p.ReappPositive) - response.SchemeList.Sum(p => p.ReappNegative) +
                    response.SchemeList.Sum(p => p.Excess);
            float perRA = Convert.ToSingle(allocation <= 0 ? 0 : ((release / allocation) * 100));
            float perEA = Convert.ToSingle(allocation <= 0 ? 0 : ((expenditure / allocation) * 100));
            float perRFG = Convert.ToSingle(finalGrant <= 0 ? 0 : ((release / finalGrant) * 100));
            float perEFG = Convert.ToSingle(finalGrant <= 0 ? 0 : ((expenditure / finalGrant) * 100));

            var result = new
            {
                fyTitle = response.FinancialYear,
                categories = lstRObjectWise,
                series = lstRObject,
                dataBE = lstRBEChart,
                dataE = lstREChart,
                perRA = perRA.ToString("0.00"),
                perEA = perEA.ToString("0.00"),
                perRFG = perRFG.ToString("0.00"),
                perEFG = perEFG.ToString("0.00")
            };

            Response.Write(GetResponse(status, message, result));
        }
        catch (Exception ex)
        {
            Response.Write(GetResponse(Enums.ResponseStatusEnum.Error.ToString(), ex.Message));
        }
        finally
        {
            HttpApplicationInstance.CompleteRequest();
        }
    }
    public void GenerateADPSummaryChart()
    {
        try
        {
            ChartRequest request = new ChartRequest();
            ChartManager manager = new ChartManager();

            request.InstituteId = 0;
            request.FinancialYearId = Convert.ToInt32(Request.Form["FYId"]);
            request.ToDate = Convert.ToDateTime(Request.Form["ToDate"]);
            request.UserId = Convert.ToInt64(HttpSession["UserId"]);

            ChartResponse response = manager.GenerateStatusWiseChart(request);
            string status = Enums.ResponseStatusEnum.Success.ToString();
            string message = "ADP Summary Chart is generated successfully.";
            List<string> lstCategory = new List<string>();
            List<object> lstObject = new List<object>();

            lstCategory.Add("ADP Summary");

            for (int i = 1; i <= 4; i++)
            {
                switch (i)
                {
                    case 1:
                        var Allocation = new
                        {
                            type = "column",
                            name = "Allocation",
                            data = new List<decimal>(),
                            tooltip = new { valueSuffix = " Millions" }
                        };

                        Allocation.data.Add((response.SchemeList.Sum(p => (p.ADPAllocation + p.Supplementary)) / 1000000));
                        lstObject.Add(Allocation);

                        break;
                    case 2:
                        var FinalGrant = new
                        {
                            type = "column",
                            name = "Final Grant",
                            data = new List<decimal>(),
                            tooltip = new { valueSuffix = " Millions" }
                        };

                        decimal fg = response.SchemeList.Sum(p => p.ADPAllocation) + response.SchemeList.Sum(p => p.Supplementary) +
                                response.SchemeList.Sum(p => p.ReappPositive) - response.SchemeList.Sum(p => p.ReappNegative) +
                                response.SchemeList.Sum(p => p.Excess);

                        FinalGrant.data.Add((fg / 1000000));
                        lstObject.Add(FinalGrant);

                        break;
                    case 3:
                        var Release = new
                        {
                            type = "column",
                            name = "Release",
                            data = new List<decimal>(),
                            tooltip = new { valueSuffix = " Millions" }
                        };

                        Release.data.Add((response.SchemeList.Sum(p => p.Release) / 1000000));
                        lstObject.Add(Release);

                        break;
                    case 4:
                        var Expenditure = new
                        {
                            type = "column",
                            name = "Expenditure",
                            data = new List<decimal>(),
                            tooltip = new { valueSuffix = " Millions" }
                        };

                        Expenditure.data.Add((response.SchemeList.Sum(p => p.Expenditure) / 1000000));
                        lstObject.Add(Expenditure);

                        break;
                    default:
                        break;
                }
            }

            decimal release = response.SchemeList.Sum(p => p.Release);
            decimal expenditure = response.SchemeList.Sum(p => p.Expenditure);
            decimal allocation = response.SchemeList.Sum(p => p.ADPAllocation) + response.SchemeList.Sum(p => p.Supplementary);
            decimal finalGrant = allocation + response.SchemeList.Sum(p => p.ReappPositive) - response.SchemeList.Sum(p => p.ReappNegative) +
                    response.SchemeList.Sum(p => p.Excess);
            float perRA = Convert.ToSingle(allocation <= 0 ? 0 : ((release / allocation) * 100));
            float perEA = Convert.ToSingle(allocation <= 0 ? 0 : ((expenditure / allocation) * 100));
            float perRFG = Convert.ToSingle(finalGrant <= 0 ? 0 : ((release / finalGrant) * 100));
            float perEFG = Convert.ToSingle(finalGrant <= 0 ? 0 : ((expenditure / finalGrant) * 100));

            var result = new
            {
                fyTitle = response.FinancialYear,
                categories = lstCategory,
                series = lstObject,
                perRA = perRA.ToString("0.00"),
                perEA = perEA.ToString("0.00"),
                perRFG = perRFG.ToString("0.00"),
                perEFG = perEFG.ToString("0.00")
            };

            Response.Write(GetResponse(status, message, result));
        }
        catch (Exception ex)
        {
            Response.Write(GetResponse(Enums.ResponseStatusEnum.Error.ToString(), ex.Message));
        }
        finally
        {
            HttpApplicationInstance.CompleteRequest();
        }
    }
    public void GenerateSubSectorSummaryChart()
    {
        try
        {
            ChartRequest request = new ChartRequest();
            ChartManager manager = new ChartManager();

            request.InstituteId = 0;
            request.FinancialYearId = Convert.ToInt32(Request.Form["FYId"]);
            request.ToDate = Convert.ToDateTime(Request.Form["ToDate"]);
            request.UserId = Convert.ToInt64(HttpSession["UserId"]);

            ChartResponse response = manager.GenerateSubSectorWiseChart(request);
            string status = Enums.ResponseStatusEnum.Success.ToString();
            string message = "Sub Sector Summary Chart is generated successfully.";
            List<object> lstObject = new List<object>();
            List<string> lstSubSectorWise = new List<string>();

            foreach (Scheme objScheme in response.SchemeList)
            {
                lstSubSectorWise.Add(objScheme.Title);
            }

            for (int i = 1; i <= 4; i++)
            {
                switch (i)
                {
                    case 1:
                        var Allocation = new
                        {
                            type = "column",
                            name = "Allocation",
                            data = new List<decimal>(),
                            tooltip = new { valueSuffix = " Millions" }
                        };

                        foreach (string subSector in lstSubSectorWise)
                        {
                            Scheme objScheme = response.SchemeList.FirstOrDefault(p => p.Title == subSector);

                            Allocation.data.Add(((objScheme.ADPAllocation + objScheme.Supplementary) / 1000000));
                        }

                        lstObject.Add(Allocation);

                        break;
                    case 2:
                        var FinalGrant = new
                        {
                            type = "column",
                            name = "Final Grant",
                            data = new List<decimal>(),
                            tooltip = new { valueSuffix = " Millions" }
                        };

                        foreach (string subSector in lstSubSectorWise)
                        {
                            Scheme objScheme = response.SchemeList.FirstOrDefault(p => p.Title == subSector);
                            decimal fg = objScheme.ADPAllocation + objScheme.Supplementary + objScheme.ReappPositive - objScheme.ReappNegative + objScheme.Excess;

                            FinalGrant.data.Add((fg / 1000000));
                        }

                        lstObject.Add(FinalGrant);

                        break;
                    case 3:
                        var Release = new
                        {
                            type = "column",
                            name = "Release",
                            data = new List<decimal>(),
                            tooltip = new { valueSuffix = " Millions" }
                        };

                        foreach (string subSector in lstSubSectorWise)
                        {
                            Scheme objScheme = response.SchemeList.FirstOrDefault(p => p.Title == subSector);

                            Release.data.Add((objScheme.Release / 1000000));
                        }

                        lstObject.Add(Release);

                        break;
                    case 4:
                        var Expenditure = new
                        {
                            type = "column",
                            name = "Expenditure",
                            data = new List<decimal>(),
                            tooltip = new { valueSuffix = " Millions" }
                        };

                        foreach (string subSector in lstSubSectorWise)
                        {
                            Scheme objScheme = response.SchemeList.FirstOrDefault(p => p.Title == subSector);

                            Expenditure.data.Add((objScheme.Expenditure / 1000000));
                        }

                        lstObject.Add(Expenditure);

                        break;
                    default:
                        break;
                }
            }

            decimal release = response.SchemeList.Sum(p => p.Release);
            decimal expenditure = response.SchemeList.Sum(p => p.Expenditure);
            decimal allocation = response.SchemeList.Sum(p => p.ADPAllocation) + response.SchemeList.Sum(p => p.Supplementary);
            decimal finalGrant = allocation + response.SchemeList.Sum(p => p.ReappPositive) - response.SchemeList.Sum(p => p.ReappNegative) +
                    response.SchemeList.Sum(p => p.Excess);
            float perRA = Convert.ToSingle(allocation <= 0 ? 0 : ((release / allocation) * 100));
            float perEA = Convert.ToSingle(allocation <= 0 ? 0 : ((expenditure / allocation) * 100));
            float perRFG = Convert.ToSingle(finalGrant <= 0 ? 0 : ((release / finalGrant) * 100));
            float perEFG = Convert.ToSingle(finalGrant <= 0 ? 0 : ((expenditure / finalGrant) * 100));

            var result = new
            {
                fyTitle = response.FinancialYear,
                categories = lstSubSectorWise,
                series = lstObject,
                perRA = perRA.ToString("0.00"),
                perEA = perEA.ToString("0.00"),
                perRFG = perRFG.ToString("0.00"),
                perEFG = perEFG.ToString("0.00")
            };

            Response.Write(GetResponse(status, message, result));
        }
        catch (Exception ex)
        {
            Response.Write(GetResponse(Enums.ResponseStatusEnum.Error.ToString(), ex.Message));
        }
        finally
        {
            HttpApplicationInstance.CompleteRequest();
        }
    }
    public void GenerateConstituencyWiseChart()
    {
        try
        {
            ChartRequest request = new ChartRequest();
            ChartManager manager = new ChartManager();

            request.DistrictId = Convert.ToInt64(Request.Form["DistrictId"]);
            request.ConstituencyId = Convert.ToInt64(Request.Form["ConstituencyId"]);
            request.FinancialYearId = Convert.ToInt32(Request.Form["FYId"]);
            request.ToDate = Convert.ToDateTime(Request.Form["ToDate"]);
            request.UserId = Convert.ToInt64(HttpSession["UserId"]);

            ChartResponse response = manager.GenerateConstituencyWiseChart(request);
            string status = Enums.ResponseStatusEnum.Success.ToString();
            string message = "Constituency Wise Chart is generated successfully.";
            List<object> lstRObject = new List<object>();
            List<string> lstRObjectWise = new List<string>();
            var Release = new
            {
                type = "column",
                name = "Release",
                data = new List<decimal>(),
                tooltip = new { valueSuffix = " Millions" }
            };
            var Expenditure = new
            {
                type = "column",
                name = "Expenditure",
                data = new List<decimal>(),
                tooltip = new { valueSuffix = " Millions" }
            };

            foreach (Scheme objScheme in response.SchemeList)
            {
                if (objScheme.Release > 0 || objScheme.Expenditure > 0)
                {
                    Release.data.Add((objScheme.Release / 1000000));
                    Expenditure.data.Add((objScheme.Expenditure / 1000000));

                    lstRObjectWise.Add(objScheme.Title);
                }
            }

            lstRObject.Add(Release);
            lstRObject.Add(Expenditure);

            decimal release = response.SchemeList.Sum(p => p.Release);
            decimal expenditure = response.SchemeList.Sum(p => p.Expenditure);
            decimal allocation = response.SchemeList.Sum(p => p.ADPAllocation) + response.SchemeList.Sum(p => p.Supplementary);
            decimal finalGrant = allocation + response.SchemeList.Sum(p => p.ReappPositive) - response.SchemeList.Sum(p => p.ReappNegative) +
                    response.SchemeList.Sum(p => p.Excess);
            float perRA = Convert.ToSingle(allocation <= 0 ? 0 : ((release / allocation) * 100));
            float perEA = Convert.ToSingle(allocation <= 0 ? 0 : ((expenditure / allocation) * 100));
            float perRFG = Convert.ToSingle(finalGrant <= 0 ? 0 : ((release / finalGrant) * 100));
            float perEFG = Convert.ToSingle(finalGrant <= 0 ? 0 : ((expenditure / finalGrant) * 100));

            var result = new
            {
                fyTitle = response.FinancialYear,
                categories = lstRObjectWise,
                series = lstRObject,
                perRA = perRA.ToString("0.00"),
                perEA = perEA.ToString("0.00"),
                perRFG = perRFG.ToString("0.00"),
                perEFG = perEFG.ToString("0.00")
            };

            Response.Write(GetResponse(status, message, result));
        }
        catch (Exception ex)
        {
            Response.Write(GetResponse(Enums.ResponseStatusEnum.Error.ToString(), ex.Message));
        }
        finally
        {
            HttpApplicationInstance.CompleteRequest();
        }
    }
    public void SignOut()
    {
        try
        {
            string status = Enums.ResponseStatusEnum.Success.ToString();
            string message = "Idle Session Timeout !!!";

            HttpSession.Clear();
            System.Web.Security.FormsAuthentication.SignOut();

            Response.Write(GetResponse(status, message, string.Empty));
        }
        catch (Exception ex)
        {
            Response.Write(GetResponse(Enums.ResponseStatusEnum.Error.ToString(), ex.Message));
        }
        finally
        {
            HttpApplicationInstance.CompleteRequest();
        }
    }
    public void KeepSessionAlive()
    {
        try
        {
            string status = Enums.ResponseStatusEnum.Success.ToString();
            string message = "Session Heartbeat !!!";

            HttpSession["Heartbeat"] = DateTime.Now;

            Response.Write(GetResponse(status, message, string.Empty));
        }
        catch (Exception ex)
        {
            Response.Write(GetResponse(Enums.ResponseStatusEnum.Error.ToString(), ex.Message));
        }
        finally
        {
            HttpApplicationInstance.CompleteRequest();
        }
    }
}