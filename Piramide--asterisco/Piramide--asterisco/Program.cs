using System;
//Crear el programa asteriscos4 en el que se introduce un número entero y se crea una pirámide de
//asteriscos.Por ejemplo, si se introduce el 6, el resultado sería:
//       *
//      ***
//     *****
//    *******
 //  *********
//  ***********
namespace ASTERISCOPIRAMIDE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<<<<<<<<<<<<<<<PIRAMIDE DE ASTERISCO>>>>>>>>>>>>");
            Console.WriteLine("INGRESE EL TAMAÑO DE LA PIRAMIDE");
            int tamaño = Convert.ToInt16(Console.ReadLine());

            for (int inicial = 1; inicial <= tamaño; inicial++)
            {
                for (int B = 1; B <= tamaño - inicial; B++)
                {
                    Console.Write(" ");
                }
                for (int A = 1; A <= (2 * inicial) - 1; A++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}


