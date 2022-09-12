using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Peso
    {
        private double cantidad;
        private static double cotzRespectoDolar;
        //---------------------------------------------Constructores
        static Peso()
        {
            Peso.cotzRespectoDolar =102.65;
        }
        public Peso (double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Peso (double cantidad, double cotizacion) : this (cantidad)
        {
            Peso.cotzRespectoDolar = cotizacion;
        }
        //---------------------------------------------GET
        public static double GetCotizacion()
        {
            return Peso.cotzRespectoDolar;
        }
        public double GetCantidad()
        {
            return this.cantidad;
        }
        //---------------------------------------------SOBRECARGA OPERADORES
        //implicita
        public static implicit operator Peso (double d)
        {
            return new Peso(d);
        }
        //Explicita
        public static explicit operator Dolar (Peso p)
        {
            return new Dolar(p.GetCantidad() / Peso.GetCotizacion());
        }
        public static explicit operator Euro (Peso p)
        {
            return (Euro)(Dolar)p;
        }
        // == Y != 
        public static bool operator == (Peso p1, Peso p2)
        {
            return (p1.GetCantidad() == p2.GetCantidad());
        }
        public static bool operator !=(Peso p1, Peso p2)
        {
            return !(p1 == p2);
        }
        public static bool operator == (Peso p, Euro e)
        {
            return (p.GetCantidad() == ((Peso)e).GetCantidad());
        }
        public static bool operator !=(Peso p, Euro e)
        {
            return !(p == e);
        }
        public static bool operator == (Peso p, Dolar d)
        {
            return (p.GetCantidad() == ((Peso)d).GetCantidad());
        }
        public static bool operator !=(Peso p, Dolar d)
        {
            return !(p == d);
        }
        //-
        public static Peso operator -( Peso p, Dolar d)
        {
            double cantidad = p.GetCantidad() - ((Peso)d).GetCantidad();
            return new Peso(cantidad);
        }
        public static Peso operator -(Peso p, Euro d)
        {
            double cantidad = p.GetCantidad() - ((Peso)d).GetCantidad();
            return new Peso(cantidad);
        }
        //+
        public static Peso operator +(Peso p, Dolar d)
        {
            double cantidad = p.GetCantidad() + ((Peso)d).GetCantidad();
            return new Peso(cantidad);
        }
        public static Peso operator +(Peso p, Euro d)
        {
            double cantidad = p.GetCantidad() + ((Peso)d).GetCantidad();
            return new Peso(cantidad);
        }
    }
}
