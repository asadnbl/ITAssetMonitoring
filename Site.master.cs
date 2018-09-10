using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class SiteMaster : System.Web.UI.MasterPage
{
    //TransactionEntity cTransactionEntity = new TransactionEntity();
    //TransactionDAL oTransactionDAL = new TransactionDAL();
    //ConnectionDatabase oConnectionDatabase = new ConnectionDatabase();
    DataTable dt = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {
       
        if (Session["dt"] != null)
        {
            dt = (DataTable)Session["dt"];
            ViewState["userId"]=dt.Rows[0]["userId"];
            ViewState["brCode"] = dt.Rows[0]["brCode"];
            Session["brCode"] = dt.Rows[0]["brCode"];
            Session["userId"] = dt.Rows[0]["userId"];
            lblUser.Text = Convert.ToString(dt.Rows[0]["userName"]);
            lblBranch.Text = Convert.ToString(dt.Rows[0]["brName"]);

            int s = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[0]["rollName"].ToString().Trim() != "SuperAdmin")
                {
                    s = 1;

                    // for (int k = 0; k < NavigationMenu.Items.Count; k++)
                    //{
                    //    if (NavigationMenu.Items[k].Text == "Admin")
                    //    {
                    //        NavigationMenu.Items[k].Enabled = false;

                    //    }
                    //}
                }
            }
            if (s == 1)
            {
                MenuItemCollection menuItems = NavigationMenu.Items;
                MenuItem adminItem = new MenuItem();
                MenuItem reportItem = new MenuItem();
                foreach (MenuItem menuItem in menuItems)
                {
                    if (menuItem.Text == "Admin")
                        adminItem = menuItem;
                    if (menuItem.Text == "Report")
                        reportItem = menuItem;
                }
                menuItems.Remove(adminItem);
                menuItems.Remove(reportItem);
            }
        }
        else
        {
            //Response.Redirect("Default.aspx");
        }
    }
    protected void btnSignOut_Click(object sender, EventArgs e)
    {
        //cTransactionEntity.LOG_DESCRIPTION = "LogOut User :" + Session["UserId"].ToString();
        //cTransactionEntity.ACTIVITY_ID = 1;
        //cTransactionEntity.USER_ID = Session["UserId"].ToString();
        //cTransactionEntity.ENTRY_EXIT_TIME = System.DateTime.Now.ToShortDateString() + " " + System.DateTime.Now.ToLongTimeString();
        //oTransactionDAL.InsertIntoISS_LOG_DETAILS(cTransactionEntity);
        //SSO_DAO oSSO_DAO = new SSO_DAO();
        //int l = oSSO_DAO.UpdateLoginStatus(ViewState["userId"].ToString(), ViewState["brCode"].ToString(), "LogoutDateTime", DateTime.Now.ToString("yyyy-MM-dd HH':'mm':'ss"), " and loginStatus=1");
        //l = oSSO_DAO.UpdateLoginStatus(ViewState["userId"].ToString(), ViewState["brCode"].ToString(), "LoginStatus", "0", ""); Session.Clear();
        //Session.Abandon();
        //Response.Redirect("webLogin.aspx");
    }
}
