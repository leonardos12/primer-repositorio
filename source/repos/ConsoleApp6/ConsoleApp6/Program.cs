using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {

    }

namespace SeriesApp
    {
        public static class Series
        {
        }
        class Program
        {
            public static class Series
            {
                public static void MostrarSeriePares(int cantidad)
                {
                    // código...
                }

                public static void MostrarSerieImpares(int cantidad)
                {
                    // código...
                }

                public static void MostrarSerieMultiplos(int numero, int cantidad)
                {
                    // código...
                }
            }
            // Variables globales
            static int cantidadTerminos;
            static int numeroMultiplo;

            static void Main(string[] args)
            {
                int opcion;
                do
                {
                    Console.Clear();
                    Console.WriteLine("===== MENÚ PRINCIPAL =====");
                    Console.WriteLine("1. Mostrar Serie de Números Pares y su Sumatoria");
                    Console.WriteLine("2. Mostrar Serie de Números Impares y su Sumatoria");
                    Console.WriteLine("3. Mostrar Serie de Múltiplos de un Número y su Sumatoria");
                    Console.WriteLine("4. Salir");
                    Console.Write("Seleccione una opción (1-4): ");

                    if (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 4)
                    {
                        Console.WriteLine("Opción inválida. Presione una tecla para continuar...");
                        Console.ReadKey();
                        continue;
                    }

                    if (opcion == 4) break;

                    cantidadTerminos = SolicitarEntero("Ingrese la cantidad de términos (mayor a 0): ", 1);

                    switch (opcion)
                    {
                        case 1:
                            Series.MostrarSeriePares(cantidadTerminos);
                            break; 
                        case 2:
                            Series.MostrarSerieImpares(cantidadTerminos);
                            break;
                        case 3:
                            numeroMultiplo = SolicitarEntero("Ingrese el número del cual desea obtener los múltiplos: ", 1);
                            Series.MostrarSerieMultiplos(numeroMultiplo, cantidadTerminos);
                            break;
                    }

                    Console.WriteLine("\nPresione una tecla para volver al menú...");
                    Console.ReadKey();

                } while (true);
            }

            // Función para validar y solicitar un entero positivo
            static int SolicitarEntero(string mensaje, int minimo)
            {
                int valor;
                do
                {
                    Console.Write(mensaje);
                    string entrada = Console.ReadLine();

                    if (!int.TryParse(entrada, out valor) || valor < minimo)
                    {
                        Console.WriteLine($"Entrada inválida. Ingrese un número entero mayor o igual a {minimo}.");
                        continue;
                    }
                    break;

                } while (true);
                return valor;
            }
        }
    }




}
 
