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
		Circulo[] b;
		GameEngine motor;
		
		public ScreenColision(int ancho, int alto) : base(ancho,alto)
		{
		}
		
		protected override void OnLoad(EventArgs e)
		{
			GL.ClearColor(Color.CornflowerBlue);
			a = new Circulo();
			b = new Circulo[2];
			
			b[0] = new Circulo();	
			b[1] = new Circulo();
			
			
			motor = new GameEngine();
			
			
			a.Datos(0,0,0.1);
			b[0].Dibuja(0.8,0,0.1);
			b[1].Dibuja(-0.8,0,0.1);
			
		}
		
		protected override void OnUpdateFrame(FrameEventArgs e)
		{
			GL.Clear(ClearBufferMask.ColorBufferBit);
		}
		
		protected override void OnRenderFrame(FrameEventArgs e)
		{
			
			a.Dibuja();
			b[0].Dibuja();
			//b[1].Dibuja();
			b[1].Dibuja();
			motor.colisionObj(a,b);
			
			SwapBuffers();
			
			
		}
	}
}
