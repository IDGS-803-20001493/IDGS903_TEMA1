using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS903_Tema1.Models
{
    public class OperasBas
    {

        public int Num1 { get; set; }

        public int Num2 { get; set; }

        public int res { get; set; }

        public int op { get; set; }

        public void Sumar() {
            this.res = this.Num1 + this.Num2;
        }
        public void Restar()
        {
            this.res = this.Num1 - this.Num2;
        }
        public void Multi()
        {
            this.res = this.Num1 * this.Num2;
        }
        public void Dividir()
        {
            this.res = this.Num1 / this.Num2;
        }

        public void Calcular() {

            switch (this.op) {
                case 1:
                    Sumar();
                    break;
                case 2:
                    Restar();
                    break;
                case 3:
                    Multi();
                    break;
                case 4:
                    Dividir();
                    break;

            }
        }
    }
}