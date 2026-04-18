using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[4, 4];

            int filaMasPositivos = 0;
            int maxPositivos = -1;

            int filaMayorPromedio = 0;
            double maxPromedio = -1;

            // Ingresar valores
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Ingrese 4 números para la fila {i + 1}:");
                for (int j = 0; j < 4; j++)
                {
                    Console.Write($"Elemento [{i},{j}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Procesamiento de filas
            for (int i = 0; i < 4; i++)
            {
                int suma = 0;
                int positivos = 0;

                for (int j = 0; j < 4; j++)
                {
                    int valor = matriz[i, j];
                    suma += valor;
                    if (valor > 0)
                        positivos++;
                }

                double promedio = suma / 4.0;

                if (positivos > maxPositivos)
                {
                    maxPositivos = positivos;
                    filaMasPositivos = i;
                }

                if (promedio > maxPromedio)
                {
                    maxPromedio = promedio;
                    filaMayorPromedio = i;
                }
            }

            // Resultados
            Console.WriteLine($"\nLa fila con más positivos es la fila {filaMasPositivos + 1}");
            Console.WriteLine($"La fila con mayor promedio es la fila {filaMayorPromedio + 1}");
        }
    }
}