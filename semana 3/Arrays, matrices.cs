// Programa Principal
Encabezado();
 
Menu();
 
PiePagina();
 
 
 
/// Funciones
static void Menu(){ // Se debe actualizar cada semana
    Console.WriteLine("Seleccione una opción del menú");
    Console.WriteLine();
    Console.WriteLine("1 Tipos de datos básicos");
    Console.WriteLine("2 POO");
    Console.WriteLine("3 Array y Matrices");
    Console.WriteLine("------------------------------");
    //Console.WriteLine(new string('-', 30));
    Console.WriteLine("0 Salir");
}
 
static void Encabezado(){
    Console.WriteLine("+++++++++++++++++++++++++++++++++");
    Console.WriteLine("+ Universidad Estatal Amazónica +");
    Console.WriteLine("+++++++++++++++++++++++++++++++++");
    Console.WriteLine();
}
 
static void PiePagina(){
    Console.WriteLine();
    Console.WriteLine("---------------------------------");
    Console.WriteLine("  Programado por @El programador");
    Console.WriteLine(new string('=', 33)); // Genera una cadena con 33 signos igual
}


using System;

public class Producto
{
    // Propiedades de la clase
    public int Id { get; set; } // ID del producto (numérico)
    public string Nombre { get; set; } = string.Empty; // Nombre del producto
    public string Unidad { get; set; } = string.Empty; // Unidad de medida
    public double[] Precios { get; set; } // Array para manejar tres precios

    // Constructor por defecto
    public Producto()
    {
        Precios = new double[3]; // Inicializar el array con tres precios
    }

    // Método para registrar un producto
    public void RegistrarProducto(int id, string nombre, string unidad, double[] precios)
    {
        if (precios.Length != 3)
        {
            throw new ArgumentException("Debe proporcionar exactamente tres precios.");
        }

        Id = id;
        Nombre = nombre;
        Unidad = unidad;
        Precios = precios;
    }

    // Método para mostrar la información del producto
    public void MostrarInformacion()
    {
        Console.WriteLine($"ID: {Id}\nNombre: {Nombre}\nUnidad: {Unidad}\nPrecios: {string.Join(", ", Precios)}");
    }
}

// Programa principal para probar la clase
class Program
{
    static void Main(string[] args)
    {
        // Crear una instancia de la clase Producto
        Producto producto = new Producto();

        // Datos del producto
        int id = 101;
        string nombre = "Telefono";
        string unidad = "Unidad";
        double[] precios = { 1200.50, 1300.75, 1400.99 };

        // Registrar el producto
        producto.RegistrarProducto(id, nombre, unidad, precios);

        // Mostrar la información del producto
        producto.MostrarInformacion();
    }
}