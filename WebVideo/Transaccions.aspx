<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Transaccions.aspx.cs" Inherits="WebVideo.Transaccions" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cuerpo" runat="server">
    <p>
        &nbsp;</p>
    <p>
        <span style="font-size: xx-large">Transacción</span></p>
    <p>
        &nbsp;</p>
    <p>
        <span style="font-size: large">Opciones de compra:</span></p>
    <p>
        <span style="font-size: medium">Precio de alquiler:
        <asp:Label ID="PrecioA" runat="server" Text="Label"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Precio de compra:
        <asp:Label ID="PrecioC" runat="server" Text="Label"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>
    </p>
    <p>
        <span style="font-size: medium">Fecha de devolución:
        <asp:Label ID="Fecha" runat="server" Text="Label"></asp:Label>
        </span>
    </p>
    <p>
        <asp:Button ID="Btn_Alquilar" runat="server" OnClick="Btn_Alquilar_Click" Text="Alquilar" style="background-color: #99CCFF" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Btn_Comprar" runat="server" OnClick="Btn_Comprar_Click" Text="Comprar" style="background-color: #FF99FF" />
&nbsp;&nbsp; <span style="font-size: medium">
        <asp:Label ID="Err" runat="server" Text="Label" Visible="False"></asp:Label>
        </span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </p>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bajoCuerpo" runat="server">
</asp:Content>
