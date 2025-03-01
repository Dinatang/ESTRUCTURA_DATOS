class Traductor
{
    static void Main()
    {
        // Crear un diccionario que mapea palabras en inglés a español
        Dictionary<string, string> diccionario = new Dictionary<string, string>
        {
            { "Time", "tiempo" },
            { "Person", "persona" },
            { "Year", "año" },
            { "Way", "camino" },
            { "Day", "día" },
            { "Thing", "cosa" },
            { "Man", "hombre" },
            { "World", "mundo" },
            { "Life", "vida" },
            { "Hand", "mano" },
            { "Part", "parte" },
            { "Child", "niño" },
            { "Eye", "ojo" },
            { "Woman", "mujer" },
            { "Place", "lugar" },
            { "Work", "trabajo" },
            { "Week", "semana" },
            { "Case", "caso" },
            { "Point", "punto" },
            { "Government", "gobierno" },
            { "Company", "empresa" }
        };

        while (true)
        {
            // Mostrar el menú
            Console.Clear();
            Console.WriteLine("MENU");
            Console.WriteLine("=======================================================");
            Console.WriteLine("1. Traducir una frase");
            Console.WriteLine("2. Ingresar más palabras al diccionario");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");
            int opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion == 1)
            {
                // Traducir una frase
                Console.Write("Ingrese la frase: ");
                string frase = Console.ReadLine();

                // Separar la frase en palabras
                string[] palabras = frase.Split(' ');

                // Traducir las palabras que están en el diccionario
                for (int i = 0; i < palabras.Length; i++)
                {
                    string palabra = palabras[i];
                    if (diccionario.ContainsKey(palabra))
                    {
                        palabras[i] = diccionario[palabra];
                    }
                }

                // Mostrar la frase traducida
                Console.WriteLine("Su frase traducida es: " + string.Join(" ", palabras));
                Console.ReadKey();
            }
            else if (opcion == 2)
            {
                // Ingresar más palabras al diccionario
                Console.Write("Ingrese la palabra en inglés: ");
                string palabraIngles = Console.ReadLine();
                Console.Write("Ingrese la traducción en español: ");
                string traduccionEspanol = Console.ReadLine();

                // Agregar al diccionario
                if (!diccionario.ContainsKey(palabraIngles))
                {
                    diccionario.Add(palabraIngles, traduccionEspanol);
                    Console.WriteLine("Palabra añadida correctamente.");
                }
                else
                {
                    Console.WriteLine("La palabra ya está en el diccionario.");
                }
                Console.ReadKey();
            }
            else if (opcion == 0)
            {
                // Salir
                break;
            }
            else
            {
                Console.WriteLine("Opción no válida. Intente de nuevo.");
                Console.ReadKey();
            }
        }
    }
}
