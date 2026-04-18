using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            {
               
                const double IGV = 0.19;
                const double precioCaña = 3.25;
                const double precioRemolacha = 4.75;
                const double precioStevia = 6.85;

                int contadorCaña = 0, contadorRemolacha = 0, contadorStevia = 0;
                string continuar = "";

                do
                {
                    Console.WriteLine("Ingrese el RUC del cliente:");
                    string ruc = Console.ReadLine();

                    Console.WriteLine("Ingrese el nombre del cliente:");
                    string nombre = Console.ReadLine();

                    Console.WriteLine("Seleccione el tipo de azúcar:");
                    Console.WriteLine("1. Caña de azúcar");
                    Console.WriteLine("2. Remolacha");
                    Console.WriteLine("3. Stevia");
                    int opcion = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese la cantidad de kilos:");
                    double kilos = double.Parse(Console.ReadLine());

                    double precioPorKilo = 0;
                    string tipoAzucar = "";

                    switch (opcion)
                    {
                        case 1:
                            precioPorKilo = precioCaña;
                            tipoAzucar = "Caña de azúcar";
                            contadorCaña++;
                            break;
                        case 2:
                            precioPorKilo = precioRemolacha;
                            tipoAzucar = "Remolacha";
                            contadorRemolacha++;
                            break;
                        case 3:
                            precioPorKilo = precioStevia;
                            tipoAzucar = "Stevia";
                            contadorStevia++;
                            break;
                        default:
                            Console.WriteLine("Opción inválida.");
                            continue;
                    }

                    double pagoBruto = precioPorKilo * kilos;
                    double montoIGV = pagoBruto * IGV;
                    double pagoNeto = pagoBruto + montoIGV;

                    Console.WriteLine("\n--- Factura ---");
                    Console.WriteLine($"RUC: {ruc}");
                    Console.WriteLine($"Cliente: {nombre}");
                    Console.WriteLine($"Tipo de azúcar: {tipoAzucar}");
                    Console.WriteLine($"Cantidad de kilos: {kilos}");
                    Console.WriteLine($"Precio por kilo: S/. {precioPorKilo:F2}");
                    Console.WriteLine($"Pago bruto: S/. {pagoBruto:F2}");
                    Console.WriteLine($"Monto IGV (19%): S/. {montoIGV:F2}");
                    Console.WriteLine($"Pago neto: S/. {pagoNeto:F2}");
                    Console.WriteLine("-------------------\n");

                    Console.WriteLine("¿Desea registrar otra venta? (S/N):");
                    continuar = Console.ReadLine();

                } while (continuar.Equals("S", StringComparison.OrdinalIgnoreCase));

                Console.WriteLine("\n--- Resumen de ventas ---");
                Console.WriteLine($"Clientes que compraron caña de azúcar: {contadorCaña}");
                Console.WriteLine($"Clientes que compraron remolacha: {contadorRemolacha}");
                Console.WriteLine($"Clientes que compraron stevia: {contadorStevia}");
                Console.WriteLine("Gracias por usar el sistema.");
            }
        }


    }
    }

