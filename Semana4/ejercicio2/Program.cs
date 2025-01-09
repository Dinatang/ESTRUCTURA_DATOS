using System;
using System.Collections.Generic;

internal class Cal_PRO
{
    static void Main()
    {
        // Lista para almacenar los números ingresados por el usuario
        List<double> numeros = new List<double>();

        Console.WriteLine("¿Cuántos números deseas ingresar?");
        
        // Leer la cantidad de números
        bool esNumeroValido = int.TryParse(Console.ReadLine(), out int cantidad);

        if (!esNumeroValido || cantidad <= 0)
        {
            Console.WriteLine("Por favor, introduce un número válido mayor que 0.");
            return;
        }

        // Solicitar los números al usuario
        for (int i = 0; i < cantidad; i++)
        {
            Console.Write($"Introduce el número {i + 1}: ");
            bool numeroValido = double.TryParse(Console.ReadLine(), out double numero);

            if (numeroValido)
            {
                numeros.Add(numero);
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, introduce un número válido.");
                i--; // Permitir repetir la entrada actual
            }
        }

        // Calcular el promedio
        double suma = 0;
        foreach (double numero in numeros)
        {
            suma += numero;
        }
        double promedio = suma / numeros.Count;

        // Mostrar el promedio
        Console.WriteLine($"\nEl promedio de los números ingresados es: {promedio:F2}");
    }
}
