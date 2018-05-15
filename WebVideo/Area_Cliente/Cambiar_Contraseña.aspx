<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Cambiar_Contraseña.aspx.cs" Inherits="WebVideo.Area_Cliente.Cambiar_Contraseña" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cuerpo" runat="server">
    <p>
        <br />
        <asp:Label ID="Contraseña1Text" runat="server" BackColor="White" BorderColor="White" ForeColor="Black" Text="Introduzca su contraseña actual:"></asp:Label>
    &nbsp;<asp:TextBox ID="Text_Pass0" runat="server" CssClass="mdl-textfield__input" TextMode="Password"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Contraseña2Text" runat="server" BackColor="White" BorderColor="White" ForeColor="Black" Text="Introduzca la nueva contraseña:"></asp:Label>
    &nbsp;
        <asp:TextBox ID="Text_Pass1" runat="server" CssClass="mdl-textfield__input" TextMode="Password"></asp:TextBox>
    </p>
    <p class="text-left">
        <asp:Label ID="Contraseña1Text1" runat="server" BackColor="White" BorderColor="White" ForeColor="Black" Text="Repita la nueva contraseña:"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="Text_Pass2" runat="server" CssClass="mdl-textfield__input" TextMode="Password"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="Btn_Cambiar" runat="server" OnClick="BTN_CAMBIARC" Text="Cambiar contraseña" />
        <asp:Label ID="Err" runat="server" BackColor="White" BorderColor="White" ForeColor="Red" style="font-style: italic" Text="*Debe aceptar los términos" Visible="False"></asp:Label>
    </p>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bajoCuerpo" runat="server">
</asp:Content>
