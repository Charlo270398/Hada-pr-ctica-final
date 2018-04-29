<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Peliculas_individual.aspx.cs" Inherits="WebVideo.Peliculas.Peliculas_individual" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cuerpo" runat="server">
    <h2><asp:Label Font-Bold="true" ID="TituloIndividual" runat="server" Text="SAGA STAR WARS"></asp:Label></h2>
    <br />
    <div id ="serie_individual">
        <asp:ImageButton ID="imagePelicula1" runat="server" Height="200px" Width="200px" ImageUrl="~/images/peliculas_img/starwarsSaga.jpg"/><br />
        <asp:Label ID="temporadasText" runat="server" Text="Películas: 8"></asp:Label><br />
        <asp:Label ID="preciCompraText" runat="server" Text="PVP Compra: 29.95€"></asp:Label><br />
        <asp:Label ID="precioAlquilerText" runat="server" Text="PVP Alquiler: 4.95€"></asp:Label><br />
    </div>
    <div id="descripcion_individual">
        <h4>SINOPSIS</h4>
        <p>Pack con la saga completa de Star Wars que incluye La Amenaza Fantasma, El Ataque de los Clones, La Venganza de los Sith, La Guerra de las Galaxias: Una Nueva Esperanza, El Imperio Contraataca , El Retorno del Jedi, El Despertar de la Fuerza y Los Últimos Jedi; junto con tres discos exclusivos de esta edición con más contenidos adicionales.</p>
    </div>
    <div id="Temporadas_serie">
        <h4>PELÍCULAS</h4>
        <h5>LA AMENAZA FANTASMA</h5>
        <asp:ImageButton ID="ImageButton1" runat="server" Height="100px" Width="100px" ImageUrl="~/images/peliculas_img/stw1.jpg" OnClick="ImageButton1_Click"/><br />
        <h5>EL ATAQUE DE LOS CLONES</h5>
        <asp:ImageButton ID="ImageButton2" runat="server" Height="100px" Width="100px" ImageUrl="~/images/peliculas_img/stw2.jpg"/><br />
        <h5>LA VENGANZA DE LOS SITH</h5>
        <asp:ImageButton ID="ImageButton3" runat="server" Height="100px" Width="100px" ImageUrl="~/images/peliculas_img/stw3.jpg"/><br />
        <h5>UNA NUEVA ESPERANZA</h5>
        <asp:ImageButton ID="ImageButton4" runat="server" Height="100px" Width="100px" ImageUrl="~/images/peliculas_img/stw4.jpg"/><br />
        <h5>EL IMPERIO CONTRAATACA</h5>
        <asp:ImageButton ID="ImageButton5" runat="server" Height="100px" Width="100px" ImageUrl="~/images/peliculas_img/stw5.jpg"/><br />
        <h5>EL RETORNO DEL JEDI</h5>
        <asp:ImageButton ID="ImageButton6" runat="server" Height="100px" Width="100px" ImageUrl="~/images/peliculas_img/stw6.jpg"/><br />
        <h5>EL DESPERTAR DE LA FUERZA</h5>
        <asp:ImageButton ID="ImageButton7" runat="server" Height="100px" Width="100px" ImageUrl="~/images/peliculas_img/stw7.jpg"/>
        <h5>EL ÚLTIMO JEDI</h5>
        <asp:ImageButton ID="ImageButton8" runat="server" Height="100px" Width="100px" ImageUrl="~/images/peliculas_img/stw8.jpg"/><br />
    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bajoCuerpo" runat="server">
</asp:Content>
