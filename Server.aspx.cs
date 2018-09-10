using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Globalization;

public partial class Server : System.Web.UI.Page
{
    ITAssetMonitoringDLL oITAssetMonitoringDLL = new ITAssetMonitoringDLL();
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            Session["brCode"] = "1914";
            Session["userId"] = "";
            LoadSoftwareDropDownList();
            LoadVendorDropDownList();
            LoadEmployeeDropDownList();
            LoadServerDropDownList();
            LoadGridView("");
        }
    }

    private void LoadServerDropDownList()
    {
        DataTable dt = oITAssetMonitoringDLL.GeIpAddress("");
        Ser_IPTextBox.DataSource = dt;
        Ser_IPTextBox.DataTextField = "IP_Address";
        Ser_IPTextBox.DataValueField = "IP_Address";
        Ser_IPTextBox.DataBind();
    }
    private void LoadSoftwareDropDownList()
    {
        DataTable dt = oITAssetMonitoringDLL.GetSoftware(" Where (Software.Sof_Name like '%WIN%' OR Software.Sof_Name like '%UNIX%' OR Software.Sof_Name like '%LINUX%')");
       Ser_Sof_DropDownList.DataSource = dt;
       Ser_Sof_DropDownList.DataTextField = "Sof_Name";
       Ser_Sof_DropDownList.DataValueField = "Sof_slNo";
       Ser_Sof_DropDownList.DataBind();
    }
    private void LoadEmployeeDropDownList()
    {
       DataTable dt = oITAssetMonitoringDLL.GetEmployee("");
       employeeDropDownList.DataSource = dt;
       employeeDropDownList.DataTextField = "Emp_Name";
       employeeDropDownList.DataValueField = "Emp_slNo";
       employeeDropDownList.DataBind();
       employeeDropDownList.Items.Insert(0, "--Select--");
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
        DataTable dt = oITAssetMonitoringDLL.GetServer(condition);
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }

    protected void addButton_Click(object sender, EventArgs e)
    {
        string[] formats = { "yyyy-MM-dd"};

        int i = 0;
        ServerClass oServerClass = new ServerClass();
        oServerClass.Ser_Name = nameTextBox.Text.Trim();
        oServerClass.Ser_Manufacture_Name =manufactureTextBox.Text.Trim();
        oServerClass.Ser_Model =modelTextBox.Text.Trim();
        oServerClass.Ser_Serial =serialNoTextBox.Text.Trim();
        oServerClass.Ser_IP =Ser_IPTextBox.SelectedItem.Text.Trim();
        oServerClass.Ser_Sof_slNo =Convert.ToInt32(Ser_Sof_DropDownList.SelectedValue);
        oServerClass.Ser_Storage =Ser_StorageTextBox.Text.Trim();
        oServerClass.Ser_Criticality =Ser_CriticalityTextBox.Text.Trim();
        oServerClass.Ser_Location =Ser_LocationTextBox.Text.Trim();
        oServerClass.Ser_RackNo =Ser_RackNoTextBox.Text.Trim();
        oServerClass.Ser_WarratyStatus =Ser_WaranteePeriodDropDownList.SelectedValue;
        oServerClass.Ser_Warranty_Start_Date = warrantyStartDateTextBox.Text;
        oServerClass.Ser_Warranty_Expired_Date = warrantyExpiredDateTextBox.Text;
        oServerClass.Ser_Challan_No=challanNoTextBox.Text;
        oServerClass.Ser_Network_PortName=networkPortNameTextBox.Text;
        oServerClass.Ser_Patch_PannelNo=patchPanelNoTextBox.Text;
        oServerClass.Ser_WorkOrder_Date =WorkOrder_DateTextBox.Text ;
        oServerClass.Ser_WorOrder_No =WorOrder_NoTextBox.Text.Trim();
        oServerClass.Ser_Receive_Date = Receive_DateTextBox.Text;
        oServerClass.Ser_UnderAMC =underAMCCheckBox.Checked;
        oServerClass.Ser_UAT_Person =Convert.ToInt32(employeeDropDownList.SelectedValue);
        oServerClass.Ser_PortOpen = PortOpenTextBox.Text.Trim();
        oServerClass.Ser_Last_Renew_Date = Last_Renew_DateTextBox.Text;
        oServerClass.Ser_Next_Renew_Date = Last_Renew_DateTextBox.Text;
        oServerClass.Ser_V_SlNo =Convert.ToInt32(vendorDropDownList.SelectedValue);
        oServerClass.BrCode = Session["brCode"].ToString();
        oServerClass.User_Id = Session["userId"].ToString();
        oServerClass.Remarks = remarksTextBox.Text;
        if (underAMCCheckBox.Checked == true)
        {
            if (oServerClass.Ser_Last_Renew_Date == "")
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Enter Last Renew Date');", true);
                return;
            }
            if (oServerClass.Ser_Next_Renew_Date == "")
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Enter Next Renew Date');", true);
                return;
            }


        }
        
        if (addButton.Text == "Add")
        {
            i = oITAssetMonitoringDLL.InsertServer(oServerClass);
            if (i == 1)
            {

                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Server Information Inserted Successfully!');", true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Server Information Not Inserted!');", true);

            }
        }
        else if (addButton.Text == "Update")
        {
            oServerClass.Ser_slNo = Convert.ToInt32(ViewState["id"]);
            i = oITAssetMonitoringDLL.UpdateServer(oServerClass);

            if (i == 1)
            {
                addButton.Text = "Add";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Server Information Updated Successfully!');", true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Server Information Not Updated!');", true);

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

            string condition = " where Ser_slNo='" + id + "'";
            // string condition = " where userId='" + userId + "'";
            DataTable dt = oITAssetMonitoringDLL.GetServer(condition);
            if (dt.Rows.Count > 0)
            {
                               
                nameTextBox.Text = dt.Rows[0]["Ser_Name"].ToString();
                manufactureTextBox.Text = dt.Rows[0]["Ser_Manufacture_Name"].ToString();
                modelTextBox.Text = dt.Rows[0]["Ser_Model"].ToString();
                serialNoTextBox.Text = dt.Rows[0]["Ser_Serial"].ToString();
                Ser_IPTextBox.SelectedItem.Value = dt.Rows[0]["Ser_IP"].ToString();
                try
                {
                    Ser_Sof_DropDownList.SelectedValue = dt.Rows[0]["Ser_Sof_slNo"].ToString();
                }
                catch
                {
                    Ser_Sof_DropDownList.SelectedValue = "1";
                }
                Ser_StorageTextBox.Text = dt.Rows[0]["Ser_Storage"].ToString();
                Ser_CriticalityTextBox.Text = dt.Rows[0]["Ser_Criticality"].ToString();
                Ser_LocationTextBox.Text = dt.Rows[0]["Ser_Location"].ToString();
                Ser_RackNoTextBox.Text = dt.Rows[0]["Ser_RackNo"].ToString();
                try
                {
                    Ser_WaranteePeriodDropDownList.SelectedValue = dt.Rows[0]["Ser_WarratyStatus"].ToString();
                }
                catch 
                {
                    //Ser_WaranteePeriodDropDownList.SelectedValue = "0";
                }

                if (string.IsNullOrEmpty(dt.Rows[0]["Ser_WorkOrder_Date"].ToString()))
                    WorkOrder_DateTextBox.Text = "";
                else
                    WorkOrder_DateTextBox.Text = Convert.ToDateTime(dt.Rows[0]["Ser_WorkOrder_Date"].ToString()).ToString("yyyy-MM-dd");
                if (string.IsNullOrEmpty(dt.Rows[0]["Ser_UnderAMC"].ToString()))
                    underAMCCheckBox.Checked = false;
                else
                    underAMCCheckBox.Checked = Convert.ToBoolean(dt.Rows[0]["Ser_UnderAMC"].ToString());
                if (string.IsNullOrEmpty(dt.Rows[0]["Ser_Last_Renew_Date"].ToString()))
                    Last_Renew_DateTextBox.Text = "";
                else
                    Last_Renew_DateTextBox.Text = Convert.ToDateTime(dt.Rows[0]["Ser_Last_Renew_Date"].ToString()).ToString("yyyy-MM-dd");
                if (string.IsNullOrEmpty(dt.Rows[0]["Ser_Next_Renew_Date"].ToString()))
                    Next_Renew_DateTextBox.Text = "";
                else
                    Next_Renew_DateTextBox.Text = Convert.ToDateTime(dt.Rows[0]["Ser_Next_Renew_Date"].ToString()).ToString("yyyy-MM-dd");

                if (string.IsNullOrEmpty(dt.Rows[0]["Ser_Warranty_Start_Date"].ToString()))
                   warrantyStartDateTextBox.Text = "";
                else
                    warrantyStartDateTextBox.Text = Convert.ToDateTime(dt.Rows[0]["Ser_Warranty_Start_Date"].ToString()).ToString("yyyy-MM-dd");

                if (string.IsNullOrEmpty(dt.Rows[0]["Ser_Warranty_Expired_Date"].ToString()))
                    warrantyExpiredDateTextBox.Text = "";
                else
                    warrantyExpiredDateTextBox.Text = Convert.ToDateTime(dt.Rows[0]["Ser_Warranty_Expired_Date"].ToString()).ToString("yyyy-MM-dd");
                remarksTextBox.Text = dt.Rows[0]["Remarks"].ToString();
                networkPortNameTextBox.Text = dt.Rows[0]["Ser_Network_PortName"].ToString();
                challanNoTextBox.Text = dt.Rows[0]["Ser_Challan_No"].ToString();
                patchPanelNoTextBox.Text = dt.Rows[0]["Ser_Patch_PannelNo"].ToString();
                WorOrder_NoTextBox.Text = dt.Rows[0]["Ser_WorOrder_No"].ToString();
                if (string.IsNullOrEmpty(dt.Rows[0]["Ser_Receive_Date"].ToString()))
                    Receive_DateTextBox.Text = "";
                else
                    Receive_DateTextBox.Text = Convert.ToDateTime(dt.Rows[0]["Ser_Receive_Date"].ToString()).ToString("yyyy-MM-dd");


                try
                {
                    employeeDropDownList.SelectedValue = string.IsNullOrEmpty(dt.Rows[0]["Ser_UAT_Person"].ToString()) ? "0" : dt.Rows[0]["Ser_UAT_Person"].ToString();
                }
                catch 
                { employeeDropDownList.SelectedItem.Text = "--Select--"; }
                PortOpenTextBox.Text = dt.Rows[0]["Ser_PortOpen"].ToString();
                ViewState["id"] = id;
                addButton.Text = "Update";


            }

        }
    }

    protected void okButton_Click(object sender, EventArgs e)
    {
        ipTextBox.Visible = true;
    }
    protected void ipTextBox_TextChanged(object sender, EventArgs e)
    {
        int i = oITAssetMonitoringDLL.InsertIP_Address(ipTextBox.Text.Trim());
        if (i == 1)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('IP Information Inserted Successfully!');", true);
            LoadServerDropDownList();
        }
        else
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('IP Information Not Inserted!');", true);
        }
        ipTextBox.Visible = false;
    }
}