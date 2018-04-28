<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Busquedas.aspx.cs" Inherits="WebVideo.Formulario_web1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cuerpo" runat="server">
    <div align="center" style="font-size: xx-large">¿Qué desea buscar?</div><br />
    Búsqueda por título (serie):<br />
    <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" Width="926px"></asp:TextBox>
    <br />
    <asp:Button ID="Button1" runat="server" Text="Buscar Serie" />
    <br />Búsqueda por título (película):<br />
    <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox1_TextChanged" Width="926px"></asp:TextBox>
    <br />
    <asp:Button ID="Button2" runat="server" Text="Buscar Película" />
    <br />Búsqueda por actor:<br />
    <asp:TextBox ID="TextBox3" runat="server" OnTextChanged="TextBox1_TextChanged" Width="926px"></asp:TextBox>
    <br />
    <asp:Button ID="Button3" runat="server" Text="Buscar Actor" />
    <br />Búsqueda por director:<br />
    <asp:TextBox ID="TextBox4" runat="server" OnTextChanged="TextBox1_TextChanged" Width="926px"></asp:TextBox>
    <br />
    <asp:Button ID="Button4" runat="server" Text="Buscar Director" />
    <br />Búsqueda por distribuidora:<br />
    <asp:TextBox ID="TextBox5" runat="server" OnTextChanged="TextBox1_TextChanged" Width="926px"></asp:TextBox>
    <br />
    <asp:Button ID="Button5" runat="server" Text="Buscar Distribuidora" />
    <br />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bajoCuerpo" runat="server">
    </asp:Content>
