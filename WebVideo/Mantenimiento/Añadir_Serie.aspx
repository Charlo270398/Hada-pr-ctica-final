<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Añadir_Serie.aspx.cs" Inherits="WebVideo.Mantenimiento.Añadir_Serie" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cuerpo" runat="server">
    <p>
        Titulo:
        <asp:TextBox ID="titulo_textBox" runat="server"></asp:TextBox>
    </p>
    <p>
        Año de Estreno:
        <asp:TextBox ID="estreno_textBox" runat="server"></asp:TextBox>
    </p>
    <p>
        Sinopsis:&nbsp;
        <asp:TextBox ID="sinopsis_textBox" runat="server"></asp:TextBox>
    </p>
    <p>
        Precio Compra (en céntimos):
        <asp:TextBox ID="compra_textBox" runat="server"></asp:TextBox>
    </p>
    <p>
        Precio Alquiler (en céntimos):
        <asp:TextBox ID="alquiler_textBox" runat="server"></asp:TextBox>
    </p>
    <p>
        Archivo de Imagen:
        <asp:TextBox ID="imagen_textBox" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Btn_Insertar" runat="server" Text="Insertar" OnClick="Btn_Insertar_Click" />
        <asp:Label ID="Err" runat="server" ForeColor="Red" Text="ERROR" Visible="False"></asp:Label>
    <p>
        &nbsp;</p>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bajoCuerpo" runat="server">
</asp:Content>
