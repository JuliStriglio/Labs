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

                ConsoleKeyInfo key = Console.ReadKey();
                String opcion = Console.ReadLine();

                int opc;

                if (opcion == "1")
                {
                    Console.WriteLine("Mayuscula");
                }
                if (opcion == "2"){
                    Console.WriteLine("minuscula");
                }
                if (opcion == "3"){
                    Console.WriteLine(inputTexto.Length);
                }
            }
            
        }
    }
}
