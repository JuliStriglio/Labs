using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis4c
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int[] numeros = new int[20];
            numeros[0] = 1;
            numeros[1] = 1;

            for(int i=2; i<20; i++)
            {
                numeros[i] = (numeros[i - 1] + numeros[i - 2]);
            }
            foreach(int item in numeros)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
