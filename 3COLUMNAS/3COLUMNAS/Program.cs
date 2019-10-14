//Crear un programa en C# que lea un número entero y positivo y que escriba tres columnas. La primera
//cuenta desde uno hasta el número escrito contando de uno en uno; la segunda columna cuenta de dos
//en dos y la tercera de tres.
using System;

namespace _3COLUMNAS
{
    class Program
    {
          public static int entero;

        static void Main(string[] args)
        {
            {

                int numero, numero1, numero2, entero;
                do
                {
                    Console.WriteLine("**NUMEROS EN UNO EN UNO  **" + "   " + "***NUMEROS DE DOS EN DOS***" + "  " + "****NUMEROS DE TRES EN TRES****");
                    Console.WriteLine("\t \t <<<<<<<<<<<<<<<<<<************>>>>>>>>>>>>>>>>>>>>>>>  \n \n");
                    Console.WriteLine("Ingrese el tamaño de numeros en sus columnas ");
                    entero = Convert.ToInt32(Console.ReadLine());

                    for (numero = 1; numero <= entero; numero++)
                    {

                        numero1 = (numero + 2);
                        numero1 = numero1 + numero;
                        Console.WriteLine("");
                        numero2 = ((numero + 3) + numero + numero);
                        Console.WriteLine("" + ("EN UNO EN UNO ") + "" + "   " + "      " + (("DOS EN DOS")) + " " + "   " + "  " + "    " + "   " + ("TRES EN TRES") + " " + "   ");
                        Console.WriteLine("" + (numero) + "." + "           " + "       " + "    " + "    " + ((numero1)) + "." + "             " + "    " + "     " + (numero2) + "." + "   ");
                    }
                    Console.WriteLine("Ingresar una tecla para continuar:");

                    Console.ReadKey();

                } while (entero !=0);

            }
        }
    }
}



