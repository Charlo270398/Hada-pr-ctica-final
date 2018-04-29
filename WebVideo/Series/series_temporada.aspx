<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="series_temporada.aspx.cs" Inherits="WebVideo.Series.series_temporada" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cuerpo" runat="server">
    <h2><asp:Label Font-Bold="true" ID="TituloIndividual" runat="server" Text="JUEGO DE TRONOS: TEMPORADA 1"></asp:Label></h2>
    <div id ="serie_individual">
        <asp:ImageButton ID="imageSerie1" runat="server" Height="200px" Width="200px" ImageUrl="~/images/series_img/gott1.jpg"/><br />
    </div>
     <div id="descripcion_temporada">
        <h4>SINOPSIS</h4>
        <p>El rey Robert Baratheon de Poniente viaja al Norte para ofrecerle a su viejo amigo Eddard "Ned" Stark, Guardián del Norte y Señor de Invernalia, el puesto de Mano del Rey. La esposa de Ned, Catelyn, recibe una carta de su hermana Lysa que implica a miembros de la familia Lannister, la familia de la reina Cersei, en el asesinato de su marido Jon Arryn, la anterior Mano del Rey. Bran, uno de los hijos de Ned y Catelyn, escala un muro y descubre a la reina Cersei y a su hermano Jaime teniendo relaciones sexuales, Jaime empuja al pequeño Bran esperando que la caída lo mate y así evitar ser delatado por el niño. Mientras tanto, al otro lado del mar Angosto, el príncipe exiliado Viserys Targaryen forja una alianza para recuperar el Trono de Hierro: dará a su hermana Daenerys en matrimonio al salvaje dothraki Khal Drogo a cambio de su ejército. El caballero exiliado Jorah Mormont se unirá a ellos para proteger a Daenerys.</p>
    </div>
    <div id="capitulos_temporada">
        <h4>CAPIUTLOS</h4>
        <h5>1X01: Winter Is Coming</h5>
        <asp:ImageButton ID="ImageButton1" runat="server" Height="100px" Width="100px" ImageUrl="~/images/series_img/1x01got.jpg"/><br />
        <p>El rey Robert Baratheon de Poniente viaja al Norte para ofrecerle a su viejo amigo Eddard "Ned" Stark...</p>
        <h5>1X02: The Kingsroad</h5>
        <asp:ImageButton ID="ImageButton2" runat="server" Height="100px" Width="100px" ImageUrl="~/images/series_img/1x02got.jpg"/><br />
        <p>El rey Robert Baratheon de Poniente viaja al Norte para ofrecerle a su viejo amigo Eddard "Ned" Stark, Guardián del Norte y Señor de Invernalia, el puesto de Mano del Rey. La esposa de Ned...</p>
    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bajoCuerpo" runat="server">
</asp:Content>
