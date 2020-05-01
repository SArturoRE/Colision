
using System;

namespace Colicion_Simple
{
	
	public class GameEngine
	{
		double despx = 0.0;
		double despy = 0.0;
		
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
					despx += 0.001;
					a.X = despx;
					colision.CalculaDisCir(a,b[i]);
					
					if(colision.Vd < 0)
					{
						a.checcol = true;
					}
					
					//Movimiento en y
					if(!a.CY)
					{
						despy += 0.001;
						a.Y = despy;
						if(despy == 0.9)
						{
							a.CY = true;
						}
					}else
					{
						despy -= 0.001;
						a.Y = despy;
						if(despy == -0.9)
						{
							a.CY = false;
						}
					}
					
					
					
					
				}else
				{
					despx -= 0.001;
					a.X = despx;
					colision.CalculaDisCir(a,b[i]);
					
					if(colision.Vd < 0)
					{
						a.checcol = false;
					}
					
					//Movimiento en y
					if(!a.CY)
					{
						despy += 0.001;
						a.Y = despy;
						if(despy < 0.9)
						{
							a.CY = true;
						}
					}else
					{
						despy -= 0.001;
						a.Y = despy;
						if(despy < -0.9)
						{
							a.CY = false;
						}
					}
					
				}
				
				
				
				//Moveremos la vola en Y
				
				/*if(!a.checcol)
				{
					despy += 0.001;
					a.Y = despy;
					colision.CalculaDisCir(a,b[i]);
					
					if(colision.Vd < 0)
					{
						a.checcol = true;
					}
				}else
				{
					despy -= 0.001;
					a.Y = despy;
					colision.CalculaDisCir(a,b[i]);
					
					if(colision.Vd < 0)
					{
						a.checcol = false;
					}
				}
				
			*/	
			}
		}
	}
}
