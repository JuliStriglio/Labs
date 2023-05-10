using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;

namespace LabClases1
{
    class Program
    {
        static void Main(string[] args)
        {

            A a1 = new A();
            a1.m1();
            a1.m2();
            a1.m3();
            B b1 = new B();

            a1.MostrarNombre();
            b1.MostrarNombre();

            Console.ReadKey();

        }
        
    }
}
