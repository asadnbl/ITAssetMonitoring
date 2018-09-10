<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="DeviceList.aspx.cs" Inherits="DeviceList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
    <style type="text/css">
        .menu
        {}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <table width="auto" align="center">
    <tr>
    <td>
    <fieldset>
    <legend>Device List</legend>
    <table>
     <tr>
     <td ></td>
     <td colspan="4">
         &nbsp;</td>
     </tr>
    <tr>
    <td >&nbsp;</td>
    <td class="style1">
        <asp:DropDownList ID="DropDownList1" AutoPostBack="true" runat="server" 
            onselectedindexchanged="DropDownList1_SelectedIndexChanged">
        <asp:ListItem Text="Software" Value="1"></asp:ListItem>
         <asp:ListItem Text="Server" Value="2"></asp:ListItem>
          <asp:ListItem Text="Network Device" Value="3"></asp:ListItem>
           <asp:ListItem Text="Database" Value="4"></asp:ListItem>
              <asp:ListItem Text="Backup" Value="5"></asp:ListItem>
        </asp:DropDownList>
        
        </td>
    <td> 
        </td>
    <td ></td>
   
    <td>
        &nbsp;</td>
         <td>&nbsp;</td><td>
        &nbsp;</td>
    </tr>
        <%--<asp:TemplateField>
       <ItemTemplate>
                <asp:LinkButton ID="btnPrint" ForeColor="Black" runat="server" Text="Print" OnClick="btnPrint_Click" />
        </ItemTemplate>
    </asp:TemplateField>--%>
    

        
    </table>
     <table ><tr><td >
       
             <asp:GridView ID="GridView1" runat="server" AllowPaging="true" 
                    AutoGenerateColumns="false" DataKeyNames="Sof_slNo"
                     Width="500px"
                                    
                    PageSize="30" onpageindexchanging="GridView1_PageIndexChanging" 
                >
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
   
                        <asp:TemplateField >
                            <EditItemTemplate>
                                <asp:TextBox ID="idTextBox" runat="server" Text='<%#Eval("Sof_slNo") %>' 
                                    Visible="false"></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="idLabel" runat="server" Text='<%#Eval("Sof_slNo") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                          <asp:TemplateField HeaderText="Sof_Name">
                           
                            <ItemTemplate>
                                <asp:Label ID="Sof_NameLabel" runat="server" Text='<%#Eval("Sof_Name") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Ser_IP">
                         
                            <ItemTemplate>
                                <asp:Label ID="Ser_IPLabel" runat="server" 
                                    Text='<%#Eval("Ser_IP") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Sof_Type">
                         
                            <ItemTemplate>
                                <asp:Label ID="Sof_TypeLabel" runat="server" 
                                    Text='<%#Eval("Sof_Type") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                       <asp:TemplateField HeaderText="Sof_CurrentVirsion">
                         
                            <ItemTemplate>
                                <asp:Label ID="Sof_CurrentVirsionLabel" runat="server" 
                                    Text='<%#Eval("Sof_CurrentVirsion") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                          <asp:TemplateField HeaderText="Sof_HostedLocation">
                         
                            <ItemTemplate>
                                <asp:Label ID="Sof_HostedLocationLabel" runat="server" 
                                    Text='<%#Eval("Sof_HostedLocation") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                          <asp:TemplateField HeaderText="Sof_ScemaName">
                         
                            <ItemTemplate>
                                <asp:Label ID="Sof_ScemaNameLabel" runat="server" 
                                    Text='<%#Eval("Sof_ScemaName") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                         <%--<asp:TemplateField HeaderText="Ser_WaranteePeriod">
                         
                            <ItemTemplate>
                                <asp:Label ID="Ser_WaranteePeriodLabel" runat="server" 
                                    Text='<%#Eval("Ser_WaranteePeriod") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>--%>
                  <asp:TemplateField>
        <ItemTemplate>
                <asp:LinkButton ID="btnEdit" ForeColor="Black" runat="server" Text="Details" OnClick="btnEdit_Click"/>
        </ItemTemplate>
      
    </asp:TemplateField>
    <%--<asp:TemplateField>
       <ItemTemplate>
                <asp:LinkButton ID="btnPrint" ForeColor="Black" runat="server" Text="Print" OnClick="btnPrint_Click" />
        </ItemTemplate>
    </asp:TemplateField>--%>
                                               
                   
                   <%-- [id] [int] IDENTITY(1,1) NOT NULL,
	[userId] [varchar](50) NOT NULL,
	[userName] [varchar](50) NULL,
	//[password] [varchar](50) NULL,
	[brCode] [varchar](50) NULL,
	[designation] [varchar](20) NULL,
	[active] [bit] NULL,
	[userType] [varchar](50) NULL,--%>
                      
                    </Columns>
                    <EditRowStyle BackColor="#999999" />
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#E9E7E2" />
                    <SortedAscendingHeaderStyle BackColor="#506C8C" />
                    <SortedDescendingCellStyle BackColor="#FFFDF8" />
                    <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                </asp:GridView>
          
             <asp:GridView ID="GridView2" runat="server" AllowPaging="true" 
                    AutoGenerateColumns="false" DataKeyNames="Ser_slNo"
                     Width="500px"
                                    
                    PageSize="30" onpageindexchanging="GridView2_PageIndexChanging" 
                >
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
   
                        <asp:TemplateField >
                            <EditItemTemplate>
                                <asp:TextBox ID="idTextBox0" runat="server" Text='<%#Eval("Ser_slNo") %>' 
                                    Visible="false"></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="idLabel0" runat="server" Text='<%#Eval("Ser_slNo") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                           <asp:TemplateField HeaderText="Ser_Name">
                           
                            <ItemTemplate>
                                <asp:Label ID="Ser_NameLabel" runat="server" Text='<%#Eval("Ser_Name") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Ser_IP">
                         
                            <ItemTemplate>
                                <asp:Label ID="Ser_IPLabel" runat="server" 
                                    Text='<%#Eval("Ser_IP") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Ser_Storage">
                         
                            <ItemTemplate>
                                <asp:Label ID="Ser_StorageLabel" runat="server" 
                                    Text='<%#Eval("Ser_Storage") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                       <asp:TemplateField HeaderText="Ser_Criticality">
                         
                            <ItemTemplate>
                                <asp:Label ID="Ser_CriticalityLabel" runat="server" 
                                    Text='<%#Eval("Ser_Criticality") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                          <asp:TemplateField HeaderText="Ser_Location">
                         
                            <ItemTemplate>
                                <asp:Label ID="Ser_LocationLabel" runat="server" 
                                    Text='<%#Eval("Ser_Location") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                          <asp:TemplateField HeaderText="Ser_RackNo">
                         
                            <ItemTemplate>
                                <asp:Label ID="Ser_RackNoLabel" runat="server" 
                                    Text='<%#Eval("Ser_RackNo") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                         <asp:TemplateField HeaderText="Ser_WarratyStatus">
                         
                            <ItemTemplate>
                                <asp:Label ID="Ser_WarratyStatusLabel" runat="server" 
                                    Text='<%#Eval("Ser_WarratyStatus") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                  <asp:TemplateField>
        <ItemTemplate>
                <asp:LinkButton ID="btnEdit0" ForeColor="Black" runat="server" Text="Details" 
                    OnClick="btnEdit_Click"/>
        </ItemTemplate>
      
    </asp:TemplateField>
    <%--<asp:TemplateField>
       <ItemTemplate>
                <asp:LinkButton ID="btnPrint" ForeColor="Black" runat="server" Text="Print" OnClick="btnPrint_Click" />
        </ItemTemplate>
    </asp:TemplateField>--%>
                                               
                   
                   <%-- [id] [int] IDENTITY(1,1) NOT NULL,
	[userId] [varchar](50) NOT NULL,
	[userName] [varchar](50) NULL,
	//[password] [varchar](50) NULL,
	[brCode] [varchar](50) NULL,
	[designation] [varchar](20) NULL,
	[active] [bit] NULL,
	[userType] [varchar](50) NULL,--%>
                      
                    </Columns>
                    <EditRowStyle BackColor="#999999" />
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#E9E7E2" />
                    <SortedAscendingHeaderStyle BackColor="#506C8C" />
                    <SortedDescendingCellStyle BackColor="#FFFDF8" />
                    <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                </asp:GridView>
          
             <asp:GridView ID="GridView3" runat="server" AllowPaging="true" 
                    AutoGenerateColumns="false" DataKeyNames="NetD_slNo"
                     Width="500px"
                                    
                    PageSize="30" onpageindexchanging="GridView3_PageIndexChanging" 
                >
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
   
                        <asp:TemplateField >
                            <EditItemTemplate>
                                <asp:TextBox ID="idTextBox1" runat="server" Text='<%#Eval("NetD_slNo") %>' 
                                    Visible="false"></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="idLabel1" runat="server" Text='<%#Eval("NetD_slNo") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                     <asp:TemplateField HeaderText="NetD_Type">
                         
                            <ItemTemplate>
                                <asp:Label ID="NetD_TypeLabel" runat="server" 
                                    Text='<%#Eval("NetD_Type") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="NetD_Name">
                           
                            <ItemTemplate>
                                <asp:Label ID="NetD_NameLabel" runat="server" Text='<%#Eval("NetD_Name") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                       
                        <asp:TemplateField HeaderText="NetD_Challan_No">
                         
                            <ItemTemplate>
                                <asp:Label ID="NetD_ChallanNoLabel" runat="server" 
                                    Text='<%#Eval("NetD_ChallanNo") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                       <asp:TemplateField HeaderText="NetD_Criticality">
                         
                            <ItemTemplate>
                                <asp:Label ID="NetD_CriticalityLabel" runat="server" 
                                    Text='<%#Eval("NetD_Criticality") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                          <asp:TemplateField HeaderText="NetD_Location">
                         
                            <ItemTemplate>
                                <asp:Label ID="NetD_LocationLabel" runat="server" 
                                    Text='<%#Eval("NetD_Location") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                         <asp:TemplateField HeaderText="Serial">
                         
                            <ItemTemplate>
                                <asp:Label ID="NetD_SerialLabel" runat="server" 
                                    Text='<%#Eval("NetD_Serial") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                         <asp:TemplateField HeaderText="Host Name">
                         
                            <ItemTemplate>
                                <asp:Label ID="NetD_HostNameLabel" runat="server" 
                                    Text='<%#Eval("NetD_HostName") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                          <asp:TemplateField HeaderText="NetD_RackNo">
                         
                            <ItemTemplate>
                                <asp:Label ID="NetD_RackNoLabel" runat="server" 
                                    Text='<%#Eval("NetD_RackNo") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                         <asp:TemplateField HeaderText="NetD_Bill_Date">
                         
                            <ItemTemplate>
                                <asp:Label ID="NetD_BillDateLabel" runat="server" 
                                    Text='<%#Eval("NetD_BillDate") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                  <asp:TemplateField>
        <ItemTemplate>
                <asp:LinkButton ID="btnEdit1" ForeColor="Black" runat="server" Text="Details" 
                    OnClick="btnEdit_Click"/>
        </ItemTemplate>
      
    </asp:TemplateField>
    <%--<asp:TemplateField>
       <ItemTemplate>
                <asp:LinkButton ID="btnPrint" ForeColor="Black" runat="server" Text="Print" OnClick="btnPrint_Click" />
        </ItemTemplate>
    </asp:TemplateField>--%>
                                               
                   
                   <%-- [id] [int] IDENTITY(1,1) NOT NULL,
	[userId] [varchar](50) NOT NULL,
	[userName] [varchar](50) NULL,
	//[password] [varchar](50) NULL,
	[brCode] [varchar](50) NULL,
	[designation] [varchar](20) NULL,
	[active] [bit] NULL,
	[userType] [varchar](50) NULL,--%>
                      
                    </Columns>
                    <EditRowStyle BackColor="#999999" />
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#E9E7E2" />
                    <SortedAscendingHeaderStyle BackColor="#506C8C" />
                    <SortedDescendingCellStyle BackColor="#FFFDF8" />
                    <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                </asp:GridView>
          
             <asp:GridView ID="GridView4" runat="server" AllowPaging="true" 
                    AutoGenerateColumns="false" DataKeyNames="DB_slNo"
                    OnPageIndexChanging="GridView4_PageIndexChanging"  Width="500px"
                                    
                    PageSize="30" 
                >
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
   
                        <asp:TemplateField >
                            <EditItemTemplate>
                                <asp:TextBox ID="idTextBox2" runat="server" Text='<%#Eval("DB_slNo") %>' 
                                    Visible="false"></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="idLabel2" runat="server" Text='<%#Eval("DB_slNo") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="DB_Name">
                           
                            <ItemTemplate>
                                <asp:Label ID="DB_NameLabel" runat="server" Text='<%#Eval("DB_Name") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="DB_Virsion">
                         
                            <ItemTemplate>
                                <asp:Label ID="DB_VirsionLabel" runat="server" 
                                    Text='<%#Eval("DB_Version") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Vendor Name">
                         
                            <ItemTemplate>
                                <asp:Label ID="V_NameLabel" runat="server" 
                                    Text='<%#Eval("V_Name") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                      
                  <asp:TemplateField>
        <ItemTemplate>
                <asp:LinkButton ID="btnEdit2" ForeColor="Black" runat="server" Text="Details" 
                    OnClick="btnEdit_Click"/>
        </ItemTemplate>
      
    </asp:TemplateField>
    <%--<asp:TemplateField>
       <ItemTemplate>
                <asp:LinkButton ID="btnPrint" ForeColor="Black" runat="server" Text="Print" OnClick="btnPrint_Click" />
        </ItemTemplate>
    </asp:TemplateField>--%>
                                               
                   
                   <%-- [id] [int] IDENTITY(1,1) NOT NULL,
	[userId] [varchar](50) NOT NULL,
	[userName] [varchar](50) NULL,
	//[password] [varchar](50) NULL,
	[brCode] [varchar](50) NULL,
	[designation] [varchar](20) NULL,
	[active] [bit] NULL,
	[userType] [varchar](50) NULL,--%>
                      
                    </Columns>
                    <EditRowStyle BackColor="#999999" />
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#E9E7E2" />
                    <SortedAscendingHeaderStyle BackColor="#506C8C" />
                    <SortedDescendingCellStyle BackColor="#FFFDF8" />
                    <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                </asp:GridView>
          <asp:GridView ID="GridView5" runat="server" AllowPaging="true" 
                    AutoGenerateColumns="false" DataKeyNames="Back_SlNo"
                    OnPageIndexChanging="GridView5_PageIndexChanging"  Width="500px"
                                    
                    PageSize="5" 
                >
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
   
                        <asp:TemplateField Visible="false">
                            <EditItemTemplate>
                                <asp:TextBox ID="idTextBox" runat="server" Text='<%#Eval("Back_SlNo") %>' 
                                    Visible="false"></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="idLabel" runat="server" Text='<%#Eval("Back_SlNo") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Application">
                           
                            <ItemTemplate>
                                <asp:Label ID="Back_SoftWareLabel" runat="server" Text='<%#Eval("Back_SoftWare") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Media">
                         
                            <ItemTemplate>
                                <asp:Label ID="Back_MediaLabel" runat="server" 
                                    Text='<%#Eval("Back_Media") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Database Name">
                         
                            <ItemTemplate>
                                <asp:Label ID="Back_DataBaseLabel" runat="server" 
                                    Text='<%#Eval("Back_DataBase") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                             <asp:TemplateField HeaderText="DataBase Receive_Date">
                         
                            <ItemTemplate>
                                <asp:Label ID="Back_DataBase_Receive_DateLabel" runat="server" 
                                    Text='<%#Eval("Back_DataBase_Receive_Date", "{0:dd/MM/yyyy}") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                      
                  <asp:TemplateField>
        <ItemTemplate>
                <asp:LinkButton ID="btnEdit" ForeColor="Black" runat="server" Text="Details" OnClick="btnEdit_Click"/>
        </ItemTemplate>
      
    </asp:TemplateField>
    <%--<asp:TemplateField>
       <ItemTemplate>
                <asp:LinkButton ID="btnPrint" ForeColor="Black" runat="server" Text="Print" OnClick="btnPrint_Click" />
        </ItemTemplate>
    </asp:TemplateField>--%>
                                               
                   
                   <%-- [id] [int] IDENTITY(1,1) NOT NULL,
	[userId] [varchar](50) NOT NULL,
	[userName] [varchar](50) NULL,
	//[password] [varchar](50) NULL,
	[brCode] [varchar](50) NULL,
	[designation] [varchar](20) NULL,
	[active] [bit] NULL,
	[userType] [varchar](50) NULL,--%>
                      
                    </Columns>
                    <EditRowStyle BackColor="#999999" />
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#E9E7E2" />
                    <SortedAscendingHeaderStyle BackColor="#506C8C" />
                    <SortedDescendingCellStyle BackColor="#FFFDF8" />
                    <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                </asp:GridView>
             </td></tr>
            
             </table>
       
    </fieldset> 
    
     </td>
    </tr>
   
    </table>

</asp:Content>
