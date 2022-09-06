using System;
//---ATRIBUTOS
//---PROPIEDADES
//---CONSTRUCTORES
//---METODOS
//---OPERADORES
namespace BibliotecaEj02
{
    public class Persona
    {
        private string nombre;
        private DateTime fechaDeNacimiento;
        private int documento;

        public Persona (string nombre, DateTime nacimiento, int documento)
        {

        }
        //setters
       public void SetNombre (string nombre)
        {
            this.nombre = nombre;
        }
        public void SetDateTime(DateTime fecha)
        {
            this.fechaDeNacimiento = fecha;
        }
        public void SetDocumento(int documento)
        {
            this.documento = documento;
        }
        //getters
        public string GetNombre()
        {
            return this.nombre;
        }
        public DateTime GetFecha()
        {
            return this.fechaDeNacimiento;
        }
        public int GetDocumento()
        {
            return this.documento;
        }
        /*
        private int CalcudarEdad (DateTime fechaInicial)
        {     
            DateTime fechaActual = DateTime.Today;
        }
        */
    }
}
