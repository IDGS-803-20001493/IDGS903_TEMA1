using System;
using System.Collections.Generic;
using IDGS903_Tema1.Models;
using System.EnterpriseServices.Internal;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;

namespace IDGS903_Tema1.Services
{
    public class PulqueServices
    {


        public List<Pulque> ObtenerPulques(){

            var pulque1 = new Pulque()
            {

                Nombre = "Pulque 1",
                Descripcion = "Mango Sandia",
                Litros = 23,
                Caducidad = new DateTime(2023, 1, 5)
            };

            var pulque2 = new Pulque()
            {
                Nombre = "Pulque 2",
                Descripcion = "Mango Piña",
                Litros = 23,
                Caducidad = new DateTime(2023, 1, 5)
            };

            return new List<Pulque> { pulque1, pulque2 };
        }
    }
}