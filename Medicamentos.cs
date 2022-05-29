using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace ProyectoFinalP_PrograIII
{
    public class Medicamentos
    {
        public string codigoMedicamento { get; set; }
        public string ingredienteGenerico { get; set; }
        public string Laboratorio { get; set; }

        private List<string> listaEnfermedades = new List<string>();
        public List<string> ListaEnfermedades { get => listaEnfermedades; set => listaEnfermedades = value; }

        public static List<Medicamentos> listaMedicamentos = new List<Medicamentos>();
        public static void guardarenJson(string archivo)
        {
            string json = JsonConvert.SerializeObject(listaMedicamentos);
            System.IO.File.WriteAllText(archivo, json);
        }
        public static void leerJson(string archivo)
        {
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            listaMedicamentos = JsonConvert.DeserializeObject<List<Medicamentos>>(json);
        }
    }
}