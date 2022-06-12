using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinalP_PrograIII
{
    public partial class ReporteConsultas : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnVer_Click(object sender, EventArgs e)
        {

           

            if (RBEnfermedades.Checked)
            {
               ControlDiagnostico.leerJson(Server.MapPath("ControlEnfermedades.json"));
                GridViewReporteC.Visible = true;
                GridViewReporteC.DataSource = ControlDiagnostico.ListaControlEnfermedades; 
            }

            if (RBEdades.Checked)
            {
                LabelEdadPromedio.Visible = true;
                Pacientes paciente = new Pacientes();
                LabelEdadPromedio.Text = "La edad promedio de pacientes es: ";
                    
                

            }

            if (RBIngresos.Checked)
            {

            }

            if (RBMedicamentos.Checked)
            {
                ControlMedicamento.leerJson(Server.MapPath("ControlMedicamentos.json"));
                GridViewReporteC.Visible = true;
                GridViewReporteC.DataSource = ControlMedicamento.ListaControlMedicamentos;
            }
        }
    }
}