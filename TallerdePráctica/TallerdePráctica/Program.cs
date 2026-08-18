using System;
using System.Diagnostics;


namespace TallerdePráctica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Crear un algoritmo que permita leer tres valores y almacenarlos en las variables numero1,
            numero2, numero3 respectivamente.El algoritmo debe comprobar si los números son
            diferentes, si es así, imprimir cual es el número mayor, además ordenar y mostrar en
            pantalla los números de menor a mayor.
            Si hay números iguales, el algoritmo debe mostrar un mensaje indicando que se deben
            ingresar números diferentes. */

            float num1 = 0;
            float num2 = 0;
            float num3 = 0;
            Console.WriteLine("Ingrese el valor del número 1");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del número 2");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del número 3");
            num3 = int.Parse(Console.ReadLine());

            if (num1 == num2 || num1 == num3 || num2 == num3)
            {
                Console.WriteLine("Se deben ingresar números diferentes.");
            }
            else if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine($"El {num1} es el número mayor");
                if (num2 > num3)
                {
                    Console.WriteLine($"El orden es: {num1}, {num2}, {num3}");
                }
                else if (num3 > num2)
                {
                    Console.WriteLine($"El orden es: {num1}, {num3}, {num2}");
                }
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine($"El {num2} es el número mayor");
                if (num1 > num3)
                {
                    Console.WriteLine($"El orden es: {num2}, {num1}, {num3}");
                }
                else if (num3 > num1)
                {
                    Console.WriteLine($"El orden es: {num2}, {num3}, {num1}");
                }
            }
            else if (num3 > num1 && num3 > num2)
            {
                Console.WriteLine($"El {num3} es el número mayor");
                if (num2 > num1)
                {
                    Console.WriteLine($"El orden es: {num3}, {num2}, {num1}");
                }
                else if (num1 > num2)
                {
                    Console.WriteLine($"El orden es: {num3}, {num1}, {num2}");
                }
            }    
        }
    }
}
