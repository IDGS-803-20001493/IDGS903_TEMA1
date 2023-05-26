using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS903_Tema1.Models
{
    public class Triangulo
    {

        public int x1 { get; set; }

        public int y1 { get; set; }


        public int x2 { get; set; }

        public int y2 { get; set; }


        public int x3 { get; set; }

        public int y3 { get; set; }

        public double Distancia1_2 { get; set; }
        public double Distancia2_3 { get; set; }
        public double Distancia3_1 { get; set; }

        public String resultado { set; get; }
        public int isTriangulo { get; set; }
        public double area { get; set; }
        public double Base {get; set;}
        public double Altura { get; set; }
        public double mayor { get; set; }



        public void Calcular() {
            this.Distancia1_2 = Math.Round(Math.Sqrt(Math.Pow((this.x2 - this.x1), 2) + Math.Pow((this.y2 - this.y1), 2)));
            this.Distancia2_3 = Math.Round(Math.Sqrt(Math.Pow((this.x3 - this.x2), 2) + Math.Pow((this.y3 - this.y2), 2)));
            this.Distancia3_1 = Math.Round(Math.Sqrt(Math.Pow((this.x1 - this.x3), 2) + Math.Pow((this.y1 - this.y3), 2)));

        }

        public void GenerarResultado() {



            this.mayor = 0.0;
            if (this.Distancia1_2 < (this.Distancia2_3 + this.Distancia3_1)){
                this.mayor = this.Distancia1_2;
            }
            else if (this.Distancia2_3 < (this.Distancia3_1 + this.Distancia1_2)){
                this.mayor = this.Distancia2_3;
            }
            else if (this.Distancia3_1 < (this.Distancia2_3 + this.Distancia1_2)){
                this.mayor = this.Distancia3_1;
            }



            this.isTriangulo = 0;
            this.resultado = "No es un triangulo";
            this.area = 0.0;
            if (this.mayor > 0.0) {
                this.isTriangulo = 1;
            }





            if (this.isTriangulo == 1)
            {

                if (this.Distancia1_2 == this.Distancia2_3 &&
                    this.Distancia1_2 == this.Distancia3_1)
                {

                    this.resultado = "Triangulo equilatero";

                    this.Base = this.Distancia1_2;
                    this.Altura = Math.Sqrt(Math.Pow(this.Distancia2_3, 2) - Math.Pow(this.Base / 2 , 2));
                    this.area = (this.Base * this.Altura) / 2;
                }
                else if (this.Distancia1_2 != this.Distancia2_3 &&
                        this.Distancia1_2 != this.Distancia3_1 &&
                        this.Distancia2_3 != this.Distancia3_1)
                {
                    this.resultado = "Triangulo escaleno";


                    double semiperimetro = (Distancia1_2 + Distancia2_3 + Distancia3_1) / 2; // 8 
                    this.area = Math.Sqrt(semiperimetro * (semiperimetro - Distancia1_2) * (semiperimetro - Distancia2_3) 
                                * (semiperimetro - Distancia3_1));


                }
                else// 8 * 4 * 1 * 3 
                {
                    this.resultado = "Triangulo Isosceles";
                    this.Base = this.Distancia1_2;
                    this.Altura = Math.Sqrt(Math.Pow(this.Distancia2_3, 2) - Math.Pow(this.Base / 2, 2));
                    this.area = (this.Base * this.Altura) / 2;
                }


            }

        }
    }
}