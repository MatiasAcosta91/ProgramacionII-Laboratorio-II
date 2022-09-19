using System;
using Biblioteca_Unidad_6_Ej_en_clase_01;

namespace Unidad_6_Ejercicio_en_clase_01
{

    #region Consigna
    #region Parte 1
    /*
     Tempera{
(-)color : ConsoleColor
(-)marca : String
(-)cantidad : Int32
//constructor 3 parámetros
(-)Mostrar() : string//instancia
(+)Mostrar(Tempera) : string//clase
//sobrecargas
== (Tempera, Tempera) : bool //marca y color
implicit (Tempera) : int // cantidad
+ (Tempera, Tempera) : Tempera
-> si temperas iguales, acumula cantidad
+ (Tempera, int) : Tempera
-> acumula cantidad 
}*/
    #endregion
    #region Parte 2
    /*
     * En el Main
Crear 4 temperas:
1) Red-Alba-50
2) Blue-Alba-50
3) Red-Alba-25
4) Black-Pinturita-50
5) Green-Temperita-50
Comparar (temperas):
1) == 2)
1) == 3)
1) == 4)
1) == null
null == 1)
Sumar (temperas):
1) + 2)
1) + 3)
1) + 4)
1) + null
Sumar (temperas):
1) + 20
2) + 30
NOTA: luego de cada comparación, suma o resta, mostrar el contenido completo de la tempera.
     */
    #endregion
    #region Parte 3
    /*
     * Paleta{
(-)temperas : List<Tempera>
(-)cantidadMaximaColores : int
//constructor
(-)()//inicializa las temperas
(-)(int)//cantidad máx de colores
implicit (int) : Paleta
(-)Mostrar() : string
(-)obtenerIndice(Tempera) : int
*->retorna el índice donde se encuentra la tempera o valor neg. si no la encuentra.
explicit (Paleta) : string
==(Paleta, Tempera) : bool
*->si tempera está en paleta --> true
+(Paleta, Tempera) : Paleta
*->si tempera está en paleta --> incrementa la cantidad en la tempera.
*->si no está --> agrega la tempera en la paleta, siempre y cuando, no supere la cantidad máxima de colores.
-(Paleta, Tempera) : Paleta
*->si tempera está en paleta -> decrementa la cantidad en la tempera.
*)si la cantidad es menor o igual a cero, elimina la tempera (RemoveAt)
+(Paleta, Paleta) : Paleta
*->genera una paleta con los colores de ambas paletas.
*)si temperas son iguales-->suma cantidades
}
     */
    #endregion
    #region Parte 4
    /*
     *  En el Main
Crear 4 temperas:
1) Red-Alba-50
2) Blue-Alba-50
3) Red-Alba-25
4) Black-Pinturita-50
5) Green-Temperita-50
Comparar (temperas):
1) == 2)
1) == 3)
1) == 4)
1) == null
null == 1)
Sumar (temperas):
1) + 2)
1) + 3)
1) + 4)
1) + null
Sumar (temperas):
1) + 20
2) + 30
Crear paleta:
Máximo 3 temperas
Comparar (paleta - tempera)
p == 1)
Sumar (paleta - tempera)
p + 1)
p + 2)
p + 3)
p + 4)
p + 5)
Restar (paleta - tempera)
p - 1)
p - 2)
p - 5)
Crear otra paleta:
Máximo 2 temperas
Sumar (paleta - tempera)
p + 5)
p + 4)
p + 3)
p + 2)
Sumar (paleta - paleta)
NOTA: luego de cada comparación, suma o resta, mostrar el contenido completo de la tempera o paleta, según corresponda.
     */
    #endregion
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            //Parte 2
            Tempera t1 = new Tempera(ConsoleColor.Red, "Alba", 50);
            Tempera t2 = new Tempera(ConsoleColor.Blue, "Alba", 50);
            Tempera t3 = new Tempera(ConsoleColor.Red, "Alba", 25);
            Tempera t4 = new Tempera(ConsoleColor.Black, "Pinturita", 50);
            Tempera t5 = new Tempera(ConsoleColor.Green, "Temperita", 50);
            Tempera t6 = null;
            Tempera t7 = null;
            Console.WriteLine("-------Comparacion---------");
            Console.WriteLine("Comparo t1 y t2 " + (t1 == t2));
            Console.WriteLine("Comparo t1 y t3 " + (t1 == t3));
            Console.WriteLine("Comparo t1 y t4 " + (t1 == t4));
            Console.WriteLine("Comparo t1 y t6(null) " + (t1 == t6));
            Console.WriteLine("Comparo t6 (null) y t7 (null) " + (t6 == t7));

            Console.WriteLine("\n\n -------------Suma de dos temperas----------");
            Console.WriteLine(t1 + t2);
            Console.WriteLine("T1 + T2:" + Tempera.Mostrar(t1));
            Console.WriteLine(t1 + t3);
            Console.WriteLine("T1 + 3:" + Tempera.Mostrar(t1));
            Console.WriteLine(t1 + t4);
            Console.WriteLine("T1 + T4:" + Tempera.Mostrar(t1));
            Console.WriteLine(t1 + null);
            Console.WriteLine("T1 + null:" + Tempera.Mostrar(t1));





            Console.WriteLine("\n\n -------------Agregar Tempera----------");
            Console.WriteLine(Tempera.Mostrar(t1));
            Console.WriteLine(Tempera.Mostrar(t2));

            Console.WriteLine("Sumo 20 a tempera 1");
            Console.WriteLine(t1 + 20);
            Console.WriteLine("Sumo 30 a tempera 2");
            Console.WriteLine(t2 + 30);

            Console.WriteLine(Tempera.Mostrar(t1));
            Console.WriteLine(Tempera.Mostrar(t2));

            //Parte 4

            Console.WriteLine("------------- PALETAS ------------------");
            Paleta paleta1 = 3;
            Console.WriteLine("verifico si p1 tiene t1 (no la tiene)");
            Console.WriteLine(paleta1 == t1);
            paleta1 -= t1; //t1 y t3 son las mismas
            paleta1 += t2;
            paleta1 += t3;//t1 y t3 son las mismas
            paleta1 += t4;
            paleta1 += t5;
            Console.WriteLine("\nCargo 5 temperas en la p1 y muestro\n");
            Console.WriteLine((string)paleta1);
            paleta1 -= t1;
            paleta1 -= t2;
            paleta1 -= t5;
            Console.WriteLine("\nsaco 3 temperas y muestro p1\n");
            Console.WriteLine((string)paleta1);

            Console.WriteLine("\nCreo otra paleta\n");
            Paleta paleta2 = 2;
            paleta2 += t5;
            paleta2 += t4;
            paleta2 += t3;
            paleta2 += t2;
            Console.WriteLine("\n\nLe cargo colores y muestro");
            Console.WriteLine((string)paleta2);

            paleta1 += paleta2;
            Console.WriteLine("\n\n  SUMO LAS DOS PALETAS\n\n");
            Console.WriteLine((string)paleta1);






        }
    }
}
