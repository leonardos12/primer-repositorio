using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = new string[0];
            int[] cantidades = new int[0];
            double[] precios = new double[0];
            int capacidad = 0;
            int total = 0;

            while (true)
            {
                Console.WriteLine("\n--- MENÚ ---");
                Console.WriteLine("1. Definir capacidad");
                Console.WriteLine("2. Agregar producto");
                Console.WriteLine("3. Buscar producto");
                Console.WriteLine("4. Mostrar inventario");
                Console.WriteLine("5. Salir");
                Console.Write("Opción: ");
                string opcion = Console.ReadLine();

                if (opcion == "1")
                {
                    Console.Write("Nueva capacidad: ");
                    int nuevaCap = int.Parse(Console.ReadLine());
                    if (nuevaCap > capacidad)
                    {
                        Array.Resize(ref nombres, nuevaCap);
                        Array.Resize(ref cantidades, nuevaCap);
                        Array.Resize(ref precios, nuevaCap);
                        capacidad = nuevaCap;
                        Console.WriteLine("Capacidad actualizada.");
                    }
                    else
                    {
                        Console.WriteLine("Debe ser mayor que la capacidad actual.");
                    }
                }
                else if (opcion == "2")
                {
                    if (total >= capacidad)
                    {
                        Console.WriteLine("Inventario lleno.");
                        continue;
                    }

                    Console.Write("Nombre del producto: ");
                    string nombre = Console.ReadLine();
                    bool existe = false;
                    for (int i = 0; i < total; i++)
                    {
                        if (nombres[i] == nombre)
                        {
                            existe = true;
                            break;
                        }
                    }
                    if (existe)
                    {
                        Console.WriteLine("El producto ya existe.");
                        continue;
                    }

                    Console.Write("Cantidad: ");
                    int cantidad = int.Parse(Console.ReadLine());

                    Console.Write("Precio: ");
                    double precio = double.Parse(Console.ReadLine());

                    nombres[total] = nombre;
                    cantidades[total] = cantidad;
                    precios[total] = precio;
                    total++;

                    Console.WriteLine("Producto agregado.");
                }
                else if (opcion == "3")
                {
                    Console.Write("Nombre a buscar: ");
                    string buscar = Console.ReadLine();
                    bool encontrado = false;
                    for (int i = 0; i < total; i++)
                    {
                        if (nombres[i] == buscar)
                        {
                            Console.WriteLine($"Nombre: {nombres[i]}, Cantidad: {cantidades[i]}, Precio: {precios[i]:0.00}");
                            encontrado = true;
                            break;
                        }
                    }
                    if (!encontrado)
                        Console.WriteLine("Producto no encontrado.");
                }
                else if (opcion == "4")
                {
                    Console.WriteLine($"\nCapacidad total: {capacidad}");
                    Console.WriteLine($"Productos registrados: {total}");
                    for (int i = 0; i < total; i++)
                    {
                        Console.WriteLine($"{i + 1}. {nombres[i]} - {cantidades[i]} unidades - S/ {precios[i]:0.00}");
                    }
                }
                else if (opcion == "5")
                {
                    Console.WriteLine("Saliendo...");
                    break;
                }
                else
                {
                    Console.WriteLine("Opción inválida.");
                }
            }
        }
    }
}
    