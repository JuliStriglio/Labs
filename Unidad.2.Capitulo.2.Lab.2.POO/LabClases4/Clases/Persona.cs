using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Persona
    {
        private string Nombre = ("Julieta");
        private string Apellido = ("Striglio");
        private int Edad = 22;
        private int DNI = 43164308;


        public Persona(string nombre)
        {
            this.Nombre = nombre;
        }

        public Persona()
        {
        }

        public void MostrarMensaje()
        {
            Console.WriteLine("Se creo un objeto ");
        }

        public void GetFullName()
        {
            Console.WriteLine(" Su nombre completo es: " + Nombre + Apellido);
        }

        public void GetAge()
        {
            Console.WriteLine("Su edad es :" + Edad);
        }



    }
}
