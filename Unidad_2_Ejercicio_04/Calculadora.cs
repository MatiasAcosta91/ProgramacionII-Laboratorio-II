using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_2_Ejercicio_04
{
    class Calculadora
    {
        static public bool OperacionOk;
        public static double Calcular (int primerOperando, int segundoOperando,char operador)
        {
            double retorno = 0;
            Calculadora.OperacionOk = true;
            switch(operador)
            {
                case '+':
                    retorno = primerOperando + segundoOperando;
                    break;
                case '-':
                    retorno = primerOperando - segundoOperando;
                    break;
                case '/':
                    if (Validar(segundoOperando) == true)
                    {
                        retorno = primerOperando / segundoOperando;
                    }
                    else
                    {
                        OperacionOk = false;
                    }
                    break;
                case '*':
                    retorno = primerOperando * segundoOperando;
                    break;
            }

            return retorno;
        }

        private static bool Validar (int operando)
        {
            bool retorno = true;
            if (operando == 0)
            {
                retorno = false;
            }
            return retorno;
        }
    }
}
