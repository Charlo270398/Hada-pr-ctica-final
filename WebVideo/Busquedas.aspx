<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Busquedas.aspx.cs" Inherits="WebVideo.Formulario_web1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cuerpo" runat="server">
    <div align="center" style="font-size: xx-large">¿Qué desea buscar?</div><br />
    Búsqueda por título (serie):<br />
    <asp:TextBox ID="TextBox1" runat="server"  OnTextChanged="TextBox1_TextChanged" Width="926px"></asp:TextBox>
    <br />
    <asp:Button ID="Btn_Serie" runat="server"  Text="Buscar Serie" OnClick="Btn_SerieC" />
    <asp:DropDownList ID="DWSeries" runat="server" Visible="False">
    </asp:DropDownList>
    <br />Búsqueda por título (película):<br />
    <asp:TextBox ID="PeliculaBox" runat="server" OnTextChanged="TextBox1_TextChanged" Width="926px"></asp:TextBox>
    <br />
    <asp:Button ID="Btn_Pelicula" runat="server" Text="Buscar Película" OnClick="Btn_PeliculaC" />
    <asp:DropDownList ID="DWPeliculas" runat="server" Visible="False">
    </asp:DropDownList>
    <asp:Button ID="Btn_Pelicula2" runat="server" Text="Mostrar Pelicula" OnClick="Btn_Pelicula2C" Visible="False" />
    <asp:Label ID="ErrPelicula" runat="server" ForeColor="Red" Text="*Debe seleccionar una película" Visible="False"></asp:Label>
    <br />Búsqueda por actor:<br />
    <asp:TextBox ID="TextBox3" runat="server" OnTextChanged="TextBox1_TextChanged" Width="926px"></asp:TextBox>
    <br />
    <asp:Button ID="Button3" runat="server" Text="Buscar Actor" />
    <asp:DropDownList ID="DWActor" runat="server" Visible="False">
    </asp:DropDownList>
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
