using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ServerClass
/// </summary>
public class ServerClass
{
	public ServerClass()
	{
		//
		// TODO: Add constructor logic here
		//
	}
   public int Ser_slNo{get;set;}
   public string Ser_Name {get;set;}
   public string Ser_Manufacture_Name { get; set; }
   public string Ser_Model { get; set; }
   public string Ser_Serial { get; set; }
   public string Ser_IP {get;set;}
   public int	Ser_Sof_slNo {get;set;}
   public string	Ser_Storage {get;set;}
   public string	Ser_Criticality {get;set;}
   public string Ser_Location {get;set;}
   public string	Ser_RackNo {get;set;}
   public string	Ser_WarratyStatus {get;set;}
   public string Ser_Warranty_Start_Date { get; set; }
   public string Ser_Warranty_Expired_Date { get; set; }
   public int	Ser_V_SlNo {get;set;}
   public string Ser_WorkOrder_Date { get; set; }
   public string Ser_WorOrder_No {get;set;}
   public string Ser_Receive_Date { get; set; }
   public bool	Ser_UnderAMC {get;set;}
   public string Ser_Last_Renew_Date { get; set; }
   public string Ser_Next_Renew_Date { get; set; }
   public string Ser_Challan_No { get; set; }
   public string Ser_Network_PortName{ get; set; }
   public string Ser_Patch_PannelNo { get; set; }
   public int	Ser_UAT_Person {get;set;}
   public string Ser_PortOpen { get; set; }
   public string User_Id { get; set; }
   public string BrCode { get; set; }
   public string Remarks { get; set; }
}