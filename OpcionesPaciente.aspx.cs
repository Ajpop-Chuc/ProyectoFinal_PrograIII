using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinalP_PrograIII
{
    public partial class OpcionesPaciente : System.Web.UI.Page
    {
        static string archivo;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                archivo = Server.MapPath("RegistroPacientes.json");
                Pacientes.listaPacientes.Clear();
                Pacientes.leerJson(archivo);
            }
        }


        protected void ButtonAgregar_Click(object sender, EventArgs e)
        {
            Pacientes paciente = new Pacientes();
            paciente.Nit = TextBoxNit.Text;
            paciente.Nombre = TextBoxNombre.Text;
            paciente.Apellido = TextBoxApellido.Text;
            paciente.Direccion = TextBoxDireccion.Text;
            paciente.FechaNacimiento = Calendar1.SelectedDate;
            paciente.Telefono = TextBoxTelefono.Text;
            Pacientes.listaPacientes.Add(paciente);
            Pacientes.guardarenJson(archivo);
        }

        protected void ButtonBuscar_Click(object sender, EventArgs e)
        {
            Pacientes paciente = Pacientes.listaPacientes.Find(x => x.Nit == TextBoxNit.Text);
            TextBoxNombre.Text = paciente.Nombre;
            TextBoxApellido.Text = paciente.Apellido;
            TextBoxDireccion.Text = paciente.Direccion;
            Calendar1.SelectedDate = paciente.FechaNacimiento;
            TextBoxTelefono.Text = paciente.Telefono;
        }

        protected void ButtonActualizar_Click(object sender, EventArgs e)
        {
            Pacientes paciente = Pacientes.listaPacientes.Find(x => x.Nit == TextBoxNit.Text);
            paciente.Nit = TextBoxNit.Text;
            paciente.Nombre = TextBoxNombre.Text;
            paciente.Apellido = TextBoxApellido.Text;
            paciente.Direccion = TextBoxDireccion.Text;
            paciente.FechaNacimiento = Calendar1.SelectedDate;
            paciente.Telefono = TextBoxTelefono.Text;
            Pacientes.guardarenJson(archivo);
        }
        protected void Limpiar()
        {
            TextBoxNit.Text = "";
            TextBoxNombre.Text = "";
            TextBoxApellido.Text = "";
            TextBoxDireccion.Text = "";
            Calendar1.SelectedDate = Calendar1.TodaysDate;
            TextBoxTelefono.Text = "";
        }

        protected void Menu1_MenuItemClick1(object sender, MenuEventArgs e)
        {
            TextBoxNit.Enabled = true;
            Limpiar();
            if (Menu1.SelectedItem == Menu1.Items[0])
            {
                ButtonBuscar.Visible = false;
                ButtonActualizar.Visible = false;
                ButtonAgregar.Visible = true;
                TextBoxNombre.Enabled = true;
                TextBoxApellido.Enabled = true;
                Calendar1.Enabled = true;
            }
            else if (Menu1.SelectedItem == Menu1.Items[1])
            {
                ButtonBuscar.Visible = true;
                ButtonActualizar.Visible = true;
                ButtonAgregar.Visible = false;
                TextBoxNombre.Enabled = false;
                TextBoxApellido.Enabled = false;
                Calendar1.Enabled = false;
            }
        }


    }
}