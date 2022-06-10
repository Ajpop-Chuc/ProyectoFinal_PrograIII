using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinalP_PrograIII
{
    public partial class OpcionesSintoma : System.Web.UI.Page
    {
        static string archivo;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                archivo = Server.MapPath("DatosSintomas.json");
                Sintomas.listaSintomas.Clear();
                Sintomas.leerJson(archivo);
            }
        }

        protected void ButtonAgregarSintoma_Click(object sender, EventArgs e)
        {
            Sintomas sintoma = new Sintomas();
            sintoma.codigoSintoma = TextBoxCodigoSintoma.Text;
            sintoma.DescripcionSintoma = TextBoxDescripcionSintoma.Text;
            Sintomas.listaSintomas.Add(sintoma);
            Response.Write("<script>alert('Sintoma Ingresado Correctamente')</script>");
            Sintomas.guardarenJson(archivo);
            Limpiar();
        }

        protected void ButtonBuscarSintoma_Click(object sender, EventArgs e)
        {
            Sintomas sintoma = Sintomas.listaSintomas.Find(x => x.codigoSintoma == TextBoxCodigoSintoma.Text);
            if (sintoma != null)
            {
                TextBoxCodigoSintoma.Text = sintoma.codigoSintoma;
                TextBoxDescripcionSintoma.Text = sintoma.DescripcionSintoma;
                ValidacionCodigoS.Enabled = true;
            }
            else
            {
                Response.Write("<script>alert('Sintoma No Ingresado ')</script>");
            }
        }

        protected void ButtonActualizarSintoma_Click(object sender, EventArgs e)
        {
            Sintomas sintoma = Sintomas.listaSintomas.Find(x => x.codigoSintoma == TextBoxCodigoSintoma.Text);
            sintoma.codigoSintoma = TextBoxCodigoSintoma.Text;
            sintoma.DescripcionSintoma = TextBoxDescripcionSintoma.Text;
            Response.Write("<script>alert('Sintoma Actualizado Correctamente')</script>");
            Sintomas.guardarenJson(archivo);
            Limpiar();
        }

        protected void Limpiar()
        {
            TextBoxCodigoSintoma.Text = "";
            TextBoxDescripcionSintoma.Text = "";
        }
    }
}