<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="page_editbook.aspx.cs" Inherits="LMS.page_editbook" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 26px;
        }
    </style>
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
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>&nbsp;Book Name</td>
        <td>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>&nbsp;Author</td>
        <td>
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style1">&nbsp;Subject</td>
        <td class="auto-style1">
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        </td>
    </tr>
   
    <tr>
        <td class="auto-style1">
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Update" />
        </td>
        <td class="auto-style1">
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Delete" />
        </td>
    </tr>
   
</table>
</asp:Content>
