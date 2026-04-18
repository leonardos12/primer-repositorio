using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
namespace BusquedaListaEnlazada
    
{
    
}

    class Nodo
    {
        public int dato;
        public Nodo siguiente;

        public Nodo(int dato)
        {
            this.dato = dato;
            this.siguiente = null;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Nodo n1 = new Nodo(5);
            Nodo n2 = new Nodo(10);
            Nodo n3 = new Nodo(15);

            n1.siguiente = n2;
            n2.siguiente = n3;

            Console.Write("Ingrese un número: ");
            int buscar = int.Parse(Console.ReadLine());

            Nodo actual = n1;
            bool encontrado = false;

            while (actual != null)
            {
                if (actual.dato == buscar)
                {
                    Console.WriteLine("Encontrado: " + buscar);
                    encontrado = true;
                    break;
                }

                actual = actual.siguiente;
            }

            if (!encontrado)
                Console.WriteLine("No encontrado");

            Console.ReadKey();
        }
    }
