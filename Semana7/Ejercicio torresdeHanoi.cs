using System;
using System.Collections.Generic;

public class TorresDeHanoi
{
    // Método recursivo que resuelve el problema de las Torres de Hanoi
    public static void ResolverTorres(int numDiscos, Stack<int> origen, Stack<int> destino, Stack<int> auxiliar)
    {
        // Caso base: Si solo hay un disco, lo movemos directamente a la torre destino
        if (numDiscos == 1)
        {
            destino.Push(origen.Pop());  // Mover el disco de la torre origen a la torre destino
            Console.WriteLine("Mover disco de {0} a {1}", origen.Peek(), destino.Peek());  // Imprimir el movimiento
            return;
        }

        // Recursión: Primero mover los n-1 discos a la torre auxiliar
        ResolverTorres(numDiscos - 1, origen, auxiliar, destino);  
        
        // Mover el disco restante de la torre origen a la torre destino
        destino.Push(origen.Pop());  
        Console.WriteLine("Mover disco de {0} a {1}", origen.Peek(), destino.Peek());  // Imprimir el movimiento

        // Mover los n-1 discos de la torre auxiliar a la torre destino
        ResolverTorres(numDiscos - 1, auxiliar, destino, origen);  
    }

    // Método principal que ejecuta el programa
    public static void Main()
    {
        int numDiscos = 3;  // Número de discos
        Stack<int> torreA = new Stack<int>();  // Torre origen
        Stack<int> torreB = new Stack<int>();  // Torre auxiliar
        Stack<int> torreC = new Stack<int>();  // Torre destino

        // Llenar la torre de origen con discos (el disco más grande tiene el valor más bajo)
        for (int i = numDiscos; i >= 1; i--)
        {
            torreA.Push(i);  // Agregar discos a la torre origen
        }

        Console.WriteLine("Comienza el movimiento de discos:");
        ResolverTorres(numDiscos, torreA, torreC, torreB);  // Llamada al método para resolver el problema
    }
}
