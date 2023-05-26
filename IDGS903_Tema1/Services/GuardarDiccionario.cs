using IDGS903_Tema1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace IDGS903_Tema1.Services
{
    public class GuardarDiccionario
    {

        public void GuardarArchivo(Diccionario dic)
        {
            var esp = dic.Español;
            var ing = dic.Ingles;

            var informacion = esp + ',' + ing + Environment.NewLine;

            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/Diccionario.txt");
            File.AppendAllText(archivo, informacion);
        }
    }
}