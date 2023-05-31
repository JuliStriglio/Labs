using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;

namespace LabClases4
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona per = new Persona();
            per.MostrarMensaje();
            per.GetFullName();
            per.GetAge();

            Console.ReadKey();
        }
    }
}
