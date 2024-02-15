

using System.Diagnostics;

public class Program
{
	public static void Main()
	{
		string n = Console.ReadLine();

		int result = 0;

		int Count = 0;

		if(n.Length < 2)
		{
			Console.WriteLine("0");
			return;
		}

		while (true)
		{
			result = 0;
			for (int i = 0; i < n.Length; i++)
			{
				result = result + int.Parse(n[i].ToString());
			}
			n = result.ToString();	
			Count++;

			if (result <= 9)
			{
				break;
			}

		}
		Console.WriteLine(Count);


		
	
	}
}