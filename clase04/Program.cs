using System;

namespace clase04
{
    class Program
    {
        static void Main(string[] args)
        {
            //--------------------------------SOBRECARGAS-----------------------------------------

            Vehiculo nuevoAuto = new Vehiculo(2);
            Vehiculo nuevoAuto2 = new Vehiculo(4,"ford");
            Vehiculo nuevoAuto3 = new Vehiculo(4,"renault","rojo");
            Vehiculo nuevoAuto4 = new Vehiculo(2,"volkswagen","azul",40);

            Console.WriteLine(nuevoAuto.Mostrar());
            Console.WriteLine(nuevoAuto2.Mostrar());
            Console.WriteLine(nuevoAuto3.Mostrar());
            Console.WriteLine(nuevoAuto4.Mostrar());
            
          
        }
    }
}
