
using System;

namespace Colicion_Simple
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Salvador Arturo Ramirez Escamilla");
			
			ScreenColision window = new ScreenColision(600,600);
			window.Run();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}