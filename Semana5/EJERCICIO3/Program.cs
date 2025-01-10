/using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Crear una lista para almacenar los números del 1 al 10
        List<int> numeros = new List<int>();

        // Llenar la lista con los números del 1 al 10
        for (int i = 1; i <= 10; i++)
        {
            numeros.Add(i);
        }

        // Mostrar los números en orden inverso
        for (int i = numeros.Count - 1; i >= 0; i--)
        {
            if (i != numeros.Count - 1)
            {
                Console.Write(", "); // Imprimir la coma para separar los números
            }
            Console.Write(numeros[i]); // Imprimir el número en orden inverso
        }

        // Salto de línea al final
        Console.WriteLine();
    }
}
