using System;
//Modificar el ejercicio  de la piramide para que aparezca un rombo
namespace ROMBO_ASTERISCO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========*****ROMBO*****==========");
            Console.WriteLine("ingrese la altura del rombo");
            int alt = Convert.ToInt32(Console.ReadLine());
            for (int inicial = 1; inicial <= alt; inicial++)

            {
                for (int b = 1; b <= alt - inicial; b++)

                {
                    Console.Write(" ");
                }
                for (int c = 1; c <= (2 * inicial) - 1; c++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            alt--;
            for (int inicial = 1; inicial <= alt; inicial++)
            {
                for (int b = 1; b <= inicial; b++)
                {
                    Console.Write(" ");
                }
                for (int c = 1; c <= (alt - inicial) * 2 + 1; c++)

                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.ReadLine();

        }

    }

}

