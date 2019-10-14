using System;

namespace Columnas1__100
{
    class Program
    {
    
        static void Main(string[] args)
        {
            int inicial, inicial1;
            Console.WriteLine("**********COLUMNA DE NUMEROS DEL 1 AL 100******** | ********COLUMNA DE NUMEROS DEL 100 AL 1 ***********");

            Console.WriteLine("\t \t°°°°°°°°°°°°°°°°°°°°°°°°°°° \n \n");

            {

                {


                    for (inicial = 1; inicial <= 100; inicial++)
                    {
                        Console.WriteLine(" " + inicial);

                        inicial1 = 101 - inicial;
                        Console.WriteLine("   " + "       " + "      " + "     " + "  " + "  " + (inicial1) + "   " + "   ");

                    }
                    Console.ReadKey();
                }
            }
        }
    }
}















