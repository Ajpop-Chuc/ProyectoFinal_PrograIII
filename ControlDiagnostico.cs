using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace ProyectoFinalP_PrograIII
{
    public class ControlDiagnostico
    {
        public static List<ControlDiagnostico> ListaControlEnfermedades = new List<ControlDiagnostico>();
        public string Enfermedad { get; set; }
        public int VecesDiagnosticada { get; set; }

        public static void guardarenJson(string archivo)
        {
            string json = JsonConvert.SerializeObject(ListaControlEnfermedades);
            System.IO.File.WriteAllText(archivo, json);
        }

        public static void leerJson(string archivo)
        {
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            ListaControlEnfermedades = JsonConvert.DeserializeObject<List<ControlDiagnostico>>(json);
        }
    }
}