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
        public string idConsulta { get; set; }
        public string NitPaciente { get; set; }
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