<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="studentdetails.aspx.cs" Inherits="LMS.studentdetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <table width="100%">
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
        <div>
        </div>
    </form>
</body>
</html>
