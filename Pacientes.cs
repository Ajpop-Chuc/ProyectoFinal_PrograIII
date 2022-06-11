using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace ProyectoFinalP_PrograIII
{
    public class Pacientes
    {
        public string Nit { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Edad { get; set; } 
        public string Telefono { get; set; }

        public static List<Pacientes> listaPacientes = new List<Pacientes>();

        public static void guardarenJson(string archivo)
        {
            string json = JsonConvert.SerializeObject(listaPacientes);
            System.IO.File.WriteAllText(archivo, json);
        }
        public static void leerJson(string archivo)
        {
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            listaPacientes = JsonConvert.DeserializeObject<List<Pacientes>>(json);
        }

        public static int edad(DateTime FechaNac)
        {
            DateTime hoy = DateTime.Now;
            TimeSpan intervalo = DateTime.Now - FechaNac;           
            return (intervalo.Days / 365);
        }

    }
}