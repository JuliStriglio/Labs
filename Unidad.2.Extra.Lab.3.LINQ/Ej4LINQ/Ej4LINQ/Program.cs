using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej4LINQ
{
    class Program
    {

        class Empleado
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public decimal Sueldo { get; set; }


        public Empleado (int id, string nombre, decimal sueldo)
            {
                Id = id;
                Nombre = nombre;
                Sueldo = sueldo;
            }
        }

        
        static void Main(string[] args)
        {

            List<Empleado> empleados = new List<Empleado>();
            Console.WriteLine("Ingrese cantidad de empleados ");
            int cant = int.Parse(Console.ReadLine());

            for (int i = 0; i <= cant; i++) {
                Console.WriteLine(" Dar de alta un empleado ");

                Console.WriteLine("Ingrese el id ");
                int id = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el nombre ");
                string nombre = Console.ReadLine();

                Console.WriteLine("Ingrese el sueldo");
                decimal sueldo = decimal.Parse(Console.ReadLine());

                Empleado empleado = new Empleado(id, nombre, sueldo);
                empleados.Add(empleado); }

            var empasc = from em in empleados
                    orderby em.Sueldo ascending
                    select em;

            foreach (Empleado e in empasc)
            {
                Console.WriteLine($"Id:{ e.Id}, Nombre :{ e.Nombre}, Sueldo: {e.Sueldo} ");
            }

            Console.ReadKey();
     
        }
    }
}
