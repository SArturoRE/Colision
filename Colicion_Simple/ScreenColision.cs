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
			b = new Circulo[10];
			
			b[0] = new Circulo();	
			b[1] = new Circulo();
			b[2] = new Circulo();
			b[3] = new Circulo();
			b[4] = new Circulo();	
			b[5] = new Circulo();
			b[6] = new Circulo();
			b[7] = new Circulo();
			b[8] = new Circulo();		
			b[9] = new Circulo();
			
			motor = new GameEngine();
			
			
			a.Datos(0,0,0.12);
			
			
			b[0].Dibuja(0.8,0.8,0.14);
			b[1].Dibuja(0.8,0.4,0.14);
			b[2].Dibuja(0.8,0.0,0.14);
			b[3].Dibuja(0.8,-0.4,0.14);			
			b[4].Dibuja(0.8,-0.8,0.14);
			
			
			b[5].Dibuja(-0.8,0.8,0.14);
			b[6].Dibuja(-0.8,0.4,0.14);
			b[7].Dibuja(-0.8,0.0,0.14);
			b[8].Dibuja(-0.8,-0.4,0.14);
			b[9].Dibuja(-0.8,-0.8,0.14);
			
		}
		
		protected override void OnUpdateFrame(FrameEventArgs e)
		{
			GL.Clear(ClearBufferMask.ColorBufferBit);
		}
		
		protected override void OnRenderFrame(FrameEventArgs e)
		{
			
			a.Dibuja();
			
			b[0].Dibuja();			
			b[1].Dibuja();
			b[2].Dibuja();
			b[3].Dibuja();			
			b[4].Dibuja();
			
			b[5].Dibuja();
			b[6].Dibuja();
			b[7].Dibuja();
			b[8].Dibuja();
			b[9].Dibuja();
			
			
			motor.colisionObj(a,b);
			
			SwapBuffers();
			
			
		}
	}
}
