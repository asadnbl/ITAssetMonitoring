<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="DB.aspx.cs" Inherits="DB" %>
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
    <legend>&nbsp;DB</legend>
    <table>
     <tr>
     <td ></td>
     <td colspan="4">
         &nbsp;</td>
     </tr>
    <tr>
    <td >Database Name<label>:</label></td>
    <td class="style1">
        <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
        
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
    <td >Version<label>:</label></td>
    <td class="style1">
            <asp:TextBox ID="versionTextBox" runat="server"></asp:TextBox>
        
        
   
                


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
    <td >Vendor<label>:</label></td>
    <td class="style1">
            <asp:DropDownList ID="vendorDropDownList" runat="server">
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
        <label>WorkOrder Date:</label></td>
    <td class="style1">
            <asp:TextBox ID="WorkOrder_DateTextBox" runat="server"></asp:TextBox>
        </td>
    <td> <asp:ImageButton ID="imgPopup" ImageUrl="image/calendar.png" ImageAlign="Bottom"
        runat="server" />
        <cc1:CalendarExtender ID="WorkOrder_DateCalendar" PopupButtonID="imgPopup" runat="server" TargetControlID="WorkOrder_DateTextBox"
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
        <label>WorkOrder No:</label></td>
    <td class="style1">
            <asp:TextBox ID="WorOrder_NoTextBox" runat="server"></asp:TextBox>
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
    </tr> 
        <tr>
    <td >
        <label>Under AMC:</label></td>
    <td class="style1">
        <asp:CheckBox ID="underAMCCheckBox" runat="server" />
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
        <label>Last_Renew_Date:</label></td>
    <td class="style1">
            <asp:TextBox ID="Last_Renew_DateTextBox" runat="server"></asp:TextBox>
        </td>
    <td> 
        <asp:ImageButton ID="imgPopup1" ImageUrl="image/calendar.png" ImageAlign="Bottom"
        runat="server" />
        <cc1:CalendarExtender ID="CalendarExtender2" PopupButtonID="imgPopup1" runat="server" TargetControlID="Last_Renew_DateTextBox"
        Format="yyyy-MM-dd"></cc1:CalendarExtender>
        </td>
    <td >
        <asp:Label ID="Label3" runat="server" ForeColor="Red" Text="yyyy-MM-dd"></asp:Label>
            </td>
   
    <td>
        &nbsp;</td>
         <td>&nbsp;</td><td>
        &nbsp;</td>
    </tr> 
     <tr>
    <td >
        <label>Next_Renew_Date:</label></td>
    <td class="style1">
            <asp:TextBox ID="Next_Renew_DateTextBox" runat="server"></asp:TextBox>
        </td>
    <td> 
        <asp:ImageButton ID="imgPopup2" ImageUrl="image/calendar.png" ImageAlign="Bottom"
        runat="server" />
        <cc1:CalendarExtender ID="CalendarExtender3" PopupButtonID="imgPopup2" runat="server" TargetControlID="Next_Renew_DateTextBox"
        Format="yyyy-MM-dd"></cc1:CalendarExtender>
        </td>
    <td >
        <asp:Label ID="Label4" runat="server" ForeColor="Red" Text="yyyy-MM-dd"></asp:Label>
            </td>
   
    <td>
        &nbsp;</td>
         <td>&nbsp;</td><td>
         &nbsp;</td>
    </tr> 
      <tr>
    <td >
        <label>Remarks:</label></td>
    <td class="style1">
        <asp:TextBox ID="remarksTextBox" runat="server"></asp:TextBox>
        </td>
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
                    AutoGenerateColumns="false" DataKeyNames="DB_slNo"
                    OnPageIndexChanging="GridView1_PageIndexChanging"  Width="500px"
                                    
                    PageSize="5" 
                >
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
   
                        <asp:TemplateField Visible="false">
                            <EditItemTemplate>
                                <asp:TextBox ID="idTextBox" runat="server" Text='<%#Eval("DB_slNo") %>' 
                                    Visible="false"></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="idLabel" runat="server" Text='<%#Eval("DB_slNo") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="DB_Name">
                           
                            <ItemTemplate>
                                <asp:Label ID="DB_NameLabel" runat="server" Text='<%#Eval("DB_Name") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="DB_Version">
                         
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


