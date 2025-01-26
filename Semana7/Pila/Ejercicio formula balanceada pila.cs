using System;
using System.Collections.Generic;

class Program
{
    static bool EsBalanceado(string expresion)
    {
        Stack<char> pila = new Stack<char>();  // Usamos una pila para almacenar los símbolos de apertura

        // Recorremos cada carácter en la expresión
        foreach (char simbolo in expresion)
        {
            // Si el símbolo es de apertura, lo añadimos a la pila
            if (simbolo == '(' || simbolo == '{' || simbolo == '[')
            {
                pila.Push(simbolo);
            }
            // Si es un símbolo de cierre, comprobamos si coincide con el de apertura en la pila
            else if (simbolo == ')' || simbolo == '}' || simbolo == ']')
            {
                if (pila.Count == 0)
                    return false;  // No hay ningún símbolo de apertura para emparejar

                char ultimo = pila.Pop();
                if (!Coincide(ultimo, simbolo))
                {
                    return false;  // No coinciden
                }
            }
        }

        // Si la pila está vacía, significa que los símbolos están balanceados
        return pila.Count == 0;
    }

    // Verifica si un par de símbolos coinciden
    static bool Coincide(char apertura, char cierre)
    {
        return (apertura == '(' && cierre == ')') ||
               (apertura == '{' && cierre == '}') ||
               (apertura == '[' && cierre == ']');
    }

    static void Main()
    {
        // Prueba de la función con ejemplos
        Console.WriteLine("Ingrese una expresión para verificar si está balanceada:");
        string expresion = Console.ReadLine();

        if (EsBalanceado(expresion))
        {
            Console.WriteLine("La expresión está balanceada.");
        }
        else
        {
            Console.WriteLine("La expresión no está balanceada.");
        }
    }
}
