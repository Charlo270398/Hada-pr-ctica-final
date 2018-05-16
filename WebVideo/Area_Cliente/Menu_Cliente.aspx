<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Menu_Cliente.aspx.cs" Inherits="WebVideo.Area_Clientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cuerpo" runat="server">
    <p>
        &nbsp;</p>
    <p>
        <strong><span style="font-size: x-large">Área del cliente</span></strong></p>
    <p>
        <em><strong>
        <asp:Label ID="admin" runat="server" Text="*ADMINISTRADOR*" ForeColor="#3333FF" Visible="False"></asp:Label>
        </strong></em></p>
    <p>
        <strong>Email: </strong>
        <asp:Label ID="email" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
        <strong>Nombre: </strong>
        <asp:Label ID="nombre" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
        <strong>País: </strong>
        <asp:Label ID="pais" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
        <strong>Fecha de alta: </strong>
        <asp:Label ID="fecha" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <strong>Peliculas:</strong><br />
    <asp:Button ID="Btn_Compra" runat="server"  Text="Ver compra" OnClick="Btn_CompraC" />
    &nbsp;&nbsp;&nbsp;
    <asp:DropDownList ID="DWCompras" runat="server" OnInit="DWCompras_Init">
    </asp:DropDownList>
        &nbsp;&nbsp;&nbsp;&nbsp;
    </p>
    <p>
    <asp:Button ID="Btn_Alquiler" runat="server"  Text="Ver alquiler" OnClick="Btn_AlquilerC" />
    &nbsp;&nbsp;&nbsp;
    <asp:DropDownList ID="DWAlquiler" runat="server">
    </asp:DropDownList>
    </p>
    <p>
        <strong>Series:</strong></p>
    <p>
    <asp:Button ID="Btn_Compra0" runat="server"  Text="Ver compra" OnClick="Btn_CompraC0" />
    <asp:DropDownList ID="DWCompras0" runat="server">
    </asp:DropDownList>
    </p>
    <p>
    <asp:Button ID="Btn_Alquiler0" runat="server"  Text="Ver alquiler" OnClick="Btn_AlquilerC0" />
    <asp:DropDownList ID="DWAlquiler0" runat="server">
    </asp:DropDownList>
    </p>
    <p>
    <asp:Button ID="Btn_ModificarContraseña" runat="server"  Text="Cambiar contraseña" OnClick="Btn_ContraseñaC" />
    </p>
    <p>
    <asp:Button ID="Btn_ModificarDatos" runat="server"  Text="Cambiar datos" OnClick="Btn_DatosC" />
    </p>
    <p>
    <asp:Button ID="Btn_Borrar" runat="server"  Text="Borrar cuenta" OnClick="Btn_BorrarC" style="background-color: #CC3300" />
    </p>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bajoCuerpo" runat="server">
</asp:Content>
