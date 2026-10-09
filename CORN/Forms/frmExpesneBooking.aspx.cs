using System;
using System.Web.UI;
using CORNBusinessLayer;
using CORNDataAccessLayer.Response;
using Newtonsoft.Json;
using CORNDataAccessLayer.Request;

public partial class Forms_frmExpesneBooking : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            SchemeExpenseBookingManager manager = new SchemeExpenseBookingManager();
            SchemeExpenseBookingRequest request = new SchemeExpenseBookingRequest();

            request.UserId = UserCommonInfo.LoggedInUserId;

            SchemeExpenseBookingResponse response = manager.SchemeExpenseBookingGetAll(request);

            this.Page.ClientScript.RegisterStartupScript(this.GetType(),
                    "FormsfrmExpesneBookingPageLoad",
                    "RC.SchemeExpenseBookingListing.SchemeExpenseBookingList = " + JsonConvert.SerializeObject(response.SchemeExpenseBookingList) + "; ",
                    true);
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "FormsfrmExpesneBookingPageLoad", "$(document).ready(function () { alert(\"" + ex.Message + "\"); });", true);
        }
    }
}