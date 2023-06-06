using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            for (int i = 0; i < 5; i++) {

                Console.WriteLine("Ingrese un numero ");
                list.Add(Convert.ToInt32(Console.ReadLine()));
            }

            var l = from li in list
                    where li > 20
            select li;

            foreach (int i in l)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
