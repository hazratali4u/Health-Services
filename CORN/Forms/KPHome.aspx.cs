using CORNBusinessLayer.Classes;
using CORNCommon.Classes;
using System;
using System.Data;
using System.Text;

public partial class Forms_KPHome : System.Web.UI.Page
{
    private void BuildLinks()
    {
        RoleManagementController roleController = new RoleManagementController();
        DataTable dtMenu = roleController.SelectRoleWiseModule((int)Session["RoleID"], 2, Constants.IntNullValue);
        StringBuilder sbFunds = new StringBuilder();
        StringBuilder sbPPR = new StringBuilder();
        StringBuilder sbMPR = new StringBuilder();
        StringBuilder sbADPSDR = new StringBuilder();
        StringBuilder sbOR = new StringBuilder();
        StringBuilder sbES = new StringBuilder();

        //sbPPR.Append("<a class='pc1schemereports btn btn-simple btn-danger' data-title='Progress Review Report' data-content=\"<ul class='list-group'>");
        sbMPR.Append("<a class='pc1schemereports btn btn-simple btn-danger' data-title='Monthly Progress Report' data-content=\"<ul class='list-group'>");
        sbADPSDR.Append("<a class='pc1schemereports btn btn-simple btn-danger' data-title='ADP Summary and Detailed Reports' data-content=\"<ul class='list-group'>");
        sbOR.Append("<a class='pc1schemereports btn btn-simple btn-danger' data-title='Other Reports' data-content=\"<ul class='list-group'>");

        foreach (DataRow dr in dtMenu.Rows)
        {
            DataTable dtSubMenu = roleController.SelectRoleWiseModule((int)Session["RoleID"], 3, Convert.ToInt32(dr["MODULE_ID"]));

            foreach (DataRow dr1 in dtSubMenu.Rows)
            {
                DataTable dtSubMenu1;

                if (Convert.ToBoolean(Session["IS_SystemAdmin"]))
                {
                    dtSubMenu1 = roleController.SelectRoleWiseModule(Constants.IntNullValue, 6, Convert.ToInt32(dr1["MODULE_ID"]));
                }
                else
                {
                    dtSubMenu1 = roleController.SelectRoleWiseModule((int)Session["RoleID"], 4, Convert.ToInt32(dr1["MODULE_ID"]));
                }

                foreach (DataRow dr2 in dtSubMenu1.Rows)
                {
                    if (Convert.ToInt64(dr["MODULE_ID"]) == 236)
                    {
                        sbFunds.Append("<span><a class='btn btn-simple btn-warning' href='" + dr2["MODULE_ID"].ToString());
                        sbFunds.Append("?LevelType=3&amp;LevelID=" + dr2["mid"].ToString());
                        sbFunds.Append("'>" + dr2["MODULE_DESCRIPTION"].ToString());
                        sbFunds.Append("</a><br /></span>");
                    }
                    else if (Convert.ToInt64(dr["MODULE_ID"]) == 241)
                    {
                        if (dr2["MODULE_ID"].ToString().ToLower().Contains("frmprogressprr.aspx"))
                        {
                            //sbPPR.Append("<li class='list-group-item' style='cursor: pointer;' ");
                            //sbPPR.Append("url='" + dr2["MODULE_ID"].ToString() + "' onclick='OpenReport(this, " + dr2["mid"].ToString() + ")'>");
                            //sbPPR.Append(dr2["MODULE_DESCRIPTION"].ToString() + "</li>");
                            sbPPR.Append("<span><a class='btn btn-simple btn-danger' href='" + dr2["MODULE_ID"].ToString());
                            sbPPR.Append("?LevelType=3&amp;LevelID=" + dr2["mid"].ToString());
                            sbPPR.Append("'>" + dr2["MODULE_DESCRIPTION"].ToString());
                            sbPPR.Append("</a></span>");
                        }
                        else if (dr2["MODULE_ID"].ToString().ToLower().Contains("frmreportoptions.aspx") ||
                            dr2["MODULE_ID"].ToString().ToLower().Contains("frmnewmpr.aspx") ||
                            dr2["MODULE_ID"].ToString().ToLower().Contains("frmsubsectormpr.aspx") ||
                            dr2["MODULE_ID"].ToString().ToLower().Contains("frmobjectmpr.aspx") ||
                            dr2["MODULE_ID"].ToString().ToLower().Contains("frmfunctionmpr.aspx"))
                        {
                            sbMPR.Append("<li class='list-group-item' style='cursor: pointer;' ");
                            sbMPR.Append("url='" + dr2["MODULE_ID"].ToString() + "' onclick='OpenReport(this, " + dr2["mid"].ToString() + ")'>");
                            sbMPR.Append(dr2["MODULE_DESCRIPTION"].ToString() + "</li>");
                        }
                        else if (dr2["MODULE_ID"].ToString().ToLower().Contains("frmadpsummary.aspx") ||
                           dr2["MODULE_ID"].ToString().ToLower().Contains("frmadpabstract.aspx") ||
                           dr2["MODULE_ID"].ToString().ToLower().Contains("frmadpdetail.aspx") ||
                           dr2["MODULE_ID"].ToString().ToLower().Contains("frmadpcomparative.aspx") ||
                           dr2["MODULE_ID"].ToString().ToLower().Contains("frmadphistoricaltrend.aspx") ||
                           dr2["MODULE_ID"].ToString().ToLower().Contains("rptnewadp.aspx"))
                        {
                            sbADPSDR.Append("<li class='list-group-item' style='cursor: pointer;' ");
                            sbADPSDR.Append("url='" + dr2["MODULE_ID"].ToString() + "' onclick='OpenReport(this, " + dr2["mid"].ToString() + ")'>");
                            sbADPSDR.Append(dr2["MODULE_DESCRIPTION"].ToString() + "</li>");
                        }
                        else if (dr2["MODULE_ID"].ToString().ToLower().Contains("rptschemesummary.aspx") ||
                           dr2["MODULE_ID"].ToString().ToLower().Contains("rptschemewithoutrelase.aspx") ||
                           dr2["MODULE_ID"].ToString().ToLower().Contains("rptschemerelase.aspx") ||
                           dr2["MODULE_ID"].ToString().ToLower().Contains("rptojectsummary.aspx") ||
                           dr2["MODULE_ID"].ToString().ToLower().Contains("rptfunctionsummary.aspx") ||
                           dr2["MODULE_ID"].ToString().ToLower().Contains("frmprojectptdr.aspx") ||
                           dr2["MODULE_ID"].ToString().ToLower().Contains("rptexcesssurrender.aspx") ||
                           dr2["MODULE_ID"].ToString().ToLower().Contains("rptexcesssurrenderplanning.aspx") ||
                           dr2["MODULE_ID"].ToString().ToLower().Contains("rptberfund.aspx") ||
                           dr2["MODULE_ID"].ToString().ToLower().Contains("rptbersubsector.aspx") ||
                           dr2["MODULE_ID"].ToString().ToLower().Contains("rptberscheme.aspx"))
                        {
                            sbOR.Append("<li class='list-group-item' style='cursor: pointer;' ");
                            sbOR.Append("url='" + dr2["MODULE_ID"].ToString() + "' onclick='OpenReport(this, " + dr2["mid"].ToString() + ")'>");
                            sbOR.Append(dr2["MODULE_DESCRIPTION"].ToString() + "</li>");
                        }
                        else
                        {
                            sbES.Append("<span><a class='btn btn-simple btn-danger' href='" + dr2["MODULE_ID"].ToString());
                            sbES.Append("?LevelType=3&amp;LevelID=" + dr2["mid"].ToString());
                            sbES.Append("'>" + dr2["MODULE_DESCRIPTION"].ToString());
                            sbES.Append("</a><br /></span>");
                        }
                    }

                    if (dr2["MODULE_ID"].ToString().ToLower().Contains("frmschemes.aspx"))
                    {
                        lnkMPRCreateModifyScheme.Visible = true;
                        lnkADPCreateModifyScheme.Visible = true;
                    }
                    else if (dr2["MODULE_ID"].ToString().ToLower().Contains("frmexpesnebooking.aspx"))
                    {
                        lnkReviewEditSchemeExpense.Visible = true;
                    }

                    if (dr2["MODULE_ID"].ToString().ToLower().Contains("frmschemecomment.aspx"))
                    {
                        lnkAddEditComments.Visible = true;
                    }
                }
            }
        }

        //sbPPR.Append("</ul>\" data-placement='top' data-animation='pop'>Progress Review Report</a>");
        sbMPR.Append("</ul>\" data-placement='top' data-animation='pop'>Monthly Progress Report</a>");
        sbADPSDR.Append("</ul>\" data-placement='top' data-animation='pop'>ADP Summary and Detailed Reports</a>");
        sbOR.Append("</ul>\" data-placement='top' data-animation='pop'>Other Reports</a>");

        ltrFunds.Text = sbFunds.ToString();
        ltrPPR.Text = sbPPR.ToString();
        ltrMPR.Text = sbMPR.ToString();
        ltrADPSDR.Text = sbADPSDR.ToString();
        ltrOR.Text = sbOR.ToString();
        ltrES.Text = sbES.ToString();
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        lnkMPRCreateModifyScheme.Visible = false;
        lnkADPCreateModifyScheme.Visible = false;
        lnkReviewEditSchemeExpense.Visible = false;
        lnkAddEditComments.Visible = false;

        if (!IsPostBack)
        {
            if (Session["Message"] != null)
            {
                lblMessage.Text = Session["Message"].ToString();
            }
        }

        int userRoleId = Convert.ToInt32(Session["RoleID"]);

        if (userRoleId != 1 && userRoleId != 2)
        {
            lnkDistributor.Visible = false;
            lnkSaleForce.Visible = false;
            lnkCreateUser.Visible = false;
            lnkUserAssignment.Visible = false;
        }

        BuildLinks();
    }
}