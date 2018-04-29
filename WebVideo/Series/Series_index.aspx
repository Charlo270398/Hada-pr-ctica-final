<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Series_index.aspx.cs" Inherits="WebVideo.Series.Series_index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cuerpo" runat="server">
    <asp:Label Font-Bold="true" ID="TituloSeries" runat="server" Text="SERIES DISPONIBLES"></asp:Label>
    <br />
    <div id ="serie_resumen">
        <asp:HyperLink ID="hyper_tituloserie1" runat="server" NavigateUrl="~/Series/Series_individual.aspx">JUEGO DE TRONOS</asp:HyperLink><br />
        <asp:ImageButton ID="imageSerie1" runat="server" OnClick="ImageSerie1_Click"  Height="150px" Width="150px" ImageUrl="~/images/series_img/juego_de_tronos.jpg"/><br />
        <asp:Label ID="fechaEstrenoText" runat="server" Text="Fecha de Estreno: 17/04/2011"></asp:Label><br />
        <asp:Label ID="temporadasText" runat="server" Text="Temporadas: 7"></asp:Label><br />
        <asp:Label ID="episodiosText" runat="server" Text="Episodios: 67"></asp:Label><br />
        <asp:Label ID="preciCompraText" runat="server" Text="PVP Compra: 9.95€"></asp:Label><br />
        <asp:Label ID="precioAlquilerText" runat="server" Text="PVP Alquiler: 3.95€"></asp:Label><br />

        <br />
        <asp:HyperLink ID="hyper_tituloserie2" runat="server">STRANGER THINGS</asp:HyperLink><br />
        <asp:ImageButton ID="imageSerie2" runat="server"  Height="150px" Width="150px" ImageUrl="~/images/series_img/stranger_things2.jpg"/><br />
        <asp:Label ID="fechaEstrenoText2" runat="server" Text="Fecha de Estreno: 17/04/2011"></asp:Label><br />
        <asp:Label ID="temporadasText2" runat="server" Text="Temporadas: 7"></asp:Label><br />
        <asp:Label ID="episodiosText2" runat="server" Text="Episodios: 67"></asp:Label><br />
        <asp:Label ID="preciCompraText2" runat="server" Text="PVP Compra: 9.95€"></asp:Label><br />
        <asp:Label ID="precioAlquilerText2" runat="server" Text="PVP Alquiler: 3.95€"></asp:Label><br />

        <br />
        <asp:HyperLink ID="hyper_tituloserie3" runat="server">LOST (PERDIDOS) </asp:HyperLink><br />
        <asp:ImageButton ID="imageSerie3" runat="server"  Height="150px" Width="150px" ImageUrl="~/images/series_img/lost.jpg"/><br />
        <asp:Label ID="fechaEstrenoText3" runat="server" Text="Fecha de Estreno: 17/04/2011"></asp:Label><br />
        <asp:Label ID="temporadasText3" runat="server" Text="Temporadas: 7"></asp:Label><br />
        <asp:Label ID="episodiosText3" runat="server" Text="Episodios: 67"></asp:Label><br />
        <asp:Label ID="preciCompraText3" runat="server" Text="PVP Compra: 9.95€"></asp:Label><br />
        <asp:Label ID="precioAlquilerText3" runat="server" Text="PVP Alquiler: 3.95€"></asp:Label><br />
    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bajoCuerpo" runat="server">
</asp:Content>
