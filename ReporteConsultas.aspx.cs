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
            if (!IsPostBack)
            {
                ControlDiagnostico.ListaControlEnfermedades.Clear();
                ControlDiagnostico.leerJson(Server.MapPath("ControlEnfermedades.json"));
                for (int a = 1; a <= 12; a++)
                {
                    DropDownListMes1.Items.Add(a.ToString());
                    DropDownListMes2.Items.Add(a.ToString());
                }
            }
        }

        protected void btnVer_Click(object sender, EventArgs e)
        {

           

            if (RBEnfermedades.Checked)
            {
                ControlDiagnostico.ListaControlEnfermedades.Clear();
                ControlDiagnostico.leerJson(Server.MapPath("ControlEnfermedades.json"));
                GridViewReporteC.Visible = true;

                GridViewReporteC.DataSource = null;
                GridViewReporteC.DataBind();
                GridViewReporteC.DataSource = ControlDiagnostico.ListaControlEnfermedades.OrderByDescending(x => x.VecesDiagnosticada);
                GridViewReporteC.DataBind();
            }

            else if (RBEdades.Checked)
            {
                Pacientes.listaPacientes.Clear();
                Pacientes.leerJson(Server.MapPath("RegistroPacientes.json"));
                ControlEdad EdadAg = new ControlEdad();
                DateTime hoy = DateTime.Now;

                foreach(var x in Pacientes.listaPacientes)
                {
                    EdadAg.Edad = (hoy.Year - x.FechaNacimiento.Year);
                    ControlEdad.Edades.Add(EdadAg);
                }

                double prom = ControlEdad.Edades.Average(x => x.Edad);
                LabelEdadPromedio.Visible = true;
                LabelEdadPromedio.Text = "La edad promedio de pacientes es: '"+prom+"'";                                           

            }

            else if (RBIngresos.Checked)
            {
                historialPaciente.listaHistorialPciente.Clear();
                historialPaciente.leerJson(Server.MapPath("HisotrialMedico.json"));
                double dinero=0;
                historialPaciente historial = new historialPaciente();
                DatosConsultaAux datos = new DatosConsultaAux();
                foreach (var x in historialPaciente.listaHistorialPciente)
                {
                    for (int recorrido = Convert.ToInt32(DropDownListMes1.SelectedValue); recorrido <= Convert.ToInt32(DropDownListMes2.SelectedValue); recorrido++)
                    {

                        foreach (var a in x.ListaDatosConsulta)
                        {
                            if (a.fechaConsulta.Month == recorrido) { dinero = dinero + a.precioConsulta;  }
                                
                        }

                    }
                }
                LabelEdadPromedio.Visible = true;
                LabelEdadPromedio.Text = "El dinero generado entre ambos meses fue de: " + dinero.ToString();
            }

            else if (RBMedicamentos.Checked)
            {
                ControlMedicamento.ListaControlMedicamentos.Clear();
                ControlMedicamento.leerJson(Server.MapPath("ControlMedicamentos.json"));
                GridViewReporteC.Visible = true;
                GridViewReporteC.DataSource = null;
                GridViewReporteC.DataBind();
                GridViewReporteC.DataSource = ControlMedicamento.ListaControlMedicamentos.OrderByDescending(x => x.VecesRecetada);
                GridViewReporteC.DataBind();
            }
            
            else
            {
                Response.Write("<script>alert('Selecciones Un Caja de Chequep')</script>");
            }
            RBEdades.Checked = false;
            RBEnfermedades.Checked = false;
            RBIngresos.Checked = false;
            RBMedicamentos.Checked = false;
        }

        protected void RBIngresos_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}