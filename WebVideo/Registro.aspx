<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="WebVideo.Registro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cuerpo" runat="server">
    <p style="font-size: xx-large" align="center">
        ¡Regístrate para pertenecer a la comunidad Hookin!</p>
    <p>
        Introduzca los siguientes datos
    </p>
    <p>
        Email:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="Text_Email" runat="server" OnTextChanged="IN_EMAIL"></asp:TextBox>
    </p>
    <p>
        Contraseña:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="Text_Cnt" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
    </p>
    <p>
        Repetir Contraseña:
        <asp:TextBox ID="Text_Rcnt" runat="server"></asp:TextBox>
    </p>
    <p>
        Nombre:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <asp:TextBox ID="Text_nom" runat="server"></asp:TextBox>
    </p>
    <p>
        Apellidos:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="Text_ap" runat="server"></asp:TextBox>
    </p>
    <p>
        País:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
        <asp:DropDownList ID="DWPais" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DWPais_SelectedIndexChanged" OnInit="DWPais_Init">
        </asp:DropDownList>
    </p>
    <p>
        &nbsp;</p>
    <p>
        Acepto los 
        <asp:HyperLink ID="TC" runat="server" NavigateUrl="~/Terminos.aspx">Términos y Condiciones de Servicio</asp:HyperLink>: <asp:CheckBox ID="Terminos" runat="server" /></p>
    <p>
        <asp:Button ID="Button1" runat="server" OnClick="BTN_CREAR" Text="Crear usuario" />
    </p>
    <p>
        &nbsp;</p>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bajoCuerpo" runat="server">
</asp:Content>
