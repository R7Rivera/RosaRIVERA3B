using System;
//crear un programa que lea las cantidades y precios y al final indique el total de la factura. Primero se pregunta "introduzca la cantidad vendida" tras lo cual el usuario introducirá
//un número entero positivo. después se pregunta "introduzca el precio" que será un número decimal positivo 
//.La lectura terminara cuando en la cantidad se introduzca un 0. sí es así, se escribirá el total.​//
namespace factura3cant
{
    class Program
    {
        public static void Main(string[] args) {

            int n = 1;// declaracion de variable inicializacion en uno 
            int pro = 1;//contador que indica el numero de producto 
            double total = 0;// variable que guarda el total a pagar 
            double precio = 0.0;// declaracion de la variable precio en 0.0 
            Console.WriteLine("************BIENVENIDOS************** ");
            do
            {

                while (n != 0)
                {

                    Console.WriteLine("producto  " + pro);

                    Console.WriteLine("cantidad vendida ");
                    n = Convert.ToInt16(Console.ReadLine());

                    if (n != 0)
                    {
                        Console.WriteLine("ingrese el precio ");
                        precio = Convert.ToDouble(Console.ReadLine());
                        if (precio < 0)
                        {
                            Console.WriteLine("precio no valido ");
                        }
                        else
                        {
                            total += n * precio;
                            pro++;

                        }
                    }
                    else { }
                    {
                        break;//
                    }
                }
            } while (n != 0);
            Console.WriteLine("=======FACTURA=======");
            Console.WriteLine("EL TOTAL  DE SU COMPRA ES: " + total + " " +    "DOLARES");
            Console.WriteLine("*********GRACIAS POR SU COMPRA*********" );
            Console.ReadKey();
        }
    }
}
             

















