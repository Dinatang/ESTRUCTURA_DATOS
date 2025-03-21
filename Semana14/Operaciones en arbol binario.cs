using System;

// Definición de la clase Nodo, que representará cada nodo del árbol binario
class Nodo
{
    public string valor;  // El valor almacenado en el nodo (cadena de texto)
    public Nodo izquierdo;  // Puntero al subárbol izquierdo
    public Nodo derecho;  // Puntero al subárbol derecho

    // Constructor del nodo, recibe una cadena y la asigna al nodo
    public Nodo(string valor)
    {
        this.valor = valor;
        izquierdo = null;  // Inicializa el subárbol izquierdo como nulo
        derecho = null;  // Inicializa el subárbol derecho como nulo
    }
}

// Definición de la clase ArbolBinario que contiene las operaciones del árbol
class ArbolBinario
{
    public Nodo raiz;  // Puntero a la raíz del árbol

    // Constructor del árbol binario, inicializa la raíz como nula
    public ArbolBinario()
    {
        raiz = null;
    }

    // Método público para insertar un nuevo valor en el árbol
    public void Insertar(string valor)
    {
        raiz = InsertarRecursivo(raiz, valor);  // Llama al método recursivo para insertar
    }

    // Método recursivo para insertar un valor en el árbol
    private Nodo InsertarRecursivo(Nodo nodo, string valor)
    {
        if (nodo == null)  // Si el nodo es nulo, significa que hemos llegado a un lugar vacío en el árbol
        {
            nodo = new Nodo(valor);  // Creamos un nuevo nodo con el valor y lo retornamos
            return nodo;
        }

        // Si el valor es menor al valor del nodo (comparación lexicográfica), lo insertamos a la izquierda
        if (string.Compare(valor, nodo.valor) < 0)
            nodo.izquierdo = InsertarRecursivo(nodo.izquierdo, valor);  // Insertamos en el subárbol izquierdo
        else if (string.Compare(valor, nodo.valor) > 0)
            nodo.derecho = InsertarRecursivo(nodo.derecho, valor);  // Insertamos en el subárbol derecho

        return nodo;  // Retorna el nodo actualizado
    }

    // Método público para buscar un valor en el árbol
    public bool Buscar(string valor)
    {
        return BuscarRecursivo(raiz, valor);  // Llama al método recursivo para buscar el valor
    }

    // Método recursivo para buscar un valor en el árbol
    private bool BuscarRecursivo(Nodo nodo, string valor)
    {
        if (nodo == null)  // Si el nodo es nulo, el valor no se encuentra
            return false;

        if (valor == nodo.valor)  // Si encontramos el valor en el nodo actual
            return true;

        // Si el valor es menor al valor del nodo, buscamos en el subárbol izquierdo
        if (string.Compare(valor, nodo.valor) < 0)
            return BuscarRecursivo(nodo.izquierdo, valor);
        else  // Si el valor es mayor, buscamos en el subárbol derecho
            return BuscarRecursivo(nodo.derecho, valor);
    }

    // Método público para realizar un recorrido en inorden del árbol (izquierda, raíz, derecha)
    public void RecorridoInorden()
    {
        RecorridoInordenRecursivo(raiz);  // Llama al método recursivo para recorrer el árbol
        Console.WriteLine();  // Imprime un salto de línea después del recorrido
    }

    // Método recursivo para realizar un recorrido en inorden
    private void RecorridoInordenRecursivo(Nodo nodo)
    {
        if (nodo != null)  // Si el nodo no es nulo, continuamos con el recorrido
        {
            RecorridoInordenRecursivo(nodo.izquierdo);  // Primero recorremos el subárbol izquierdo
            Console.Write(nodo.valor + " ");  // Luego imprimimos el valor del nodo
            RecorridoInordenRecursivo(nodo.derecho);  // Finalmente, recorremos el subárbol derecho
        }
    }

    // Método público para realizar un recorrido en preorden del árbol (raíz, izquierda, derecha)
    public void RecorridoPreorden()
    {
        RecorridoPreordenRecursivo(raiz);  // Llama al método recursivo para recorrer el árbol
        Console.WriteLine();  // Imprime un salto de línea después del recorrido
    }

    // Método recursivo para realizar un recorrido en preorden
    private void RecorridoPreordenRecursivo(Nodo nodo)
    {
        if (nodo != null)  // Si el nodo no es nulo, continuamos con el recorrido
        {
            Console.Write(nodo.valor + " ");  // Primero imprimimos el valor del nodo
            RecorridoPreordenRecursivo(nodo.izquierdo);  // Luego recorremos el subárbol izquierdo
            RecorridoPreordenRecursivo(nodo.derecho);  // Finalmente, recorremos el subárbol derecho
        }
    }

    // Método público para realizar un recorrido en postorden del árbol (izquierda, derecha, raíz)
    public void RecorridoPostorden()
    {
        RecorridoPostordenRecursivo(raiz);  // Llama al método recursivo para recorrer el árbol
        Console.WriteLine();  // Imprime un salto de línea después del recorrido
    }

    // Método recursivo para realizar un recorrido en postorden
    private void RecorridoPostordenRecursivo(Nodo nodo)
    {
        if (nodo != null)  // Si el nodo no es nulo, continuamos con el recorrido
        {
            RecorridoPostordenRecursivo(nodo.izquierdo);  // Primero recorremos el subárbol izquierdo
            RecorridoPostordenRecursivo(nodo.derecho);  // Luego recorremos el subárbol derecho
            Console.Write(nodo.valor + " ");  // Finalmente, imprimimos el valor del nodo
        }
    }

    // Método público para eliminar un valor en el árbol
    public void Eliminar(string valor)
    {
        raiz = EliminarRecursivo(raiz, valor);  // Llama al método recursivo para eliminar el valor
    }

    // Método recursivo para eliminar un nodo con un valor específico
    private Nodo EliminarRecursivo(Nodo nodo, string valor)
    {
        if (nodo == null)  // Si el nodo es nulo, significa que no encontramos el valor
            return nodo;

        // Si el valor es menor al valor del nodo actual, lo buscamos en el subárbol izquierdo
        if (string.Compare(valor, nodo.valor) < 0)
            nodo.izquierdo = EliminarRecursivo(nodo.izquierdo, valor);
        // Si el valor es mayor al valor del nodo actual, lo buscamos en el subárbol derecho
        else if (string.Compare(valor, nodo.valor) > 0)
            nodo.derecho = EliminarRecursivo(nodo.derecho, valor);
        else  // Si encontramos el nodo con el valor que queremos eliminar
        {
            // Caso 1: El nodo no tiene hijos (hoja)
            if (nodo.izquierdo == null)
                return nodo.derecho;  // Retorna el subárbol derecho (puede ser nulo)

            // Caso 2: El nodo tiene solo un hijo (izquierdo o derecho)
            else if (nodo.derecho == null)
                return nodo.izquierdo;  // Retorna el subárbol izquierdo (puede ser nulo)

            // Caso 3: El nodo tiene dos hijos
            // En este ejemplo, para simplificar, no se maneja el caso de reestructuración.
            nodo.derecho = EliminarRecursivo(nodo.derecho, valor);
        }

        return nodo;  // Retorna el nodo actualizado
    }
}

// Clase principal que ejecuta el programa
class Program
{
    static void Main(string[] args)
    {
        ArbolBinario arbol = new ArbolBinario();  // Crea una instancia del árbol binario
        int opcion;
        string valor;

        do
        {
            Console.Clear();  // Limpia la consola para mostrar el menú
            Console.WriteLine("Menu de operaciones en Árbol Binario de Cadenas");
            Console.WriteLine("1. Insertar");
            Console.WriteLine("2. Buscar");
            Console.WriteLine("3. Eliminar");
            Console.WriteLine("4. Recorrido Inorden");
            Console.WriteLine("5. Recorrido Preorden");
            Console.WriteLine("6. Recorrido Postorden");
            Console.WriteLine("7. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine());  // Lee la opción seleccionada por el usuario

            switch (opcion)
            {
                case 1:
                    // Opción para insertar un valor
                    Console.Write("Ingrese el valor a insertar: ");
                    valor = Console.ReadLine();  // Lee la cadena a insertar
                    arbol.Insertar(valor);  // Llama al método para insertar el valor
                    break;
                case 2:
                    // Opción para buscar un valor
                    Console.Write("Ingrese el valor a buscar: ");
                    valor = Console.ReadLine();  // Lee la cadena a buscar
                    if (arbol.Buscar(valor))  // Llama al método de búsqueda
                        Console.WriteLine("Valor encontrado.");
                    else
                        Console.WriteLine("Valor no encontrado.");
                    break;
                case 3:
                    // Opción para eliminar un valor
                    Console.Write("Ingrese el valor a eliminar: ");
                    valor = Console.ReadLine();  // Lee la cadena a eliminar
                    arbol.Eliminar(valor);  // Llama al método para eliminar el valor
                    break;
                case 4:
                    // Opción para mostrar el recorrido inorden
                    Console.WriteLine("Recorrido Inorden:");
                    arbol.RecorridoInorden();  // Llama al método para el recorrido inorden
                    break;
                case 5:
                    // Opción para mostrar el recorrido preorden
                    Console.WriteLine("Recorrido Preorden:");
                    arbol.RecorridoPreorden();  // Llama al método para el recorrido preorden
                    break;
                case 6:
                    // Opción para mostrar el recorrido postorden
                    Console.WriteLine("Recorrido Postorden:");
                    arbol.RecorridoPostorden();  // Llama al método para el recorrido postorden
                    break;
                case 7:
                    // Opción para salir del programa
                    Console.WriteLine("Saliendo...");
                    break;
                default:
                    // En caso de una opción no válida
                    Console.WriteLine("Opción no válida.");
                    break;
            }
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();  // Espera que el usuario presione una tecla para continuar

        } while (opcion != 7);  // El programa sigue ejecutándose hasta que el usuario seleccione la opción 7 (salir)
    }
}
