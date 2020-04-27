using System;
using System.Drawing;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace Colicion_Simple
{
	public class Circulo
	{
		double x,y,r;
		
		public Circulo()
		{
			x = y = r = 0.0;
		}
		
		public void Dibuja(double cx, double cy, double rad)
		{
			x = cx;
			y = cy;
			r = rad;
			
			GL.Begin(PrimitiveType.LineLoop);
			//GL.Color4(0.0,0.0,0.0);
			for(double i = 0; i < Math.PI*2; i += 0.01)
			{
				GL.Vertex2((x + Math.Cos(i) * r),(y + Math.Sin(i) * r));
			}
			
			GL.End();
		}
		
		public double X
		{
			get{return x;}
		}
		
		public double Y
		{
			get{return y;}
		}
	}
}
