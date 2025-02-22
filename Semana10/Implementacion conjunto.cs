
class Program
{
    static void Main()
    {
        // Crear un conjunto ficticio de 500 ciudadanos
        HashSet<int> ciudadanos = new HashSet<int>(Enumerable.Range(1, 500));

        // Crear un conjunto ficticio de 75 ciudadanos vacunados con Pfizer
        HashSet<int> vacunadosPfizer = new HashSet<int>(Enumerable.Range(1, 75));

        // Crear un conjunto ficticio de 75 ciudadanos vacunados con AstraZeneca
        HashSet<int> vacunadosAstraZeneca = new HashSet<int>(Enumerable.Range(76, 75));

        // Ciudadanos que no se han vacunado
        HashSet<int> noVacunados = new HashSet<int>(ciudadanos);
        noVacunados.ExceptWith(vacunadosPfizer);
        noVacunados.ExceptWith(vacunadosAstraZeneca);

        // Ciudadanos que han recibido las dos vacunas (intersección de los dos conjuntos)
        HashSet<int> vacunadosAmbas = new HashSet<int>(vacunadosPfizer);
        vacunadosAmbas.IntersectWith(vacunadosAstraZeneca);

        // Ciudadanos que solamente han recibido la vacuna de Pfizer
        HashSet<int> soloPfizer = new HashSet<int>(vacunadosPfizer);
        soloPfizer.ExceptWith(vacunadosAstraZeneca);

        // Ciudadanos que solamente han recibido la vacuna de AstraZeneca
        HashSet<int> soloAstraZeneca = new HashSet<int>(vacunadosAstraZeneca);
        soloAstraZeneca.ExceptWith(vacunadosPfizer);

        // Mostrar resultados
        Console.WriteLine("Ciudadanos no vacunados: " + noVacunados.Count);
        Console.WriteLine("Ciudadanos vacunados con ambas vacunas: " + vacunadosAmbas.Count);
        Console.WriteLine("Ciudadanos vacunados solo con Pfizer: " + soloPfizer.Count);
        Console.WriteLine("Ciudadanos vacunados solo con AstraZeneca: " + soloAstraZeneca.Count);
    }
}
