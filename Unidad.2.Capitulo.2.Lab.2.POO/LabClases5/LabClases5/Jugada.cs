using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabClases5
{
    class Jugada
    {
        
      public Jugada(int maxNumero)
        {
            Random rnd = new Random();
            maxNumero = rnd.Next(maxNumero);
        }


       public bool Adivina
       {
          get { return _adivino; }
            set { _adivino = value; }
       }

       public int Intentos
       {
           get { return _intentos;  }
            set { _intentos = value; }
       }

       public string Numero
        {
            get { return _numero; }
            set { _numero = value; }
        }



        void Comparar()
        {
            Console.WriteLine("Ingresar el numero para comparar : ");
           _numero = Console.ReadLine();
           _intentos++;
           int _num;
           _num = Convert.ToInt32(_numero);

            Jugada j = new Jugada(10);
        
}

           




        private string _numero; // campo privado
        private int  _intentos ; // campo privado
        private bool _adivino; // campo privado
    }
}
