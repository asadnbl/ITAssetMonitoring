using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Globalization;

public partial class NetworkDevice : System.Web.UI.Page
{
    ITAssetMonitoringDLL oITAssetMonitoringDLL = new ITAssetMonitoringDLL();
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            Session["brCode"] = "1914";
            Session["userId"] = "";
           // LoadSoftwareDropDownList();
            LoadVendorDropDownList();
            LoadEmployeeDropDownList();
            LoadGridView("");
        }
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
        DataTable dt = oITAssetMonitoringDLL.GetNetworkDevice(condition);
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }

    protected void addButton_Click(object sender, EventArgs e)
    {
        string[] formats = { "yyyy-MM-dd" };

        int i = 0;
        NetworkDeviceClass oNetworkDeviceClass = new NetworkDeviceClass();
        oNetworkDeviceClass.NetD_Serial = serialNoTextBox.Text.Trim();
        oNetworkDeviceClass.NetD_HostName = hostNameTextBox.Text.Trim();
        oNetworkDeviceClass.NetD_Name = nameTextBox.Text.Trim();
        oNetworkDeviceClass.NetD_Type =NetD_TypeDropDownList.SelectedValue;
        oNetworkDeviceClass.NetD_V_SlNo = Convert.ToInt32(vendorDropDownList.SelectedValue);
        oNetworkDeviceClass.NetD_Model =modelTextBox.Text.Trim();
        oNetworkDeviceClass.NetD_ChallanNo =challanNoTextBox.Text.Trim();
        oNetworkDeviceClass.NetD_Criticality = CriticalityTextBox.Text.Trim();
        oNetworkDeviceClass.NetD_Location = LocationTextBox.Text.Trim();
        oNetworkDeviceClass.NetD_RackNo = RackNoTextBox.Text.Trim();
        oNetworkDeviceClass.NetD_ChallanDate =challanDateTextBox.Text;
        oNetworkDeviceClass.NetD_WorkOrder_Date = WorkOrder_DateTextBox.Text;
        oNetworkDeviceClass.NetD_WorkOrder_No = WorOrder_NoTextBox.Text.Trim();
        oNetworkDeviceClass.NetD_Receive_Date = Receive_DateTextBox.Text;
        oNetworkDeviceClass.NetD_UnderAMC = underAMCCheckBox.Checked;
       // oNetworkDeviceClass.NetD_Last_Renew_Date = DateTime.ParseExact(Last_Renew_DateTextBox.Text, formats, new CultureInfo("en-US"), DateTimeStyles.None);
        //oNetworkDeviceClass.NetD_Next_Renew_Date = DateTime.ParseExact(Next_Renew_DateTextBox.Text, formats, new CultureInfo("en-US"), DateTimeStyles.None);
        oNetworkDeviceClass.NetD_UAT_Person = Convert.ToInt32(employeeDropDownList.SelectedValue);
        oNetworkDeviceClass.NetD_BillDate =billDateTextBox.Text.Trim();

        oNetworkDeviceClass.NetD_Last_Renew_Date = Last_Renew_DateTextBox.Text;
        oNetworkDeviceClass.NetD_Next_Renew_Date = Next_Renew_DateTextBox.Text;
        oNetworkDeviceClass.Ser_WaranteePeriod = Ser_WaranteePeriodDropDownList.SelectedValue;
        if (underAMCCheckBox.Checked == true)
        {
            if (oNetworkDeviceClass.NetD_Last_Renew_Date == "")
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Enter Last Renew Date');", true);
                return;
            }
            if (oNetworkDeviceClass.NetD_Next_Renew_Date == "")
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Enter Next Renew Date');", true);
                return;
            }


        }

        oNetworkDeviceClass.Remarks = remarksTextBox.Text;
        oNetworkDeviceClass.BrCode = Session["brCode"].ToString();
        oNetworkDeviceClass.User_Id = Session["userId"].ToString();
        if (addButton.Text == "Add")
        {
            i = oITAssetMonitoringDLL.InsertNetworkDevice(oNetworkDeviceClass);
            if (i == 1)
            {

                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Network Device Information Inserted Successfully!');", true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Network Device Information Not Inserted!');", true);

            }
        }
        else if (addButton.Text == "Update")
        {
            oNetworkDeviceClass.NetD_slNo = Convert.ToInt32(ViewState["id"]);
            i = oITAssetMonitoringDLL.UpdateNetworkDevice(oNetworkDeviceClass);

            if (i == 1)
            {
                addButton.Text = "Add";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Network Device Information Updated Successfully!');", true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Network Device Information Not Updated!');", true);

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

            string condition = " where NetD_slNo='" + id + "'";
            // string condition = " where userId='" + userId + "'";
            DataTable dt = oITAssetMonitoringDLL.GetNetworkDevice(condition);
            if (dt.Rows.Count > 0)
            {

                hostNameTextBox.Text = dt.Rows[0]["NetD_HostName"].ToString();
                serialNoTextBox.Text = dt.Rows[0]["NetD_Serial"].ToString();
                nameTextBox.Text = dt.Rows[0]["NetD_Name"].ToString();
                NetD_TypeDropDownList.SelectedValue = dt.Rows[0]["NetD_Type"].ToString();
                vendorDropDownList.SelectedValue = dt.Rows[0]["NetD_V_SlNo"].ToString();
                modelTextBox.Text = dt.Rows[0]["NetD_Model"].ToString();
                challanNoTextBox.Text = dt.Rows[0]["NetD_ChallanNo"].ToString();
                CriticalityTextBox.Text = dt.Rows[0]["NetD_Criticality"].ToString();
                LocationTextBox.Text = dt.Rows[0]["NetD_Location"].ToString();
                RackNoTextBox.Text = dt.Rows[0]["NetD_RackNo"].ToString();

                if (string.IsNullOrEmpty(dt.Rows[0]["NetD_WorkOrder_Date"].ToString()))
                    WorkOrder_DateTextBox.Text = "";
                else
                    WorkOrder_DateTextBox.Text = Convert.ToDateTime(dt.Rows[0]["NetD_WorkOrder_Date"].ToString()).ToString("yyyy-MM-dd");

                if (string.IsNullOrEmpty(dt.Rows[0]["NetD_ChallanDate"].ToString()))
                    challanDateTextBox.Text = "";
                else
                    challanDateTextBox.Text = Convert.ToDateTime(dt.Rows[0]["NetD_ChallanDate"].ToString()).ToString("yyyy-MM-dd");

                if (string.IsNullOrEmpty(dt.Rows[0]["NetD_Last_Renew_Date"].ToString()))
                    Last_Renew_DateTextBox.Text = "";
                else
                    Last_Renew_DateTextBox.Text = Convert.ToDateTime(dt.Rows[0]["NetD_Last_Renew_Date"].ToString()).ToString("yyyy-MM-dd");

                if (string.IsNullOrEmpty(dt.Rows[0]["NetD_Next_Renew_Date"].ToString()))
                    Next_Renew_DateTextBox.Text = "";
                else
                    Next_Renew_DateTextBox.Text = Convert.ToDateTime(dt.Rows[0]["NetD_Next_Renew_Date"].ToString()).ToString("yyyy-MM-dd");

                if (string.IsNullOrEmpty(dt.Rows[0]["NetD_Receive_Date"].ToString()))
                    Receive_DateTextBox.Text = "";
                else
                    Receive_DateTextBox.Text = Convert.ToDateTime(dt.Rows[0]["NetD_Receive_Date"].ToString()).ToString("yyyy-MM-dd");

                if (string.IsNullOrEmpty(dt.Rows[0]["NetD_BillDate"].ToString()))
                   billDateTextBox.Text = "";
                else
                    billDateTextBox.Text = Convert.ToDateTime(dt.Rows[0]["NetD_BillDate"].ToString()).ToString("yyyy-MM-dd");


                if (string.IsNullOrEmpty(dt.Rows[0]["NetD_UnderAMC"].ToString()))
                    underAMCCheckBox.Checked = false;
                else
                    underAMCCheckBox.Checked = Convert.ToBoolean(dt.Rows[0]["NetD_UnderAMC"].ToString());

                remarksTextBox.Text = dt.Rows[0]["Remarks"].ToString();
                //challanDateTextBox.Text = dt.Rows[0]["NetD_ChallanDate"].ToString();
               // WorkOrder_DateTextBox.Text = dt.Rows[0]["NetD_WorkOrder_Date"].ToString()== null ? "" :Convert.ToDateTime(dt.Rows[0]["NetD_WorkOrder_Date"].ToString()).ToString("yyyy-MM-dd");
                WorOrder_NoTextBox.Text = dt.Rows[0]["NetD_WorkOrder_No"].ToString();
                //Receive_DateTextBox.Text = dt.Rows[0]["NetD_Receive_Date"].ToString()== null ? "" :Convert.ToDateTime(dt.Rows[0]["NetD_Receive_Date"].ToString()).ToString("yyyy-MM-dd");
                underAMCCheckBox.Checked = Convert.ToBoolean(dt.Rows[0]["NetD_UnderAMC"].ToString());
                //Last_Renew_DateTextBox.Text = dt.Rows[0]["NetD_Last_Renew_Date"].ToString()== null ? "" :Convert.ToDateTime(dt.Rows[0]["NetD_Last_Renew_Date"].ToString()).ToString("yyyy-MM-dd");
                //Next_Renew_DateTextBox.Text = dt.Rows[0]["NetD_Next_Renew_Date"].ToString() == null ? "" : Convert.ToDateTime(dt.Rows[0]["NetD_Next_Renew_Date"].ToString()).ToString("yyyy-MM-dd");
                try
                {
                    employeeDropDownList.SelectedValue = string.IsNullOrEmpty(dt.Rows[0]["NetD_UAT_Person"].ToString()) ? "0" : dt.Rows[0]["NetD_UAT_Person"].ToString();
                }
                catch
                { employeeDropDownList.SelectedItem.Text = "--Select--"; }

                Ser_WaranteePeriodDropDownList.SelectedValue = dt.Rows[0]["Ser_WaranteePeriod"].ToString();

               // employeeDropDownList.SelectedValue = dt.Rows[0]["Ser_UAT_Person"].ToString();
                //CurrentVersionTextBox.Text = dt.Rows[0]["NetD_CurrentVersion"].ToString();
                ViewState["id"] = id;
                addButton.Text = "Update";


            }

        }
    }
    protected void addButton_Click1(object sender, EventArgs e)
    {

    }
}