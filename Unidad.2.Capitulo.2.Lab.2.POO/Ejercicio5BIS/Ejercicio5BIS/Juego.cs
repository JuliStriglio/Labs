using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio5BIS
{
    public class Juego
    {

        private int _record;

        public Juego()
        {

        }
 
        public void ComenzarJuego()
        {

            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("Ingresar la opcion ");
                Console.WriteLine("1- Realizar una partida ");
                Console.WriteLine("1-  ");
                Console.WriteLine("1-  ");
                Console.WriteLine("4- SALIR ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1": Console.WriteLine("Realizar una partida");
                        Jugada jug = new Jugada(10);

                     for(int i=0; i<=3; i++)
                        {
                            Console.WriteLine("Ingrese el numero que cree adivinar : ");
                            jug._numero = Convert.ToInt32(Console.ReadLine());
                            i++;

                            if (jug._numero == jug.Numero)
                            {
                                Console.WriteLine("Adivino !!!");
                                i = _record;
                            }
                           
                        }

                        break;

                    case "2":
                        Console.WriteLine("Opcion 1");
                        break;

                    case "3":
                        Console.WriteLine("Opcion 1");
                        break;

                    case "4":
                        Console.WriteLine("Hasta luego");
                        break;
                }
            }
            
            
            
            
            
            
            
            throw new System.NotImplementedException();
        }

        private void CompararRecord()
        {
            throw new System.NotImplementedException();
        }

        private void Continuar()
        {
            throw new System.NotImplementedException();
        }

        private void PreguntarMaximo()
        {
            throw new System.NotImplementedException();
        }

        private void PreguntarNumero()
        {
            throw new System.NotImplementedException();
        }
    }
}