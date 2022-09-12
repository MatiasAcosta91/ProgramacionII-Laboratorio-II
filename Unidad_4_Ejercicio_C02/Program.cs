using System;
using Biblioteca_Unidad4_Ej_C02;
namespace Unidad_4_Ejercicio_C02
{
    class Program
    {
        static void Main(string[] args)
        {
            Producto asd = new Producto("caca", "14sc", 245);
            Console.WriteLine(Producto.MostrarPorducto(asd));

            Console.WriteLine((string)asd);
        }
    }
}
