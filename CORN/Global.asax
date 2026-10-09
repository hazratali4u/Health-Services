<%@ Application Language="C#" %>

<script RunAt="server">

    void Application_Start(object sender, EventArgs e)
    {
        Application["LoginRelativePath"] = ConfigurationManager.AppSettings["LoginRelativePath"];
        Application["HomePath"] = ConfigurationManager.AppSettings["HomePath"];
        Application["HeaderText"] = ConfigurationManager.AppSettings["HeaderText"];
        Application["FooterText"] = ConfigurationManager.AppSettings["FooterText"];
        Application["CopyrightText"] = ConfigurationManager.AppSettings["CopyrightText"].Replace("[YEAR]", DateTime.Now.Year.ToString());
    }

    void Application_End(object sender, EventArgs e)
    {
        //  Code that runs on application shutdown

    }

    void Application_Error(object sender, EventArgs e)
    {
        // Code that runs when an unhandled error occurs

    }

    void Session_Start(object sender, EventArgs e)
    {
        // Code that runs when a new session is started

    }

    void Session_End(object sender, EventArgs e)
    {
        try
        {
            CORNBusinessLayer.Classes.UserController UserCtl = new CORNBusinessLayer.Classes.UserController();

            if (Session["UserID"] != null)
            {
                UserCtl.InsertUserLogoutTime(Convert.ToInt32(Session["User_Log_ID"]), Convert.ToInt32(Session["UserID"]));
            }
        }
        catch (Exception)
        {
        }
        finally
        {
            Session.Clear();
            //Response.Redirect(Convert.ToString(Application["LoginRelativePath"]));
        }
    }

</script>
