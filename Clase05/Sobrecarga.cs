using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase05
{
    class Sobrecarga
    {
        private int entero;
        private string cadena;

        public Sobrecarga(int entero)
        {
            this.entero = entero;
        }
        public Sobrecarga (int entero, string cadena) : this (entero)
        {
            this.cadena = cadena;
        }

        public static int operator +(Sobrecarga v1,int num1)
        {
            return v1.entero + num1;
            //como el + es un operador binario se le tienen que pasar dos parametros. Uno de los parametros tiene que ser
            // de la clase
        }
        public static int operator -(Sobrecarga v1, int num1)
        {
            return v1.entero - num1;
            //como el - es un operador binario se le tienen que pasar dos parametros. Uno de los parametros tiene que ser
            // de la clase

        }
        public static int operator *(Sobrecarga v1, int num1)
        {
            return v1.entero * num1;
            //como el * es un operador binario se le tienen que pasar dos parametros. Uno de los parametros tiene que ser
            // de la clase

        }
        public static int operator / (Sobrecarga v1, int num1)
        {
            return v1.entero / num1;
            //como el / es un operador binario se le tienen que pasar dos parametros. UNO de los parametros tiene que ser
            // de la clase, el otro puede ser de la misma clase o tambien cualquier otro tipo de dato, en este caso
            //uso una clase y un entero.

        }
        public static bool operator == (Sobrecarga v1, int num1)
        {
            return v1.entero == num1;
            //Cuando sobrecargamos un  == tambien se tiene que sobrecargar un !=
        }
        public static bool operator !=(Sobrecarga v1, int num1)
        {
            return !(v1.entero == num1);
            //como hice el == tambien debo hacer el !=
        }

        public static implicit operator string (Sobrecarga v1)
        {
            return v1.cadena;
        }
        public static explicit operator int  (Sobrecarga v1)
        {
            return v1.entero;
            //Esto me permite desde el main poder hacer
            /* int variable1;
             * Sobrecarga ejemplo = new Sobrecarga()
             * variable1 = (int)ejemplo ->>> es necesario realizar el casteo, por eso es que la sobrecarga es "explicit"
             * Lo que hago es castear de manera explicita, devolver el campo "entero" al hacer la asignacion
             */
        }
    }
}
