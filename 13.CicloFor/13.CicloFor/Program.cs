using System;

namespace _13.CicloFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ciclo For
/*            int acumulador = 0;

            for (int contador = 1;contador<=5; contador++)
            {
                acumulador += contador;
            }
            Console.WriteLine($"La suma de los cinco primeros números enteros es: {acumulador}");*/

            int numero = 0;
            int acumulador = 1;
            Console.WriteLine("Ingrese un número para sacar su factorial.");
            numero = int.Parse(Console.ReadLine());
            for (int contador = 1; contador <= numero; contador++)
            {
                acumulador *= contador;
            }
            Console.WriteLine($"La factorial del número dado es {acumulador}");
        }
    }
}
