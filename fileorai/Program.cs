namespace fileorai
{
	internal class Program
	{

		static void Main(string[] args)
		{
					 List<Karakter> karakterek = [];

			fileBeolvas("karakterek.txt",karakterek);
			foreach(var item in karakterek)
			{
				Console.WriteLine(item);

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

		
		
	}
}
