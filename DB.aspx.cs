using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class DB : System.Web.UI.Page
{
    ITAssetMonitoringDLL oITAssetMonitoringDLL = new ITAssetMonitoringDLL();
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            Session["brCode"] = "1914";
            Session["userId"] = "";
            LoadVendorDropDownList();
            LoadGridView("");
        }
    }

    private void LoadVendorDropDownList()
    {
        DataTable dt = oITAssetMonitoringDLL.GetVendor("");
      vendorDropDownList.DataSource = dt;
      vendorDropDownList.DataTextField = "V_Name";
      vendorDropDownList.DataValueField = "V_slNo";
      vendorDropDownList.DataBind();
    }

    private void LoadGridView(string condition)
    {
        DataTable dt = oITAssetMonitoringDLL.GetDB(condition);
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }

    protected void addButton_Click(object sender, EventArgs e)
    {

        int i = 0;
        DBClass oDBClass = new DBClass();
        oDBClass.DB_Name = nameTextBox.Text.Trim();
        oDBClass.DB_Version = versionTextBox.Text.Trim();
        oDBClass.DB_V_slNo =Convert.ToInt32(vendorDropDownList.SelectedValue);

        oDBClass.DB_WorkOrder_No = WorOrder_NoTextBox.Text;
        oDBClass.DB_WorkOrder_Date = WorkOrder_DateTextBox.Text;
        oDBClass.DB_Receive_Date = Receive_DateTextBox.Text;
        oDBClass.DB_UnderAMC = underAMCCheckBox.Checked;
        oDBClass.DB_Last_Renew_Date = Last_Renew_DateTextBox.Text;
        oDBClass.DB_Next_Renew_Date = Next_Renew_DateTextBox.Text;

        if (underAMCCheckBox.Checked == true)
        {
            if (oDBClass.DB_Last_Renew_Date == "")
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Enter Last Renew Date');", true);
                return;
            }
            if (oDBClass.DB_Next_Renew_Date == "")
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Enter Next Renew Date');", true);
                return;
            }


        }

        oDBClass.Remarks = remarksTextBox.Text;

        oDBClass.BrCode = Session["brCode"].ToString();
        oDBClass.User_Id = Session["userId"].ToString();
        if (addButton.Text == "Add")
        {
            i = oITAssetMonitoringDLL.InsertDB(oDBClass);
            if (i == 1)
            {

                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Database Information Inserted Successfully!');", true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Database Information Not Inserted!');", true);

            }
        }
        else if (addButton.Text == "Update")
        {
            oDBClass.DB_slNo = Convert.ToInt32(ViewState["id"]);
            i = oITAssetMonitoringDLL.UpdateDB(oDBClass);

            if (i == 1)
            {
                addButton.Text = "Add";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Database Information Updated Successfully!');", true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Database Information Not Updated!');", true);

            }
        }
        LoadGridView("");
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        LoadGridView("");
    }
    protected void btnEdit_Click(object sender, EventArgs e)
    {

        LinkButton b = (LinkButton)sender;
        GridViewRow row = (GridViewRow)b.NamingContainer;
        if (row != null)
        {
            int index = row.RowIndex; //gets the row index selected
            int id = Convert.ToInt32(GridView1.DataKeys[index].Value.ToString());

            string condition = " where DB_slNo='" + id + "'";
            // string condition = " where userId='" + userId + "'";
            DataTable dt = oITAssetMonitoringDLL.GetDB(condition);
            if (dt.Rows.Count > 0)
            {
                nameTextBox.Text = dt.Rows[0]["DB_Name"].ToString();
                versionTextBox.Text = dt.Rows[0]["DB_Version"].ToString();
                vendorDropDownList.SelectedValue = dt.Rows[0]["DB_V_slNo"].ToString();
               
                
                if (string.IsNullOrEmpty(dt.Rows[0]["DB_UnderAMC"].ToString()))
                    underAMCCheckBox.Checked = false;
                else
                    underAMCCheckBox.Checked = Convert.ToBoolean(dt.Rows[0]["DB_UnderAMC"].ToString());
                WorOrder_NoTextBox.Text = dt.Rows[0]["DB_WorkOrder_No"].ToString();
                
                
                if (string.IsNullOrEmpty(dt.Rows[0]["DB_WorkOrder_Date"].ToString()))
                  WorkOrder_DateTextBox.Text = "";
                else
                   WorkOrder_DateTextBox.Text = Convert.ToDateTime(dt.Rows[0]["DB_WorkOrder_Date"].ToString()).ToString("yyyy-MM-dd");

                if (string.IsNullOrEmpty(dt.Rows[0]["DB_Receive_Date"].ToString()))
                  Receive_DateTextBox.Text = "";
                else
                   Receive_DateTextBox.Text = Convert.ToDateTime(dt.Rows[0]["DB_Receive_Date"].ToString()).ToString("yyyy-MM-dd");


                if (string.IsNullOrEmpty(dt.Rows[0]["DB_Last_Renew_Date"].ToString()))
                 Last_Renew_DateTextBox.Text = "";
                else
                   Last_Renew_DateTextBox.Text = Convert.ToDateTime(dt.Rows[0]["DB_Last_Renew_Date"].ToString()).ToString("yyyy-MM-dd");
                if (string.IsNullOrEmpty(dt.Rows[0]["DB_Next_Renew_Date"].ToString()))
                   Next_Renew_DateTextBox.Text = "";
                else
                   Next_Renew_DateTextBox.Text = Convert.ToDateTime(dt.Rows[0]["DB_Next_Renew_Date"].ToString()).ToString("yyyy-MM-dd");
                remarksTextBox.Text = dt.Rows[0]["Remarks"].ToString();

                ViewState["id"] = id;
                addButton.Text = "Update";


            }

        }
    }
}