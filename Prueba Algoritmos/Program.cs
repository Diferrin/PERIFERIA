using System;
using System.Collections.Generic;

namespace Prueba_Algoritmos
{
    class Program
    {
        public static string Eleccion { get; set; }
        static void Main(string[] args)
        {
            Menu();

            while (Eleccion != "4")
            {
                switch (Eleccion)
                {
                    case "1":
                        Bingo();
                        break;
                    case "2":
                        Primos();
                        break;
                    case "3":
                        CadenaInversa();
                        break;
                    default:
                        Console.WriteLine("Debe elegir una de las opciones dadas");
                        Eleccion = Console.ReadLine();
                        break;
                }
            }
        }

        public static void Bingo()
        {
            Console.Clear();
            Console.WriteLine("Bingo - Algoritmo A");
            var limite = 100;
            for (int i = 1; i <= limite; i++)
            {
                if (i % 3 == 0)
                {
                    if (i % 5 == 0)
                    {
                        Console.WriteLine("Bingo!");
                        continue;
                    }
                    Console.WriteLine("Bin");
                    continue;
                }
                if (i % 5 == 0)
                {
                    Console.WriteLine("Go");
                    continue;
                }
                Console.WriteLine(i);
            }
            Console.WriteLine("\nOprima enter para volver al menú");
            Console.ReadKey();
            Menu();

        }

        public static void Primos()
        {
            Console.Clear();
            Console.WriteLine("Primeros 50 primos - Algoritmo B");
            var limitePrimos = 50;
            List<int> listaPrimos = new List<int>();

            for (int numEvaluar = 2; numEvaluar < limitePrimos; numEvaluar++)
            {
                bool rompe = false;
                for (int i = 2; i < numEvaluar; i++)
                {
                    if (numEvaluar % i == 0)
                    {
                        rompe = true;
                        break;
                    }
                }

                if (!rompe)
                {
                    listaPrimos.Add(numEvaluar);
                }
            }

            foreach (var item in listaPrimos)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nOprima enter para volver al menú");
            Console.ReadKey();
            Menu();

        }

        public static void CadenaInversa()
        {
            Console.Clear();
            Console.WriteLine("Orden inverso - Algoritmo C");
            Console.WriteLine("Escriba la cadena de texto y luego oprima Enter");
            var cadenaDada = Console.ReadLine();
            var listaPalabras = cadenaDada.Split(' ');
            List<string> listaInversa = new List<string>();

            for (int i = listaPalabras.Length - 1; i >= 0; i--)
            {
                listaInversa.Add(listaPalabras[i]);
            }
            Console.WriteLine(string.Join(" ", listaInversa));
            Console.WriteLine("\nOprima enter para volver al menú");
            Console.ReadKey();

            Menu();
        }

        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("PRUEBA DIEGO FERRIN SKANDIA - PERIFERIA");
            Console.WriteLine("========================================");
            Console.Write("\r\n Eliga una opción: \n\n");
            Console.WriteLine("1. Bingo - Algoritmo A");
            Console.WriteLine("2. Primeros 50 primos - Algoritmo B");
            Console.WriteLine("3. Orden inverso - Algoritmo C");
            Console.WriteLine("4. Salir");
            Eleccion = Console.ReadLine();
        }
    }
}
