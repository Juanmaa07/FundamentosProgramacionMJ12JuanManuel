using System;
using System.Diagnostics;

namespace _11.CicloDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ciclo Do While
            /*            int contador = 1;
                        int acumulador = 0;

                        do
                        {
                            acumulador += contador;
                            contador++;
                        } while (contador <= 5);

                        Console.WriteLine($"La suma de los cinco primeros números enteros es: {acumulador}.");*/

            //Desarrolle un algoritmo que solicite un número y genere su correspondiente tabla de multiplicar desde el 1 hasta el 10, y así sucesivamente
            //hasta que el usuario ya no desee continuar generando tablas de multiplicar.

            /*Console.WriteLine("Por favor, ingrese un número para realizar su tabla de multiplicar correspondiente.");
            numero = int.Parse(Console.ReadLine());*/

            /*do
            {
                Console.WriteLine($"{numero}X{contador} es igual a {numero*contador}.");
                contador++;
            }while (contador <= 10);*/

            int contador = 1;
            int numero;
            char respuesta = ' ';

            do
            {
                Console.WriteLine("Por favor, ingrese un número para realizar su tabla de multiplicar correspondiente.");
                numero = int.Parse(Console.ReadLine());

                do
                {
                    Console.WriteLine($"{numero}X{contador} es igual a {numero * contador}.");
                    contador++;
                } while (contador <= 10);
                contador = 1;

                Console.WriteLine("¿Desea continuar? s/sí, n/no.");
                respuesta = char.Parse(Console.ReadLine());
            } while (respuesta == 's');

            //Crear un algoritmo que permita calcular y mostrar por pantalla los números primos hata el número 100.
        }
    }
}
