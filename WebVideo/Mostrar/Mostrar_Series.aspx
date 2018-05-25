<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Mostrar_Series.aspx.cs" Inherits="WebVideo.Series.Mostrar_Series" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cuerpo" runat="server">
    <h2>
        <asp:Label Font-Bold="True" ID="Titulo_S" runat="server" Text="Titulo_S"></asp:Label>
    </h2>
    <br />
    <div id ="serie_individual">
        <asp:ImageButton ID="Imagen" runat="server" Height="300px" Width="225px" OnInit="imageSerie1_Init" BorderStyle="Groove" BorderWidth="10px"/>
        <br />
        <h4>FICHA DE LA SERIE</h4>
        <asp:Label ID="Fecha_Etext" runat="server" Text="Fecha de estreno: " Font-Italic="False" Font-Strikeout="False"></asp:Label>
        <asp:Label ID="fechaEstrenotext" runat="server" Text="0"></asp:Label>
        <br />
        <asp:Label ID="preciCompraText" runat="server" Text="PVP Compra:"></asp:Label>
        <asp:Label ID="precioCnumtext" runat="server" Text="0"></asp:Label>
        <br />
        <asp:Label ID="precioAlquilerText" runat="server" Text="PVP Alquiler:"></asp:Label>
        <asp:Label ID="precioAnumtext" runat="server" Text="0"></asp:Label>
        <br />
    </div>
    <div id="descripcion_individual">
        <h4>SINOPSIS</h4>
        <asp:Label ID="Texto_Sinopsis" runat="server" Text="texto_sinopsis"></asp:Label>
        <br />
        <br />
        <asp:HyperLink ID="adquirirText" runat="server" Visible="False">Adquirir Serie</asp:HyperLink>
        <br />
        <br />
    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bajoCuerpo" runat="server">
</asp:Content>
