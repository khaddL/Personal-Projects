using System;

class Program
{
    static void Main(string[] args)
    {
        // Entrada del valor objetivo
        Console.Write("Ingrese el valor objetivo: ");
        int valorObjetivo = int.Parse(Console.ReadLine());

        int []arreglo = GenerarArreglo();

        // Lógica para encontrar los índices
        Console.WriteLine("Combinaciones de índices que suman el valor objetivo:");
        bool seEncontraronCombinaciones = EncontrarCombinaciones(arreglo, valorObjetivo);

        // Si no se encontraron combinaciones
        if (!seEncontraronCombinaciones)
        {
            Console.WriteLine("No se encontraron combinaciones que sumen el valor objetivo.");
        }
    }

    static private int[] GenerarArreglo()
    {
        // Secuencia base
        int[] secuenciaBase = { 10, 15, 30, 50, 70, 80, 100, 150, 200 };
        int tamañoArreglo = 1000;

        // Arreglo de 1000 elementos
        int[] arreglo = new int[tamañoArreglo];

        // Llenar el arreglo
        for (int i = 0; i < tamañoArreglo; i++)
        {
            if(i < secuenciaBase.Length) { 
                arreglo[i] = secuenciaBase[i];
            }
            else
            {
                arreglo[i] = arreglo[i-1] + 50;
            }
        }

        Console.WriteLine("Elementos del arreglo:");
        for (int i = 0; i < 1000; i++)
        {
            Console.Write("("+i+")"+arreglo[i] + " ");
        }
        Console.WriteLine(" ");
        return arreglo;
    }

    static private bool EncontrarCombinaciones(int[] arreglo, int valorObjetivo)
    {
        bool seEncontraronCombinaciones = false;
        // Ciclos para buscar combinaciones
        for (int i = 0; i < arreglo.Length; i++)
        {
            for (int j = i + 1; j < arreglo.Length; j++)
            {
                for (int k = j + 1; k < arreglo.Length; k++)
                {
                    // Verificar si la suma de los elementos actuales coincide con el valor objetivo
                    if (arreglo[i] + arreglo[j] + arreglo[k] == valorObjetivo)
                    {
                        Console.WriteLine($"Índices: {i}, {j}, {k}");
                        seEncontraronCombinaciones = true;
                    }
                }
            }
        }
        return seEncontraronCombinaciones;
    }
}