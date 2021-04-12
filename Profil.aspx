<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Profil.aspx.cs" Inherits="Exercice2_AT5.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
    <table>
        <tr style="height:300px;width:300px;">
            <td><asp:Image ID="Image1" runat="server" Height="300px" ImageUrl="~/Images/profil2.jpg" /></td>
            <td><asp:Image ID="Image2" runat="server" Height="300px" ImageUrl="~/Images/profil1.jpg" /></td>
        </tr>
        <tr>
            <td><span>web developer</span></td>
            <td><span>mobile developer</span></td>
        </tr>
    </table>
</asp:Content>
