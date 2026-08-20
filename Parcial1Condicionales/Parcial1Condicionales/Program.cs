using System;
namespace Parcial1Condicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Nombre;
            Console.WriteLine("Ingrese su nombre");
            Console.ReadLine();
            int Ttrabajado = 0;
            Console.WriteLine("Ingrese sus años trabajando en la empresa");
            float Cactual = 0;
            Console.WriteLine("Ingrese su calificación de este año (0.0, 0.4, 0.6, 1.0)");
            float Cpasada = 0;
            Console.WriteLine("Ingrese su calificación del año pasado (0.0, 0.4, 0.6, 1.0)");

            if (Cactual != 0.0 || Cactual != 0.4 || Cactual != 0.6 || Cactual != 1.0)
            {
                Console.WriteLine("Los valores son inválidos, el sistema terminará.");
                if (Cactual != 0.0 || Cactual != 0.4 || Cactual != 0.6 || Cactual != 1.0)
                {
                    Environment.Exit(0);
                }
            }
            if (Cpasada != 0.0 || Cpasada != 0.4 || Cpasada != 0.6 || Cpasada != 1.0)
            {
                Console.WriteLine("Los valores son inválidos, el sistema terminará.");
                if (Cpasada != 0.0 || Cpasada != 0.4 || Cpasada != 0.6 || Cpasada != 1.0)
                {
                    Environment.Exit(0);
                }
                else if (Cactual = 0.0 || Cactual = 0.4 || Cactual = 0.6 || Cactual = 1.0);
                {
                    float Promedio = ((Cpasada + Cactual / 2));
                }
                {
                    (Cpasada == 0.0 || Cpasada == 0.4 || Cpasada == 0.6 || Cpasada == 1.0);
                    {
                        float Promedio = ((Cpasada + Cactual / 2));
                    }
                }
                if (Ttrabajado <= 5)
                {
                    float Paumento = 5;
                }
                else if (Ttrabajado > 5)
                {
                    float Paumento = 30;
                }
                decimal SBase = 2500000m;

                float VAumento = SBase * (Paumento / 100);

                Console.WriteLine($"Señor, {Nombre}.");
                Console.WriteLine($"Su promedio ha sido de {Promedio}.");
                Console.WriteLine($"Por lo tanto su aumento es del {Paumento} por ciento.");
                Console.WriteLine($"Y su reflejo en pesos es de {VAumento}.");
            }
        }
    }
}