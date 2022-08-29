using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_2_Ejercicio_05
{
    class Tabla
    {
        public static string CrearTablaMultiplicar (int numero)
        {
            StringBuilder stringTablas = new StringBuilder();
            stringTablas.AppendLine($"Tabla de multiplicar del numero {numero}");
            for (int i = 1; i <= 9; i++)
            {  
                stringTablas.AppendLine($"{ numero} x {i} = {i * numero}");
            }
            return stringTablas.ToString();

        }
    }
}
