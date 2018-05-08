<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Mostrar_Peliculas.aspx.cs" Inherits="WebVideo.Peliculas.Mostrar_Peliculas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cuerpo" runat="server">
    <h2>
        <asp:Label Font-Bold="True" ID="Titulo" runat="server" Text="Titulo" OnInit="TituloIndividual_Init"></asp:Label>
    </h2>
    <br />
    <div id ="serie_individual">
        <asp:ImageButton ID="Imagen" runat="server" Height="200px" Width="200px" OnInit="imagePelicula1_Init" BorderStyle="Groove" BorderWidth="10px"/>
        <br />
        <br />
        <asp:Label ID="Fecha_Etext" runat="server" Text="Fecha de estreno: " Font-Italic="False" Font-Strikeout="False"></asp:Label>
        <asp:Label ID="fechaEstrenotext" runat="server" Text="0" OnInit="fechaEstrenotext_Init"></asp:Label>
        <br />
        <asp:Label ID="duraciontext" runat="server" Text="Duración:"></asp:Label>
        <asp:Label ID="duracionNumtext" runat="server" Text="0" OnInit="duraciontext_Init"></asp:Label>
        <br />
        <asp:Label ID="preciCompraText" runat="server" Text="PVP Compra:"></asp:Label>
        <asp:Label ID="precioCnumtext" runat="server" Text="0" OnInit="precioCnumtext_Init"></asp:Label>
        <br />
        <asp:Label ID="precioAlquilerText" runat="server" Text="PVP Alquiler:"></asp:Label>
        <asp:Label ID="precioAnumtext" runat="server" Text="0" OnInit="precioAnumtext_Init"></asp:Label>
        <br />
        <br />
    </div>
    <div id="descripcion_individual">
        <h4>SINOPSIS</h4>
        <asp:Label ID="Texto_Sinopsis" runat="server" Text="texto_sinopsis" OnInit="I_sinopsis"></asp:Label>
        <br />
        <br />
        <asp:HyperLink ID="TrailerLink" runat="server" ForeColor="#CC3399" OnInit="cargaTrailer">Ver trailer</asp:HyperLink>
        <br />
        <br />
    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bajoCuerpo" runat="server">
</asp:Content>
