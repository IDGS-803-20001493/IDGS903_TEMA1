using IDGS903_Tema1.Models;
using IDGS903_Tema1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS903_Tema1.Controllers
{
    public class DiccionarioBusquedaController : Controller
    {

        public ActionResult DiccionarioBusqueda() {

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

    }
}
