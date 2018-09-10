using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Web.Configuration;
using System.Data.SqlTypes;
/// <summary>
/// Summary description for ITAssetMonitoringDLL
/// </summary>
public class ITAssetMonitoringDLL
{
	public ITAssetMonitoringDLL()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    SqlConnection con;
    SqlCommand cmd;
    public SqlConnection DatabaseConnection()
    {

        //string sqlConnection = "Data Source=USER-HP\\SQLEXPRESS;Initial Catalog=CollectionAccount;User Id=wasa;Password=123;Integrated Security=false";
        //con = new SqlConnection(sqlConnection);
        //try { con.Open(); }
        //catch { }
        //return con;
        con = new SqlConnection(WebConfigurationManager.ConnectionStrings["ApplicationServices"].ToString());
        try { con.Open(); }
        catch { }
        return con;

      
    }
    #region vendeor
    public int InsertVendor(VendorClass oVendorClass)
    {
        con = DatabaseConnection();
        int i = 0, k = 0;


        cmd = new SqlCommand("INSERT INTO Vendor (V_Name,V_ContactPerson,V_ContactNo,V_Address,V_Email,User_Id,BrCode,Remarks) VALUES(@V_Name,@V_ContactPerson,@V_ContactNo,@V_Address,@V_Email,@User_Id,@BrCode,@Remarks)", con);
        //SqlCommand cmd = new SqlCommand("insert into test VALUES(@name)",con);
        //    cmd.Parameters.AddWithValue("@name",N'TextBox1.Text);
        cmd.Parameters.AddWithValue("@V_Name", SqlDbType.VarChar).Value = oVendorClass.V_Name;
        cmd.Parameters.AddWithValue("@V_ContactPerson", SqlDbType.VarChar).Value = oVendorClass.V_ContactPerson;
        cmd.Parameters.AddWithValue("@V_ContactNo", SqlDbType.VarChar).Value = oVendorClass.V_ContactNo;
        cmd.Parameters.AddWithValue("@V_Address", SqlDbType.VarChar).Value = oVendorClass.V_Address;
        cmd.Parameters.AddWithValue("@V_Email", SqlDbType.VarChar).Value = oVendorClass.V_Email;
        cmd.Parameters.AddWithValue("@User_Id", SqlDbType.VarChar).Value = oVendorClass.User_Id;
        cmd.Parameters.AddWithValue("@BrCode", SqlDbType.VarChar).Value = oVendorClass.BrCode;
        cmd.Parameters.AddWithValue("@Remarks", SqlDbType.VarChar).Value =oVendorClass.Remarks;
        try
        {
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            i = 1;

        }
        catch { }
        con.Close();
        return i;
    }
    public int UpdateVendor(VendorClass oVendorClass)
    {
        con = DatabaseConnection();
        int i = 0, k = 0;


        cmd = new SqlCommand("UPDATE Vendor SET V_Name=@V_Name,V_ContactPerson=@V_ContactPerson,V_ContactNo=@V_ContactNo,V_Address=@V_Address,V_Email=@V_Email,User_Id=@User_Id,BrCode=@BrCode,Remarks=@Remarks WHERE V_slNo=@V_slNo", con);
        //SqlCommand cmd = new SqlCommand("insert into test VALUES(@name)",con);
        //    cmd.Parameters.AddWithValue("@name",N'TextBox1.Text);
        cmd.Parameters.AddWithValue("@V_slNo", SqlDbType.Int).Value = oVendorClass.V_slNo;
        cmd.Parameters.AddWithValue("@V_Name", SqlDbType.VarChar).Value = oVendorClass.V_Name;
        cmd.Parameters.AddWithValue("@V_ContactPerson", SqlDbType.VarChar).Value = oVendorClass.V_ContactPerson;
        cmd.Parameters.AddWithValue("@V_ContactNo", SqlDbType.VarChar).Value = oVendorClass.V_ContactNo;
        cmd.Parameters.AddWithValue("@V_Address", SqlDbType.VarChar).Value = oVendorClass.V_Address;
        cmd.Parameters.AddWithValue("@V_Email", SqlDbType.VarChar).Value = oVendorClass.V_Email;
        cmd.Parameters.AddWithValue("@User_Id", SqlDbType.VarChar).Value = oVendorClass.User_Id;
        cmd.Parameters.AddWithValue("@BrCode", SqlDbType.VarChar).Value = oVendorClass.BrCode;
        cmd.Parameters.AddWithValue("@Remarks", SqlDbType.VarChar).Value =oVendorClass.Remarks;
        try
        {
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            i = 1;

        }
        catch { }
        con.Close();
        return i;
    }
    public DataTable GetVendor(string condition)
    {
        con = DatabaseConnection();
        cmd = new SqlCommand("SELECT  * FROM Vendor " + condition + " ORDER BY V_slNo", con);
        cmd.CommandType = CommandType.Text;
        SqlDataAdapter da = new SqlDataAdapter(cmd);

        DataTable dt = new DataTable();
        try
        {
            da.Fill(dt);
            con.Close();

        }
        catch
        {

        }
        return dt;

    }
    #endregion
    #region software
    public int InsertSoftware(SoftwareClass oSoftwareClass)
    {
        con = DatabaseConnection();
        int i = 0, k = 0;


        cmd = new SqlCommand("INSERT INTO Software (Sof_Name,Sof_Ser_slNo,Sof_Type,Sof_V_slNo,Sof_EndUser,Sof_BenifitiaryUser,Sof_CurrentVirsion,Sof_HostedLocation,Sof_WorkOrder_Date,Sof_WorkOrder_No,Sof_Receive_Date,Sof_UnderAMC,Sof_Last_Renew_Date,Sof_Next_Renew_Date,Sof_UAT_Person,Sof_UAT_Date,Sof_NetworkGateway,Sof_IsHosted,Sof_BlackboxTest,Sof_WhiteboxTest,Sof_Vernability,Sof_PenitrationTest,Sof_OperationalManual,Sof_TechnicalManual,Sof_Port,Sof_ScemaName,User_Id,BrCode,Remarks,Sof_Res_Person) VALUES(@Sof_Name,@Sof_Ser_slNo,@Sof_Type,@Sof_V_slNo,@Sof_EndUser,@Sof_BenifitiaryUser,@Sof_CurrentVirsion,@Sof_HostedLocation,@Sof_WorkOrder_Date,@Sof_WorkOrder_No,@Sof_Receive_Date,@Sof_UnderAMC,@Sof_Last_Renew_Date,@Sof_Next_Renew_Date,@Sof_UAT_Person,@Sof_UAT_Date,@Sof_NetworkGateway,@Sof_IsHosted,@Sof_BlackboxTest,@Sof_WhiteboxTest,@Sof_Vernability,@Sof_PenitrationTest,@Sof_OperationalManual,@Sof_TechnicalManual,@Sof_Port,@Sof_ScemaName,@User_Id,@BrCode,@Remarks,@Sof_Res_Person)", con);
        //SqlCommand cmd = new SqlCommand("insert into test VALUES(@name)",con);
        //    cmd.Parameters.AddWithValue("@name",N'TextBox1.Text);
        cmd.Parameters.AddWithValue("@Sof_Name", SqlDbType.VarChar).Value = oSoftwareClass.Sof_Name;
        cmd.Parameters.AddWithValue("@Sof_Ser_slNo", SqlDbType.Bit).Value = oSoftwareClass.Sof_Ser_slNo;
        cmd.Parameters.AddWithValue("@Sof_Type", SqlDbType.VarChar).Value = oSoftwareClass.Sof_Type;
        cmd.Parameters.AddWithValue("@Sof_V_slNo", SqlDbType.VarChar).Value = oSoftwareClass.Sof_V_slNo;
        cmd.Parameters.AddWithValue("@Sof_EndUser", SqlDbType.VarChar).Value = oSoftwareClass.Sof_EndUser;
        cmd.Parameters.AddWithValue("@Sof_BenifitiaryUser", SqlDbType.VarChar).Value = oSoftwareClass.Sof_BenifitiaryUser;
        cmd.Parameters.AddWithValue("@Sof_CurrentVirsion", SqlDbType.VarChar).Value = oSoftwareClass.Sof_CurrentVirsion;
        cmd.Parameters.AddWithValue("@Sof_HostedLocation", SqlDbType.VarChar).Value = oSoftwareClass.Sof_HostedLocation;
        // cmd.Parameters.AddWithValue("@Sof_WorkOrder_Date", SqlDbType.VarChar).Value = oSoftwareClass.Sof_WorkOrder_Date;
        if (oSoftwareClass.Sof_WorkOrder_Date == "")
        {
            cmd.Parameters.AddWithValue("@Sof_WorkOrder_Date", SqlDbType.DateTime).Value = DBNull.Value;
            //cmd.Parameters["@Sof_UAT_Date"].Value = DBNull.Value;
        }
        else
        {
            cmd.Parameters.AddWithValue("@Sof_WorkOrder_Date", SqlDbType.VarChar).Value = oSoftwareClass.Sof_WorkOrder_Date ;

        }
        cmd.Parameters.AddWithValue("@Sof_WorkOrder_No", SqlDbType.VarChar).Value = oSoftwareClass.Sof_WorkOrder_No;
        if (oSoftwareClass.Sof_Receive_Date == "")
        {
            cmd.Parameters.AddWithValue("@Sof_Receive_Date", SqlDbType.DateTime).Value = DBNull.Value;
            //cmd.Parameters["@Sof_UAT_Date"].Value = DBNull.Value;
        }
        else
        {
            cmd.Parameters.AddWithValue("@Sof_Receive_Date", SqlDbType.VarChar).Value = oSoftwareClass.Sof_Receive_Date ;

        }

        cmd.Parameters.AddWithValue("@Sof_UnderAMC", SqlDbType.VarChar).Value = oSoftwareClass.Sof_UnderAMC;

        if (oSoftwareClass.Sof_Last_Renew_Date == "")
        {
            cmd.Parameters.AddWithValue("@Sof_Last_Renew_Date", SqlDbType.DateTime).Value = DBNull.Value;
            //cmd.Parameters["@Sof_UAT_Date"].Value = DBNull.Value;
        }
        else
        {
            cmd.Parameters.AddWithValue("@Sof_Last_Renew_Date", SqlDbType.VarChar).Value = oSoftwareClass.Sof_Last_Renew_Date ;

        }
        if (oSoftwareClass.Sof_Next_Renew_Date == "")
        {
            cmd.Parameters.AddWithValue("@Sof_Next_Renew_Date", SqlDbType.DateTime).Value = DBNull.Value;
            //cmd.Parameters["@Sof_UAT_Date"].Value = DBNull.Value;
        }
        else
        {
            cmd.Parameters.AddWithValue("@Sof_Next_Renew_Date", SqlDbType.VarChar).Value = oSoftwareClass.Sof_Next_Renew_Date ;

        }


        cmd.Parameters.AddWithValue("@Sof_UAT_Person", SqlDbType.VarChar).Value = oSoftwareClass.Sof_UAT_Person;
        if (oSoftwareClass.Sof_UAT_Date == "")
        {
            cmd.Parameters.AddWithValue("@Sof_UAT_Date", SqlDbType.DateTime).Value = DBNull.Value;
            //cmd.Parameters["@Sof_UAT_Date"].Value = DBNull.Value;
        }
        else
        {
            cmd.Parameters.AddWithValue("@Sof_UAT_Date", SqlDbType.VarChar).Value = oSoftwareClass.Sof_UAT_Date ;

        }
        cmd.Parameters.AddWithValue("@Sof_NetworkGateway", SqlDbType.VarChar).Value = oSoftwareClass.Sof_NetworkGateway;
        cmd.Parameters.AddWithValue("@Sof_IsHosted", SqlDbType.VarChar).Value = oSoftwareClass.Sof_IsHosted;
        cmd.Parameters.AddWithValue("@Sof_BlackboxTest", SqlDbType.VarChar).Value = oSoftwareClass.Sof_BlackboxTest;
        cmd.Parameters.AddWithValue("@Sof_WhiteboxTest", SqlDbType.VarChar).Value = oSoftwareClass.Sof_WhiteboxTest;
        cmd.Parameters.AddWithValue("@Sof_Vernability", SqlDbType.VarChar).Value = oSoftwareClass.Sof_Vernability;
        cmd.Parameters.AddWithValue("@Sof_PenitrationTest", SqlDbType.VarChar).Value = oSoftwareClass.Sof_PenitrationTest;
        cmd.Parameters.AddWithValue("@Sof_OperationalManual", SqlDbType.VarChar).Value = oSoftwareClass.Sof_OperationalManual;
        cmd.Parameters.AddWithValue("@Sof_TechnicalManual", SqlDbType.VarChar).Value = oSoftwareClass.Sof_TechnicalManual;
        cmd.Parameters.AddWithValue("@Sof_Port", SqlDbType.VarChar).Value = oSoftwareClass.Sof_Port;
        cmd.Parameters.AddWithValue("@Sof_ScemaName", SqlDbType.VarChar).Value = oSoftwareClass.Sof_ScemaName;
        cmd.Parameters.AddWithValue("@User_Id", SqlDbType.VarChar).Value = oSoftwareClass.User_Id;
        cmd.Parameters.AddWithValue("@BrCode", SqlDbType.VarChar).Value = oSoftwareClass.BrCode;
        cmd.Parameters.AddWithValue("@Remarks", SqlDbType.VarChar).Value =oSoftwareClass.Remarks;
        cmd.Parameters.AddWithValue("@Sof_Res_Person", SqlDbType.VarChar).Value = oSoftwareClass.Sof_Res_Person;
        try
        {
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            i = 1;

        }
        catch { }
        con.Close();
        return i;
    }
   
    public int UpdateSoftware(SoftwareClass oSoftwareClass)
    {
        con = DatabaseConnection();
        int i = 0, k = 0;


        cmd = new SqlCommand("UPDATE Software SET Sof_Name=@Sof_Name,Sof_Ser_slNo=@Sof_Ser_slNo,Sof_Type=@Sof_Type,Sof_V_slNo=@Sof_V_slNo,Sof_EndUser=@Sof_EndUser,Sof_BenifitiaryUser=@Sof_BenifitiaryUser,Sof_CurrentVirsion=@Sof_CurrentVirsion,Sof_HostedLocation=@Sof_HostedLocation,Sof_WorkOrder_No=@Sof_WorkOrder_No,Sof_Receive_Date=@Sof_Receive_Date,Sof_UnderAMC=@Sof_UnderAMC,Sof_Last_Renew_Date=@Sof_Last_Renew_Date,Sof_Next_Renew_Date=@Sof_Next_Renew_Date,Sof_UAT_Person=@Sof_UAT_Person,Sof_UAT_Date=@Sof_UAT_Date,Sof_NetworkGateway=@Sof_NetworkGateway,Sof_IsHosted=@Sof_IsHosted ,Sof_BlackboxTest=@Sof_BlackboxTest,Sof_WhiteboxTest=@Sof_WhiteboxTest,Sof_Vernability=@Sof_Vernability,Sof_PenitrationTest=@Sof_PenitrationTest,Sof_OperationalManual=@Sof_OperationalManual,Sof_TechnicalManual=@Sof_TechnicalManual,Sof_Port=@Sof_Port,Sof_ScemaName=@Sof_ScemaName,User_Id=@User_Id,BrCode=@BrCode,Remarks=@Remarks,Sof_Res_Person=@Sof_Res_Person WHERE Sof_slNo=@Sof_slNo", con);
        //SqlCommand cmd = new SqlCommand("insert into test VALUES(@name)",con);
        //    cmd.Parameters.AddWithValue("@name",N'TextBox1.Text);
        cmd.Parameters.AddWithValue("@Sof_slNo", SqlDbType.VarChar).Value = oSoftwareClass.Sof_slNo;
        cmd.Parameters.AddWithValue("@Sof_Name", SqlDbType.VarChar).Value = oSoftwareClass.Sof_Name;
        cmd.Parameters.AddWithValue("@Sof_Ser_slNo", SqlDbType.Bit).Value = oSoftwareClass.Sof_Ser_slNo;
        cmd.Parameters.AddWithValue("@Sof_Type", SqlDbType.VarChar).Value = oSoftwareClass.Sof_Type;
        cmd.Parameters.AddWithValue("@Sof_V_slNo", SqlDbType.VarChar).Value = oSoftwareClass.Sof_V_slNo;
        cmd.Parameters.AddWithValue("@Sof_EndUser", SqlDbType.VarChar).Value = oSoftwareClass.Sof_EndUser;
        cmd.Parameters.AddWithValue("@Sof_BenifitiaryUser", SqlDbType.VarChar).Value = oSoftwareClass.Sof_BenifitiaryUser;
        cmd.Parameters.AddWithValue("@Sof_CurrentVirsion", SqlDbType.VarChar).Value = oSoftwareClass.Sof_CurrentVirsion;
        cmd.Parameters.AddWithValue("@Sof_HostedLocation", SqlDbType.VarChar).Value = oSoftwareClass.Sof_HostedLocation;
       // cmd.Parameters.AddWithValue("@Sof_WorkOrder_Date", SqlDbType.VarChar).Value = oSoftwareClass.Sof_WorkOrder_Date;
        if (oSoftwareClass.Sof_WorkOrder_Date == "")
        {
            cmd.Parameters.AddWithValue("@Sof_WorkOrder_Date", SqlDbType.DateTime).Value = DBNull.Value;
            //cmd.Parameters["@Sof_UAT_Date"].Value = DBNull.Value;
        }
        else
        {
            cmd.Parameters.AddWithValue("@Sof_WorkOrder_Date", SqlDbType.VarChar).Value = oSoftwareClass.Sof_WorkOrder_Date ;

        }
        cmd.Parameters.AddWithValue("@Sof_WorkOrder_No", SqlDbType.VarChar).Value = oSoftwareClass.Sof_WorkOrder_No;
        if (oSoftwareClass.Sof_Receive_Date == "")
        {
            cmd.Parameters.AddWithValue("@Sof_Receive_Date", SqlDbType.DateTime).Value = DBNull.Value;
            //cmd.Parameters["@Sof_UAT_Date"].Value = DBNull.Value;
        }
        else
        {
            cmd.Parameters.AddWithValue("@Sof_Receive_Date", SqlDbType.VarChar).Value = oSoftwareClass.Sof_Receive_Date ;

        }
      
        cmd.Parameters.AddWithValue("@Sof_UnderAMC", SqlDbType.VarChar).Value = oSoftwareClass.Sof_UnderAMC;

        if (oSoftwareClass.Sof_Last_Renew_Date == "")
        {
            cmd.Parameters.AddWithValue("@Sof_Last_Renew_Date", SqlDbType.DateTime).Value = DBNull.Value;
            //cmd.Parameters["@Sof_UAT_Date"].Value = DBNull.Value;
        }
        else
        {
            cmd.Parameters.AddWithValue("@Sof_Last_Renew_Date", SqlDbType.VarChar).Value = oSoftwareClass.Sof_Last_Renew_Date ;

        }
        if (oSoftwareClass.Sof_Next_Renew_Date == "")
        {
            cmd.Parameters.AddWithValue("@Sof_Next_Renew_Date", SqlDbType.DateTime).Value = DBNull.Value;
            //cmd.Parameters["@Sof_UAT_Date"].Value = DBNull.Value;
        }
        else
        {
            cmd.Parameters.AddWithValue("@Sof_Next_Renew_Date", SqlDbType.VarChar).Value = oSoftwareClass.Sof_Next_Renew_Date ;

        }

        
        cmd.Parameters.AddWithValue("@Sof_UAT_Person", SqlDbType.VarChar).Value = oSoftwareClass.Sof_UAT_Person;
        if (oSoftwareClass.Sof_UAT_Date == "")
        {
            cmd.Parameters.AddWithValue("@Sof_UAT_Date", SqlDbType.DateTime).Value = DBNull.Value;
            //cmd.Parameters["@Sof_UAT_Date"].Value = DBNull.Value;
        }
        else
        {
            cmd.Parameters.AddWithValue("@Sof_UAT_Date", SqlDbType.VarChar).Value = oSoftwareClass.Sof_UAT_Date ;

        }
        cmd.Parameters.AddWithValue("@Sof_NetworkGateway", SqlDbType.VarChar).Value = oSoftwareClass.Sof_NetworkGateway;
        cmd.Parameters.AddWithValue("@Sof_IsHosted", SqlDbType.VarChar).Value = oSoftwareClass.Sof_IsHosted;
        cmd.Parameters.AddWithValue("@Sof_BlackboxTest", SqlDbType.VarChar).Value = oSoftwareClass.Sof_BlackboxTest;
        cmd.Parameters.AddWithValue("@Sof_WhiteboxTest", SqlDbType.VarChar).Value = oSoftwareClass.Sof_WhiteboxTest;
        cmd.Parameters.AddWithValue("@Sof_Vernability", SqlDbType.VarChar).Value = oSoftwareClass.Sof_Vernability;
        cmd.Parameters.AddWithValue("@Sof_PenitrationTest", SqlDbType.VarChar).Value = oSoftwareClass.Sof_PenitrationTest;
        cmd.Parameters.AddWithValue("@Sof_OperationalManual", SqlDbType.VarChar).Value = oSoftwareClass.Sof_OperationalManual;
        cmd.Parameters.AddWithValue("@Sof_TechnicalManual", SqlDbType.VarChar).Value = oSoftwareClass.Sof_TechnicalManual;
        cmd.Parameters.AddWithValue("@Sof_Port", SqlDbType.VarChar).Value = oSoftwareClass.Sof_Port;
        cmd.Parameters.AddWithValue("@Sof_ScemaName", SqlDbType.VarChar).Value = oSoftwareClass.Sof_ScemaName;
        cmd.Parameters.AddWithValue("@User_Id", SqlDbType.VarChar).Value = oSoftwareClass.User_Id;
        cmd.Parameters.AddWithValue("@BrCode", SqlDbType.VarChar).Value = oSoftwareClass.BrCode;
        cmd.Parameters.AddWithValue("@Remarks", SqlDbType.VarChar).Value =oSoftwareClass.Remarks;
        cmd.Parameters.AddWithValue("@Sof_Res_Person", SqlDbType.VarChar).Value = oSoftwareClass.Sof_Res_Person;
        try
        {
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            i = 1;

        }
        catch { }
        con.Close();
        return i;
    }
    public DataTable GetSoftware(string condition)
    {
        con = DatabaseConnection();
        cmd = new SqlCommand("SELECT  software.*, Server.Ser_slNo, Server.Ser_Name, Server.Ser_IP, Server.Ser_Sof_slNo, Server.Ser_Storage, "+
                      "Server.Ser_Criticality, Server.*, Vendor.V_slNo, Vendor.V_Name, Vendor.V_ContactPerson, Vendor.V_ContactNo, "+
                      "Vendor.V_Address, Vendor.V_Email, Vendor.User_Id, Vendor.BrCode, Emplyee.*,R.Emp_Name 'Res_Name' FROM  Software LEFT OUTER JOIN " +
                     " Emplyee ON Software.Sof_UAT_Person = Emplyee.Emp_slNo LEFT OUTER JOIN Emplyee R on R.Emp_slNo=Software.Sof_Res_Person LEFT OUTER JOIN  Vendor ON Software.Sof_V_slNo = Vendor.V_slNo LEFT OUTER JOIN " +
                    "  Server ON Software.Sof_Ser_slNo = Server.Ser_slNo" + condition + " ORDER BY Sof_slNo desc", con);
        cmd.CommandType = CommandType.Text;
        SqlDataAdapter da = new SqlDataAdapter(cmd);

        DataTable dt = new DataTable();
        try
        {
            da.Fill(dt);
            con.Close();

        }
        catch
        {

        }
        return dt;

    }
    public int InsOrUpdateSof_UAT_Person(Sof_UAT_PersonClass oSof_UAT_PersonClass)
    {

        DataTable dt = GetSof_UAT_Person(" Where Sof_UAT_Person.Sof_slNo=" + oSof_UAT_PersonClass.Sof_slNo + " and Sof_UAT_Person.Sof_UAT_Person=" + oSof_UAT_PersonClass.Sof_UAT_Person + "");



        con = DatabaseConnection();
        int i = 0, k = 0;

        if (dt.Rows.Count == 0)
            cmd = new SqlCommand("INSERT INTO Sof_UAT_Person (Sof_slNo,Sof_UAT_Person) VALUES(@Sof_slNo,@Sof_UAT_Person)", con);
        else
        {
            cmd = new SqlCommand("UPDATE Sof_UAT_Person SET Sof_slNo=@Sof_slNo,Sof_UAT_Person=@Sof_UAT_Person Where slNo=" + oSof_UAT_PersonClass.slNo + ")", con);
            cmd.Parameters.AddWithValue("@slNo", SqlDbType.VarChar).Value = oSof_UAT_PersonClass.slNo;

        }//SqlCommand cmd = new SqlCommand("insert into test VALUES(@name)",con);
        //    cmd.Parameters.AddWithValue("@name",N'TextBox1.Text);
        cmd.Parameters.AddWithValue("@Sof_slNo", SqlDbType.VarChar).Value = oSof_UAT_PersonClass.Sof_slNo;
        cmd.Parameters.AddWithValue("@Sof_UAT_Person", SqlDbType.Bit).Value = oSof_UAT_PersonClass.Sof_UAT_Person;

        try
        {
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            i = 1;

        }
        catch { }
        con.Close();
        return i;
    }
    public DataTable GetSof_UAT_Person(string condition)
    {
        con = DatabaseConnection();
        cmd = new SqlCommand("SELECT Sof_UAT_Person.slNo, Sof_UAT_Person.Sof_slNo, Sof_UAT_Person.Sof_UAT_Person, Software.Sof_Name, Emplyee.Emp_slNo, Emplyee.Emp_Name, " +
                   "   Emplyee.Emp_BrCode, Emplyee.Emp_Active, Emplyee.Emp_Designation, Emplyee.Emp_ContactNo, Emplyee.Emp_Email, Emplyee.Emp_CurrentDesk " +
                   "  FROM Sof_UAT_Person INNER JOIN   Software ON Sof_UAT_Person.Sof_slNo = Software.Sof_slNo LEFT OUTER JOIN " +
                    "  Emplyee ON Sof_UAT_Person.Sof_UAT_Person = Emplyee.Emp_slNo" + condition + " ", con);
        cmd.CommandType = CommandType.Text;
        SqlDataAdapter da = new SqlDataAdapter(cmd);

        DataTable dt = new DataTable();
        try
        {
            da.Fill(dt);
            con.Close();

        }
        catch
        {

        }
        return dt;

    }
    public int DeleteSof_UAT_Person(string condition)
    {
        int i = 0, k = 0;

        con = DatabaseConnection();
        cmd = new SqlCommand("Delete from Sof_UAT_Person" + condition + " ", con);
        cmd.CommandType = CommandType.Text;
        try
        {
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            i = 1;

        }
        catch { }
        con.Close();
        return i;

    }
    public int InsOrUpdateSof_FallBack_Person(Sof_FallBack_PersonClass oSof_FallBack_PersonClass)
    {

        DataTable dt = GetSof_FallBack_Person(" Where Sof_FallBack_Person.Sof_slNo=" + oSof_FallBack_PersonClass.Sof_slNo + " and Sof_FallBack_Person.Sof_FallBack_Person=" + oSof_FallBack_PersonClass.Sof_FallBack_Person + "");



        con = DatabaseConnection();
        int i = 0, k = 0;

        if (dt.Rows.Count == 0)
            cmd = new SqlCommand("INSERT INTO Sof_FallBack_Person (Sof_slNo,Sof_FallBack_Person) VALUES(@Sof_slNo,@Sof_FallBack_Person)", con);
        else
        {
            cmd = new SqlCommand("UPDATE Sof_FallBack_Person SET Sof_slNo=@Sof_slNo,Sof_FallBack_Person=@Sof_FallBack_Person Where slNo=" + oSof_FallBack_PersonClass.slNo + ")", con);
            cmd.Parameters.AddWithValue("@slNo", SqlDbType.VarChar).Value = oSof_FallBack_PersonClass.slNo;

        }//SqlCommand cmd = new SqlCommand("insert into test VALUES(@name)",con);
        //    cmd.Parameters.AddWithValue("@name",N'TextBox1.Text);
        cmd.Parameters.AddWithValue("@Sof_slNo", SqlDbType.VarChar).Value = oSof_FallBack_PersonClass.Sof_slNo;
        cmd.Parameters.AddWithValue("@Sof_FallBack_Person", SqlDbType.Bit).Value = oSof_FallBack_PersonClass.Sof_FallBack_Person;

        try
        {
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            i = 1;

        }
        catch { }
        con.Close();
        return i;
    }
    public DataTable GetSof_FallBack_Person(string condition)
    {
        con = DatabaseConnection();
        cmd = new SqlCommand("SELECT Sof_FallBack_Person.slNo, Sof_FallBack_Person.Sof_slNo, Sof_FallBack_Person.Sof_FallBack_Person, Software.Sof_Name, Emplyee.Emp_slNo, Emplyee.Emp_Name, " +
                   "   Emplyee.Emp_BrCode, Emplyee.Emp_Active, Emplyee.Emp_Designation, Emplyee.Emp_ContactNo, Emplyee.Emp_Email, Emplyee.Emp_CurrentDesk " +
                   "  FROM Sof_FallBack_Person INNER JOIN   Software ON Sof_FallBack_Person.Sof_slNo = Software.Sof_slNo LEFT OUTER JOIN " +
                    "  Emplyee ON Sof_FallBack_Person.Sof_FallBack_Person = Emplyee.Emp_slNo" + condition + " ", con);
        cmd.CommandType = CommandType.Text;
        SqlDataAdapter da = new SqlDataAdapter(cmd);

        DataTable dt = new DataTable();
        try
        {
            da.Fill(dt);
            con.Close();

        }
        catch
        {

        }
        return dt;

    }
    public int DeleteSof_FallBack_Person(string condition)
    {
        int i = 0, k = 0;

        con = DatabaseConnection();
        cmd = new SqlCommand("Delete from Sof_FallBack_Person" + condition + " ", con);
        cmd.CommandType = CommandType.Text;
        try
        {
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            i = 1;

        }
        catch { }
        con.Close();
        return i;

    }

    #endregion
    #region server
    public int InsertServer(ServerClass oServerClass)
    {
        con = DatabaseConnection();
        int i = 0, k = 0;


        cmd = new SqlCommand("INSERT INTO Server (Ser_Name,Ser_Manufacture_Name,Ser_Model,Ser_Serial,Ser_IP,Ser_Sof_slNo,Ser_Storage,Ser_Criticality,Ser_Location,Ser_RackNo,Ser_WarratyStatus,Ser_Warranty_Start_Date,Ser_Warranty_Expired_Date,Ser_V_SlNo,Ser_WorkOrder_Date,Ser_WorOrder_No,Ser_Receive_Date,Ser_UnderAMC,Ser_Last_Renew_Date,Ser_Next_Renew_Date,Ser_Challan_No,Ser_UAT_Person,Ser_PortOpen,Ser_Network_PortName,Ser_Patch_PannelNo,User_Id,BrCode,Remarks) VALUES(@Ser_Name,@Ser_Manufacture_Name,@Ser_Model,@Ser_Serial,@Ser_IP,@Ser_Sof_slNo,@Ser_Storage,@Ser_Criticality,@Ser_Location,@Ser_RackNo,@Ser_WarratyStatus,@Ser_Warranty_Start_Date,@Ser_Warranty_Expired_Date,@Ser_V_SlNo,@Ser_WorkOrder_Date,@Ser_WorOrder_No,@Ser_Receive_Date,@Ser_UnderAMC,@Ser_Last_Renew_Date,@Ser_Next_Renew_Date,@Ser_Challan_No,@Ser_UAT_Person,@Ser_PortOpen,@Ser_Network_PortName,@Ser_Patch_PannelNo,@User_Id,@BrCode,@Remarks)", con);
        //SqlCommand cmd = new SqlCommand("insert into test VALUES(@name)",con);
        //    cmd.Parameters.AddWithValue("@name",N'TextBox1.Text);
        cmd.Parameters.AddWithValue("@Ser_Name", SqlDbType.VarChar).Value = oServerClass.Ser_Name;
        cmd.Parameters.AddWithValue("@Ser_Manufacture_Name", SqlDbType.VarChar).Value = oServerClass.Ser_Manufacture_Name;
        cmd.Parameters.AddWithValue("@Ser_Model", SqlDbType.VarChar).Value = oServerClass.Ser_Model;
        cmd.Parameters.AddWithValue("@Ser_Serial", SqlDbType.VarChar).Value = oServerClass.Ser_Serial;
        cmd.Parameters.AddWithValue("@Ser_IP", SqlDbType.Bit).Value = oServerClass.Ser_IP;
        cmd.Parameters.AddWithValue("@Ser_Sof_slNo", SqlDbType.VarChar).Value = oServerClass.Ser_Sof_slNo;
        cmd.Parameters.AddWithValue("@Ser_Storage", SqlDbType.VarChar).Value = oServerClass.Ser_Storage;
        cmd.Parameters.AddWithValue("@Ser_Criticality", SqlDbType.VarChar).Value = oServerClass.Ser_Criticality;
        cmd.Parameters.AddWithValue("@Ser_Location", SqlDbType.VarChar).Value = oServerClass.Ser_Location;
        cmd.Parameters.AddWithValue("@Ser_RackNo", SqlDbType.VarChar).Value = oServerClass.Ser_RackNo;
        cmd.Parameters.AddWithValue("@Ser_WarratyStatus", SqlDbType.VarChar).Value = oServerClass.Ser_WarratyStatus;
        if (oServerClass.Ser_Warranty_Start_Date == "")
        {
            cmd.Parameters.AddWithValue("@Ser_Warranty_Start_Date", SqlDbType.DateTime).Value = DBNull.Value;
            //cmd.Parameters["@Sof_UAT_Date"].Value = DBNull.Value;
        }
        else
        {
            cmd.Parameters.AddWithValue("@Ser_Warranty_Start_Date", SqlDbType.VarChar).Value = oServerClass.Ser_Warranty_Start_Date;

        }

        if (oServerClass.Ser_Warranty_Expired_Date == "")
        {
            cmd.Parameters.AddWithValue("@Ser_Warranty_Expired_Date", SqlDbType.DateTime).Value = DBNull.Value;
            //cmd.Parameters["@Sof_UAT_Date"].Value = DBNull.Value;
        }
        else
        {
            cmd.Parameters.AddWithValue("@Ser_Warranty_Expired_Date", SqlDbType.VarChar).Value = oServerClass.Ser_Warranty_Expired_Date;

        }

        cmd.Parameters.AddWithValue("@Ser_V_SlNo", SqlDbType.VarChar).Value = oServerClass.Ser_V_SlNo;
       // cmd.Parameters.AddWithValue("@Ser_WorkOrder_Date", SqlDbType.VarChar).Value = oServerClass.Ser_WorkOrder_Date;
        if (oServerClass.Ser_WorkOrder_Date == "")
        {
            cmd.Parameters.AddWithValue("@Ser_WorkOrder_Date", SqlDbType.DateTime).Value = DBNull.Value;
          
        }
        else
        {
            cmd.Parameters.AddWithValue("@Ser_WorkOrder_Date", SqlDbType.VarChar).Value = oServerClass.Ser_WorkOrder_Date;

        }
        
        
        cmd.Parameters.AddWithValue("@Ser_WorOrder_No", SqlDbType.VarChar).Value = oServerClass.Ser_WorOrder_No;
        if (oServerClass.Ser_Receive_Date == "")
        {
            cmd.Parameters.AddWithValue("@Ser_Receive_Date", SqlDbType.DateTime).Value = DBNull.Value;

        }
        else
        {
            cmd.Parameters.AddWithValue("@Ser_Receive_Date", SqlDbType.VarChar).Value = oServerClass.Ser_Receive_Date;

        }
        
        
        cmd.Parameters.AddWithValue("@Ser_UnderAMC", SqlDbType.VarChar).Value = oServerClass.Ser_UnderAMC;
      
        if (oServerClass.Ser_Last_Renew_Date == "")
        {
            cmd.Parameters.AddWithValue("@Ser_Last_Renew_Date", SqlDbType.DateTime).Value = DBNull.Value;

        }
        else
        {
            cmd.Parameters.AddWithValue("@Ser_Last_Renew_Date", SqlDbType.VarChar).Value = oServerClass.Ser_Last_Renew_Date;

        }
        if (oServerClass.Ser_Next_Renew_Date == "")
        {
            cmd.Parameters.AddWithValue("@Ser_Next_Renew_Date", SqlDbType.DateTime).Value = DBNull.Value;

        }
        else
        {
            cmd.Parameters.AddWithValue("@Ser_Next_Renew_Date", SqlDbType.VarChar).Value = oServerClass.Ser_Next_Renew_Date;

        }
        cmd.Parameters.AddWithValue("@Ser_UAT_Person", SqlDbType.VarChar).Value = oServerClass.Ser_UAT_Person;
        cmd.Parameters.AddWithValue("@Ser_Challan_No", SqlDbType.VarChar).Value = oServerClass.Ser_Challan_No;
        cmd.Parameters.AddWithValue("@Ser_Network_PortName", SqlDbType.VarChar).Value = oServerClass.Ser_Network_PortName;
        cmd.Parameters.AddWithValue("@Ser_Patch_PannelNo", SqlDbType.VarChar).Value = oServerClass.Ser_Patch_PannelNo;   
        cmd.Parameters.AddWithValue("@Ser_PortOpen", SqlDbType.VarChar).Value = oServerClass.Ser_PortOpen;    
        cmd.Parameters.AddWithValue("@User_Id", SqlDbType.VarChar).Value = oServerClass.User_Id;
        cmd.Parameters.AddWithValue("@BrCode", SqlDbType.VarChar).Value = oServerClass.BrCode;
        cmd.Parameters.AddWithValue("@Remarks", SqlDbType.VarChar).Value = oServerClass.Remarks;

        try
        {
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            i = 1;

        }
        catch { }
        con.Close();
        return i;
    }
    public int UpdateServer(ServerClass oServerClass)
    {
        con = DatabaseConnection();
        int i = 0, k = 0;


        cmd = new SqlCommand("UPDATE Server SET Ser_Name=@Ser_Name,Ser_IP=@Ser_IP,Ser_Manufacture_Name=@Ser_Manufacture_Name,Ser_Model=@Ser_Model,Ser_Serial=@Ser_Serial,Ser_Sof_slNo=@Ser_Sof_slNo,Ser_Storage=@Ser_Storage,Ser_Criticality=@Ser_Criticality,Ser_Location=@Ser_Location,Ser_RackNo=@Ser_RackNo,Ser_WarratyStatus=@Ser_WarratyStatus,Ser_Warranty_Start_Date=@Ser_Warranty_Start_Date,Ser_Warranty_Expired_Date=@Ser_Warranty_Expired_Date,Ser_V_SlNo=@Ser_V_SlNo,Ser_WorkOrder_Date=@Ser_WorkOrder_Date,Ser_WorOrder_No=@Ser_WorOrder_No,Ser_Receive_Date=@Ser_Receive_Date,Ser_UnderAMC=@Ser_UnderAMC,Ser_Last_Renew_Date=@Ser_Last_Renew_Date,Ser_Next_Renew_Date=@Ser_Next_Renew_Date,Ser_UAT_Person=@Ser_UAT_Person ,Ser_PortOpen=@Ser_PortOpen,Ser_Challan_No=@Ser_Challan_No,Ser_Network_PortName=@Ser_Network_PortName,Ser_Patch_PannelNo=@Ser_Patch_PannelNo,User_Id=@User_Id,BrCode=@BrCode,Remarks=@Remarks WHERE Ser_slNo=@Ser_slNo", con);
        //SqlCommand cmd = new SqlCommand("insert into test VALUES(@name)",con);
        //    cmd.Parameters.AddWithValue("@name",N'TextBox1.Text);
        cmd.Parameters.AddWithValue("@Ser_slNo", SqlDbType.VarChar).Value = oServerClass.Ser_slNo;
        cmd.Parameters.AddWithValue("@Ser_Name", SqlDbType.VarChar).Value = oServerClass.Ser_Name;
        cmd.Parameters.AddWithValue("@Ser_Manufacture_Name", SqlDbType.VarChar).Value = oServerClass.Ser_Manufacture_Name;
        cmd.Parameters.AddWithValue("@Ser_Model", SqlDbType.VarChar).Value = oServerClass.Ser_Model;
        cmd.Parameters.AddWithValue("@Ser_Serial", SqlDbType.VarChar).Value = oServerClass.Ser_Serial;
        cmd.Parameters.AddWithValue("@Ser_IP", SqlDbType.Bit).Value = oServerClass.Ser_IP;
        cmd.Parameters.AddWithValue("@Ser_Sof_slNo", SqlDbType.VarChar).Value = oServerClass.Ser_Sof_slNo;
        cmd.Parameters.AddWithValue("@Ser_Storage", SqlDbType.VarChar).Value = oServerClass.Ser_Storage;
        cmd.Parameters.AddWithValue("@Ser_Criticality", SqlDbType.VarChar).Value = oServerClass.Ser_Criticality;
        cmd.Parameters.AddWithValue("@Ser_Location", SqlDbType.VarChar).Value = oServerClass.Ser_Location;
        cmd.Parameters.AddWithValue("@Ser_RackNo", SqlDbType.VarChar).Value = oServerClass.Ser_RackNo;
        cmd.Parameters.AddWithValue("@Ser_WarratyStatus", SqlDbType.VarChar).Value = oServerClass.Ser_WarratyStatus;
        if (oServerClass.Ser_Warranty_Start_Date == "")
        {
            cmd.Parameters.AddWithValue("@Ser_Warranty_Start_Date", SqlDbType.DateTime).Value = DBNull.Value;
            //cmd.Parameters["@Sof_UAT_Date"].Value = DBNull.Value;
        }
        else
        {
            cmd.Parameters.AddWithValue("@Ser_Warranty_Start_Date", SqlDbType.VarChar).Value = oServerClass.Ser_Warranty_Start_Date;

        }

        if (oServerClass.Ser_Warranty_Expired_Date == "")
        {
            cmd.Parameters.AddWithValue("@Ser_Warranty_Expired_Date", SqlDbType.DateTime).Value = DBNull.Value;
            //cmd.Parameters["@Sof_UAT_Date"].Value = DBNull.Value;
        }
        else
        {
            cmd.Parameters.AddWithValue("@Ser_Warranty_Expired_Date", SqlDbType.VarChar).Value = oServerClass.Ser_Warranty_Expired_Date;

        }

        cmd.Parameters.AddWithValue("@Ser_V_SlNo", SqlDbType.VarChar).Value = oServerClass.Ser_V_SlNo;
        // cmd.Parameters.AddWithValue("@Ser_WorkOrder_Date", SqlDbType.VarChar).Value = oServerClass.Ser_WorkOrder_Date;
        if (oServerClass.Ser_WorkOrder_Date == "")
        {
            cmd.Parameters.AddWithValue("@Ser_WorkOrder_Date", SqlDbType.DateTime).Value = DBNull.Value;

        }
        else
        {
            cmd.Parameters.AddWithValue("@Ser_WorkOrder_Date", SqlDbType.VarChar).Value = oServerClass.Ser_WorkOrder_Date;

        }


        cmd.Parameters.AddWithValue("@Ser_WorOrder_No", SqlDbType.VarChar).Value = oServerClass.Ser_WorOrder_No;
        if (oServerClass.Ser_Receive_Date == "")
        {
            cmd.Parameters.AddWithValue("@Ser_Receive_Date", SqlDbType.DateTime).Value = DBNull.Value;

        }
        else
        {
            cmd.Parameters.AddWithValue("@Ser_Receive_Date", SqlDbType.VarChar).Value = oServerClass.Ser_Receive_Date;

        }


        cmd.Parameters.AddWithValue("@Ser_UnderAMC", SqlDbType.VarChar).Value = oServerClass.Ser_UnderAMC;

        if (oServerClass.Ser_Last_Renew_Date == "")
        {
            cmd.Parameters.AddWithValue("@Ser_Last_Renew_Date", SqlDbType.DateTime).Value = DBNull.Value;

        }
        else
        {
            cmd.Parameters.AddWithValue("@Ser_Last_Renew_Date", SqlDbType.VarChar).Value = oServerClass.Ser_Last_Renew_Date;

        }
        if (oServerClass.Ser_Next_Renew_Date == "")
        {
            cmd.Parameters.AddWithValue("@Ser_Next_Renew_Date", SqlDbType.DateTime).Value = DBNull.Value;

        }
        else
        {
            cmd.Parameters.AddWithValue("@Ser_Next_Renew_Date", SqlDbType.VarChar).Value = oServerClass.Ser_Next_Renew_Date;

        }
        cmd.Parameters.AddWithValue("@Ser_UAT_Person", SqlDbType.VarChar).Value = oServerClass.Ser_UAT_Person;
        cmd.Parameters.AddWithValue("@Ser_Challan_No", SqlDbType.VarChar).Value = oServerClass.Ser_Challan_No;
        cmd.Parameters.AddWithValue("@Ser_Network_PortName", SqlDbType.VarChar).Value = oServerClass.Ser_Network_PortName;
        cmd.Parameters.AddWithValue("@Ser_Patch_PannelNo", SqlDbType.VarChar).Value = oServerClass.Ser_Patch_PannelNo;
        cmd.Parameters.AddWithValue("@Ser_PortOpen", SqlDbType.VarChar).Value = oServerClass.Ser_PortOpen;
        cmd.Parameters.AddWithValue("@User_Id", SqlDbType.VarChar).Value = oServerClass.User_Id;
        cmd.Parameters.AddWithValue("@BrCode", SqlDbType.VarChar).Value = oServerClass.BrCode;
        cmd.Parameters.AddWithValue("@Remarks", SqlDbType.VarChar).Value = oServerClass.Remarks;
        try
        {
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            i = 1;

        }
        catch { }
        con.Close();
        return i;
    }
    public DataTable GetServer(string condition)
    {
        con = DatabaseConnection();
        cmd = new SqlCommand("SELECT server.*, " +
                     " Vendor.V_slNo, Vendor.V_Name, Vendor.V_ContactPerson, Vendor.V_ContactNo, Vendor.V_Address, Vendor.V_Email, "+
                     " Vendor.User_Id AS Expr3, Vendor.BrCode AS Expr4, Emplyee.Emp_slNo, Emplyee.Emp_Name, Emplyee.Emp_BrCode, Emplyee.Emp_Active, "+
                     " Emplyee.Emp_Designation, Emplyee.Emp_ContactNo, Emplyee.Emp_Email, Emplyee.Emp_CurrentDesk FROM  Server LEFT OUTER JOIN "+
                     " Emplyee ON Server.Ser_UAT_Person = Emplyee.Emp_slNo LEFT OUTER JOIN  Vendor ON Server.Ser_V_SlNo = Vendor.V_slNo LEFT OUTER JOIN " +
                     " Software ON Server.Ser_Sof_slNo = Software.Sof_slNo" + condition + " ORDER BY Ser_slNo desc", con);
        cmd.CommandType = CommandType.Text;
        SqlDataAdapter da = new SqlDataAdapter(cmd);

        DataTable dt = new DataTable();
        try
        {
            da.Fill(dt);
            con.Close();

        }
        catch
        {

        }
        return dt;

    }
    #endregion
    #region NetworkDevice
    public int InsertNetworkDevice(NetworkDeviceClass oNetworkDeviceClass)
    {
        con = DatabaseConnection();
        int i = 0, k = 0;


        cmd = new SqlCommand("INSERT INTO NetworkDevice (NetD_Name,NetD_Type,NetD_V_SlNo,NetD_Model,NetD_ChallanNo,NetD_Criticality,NetD_Location,NetD_RackNo,NetD_ChallanDate,NetD_WorkOrder_Date,NetD_WorkOrder_No,NetD_Receive_Date,NetD_UnderAMC,NetD_Last_Renew_Date,NetD_Next_Renew_Date,NetD_UAT_Person,NetD_BillDate,User_Id,BrCode,Ser_WaranteePeriod,Remarks,NetD_Serial,NetD_HostName) VALUES(@NetD_Name,@NetD_Type,@NetD_V_SlNo,@NetD_Model,@NetD_ChallanNo,@NetD_Criticality,@NetD_Location,@NetD_RackNo,@NetD_ChallanDate,@NetD_WorkOrder_Date,@NetD_WorkOrder_No,@NetD_Receive_Date,@NetD_UnderAMC,@NetD_Last_Renew_Date,@NetD_Next_Renew_Date,@NetD_UAT_Person,@NetD_BillDate,@User_Id,@BrCode,@Ser_WaranteePeriod,@Remarks,@NetD_Serial,@NetD_HostName)", con);
        //SqlCommand cmd = new SqlCommand("insert into test VALUES(@name)",con);
        //    cmd.Parameters.AddWithValue("@name",N'TextBox1.Text);

        cmd.Parameters.AddWithValue("@NetD_Name", SqlDbType.VarChar).Value = oNetworkDeviceClass.NetD_Name;
        cmd.Parameters.AddWithValue("@NetD_Type", SqlDbType.Bit).Value = oNetworkDeviceClass.NetD_Type;
        cmd.Parameters.AddWithValue("@NetD_V_SlNo", SqlDbType.VarChar).Value = oNetworkDeviceClass.NetD_V_SlNo;
        cmd.Parameters.AddWithValue("@NetD_Model", SqlDbType.VarChar).Value = oNetworkDeviceClass.NetD_Model;
        cmd.Parameters.AddWithValue("@NetD_ChallanNo", SqlDbType.VarChar).Value = oNetworkDeviceClass.NetD_ChallanNo;
        cmd.Parameters.AddWithValue("@NetD_Criticality", SqlDbType.VarChar).Value = oNetworkDeviceClass.NetD_Criticality;
        cmd.Parameters.AddWithValue("@NetD_Location", SqlDbType.VarChar).Value = oNetworkDeviceClass.NetD_Location;
        cmd.Parameters.AddWithValue("@NetD_RackNo", SqlDbType.VarChar).Value = oNetworkDeviceClass.NetD_RackNo;

        if (oNetworkDeviceClass.NetD_ChallanDate == "")
        {
            cmd.Parameters.AddWithValue("@NetD_ChallanDate", SqlDbType.DateTime).Value = DBNull.Value;
            //cmd.Parameters["@Sof_UAT_Date"].Value = DBNull.Value;
        }
        else
        {
            cmd.Parameters.AddWithValue("@NetD_ChallanDate", SqlDbType.VarChar).Value = oNetworkDeviceClass.NetD_ChallanDate;

        }

        if (oNetworkDeviceClass.NetD_WorkOrder_Date == "")
        {
            cmd.Parameters.AddWithValue("@NetD_WorkOrder_Date", SqlDbType.DateTime).Value = DBNull.Value;
            //cmd.Parameters["@Sof_UAT_Date"].Value = DBNull.Value;
        }
        else
        {
            cmd.Parameters.AddWithValue("@NetD_WorkOrder_Date", SqlDbType.VarChar).Value = oNetworkDeviceClass.NetD_WorkOrder_Date;

        }
        if (oNetworkDeviceClass.NetD_Receive_Date == "")
        {
            cmd.Parameters.AddWithValue("@NetD_Receive_Date", SqlDbType.DateTime).Value = DBNull.Value;
            //cmd.Parameters["@Sof_UAT_Date"].Value = DBNull.Value;
        }
        else
        {
            cmd.Parameters.AddWithValue("@NetD_Receive_Date", SqlDbType.VarChar).Value = oNetworkDeviceClass.NetD_Receive_Date;

        }
        if (oNetworkDeviceClass.NetD_Last_Renew_Date == "")
        {
            cmd.Parameters.AddWithValue("@NetD_Last_Renew_Date", SqlDbType.DateTime).Value = DBNull.Value;
            //cmd.Parameters["@Sof_UAT_Date"].Value = DBNull.Value;
        }
        else
        {
            cmd.Parameters.AddWithValue("@NetD_Last_Renew_Date", SqlDbType.VarChar).Value = oNetworkDeviceClass.NetD_Last_Renew_Date;

        }

        if (oNetworkDeviceClass.NetD_Next_Renew_Date == "")
        {
            cmd.Parameters.AddWithValue("@NetD_Next_Renew_Date", SqlDbType.DateTime).Value = DBNull.Value;
            //cmd.Parameters["@Sof_UAT_Date"].Value = DBNull.Value;
        }
        else
        {
            cmd.Parameters.AddWithValue("@NetD_Next_Renew_Date", SqlDbType.VarChar).Value = oNetworkDeviceClass.NetD_Next_Renew_Date;

        }

        if (oNetworkDeviceClass.NetD_BillDate == "")
        {
            cmd.Parameters.AddWithValue("@NetD_BillDate", SqlDbType.DateTime).Value = DBNull.Value;
            //cmd.Parameters["@Sof_UAT_Date"].Value = DBNull.Value;
        }
        else
        {
            cmd.Parameters.AddWithValue("@NetD_BillDate", SqlDbType.VarChar).Value = oNetworkDeviceClass.NetD_BillDate;

        }

       // cmd.Parameters.AddWithValue("@NetD_ChallanDate", SqlDbType.VarChar).Value = oNetworkDeviceClass.NetD_ChallanDate;
        //cmd.Parameters.AddWithValue("@NetD_WorkOrder_Date", SqlDbType.VarChar).Value = oNetworkDeviceClass.NetD_WorkOrder_Date;
        cmd.Parameters.AddWithValue("@NetD_WorkOrder_No", SqlDbType.VarChar).Value = oNetworkDeviceClass.NetD_WorkOrder_No;
        //cmd.Parameters.AddWithValue("@NetD_Receive_Date", SqlDbType.VarChar).Value = oNetworkDeviceClass.NetD_Receive_Date;
        cmd.Parameters.AddWithValue("@NetD_UnderAMC", SqlDbType.VarChar).Value = oNetworkDeviceClass.NetD_UnderAMC;
        //cmd.Parameters.AddWithValue("@NetD_Last_Renew_Date", SqlDbType.VarChar).Value = oNetworkDeviceClass.NetD_Last_Renew_Date;
        //cmd.Parameters.AddWithValue("@NetD_Next_Renew_Date", SqlDbType.VarChar).Value = oNetworkDeviceClass.NetD_Next_Renew_Date;
        cmd.Parameters.AddWithValue("@NetD_UAT_Person", SqlDbType.VarChar).Value = oNetworkDeviceClass.NetD_UAT_Person;
        //cmd.Parameters.AddWithValue("@NetD_BillDate", SqlDbType.VarChar).Value = oNetworkDeviceClass.NetD_BillDate;
        cmd.Parameters.AddWithValue("@User_Id", SqlDbType.VarChar).Value = oNetworkDeviceClass.User_Id;
        cmd.Parameters.AddWithValue("@BrCode", SqlDbType.VarChar).Value = oNetworkDeviceClass.BrCode;
        cmd.Parameters.AddWithValue("@Ser_WaranteePeriod", SqlDbType.VarChar).Value = oNetworkDeviceClass.Ser_WaranteePeriod;
        cmd.Parameters.AddWithValue("@Remarks", SqlDbType.VarChar).Value =oNetworkDeviceClass.Remarks;
        cmd.Parameters.AddWithValue("@NetD_Serial", SqlDbType.VarChar).Value = oNetworkDeviceClass.NetD_Serial;
        cmd.Parameters.AddWithValue("@NetD_HostName", SqlDbType.VarChar).Value = oNetworkDeviceClass.NetD_HostName;


        try
        {
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            i = 1;

        }
        catch { }
        con.Close();
        return i;
    }
    public int UpdateNetworkDevice(NetworkDeviceClass oNetworkDeviceClass)
    {
        con = DatabaseConnection();
        int i = 0, k = 0;


        cmd = new SqlCommand("UPDATE NetworkDevice SET NetD_Name=@NetD_Name,NetD_Type=@NetD_Type,NetD_V_SlNo=@NetD_V_SlNo,NetD_Model=@NetD_Model,NetD_ChallanNo=@NetD_ChallanNo,NetD_Criticality=@NetD_Criticality,NetD_Location=@NetD_Location,NetD_RackNo=@NetD_RackNo,NetD_ChallanDate=@NetD_ChallanDate,NetD_WorkOrder_Date=@NetD_WorkOrder_Date,NetD_WorkOrder_No=@NetD_WorkOrder_No,NetD_Receive_Date=@NetD_Receive_Date,NetD_UnderAMC=@NetD_UnderAMC,NetD_Last_Renew_Date=@NetD_Last_Renew_Date,NetD_Next_Renew_Date=@NetD_Next_Renew_Date,NetD_UAT_Person=@NetD_UAT_Person,NetD_BillDate=@NetD_BillDate,User_Id=@User_Id,BrCode=@BrCode,Ser_WaranteePeriod=@Ser_WaranteePeriod,Remarks=@Remarks,NetD_Serial=@NetD_Serial,NetD_HostName=@NetD_HostName WHERE NetD_slNo=@NetD_slNo", con);
        //SqlCommand cmd = new SqlCommand("insert into test VALUES(@name)",con);
        //    cmd.Parameters.AddWithValue("@name",N'TextBox1.Text);
        cmd.Parameters.AddWithValue("@NetD_slNo", SqlDbType.VarChar).Value = oNetworkDeviceClass.NetD_slNo;
        cmd.Parameters.AddWithValue("@NetD_Name", SqlDbType.VarChar).Value = oNetworkDeviceClass.NetD_Name;
        cmd.Parameters.AddWithValue("@NetD_Type", SqlDbType.Bit).Value = oNetworkDeviceClass.NetD_Type;
        cmd.Parameters.AddWithValue("@NetD_V_SlNo", SqlDbType.VarChar).Value = oNetworkDeviceClass.NetD_V_SlNo;
        cmd.Parameters.AddWithValue("@NetD_Model", SqlDbType.VarChar).Value = oNetworkDeviceClass.NetD_Model;
        cmd.Parameters.AddWithValue("@NetD_ChallanNo", SqlDbType.VarChar).Value = oNetworkDeviceClass.NetD_ChallanNo;
        cmd.Parameters.AddWithValue("@NetD_Criticality", SqlDbType.VarChar).Value = oNetworkDeviceClass.NetD_Criticality;
        cmd.Parameters.AddWithValue("@NetD_Location", SqlDbType.VarChar).Value = oNetworkDeviceClass.NetD_Location;
        cmd.Parameters.AddWithValue("@NetD_RackNo", SqlDbType.VarChar).Value = oNetworkDeviceClass.NetD_RackNo;

        if (oNetworkDeviceClass.NetD_ChallanDate == "")
        {
            cmd.Parameters.AddWithValue("@NetD_ChallanDate", SqlDbType.DateTime).Value = DBNull.Value;
            //cmd.Parameters["@Sof_UAT_Date"].Value = DBNull.Value;
        }
        else
        {
            cmd.Parameters.AddWithValue("@NetD_ChallanDate", SqlDbType.VarChar).Value = oNetworkDeviceClass.NetD_ChallanDate;

        }

        if (oNetworkDeviceClass.NetD_WorkOrder_Date == "")
        {
            cmd.Parameters.AddWithValue("@NetD_WorkOrder_Date", SqlDbType.DateTime).Value = DBNull.Value;
            //cmd.Parameters["@Sof_UAT_Date"].Value = DBNull.Value;
        }
        else
        {
            cmd.Parameters.AddWithValue("@NetD_WorkOrder_Date", SqlDbType.VarChar).Value = oNetworkDeviceClass.NetD_WorkOrder_Date;

        }
        if (oNetworkDeviceClass.NetD_Receive_Date == "")
        {
            cmd.Parameters.AddWithValue("@NetD_Receive_Date", SqlDbType.DateTime).Value = DBNull.Value;
            //cmd.Parameters["@Sof_UAT_Date"].Value = DBNull.Value;
        }
        else
        {
            cmd.Parameters.AddWithValue("@NetD_Receive_Date", SqlDbType.VarChar).Value = oNetworkDeviceClass.NetD_Receive_Date;

        }
        if (oNetworkDeviceClass.NetD_Last_Renew_Date == "")
        {
            cmd.Parameters.AddWithValue("@NetD_Last_Renew_Date", SqlDbType.DateTime).Value = DBNull.Value;
            //cmd.Parameters["@Sof_UAT_Date"].Value = DBNull.Value;
        }
        else
        {
            cmd.Parameters.AddWithValue("@NetD_Last_Renew_Date", SqlDbType.VarChar).Value = oNetworkDeviceClass.NetD_Last_Renew_Date;

        }

        if (oNetworkDeviceClass.NetD_Next_Renew_Date == "")
        {
            cmd.Parameters.AddWithValue("@NetD_Next_Renew_Date", SqlDbType.DateTime).Value = DBNull.Value;
            //cmd.Parameters["@Sof_UAT_Date"].Value = DBNull.Value;
        }
        else
        {
            cmd.Parameters.AddWithValue("@NetD_Next_Renew_Date", SqlDbType.VarChar).Value = oNetworkDeviceClass.NetD_Next_Renew_Date;

        }

        if (oNetworkDeviceClass.NetD_BillDate == "")
        {
            cmd.Parameters.AddWithValue("@NetD_BillDate", SqlDbType.DateTime).Value = DBNull.Value;
            //cmd.Parameters["@Sof_UAT_Date"].Value = DBNull.Value;
        }
        else
        {
            cmd.Parameters.AddWithValue("@NetD_BillDate", SqlDbType.VarChar).Value = oNetworkDeviceClass.NetD_BillDate;

        }

        // cmd.Parameters.AddWithValue("@NetD_ChallanDate", SqlDbType.VarChar).Value = oNetworkDeviceClass.NetD_ChallanDate;
        //cmd.Parameters.AddWithValue("@NetD_WorkOrder_Date", SqlDbType.VarChar).Value = oNetworkDeviceClass.NetD_WorkOrder_Date;
        cmd.Parameters.AddWithValue("@NetD_WorkOrder_No", SqlDbType.VarChar).Value = oNetworkDeviceClass.NetD_WorkOrder_No;
        //cmd.Parameters.AddWithValue("@NetD_Receive_Date", SqlDbType.VarChar).Value = oNetworkDeviceClass.NetD_Receive_Date;
        cmd.Parameters.AddWithValue("@NetD_UnderAMC", SqlDbType.VarChar).Value = oNetworkDeviceClass.NetD_UnderAMC;
        //cmd.Parameters.AddWithValue("@NetD_Last_Renew_Date", SqlDbType.VarChar).Value = oNetworkDeviceClass.NetD_Last_Renew_Date;
        //cmd.Parameters.AddWithValue("@NetD_Next_Renew_Date", SqlDbType.VarChar).Value = oNetworkDeviceClass.NetD_Next_Renew_Date;
        cmd.Parameters.AddWithValue("@NetD_UAT_Person", SqlDbType.VarChar).Value = oNetworkDeviceClass.NetD_UAT_Person;
        //cmd.Parameters.AddWithValue("@NetD_BillDate", SqlDbType.VarChar).Value = oNetworkDeviceClass.NetD_BillDate;
        cmd.Parameters.AddWithValue("@User_Id", SqlDbType.VarChar).Value = oNetworkDeviceClass.User_Id;
        cmd.Parameters.AddWithValue("@BrCode", SqlDbType.VarChar).Value = oNetworkDeviceClass.BrCode;
        cmd.Parameters.AddWithValue("@Ser_WaranteePeriod", SqlDbType.VarChar).Value = oNetworkDeviceClass.Ser_WaranteePeriod;
        cmd.Parameters.AddWithValue("@Remarks", SqlDbType.VarChar).Value =oNetworkDeviceClass.Remarks;
        cmd.Parameters.AddWithValue("@NetD_Serial", SqlDbType.VarChar).Value = oNetworkDeviceClass.NetD_Serial;
        cmd.Parameters.AddWithValue("@NetD_HostName", SqlDbType.VarChar).Value = oNetworkDeviceClass.NetD_HostName;

        try
        {
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            i = 1;

        }
        catch { }
        con.Close();
        return i;
    }
    public DataTable GetNetworkDevice(string condition)
    {
        con = DatabaseConnection();
        cmd = new SqlCommand("SELECT NetworkDevice.NetD_Serial,NetworkDevice.NetD_HostName, NetworkDevice.NetD_slNo, NetworkDevice.NetD_Name, NetworkDevice.NetD_Type, NetworkDevice.NetD_V_SlNo, NetworkDevice.NetD_WorkOrder_No, " +
                     " CONVERT(DATE,NetworkDevice.NetD_WorkOrder_Date) NetD_WorkOrder_Date, CONVERT(DATE,NetworkDevice.NetD_Receive_Date) NetD_Receive_Date, NetworkDevice.NetD_UnderAMC, CONVERT(DATE,NetworkDevice.NetD_Last_Renew_Date) NetD_Last_Renew_Date, " +
                     " CONVERT(DATE,NetworkDevice.NetD_Next_Renew_Date) NetD_Next_Renew_Date, NetworkDevice.NetD_Location, NetworkDevice.NetD_RackNo, NetworkDevice.NetD_BillDate, " +
                     " NetworkDevice.NetD_ChallanDate, NetworkDevice.NetD_Criticality, NetworkDevice.NetD_ChallanNo, NetworkDevice.NetD_Model,NetworkDevice.Ser_WaranteePeriod,NetworkDevice.Remarks, " +
                     " NetworkDevice.NetD_UAT_Person, NetworkDevice.User_Id, NetworkDevice.BrCode, Vendor.V_slNo, Vendor.V_Name, Vendor.V_ContactPerson, Vendor.V_ContactNo, "+
                     " Vendor.V_Address, Vendor.V_Email, Vendor.User_Id AS Expr1, Vendor.BrCode AS Expr2, Emplyee.Emp_slNo, Emplyee.Emp_Name, Emplyee.Emp_BrCode, "+
                     " Emplyee.Emp_Active, Emplyee.Emp_Designation, Emplyee.Emp_ContactNo, Emplyee.Emp_Email, Emplyee.Emp_CurrentDesk "+
                     " FROM  NetworkDevice LEFT OUTER JOIN  Emplyee ON NetworkDevice.NetD_UAT_Person = Emplyee.Emp_slNo LEFT OUTER JOIN "+
                     " Vendor ON NetworkDevice.NetD_V_SlNo = Vendor.V_slNo" + condition + " ORDER BY NetD_slNo desc", con);
        cmd.CommandType = CommandType.Text;
        SqlDataAdapter da = new SqlDataAdapter(cmd);

        DataTable dt = new DataTable();
        try
        {
            da.Fill(dt);
            con.Close();

        }
        catch
        {

        }
        return dt;

    }
    #endregion
    #region DB
    public int InsertDB(DBClass oDBClass)
    {
        con = DatabaseConnection();
        int i = 0, k = 0;


        cmd = new SqlCommand("INSERT INTO DB (DB_Name,DB_Version,DB_V_slNo,User_Id,BrCode,DB_WorkOrder_No,DB_WorkOrder_Date,DB_Receive_Date,DB_UnderAMC,DB_Last_Renew_Date,DB_Next_Renew_Date,Remarks) VALUES(@DB_Name,@DB_Version,@DB_V_slNo,@User_Id,@BrCode,@DB_WorkOrder_No,@DB_WorkOrder_Date,@DB_Receive_Date,@DB_UnderAMC,@DB_Last_Renew_Date,@DB_Next_Renew_Date,@Remarks)", con);
        //SqlCommand cmd = new SqlCommand("insert into test VALUES(@name)",con);
        //    cmd.Parameters.AddWithValue("@name",N'TextBox1.Text);
        cmd.Parameters.AddWithValue("@DB_Name", SqlDbType.VarChar).Value = oDBClass.DB_Name;
        cmd.Parameters.AddWithValue("@DB_Version", SqlDbType.Bit).Value = oDBClass.DB_Version;
        cmd.Parameters.AddWithValue("@DB_V_slNo", SqlDbType.VarChar).Value = oDBClass.DB_V_slNo;
        cmd.Parameters.AddWithValue("@User_Id", SqlDbType.VarChar).Value = oDBClass.User_Id;
        cmd.Parameters.AddWithValue("@BrCode", SqlDbType.VarChar).Value = oDBClass.BrCode;
        cmd.Parameters.AddWithValue("@DB_WorkOrder_No", SqlDbType.VarChar).Value = oDBClass.DB_WorkOrder_No;
        if (oDBClass.DB_WorkOrder_Date == "")
        {
            cmd.Parameters.AddWithValue("@DB_WorkOrder_Date", SqlDbType.DateTime).Value = DBNull.Value;
            //cmd.Parameters["@Sof_UAT_Date"].Value = DBNull.Value;
        }
        else
        {
            cmd.Parameters.AddWithValue("@DB_WorkOrder_Date", SqlDbType.VarChar).Value = oDBClass.DB_WorkOrder_Date;

        }
        if (oDBClass.DB_Receive_Date == "")
        {
            cmd.Parameters.AddWithValue("@DB_Receive_Date", SqlDbType.DateTime).Value = DBNull.Value;
            //cmd.Parameters["@Sof_UAT_Date"].Value = DBNull.Value;
        }
        else
        {
            cmd.Parameters.AddWithValue("@DB_Receive_Date", SqlDbType.VarChar).Value = oDBClass.DB_Receive_Date;

        }
        if (oDBClass.DB_Last_Renew_Date == "")
        {
            cmd.Parameters.AddWithValue("@DB_Last_Renew_Date", SqlDbType.DateTime).Value = DBNull.Value;
            //cmd.Parameters["@Sof_UAT_Date"].Value = DBNull.Value;
        }
        else
        {
            cmd.Parameters.AddWithValue("@DB_Last_Renew_Date", SqlDbType.VarChar).Value = oDBClass.DB_Last_Renew_Date;

        }
        if (oDBClass.DB_Next_Renew_Date == "")
        {
            cmd.Parameters.AddWithValue("@DB_Next_Renew_Date", SqlDbType.DateTime).Value = DBNull.Value;
            //cmd.Parameters["@Sof_UAT_Date"].Value = DBNull.Value;
        }
        else
        {
            cmd.Parameters.AddWithValue("@DB_Next_Renew_Date", SqlDbType.VarChar).Value = oDBClass.DB_Next_Renew_Date;

        }
        cmd.Parameters.AddWithValue("@DB_UnderAMC", SqlDbType.VarChar).Value = oDBClass.DB_UnderAMC;
        cmd.Parameters.AddWithValue("@Remarks", SqlDbType.VarChar).Value =oDBClass.Remarks;
        try
        {
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            i = 1;

        }
        catch { }
        con.Close();
        return i;
    }
    public int UpdateDB(DBClass oDBClass)
    {
        con = DatabaseConnection();
        int i = 0, k = 0;


        cmd = new SqlCommand("UPDATE DB SET DB_Name=@DB_Name,DB_Version=@DB_Version,DB_V_slNo=@DB_V_slNo,User_Id=@User_Id,BrCode=@BrCode,DB_WorkOrder_No=@DB_WorkOrder_No,DB_WorkOrder_Date=@DB_WorkOrder_Date,DB_Receive_Date=@DB_Receive_Date,DB_Last_Renew_Date=@DB_Last_Renew_Date,DB_Next_Renew_Date=@DB_Next_Renew_Date,Remarks=@Remarks WHERE DB_slNo=@DB_slNo", con);
        //SqlCommand cmd = new SqlCommand("insert into test VALUES(@name)",con);
        //    cmd.Parameters.AddWithValue("@name",N'TextBox1.Text);
        cmd.Parameters.AddWithValue("@DB_slNo", SqlDbType.Int).Value = oDBClass.DB_slNo;
        cmd.Parameters.AddWithValue("@DB_Name", SqlDbType.VarChar).Value = oDBClass.DB_Name;
        cmd.Parameters.AddWithValue("@DB_Version", SqlDbType.Bit).Value = oDBClass.DB_Version;
        cmd.Parameters.AddWithValue("@DB_V_slNo", SqlDbType.VarChar).Value = oDBClass.DB_V_slNo;
        cmd.Parameters.AddWithValue("@User_Id", SqlDbType.VarChar).Value = oDBClass.User_Id;
        cmd.Parameters.AddWithValue("@BrCode", SqlDbType.VarChar).Value = oDBClass.BrCode;
        cmd.Parameters.AddWithValue("@DB_WorkOrder_No", SqlDbType.VarChar).Value = oDBClass.DB_WorkOrder_No;
        if (oDBClass.DB_WorkOrder_Date == "")
        {
            cmd.Parameters.AddWithValue("@DB_WorkOrder_Date", SqlDbType.DateTime).Value = DBNull.Value;
            //cmd.Parameters["@Sof_UAT_Date"].Value = DBNull.Value;
        }
        else
        {
            cmd.Parameters.AddWithValue("@DB_WorkOrder_Date", SqlDbType.VarChar).Value = oDBClass.DB_WorkOrder_Date;

        }
        if (oDBClass.DB_Receive_Date == "")
        {
            cmd.Parameters.AddWithValue("@DB_Receive_Date", SqlDbType.DateTime).Value = DBNull.Value;
            //cmd.Parameters["@Sof_UAT_Date"].Value = DBNull.Value;
        }
        else
        {
            cmd.Parameters.AddWithValue("@DB_Receive_Date", SqlDbType.VarChar).Value = oDBClass.DB_Receive_Date;

        }
        if (oDBClass.DB_Last_Renew_Date == "")
        {
            cmd.Parameters.AddWithValue("@DB_Last_Renew_Date", SqlDbType.DateTime).Value = DBNull.Value;
            //cmd.Parameters["@Sof_UAT_Date"].Value = DBNull.Value;
        }
        else
        {
            cmd.Parameters.AddWithValue("@DB_Last_Renew_Date", SqlDbType.VarChar).Value = oDBClass.DB_Last_Renew_Date;

        }
        if (oDBClass.DB_Next_Renew_Date == "")
        {
            cmd.Parameters.AddWithValue("@DB_Next_Renew_Date", SqlDbType.DateTime).Value = DBNull.Value;
            //cmd.Parameters["@Sof_UAT_Date"].Value = DBNull.Value;
        }
        else
        {
            cmd.Parameters.AddWithValue("@DB_Next_Renew_Date", SqlDbType.VarChar).Value = oDBClass.DB_Next_Renew_Date;

        }
        cmd.Parameters.AddWithValue("@DB_UnderAMC", SqlDbType.VarChar).Value = oDBClass.DB_UnderAMC;
        cmd.Parameters.AddWithValue("@Remarks", SqlDbType.VarChar).Value =oDBClass.Remarks;
        try
        {
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            i = 1;

        }
        catch { }
        con.Close();
        return i;
    }
    public DataTable GetDB(string condition)
    {
        con = DatabaseConnection();
        cmd = new SqlCommand("SELECT DB.*, Vendor.* FROM DB INNER JOIN   Vendor ON DB.DB_V_slNo = Vendor.V_slNo " + condition + " ORDER BY DB_slNo", con);
        cmd.CommandType = CommandType.Text;
        SqlDataAdapter da = new SqlDataAdapter(cmd);

        DataTable dt = new DataTable();
        try
        {
            da.Fill(dt);
            con.Close();

        }
        catch
        {

        }
        return dt;

    }
    #endregion
    #region Employee

    public DataTable GetEmployee(string condition)
    {
        con = DatabaseConnection();
        cmd = new SqlCommand("SELECT * from Emplyee " + condition + " ORDER BY  CONVERT(int, Emp_Designation)", con);
        cmd.CommandType = CommandType.Text;
        SqlDataAdapter da = new SqlDataAdapter(cmd);

        DataTable dt = new DataTable();
        try
        {
            da.Fill(dt);
            con.Close();

        }
        catch
        {

        }
        return dt;

    }
    #endregion
    #region Responsibility
    public DataTable GetResponsibility(string condition)
    {
        con = DatabaseConnection();
        cmd = new SqlCommand("SELECT * from Responsibility " + condition + " ORDER BY Res_slNo desc", con);
        cmd.CommandType = CommandType.Text;
        SqlDataAdapter da = new SqlDataAdapter(cmd);

        DataTable dt = new DataTable();
        try
        {
            da.Fill(dt);
            con.Close();

        }
        catch
        {

        }
        return dt;
    }
    #endregion
    #region EmployeeResponsibility
    public int InsertEmployeeResponsibility(int ER_Emp_slNo, int ER_Res_slNo ,string columnName,int columnValue)
    {
        con = DatabaseConnection();
        int i = 0, k = 0;


        cmd = new SqlCommand("INSERT INTO EmployeeResposibility (ER_Emp_slNo,ER_Res_slNo," + columnName + ") VALUES(@ER_Emp_slNo,@ER_Res_slNo,@" + columnName + ")", con);
        //SqlCommand cmd = new SqlCommand("insert into test VALUES(@name)",con);
        //    cmd.Parameters.AddWithValue("@name",N'TextBox1.Text);
        cmd.Parameters.AddWithValue("@ER_Emp_slNo", SqlDbType.VarChar).Value = ER_Emp_slNo;
        cmd.Parameters.AddWithValue("@ER_Res_slNo", SqlDbType.Bit).Value = ER_Res_slNo;
        cmd.Parameters.AddWithValue("@" + columnName + "", SqlDbType.VarChar).Value = columnValue;
       
        try
        {
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            i = 1;

        }
        catch { }
        con.Close();
        return i;
    }

    public int UpdateEmployeeResponsibility(int ER_slNo, int ER_Emp_slNo, int ER_Res_slNo, string columnName, int columnValue)
    {
        con = DatabaseConnection();
        int i = 0, k = 0;


        cmd = new SqlCommand("UPDATE EmployeeResposibility SET ER_Emp_slNo=@ER_Emp_slNo,ER_Res_slNo=@ER_Res_slNo," + columnName + "=@" + columnName + " WHERE ER_slNo=@ER_slNo", con);
        //SqlCommand cmd = new SqlCommand("insert into test VALUES(@name)",con);
        //    cmd.Parameters.AddWithValue("@name",N'TextBox1.Text);
        cmd.Parameters.AddWithValue("@ER_Emp_slNo", SqlDbType.Int).Value = ER_Emp_slNo;
        cmd.Parameters.AddWithValue("@ER_Res_slNo", SqlDbType.Int).Value = ER_Res_slNo;
        cmd.Parameters.AddWithValue("@" + columnName + "", SqlDbType.VarChar).Value = columnValue;
        cmd.Parameters.AddWithValue("@ER_slNo", SqlDbType.Int).Value = ER_slNo;

        try
        {
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            i = 1;

        }
        catch { }
        con.Close();
        return i;
    }
    public DataTable GetEmployeeResponsibility(string condition)
    {
        con = DatabaseConnection();
        cmd = new SqlCommand("SELECT  EmployeeResposibility.ER_slNo, EmployeeResposibility.ER_Emp_slNo, EmployeeResposibility.ER_Res_slNo, EmployeeResposibility.ER_Ser_slNo, "+ 
                     " EmployeeResposibility.ER_Sof_slNo, EmployeeResposibility.ER_Net_slNo, EmployeeResposibility.ER_DB_slNo, Responsibility.Res_Name, Emplyee.Emp_Name, "+
                    "  Software.Sof_Name, Server.Ser_Name, Server.Ser_IP, NetworkDevice.NetD_Name, DB.DB_Name "+
                     "  FROM         EmployeeResposibility INNER JOIN   Responsibility ON EmployeeResposibility.ER_Res_slNo = Responsibility.Res_slNo INNER JOIN "+
                     " Emplyee ON EmployeeResposibility.ER_Emp_slNo = Emplyee.Emp_slNo LEFT OUTER JOIN "+
                     " Server ON EmployeeResposibility.ER_Ser_slNo = Server.Ser_slNo LEFT OUTER JOIN "+
                     " NetworkDevice ON EmployeeResposibility.ER_Net_slNo = NetworkDevice.NetD_slNo LEFT OUTER JOIN "+
                    "  DB ON EmployeeResposibility.ER_DB_slNo = DB.DB_slNo LEFT OUTER JOIN "+
                     " Software ON EmployeeResposibility.ER_Sof_slNo = Software.Sof_slNo " + condition + " ORDER BY ER_slNo desc", con);
        cmd.CommandType = CommandType.Text;
        SqlDataAdapter da = new SqlDataAdapter(cmd);

        DataTable dt = new DataTable();
        try
        {
            da.Fill(dt);
            con.Close();

        }
        catch
        {

        }
        return dt;
    }
    #endregion
    #region IpAddress
    public DataTable GeIpAddress(string condition)
    {
        con = DatabaseConnection();
        cmd = new SqlCommand("SELECT * from IP_Adrress " + condition + " ORDER BY IP_slNo desc", con);
        cmd.CommandType = CommandType.Text;
        SqlDataAdapter da = new SqlDataAdapter(cmd);

        DataTable dt = new DataTable();
        try
        {
            da.Fill(dt);
            con.Close();

        }
        catch
        {

        }
        return dt;

    }
    public int InsertIP_Address(string IP_Address)
    {
        con = DatabaseConnection();
        int i = 0, k = 0;


        cmd = new SqlCommand("INSERT INTO dbo.[IP_Adrress] (IP_Address) VALUES(@IP_Address)", con);
        //SqlCommand cmd = new SqlCommand("insert into test VALUES(@name)",con);
        //    cmd.Parameters.AddWithValue("@name",N'TextBox1.Text);
        cmd.Parameters.AddWithValue("@IP_Address", SqlDbType.VarChar).Value = IP_Address;

        try
        {
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            i = 1;

        }
        catch { }
        con.Close();
        return i;
    }
    #endregion

    #region Backup
    public int InsertBackup(BackupClass oBackupClass)
    {
        con = DatabaseConnection();
        int i = 0, k = 0;


        cmd = new SqlCommand("INSERT INTO dbo.[Backup] (Back_SoftWare,Back_Media,Back_DataBase,Back_DataBase_Receive_Date,Back_custodian,Back_Person,Back_CheckedBy,Back_Entry_Date,User_Id,BrCode,Remarks) VALUES(@Back_SoftWare,@Back_Media,@Back_DataBase,@Back_DataBase_Receive_Date,@Back_custodian,@Back_Person,@Back_CheckedBy,@Back_Entry_Date,@User_Id,@BrCode,@Remarks)", con);
        //SqlCommand cmd = new SqlCommand("insert into test VALUES(@name)",con);
        //    cmd.Parameters.AddWithValue("@name",N'TextBox1.Text);
        cmd.Parameters.AddWithValue("@Back_SoftWare", SqlDbType.VarChar).Value = oBackupClass.Back_SoftWare;
        cmd.Parameters.AddWithValue("@Back_Media", SqlDbType.VarChar).Value = oBackupClass.Back_Media;
        cmd.Parameters.AddWithValue("@Back_DataBase", SqlDbType.VarChar).Value = oBackupClass.Back_DataBase;
        //cmd.Parameters.AddWithValue("@Back_DataBase_Receive_Date", SqlDbType.VarChar).Value = oBackupClass.Back_DataBase_Receive_Date;
        cmd.Parameters.AddWithValue("@Back_custodian", SqlDbType.VarChar).Value = oBackupClass.Back_custodian;
        cmd.Parameters.AddWithValue("@Back_Person", SqlDbType.VarChar).Value = oBackupClass.Back_Person;
        cmd.Parameters.AddWithValue("@Back_CheckedBy", SqlDbType.VarChar).Value = oBackupClass.Back_CheckedBy;
        //cmd.Parameters.AddWithValue("@Back_Entry_Date", SqlDbType.VarChar).Value = oBackupClass.Back_Entry_Date;
        if (oBackupClass.Back_Entry_Date == "")
        {
            cmd.Parameters.AddWithValue("@Back_Entry_Date", SqlDbType.DateTime).Value = DBNull.Value;
            //cmd.Parameters["@Sof_UAT_Date"].Value = DBNull.Value;
        }
        else
        {
            cmd.Parameters.AddWithValue("@Back_Entry_Date", SqlDbType.VarChar).Value = oBackupClass.Back_Entry_Date;

        }
        if (oBackupClass.Back_DataBase_Receive_Date == "")
        {
            cmd.Parameters.AddWithValue("@Back_DataBase_Receive_Date", SqlDbType.DateTime).Value = DBNull.Value;
            //cmd.Parameters["@Sof_UAT_Date"].Value = DBNull.Value;
        }
        else
        {
            cmd.Parameters.AddWithValue("@Back_DataBase_Receive_Date", SqlDbType.VarChar).Value = oBackupClass.Back_DataBase_Receive_Date;

        }
        cmd.Parameters.AddWithValue("@User_Id", SqlDbType.VarChar).Value = oBackupClass.User_Id;
        cmd.Parameters.AddWithValue("@BrCode", SqlDbType.VarChar).Value = oBackupClass.BrCode;
        cmd.Parameters.AddWithValue("@Remarks", SqlDbType.VarChar).Value = oBackupClass.Remarks;
        try
        {
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            i = 1;

        }
        catch { }
        con.Close();
        return i;
    }
    public int UpdateBackup(BackupClass oBackupClass)
    {
        con = DatabaseConnection();
        int i = 0, k = 0;


        cmd = new SqlCommand("UPDATE dbo.[Backup] SET Back_SoftWare=@Back_SoftWare,Back_Media=@Back_Media,Back_DataBase=@Back_DataBase,Back_DataBase_Receive_Date=@Back_DataBase_Receive_Date,Back_custodian=@Back_custodian,Back_Person=@Back_Person,Back_CheckedBy=@Back_CheckedBy,Back_Entry_Date=@Back_Entry_Date,User_Id=@User_Id,BrCode=@BrCode,Remarks=@Remarks WHERE Back_SlNo=@Back_SlNo", con);
        //SqlCommand cmd = new SqlCommand("insert into test VALUES(@name)",con);
        //    cmd.Parameters.AddWithValue("@name",N'TextBox1.Text);
        cmd.Parameters.AddWithValue("@Back_SlNo", SqlDbType.Int).Value = oBackupClass.Back_SlNo;
        cmd.Parameters.AddWithValue("@Back_SoftWare", SqlDbType.VarChar).Value = oBackupClass.Back_SoftWare;
        cmd.Parameters.AddWithValue("@Back_Media", SqlDbType.VarChar).Value = oBackupClass.Back_Media;
        cmd.Parameters.AddWithValue("@Back_DataBase", SqlDbType.VarChar).Value = oBackupClass.Back_DataBase;
        //cmd.Parameters.AddWithValue("@Back_DataBase_Receive_Date", SqlDbType.VarChar).Value = oBackupClass.Back_DataBase_Receive_Date;
        cmd.Parameters.AddWithValue("@Back_custodian", SqlDbType.VarChar).Value = oBackupClass.Back_custodian;
        cmd.Parameters.AddWithValue("@Back_Person", SqlDbType.VarChar).Value = oBackupClass.Back_Person;
        cmd.Parameters.AddWithValue("@Back_CheckedBy", SqlDbType.VarChar).Value = oBackupClass.Back_CheckedBy;
        //cmd.Parameters.AddWithValue("@Back_Entry_Date", SqlDbType.VarChar).Value = oBackupClass.Back_Entry_Date;
        if (oBackupClass.Back_Entry_Date == "")
        {
            cmd.Parameters.AddWithValue("@Back_Entry_Date", SqlDbType.DateTime).Value = DBNull.Value;
            //cmd.Parameters["@Sof_UAT_Date"].Value = DBNull.Value;
        }
        else
        {
            cmd.Parameters.AddWithValue("@Back_Entry_Date", SqlDbType.VarChar).Value = oBackupClass.Back_Entry_Date;

        }
        if (oBackupClass.Back_DataBase_Receive_Date == "")
        {
            cmd.Parameters.AddWithValue("@Back_DataBase_Receive_Date", SqlDbType.DateTime).Value = DBNull.Value;
            //cmd.Parameters["@Sof_UAT_Date"].Value = DBNull.Value;
        }
        else
        {
            cmd.Parameters.AddWithValue("@Back_DataBase_Receive_Date", SqlDbType.VarChar).Value = oBackupClass.Back_DataBase_Receive_Date;

        }
        cmd.Parameters.AddWithValue("@User_Id", SqlDbType.VarChar).Value = oBackupClass.User_Id;
        cmd.Parameters.AddWithValue("@BrCode", SqlDbType.VarChar).Value = oBackupClass.BrCode;
        cmd.Parameters.AddWithValue("@Remarks", SqlDbType.VarChar).Value = oBackupClass.Remarks;
        try
        {
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            i = 1;

        }
        catch { }
        con.Close();
        return i;
    }
    public DataTable GetBackup(string condition)
    {
        con = DatabaseConnection();
        cmd = new SqlCommand("SELECT  [Backup].Back_SlNo, [Backup].Back_SoftWare, [Backup].Back_Media, [Backup].Back_DataBase, [Backup].Back_DataBase_Receive_Date, [Backup].Back_custodian, "+
                     " [Backup].Back_Person, [Backup].Back_CheckedBy, [Backup].Back_Entry_Date, [Backup].User_Id, [Backup].BrCode, [Backup].Remarks, Emplyee.Emp_Name 'BackupBy', "+
                     " Emplyee_1.Emp_Name 'ChecedBy' FROM   [Backup]   Left outer JOIN "+
                     " Emplyee ON Emplyee.Emp_slNo = [Backup].Back_Person Left outer JOIN " +
                     " Emplyee AS Emplyee_1 ON [Backup].Back_CheckedBy = Emplyee_1.Emp_slNo " + condition + " ORDER BY Back_SlNo desc", con);
        cmd.CommandType = CommandType.Text;
        SqlDataAdapter da = new SqlDataAdapter(cmd);

        DataTable dt = new DataTable();
        try
        {
            da.Fill(dt);
            con.Close();

        }
        catch
        {

        }
        return dt;

    }
    #endregion
    
}