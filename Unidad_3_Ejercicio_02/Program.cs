using System;
using BibliotecaEj02;
/*Crear una aplicación de consola y una biblioteca de clases que contenga la clase Persona.

Deberá tener los atributos:

nombre
fechaDeNacimiento
dni
Deberá tener un constructor que inicialice todos los atributos.

Construir los siguientes métodos para la clase:

Setter y getter para cada uno de los atributos.
CalcularEdad será privado y retornará la edad de la persona calculándola a partir de la fecha de nacimiento.
Mostrar retornará una cadena de texto con todos los datos de la persona, incluyendo la edad actual.
EsMayorDeEdad si es mayor de edad devuelve el valor “Es mayor de edad", sino devuelve “es menor”.
Instanciar 3 objetos de tipo Persona en el método Main.
Mostrar quiénes son mayores de edad y quiénes no.
*/

namespace Unidad_3_Ejercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime fecha = new DateTime(1991,08,20);

            Persona personUno = new Persona("juan", fecha, 36401197);

            
        }
    }
}
