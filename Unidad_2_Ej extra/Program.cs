using System;
/*
 * crear clase sello. poner atributo publico string. y hacer 2 metodos publicos "imrprimir " y "guardar"
 * */
namespace Unidad_2_Ej_extra
{
    class Program
    {
        static void Main(string[] args)
        {
            //cargo el mensaje hola mundo
            Sello.mensaje = "hola mundo";
            //muestro el mensaje
            Console.WriteLine(Sello.Imprimir());
            //borro el mensaje
            Sello.Borrar();
            //muestro que borro
            Console.WriteLine(Sello.Imprimir());

            Sello.mensaje = "Hola Mundo C#";
            
            Sello.color = ConsoleColor.Red;
            Sello.ImprimirEnColor();
            Console.WriteLine(Sello.Imprimir());
        }
    }
}
