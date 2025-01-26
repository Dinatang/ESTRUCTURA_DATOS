using System;
using System.Collections.Generic;

class TorresDeHanoi
{
    static void Main()
    {
        // Número de discos
        int n = 3;

        // Crear las tres torres como pilas
        Stack<int> torreA = new Stack<int>();
        Stack<int> torreB = new Stack<int>();
        Stack<int> torreC = new Stack<int>();

        // Inicializamos la torre A con los discos (de mayor a menor)
        for (int i = n; i >= 1; i--)
        {
            torreA.Push(i);
        }

        // Mostrar el estado inicial de las torres
        MostrarTorre("A", torreA);
        MostrarTorre("B", torreB);
        MostrarTorre("C", torreC);

        // Realizamos las movidas (con solo 3 discos)
        MoverDiscos(n, torreA, torreC, torreB);

        // Mostrar el estado final
        Console.WriteLine("\nEstado final:");
        MostrarTorre("A", torreA);
        MostrarTorre("B", torreB);
        MostrarTorre("C", torreC);
    }

    // Función para mover los discos entre las torres
    static void MoverDiscos(int n, Stack<int> origen, Stack<int> destino, Stack<int> auxiliar)
    {
        // Si solo hay un disco, lo movemos directamente
        if (n == 1)
        {
            destino.Push(origen.Pop());
            Console.WriteLine("Mover disco de A a C");
        }
        else
        {
            // Mover los n-1 discos a la torre auxiliar
            MoverDiscos(n - 1, origen, auxiliar, destino);

            // Mover el disco más grande a la torre destino
            destino.Push(origen.Pop());
            Console.WriteLine("Mover disco de A a C");

            // Mover los n-1 discos de la torre auxiliar a la torre destino
            MoverDiscos(n - 1, auxiliar, destino, origen);
        }
    }

    // Función para mostrar el estado de las torres
    static void MostrarTorre(string nombre, Stack<int> torre)
    {
        Console.WriteLine($"{nombre}: " + string.Join(", ", torre));
    }
}
