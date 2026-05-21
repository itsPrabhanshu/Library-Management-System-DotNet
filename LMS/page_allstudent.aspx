<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="page_allstudent.aspx.cs" Inherits="LMS.page_allstudent" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
    <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AutoGenerateColumns="False">
       <Columns>
           <asp:TemplateField HeaderText="Student Id" >

                   <ItemTemplate >
                         <%#Eval("sid") %>
                   </ItemTemplate>
           </asp:TemplateField>
             <asp:TemplateField HeaderText="Student Name" >
          <ItemTemplate >
                <%#Eval("sname") %>
          </ItemTemplate>
  </asp:TemplateField>
           <asp:TemplateField HeaderText="Degree" >
                   <ItemTemplate >
                         <%#Eval("degree") %>
                   </ItemTemplate>
           </asp:TemplateField>
         
           
           <asp:TemplateField HeaderText="Veiw" >
                   <ItemTemplate >
                       <asp:LinkButton ID="LinkButton1" runat="server" Text="Veiw" CommandName='<%#Eval("sid") %>' OnCommand="LinkButton1_Command"></asp:LinkButton>
                   </ItemTemplate>
           </asp:TemplateField>
           
       </Columns>    
    </asp:GridView>
       
        </center>
</asp:Content>
