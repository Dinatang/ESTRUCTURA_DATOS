using System;

class Program
{
    static void Main()
    {
        // Solicitar al usuario que ingrese una palabra
        Console.Write("Introduce una palabra: ");
        string palabra = Console.ReadLine().ToLower(); // Convertimos la palabra a minúsculas para facilitar la comparación

        // Inicializamos las variables para contar las vocales
        int aCount = 0;
        int eCount = 0;
        int iCount = 0;
        int oCount = 0;
        int uCount = 0;

        // Recorremos cada letra de la palabra
        foreach (char letra in palabra)
        {
            // Comprobamos si la letra es una vocal y contamos
            switch (letra)
            {
                case 'a':
                    aCount++;
                    break;
                case 'e':
                    eCount++;
                    break;
                case 'i':
                    iCount++;
                    break;
                case 'o':
                    oCount++;
                    break;
                case 'u':
                    uCount++;
                    break;
            }
        }

        // Mostrar el resultado
        Console.WriteLine($"La vocal 'a' aparece {aCount} veces.");
        Console.WriteLine($"La vocal 'e' aparece {eCount} veces.");
        Console.WriteLine($"La vocal 'i' aparece {iCount} veces.");
        Console.WriteLine($"La vocal 'o' aparece {oCount} veces.");
        Console.WriteLine($"La vocal 'u' aparece {uCount} veces.");
    }
}
