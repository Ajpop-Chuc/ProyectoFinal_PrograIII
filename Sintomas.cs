using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace ProyectoFinalP_PrograIII
{
    public class Sintomas
    {
        public string codigoSintoma { get; set; }
        public string DescripcionSintoma { get; set; }

        public static List<Sintomas> listaSintomas = new List<Sintomas>();

        public static void guardarenJson(string archivo)
        {
            string json = JsonConvert.SerializeObject(listaSintomas);
            System.IO.File.WriteAllText(archivo, json);
        }
        public static void leerJson(string archivo)
        {
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            listaSintomas = JsonConvert.DeserializeObject<List<Sintomas>>(json);
        }
    }
}