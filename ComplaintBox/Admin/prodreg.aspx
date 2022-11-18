<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="prodreg.aspx.cs" Inherits="ComplaintBox.Admin.prodreg" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
        <div>
            <h2 align="center">
                <u>Product Registration</u>
            </h2>
            <table align="center">
                <tr>
                    <td>Product Name :</td>
                        <td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Product Price :</td>
                        <td><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                        <asp:Button ID="Button1" runat="server" Text="Add Product" OnClick="Button1_Click" /></td>
                </tr>    
                   
            </table>
        </div>
      
</asp:Content>
