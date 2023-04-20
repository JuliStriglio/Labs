using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis4e
{
    class Program
    {
        static void Main(string[] args)
        {

            String[] meses = {"enero", "febrero", "marzo", "abril", "mayo","junio", "julio", "agosto", "septiembre", "octubre", "noviembre", "diciembre" };

            Console.WriteLine("Ingrese el nombre de un mes del año");
            String mes = Console.ReadLine();

            int i = 1;


            foreach (string item in meses)
            {
                if (mes == item)
                {
                    Console.WriteLine("Nombre del mes:  " + mes + " numero del mes:  " + i);
                }
                else
                {
                    i++;
                }
            }
            Console.ReadKey();
        }
    }
}
