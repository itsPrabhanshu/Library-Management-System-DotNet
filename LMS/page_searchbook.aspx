<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="page_searchbook.aspx.cs" Inherits="LMS.page_searchbook" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table width="100%">
    <tr>
        <td>Enter Book Id</td>
        <td>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>
            <asp:Button ID="Button1" runat="server" Text="Search" OnClick="Button1_Click" />
        </td>
    </tr>
    <tr>
        <td>Book Id</td>
        <td>
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>&nbsp;Book Name</td>
        <td>
            <asp:Label ID="Label2" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>&nbsp;Author</td>
        <td>
            <asp:Label ID="Label3" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>&nbsp;Subject</td>
        <td>
            <asp:Label ID="Label4" runat="server"></asp:Label>
        </td>
    </tr>
   
</table>
</asp:Content>
