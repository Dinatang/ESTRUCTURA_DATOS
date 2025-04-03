using System;
using System.Collections.Generic;

public class Grafo  // Hacemos la clase 'Grafo' pública para que sea accesible fuera del ensamblado
{
    private Dictionary<int, List<int>> adjList;

    public Grafo()
    {
        adjList = new Dictionary<int, List<int>>();
    }

    // Añadir una arista entre dos nodos
    public void AñadirArista(int origen, int destino)
    {
        if (!adjList.ContainsKey(origen))
            adjList[origen] = new List<int>();
        if (!adjList.ContainsKey(destino))
            adjList[destino] = new List<int>();

        adjList[origen].Add(destino);
        adjList[destino].Add(origen);
    }

    // Obtener los vecinos de un nodo
    public List<int> ObtenerVecinos(int nodo)
    {
        return adjList.ContainsKey(nodo) ? adjList[nodo] : new List<int>();
    }

    // Obtener todos los nodos
    public List<int> ObtenerNodos()
    {
        List<int> nodos = new List<int>();
        foreach (var nodo in adjList.Keys)
        {
            nodos.Add(nodo);
        }
        return nodos;
    }

    // Número de nodos en el grafo
    public int ObtenerCantidadNodos()
    {
        return adjList.Count;
    }
}

public class Centralidad
{
    // Centralidad de grado
    public static Dictionary<int, int> CalcularCentralidadDeGrado(Grafo grafo)
    {
        Dictionary<int, int> centralidadDeGrado = new Dictionary<int, int>();
        List<int> nodos = grafo.ObtenerNodos();

        foreach (var nodo in nodos)
        {
            // La centralidad de grado es simplemente el número de vecinos de un nodo
            centralidadDeGrado[nodo] = grafo.ObtenerVecinos(nodo).Count;
        }

        return centralidadDeGrado;
    }

    // Centralidad de cercanía
    public static Dictionary<int, double> CalcularCentralidadDeCercania(Grafo grafo)
    {
        Dictionary<int, double> centralidadDeCercania = new Dictionary<int, double>();
        List<int> nodos = grafo.ObtenerNodos();

        foreach (var nodo in nodos)
        {
            double sumaDeDistancias = 0;
            Dictionary<int, int> distancias = ObtenerDistanciasBFS(grafo, nodo);

            foreach (var distancia in distancias.Values)
            {
                sumaDeDistancias += distancia;
            }

            if (sumaDeDistancias > 0)
            {
                centralidadDeCercania[nodo] = 1.0 / sumaDeDistancias;
            }
            else
            {
                centralidadDeCercania[nodo] = 0;
            }
        }

        return centralidadDeCercania;
    }

    // Obtener distancias utilizando BFS
    private static Dictionary<int, int> ObtenerDistanciasBFS(Grafo grafo, int nodoInicial)
    {
        Dictionary<int, int> distancias = new Dictionary<int, int>();
        Queue<int> cola = new Queue<int>();
        HashSet<int> visitados = new HashSet<int>();

        distancias[nodoInicial] = 0;
        cola.Enqueue(nodoInicial);
        visitados.Add(nodoInicial);

        while (cola.Count > 0)
        {
            int nodo = cola.Dequeue();
            int distanciaActual = distancias[nodo];

            foreach (var vecino in grafo.ObtenerVecinos(nodo))
            {
                if (!visitados.Contains(vecino))
                {
                    visitados.Add(vecino);
                    cola.Enqueue(vecino);
                    distancias[vecino] = distanciaActual + 1;
                }
            }
        }

        // Si algún nodo no ha sido alcanzado, asignamos una distancia infinita (o un valor muy alto)
        foreach (var nodo in grafo.ObtenerNodos())
        {
            if (!distancias.ContainsKey(nodo))
            {
                distancias[nodo] = int.MaxValue;
            }
        }

        return distancias;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Crear el grafo
        Grafo grafo = new Grafo();
        grafo.AñadirArista(0, 1);
        grafo.AñadirArista(1, 2);
        grafo.AñadirArista(2, 3);
        grafo.AñadirArista(3, 0);
        grafo.AñadirArista(1, 3);

        // Calcular Centralidad de Grado
        var centralidadDeGrado = Centralidad.CalcularCentralidadDeGrado(grafo);
        Console.WriteLine("Centralidad de Grado:");
        foreach (var item in centralidadDeGrado)
        {
            Console.WriteLine($"Nodo {item.Key}: {item.Value}");
        }

        // Calcular Centralidad de Cercanía
        var centralidadDeCercania = Centralidad.CalcularCentralidadDeCercania(grafo);
        Console.WriteLine("Centralidad de Cercanía:");
        foreach (var item in centralidadDeCercania)
        {
            Console.WriteLine($"Nodo {item.Key}: {item.Value}");
        }

        // Pausa para que la consola no se cierre inmediatamente
        Console.ReadLine();
    }
}
