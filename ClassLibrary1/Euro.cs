﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro
    {
        private double cantidad;
        private static double cotzRespectoDolar;
        //---------------------------------------------Constructores
        static Euro()
        {
            Euro.cotzRespectoDolar = 1 / 1.17;
        }
        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Euro(double cantidad, double cotizacion) : this(cantidad)
        {
            Euro.cotzRespectoDolar = cotizacion;
        }
        //---------------------------------------------GET
        public static double GetCotizacion()
        {
            return Euro.cotzRespectoDolar;
        }
        public double GetCantidad()
        {
            return this.cantidad;
        }
        //---------------------------------------------SOBRECARGA OPERADORES
        //Implicita
        public static implicit operator Euro(double d)
        {
            return new Euro(d);
        }
        //Explicita
        public static explicit operator Dolar(Euro e)
        {
            return new Dolar(e.cantidad / Euro.GetCotizacion());
        }
        public static explicit operator Peso(Euro e)
        {
            return (Peso)(Dolar)e;
        }
        // == y !=
        public static bool operator ==(Euro e1, Euro e2)
        {
            return e1.GetCantidad() == e2.GetCantidad();
        }
        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }
        public static bool operator ==(Euro e, Dolar d)
        {
            return (((Dolar)e).GetCantidad() == d.GetCantidad());
        }
        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e == d);
        }
        public static bool operator ==(Euro e, Peso p)
        {
            return (e.GetCantidad() == ((Euro)p).GetCantidad());
        }
        public static bool operator !=(Euro e, Peso p)
        {
            return !(e == p);
        }
        //-
        public static Euro operator -(Euro e, Dolar d)
        {
            double cantidad = e.GetCantidad() - ((Euro)d).GetCantidad();
            return new Euro(cantidad);
        }
        public static Euro operator -(Euro e, Peso p)
        {
            double cantidad = e.GetCantidad() - ((Euro)p).GetCantidad();
            return new Euro(cantidad);
        } 
        // +
        public static Euro operator +(Euro e, Dolar d)
        {
            double cantidad = e.GetCantidad() + ((Euro)d).GetCantidad();
            return new Euro(cantidad);
        }
        public static Euro operator +(Euro e, Peso p)
        {
            double cantidad = e.GetCantidad() + ((Euro)p).GetCantidad();
            return new Euro(cantidad);
        }

    }
}
