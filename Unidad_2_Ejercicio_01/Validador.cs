using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_2_Ejercicio_01
{
    /// <summary>
    /// Permite realizar validaciones.
    /// </summary>
    class Validador
    {
        /// <summary>
        /// valida que el numero ingresado se encuentre entre dos valores
        /// </summary>
        /// <param name="valor"> valo que se valuara</param> 
        /// <param name="min"> valor minimo </param>
        /// <param name="max"> valor maximo</param>
        /// <returns> true/false</returns>
        public static bool validar (int valor, int min, int max)
        {
            bool retorno = false;
            if (valor <= max && valor >= min)
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
