using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Backup : System.Web.UI.Page
{
    ITAssetMonitoringDLL oITAssetMonitoringDLL = new ITAssetMonitoringDLL();
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            Session["brCode"] = "1914";
            Session["userId"] = "";
            LoadBackupByDropDownList();
            LoadCheckedByDropDownList();
            LoadSoftwareDropDownList();
            LoadDBDropDownList();
            LoadGridView("");
        }
    }

    private void LoadBackupByDropDownList()
    {
        DataTable dt = oITAssetMonitoringDLL.GetEmployee("");
        backupByDropDownList.DataSource = dt;
        backupByDropDownList.DataTextField = "Emp_Name";
        backupByDropDownList.DataValueField = "Emp_slNo";
        backupByDropDownList.DataBind();
        backupByDropDownList.Items.Insert(0, "--Select--");
    }
    private void LoadCheckedByDropDownList()
    {
        DataTable dt = oITAssetMonitoringDLL.GetEmployee("");
        checkedByDropDownList.DataSource = dt;
        checkedByDropDownList.DataTextField = "Emp_Name";
        checkedByDropDownList.DataValueField = "Emp_slNo";
        checkedByDropDownList.DataBind();
        checkedByDropDownList.Items.Insert(0, "--Select--");
    }
    private void LoadSoftwareDropDownList()
    {
        DataTable dt = oITAssetMonitoringDLL.GetSoftware(" Where (Software.Sof_Name not like  '%WIN%' and Software.Sof_Name not like '%UNIX%' and Software.Sof_Name not like '%LINUX%')");
        softwareDropDownList.DataSource = dt;
        softwareDropDownList.DataTextField = "Sof_Name";
        softwareDropDownList.DataValueField = "Sof_Name";
        softwareDropDownList.DataBind();
        softwareDropDownList.Items.Insert(0, "--Select--");
    }
    private void LoadDBDropDownList()
    {
        //DataTable dt = oITAssetMonitoringDLL.GetSoftware("");
        DataTable dt = oITAssetMonitoringDLL.GetSoftware(" Where (Software.Sof_Name not like  '%WIN%' and Software.Sof_Name not like '%UNIX%' and Software.Sof_Name not like '%LINUX%')");
     
        dbDropDownList.DataSource = dt;
        dbDropDownList.DataTextField = "Sof_ScemaName";
        dbDropDownList.DataValueField = "Sof_ScemaName";
        dbDropDownList.DataBind();
        dbDropDownList.Items.Insert(0, "--Select--");
    }
    private void LoadGridView(string condition)
    {
        DataTable dt = oITAssetMonitoringDLL.GetBackup(condition);
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }

    protected void addButton_Click(object sender, EventArgs e)
    {

        int i = 0;
        BackupClass oBackupClass = new BackupClass();

        oBackupClass.Back_SoftWare = softwareDropDownList.SelectedValue=="0"?"":softwareDropDownList.SelectedValue;
        oBackupClass.Back_DataBase = dbDropDownList.SelectedValue=="0"?"":dbDropDownList.SelectedValue;
        oBackupClass.Back_DataBase_Receive_Date = receive_DateTextBox.Text;
        oBackupClass.Back_Entry_Date = DateTime.Now.ToString("yyyy-MM-dd");
        oBackupClass.Back_Media = mediaDropDownList.SelectedValue;
        oBackupClass.Back_custodian = CustodianDropDownList.SelectedValue;
        oBackupClass.Back_Person = Int32.Parse(backupByDropDownList.SelectedItem.Text == "--Select--" ? "0" : backupByDropDownList.SelectedValue);
        oBackupClass.Back_CheckedBy = Int32.Parse(checkedByDropDownList.SelectedItem.Text == "--Select--" ? "0" : checkedByDropDownList.SelectedValue);
        oBackupClass.BrCode = Session["brCode"].ToString();
        oBackupClass.User_Id = Session["userId"].ToString();



        oBackupClass.Remarks ="";

     
        if (addButton.Text == "Add")
        {
            i = oITAssetMonitoringDLL.InsertBackup(oBackupClass);
            if (i == 1)
            {

                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Backup Information Inserted Successfully!');", true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Backup Information Not Inserted!');", true);

            }
        }
        else if (addButton.Text == "Update")
        {
            oBackupClass.Back_SlNo = Convert.ToInt32(ViewState["id"]);
            i = oITAssetMonitoringDLL.UpdateBackup(oBackupClass);

            if (i == 1)
            {
                addButton.Text = "Add";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Backup Information Updated Successfully!');", true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Backup Information Not Updated!');", true);

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

            string condition = " where Back_SlNo='" + id + "'";
            // string condition = " where userId='" + userId + "'";
            DataTable dt = oITAssetMonitoringDLL.GetBackup(condition);
            if (dt.Rows.Count > 0)
            {

                if (!string.IsNullOrEmpty(dt.Rows[0]["Back_SoftWare"].ToString()))
                    softwareDropDownList.SelectedValue = dt.Rows[0]["Back_SoftWare"].ToString();
                if (!string.IsNullOrEmpty(dt.Rows[0]["Back_DataBase"].ToString()))
                   dbDropDownList.SelectedValue = dt.Rows[0]["Back_DataBase"].ToString();
               // receive_DateTextBox.Text = dt.Rows[0]["Back_DataBase_Receive_Date"].ToString();
                mediaDropDownList.SelectedValue = dt.Rows[0]["Back_Media"].ToString();
                CustodianDropDownList.SelectedValue = dt.Rows[0]["Back_custodian"].ToString();
                if (dt.Rows[0]["Back_Person"].ToString() != "0")
                    backupByDropDownList.SelectedValue = dt.Rows[0]["Back_Person"].ToString();
                if (dt.Rows[0]["Back_CheckedBy"].ToString() != "0")
                checkedByDropDownList.SelectedValue = dt.Rows[0]["Back_CheckedBy"].ToString();
              

                if (string.IsNullOrEmpty(dt.Rows[0]["Back_DataBase_Receive_Date"].ToString()))
                    receive_DateTextBox.Text = "";
                else
                    receive_DateTextBox.Text = Convert.ToDateTime(dt.Rows[0]["Back_DataBase_Receive_Date"].ToString()).ToString("yyyy-MM-dd");



                ViewState["id"] = id;
                addButton.Text = "Update";


            }

        }
    }
}