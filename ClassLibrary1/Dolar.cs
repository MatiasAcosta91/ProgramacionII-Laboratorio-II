using System;

namespace Billetes
{
    public class Dolar
    {
        private double cantidad;
        private static double cotzRespectoDolar;
        //---------------------------------------------Constructores
        static Dolar()
        {
            Dolar.cotzRespectoDolar = 1;
        }
      public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Dolar(double cantidad, double cotizacion) : this(cantidad)
        {
            Dolar.cotzRespectoDolar = cotizacion;
        }
        //---------------------------------------------GET
        public static double GetCotizacion()
        {
            return Dolar.cotzRespectoDolar;
        }
        public double GetCantidad()
        {
            return this.cantidad;
        }
        //---------------------------------------------SOBRECARGA OPERADORES
        //Implicita
        public static implicit operator Dolar(double d)
        {
            return new Dolar(d); // es una sobrecarga implicita, si tengo una variable tipo Dolar llamada ej1, si hago ej1 = 20; le cargara el valor 20 en cantidad.
        }
        //Explicita
        public static explicit operator Euro (Dolar d)
        {
            return new Euro(d.cantidad * Euro.GetCotizacion());
        }
        public static explicit operator Peso (Dolar d)
        {
            return new Peso(d.cantidad * Peso.GetCotizacion());
        }
        // == y !=
        public static bool operator == (Dolar d1, Dolar d2)
        {
            bool retorno = false;
            if (d1.cantidad == d2.cantidad)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Dolar d1, Dolar d2)
        {

            return !(d1 == d2);
        }
        public static bool operator ==(Dolar d, Euro e)
        {
            bool retorno = false;
            if (d.GetCantidad() == ((Dolar)e).GetCantidad())
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator != (Dolar d, Euro e)
        {
            return !(d == e);
        }
        public static bool operator == (Dolar d, Peso p)
        {
            return (d.GetCantidad() == ((Dolar)p).GetCantidad());
        }
        public static bool operator !=(Dolar d, Peso p)
        {
            return !(d == p);
        }
        //-
        public static Dolar operator -(Dolar d, Euro e)
        {
            double cantidad = d.GetCantidad() - ((Dolar)e).GetCantidad();
            return new Dolar(cantidad);
        }
        public static Dolar operator - (Dolar d, Peso p)
        {
            double cantidad = d.GetCantidad() - ((Dolar)p).GetCantidad();
            return new Dolar(cantidad);
        }
        //+
        public static Dolar operator + (Dolar d, Euro e)
        {
            double cantidad = d.GetCantidad() + ((Dolar)e).GetCantidad();
            return new Dolar(cantidad);
        }
        public static Dolar operator +(Dolar d, Peso p)
        {
            double cantidad = d.GetCantidad() + ((Dolar)p).GetCantidad();
            return new Dolar(cantidad);
        }


    }
}
