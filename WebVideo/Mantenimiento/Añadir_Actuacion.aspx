<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Añadir_Actuacion.aspx.cs" Inherits="WebVideo.Mantenimiento.Añadir_Actuacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cuerpo" runat="server">
    Actor:&nbsp; &nbsp;&nbsp;
    <asp:DropDownList ID="DWActor" runat="server" AutoPostBack="true">
    </asp:DropDownList>
&nbsp;&nbsp;&nbsp; Película:&nbsp;&nbsp;&nbsp;
    <asp:DropDownList ID="DWPelicula" runat="server" AutoPostBack="true" OnInit="DWactuacion_init">
    </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Btn_Insertar1" runat="server" OnClick="Btn_Añadir_Click" Text="Insertar" />
    <asp:Label ID="Err1" runat="server" ForeColor="Red" Text="ERROR" Visible="False"></asp:Label>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bajoCuerpo" runat="server">
</asp:Content>
