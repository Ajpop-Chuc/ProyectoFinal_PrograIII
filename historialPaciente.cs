using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace ProyectoFinalP_PrograIII
{
    public class historialPaciente
    {
        public string NitPaciente { get; set; }
        private List<DatosConsultaAux> listaDatosConsulta = new List<DatosConsultaAux>();
        public List<DatosConsultaAux> ListaDatosConsulta { get => listaDatosConsulta; set => listaDatosConsulta = value; }

  
        public static List<historialPaciente> listaHistorialPciente = new List<historialPaciente>();

        public static void guardarenJson(string archivo)
        {
            string json = JsonConvert.SerializeObject(listaHistorialPciente);
            System.IO.File.WriteAllText(archivo, json);
        }
        public static void leerJson(string archivo)
        {
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            listaHistorialPciente = JsonConvert.DeserializeObject<List<historialPaciente>>(json);
        }

        
    }
}