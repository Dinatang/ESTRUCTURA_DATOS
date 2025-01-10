using System;
using System.Collections.Generic;

// Definir record representando al paciente
public record Paciente(string Nombre, int Edad, string Identificacion);

// Definir un struct para representar un Turno
public struct Turno
{
    public Paciente Paciente { get; } // Paciente del turno
    public DateTime Fecha { get; } // Fecha del turno
    public string Especialidad { get; } // Especialidad médica para asignar turno

    // Constructor para crear los datos del turno
    public Turno(Paciente paciente, DateTime fecha, string especialidad)
    {
        Paciente = paciente;
        Fecha = fecha;
        Especialidad = especialidad;
    }
}

// Clase que maneja la agenda de turnos
public class Agenda
{
    private List<Turno> turnos;

    // Constructor
    public Agenda()
    {
        turnos = new List<Turno>();
    }

    // Método para agregar turnos a la agenda
    public void AgregarTurno(Turno turno)
    {
        turnos.Add(turno);
    }

    // Mostrar los turnos almacenados en la agenda
    public void MostrarTurnos()
    {
        foreach (var turno in turnos)
        {
            Console.WriteLine($"\nPaciente: {turno.Paciente.Nombre}, Edad: {turno.Paciente.Edad}, Identificación: {turno.Paciente.Identificacion}, Especialidad: {turno.Especialidad}, Fecha: {turno.Fecha}");
        }
    }

    // Matriz de obtención de turnos por la especialidad
    public Turno[,] ObtenerMatrizTurnosPorEspecialidad(string especialidad)
    {
        // Filtrar turnos por especialidad específica
        var turnosFiltrados = turnos.FindAll(t => t.Especialidad == especialidad);

        // Matriz con filas para cada turno
        Turno[,] matrizTurnos = new Turno[turnosFiltrados.Count, 1];

        for (int i = 0; i < turnosFiltrados.Count; i++)
        {
            matrizTurnos[i, 0] = turnosFiltrados[i];
        }
        return matrizTurnos;
    }
}

// Clase principal para pruebas
public class Ejercicio2
{
    public static void Main()
    {
        // Crear una agenda
        Agenda agenda = new Agenda();

        // Crear pacientes
        Paciente paciente1 = new("Juan Pérez", 30, "123456");
        Paciente paciente2 = new("Ana Gómez", 25, "654321");

        // Crear turnos
        Turno turno1 = new Turno(paciente1, new DateTime(2025, 1, 15, 10, 0, 0), "Cardiología");
        Turno turno2 = new Turno(paciente2, new DateTime(2025, 1, 15, 11, 0, 0), "Pediatría");
        Turno turno3 = new Turno(paciente1, new DateTime(2025, 1, 16, 9, 0, 0), "Cardiología");

        // Agregar turnos a la agenda
        agenda.AgregarTurno(turno1);
        agenda.AgregarTurno(turno2);
        agenda.AgregarTurno(turno3);

        // Mostrar turnos
        Console.WriteLine("Turnos en la agenda:");
        agenda.MostrarTurnos();

        // Obtener matriz de turnos por especialidad
        Console.WriteLine("\nTurnos para la especialidad Cardiología:");
        var matriz = agenda.ObtenerMatrizTurnosPorEspecialidad("Cardiología");

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            Console.WriteLine($"Paciente: {matriz[i, 0].Paciente.Nombre}, Fecha: {matriz[i, 0].Fecha}");
        }
    }
}
