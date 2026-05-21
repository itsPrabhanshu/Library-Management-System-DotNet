<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="page_statusupdate.aspx.cs" Inherits="LMS.page_statusupdate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
        <tr>
            <td colspan="3">Request Id</td>
            <td>
                <asp:Label ID="Label1" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="3">Student Id</td>
            <td>
                <asp:Label ID="Label2" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="3">BookName</td>
            <td>
                <asp:Label ID="Label3" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="3">Author</td>
            <td>
                <asp:Label ID="Label4" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="3">Subject</td>
            <td>
                <asp:Label ID="Label5" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="3">Date Of Request</td>
            <td>
                <asp:Label ID="Label6" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="3">Status</td>
            <td>
                <asp:Label ID="Label7" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Accept" />
            </td>
            <td style="margin-left: 120px">
                <asp:Button ID="Button2" runat="server" Text="Reject" />
            </td>
            <td>
                <asp:Button ID="Button3" runat="server" Text="Order" />
            </td>
            <td>
                <asp:Button ID="Button4" runat="server" Text="Available" />
            </td>
        </tr>
    </table>
</asp:Content>
