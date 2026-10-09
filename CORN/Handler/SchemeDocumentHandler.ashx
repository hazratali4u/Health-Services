<%@ WebHandler Language="C#" Class="SchemeDocumentHandler" %>

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

public class SchemeDocumentHandler : IHttpHandler, IRequiresSessionState
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

    public void SchemeDocumentAdd()
    {
        try
        {
            SchemeDocumentRequest request = new SchemeDocumentRequest();

            request.SchemeDocumentObject = JSONSerializer.Deserialize<SchemeDocument>(Request.Form["objSchemeDocument"]);
            request.UserId = UserCommonInfo.LoggedInUserId;

            if (HttpSession["DocumentFile"] != null)
            {
                string[] arrDocumentFile = Convert.ToString(HttpSession["DocumentFile"]).Split(',');

                foreach (var DocumentFile in arrDocumentFile)
                {
                    SchemeDocumentFile objDocumentFile = new SchemeDocumentFile();

                    objDocumentFile.Title = DocumentFile;

                    request.SchemeDocumentObject.SchemeDocumentFileList.Add(objDocumentFile);
                }
            }

            SchemeDocumentManager manager = new SchemeDocumentManager();
            SchemeDocumentResponse response = manager.SchemeDocumentAdd(request);
            string status = Enums.ResponseStatusEnum.Error.ToString();
            string message = "Document not added.";

            if (response.Status)
            {
                UserCommonInfo.MoveDocumentFileInSession();
                UserCommonInfo.ResetDocumentInfoInSession(true);

                status = Enums.ResponseStatusEnum.Success.ToString();
                message = "Document is added successfully.";
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
    public void SchemeDocumentUpdate()
    {
        try
        {
            SchemeDocumentRequest request = new SchemeDocumentRequest();

            request.SchemeDocumentObject = JSONSerializer.Deserialize<SchemeDocument>(Request.Form["objSchemeDocument"]);
            request.UserId = UserCommonInfo.LoggedInUserId;

            List<SchemeDocumentFile> DocumentFilesToDelete = JSONSerializer.Deserialize<List<SchemeDocumentFile>>(Request.Form["SchemeDocumentFilesToDelete"]);

            if (HttpSession["DocumentFile"] != null)
            {
                string[] arrDocumentFile = Convert.ToString(HttpSession["DocumentFile"]).Split(',');

                foreach (var DocumentFile in arrDocumentFile)
                {
                    SchemeDocumentFile objDocumentFile = new SchemeDocumentFile();

                    objDocumentFile.Title = DocumentFile;

                    request.SchemeDocumentObject.SchemeDocumentFileList.Add(objDocumentFile);
                }
            }

            SchemeDocumentManager manager = new SchemeDocumentManager();
            SchemeDocumentResponse response = manager.SchemeDocumentUpdate(request);
            string status = Enums.ResponseStatusEnum.Error.ToString();
            string message = "Document not updated.";

            if (response.Status)
            {
                string DocumentFileList = string.Empty;

                foreach (var DocumentFile in DocumentFilesToDelete)
                {
                    DocumentFileList = DocumentFileList + "," + DocumentFile.Title;
                }

                UserCommonInfo.DeleteDocumentFile(DocumentFileList);
                UserCommonInfo.MoveDocumentFileInSession();
                UserCommonInfo.ResetDocumentInfoInSession(true);

                status = Enums.ResponseStatusEnum.Success.ToString();
                message = "Document is updated successfully.";
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
    public void DocumentDelete()
    {
        try
        {
            SchemeDocumentRequest catRequest = new SchemeDocumentRequest();

            catRequest.Id = Convert.ToInt64(Request.Form["DocumentId"]);

            SchemeDocumentManager catManager = new SchemeDocumentManager();
            SchemeDocumentResponse catResponse = catManager.DocumentGetId(catRequest);
            SchemeDocument objDocument = catResponse.SchemeDocumentObject;

            catRequest.UserId = UserCommonInfo.LoggedInUserId;
            catResponse = catManager.SchemeDocumentDelete(catRequest);

            string status = Enums.ResponseStatusEnum.Error.ToString();
            string message = "Document not deleted.";

            if (catResponse.Status)
            {
                string DocumentFileList = string.Empty;

                foreach (var DocumentFile in objDocument.SchemeDocumentFileList)
                {
                    DocumentFileList = DocumentFileList + "," + DocumentFile.Title;
                }

                UserCommonInfo.DeleteDocumentFile(DocumentFileList);
                UserCommonInfo.ResetDocumentInfoInSession(true);

                status = Enums.ResponseStatusEnum.Success.ToString();
                message = "Document is deleted successfully.";
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
    public void UploadSchemeDocumentFile()
    {
        try
        {
            var formUpload = Request.Files.Count > 0;
            var inputStream = formUpload ? Request.Files[0].InputStream : Request.InputStream;
            var xFileName = Request.Headers["X-File-Name"];
            var qqFile = Request["qqfile"];
            var formFilename = formUpload ? Request.Files[0].FileName : null;
            var filename = xFileName ?? qqFile ?? formFilename;

            filename = DateTime.Now.Ticks.ToString() + Path.GetExtension(filename);

            var filePath = Path.Combine(HttpApplicationInstance.Server.MapPath("~/UploadedFile/TempFile/"), filename);

            using (var fileStream = File.OpenWrite(filePath))
            {
                inputStream.CopyTo(fileStream);
            }

            HttpSession["DocumentFile"] = HttpSession["DocumentFile"] == null ? filename : Convert.ToString(HttpSession["DocumentFile"]) + "," + filename;

            Response.ContentType = "application/json";
            Response.Write("{\"success\":true}");
        }
        catch (Exception ex)
        {
            Response.Write("{\"success\":false, \"Exception\":\"" + ex.Message + "\"}");
        }
        finally
        {
            HttpApplicationInstance.CompleteRequest();
        }
    }
}