using System;

class NumeroRomano
{
    static void Main()
    {
        int numero;

        Console.Write("Ingrese un número entero: ");
        numero = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("El número romano equivalente es: " + ConvertirARomano(numero));
        Console.ReadKey();
    }
    

    static string ConvertirARomano(int numero)
    {
        if (numero < 1 || numero > 3999)
        {
            throw new ArgumentOutOfRangeException("El número debe estar entre 1 y 3999.");
        }

        string[] simbolos = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
        int[] valores = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };

        string numeroRomano = "";

        for (int i = 0; i < simbolos.Length; i++)
        {
            while (numero >= valores[i])
            {
                numero -= valores[i];
                numeroRomano += simbolos[i];
            }
        }

        return numeroRomano;
      
    }

   
}

