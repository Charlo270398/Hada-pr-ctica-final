<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Cambiar_Datos.aspx.cs" Inherits="WebVideo.Area_Cliente.Cambiar_Datos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cuerpo" runat="server">
    <p>
        <asp:Label ID="Contraseña1Text" runat="server" BackColor="White" BorderColor="White" ForeColor="Black" Text="Introduzca su nuevo nombre"></asp:Label>
    &nbsp;<asp:TextBox ID="Text_nombre" runat="server" CssClass="mdl-textfield__input"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Contraseña2Text" runat="server" BackColor="White" BorderColor="White" ForeColor="Black" Text="Introduzca sus nuevos apellidos"></asp:Label>
    &nbsp;
        <asp:TextBox ID="Text_apellidos" runat="server" CssClass="mdl-textfield__input"></asp:TextBox>
    </p>
    <p>
        Introduzca su nuevo país:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DWPais" runat="server" AutoPostBack="true" OnInit="DWPais_Init">
        </asp:DropDownList>
        </p>
    <p>
        <asp:Button ID="Btn_Cambiar" runat="server" OnClick="BTN_CAMBIARC" Text="Cambiar datos" />
        <asp:Label ID="Err" runat="server" BackColor="White" BorderColor="White" ForeColor="Red" style="font-style: italic" Text="*Campos vacíos" Visible="False"></asp:Label>
    </p>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bajoCuerpo" runat="server">
</asp:Content>
