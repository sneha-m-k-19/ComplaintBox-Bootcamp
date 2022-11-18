<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="ComplaintView.aspx.cs" Inherits="ComplaintBox.Admin.ComplaintView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <u><h2 align="center" >Users Complaint List</h2></u>
    <u><h4  align="center">All Complaints</h4></u>
    <table align="center">
                <tr>
                    <td>&nbsp</td>
                    <td>&nbsp</td>
                </tr>
                <tr>
                    <td>
                        <asp:GridView ID="GridView2" runat="server"  AutoGenerateColumns="False" DataKeyNames="C_Id"  >
                            <Columns>
            
                                <asp:BoundField DataField="C_Id" HeaderText="Complaint ID" />
                                <asp:BoundField DataField="UserName" HeaderText="User Name" />  
                                <asp:BoundField DataField="Product_Id" HeaderText="Product_Id" />
                                <asp:BoundField DataField="Complaint" HeaderText="Complaint" />
                                <asp:BoundField DataField="C_Date" DataFormatString="{0:dd/MM/yyyy}" HeaderText="Complaint Date" />
                                <asp:BoundField DataField="status" HeaderText="Status" />                               
                            </Columns>
                        </asp:GridView>
                    </td>
                </tr>
        </table>
    <br /><br />
    <table align="center">
        <tr>
            <th>&nbsp From :&nbsp</th>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" TextMode="Date"></asp:TextBox>
            </td>
            <th>&nbsp To :&nbsp</th>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" TextMode="Date"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>&nbsp</td>
            <td>&nbsp</td>
        </tr>
    </table>
    <div align="center" >
        <asp:Button ID="Button1" runat="server" Text="View Pending" OnClick="Button1_Click"  />&nbsp&nbsp&nbsp&nbsp<asp:Button ID="Button2" runat="server" Text="View In Progress" OnClick="Button2_Click"/></div>
    <table align="center">
                <tr>
                    <td>&nbsp</td>
                    <td>&nbsp</td>
                </tr>
                <tr>
                    <td>
                        <asp:GridView ID="GridView1" runat="server"  AutoGenerateColumns="False" DataKeyNames="C_Id" OnRowDeleting="GridView1_RowDeleting" >
                            <Columns>
            
                                <asp:BoundField DataField="C_Id" HeaderText="Complaint ID" />
                                <asp:BoundField DataField="UserName" HeaderText="User Name" />  
                                <asp:BoundField DataField="Product_Id" HeaderText="Product_Id" />
                                <asp:BoundField DataField="Complaint" HeaderText="Complaint" />
                                <asp:BoundField DataField="C_Date" DataFormatString="{0:dd/MM/yyyy}" HeaderText="Complaint Date" />
                                <asp:CommandField HeaderText="Status" ShowDeleteButton="true" DeleteText="View Complaint" />
                            </Columns>
                        </asp:GridView>
                    </td>
                </tr>
        </table>
        <table align="center">
                <tr>
                    <td>&nbsp</td>
                    <td>&nbsp</td>
                </tr>
                <tr>
                    <td>
                        <asp:GridView ID="GridView3" runat="server"  AutoGenerateColumns="False" DataKeyNames="C_Id" OnRowDeleting="GridView3_RowDeleting" >
                            <Columns>
            
                                <asp:BoundField DataField="C_Id" HeaderText="Complaint ID" />
                                <asp:BoundField DataField="UserName" HeaderText="User Name" />  
                                <asp:BoundField DataField="Product_Id" HeaderText="Product_Id" />
                                <asp:BoundField DataField="Complaint" HeaderText="Complaint" />
                                <asp:BoundField DataField="C_Date" DataFormatString="{0:dd/MM/yyyy}" HeaderText="Complaint Date" />
                                <asp:CommandField HeaderText="Status" ShowDeleteButton="true" DeleteText="Closed" />
                            </Columns>
                        </asp:GridView>
                    </td>
                </tr>
        </table>
        
     
</asp:Content>
