using IDGS903_Tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace IDGS903_Tema1.Controllers
{
    public class TrianguloController : Controller
    {

        public ActionResult Triangulo()
        {
            ViewBag.resultado = "";
            ViewBag.Distancia1_2 = "";
            ViewBag.Distancia2_3 = "";
            ViewBag.Distancia3_1 = "";
            ViewBag.area = "";
            return View();
        }

        [HttpPost]
        public ActionResult Triangulo(Triangulo t) {
            t.Calcular();
            t.GenerarResultado();

            var model = new Triangulo();
            model.resultado = t.resultado;
            model.Distancia1_2 = t.Distancia1_2;
            model.Distancia2_3 = t.Distancia2_3;
            model.Distancia3_1 = t.Distancia3_1;
            model.area = t.area;


            ViewBag.resultado = model.resultado;
            ViewBag.Distancia1_2 = model.Distancia1_2;
            ViewBag.Distancia2_3 = model.Distancia2_3;
            ViewBag.Distancia3_1 = model.Distancia3_1;
            ViewBag.area = model.area;


            return View(model);
        }
    }
}
