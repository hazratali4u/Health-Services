<%@ WebHandler Language="C#" Class="BaseHandler" %>

using System;
using System.Reflection;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.SessionState;
using CORNCommon;

public class BaseHandler : IHttpHandler, IRequiresSessionState
{
    public HttpApplication HttpApplicationInstance { get; private set; }
    public HttpRequest Request { get; set; }
    public HttpResponse Response { get; set; }
    public JavaScriptSerializer JSONSerializer { get; set; }
    public ResponseData ServerResponse { get; set; }
    protected HttpSessionState HttpSession { get; set; }

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

    public bool IsReusable
    {
        get
        {
            return false;
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
}