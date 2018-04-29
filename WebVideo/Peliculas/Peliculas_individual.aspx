<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Peliculas_individual.aspx.cs" Inherits="WebVideo.Series.Series_individual" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cuerpo" runat="server">
    <h2><asp:Label Font-Bold="true" ID="TituloIndividual" runat="server" Text="JUEGO DE TRONOS"></asp:Label></h2>
    <br />
    <div id ="serie_individual">
        <asp:ImageButton ID="imageSerie1" runat="server" Height="200px" Width="200px" ImageUrl="~/images/series_img/juego_de_tronos.jpg"/><br />
        <asp:Label ID="fechaEstrenoText" runat="server" Text="Fecha de Estreno: 17/04/2011"></asp:Label><br />
        <asp:Label ID="temporadasText" runat="server" Text="Temporadas: 7"></asp:Label><br />
        <asp:Label ID="episodiosText" runat="server" Text="Episodios: 67"></asp:Label><br />
        <asp:Label ID="preciCompraText" runat="server" Text="PVP Compra: 9.95€"></asp:Label><br />
        <asp:Label ID="precioAlquilerText" runat="server" Text="PVP Alquiler: 3.95€"></asp:Label><br />
    </div>
    <div id="descripcion_individual">
        <h4>SINOPSIS</h4>
        <p>Serie de TV (2011-Actualidad). La historia se desarrolla en un mundo ficticio de carácter medieval donde hay Siete Reinos. Hay tres líneas argumentales principales: la crónica de la guerra civil dinástica por el control de Poniente entre varias familias nobles que aspiran al Trono de Hierro, la creciente amenaza de los Otros, seres desconocidos que viven al otro lado de un inmenso muro de hielo que protege el Norte de Poniente, y el viaje de Daenerys Targaryen, la hija exiliada del rey que fue asesinado en una guerra civil anterior, y que pretende regresar a Poniente para reclamar sus derechos. Tras un largo verano de varios años, el temible invierno se acerca a los Siete Reinos. Lord Eddard 'Ned' Stark, señor de Invernalia, deja sus dominios para ir a la corte de su amigo, el rey Robert Baratheon en Desembarco del Rey, la capital de los Siete Reinos. Stark se convierte en la Mano del Rey e intenta desentrañar una maraña de intrigas que pondrá en peligro su vida y la de todos los suyos. Mientras tanto diversas facciones conspiran con un solo objetivo: apoderarse del trono.</p>
    </div>
    <div id="Temporadas_serie">
        <h4>TEMPORADAS</h4>
        <h5>TEMPORADA 1</h5>
        <asp:ImageButton ID="ImageButton1" runat="server" Height="100px" Width="100px" ImageUrl="~/images/series_img/gott1.jpg" OnClick="ImageButton1_Click"/><br />
        <h5>TEMPORADA 2</h5>
        <asp:ImageButton ID="ImageButton2" runat="server" Height="100px" Width="100px" ImageUrl="~/images/series_img/gott2.jpg"/><br />
        <h5>TEMPORADA 3</h5>
        <asp:ImageButton ID="ImageButton3" runat="server" Height="100px" Width="100px" ImageUrl="~/images/series_img/gott3.jpg"/><br />
        <h5>TEMPORADA 4</h5>
        <asp:ImageButton ID="ImageButton4" runat="server" Height="100px" Width="100px" ImageUrl="~/images/series_img/gott4.jpg"/><br />
        <h5>TEMPORADA 5</h5>
        <asp:ImageButton ID="ImageButton5" runat="server" Height="100px" Width="100px" ImageUrl="~/images/series_img/gott5.jpg"/><br />
        <h5>TEMPORADA 6</h5>
        <asp:ImageButton ID="ImageButton6" runat="server" Height="100px" Width="100px" ImageUrl="~/images/series_img/gott6.jpg"/><br />
        <h5>TEMPORADA 7</h5>
        <asp:ImageButton ID="ImageButton7" runat="server" Height="100px" Width="100px" ImageUrl="~/images/series_img/gott7.jpg"/><br />
    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bajoCuerpo" runat="server">
</asp:Content>
