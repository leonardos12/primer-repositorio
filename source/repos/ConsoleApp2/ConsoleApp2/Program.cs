using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("----------------------------------");
            Console.WriteLine("               MENÚ              ");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("1. Sumatoria");
            Console.WriteLine("2. Factorial");
            Console.WriteLine("3. Verificar si es número primo");
            Console.WriteLine("4. Salir");
            Console.Write("Elige una opción: ");

            int opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion == 1)
            {
                Console.Write("Ingresa un número entero positivo: ");
                int n = Convert.ToInt32(Console.ReadLine());

                if (n > 0)
                {
                    int suma = Sumatoria(n);
                    Console.WriteLine("La sumatoria de 1 a " + n + " es: " + suma);
                }
                else
                {
                    Console.WriteLine("Número no válido.");
                }
            }

            else if (opcion == 2)
            {
                Console.Write("Ingresa un número entero positivo (o 0): ");
                int n = Convert.ToInt32(Console.ReadLine());

                if (n >= 0)
                {
                    long resultado = Factorial(n);
                    Console.WriteLine("El factorial de " + n + " es: " + resultado);
                }
                else
                {
                    Console.WriteLine("Número no válido.");
                }
            }

            else if (opcion == 3)
            {
                Console.Write("Ingresa un número entero mayor que 1: ");
                int n = Convert.ToInt32(Console.ReadLine());

                if (n > 1)
                {
                    bool esPrimo = EsPrimo(n, 2);
                    if (esPrimo)
                        Console.WriteLine(n + " es un número primo.");
                    else
                        Console.WriteLine(n + " no es un número primo.");
                }
                else
                {
                    Console.WriteLine("Número no válido.");
                }
            }

            else if (opcion == 4)
            {
                Console.WriteLine("Saliendo del programa...");
            }

            else
            {
                Console.WriteLine("Opción no válida.");
            }
        }

        // sumatoria
        static int Sumatoria(int n)
        {
            if (n == 1) return 1;
            return n + Sumatoria(n - 1);
        }

        // factorial
        static long Factorial(int n)
        {
            if (n == 0) return 1;
            return n * Factorial(n - 1);
        }

        // verificacion si es primo
        static bool EsPrimo(int n, int divisor)
        {
            if (divisor == n) return true;
            if (n % divisor == 0) return false;
            return EsPrimo(n, divisor + 1);
        }
    }

}
