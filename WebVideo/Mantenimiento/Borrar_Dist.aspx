<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Borrar_Dist.aspx.cs" Inherits="WebVideo.Mantenimiento.Borrar_Dist" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cuerpo" runat="server">
    <br />
    <br />
    <br />
&nbsp;&nbsp;&nbsp;&nbsp; Inserte ID a borrar:&nbsp;&nbsp;
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:Label ID="Err" runat="server" ForeColor="Red" Text="ERROR" Visible="False"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Btn_Borrar" runat="server" OnClick="Btn_Borrar_Click" Text="Borrar" />
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bajoCuerpo" runat="server">
    </asp:Content>


