<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Peliculas_index.aspx.cs" Inherits="WebVideo.Peliculas.Peliculas_index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cuerpo" runat="server">
    <asp:Label Font-Bold="True" ID="TituloSeries" runat="server" Text="PELÍCULAS DISPONIBLES"></asp:Label>
    <br />
    <div id ="serie_resumen">
        <asp:HyperLink ID="hyper_tituloserie1" runat="server">DUNKERQUE</asp:HyperLink><br />
        <asp:ImageButton ID="imagePelicula1" runat="server" OnClick="ImagePelicula1_Click"  Height="150px" Width="150px" ImageUrl="~/images/peliculas_img/dunkerque.jpg"/><br />
        <asp:Label ID="fechaEstrenoText" runat="server" Text="Fecha de Estreno: 13/07/2017"></asp:Label><br />
        <asp:Label ID="temporadasText" runat="server" Text="Sinopsis: Los soldados aliados de Bélgica, el Imperio Británico, Canada y Francia estaban rodeados por el ejército Alemán y fueron evacuados en una batalla feroz durante la Segunda Guerra Mundial. &quot;Dunkerque&quot; comienza mientras cientos de miles soldados Británicos y tropas Aliadas están siendo rodeadas por las fuerzas enemigas."></asp:Label><br />
        <asp:Label ID="preciCompraText" runat="server" Text="PVP Compra: 4.95€"></asp:Label><br />
        <asp:Label ID="precioAlquilerText" runat="server" Text="PVP Alquiler: 0.95€"></asp:Label><br />

        <br />
        <asp:HyperLink ID="hyper_tituloserie2" runat="server">IT</asp:HyperLink><br />
        <asp:ImageButton ID="imageSerie2" runat="server"  Height="150px" Width="150px" ImageUrl="~/images/peliculas_img/it.jpg" OnClick="imageSerie2_Click"/><br />
        <asp:Label ID="fechaEstrenoText2" runat="server" Text="Fecha de Estreno: 8/09/2017"></asp:Label><br />
        <asp:Label ID="temporadasText2" runat="server" Text="Sinopsis: Son los años 80 en el pequeño pueblo de Derry, en el estado de Maine. En él vive una panda de siete niños conocidos como 'El club de los perdedores', que debe enfrentarse a sus problemas cotidianos con los matones de la escuela. Pero su vida da un giro inesperado cuando, durante el verano, una gran amenaza se cierne sobre ellos después de que una oleada de extrañas muertes provoquen el pánico y el terror entre los habitantes del lugar. "></asp:Label><br />
        <asp:Label ID="preciCompraText2" runat="server" Text="PVP Compra: 4.95€"></asp:Label><br />
        <asp:Label ID="precioAlquilerText2" runat="server" Text="PVP Alquiler: 0.95€"></asp:Label><br />

        <br />
        <asp:HyperLink ID="hyper_tituloserie3" runat="server" NavigateUrl="~/Peliculas/Peliculas_individual.aspx">SAGA STAR WARS</asp:HyperLink><br />
        <asp:ImageButton ID="imageSerie3" runat="server" OnClick="ImagePelicula3_Click"  Height="150px" Width="150px" ImageUrl="~/images/peliculas_img/starwarsSaga.jpg"/><br />
        <asp:Label ID="temporadasText3" runat="server" Text="Nº Películas: 8"></asp:Label>
        <br />
        <asp:Label ID="temporadasText4" runat="server" Text="Sinopsis: Pack con la saga completa de Star Wars que incluye La Amenaza Fantasma, El Ataque de los Clones, La Venganza de los Sith, La Guerra de las Galaxias: Una Nueva Esperanza, El Imperio Contraataca, El Retorno del Jedi, El Despertar de la Fuerza y El Último Jedi; junto con tres discos exclusivos de esta edición con más contenidos adicionales. "></asp:Label><br />
        <asp:Label ID="preciCompraText3" runat="server" Text="PVP Compra: 29.95€"></asp:Label><br />
        <asp:Label ID="precioAlquilerText3" runat="server" Text="PVP Alquiler: 4.95€"></asp:Label><br />
    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bajoCuerpo" runat="server">
</asp:Content>
