using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class DeviceList : System.Web.UI.Page
{
    ITAssetMonitoringDLL oITAssetMonitoringDLL = new ITAssetMonitoringDLL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadSoftwareGridView("");
            LoadNetworkDeviceGridView("");
            LoadServerGridView("");
            LoadDBGridView("");
            LoadBackupGridView("");
            GridView2.Visible = false;
            GridView3.Visible = false;
            GridView4.Visible = false;
            GridView5.Visible = false;

        }

    }
    private void LoadBackupGridView(string condition)
    {
        DataTable dt = oITAssetMonitoringDLL.GetBackup(condition);
        GridView5.DataSource = dt;
        GridView5.DataBind();
    }
    private void LoadServerGridView(string condition)
    {
        DataTable dt = oITAssetMonitoringDLL.GetServer(condition);
        DataView view = dt.DefaultView;
        view.Sort = "Ser_slNo ASC";
        DataTable dt1 = view.ToTable();
        GridView2.DataSource = dt1;
        GridView2.DataBind();
    }
    private void LoadNetworkDeviceGridView(string condition)
    {
        DataTable dt = oITAssetMonitoringDLL.GetNetworkDevice(condition);
        DataView view = dt.DefaultView;
        view.Sort = "NetD_slNo ASC";
        DataTable dt1 = view.ToTable();
        GridView3.DataSource = dt1;
        GridView3.DataBind();
    }
    private void LoadSoftwareGridView(string condition)
    {
        DataTable dt = oITAssetMonitoringDLL.GetSoftware(condition);
        DataView view = dt.DefaultView;
        view.Sort = "Sof_slNo ASC";
        DataTable dt1 = view.ToTable();
        GridView1.DataSource = dt1;
        GridView1.DataBind();
    }
    private void LoadDBGridView(string condition)
    {
        DataTable dt = oITAssetMonitoringDLL.GetDB(condition);
        GridView4.DataSource = dt;
        GridView4.DataBind();
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (DropDownList1.SelectedValue == "1")
        {
            GridView1.Visible = true;
            GridView2.Visible = false;
            GridView3.Visible = false;
            GridView4.Visible = false;
            GridView5.Visible = false;
        }
        else if (DropDownList1.SelectedValue == "2")
        {
            GridView1.Visible = false;
            GridView2.Visible = true;
            GridView3.Visible = false;
            GridView4.Visible = false;
            GridView5.Visible = false;
        }
        else if (DropDownList1.SelectedValue == "3")
        {
            GridView1.Visible = false;
            GridView2.Visible = false;
            GridView3.Visible = true;
            GridView4.Visible = false;
            GridView5.Visible = false;
        }
        else if (DropDownList1.SelectedValue == "4")
        {
            GridView1.Visible = false;
            GridView2.Visible = false;
            GridView3.Visible = false;
            GridView4.Visible = true;
            GridView5.Visible = false;
        }
        else if (DropDownList1.SelectedValue == "5")
        {
            GridView1.Visible = false;
            GridView2.Visible = false;
            GridView3.Visible = false;
            GridView4.Visible = false;
            GridView5.Visible = true;
        }
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        LoadSoftwareGridView("");
    }
    protected void GridView2_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView2.PageIndex = e.NewPageIndex;
        LoadServerGridView("");
    }
    protected void GridView3_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView3.PageIndex = e.NewPageIndex;
        LoadNetworkDeviceGridView("");
    }
    protected void GridView4_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView4.PageIndex = e.NewPageIndex;
        LoadDBGridView("");
    }
    protected void GridView5_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView5.PageIndex = e.NewPageIndex;
        LoadBackupGridView("");
    }
    protected void btnEdit_Click(object sender, EventArgs e)
    {
        int id = 0;
        int index = 0;
        string dName = "";
        LinkButton b = (LinkButton)sender;
        GridViewRow row = (GridViewRow)b.NamingContainer;
        if (row != null)
        {
             index = row.RowIndex;
        }
        if (DropDownList1.SelectedValue == "1")
        {
            id = Convert.ToInt32(GridView1.DataKeys[index].Value.ToString());
        }
        else if (DropDownList1.SelectedValue == "2")
        {
            id = Convert.ToInt32(GridView2.DataKeys[index].Value.ToString());
        }
        else if (DropDownList1.SelectedValue == "3")
        {
            id = Convert.ToInt32(GridView3.DataKeys[index].Value.ToString());
        }
        else if (DropDownList1.SelectedValue == "4")
        {
            id = Convert.ToInt32(GridView4.DataKeys[index].Value.ToString());
        }
        else if (DropDownList1.SelectedValue == "5")
        {
            id = Convert.ToInt32(GridView5.DataKeys[index].Value.ToString());
        }
        Session["id"] = id;
        Session["dValue"] = DropDownList1.SelectedValue;
        Response.Redirect("~/ReportViewer.aspx");
        //if (row != null)
        //{
        //    int index = row.RowIndex; //gets the row index selected
            

        //    string condition = " where DB_slNo='" + id + "'";
        //    // string condition = " where userId='" + userId + "'";
        //    DataTable dt = oITAssetMonitoringDLL.GetDB(condition);
        //    if (dt.Rows.Count > 0)
        //    {
        //        //nameTextBox.Text = dt.Rows[0]["DB_Name"].ToString();
        //        //versionTextBox.Text = dt.Rows[0]["DB_Version"].ToString();
        //        //vendorDropDownList.SelectedValue = dt.Rows[0]["DB_V_slNo"].ToString();

        //        //ViewState["id"] = id;
        //        //addButton.Text = "Update";


        //    }

        //}
    }
}