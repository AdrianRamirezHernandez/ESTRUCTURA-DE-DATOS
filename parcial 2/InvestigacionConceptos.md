
# INVESTIGACION DE CONCEPTOS DE ESTRUCTURA DE DATOS
## Alumno: Adrian Ramirez Hernandez

Una estructura de datos es un formato especializado para organizar, procesar y almacenar datos  en la memoria de una computadora. Permite el acceso y la manipulación eficiente de los datos, facilitando operaciones como búsquedas, inserciones y modificaciones. Existen diferentes tipos de estructuras de datos.
 
- Arreglos
   -Vector
   -Matrices
- Pilas
- Colas
- Listas Enlazadas  
   - Simples
   - Dobles
   - CircularesS

### Arreglos
- #### Los vectores
      Los vectores son una estructura de datos estatica, aunque algunos 
      lenguajes de  programacion son dinamicas (Python), en nuestro caso el lenguaje de c#,
      los vectores son  estaticos, Un vector la podemos ver como una columna y sus 
      elementos tienen que ser del  mismo tipo de dato.

- #### Las Matrices.
      Las matrices en programación son estructuras de datos que permiten almacenar
       y organizar múltiples elementos del mismo tipo en una colección ordenada.
       Cada elemento dentro de una matriz se identifica mediante un índice o conjunto
        de índices, dependiendo de la dimensión de la matriz.
### Pilas
    Una pila en C# es una estructura de datos que sigue el principio LIFO (Last In, First Out), 
    es decir, el último elemento que se agrega es el primero en salir. Imagina una pila de 
    libros: el último libro que colocas en la parte superior será el primero que retires.

   En C#, la clase Stack<T> del espacio de nombres System.Collections.Generic se utiliza para
   implementar pilas. Algunas de las operaciones principales que puedes realizar con una pila 
   son:

   - Push: Agregar un elemento a la pila.
   - Pop: Eliminar y devolver el elemento en la parte superior de la pila.
   - Peek: Ver el elemento en la parte superior sin eliminarlo.
   - Count: Obtener el número de elementos en la pila.
``` C#
 // Crear una pila de enteros
        Stack<int> pila = new Stack<int>();

        // Agregar elementos a la pila
        pila.Push(10);
        pila.Push(20);
        pila.Push(30);

        // Mostrar el elemento en la parte superior
        Console.WriteLine("Elemento en la cima: " + pila.Peek());

        // Eliminar un elemento (Pop)
        Console.Writ
```


### Colas
   Una Cola en C# es una estructura de datos que sigue el principio FIFO (First In, First Out)
   lo que significa que el primer elemento que entra es el primero en salir. Es ideal para
    situaciones donde los datos deben procesarse en el mismo orden en que se reciben, como en
     sistemas de colas de impresión o manejo de tareas.

   En C#, las colas se implementan mediante la clase Queue<T>, donde T representa el tipo de
   datos que almacenará la cola. Esta clase pertenece al espacio de nombres
    System.Collections.Generic.

   Características principales de una Cola:
   - Ordenada: Los elementos se almacenan en el orden en que se agregan.
   - Operaciones principales:
       - Enqueue(T item): Agrega un elemento al final de la cola.
       - Dequeue(): Elimina y devuelve el elemento al frente de la cola.
       - Peek(): Devuelve el elemento al frente de la cola sin eliminarlo.

Uso común: Procesamiento de datos en secuencia, como tareas en espera o flujos de datos.
```C#
// Crear una cola de enteros
        Queue<int> cola = new Queue<int>();

        // Agregar elementos a la cola
        cola.Enqueue(10);
        cola.Enqueue(20);
        cola.Enqueue(30);

        // Mostrar el primer elemento sin eliminarlo
        Console.WriteLine("Primer elemento: " + cola.Peek());



```


### Listas Enlazadas
  - #### Simples
      Una lista simplemente enlazada es una estructura de datos lineal, como los arreglos
      aunque a diferencia de estos, sus elementos se encuentran relacionados (enlazados) por
      medio de punteros, mientras que en los arreglos sus elementos se encuentran en espacios
      de memoria consecutivos.

      Gracias a lo anterior, la lista simplemente enlazada es una estructura de datos de tamaño
      dinámico, es decir, no esta limitada a un tamaño inicial y puede crecer indefinidamente
      mientras haya espacio de memoria disponible en el equipo.
  - #### Dobles
      Una lista doblemente enlazada es una estructura de datos que consiste en un conjunto de 
      nodos enlazados secuencialmente, donde cada nodo tiene dos enlaces: uno al nodo siguiente 
      y otro al nodo anterior. Esta estructura permite realizar operaciones de inserción y 
      eliminación de elementos de manera más eficiente en comparación con las listas simplemente 
      enlazadas, ya que se puede acceder a ambos extremos de la lista. Las listas doblemente 
      enlazadas son útiles en programación cuando se requieren múltiples operaciones de este 
      tipo. Además, se diferencian de las listas simplemente enlazadas, que solo tienen un 
      enlace al siguiente nodo.

  - #### Circulares
      Una lista enlazada circular es una variación de las listas enlazadas en la que el último 
      nodo de la lista apunta al primer nodo, en lugar de apuntar a un puntero nulo. Esto 
      permite que la lista se recorra de manera continua sin llegar a un final, lo que es útil 
      en diversas aplicaciones donde se requiere un acceso cíclico a los elementos.
      
      En una lista enlazada circular, cada nodo contiene al menos dos componentes:
      Dato: El valor que se almacena en el nodo.
      Puntero: Una referencia al siguiente nodo en la lista. En el caso de la lista circular, el puntero del último nodo apunta de nuevo al primer nodo. 


  ### Operaciones Básicas de cualquier tipo de lista.
         Las operaciones que se pueden realizar en una lista enlazada circular incluyen:

       - Inserción: Agregar un nuevo nodo en una posición específica de la lista. Esto puede   hacerse al principio, al final o en cualquier posición intermedia.
  
       - Eliminación: Quitar un nodo existente de la lista, que puede ser identificado por su valor o posición.
       - Recorrido: Mostrar el contenido completo de la lista, comenzando desde un nodo
          específico y volviendo al mismo nodo. 
  
 
