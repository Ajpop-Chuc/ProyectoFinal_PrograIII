﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinalP_PrograIII
{
    public partial class RegistroCitas : System.Web.UI.Page
    {
        static string archivo;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                archivo = Server.MapPath("RegistroCitas.json");
                Agenda.listaAgenda.Clear();
                Agenda.leerJson(archivo);

                Pacientes.listaPacientes.Clear();
                Pacientes.leerJson(Server.MapPath("RegistroPacientes.json"));
                foreach (var x in Pacientes.listaPacientes)
                {
                    DropDownListNit.Items.Add(x.Nit);
                }
            }
        }

        protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
        {
            if (Menu1.SelectedItem == Menu1.Items[0])
            {
                ButtonBuscar.Visible = false;
                ButtonEliminar.Visible = false;
                ButtonAgendar.Visible = true;
            }
            else if (Menu1.SelectedItem == Menu1.Items[1])
            {
                ButtonBuscar.Visible = true;
                ButtonEliminar.Visible = true;
                ButtonAgendar.Visible = false;
            }
        }

        protected void ButtonAgendar_Click(object sender, EventArgs e)
        {
            DatosCita datos = new DatosCita();
            Agenda agenda = Agenda.listaAgenda.Find(x => x.FechaCita == Calendar1.SelectedDate);
            if (agenda == null) { agenda = new Agenda(); }

            datos.NitPaceinte = DropDownListNit.Text;
            datos.horaInicio = TextBoxHInicio.Text;
            datos.horaFinal = TextBoxHFinalizacion.Text;

            agenda.FechaCita = Calendar1.SelectedDate;
            agenda.ListaCitas.Add(datos);

            if (Agenda.listaAgenda.Find(x => x.FechaCita == Calendar1.SelectedDate) == null) { Agenda.listaAgenda.Add(agenda); }

            Agenda.guardarenJson(archivo);
        }

        protected void ButtonBuscar_Click(object sender, EventArgs e)
        {
            DropDownList1.Items.Clear();
            foreach (var x in Agenda.listaAgenda)
            {
                foreach (var i in x.ListaCitas)
                {
                    if (i.NitPaceinte == DropDownListNit.Text)
                    {
                        DropDownList1.Items.Add(x.FechaCita.ToShortDateString());
                    }
                }
            }
        }//+" Horario:"+i.horaInicio+"-"+i.horaFinal

        protected void ButtonEliminar_Click(object sender, EventArgs e)
        {
            Agenda fecha = Agenda.listaAgenda.Find(x => x.FechaCita == Convert.ToDateTime(DropDownList1.Text));
            int posicion = fecha.ListaCitas.FindIndex(x => x.NitPaceinte == DropDownListNit.Text);

            fecha.ListaCitas.RemoveAt(posicion);
            Agenda.guardarenJson(archivo);
        }
    }
}