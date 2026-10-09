<%@ WebHandler Language="C#" Class="GeoHierarchyHandler" %>

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

public class GeoHierarchyHandler : IHttpHandler, IRequiresSessionState
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

    public void GeoHierarchyGetId()
    {
        try
        {
            GeoHierarchyRequest request = new GeoHierarchyRequest();

            request.Id = Convert.ToInt64(Request.Form["Id"]);

            GeoHierarchyManager manager = new GeoHierarchyManager();
            GeoHierarchyResponse response = manager.GeoHierarchyGetId(request);
            string status = Enums.ResponseStatusEnum.Success.ToString();
            string message = "Geo Hierarchy is loaded successfully.";

            Response.Write(GetResponse(status, message, response.GeoHierarchyObject));
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
    public void GeoHierarchyAdd()
    {
        try
        {
            GeoHierarchyRequest request = new GeoHierarchyRequest();

            request.GeoHierarchyObject = JSONSerializer.Deserialize<GeoHierarchy>(Request.Form["objGeoHierarchy"]);
            request.UserId = UserCommonInfo.LoggedInUserId;

            GeoHierarchyManager manager = new GeoHierarchyManager();
            GeoHierarchyResponse response = manager.GeoHierarchyAdd(request);
            string status = Enums.ResponseStatusEnum.Success.ToString();
            string message = "Geo Hierarchy is added successfully.";

            Response.Write(GetResponse(status, message, response.GeoHierarchyObject));
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
    public void GeoHierarchyUpdate()
    {
        try
        {
            GeoHierarchyRequest request = new GeoHierarchyRequest();

            request.GeoHierarchyObject = JSONSerializer.Deserialize<GeoHierarchy>(Request.Form["objGeoHierarchy"]);
            request.UserId = UserCommonInfo.LoggedInUserId;

            GeoHierarchyManager manager = new GeoHierarchyManager();
            GeoHierarchyResponse response = manager.GeoHierarchyUpdate(request);
            string status = Enums.ResponseStatusEnum.Success.ToString();
            string message = "Geo Hierarchy is updated successfully.";

            Response.Write(GetResponse(status, message, response.GeoHierarchyObject));
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
    public void GeoHierarchyDelete()
    {
        try
        {
            GeoHierarchyRequest request = new GeoHierarchyRequest();

            request.Id = Convert.ToInt64(Request.Form["Id"]);

            GeoHierarchyManager manager = new GeoHierarchyManager();
            GeoHierarchyResponse response = manager.GeoHierarchyDelete(request);

            string status = Enums.ResponseStatusEnum.Error.ToString();
            string message = "Geo Hierarchy not deleted.";

            if (response.Status)
            {
                status = Enums.ResponseStatusEnum.Success.ToString();
                message = "Geo Hierarchy is deleted successfully.";
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
    public void GeoHierarchyGetTypeIdParentId()
    {
        try
        {
            GeoHierarchyRequest request = new GeoHierarchyRequest();

            request.TypeId = Convert.ToInt32(Request.Form["TypeId"]);
            request.ParentId = Convert.ToInt32(Request.Form["ParentId"]);
            request.UserId = UserCommonInfo.LoggedInUserId;

            GeoHierarchyManager manager = new GeoHierarchyManager();
            GeoHierarchyResponse response = manager.GeoHierarchyGetTypeIdParentId(request);
            string status = Enums.ResponseStatusEnum.Success.ToString();
            string message = "Geo Hierarchy listed is selected successfully.";

            Response.Write(GetResponse(status, message, response.GeoHierarchyList));
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
    public void GeoHierarchyConstituencyGetDistrictId()
    {
        try
        {
            GeoHierarchyRequest request = new GeoHierarchyRequest();

            request.Id = Convert.ToInt32(Request.Form["Id"]);
            request.UserId = UserCommonInfo.LoggedInUserId;

            GeoHierarchyManager manager = new GeoHierarchyManager();
            GeoHierarchyResponse response = manager.GeoHierarchyConstituencyGetDistrictId(request);
            string status = Enums.ResponseStatusEnum.Success.ToString();
            string message = "Geo Hierarchy listed is selected successfully.";

            Response.Write(GetResponse(status, message, response.GeoHierarchyList));
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