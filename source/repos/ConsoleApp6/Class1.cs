namespace _9_tarea
{
    public class Series
    {
        public static void MostrarSeriePares(int cantidad)
        {
            Console.WriteLine("\nSerie de Números Pares:");
            int suma = 0;
            for (int i = 1, contador = 0; contador < cantidad; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                    suma += i;
                    contador++;
                }
            }
            Console.WriteLine("\nSumatoria: {suma}");
        }

        public static void MostrarSerieImpares(int cantidad)
        {
            Console.WriteLine("\nSerie de Números Impares:");
            int suma = 0;
            for (int i = 1, contador = 0; contador < cantidad; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + " ");
                    suma += i;
                    contador++;
                }
            }
            Console.WriteLine("\nSumatoria: {suma}");
        }

        public static void MostrarSerieMultiplos(int numero, int cantidad)
        {
            Console.WriteLine("\nSerie de Múltiplos de {numero}:");
            int suma = 0;
            for (int i = 1; i <= cantidad; i++)
            {
                int multiplo = numero * i;
                Console.Write(multiplo + " ");
                suma += multiplo;
            }
            Console.WriteLine("\nSumatoria: {suma}");
        }
    }