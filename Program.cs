using System;

namespace itla3divisible
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int number;

			Console.WriteLine("Bienvenido!");
			Console.WriteLine("ingrese numero");

			number = int.Parse(Console.ReadLine());

			Console.WriteLine("---------------------");
			if (number % 3 == 0) {
				Console.WriteLine(number + " es divisible por 3");
			} else {
				Console.WriteLine(number + " no es divisible por 3");
			}
			
			if (number % 5 == 0) {
				Console.WriteLine(" y es divisible por 5");
			} else {
				Console.WriteLine(" y no es divisible por 5");
			}
		}
	}
}
