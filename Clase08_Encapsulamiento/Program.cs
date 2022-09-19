using System;

namespace Clase08_Encapsulamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            //-----------------------------Encapsulamiento--------------------------------
            /*El encapsulamiento nos permite no dejar al usuario o al programador acceder a ciertos elementos 
             * de la clase a traves de los modificadores de visibilidad.
             * -Public: Accesible desde cualquier parte
             * -Private Solo accesible dentro del mismo tipo (clase)
             * -Internal: Solo accesible dentro del mismo proyecto
             * -protected: Solo accesible desde el mismo tipo o derivados (hijos) -Se amplia en la clase de herencia.
             * 
             * ------------------------Propiedades-------------------------------------
             * La propiedad es un metodo especial y se llama descripto de acceso.
             * Es un mecanismo que nos permite leer, escribir o calcular el valor de un campo. 
             * Permite que una clase exponga de manera publica una manera de obtener y establecer valores mientras
             * oculta el codigo de implementacion o validacion.
             * Nos da una manera de poder modificar  o ver atributos privados estableciendo reglas.
             * 
             * 
             * ----------------------------Enumerados------------------------------------------
             * Es un tipo de valor que define un conjunto de constantes con nombre.
             * Sirve para deifirni y limitar el conjunto de valores que pueden ser asignados a una variable o parametro
             * de entrada.
             * ej:
             * public enum Color
             * {
             *          rojo,
             *          verde,
             *          azul,
             * }
             * 
             * -------------------------------INDEXADORES--------------------------------------------
             * Es parecido a una propiedad, me permite acceder a los datos de un objeto a traves de un indice
             *  Ver la clase Hola.
             */
            Hola h1 = new Hola();
            //get
            Console.WriteLine(h1[0]); //lo hago a traves de la instancia
            Console.WriteLine(h1[2]);
            Console.WriteLine(h1[1]);
            //set
            h1[0] = "Seteo nuevo valor";

            Console.WriteLine(h1[0]);
            // se untiliza en arrays o colecciones.



        }
    }
}
