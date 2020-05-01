
using System;

namespace Colicion_Simple
{
	
	public class GameEngine
	{
		public GameEngine()
		{
		}
		
		public void colisionObj(Circulo a, Circulo b)
		{
			MyVector colision = new MyVector();
			
			colision.CalculaDisCir(a,b);
			
			if(colision.Vd < 0)
			{
				Console.WriteLine("Colision !!!!");
				a.checcol = true;
			}
		}
	}
}
