using System;
using System.Text;

namespace Biblioteca_Unidad4_Ej_C02
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string marca, string codigo, float precio)
        {
            this.marca = marca;
            this.codigoDeBarra = codigo;
            this.precio = precio;
        }
        public string GetMarca()
        {
            return this.marca;
        }
        public float GetPrecio()
        {
            return this.precio;
        }
        public static string MostrarPorducto(Producto p)
        {
            StringBuilder texto = new StringBuilder();
            texto.Append($"Marca: " + p.marca + " Precio: " + p.precio + " Codigo de barras: " + p.codigoDeBarra);
            return texto.ToString();
        }
        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }
        public static bool operator ==(Producto p1, Producto p2)
        {
            return (p1.marca == p2.marca && p1.codigoDeBarra == p2.codigoDeBarra);
        }
        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }
        public static bool operator ==(Producto p, string m)
        {
            return (p.marca == m);
        }
        public static bool operator !=(Producto p, string m)
        {
            return !(p == m);
        }
    }

}
