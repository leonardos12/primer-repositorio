using System;
using System;
using System.Collections.Generic;

public class Class1
{
	public Class1()
        public static void MostrarSerieArmstrong(int cantidad) { ... }
    public static int SumaroriaArmstrong(int cantidad) { ... }

    public static void MostrarSeriePerfectos(int cantidad) { ... }
    public static int SumaroriaPerfectos(int cantidad) { ... }

    {
        public static void MostrarSerieArmstrong(int cantidad) { /*...*/ }

    public static void MostrarSeriePerfectos(int cantidad) { /*...*/ }

    public static int SumatoriaArmstrong(int cantidad) { return 0; }

    public static int SumatoriaPerfectos(int cantidad) { return 0; }
}

{
        // Método para mostrar la serie de números de Armstrong
        public static void MostrarSerieArmstrong(int cantidadTerminos)
    {
        int contador = 0;
        int numero = 1;
        Console.WriteLine("Serie de Números de Armstrong:");
        while (contador < cantidadTerminos)
        {
            if (EsNumeroArmstrong(numero))
            {
                Console.Write($"{numero} ");
                contador++;
            }
            numero++;
        }
        Console.WriteLine();
    }

    // Método para calcular la sumatoria de números de Armstrong
    public static int SumatoriaArmstrong(int cantidadTerminos)
    {
        int contador = 0;
        int numero = 1;
        int sumatoria = 0;
        while (contador < cantidadTerminos)
        {
            if (EsNumeroArmstrong(numero))
            {
                sumatoria += numero;
                contador++;
            }
            numero++;
        }
        return sumatoria;
    }

    // Método para mostrar la serie de números perfectos
    public static void MostrarSeriePerfectos(int cantidadTerminos)
    {
        int contador = 0;
        int numero = 1;
        Console.WriteLine("Serie de Números Perfectos:");
        while (contador < cantidadTerminos)
        {
            if (EsNumeroPerfecto(numero))
            {
                Console.Write($"{numero} ");
                contador++;
            }
            numero++;
        }
        Console.WriteLine();
    }

    // Método para calcular la sumatoria de números perfectos
    public static int SumatoriaPerfectos(int cantidadTerminos)
    {
        int contador = 0;
        int numero = 1;
        int sumatoria = 0;
        while (contador < cantidadTerminos)
        {
            if (EsNumeroPerfecto(numero))
            {
                sumatoria += numero;
                contador++;
            }
            numero++;
        }
        return sumatoria;
    }

    // Función auxiliar para verificar si un número es de Armstrong
    private static bool EsNumeroArmstrong(int numero)
    {
        int suma = 0, temp = numero, digitos = numero.ToString().Length;
        while (temp > 0)
        {
            int digito = temp % 10;
            suma += (int)Math.Pow(digito, digitos);
            temp /= 10;
        }
        return suma == numero;
    }

    // Función auxiliar para verificar si un número es perfecto
    private static bool EsNumeroPerfecto(int numero)
    {
        int suma = 0;
        for (int i = 1; i <= numero / 2; i++)
        {
            if (numero % i == 0)
            {
                suma += i;
            }
        }
        return suma == numero;
    }
}
}