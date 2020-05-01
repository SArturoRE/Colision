
using System;

namespace Colicion_Simple
{
	
	public class GameEngine
	{
		double despx; //despy;
		
		public GameEngine()
		{
		}
		
		public void colisionObj(Circulo a, Circulo[] b)
		{
			MyVector colision = new MyVector();
			
			for(int i=0 ; i < b.Length; i++)
			{
				if(!a.checcol)
				{
					despx += 0.009;
					a.X = despx;
					colision.CalculaDisCir(a,b[i]);
					
					if(colision.Vd < 0)
					{
						a.checcol = true;
					}
				}else
				{
					despx -= 0.009;
					a.X = despx;
					colision.CalculaDisCir(a,b[i]);
					
					if(colision.Vd < 0)
					{
						a.checcol = false;
					}
				}
			}
		}
	}
}
