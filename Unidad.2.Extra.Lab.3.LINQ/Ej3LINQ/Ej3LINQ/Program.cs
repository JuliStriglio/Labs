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

             public string Nombre;
             public int CodP;

             public Ciudad(string nombre, int codP)
             {
                 Nombre = nombre;
                 CodP = codP;
             }
         }
        static void Main(string[] args)
        {

            List<Ciudad> ciudades = new List<Ciudad>();

            Ciudad ciu1 = new Ciudad ("Santa fe", 2173);
            ciudades.Add(ciu1);
             Ciudad ciu2 = new Ciudad ("Rosario", 2000);
            ciudades.Add(ciu2);
             Ciudad ciu3 = new Ciudad ("Cordoba", 5000);
            ciudades.Add(ciu3);
           

            var c = from ci in ciudades
                    where ci.Nombre.StartsWith("R")
            select ci;

            foreach()
            {
                Console.WriteLine(i);
            }




        }
    }
}
