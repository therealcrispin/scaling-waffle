// Witam, to jest mój konwerter jednostek. Powstal, bo mam dość szukania tego w internecie i po prostu będzie mi łatwiej.
// W zasadzie jest to mój 2 projekt w C#.

using System;

public class KonwerterJednostek
{
	public static void Main(string[] args)
	{
		Console.Clear();
		string powitanie = ("\nHej, jest to prosty konwerter jednostek, który pozoli Ci szybko przeliczyć miary metryczne,\n"+
				"na miary imperialne i na odwrót. Mam nadzieje, że pomoże Ci to w tym co własnie próbujesz zrobić.\n"+
				"Na przykład stworzyć zawodnika w NBA 2k i nie wiesz ile to będzie 210 cm i 120 kg w ich miarach.\n"+
				"\nZapraszam :)");

		Console.WriteLine(powitanie);

		string naglowek = ("\n\nWybierz jaki konwerter Cię interesuje:");
		Console.WriteLine(naglowek);

		while (true)
		{
			Console.WriteLine("[1] Centymetry i cale");
			Console.WriteLine("[2] Centymetry i stopy");
			Console.WriteLine("[3] Metry i jardy");
			Console.WriteLine("[4] Kilometry i mile");
			Console.WriteLine("[5] Kilogramy i funty");
			Console.WriteLine("[6] Zamknij program");

			var input = Console.ReadLine();

			switch (input)
			{
				case "1":
					Sekcja1();
					break;
				case "2":
					Sekcja2();
					break;
				case "3":
					Sekcja3();
					break;
				case "4":
					Sekcja4();
					break;
				case "5":
					Sekcja5();
					break;
				case "6":
					Console.Clear();
				return;
					default:
				Console.Clear();
					Console.WriteLine("Błędny wybór, spróbuj raz jeszcze");
					break;
					

			}
		}

	}

	static void Sekcja1()
	{
		Console.Clear();
		
		Console.WriteLine("Wybierz opcję:");
		Console.WriteLine("[1] Konwersja cm na cale");
		Console.WriteLine("[2] Konwersja cale na cm");
		Console.WriteLine("[3] Wróc");

		string choice = Console.ReadLine();

		switch (choice)
		{
			case "1":
			Console.Clear();

			Console.WriteLine("\nWprowadź cemtymetry: ");
			double cmcale = double.Parse(Console.ReadLine());
			double cale = cmcale * 0.39;
			Console.Clear();
			Console.WriteLine($"\n{cmcale} centymetrów to {cale:F2} cali\n");
			break;

			case "2":
			Console.Clear();

			Console.WriteLine("\nWprowadź cale: ");
			double calecm = double.Parse(Console.ReadLine());
			double cm = calecm * 2.54;
			Console.Clear();
			Console.WriteLine($"\n{calecm} cali to {cm:F2} centymetrów\n");
			break;

			case "3":
			Console.Clear();
			return;

		default:
			Console.WriteLine("Błędny wybór, spróbuj raz jeszcze");
			break;
		}


	}

	static void Sekcja2()
	{
		Console.Clear();

		Console.WriteLine("Wybierz opcję: ");
		Console.WriteLine("[1] Centymetry na stopy");
		Console.WriteLine("[2] Stopy na centymetry");
		Console.WriteLine("[3] Wróć");

		string choice = Console.ReadLine();

		switch (choice)
		{
			case "1":
			Console.WriteLine("\nWprowadź centrymetry: ");
			double centymetry = double.Parse(Console.ReadLine());

			double stopy = Math.Floor(centymetry / 30.48);
			double cale = Math.Round((centymetry % 30.48) / 2.54);
			
			Console.Clear();
			Console.WriteLine($"/n{centymetry} centymetrów to {stopy}'{cale}''");
			break;

			case "2":
			Console.Clear();
			Console.Write("Podaj wartość w stopach i calach (np. 5'11' dla 5 stóp 11 cali): ");
			string[] parts = Console.ReadLine().Split('\'', '\"');
			double feetInput = double.Parse(parts[0]);
			double inchesInput = double.Parse(parts[1]);

			double totalCentimeters = (feetInput * 30.48) + (inchesInput * 2.54);
			
			Console.Clear();
			Console.WriteLine($"\nWynik to {totalCentimeters:F2} centymetrów\n");
			break;

			case "3":
			Console.Clear();
				return;

			default:

				Console.WriteLine("Błędny wybór, spróbuj raz jeszcze");
				break;
		}

	}

	static void Sekcja3()
	{
	
	Console.Clear();

	Console.WriteLine("Wybierz opcje: ");
	Console.WriteLine("[1] Metry na jardy");
	Console.WriteLine("[2] Jardy na metry");
	Console.WriteLine("[3] Wróć");

	string choice = Console.ReadLine();

	switch (choice)
	{
		case "1":
		Console.Clear();
		Console.WriteLine("\nWprowadź metry");
		double mjardy = double.Parse(Console.ReadLine());
		double jardy = mjardy * 1.09361;

		Console.Clear();
		Console.WriteLine($"\nWynik to {mjardy} metrów to {jardy:F2} jardów\n");
		break;

		case "2":
		Console.Clear();
		Console.WriteLine("\nWprowadź jardy");
		double jardym = double.Parse(Console.ReadLine());
		double m = jardym * 0.9144;

		Console.Clear();
		Console.WriteLine($"\nWynik to: {jardym} jardów to {m:F2} metrów\n");
		break;

		case "3":
		Console.Clear();
			return;

		default:

		Console.WriteLine("Błędny wybór, spróbuj raz jeszcze");
		break;
		
	}
	}
	

	static void Sekcja4()
	{

	Console.Clear();
	Console.WriteLine("Wybierz opcje: ");
	Console.WriteLine("[1] Kilometry na mile");
	Console.WriteLine("[2] Mile na kilometry");
	Console.WriteLine("Wróć");

	string choice = Console.ReadLine();

	switch (choice)
	{
		case "1":
		Console.Clear();

		Console.WriteLine("Wprowadź kilometry: ");
		double kmm = double.Parse(Console.ReadLine());
		double mile = kmm * 0.621;

		Console.Clear();
		Console.WriteLine($"\n{kmm} kilometrów to {mile:F2} mili\n");
		break;

		case "2":
		Console.Clear();

		Console.WriteLine("Wprowadź mile: ");
		double mkm = double.Parse(Console.ReadLine());
		double km = mkm * 1.609;

		Console.Clear();
		Console.WriteLine($"\n{mkm} mil to {km:F2} kilometrów\n");
		break;

		case "3":
		Console.Clear();
			return;

		default:
		Console.WriteLine("Błędny wybór, spróbuj raz jeszcze");
		break;

	}

	}

	static void Sekcja5()
	{

	Console.Clear();
	Console.WriteLine("Wybierz opcje: ");
	Console.WriteLine("[1] Kilogramy na funty");
	Console.WriteLine("[2] Funty na kilogramy");
	Console.WriteLine("[3] Wróć");
	
	string choice = Console.ReadLine();

	switch (choice)
	{
		case "1":
		Console.WriteLine("Podaj kilogramy: ");
		double kgf = double.Parse(Console.ReadLine());
		double funty = kgf / 0.45359237;

		Console.Clear();
		Console.WriteLine($"\n{kgf} kilogramów to {funty:F2} funtów\n");
		break;

		case "2":
		Console.WriteLine("Podaj funty: ");
		double fkg = double.Parse(Console.ReadLine());
		double kg = fkg / 2.20462262;

		Console.Clear();
		Console.WriteLine($"\n{fkg} funtów to {kg:F2} kilogramów\n");
		break;

		case "3":
		Console.Clear();
			return;

		default:
	Console.WriteLine("Błędny wybór, spróbuj raz jeszcze");
	break;

	}



	}
	
}

