﻿using System;
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
		
		bool colx;
		double des;
		public ScreenColision(int ancho, int alto) : base(ancho,alto)
		{
		}
		
		protected override void OnLoad(EventArgs e)
		{
			GL.ClearColor(Color.CornflowerBlue);
			a = new Circulo();
			b = new Circulo();
			colx = false;
			des = 0.0;
		}
		
		protected override void OnUpdateFrame(FrameEventArgs e)
		{
			GL.Clear(ClearBufferMask.ColorBufferBit);
		}
		
		protected override void OnRenderFrame(FrameEventArgs e)
		{
			
			a.Dibuja(des,0,0.15);
			b.Dibuja(1,0,0.10);
			if(!colx)
			{
				des += 0.01;
				if(a.X > 1)
				{
					colx = true;
				}
			}else
			{
				des -= 0.01;
				if(a.X < -1)
				{
					colx = false;
				}
			}
			SwapBuffers();
			
			
		}
	}
}
