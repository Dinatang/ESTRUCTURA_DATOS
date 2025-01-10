using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Almacenamos los vectores en listas
        List<int> vector1 = new List<int> { 1, 2, 3 };
        List<int> vector2 = new List<int> { -1, 0, 2 };

        // Comprobamos que los vectores tienen el mismo tamaño
        if (vector1.Count != vector2.Count)
        {
            Console.WriteLine("Los vectores no tienen el mismo tamaño.");
            return;
        }

        // Calculamos el producto escalar
        int productoEscalar = 0;
        for (int i = 0; i < vector1.Count; i++)
        {
            productoEscalar += vector1[i] * vector2[i];
        }

        // Mostramos el resultado
        Console.WriteLine($"El producto escalar de los vectores es: {productoEscalar}");
    }
}
