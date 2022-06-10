using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinalP_PrograIII
{
    public partial class OpcionesMedicamento : System.Web.UI.Page
    {
        static string archivo;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                archivo = Server.MapPath("DatosMedicamentos.json");
                Medicamentos.listaMedicamentos.Clear();
                Medicamentos.leerJson(archivo);
            }
        }

        protected void ButtonAgregarMedicamento_Click(object sender, EventArgs e)
        {
            
            Medicamentos medicamento = new Medicamentos();
            medicamento.codigoMedicamento = TextBoxCodigoMedicamento.Text;
            medicamento.ingredienteGenerico = TextBoxIngredienteGenerico.Text;
            medicamento.Laboratorio = TextBoxLaboratorio.Text;
            Medicamentos.listaMedicamentos.Add(medicamento);
            Response.Write("<script>alert('Medicamento Ingresado Correctamente')</script>");
            Medicamentos.guardarenJson(archivo);
            Limpiar();

        }

        protected void ButtonBuscarMedicamento_Click(object sender, EventArgs e)
        {
            
            Medicamentos medicamento = Medicamentos.listaMedicamentos.Find(x => x.codigoMedicamento == TextBoxCodigoMedicamento.Text);
            if (medicamento != null)
            {
                TextBoxCodigoMedicamento.Text = medicamento.codigoMedicamento;
                TextBoxIngredienteGenerico.Text = medicamento.ingredienteGenerico;
                TextBoxLaboratorio.Text = medicamento.Laboratorio;
                Validacioncodigom.Enabled = true;
            }
            else
            {
                Response.Write("<script>alert('Medicamento No Ingresado ')</script>");
            }
            TextBoxCodigoMedicamento.Enabled = false;
        }

        protected void ButtonActualizarMedicamento_Click(object sender, EventArgs e)
        {
            
            Medicamentos medicamento = Medicamentos.listaMedicamentos.Find(x => x.codigoMedicamento == TextBoxCodigoMedicamento.Text);
            medicamento.codigoMedicamento = TextBoxCodigoMedicamento.Text;
            medicamento.ingredienteGenerico = TextBoxIngredienteGenerico.Text;
            medicamento.Laboratorio = TextBoxLaboratorio.Text;
            Response.Write("<script>alert('Medicamento Actualizado Correctamente')</script>");
            Medicamentos.guardarenJson(archivo);
            Limpiar();
        }

        protected void Limpiar()
        {
            TextBoxCodigoMedicamento.Text = "";
            TextBoxIngredienteGenerico.Text = "";
            TextBoxLaboratorio.Text = "";
        }

        protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
        {
            if (Menu1.SelectedItem == Menu1.Items[0])
            {
                TextBoxCodigoMedicamento.Enabled = true;
                ButtonBuscarMedicamento.Visible = false;
                ButtonActualizarMedicamento.Visible = false;
                ButtonAgregarMedicamento.Visible = true;
            }
            else if (Menu1.SelectedItem == Menu1.Items[1])
            {
                TextBoxCodigoMedicamento.Enabled = true;
                ButtonBuscarMedicamento.Visible = true;
                ButtonActualizarMedicamento.Visible = true;
                ButtonAgregarMedicamento.Visible = false;
            }
        }
    }
}