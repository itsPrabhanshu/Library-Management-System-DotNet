<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="page_bookdetails2.aspx.cs" Inherits="LMS.page_bookdetails2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
                <table width="100%">
    
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
