<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Añadir_Director.aspx.cs" Inherits="WebVideo.Mantenimiento.Añadir_Director" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cuerpo" runat="server">
    Nombre:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:Label ID="Err" runat="server" ForeColor="Red" Text="ERROR" Visible="False"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
    Apellidos:&nbsp; &nbsp;&nbsp;
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <asp:Label ID="Err0" runat="server" ForeColor="Red" Text="ERROR" Visible="False"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
    País:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <asp:DropDownList ID="DWPais" runat="server" AutoPostBack="true" OnInit="DWPais_Init">
        </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
    <asp:Button ID="Btn_Insertar1" runat="server" OnClick="Btn_Añadir_Click" Text="Insertar" />
    <asp:Label ID="Err1" runat="server" ForeColor="Red" Text="ERROR" Visible="False"></asp:Label>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bajoCuerpo" runat="server">
</asp:Content>
