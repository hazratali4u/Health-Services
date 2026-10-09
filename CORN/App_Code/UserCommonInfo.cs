using System;
using System.IO;
using System.Web.Hosting;
using System.Web.SessionState;

/// <summary>
/// Summary description for UserCommonInfo
/// </summary>

public static class UserCommonInfo
{
    public static HttpSessionState CurrentSession { get; set; }

    public static bool SessionExists
    {
        get
        {
            bool _sessionExists = true;

            if (CurrentSession == null || CurrentSession["UserID"] == null)
            {
                _sessionExists = false;
            }

            return _sessionExists;
        }
    }
    public static long LoggedInUserId
    {
        get
        {
            long _loggedInUserId = 0;

            if (SessionExists)
            {
                _loggedInUserId = Convert.ToInt64(CurrentSession["UserID"]);
            }

            return _loggedInUserId;
        }
    }

    public static void ResetDocumentInfoInSession(bool resetDocumentListing = false)
    {
        CurrentSession["DocumentFile"] = null;
    }
    public static void MoveDocumentFileInSession()
    {
        if (CurrentSession["DocumentFile"] != null)
        {
            string[] arrDocumentFile = Convert.ToString(CurrentSession["DocumentFile"]).Split(',');

            foreach (var DocumentFile in arrDocumentFile)
            {
                string targetFolder = HostingEnvironment.MapPath("~/UploadedFile/TempFile/") + DocumentFile;
                string destinationFolder = HostingEnvironment.MapPath("~/UploadedFile/DocumentFile/") + DocumentFile;

                try
                {
                    File.Move(targetFolder, destinationFolder);
                }
                catch { }
            }
        }
    }
    public static void DeleteDocumentFile(string DocumentFileList)
    {
        string[] arrDocumentFile = DocumentFileList.Split(',');

        foreach (string DocumentFile in arrDocumentFile)
        {
            if (!string.IsNullOrEmpty(DocumentFile))
            {
                try
                {
                    File.Delete(HostingEnvironment.MapPath("~/UploadedFile/DocumentFile/") + DocumentFile);
                }
                catch { }
            }
        }
    }

    public static void ResetExpenseBookingInfoInSession(bool resetExpenseBookingListing = false)
    {
        CurrentSession["ExpenseBookingFile"] = null;
    }
    public static void MoveExpenseBookingFileInSession()
    {
        if (CurrentSession["ExpenseBookingFile"] != null)
        {
            string[] arrExpenseBookingFile = Convert.ToString(CurrentSession["ExpenseBookingFile"]).Split(',');

            foreach (var ExpenseBookingFile in arrExpenseBookingFile)
            {
                string targetFolder = HostingEnvironment.MapPath("~/UploadedFile/TempFile/") + ExpenseBookingFile;
                string destinationFolder = HostingEnvironment.MapPath("~/UploadedFile/ExpenseBookingFile/") + ExpenseBookingFile;

                try
                {
                    File.Move(targetFolder, destinationFolder);
                }
                catch { }
            }
        }
    }
    public static void DeleteExpenseBookingFile(string ExpenseBookingFileList)
    {
        string[] arrExpenseBookingFile = ExpenseBookingFileList.Split(',');

        foreach (string ExpenseBookingFile in arrExpenseBookingFile)
        {
            if (!string.IsNullOrEmpty(ExpenseBookingFile))
            {
                try
                {
                    File.Delete(HostingEnvironment.MapPath("~/UploadedFile/ExpenseBookingFile/") + ExpenseBookingFile);
                }
                catch { }
            }
        }
    }

    public static void ResetPC1SchemeInfoInSession(bool resetPC1SchemeListing = false)
    {
        CurrentSession["PC1SchemeFile"] = null;
    }
    public static void MovePC1SchemeFileInSession()
    {
        if (CurrentSession["PC1SchemeFile"] != null)
        {
            string[] arrPC1SchemeFile = Convert.ToString(CurrentSession["PC1SchemeFile"]).Split(',');

            foreach (var objPC1SchemeFile in arrPC1SchemeFile)
            {
                string targetFolder = HostingEnvironment.MapPath("~/UploadedFile/TempFile/") + objPC1SchemeFile;
                string destinationFolder = HostingEnvironment.MapPath("~/UploadedFile/PC1SchemeFile/") + objPC1SchemeFile;

                try
                {
                    File.Move(targetFolder, destinationFolder);
                }
                catch { }
            }
        }
    }
    public static void DeletePC1SchemeFile(string PC1SchemeFileList)
    {
        string[] arrPC1SchemeFile = PC1SchemeFileList.Split(',');

        foreach (string PC1SchemeFile in arrPC1SchemeFile)
        {
            if (!string.IsNullOrEmpty(PC1SchemeFile))
            {
                try
                {
                    File.Delete(HostingEnvironment.MapPath("~/UploadedFile/PC1SchemeFile/") + PC1SchemeFile);
                }
                catch { }
            }
        }
    }
}
