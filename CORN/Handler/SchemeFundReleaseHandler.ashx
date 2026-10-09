<%@ WebHandler Language="C#" Class="SchemeFundReleaseHandler" %>

using System;
using System.Reflection;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.SessionState;
using CORNCommon;
using CORNDataAccessLayer.Request;
using CORNDataAccessLayer.Response;
using CORNDataAccessLayer;
using CORNBusinessLayer;
using System.Linq;

public class SchemeFundReleaseHandler : IHttpHandler, IRequiresSessionState
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

    public void SchemeFundReleaseAdd()
    {
        try
        {
            SchemeFundReleaseRequest request = new SchemeFundReleaseRequest();

            request.SchemeFundReleaseObject = JSONSerializer.Deserialize<SchemeFundRelease>(Request.Form["objSchemeFundRelease"]);
            request.UserId = UserCommonInfo.LoggedInUserId;

            SchemeFundReleaseManager manager = new SchemeFundReleaseManager();
            SchemeFundReleaseResponse response = manager.SchemeFundReleaseAdd(request);
            string status = Enums.ResponseStatusEnum.Error.ToString();
            string message = "Fund Release not added.";

            if (response.Status)
            {
                status = Enums.ResponseStatusEnum.Success.ToString();
                message = "Fund Release is added successfully.";
            }

            Response.Write(GetResponse(status, message));
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
    public void SchemeFundReleaseUpdate()
    {
        try
        {
            SchemeFundReleaseRequest request = new SchemeFundReleaseRequest();

            request.SchemeFundReleaseObject = JSONSerializer.Deserialize<SchemeFundRelease>(Request.Form["objSchemeFundRelease"]);
            request.UserId = UserCommonInfo.LoggedInUserId;

            SchemeFundReleaseManager manager = new SchemeFundReleaseManager();
            SchemeFundReleaseResponse response = manager.SchemeFundReleaseUpdate(request);
            string status = Enums.ResponseStatusEnum.Error.ToString();
            string message = "Fund Release not updated.";

            if (response.Status)
            {
                status = Enums.ResponseStatusEnum.Success.ToString();
                message = "Fund Release is updated successfully.";
            }

            Response.Write(GetResponse(status, message));
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
    public void SchemeFundAllocationGetSchemeId()
    {
        try
        {
            SchemeFundReleaseRequest request = new SchemeFundReleaseRequest();

            request.SchemeId = Convert.ToInt64(Request.Form["SchemeId"]);
            request.FinancialYearId = Convert.ToInt64(Request.Form["FinancialYearId"]);
            request.COAId = Convert.ToInt64(Request.Form["COAId"]);

            SchemeFundReleaseManager manager = new SchemeFundReleaseManager();
            SchemeFundReleaseResponse response = manager.SchemeFundAllocationGetSchemeId(request);
            string status = Enums.ResponseStatusEnum.Success.ToString();
            string message = "Allocation Fund found";

            Response.Write(GetResponse(status, message, response.SchemeFundReleaseDetailList));
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
    public void SchemeFundAllocationTotalAmountGetSchemeId()
    {
        try
        {
            SchemeFundReleaseRequest request = new SchemeFundReleaseRequest();

            request.SchemeId = Convert.ToInt64(Request.Form["SchemeId"]);
            request.FinancialYearId = Convert.ToInt64(Request.Form["FinancialYearId"]);
            request.COAId = Convert.ToInt64(Request.Form["COAId"]);

            SchemeFundReleaseManager manager = new SchemeFundReleaseManager();
            SchemeFundReleaseResponse response = manager.SchemeFundAllocationGetSchemeIdForTotal(request);
            string status = Enums.ResponseStatusEnum.Success.ToString();
            string message = "Allocation Fund found";
            decimal capFundAllocation = response.SchemeFundAllocationDetailList.FindAll(p => p.TypeId == 1 && p.FundAllocationTypeId == 1).Sum(p => p.Amount);
            decimal capSupplementary = response.SchemeFundAllocationDetailList.FindAll(p => p.TypeId == 1 && p.FundAllocationTypeId == 2).Sum(p => p.Amount);
            decimal capReappropraionTo = response.SchemeReappropriationDetailList.FindAll(p => p.ToFundTypeId == 1 && p.ToCOAId == request.COAId && p.ToSchemeId == request.SchemeId).Sum(p => p.Amount);
            decimal capReappropriationFrom = response.SchemeReappropriationDetailList.FindAll(p => p.ToFundTypeId == 1 && p.FromCOAId == request.COAId && p.FromSchemeId == request.SchemeId).Sum(p => p.Amount);
            decimal capSurrender = response.SchemeExcessDetailList.FindAll(p => p.TypeId == 1 && p.AmountStatusId == 2).Sum(p => p.Amount);
            decimal capExcess = response.SchemeExcessDetailList.FindAll(p => p.TypeId == 1 && p.AmountStatusId == 1).Sum(p => p.Amount);

            decimal revFundAllocation = response.SchemeFundAllocationDetailList.FindAll(p => p.TypeId == 2 && p.FundAllocationTypeId == 1).Sum(p => p.Amount);
            decimal revSupplementary = response.SchemeFundAllocationDetailList.FindAll(p => p.TypeId == 2 && p.FundAllocationTypeId == 2).Sum(p => p.Amount);
            decimal revReappropraionTo = response.SchemeReappropriationDetailList.FindAll(p => p.ToFundTypeId == 2 && p.ToCOAId == request.COAId && p.ToSchemeId == request.SchemeId).Sum(p => p.Amount);
            decimal revReappropriationFrom = response.SchemeReappropriationDetailList.FindAll(p => p.ToFundTypeId == 2 && p.FromCOAId == request.COAId && p.FromSchemeId == request.SchemeId).Sum(p => p.Amount);
            decimal revSurrender = response.SchemeExcessDetailList.FindAll(p => p.TypeId == 2 && p.AmountStatusId == 2).Sum(p => p.Amount);
            decimal revExcess = response.SchemeExcessDetailList.FindAll(p => p.TypeId == 2 && p.AmountStatusId == 1).Sum(p => p.Amount);

            decimal ffFundAllocation = response.SchemeFundAllocationDetailList.FindAll(p => p.TypeId == 3 && p.FundAllocationTypeId == 1).Sum(p => p.Amount);
            decimal ffSupplementary = response.SchemeFundAllocationDetailList.FindAll(p => p.TypeId == 3 && p.FundAllocationTypeId == 2).Sum(p => p.Amount);
            decimal ffReappropraionTo = response.SchemeReappropriationDetailList.FindAll(p => p.ToFundTypeId == 3 && p.ToCOAId == request.COAId && p.ToSchemeId == request.SchemeId).Sum(p => p.Amount);
            decimal ffReappropriationFrom = response.SchemeReappropriationDetailList.FindAll(p => p.ToFundTypeId == 3 && p.FromCOAId == request.COAId && p.FromSchemeId == request.SchemeId).Sum(p => p.Amount);
            decimal ffSurrender = response.SchemeExcessDetailList.FindAll(p => p.TypeId == 3 && p.AmountStatusId == 2).Sum(p => p.Amount);
            decimal ffExcess = response.SchemeExcessDetailList.FindAll(p => p.TypeId == 3 && p.AmountStatusId == 1).Sum(p => p.Amount);

            decimal capFundRelease = response.SchemeFundReleaseDetailList.FindAll(p => p.TypeId == 1).Sum(p => p.Amount);
            decimal revFundRelease = response.SchemeFundReleaseDetailList.FindAll(p => p.TypeId == 2).Sum(p => p.Amount);
            decimal ffFundRelease = response.SchemeFundReleaseDetailList.FindAll(p => p.TypeId == 3).Sum(p => p.Amount);

            var result = new
            {
                TotalCapital = capFundAllocation + capSupplementary + capReappropraionTo - capReappropriationFrom - capSurrender + capExcess - capFundRelease,
                TotalRevenue = revFundAllocation + revSupplementary + revReappropraionTo - revReappropriationFrom - revSurrender + revExcess - revFundRelease,
                TotalForeignFunding = ffFundAllocation + ffSupplementary + ffReappropraionTo - ffReappropriationFrom - ffSurrender + ffExcess - ffFundRelease,
                TotalCapitalDetail = new
                {
                    FundAllocation = capFundAllocation,
                    Supplementary = capSupplementary,
                    ReappropraionTo = capReappropraionTo,
                    ReappropriationFrom = capReappropriationFrom,
                    Surrender = capSurrender,
                    Excess = capExcess,
                    Release = capFundRelease
                },
                TotalRevenueDetail = new
                {
                    FundAllocation = revFundAllocation,
                    Supplementary = revSupplementary,
                    ReappropraionTo = revReappropraionTo,
                    ReappropriationFrom = revReappropriationFrom,
                    Surrender = revSurrender,
                    Excess = revExcess,
                    Release = revFundRelease
                },
                TotalForeignFundingDetail = new
                {
                    FundAllocation = ffFundAllocation,
                    Supplementary = ffSupplementary,
                    ReappropraionTo = ffReappropraionTo,
                    ReappropriationFrom = ffReappropriationFrom,
                    Surrender = ffSurrender,
                    Excess = ffExcess,
                    Release = ffFundRelease
                }
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
}