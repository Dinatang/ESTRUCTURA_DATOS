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
            // Validación del radio, asegurándose de que sea mayor que 0
            if (radio <= 0)
                throw new ArgumentException("El radio debe ser mayor que 0"); 
            
            // Asignación del valor del radio
            this.radio = radio;
        }

        // Propiedad para obtener y establecer el valor del radio
        public double Radio
        {
            get { return radio; } // Devuelve el valor del radio
            set
            {
                // Validación del valor del radio
                if (value <= 0)
                    throw new ArgumentException("El radio debe ser mayor que 0"); 
                
                radio = value; // Asigna el nuevo valor al radio
            }
        }

        // Método para calcular el área del círculo
        public double CalcularArea()
        {
            // Fórmula para calcular el área: π * r^2
            return Math.PI * Math.Pow(radio, 2); 
        }

        // Método para calcular el perímetro del círculo
        public double CalcularPerimetro()
        {
            // Fórmula para calcular el perímetro: 2 * π * r
            return 2 * Math.PI * radio;
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
            // Validación de las dimensiones, asegurándose de que sean mayores que 0
            if (largo <= 0 || ancho <= 0)
                throw new ArgumentException("El largo y el ancho deben ser mayores que 0"); 
            
            // Asignación de los valores del largo y ancho
            this.largo = largo;
            this.ancho = ancho;
        }

        // Propiedad para obtener y establecer el valor del largo
        public double Largo
        {
            get { return largo; } // Devuelve el valor del largo
            set
            {
                // Validación del valor del largo
                if (value <= 0)
                    throw new ArgumentException("El largo debe ser mayor que 0"); 
                
                largo = value; // Asigna el nuevo valor al largo
            }
        }

        // Propiedad para obtener y establecer el valor del ancho
        public double Ancho
        {
            get { return ancho; } // Devuelve el valor del ancho
            set
            {
                // Validación del valor del ancho
                if (value <= 0)
                    throw new ArgumentException("El ancho debe ser mayor que 0"); 
                
                ancho = value; // Asigna el nuevo valor al ancho
            }
        }

        // Método para calcular el área del rectángulo
        public double CalcularArea()
        {
            // Fórmula para calcular el área: largo * ancho
            return largo * ancho; 
        }

        // Método para calcular el perímetro del rectángulo
        public double CalcularPerimetro()
        {
            // Fórmula para calcular el perímetro: 2 * (largo + ancho)
            return 2 * (largo + ancho); 
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Solicitamos al usuario que ingrese el radio del círculo
            Console.Write("Ingrese el radio del círculo: ");
            double radio = Convert.ToDouble(Console.ReadLine()); // Leemos el valor y lo convertimos a double

            // Creamos un objeto de la clase Circulo con el radio ingresado
            Circulo circulo = new Circulo(radio);

            // Mostramos el área y el perímetro del círculo
            Console.WriteLine($"Área del círculo: {circulo.CalcularArea()}");
            Console.WriteLine($"Perímetro del círculo: {circulo.CalcularPerimetro()}");

            // Solicitamos al usuario que ingrese las dimensiones del rectángulo
            Console.Write("Ingrese el largo del rectángulo: ");
            double largo = Convert.ToDouble(Console.ReadLine()); // Leemos el largo y lo convertimos a double

            Console.Write("Ingrese el ancho del rectángulo: ");
            double ancho = Convert.ToDouble(Console.ReadLine()); // Leemos el ancho y lo convertimos a double

            // Creamos un objeto de la clase Rectangulo con el largo y ancho ingresados
            Rectangulo rectangulo = new Rectangulo(largo, ancho);

            // Mostramos el área y el perímetro del rectángulo
            Console.WriteLine($"Área del rectángulo: {rectangulo.CalcularArea()}");
            Console.WriteLine($"Perímetro del rectángulo: {rectangulo.CalcularPerimetro()}");
        }
    }
}
