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
            if (radio <= 0)
                throw new ArgumentException("El radio debe ser mayor que 0"); // Validación del radio
            this.radio = radio;
        }

        // Propiedad para obtener y establecer el valor del radio
        public double Radio
        {
            get { return radio; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("El radio debe ser mayor que 0"); // Validación del radio
                radio = value;
            }
        }

        // Método para calcular el área del círculo
        public double CalcularArea()
        {
            return Math.PI * Math.Pow(radio, 2); // Fórmula del área: π * r^2
        }

        // Método para calcular el perímetro del círculo
        public double CalcularPerimetro()
        {
            return 2 * Math.PI * radio; // Fórmula del perímetro: 2 * π * r
        }
    }

    // Clase que representa un rectángulo
    public class Rectangulo
    {
        // Campos privados para almacenar las dimensiones del rectángulo
        private double largo;
        private double ancho;

        // Constructor para inicializar el largo y el ancho del rectángulo
        public Rectangulo(double largo, double ancho)
        {
            if (largo <= 0 || ancho <= 0)
                throw new ArgumentException("El largo y el ancho deben ser mayores que 0"); // Validación de dimensiones
            this.largo = largo;
            this.ancho = ancho;
        }

        // Propiedad para obtener y establecer el valor del largo
        public double Largo
        {
            get { return largo; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("El largo debe ser mayor que 0"); // Validación del largo
                largo = value;
            }
        }

        // Propiedad para obtener y establecer el valor del ancho
        public double Ancho
        {
            get { return ancho; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("El ancho debe ser mayor que 0"); // Validación del ancho
                ancho = value;
            }
        }

        // Método para calcular el área del rectángulo
        public double CalcularArea()
        {
            return largo * ancho; // Fórmula del área: largo * ancho
        }

        // Método para calcular el perímetro del rectángulo
        public double CalcularPerimetro()
        {
            return 2 * (largo + ancho); // Fórmula del perímetro: 2 * (largo + ancho)
        }
    }

    // Clase principal para probar las funcionalidades de las figuras geométricas
    class Program
    {
        static void Main(string[] args)
        {
            // Crear un círculo con un radio de 5 unidades
            Circulo circulo = new Circulo(5);
            Console.WriteLine("Círculo:");
            Console.WriteLine($"Radio: {circulo.Radio}"); // Mostrar el radio del círculo
            Console.WriteLine($"Área: {circulo.CalcularArea()}"); // Mostrar el área del círculo
            Console.WriteLine($"Perímetro: {circulo.CalcularPerimetro()}"); // Mostrar el perímetro del círculo

            // Crear un rectángulo con un largo de 10 unidades y un ancho de 5 unidades
            Rectangulo rectangulo = new Rectangulo(10, 5);
            Console.WriteLine("\nRectángulo:");
            Console.WriteLine($"Largo: {rectangulo.Largo}"); // Mostrar el largo del rectángulo
            Console.WriteLine($"Ancho: {rectangulo.Ancho}"); // Mostrar el ancho del rectángulo
            Console.WriteLine($"Área: {rectangulo.CalcularArea()}"); // Mostrar el área del rectángulo
            Console.WriteLine($"Perímetro: {rectangulo.CalcularPerimetro()}"); // Mostrar el perímetro del rectángulo
        }
    }
}



