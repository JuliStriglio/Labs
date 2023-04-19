using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis4b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un año: ");
            string año = Console.ReadLine();
            int anio = Convert.ToInt32(año);

            if (anio % 4 == 0)
            {
                if (anio % 100 == 0)
                {
                    if (anio % 400 == 0)
                    {
                        Console.WriteLine("El año es bisiesto");
                    }
                    else
                    {
                        Console.WriteLine("El año NO es bisiesto");
                    }
                }

                else
                {
                    Console.WriteLine("El año es bisiesto ");
                }

            }
            else
            {
                Console.WriteLine("El año NO es bisiesto");
            }
            Console.ReadKey();
        }
        
    }
}
