<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Mostrar_Peliculas.aspx.cs" Inherits="WebVideo.Peliculas.Mostrar_Peliculas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cuerpo" runat="server">
    <h2>
        <asp:Label Font-Bold="True" ID="Titulo" runat="server" Text="SAGA STAR WARS" OnInit="TituloIndividual_Init"></asp:Label>
    </h2>
    <br />
    <div id ="serie_individual">
        <asp:ImageButton ID="Imagen" runat="server" Height="200px" Width="200px" ImageUrl="~/images/peliculas_img/starwarsSaga.jpg" OnInit="imagePelicula1_Init"/>
        <br />
        <asp:Label ID="temporadasText" runat="server" Text="Películas: 8"></asp:Label>
        <br />
        <asp:Label ID="preciCompraText" runat="server" Text="PVP Compra: 29.95€"></asp:Label>
        <br />
        <asp:Label ID="precioAlquilerText" runat="server" Text="PVP Alquiler: 4.95€"></asp:Label>
        <br />
    </div>
    <div id="descripcion_individual">
        <h4>SINOPSIS</h4>
        <asp:Label ID="Sinopsis" runat="server" Text="Pack con la saga completa de Star Wars que incluye La Amenaza Fantasma, El Ataque de los Clones, La Venganza de los Sith, La Guerra de las Galaxias: Una Nueva Esperanza, El Imperio Contraataca , El Retorno del Jedi, El Despertar de la Fuerza y Los Últimos Jedi; junto con tres discos exclusivos de esta edición con más contenidos adicionales." OnInit="I_sinopsis"></asp:Label>
        <br />
    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bajoCuerpo" runat="server">
</asp:Content>
