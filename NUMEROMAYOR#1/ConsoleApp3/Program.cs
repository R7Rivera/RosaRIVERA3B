using System;
//1. Programa que lea una serie de números por teclado e indique cuál es el mayor
namespace ConsoleApp3
{
    class Program
    {


        static void Main(string[] args)
        {

            int cant, num, mayor = 0;
            Console.WriteLine("*********NUMERO MAYOR*********\n ");
            Console.Write("INGRESE LA CANTIDAD DE NUMERO :\n");
            cant = int.Parse(Console.ReadLine());
        
            for (int i = 0; i < cant; i++) {

                Console.WriteLine("ESCRIBA UN NÚMERO : \n");
                num = int.Parse(Console.ReadLine());

                if (i == 0) {
                    mayor = num;
                }
                else if (i != 0){ 

                
                    if (num > mayor) {

                        mayor = num;
                    }
                }
            }
            Console.WriteLine("EL NUMERO  MAYOR ES : " + mayor);
            Console.WriteLine("*********GRACIAS ********* ");

            Console.ReadKey();
        }
    }
}






























