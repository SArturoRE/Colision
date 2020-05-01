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
		bool circcol;
		bool colisiony;
		
		public Circulo()
		{
			x = y = r = 0.0;
			circcol = false;
			colisiony = false;
		}
		
		public void Datos(double cx, double cy, double rad)
		{
			x = cx;
			y = cy;
			r = rad;
			
		}
		
		public void Dibuja(double cx, double cy, double rad)
		{
			x = cx;
			y = cy;
			r = rad;
			
			GL.Begin(PrimitiveType.LineLoop);
			//GL.Color3(0.5,0.2,0.9);
			//GL.ClearColor(Color.White);
			for(double i = 0; i < Math.PI*2; i += 0.01)
			{
				GL.Vertex2((x + Math.Cos(i) * r),(y + Math.Sin(i) * r));
			}
			
			GL.End();
		}
		
		public void Dibuja()
		{
			
			GL.Begin(PrimitiveType.LineLoop);
			//GL.Color3(0.5,0.2,0.9);
			//GL.ClearColor(Color.White);
			for(double i = 0; i < Math.PI*2; i += 0.01)
			{
				GL.Vertex2((x + Math.Cos(i) * r),(y + Math.Sin(i) * r));
			}
			
			GL.End();
		}
		
		public double X
		{
			get{return x;}
			set{x = value;}
		}
		
		public double Y
		{
			get{return y;}
			set{y = value;}
		}
		
		public double R
		{
			get {return r;}
			set {r = value;}
		}
		
		public bool checcol
		{
			get { return circcol;}
			set { circcol = value;}
		}
		
		public bool CY
		{
			get{return colisiony;}
			set{colisiony = value;}
		}
	}
}
