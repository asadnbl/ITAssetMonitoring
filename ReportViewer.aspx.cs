using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataSet1TableAdapters;
using CrystalDecisions.CrystalReports.Engine;
using System.IO;

public partial class ReportViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["id"] != null && Session["dValue"] != null)
            {
                string report = "";
                DataSet1 oDataSet1 = new DataSet1();
                if (Session["dValue"].ToString() == "1") 
                {
                    GetSoftwareReportDetailTableAdapter oGetSoftwareReportDetailTableAdapter = new GetSoftwareReportDetailTableAdapter();
                    oGetSoftwareReportDetailTableAdapter.Fill(oDataSet1.GetSoftwareReportDetail, int.Parse(Session["id"].ToString()));
                    GetSoftwareUATpersonReportTableAdapter oGetSoftwareUATpersonReportTableAdapter = new GetSoftwareUATpersonReportTableAdapter();
                    oGetSoftwareUATpersonReportTableAdapter.Fill(oDataSet1.GetSoftwareUATpersonReport, int.Parse(Session["id"].ToString()));
                    report = "SoftwareDetailsReport";

                }
                else if (Session["dValue"].ToString() == "2")
                {
                    GetServerReportDetailTableAdapter oGetServerReportDetailTableAdapter = new GetServerReportDetailTableAdapter();
                    oGetServerReportDetailTableAdapter.Fill(oDataSet1.GetServerReportDetail, int.Parse(Session["id"].ToString()));
                    report = "ServerReport";
                }
                else if (Session["dValue"].ToString() == "3")
                {
                    GetNetworkDeviceReportDetailTableAdapter oGetNetworkDeviceReportDetailTableAdapter = new GetNetworkDeviceReportDetailTableAdapter();
                    oGetNetworkDeviceReportDetailTableAdapter.Fill(oDataSet1.GetNetworkDeviceReportDetail, int.Parse(Session["id"].ToString()));
                    report = "NetworkDeviceReport";
                }
                else if (Session["dValue"].ToString() == "4")
                {
                    GetDBReportDetailTableAdapter oGetDBReportDetailTableAdapter = new GetDBReportDetailTableAdapter();
                    oGetDBReportDetailTableAdapter.Fill(oDataSet1.GetDBReportDetail, int.Parse(Session["id"].ToString()));
                    report = "DBReport";
                
                }

                else if (Session["dValue"].ToString() == "5")
                {
                    GetBackupReportDetailTableAdapter oGetBackupReportDetailTableAdapter = new GetBackupReportDetailTableAdapter();
                    oGetBackupReportDetailTableAdapter.Fill(oDataSet1.GetBackupReportDetail, int.Parse(Session["id"].ToString()));
                    report = "BackupReport";

                }
                ReportDocument myReportDocument = new ReportDocument();

                myReportDocument.Load(Server.MapPath("~/" + report + ".rpt"));
                myReportDocument.SetDataSource(oDataSet1);
                //myReportDocument.SetParameterValue("ReportName", reportName);
                MemoryStream oStream = (MemoryStream)myReportDocument.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat);

                Response.Clear();
                Response.Buffer = true;
                Response.ContentType = "application/pdf";
                Response.AddHeader("Content-Disposition", "attachment; filename='" + report + "'.pdf'");
                Response.BinaryWrite(oStream.ToArray());
                Response.End();
            }
        }

    }
}