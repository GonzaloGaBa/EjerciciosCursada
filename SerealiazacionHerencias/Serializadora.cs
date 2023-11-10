using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace SerealiazacionHerencias
{
    public class Serializadora
    {
        public static void EscribirXML(string path, List<Empleado> lista)
        {
            using(StreamWriter  sw = new StreamWriter(path))
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<Empleado>));
                ser.Serialize(sw, lista);

            }
        }
        public static List<Empleado> LeerXML (string path)  
        {
            List<Empleado> lista;
            using(StreamReader sr = new StreamReader(path)) 
            {
                XmlSerializer des = new XmlSerializer(typeof(List<Empleado>));
                
                lista = (List<Empleado>) des.Deserialize(sr);  
            }
                    
            return lista;
        }
        
        public static void EscribirJson(string ruta, List<Empleado> lista)
        {
            try
            {
                string json = JsonConvert.SerializeObject(lista,Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(ruta, json);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.ToString());
            }
        }

        public static List<Empleado> LeerJson(string path)
        {
            List<Empleado> lista = null;
            try
            {
                string json = File.ReadAllText(path);
                lista = JsonConvert.DeserializeObject<List<Empleado>>(json);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.ToString());
            }
            return lista;
        }        
    }
}
