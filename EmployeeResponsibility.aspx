<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="EmployeeResponsibility.aspx.cs" Inherits="EmployeeResponsibility" %>


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
    <legend>&nbsp;Employee Responsibility</legend>
    <table>
     <tr>
     <td ></td>
     <td colspan="4">
         &nbsp;</td>
     </tr>
    <tr>
    <td >Employee<label>:</label></td>
    <td class="style1">
        <asp:DropDownList ID="employeeDropDownList" runat="server">
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
    <tr>
    <td >&nbsp;</td>
    <td class="style1">
        <asp:DropDownList ID="deviceDropDownList" runat="server"  AutoPostBack="true"
            onselectedindexchanged="deviceDropDownList_SelectedIndexChanged">
           <asp:ListItem Text="Software" Value="1"></asp:ListItem>
         <asp:ListItem Text="Server" Value="2"></asp:ListItem>
          <asp:ListItem Text="Network Device" Value="3"></asp:ListItem>
           <asp:ListItem Text="Database" Value="4"></asp:ListItem>
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
     <tr>
    <td >List:</td>
    <td class="style1">
        <asp:DropDownList ID="ListDropDownList" runat="server">
         
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
    <tr>
    <td >
        <label>Responsibility:</label></td>
    <td class="style1">
        <asp:DropDownList ID="responsibilityDropDownList" runat="server">
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
      
   <tr>
    <td >
        &nbsp;</td>
    <td class="style1">
            &nbsp;</td>
    <td> 
        </td>
    <td ></td>
   
    <td>
        &nbsp;</td>
         <td>&nbsp;</td><td>
        &nbsp;</td>
    </tr>
   <tr>
    <td >
        &nbsp;</td>
    <td class="style1">
            &nbsp;</td>
    <td> 
        </td>
    <td ></td>
   
    <td>
        &nbsp;</td>
         <td>&nbsp;</td><td>
        &nbsp;</td>
    </tr>   
    <tr><td>
        
        </td>
        <td colspan="2">
        <asp:Button ID="addButton" CssClass="menu" runat="server" Text="Add" Width="61px" 
            ValidationGroup="s" onclick="addButton_Click" />
            </td>
            <td>
                &nbsp;</td>
        </tr>

        
    </table>
     <table ><tr><td >
       
             <asp:GridView ID="GridView1" runat="server" AllowPaging="true" 
                    AutoGenerateColumns="false" DataKeyNames="ER_slNo"
                    OnPageIndexChanging="GridView1_PageIndexChanging"  Width="500px"
                                    
                    PageSize="5" 
                >
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
   
                        <asp:TemplateField Visible="false">
                            <EditItemTemplate>
                                <asp:TextBox ID="idTextBox" runat="server" Text='<%#Eval("ER_slNo") %>' 
                                    Visible="false"></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="idLabel" runat="server" Text='<%#Eval("ER_slNo") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Emp_Name">
                           
                            <ItemTemplate>
                                <asp:Label ID="Emp_NameLabel" runat="server" Text='<%#Eval("Emp_Name") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Res_Name">
                         
                            <ItemTemplate>
                                <asp:Label ID="Res_NameLabel" runat="server" 
                                    Text='<%#Eval("Res_Name") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Sof_Name">
                         
                            <ItemTemplate>
                                <asp:Label ID="Sof_NameLabel" runat="server" 
                                    Text='<%#Eval("Sof_Name") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                       <asp:TemplateField HeaderText="Ser_Name">
                         
                            <ItemTemplate>
                                <asp:Label ID="Ser_NameLabel" runat="server" 
                                    Text='<%#Eval("Ser_Name") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                          <asp:TemplateField HeaderText="Ser_IP">
                         
                            <ItemTemplate>
                                <asp:Label ID="Ser_IPLabel" runat="server" 
                                    Text='<%#Eval("Ser_IP") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                         <asp:TemplateField HeaderText="NetD_Name">
                         
                            <ItemTemplate>
                                <asp:Label ID="NetD_NameLabel" runat="server" 
                                    Text='<%#Eval("NetD_Name") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                         <asp:TemplateField HeaderText="DB_Name">
                         
                            <ItemTemplate>
                                <asp:Label ID="DB_NameLabel" runat="server" 
                                    Text='<%#Eval("DB_Name") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                  <asp:TemplateField>
        <ItemTemplate>
                <asp:LinkButton ID="btnEdit" ForeColor="Black" runat="server" Text="Select" OnClick="btnEdit_Click"/>
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

