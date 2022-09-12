using System;

namespace Clase05
{
    class Program
    {
        static void Main(string[] args)
        {
            //-------------------------------Sobrecarga de operadores
            /*
             * Permite sobrecargar operadores como los operadores aritmeticos o logicos.
             * SON TODOS ESTATICOS
            */
            Sobrecarga algo = new Sobrecarga(5);
            Sobrecarga algo2 = new Sobrecarga(7,"texto");
            /*
             * La sobrecarga de un operador, por ejemplo la del == Nos permite poder realizar la comparacion de objetos
             * o de atributos determinados de un objeto. Si no realizamos la sobrecarga y hicieramos una comparacion
             * objeto1==objeto2, esto no compararia los objetos, sino que compararia las referencias(las direcciones
             * de memoria donde se encuentra alojados los objetos)
             * 
             * 
             * Si uso una sobrecarga del operador +, me permitiria hacer una suma a uno de sus campos.
            */

            // SOBRECARGA DE
            int asd;

            asd = algo + 6;






        }
    }
}
