using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DBClass
/// </summary>
public class DBClass
{
	public DBClass()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public int DB_slNo { get; set; }
    public string DB_Name { get; set; }
    public string DB_Version { get; set; }
    public int DB_V_slNo { get; set; }   
    public string User_Id { get; set; }
    public string BrCode { get; set; }
    public string DB_WorkOrder_No { get; set; }
	public string DB_WorkOrder_Date  { get; set; }
	public string DB_Receive_Date  { get; set;} 
	public bool DB_UnderAMC  { get; set;} 
	public string DB_Last_Renew_Date { get; set;}
    public string DB_Next_Renew_Date { get; set; }
    public string Remarks { get; set; }
}