<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="WebVideo.Inicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cuerpo" runat="server">
    <p class="text-center">
    <br />
&nbsp; <strong>&nbsp; </strong><span style="font-size: xx-large"><strong>¡Bienvenido a Hookin!</strong></span></p>
<p class="text-left">
    &nbsp;</p>
<p class="text-left">
    <span style="font-size: x-large">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span></p>
    <p class="text-left">
        <span style="font-size: x-large">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Último estreno:</span></p>
<p class="text-center">
    <strong>
    <asp:Label ID="Titulo" runat="server" style="font-size: x-large" Text="Título"></asp:Label>
    </strong>
</p>
<p class="text-center">
    <asp:Image ID="Imagen" runat="server" OnInit="Imagen_Init" Width="400px" BorderStyle="Groove" BorderWidth="10px" />
</p>
<p class="text-center">
    <asp:HyperLink ID="HyperLink" runat="server">Ver película</asp:HyperLink>
</p>
<p class="text-center">
    &nbsp;</p>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bajoCuerpo" runat="server">
</asp:Content>
