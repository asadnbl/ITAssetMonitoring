using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Globalization;
using System.Data.SqlTypes;

public partial class Software : System.Web.UI.Page
{
    ITAssetMonitoringDLL oITAssetMonitoringDLL = new ITAssetMonitoringDLL();
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            Session["brCode"] = "1914";
            Session["userId"] = "";
            LoadServerDropDownList();
            LoadVendorDropDownList();
            LoadEmployeeDropDownList();
            LoadresPonsibleDropDownList();
            LoadfallBackDropDownList();
            LoadGridView("");
            SetInitialRow(); 
        }
    }

    private void LoadServerDropDownList()
    {
        DataTable dt = oITAssetMonitoringDLL.GetServer("");
        ServerDropDownList.DataSource = dt;
        ServerDropDownList.DataTextField = "Ser_IP";
        ServerDropDownList.DataValueField = "Ser_slNo";
        ServerDropDownList.DataBind();
        ServerDropDownList.Items.Insert(0, "--Select--");
    }
    private void LoadEmployeeDropDownList()
    {
        DataTable dt = oITAssetMonitoringDLL.GetEmployee("");
        employeeDropDownList.DataSource = dt;
        employeeDropDownList.DataTextField = "Emp_Name";
        employeeDropDownList.DataValueField = "Emp_slNo";
        employeeDropDownList.DataBind();
    }
    private void LoadresPonsibleDropDownList()
    {
        DataTable dt = oITAssetMonitoringDLL.GetEmployee("");
        resPonsibleDropDownList.DataSource = dt;
        resPonsibleDropDownList.DataTextField = "Emp_Name";
        resPonsibleDropDownList.DataValueField = "Emp_slNo";
        resPonsibleDropDownList.DataBind();
    }
    private void LoadfallBackDropDownList()
    {
        DataTable dt = oITAssetMonitoringDLL.GetEmployee("");
        fallBackDropDownList.DataSource = dt;
        fallBackDropDownList.DataTextField = "Emp_Name";
        fallBackDropDownList.DataValueField = "Emp_slNo";
        fallBackDropDownList.DataBind();
    }
    private void LoadVendorDropDownList()
    {
        DataTable dt = oITAssetMonitoringDLL.GetVendor("");
        vendorDropDownList.DataSource = dt;
        vendorDropDownList.DataTextField = "V_Name";
        vendorDropDownList.DataValueField = "V_slNo";
        vendorDropDownList.DataBind();
        vendorDropDownList.Items.Insert(0, "--Select--");
    }
    private void LoadGridView(string condition)
    {
        DataTable dt = oITAssetMonitoringDLL.GetSoftware(condition);
        GridView1.DataSource = dt;
        GridView1.DataBind();
      
        if (dt.Rows.Count > 0)
        {
            sofSLLabel.Text = (Convert.ToInt32(dt.Rows[0]["Sof_slNo"]) + 1).ToString();
            ViewState["sof_slNo"] = dt.Rows[0]["Sof_slNo"];
        }
        else
        {
            sofSLLabel.Text = "1";
        }

    }

    protected void addButton_Click(object sender, EventArgs e)
    {
        string[] formats = { "dd/MM/yyyy", "dd-MM-yyyy", "MM/dd/yyyy", "MM-dd-yyyy", "yyyy/MM/dd", "yyyy-MM-dd" };
        SqlDateTime sqldatenull;
        int i = 0;
        SoftwareClass oSoftwareClass = new SoftwareClass();
        oSoftwareClass.Sof_Name = nameTextBox.Text.Trim();
        try
        {
            oSoftwareClass.Sof_Ser_slNo = Convert.ToInt32(ServerDropDownList.SelectedValue);
        }
        catch { oSoftwareClass.Sof_Ser_slNo = 0; }
        oSoftwareClass.Sof_Type =Sof_TypeTextBox.Text ;
        oSoftwareClass.Sof_EndUser =EndUserTextBox.Text.Trim();
        oSoftwareClass.Sof_BenifitiaryUser =BenifitiaryUserTextBox.Text.Trim();
        oSoftwareClass.Sof_CurrentVirsion =CurrentVirsionTextBox.Text.Trim();
        oSoftwareClass.Sof_HostedLocation =HostedLocationTextBox.Text.Trim();
        oSoftwareClass.Sof_WorkOrder_Date = WorkOrder_DateTextBox.Text;
        oSoftwareClass.Sof_WorkOrder_No = WorOrder_NoTextBox.Text.Trim();
        oSoftwareClass.Sof_Receive_Date = Receive_DateTextBox.Text;
        oSoftwareClass.Sof_UnderAMC = underAMCCheckBox.Checked;
        oSoftwareClass.Sof_Last_Renew_Date = Last_Renew_DateTextBox.Text;
        oSoftwareClass.Sof_Next_Renew_Date = Next_Renew_DateTextBox.Text;

        if (underAMCCheckBox.Checked == true)
        {
            if (oSoftwareClass.Sof_Last_Renew_Date == "")
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Enter Last Renew Date');", true);
                return;
            }
            if (oSoftwareClass.Sof_Next_Renew_Date == "")
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Enter Next Renew Date');", true);
                return;
            }
           
          
        }

        oSoftwareClass.Sof_UAT_Person = 0;

        oSoftwareClass.Sof_UAT_Date =UATsignDateTextBox.Text;
        oSoftwareClass.Sof_NetworkGateway =NetworkGatewayTextBox.Text.Trim();
        oSoftwareClass.Sof_IsHosted =IsHostedCheckBox.Checked;
        oSoftwareClass.Sof_BlackboxTest = BlackboxTestCheckBox.Checked;
        oSoftwareClass.Sof_WhiteboxTest = WhiteboxTestCheckBox.Checked;
        oSoftwareClass.Sof_Vernability = VernabilityCheckBox.Checked;
        oSoftwareClass.Sof_PenitrationTest = PenitrationTestCheckBox.Checked;
        oSoftwareClass.Sof_OperationalManual = OperationalManualCheckBox.Checked;
        oSoftwareClass.Sof_Port = PortTextBox.Text.Trim();
        oSoftwareClass.Sof_ScemaName = ScemaNameTextBox.Text.Trim();
        try
        {
            oSoftwareClass.Sof_V_slNo = Convert.ToInt32(vendorDropDownList.SelectedValue);
        }
        catch { oSoftwareClass.Sof_V_slNo = 0; }
        oSoftwareClass.BrCode = Session["brCode"].ToString();
        oSoftwareClass.User_Id = Session["userId"].ToString();
        oSoftwareClass.Remarks = remarksTextBox.Text;
        try
        {
            oSoftwareClass.Sof_Res_Person = Convert.ToInt32(resPonsibleDropDownList.SelectedValue);
        }
        catch { oSoftwareClass.Sof_Res_Person = 0; }


        if (addButton.Text == "Save")
        {
            i = oITAssetMonitoringDLL.InsertSoftware(oSoftwareClass);
            if (i == 1)
            {

                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Software Information Inserted Successfully!');", true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Software Information Not Inserted!');", true);

            }
        }
        else if (addButton.Text == "Update")
        {
            oSoftwareClass.Sof_slNo = Convert.ToInt32(ViewState["id"]);
            i = oITAssetMonitoringDLL.UpdateSoftware(oSoftwareClass);

            if (i == 1)
            {
                addButton.Text = "Save";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Software Information Updated Successfully!');", true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Software Information Not Updated!');", true);

            }
        }

        for (int j = 0; j < GridView2.Rows.Count; j++)
        {
            Sof_UAT_PersonClass oSof_UAT_PersonClass = new Sof_UAT_PersonClass();
            oSof_UAT_PersonClass.Sof_slNo =Convert.ToInt32(sofSLLabel.Text);
            oSof_UAT_PersonClass.Sof_UAT_Person = Convert.ToInt32(((Label)GridView2.Rows[j].FindControl("Emp_slNoLabel")).Text);
            oITAssetMonitoringDLL.InsOrUpdateSof_UAT_Person(oSof_UAT_PersonClass);
        
        }
        for (int j = 0; j < GridView3.Rows.Count; j++)
        {
            Sof_FallBack_PersonClass oSof_FallBack_PersonClass = new Sof_FallBack_PersonClass();
            oSof_FallBack_PersonClass.Sof_slNo = Convert.ToInt32(sofSLLabel.Text);
            oSof_FallBack_PersonClass.Sof_FallBack_Person = Convert.ToInt32(((Label)GridView3.Rows[j].FindControl("Emp_slNoLabel")).Text);
            oITAssetMonitoringDLL.InsOrUpdateSof_FallBack_Person(oSof_FallBack_PersonClass);

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

            string condition = " where Sof_slNo='" + id + "'";
            // string condition = " where userId='" + userId + "'";
            DataTable dt = oITAssetMonitoringDLL.GetSoftware(condition);
            if (dt.Rows.Count > 0)
            {

                sofSLLabel.Text = id.ToString();
                nameTextBox.Text = dt.Rows[0]["Sof_Name"].ToString();
                try
                {
                    ServerDropDownList.SelectedValue = dt.Rows[0]["Sof_Ser_slNo"].ToString();
                }
                catch { }
                Sof_TypeTextBox.Text = dt.Rows[0]["Sof_Type"].ToString();
                EndUserTextBox.Text = dt.Rows[0]["Sof_EndUser"].ToString();
                BenifitiaryUserTextBox.Text = dt.Rows[0]["Sof_BenifitiaryUser"].ToString();
                CurrentVirsionTextBox.Text = dt.Rows[0]["Sof_CurrentVirsion"].ToString();
                HostedLocationTextBox.Text = dt.Rows[0]["Sof_HostedLocation"].ToString();

                if (string.IsNullOrEmpty(dt.Rows[0]["Sof_WorkOrder_Date"].ToString()))
                    WorkOrder_DateTextBox.Text = "";
                else
                    WorkOrder_DateTextBox.Text = Convert.ToDateTime(dt.Rows[0]["Sof_WorkOrder_Date"].ToString()).ToString("yyyy-MM-dd"); 
                //WorkOrder_DateTextBox.Text= dt.Rows[0]["Sof_WorkOrder_Date"].ToString()== null ? "" :  Convert.ToDateTime(dt.Rows[0]["Sof_WorkOrder_Date"].ToString()).ToString("yyyy-MM-dd");
                WorOrder_NoTextBox.Text = dt.Rows[0]["Sof_WorkOrder_No"].ToString();

                if (string.IsNullOrEmpty(dt.Rows[0]["Sof_Receive_Date"].ToString()))
                    Receive_DateTextBox.Text = "";
                else
                    Receive_DateTextBox.Text = Convert.ToDateTime(dt.Rows[0]["Sof_Receive_Date"].ToString()).ToString("yyyy-MM-dd"); 
                //Receive_DateTextBox.Text = dt.Rows[0]["Sof_Receive_Date"].ToString() == null ? "" : Convert.ToDateTime(dt.Rows[0]["Sof_Receive_Date"].ToString()).ToString("yyyy-MM-dd");
                //underAMCCheckBox.Checked = Convert.ToBoolean(dt.Rows[0]["Sof_UnderAMC"].ToString());

                if (string.IsNullOrEmpty(dt.Rows[0]["Sof_UnderAMC"].ToString()))
                    underAMCCheckBox.Checked = false;
                else
                    underAMCCheckBox.Checked = Convert.ToBoolean(dt.Rows[0]["Sof_UnderAMC"].ToString());

                if (string.IsNullOrEmpty(dt.Rows[0]["Sof_Last_Renew_Date"].ToString()))
                    Last_Renew_DateTextBox.Text = "";
                else
                    Last_Renew_DateTextBox.Text = Convert.ToDateTime(dt.Rows[0]["Sof_Last_Renew_Date"].ToString()).ToString("yyyy-MM-dd"); 

                //Last_Renew_DateTextBox.Text =dt.Rows[0]["Sof_Last_Renew_Date"].ToString()== null ? "" : Convert.ToDateTime(dt.Rows[0]["Sof_Last_Renew_Date"].ToString()).ToString("yyyy-MM-dd");

                if (string.IsNullOrEmpty(dt.Rows[0]["Sof_Next_Renew_Date"].ToString()))
                    Next_Renew_DateTextBox.Text = "";
                else
                    Next_Renew_DateTextBox.Text= Convert.ToDateTime(dt.Rows[0]["Sof_Next_Renew_Date"].ToString()).ToString("yyyy-MM-dd"); 
                
               // Next_Renew_DateTextBox.Text = dt.Rows[0]["Sof_Last_Renew_Date"].ToString() == null ? "" : Convert.ToDateTime(dt.Rows[0]["Sof_Next_Renew_Date"].ToString()).ToString("yyyy-MM-dd"); 
                //employeeDropDownList.SelectedValue = dt.Rows[0]["Sof_UAT_Person"].ToString();
                NetworkGatewayTextBox.Text = dt.Rows[0]["Sof_NetworkGateway"].ToString();
                if (string.IsNullOrEmpty(dt.Rows[0]["Sof_IsHosted"].ToString()))
                    IsHostedCheckBox.Checked = false;
                else
                    IsHostedCheckBox.Checked = Convert.ToBoolean(dt.Rows[0]["Sof_IsHosted"].ToString());
                if (string.IsNullOrEmpty(dt.Rows[0]["Sof_BlackboxTest"].ToString()))
                    BlackboxTestCheckBox.Checked = false;
                else
                    BlackboxTestCheckBox.Checked= Convert.ToBoolean(dt.Rows[0]["Sof_BlackboxTest"].ToString());
                if (string.IsNullOrEmpty(dt.Rows[0]["Sof_WhiteboxTest"].ToString()))
                    WhiteboxTestCheckBox.Checked = false;
                else
                    WhiteboxTestCheckBox.Checked= Convert.ToBoolean(dt.Rows[0]["Sof_WhiteboxTest"].ToString());
                if (string.IsNullOrEmpty(dt.Rows[0]["Sof_Vernability"].ToString()))
                    VernabilityCheckBox.Checked=false;
                else
                    VernabilityCheckBox.Checked = Convert.ToBoolean(dt.Rows[0]["Sof_Vernability"].ToString());
                if (string.IsNullOrEmpty(dt.Rows[0]["Sof_PenitrationTest"].ToString()))
                    PenitrationTestCheckBox.Checked=false;
                else
                    Convert.ToBoolean(dt.Rows[0]["Sof_PenitrationTest"].ToString());
                if (string.IsNullOrEmpty(dt.Rows[0]["Sof_OperationalManual"].ToString()))
                    OperationalManualCheckBox.Checked = false;
                else
                    OperationalManualCheckBox.Checked = Convert.ToBoolean(dt.Rows[0]["Sof_OperationalManual"].ToString());
                //IsHostedCheckBox.Checked =Convert.ToBoolean(dt.Rows[0]["Sof_IsHosted"].ToString());
               // BlackboxTestCheckBox.Checked = Convert.ToBoolean(dt.Rows[0]["Sof_BlackboxTest"].ToString());
               // WhiteboxTestCheckBox.Checked = Convert.ToBoolean(dt.Rows[0]["Sof_WhiteboxTest"].ToString());
                //VernabilityCheckBox.Checked = Convert.ToBoolean(dt.Rows[0]["Sof_Vernability"].ToString());
                //PenitrationTestCheckBox.Checked = Convert.ToBoolean(dt.Rows[0]["Sof_PenitrationTest"].ToString());
               // OperationalManualCheckBox.Checked = Convert.ToBoolean(dt.Rows[0]["Sof_OperationalManual"].ToString());
                PortTextBox.Text = dt.Rows[0]["Sof_Port"].ToString();
                ScemaNameTextBox.Text = dt.Rows[0]["Sof_ScemaName"].ToString();
                try
                {
                    vendorDropDownList.SelectedValue = dt.Rows[0]["Sof_V_slNo"].ToString();
                }
                catch { }
                try
                {
                    resPonsibleDropDownList.SelectedValue = dt.Rows[0]["Sof_Res_Person"].ToString();
                }
                catch { }
                remarksTextBox.Text = dt.Rows[0]["Remarks"].ToString();
                if (string.IsNullOrEmpty(dt.Rows[0]["Sof_UAT_Date"].ToString()))
                    UATsignDateTextBox.Text = "";
                else
                    Convert.ToDateTime(dt.Rows[0]["Sof_UAT_Date"].ToString()).ToString("yyyy-MM-dd"); 
                ViewState["id"] = id;

                DataTable dtCurrentTable = oITAssetMonitoringDLL.GetSof_UAT_Person(" Where Sof_UAT_Person.Sof_slNo="+id+"");
                ViewState["CurrentTable"] = dtCurrentTable;

                if (dtCurrentTable.Rows.Count > 0)
                {
                    //Re bind the GridView for the updated data  
                    GridView2.DataSource = dtCurrentTable;
                    GridView2.DataBind();
                }
                else 
                { 
                    SetInitialRow();
                    GridView2.DataSource = dtCurrentTable;
                    GridView2.DataBind();
                }
                DataTable dtCurrentTable1 = oITAssetMonitoringDLL.GetSof_FallBack_Person(" Where Sof_FallBack_Person.Sof_slNo=" + id + "");
                ViewState["CurrentTable1"] = dtCurrentTable1;

                if (dtCurrentTable1.Rows.Count > 0)
                {
                    //Re bind the GridView for the updated data  
                    GridView3.DataSource = dtCurrentTable1;
                    GridView3.DataBind();
                }
                else
                {
                    SetInitialRow1();
                    GridView3.DataSource = dtCurrentTable1;
                    GridView3.DataBind();
                }
                    //(DataTable)ViewState["CurrentTable"];
                addButton.Text = "Update";


            }

        }
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        LinkButton lb = (LinkButton)sender;
        GridViewRow gvRow = (GridViewRow)lb.NamingContainer;
        int rowID = gvRow.RowIndex;
        if (ViewState["CurrentTable"] != null)
        {

            DataTable dt = (DataTable)ViewState["CurrentTable"];
            if (dt.Rows.Count > 0)
            {
                if (gvRow.RowIndex < dt.Rows.Count)
                {
                    if (addButton.Text == "Update")
                    {

                            int index = gvRow.RowIndex; //gets the row index selected
                            int id = Convert.ToInt32(GridView2.DataKeys[index].Value.ToString());
                            oITAssetMonitoringDLL.DeleteSof_UAT_Person(" Where Sof_slNo=" + sofSLLabel.Text + " and Sof_UAT_Person="+id+"");
                        
                    }
                    //Remove the Selected Row data and reset row number   
                    dt.Rows.Remove(dt.Rows[rowID]);
                    ResetRowID(dt);
                }
            }

            //Store the current data in ViewState for future reference  
            ViewState["CurrentTable"] = dt;

            //Re bind the GridView for the updated data  
            GridView2.DataSource = dt;
            GridView2.DataBind();
        }   
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        LinkButton lb = (LinkButton)sender;
        GridViewRow gvRow = (GridViewRow)lb.NamingContainer;
        int rowID = gvRow.RowIndex;
        if (ViewState["CurrentTable1"] != null)
        {

            DataTable dt = (DataTable)ViewState["CurrentTable1"];
            if (dt.Rows.Count > 0)
            {
                if (gvRow.RowIndex < dt.Rows.Count)
                {
                    if (addButton.Text == "Update")
                    {

                        int index = gvRow.RowIndex; //gets the row index selected
                        int id = Convert.ToInt32(GridView3.DataKeys[index].Value.ToString());
                        oITAssetMonitoringDLL.DeleteSof_FallBack_Person(" Where Sof_slNo=" + sofSLLabel.Text + " and Sof_FallBack_Person=" + id + "");

                    }
                    //Remove the Selected Row data and reset row number   
                    dt.Rows.Remove(dt.Rows[rowID]);
                    ResetRowID(dt);
                }
            }

            //Store the current data in ViewState for future reference  
            ViewState["CurrentTable1"] = dt;

            //Re bind the GridView for the updated data  
            GridView3.DataSource = dt;
            GridView3.DataBind();
        }
    }
    private void SetInitialRow()
    {

        DataTable dt = new DataTable();
        DataRow dr = null;


        dt.Columns.Add(new DataColumn("Emp_slNo", typeof(string)));//for TextBox value   
        dt.Columns.Add(new DataColumn("Emp_Name", typeof(string)));//for TextBox value   
      

        dr = dt.NewRow();

        dr["Emp_slNo"] = string.Empty;
        dr["Emp_Name"] = string.Empty;
        dt.Rows.Add(dr);

        //Store the DataTable in ViewState for future reference   
        ViewState["CurrentTable"] = dt;

        //Bind the Gridview   
        //GridView2.DataSource = dt;
        //GridView2.DataBind();

        //After binding the gridview, we can then extract and fill the DropDownList with Data   
       
    }
    private void SetInitialRow1()
    {

        DataTable dt = new DataTable();
        DataRow dr = null;


        dt.Columns.Add(new DataColumn("Emp_slNo", typeof(string)));//for TextBox value   
        dt.Columns.Add(new DataColumn("Emp_Name", typeof(string)));//for TextBox value   


        dr = dt.NewRow();

        dr["Emp_slNo"] = string.Empty;
        dr["Emp_Name"] = string.Empty;
        dt.Rows.Add(dr);

        //Store the DataTable in ViewState for future reference   
        ViewState["CurrentTable1"] = dt;

        //Bind the Gridview   
        //GridView2.DataSource = dt;
        //GridView2.DataBind();

        //After binding the gridview, we can then extract and fill the DropDownList with Data   

    }
    private void AddNewRowToGrid1()
    {

        if (ViewState["CurrentTable1"] != null)
        {

            DataTable dtCurrentTable = (DataTable)ViewState["CurrentTable1"];
            DataRow drCurrentRow = null;

            if (dtCurrentTable.Rows.Count > 0)
            {
                drCurrentRow = dtCurrentTable.NewRow();
                drCurrentRow["Emp_slNo"] =fallBackDropDownList.SelectedValue;
                drCurrentRow["Emp_Name"] = fallBackDropDownList.SelectedItem.Text;
                //add new row to DataTable   
                dtCurrentTable.Rows.Add(drCurrentRow);
                //Store the current data to ViewState for future reference   

                ViewState["CurrentTable"] = dtCurrentTable;

                if (string.IsNullOrEmpty(dtCurrentTable.Rows[0]["Emp_slNo"].ToString()))
                {
                    dtCurrentTable.Rows.RemoveAt(0);
                }
                ViewState["CurrentTable1"] = dtCurrentTable;
                //Rebind the Grid with the current data to reflect changes   
                GridView3.DataSource = dtCurrentTable;
                GridView3.DataBind();
            }
            else
            {
                SetInitialRow1();
            }
        }
        else
        {
            Response.Write("ViewState is null");

        }
        //Set Previous Data on Postbacks   

    }
    private void AddNewRowToGrid()
    {

        if (ViewState["CurrentTable"] != null)
        {

            DataTable dtCurrentTable = (DataTable)ViewState["CurrentTable"];
            DataRow drCurrentRow = null;

            if (dtCurrentTable.Rows.Count > 0)
            {
                drCurrentRow = dtCurrentTable.NewRow();
                drCurrentRow["Emp_slNo"] = employeeDropDownList.SelectedValue;
                drCurrentRow["Emp_Name"] = employeeDropDownList.SelectedItem.Text;
                //add new row to DataTable   
                dtCurrentTable.Rows.Add(drCurrentRow);
                //Store the current data to ViewState for future reference   

                ViewState["CurrentTable"] = dtCurrentTable;

                if (string.IsNullOrEmpty(dtCurrentTable.Rows[0]["Emp_slNo"].ToString()))
                {
                    dtCurrentTable.Rows.RemoveAt(0);
                }
                ViewState["CurrentTable"] = dtCurrentTable;
                //Rebind the Grid with the current data to reflect changes   
                GridView2.DataSource = dtCurrentTable;
                GridView2.DataBind();
            }
            else
            {
                SetInitialRow(); 
            }
        }
        else
        {
            Response.Write("ViewState is null");

        }
        //Set Previous Data on Postbacks   
        
    }
    protected void okButton_Click(object sender, EventArgs e)
    {
        AddNewRowToGrid();  
    }
    protected void Gridview3_RowCreated(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            DataTable dt = (DataTable)ViewState["CurrentTable1"];


            LinkButton lb = (LinkButton)e.Row.FindControl("LinkButton2");
            if (lb != null)
            {
                if (dt.Rows.Count > 1)
                {

                    if (e.Row.RowIndex == dt.Rows.Count - 1)
                    {
                        lb.Visible = false;
                    }
                }
                else
                {
                    lb.Visible = false;
                }
            }
        }
    }
    protected void Gridview2_RowCreated(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            DataTable dt = (DataTable)ViewState["CurrentTable"];

         
            LinkButton lb = (LinkButton)e.Row.FindControl("LinkButton1");
            if (lb != null)
            {
                if (dt.Rows.Count > 1)
                {
                   
                    if (e.Row.RowIndex == dt.Rows.Count - 1)
                    {
                        lb.Visible = false;
                    }
                }
                else
                {
                    lb.Visible = false;
                }
            }
        }
    }
    private void ResetRowID(DataTable dt)
    {
        int rowNumber = 1;
        if (dt.Rows.Count > 0)
        {
            foreach (DataRow row in dt.Rows)
            {
                row[0] = rowNumber;
                rowNumber++;
            }
        }
    }
    protected void fallbackAddButton_Click(object sender, EventArgs e)
    {
        AddNewRowToGrid1(); 
    }
}