using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinalP_PrograIII
{
    public partial class ConsultaNueva : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Pacientes.listaPacientes.Clear();
                Pacientes.leerJson(Server.MapPath("RegistroPacientes.json"));
            }
        }

        protected void ButtonBuscar_Click(object sender, EventArgs e)
        {
            if(!Pacientes.listaPacientes.Exists(x=>x.Nit==TextBoxNit.Text))
            {
                Response.Write("<script>alert('Error: Paciente No Registrado...');</script>");
            }
            else
            {
                ButtonAgregarReceta.Visible = true;
                ButtonAgregarSintoma.Visible = true;
                ButtonGuardarConsulta.Visible = true;
                Validacion.Enabled = true;
            }
        }

        protected void ButtonGuardarConsulta_Click(object sender, EventArgs e)
        {
            
        }
    }
}