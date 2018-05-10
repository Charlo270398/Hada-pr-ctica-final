<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Area_Cliente.aspx.cs" Inherits="WebVideo.Area_Cliente" %>
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
        <br />
    <asp:Button ID="Btn_Compra" runat="server"  Text="Ver compra" OnClick="Btn_CompraC" />
    <asp:DropDownList ID="DWCompras" runat="server">
    </asp:DropDownList>
    &nbsp;</p>
    <p>
    <asp:Button ID="Btn_Alquiler" runat="server"  Text="Ver alquiler" OnClick="Btn_AlquilerC" />
    <asp:DropDownList ID="DWAlquiler" runat="server">
    </asp:DropDownList>
    </p>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bajoCuerpo" runat="server">
</asp:Content>
