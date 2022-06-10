using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinalP_PrograIII
{
	public partial class HistorialMedico : System.Web.UI.Page
	{
        static historialPaciente historialConsultas;
        static DatosConsultaAux datosConsultaAux = new DatosConsultaAux();
        static RecetaAux recetaAux = new RecetaAux();
        protected void Page_Load(object sender, EventArgs e)
		{
            if (!IsPostBack)
            {
                Pacientes.listaPacientes.Clear();
                Pacientes.leerJson(Server.MapPath("RegistroPacientes.json"));
                Sintomas.listaSintomas.Clear();
                Sintomas.leerJson(Server.MapPath("DatosSintomas.json"));
                Medicamentos.listaMedicamentos.Clear();
                Medicamentos.leerJson(Server.MapPath("DatosMedicamentos.json"));
                historialPaciente.listaHistorialPciente.Clear();
                historialPaciente.leerJson(Server.MapPath("HisotrialMedico.json"));
            }
        }
        protected void ButtonBuscar_Click1(object sender, EventArgs e)
        {
            historialConsultas = historialPaciente.listaHistorialPciente.Find(x => x.NitPaciente == TextBoxNit.Text);
            if (historialConsultas == null)
            {
                Response.Write("<script>alert('El Paciente No Tinene Consultas Previas')</script>");
            }
            else {
                foreach (var x in historialConsultas.ListaDatosConsulta)
                {
                    DropDownListCitas.Items.Add(x.idConsulta.ToString());
                }
            }
            
        }
      
        protected void ButtonVisualizar_Click(object sender, EventArgs e)
        {
            datosConsultaAux = historialConsultas.ListaDatosConsulta.Find(x => x.idConsulta == DropDownListCitas.Text);
            TextBoxFecha.Text = datosConsultaAux.fechaConsulta.ToString();
            TextBoxHorario.Text = datosConsultaAux.horaCita;
            TextBoxTemperatura.Text = datosConsultaAux.Temperatura;
            TextBoxPresión.Text = datosConsultaAux.Presion;
            GridViewSintomas.DataSource = null;
            GridViewSintomas.DataBind();
            GridViewSintomas.DataSource = datosConsultaAux.Sintomas;
            GridViewSintomas.DataBind();
            TextBoxDiagnostico.Text = datosConsultaAux.Diagnostico;
            TextBoxTratamiento.Text = datosConsultaAux.Tratamiento;
            GridViewReceta.DataSource = null;
            GridViewReceta.DataBind();
            GridViewReceta.DataSource = datosConsultaAux.Receta;
            GridViewReceta.DataBind();
            //fotos
        }
        protected void ButtonBuscar_Click(object sender, EventArgs e)
        {

        }

        protected void GridViewImagenes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}