<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Borrar_Dist.aspx.cs" Inherits="WebVideo.Mantenimiento.Borrar_Dist" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cuerpo" runat="server">
    <br />
    <br />
    <br />
&nbsp;&nbsp;&nbsp;&nbsp; Distribuidora:&nbsp;<asp:DropDownList ID="DWDist" runat="server" AutoPostBack="true" OnInit="DWDist_Init">
    </asp:DropDownList>
    &nbsp;
&nbsp;<asp:Button ID="Btn_Borrar" runat="server" OnClick="Btn_Borrar_Click" Text="Borrar" />
    &nbsp;
    <asp:Label ID="Err" runat="server" ForeColor="Red" Text="ERROR" Visible="False"></asp:Label>
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bajoCuerpo" runat="server">
    </asp:Content>


