using System;
using System.Security.Cryptography;
namespace _17.ArreglosBidimensionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*            //Arreglos bidimensionales - Matrices
                        int[,] numeros = new int[2, 3];

                        //numeros[2, 1] = 23 = No se puede almacenar porque el índice de la fila no existe.
                        //numeros[1,3] = 54 = No se puede almacenar porque el índice de la columna no existe.
                        numeros[0, 0] = 25;
                        numeros[0, 1] = 41;
                        numeros[0, 2] = 104;
                        numeros[1, 0] = 47;
                        numeros[1, 1] = 56;
                        numeros[1, 2] = 6;

                        Console.WriteLine($"El valor almacenado en números [1,1] es: {numeros[1, 1]}.");
                        char[,] simbolos = new char[3, 4];

                        //Recorrer para llenar.
                        for(int i = 0; i < 3; i++) //Recorre las filas.
                        {
                            for (int j = 0; j < 2; j++) //Recorre las columnas.
                            {
                                Console.WriteLine($"Ingrese el caracter para símbolos[{i},{j}]");
                                simbolos[i, j] = char.Parse(Console.ReadLine());
                            }
                        }

                        Console.Clear();
                        //Recorrer para recuperar //GetLength(0) devuelve el número de las filas.
                        for (int i = 0;i < simbolos.GetLength(0); i++)
                        {
                            for (int j = 0;j < simbolos.GetLength(1); j++) //GetLength(1) devuelve el número de columnas.
                            {
                                Console.Write($"{simbolos[i,j]} |");
                            }
                            Console.WriteLine();
                        }

                        //Otra forma de declarar e inicializar matrices:
                        string[,] nombres =
                        {
                            {"Ana", "Carlos", "Alex", "Mauricio"},
                            {"Juan", "Marta", "María", "Álvaro"},
                            {"Ramiro", "Guillermo", "Cristian", "Blanca"}
                        };*/

            // 1. Crear una matríz[10, 20] y en cada posición de la matriz poner el número 100. Por último mostrar la matríz en la consola.

            /* int[,] mCien = new int[10, 20];
            
            for (int i = 0; i < mCien.GetLength(0); i++)
            {
                for (int j = 0; j < mCien.GetLength(1); j++)
                {
                    mCien[i, j] = 100;
                    Console.Write($"{mCien[i, j]}, ");
                }
            }
            */

            /* 2. Escribe un programa que realice la suma de dos matrices de dimensiones 2x3 
            Requisitos del programa:
            Solicita al usuario que ingrese los elementos de la primera matriz de 2 filas y 3 columnas.
            Solicita al usuario que ingrese los elementos de la segunda matriz de las mismas dimensiones (2x3).
            Calcula la matriz suma, resultado de sumar cada elemento correspondiente de las dos matrices.
            Muestra la matriz resultante de la suma en formato de matriz (2 filas, 3 columnas).*/

            int[,] priMatriz = new int[2, 3];
            int[,] segMatriz = new int[2, 3];
            int[,] sumMatriz = new int[2, 3];

            for (int i = 0; i < priMatriz.GetLength(0); i++)
            {
                for (int j = 0; j < priMatriz.GetLength(1); j++)
                {
                    Console.WriteLine($"Ingrese los números de la primera matriz [{i}, {j}]");
                    priMatriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < segMatriz.GetLength(0); i++)
            {
                for(int j = 0; j < segMatriz.GetLength(1); j++)
                {
                    Console.WriteLine($"Ingrese los números de la segunda matriz [{i}, {j}]");
                    segMatriz[i, j] = int.Parse(Console.ReadLine());
                    sumMatriz[i, j] = priMatriz[i,j] + segMatriz[i, j];
                }
            }
            for (int i = 0; i < segMatriz.GetLength(0); i++)
            {
                for (int j = 0; j < segMatriz.GetLength(1); j++)
                {
                    Console.Write($"{sumMatriz[i,j]} |");
                }
                Console.WriteLine(" ");
            }
        }
    }
}
