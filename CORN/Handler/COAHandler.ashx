<%@ WebHandler Language="C#" Class="COAHandler" %>

using System;
using System.Data;
using System.Reflection;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.SessionState;
using CORNBusinessLayer.Classes;
using CORNCommon;
using CORNCommon.Classes;
using CORNDataAccessLayer;

public class COAHandler : IHttpHandler, IRequiresSessionState
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

            string status = CORNCommon.Enums.ResponseStatusEnum.SessionExpired.ToString();
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
                    status = CORNCommon.Enums.ResponseStatusEnum.Error.ToString();
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
            Response.Write(GetResponse(CORNCommon.Enums.ResponseStatusEnum.Error.ToString(), ex.Message));
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

    public void COAGetSchemeId()
    {
        try
        {
            AccountHeadController mAccountController = new AccountHeadController();
            DataTable dtHead = mAccountController.SelectAccountHeadNew(Constants.AC_AccountHeadId, Constants.LongNullValue, 4, Constants.Account_Form_COA, Convert.ToInt64(Request.Form["SchemeId"]));
            string status = CORNCommon.Enums.ResponseStatusEnum.Success.ToString();
            string message = "COA are found successfully.";

            Response.Write(GetResponse(status, message, dtHead.ToList<COA>()));
        }
        catch (Exception ex)
        {
            Response.Write(GetResponse(CORNCommon.Enums.ResponseStatusEnum.Error.ToString(), ex.Message));
        }
        finally
        {
            HttpApplicationInstance.CompleteRequest();
        }
    }

    public void COAGetParentId()
    {
        try
        {
            long parentCOAId = Convert.ToInt64(Request.Form["ParentCOAId"]);
            string status = CORNCommon.Enums.ResponseStatusEnum.Success.ToString();
            string message = "COA are found successfully.";
            DataTable dtHead = new DataTable();

            if (parentCOAId > 0)
            {
                AccountHeadController mAccountController = new AccountHeadController();

                dtHead = mAccountController.SelectAccountHeadNew(Constants.AC_DetailTypeId, Convert.ToInt64(Request.Form["ParentCOAId"]), 3, Constants.Account_Form_COA, Constants.LongNullValue);

                DataRow dr = dtHead.NewRow();

                dr["ACCOUNT_HEAD_ID"] = 0;
                dr["ACCOUNT_CODE"] = "All";
                dr["ACCOUNT_NAME"] = "All";

                dtHead.Rows.InsertAt(dr, 0);
            }
            else
            {
                DataColumn dcId = new DataColumn();
                DataColumn dcCode = new DataColumn();
                DataColumn dcName = new DataColumn();

                dcId.ColumnName = "ACCOUNT_HEAD_ID";
                dcCode.ColumnName = "ACCOUNT_CODE";
                dcName.ColumnName = "ACCOUNT_NAME";

                dtHead.Columns.Add(dcId);
                dtHead.Columns.Add(dcCode);
                dtHead.Columns.Add(dcName);

                DataRow drm = dtHead.NewRow();

                drm["ACCOUNT_HEAD_ID"] = 0;
                drm["ACCOUNT_CODE"] = "All";
                drm["ACCOUNT_NAME"] = "All";

                dtHead.Rows.InsertAt(drm, 0);
            }

            Response.Write(GetResponse(status, message, dtHead.ToList<COA>()));
        }
        catch (Exception ex)
        {
            Response.Write(GetResponse(CORNCommon.Enums.ResponseStatusEnum.Error.ToString(), ex.Message));
        }
        finally
        {
            HttpApplicationInstance.CompleteRequest();
        }
    }

    public void COAGetSchemeIdForAllocation()
    {
        try
        {
            AccountHeadController mAccountController = new AccountHeadController();
            DataTable dtHead = mAccountController.SelectAccountHeadNew(Constants.AC_AccountHeadId, Constants.LongNullValue, 5, Constants.Account_Form_COA, Convert.ToInt64(Request.Form["SchemeId"]));
            string status = CORNCommon.Enums.ResponseStatusEnum.Success.ToString();
            string message = "COA are found successfully.";

            Response.Write(GetResponse(status, message, dtHead.ToList<COA>()));
        }
        catch (Exception ex)
        {
            Response.Write(GetResponse(CORNCommon.Enums.ResponseStatusEnum.Error.ToString(), ex.Message));
        }
        finally
        {
            HttpApplicationInstance.CompleteRequest();
        }
    }

    public void COAGetParentChildSchemeId()
    {
        try
        {
            AccountHeadController mAccountController = new AccountHeadController();
            DataTable dtHead = mAccountController.SelectAccountHeadNew(Constants.AC_AccountHeadId, Constants.LongNullValue, 6, Constants.Account_Form_COA, Convert.ToInt64(Request.Form["SchemeId"]));
            string status = CORNCommon.Enums.ResponseStatusEnum.Success.ToString();
            string message = "COA are found successfully.";

            Response.Write(GetResponse(status, message, dtHead.ToList<COA>()));
        }
        catch (Exception ex)
        {
            Response.Write(GetResponse(CORNCommon.Enums.ResponseStatusEnum.Error.ToString(), ex.Message));
        }
        finally
        {
            HttpApplicationInstance.CompleteRequest();
        }
    }
}