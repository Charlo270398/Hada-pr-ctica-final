<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeFile ="Inicio.aspx.cs" Inherits="WebVideo.Inicio" MaintainScrollPositionOnPostback="true"  %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cuerpo" runat="server">
    <p class="text-center">
    <br />
&nbsp; <strong>&nbsp; </strong><span style="font-size: xx-large"><strong>¡Bienvenido a Hookin!</strong></span><span style="font-size: x-large">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span></p>
    <p class="text-left">
        <asp:ScriptManager ID="ScriptManager1" runat="server">


        </asp:ScriptManager>

    </p>
    <p>
        <span style="font-size: x-large">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</span></p>
    <p>
        <span style="font-size: x-large">Nuestras películas:</span></p>
<p class="text-center">
    &nbsp;</p>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div class="text-center" style="height: 295px">
                <asp:Timer ID="Timer1" runat="server" OnTick="Timer1_Tick" Interval="2000">
                </asp:Timer>
                <strong>
                <asp:Label ID="Titulo" runat="server" style="font-size: x-large" Text="Título"></asp:Label>
                <br />
                <br />
                </strong>
                <asp:Image ID="Imagen" runat="server" BorderStyle="Groove" BorderWidth="10px" OnInit="Imagen_Init" Width="400px" Height="550px" />
                <br />
                <asp:HyperLink ID="HyperLink" runat="server">Ver película</asp:HyperLink>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
<p class="text-center">
    &nbsp;</p>
<p class="text-center">
    &nbsp;</p>
<p class="text-center">
    &nbsp;</p>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bajoCuerpo" runat="server">
</asp:Content>
