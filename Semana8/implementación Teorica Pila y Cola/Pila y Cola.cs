
public class Asientos
{
    private Stack<int> pilaAsientos;  // Usamos una pila para gestionar los asientos disponibles.

    // Constructor que inicializa la pila con asientos
    public Asientos(int numAsientos)
    {
        pilaAsientos = new Stack<int>();
        for (int i = numAsientos; i >= 1; i--)
        {
            pilaAsientos.Push(i);  // Coloca los asientos en la pila (el último asiento será el primero en ser asignado).
        }
    }

    // Método para asignar un asiento. Saca el asiento de la pila y lo asigna.
    public int AsignarAsiento()
    {
        if (pilaAsientos.Count > 0)
        {
            return pilaAsientos.Pop();  // Devuelve el último asiento disponible (pila LIFO).
        }
        else
        {
            return -1;  // No quedan asientos disponibles.
        }
    }

    // Método para liberar un asiento (si es necesario). Lo coloca de nuevo en la pila.
    public void LiberarAsiento(int asiento)
    {
        pilaAsientos.Push(asiento);  // Coloca el asiento nuevamente en la pila.
    }
}

public class Congreso
{
    private Queue<int> colaCongresistas;  // Usamos una cola para gestionar el registro de congresistas.
    private Asientos asientos;  // Referencia a los asientos disponibles.

    // Constructor que inicializa la cola de congresistas
    public Congreso(int numCongresistas, Asientos asientos)
    {
        colaCongresistas = new Queue<int>();
        for (int i = 1; i <= numCongresistas; i++)
        {
            colaCongresistas.Enqueue(i);  // Agrega congresistas a la cola (FIFO).
        }
        this.asientos = asientos;
    }

    // Método para registrar congresistas en asientos
    public void RegistrarAsientos(int persona)
    {
        while (colaCongresistas.Count > 0)
        {
            int congresista = colaCongresistas.Dequeue();  // El primer congresista en la cola es el primero en ser registrado.
            int asientoAsignado = asientos.AsignarAsiento();
            if (asientoAsignado != -1)
            {
                Console.WriteLine($"Persona {persona} asignó asiento {asientoAsignado} al congresista {congresista}");
            }
            else
            {
                Console.WriteLine($"No quedan asientos disponibles para el congresista {congresista}");
            }
        }
    }
}

public class Program
{
    public static void Main()
    {
        // Inicializamos los 30 asientos disponibles en forma de pila (LIFO)
        Asientos asientos = new Asientos(30);

        // Inicializamos el congreso con 100 congresistas
        Congreso congreso = new Congreso(100, asientos);

        // Creamos dos hilos para registrar a los congresistas de manera concurrente
        Thread persona1 = new Thread(() => congreso.RegistrarAsientos(1));
        Thread persona2 = new Thread(() => congreso.RegistrarAsientos(2));

        // Iniciamos los hilos
        persona1.Start();
        persona2.Start();

        // Esperamos a que ambos hilos terminen
        persona1.Join();
        persona2.Join();

        Console.WriteLine("El registro de congresistas ha finalizado.");
    }
}




