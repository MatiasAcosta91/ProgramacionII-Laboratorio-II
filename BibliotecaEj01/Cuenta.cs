using System;
//---ATRIBUTOS
//---PROPIEDADES
//---CONSTRUCTORES
//---METODOS
//---OPERADORES
namespace BibliotecaEj01
{
    public class Cuenta
    {
        private string titular;
        private int cantidad;

        public Cuenta (string nombre, int cantidad)
        {
            this.titular = nombre;
            this.cantidad = cantidad;       
        }
        public string GetterTitular ()
        {
            return  this.titular;
        }

        public int GetterSaldo()
        {
            return this.cantidad;
        }
        public void Ingresar(int ingreso)
        {
            if (ingreso > 0)
            {
                this.cantidad += ingreso;
            }
        }
        public void Retirar (int retiro)
        {
            this.cantidad -= retiro;
        }
        public void Mostrar ()
        {
            Console.WriteLine($" Titular :{this.titular}    Saldo: {this.cantidad}");
        }

    }
}
