using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase02
{
    class Class1 //esta clase no tiene declarada el modificador de visibilidad por lo cual no se podra acceder a la clase por fuera del proyecto.
    {
        //"PUBLIC" (modificador de visibilidad) indica que se podra acceder al metodo fuera de la clase. incluso fuera del proytecto. Si se omite
        //el modificador de visibilidad se asume que es privado. (de todas maneras siempre ponerlo ya que en otros lenguajes no funciona de la misma manera)
            /*  - public se puede acceder desde cualquier parte
                - private solo se accede desde el mismo tipo (desde la misma clase)
                - internal solo se puede acceder dentro del mismo proyecto
                - protected se vera mas adelante, esta relacionado a la herencia.
             */

        //"STATIC" indica como se puede acceder a este elemento, Si se establece como static voy a poder accederlo escribiendo nombre de clase.metodo o atributo
        //ej "class1.verbo"(metodo) o "Class1.cadena"(atributo), si no pongo el static la manera de acceder va a ser distinta.

        //"VOID" valor que retornara la funcion (int, float, double, decimal, void etc)

        //"VERBOS" nombre del metodo, debe ser un verbo identificativo y representativo. Debe comenzar con mayuscula cada palabra del nombre

        //"(int aaa, string bbb)" Listado de argumentos que recibe la funcion, siempre se indica el tipo y luego el identificador del parametro

        //ATRIBUTOS:
        public static string cadena; //esto seria un atributo dentro de la clase. seria como un campo dentro de una estructura. al ser public tambien me
        //permite acceder al atributo escribiendo Class1.cadena

        public static void Verbos(int aaa, string bbb)
        {
            string algo; // es una variable local

           algo =  Class1.cadena; //es un atributo del metodo.

            //Bloque de codigo que ejecutara el metodo cuando sea invocado.
        }
        /// <summary>
        /// descripccion de que hace el metodo
        /// </summary>
        /// <returns> Devuelve un entero</returns>
        public static int OtroMetodo ()
        {
            int numero = 1;
            return numero;
        }
    }
}
