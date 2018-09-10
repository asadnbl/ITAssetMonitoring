using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class EmployeeResponsibility : System.Web.UI.Page
{
    ITAssetMonitoringDLL oITAssetMonitoringDLL = new ITAssetMonitoringDLL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadEmployeeDropDownList();
            LoadResponsibilityDropDownList();
            LoadListDropDownList();
            LoadGridView("");
        }
    }

    private void LoadListDropDownList()
    {
        if (deviceDropDownList.SelectedValue == "1")
        {
            DataTable dt = oITAssetMonitoringDLL.GetSoftware("");
            ListDropDownList.DataSource = dt;
            ListDropDownList.DataTextField = "Sof_Name";
            ListDropDownList.DataValueField = "Sof_slNo";
            ListDropDownList.DataBind();
        }
        else if (deviceDropDownList.SelectedValue == "2")
        {
            DataTable dt = oITAssetMonitoringDLL.GetServer("");
            ListDropDownList.DataSource = dt;
            ListDropDownList.DataTextField = "Ser_IP";
            ListDropDownList.DataValueField = "Ser_slNo";
            ListDropDownList.DataBind();
        }
        else if (deviceDropDownList.SelectedValue == "3")
        {
            DataTable dt = oITAssetMonitoringDLL.GetNetworkDevice("");
            ListDropDownList.DataSource = dt;
            ListDropDownList.DataTextField = "NetD_Name";
            ListDropDownList.DataValueField = "NetD_slNo";
            ListDropDownList.DataBind();
        }
        else if (deviceDropDownList.SelectedValue == "4")
        {
            DataTable dt = oITAssetMonitoringDLL.GetDB("");
            ListDropDownList.DataSource = dt;
            ListDropDownList.DataTextField = "DB_Name";
            ListDropDownList.DataValueField = "DB_slNo";
            ListDropDownList.DataBind();
        }
    }

    private void LoadResponsibilityDropDownList()
    {
        DataTable dt = oITAssetMonitoringDLL.GetResponsibility("");
        responsibilityDropDownList.DataSource = dt;
        responsibilityDropDownList.DataTextField = "Res_Name";
        responsibilityDropDownList.DataValueField = "Res_slNo";
        responsibilityDropDownList.DataBind();
    }
    private void LoadEmployeeDropDownList()
    {
        DataTable dt = oITAssetMonitoringDLL.GetEmployee("");
        employeeDropDownList.DataSource = dt;
        employeeDropDownList.DataTextField = "Emp_Name";
        employeeDropDownList.DataValueField = "Emp_slNo";
        employeeDropDownList.DataBind();
    }
    protected void addButton_Click(object sender, EventArgs e)
    {
        string columnName = "";
        int value = 0;
        int i = 0;
        if (deviceDropDownList.SelectedValue == "1")
        {
            columnName = "ER_Sof_slNo";
        }
        else if (deviceDropDownList.SelectedValue == "2")
        {
            columnName = "ER_Ser_slNo";
        }
        else if (deviceDropDownList.SelectedValue == "3")
        {
            columnName = "ER_Net_slNo";
        }
        else if (deviceDropDownList.SelectedValue == "4")
        {
            columnName = "ER_DB_slNo";
        }
        if (addButton.Text == "Add")
        {
            i = oITAssetMonitoringDLL.InsertEmployeeResponsibility(int.Parse(employeeDropDownList.SelectedValue),int.Parse(responsibilityDropDownList.SelectedValue),columnName,int.Parse( ListDropDownList.SelectedValue));
            if (i == 1)
            {

                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Employee Responsibility Information Inserted Successfully!');", true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Employee Responsibility Information Not Inserted!');", true);

            }
        }
        else if (addButton.Text == "Update")
        {
            int ER_slNo = Convert.ToInt32(ViewState["id"]);
            i = oITAssetMonitoringDLL.UpdateEmployeeResponsibility(ER_slNo,int.Parse(employeeDropDownList.SelectedValue),int.Parse(responsibilityDropDownList.SelectedValue),columnName,int.Parse( ListDropDownList.SelectedValue));

            if (i == 1)
            {
                addButton.Text = "Add";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Employee Responsibility Information Updated Successfully!');", true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Employee Responsibility Information Not Updated!');", true);

            }
        }
        LoadGridView("");

    }

    private void LoadGridView(string condiiton)
    {
        DataTable dt = oITAssetMonitoringDLL.GetEmployeeResponsibility("");
        GridView1.DataSource = dt;
        GridView1.DataBind(); 
    }

    protected void deviceDropDownList_SelectedIndexChanged(object sender, EventArgs e)
    {
        LoadListDropDownList();
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

            string condition = " where ER_slNo='" + id + "'";
            // string condition = " where userId='" + userId + "'";
            DataTable dt = oITAssetMonitoringDLL.GetEmployeeResponsibility(condition);
            if (dt.Rows.Count > 0)
            {

                employeeDropDownList.SelectedValue = dt.Rows[0]["ER_Emp_slNo"].ToString();
                responsibilityDropDownList.SelectedValue = dt.Rows[0]["ER_Res_slNo"].ToString();
                if (!string.IsNullOrEmpty(dt.Rows[0]["ER_Sof_slNo"].ToString()))
                {
                       ListDropDownList.DataSource = null;
                        DataTable dt1 = oITAssetMonitoringDLL.GetSoftware("");
                        ListDropDownList.DataSource = dt1;
                        ListDropDownList.DataTextField = "Sof_Name";
                        ListDropDownList.DataValueField = "Sof_slNo";
                        ListDropDownList.DataBind();
                        ListDropDownList.SelectedValue = dt.Rows[0]["ER_Sof_slNo"].ToString();
                        deviceDropDownList.SelectedValue = "1";
                    
                    
                   
                   
                }
                else if (!string.IsNullOrEmpty(dt.Rows[0]["ER_Ser_slNo"].ToString()))
                {
                        ListDropDownList.DataSource = null;
                        DataTable dt1 = oITAssetMonitoringDLL.GetServer("");
                        ListDropDownList.DataSource = dt1;
                        ListDropDownList.DataTextField = "Ser_IP";
                        ListDropDownList.DataValueField = "Ser_slNo";
                        ListDropDownList.DataBind();
                        ListDropDownList.SelectedValue=dt.Rows[0]["ER_Ser_slNo"].ToString();
                        deviceDropDownList.SelectedValue = "2";
                    
                }
                else if (!string.IsNullOrEmpty(dt.Rows[0]["ER_Net_slNo"].ToString()))
                {
                        ListDropDownList.DataSource = null;
                        DataTable dt1 = oITAssetMonitoringDLL.GetNetworkDevice("");
                        ListDropDownList.DataSource = dt1;
                        ListDropDownList.DataTextField = "NetD_Name";
                        ListDropDownList.DataValueField = "NetD_slNo";
                        ListDropDownList.DataBind();
                        ListDropDownList.SelectedValue=dt.Rows[0]["ER_Net_slNo"].ToString();
                        deviceDropDownList.SelectedValue = "3";
                    
                }
                else if (!string.IsNullOrEmpty(dt.Rows[0]["ER_DB_slNo"].ToString()))
                {
                        ListDropDownList.DataSource = null;
                        DataTable dt1 = oITAssetMonitoringDLL.GetDB("");
                        ListDropDownList.DataSource = dt1;
                        ListDropDownList.DataTextField = "DB_Name";
                        ListDropDownList.DataValueField = "DB_slNo";
                        ListDropDownList.DataBind();
                        ListDropDownList.SelectedValue = dt.Rows[0]["ER_DB_slNo"].ToString();
                        deviceDropDownList.SelectedValue = "4";
                   
                }


                //nameTextBox.Text = dt.Rows[0]["Sof_Name"].ToString();
                //ServerDropDownList.SelectedValue = dt.Rows[0]["Sof_Ser_slNo"].ToString();
                //Sof_TypeTextBox.Text = dt.Rows[0]["Sof_Type"].ToString();
                //EndUserTextBox.Text = dt.Rows[0]["Sof_EndUser"].ToString();
                //BenifitiaryUserTextBox.Text = dt.Rows[0]["Sof_BenifitiaryUser"].ToString();
                //CurrentVirsionTextBox.Text = dt.Rows[0]["Sof_CurrentVirsion"].ToString();
                //HostedLocationTextBox.Text = dt.Rows[0]["Sof_HostedLocation"].ToString();
                //WorkOrder_DateTextBox.Text = dt.Rows[0]["Sof_WorkOrder_Date"].ToString() == null ? "" : Convert.ToDateTime(dt.Rows[0]["Sof_WorkOrder_Date"].ToString()).ToString("yyyy-MM-dd");
                //WorOrder_NoTextBox.Text = dt.Rows[0]["Sof_WorkOrder_No"].ToString();
                //Receive_DateTextBox.Text = dt.Rows[0]["Sof_Receive_Date"].ToString() == null ? "" : Convert.ToDateTime(dt.Rows[0]["Sof_Receive_Date"].ToString()).ToString("yyyy-MM-dd");
                //underAMCCheckBox.Checked = Convert.ToBoolean(dt.Rows[0]["Sof_UnderAMC"].ToString());
                //Last_Renew_DateTextBox.Text = dt.Rows[0]["Sof_Last_Renew_Date"].ToString() == null ? "" : Convert.ToDateTime(dt.Rows[0]["Sof_Last_Renew_Date"].ToString()).ToString("yyyy-MM-dd");
                //Next_Renew_DateTextBox.Text = dt.Rows[0]["Sof_Last_Renew_Date"].ToString() == null ? "" : Convert.ToDateTime(dt.Rows[0]["Sof_Next_Renew_Date"].ToString()).ToString("yyyy-MM-dd");
                //employeeDropDownList.SelectedValue = dt.Rows[0]["Sof_UAT_Person"].ToString();
                //NetworkGatewayTextBox.Text = dt.Rows[0]["Sof_NetworkGateway"].ToString();
                //IsHostedCheckBox.Checked = Convert.ToBoolean(dt.Rows[0]["Sof_IsHosted"].ToString());
                //BlackboxTestCheckBox.Checked = Convert.ToBoolean(dt.Rows[0]["Sof_BlackboxTest"].ToString());
                //WhiteboxTestCheckBox.Checked = Convert.ToBoolean(dt.Rows[0]["Sof_WhiteboxTest"].ToString());
                //VernabilityCheckBox.Checked = Convert.ToBoolean(dt.Rows[0]["Sof_Vernability"].ToString());
                //PenitrationTestCheckBox.Checked = Convert.ToBoolean(dt.Rows[0]["Sof_PenitrationTest"].ToString());
                //OperationalManualCheckBox.Checked = Convert.ToBoolean(dt.Rows[0]["Sof_OperationalManual"].ToString());
                //PortTextBox.Text = dt.Rows[0]["Sof_Port"].ToString();
                //ScemaNameTextBox.Text = dt.Rows[0]["Sof_ScemaName"].ToString();
                //vendorDropDownList.SelectedValue = dt.Rows[0]["Sof_V_slNo"].ToString();
                ViewState["id"] = id;
                addButton.Text = "Update";


            }

        }
    }
}