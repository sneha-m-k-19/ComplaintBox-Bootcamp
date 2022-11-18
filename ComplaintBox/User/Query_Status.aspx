<%@ Page Title="" Language="C#" MasterPageFile="~/User/UserPage.Master" AutoEventWireup="true" CodeBehind="Query_Status.aspx.cs" Inherits="ComplaintBox.User.Query_Status" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <u><h2 align="center" style="color:orangered">Your Query List</h2></u>
    <table align="center">
                <tr>
                    <td>&nbsp</td>
                    <td>&nbsp</td>
                </tr>
                <tr>
                    <td>
                        <asp:GridView ID="GridView3" runat="server"  AutoGenerateColumns="False" >
                            <Columns>
            
                                <asp:BoundField DataField="Query_Id" HeaderText="Query Id" />                 
                                <asp:BoundField DataField="Product_Id" HeaderText="Product_Id" />
                                <asp:BoundField DataField="Query" HeaderText="Query" />
                                <asp:BoundField DataField="Reply" HeaderText="Reply" /> 
                            </Columns>
                        </asp:GridView>
                    </td>
                </tr>
        </table>
</asp:Content>
