using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_2_Ejercicio_03
{
    class Conversor
    {
        /// <summary>
        /// Inverte el orden de una cadena tipo string.
        /// </summary>
        /// cadena a ser invertida
        /// <param name="cadena"></param>
        /// retorna el string invertido
        /// <returns></returns>
        private static string InvertirCadena(string cadena)
        {
            string retorno = "";
            int len = cadena.Length;
            for (int i = len - 1; i >= 0; i--)
            {
                retorno += cadena[i];
            }
            return retorno;
        }
        public static string ConvertirDecimalABinario(int numeroEnetero)
        {
            int resto;
            int cociente;
            string retorno="";
            int dividendo = numeroEnetero;
            do
            {   
                    cociente = dividendo / 2; //divido el numero ingresado por 2
                    resto = dividendo % 2; //obtengo el resto (0 o 1)
                    dividendo = cociente; //piso el valor de dividnedo para la proxima vuelta dividirlo por dos
                retorno += resto.ToString(); //guardo en un string todos los restos obtenidos
            } while (cociente != 0); //itero siempre que el cociente sea distinto de 0

            retorno = Conversor.InvertirCadena(retorno); //invierto la cadena para obtener el numero en binario
            return retorno;
        }

        public static  int ConvertirBinarioADecimal(int numeroEntero)
        {
            double resultado = 0;
            int retorno;
            string cadenaDecimal = numeroEntero.ToString(); //transformo el numero ingresado en string
            int len = cadenaDecimal.Length;//obtengo el largo de la candena
            int exponente = len-1; //establesco el exponente como su lugar en la cadena -1.

            for (int i = 0; i < len; i++)
            {
                if (cadenaDecimal[i] == '1') //elevo al exponente solo  cuando haya un 1.
                {
                    resultado += Math.Pow(2, exponente);//multiplico la base 2 por el exponente que corresponda al lugar-1     
                }
                exponente--; //resto el exponente para la prox vuelta
            }
            retorno = Convert.ToInt32(resultado);

            return retorno;
        }
    }
}
