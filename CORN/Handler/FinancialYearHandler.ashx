<%@ WebHandler Language="C#" Class="FinancialYearHandler" %>

using System;
using System.Reflection;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.SessionState;
using CORNCommon;
using CORNDataAccessLayer.Request;
using CORNDataAccessLayer.Response;
using CORNBusinessLayer;
using CORNDataAccessLayer;

public class FinancialYearHandler : IHttpHandler, IRequiresSessionState
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

    public void FinancialYearGetSchemeId()
    {
        try
        {
            FinancialYearRequest request = new FinancialYearRequest();

            request.SchemeId = Convert.ToInt64(Request.Form["SchemeId"]);
            request.SchemeFetchMode = Convert.ToInt32(Request.Form["SchemeFetchMode"]);

            FinancialYearManager manager = new FinancialYearManager();
            FinancialYearResponse response = manager.FinancialYearGetSchemeId(request);
            string status = Enums.ResponseStatusEnum.Success.ToString();
            string message = "Financial Year are found successfully.";

            Response.Write(GetResponse(status, message, response.FinancialYearList));
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
    public void FinancialYearGetId()
    {
        try
        {
            FinancialYearRequest request = new FinancialYearRequest();

            request.Id = Convert.ToInt64(Request.Form["Id"]);

            FinancialYearManager manager = new FinancialYearManager();
            FinancialYearResponse response = manager.FinancialYearGetId(request);
            string status = Enums.ResponseStatusEnum.Success.ToString();
            string message = "Financial Year is loaded successfully.";

            Response.Write(GetResponse(status, message, response.FinancialYearObject));
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
    public void FinancialYearAdd()
    {
        try
        {
            FinancialYearRequest request = new FinancialYearRequest();

            request.FinancialYearObject = JSONSerializer.Deserialize<FinancialYear>(Request.Form["objFinancialYear"]);
            request.UserId = UserCommonInfo.LoggedInUserId;

            FinancialYearManager manager = new FinancialYearManager();
            FinancialYearResponse response = manager.FinancialYearAdd(request);
            string status = Enums.ResponseStatusEnum.Success.ToString();
            string message = "Financial Year is added successfully.";

            Response.Write(GetResponse(status, message, response.FinancialYearObject));
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
    public void FinancialYearUpdate()
    {
        try
        {
            FinancialYearRequest request = new FinancialYearRequest();

            request.FinancialYearObject = JSONSerializer.Deserialize<FinancialYear>(Request.Form["objFinancialYear"]);
            request.UserId = UserCommonInfo.LoggedInUserId;

            FinancialYearManager manager = new FinancialYearManager();
            FinancialYearResponse response = manager.FinancialYearUpdate(request);
            string status = Enums.ResponseStatusEnum.Success.ToString();
            string message = "Financial Year is updated successfully.";

            Response.Write(GetResponse(status, message, response.FinancialYearObject));
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
    public void FinancialYearDelete()
    {
        try
        {
            FinancialYearRequest request = new FinancialYearRequest();

            request.Id = Convert.ToInt64(Request.Form["Id"]);

            FinancialYearManager manager = new FinancialYearManager();
            FinancialYearResponse response = manager.FinancialYearDelete(request);

            string status = Enums.ResponseStatusEnum.Error.ToString();
            string message = "Financial Year not deleted.";

            if (response.Status)
            {
                status = Enums.ResponseStatusEnum.Success.ToString();
                message = "Financial Year is deleted successfully.";
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
}