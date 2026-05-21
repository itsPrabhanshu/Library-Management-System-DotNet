<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="page_submit.aspx.cs" Inherits="LMS.page_submit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <table width="100%">
          <tr>
     <td>BookId</td>
     <td>
         <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
     </td>
              
 </tr>
         <tr>
                          <td> </td>
              <td>
    <asp:Button ID="Button1" runat="server" Text="Search" OnClick="Button1_Click" />
</td>
         </tr>
     <tr>
         <td>BookId</td>
         <td>
             <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click"></asp:LinkButton>
         </td>
     </tr>
     <tr>
         <td class="auto-style2">StudentId</td>
         <td class="auto-style2">
             <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click"></asp:LinkButton>
         </td>
     </tr>
     <tr>
         <td>Date Of Issue</td>
         <td>
             <asp:Label ID="Label3" runat="server"></asp:Label>
         </td>
     </tr>
     <tr>
         <td>Date Of Submission</td>
         <td>
             <asp:Label ID="Label4" runat="server"></asp:Label>
         </td>
     </tr>
    
     <tr>
         <td>&nbsp;</td>
         <td>
             <asp:Button ID="Button2" runat="server" Text="Submit" OnClick="Button2_Click" />
         </td>
     </tr>
    
 </table>
</asp:Content>
