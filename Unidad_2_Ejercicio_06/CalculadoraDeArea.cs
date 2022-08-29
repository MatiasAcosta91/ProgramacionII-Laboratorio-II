using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_2_Ejercicio_06
{
    class CalculadoraDeArea
    {
        public static double CalcularAreaCuadrado(double longitudLado)
        {
            return Math.Pow(longitudLado,2);
        }
        public static double CalcularAreaTriangulo(double basee, double altura)
        {
            return  (basee * altura) / 2;
        }
        public static double CalcularAreaCirculo(double radio)
        {
            return Math.Pow(Math.PI * radio, 2);
        }
    }
}
