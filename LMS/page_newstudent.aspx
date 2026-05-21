<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="page_newstudent.aspx.cs" Inherits="LMS.page_newstudent" %>
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
            <td>Student Id</td>
            <td>
                <asp:Label ID="Label1" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Student Name</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Fathers Name</td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Gender</td>
            <td>
                <asp:RadioButton ID="RadioButton1" runat="server" GroupName="g1" Text="Male" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:RadioButton ID="RadioButton2" runat="server" GroupName="g1" Text="Female" />
            </td>
        </tr>
        <tr>
            <td>Mo.No.</td>
            <td>
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Degree</td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem>B.Sc.</asp:ListItem>
                    <asp:ListItem>B.Com</asp:ListItem>
                    <asp:ListItem>B.Ca</asp:ListItem>
                    <asp:ListItem>M.Sc.</asp:ListItem>
                    <asp:ListItem>M.Com.</asp:ListItem>
                    <asp:ListItem>M.Ca.</asp:ListItem>
                    <asp:ListItem>B.Tech</asp:ListItem>
                    <asp:ListItem>M.Tech</asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>Branch</td>
            <td>
                <asp:DropDownList ID="DropDownList2" runat="server">
                    <asp:ListItem>Science</asp:ListItem>
                    <asp:ListItem>Computer</asp:ListItem>
                    <asp:ListItem>Bussiness</asp:ListItem>
                    <asp:ListItem>Finance</asp:ListItem>
                    <asp:ListItem>Agriculture</asp:ListItem>
                    <asp:ListItem>Electrical</asp:ListItem>
                    <asp:ListItem>Mechanical</asp:ListItem>
                    <asp:ListItem>Civil</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>User Id</td>
            <td>
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>User Password</td>
            <td>
                <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Register" />
            </td>
        </tr>
    </table>
</asp:Content>
