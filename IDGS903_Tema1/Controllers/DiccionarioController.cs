using IDGS903_Tema1.Models;
using IDGS903_Tema1.Services;
using Microsoft.Ajax.Utilities;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS903_Tema1.Controllers
{
    public class DiccionarioController : Controller
    {

        Array DiccionarioCompleto2 = new String[] { "", "" };
        public ActionResult DiccionarioBusqueda()
        {

            ViewBag.DiccionarioCompleto = "No hay coincidencias";
            return View();
        }

        [HttpPost]
        public ActionResult DiccionarioBusqueda(Diccionario dic, String opcion)
        {

            ViewBag.DiccionarioCompleto = "No hay coincidencias";



            var op = new LeerDiccionario();
            ViewBag.DiccionarioCompleto = op.BuscarDic(dic, opcion);

            return View();
        }


        public ActionResult DiccionarioFormulario()
        {
            Array DiccionarioCompleto2 = new String[] { "", "" };
            ViewBag.DiccionarioCompleto = DiccionarioCompleto2;
            return View();
        }




        [HttpPost]
        public ActionResult DiccionarioFormulario(Diccionario dic)
        {
            Array DiccionarioCompleto2 = new String[] { "", "" };
            ViewBag.DiccionarioCompleto = DiccionarioCompleto2;

            if (dic.mostrar == 1)
            {
                var dicCompleto = new LeerDiccionario();
                ViewBag.DiccionarioCompleto = dicCompleto.LeerDic();
            }
            else
            {
                var op = new GuardarDiccionario();
                op.GuardarArchivo(dic);
            }

            return View();
        }

    }
}
