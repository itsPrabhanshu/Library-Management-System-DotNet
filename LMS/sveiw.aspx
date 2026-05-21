<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="sveiw.aspx.cs" Inherits="LMS.sveiw" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 29px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
                <table width="100%">
   
    <tr>
        <td class="auto-style1">Student Id</td>
        <td class="auto-style1" colspan="2">
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style1">Student Name</td>
        <td colspan="2" class="auto-style1">
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>Father Name</td>
        <td colspan="2">
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>Gender</td>
        <td colspan="2">
            <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>Mob.No.</td>
        <td colspan="2">
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>Degree</td>
        <td colspan="2">
            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>Branch</td>
        <td colspan="2">
            <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
        </td>
    </tr>
   

    <tr>
        <td class="auto-style1">
            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/images/back.png" OnClick="ImageButton1_Click" Width="30px" />
        </td>
        <td class="auto-style1">
            &nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Update" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Delete" />
        </td>
        <td class="auto-style1">
            &nbsp;</td>
    </tr>
   

    <tr>
        <td class="auto-style1">
            &nbsp;</td>
        <td class="auto-style1">
            &nbsp;</td>
        <td class="auto-style1">
            &nbsp;</td>
    </tr>
   

</table>
</asp:Content>
