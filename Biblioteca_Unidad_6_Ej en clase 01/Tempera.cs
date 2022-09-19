using System;

namespace Biblioteca_Unidad_6_Ej_en_clase_01
{
    //PARTE 1
    public class Tempera
    {
        private ConsoleColor color;
        private string marca;
        private int cantidad;

        public Tempera(ConsoleColor color, string marca, int cantidad)
        {
            this.color = color;
            this.marca = marca;
            this.cantidad = cantidad;
        }
        private string Mostrar()
        {
            return "Color: " + this.color + " marca: " + this.marca + " cantidad: " + this.cantidad;
        }
        public static string Mostrar(Tempera t)
        {
            return t.Mostrar();
        }

        public static bool operator ==(Tempera t1, Tempera t2)
        {
            bool retorno = false;
            if (t1 is null && t2 is null)
            {
                retorno = true;
            }
            else if ((t1 is not null) && (t2 is not null) && t1.marca == t2.marca && t1.color == t2.color)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Tempera t1, Tempera t2)
        {
            return !(t1 == t2);
        }
        public static implicit operator int (Tempera t)
        {
            return t.cantidad;
        }
        public static Tempera operator + (Tempera t1,Tempera t2)
        { 
            if (t1 == t2)
            {
                t1 += t2.cantidad; //reutilizo la sobrecarga + que esta abajo
            }
            return t1;
        }
        public static Tempera operator + (Tempera t, int cantidad)
        {
            t.cantidad += cantidad;
            return t;
        }
       
    }
}
