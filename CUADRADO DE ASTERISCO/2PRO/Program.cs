using System;
//2. Crear un programa que lea un número entero y a partir de él cree un cuadrado de asteriscos con ese
//tamaño.Los asteriscos sólo se verán en el borde del cuadrado, no en el interior.
namespace _2PRO
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("*********CUADRADO DE ASTERISCO*********** \n");
            Console.WriteLine("INGRESE EL TAMAÑO DEL CUADRADO : \n");
            int tam = int.Parse(Console.ReadLine());
            
                //linea superior 
                for (int sup = 0; sup < tam; sup++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();

                //centro de la forma
                for (int sup = 0; sup < tam - 2; sup++)
                {
                    Console.Write("*");
                    for (int medio = 0; medio < tam - 2; medio++)
                    {
                        Console.Write("  ");
                    }
                    Console.WriteLine(" * ");
                }
                //inferior 
                for (int inf = 0; inf < tam; inf++)
                {
                    Console.Write("* ");
                }

            
        }
    }
}


