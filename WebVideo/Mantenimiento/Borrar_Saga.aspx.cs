using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CAD;
using System.Drawing;
using Clases.EN;

namespace WebVideo.Mantenimiento
{
    public partial class Borrar_Saga : System.Web.UI.Page
    {
        sagaEN saga = new sagaEN();
        List<sagaEN> listaSagas = new List<sagaEN>();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DWSaga_Init(object sender, EventArgs e)
        {
            int i;
            if (DWSaga != null)
            {

                sagaCAD S = new sagaCAD();
                List<String> nombres = new List<string>();
                listaSagas = S.listaSagas();
                for (i = 0; i < listaSagas.Count; i++)
                {
                    nombres.Add(listaSagas[i].Nombre);
                }
                DWSaga.DataSource = nombres;
                DWSaga.DataBind();
                DWSaga.Items.Insert(0, new ListItem("[Seleccionar]", "0"));
            }
            if (DWSaga.Items.Count == 1)
            {
                Btn_Borrar.Visible = false;
                Err1.ForeColor = Color.Red;
                Err1.Visible = true;
                Err1.Text = "No quedan sagas";
            }

        }

        protected void Btn_Borrar_Click(object sender, EventArgs e)
        {
            if (DWSaga.Items.Count == 1)
            {
                Btn_Borrar.Visible = false;
                Err1.ForeColor = Color.Red;
                Err1.Visible = true;
                Err1.Text = "No quedan sagas";
            }
            else
            {
                if (DWSaga.SelectedItem.ToString() != "[Seleccionar]")
                {
                    try
                    {
                        bool stop = false;
                        for (int i = 0; i < listaSagas.Count && !stop; i++)
                        {
                            if (listaSagas[i].Nombre == DWSaga.SelectedItem.ToString())
                            {
                                saga.IDsaga = listaSagas[i].IDsaga;
                                stop = true;
                            }
                        }
                        saga.borrarSaga();
                        Err1.ForeColor = Color.Green;
                        Err1.Visible = true;
                        Err1.Text = "BORRADO CORRECTAMENTE";

                        DWSaga_Init(sender, e);
                    }
                    catch (Exception ex)
                    {
                        Err1.ForeColor = Color.Red;
                        Err1.Visible = true;
                        Err1.Text = ex.Message;
                    }
                }
            }

        }

    }
}