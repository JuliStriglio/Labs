using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabClases5
{
    class Juego
    {
        public Juego()
        {

        }

        public void ComenzarJuego()
        {
            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("MENU");
                Console.WriteLine("1 - ");
                Console.WriteLine("2 - ");
                Console.WriteLine("3 - SALIR ");
                Console.WriteLine("--------------------");
                Console.WriteLine("Ingrese la opcion : ");

            }

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.WriteLine("Seleccionaste la opcion 1");
                    Jugada ju = new Jugada(10);
                   

                    break;

                case "2":
                    Console.WriteLine("Seleccionaste la opcion 2");
                    break;

                case "3":
                    Console.WriteLine("HASTA LUEGO !");
                    salir = true;
                    break;

                default:
                    Console.WriteLine("Ingrese una opcion valida");
                    break;
            }

            Console.WriteLine();

        }

        void CompararRecord()
        {

        }
       void Continuar()
        {

        }
      void PreguntarMaximo()
        {

        }

       void PreguntarNumero()
        {

        }

        int _record;
    }
}