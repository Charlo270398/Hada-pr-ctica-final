<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Busquedas.aspx.cs" Inherits="WebVideo.Formulario_web1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cuerpo" runat="server">
    <div align="center" style="font-size: xx-large">¿Qué desea buscar?</div>
        <span style="font-size: x-large"><strong>
    <br />
                <asp:Label ID="Titulo0" runat="server" style="font-size: small" Text="Cantidad de búsquedas hoy:"></asp:Label>
                &nbsp;<asp:Label ID="num" runat="server" style="font-size: small" Text="Título"></asp:Label>
                <br />
    </strong></span><br />
    Búsqueda por título (serie):<br />
    <asp:TextBox ID="SerieBox" runat="server" Width="926px"></asp:TextBox>
    <br />
    <asp:Button ID="Btn_Serie" runat="server"  Text="Buscar Serie" OnClick="Btn_SerieC" />
    <asp:DropDownList ID="DWSeries" runat="server" Visible="False">
    </asp:DropDownList>
    <asp:Button ID="Btn_Serie2" runat="server" Text="Mostrar Serie" OnClick="Btn_Serie2C" Visible="False" />
    <asp:Label ID="ErrSerie" runat="server" ForeColor="Red" Text="*Debe seleccionar una serie" Visible="False"></asp:Label>
    <br />Búsqueda por título (película):<br />
    <asp:TextBox ID="PeliculaBox" runat="server" Width="926px"></asp:TextBox>
    <br />
    <asp:Button ID="Btn_Pelicula" runat="server" Text="Buscar Película" OnClick="Btn_PeliculaC" />
    <asp:DropDownList ID="DWPeliculas" runat="server" Visible="False">
    </asp:DropDownList>
    <asp:Button ID="Btn_Pelicula2" runat="server" Text="Mostrar Pelicula" OnClick="Btn_Pelicula2C" Visible="False" />
    <asp:Label ID="ErrPelicula" runat="server" ForeColor="Red" Text="*Debe seleccionar una película" Visible="False"></asp:Label>
    <br />Búsqueda por actor:<br />
    <asp:TextBox ID="ActorBox" runat="server" Width="926px"></asp:TextBox>
    <br />
    <asp:Button ID="Button3" runat="server" Text="Buscar Actor" OnClick="Button_Actor" />
    <asp:DropDownList ID="DWActor" runat="server" Visible="False">
    </asp:DropDownList>
    <asp:Button ID="Btn_Actor2" runat="server" Text="Mostrar Actor" OnClick="Btn_Actor2C" Visible="False" />
    <asp:Label ID="ErrActor" runat="server" ForeColor="Red" Text="*Debe seleccionar un actor" Visible="False"></asp:Label>
    <br />Búsqueda por director:<br />
    <asp:TextBox ID="DirectorBox" runat="server" Width="926px"></asp:TextBox>
    <br />
    <asp:Button ID="Btn_Director" runat="server" Text="Buscar Director" OnClick="Btn_DirectorC" />
    <asp:DropDownList ID="DWDirector" runat="server" Visible="False">
    </asp:DropDownList>
    <asp:Button ID="Btn_Director2" runat="server" Text="Mostrar Director" OnClick="Btn_Director2C" Visible="False" />
    <asp:Label ID="ErrDirector" runat="server" ForeColor="Red" Text="*Debe seleccionar un director" Visible="False"></asp:Label>
    <br />Búsqueda por distribuidora:<br />
    <asp:TextBox ID="DistribuidoraBox" runat="server" Width="926px"></asp:TextBox>
    <br />
    <asp:Button ID="Btn_Distribuidora" runat="server" Text="Buscar Distribuidora" OnClick="Btn_DistribuidoraC" />
    <asp:DropDownList ID="DWDistribuidora" runat="server" Visible="False">
    </asp:DropDownList>
    <asp:Button ID="Btn_Distribuidora2" runat="server" Text="Mostrar Distribuidora" OnClick="Btn_Distribuidora2C" Visible="False" />
    <asp:Label ID="ErrDistribuidora" runat="server" ForeColor="Red" Text="*Debe seleccionar una distribuidora" Visible="False"></asp:Label>
    <br />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bajoCuerpo" runat="server">
    </asp:Content>
