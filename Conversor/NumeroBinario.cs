using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibilioteca__Unidad4_Ej_C01
{
    public class NumeroBinario
    {
        //atributos
        private string numero;
        //conversor
        public  NumeroBinario(string numero)
        {
            this.numero = numero;
        }
        //get
        public string GetNumeroBinario()
        {
            return this.numero;
        }
        //metodo de conversion
        public static double ConvertirBinarioADecimal(string numeroEntero)
        {
            double retorno = 0;
            string cadenaDecimal = numeroEntero.ToString(); //transformo el numero ingresado en string
            int len = cadenaDecimal.Length;//obtengo el largo de la candena
            int exponente = len - 1; //establesco el exponente como su lugar en la cadena -1.

            for (int i = 0; i < len; i++)
            {
                if (cadenaDecimal[i] == '1') //elevo al exponente solo  cuando haya un 1.
                {
                    retorno += Math.Pow(2, exponente);//multiplico la base 2 por el exponente que corresponda al lugar-1     
                }
                exponente--; //resto el exponente para la prox vuelta
            }
            return retorno;
        }

        //sobrecargas
        //implicita
        public static implicit operator NumeroBinario (string cadena)
        {
            return new NumeroBinario(cadena);
        }
        //explicita

        public static explicit operator NumeroDecimal (NumeroBinario b)
        {
            return (NumeroDecimal)ConvertirBinarioADecimal(b.GetNumeroBinario());
        }
        // + y -
        public static string operator +(NumeroBinario bin, NumeroDecimal dec)
        {
            double suma = ConvertirBinarioADecimal(bin.GetNumeroBinario()) + dec.GetNumeroDecimal();
            return NumeroDecimal.ConvertirDecimalABinario(suma); 
        }
        public static string operator -(NumeroBinario bin, NumeroDecimal dec)
        {
            double suma = ConvertirBinarioADecimal(bin.GetNumeroBinario()) - dec.GetNumeroDecimal();
            return NumeroDecimal.ConvertirDecimalABinario(suma);
        }
        // == y !=
        public static bool operator == (NumeroBinario bin,NumeroDecimal dec)
        {
            return (bin.GetNumeroBinario() == ((NumeroBinario)dec).GetNumeroBinario());
        }
        public static bool operator !=(NumeroBinario bin, NumeroDecimal dec)
        {
            return !(bin == dec);
        }
    }
}
