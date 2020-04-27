using System;
using OpenTK.Graphics.OpenGL;


namespace Colicion_Simple.Properties
{
	/// <summary>
	/// Description of circulo.
	/// </summary>
	public class circulo
	{
		double x,y,r;
		
		public circulo()
		{
			x = y = r = 0.0;
		}
		
		public void dibujar(double centrox, double centroy, double radio)
		{
			x = centrox;
			y = centroy; 
			r = radio;
			
			GL.Begin(PrimitiveType.LineLoop);
			for(double i = 0.0; i<Math.PI*2;i+=0.01)
			{
				
			}
		}
	}
}
