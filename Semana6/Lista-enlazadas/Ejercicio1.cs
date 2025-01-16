using System;
using System.Collections.Generic;

namespace Estacionamiento
{
    // Clase que representa un vehículo
    public class Vehiculo
    {
        public string Placa { get; set; } // Propiedad para la placa del vehículo
        public string Marca { get; set; } // Propiedad para la marca del vehículo
        public string Modelo { get; set; } // Propiedad para el modelo del vehículo
        public int Año { get; set; } // Propiedad para el año del vehículo
        public decimal Precio { get; set; } // Propiedad para el precio del vehículo
        public Vehiculo Siguiente { get; set; } // Puntero al siguiente nodo en la lista enlazada

        // Constructor para inicializar los datos del vehículo
        public Vehiculo(string placa, string marca, string modelo, int año, decimal precio)
        {
            Placa = placa;
            Marca = marca;
            Modelo = modelo;
            Año = año;
            Precio = precio;
            Siguiente = null; // Inicialmente no apunta a ningún otro nodo
        }
    }

    // Clase que representa la lista enlazada de vehículos
    public class ListaVehiculos
    {
        private Vehiculo cabeza; // Nodo inicial de la lista

        // Constructor que inicializa la lista vacía
        public ListaVehiculos()
        {
            cabeza = null;
        }

        // Método para agregar un nuevo vehículo a la lista
        public void AgregarVehiculo(string placa, string marca, string modelo, int año, decimal precio)
        {
            Vehiculo nuevoVehiculo = new Vehiculo(placa, marca, modelo, año, precio); // Crear nuevo nodo
            if (cabeza == null) // Si la lista está vacía
            {
                cabeza = nuevoVehiculo; // El nuevo vehículo es la cabeza
            }
            else
            {
                Vehiculo actual = cabeza;
                // Recorre hasta el último nodo
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = nuevoVehiculo; // Añade el nuevo vehículo al final de la lista
            }
            Console.WriteLine("Vehículo agregado exitosamente.");
        }

        // Método para buscar un vehículo por su placa
        public void BuscarPorPlaca(string placa)
        {
            Vehiculo actual = cabeza;
            while (actual != null) // Recorre la lista
            {
                if (actual.Placa == placa) // Compara la placa
                {
                    // Muestra los datos del vehículo encontrado
                    Console.WriteLine($"Placa: {actual.Placa}, Marca: {actual.Marca}, Modelo: {actual.Modelo}, Año: {actual.Año}, Precio: {actual.Precio}");
                    return;
                }
                actual = actual.Siguiente;
            }
            Console.WriteLine("Vehículo no encontrado.");
        }

        // Método para mostrar los vehículos registrados en un año específico
        public void VerPorAño(int año)
        {
            Vehiculo actual = cabeza;
            bool encontrado = false;
            while (actual != null) // Recorre la lista
            {
                if (actual.Año == año) // Compara el año
                {
                    // Muestra los datos de los vehículos encontrados
                    Console.WriteLine($"Placa: {actual.Placa}, Marca: {actual.Marca}, Modelo: {actual.Modelo}, Precio: {actual.Precio}");
                    encontrado = true;
                }
                actual = actual.Siguiente;
            }
            if (!encontrado) // Si no se encontró ningún vehículo
            {
                Console.WriteLine("No se encontraron vehículos para ese año.");
            }
        }

        // Método para mostrar todos los vehículos registrados
        public void VerTodos()
        {
            Vehiculo actual = cabeza;
            if (actual == null) // Si la lista está vacía
            {
                Console.WriteLine("No hay vehículos registrados.");
                return;
            }

            while (actual != null) // Recorre la lista
            {
                // Muestra los datos de cada vehículo
                Console.WriteLine($"Placa: {actual.Placa}, Marca: {actual.Marca}, Modelo: {actual.Modelo}, Año: {actual.Año}, Precio: {actual.Precio}");
                actual = actual.Siguiente;
            }
        }

        // Método para eliminar un vehículo por su placa
        public void EliminarPorPlaca(string placa)
        {
            if (cabeza == null) // Si la lista está vacía
            {
                Console.WriteLine("No hay vehículos registrados.");
                return;
            }

            if (cabeza.Placa == placa) // Si el vehículo a eliminar es la cabeza
            {
                cabeza = cabeza.Siguiente; // La cabeza ahora apunta al siguiente nodo
                Console.WriteLine("Vehículo eliminado exitosamente.");
                return;
            }

            Vehiculo actual = cabeza;
            // Busca el nodo anterior al que se desea eliminar
            while (actual.Siguiente != null && actual.Siguiente.Placa != placa)
            {
                actual = actual.Siguiente;
            }

            if (actual.Siguiente != null) // Si encontró el vehículo
            {
                actual.Siguiente = actual.Siguiente.Siguiente; // Salta el nodo a eliminar
                Console.WriteLine("Vehículo eliminado exitosamente.");
            }
            else
            {
                Console.WriteLine("Vehículo no encontrado.");
            }
        }
    }

    // Clase principal del programa
    class Program
    {
        static void Main(string[] args)
        {
            ListaVehiculos listaVehiculos = new ListaVehiculos(); // Crear instancia de la lista enlazada

            while (true) // Bucle principal del programa
            {
                Console.WriteLine("\nMenú de opciones:");
                Console.WriteLine("1. Agregar vehículo");
                Console.WriteLine("2. Buscar vehículo por placa");
                Console.WriteLine("3. Ver vehículos por año");
                Console.WriteLine("4. Ver todos los vehículos registrados");
                Console.WriteLine("5. Eliminar vehículo");
                Console.WriteLine("6. Salir");
                Console.Write("Seleccione una opción: ");

                int opcion = int.Parse(Console.ReadLine()); // Lee la opción del usuario

                switch (opcion)
                {
                    case 1: // Agregar vehículo
                        Console.Write("Ingrese la placa: ");
                        string placa = Console.ReadLine();
                        Console.Write("Ingrese la marca: ");
                        string marca = Console.ReadLine();
                        Console.Write("Ingrese el modelo: ");
                        string modelo = Console.ReadLine();
                        Console.Write("Ingrese el año: ");
                        int año = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese el precio: ");
                        decimal precio = decimal.Parse(Console.ReadLine());
                        listaVehiculos.AgregarVehiculo(placa, marca, modelo, año, precio);
                        break;

                    case 2: // Buscar vehículo por placa
                        Console.Write("Ingrese la placa: ");
                        placa = Console.ReadLine();
                        listaVehiculos.BuscarPorPlaca(placa);
                        break;

                    case 3: // Ver vehículos por año
                        Console.Write("Ingrese el año: ");
                        año = int.Parse(Console.ReadLine());
                        listaVehiculos.VerPorAño(año);
                        break;

                    case 4: // Ver todos los vehículos registrados
                        listaVehiculos.VerTodos();
                        break;

                    case 5: // Eliminar vehículo
                        Console.Write("Ingrese la placa: ");
                        placa = Console.ReadLine();
                        listaVehiculos.EliminarPorPlaca(placa);
                        break;

                    case 6: // Salir del programa
                        Console.WriteLine("Saliendo del programa...");
                        return;

                    default: // Opción inválida
                        Console.WriteLine("Opción inválida. Intente nuevamente.");
                        break;
                }
            }
        }
    }
}
