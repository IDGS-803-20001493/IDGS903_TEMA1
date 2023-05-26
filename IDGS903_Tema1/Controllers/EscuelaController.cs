using Antlr.Runtime.Misc;
using IDGS903_Tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS903_Tema1.Controllers
{
    public class EscuelaController : Controller
    {
        // GET: Escuela
        public ActionResult Escuela(Alumnos alum)
        {
            var alumno1 = new Alumnos()
            {
                Nombre = "Antonio",
                Edad = 20,
                
                Inscrito = new DateTime(2023, 01, 01),
                Activo = true

            };

            ViewBag.Alumnos = alumno1;
            return View();
        }


        public ActionResult Registrar(Alumnos alum) {
            var alumno1 = new Alumnos()
            {
                Nombre = "Antonio",
                Edad = 20,

                Inscrito = new DateTime(2023, 01, 01),
                Activo = true

            };

            alum = alumno1;
            return View(alum);
        }



        public ActionResult Resgistrar2() {
            return View();
        }
    }

}
