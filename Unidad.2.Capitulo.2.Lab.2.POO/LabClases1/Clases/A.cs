using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Clases
{
    public class A
    {
        String NombreInstancia;

        public A()//Por defecto 
        {
            this.NombreInstancia = "Instancia sin nombre";
        }
        public A(string nombreInstancia)
        {
            this.NombreInstancia = nombreInstancia;
        }

        public void MostrarNombre()
        {
            Console.WriteLine(NombreInstancia);
        }
        
        public void m1()
        {
            Console.WriteLine("El metodo M1 fue invocado");
        }
        public void m2()
        {
            Console.WriteLine("El metodo M2 fue invocado");
        }
        public void m3()
        {
            Console.WriteLine("El metodo M3 fue invocado");
        }







    }
}
