using System;

namespace FigurasGeometricas
{
    // Clase que representa un círculo
    public class Circulo
    {
        // Campo privado para almacenar el radio del círculo
        private double radio;

        // Constructor para inicializar el radio del círculo
        public Circulo(double radio)
        {
            // Validación para asegurarse de que el radio sea mayor que 0
            if (radio <= 0)
                throw new ArgumentException("El radio debe ser mayor que 0"); // Si el radio es menor o igual a 0, lanza una excepción
            this.radio = radio;
        }

        // Propiedad para obtener y establecer el valor del radio
        public double Radio
        {
            get { return radio; } // Devuelve el valor del radio
            set
            {
                if (value <= 0)
                    throw new ArgumentException("El radio debe ser mayor que 0"); // Valida si el nuevo valor es mayor que 0
                radio = value; // Asigna el nuevo valor al radio
            }
        }

        // Método para calcular el área del círculo
        // CalcularArea es una función que devuelve un valor double, se utiliza para calcular el área de un círculo,
        // requiere como argumento el radio del círculo.
        public double CalcularArea()
        {
            // Fórmula para el área del círculo: π * r^2
            return Math.PI * Math.Pow(radio, 2);
        }

        // Método para calcular el perímetro del círculo
        // CalcularPerimetro es una función que devuelve un valor double, se utiliza para calcular el perímetro del círculo,
        // requiere como argumento el radio del círculo.
        public double CalcularPerimetro()
        {
            // Fórmula para el perímetro del círculo: 2 * π * r
            return 2 * Math.PI * radio;
        }
    }

    // Clase que representa un cuadrado
    public class Cuadrado
    {
        // Campo privado para almacenar el lado del cuadrado
        private double lado;

        // Constructor para inicializar el lado del cuadrado
        public Cuadrado(double lado)
        {
            // Validación para asegurarse de que el lado sea mayor que 0
            if (lado <= 0)
                throw new ArgumentException("El lado debe ser mayor que 0"); // Si el lado es menor o igual a 0, lanza una excepción
            this.lado = lado;
        }

        // Propiedad para obtener y establecer el valor del lado
        public double Lado
        {
            get { return lado; } // Devuelve el valor del lado
            set
            {
                if (value <= 0)
                    throw new ArgumentException("El lado debe ser mayor que 0"); // Valida si el nuevo valor es mayor que 0
                lado = value; // Asigna el nuevo valor al lado
            }
        }

        // Método para calcular el área del cuadrado
        // CalcularArea es una función que devuelve un valor double, se utiliza para calcular el área de un cuadrado,
        // requiere como argumento el lado del cuadrado.
        public double CalcularArea()
        {
            // Fórmula para el área del cuadrado: lado * lado
            return lado * lado;
        }

        // Método para calcular el perímetro del cuadrado
        // CalcularPerimetro es una función que devuelve un valor double, se utiliza para calcular el perímetro del cuadrado,
        // requiere como argumento el lado del cuadrado.
        public double CalcularPerimetro()
        {
            // Fórmula para el perímetro del cuadrado: 4 * lado
            return 4 * lado;
        }
    }

    // Clase principal para ejecutar el código
    class Program
    {
        static void Main(string[] args)
        {
            // Solicitamos al usuario que ingrese el radio del círculo
            Console.Write("Ingrese el radio del círculo: ");
            double radio = Convert.ToDouble(Console.ReadLine()); // Leemos el radio y lo convertimos a double

            // Creamos un objeto de la clase Circulo con el radio ingresado
            Circulo circulo = new Circulo(radio);

            // Mostramos el área y el perímetro del círculo
            Console.WriteLine($"Área del círculo: {circulo.CalcularArea()}");
            Console.WriteLine($"Perímetro del círculo: {circulo.CalcularPerimetro()}");

            // Solicitamos al usuario que ingrese el lado del cuadrado
            Console.Write("Ingrese el lado del cuadrado: ");
            double lado = Convert.ToDouble(Console.ReadLine()); // Leemos el lado y lo convertimos a double

            // Creamos un objeto de la clase Cuadrado con el lado ingresado
            Cuadrado cuadrado = new Cuadrado(lado);

            // Mostramos el área y el perímetro del cuadrado
            Console.WriteLine($"Área del cuadrado: {cuadrado.CalcularArea()}");
            Console.WriteLine($"Perímetro del cuadrado: {cuadrado.CalcularPerimetro()}");
        }
    }
}
