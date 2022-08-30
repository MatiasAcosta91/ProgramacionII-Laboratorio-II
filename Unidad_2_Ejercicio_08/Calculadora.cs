using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_2_Ejercicio_08
{
    class Calculadora
    {
        public static int CalculadoraDeVida (int diaIngresado, int mesIngresado, int añoIngresado)
        {
            DateTime fechaActual = DateTime.Today;
            int añoActual = fechaActual.Year;
            int mesActual = fechaActual.Month;
            int diaActual = fechaActual.Day;
            int acumuladorDias = 0;
            //          CALCULO AÑOS
            //recorro desde el año ingresado hasta la fecha actual
            for (int i = añoIngresado; i < añoActual; i++)
            {
                if (Calculadora.EsBisiesto(i) == true)
                {
                    acumuladorDias += 366;
                }
                else
                {
                    acumuladorDias += 365;
                }
            }
            //CALCULO MESES
            
            for (int j = mesIngresado; j < mesActual; j++)
            {
                switch (j)
                { //enero, marzo, mayo, julio, agosto, octubre, diciembre tienen 31 dias
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        acumuladorDias += 31; 
                        break;
                        // abril, junio, septiembre y noviembre tienen 30 dias,
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        acumuladorDias += 30;
                        break;
                        //febrero tiene 29 si es bisiesto, 28 si no lo es                        
                    case 2: 
                        if (Calculadora.EsBisiesto(añoActual) == true)
                        {
                            acumuladorDias += 29;
                        }
                        else
                        {
                            acumuladorDias += 28;
                        }
                        break;
                }
                    
            }
            //AGREGO LA DIFERENCIA DE DIAS
            acumuladorDias += (diaActual - diaIngresado);
            
            return  acumuladorDias;
        }

        private static bool EsBisiesto (int año)
        {
            bool retorno = false;
            if (año % 4 == 0 && (año % 100 != 0) || (año % 100 == 0 && año % 400 == 0))
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
