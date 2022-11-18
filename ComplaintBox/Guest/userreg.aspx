<%@ Page Title="" Language="C#" MasterPageFile="~/Guest/GuestMaster.Master" AutoEventWireup="true" CodeBehind="userreg.aspx.cs" Inherits="ComplaintBox.User.userreg" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <u><h1 align="center" style="color:white">User Registration</h1></u><br />
    <table align="center" style="background-color:burlywood" width="400">
        <tr>
           <th align="left">Name :</th>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
           <th align="left">Email :</th>
            <td>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
           <th align="left">Phone Number :</th>
            <td>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
        </tr>
         <tr>
           <th align="left">PassWord :</th>
            <td>
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
           <td colspan="2" align="center">
               <asp:Button ID="Button1" runat="server" Text="Register" OnClick="Button1_Click" /></td>
            
        </tr>
    </table>
</asp:Content>
