using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis4i
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el numero de filas para el triangulo ");
            string filass = Console.ReadLine();
            int filas = Convert.ToInt32(filass);

            for(int i = 1; i <= filas; i++)
            {
                for (int j = 0; j< i; j++)
                {
                    Console.WriteLine("*");

                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }
    }
}
