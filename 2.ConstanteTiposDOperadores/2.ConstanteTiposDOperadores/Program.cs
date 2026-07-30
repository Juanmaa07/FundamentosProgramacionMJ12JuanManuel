using System;
namespace _2.ConstanteTiposDOperadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Constantes
            const string gravedad = "9.8";
            string nombre = "Juan Manuel";
            nombre = "Vegetta777";
            //No puedo cambiar el valor de una constante

            //TIPOS DE DATOS
            byte dato1 = 0;
            int dato2 = -4563;
            ulong dato3 = 23262636635;
            float dato4 = 14.6f;
            double dato5 = 2123636.32568d;
            decimal dato6 = 123653623633.123565985632m;

            char dato7 = '+';
            string dato8 = "jfhfdjhdjhsfhjfdjh´´+{ñ.,";
            bool dato9 = false;//true o false
            object dato10 = new object();

            //OPERADORES
            //Operadores Numéricos
            //Cambio de Signo
            int dato11 = 5;
            int dato12 = -dato11;
            int dato13 = +dato12;
            int dato14 = -dato13;
            Console.WriteLine("dato11:{0}, dato12:{1}, dato 13:{2}, dato 14:{3}", dato11, dato12, dato13, dato14);
            int dato15 = 5 + 3; //Suma
            int dato16 = dato15 -2;//Resta
            int dato17 = 25 * 3;//Producto
            //float dato18 =(float) 5 / 3;//División
            float dato18 = 5f / 3f;
            Console.WriteLine("Suma: {0}, Resta:{1}, producto:{2}, división:{3}",dato15, dato16, dato17, dato18);
        }
    }
}
