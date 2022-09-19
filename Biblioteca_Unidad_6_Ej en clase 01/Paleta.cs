using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Unidad_6_Ej_en_clase_01
{

    public class Paleta
    {
        private List<Tempera> temperas;
        private int cantidadMaximaColores;

        private Paleta()
        {
            this.temperas = new List<Tempera>();
        }
        private Paleta(int cantidadMax) : this()
        {
            this.cantidadMaximaColores = cantidadMax;
        }
        public static implicit operator Paleta(int cantidad)
        {
            return new Paleta(cantidad);
            //Al ser los constructores privados, solo voy a poder crear la paleta de manera implicta
            //en el main haria Paleta paleta1 = 5;
        }
        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Tempera item in this.temperas)
            {
                sb.AppendLine(Tempera.Mostrar(item));
            }
            sb.AppendLine($"Cantidad Maxima Colores: {this.cantidadMaximaColores}");
            return sb.ToString();
        }
        private int ObtenerIndice(Tempera t)
        {
            int retorno = -1;
            for (int i = 0; i < this.temperas.Count; i++)
            {
                if (this.temperas[i] == t)
                {
                    retorno = i;
                    break;
                }
            }
            return retorno;
        }
        public static explicit operator string(Paleta p)
        {
            return p.Mostrar();
            //desde el main tendria que castear mi objeto a string para mostrarlo.
        }
        public static bool operator ==(Paleta p, Tempera t)
        {
            bool retorno = false;
            if (p.ObtenerIndice(t) >= 0) //si el indice es mayor a cero es xq la tempera esta en la paleta
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Paleta p, Tempera t)
        {
            return !(p == t);
        }
        public static Paleta operator +(Paleta p, Tempera t)
        {
            int indice = p.ObtenerIndice(t);
            if (indice > -1) //si el indice es 0 o mayor la tempera esta en la paleta
            {
                p.temperas[indice] += t; //agrego mas cantidad de tempera en la paleta
            }
            else //Si la tempera no existe en la paleta creo la tempera
            {
                if (p.temperas.Count < p.cantidadMaximaColores)
                {
                    p.temperas.Add(t);
                }
            }
            return p;
        }
        public static Paleta operator -(Paleta p, Tempera t)
        {
            int indice = p.ObtenerIndice(t);
            if (indice > -1)
            {
                p.temperas[indice] += (-t);
                //Como solo tenho hecha la sobrecarga del +
                //para sumar temperas y no la del - para restarlas, hago la suma pero pongo la tempera
                //en negativo
                if (p.temperas[indice] <= 0)
                {//si la cantidad de esa tempera en la paleta es 0 o menos entro al if
                    p.temperas.RemoveAt(indice);//remuevo la tempera
                }
            }
            return p;
        }
        public static Paleta operator +(Paleta p1, Paleta p2)
        {
            Paleta nuevaPaleta = new Paleta(p1.temperas.Count + p2.temperas.Count);
            {
                nuevaPaleta.temperas = p1.temperas; //A la nueva paleta le aisgno
                //todas las temperas de la paleta p1
                for (int i = 0; i < p2.temperas.Count; i++)
                {
                    nuevaPaleta += p2.temperas[i]; //Reutilizo la sobrebarga de la linea 69
                    //si la tempera de la paleta 2 existe la sumo, si no existe la agrego.
                }
            }
            return nuevaPaleta;
        }


    }

}
