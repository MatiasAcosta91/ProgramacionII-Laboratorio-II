using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase03
{
    class Clase
    {
        // NUNCA INICIALIZAR ATRIBUTOS DESDE ACA. DEBEN SER INICIALIZADO POR MEDIO DE CONSTRUCTORES
        #region  atributos NO estaticos o de instancia
        public string cadena;
        public int entero;
        /*
         Siempre que usemos atributos de instancia se debe hacer referencia a ellos por medio del this,
        Se lo llamaria como this.cadena
        this se utiliza solo dentro de una clase. NO DESDE EL MAIN (para utilizarlos desde el main hay que instanciarlos creando un objeto y 
        de esta manera puedo acceder al atributo como nombreDelObjeto.atributo).
        */
        #endregion

        #region Atributos estaticos o de clase
        public static double doble;
        /*
         * Para hacer referencia a un atributo de clase se usa el nombre de la clase
         * Lo llamaria como Clase.numero
         *
         *      NUNCA SE DEBE MESCLAR CON THIS CON NOMBRE DE LA CLASE.
         *        LOS DE INSTANCIA SOLO CON THIS
         *        LOS DE CLASE CON NOMBRE DE LA CLASE
        ¨*/
        #endregion

        #region Metodos no estaticos o de instancia
        public void MetodoDeInstancia()
        {
            Console.WriteLine("Cadena: {0} Valor entero: {1} valor doble: {2}", this.cadena, this.entero, Clase.doble);
            //si el metodo es no estatico voy poder ACCEDER a atributos estaticos y no estaticos
        }
        #endregion

        #region Metodos  estaticos o de clase
        public static void MetodoDeClase()
        {
            Console.WriteLine("doble {0}",Clase.doble);
            //Si el metodo es estatico solo voy a poder acceder a atributos estaticos
        }
        #endregion

        //----------------------------- CONSTRUCTOR  DE INSTANCIA
        // definir un constructor para la clase, esto anula el constructor por default
        //Debe tener SI O SI el mismo nombre de la clase.
        //El constructor es el unico elemento dentro de una clase que puede tener el mismo nombre de la clase en si.
        //cada vez que genere un objeto nuevo de mi clase se pasara por este constructor que va a inicializar los atributos
        //Todas las clases que se creen tendran unicializados por defecto cadena "valor inicial y entero 8. Son valores fijos.
        
        public Clase ()
        {
            this.cadena = "valor inicial";
            this.entero = 8;
        }
        

        //-------------------------------CONSTRUCTOR DE INSTANCIA PARAMETRIZADO
        //Este constructor a diferencia del anterior, me permite generar objetos que se inicializaran con el valor que
        //yo desee, que seran pasados al constructor al momento de crear el objeto.
        public Clase(int entero, string cadena)
        {
            this.cadena = cadena;
            this.entero = entero;
        }

        // ----------------------CONSTRUCTOR ESTATICO
        //Se le debe poner static.
        //No se le pone modificador de acceso.
        //Al constructor estatico no se le pueden pasar parametros.
        //este se ejecuta una unica vez a lo largo de la vida del proyecto y es cuando se genera el
        //primer objeto   dentro mi clase (SOLAMENTE EN EL PRIMER OBJETO, EN LOS DEMAS NO VOLVERA A PASAR).
        static Clase ()
        {
            Clase.doble = 7;
            
        }

    }

    //DENTRO DE UNA CLASE SIEMPRE DEBE ESTRUCTURARSE DESDE ARRIBA HACIA ABAJO DE LA SIGUIENTE
    //MANERA PARA SEGUIR UN ORDEN PROLIJO.

    //---ATRIBUTOS
    //---PROPIEDADES
    //---CONSTRUCTORES
    //---METODOS
    //---OPERADORES
}
