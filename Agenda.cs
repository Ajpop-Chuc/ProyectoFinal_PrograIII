using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace ProyectoFinalP_PrograIII
{
    public class Agenda
    {
        public DateTime FechaCita { get; set; }

        private List<DatosCita> listaCitas = new List<DatosCita>();
        public List<DatosCita> ListaCitas { get => listaCitas; set => listaCitas = value; }

        public static List<Agenda> listaAgenda = new List<Agenda>();

        public static void guardarenJson(string archivo)
        {
            string json = JsonConvert.SerializeObject(listaAgenda);
            System.IO.File.WriteAllText(archivo, json);
        }
        public static void leerJson(string archivo)
        {
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            listaAgenda = JsonConvert.DeserializeObject<List<Agenda>>(json);
        }
    }
}