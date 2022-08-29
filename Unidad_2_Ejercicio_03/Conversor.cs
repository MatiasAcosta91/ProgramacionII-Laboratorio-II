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
                    cociente = dividendo / 2;
                    resto = dividendo % 2;
                    dividendo = cociente; 
                retorno += resto.ToString();
            } while (cociente != 0);

            retorno = Conversor.InvertirCadena(retorno);
            return retorno;
        }

        public static  int ConvertirBinarioADecimal(int numeroEntero)
        {
            double resultado = 0;
            int retorno;
            string cadenaDecimal = numeroEntero.ToString();
            int len = cadenaDecimal.Length;
            int exponente = len-1;

            for (int i = 0; i < len; i++)
            {
                if (cadenaDecimal[i] == '1')
                {
                    resultado += Math.Pow(2, exponente);     
                }
                exponente--;
            }
            retorno = Convert.ToInt32(resultado);

            return retorno;
        }
    }
}
