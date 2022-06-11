using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoFinalP_PrograIII
{
    public class nCitasEnFechasAux
    {
        public DateTime fecha { get; set; }
        public int cantidadCitas { get; set; }

        public static List<nCitasEnFechasAux> listaCantidadCitas = new List<nCitasEnFechasAux>();
    }
}