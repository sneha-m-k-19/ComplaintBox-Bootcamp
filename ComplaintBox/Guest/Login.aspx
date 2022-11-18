<%@ Page Title="" Language="C#" MasterPageFile="~/Guest/GuestMaster.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ComplaintBox.Guest.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
    <h1 align="center" style="color:white">Login Page</h1>
    <table align="center" style="background-color:burlywood" width="400" heigth="400">
        <tr>
            <td>
                <b><asp:Label ID="Label1" runat="server" Text="User Name :"></asp:Label></b>
                
            </td>
            <td>
                <asp:TextBox ID="TextName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr></tr>
        <tr>
            <td>
                <b><asp:Label ID="Label2" runat="server" Text="Password :"></asp:Label></b>
                
            </td>
            <td>
                <asp:TextBox ID="TextPassword" runat="server" Visible="True" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr></tr>
        <tr>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Cancel" />
            </td>
            <td>
                <asp:Button ID="Button2" runat="server" Text="Login" OnClick="Button2_Click" />
            </td>
        </tr>
    </table>


</asp:Content>
