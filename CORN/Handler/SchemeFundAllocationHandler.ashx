<%@ WebHandler Language="C#" Class="SchemeFundAllocationHandler" %>

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

public class SchemeFundAllocationHandler : IHttpHandler, IRequiresSessionState
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

    public void SchemeFundAllocationAdd()
    {
        try
        {
            SchemeFundAllocationRequest request = new SchemeFundAllocationRequest();

            request.SchemeFundAllocationObject = JSONSerializer.Deserialize<SchemeFundAllocation>(Request.Form["objSchemeFundAllocation"]);
            request.UserId = UserCommonInfo.LoggedInUserId;

            SchemeFundAllocationManager manager = new SchemeFundAllocationManager();
            SchemeFundAllocationResponse response = manager.SchemeFundAllocationAdd(request);
            string status = Enums.ResponseStatusEnum.Error.ToString();
            string message = "Fund Allocation not added.";

            if (response.Status)
            {
                status = Enums.ResponseStatusEnum.Success.ToString();
                message = "Fund Allocation is added successfully.";
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
    public void SchemeFundAllocationUpdate()
    {
        try
        {
            SchemeFundAllocationRequest request = new SchemeFundAllocationRequest();

            request.SchemeFundAllocationObject = JSONSerializer.Deserialize<SchemeFundAllocation>(Request.Form["objSchemeFundAllocation"]);
            request.UserId = UserCommonInfo.LoggedInUserId;

            SchemeFundAllocationManager manager = new SchemeFundAllocationManager();
            SchemeFundAllocationResponse response = manager.SchemeFundAllocationUpdate(request);
            string status = Enums.ResponseStatusEnum.Error.ToString();
            string message = "Fund Allocation not updated.";

            if (response.Status)
            {
                status = Enums.ResponseStatusEnum.Success.ToString();
                message = "Fund Allocation is updated successfully.";
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
    public void SchemeFundApprovalGetSchemeId()
    {
        try
        {
            SchemeFundAllocationRequest request = new SchemeFundAllocationRequest();

            request.SchemeId = Convert.ToInt64(Request.Form["SchemeId"]);
            request.FinancialYearId = Convert.ToInt64(Request.Form["FinancialYearId"]);

            SchemeFundAllocationManager manager = new SchemeFundAllocationManager();
            SchemeFundAllocationResponse response = manager.SchemeFundApprovalGetSchemeId(request);
            string status = Enums.ResponseStatusEnum.Success.ToString();
            string message = "Approval Fund found";

            Response.Write(GetResponse(status, message, response.SchemeFundAllocationDetailList));
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
    public void SchemeFundApprovalTotalAmountGetSchemeId()
    {
        try
        {
            SchemeFundAllocationRequest request = new SchemeFundAllocationRequest();

            request.SchemeId = Convert.ToInt64(Request.Form["SchemeId"]);
            request.FinancialYearId = Convert.ToInt64(Request.Form["FinancialYearId"]);
            request.COAId = Convert.ToInt64(Request.Form["COAId"]);

            SchemeFundAllocationManager manager = new SchemeFundAllocationManager();
            SchemeFundAllocationResponse response = manager.SchemeFundApprovalGetSchemeId(request);
            string status = Enums.ResponseStatusEnum.Success.ToString();
            string message = "Approval Fund found";
            var result = new
            {
                TotalCapital = String.Format("{0:C}", response.SchemeFundAllocationDetailList.FindAll(p => p.TypeId == 1).Sum(p => p.Amount)).Replace("$", "Rs "),
                TotalRevenue = String.Format("{0:C}", response.SchemeFundAllocationDetailList.FindAll(p => p.TypeId == 2).Sum(p => p.Amount)).Replace("$", "Rs "),
                TotalForeignFunding = String.Format("{0:C}", response.SchemeFundAllocationDetailList.FindAll(p => p.TypeId == 3).Sum(p => p.Amount)).Replace("$", "Rs ")
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