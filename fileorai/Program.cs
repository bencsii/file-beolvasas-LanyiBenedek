namespace fileorai
{
	internal class Program
	{

		static void Main(string[] args)
		{
					 List<Karakter> karakterek = [];

			fileBeolvas("karakterek.txt",karakterek);
			//atlagosSzint(karakterek);
			//legmagasabbEletero(karakterek);
			//erossegMeghaladja(karakterek);

			karakterStat(karakterek, 9);
			adatMentes(karakterek);

			foreach(var item in karakterek)
			{
				//Console.WriteLine(item);

			}
			
			
		}

		static void fileBeolvas(string file, List<Karakter> karakterek)
		{
			StreamReader sr = new(file);
			sr.ReadLine();

			while (!sr.EndOfStream)
			{
				string sor = sr.ReadLine();
				string[] szavak = sor.Split(";");

				Karakter karakter = new(szavak[0], Convert.ToInt16(szavak[1]), Convert.ToInt16(szavak[2]), Convert.ToInt16(szavak[3]));
				karakterek.Add(karakter);
			}


		}

		static void atlagosSzint(List<Karakter> karakterek)
		{
			double atlag = 0;
			int count = 0;
			for(int i = 0; i < karakterek.Count; i++)
			{
				count += karakterek[i].Szint;
				
			}	
			atlag = count / karakterek.Count;
			Console.WriteLine(atlag);

		}
		static void legmagasabbEletero(List<Karakter> karakterek)
		{
			Karakter legtobbElet = karakterek[0];
			for (int i = 0;i < karakterek.Count;i++)
			{
				

				if (karakterek[i].Eletero > legtobbElet.Eletero)
				{
					legtobbElet = karakterek[i];
				}
			
			}
			

			Console.WriteLine("Legtobb elettel rendelkezo karakter: " + legtobbElet);
		}

		static void erossegMeghaladja(List<Karakter> karakterek)
		{
			for (int i = 0;i < karakterek.Count ; i++)
			{
				if (karakterek[i].Ero > 50)
				{
					Console.WriteLine("true");
				}
				else
				{
					Console.WriteLine("false");
				}
			}
		}

		static void karakterStat(List<Karakter> karakterek, int szintLimit)
		{
			for(int i = 0; i < karakterek.Count; i++)
			{
				Karakter adat = karakterek[i];
				if (karakterek[i].Szint > szintLimit)
				{
					Console.WriteLine("Magasabb szint a limitnel: " + adat);
				}
			}
		}

		static void adatMentes(List<Karakter> karakterek)
		{
			for (int i = 0; i < karakterek.Count; i++)
			{
				Karakter item = karakterek[i];
				
				File.WriteAllText("./karakterekWrite.csv", item.ToString());
			}
				
			
			
		}




		
		
	}
}
