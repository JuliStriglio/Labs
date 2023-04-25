using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis4h
{
    class Program
    {
        static void Main(string[] args)
        {

            int intento = 0;
            string clave = "clave";
            string leer = "";

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese la clave ");
                leer = Console.ReadLine();
                intento++;

                if (leer == clave)
                {
                    Console.WriteLine("CLave correcta ");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine("Clave incorrecta ");
                }
                if (intento == 4)
                {
                    Console.WriteLine("Intento numero 4, NO tiene mas intentos");
                    Console.ReadKey();
                    break;

                }

                
            }
            
           

        }
    }
}
