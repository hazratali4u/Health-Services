<%@ WebHandler Language="C#" Class="SchemeHandler" %>

using System;
using System.Reflection;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.SessionState;
using CORNCommon;
using CORNBusinessLayer.Classes;
using CORNDataAccessLayer.Request;
using CORNDataAccessLayer.Response;
using CORNDataAccessLayer;
using CORNBusinessLayer;

public class SchemeHandler : IHttpHandler, IRequiresSessionState
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

    public void SchemeAdd()
    {
        try
        {
            Scheme objScheme = JSONSerializer.Deserialize<Scheme>(Request.Form["objScheme"]);
            HealthSchemeController HealthCtl = new HealthSchemeController();
            string errorMessage = HealthCtl.CheckDuplicateScheme(0, objScheme.strSchemeName, objScheme.strCapitalCode, objScheme.strSchemeCode, objScheme.strGSCode, objScheme.dtmFinancialYear);

            if (!string.IsNullOrEmpty(errorMessage))
            {
                throw new Exception(errorMessage);
            }

            SchemeRequest request = new SchemeRequest();

            request.SchemeObject = objScheme;
            request.UserId = UserCommonInfo.LoggedInUserId;

            SchemeManager manager = new SchemeManager();
            SchemeResponse response = manager.SchemeAdd(request);
            string status = Enums.ResponseStatusEnum.Success.ToString();
            string message = "Scheme is added successfully.";

            Response.Write(GetResponse(status, message, response.Status));
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
    public void SchemeUpdate()
    {
        try
        {
            Scheme objScheme = JSONSerializer.Deserialize<Scheme>(Request.Form["objScheme"]);
            HealthSchemeController HealthCtl = new HealthSchemeController();
            string errorMessage = HealthCtl.CheckDuplicateScheme(Convert.ToInt32(objScheme.lngSchemeCode), objScheme.strSchemeName, objScheme.strCapitalCode, objScheme.strSchemeCode, objScheme.strGSCode, objScheme.dtmFinancialYear);

            if (!string.IsNullOrEmpty(errorMessage))
            {
                throw new Exception(errorMessage);
            }

            SchemeRequest request = new SchemeRequest();

            request.SchemeObject = objScheme;
            request.UserId = UserCommonInfo.LoggedInUserId;

            SchemeManager manager = new SchemeManager();
            SchemeResponse response = manager.SchemeUpdate(request);
            string status = Enums.ResponseStatusEnum.Success.ToString();
            string message = "Scheme is updated successfully.";

            Response.Write(GetResponse(status, message, response.Status));
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
    public void SchemeUpdateStatus()
    {
        try
        {
            SchemeRequest request = new SchemeRequest();

            request.SchemeIds = Request.Form["SchemeIds"];
            request.CategoryId = Convert.ToInt64(Request.Form["CategoryId"]);
            request.FinancialYearId = Convert.ToInt64(Request.Form["FinancialYearId"]);
            request.UserId = UserCommonInfo.LoggedInUserId;

            SchemeManager manager = new SchemeManager();
            SchemeResponse response = manager.SchemeUpdateStatus(request);
            string status = Enums.ResponseStatusEnum.Success.ToString();
            string message = "Selected scheme's statuses are updated successfully.";

            Response.Write(GetResponse(status, message, response.SchemeList));
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
    public void SchemeUpdateActiveInActive()
    {
        try
        {
            SchemeRequest request = new SchemeRequest();

            request.SchemeIds = Request.Form["SchemeIds"];
            request.FinancialYearId = Convert.ToInt64(Request.Form["FinancialYearId"]);
            request.UserId = UserCommonInfo.LoggedInUserId;

            SchemeManager manager = new SchemeManager();
            SchemeResponse response = manager.SchemeUpdateActiveInActive(request);
            string status = Enums.ResponseStatusEnum.Success.ToString();
            string message = "Selected scheme's active/inactive statuses are updated successfully.";

            Response.Write(GetResponse(status, message, response.SchemeList));
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
    public void SchemeUpdatePromote()
    {
        try
        {
            SchemeRequest request = new SchemeRequest();

            request.SchemeIds = Request.Form["SchemeIds"];
            request.FinancialYear = Request.Form["FinancialYear"];
            request.FinancialYearId = Convert.ToInt64(Request.Form["FinancialYearId"]);
            request.UserId = UserCommonInfo.LoggedInUserId;

            SchemeManager manager = new SchemeManager();
            SchemeResponse response = manager.SchemeUpdatePromote(request);
            string status = Enums.ResponseStatusEnum.Success.ToString();
            string message = "Selected schemes are promoted successfully.";

            Response.Write(GetResponse(status, message, response.SchemeList));
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
    public void SchemeGetId()
    {
        try
        {
            SchemeRequest request = new SchemeRequest();

            request.Id = Convert.ToInt64(Request.Form["SchemeId"]);
            request.UserId = UserCommonInfo.LoggedInUserId;

            SchemeManager manager = new SchemeManager();
            SchemeResponse response = manager.SchemeGetId(request);
            string status = Enums.ResponseStatusEnum.Success.ToString();
            string message = "Scheme is selected successfully.";

            Response.Write(GetResponse(status, message, response.SchemeObject));
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
    public void SchemeGetAll()
    {
        try
        {
            SchemeRequest request = new SchemeRequest();
            
            request.SchemeIds = string.Empty;
            request.FinancialYearId = Convert.ToInt64(Request.Form["FinancialYearId"]);
            request.UserId = UserCommonInfo.LoggedInUserId;
            
            SchemeManager manager = new SchemeManager();
            SchemeResponse response = manager.SchemeGetAll(request);
            string status = Enums.ResponseStatusEnum.Success.ToString();
            string message = "Scheme are selected successfully.";
            
            Response.Write(GetResponse(status, message, response.SchemeList));
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