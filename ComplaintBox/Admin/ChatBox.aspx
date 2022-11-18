<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="ChatBox.aspx.cs" Inherits="ComplaintBox.Admin.ChatBox" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2 align="center" style="color:orangered">Users Query List</h2>
    <table align="center">
                <tr>
                    <td>&nbsp</td>
                    <td>&nbsp</td>
                </tr>
                <tr>
                    <td>
                        <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" DataKeyNames="Query_Id">
                            <Columns>
            
                                <asp:BoundField DataField="Query_Id" HeaderText="Query Id" />                 
                                <asp:BoundField DataField="UserName" HeaderText="UserName" />
                                <asp:BoundField DataField="Product_Id" HeaderText="Product_Id" />
                                <asp:BoundField DataField="Query" HeaderText="Query" />
                                <asp:HyperLinkField DataNavigateUrlFields="Query_Id" DataNavigateUrlFormatString="Query_Reply.aspx?Query_Id={0}" HeaderText="Reply" Text="Reply" />
                               
                            </Columns>
                        </asp:GridView>
                    </td>
                </tr>
        </table>
</asp:Content>
