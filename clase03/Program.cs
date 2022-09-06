using System;
using MiBiblioteca;

namespace clase03
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //--------------------------------PROGRAMACION ORIENTADA A OBJETOS

            // CONTENIDO: TRIBUTOS ESTATICOS Y NO ESTATICOS, CONSTRUCTORES ESTATICOS Y NO ESTATICOS.
            /*
             *  Pilares de programacion orientada a objetos.
             *  
             *  1-Encapsulamiento:Es agrupar los atributos y metodos de un objeto. Los metodos no se encuentran sueltos, todos se encuentran 
             *  dentro de clases. esto me permite a traves de los modificadores de visibilidad indicar que metodos seran accesibles 
             *  por fuera de la clase y cuales no.
             *  
             *  2-abstraccion: Nos permite poder describir un objeto mediante atributos y su comportamiento mendiante metodos. 
             *  No hay reglas explicitas para saber como describir objetos, se gana con la experiencia misma.
             *  
             *  3-Herencia: Indica la forma de construir una jerarquia de clases que esten entrelazadas entre si de tal forma
             *  que pueda escribir la menor cantidad de codigo posible, y pueda reutilizar ese codigo.
             *  
             *  4-Polimorfismo: Nos permite ir modificando el comportamiento de distintos elementos de una clase (ej: 
             *  fuincionalidad del metodo tipo de propiedad etc).
             *  
             *  ---------------------------------------------
             *  Una clase define una estructura nueva de datos que me permite tener distintos atritubos y metodos.
             *  Los nombres de las clases deben comenzar en Mayuscula y tener nombre de sustantivos.
             *  Ademas es un elemento que permite generar objetos en memoria, herencia sobre otras clases.
             *  Las clases ademas de tener atributos y metodos tambien pueden poseer otros tipos de datos.
             *  
             *  
             *  ---Los atributos son campos donde se pueden guardar valores, basicamente son variables de la clase que
             *  pueden ser de cualquier tipo. A estos atributos se le puede dar distintos tipos de acceso mediante los
             *  modificadores de visibilidad (public, private, external etc) y distintas formas de accederlo (static,etc),
             *  Deben tener nombre de sustantivos y empezar con minuscula.
             *  
             *      -atributos no estaticos o de instancia: son atributos que no tienen el modificador static. Se debe
             *      hacer referencia a ellos como this.nombre del atributo de instancia (se llaman de instancia ya que es necesario instanciarlos 
             *      -es decir crear un objeto de ese tipo- para poder acceder a ellos). Por ejemplo si tuviera el objeto Auto con atributos de 
             *      instancia, para poder acceder a dichos atributos de instancia deberia hacer.
             *      Auto primerAuto = new Auto; 
             *      primerAuto.atributo  ; debo instanciarlo para poder acceder a el.
             *      
             *      -atributos estaticos o de clase: poseen el modificador static. Se debe hacer referencia como
             *      NombreDeClase.atributo
             *      
             *  ---Los metodos son funciones que estan definidos dentro de la clase. Los metodos tienen que tener
             *  nombre de acciones y deben comenzar con mayuscula.
             *  ------------------------------------------------
             *  
             *  Un constructor es un metodo que inicializa los atributos dentro de una clase.
             *  Los constructores inicializan por defecto las variables:
             *  -tipos de datos por referencia los inicializa en null
             *  -tipos de datos por valor los inicializa en 0
             *  
             *  Existen 2 tipos de constructores:
             *  - Constructor De instancia o no estatico: inicializan los atributos de instancia de mi clase, 
             *  de referencia en 0, de valor en 0 o bool en false
             *  -Constructor estatico: Se ejecutan una unica vez durante el ciclo de vida del proyecto, no permite
             *  recibir ningun tipo de parametro, no tiene modificador de accesibilidad
             */

            //acceder a un atributo estatico o de clase
            Clase.doble = 5.66;
            //acceder a metodo de estatico o de clase
            Clase.MetodoDeClase();

            /* para poder acceder a campos no estaticos o de instancia necesito hacerlo mediante la generacion de objetos
            por medio de constructores.

            ----------------------------------------CONSTRUCTORES--------------------------------------
            
            Los constructores son metodos cuya unica funcion es darle un valor inicial a los atributos de un objeto
            para asegurrar el correcto funcionamiento del mismo.
            Hay incorporado un constructor por defecto que automaticamente inicializa los atributos, los atributos por valor
            los inicializa en cero, los atributos de referencia en NULL. Esto es automatico, no hay que hacer nada.
            es por esto que se puede declarar un atributo sin necesidad de inicializarlo

            public static int cantiadadHoras; 

            NOTA: esto solamente sucede con los atributos. en cambio con las variables locales a un metodo esto no va a ser
            asi.. va a ser necesario inicializarlas al momento de declararlas, si yo hiciera:

            int i;                 
            i++; ----> esto daria error de compilacion, se esta intentando hacer una suma a una variable no inicializada.

            Tambien puede crearse un constructor

            Existen dos tipos de constructores. De instancia o no estaticos y los estaticos.

            **De instancia o no estaticos:
                -Se encarga de inicializar los atributos no estaticos.(referencia = null, valor = 0; bool=false)
                -inicializan los objetos al momento de su creacion.
                -En c# la unica forma de crear un objeto es mediante la palabra reservada new
                -Deben llevar el mismo nombre de la clase
            **Estaticos:
                -Se encarga de inicializar los atributos estaticos.(referencia = null, valor = 0; bool=false)
                -Se ejecutan una UNICA VEZ  durante el ciclo de vida del proyecto (cuando se crea un objeto de esa clase)
                -No permite recibir ningun tipo de parametro.
                -No tiene modificador de visibilidad,


            */
            //CONSTRUCTOR  DE ISTANCIA O NO ESTATICO.
            Clase objeto1 = new Clase(); //objeto1 Es la referencia al objeto creado.

            // de esta manera puedo acceder a los metodos de instancia y atributos de instancia
            // del objeto que acabo de crear

            //Para poder acceder a los atributos y metodos no estaticos se deben acceder si o si a traves de la referencia 
            //al objeto, en este caso objeto1. Es por esto que se llaman de instancia, ya que necesito instanciarlos para 
            // acceder a ellos. Debo crear el objeto y luego usar la referencia a ese objeto para acceder al metodo o atributo
            //caso contrario pasa con los metodos o atributos static a los cuales solo accedo haciendo clase.atributo o clase.metodo

            //CONSTRUCTOR DE INSTANCIA.
            //Puedo anular el constructor por default que inicializa los atributos de valor en 0 y de referencia en NULL
            //creando un constructor, este debe crearse dentrod e la clase (mirar el archivo clase.cs)


            // Uso de un constructor estatico.

            Clase objeto2 = new Clase(1,"cadena");
            //en este caso use un constructor al cual le paso como parametro el valor que se le asignara a los atributos.
            
            
        }
    }
}
