<%@ WebHandler Language="C#" Class="FundTypeHandler" %>

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
using System.Collections.Generic;
using System.IO;

public class FundTypeHandler : IHttpHandler, IRequiresSessionState
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

    public void FundTypeGetId()
    {
        try
        {
            FundTypeRequest request = new FundTypeRequest();

            request.Id = Convert.ToInt64(Request.Form["Id"]);

            FundTypeManager manager = new FundTypeManager();
            FundTypeResponse response = manager.FundTypeGetId(request);
            string status = Enums.ResponseStatusEnum.Success.ToString();
            string message = "Fund Type is loaded successfully.";

            Response.Write(GetResponse(status, message, response.FundTypeObject));
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
    public void FundTypeAdd()
    {
        try
        {
            FundTypeRequest request = new FundTypeRequest();

            request.FundTypeObject = JSONSerializer.Deserialize<FundType>(Request.Form["objFundType"]);
            request.UserId = UserCommonInfo.LoggedInUserId;

            FundTypeManager manager = new FundTypeManager();
            FundTypeResponse response = manager.FundTypeAdd(request);
            string status = Enums.ResponseStatusEnum.Success.ToString();
            string message = "Fund Type is added successfully.";

            Response.Write(GetResponse(status, message, response.FundTypeObject));
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
    public void FundTypeUpdate()
    {
        try
        {
            FundTypeRequest request = new FundTypeRequest();

            request.FundTypeObject = JSONSerializer.Deserialize<FundType>(Request.Form["objFundType"]);
            request.UserId = UserCommonInfo.LoggedInUserId;

            FundTypeManager manager = new FundTypeManager();
            FundTypeResponse response = manager.FundTypeUpdate(request);
            string status = Enums.ResponseStatusEnum.Success.ToString();
            string message = "Fund Type is updated successfully.";

            Response.Write(GetResponse(status, message, response.FundTypeObject));
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
    public void FundTypeDelete()
    {
        try
        {
            FundTypeRequest request = new FundTypeRequest();

            request.Id = Convert.ToInt64(Request.Form["Id"]);

            FundTypeManager manager = new FundTypeManager();
            FundTypeResponse response = manager.FundTypeDelete(request);

            string status = Enums.ResponseStatusEnum.Error.ToString();
            string message = "Fund Type not deleted.";

            if (response.Status)
            {
                status = Enums.ResponseStatusEnum.Success.ToString();
                message = "Fund Type is deleted successfully.";
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