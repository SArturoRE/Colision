using System;
using System.Drawing;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;


namespace Colicion_Simple
{
	
	public class ScreenColision : GameWindow
	{
		Circulo a;
		Circulo b;
		GameEngine motor;
		double des;
		bool colx;
		
		public ScreenColision(int ancho, int alto) : base(ancho,alto)
		{
		}
		
		protected override void OnLoad(EventArgs e)
		{
			GL.ClearColor(Color.CornflowerBlue);
			a = new Circulo();
			b = new Circulo();
			motor = new GameEngine();
			des = 0.0;
			a.Datos(0,0,0.15);
			b.Datos(0.8,0,0.10);
		}
		
		protected override void OnUpdateFrame(FrameEventArgs e)
		{
			GL.Clear(ClearBufferMask.ColorBufferBit);
		}
		
		protected override void OnRenderFrame(FrameEventArgs e)
		{
			
			a.Dibuja();
			b.Dibuja();
			motor.colisionObj(a,b);
			
			/*if(!colx)
			{
				des += 0.009;
				if(des < 0)
				{
					colx = true;
				}
			}else
			{
				des -= 0.009;
				if(des > 1)
				{
					colx = false;
				}
			}*/
			SwapBuffers();
			
			
		}
	}
}
