<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebVideo.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cuerpo" runat="server">
    <span style="font-size: large"><strong>
<br />
</strong>I<span style="font-weight: bold">ntroduce tu email y contraseña:</span></span><p>
    &nbsp;</p>
<p>
        Email:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="Text_Email" runat="server"></asp:TextBox>
    <asp:Label ID="EmailErr" runat="server" BackColor="White" BorderColor="White" ForeColor="Red" style="font-style: italic" Text="*Campo vacío" Visible="False"></asp:Label>
</p>
<p>
        Contraseña:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="Text_Pass" runat="server" CssClass="mdl-textfield__input" TextMode="Password"></asp:TextBox>
    <asp:Label ID="PassErr" runat="server" BackColor="White" BorderColor="White" ForeColor="Red" style="font-style: italic" Text="*Campo vacío" Visible="False"></asp:Label>
</p>
<p>
    &nbsp;</p>
    <p>
        <asp:Button ID="Btn_Login" runat="server" OnClick="BTN_LOGIN" Text="Crear usuario" />
        <asp:Label ID="Err" runat="server" BackColor="White" BorderColor="White" ForeColor="Red" style="font-style: italic" Text="*Debe aceptar los términos" Visible="False"></asp:Label>
    </p>
    <p>
        &nbsp;</p>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bajoCuerpo" runat="server">
</asp:Content>
