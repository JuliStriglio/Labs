using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una palabra");
            String inputTexto = Console.ReadLine();
            if (inputTexto == String.Empty)
            {
                Console.WriteLine("No ingreso un tipo de dato string");
            }
           else
            {
                Console.WriteLine("Ingrese una opcion");
                Console.WriteLine("1- Mostrar frase en mayuscula ");
                Console.WriteLine("2- Mostrar frase en minuscula");
                Console.WriteLine("3- Mostrar cantidad de caracteres");


                //ConsoleKeyInfo key = Console.ReadKey();
               // String opcion = Console.ReadLine();

                ConsoleKeyInfo opcion;
                opcion = Console.ReadKey();

                

                if (opcion.Key == ConsoleKey.D1)
               {
                   
                   
                    Console.WriteLine(inputTexto.ToUpper());
                    Console.ReadKey();
                }
                if (opcion.Key == ConsoleKey.D2)
                {
                   
                    Console.WriteLine(inputTexto.ToLower());
                    Console.ReadKey();
                }
                if (opcion.Key == ConsoleKey.D3){
                    
                    Console.WriteLine(inputTexto.Length);
                    Console.ReadKey();
                }
            }
            
        }
    }
}
