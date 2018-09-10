<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Backup.aspx.cs" Inherits="Backup" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
    <style type="text/css">
        .menu
        {}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <cc1:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </cc1:ToolkitScriptManager>
    <table width="auto" align="center">
    <tr>
    <td>
    <fieldset>
    <legend>&nbsp;Backup</legend>
    <table>
     <tr>
     <td ></td>
     <td colspan="4">
         &nbsp;</td>
     </tr>
    <tr>
    <td >Application Name<label>:</label></td>
    <td class="style1">
            <asp:DropDownList ID="softwareDropDownList" runat="server">
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
    <td >
        <label>Backup Media:</label></td>
    <td class="style1">
            <asp:DropDownList ID="mediaDropDownList" runat="server">
            <asp:ListItem>
            Hard Disk
            </asp:ListItem>
            <asp:ListItem>
            Penderive
            </asp:ListItem>
            <asp:ListItem>
            Tape
            </asp:ListItem>
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
        <label>Database Name:</label></td>
    <td class="style1">
            <asp:DropDownList ID="dbDropDownList" runat="server">
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
        Database
        <label>Receive Date:</label></td>
    <td class="style1">
            <asp:TextBox ID="receive_DateTextBox" runat="server"></asp:TextBox>
        </td>
    <td> <asp:ImageButton ID="imgPopup" ImageUrl="image/calendar.png" ImageAlign="Bottom"
        runat="server" />
        <cc1:CalendarExtender ID="WorkOrder_DateCalendar" PopupButtonID="imgPopup" runat="server" TargetControlID="receive_DateTextBox"
        Format="yyyy-MM-dd">
    </cc1:CalendarExtender></td>
    <td >
        <asp:Label ID="Label1" runat="server" ForeColor="Red" Text="yyyy-MM-dd"></asp:Label>
            </td>
   
    <td>
        &nbsp;</td>
         <td>&nbsp;</td><td>
        &nbsp;</td>
    </tr>  
    <tr>
    <td >
        Custodian<label>:</label></td>
    <td class="style1">
            <asp:DropDownList ID="CustodianDropDownList" runat="server">
            <asp:ListItem>IT</asp:ListItem>
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
    <%-- <tr>
    <td >
        <label>Receive Date:</label></td>
    <td class="style1">
            <asp:TextBox ID="Receive_DateTextBox" runat="server"></asp:TextBox>
        </td>
    <td> 
        <asp:ImageButton ID="imgPopup0" ImageUrl="image/calendar.png" ImageAlign="Bottom"
        runat="server" />
         <cc1:CalendarExtender ID="CalendarExtender1" PopupButtonID="imgPopup0" runat="server" TargetControlID="Receive_DateTextBox"
        Format="yyyy-MM-dd"></cc1:CalendarExtender>
        </td>
    <td >
        <asp:Label ID="Label2" runat="server" ForeColor="Red" Text="yyyy-MM-dd"></asp:Label>
            </td>
   
    <td>
        &nbsp;</td>
         <td>&nbsp;</td><td>
        &nbsp;</td>
    </tr> --%>
        <tr>
    <td >
        <label>Backup By:</label></td>
    <td class="style1">
            <asp:DropDownList ID="backupByDropDownList" runat="server">
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
        <label>Checked By:</label></td>
    <td class="style1">
            <asp:DropDownList ID="checkedByDropDownList" runat="server">
            </asp:DropDownList>
        </td>
    <td> 
        &nbsp;</td>
    <td >
        &nbsp;</td>
   
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
                    AutoGenerateColumns="false" DataKeyNames="Back_SlNo"
                    OnPageIndexChanging="GridView1_PageIndexChanging"  Width="500px"
                                    
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

