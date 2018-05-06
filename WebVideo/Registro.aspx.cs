using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CAD;

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
           
        }
        
        protected void DWPais_SelectedIndexChanged(object sender, EventArgs e)
        {

            

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

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

       

        protected void DWPais_Init(object sender, EventArgs e)
        {
            if (DWPais != null)
            {
                paisCAD pais = new paisCAD();
                DWPais.DataSource = Consultar("SELECT Pais FROM Paises");
                DWPais.DataBind();
                DWPais.Items.Insert(0, new ListItem("[Seleccionar]", "0"));
                TextBox2.Text = pais.mostrarNombrePais(160).Pais;
            }

        }
    }
}