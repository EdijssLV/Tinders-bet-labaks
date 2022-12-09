using System;
					
public class Program
{
	public static void Main()
	{
		string[] viriesuVardi = {"Egils", "Edijs", "Mārtiņš", "Uģis", "Alberts", "Ādolfs", "Didzis", "Jēkabs", "Markuss", "Igors", "Oskars", "Ivis", "Vadims", "Vaidis", "Mariks", "Harijs", "Ģirts", "Gusts", "Agris", "Agnis,", "Bruno", "Aivars", "Igors", "Bens", "Vagifs", "Māris"};
		string[] viriesuUzvardi = {"Ābele", "Āboltiņš", "Auns", "Bērziņš", "Dadzis", "Donis", "Frīdbergs", "Levits", "Fišers", "Ozols", "Sakne", "Ulmanis", "Čakste", "Vanags", "Zeltiņš", "Baltiņš", "Bebris", "Bargais", "Bite", "Buks", "Cērps", "Dukurs", "Ērglis", "Ezeriņš", "Jankavs"};

		string[] sieviesuVardi = {"Ūva", "Rasma", "Liāna", "Liana", "Aģe", "Grēta", "Grieta", "Eva", "Agrita", "Laila", "Auce", "Ādolfīna", "Austra", "Grita", "Olga", "Svetlana", "Una", "Sarma", "Milda", "Loreta", "Lote", "Eba", "Evelīna", "Dace", "Alba", "Aiva", "Aleksa", "Anna", "Marija", "Milda"};
		string[] sieviesuUzvardi = {"Ābelīte","Āboliņa", "Aune", "Bērziņa", "Dadze", "Done", "Frīdberga", "Levite", "Fišere", "Ozole", "Sakne", "Ulmane", "Čakste", "Vanags", "Zeltiņa", "Baltiņa", "Bebre", "Bragais", "Bite", "Buka", "Cērpe", "Dukure", "Ērgle", "Ezeriņa", "Jankava"};
		
		Random rnd = new Random();
		int km = rnd.Next(1, 250);
		int Km = rnd.Next(1, 250);
		
		int X = rnd.Next(viriesuVardi.Length);
		int XX = rnd.Next(viriesuUzvardi.Length);
		
		int Y = rnd.Next(sieviesuVardi.Length);
		int YY = rnd.Next(sieviesuUzvardi.Length);
		
		Console.WriteLine("Patīk džeki vai skuķi?");
		Console.WriteLine("1. Džeki");
		Console.WriteLine("2. Skuķi");
		Console.WriteLine("3. Abi");
		Console.WriteLine("------------------------");
		int ievade = Convert.ToInt32(Console.ReadLine());
		if(ievade == 1)
		{
			for (int i = 0; i < 1000; i++) 
			{
 				Console.WriteLine(viriesuVardi[X]+" "+viriesuUzvardi[XX]);
				Console.WriteLine(km+" kilometru attālumā");
				Console.WriteLine("Patīk? Nepatīk?");
				Console.ReadLine();
			}
		}
		else if(ievade == 2)
		{
			for (int i = 0; i < 1000; i++) 
			{
 				Console.WriteLine(sieviesuVardi[Y]+" "+sieviesuUzvardi[YY]);
				Console.WriteLine(km+" kilometru attālumā");
				Console.WriteLine("Patīk? Nepatīk?");
				Console.ReadLine();
			}
		}
		else
		{
			for (int i = 0; i < 1000; i++) 
			{
				Console.WriteLine("1. "+viriesuVardi[X]+" "+viriesuUzvardi[XX]);
				Console.WriteLine(km+" kilometru attālumā");
 				Console.WriteLine("2. "+sieviesuVardi[Y]+" "+sieviesuUzvardi[YY]);
				Console.WriteLine(Km+" kilometru attālumā");
				Console.WriteLine("Kuri no diviem vairāk patīk??");
				Console.WriteLine("1. vai 2.?");
				Console.ReadLine();
			}
		}
	}
}
