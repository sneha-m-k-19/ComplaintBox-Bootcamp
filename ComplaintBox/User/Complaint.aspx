<%@ Page Title="" Language="C#" MasterPageFile="~/User/UserPage.Master" AutoEventWireup="true" CodeBehind="Complaint.aspx.cs" Inherits="ComplaintBox.User.Complaint" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <u><h2 align="center">Complaint Portal</h2></u>
    <table align="center">
                <tr>
                    <td>&nbsp</td>
                    <td>&nbsp</td>
                </tr>
                <tr>
                    <td>
                        <asp:GridView ID="GridView1" runat="server"  AutoGenerateColumns="False" DataKeyNames="Product_Id"  >
                            <Columns>
            
                                <asp:BoundField DataField="Product_Id" HeaderText="Product Id" />
                                <asp:BoundField DataField="Product_Name" HeaderText="Product Name" />  
                                <asp:BoundField DataField="Price" HeaderText="Product Price" />
                            </Columns>
                        </asp:GridView>
                    </td>
                </tr>
        </table>
        <div>
            <h2 align="center">Register Your Complaints Here</h2>
            <table align="center">
                <tr>
                    <td>Product Name</td>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server" ></asp:DropDownList>
                        

                    </td>
                  </tr>
                  <tr>
                      <td>Complaint Box :</td>
                      <td>
                          <textarea id="TextArea1" name="TextArea1" cols="20" rows="3"></textarea>
                      </td>
                  </tr>
                <tr>
                    <td colspan="2" align="center">
                        <asp:Button ID="Button1" runat="server" Text="Register Here" OnClick="Button1_Click" />
                    </td>
                </tr>
            </table>
        </div>
</asp:Content>
