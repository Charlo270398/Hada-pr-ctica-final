using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebVideo
{
    public partial class Registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
    
        }

        protected void CreateUserWizard1_CreatedUser(object sender, EventArgs e)
        {

        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Consultar("SELECT Pais FROM Paises where Id_pais = 97");
            TextBox2.Text = Consultar("SELECT Pais FROM Paises")[0];
            DWPais.DataSource = Consultar("SELECT Pais FROM Paises");
            DWPais.DataBind();
            DWPais.Items.Insert(0, new ListItem("[Seleccionar]", "0"));
        }

        protected void DWPais_SelectedIndexChanged(object sender, EventArgs e)
        {
     
            DWPais.DataSource = Consultar("SELECT Pais FROM Paises");
            DWPais.DataTextField = "Pais";
            DWPais.DataValueField = "PaisID";
            DWPais.DataBind();
            DWPais.Items.Insert(0, new ListItem("[Seleccionar]", "0"));
            
        }

        public List<string> Consultar (string comando)
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["bbdd"].ToString());
            cn.Open();
            SqlCommand cmd = new SqlCommand(comando, cn);
            var reader = cmd.ExecuteReader();
            List <string> s = new List<string>();
            while(reader.Read())
            {
                 s.Add(reader["Pais"].ToString());
            }
            reader.Close();
            cn.Close();
            return s;
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList1.DataSource = Consultar("SELECT Pais FROM Paises");
            DropDownList1.DataTextField = "Pais";
            DropDownList1.DataValueField = "PaisID";
            DropDownList1.DataBind();
            DropDownList1.Items.Insert(0, new ListItem("[Seleccionar]", "0"));
        }
    }
}