using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BackupClass
/// </summary>
public class BackupClass
{
	public BackupClass()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public int Back_SlNo { get; set; }
    public string Back_SoftWare { get; set; }
    public string Back_Media { get; set; }
    public string Back_DataBase { get; set; }
    public string Back_DataBase_Receive_Date { get; set; }
    public string Back_custodian { get; set; }
    public int Back_Person { get; set; }
    public int Back_CheckedBy { get; set; }
    public string Back_Entry_Date { get; set; }
    public string User_Id { get; set; }
    public string BrCode { get; set; }
    public string Remarks { get; set; }
   
}