using System;
using System.Collections.Generic;

class Ejercicio2
{
    public Ejercicio2()
    {
    }

    static void Main()
    {
        // Lista de asignaturas
        List<string> asignaturas = new List<string> { "Matemáticas", "Física", "Química", "Historia", "Lengua" };

        // Recorrer la lista y mostrar el mensaje
        foreach (string asignatura in asignaturas)
        {
            Console.WriteLine($"Yo estudio {asignatura}");
        }
    }
}
