using System;
using BibliotecaEj05;

namespace Unidad_3_Ejercicio_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Geometria.Punto punto1 = new Geometria.Punto(1,2);
            Geometria.Punto punto3 = new Geometria.Punto(7,4);

            Geometria.Rectangulo unRectangulo = new Geometria.Rectangulo(punto1, punto3);

            Console.WriteLine(unRectangulo.GetArea());
            Console.WriteLine(unRectangulo.GetPerimetro());


        }
    }
}
