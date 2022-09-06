using System;
using BibliotecaEstudiante;



/*
 Crear una aplicación de consola y una biblioteca de clases que contenga la clase del siguiente diagrama:

Diagrama de clases

La clase Estudiante:

Tendrá un constructor estático que inicializará el atributo estático random.
Tendrá un constructor de instancia que inicializará los atributos nombre, apellido y legajo.
El método setter SetNotaPrimerParcial permitirá cambiar el valor del atributo notaPrimerParcial.
El método setter SetNotaSegundoParcial permitirá cambiar el valor del atributo notaSegundoParcial.
El método privado CalcularPromedio retornará el promedio de las dos notas.
El método CalcularNotaFinal deberá retornar la nota del final con un numero aleatorio entre 6 y 10 incluidos siempre y cuando las notas del primer y segundo parcial sean mayores o iguales a 4, caso contrario la inicializará con el valor -1.
El método Mostrar utilizará StringBuilder para armar una cadena de texto con todos los datos de los alumnos:
Nombre, apellido y legajo.
Nota del primer y segundo parcial.
Promedio.
Nota final. Se mostrará sólo si el valor es distinto de -1, caso contrario se mostrará la leyenda "Alumno desaprobado".
Crear tres instancias de la clase Estudiante (tres objetos) en el método Main.
Cargar las notas del primer y segundo parcial a todos los alumnos. Dos deberán estar aprobados y uno desaprobado.
Mostrar los datos de todos los alumnos.
IMPORTANTE
Para darle un valor aleatorio a la nota final utilice el método de instancia Next de la clase Random.
*/

namespace Unidad_3_Ejercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudiante alumno1 = new Estudiante("Juan", "Perez", "12345");
            alumno1.SetNotaPrimerParcial(2);
            alumno1.SetNotaSegundoParcial(1);

            Estudiante alumno2 = new Estudiante("Carlos", "Avena", "54123");
            alumno2.SetNotaPrimerParcial(7);
            alumno2.SetNotaSegundoParcial(9);


            Estudiante alumno3 = new Estudiante("Franco", "Green", "8124");
            alumno3.SetNotaPrimerParcial(10);
            alumno3.SetNotaSegundoParcial(10);

            Console.WriteLine(alumno1.Mostrar());
            Console.WriteLine(alumno2.Mostrar());
            Console.WriteLine(alumno3.Mostrar());
   
        }
    }
}
