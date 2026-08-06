using System;
namespace _4.CondicionalesSimpleDoble
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ESTRUCTURAS DE CONTROL CONDICIONALES
            //Simples
            //1. Crea un algoritmo que lea la edad de un usuario, si el usuario es mayor de 18 años, se debe mostrar el siguiente mensaje: "Bienvenido a mi sitio web"
            /*            byte edad = 0;
                        Console.WriteLine("Ingrese su edad");
                        edad = Convert.ToByte( Console.ReadLine() );
                        if(edad >= 18)
                        {
                            //Si se cumple la condición
                            Console.WriteLine("Bienvenidos a mi sitio web");*/
            //Crear un algoritmo que permita ingresar el nombre y el sueldo de una persona, si el sueldo supera los 3000 pesos, mostrar el mensaje en pantalla con el nombre de la persona, indicado que debe abonar impuestos
            {
                /*               float num = 0f;
                               string nombre;
                               Console.WriteLine("Ingrese su nombre");
                               nombre = Console.ReadLine();

                               Console.WriteLine("Ingrese su sueldo");
                                num = Convert.ToSingle (Console.ReadLine());
                                if (num >= 3000)
                                {
                                   Console.WriteLine(nombre+", Su sueldo supera el límite establecido. Está obligado a abonar impuestos." + num);*/
            }
            {
                byte edad = 0;
                Console.WriteLine("Ingrese su edad");
                edad = Convert.ToByte(Console.ReadLine());
                if (edad >= 18)
                {
                    //Si se cumple la condición
                    Console.WriteLine("Bienvenidos a mi sitio web");
                } else
                {
                    //Si NO se cumple la condició
                    Console.WriteLine("No es apto para el contenido del sitio web");
                }
            }
        }
    }
}