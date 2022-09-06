using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_4_Ejercicio_en_clase
{
    class Cosa
    {
        private int entero;
        private string cadena;
        private DateTime fecha;
        //constructores
        public Cosa()
        {
            this.entero = 10;
            this.cadena = "sin valor";
            this.fecha = DateTime.Now;
        }
        public Cosa(string texto) : this()
        {
            this.cadena = texto;
        }
        public Cosa(string texto,int numero) : this(texto) 
        {
            this.entero = numero;
        }
        public Cosa(string texto,int numero,DateTime unaFecha) : this(texto,numero)
        {
            this.fecha = unaFecha;
        }

        //metodos
        public void EstablecerValor(int numeroEntero)
        {
            this.entero = numeroEntero;
        }
        public void EstablecerValor(string texto)
        {
            this.cadena = texto;
        }

        public void EstablecerValor(DateTime unaFecha)
        {
            this.fecha = unaFecha;
        }

        public string Mostrar()
        {
            return $"{this.entero} - {this.cadena} - {this.fecha.ToLongTimeString()}";
        }
        public static string Mostrar(Cosa unaCosa)
        {
            /*
             * haciendolo de esta manera estoy repitiendo lineas de codigo que ya utilice en la sobrecarga anterior de
             * este mismo metodo
            return $"{this.entero} - {this.cadena} - {this.fecha.ToLongTimeString()}" ;
            */

            //puedo reutilizar codigo si llamo al metodo mostrar anterior
            return unaCosa.Mostrar();
            //En este caso reutilizo el codigo del metodo mostrar anterior, ya que lo estoy haciendo sobre una instancia.
        }




    }
}
