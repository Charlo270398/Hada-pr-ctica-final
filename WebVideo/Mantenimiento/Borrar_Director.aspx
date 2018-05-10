<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Borrar_Director.aspx.cs" Inherits="WebVideo.Mantenimiento.Borrar_Director" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cuerpo" runat="server">
    Director:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
    <asp:DropDownList ID="DWDirector" runat="server" AutoPostBack="true" OnInit="DWDirector_Init">
    </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
    <asp:Button ID="Btn_Borrar" runat="server" OnClick="Btn_Borrar_Click" Text="Borrar" />
    <asp:Label ID="Err1" runat="server" ForeColor="Red" Text="ERROR" Visible="False"></asp:Label>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bajoCuerpo" runat="server">
</asp:Content>
