
//Crear un programa para calcular el salario semanal de unos empleados a los que se les paga 15 dólares 
//por hora si éstas no superan las 35 horas. Cada hora por encima de 35 se considerará extra y 
//se paga a 22 dólares. 
//El programa pide las horas del trabajador y devuelve el salario que se le debe pagar.
//Además, el programa debe preguntar si deseamos calcular otro salario, si es así el programa se repite






using System;

namespace salario
{
    class Program
    {
           static void Main (string[] args)

        {

            int salario, horas, next;
                int extra = 22, jornadanormal = 15;
            do
            {

                Console.WriteLine("=========SALARIO DE TRABAJADORES=================");
                Console.Write("Ingrese la cantidad de horas trabajadas en la semana ");
                horas = int.Parse(Console.ReadLine());
            

                if (horas <= jornadanormal)
                {
                    salario = jornadanormal * horas;
                }
                else
                {
                    extra = (horas - 35) * extra;
                    salario = extra + (jornadanormal * 35);

                }

                Console.WriteLine("salario total es " + salario);
                Console.WriteLine("Desea ingresar otro salario  1=SI, 0=NO?");
                 next = Convert.ToInt32(Console.ReadLine());
            } while (next == 1);

            Console.WriteLine("El proceso se ha calculado con exito :HASTA LA PROXIMA" );
                Console.ReadLine();
            }
        }
    }

                








