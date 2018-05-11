<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="WebVideo.Mantenimiento.Main" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cuerpo" runat="server">
    <h2>Área de mantenimieto</h2>
    <h2>
        <br />
        <asp:Button ID="Btn_Dist" runat="server" OnClick="Btn_Dist_Click" Text="Distribuidora" Width="119px" />
&nbsp;&nbsp;
        <asp:DropDownList ID="DW_Dist" runat="server" OnInit="DW_Dist_Init" Width="200px">
        </asp:DropDownList>
    &nbsp;</h2>
    <p>
        <asp:Button ID="Btn_Dir" runat="server" Text="Director" Width="120px" OnClick="Btn_Dir_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DW_Dir" runat="server" Width="200px">
        </asp:DropDownList>
    </p>
    <p>
        <asp:Button ID="Btn_Actor" runat="server" Text="Actor" Width="120px" OnClick="Btn_Actor_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DW_Actor" runat="server" Width="200px">
        </asp:DropDownList>
    </p>
    <p>
        <asp:Button ID="Btn_Pelicula" runat="server" Text="Película" Width="120px" OnClick="Btn_Pelicula_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DW_Pelicula" runat="server" Width="200px">
        </asp:DropDownList>
    </p>
    <p>
        <asp:Button ID="Btn_Saga" runat="server" Text="Saga" Width="120px" OnClick="Btn_Saga_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DW_Saga" runat="server" Width="200px">
        </asp:DropDownList>
    </p>
    <p>
        <asp:Button ID="Btn_Actuaciones" runat="server" Text="Actuaciones" Width="120px" OnClick="Btn_Actuaciones_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DW_Actuaciones" runat="server" Width="200px">
        </asp:DropDownList>
    </p>
    <p>
        <asp:Button ID="Btn_Privilegios" runat="server" Text="Dar Privilegios" Width="120px" OnClick="Btn_Privilegios_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DW_Privilegios" runat="server" Width="200px">
        </asp:DropDownList>
        <asp:Label ID="err" runat="server" Text="err" Visible="False"></asp:Label>
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bajoCuerpo" runat="server">
</asp:Content>
