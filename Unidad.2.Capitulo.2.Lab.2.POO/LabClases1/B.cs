using System;
using Clases;

public class B : A
{
	public B()
	{
		A n1 = new A("Instancia de B");

	}

	public void m4()
    {
		Console.WriteLine("Metodo del hijo invocado ");
    }
}
