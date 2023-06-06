using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1LINQ
{
     class Program
    {
        static void Main(string[] args)
        {

            String[] list = { " Buenos aires", "Santa fe", "Tucuman", "Cordoba" , "San luis"};

            var l = from p in list
                    where p.StartsWith("S") || p.StartsWith("T")
                    select p;

            foreach(String s in l)
            {
                Console.WriteLine(s);
            }

            Console.ReadKey();


        }
    }
}
