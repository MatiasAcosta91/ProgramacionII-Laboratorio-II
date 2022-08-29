using System;
/*
Realizar una clase llamada CalculadoraDeArea que posea tres métodos de clase (estáticos) que realicen el cálculo del área que corresponda:

public double CalcularAreaCuadrado(double longitudLado) {}

public double CalcularAreaTriangulo(double base, double altura) {}

public double CalcularAreaCirculo(double radio) {}

El ingreso de los datos como la visualización se deberán realizar desde el método Main().
*/

namespace Unidad_2_Ejercicio_06
{
    class Program
    {
        static void Main(string[] args)
        {
            int lado;
            int basee;
            int altura;
            int radio;
            double resultado;
            Console.WriteLine("Ingrese el lado del cuadrado: ");
            lado = int.Parse(Console.ReadLine());
            resultado = CalculadoraDeArea.CalcularAreaCuadrado(lado);
            Console.WriteLine("El area del cuadrado  es: "+resultado);

            Console.WriteLine("Ingrese La base del triangulo");
            basee = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la altura del triangulo: ");
            altura = int.Parse(Console.ReadLine());
            resultado = CalculadoraDeArea.CalcularAreaTriangulo(basee, altura);
            Console.WriteLine("El area del triangulo es: "+resultado);

            Console.WriteLine("Ingrese el radio del circulo: ");
            radio = int.Parse(Console.ReadLine());
            resultado = CalculadoraDeArea.CalcularAreaCirculo(radio);
            Console.WriteLine("El area del circulo es: "+resultado);

        }
    }
}
