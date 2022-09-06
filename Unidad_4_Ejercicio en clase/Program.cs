using System;

namespace Unidad_4_Ejercicio_en_clase
{
    class Program
    {
        static void Main(string[] args)
        {

            
            DateTime fecha = new DateTime(2022, 9, 6);
            Cosa nuevaCosa = new Cosa("asd", 555, fecha);


            //Muestro vacio
            Console.WriteLine(nuevaCosa.Mostrar()); 
            //cargo con valores
            nuevaCosa.EstablecerValor(124241);
            nuevaCosa.EstablecerValor("hola");
            nuevaCosa.EstablecerValor(fecha);
            //muestro con valores con metodo de instancia
            Console.WriteLine(nuevaCosa.Mostrar());
            //muestro valores con metodo estatico
            Console.WriteLine(Cosa.Mostrar(nuevaCosa)); 





        }


    }
}
