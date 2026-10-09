<%@ WebHandler Language="C#" Class="PC1SchemeFundApprovalHandler" %>

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

public class PC1SchemeFundApprovalHandler : IHttpHandler, IRequiresSessionState
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

    public void SchemeFundApprovalAdd()
    {
        try
        {
            SchemeFundApprovalRequest request = new SchemeFundApprovalRequest();

            request.SchemeFundApprovalObject = JSONSerializer.Deserialize<SchemeFundApproval>(Request.Form["objSchemeFundApproval"]);
            request.UserId = UserCommonInfo.LoggedInUserId;

            PC1SchemeFundApprovalManager manager = new PC1SchemeFundApprovalManager();
            SchemeFundApprovalResponse response = manager.SchemeFundApprovalAdd(request);
            string status = Enums.ResponseStatusEnum.Error.ToString();
            string message = "Fund Status not added.";

            if (response.Status)
            {
                status = Enums.ResponseStatusEnum.Success.ToString();
                message = "Fund Status is added successfully.";
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
    public void SchemeFundApprovalUpdate()
    {
        try
        {
            SchemeFundApprovalRequest request = new SchemeFundApprovalRequest();

            request.SchemeFundApprovalObject = JSONSerializer.Deserialize<SchemeFundApproval>(Request.Form["objSchemeFundApproval"]);
            request.UserId = UserCommonInfo.LoggedInUserId;

            PC1SchemeFundApprovalManager manager = new PC1SchemeFundApprovalManager();
            SchemeFundApprovalResponse response = manager.SchemeFundApprovalUpdate(request);
            string status = Enums.ResponseStatusEnum.Error.ToString();
            string message = "Fund Status not updated.";

            if (response.Status)
            {
                status = Enums.ResponseStatusEnum.Success.ToString();
                message = "Fund Status is updated successfully.";
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
    public void SchemeFundProposedGetSchemeId()
    {
        try
        {
            SchemeFundApprovalRequest request = new SchemeFundApprovalRequest();

            request.SchemeId = Convert.ToInt64(Request.Form["SchemeId"]);

            PC1SchemeFundApprovalManager manager = new PC1SchemeFundApprovalManager();
            SchemeFundApprovalResponse response = manager.SchemeFundProposedGetSchemeId(request);
            string status = Enums.ResponseStatusEnum.Success.ToString();
            string message = "Proposed Fund found";

            Response.Write(GetResponse(status, message, response.SchemeFundApprovalDetailList));
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