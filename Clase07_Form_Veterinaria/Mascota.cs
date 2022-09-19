using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_7_Form_Veterinaria
{
    public class Mascota
    {
        #region Atributos

        public string nombre;
        public int edad;
        #endregion

        #region Constructor
        
        public Mascota (string n, int e)
        {
            this.edad = e;
            this.nombre = n;
        }

        #endregion

        #region Sobrecarga

        public static bool operator == (Mascota m, Mascota m2)
        {
            bool retorno = false;
            if (m.nombre == m2.nombre && m.edad == m2.edad)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Mascota m, Mascota m2)
        {
            return !(m == m2);
        }
        #endregion

        #region Metodos

        public override string ToString()
        {
            return "Mascota -> "+ this.nombre + " " + this.edad + " Años";
        }

        #endregion
    }
}
