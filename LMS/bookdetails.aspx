<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="bookdetails.aspx.cs" Inherits="LMS.bookdetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
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
        <div>
        </div>
    </form>
</body>
</html>
