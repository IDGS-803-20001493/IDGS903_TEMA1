using IDGS903_Tema1.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;


namespace IDGS903_Tema1.Services
{
    public class LeerDiccionario
    {

        public Array LeerDic()
        {
            Array DiccionarioCompleto = null;
            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/Diccionario.txt");
            if (File.Exists(archivo))
            {
                DiccionarioCompleto = File.ReadAllLines(archivo);

            }
            return DiccionarioCompleto;
        }

        public String BuscarDic(Diccionario dic,String opcion)
        {

            List<Diccionario> archivoLeido = new List<Diccionario>();

            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/Diccionario.txt");


            if (File.Exists(archivo))
            {
                String[] lectura = File.ReadAllLines(archivo);

                foreach (String linea in lectura) {
                    String[] atributos = linea.Split(',');
                    if (atributos.Length >= 2) {

                        Diccionario listaDiccionario = new Diccionario
                        {
                            Español = atributos[0],
                            Ingles = atributos[1]
                        };

                        archivoLeido.Add(listaDiccionario);
                    }
                }
            }

            String resultado = "";

            if (opcion.Equals("Español"))
            {
                Diccionario dic2 = archivoLeido.FirstOrDefault(p => p.Ingles.Equals(dic.Busqueda, StringComparison.InvariantCultureIgnoreCase));

                resultado = dic2.Español;
            }
            else {
                Diccionario dic2 = archivoLeido.FirstOrDefault(p => p.Español.Equals(dic.Busqueda, StringComparison.InvariantCultureIgnoreCase));

                resultado = dic2.Ingles;
            }
            
            return resultado;
        }
    }
}