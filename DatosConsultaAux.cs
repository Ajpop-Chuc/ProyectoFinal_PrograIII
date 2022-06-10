using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoFinalP_PrograIII
{
    public class DatosConsultaAux
    {
        public string idConsulta { get; set; }
        public DateTime fechaConsulta { get; set; }
        public string horaCita { get; set; }
        public string Temperatura { get; set; }
        public string Presion { get; set; }

        private List<string> sintomas = new List<string>();
        public string Diagnostico { get; set; }
        public string Tratamiento { get; set; }

        private List<RecetaAux> receta = new List<RecetaAux>();
        public DateTime ProxCita { get; set; }
        public double precioConsulta { get; set; }

        public string imgenesConsulta { get; set; }
        public List<string> Sintomas { get => sintomas; set => sintomas = value; }
        public List<RecetaAux> Receta { get => receta; set => receta = value; }
    }
}