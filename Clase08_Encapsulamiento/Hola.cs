using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase08_Encapsulamiento
{
    public class Hola
    {
        private string saludo;
        private string[] variantes = { "Buenos dias", "Buenas tardes", "Buenas noches" };

        public string this [int index]
        {
            get
            {
                return this.variantes[index];
            }
            set
            {
                this.variantes[index] = value;
            }
        }
    }
}
