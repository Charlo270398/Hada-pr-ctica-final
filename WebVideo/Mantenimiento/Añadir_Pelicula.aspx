<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Añadir_Pelicula.aspx.cs" Inherits="WebVideo.Mantenimiento.Añadir_Pelicula" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cuerpo" runat="server">
    Titulo:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="tituloBox" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />Duración:&nbsp; &nbsp;&nbsp;
    <asp:TextBox ID="duracionBox" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />Fecha de Estreno:&nbsp; &nbsp;&nbsp;
    <asp:DropDownList ID="DWdia" runat="server" AutoPostBack="true" OnInit="DWdia_Init">
    </asp:DropDownList>
    <asp:DropDownList ID="DWmes" runat="server" AutoPostBack="true">
    </asp:DropDownList>
    <asp:DropDownList ID="DWaño" runat="server" AutoPostBack="true">
    </asp:DropDownList>
    &nbsp;&nbsp;&nbsp;&nbsp;
    <br />Sinopsis:&nbsp; &nbsp;&nbsp; <asp:TextBox ID="sinopsisBox" runat="server"></asp:TextBox>
    &nbsp;<br />
    Precio de Compra (en céntimos):&nbsp; &nbsp;&nbsp;
    <asp:TextBox ID="compraBox" runat="server"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;<br />
    Precio de Alquiler (en céntimos):&nbsp; &nbsp;&nbsp;
    <asp:TextBox ID="alquilerBox" runat="server"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
    Distribuidora:&nbsp; &nbsp;&nbsp; <asp:DropDownList ID="DWdist" runat="server" AutoPostBack="true">
    </asp:DropDownList>
    <br />
    Director:&nbsp; &nbsp;&nbsp;
    <asp:DropDownList ID="DWdir" runat="server" AutoPostBack="true">
    </asp:DropDownList>
    <br />
    Archivo de imagen (ej: imagen.jpg):&nbsp; &nbsp;&nbsp; <asp:TextBox ID="imagenBox" runat="server"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
    Saga:&nbsp; &nbsp;&nbsp;
    <asp:DropDownList ID="DWsaga" runat="server" AutoPostBack="true">
    </asp:DropDownList>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
    URL trailer:&nbsp; &nbsp;&nbsp; <asp:TextBox ID="trailerBox" runat="server"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
    <asp:Button ID="Btn_Insertar" runat="server" OnClick="Btn_Añadir_Click" Text="Insertar" />
    <asp:Label ID="Err" runat="server" ForeColor="Red" Text="ERROR" Visible="False"></asp:Label>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bajoCuerpo" runat="server">
</asp:Content>
