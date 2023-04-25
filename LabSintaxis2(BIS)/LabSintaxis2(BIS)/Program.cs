using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis2_BIS_
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
            }

           string opcion = Console.ReadLine();
           opcion = Convert.ToInt32(opcion);

            switch (opcion) {

                case opcion == 1:
                    break;
                    



            }

        }
    }
}