using IDGS903_Tema1.Services;
using IDGS903_Tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http.Headers;

namespace IDGS903_Tema1.Controllers
{
    public class TiendaController : Controller
    {
        public ActionResult MuestraPulques()
        {
            var pulquesVenta = new PulqueServices();
            var model = pulquesVenta.ObtenerPulques();
            return View(model);
        }

        public ActionResult MuestraPulque2()
        {
            TempData["Nombres"] = "El perro bermudes";
            var pulquesVenta = new PulqueServices();
            var model = pulquesVenta.ObtenerPulques();
            return View(model);
        }


        public ActionResult Index() {

            var pulque1 = new Pulque() {
                Nombre = "Pulque sabor a tamal",
                Descripcion = "Pulque de tamal"
            };
            return Json(pulque1, JsonRequestBehavior.AllowGet);
            //return Content("Jorge Armando Ramirez Patlan");
            //return View();
        }

        public ActionResult Goggle() {

            var pulque1 = new Pulque()
            {
                Nombre = "Pulque sabor a tamal",
                Descripcion = "Pulque de tamal",
                Caducidad=new DateTime(2023,1,1),
                Litros=23
            };

            ViewBag.pulques = pulque1;

            return View();
           // return Redirect("https://google.com.mx");
        }

        public ActionResult muestra2() {

            ViewBag.saludo = "Hola mundo";
            ViewBag.fecha = new DateTime(2023, 1, 1);
            ViewData["Nombre"] = "Guapo";


            String nombre = "";
            if (TempData.ContainsKey("nombres"))
            {
                nombre = TempData["nombres"] as String;
            }
            ViewBag.nombrenuevo = nombre;


            return View();

           // return RedirectToAction("MuestraPulque2");
        }  
    }
}
