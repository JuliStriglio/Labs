using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Persona
    {
        private string Nombre;
        private string Apellido;
        private int Edad;
        private int DNI ;


        public Persona() //Constructor 
        {
      
           Console.WriteLine("Se creo un objeto");
        }


        //public void MostrarMensaje()
        //{
           // Console.WriteLine("Se creo un objeto ");
        //}

        public void GetFullName()
        {
            Console.WriteLine(" Su nombre completo es: " + Nombre + Apellido);
        }

        public void GetAge()
        {
            Console.WriteLine("Su edad es :" + Edad);
        }

        ~Persona()
        {
            Console.WriteLine("El objeto se destruyo");
        }
        
    }
}
