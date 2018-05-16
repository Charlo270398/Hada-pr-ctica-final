<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Borrar_Serie.aspx.cs" Inherits="WebVideo.Mantenimiento.Borrar_Serie" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cuerpo" runat="server">
    <p>
        Serie:&nbsp;&nbsp;
        <asp:DropDownList ID="DWSeries" runat="server" AutoPostBack="true" OnInit="DWSeries_Init">
        </asp:DropDownList>
&nbsp;&nbsp;
        <asp:Button ID="Btn_Borrar" runat="server" Text="Borrar" OnClick="Btn_Borrar_Click" />
        <asp:Label ID="Err" runat="server" ForeColor="Red" Text="ERROR" Visible="False"></asp:Label>
    </p>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bajoCuerpo" runat="server">
</asp:Content>
