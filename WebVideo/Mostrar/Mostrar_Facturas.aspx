<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Mostrar_Facturas.aspx.cs" Inherits="WebVideo.Mostrar.Mostrar_Facturas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cuerpo" runat="server">
    <br />
    <asp:Label Font-Bold="True" ID="Factura" runat="server" Text="Factura" style="font-size: xx-large"></asp:Label>
&nbsp;&nbsp;&nbsp;
    <br />
    <br />
    <br />
    <asp:Label ID="p" runat="server" Text="·Producto:" style="font-size: large"></asp:Label>
    <asp:Label ID="producto" runat="server" Text="nombre" style="font-size: medium; font-style: italic"></asp:Label>
    <br />
    <br />
    <asp:Label ID="p0" runat="server" Text="·Tipo de compra:" style="font-size: large"></asp:Label>
    <asp:Label ID="tipo" runat="server" Text="nombre" style="font-size: medium; font-style: italic"></asp:Label>
    <br />
    <br />
    <asp:Label ID="PaisText" runat="server" Text="·Importe:" style="font-size: large"></asp:Label>
    <asp:Label ID="importe" runat="server" Text="0€" style="font-size: medium; font-style: italic"></asp:Label>
    <br />
    <br />
    <asp:Label ID="PaisText0" runat="server" Text="·Fecha de pago:" style="font-size: large"></asp:Label>
    <asp:Label ID="fechaPago" runat="server" Text="00-00-0000" style="font-size: medium; font-style: italic"></asp:Label>
    <br />
    <br />
    <asp:Label ID="FechaDevText" runat="server" Text="·Fecha de devolución:" style="font-size: large" OnInit="FechaDevText_Init" Visible="False"></asp:Label>
    <asp:Label ID="fechaDevNum" runat="server" Text="00-00-0000" style="font-size: medium; font-style: italic" Visible="False"></asp:Label>
    <br />
    <br />
    <br />
    <h4>&nbsp;</h4>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bajoCuerpo" runat="server">
</asp:Content>
