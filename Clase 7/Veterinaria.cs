using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_7
{
    class Veterinaria
    {
        #region Atributos

        public int capacidad;
        public List<Mascota> lista;

        #endregion

        #region Constructores
        
        public Veterinaria()
        {
            this.capacidad = 4;
            this.lista = new List<Mascota>();
        }
        public Veterinaria (int capacidad) :this()
        {
            this.capacidad = capacidad;
        }

        #endregion

        #region Metodos

        public bool BuscarMascota ( Mascota m)
        {
            bool retorno = false;
            foreach (Mascota item in this.lista)
            {
                if(item == m)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        public bool Agregar (Mascota m)
        {
            bool seAgrega = false;
            if (this.lista.Count < this.capacidad) //verifico si hay capacidad
            {
                if(!this.BuscarMascota(m)) //verifico si la mascota ya esta ingresada
                {
                    this.lista.Add(m);
                    seAgrega = true;
                    Console.WriteLine($"Mascota agregada! Nombre: {m.nombre} Edad: {m.edad}");
                }
                else
                {
                    Console.WriteLine($"La mascota Nombre: {m.nombre} Edad: {m.edad} ya se encuentra ingresada");
                }
            }
            else
            {
                Console.WriteLine("No hay espacio disponible");
            }
            return seAgrega;
        }

        public bool Eliminar (Mascota m)
        {
            bool eliminada = false;
            foreach (Mascota item in this.lista)
            {
                if (item == m)
                {
                    lista.Remove(item);
                    eliminada = true;
                    Console.WriteLine("Mascota Eliminada");
                    break;
                }
            }
            return eliminada;
        }
        //Tambien podria haberlo hecho de la siguiente manera
        /*
        public bool Eliminara(Mascota m)
        {
            bool elimina = false;
            for (int i = 0; i < this.lista.Count; i++)
            {
                if (this.lista[i] == m)
                {
                    this.lista.RemoveAt(i);
                    elimina = true;
                    break;
                }
            }
            return elimina;
        }
        */
        #endregion
    }
}
