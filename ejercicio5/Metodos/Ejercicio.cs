using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Ejercicio5.Metodos
{
    internal class Ejercicio
    {
        private static void Main(string[] args)
        {

            int[] numeros = { 3, 7, 1, 9, 4, 2, 6, 5 };
            Console.Write("Introduce el número a buscar: ");
            int numeroBuscado = Convert.ToInt32(Console.ReadLine());

            int indice = -1;
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == numeroBuscado)
                {
                    indice = i;
                    break;
                }
            }

            if (indice != -1)
            {
                Console.WriteLine($"El número {numeroBuscado} se encuentra en la posición {indice}.");
            }
            else
            {
                Console.WriteLine($"El número {numeroBuscado} no se encuentra en la lista.");
            }
        }

        static void Main2(string[] args)
        {
            string[] cadenas = { "Hola", "Mundo", "C#", "Programación", "Búsqueda" };
            Console.Write("Introduce la cadena a buscar: ");
            string cadenaBuscada = Console.ReadLine();

            int indice = -1;
            for (int i = 0; i < cadenas.Length; i++)
            {
                if (cadenas[i].Equals(cadenaBuscada))
                {
                    indice = i;
                    break;
                }
            }

            if (indice != -1)
            {
                Console.WriteLine($"La cadena '{cadenaBuscada}' se encuentra en la posición {indice}.");
            }
            else
            {
                Console.WriteLine($"La cadena '{cadenaBuscada}' no está presente en la lista.");
            }
        }

        static void Main3(string[] args)
        {
           
            int[] numeros = { 1, 3, 5, 2, 8, 4, 7, 10 };
            int indice = -1;

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] % 2 == 0)
                {
                    indice = i;
                    break;
                }
            }

            if (indice != -1)
            {
                Console.WriteLine($"El primer número par se encuentra en la posición {indice}.");
            }
            else
            {
                Console.WriteLine("No se encontraron números pares en la lista.");
            }
        }

        static void Main4(string[] args)
        {
           
            int[,] matriz = {
                { 1, 2, 3, 4 },
                { 5, 6, 7, 8 },
                { 9, 10, 11, 12 },
                { 13, 14, 15, 16 }
            };

            int filas = matriz.GetLength(0);
            int columnas = matriz.GetLength(1);

            Console.WriteLine("Posiciones de los números pares en la matriz:");

            for (int fila = 0; fila < filas; fila++)
            {
                for (int columna = 0; columna < columnas; columna++)
                {
                    if (matriz[fila, columna] % 2 == 0)
                    {
                        Console.WriteLine($"Fila: {fila}, Columna: {columna}");
                    }
                }
            }
        }

        static void Main5(string[] args)
        {
            
            int[] sortedNumeros = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29 };
            Console.Write("Ingrese el número a buscar: ");
            int numeroBuscado = Convert.ToInt32(Console.ReadLine());

            int inicio = 0;
            int fin = sortedNumeros.Length - 1;
            int posicion = -1;

            while (inicio <= fin)
            {
                int medio = (inicio + fin) / 2;

                if (sortedNumeros[medio] == numeroBuscado)
                {
                    posicion = medio;
                    break;
                }
                else if (sortedNumeros[medio] < numeroBuscado)
                {
                    inicio = medio + 1;
                }
                else
                {
                    fin = medio - 1;
                }
            }

            if (posicion != -1)
            {
                Console.WriteLine($"El número {numeroBuscado} se encuentra en la posición {posicion} del arreglo.");
            }
            else
            {
                Console.WriteLine($"El número {numeroBuscado} no está en el arreglo.");
            }
        }

        static void Main6(string[] args)
        {
            
            string[] palabras = { "apple", "banana", "cat", "dog", "elephant", "zebra" };

            Console.Write("Ingrese la palabra a buscar: ");
            string palabraBuscada = Console.ReadLine();

            int inicio = 0;
            int fin = palabras.Length - 1;
            int posicion = -1;

            while (inicio <= fin)
            {
                int medio = (inicio + fin) / 2;

                int comparacion = string.Compare(palabraBuscada, palabras[medio], StringComparison.Ordinal);

                if (comparacion == 0)
                {
                    posicion = medio;
                    break;
                }
                else if (comparacion < 0)
                {
                    fin = medio - 1;
                }
                else
                {
                    inicio = medio + 1;
                }
            }

            if (posicion != -1)
            {
                Console.WriteLine($"La palabra '{palabraBuscada}' se encuentra en la posición {posicion} del arreglo.");
            }
            else
            {
                Console.WriteLine($"La palabra '{palabraBuscada}' no está en el arreglo.");
            }
        }

        static void Main7(string[] args)
        {
           
            int[] numeros = { 1, 3, 5, 6, 8, 10, 12, 14, 15 };

            int inicio = 0;
            int fin = numeros.Length - 1;
            int posicion = -1;

            while (inicio <= fin)
            {
                int medio = (inicio + fin) / 2;

                if (numeros[medio] % 2 == 0)
                {
                    posicion = medio;
                    fin = medio - 1; 
                }
                else
                {
                    inicio = medio + 1;
                }
            }

            if (posicion != -1)
            {
                Console.WriteLine($"El primer número par se encuentra en la posición {posicion} del arreglo.");
            }
            else
            {
                Console.WriteLine("No se encontraron números pares en el arreglo.");
            }
        }
    }
}


