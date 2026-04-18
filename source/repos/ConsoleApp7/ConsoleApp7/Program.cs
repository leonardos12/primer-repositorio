using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{

    

        

namespace ConsoleApp7
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                int N;
                int edad, mayorEdad = 0;
                int primaria = 0, secundaria = 0, superior = 0;
                int superiorNo35 = 0;
                string grado;

                Console.Write("Ingrese el número de personas encuestadas: ");
                N = int.Parse(Console.ReadLine());

                for (int i = 0; i < N; i++)
                {
                    Console.WriteLine($"\nPersona {i + 1}");

                    Console.Write("Ingrese el grado de instrucción (Primaria, Secundaria, Superior): ");
                    grado = Console.ReadLine();

                    Console.Write("Ingrese la edad: ");
                    edad = int.Parse(Console.ReadLine());

                    // a) Encontrar la mayor edad
                    if (edad > mayorEdad)
                    {
                        mayorEdad = edad;
                    }

                    // b) Contar personas según su nivel educativo
                    if (grado.Equals("Primaria", StringComparison.OrdinalIgnoreCase))
                    {
                        primaria++;
                    }
                    else if (grado.Equals("Secundaria", StringComparison.OrdinalIgnoreCase))
                    {
                        secundaria++;
                    }
                    else if (grado.Equals("Superior", StringComparison.OrdinalIgnoreCase))
                    {
                        superior++;

                        // c) Superior pero NO tienen 35 años
                        if (edad != 35)
                        {
                            superiorNo35++;
                        }
                    }
                }

                // Resultados
                Console.WriteLine("\n--- RESULTADOS ---");
                Console.WriteLine("La mayor edad es: " + mayorEdad);
                Console.WriteLine("Personas con Primaria: " + primaria);
                Console.WriteLine("Personas con Secundaria: " + secundaria);
                Console.WriteLine("Personas con Superior: " + superior);
                Console.WriteLine("Personas con Superior y distinta edad de 35: " + superiorNo35);

                Console.WriteLine("\nPresione cualquier tecla para salir...");
                Console.ReadKey();
            }
        }
    }
}
