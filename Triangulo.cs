using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_4._1
{
    public class Triangulo
    {
        public double LadoA {  get; set; }
        public double LadoB { get; set; }
        public double LadoC { get; set; }

        public Triangulo() 
        {
        LadoA = 0;
        LadoB = 0;
        LadoC = 0;
        }

        public Triangulo(double ladoA, double ladoB, double ladoC)
        {
            LadoA = ladoA;
            LadoB = ladoB;
            LadoC = ladoC;
        }

        public double Perimetro()
        {
            return LadoA  + LadoB + LadoC;
        }


    }
}
