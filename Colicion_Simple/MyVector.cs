
using System;

namespace Colicion_Simple
{
	
		
	public class MyVector
	{
		double vx,vy,vd;
		public MyVector()
		{
			vx = vy = vd = 0.0;
		}
		
		public void CalculaDisCir(Circulo a, Circulo b)
		{
			vx = a.X - b.X;
			vy = a.Y - b.Y;
			
			vd = Math.Sqrt((vx * vx) + (vy * vy)) - (a.R + b.R);
		}
		
		public double Vd
		{
			get{ return vd; }
		}
	}
}
