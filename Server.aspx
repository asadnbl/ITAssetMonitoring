<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Server.aspx.cs" Inherits="Server" %>
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
    <legend>Server</legend>
    <table>
     <tr>
     <td ></td>
     <td colspan="4">
         &nbsp;</td>
     </tr>
    <tr>
    <td >Server Name<label>:</label></td>
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
    <td >Manufacturer Name<label>:</label></td>
    <td class="style1">
        <asp:TextBox ID="manufactureTextBox" runat="server"></asp:TextBox>
        
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
    <td >Model<label>:</label></td>
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
    <td >Serial Number<label>:</label></td>
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
    <td >IP<label>:</label></td>
    <td class="style1" colspan="3">
            <%--<asp:TextBox ID="Ser_IPTextBox" runat="server"></asp:TextBox>--%>
        
        
   
                


            <asp:DropDownList ID="Ser_IPTextBox" runat="server">
            </asp:DropDownList>
        
        
   
                


            <asp:Button ID="okButton" runat="server" Text="Add" onclick="okButton_Click" />
        
        
   
                


            <asp:TextBox ID="ipTextBox" Visible="false" runat="server" AutoPostBack="true" 
                ontextchanged="ipTextBox_TextChanged"></asp:TextBox>
        
        
   
                


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
        <label>Operating System:</label></td>
    <td class="style1">
        <asp:DropDownList ID="Ser_Sof_DropDownList" runat="server">
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
        <label>Storage:</label></td>
    <td class="style1">
            <asp:TextBox ID="Ser_StorageTextBox" runat="server"></asp:TextBox>
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
        <label>Application Running:</label></td>
    <td class="style1">
            <asp:TextBox ID="applicationTextBox" runat="server"></asp:TextBox>
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
        <label>Criticality:</label></td>
    <td class="style1">
            <asp:TextBox ID="Ser_CriticalityTextBox" runat="server"></asp:TextBox>
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
        <label>Location:</label></td>
    <td class="style1">
            <asp:TextBox ID="Ser_LocationTextBox" runat="server"></asp:TextBox>
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
        <label>RackNo:</label></td>
    <td class="style1">
            <asp:TextBox ID="Ser_RackNoTextBox" runat="server"></asp:TextBox>
        </td>
    <td> 
        </td>
    <td ></td>
   
    <td>
        &nbsp;</td>
         <td>&nbsp;</td><td>
        &nbsp;</td>
    </tr>  
<%--         <tr>
    <td >
        <label>WaranteePeriod:</label></td>
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
    </tr> --%> 
            <tr>
    <td >
        <label>Warranty Strat Date:</label></td>
    <td class="style1">
            <asp:TextBox ID="warrantyStartDateTextBox" runat="server"></asp:TextBox>
        </td>
    <td> <asp:ImageButton ID="ImageButton1" ImageUrl="image/calendar.png" ImageAlign="Bottom"
        runat="server" />
        <cc1:CalendarExtender ID="CalendarExtender4" PopupButtonID="ImageButton1" runat="server" TargetControlID="warrantyStartDateTextBox"
        Format="yyyy-MM-dd">
    </cc1:CalendarExtender></td>
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
        <label>Warranty Expired Date:</label></td>
    <td class="style1">
            <asp:TextBox ID="warrantyExpiredDateTextBox" runat="server"></asp:TextBox>
        </td>
    <td> <asp:ImageButton ID="ImageButton2" ImageUrl="image/calendar.png" ImageAlign="Bottom"
        runat="server" />
        <cc1:CalendarExtender ID="CalendarExtender5" PopupButtonID="ImageButton2" runat="server" TargetControlID="warrantyExpiredDateTextBox"
        Format="yyyy-MM-dd">
    </cc1:CalendarExtender></td>
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
        <label>Warranty Status:</label></td>
    <td class="style1">
        <asp:DropDownList ID="Ser_WaranteePeriodDropDownList" runat="server">
        <asp:ListItem>Yes</asp:ListItem>
          <asp:ListItem>No</asp:ListItem>
            <asp:ListItem>Expired</asp:ListItem>
              
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
        <label>AMC Expired Date:</label></td>
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
        <label>challan No:</label></td>
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
        
     <tr>
    <td >Receive &amp; Installation<br />
        commissioning Person<label></td>
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

    <tr>
    <td >
        <label>Network Port Name:</label></td>
    <td class="style1">
            <asp:TextBox ID="networkPortNameTextBox" runat="server"></asp:TextBox>
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
        <label>Port Open:</label></td>
    <td class="style1">
            <asp:TextBox ID="PortOpenTextBox" runat="server"></asp:TextBox>
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
        <label>Patch Pannel No:</label></td>
    <td class="style1">
            <asp:TextBox ID="patchPanelNoTextBox" runat="server"></asp:TextBox>
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
                    AutoGenerateColumns="false" DataKeyNames="Ser_slNo"
                     Width="500px"
                                    
                    PageSize="25" onpageindexchanging="GridView1_PageIndexChanging" 
                >
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
   
                        <asp:TemplateField Visible="false">
                            <EditItemTemplate>
                                <asp:TextBox ID="idTextBox" runat="server" Text='<%#Eval("Ser_slNo") %>' 
                                    Visible="false"></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="idLabel" runat="server" Text='<%#Eval("Ser_slNo") %>'></asp:Label>
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

