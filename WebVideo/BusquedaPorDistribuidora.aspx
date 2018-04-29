<%@ Page Language="C#" %>

<!DOCTYPE html>
<html lang="en" xmlns="http://www.w3.org/1999/xhtml">

  <head runat="server">
    <title>Videoclub 2018: HADA es otra película!</title>
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <meta content="text/html; charset=UTF-8" http-equiv="Content-Type" />
    <link rel="stylesheet" href="css/bootstrap.css" />
    <link rel="stylesheet" href="css/bootstrap-responsive.css" />
    <link rel="stylesheet" href="css/style.css" />
    <script src="js/jquery.min.js" type="text/javascript"></script>
    <script src="js/bootstrap.min.js" type="text/javascript"></script>
  </head>
  
  <body><form id="form1" runat="server">
    <div class="navbar navbar-fixed-top">
      <div class="navbar-inner">
        <div class="container">
          <a class="brand" href="#">Hookin</a>
          <a></a>
          <div class="usuario pull-left">
              Tu videoclub online</div>
          <div class="navbar-content">
            <ul class="nav  pull-right">
              <li>
              <asp:HyperLink ID="menuInicio" runat="server" NavigateUrl="inicio.aspx">Sobre Nosotros</asp:HyperLink> 
              </li>
              <li>
                <asp:HyperLink ID="menuPeliculas" runat="server" NavigateUrl="peliculas.aspx">Salir</asp:HyperLink> 
              </li>   
              <li>
              </li>
              <li>
              </li>
              <li>
              </li>
              <li>
              </li>          
            </ul>
            <ul class="nav  pull-right">
              <li>
              </li>
            </ul>
            <ul class="nav  pull-right">
              <li>
              <asp:HyperLink ID="menuInicio0" runat="server" NavigateUrl="Busquedas.aspx">Búsquedas</asp:HyperLink> 
              </li>
            </ul>
            <ul class="nav  pull-right">
              <li>
              <asp:HyperLink ID="menuInicio1" runat="server" NavigateUrl="inicio.aspx">Peliculas</asp:HyperLink> 
              </li>
              <li>
              <asp:HyperLink ID="menuInicio2" runat="server" NavigateUrl="Series\Series_index.aspx">Series</asp:HyperLink> 
              </li>
            </ul>
            <ul class="nav  pull-right">
              <li>
              <asp:HyperLink ID="menuInicio3" runat="server" NavigateUrl="inicio.aspx">Inicio</asp:HyperLink> 
              </li>
            </ul>
          </div>
        </div>
      </div>
    </div>
    <div><br /><br /><br /></div>



    <div class="container">

    

    <asp:Panel ID="globoInicioSesion" runat="server">
      <div class="alert alert-info hidden-phone">
        <div class="pull-right form-inline" id="formInicioSesion">
            <asp:Label ID="Label2" runat="server" Text="Distribuidora:" />
            <asp:TextBox ID="passTextBox" runat="server" CssClass="input-medium" TextMode="Password" />
            
            <asp:CheckBox ID="Label1" runat="server" Text="Peliculas" />
            <asp:CheckBox ID="Label3" runat="server" Text="Series" />
            <asp:CheckBox ID="Label4" runat="server" Text="Otros" />
          </div>

          <asp:Button ID="accederButton" runat="server" CssClass="btn" onclick="accederButton_Click" Text="Iniciar Sesión" Width="83px" />
          <asp:Button ID="nuevoUsuarioButton" runat="server" CssClass="btn" onclick="nuevoUsuarioButton_Click" Text="Registrarse" Width="73px" />

      </div>
    </asp:Panel>
        Resultados de búsqueda...<br />&nbsp;<br /><br />
    <br /><br />

    
    
    </div>
  </form></body>

</html>
