using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio5BIS
{
    public class Jugada
    {
        public int _adivino;
        public int _intentos;
        public int _numero;

        public Jugada(int maxNumero)
        {
           
                Random rnd = new Random();
                Numero = rnd.Next(maxNumero);
            
        }
        public int Adivino
        {
            get => default;
            set
            {
            }
        }

        public int Intento
        {
            get => default;
            set
            {
            }
        }

        public int Numero
        {
            get => default;
            set
            {
            }
        }

        public void Comparar()
        {
            throw new System.NotImplementedException();
        }
    }
}