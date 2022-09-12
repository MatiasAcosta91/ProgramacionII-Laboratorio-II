using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibilioteca__Unidad4_Ej_C01
{
    public class NumeroDecimal
    {
        //atributos
        private double numero;
        //constructor
        public NumeroDecimal (double numero)
        {
            this.numero = numero;
        }
        //Get
        public  double GetNumeroDecimal()
        {
            return this.numero;
        }
        //metodo de conversion
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

        public static string ConvertirDecimalABinario(double numeroEnetero)
        {
            double resto;
            int cociente;
            string retorno = "";
            int dividendo = (int) numeroEnetero;
            do
            {
                cociente = dividendo / 2; //divido el numero ingresado por 2
                resto = dividendo % 2; //obtengo el resto (0 o 1)
                dividendo = cociente; //piso el valor de dividnedo para la proxima vuelta dividirlo por dos
                retorno += resto.ToString(); //guardo en un string todos los restos obtenidos
            } while (cociente > 0); //itero siempre que el cociente sea distinto de 0

            retorno = NumeroDecimal.InvertirCadena(retorno); //invierto la cadena para obtener el numero en binario
            return retorno;
        }

        //sobrecargas
        //implicita
        public static implicit operator NumeroDecimal (double d)
        {
            return new NumeroDecimal(d);
        }
        //explicita
        public static explicit operator NumeroBinario (NumeroDecimal d)
        {
            return (NumeroBinario)ConvertirDecimalABinario(d.GetNumeroDecimal());
        }
        // + y -
        public static double operator + (NumeroDecimal dec,NumeroBinario bin)
        {
            return dec.GetNumeroDecimal() + ((NumeroDecimal)bin).GetNumeroDecimal();
        }
        public static double operator -(NumeroDecimal dec, NumeroBinario bin)
        {
            return dec.GetNumeroDecimal() - ((NumeroDecimal)bin).GetNumeroDecimal();
        }
        // == y !=
        public static bool operator == (NumeroDecimal dec, NumeroBinario bin)
        {
            return (dec.GetNumeroDecimal() == ((NumeroDecimal)bin).GetNumeroDecimal());
        }
        public static bool operator !=(NumeroDecimal dec, NumeroBinario bin)
        {
            return !(dec == bin);
        }
    }
}
