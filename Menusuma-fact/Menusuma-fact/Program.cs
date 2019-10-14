//Crear un programa que muestre un menú como este:
//1) Salir
//2) Sumatorio
//3) Factorial
//Tras mostrar el menú, el programa debe leer un número del 1 al tres si se elige 1, el programa acaba.Si se
//elige 2 se calcula el sumatorio del número, si se elige 3 se calcula la factorial(en ambos casos el programa
//pedirá escribir el número sobre el que se calcula el sumatorio o la factorial). Tras calcular el sumatorio o la
//  factorial e indicar el resultado, el programa volverá a mostrar el menú y así sucesivamente




using System;

namespace Menusuma_fact
{
    class Program
    {
        static void Main(string[] args)
        {
            int alternativa;

            do
            {
                Console.WriteLine("\n ********BIENVENIDOS AL MENÙ********");
                Console.WriteLine("\n");
                    
                    Console.WriteLine("\n 1.Salir\n");
                    Console.WriteLine("\n 2. Suma\n");
                    Console.WriteLine("\n 3.factorial\n");
                do
                {
                    Console.WriteLine("\n *******ESCOJA UNA OPCION ENTRE EL (1-3) :*******");
                    alternativa = Convert.ToInt32(Console.ReadLine());

                } while (alternativa < 1 || alternativa > 3);

                switch (alternativa)
                {
                    //Alternativa uno Salir//
                    case '1':
                       
                        Console.ReadKey();
                        break;
                    //Alternativa dos sumar //
                    case 2:
                        Console.WriteLine("SUMA");
                        Console.WriteLine("INGRESE EL PRIMER NUMERO");
                        int NUMERO1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("INGRESE EL SEGUNDO NUMERO");
                        int NUMERO2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("EL RESULTADO ES :   " + (NUMERO1 + NUMERO2));
                        Console.Write("\nPULSE UNA TECLA PARA CONTNUAR:"); Console.ReadLine();
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("INGRESE UN NUMERO PARA CALCULAR EL FACTORIAL:");
                        int numero = Convert.ToInt32(Console.ReadLine());
                        int fact = numero;
                        for (int i = numero - 1; i >= 1; i--)
                        {
                            fact = fact * i;
                        }
                        Console.WriteLine(" EL RESULTADO DEL FACTORIAL DE  {0} es {1}", numero, fact);
                        Console.WriteLine("\nPULSE UNA TECLA PARA CONTINUAR:"); Console.ReadLine();
                        Console.ReadKey();

                        break;
                }
            } while (alternativa != 1);
            Console.WriteLine("**********ACABA DE SALIR GRACIAS**********");

        }
    }
}

          

                






