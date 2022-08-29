using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_2_Ejercicio_02
{
    class Validador
    {
        public static bool ValidarRespuesta (char respuesta)
        {
            bool retorno = false;
            if (respuesta == 'S' || respuesta == 's')
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
