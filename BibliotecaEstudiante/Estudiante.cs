using System;
using System.Text;
//---ATRIBUTOS
//---PROPIEDADES
//---CONSTRUCTORES
//---METODOS
//---OPERADORES

namespace BibliotecaEstudiante
{
    public class Estudiante
    {
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;

        static Estudiante()
        {
            Estudiante.random = new Random();

        }
        public Estudiante(string nombreIngresado, string apellidoIngresado, string legajoIngresado)
        {
            this.nombre = nombreIngresado;
            this.apellido = apellidoIngresado;
            this.legajo = legajoIngresado;
        }


        public void SetNotaPrimerParcial(int nota1)
        {
            this.notaPrimerParcial = nota1;
        }
        public void SetNotaSegundoParcial(int nota2)
        {
            this.notaSegundoParcial = nota2;
        }
        private float CalcularPromedio()
       {
            return  (float) (this.notaPrimerParcial + this.notaSegundoParcial) / 2;
        }
        public int CalcularNotaFinal()
        {
            int retorno = -1;
            if (this.notaPrimerParcial >=4 && this.notaSegundoParcial>=4)
            {
                retorno = Estudiante.random.Next(6, 11);
            }
            return retorno;
        }
        public string Mostrar()
        {
           int notaFinal = this.CalcularNotaFinal();
            float promedio = this.CalcularPromedio();
            string stringNotaFinal = "";
           if(notaFinal == -1)
            {
                stringNotaFinal = "Alumno Desaprobado";
            }
            else
            {
                stringNotaFinal = notaFinal.ToString();
            }
            StringBuilder informacionAlumno = new StringBuilder();

            informacionAlumno.AppendLine($"Nombre: {this.nombre} Apellido: {this.apellido} Legajo: {this.legajo}");
            informacionAlumno.AppendLine($"Nota primer parcial: {this.notaPrimerParcial} Nota segundo parcial: {this.notaSegundoParcial}");
            informacionAlumno.AppendLine($"Promedio {promedio}");
            informacionAlumno.AppendLine($"Nota final: {stringNotaFinal}");
            return informacionAlumno.ToString();
        }

       
    }
}
