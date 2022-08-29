using System;
/*
 * Un centro numérico es un número que separa una lista de números enteros (comenzando en 1) en dos grupos de números, cuyas sumas son iguales.

El primer centro numérico es el 6, el cual separa la lista (1 a 8) en los grupos: (1; 2; 3; 4; 5) y (7; 8) cuyas sumas son ambas iguales a 15. El segundo centro numérico es el 35, el cual separa la lista (1 a 49) en los grupos: (1 a 34) y (36 a 49) cuyas sumas son ambas iguales a 595.

Se pide elaborar una aplicación que calcule los centros numéricos entre 1 y el número que el usuario ingrese por consola.
*/
namespace Unidad_1_Ejercicio_05
{
    class Program
    {


        static void Main(string[] args)
        {
            bool esNumero;
            string valorIngresado;
            int numeroInicial = 1;
            int numeroFinal;
            int acumuladorGrupoA = 0;
            int acumuladorGrupoB = 0;
            int centro = 1;


            Console.WriteLine("Ingrese un numero mayor a 1: ");
            valorIngresado = Console.ReadLine();
            esNumero = int.TryParse(valorIngresado, out numeroFinal);
            while (esNumero == false || numeroFinal < numeroInicial)
            {
                Console.WriteLine("ERROR:Ingrese un numero mayor a 1: ");
                valorIngresado = Console.ReadLine();
                esNumero = int.TryParse(valorIngresado, out numeroFinal);
            }

            for (int i = numeroInicial; i < numeroFinal; i++)
            {
                //Calculo Grupo A
                for (int j = numeroInicial; j < centro; j++)
                {
                    acumuladorGrupoA += j;
                }
                //Calculo Grupo B
                for (int k = centro + 1; k <= numeroFinal; k++)
                {
                    acumuladorGrupoB += k;
                    if (acumuladorGrupoA == acumuladorGrupoB || acumuladorGrupoB>acumuladorGrupoA)
                    {
                        break;
                    }
                }

                if (acumuladorGrupoA == acumuladorGrupoB)
                {
                    Console.WriteLine("es un centro numerico: " + centro);
                }
                centro++;
                acumuladorGrupoA = 0;
                acumuladorGrupoB = 0;
            }


        }
    }
}
