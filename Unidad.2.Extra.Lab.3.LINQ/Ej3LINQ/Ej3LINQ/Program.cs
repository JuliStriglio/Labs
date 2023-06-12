using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3LINQ
{
    class Program
    {

        class Ciudad
         {

             public string Nombre {get; set;} 
             public int CodP{get; set;}

             public Ciudad(string nombre, int codP)
             {
                 Nombre = nombre;
                 CodP = codP;
             }
         }
        static void Main(string[] args)
        {

            List<Ciudad> ciudades = new List<Ciudad>();

            Ciudad ciu1 = new Ciudad("Santa fe", 2173);
            ciudades.Add(ciu1);
            Ciudad ciu2 = new Ciudad ("Rosario", 2000);
            ciudades.Add(ciu2);
            Ciudad ciu3 = new Ciudad ("Cordoba", 5000);
            ciudades.Add(ciu3);
         
        Console.WriteLine("Ingrese la expresion");
            string expresion = Console.ReadLine();

        expresion = expresion.ToLower();

            var c = from ci in ciudades
                    where ci.Nombre.Contains(expresion)
            select ci.CodP;

            foreach(var cods in c)
            {
                Console.WriteLine(cods);
            }

            Console.ReadKey();


        }
    }
}
