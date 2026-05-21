<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="page_sveiw.aspx.cs" Inherits="LMS.page_sveiw" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
            <table width="100%">
   
    <tr>
        <td>Student Id</td>
        <td>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>Student Name</td>
        <td>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>Father Name</td>
        <td>
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>Gender</td>
        <td>
            <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>Mob.No.</td>
        <td>
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>Degree</td>
        <td>
            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>Branch</td>
        <td>
            <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
        </td>
    </tr>
   

    <tr>
        <td class="auto-style1">
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Update" />
        </td>
        <td class="auto-style1">
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Delete" />
        </td>
    </tr>
   

</table>
        <div>
        </div>
    </form>
</body>
</html>
