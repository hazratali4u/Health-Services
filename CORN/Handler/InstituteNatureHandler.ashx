<%@ WebHandler Language="C#" Class="InstituteNatureHandler" %>

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

public class InstituteNatureHandler : IHttpHandler, IRequiresSessionState
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

    public void InstituteNatureGetId()
    {
        try
        {
            InstituteNatureRequest request = new InstituteNatureRequest();

            request.Id = Convert.ToInt64(Request.Form["Id"]);

            InstituteNatureManager manager = new InstituteNatureManager();
            InstituteNatureResponse response = manager.InstituteNatureGetId(request);
            string status = Enums.ResponseStatusEnum.Success.ToString();
            string message = "Approved By is loaded successfully.";

            Response.Write(GetResponse(status, message, response.InstituteNatureObject));
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
    public void InstituteNatureAdd()
    {
        try
        {
            InstituteNatureRequest request = new InstituteNatureRequest();

            request.InstituteNatureObject = JSONSerializer.Deserialize<InstituteNature>(Request.Form["objInstituteNature"]);
            request.UserId = UserCommonInfo.LoggedInUserId;

            InstituteNatureManager manager = new InstituteNatureManager();
            InstituteNatureResponse response = manager.InstituteNatureAdd(request);
            string status = Enums.ResponseStatusEnum.Success.ToString();
            string message = "Approved By is added successfully.";

            Response.Write(GetResponse(status, message, response.InstituteNatureObject));
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
    public void InstituteNatureUpdate()
    {
        try
        {
            InstituteNatureRequest request = new InstituteNatureRequest();

            request.InstituteNatureObject = JSONSerializer.Deserialize<InstituteNature>(Request.Form["objInstituteNature"]);
            request.UserId = UserCommonInfo.LoggedInUserId;

            InstituteNatureManager manager = new InstituteNatureManager();
            InstituteNatureResponse response = manager.InstituteNatureUpdate(request);
            string status = Enums.ResponseStatusEnum.Success.ToString();
            string message = "Approved By is updated successfully.";

            Response.Write(GetResponse(status, message, response.InstituteNatureObject));
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
    public void InstituteNatureDelete()
    {
        try
        {
            InstituteNatureRequest request = new InstituteNatureRequest();

            request.Id = Convert.ToInt64(Request.Form["Id"]);

            InstituteNatureManager manager = new InstituteNatureManager();
            InstituteNatureResponse response = manager.InstituteNatureDelete(request);

            string status = Enums.ResponseStatusEnum.Error.ToString();
            string message = "Approved By not deleted.";

            if (response.Status)
            {
                status = Enums.ResponseStatusEnum.Success.ToString();
                message = "Approved By is deleted successfully.";
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