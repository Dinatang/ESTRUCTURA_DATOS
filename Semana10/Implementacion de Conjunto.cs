
class Program
{
    static void Main()
    {
        // Crear un conjunto ficticio de 500 ciudadanos
        HashSet<int> ciudadanos = new HashSet<int>();
        for (int i = 1; i <= 500; i++)
        {
            ciudadanos.Add(i);
        }

        // Crear conjuntos ficticios de 75 ciudadanos vacunados con Pfizer y Astrazeneca
        HashSet<int> pfizer = new HashSet<int>();
        HashSet<int> astrazeneca = new HashSet<int>();

        // Asumimos que los ciudadanos vacunados con Pfizer son del 1 al 75
        for (int i = 1; i <= 75; i++)
        {
            pfizer.Add(i);
        }

        // Asumimos que los ciudadanos vacunados con Astrazeneca son del 50 al 124
        for (int i = 50; i <= 124; i++)
        {
            astrazeneca.Add(i);
        }

        // Operaciones de conjuntos
        // 1. Listado de ciudadanos que no se han vacunado
        var noVacunados = ciudadanos.Except(pfizer.Union(astrazeneca));

        // 2. Listado de ciudadanos que han recibido las dos vacunas
        var ambosVacunados = pfizer.Intersect(astrazeneca);

        // 3. Listado de ciudadanos que solamente han recibido la vacuna de Pfizer
        var soloPfizer = pfizer.Except(astrazeneca);

        // 4. Listado de ciudadanos que solamente han recibido la vacuna de Astrazeneca
        var soloAstrazeneca = astrazeneca.Except(pfizer);

        // Mostrar los resultados
        Console.WriteLine("Ciudadanos no vacunados: " + noVacunados.Count());
        Console.WriteLine("Ciudadanos vacunados con ambas vacunas: " + ambosVacunados.Count());
        Console.WriteLine("Ciudadanos vacunados solamente con Pfizer: " + soloPfizer.Count());
        Console.WriteLine("Ciudadanos vacunados solamente con Astrazeneca: " + soloAstrazeneca.Count());
    }
}
