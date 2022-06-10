using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinalP_PrograIII
{
    public partial class ConsultaNueva : System.Web.UI.Page
    {
        static historialPaciente ConsultaPaciente;
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

        protected void ButtonBuscar_Click(object sender, EventArgs e)
        {
            if (!Pacientes.listaPacientes.Exists(x => x.Nit == TextBoxNit.Text))
            {
                Response.Write("<script>alert('Error: Paciente No Registrado...');</script>");
            }
            else
            {
                ButtonAgregarReceta.Visible = true;
                ButtonAgregarSintoma.Visible = true;
                ButtonGuardarConsulta.Visible = true;
                Validacion1.Enabled = true;
                Validacion2.Enabled = true;
                Validacion3.Enabled = true;

                ConsultaPaciente = historialPaciente.listaHistorialPciente.Find(x => x.NitPaciente == TextBoxNit.Text);
                if (ConsultaPaciente == null)
                {
                    ConsultaPaciente = new historialPaciente();
                }

                cargarDDownList();
            }
        }
        protected void ButtonAgregarSintoma_Click(object sender, EventArgs e)
        {
            datosConsultaAux.Sintomas.Add(DropDownListSintomas.SelectedItem.ToString());
        }
        protected void ButtonAgregarReceta_Click(object sender, EventArgs e)
        {
            recetaAux.Medicamento = DropDownListMedicamento.SelectedItem.ToString();
            recetaAux.Dosis = TextBoxDosis.Text;
            recetaAux.HorarioAdmin = TextBoxHorarioAdmin.Text;
            datosConsultaAux.Receta.Add(recetaAux);
            recetaAux = new RecetaAux();
            TextBoxDosis.Text = "";
            TextBoxHorarioAdmin.Text = "";
        }
        protected void ButtonGuardarConsulta_Click(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now;

            datosConsultaAux.idConsulta = cracionIdCita();
            datosConsultaAux.fechaConsulta = fecha.Date;
            datosConsultaAux.horaCita = (fecha.Hour).ToString();
            datosConsultaAux.Temperatura = TextBoxTemperatura.Text;
            datosConsultaAux.Presion = TextBoxPresión.Text;
            //sintomas -> ya
            datosConsultaAux.Diagnostico = TextBoxDiagnostico.Text;
            datosConsultaAux.Tratamiento = TextBoxTratamiento.Text;
            //recetas -> ya
            datosConsultaAux.precioConsulta = Convert.ToDouble(TextBoxCosto.Text);
            string archivo = "~/imagenes/" + FileUploadImagen.FileName;
            datosConsultaAux.ImgenesConsulta.Add(archivo);

            ConsultaPaciente.NitPaciente = TextBoxNit.Text;
            ConsultaPaciente.ListaDatosConsulta.Add(datosConsultaAux);

            if (historialPaciente.listaHistorialPciente.Find(x => x.NitPaciente == TextBoxNit.Text) == null)
            {
                historialPaciente.listaHistorialPciente.Add(ConsultaPaciente);
            }

            historialPaciente.guardarenJson(Server.MapPath("HisotrialMedico.json"));
            ConsultaPaciente = new historialPaciente();
            limpiar();
        }



        protected void cargarDDownList()
        {
            foreach (var x in Sintomas.listaSintomas)
            {
                DropDownListSintomas.Items.Add(x.codigoSintoma);
            }
            foreach (var x in Medicamentos.listaMedicamentos)
            {
                DropDownListMedicamento.Items.Add(x.codigoMedicamento);
            }
        }
        protected void DropDownListMedicamento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void guardarImgen()
        {
            string archivoOrigen = Path.GetFileName(FileUploadImagen.FileName);
            try
            {
                FileUploadImagen.SaveAs(Server.MapPath("~/imagenes/") + archivoOrigen);
            }
            catch
            {

            }
        }

        protected void limpiar()
        {
            TextBoxNit.Text = "";
            TextBoxTemperatura.Text = "";
            TextBoxPresión.Text = "";
            TextBoxDiagnostico.Text = "";
            TextBoxTratamiento.Text = "";
            TextBoxCosto.Text = "";
        }

        protected string cracionIdCita()
        {
            string ID = "";
            bool exitencia = true;
            historialPaciente paciente = new historialPaciente();
            paciente = historialPaciente.listaHistorialPciente.Find(x => x.NitPaciente==TextBoxNit.Text);

                for (char letra = 'A'; letra <= 'Z'; letra++)
                {
                    for (int entero = 1; entero <= 5; entero++)
                    {
                        for (int entero2 = 10; entero2 >= 5; entero2--)
                        {
                            ID = paciente.NitPaciente+letra.ToString() + entero.ToString() + entero2.ToString();

                            if (paciente.ListaDatosConsulta.Exists(x => x.idConsulta == ID))
                            { }

                            else { exitencia = false;  break;}
                        }
                        if (exitencia == false)
                        { break; }
                    }
                    if (exitencia==false)
                    { break; }
                }
                        

            return ID;
        }
    }
}