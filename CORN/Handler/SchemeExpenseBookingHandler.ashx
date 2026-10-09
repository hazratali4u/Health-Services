<%@ WebHandler Language="C#" Class="SchemeExpenseBookingHandler" %>

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
using System.Linq;
using Newtonsoft.Json;

public class SchemeExpenseBookingHandler : IHttpHandler, IRequiresSessionState
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

    public void SchemeExpenseBookingAdd()
    {
        try
        {
            SchemeExpenseBookingRequest request = new SchemeExpenseBookingRequest();

            request.SchemeExpenseBookingObject = JSONSerializer.Deserialize<SchemeExpenseBooking>(Request.Form["objSchemeExpenseBooking"]);
            request.UserId = UserCommonInfo.LoggedInUserId;

            if (HttpSession["ExpenseBookingFile"] != null)
            {
                string[] arrExpenseBookingFile = Convert.ToString(HttpSession["ExpenseBookingFile"]).Split(',');

                foreach (var ExpenseBookingFile in arrExpenseBookingFile)
                {
                    SchemeExpenseBookingFile objExpenseBookingFile = new SchemeExpenseBookingFile();

                    objExpenseBookingFile.Title = ExpenseBookingFile;

                    request.SchemeExpenseBookingObject.SchemeExpenseBookingFileList.Add(objExpenseBookingFile);
                }
            }

            SchemeExpenseBookingManager manager = new SchemeExpenseBookingManager();
            SchemeExpenseBookingResponse response = manager.SchemeExpenseBookingAdd(request);
            string status = Enums.ResponseStatusEnum.Error.ToString();
            string message = "Expense Booking not added.";

            if (response.Status)
            {
                UserCommonInfo.MoveExpenseBookingFileInSession();
                UserCommonInfo.ResetExpenseBookingInfoInSession(true);

                status = Enums.ResponseStatusEnum.Success.ToString();
                message = "Expense Booking is added successfully.";
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
    public void SchemeExpenseBookingUpdate()
    {
        try
        {
            SchemeExpenseBookingRequest request = new SchemeExpenseBookingRequest();

            request.SchemeExpenseBookingObject = JSONSerializer.Deserialize<SchemeExpenseBooking>(Request.Form["objSchemeExpenseBooking"]);
            request.UserId = UserCommonInfo.LoggedInUserId;

            List<SchemeExpenseBookingFile> ExpenseBookingFilesToDelete = JSONSerializer.Deserialize<List<SchemeExpenseBookingFile>>(Request.Form["SchemeExpenseBookingFilesToDelete"]);

            if (HttpSession["ExpenseBookingFile"] != null)
            {
                string[] arrExpenseBookingFile = Convert.ToString(HttpSession["ExpenseBookingFile"]).Split(',');

                foreach (var ExpenseBookingFile in arrExpenseBookingFile)
                {
                    SchemeExpenseBookingFile objExpenseBookingFile = new SchemeExpenseBookingFile();

                    objExpenseBookingFile.Title = ExpenseBookingFile;

                    request.SchemeExpenseBookingObject.SchemeExpenseBookingFileList.Add(objExpenseBookingFile);
                }
            }

            SchemeExpenseBookingManager manager = new SchemeExpenseBookingManager();
            SchemeExpenseBookingResponse response = manager.SchemeExpenseBookingUpdate(request);
            string status = Enums.ResponseStatusEnum.Error.ToString();
            string message = "Expense Booking not updated.";

            if (response.Status)
            {
                string ExpenseBookingFileList = string.Empty;

                foreach (var ExpenseBookingFile in ExpenseBookingFilesToDelete)
                {
                    ExpenseBookingFileList = ExpenseBookingFileList + "," + ExpenseBookingFile.Title;
                }

                UserCommonInfo.DeleteExpenseBookingFile(ExpenseBookingFileList);
                UserCommonInfo.MoveExpenseBookingFileInSession();
                UserCommonInfo.ResetExpenseBookingInfoInSession(true);

                status = Enums.ResponseStatusEnum.Success.ToString();
                message = "Expense Booking is updated successfully.";
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
    public void SchemeExpenseBookingDelete()
    {
        try
        {
            SchemeExpenseBookingRequest catRequest = new SchemeExpenseBookingRequest();

            catRequest.Id = Convert.ToInt64(Request.Form["Id"]);

            SchemeExpenseBookingManager catManager = new SchemeExpenseBookingManager();
            SchemeExpenseBookingResponse catResponse = catManager.SchemeExpenseBookingGetId(catRequest);
            SchemeExpenseBooking objSchemeExpenseBooking = catResponse.SchemeExpenseBookingObject;

            catRequest.UserId = UserCommonInfo.LoggedInUserId;
            catResponse = catManager.SchemeExpenseBookingDelete(catRequest);

            string status = Enums.ResponseStatusEnum.Error.ToString();
            string message = "Expense Booking not deleted.";

            if (catResponse.Status)
            {
                string ExpenseBookingFileList = string.Empty;

                foreach (var ExpenseBookingFile in objSchemeExpenseBooking.SchemeExpenseBookingFileList)
                {
                    ExpenseBookingFileList = ExpenseBookingFileList + "," + ExpenseBookingFile.Title;
                }

                UserCommonInfo.DeleteExpenseBookingFile(ExpenseBookingFileList);
                UserCommonInfo.ResetExpenseBookingInfoInSession(true);

                status = Enums.ResponseStatusEnum.Success.ToString();
                message = "Expense Booking is deleted successfully.";
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
    public void LoadSchemePOReferenceNoList()
    {
        try
        {
            SchemePOReferenceNoManager manager = new SchemePOReferenceNoManager();
            SchemePOReferenceNoResponse response = manager.SchemeExpenseBookingGetAll();
            string status = Enums.ResponseStatusEnum.Success.ToString();
            string message = "PO Reference No found.";

            Response.Write(GetResponse(status, message, response.SchemePOReferenceNoList));
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
    public void UploadSchemeExpenseBookingFile()
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

            HttpSession["ExpenseBookingFile"] = HttpSession["ExpenseBookingFile"] == null ? filename : Convert.ToString(HttpSession["ExpenseBookingFile"]) + "," + filename;

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
    public void SchemeFundReleaseTotalAmountGetSchemeId()
    {
        try
        {
            SchemeExpenseBookingRequest request = new SchemeExpenseBookingRequest();

            request.SchemeId = Convert.ToInt64(Request.Form["SchemeId"]);
            request.COAId = Convert.ToInt64(Request.Form["COAId"]);

            SchemeExpenseBookingManager manager = new SchemeExpenseBookingManager();
            SchemeExpenseBookingResponse response = manager.SchemeFundReleaseGetSchemeId(request);
            string status = Enums.ResponseStatusEnum.Success.ToString();
            string message = "Release Fund found";
            var result = new
            {
                //TotalCapital = String.Format("{0:C}", response.SchemeExpenseBookingDetailList.FindAll(p => p.TypeId == 1).Sum(p => p.Amount)).Replace("$", "Rs "),
                //TotalRevenue = String.Format("{0:C}", response.SchemeExpenseBookingDetailList.FindAll(p => p.TypeId == 2).Sum(p => p.Amount)).Replace("$", "Rs ")
                TotalCapital = response.SchemeFundReleaseDetailList.FindAll(p => p.TypeId == 1).Sum(p => p.Amount) - response.SchemeExpenseBookingDetailList.FindAll(p => p.ExpenseTypeId == 1).Sum(p => p.Amount),
                TotalRevenue = response.SchemeFundReleaseDetailList.FindAll(p => p.TypeId == 2).Sum(p => p.Amount) - response.SchemeExpenseBookingDetailList.FindAll(p => p.ExpenseTypeId == 2).Sum(p => p.Amount),
                TotalForeignFunding = response.SchemeFundReleaseDetailList.FindAll(p => p.TypeId == 3).Sum(p => p.Amount) - response.SchemeExpenseBookingDetailList.FindAll(p => p.ExpenseTypeId == 3).Sum(p => p.Amount)
            };

            Response.Write(GetResponse(status, message, result));
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
    public void SchemeExpenseBookingPayeeGet()
    {
        try
        {
            SchemeExpenseBookingManager manager = new SchemeExpenseBookingManager();
            SchemeExpenseBookingRequest request = new SchemeExpenseBookingRequest();

            request.UserId = UserCommonInfo.LoggedInUserId;

            SchemeExpenseBookingResponse response = manager.SchemeExpenseBookingPayeeGet(request);
            string status = Enums.ResponseStatusEnum.Success.ToString();
            string message = "Payee found";

            Response.Write(GetResponse(status, message, JsonConvert.SerializeObject(response.AutoCompleteList)));
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