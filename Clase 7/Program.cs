using System;


namespace Clase_7
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Matrices
            //------------------------------------MATRICES-----------------------
            //estructura de datos que nos permite almacenar multiples variables del mismo tipo.
            /*
             * Caracteristicas: 
             * 1_Dimensionalidad: Unidimensionales y multidimensionales.
             * 2_TamañO fijo: El temaño es establecido al momento de instanciar la matriz, no puede ser cambiado luego
             * si se necesita cambiar el tamaño es necesario crear uno nuevo con distinta longitud y migrar los datos.
             * 3_Indexacion Base 0: El indice numerico comienza en 0.
             * 4_Valor por defecto: Todos los elementos se inicializan con un valor por defecto, tipo valor en 0
             * tipo referencia en null, tipo bool en false.
             */

            #region ARRAYS
            //---------------------------- ARRAYS (UNIDIMENSINALES)----------------------
            //se declara tipo de dato [] nombre de la variable =  new tipo de dato [Tamaño]
            Console.WriteLine("--------- A R R A Y S ---------");
            int[] array = new int[4];
            array[0] = 4;
            array[1] = 5;
            array[2] = 6;
            array[3] = 7;

            //Tambien se puede hacer como
            //int[] array2 = { 1, 2, 3, 4 };

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Elemento en posicion " + i + ": " + array[i]);
            }

            //tambien se puede hacer arrays de objetos. Si tubieramos un objeto persona
            /*
             * podriamos hacer
             * Persona[] personas = 
             * {
             *      new Persona("juan");
             *      new Persona("maria");
             *      new Persona("pedro");
             * }
             * 
             * y pordria recorrer el array de personas de la siguiente manera
             * 
             * foreach(Persona item in personas)
             * {
             *         Console.WriteLine("Nombre: " + item.nombre);
             * }
             * 
             * */
            #endregion
            #region Bidimensionales

            //------------------------------------MATRICES (MULTIDIMENCIONALES - BIDIMENSIONAL)
            Console.WriteLine("-------------- MATRICES BIDIMENSIONALES---------");
            int[,] matriz = new int[2, 2]; //primer elemento fila, segundo elemento columna
            matriz[0, 0] = 2;
            matriz[0, 1] = 3;
            matriz[1, 0] = 4;
            matriz[1, 1] = 5;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine($"Fila {i}, Comlumna {j}: valor: {matriz[i, j]}");
                }
            }
            #endregion
            #region Tridimensionales

            //------------------------------Matriz Multidimensional (Tridimensional)

            int[,,] arrayTri = new int[2, 4, 5]; //fila, columna,Z

            #endregion

            #region Matriz Escalonada
            //------------------------------------MATRICES Escalonada
            int[][] matrizEscalonada = new int[4][]; //declaro solo la cantidad de filas
            //permite tener una matriz y que cada columna tenga un valor variable
            //por cada fila creo un nuevo array y cada uno tendra un largo distinto
            matrizEscalonada[0] = new int[] { 2, 3, 4, 5, 6, 8 };
            matrizEscalonada[1] = new int[] { 2, 23 };
            matrizEscalonada[2] = new int[] { 2, 7, 10, };
            matrizEscalonada[3] = new int[] { 5, 1, 4, 5, };

            #endregion
            #endregion




            #region Colecciones
            //---------------------------------COLECCIONES
            Console.WriteLine("------------------------COLECCIONES------------------");
            //Las colecciones SON OBJETOS especializados en almacenar, organizar y administrar gran cantidades de datos
            /*Caracteristicas
             * 1_Tamaño dinamico: se puede modificar el tamaño en tiempo de ejecucion.
             * 2_Enumerable: Impementan la interface IEnumerable esto nos permite recorrerla con un foreach
             * 3_Indice numerico: cada posicion posee un indice
             * 4_Indexacion en base cero: el indice comienza en 0
             * 
             * Hay dos tipos de colecciones, genericas y no genericas:
             * -----> Genericas son del mismo tipo (ejemplo que sean todos del tipo Persona), usar el System.Collections.Generic
             * -----> No genericas son de distinto tipo(Podria guardar Persona, Auto,Libro,Casa). Usar system.collections (TIPO PILA COMPORTAMIENTO LIFO)
             */
            #region Colecciones No Genericas
            Console.WriteLine("------------------------ COLECCIONES NO GENERICAS -------------------------------");
            //--------------------------NO GENERICAS
            // Incluir en la libreria System.Collections


            #region Tipo PILA (LIFO)
            System.Collections.Stack pilaNoGenericaPila = new System.Collections.Stack();
            // El system.collections se debe poner arriba de todo con un using
            //en caso de hacerlo asi solo hacemos stack pilaNoGenerica = new Stack();

            //La clase stack es del tipo PILA , es decir que tiene comportamiento tipo LIFO (LAST IN FIRST OUT, ULTIMO EN ENTRAR PRIMERO EN SALIR)

            //Con metodo PUSH se agrega algo a la pila, con el metodo POP se saca. El metodo PEEK muestra el proximo
            //elemento en salir (como estamos en PILA el primero en salir va a ser el ultimo que entro)
            Console.WriteLine("------------------------ NO GENERICAS TIPO PILA (LIFO)------------------");
            pilaNoGenericaPila.Push("Juancho");
            pilaNoGenericaPila.Push(true);
            pilaNoGenericaPila.Push("Pablo");
            pilaNoGenericaPila.Push(5);

            foreach (object itemEnLaPila in pilaNoGenericaPila) //uso objet para "envolver" el tipo de dato, dado que tengo int, float, bool y string
            {
                Console.WriteLine("Elemento " + itemEnLaPila);
            }

            Console.WriteLine("\n\nPeek: " + pilaNoGenericaPila.Peek()); //muestra el proximo en salir, en este caso mostrara
            //3.14 ya que fue el ultimo en entrar (LIFO)
            pilaNoGenericaPila.Pop();
            pilaNoGenericaPila.Pop();
            Console.WriteLine("\n\nDespues de desapilar dos Peek: " + pilaNoGenericaPila.Peek());
            //como desapile dos objetos deberia mostrar "true";
            #endregion
            #region Tipo COLA (FIFO)
            Console.WriteLine("------------------------NO GENERICAS TIPO COLA (FIFO)------------------");
            //Tipo COLA tiene comportamiento FIFO (FIRST IN FIRST OUT)
            System.Collections.Queue pilaNoGenericaCola = new System.Collections.Queue();
            //con el metodo ENQUEUE agrego algo a la lista, con DEQUEUE saco algo de la lista, PEEK muestra el proximo en salir

            pilaNoGenericaCola.Enqueue(2.5f);
            pilaNoGenericaCola.Enqueue("juan");
            pilaNoGenericaCola.Enqueue(false);
            pilaNoGenericaCola.Enqueue(20);

            foreach (object itemEnCola in pilaNoGenericaCola)
            {
                Console.WriteLine("Elemento " + itemEnCola);
            }

            Console.WriteLine("\n\n" + pilaNoGenericaCola.Peek());//muestra 2.5 ya que fue el primero en entrar
            pilaNoGenericaCola.Dequeue();
            pilaNoGenericaCola.Dequeue();
            Console.WriteLine(pilaNoGenericaCola.Peek());//como saco dos va a mostrar false




            #endregion
            #region Listas Dinamicas
            Console.WriteLine("\n\n-------------NO GENERICAS LISTAS DINAMICAS-------");
            //No hay comportamiento FIFO o LIFO, con el indice puedo acceder a donde yo quiera o borrar lo que yo quiera.
            System.Collections.ArrayList listaNoGenerica = new System.Collections.ArrayList();
            //Con el metodo ADD agrego cosas
            //Con el metodo REMOVE remuevo cosas, pero debo pasarle al metodo exactamente que quiero eliminar
            listaNoGenerica.Add(4);
            listaNoGenerica.Add("juan");
            listaNoGenerica.Add(true);
            listaNoGenerica.Add(3.14f);

            foreach (object item in listaNoGenerica)
            {
                Console.WriteLine("Elemento " + item);
            }
            listaNoGenerica.Remove("juan"); //le indico que remover
            listaNoGenerica.Remove(true); //le indico que remover
            Console.WriteLine("\n\n Luego de remover true y juan");
            foreach (object item in listaNoGenerica)
            {
                Console.WriteLine("Elemento " + item);
            }


            #endregion
            #region Hashtable
            Console.WriteLine("\n\n-------------NO GENERICAS HASHTABLE ->>>> CLAVE - VALOR------------");
            //Este tipo de coleccion esta definida por su CLAVE y su VALOR
            System.Collections.Hashtable hastable = new System.Collections.Hashtable();
            //Con el metodo ADD puedo agregar elementos
            //Con el metodo REMOVE elimino elementos a traves de su KEY
            hastable.Add(3, "Pedro");
            hastable.Add(false, 3.14f);
            hastable.Add(DateTime.Now, "juan");
            //TANTO COMO CLAVE Y COMO VALOR PUEDO USAR CUALQUIER COSA

            foreach (System.Collections.DictionaryEntry item in hastable)
            {
                Console.WriteLine($"Key {item.Key} valor {item.Value}");
            }
            Console.WriteLine("Elimino cosas");
            hastable.Remove(3); //borre pedro
            hastable.Remove(false); //borre 3.14f
            foreach (System.Collections.DictionaryEntry item in hastable)
            {
                Console.WriteLine($"Key {item.Key} valor {item.Value}");
            }

            #endregion
            #endregion
            #region Colecciones Genericas
            Console.WriteLine("----------------- COLECCIONES GENERICAS-----------------------");
            //agregar System.Collection.Generic
            #region Tipo Pila (LIFO)
            Console.WriteLine("---- GENERICAS TIPO PILA (LIFO)");
            //funciona igual que tipo pila no generica solo que permite guardar un solo tipo de dato.
            System.Collections.Generic.Stack<string> pilaGenerica = new System.Collections.Generic.Stack<string>();
            //al utilizar el using quedaria asi stack<tipoDeDato> nombre = new Stack<tipoDeDato>();

            pilaGenerica.Push("Juan");
            pilaGenerica.Push("Pedro");
            pilaGenerica.Push("Lucas");
            pilaGenerica.Push("Horacio");

            foreach (string item in pilaGenerica)
            {
                Console.WriteLine("elemento: " + item);
            }
            Console.WriteLine("\nSaco Elementos\n");
            pilaGenerica.Pop();
            pilaGenerica.Pop();
            Console.WriteLine(pilaGenerica.Peek()); //Deberia mostrar Pedro


            #endregion
            #region Tipo Cola (FIFO)
            Console.WriteLine("---- GENERICAS TIPO COLA (FIFO)");
            //Funciona igual que la cola no generica solo que admite un unico tipo de dato.
            System.Collections.Generic.Queue<int> colaGenerica = new System.Collections.Generic.Queue<int>();
            colaGenerica.Enqueue(1);
            colaGenerica.Enqueue(35);
            colaGenerica.Enqueue(6);
            colaGenerica.Enqueue(295);

            foreach (int item in colaGenerica)
            {
                Console.WriteLine("elemento " + item);
            }
            Console.WriteLine("\nSaco dos elementos\n");
            colaGenerica.Dequeue();
            colaGenerica.Dequeue();
            Console.WriteLine(colaGenerica.Peek()); //deberia mostar el 6





            #endregion
            #region Listas Dinamicas
            Console.WriteLine("------------------LISTAS DINAMICAS-----------------");
            //No hay comportamiento FIFO o LIFO, con el indice puedo acceder a donde yo quiera o borrar lo que yo quiera.
            // puedo usar metodo SORT  para ordenar Ascendente, o metodo REVERSE para descendente
            System.Collections.Generic.List<int> listaDinamicaGnerica = new System.Collections.Generic.List<int>();
            listaDinamicaGnerica.Add(5);
            listaDinamicaGnerica.Add(25);
            listaDinamicaGnerica.Add(1);
            listaDinamicaGnerica.Add(6712);
            listaDinamicaGnerica.Add(74);

            foreach (int item in listaDinamicaGnerica)
            {
                Console.WriteLine(item);
            }
            listaDinamicaGnerica.Remove(1);
            listaDinamicaGnerica.Remove(6712);
            Console.WriteLine("\nElimino 1 y 6712\n");
            foreach (int item in listaDinamicaGnerica)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Ordeno Ascendente");
            listaDinamicaGnerica.Sort();
            foreach (int item in listaDinamicaGnerica)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Ordeno Descendente");
            listaDinamicaGnerica.Reverse();
            foreach (int item in listaDinamicaGnerica)
            {
                Console.WriteLine(item);
            }

            #endregion
            #region Hastable
            Console.WriteLine("-------------------HASHTABLE GENERICO-------------------------");
            System.Collections.Generic.Dictionary<int, string> hashtableGenerico = new System.Collections.Generic.Dictionary<int, string>();
            hashtableGenerico.Add(1, "juan");
            hashtableGenerico.Add(3, "Pedro");
            hashtableGenerico.Add(5, "laura");
            hashtableGenerico.Add(21, "maria");
            //en este caso en lugar de usar el dictionary entro uso keyvaluepair
            foreach (System.Collections.Generic.KeyValuePair<int, string> item in hashtableGenerico)
            {
                Console.WriteLine($"KEY {item.Key} valor {item.Value}");
            }
            Console.WriteLine("\nremuevo key 5\n");
            hashtableGenerico.Remove(5);
            foreach (System.Collections.Generic.KeyValuePair<int, string> item in hashtableGenerico)
            {
                Console.WriteLine($"KEY {item.Key} valor {item.Value}");
            }


            #endregion
            #endregion
            #endregion


            #region Ejemplo usando las bibliotecas de clase Veterinaria y Mascota
            Console.WriteLine("\n\n\n--------------EJ VETERINARIA MASCOTA-------------");
            Veterinaria ejVeterinaria = new Veterinaria(4);

            ejVeterinaria.Agregar(new Mascota("Gorda", 5));
            ejVeterinaria.Agregar(new Mascota("Chas", 12));
            ejVeterinaria.Agregar(new Mascota("Oso", 7));
            ejVeterinaria.Agregar(new Mascota("Oso", 7));//Este no se va a agregar xq ya existe
            // Oso con 7 años, ver metodoa gregar
            ejVeterinaria.Agregar(new Mascota("Lobito", 13));
            ejVeterinaria.Agregar(new Mascota("Bartolo", 16)); //este no se va a agregar xq no
            //hay espacio disponible
            Console.WriteLine("\n\n Muestro lo agregado\n\n");
            foreach (Mascota item in ejVeterinaria.lista)
            {
                Console.WriteLine(item.ToString());
            }

            foreach (Mascota item in ejVeterinaria.lista)
            {
                Console.WriteLine(item.ToString());
            }

            #endregion


        }
    }
}
