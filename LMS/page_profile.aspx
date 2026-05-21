<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="page_profile.aspx.cs" Inherits="LMS.page_profile" %>
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
            <td>Student Id </td>
            <td>
                <asp:Label ID="Label1" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Student Name</td>
            <td>
                <asp:Label ID="Label2" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Father Name</td>
            <td>
                <asp:Label ID="Label3" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Gender</td>
            <td>
                <asp:Label ID="Label4" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Mob.No.</td>
            <td>
                <asp:Label ID="Label5" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Degree</td>
            <td>
                <asp:Label ID="Label6" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Branch</td>
            <td>
                <asp:Label ID="Label7" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
