using System;

namespace FigurasGeometricas
{
    // Clase para un círculo
    public class Circulo
    {
        private double radio;

        // Constructor
        public Circulo(double radio)
        {
            if (radio <= 0)
                throw new ArgumentException("El radio debe ser mayor que 0");
            this.radio = radio;
        }

        // Propiedad para acceder y modificar el radio
        public double Radio
        {
            get { return radio; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("El radio debe ser mayor que 0");
                radio = value;
            }
        }

        // Método para calcular el área
        public double CalcularArea()
        {
            return Math.PI * Math.Pow(radio, 2);
        }

        // Método para calcular el perímetro
        public double CalcularPerimetro()
        {
            return 2 * Math.PI * radio;
        }
    }

    // Clase para un rectángulo
    public class Rectangulo
    {
        private double largo;
        private double ancho;

        // Constructor
        public Rectangulo(double largo, double ancho)
        {
            if (largo <= 0 || ancho <= 0)
                throw new ArgumentException("El largo y el ancho deben ser mayores que 0");
            this.largo = largo;
            this.ancho = ancho;
        }

        // Propiedades para acceder y modificar el largo y el ancho
        public double Largo
        {
            get { return largo; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("El largo debe ser mayor que 0");
                largo = value;
            }
        }

        public double Ancho
        {
            get { return ancho; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("El ancho debe ser mayor que 0");
                ancho = value;
            }
        }

        // Método para calcular el área
        public double CalcularArea()
        {
            return largo * ancho;
        }

        // Método para calcular el perímetro
        public double CalcularPerimetro()
        {
            return 2 * (largo + ancho);
        }
    }

    // Clase principal para probar las figuras geométricas
    class Program
    {
        static void Main(string[] args)
        {
            // Crear un círculo y mostrar sus cálculos
            Circulo circulo = new Circulo(5);
            Console.WriteLine("Círculo:");
            Console.WriteLine($"Radio: {circulo.Radio}");
            Console.WriteLine($"Área: {circulo.CalcularArea()}");
            Console.WriteLine($"Perímetro: {circulo.CalcularPerimetro()}");

            // Crear un rectángulo y mostrar sus cálculos
            Rectangulo rectangulo = new Rectangulo(10, 5);
            Console.WriteLine("\nRectángulo:");
            Console.WriteLine($"Largo: {rectangulo.Largo}");
            Console.WriteLine($"Ancho: {rectangulo.Ancho}");
            Console.WriteLine($"Área: {rectangulo.CalcularArea()}");
            Console.WriteLine($"Perímetro: {rectangulo.CalcularPerimetro()}");
        }
    }
}


