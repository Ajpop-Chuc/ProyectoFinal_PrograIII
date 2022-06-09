using System;
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
        public string Sintomas { get; set; }
        public string Diagnostico { get; set; }
        public string Tratamiento { get; set; }
        public string Receta { get; set; }
        public DateTime ProxCita { get; set; }
        public string precioConsulta { get; set; }
        public string ImgenesConsulta { get; set; }
    }
}