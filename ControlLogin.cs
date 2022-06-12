using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace ProyectoFinalP_PrograIII
{
    public class ControlLogin
    {
        public string usuario { get; set; }
        public string contraseña { get; set; }
        public int modulo { get; set; }

        public static List<ControlLogin> listaDatosLogin = new List<ControlLogin>();

        public static void guardarenJson(string archivo)
        {
            string json = JsonConvert.SerializeObject(listaDatosLogin);
            System.IO.File.WriteAllText(archivo, json);
        }
        public static void leerJson(string archivo)
        {
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            listaDatosLogin = JsonConvert.DeserializeObject<List<ControlLogin>>(json);
        }
    }
}