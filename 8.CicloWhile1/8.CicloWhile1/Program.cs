using System;

namespace _8.CicloWhile1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Realizar un algoritmo que pida números enteros positivos y los sume, hasta que se ingrese un número entero negativo. Se debe mostrar por pantalla el total de la suma de los números ingresados.

            int numero;
            int sumaNumeros = 0;
            Console.WriteLine("Ingrese un número entero positivo");
            numero = int.Parse(Console.ReadLine());

            while (numero >= 0)
            {
                sumaNumeros += numero;

                Console.WriteLine("Ingrese nuevamente un número positivo, o uno negativo para terminar");
                numero = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"La suma total de los números ingresados es de: {sumaNumeros}");

        }
    }
}
