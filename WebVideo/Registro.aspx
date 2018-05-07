<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="WebVideo.Registro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cuerpo" runat="server">
    <p style="font-size: xx-large" align="center">
        ¡Regístrate para pertenecer a la comunidad Hookin!</p>
    <p>
        Introduzca los siguientes datos
    </p>
    <p>
        Email:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="Text_Email" runat="server" OnTextChanged="Email_Cambio" OnDataBinding="Text_Email_DataBinding"></asp:TextBox>
        <asp:Label ID="EmailErr" runat="server" BackColor="White" BorderColor="White" ForeColor="Red" style="font-style: italic" Text="*Campo vacío" Visible="False"></asp:Label>
    </p>
    <p>
        Contraseña:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="Text_Cnt" runat="server" CssClass="mdl-textfield__input" TextMode="Password" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
        <asp:Label ID="CntErr" runat="server" BackColor="White" BorderColor="White" ForeColor="Red" style="font-style: italic" Text="*Campo vacío" Visible="False"></asp:Label>
    </p>
    <p>
        Repetir Contraseña:
        <asp:TextBox ID="Text_Rcnt" runat="server" CssClass="mdl-textfield__input" TextMode="Password"></asp:TextBox>
        <asp:Label ID="RcntErr" runat="server" BackColor="White" BorderColor="White" ForeColor="Red" style="font-style: italic" Text="*Campo vacío" Visible="False"></asp:Label>
    </p>
    <p>
        Nombre:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <asp:TextBox ID="Text_nom" runat="server"></asp:TextBox>
        <asp:Label ID="NombreErr" runat="server" BackColor="White" BorderColor="White" ForeColor="Red" style="font-style: italic" Text="*Campo vacío" Visible="False"></asp:Label>
    </p>
    <p>
        Apellidos:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="Text_ap" runat="server"></asp:TextBox>
        <asp:Label ID="ApellidosErr" runat="server" BackColor="White" BorderColor="White" ForeColor="Red" style="font-style: italic" Text="*Campo vacío" Visible="False"></asp:Label>
    </p>
    <p>
        País:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
        <asp:DropDownList ID="DWPais" runat="server" AutoPostBack="true" OnInit="DWPais_Init">
        </asp:DropDownList>
        <asp:Label ID="PaisErr" runat="server" BackColor="White" BorderColor="White" ForeColor="Red" style="font-style: italic" Text="*País sin seleccionar" Visible="False"></asp:Label>
    </p>
    <p>
        &nbsp;</p>
    <p>
        Acepto los 
        <asp:HyperLink ID="TC" runat="server" NavigateUrl="~/Terminos.aspx">Términos y Condiciones de Servicio</asp:HyperLink>: <asp:CheckBox ID="Terminos" runat="server" />
        <asp:Label ID="TerminosErr" runat="server" BackColor="White" BorderColor="White" ForeColor="Red" style="font-style: italic" Text="*Debe aceptar los términos" Visible="False"></asp:Label>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" OnClick="BTN_CREAR" Text="Crear usuario" />
    </p>
    <p>
        &nbsp;</p>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bajoCuerpo" runat="server">
</asp:Content>
