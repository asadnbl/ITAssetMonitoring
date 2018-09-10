<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Software.aspx.cs" Inherits="Software" %>

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
    <legend>Software</legend>
    <table>
     <tr>
     <td ></td>
     <td colspan="4">
         <asp:Label ID="sofSLLabel" runat="server" Visible="false"></asp:Label>
         </td>
     </tr>
    <tr>
    <td >Software Name<label>:</label></td>
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
    <td >Sof_Type<label>:</label></td>
    <td class="style1">
            <asp:DropDownList ID="Sof_TypeTextBox" runat="server">
            <asp:ListItem>Purchase</asp:ListItem>
            <asp:ListItem>Inhouse</asp:ListItem>
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
        <label>Server IP:</label></td>
    <td class="style1">
        <asp:DropDownList ID="ServerDropDownList" runat="server">
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
        <label>End User:</label></td>
    <td class="style1">
            <asp:TextBox ID="EndUserTextBox" runat="server"></asp:TextBox>
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
        Benifitiary User<label>:</label></td>
    <td class="style1">
            <asp:TextBox ID="BenifitiaryUserTextBox" runat="server"></asp:TextBox>
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
        <label>Current Version:</label></td>
    <td class="style1">
            <asp:TextBox ID="CurrentVirsionTextBox" runat="server"></asp:TextBox>
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
        <label>IsHosted:</label></td>
    <td class="style1">
        <asp:CheckBox ID="IsHostedCheckBox" runat="server" />
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
        <label>Hosted Location:</label></td>
    <td class="style1">
            <asp:TextBox ID="HostedLocationTextBox" runat="server"></asp:TextBox>
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
    <td >UAT Person<label>:</label></td>
    <td class="style1">
            <asp:DropDownList ID="employeeDropDownList" runat="server">
            </asp:DropDownList>
            <asp:Button ID="okButton" runat="server" Text="Add" onclick="okButton_Click" />
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
    <td >&nbsp;</td>
    <td class="style1">
            <asp:GridView ID="GridView2" runat="server"  AutoGenerateColumns="false" DataKeyNames="Emp_slNo">
            <Columns>
             <asp:TemplateField Visible="false">
                            <EditItemTemplate>
                                <asp:TextBox ID="idTextBox" runat="server" Text='<%#Eval("Emp_slNo") %>' 
                                    Visible="false"></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Emp_slNoLabel" runat="server" Text='<%#Eval("Emp_slNo") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Emp_Name">
                           
                            <ItemTemplate>
                                <asp:Label ID="Sof_NameLabel" runat="server" Text='<%#Eval("Emp_Name") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                       <asp:TemplateField>
        <ItemTemplate>
                <asp:LinkButton ID="LinkButton1" ForeColor="Black" runat="server" Text="Remove" onclick="LinkButton1_Click"/>
        </ItemTemplate>
      
    </asp:TemplateField>

                      
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
        <label>UAT Sign Date:</label></td>
    <td class="style1">
            <asp:TextBox ID="UATsignDateTextBox" runat="server"></asp:TextBox>
        </td>
    <td> 
        <asp:ImageButton ID="ImageButton1" ImageUrl="image/calendar.png" ImageAlign="Bottom"
        runat="server" />
        <cc1:CalendarExtender ID="CalendarExtender4" PopupButtonID="ImageButton1" runat="server" TargetControlID="UATsignDateTextBox"
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
    <td >Responsible Person<label>:</label></td>
    <td class="style1">
            <asp:DropDownList ID="resPonsibleDropDownList" runat="server">
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
    <td >FallBack&nbsp; Person<label>:</label></td>
    <td class="style1">
            <asp:DropDownList ID="fallBackDropDownList" runat="server">
            </asp:DropDownList>
            <asp:Button ID="fallbackAddButton" runat="server" Text="Add" 
                onclick="fallbackAddButton_Click"  />
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
    <td >&nbsp;</td>
    <td class="style1">
            <asp:GridView ID="GridView3" runat="server"  AutoGenerateColumns="false" DataKeyNames="Emp_slNo">
            <Columns>
             <asp:TemplateField Visible="false">
                            <EditItemTemplate>
                                <asp:TextBox ID="idTextBox" runat="server" Text='<%#Eval("Emp_slNo") %>' 
                                    Visible="false"></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Emp_slNoLabel" runat="server" Text='<%#Eval("Emp_slNo") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Emp_Name">
                           
                            <ItemTemplate>
                                <asp:Label ID="Sof_NameLabel" runat="server" Text='<%#Eval("Emp_Name") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                       <asp:TemplateField>
        <ItemTemplate>
                <asp:LinkButton ID="LinkButton2" ForeColor="Black" runat="server" Text="Remove" onclick="LinkButton2_Click"/>
        </ItemTemplate>
      
    </asp:TemplateField>

                      
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
        Network Gateway<label>:</label></td>
    <td class="style1">
            <asp:TextBox ID="NetworkGatewayTextBox" runat="server"></asp:TextBox>
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
        Sof Port<label>:</label></td>
    <td class="style1">
            <asp:TextBox ID="PortTextBox" runat="server"></asp:TextBox>
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
        ScemaName<label>:</label></td>
    <td class="style1">
            <asp:TextBox ID="ScemaNameTextBox" runat="server"></asp:TextBox>
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
        <label>BlackboxTest:</label></td>
    <td class="style1">
        <asp:CheckBox ID="BlackboxTestCheckBox" runat="server" />
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
        <label>WhiteboxTest:</label></td>
    <td class="style1">
        <asp:CheckBox ID="WhiteboxTestCheckBox" runat="server" />
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
        <label>Vernability:</label></td>
    <td class="style1">
        <asp:CheckBox ID="VernabilityCheckBox" runat="server" />
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
        <label>PenitrationTest:</label></td>
    <td class="style1">
        <asp:CheckBox ID="PenitrationTestCheckBox" runat="server" />
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
        <label>OperationalManual:</label></td>
    <td class="style1">
        <asp:CheckBox ID="OperationalManualCheckBox" runat="server" />
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
        <label>TechnicalManual:</label></td>
    <td class="style1">
        <asp:CheckBox ID="TechnicalManualCheckBox" runat="server" />
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
        <asp:Button ID="addButton" CssClass="menu" runat="server" Text="Save" Width="61px" 
            ValidationGroup="s" onclick="addButton_Click"  />
            </td>
            <td>
                &nbsp;</td>
        </tr>

        
    </table>
     <table ><tr><td >
       
             <asp:GridView ID="GridView1" runat="server" AllowPaging="true" 
                    AutoGenerateColumns="false" DataKeyNames="Sof_slNo"
                     Width="500px"
                                    
                    PageSize="25" onpageindexchanging="GridView1_PageIndexChanging" 
                >
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
   
                        <asp:TemplateField Visible="false">
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
                         <asp:TemplateField HeaderText="Responsible Person">
                         
                            <ItemTemplate>
                                <asp:Label ID="Res_NameLabel" runat="server" 
                                    Text='<%#Eval("Res_Name") %>'></asp:Label>
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


