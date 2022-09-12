﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_ejercicio_en_clase_2
{
    public class Pluma
    {
        private string marca;
        private Tinta tinta;
        private int cantidad;

        public Pluma()
        {
            this.marca = "Sin marca";
            this.tinta = null;
            this.cantidad = 1;
        }
        public Pluma(string marca) : this()
        {
            this.marca = marca;
        }
        public Pluma(string marca, Tinta tinta) : this(marca)
        {
            this.tinta = tinta;
        }
        public Pluma(string marca, Tinta tinta, int cantidad) : this(marca, tinta)
        {
            this.cantidad = cantidad;
        }
        public string Mostrar()
        {
            return $"Marca: {this.marca} - Tinta: {(string)this.tinta} - Cantidad: {this.cantidad}";
        }
        public static bool operator == (Pluma pluma, Tinta tinta)
        {
            return pluma.tinta == tinta;
        }
        public static bool operator !=(Pluma pluma, Tinta tinta)
        {
            return !(pluma == tinta);
        }
        public static Pluma operator +(Pluma pluma, Tinta tinta)
        {
            if (pluma == tinta)
            {
                pluma.cantidad++;
            }
            return pluma;
        }
        public static Pluma operator -(Pluma pluma, Tinta tinta)
        {
            if (pluma == tinta)
            {
                pluma.cantidad --;
            }
            return pluma;
        }

        public static implicit operator string (Pluma pluma)
        {
            return pluma.Mostrar();
        }
    }
}
