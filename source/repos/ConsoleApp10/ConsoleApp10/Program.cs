using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static string[] nombres;
            static int[] cantidades;
            static double[] precios;
            static int capacidad = 0;
            static int totalProductos = 0;

            static void Main()
            {
                int opcion;
                do
                {
                    Console.WriteLine("\n===== MENÚ DEL INVENTARIO =====");
                    Console.WriteLine("1. Definir capacidad del inventario");
                    Console.WriteLine("2. Agregar producto");
                    Console.WriteLine("3. Buscar producto");
                    Console.WriteLine("4. Actualizar producto");
                    Console.WriteLine("5. Eliminar producto");
                    Console.WriteLine("6. Mostrar inventario");
                    Console.WriteLine("7. Salir");
                    Console.Write("Seleccione una opción: ");

                    if (!int.TryParse(Console.ReadLine(), out opcion))
                    {
                        Console.WriteLine("Opción inválida. Ingrese un número del 1 al 7.");
                        continue;
                    }

                    switch (opcion)
                    {
                        case 1: DefinirCapacidad(); break;
                        case 2: AgregarProducto(); break;
                        case 3: BuscarProducto(); break;
                        case 4: ActualizarProducto(); break;
                        case 5: EliminarProducto(); break;
                        case 6: MostrarInventario(); break;
                        case 7: Console.WriteLine("Saliendo del programa..."); break;
                        default: Console.WriteLine("Opción inválida."); break;
                    }

                } while (opcion != 7);
            }

            static void DefinirCapacidad()
            {
                Console.Write("Ingrese la nueva capacidad del inventario: ");
                if (int.TryParse(Console.ReadLine(), out int nuevaCapacidad) && nuevaCapacidad > capacidad)
                {
                    string[] nuevosNombres = new string[nuevaCapacidad];
                    int[] nuevasCantidades = new int[nuevaCapacidad];
                    double[] nuevosPrecios = new double[nuevaCapacidad];

                    for (int i = 0; i < totalProductos; i++)
                    {
                        nuevosNombres[i] = nombres[i];
                        nuevasCantidades[i] = cantidades[i];
                        nuevosPrecios[i] = precios[i];
                    }

                    nombres = nuevosNombres;
                    cantidades = nuevasCantidades;
                    precios = nuevosPrecios;
                    capacidad = nuevaCapacidad;

                    Console.WriteLine("Capacidad actualizada a " + capacidad);
                }
                else
                {
                    Console.WriteLine("La nueva capacidad debe ser un número entero mayor que la actual.");
                }
            }

            static void AgregarProducto()
            {
                if (capacidad == 0)
                {
                    Console.WriteLine("Primero debe definir la capacidad del inventario (opción 1).");
                    return;
                }

                if (totalProductos >= capacidad)
                {
                    Console.WriteLine("Inventario lleno. No se puede agregar más productos.");
                    return;
                }

                Console.Write("Nombre del producto: ");
                string nombre = Console.ReadLine();

                if (BuscarIndice(nombre) != -1)
                {
                    Console.WriteLine("El producto ya existe.");
                    return;
                }

                Console.Write("Cantidad: ");
                if (!int.TryParse(Console.ReadLine(), out int cantidad) || cantidad < 0)
                {
                    Console.WriteLine("Cantidad inválida.");
                    return;
                }

                Console.Write("Precio unitario: ");
                if (!double.TryParse(Console.ReadLine(), out double precio) || precio < 0)
                {
                    Console.WriteLine("Precio inválido.");
                    return;
                }

                nombres[totalProductos] = nombre;
                cantidades[totalProductos] = cantidad;
                precios[totalProductos] = precio;
                totalProductos++;

                Console.WriteLine("Producto agregado correctamente.");
            }

            static void BuscarProducto()
            {
                if (totalProductos == 0)
                {
                    Console.WriteLine("Inventario vacío.");
                    return;
                }

                Console.Write("Ingrese el nombre del producto a buscar: ");
                string nombre = Console.ReadLine();

                int indice = BuscarIndice(nombre);

                if (indice == -1)
                {
                    Console.WriteLine("Producto no encontrado.");
                }
                else
                {
                    Console.WriteLine($"Producto: {nombres[indice]}, Cantidad: {cantidades[indice]}, Precio: {precios[indice]:0.00}");
                }
            }

            static void ActualizarProducto()
            {
                if (totalProductos == 0)
                {
                    Console.WriteLine("Inventario vacío.");
                    return;
                }

                Console.Write("Ingrese el nombre del producto a actualizar: ");
                string nombre = Console.ReadLine();

                int indice = BuscarIndice(nombre);

                if (indice == -1)
                {
                    Console.WriteLine("Producto no encontrado.");
                    return;
                }

                Console.Write("Nueva cantidad: ");
                if (!int.TryParse(Console.ReadLine(), out int nuevaCantidad) || nuevaCantidad < 0)
                {
                    Console.WriteLine("Cantidad inválida.");
                    return;
                }

                Console.Write("Nuevo precio: ");
                if (!double.TryParse(Console.ReadLine(), out double nuevoPrecio) || nuevoPrecio < 0)
                {
                    Console.WriteLine("Precio inválido.");
                    return;
                }

                cantidades[indice] = nuevaCantidad;
                precios[indice] = nuevoPrecio;
                Console.WriteLine("Producto actualizado.");
            }

            static void EliminarProducto()
            {
                if (totalProductos == 0)
                {
                    Console.WriteLine("Inventario vacío.");
                    return;
                }

                Console.Write("Ingrese el nombre del producto a eliminar: ");
                string nombre = Console.ReadLine();

                int indice = BuscarIndice(nombre);

                if (indice == -1)
                {
                    Console.WriteLine("Producto no encontrado.");
                    return;
                }

                for (int i = indice; i < totalProductos - 1; i++)
                {
                    nombres[i] = nombres[i + 1];
                    cantidades[i] = cantidades[i + 1];
                    precios[i] = precios[i + 1];
                }

                totalProductos--;
                Console.WriteLine("Producto eliminado.");
            }

            static void MostrarInventario()
            {
                Console.WriteLine("\n--- INVENTARIO ACTUAL ---");
                Console.WriteLine("Capacidad total: " + capacidad);
                Console.WriteLine("Productos registrados: " + totalProductos);

                if (totalProductos == 0)
                {
                    Console.WriteLine("No hay productos en el inventario.");
                    return;
                }

                for (int i = 0; i < totalProductos; i++)
                {
                    Console.WriteLine($"{i + 1}. {nombres[i]} - Cantidad: {cantidades[i]}, Precio: {precios[i]:0.00}");
                }
            }

            static int BuscarIndice(string nombre)
            {
                for (int i = 0; i < totalProductos; i++)
                {
                    if (nombres[i].Equals(nombre, StringComparison.OrdinalIgnoreCase))
                    {
                        return i;
                    }
                }
                return -1;
            }
        }
    }
    }
}
