using System;
namespace _14.ArreglosUnidimensionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*            //Arreglos Unidimensionales - Vectores
                        int[] numeros = new int[5];
                        numeros[0] = 10;
                        numeros[1] = 56;
                        numeros[2] = 22;
                        numeros[3] = 45;
                        numeros[4] = 102;
                        //Números [5] = 14; No se puede almacenar porque es una posición que no existe.
                        Console.WriteLine($"El número almacenado en la posición 3 con índice 2 es: {numeros[2]}.");
                        //Otras formas de declarar e inicializar vectores:
                        char[] simbolos = new char[] {'#', '&', 'ó', '#', '0', 'a',};
                        bool[] valresVerdad = {true , false, false, true, true, false, false};
                        //Recorrer para almacenar datos:
                        string[] nombres = new string[7];
                        for (int i = 0; i < 7; i++)
                        {
                            Console.WriteLine($"Ingrese el nombre para P{i + 1}: I{i}");
                            nombres[i] = Console.ReadLine();
                        }
                        Console.Clear();
                        //Recorrer para recuperar:
                        for (int i = 0; i < nombres.Length; i++)
                        {
                            Console.Write($"{nombres[i]}  |");
                        }*/

            //Crear un arreglo llamado "números" de 100 elementos y asignar el número 10 en cada una de las posiciones del arreglo.
            //Leer el contenido de cada elemento y escribirlo en pantalla.

            /*            int[] numeros = new int[100];
                        for (int i = 0; i < 100; i++)
                        {
                            numeros[i] = 10;
                            Console.WriteLine($"{numeros[i]}");
                        }*/

            //Algoritmo que permita solicitar 10 números, los cuales serán almacenados en un arreglo. Al final, debe visualizar el promedio de esos números.

            float[] num = new float[10];
            float acumulador = 0;
            float prom;
            for (int n = 0; n < 10; n++)
            {
                Console.WriteLine($"Ingrese el número {n + 1}");
                num[n] = float.Parse(Console.ReadLine());
                acumulador += num[n];
            }
            prom = acumulador / num.Length;
            Console.WriteLine($"El promedio de los números ingresados es de {prom}");
        }
    }
}
