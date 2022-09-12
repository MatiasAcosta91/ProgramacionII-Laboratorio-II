using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase04
{
    class Vehiculo
    {
        private int puerta;
        private string marca;
        private string color;
        private int listrosNafta;
        //---------------------CONSTRUCTORES
        //
        /*
        public Vehiculo(int puertas)
        {
            this.puerta = puertas; 
        }

        public Vehiculo(string marca, int puertas) : this(puertas)
        {
            this.puerta = puertas;
            this.marca = marca;
        }
        public  Vehiculo (string marca,int puertas,string color) : this(marca, puertas)
        {
            this.puerta = puertas;
            this.marca = marca;
            this.color = color;
        }
        public Vehiculo (string marca, int puertas, string color, int nafta) : this(marca,puertas,color)
        {
            this.puerta = puertas;
            this.marca = marca;
            this.color = color;
            this.listrosNafta = nafta;
        }
        */
        //---------------------Sobrecarga de constructores
        //Nos permite desde un constructor llamar a oto para no repetir lineas de codigo.
        public Vehiculo(int puertas)
        {
            this.puerta = puertas;
        }

        public Vehiculo(int puertas, string marca) : this(puertas) //este constructor llama al constructor de puertas
        {     
            this.marca = marca;
        }
        public Vehiculo(int puertas, string marca, string color) : this(puertas,marca) //llama al constructor de puertas y marca
        {
            this.color = color;
        }
        public Vehiculo(int puertas,string marca, string color, int nafta) : this(puertas,marca,color) //llama al const puertas marca color
        {
            this.listrosNafta = nafta;
        }
        public string Mostrar()
        {
            StringBuilder asd = new StringBuilder();

            asd.AppendLine($"Puertas:" + this.puerta);
            asd.AppendLine($"Marca: " + this.marca);
            asd.AppendLine($"Color: " + this.color);
            asd.AppendLine($"Litros: " + this.listrosNafta);
            return asd.ToString();
        }
        //--------------------SOBRECARGA DE UN METODO
        //La sobrecarga de un metodo nos permite tener un unico metodo, el cual puede recibir valores de distinto tipo y orden
        //y retornar cosas distintas.
        public string Mostrar(string mensaje)
        {
            StringBuilder asd = new StringBuilder();

            asd.AppendLine($"Puertas:" + this.puerta);
            asd.AppendLine($"Marca: " + this.marca);
            asd.AppendLine($"Color: " + this.color);
            asd.AppendLine($"Litros: " + this.listrosNafta);
            asd.AppendLine($"Muestro mensaje extra: " + mensaje);
            return asd.ToString();
        }
        public string Mostrar(string mensaje,int numero)
        {
            StringBuilder asd = new StringBuilder();

            asd.AppendLine($"Puertas:" + this.puerta);
            asd.AppendLine($"Marca: " + this.marca);
            asd.AppendLine($"Color: " + this.color);
            asd.AppendLine($"Litros: " + this.listrosNafta);
            asd.AppendLine($"Muestro mensaje extra: " + mensaje);
            asd.AppendLine($"Muestro numero extra: " + numero);
            return asd.ToString();
        }
        //--------------------------------------SOBRECARGA DE OPERADORES

    }   
}
