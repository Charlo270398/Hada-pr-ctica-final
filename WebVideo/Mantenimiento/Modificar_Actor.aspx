<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Modificar_Actor.aspx.cs" Inherits="WebVideo.Mantenimiento.Modificar_Actor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cuerpo" runat="server">
    Actor:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:DropDownList ID="DWActor" runat="server" AutoPostBack="true" OnInit="DWActor_Init">
    </asp:DropDownList>
    &nbsp;
    <br />
    Nombre:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:Label ID="ErrN" runat="server" ForeColor="Red" Text="ERROR" Visible="False"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />Apellidos:&nbsp; &nbsp;&nbsp;
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <asp:Label ID="ErrA" runat="server" ForeColor="Red" Text="ERROR" Visible="False"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />Fecha nacimiento:&nbsp; &nbsp;&nbsp;
    <asp:DropDownList ID="DWdia" runat="server" AutoPostBack="true" OnInit="DWPais_Init">
    </asp:DropDownList>
    <asp:DropDownList ID="DWmes" runat="server" AutoPostBack="true" OnInit="DWPais_Init">
    </asp:DropDownList>
    <asp:DropDownList ID="DWaño" runat="server" AutoPostBack="true" OnInit="DWPais_Init">
    </asp:DropDownList>
    <asp:Label ID="ErrF" runat="server" ForeColor="Red" Text="ERROR" Visible="False"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;
    <br />País:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; 
    <asp:DropDownList ID="DWPais" runat="server" AutoPostBack="true" OnInit="DWPais_Init">
    </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
    <asp:Button ID="Btn_Modificar1" runat="server" OnClick="Btn_Modificar_Click" Text="Modificar" />
    <asp:Label ID="ErrM" runat="server" ForeColor="Red" Text="ERROR" Visible="False"></asp:Label>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bajoCuerpo" runat="server">
</asp:Content>
