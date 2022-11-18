<%@ Page Title="" Language="C#" MasterPageFile="~/User/UserPage.Master" AutoEventWireup="true" CodeBehind="QueryPage.aspx.cs" Inherits="ComplaintBox.User.QueryPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <u><h2 align="center">Query Portal</h2></u>
    <table align="center">
        <tr>
            <td>Product Name :</td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>Query here :</td>
            <td>
                <textarea id="TextArea1" name="TextArea1" cols="20" rows="2"></textarea>
            </td>
        </tr>
        <tr>
            <td colspan="2" align="center">
                <asp:Button ID="Button1" runat="server" Text="Register Query" OnClick="Button1_Click" /></td>
        </tr>
    </table>
</asp:Content>
