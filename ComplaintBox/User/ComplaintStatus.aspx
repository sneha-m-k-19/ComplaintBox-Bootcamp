<%@ Page Title="" Language="C#" MasterPageFile="~/User/UserPage.Master" AutoEventWireup="true" CodeBehind="ComplaintStatus.aspx.cs" Inherits="ComplaintBox.User.ComplaintStatus" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <u><h2 align="center" style="color:orangered">Your complaint List</h2></u>
    <table align="center">
                <tr>
                    <td>&nbsp</td>
                    <td>&nbsp</td>
                </tr>
                <tr>
                    <td>
                        <asp:GridView ID="GridView3" runat="server"  AutoGenerateColumns="False" DataKeyNames="C_Id"  >
                            <Columns>
            
                                <asp:BoundField DataField="C_Id" HeaderText="Complaint ID" />                 
                                <asp:BoundField DataField="Product_Id" HeaderText="Product_Id" />
                                <asp:BoundField DataField="Complaint" HeaderText="Complaint" />
                                <asp:BoundField DataField="C_Date" DataFormatString="{0:dd/MM/yyyy}" HeaderText="Complaint Date" />
                                <asp:BoundField DataField="status" HeaderText="Status" /> 
                            </Columns>
                        </asp:GridView>
                    </td>
                </tr>
        </table>
</asp:Content>
