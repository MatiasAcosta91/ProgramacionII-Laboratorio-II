using System;
/*Se debe pedir el ingreso por teclado del valor hora, el nombre, la antigüedad (en años) y la cantidad de horas trabajadas en el mes de N cantidad 
de empleados de una fábrica. Se pide calcular el importe a cobrar teniendo en cuenta que el total (que resulta de multiplicar el valor
 hora por la cantidad de horas trabajadas), hay que sumarle la cantidad de años trabajados multiplicados por $150, y al total de todas esas 
operaciones restarle el 13% en concepto de descuentos. Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora, 
el total a cobrar en bruto y el total a cobrar neto de todos los empleados ingresados.
 */

namespace Unidad_1_Ejercicio_07
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            
            float precioHora;
            int antiguedad;
            int horasTrabajadas;
            float totalBruto;
            float totalNeto;
            string CadenaFinal = "";
            string continuar = "s";

            do
            {
                Console.WriteLine("Ingrese Nombre: ");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingrese horas trabajadas: ");
                horasTrabajadas = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese precio por hora: ");
                precioHora = float.Parse(Console.ReadLine());
                Console.WriteLine("ingrese antiguedad en años: ");
                antiguedad = int.Parse(Console.ReadLine());

                totalBruto = (horasTrabajadas * precioHora) + (antiguedad * 150);
                totalNeto = totalBruto * .87F;

                CadenaFinal += "Nombre: " + nombre + " Antiguedad: " + antiguedad + " Valor Hora: $" + precioHora + " Total Bruto: $" + totalBruto + " Total Neto: $" + totalNeto + "\n";
                Console.WriteLine(CadenaFinal);
                Console.WriteLine("Desea continuar? s/n:");
                continuar = Console.ReadLine();
                Console.Clear();
            } while (continuar == "s");




        }
    }
}
