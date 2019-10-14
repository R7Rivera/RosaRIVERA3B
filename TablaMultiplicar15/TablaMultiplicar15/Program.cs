//Crear el programa tablaMultiplicar que escriba la tabla de multiplicar del número 1 al número 15
using System;

namespace TablaMultiplicar15
{
    class Program
    {
        static void Main(string[] args)
        {
                int numero, Inicial;
                int resultado;
                do
                {
                Console.Write("*********TABLA DE MULTIPLICAR***********");
                Console.Write(" \n\n ");
                Console.Write("DIGITE NÚMERO DEL 1 AL 15:\n");
                numero = int.Parse(Console.ReadLine());
                for (Inicial = 1; Inicial <= 15; Inicial++)
                {
                    resultado = numero * Inicial;
                    Console.WriteLine("\n{0} * {1} = {2}", numero, Inicial,resultado);
                }
                Console.Write("PULSE UNA TECLA SI DESEA CONTINUAR  :\n"); 
                Console.ReadKey();
            } while (Inicial != 0);
        }
    }
}
