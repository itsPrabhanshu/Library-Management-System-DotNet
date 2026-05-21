<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="page_allrequest.aspx.cs" Inherits="LMS.page_allrequest" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:TemplateField HeaderText="Requestid">
                    <ItemTemplate>
                        <%#Eval("rid") %>
                    </ItemTemplate>
                </asp:TemplateField>
                
                <asp:TemplateField HeaderText="Studentid">
                    <ItemTemplate>
                        <%#Eval("sid") %>
                    </ItemTemplate>
                </asp:TemplateField>
                
                <asp:TemplateField HeaderText="BookName">
                    <ItemTemplate>
                        <%#Eval("bname") %>
                    </ItemTemplate>
                </asp:TemplateField>
                
                <asp:TemplateField HeaderText="Author">
                    <ItemTemplate>
                        <%#Eval("auther") %>
                    </ItemTemplate>
                </asp:TemplateField>
                
                <asp:TemplateField HeaderText="BookSubject">
                    <ItemTemplate>
                        <%#Eval("bsubject") %>
                    </ItemTemplate>
                </asp:TemplateField>
                
                <asp:TemplateField HeaderText="DateOfRequest">
                    <ItemTemplate>
                        <%#Eval("dor") %>
                    </ItemTemplate>
                </asp:TemplateField>
                
                <asp:TemplateField HeaderText="RequestStatus">
                    <ItemTemplate>
                        <%#Eval("rstatus") %>
                    </ItemTemplate>
                </asp:TemplateField>
                
                <asp:TemplateField HeaderText="Accept">
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" Text="Accept" CommandName='<%#Eval("rid") %>' OnCommand="Linkbutton1_Command1"></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>

                
                <asp:TemplateField HeaderText="Reject">
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton2" runat="server" Text="Reject" CommandName='<%#Eval("rid") %>' OnCommand="Linkbutton2_Command"></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
                
                <asp:TemplateField HeaderText="Ordered">
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton3" runat="server" Text="Ordered" CommandName='<%#Eval("rid") %>' OnCommand="Linkbutton3_Command"></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
                
                <asp:TemplateField HeaderText="Available">
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton4" runat="server" Text="Available" CommandName='<%#Eval("rid") %>' OnCommand="Linkbutton4_Command"></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
    </asp:GridView>
        
        <br />
        
        <table width="100%">
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>

                    &nbsp;</td>
            </tr>

        </table>
        </center>
    
</asp:Content>
