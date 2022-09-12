using System;

namespace Biblioteca_ejercicio_en_clase_2
{
    public class Tinta
    {
        //atributos
        private ConsoleColor color;
        private ETipoTinta tipo;

        //Constructores

        public Tinta ()
        {
            this.color = ConsoleColor.Black;
            this.tipo = ETipoTinta.Comun;
        }
        public Tinta(ConsoleColor color) : this()
        {
            this.color = color;
        }
        public Tinta(ConsoleColor color, ETipoTinta tipoTinta) : this (color)
        {
            this.tipo = tipoTinta;
        }
        public string Mostrar()
        {
            return $"Color: {this.color} - Tinta: {this.tipo}";
        }
        public static string Mostrar(Tinta tinta)
        {
            return tinta.Mostrar();
        }
        //sobrecarga de operadores
        
        public static bool operator == (Tinta tinta1,Tinta tinta2)
        {
            return (tinta1.tipo ==  tinta2.tipo && tinta1.color == tinta2.color);
        }
        public static bool operator != (Tinta tinta1, Tinta tinta2)
        {
            return !(tinta1 == tinta2);
        }

        public static explicit operator string (Tinta tinta)
        {
            return tinta.Mostrar();
        }
    }
}
