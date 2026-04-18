using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System;

namespace ConsoleApp8
{
    public static class Class1
    {
        // Verifica si un número es de Armstrong (solo considera números de 3 dígitos o más)
        private static bool EsArmstrong(int numero)
        {
            int suma = 0, temp = numero;
            int numDigitos = numero.ToString().Length;

            while (temp > 0)
            {
                int digito = temp % 10;
                suma += (int)Math.Pow(digito, numDigitos);
                temp /= 10;
            }

            return suma == numero && numero >= 100; // Asegura que sea de al menos 3 dígitos
        }

        // Mostrar la serie de Armstrong
        public static void MostrarSerieArmstrong(int cantidad)
        {
            int encontrados = 0, numero = 100;
            while (encontrados < cantidad)
            {
                if (EsArmstrong(numero))
                {
                    Console.Write(numero + " ");
                    encontrados++;
                }
                numero++;
            }
            Console.WriteLine();
        }

        // Sumatoria de la serie de Armstrong
        public static int SumatoriaArmstrong(int cantidad)
        {
            int suma = 0, encontrados = 0, numero = 100;
            while (encontrados < cantidad)
            {
                if (EsArmstrong(numero))
                {
                    suma += numero;
                    encontrados++;
                }
                numero++;
            }
            return suma;
        }

        // Verifica si un número es perfecto
        private static bool EsPerfecto(int numero)
        {
            int suma = 0;
            for (int i = 1; i <= numero / 2; i++)
            {
                if (numero % i == 0)
                    suma += i;
            }
            return suma == numero;
        }

        // Mostrar la serie de números perfectos
        public static void MostrarSeriePerfectos(int cantidad)
        {
            int encontrados = 0, numero = 2;
            while (encontrados < cantidad)
            {
                if (EsPerfecto(numero))
                {
                    Console.Write(numero + " ");
                    encontrados++;
                }
                numero++;
            }
            Console.WriteLine();
        }

        // Sumatoria de la serie de números perfectos
        public static int SumatoriaPerfectos(int cantidad)
        {
            int suma = 0, encontrados = 0, numero = 2;
            while (encontrados < cantidad)
            {
                if (EsPerfecto(numero))
                {
                    suma += numero;
                    encontrados++;
                }
                numero++;
            }
            return suma;
        }
    }
}