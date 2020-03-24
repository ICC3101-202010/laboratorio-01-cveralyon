using System;

namespace lab001
{
	// Clase Persona (check)
	public class Person
	{
		String first;
		String last;


		// Constructor de clase Persona (check)
		public Person(String first, String last)
		{
			this.first = first;
			this.last = last;

		}

		// metodo Lanzar (check)
		public int lanzar()
		{
			Random random = new Random();
			return random.Next(0, 3);
		}

		// main del programa
		public static void Main(String[] args)
		{

			// creacion de Bob Kunga
			Person Bob = new Person("Bob", "Kunga");

			Console.WriteLine(Bob.first, Bob.last, "jugo el Ca Chi Pun con:");
            Console.WriteLine(Bob.lanzar());
		}

	}
}




