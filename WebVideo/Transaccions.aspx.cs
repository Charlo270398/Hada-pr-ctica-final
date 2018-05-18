using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Clases.EN;
using System.Drawing;
using System.Net.Mail;
using Clases.CAD;
namespace WebVideo
{
    public partial class Transaccions : System.Web.UI.Page
    {
        serieEN serie = new serieEN();
        usuarioEN user = new usuarioEN();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                user = (usuarioEN)Session["user_session_data"];
                int id;
                int.TryParse(Request.QueryString["id"], out id);
                double precio;
                serieCAD p = new serieCAD();
                serie = new serieEN(id, "");
                serie = p.mostrarSerie(serie);
                precio = serie.PrecioC / 100;
                Fecha.Text = (DateTime.Now).AddDays(7).ToString().Substring(0, 11);
                PrecioC.Text = precio.ToString() + "€";
                precio = serie.PrecioA / 100;
                PrecioA.Text = precio.ToString() + "€";
            }
            catch (Exception ex)
            {
                Response.Redirect("Pagina_Error.aspx?err=" + ex.Message);
            }
        }

        protected void Btn_Alquilar_Click(object sender, EventArgs e)
        {
            try
            {
                transaccionSerieEN trans = new transaccionSerieEN(serie.IdS, user.Email);
                trans.alquilarSerie();
                Err.Visible = true;
                Err.Text = "Transaccion completada";
                Err.ForeColor = Color.Green;

                SmtpClient cliente = new SmtpClient("smtp.gmail.com", 587);
                cliente.EnableSsl = true;
                cliente.Credentials = new System.Net.NetworkCredential("hookinVideoclub@gmail.com", "hookin123");
                double precio;
                precio = serie.PrecioA / 100 + 0.00;
                string contenido = "Hola, " + user.Nombre + ". Le informamos de que su última compra acaba de ser validada. \nSerie: " + serie.Titulo + "\n";
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
                transaccionSerieEN trans = new transaccionSerieEN(serie.IdS, user.Email);
                trans.comprarSerie();
                Err.Visible = true;
                Err.Text = "Transaccion completada";
                Err.ForeColor = Color.Green;
                
                SmtpClient cliente = new SmtpClient("smtp.gmail.com",587);
                cliente.EnableSsl = true;
                cliente.Credentials = new System.Net.NetworkCredential("hookinVideoclub@gmail.com", "hookin123");
                double precio;
                precio = serie.PrecioC / 100 + 0.00;
                string contenido = "Hola, " + user.Nombre + ". Le informamos de que su última compra acaba de ser validada. \nSerie: " + serie.Titulo + "\n";
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