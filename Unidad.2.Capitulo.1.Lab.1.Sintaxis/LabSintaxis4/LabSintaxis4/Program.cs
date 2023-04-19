using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el numero 1");
            string num1 = Console.ReadLine();
            int n1 = Convert.ToInt32(num1);

            Console.WriteLine("Ingrese el numero 2");
            string num2 = Console.ReadLine();
            int n2 = Convert.ToInt32(num2);

            int suma = n1 + n2;

            Console.WriteLine("La sumatoria del numero" + num1 + "y el numero " + num2 + "es " + suma);
            Console.ReadKey();

        }
    }
}
