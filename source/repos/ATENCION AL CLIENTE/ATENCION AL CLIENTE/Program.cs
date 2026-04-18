using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATENCION_AL_CLIENTE
{
    internal class Program
    {
        class Cliente
        {
            public int Id;
            public string Nombre;
            public Cliente Siguiente;

            public Cliente(int id, string nombre)
            {
                Id = id;
                Nombre = nombre;
                Siguiente = null;
            }
        }

        class ListaClientes
        {
            private Cliente cabeza;
            private Cliente cola;

            public void Insertar(int id, string nombre)
            {
                Cliente nuevo = new Cliente(id, nombre);

                if (cabeza == null)
                {
                    cabeza = nuevo;
                    cola = nuevo;
                }
                else
                {
                    cola.Siguiente = nuevo;
                    cola = nuevo;
                }
            }

            public void Mostrar()
            {
                Cliente actual = cabeza;

                while (actual != null)
                {
                    Console.WriteLine("ID: " + actual.Id + " Nombre: " + actual.Nombre);
                    actual = actual.Siguiente;
                }
            }

            public void Eliminar(int id)
            {
                if (cabeza == null) return;

                if (cabeza.Id == id)
                {
                    cabeza = cabeza.Siguiente;
                    return;
                }

                Cliente actual = cabeza;

                while (actual.Siguiente != null && actual.Siguiente.Id != id)
                {
                    actual = actual.Siguiente;
                }

                if (actual.Siguiente != null)
                {
                    actual.Siguiente = actual.Siguiente.Siguiente;
                }
            }
        }
        static void Main(string[] args)
        {
            ListaClientes lista = new ListaClientes();

            lista.Insertar(1, "Juan");
            lista.Insertar(2, "Maria");
            lista.Insertar(3, "Carlos");

            Console.WriteLine("Clientes:");
            lista.Mostrar();

            Console.WriteLine("\nEliminando ID 2...\n");
            lista.Eliminar(2);

            lista.Mostrar();

            Console.ReadLine();
        }
    }
}
