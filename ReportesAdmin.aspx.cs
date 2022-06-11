using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinalP_PrograIII
{
    public partial class ReportesAdmin : System.Web.UI.Page
    { 
        Agenda agenda = new Agenda();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Agenda.listaAgenda.Clear();
                Agenda.leerJson(Server.MapPath("RegistroCitas.Json"));
                for(int a = 1; a <= 12; a++)
                {
                    DropDownListMes1.Items.Add(a.ToString());
                    DropDownListMes2.Items.Add(a.ToString());
                }
            }
            
        }
        protected void Opcion1()
        {
            foreach (var x in Agenda.listaAgenda)
            {
                if (x.FechaCita.Month == Convert.ToInt16(DropDownListMes1.SelectedValue))
                {
                    nCitasEnFechasAux Citas = new nCitasEnFechasAux();
                    Citas.fecha = x.FechaCita;
                    Citas.cantidadCitas = x.ListaCitas.Count;
                    nCitasEnFechasAux.listaCantidadCitas.Add(Citas);
                }
            }
            if (nCitasEnFechasAux.listaCantidadCitas.Count != 0)
            {
                int max = nCitasEnFechasAux.listaCantidadCitas.Max(x => x.cantidadCitas);
                nCitasEnFechasAux FechaMax = nCitasEnFechasAux.listaCantidadCitas.Find(x => x.cantidadCitas == max);
                //Label1.Text = max.ToString();
                //Label2.Text = FechaMax.fecha + " --- " + FechaMax.cantidadCitas.ToString();
                string fechaArreglada = FechaMax.fecha.Day.ToString() + "/" + FechaMax.fecha.Month.ToString() + "/" + FechaMax.fecha.Year.ToString();
                Label4.Text= "El Día Con Más Citas Programadas es el '"+fechaArreglada + "' Con Un Total De '" + FechaMax.cantidadCitas.ToString() + "' Citas Programadas";
            }
            else { Response.Write("<script>alert('No Existen Citas Registradas En el Mes Especificado')</script>"); }
        }
        protected void Opcion2()
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Menu1.SelectedItem == Menu1.Items[0])
                Opcion1();

            else if (Menu1.SelectedItem == Menu1.Items[1])
                Opcion2();

        }
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
        {
            if (Menu1.SelectedItem == Menu1.Items[0])
            {
                Label1.Visible = true;
                Label2.Visible = false;
                Label3.Visible = false;
                DropDownListMes1.Visible = true;
                DropDownListMes2.Visible = false;
            }
            if (Menu1.SelectedItem == Menu1.Items[0])
            {
                Label1.Visible = false;
                Label2.Visible = true;
                Label3.Visible = true;
                DropDownListMes1.Visible = true;
                DropDownListMes2.Visible = true;
            }
        }
    }
}