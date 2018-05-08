<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Mostrar_Director.aspx.cs" Inherits="WebVideo.Mostrar.Mostrar_Director" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cuerpo" runat="server">
    <asp:Label Font-Bold="True" ID="NombreText" runat="server" Text="Nombre" OnInit="Nombre_Init" style="font-size: xx-large"></asp:Label>
&nbsp;&nbsp;&nbsp;
    <asp:Label Font-Bold="True" ID="ApellidosText" runat="server" Text="Apellidos" style="font-size: xx-large"></asp:Label>
    <br />
    <br />
        <asp:Label ID="PaisText" runat="server" Text="·Nacido en:" style="font-size: large"></asp:Label>
        <asp:Label ID="nombrePais" runat="server" Text="Narnia" style="font-size: medium; font-style: italic"></asp:Label>
        <br />
        <h4>Películas</h4>
    <p>
    <asp:DropDownList ID="DWPeliculas" runat="server">
    </asp:DropDownList>
    <asp:Button ID="Btn_Pelicula" runat="server" Text="Mostrar Pelicula" OnClick="Btn_PeliculaC" />
    <asp:Label ID="ErrPelicula" runat="server" ForeColor="Red" Text="*Debe seleccionar una película" Visible="False"></asp:Label>
    </p>
        <br />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bajoCuerpo" runat="server">
    <br />
</asp:Content>
