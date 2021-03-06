﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Modificar_Serie.aspx.cs" Inherits="WebVideo.Mantenimiento.Modificar_Serie" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cuerpo" runat="server">
    <p>
        Serie:
        <asp:DropDownList ID="DWSeries" runat="server" AutoPostBack="true" OnInit="DWSeries_Init">
        </asp:DropDownList>
    </p>
    <p>
        Titulo:
        <asp:TextBox ID="tituloBox" runat="server"></asp:TextBox>
    </p>
    <p>
        Sinopsis:
        <asp:TextBox ID="sinopsisBox" runat="server"></asp:TextBox>
    </p>
    <p>
        Año de Estreno:
        <asp:TextBox ID="fechaBox" runat="server"></asp:TextBox>
    </p>
    <p>
        Precio de Compra (en céntimos):
        <asp:TextBox ID="compraBox" runat="server"></asp:TextBox>
    </p>
    <p>
        Precio de Alquiler (en céntimos):
        <asp:TextBox ID="alquilerBox" runat="server"></asp:TextBox>
    </p>
    <p>
        Imagen (ej: Imagen.jpg):
        <asp:TextBox ID="imgBox" runat="server"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Btn_modificar" runat="server" Text="Modificar" OnClick="Btn_modificar_Click" />
        <asp:Label ID="Err" runat="server" ForeColor="Red" Text="ERROR" Visible="False"></asp:Label>
    </p>
    <p>
        &nbsp;</p>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bajoCuerpo" runat="server">
</asp:Content>
