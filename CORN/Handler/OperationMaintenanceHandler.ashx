<%@ WebHandler Language="C#" Class="OperationMaintenanceHandler" %>

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

public class OperationMaintenanceHandler : IHttpHandler, IRequiresSessionState
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

    public void OperationMaintenanceGetId()
    {
        try
        {
            OperationMaintenanceRequest request = new OperationMaintenanceRequest();

            request.Id = Convert.ToInt64(Request.Form["Id"]);

            OperationMaintenanceManager manager = new OperationMaintenanceManager();
            OperationMaintenanceResponse response = manager.OperationMaintenanceGetId(request);
            string status = Enums.ResponseStatusEnum.Success.ToString();
            string message = "Operation Maintenance is loaded successfully.";

            Response.Write(GetResponse(status, message, response.OperationMaintenanceObject));
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
    public void OperationMaintenanceAdd()
    {
        try
        {
            OperationMaintenanceRequest request = new OperationMaintenanceRequest();

            request.OperationMaintenanceObject = JSONSerializer.Deserialize<OperationMaintenance>(Request.Form["objOperationMaintenance"]);
            request.UserId = UserCommonInfo.LoggedInUserId;

            OperationMaintenanceManager manager = new OperationMaintenanceManager();
            OperationMaintenanceResponse response = manager.OperationMaintenanceAdd(request);
            string status = Enums.ResponseStatusEnum.Success.ToString();
            string message = "Operation Maintenance is added successfully.";

            Response.Write(GetResponse(status, message, response.OperationMaintenanceObject));
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
    public void OperationMaintenanceUpdate()
    {
        try
        {
            OperationMaintenanceRequest request = new OperationMaintenanceRequest();

            request.OperationMaintenanceObject = JSONSerializer.Deserialize<OperationMaintenance>(Request.Form["objOperationMaintenance"]);
            request.UserId = UserCommonInfo.LoggedInUserId;

            OperationMaintenanceManager manager = new OperationMaintenanceManager();
            OperationMaintenanceResponse response = manager.OperationMaintenanceUpdate(request);
            string status = Enums.ResponseStatusEnum.Success.ToString();
            string message = "Operation Maintenance is updated successfully.";

            Response.Write(GetResponse(status, message, response.OperationMaintenanceObject));
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
    public void OperationMaintenanceDelete()
    {
        try
        {
            OperationMaintenanceRequest request = new OperationMaintenanceRequest();

            request.Id = Convert.ToInt64(Request.Form["Id"]);

            OperationMaintenanceManager manager = new OperationMaintenanceManager();
            OperationMaintenanceResponse response = manager.OperationMaintenanceDelete(request);

            string status = Enums.ResponseStatusEnum.Error.ToString();
            string message = "Operation Maintenance not deleted.";

            if (response.Status)
            {
                status = Enums.ResponseStatusEnum.Success.ToString();
                message = "Operation Maintenance is deleted successfully.";
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