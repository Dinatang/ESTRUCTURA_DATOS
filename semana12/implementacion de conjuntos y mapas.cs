using System;
using System.Collections.Generic;

class Program
{
    // Definir clases para representar los jugadores y equipos
    public class Jugador
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Posicion { get; set; }

        public Jugador(string nombre, int edad, string posicion)
        {
            Nombre = nombre;
            Edad = edad;
            Posicion = posicion;
        }

        public override string ToString()
        {
            return $"{Nombre} (Edad: {Edad}, Posición: {Posicion})";
        }
    }

    public class Equipo
    {
        public string Nombre { get; set; }
        public string Entrenador { get; set; }
        public HashSet<Jugador> Jugadores { get; set; }

        public Equipo(string nombre, string entrenador)
        {
            Nombre = nombre;
            Entrenador = entrenador;
            Jugadores = new HashSet<Jugador>();
        }

        // Método para agregar un jugador al equipo
        public void AgregarJugador(Jugador jugador)
        {
            Jugadores.Add(jugador);
        }

        public void MostrarEquipo()
        {
            Console.WriteLine($"Equipo: {Nombre} (Entrenador: {Entrenador})");
            Console.WriteLine("Jugadores:");
            foreach (var jugador in Jugadores)
            {
                Console.WriteLine($"- {jugador}");
            }
        }
    }

    static void Main()
    {
        // Diccionario que almacena equipos por nombre
        Dictionary<string, Equipo> equipos = new Dictionary<string, Equipo>();

        while (true)
        {
            Console.WriteLine("\n--- Menú de Torneo de Fútbol ---");
            Console.WriteLine("1. Registrar equipo");
            Console.WriteLine("2. Registrar jugador en un equipo");
            Console.WriteLine("3. Mostrar todos los equipos");
            Console.WriteLine("4. Mostrar jugadores de un equipo");
            Console.WriteLine("5. Salir");
            Console.Write("Selecciona una opción: ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    // Registrar equipo
                    Console.Write("Ingresa el nombre del equipo: ");
                    string nombreEquipo = Console.ReadLine();
                    Console.Write("Ingresa el nombre del entrenador: ");
                    string entrenador = Console.ReadLine();
                    if (!equipos.ContainsKey(nombreEquipo))
                    {
                        equipos[nombreEquipo] = new Equipo(nombreEquipo, entrenador);
                        Console.WriteLine("Equipo registrado exitosamente.");
                    }
                    else
                    {
                        Console.WriteLine("Ya existe un equipo con ese nombre.");
                    }
                    break;

                case 2:
                    // Registrar jugador en un equipo
                    Console.Write("Ingresa el nombre del equipo: ");
                    nombreEquipo = Console.ReadLine();
                    if (equipos.ContainsKey(nombreEquipo))
                    {
                        Console.Write("Ingresa el nombre del jugador: ");
                        string nombreJugador = Console.ReadLine();
                        Console.Write("Ingresa la edad del jugador: ");
                        int edad = int.Parse(Console.ReadLine());
                        Console.Write("Ingresa la posición del jugador: ");
                        string posicion = Console.ReadLine();

                        Jugador jugador = new Jugador(nombreJugador, edad, posicion);
                        equipos[nombreEquipo].AgregarJugador(jugador);
                        Console.WriteLine("Jugador registrado exitosamente.");
                    }
                    else
                    {
                        Console.WriteLine("No existe un equipo con ese nombre.");
                    }
                    break;

                case 3:
                    // Mostrar todos los equipos
                    Console.WriteLine("\nEquipos registrados:");
                    foreach (var equipo in equipos.Values)
                    {
                        Console.WriteLine($"- {equipo.Nombre}");
                    }
                    break;

                case 4:
                    // Mostrar jugadores de un equipo
                    Console.Write("Ingresa el nombre del equipo para ver sus jugadores: ");
                    nombreEquipo = Console.ReadLine();
                    if (equipos.ContainsKey(nombreEquipo))
                    {
                        equipos[nombreEquipo].MostrarEquipo();
                    }
                    else
                    {
                        Console.WriteLine("No existe un equipo con ese nombre.");
                    }
                    break;

                case 5:
                    // Salir
                    Console.WriteLine("¡Hasta luego!");
                    return;

                default:
                    Console.WriteLine("Opción no válida. Intenta nuevamente.");
                    break;
            }
        }
    }
}

