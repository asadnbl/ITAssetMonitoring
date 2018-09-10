using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Vendor : System.Web.UI.Page
{
    ITAssetMonitoringDLL oITAssetMonitoringDLL = new ITAssetMonitoringDLL();
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            Session["brCode"] = "1914";
            Session["userId"] = "";
            LoadVendor("");
        }
    }

    private void LoadVendor(string condition)
    {
        DataTable dt = oITAssetMonitoringDLL.GetVendor(condition);
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }
       
    protected void addButton_Click(object sender, EventArgs e)
    {
       
        int i = 0;
        VendorClass oVendorClass = new VendorClass();
        oVendorClass.V_Name = nameTextBox.Text.Trim();
        oVendorClass.V_ContactPerson = contactPersonTextBox.Text.Trim();
        oVendorClass.V_ContactNo = contactTextBox.Text.Trim();
        oVendorClass.V_Address = addressTextBox.Text.Trim();
        oVendorClass.V_Email = emailTextBox.Text.Trim();
        oVendorClass.BrCode = Session["brCode"].ToString();
        oVendorClass.User_Id = Session["userId"].ToString();
        oVendorClass.Remarks = remarksTextBox.Text;
        if(addButton.Text=="Add")
        {
            i = oITAssetMonitoringDLL.InsertVendor(oVendorClass);
            if (i == 1)
            {
               
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Vendor Information Inserted Successfully!');", true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Vendor Information Not Inserted!');", true);

            }
        }
        else if (addButton.Text == "Update")
        {
            oVendorClass.V_slNo =Convert.ToInt32(ViewState["id"]);
            i = oITAssetMonitoringDLL.UpdateVendor(oVendorClass);

            if (i == 1)
            {
                addButton.Text = "Add";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Vendor Information Updated Successfully!');", true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Vendor Information Not Updated!');", true);
   
            }
        }
        LoadVendor("");
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        LoadVendor("");
    }
    protected void btnEdit_Click(object sender, EventArgs e)
    {

        LinkButton b = (LinkButton)sender;
        GridViewRow row = (GridViewRow)b.NamingContainer;
        if (row != null)
        {
            int index = row.RowIndex; //gets the row index selected
            int id = Convert.ToInt32(GridView1.DataKeys[index].Value.ToString());
             
                string condition = " where V_slNo='" + id + "'";
                // string condition = " where userId='" + userId + "'";
                DataTable dt = oITAssetMonitoringDLL.GetVendor(condition);
                if (dt.Rows.Count > 0)
                {
                    nameTextBox.Text = dt.Rows[0]["V_Name"].ToString();
                    contactPersonTextBox.Text = dt.Rows[0]["V_ContactPerson"].ToString();
                    contactTextBox.Text = dt.Rows[0]["V_ContactNo"].ToString();
                    addressTextBox.Text = dt.Rows[0]["V_Address"].ToString();
                    emailTextBox.Text = dt.Rows[0]["V_Email"].ToString();
                    remarksTextBox.Text = dt.Rows[0]["Remarks"].ToString();
                    ViewState["id"] = id;
                    addButton.Text = "Update";

                   
                }
              
        }
    }
}