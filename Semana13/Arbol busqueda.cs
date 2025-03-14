using System;

class Nodo
{
    public string Titulo;
    public Nodo Izquierda, Derecha;

    public Nodo(string titulo)
    {
        Titulo = titulo;
        Izquierda = null;
        Derecha = null;
    }
}

class ArbolBinarioBusqueda
{
    private Nodo raiz;

    public ArbolBinarioBusqueda()
    {
        raiz = null;
    }

    // Método para insertar un título en el árbol
    public void Insertar(string titulo)
    {
        raiz = InsertarRecursivo(raiz, titulo);
    }

    // Método recursivo para insertar un título
    private Nodo InsertarRecursivo(Nodo raiz, string titulo)
    {
        if (raiz == null)
        {
            raiz = new Nodo(titulo);
            return raiz;
        }

        if (string.Compare(titulo, raiz.Titulo) < 0) // Titulo menor, va a la izquierda
            raiz.Izquierda = InsertarRecursivo(raiz.Izquierda, titulo);
        else if (string.Compare(titulo, raiz.Titulo) > 0) // Titulo mayor, va a la derecha
            raiz.Derecha = InsertarRecursivo(raiz.Derecha, titulo);

        return raiz;
    }

    // Método para buscar un título de manera recursiva
    public bool BuscarRecursiva(string titulo)
    {
        return BuscarRecursivo(raiz, titulo);
    }

    // Método recursivo para buscar un título
    private bool BuscarRecursivo(Nodo raiz, string titulo)
    {
        if (raiz == null) // Caso base: no se encuentra el título
            return false;

        if (string.Compare(titulo, raiz.Titulo) == 0) // Titulo encontrado
            return true;

        if (string.Compare(titulo, raiz.Titulo) < 0) // Buscar en la izquierda
            return BuscarRecursivo(raiz.Izquierda, titulo);

        return BuscarRecursivo(raiz.Derecha, titulo); // Buscar en la derecha
    }

    // Método para buscar un título de manera iterativa
    public bool BuscarIterativa(string titulo)
    {
        Nodo current = raiz;

        while (current != null)
        {
            if (string.Compare(titulo, current.Titulo) == 0) // Titulo encontrado
                return true;
            else if (string.Compare(titulo, current.Titulo) < 0) // Buscar en la izquierda
                current = current.Izquierda;
            else // Buscar en la derecha
                current = current.Derecha;
        }

        return false; // Si no se encontró el título
    }
}

class Program
{
    static void Main()
    {
        // Crear un árbol binario de búsqueda
        ArbolBinarioBusqueda arbol = new ArbolBinarioBusqueda();

        // Insertar 10 títulos al árbol
        string[] titulos = new string[]
        {
            "National Geographic",
            "Scientific American",
            "Time Magazine",
            "Nature",
            "The Economist",
            "Forbes",
            "Popular Science",
            "Wired",
            "MIT Technology Review",
            "The New Yorker"
        };

        foreach (var titulo in titulos)
        {
            arbol.Insertar(titulo);
        }

        // Menú de opciones
        Console.WriteLine("\nMenú:");
        Console.WriteLine("1. Búsqueda recursiva");
        Console.WriteLine("2. Búsqueda iterativa");
        Console.Write("Elija una opción (1 o 2): ");
        int opcion = int.Parse(Console.ReadLine());

        // Leer el título a buscar
        Console.Write("Ingrese el título a buscar: ");
        string tituloBuscar = Console.ReadLine();

        // Realizar la búsqueda según la opción seleccionada
        if (opcion == 1)
        {
            // Búsqueda recursiva
            if (arbol.BuscarRecursiva(tituloBuscar))
                Console.WriteLine("Título encontrado.");
            else
                Console.WriteLine("Título no encontrado.");
        }
        else if (opcion == 2)
        {
            // Búsqueda iterativa
            if (arbol.BuscarIterativa(tituloBuscar))
                Console.WriteLine("Título encontrado.");
            else
                Console.WriteLine("Título no encontrado.");
        }
        else
        {
            Console.WriteLine("Opción no válida.");
        }
    }
}
