<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="NetworkDevice.aspx.cs" Inherits="NetworkDevice" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
    <style type="text/css">
        .menu
        {
            height: 26px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
 <cc1:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </cc1:ToolkitScriptManager>
    <table width="auto" align="center">
    <tr>
    <td>
    <fieldset>
    <legend>Network Device</legend>
    <table>
     <tr>
    <td >
        <label>NetD_Type:</label></td>
    <td class="style1">
            <asp:DropDownList ID="NetD_TypeDropDownList" runat="server">
            <asp:ListItem>Router</asp:ListItem>
            <asp:ListItem>Switch</asp:ListItem>
            <asp:ListItem>firewall</asp:ListItem>
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
    <td >&nbsp;Brand Name<label>:</label></td>
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
     <tr>
    <td >Serial No.<label>:</label></td>
    <td class="style1">
        <asp:TextBox ID="serialNoTextBox" runat="server"></asp:TextBox>
        
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
        <label>Model:</label></td>
    <td class="style1">
            <asp:TextBox ID="modelTextBox" runat="server"></asp:TextBox>
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
        <label>Host Name:</label></td>
    <td class="style1">
            <asp:TextBox ID="hostNameTextBox" runat="server"></asp:TextBox>
        </td>
    <td> 
        </td>
    <td ></td>
   
    <td>
        &nbsp;</td>
         <td>&nbsp;</td><td>
        &nbsp;</td>
    </tr>
    <tr >
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
        Criticality<label>:</label></td>
    <td class="style1">
            <asp:TextBox ID="CriticalityTextBox" runat="server"></asp:TextBox>
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
        Location<label>:</label></td>
    <td class="style1">
            <asp:TextBox ID="LocationTextBox" runat="server"></asp:TextBox>
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
        RackNo<label>:</label></td>
    <td class="style1">
            <asp:TextBox ID="RackNoTextBox" runat="server"></asp:TextBox>
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
   
    Receive Person<label>:</label>
  
         </td>
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
     <tr >
    <td >
        Challan No<label>:</label></td>
    <td class="style1">
            <asp:TextBox ID="challanNoTextBox" runat="server"></asp:TextBox>
        </td>
    <td> 
        </td>
    <td ></td>
   
    <td>
        &nbsp;</td>
         <td>&nbsp;</td><td>
        &nbsp;</td>
    </tr> 
     <tr >
    <td >
        Challan<label> Date:</label></td>
    <td class="style1">
            <asp:TextBox ID="challanDateTextBox" runat="server"></asp:TextBox>
        </td>
    <td> 
         <asp:ImageButton ID="ImageButton1" ImageUrl="image/calendar.png" ImageAlign="Bottom"
        runat="server" />
         <cc1:CalendarExtender ID="CalendarExtender4" PopupButtonID="ImageButton1" runat="server" TargetControlID="challanDateTextBox"
        Format="yyyy-MM-dd"></cc1:CalendarExtender>
        </td>
    <td >
        <asp:Label ID="Label5" runat="server" ForeColor="Red" Text="yyyy-MM-dd"></asp:Label>
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
        <label>AMC Start Date:</label></td>
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
        AMC End
        <label>Date:</label></td>
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
        Bill Date:</td>
    <td class="style1">
            <asp:TextBox ID="billDateTextBox" runat="server"></asp:TextBox>
        </td>
   <td> 
        <asp:ImageButton ID="ImageButton2" ImageUrl="image/calendar.png" ImageAlign="Bottom"
        runat="server" />
        <cc1:CalendarExtender ID="CalendarExtender5" PopupButtonID="ImageButton2" runat="server" TargetControlID="billDateTextBox"
        Format="yyyy-MM-dd"></cc1:CalendarExtender>
        </td>
    <td >
        <asp:Label ID="Label6" runat="server" ForeColor="Red" Text="yyyy-MM-dd"></asp:Label>
            </td>
   
   
    <td>
        &nbsp;</td>
         <td>&nbsp;</td><td>
        &nbsp;</td>
    </tr>
      <tr>
    <td >
        <label>Warranty:</label></td>
    <td class="style1">
        <asp:DropDownList ID="Ser_WaranteePeriodDropDownList" runat="server">
        <asp:ListItem>1 year</asp:ListItem>
          <asp:ListItem>2 year</asp:ListItem>
            <asp:ListItem>3 year</asp:ListItem>
              <asp:ListItem>4 year</asp:ListItem>
                <asp:ListItem>5 year</asp:ListItem>
                  <asp:ListItem>6 year</asp:ListItem>
                    <asp:ListItem>7 year</asp:ListItem>
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
            ValidationGroup="s" onclick="addButton_Click"  />
            </td>
            <td>
                &nbsp;</td>
        </tr>

        
    </table>
     <table ><tr><td >
       
             <asp:GridView ID="GridView1" runat="server" AllowPaging="true" 
                    AutoGenerateColumns="false" DataKeyNames="NetD_slNo"
                     Width="500px"
                                    
                    PageSize="25" onpageindexchanging="GridView1_PageIndexChanging" 
                >
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
   
                        <asp:TemplateField Visible="false">
                            <EditItemTemplate>
                                <asp:TextBox ID="idTextBox" runat="server" Text='<%#Eval("NetD_slNo") %>' 
                                    Visible="false"></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="idLabel" runat="server" Text='<%#Eval("NetD_slNo") %>'></asp:Label>
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
                         <asp:TemplateField HeaderText="Serial No">
                         
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

