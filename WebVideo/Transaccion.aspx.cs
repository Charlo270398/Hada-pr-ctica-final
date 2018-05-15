using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Clases.EN;
using System.Drawing;
using System.Net.Mail;

namespace WebVideo
{
    public partial class Transaccion : System.Web.UI.Page
    {
        peliculaEN pelicula = new peliculaEN();
        usuarioEN user = new usuarioEN();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                user = (usuarioEN)Session["user_session_data"];
                int id;
                int.TryParse(Request.QueryString["id"], out id);
                pelicula.IdP = id;
                pelicula = pelicula.mostrarPelicula();
                double precio;
                precio = pelicula.PrecioC / 100 + 0.00;
                PrecioC.Text = precio.ToString() + "€";
                precio = pelicula.PrecioA / 100 + 0.00;
                PrecioA.Text = precio.ToString() + "€";
                Fecha.Text = (DateTime.Now).AddDays(7).ToString().Substring(0,11);

            }
            catch (Exception)
            {
                Response.Redirect("Pagina_Error.aspx");
            }
        }

        protected void Btn_Alquilar_Click(object sender, EventArgs e)
        {
            try
            {
                transaccionPeliculaEN trans = new transaccionPeliculaEN(pelicula.IdP, user.Email);
                trans.alquilarPelicula();
                Err.Visible = true;
                Err.Text = "Transaccion completada";
                Err.ForeColor = Color.Green;

                SmtpClient cliente = new SmtpClient("smtp.gmail.com", 587);
                cliente.EnableSsl = true;
                cliente.Credentials = new System.Net.NetworkCredential("hookinVideoclub@gmail.com", "hookin123");
                double precio;
                precio = pelicula.PrecioA / 100 + 0.00;
                string contenido = "Hola, " + user.Nombre + ". Le informamos de que su última compra acaba de ser validada. \nPelícula: " + pelicula.NombreP + "\n";
                contenido += "Tipo de compra: Alquiler \n";
                contenido += "Fecha de compra: " + (DateTime.Now).ToString() + "\n";
                contenido += "Fecha de devolución: " + (DateTime.Now).AddDays(7).ToString() + "\n";
                contenido += "Precio total: " + precio.ToString() + "€\n";
                contenido += "Puede comprobar su compra en la aplicación de Hookin.\n\n";
                contenido += "El equipo de Cuentas de Hookin";
                MailMessage mail = new MailMessage("hookinVideoclub@gmail.com", user.Email, "Factura de compra", contenido);
                cliente.Send(mail);
            }

            catch (Exception ex)
            {
                Err.Visible = true;
                Err.Text = ex.Message;
                Err.ForeColor = Color.Red;
            }

}

        protected void Btn_Comprar_Click(object sender, EventArgs e)
        {
            try
            {
                transaccionPeliculaEN trans = new transaccionPeliculaEN(pelicula.IdP, user.Email);
                trans.comprarPelicula();
                Err.Visible = true;
                Err.Text = "Transaccion completada";
                Err.ForeColor = Color.Green;
                
                SmtpClient cliente = new SmtpClient("smtp.gmail.com",587);
                cliente.EnableSsl = true;
                cliente.Credentials = new System.Net.NetworkCredential("hookinVideoclub@gmail.com", "hookin123");
                double precio;
                precio = pelicula.PrecioC / 100 + 0.00;
                string contenido = "Hola, " + user.Nombre + ". Le informamos de que su última compra acaba de ser validada. \nPelícula: " + pelicula.NombreP + "\n";
                contenido += "Tipo de compra: Compra estándar \n";
                contenido += "Fecha de compra: " + (DateTime.Now).ToString() + "\n";
                contenido += "Precio total: " + precio.ToString() + "€\n";
                contenido += "Puede comprobar su compra en la aplicación de Hookin.\n\n";
                contenido += "El equipo de Cuentas de Hookin";
                MailMessage mail = new MailMessage("hookinVideoclub@gmail.com", user.Email, "Factura de compra", contenido);
                cliente.Send(mail);

            }
            catch(Exception ex)
            {
                Err.Visible = true;
                Err.Text = ex.Message;
                Err.ForeColor = Color.Red;
            }
        }
    }
}