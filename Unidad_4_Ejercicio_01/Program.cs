using System;
using Biblioteca_Unidad4_Ej01;

namespace Unidad_4_Ejercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador ej1 = new Sumador(); //Creo un objeto sumador con 0 sumas

            Console.WriteLine(ej1.Sumar(23, 5) ); //Utilizo metodo con sobrecarga de int, total de sumas 1
            Console.WriteLine(ej1.Sumar(23, 4) ); //utilizo metodo con sobrecarga de int, total de sumas 2
            Console.WriteLine(ej1.Sumar("hola ","como estas")); //utilizo metodo con sobrecarga de string, total de sumas 3
            Console.WriteLine(ej1.Sumar("bien ", "me alegro")); //utilizo metodo con sobrecarga de string, total de sumas 4

            int cantidadSumas = (int)ej1; // utilizo conversion explicita para devolver el campo sumas del objeto ej1;

            Console.WriteLine("cantidad de sumas: " + cantidadSumas); // muestro la cantidad de sumas, que debe ser 4


            Sumador ej2 = new Sumador(2); //creo un segundo objeto inicializado con 2 sumas

            long totalSumas; //creo una variable tipo long para almacenar la suma de ambos objetos
            totalSumas = ej1 + ej2; //utilizo la sobrecarga de + para devolver la suma de los atributos cantidad de sumas de cada objeto

            Console.WriteLine("total de sumas de ambos objetos: " + totalSumas); //muestro el total de sumas de ambos objetos, 6

            bool igualSumas; // creo un bool para guardar si la cantidad de sumas de ambos objetos es igual,
            igualSumas = ej1 | ej2; // utilizo la sobregarca de | para comparar las cantidad de sumas de cada objeto y devolver un bool
           

            Console.WriteLine(igualSumas); //como ej1 tieen 4 y ej2 tiene 2 dara false
            ej2.Sumar(1, 2);
            ej2.Sumar("a", "b");//hago otras dos sumas en ej2 para que ambos tengan 4.

            igualSumas = ej1 | ej2; //vuelvo a usar la sobrecarga de |
            Console.WriteLine(igualSumas); //dara true


            
        }
    }
}
