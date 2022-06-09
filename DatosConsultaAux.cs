﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoFinalP_PrograIII
{
    public class DatosConsultaAux
    {
        public string idConsulta { get; set; }
        public string fechaConsulta { get; set; }
        public string horaCita { get; set; }
        public double Temperatura { get; set; }
        public double Presion { get; set; }

        private List<string> sintomas = new List<string>();
        public string Diagnostico { get; set; }
        public string Tratamiento { get; set; }

        private List<RecetaAux> receta = new List<RecetaAux>();
        public DateTime ProxCita { get; set; }
        public string precioConsulta { get; set; }

        private List<string> imgenesConsulta = new List<string>();
        public List<string> Sintomas { get => sintomas; set => sintomas = value; }
        public List<RecetaAux> Receta { get => receta; set => receta = value; }
        public List<string> ImgenesConsulta { get => imgenesConsulta; set => imgenesConsulta = value; }
    }
}