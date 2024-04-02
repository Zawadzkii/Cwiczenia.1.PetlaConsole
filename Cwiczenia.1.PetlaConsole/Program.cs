using System;

class Program
{
	static void Main()
	{
		int count = 0; // Licznik liczb pierwszych

		// Iteracja przez liczby od 2 do 100
		for (int i = 2; i <= 100; i++)
		{
			bool isPrime = true; // Flaga określająca, czy liczba jest pierwsza

			// Sprawdzenie, czy liczba jest pierwsza
			for (int j = 2; j <= Math.Sqrt(i); j++)
			{
				if (i % j == 0)
				{
					isPrime = false;
					break; // Jeśli liczba nie jest pierwsza, przerwij pętlę
				}
			}

			// Jeśli liczba jest pierwsza, zwiększ licznik
			if (isPrime)
			{
				count++;
			}
		}

		Console.WriteLine("Liczba liczb pierwszych w zakresie od 0 do 100: " + count);
	}
}