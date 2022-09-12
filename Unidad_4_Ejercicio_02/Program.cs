using System;
using Billetes;

namespace Unidad_4_Ejercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Dolar billeteDolar = 1; //Uso el casteo implicito el cual utilizare el constructor para crear el billete dolar
            Peso billetePeso = (Peso)billeteDolar; //uso casteo explicito para transformar el billete dolar a peso
            Console.WriteLine("1 Peso equivale a: "+billetePeso.GetCantidad() + " Pesos");

            Euro billeteEuro = 1;//Uso el casteo implicito el cual utilizare el constructor para crear el billete euro
            billetePeso = (Peso)billeteEuro; //uso casteo explicito para transformar el billete Euro a peso
            Console.WriteLine("1 Euro equivale a: " + billetePeso.GetCantidad() + " Pesos");


            Peso p1 = 100; // creo un nuevo billete de 100 pesos
            Euro e1 = 2;  //creo un nuevo billete de 2 dolares


            Dolar sumaDePesoYEuro = (Dolar) p1+ (Euro)e1; //uso casteo explicito para transformar ambas monedas
            Console.WriteLine(sumaDePesoYEuro.GetCantidad());




        }
    }
}
