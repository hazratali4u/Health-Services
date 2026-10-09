<%@ WebHandler Language="C#" Class="PC1SchemeHandler" %>

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
using System.IO;
using System.Collections.Generic;

public class PC1SchemeHandler : IHttpHandler, IRequiresSessionState
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
            //HealthSchemeController HealthCtl = new HealthSchemeController();
            //string errorMessage = HealthCtl.CheckDuplicateScheme(0, objScheme.strSchemeName, objScheme.strCapitalCode, objScheme.strSchemeCode, objScheme.strGSCode, objScheme.dtmFinancialYear);

            //if (!string.IsNullOrEmpty(errorMessage))
            //{
            //    throw new Exception(errorMessage);
            //}

            SchemeRequest request = new SchemeRequest();

            request.SchemeObject = objScheme;
            request.UserId = UserCommonInfo.LoggedInUserId;

            PC1SchemeManager manager = new PC1SchemeManager();
            SchemeResponse response = manager.SchemeAdd(request);
            string status = Enums.ResponseStatusEnum.Success.ToString();
            string message = "Scheme is added successfully.";

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
    public void SchemeUpdate()
    {
        try
        {
            Scheme objScheme = JSONSerializer.Deserialize<Scheme>(Request.Form["objScheme"]);
            List<SchemeFile> lstSchemeFilesToDelete = JSONSerializer.Deserialize<List<SchemeFile>>(Request.Form["schemeFilesToDelete"]);
            //HealthSchemeController HealthCtl = new HealthSchemeController();
            //string errorMessage = HealthCtl.CheckDuplicateScheme(Convert.ToInt32(objScheme.lngSchemeCode), objScheme.strSchemeName, objScheme.strCapitalCode, objScheme.strSchemeCode, objScheme.strGSCode, objScheme.dtmFinancialYear);

            //if (!string.IsNullOrEmpty(errorMessage))
            //{
            //    throw new Exception(errorMessage);
            //}

            SchemeRequest request = new SchemeRequest();

            request.SchemeObject = objScheme;
            request.WizardStep = Convert.ToInt64(Request.Form["wizardStep"]);
            request.UserId = UserCommonInfo.LoggedInUserId;

            if (request.WizardStep == 16)
            {
                if (HttpSession["PC1SchemeFile"] != null)
                {
                    string[] arrSchemeFile = Convert.ToString(HttpSession["PC1SchemeFile"]).Split(',');

                    foreach (var schemeFile in arrSchemeFile)
                    {
                        SchemeFile objSchemeFile = new SchemeFile();

                        objSchemeFile.Title = schemeFile;

                        request.SchemeObject.SchemeFileList.Add(objSchemeFile);
                    }
                }
            }

            PC1SchemeManager manager = new PC1SchemeManager();
            SchemeResponse response = manager.SchemeUpdate(request);
            string status = Enums.ResponseStatusEnum.Success.ToString();
            string message = "Scheme is updated successfully.";

            if (request.WizardStep == 16 && response.Status)
            {
                string lstSchemeFile = string.Empty;

                foreach (var objSchemeFile in lstSchemeFilesToDelete)
                {
                    lstSchemeFile = lstSchemeFile + "," + objSchemeFile.Title;
                }

                UserCommonInfo.DeletePC1SchemeFile(lstSchemeFile);
                UserCommonInfo.MovePC1SchemeFileInSession();
                UserCommonInfo.ResetPC1SchemeInfoInSession(true);

                Response.Write(GetResponse(status, message, response.SchemeFileList));
            }
            else
            {
                Response.Write(GetResponse(status, message, response.SchemeObject));
            }
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
    public void UploadSchemeFile()
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

            HttpSession["PC1SchemeFile"] = HttpSession["PC1SchemeFile"] == null ? filename : Convert.ToString(HttpSession["PC1SchemeFile"]) + "," + filename;

            Response.ContentType = "application/json";
            Response.Write("{\"success\":true}");
        }
        catch (Exception)
        {
            Response.Write("{\"success\":false}");
        }
        finally
        {
            HttpApplicationInstance.CompleteRequest();
        }
    }
}