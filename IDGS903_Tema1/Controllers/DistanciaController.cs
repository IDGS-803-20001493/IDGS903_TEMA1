using IDGS903_Tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS903_Tema1.Controllers
{
    public class DistanciaController : Controller
    {

        public ActionResult Distancia(Distancia cs)
        {
           
                return View(cs);
            
        }


        public ActionResult ResultadoCalculo(Distancia cs) {
            cs.Calcular();
            return View(cs);
        }

    }
}
