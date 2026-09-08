using Microsoft.Win32;
using System;
using System.Security.Cryptography;
using System.Text;

namespace Taller_Ciclos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Algoritmo que permita calcular el promedio de calificaciones, el algoritmo le permitirá al usuario, introducir tantas calificaciones como así desee, en el momento en que seleccione que no desea continuar capturando calificaciones, el algoritmo debe presentar el promedio de las calificaciones capturadas previamente. 

            /*            decimal calificación = 0;
                        int calificacionesIngresadas = 0;
                        char respuesta = ' ';
                        decimal promedio;
                        do
                        {
                            Console.WriteLine("Ingrese una calificación.");
                            calificación = decimal.Parse(Console.ReadLine());
                            calificacionesIngresadas++;
                            promedio = calificación / calificacionesIngresadas;
                            Console.WriteLine("¿Desea ingresar otra calificación? S/si, N/no");
                            respuesta = char.Parse(Console.ReadLine());
                        } while(respuesta == 's');
                        Console.WriteLine($"Se ingresó un total de {calificacionesIngresadas} calificaciones, y su promedio es de {promedio}.");*/

            //Se requiere un algoritmo para mostrar por pantalla los divisores de un 
            //número ingresado por teclado. 
            //Tener en cuenta que dados dos números enteros a y b, se dice que b es
            //divisor de a si se cumple que al efectuar una división entera a/ b el
            //residuo es 0, en C# utilizar el operador Mod para obtener el residuo de 
            //una división de dos números. Ejemplo: si se ingresa 6 por teclado, por pantalla se debe mostrar 6, 3, 
            //2, 1 que son los divisores del número 6.


            /*            int numero;
                        Console.WriteLine("Ingrese un número.");
                        numero = int.Parse(Console.ReadLine());
                        int contador = 0;

                        do
                        {
                            contador++;
                            if (numero % contador == 0)
                            {
                                Console.WriteLine(contador);
                            }
                        }while (contador <= numero);*/

            /*            Dados dos números enteros ingresados por teclado: b que es la base y
                        e que es el exponente, se requiere calcular el resultado de la
                        potenciación.
                        Ejemplo: b = 2, e = 5  25 = 2 * 2 * 2 * 2 * 2 = 32
                        Mostrar por pantalla el resultado de la potenciación. 
                        Seguir pidiendo por teclado la base y el exponente y realizar la
                        potenciación correspondiente, hasta que el usuario ingrese por teclado
                        el carácter de escape ‘n’ */
            /*            char respuesta = ' ';
                        do
                        {
                            int contador = 0;
                            int potencia = 1;
                            int bas;
                            int expo;
                            Console.WriteLine("Ingrese la base de una potenciación");
                            bas = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese el exponente para la potenciación");
                            expo = int.Parse(Console.ReadLine());
                            do
                            {
                                contador++;
                                potencia *= bas;

                            } while (expo > contador);
                            Console.WriteLine(potencia);
                            Console.WriteLine("¿Desea continuar? S/sí, N/no");
                            respuesta = char.Parse(Console.ReadLine());
                        } while (respuesta == 's');*/


/*          Un entrenador le ha propuesto a un atleta recorrer una ruta de cinco
            kilómetros durante 10 días, para determinar si es apto para la prueba de
            5 kilómetros.Para considerarlo apto debe cumplir las siguientes
            condiciones: 
             Que en ninguna de las pruebas haga un tiempo mayor a 20 minutos.
             Que al menos en una de las pruebas realice un tiempo menor de 15
            minutos.
             Que su promedio sea menor o igual a 18 minutos.
            Diseñar un algoritmo para registrar los datos y decidir si es apto para la
            competencia.*/



        }
    }
}
