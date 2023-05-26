using IDGS903_Tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS903_Tema1.Controllers
{
    public class NuevoController : Controller
    {
        // GET: Nuevo
        public ActionResult Ventana()
        {
            return View();
        }

        public ActionResult Calculos2(OperasBas ope)
        {
            ope.Calcular();
            var model = new OperasBas();
            model.res = ope.res;

            return View(model);
        }


        public ActionResult Calculos(string n1, string n2, string operacion)
        {
            int res = 0;

            if (operacion == "sumar")
            {
                res = Convert.ToInt16(n1) + Convert.ToInt16(n2);
            }
            if (operacion == "restar")
            {
                res = Convert.ToInt16(n1) - Convert.ToInt16(n2);
            }
            if (operacion == "multiplicar")
            {
                res = Convert.ToInt16(n1) * Convert.ToInt16(n2);
            }
            if (operacion == "dividir")
            {
                res = Convert.ToInt16(n1) / Convert.ToInt16(n2);
            }

            ViewBag.Res = Convert.ToString(res);
            return View();
        }
    
}
}