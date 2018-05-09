<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Mostrar_Actor.aspx.cs" Inherits="WebVideo.Mostrar.Mostrar_Actor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cuerpo" runat="server">
    <asp:Label Font-Bold="True" ID="NombreText" runat="server" Text="Nombre" style="font-size: xx-large"></asp:Label>
&nbsp;&nbsp;&nbsp;
    <asp:Label Font-Bold="True" ID="ApellidosText" runat="server" Text="Apellidos" style="font-size: xx-large"></asp:Label>
    <br />
    <br />
    <asp:Label ID="PaisText" runat="server" Text="·Nacido en:" style="font-size: large"></asp:Label>
    <asp:Label ID="nombrePais" runat="server" Text="Narnia" style="font-size: medium; font-style: italic"></asp:Label>
    <br />
    <br />
    <asp:Label ID="PaisText0" runat="server" Text="·Fecha de nacimiento:" style="font-size: large"></asp:Label>
    <asp:Label ID="fechaNac" runat="server" Text="00-00-0000" style="font-size: medium; font-style: italic"></asp:Label>
    <h4>Películas</h4>
    <p>
        <asp:DropDownList ID="DWPeliculas" runat="server" OnInit="DWPeliculas_Init">
        </asp:DropDownList>
        <asp:Button ID="Btn_Pelicula" runat="server" Text="Mostrar Pelicula" OnClick="Btn_PeliculaC" />
        <asp:Label ID="ErrPelicula" runat="server" ForeColor="Red" Text="*Debe seleccionar una película" Visible="False"></asp:Label>
    </p>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bajoCuerpo" runat="server">
</asp:Content>
