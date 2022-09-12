using System;
using Biblioteca_ejercicio_en_clase_2;
namespace Unidad_4_Ejercicio_en_clase2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Parte 1
            Console.WriteLine("---------------------Parte 1--------------------");
            Tinta tintaUno = new Tinta();
            Tinta tintaDos = new Tinta(ConsoleColor.Red);
            Tinta tintaTres = new Tinta(ConsoleColor.Red, ETipoTinta.ConBrillito);

            string cadenaDePrueba = (string) tintaUno;
            Console.WriteLine(cadenaDePrueba);

            cadenaDePrueba = (string) tintaDos;
            Console.WriteLine(cadenaDePrueba);

            cadenaDePrueba = (string)tintaTres;
            Console.WriteLine(cadenaDePrueba);

            Console.WriteLine(tintaTres.Mostrar());
            //Parte 2
            Console.WriteLine("---------------------Parte 2--------------------");

    
            Pluma plumaUno = new Pluma();
            //Console.WriteLine(plumaUno.Mostrar());

            Pluma plumaDos = new Pluma("Parker");
            //Console.WriteLine(plumaDos.Mostrar());

            Pluma plumaTres = new Pluma("Bic",tintaDos);
            //Console.WriteLine(plumaTres.Mostrar());

            Pluma plumaCuatro = new Pluma("Filgo",tintaTres,20);
            Console.WriteLine(plumaCuatro.Mostrar());
            

        }
    }
}
