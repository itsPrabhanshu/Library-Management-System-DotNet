<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="page_editstudent.aspx.cs" Inherits="LMS.page_editstudent" %>
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
         <td>Enter Student Id</td>
         <td>
             <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
         </td>
     </tr>
    
     <tr>
         <td>&nbsp;</td>
         <td>
             <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Search" />
         </td>
     </tr>
    
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
</asp:Content>
