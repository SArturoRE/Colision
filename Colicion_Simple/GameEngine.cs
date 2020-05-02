
using System;

namespace Colicion_Simple
{
	
	public class GameEngine
	{
		double despx = 0.0;
		double despy = 0.0;
		byte[] verde = {0x00, 0xFF, 0xFF};
        byte[] blanco = {0xFF, 0xFF, 0xFF};
		
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
						//b[i].colorcirculo(verde);
					}
					
					
					//Movimiento en y
					if(!a.ColY)
					{
						despy += 0.0009;
						a.Y = despy;
						
						if(colision.Vd < 0)
						{
							a.ColY = true;
						}
					}else
					{
						despy -= 0.0009;
						a.Y = despy;
						if(despy < -0.8)
						{
							a.ColY = false;
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
						b[i].colorcirculo(blanco);
					}
					b[i].colorcirculo(blanco);
					//Movimiento en y
					if(!a.ColY)
					{
						despy += 0.001;
						a.Y = despy;
						if(colision.Vd < 0)
						{
							a.ColY = true;
						}
					}else
					{
						despy -= 0.001;
						a.Y = despy;
						if(colision.Vd < 0)
						{
							a.ColY = false;
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
