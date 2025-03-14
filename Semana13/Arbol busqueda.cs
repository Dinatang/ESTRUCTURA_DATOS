using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // 1. Crear un catálogo de revistas
        List<string> catalogo = new List<string>()
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

        // 2. Mostrar los títulos en el catálogo
        Console.WriteLine("Catálogo de revistas:");
        foreach (var revista in catalogo)
        {
            Console.WriteLine(revista);
        }

        // 3. Mostrar el menú de opciones
        Console.WriteLine("\nMenú:");
        Console.WriteLine("1. Búsqueda iterativa");
        Console.WriteLine("2. Búsqueda recursiva");
        Console.Write("Elija una opción (1 o 2): ");
        int opcion = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el título a buscar: ");
        string tituloBuscar = Console.ReadLine();

        // 4. Realizar la búsqueda según la opción seleccionada
        if (opcion == 1)
        {
            // Búsqueda iterativa
            if (BusquedaIterativa(catalogo, tituloBuscar))
                Console.WriteLine("Título encontrado.");
            else
                Console.WriteLine("Título no encontrado.");
        }
        else if (opcion == 2)
        {
            // Búsqueda recursiva
            if (BusquedaRecursiva(catalogo, tituloBuscar, 0))
                Console.WriteLine("Título encontrado.");
            else
                Console.WriteLine("Título no encontrado.");
        }
        else
        {
            Console.WriteLine("Opción no válida.");
        }
    }

    // Método de búsqueda iterativa
    static bool BusquedaIterativa(List<string> catalogo, string tituloBuscar)
    {
        foreach (var titulo in catalogo)
        {
            if (titulo.Equals(tituloBuscar, StringComparison.OrdinalIgnoreCase))
                return true;
        }
        return false;
    }

    // Método de búsqueda recursiva
    static bool BusquedaRecursiva(List<string> catalogo, string tituloBuscar, int index)
    {
        if (index >= catalogo.Count) // Caso base: hemos recorrido toda la lista
            return false;

        if (catalogo[index].Equals(tituloBuscar, StringComparison.OrdinalIgnoreCase)) // Si encontramos el título
            return true;

        // Llamada recursiva con el siguiente índice
        return BusquedaRecursiva(catalogo, tituloBuscar, index + 1);
    }
}
