using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Crear una lista enlazada para almacenar números enteros
        LinkedList<int> listaEnlazada = new LinkedList<int>();
        Random random = new Random();

        // Generar 50 números aleatorios entre 1 y 999 y agregarlos a la lista enlazada
        for (int i = 0; i < 50; i++)
        {
            int numeroAleatorio = random.Next(1, 1000); // Generar un número aleatorio
            listaEnlazada.AddLast(numeroAleatorio); // Agregar el número a la lista
        }

        // Mostrar los números generados
        Console.WriteLine("Lista generada inicialmente:");
        foreach (var numero in listaEnlazada)
        {
            Console.Write(numero + " ");
        }
        Console.WriteLine();

        // Leer los valores de rango desde el teclado
        Console.WriteLine("Ingrese el valor mínimo del rango:");
        int rangoMinimo = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el valor máximo del rango:");
        int rangoMaximo = int.Parse(Console.ReadLine());

        // Validar que el rango sea correcto
        if (rangoMinimo > rangoMaximo)
        {
            Console.WriteLine("El rango mínimo no puede ser mayor que el rango máximo.");
            return;
        }

        // Recorrer la lista y eliminar nodos fuera del rango
        LinkedListNode<int> nodoActual = listaEnlazada.First; // Apuntar al primer nodo
        while (nodoActual != null)
        {
            LinkedListNode<int> siguienteNodo = nodoActual.Next; // Guardar referencia al siguiente nodo
            if (nodoActual.Value < rangoMinimo || nodoActual.Value > rangoMaximo)
            {
                listaEnlazada.Remove(nodoActual); // Eliminar el nodo si está fuera del rango
            }
            nodoActual = siguienteNodo; // Mover al siguiente nodo
        }

        // Mostrar la lista después de eliminar los nodos fuera del rango
        Console.WriteLine("Lista después de eliminar nodos fuera del rango:");
        foreach (var numero in listaEnlazada)
        {
            Console.Write(numero + " ");
        }
        Console.WriteLine();
    }
}
