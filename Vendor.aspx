<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Vendor.aspx.cs" Inherits="Vendor" %>

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
    <legend>&nbsp;Vendor</legend>
    <table>
     <tr>
     <td ></td>
     <td colspan="4">
         &nbsp;</td>
     </tr>
    <tr>
    <td >Vendor Name<label>:</label></td>
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
    <td >Contact Person<label>:</label></td>
    <td class="style1">
            <asp:TextBox ID="contactPersonTextBox" runat="server"></asp:TextBox>
        
        
   
                


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
    <td >Contact No<label>:</label></td>
    <td class="style1">
            <asp:TextBox ID="contactTextBox" runat="server"></asp:TextBox>
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
        Address<label>:</label></td>
    <td class="style1">
            <asp:TextBox ID="addressTextBox" runat="server" TextMode="MultiLine"></asp:TextBox>
        
        
   
                


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
        <label>Email:</label></td>
    <td class="style1">
            <asp:TextBox ID="emailTextBox" runat="server" ></asp:TextBox>
        
        
   
                


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
            ValidationGroup="s" onclick="addButton_Click" />
            </td>
            <td>
                &nbsp;</td>
        </tr>

        
    </table>
     <table ><tr><td >
       
             <asp:GridView ID="GridView1" runat="server" AllowPaging="true" 
                    AutoGenerateColumns="false" DataKeyNames="V_slNo"
                    OnPageIndexChanging="GridView1_PageIndexChanging"  Width="500px"
                                    
                    PageSize="5" 
                >
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
   
                        <asp:TemplateField Visible="false">
                            <EditItemTemplate>
                                <asp:TextBox ID="idTextBox" runat="server" Text='<%#Eval("V_slNo") %>' 
                                    Visible="false"></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="idLabel" runat="server" Text='<%#Eval("V_slNo") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="V_Name">
                           
                            <ItemTemplate>
                                <asp:Label ID="V_NameLabel" runat="server" Text='<%#Eval("V_Name") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="V_ContactPerson">
                         
                            <ItemTemplate>
                                <asp:Label ID="V_ContactPersonLabel" runat="server" 
                                    Text='<%#Eval("V_ContactPerson") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="V_ContactNo">
                         
                            <ItemTemplate>
                                <asp:Label ID="V_ContactNoLabel" runat="server" 
                                    Text='<%#Eval("V_ContactNo") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                       <asp:TemplateField HeaderText="V_Address">
                         
                            <ItemTemplate>
                                <asp:Label ID="V_AddressLabel" runat="server" 
                                    Text='<%#Eval("V_Address") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                          <asp:TemplateField HeaderText="V_Email">
                         
                            <ItemTemplate>
                                <asp:Label ID="V_EmailLabel" runat="server" 
                                    Text='<%#Eval("V_Email") %>'></asp:Label>
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

