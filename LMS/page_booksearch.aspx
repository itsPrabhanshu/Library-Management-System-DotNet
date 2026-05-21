<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="page_booksearch.aspx.cs" Inherits="LMS.page_booksearch" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 26px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
        <tr>
            <td>BookId</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Search" />
            </td>
        </tr>
        <tr>
            <td class="auto-style2">BookId</td>
            <td class="auto-style2">
                <asp:Label ID="Label1" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>BookName</td>
            <td>
                <asp:Label ID="Label2" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Author</td>
            <td>
                <asp:Label ID="Label3" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Subject</td>
            <td>
                <asp:Label ID="Label4" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
