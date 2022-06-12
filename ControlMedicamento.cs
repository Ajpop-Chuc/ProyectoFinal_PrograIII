using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace ProyectoFinalP_PrograIII
{
    public class ControlMedicamento
    {
        public static List<ControlMedicamento> ListaControlMedicamentos = new List<ControlMedicamento>();
        public string Nombre { get; set; }
        public int VecesRecetada { get; set; }

        public static void guardarenJson(string archivo)
        {
            string json = JsonConvert.SerializeObject(ListaControlMedicamentos);
            System.IO.File.WriteAllText(archivo, json);
        }

        public static void leerJson(string archivo)
        {
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            ListaControlMedicamentos = JsonConvert.DeserializeObject<List<ControlMedicamento>>(json);
        }

    }
}