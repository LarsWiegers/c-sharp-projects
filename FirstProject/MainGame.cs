﻿// C# example program to demonstrate OpenTK
//
// Steps:
// 1.0f. Create an empty C# console application project in Visual Studio
// 2. Place OpenTK.dll in the directory of the C# source file
// 3. Add System.Drawing and OpenTK as References to the project
// 4. Paste this source code into the C# source file
// 5. Run. You should see a colored triangle. Press ESC to quit.
//
// Copyright (c) 201.0f3 Ashwin Nanjappa
// Released under the MIT License

using System;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;

namespace StarterKit
{
    class Game : GameWindow
    {
        private float zoff;
        private double xrot;
        private double zrot;
        private double yrot;

        public Game()
            : base(800, 600, GraphicsMode.Default, "OpenTK Quick Start Sample")
        {
            VSync = VSyncMode.On;
            zoff = 1.0f;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            GL.ClearColor(0.1f, 0.2f, 0.5f, 0.0f);
            GL.Enable(EnableCap.DepthTest);
            
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            GL.Viewport(ClientRectangle.X, ClientRectangle.Y, ClientRectangle.Width, ClientRectangle.Height);

            Matrix4 projection = Matrix4.CreatePerspectiveFieldOfView((float)Math.PI / 4, Width / (float)Height, 0.1f, 64.0f);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix(ref projection);
        }
        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);

            if (Keyboard[Key.Escape])
                Exit();
        }
        protected override void OnRenderFrame(FrameEventArgs e)
        {
            base.OnRenderFrame(e);

            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            Matrix4 modelview = Matrix4.LookAt(Vector3.Zero, Vector3.UnitZ, Vector3.UnitY);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadMatrix(ref modelview);
            GL.Translate(0f, 0.0f, 8.0f);
            GL.Rotate(xrot += 0.5, 1, 0, 0); //rotate on x
            GL.Rotate(yrot += 0.3, 0, 1, 0); //rotate on y
            GL.Rotate(zrot += 0.2, 0, 0, 1); //rotate on z

            //face 1
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(1.0f, 0, 1.0f);
            GL.Vertex3(1.0f, 1.0f, -1.0f);
            GL.Vertex3(1.0f, -1.0f, -1.0f);
            GL.Vertex3(-1.0f, -1.0f, -1.0f);
            GL.Vertex3(-1.0f, 1.0f, -1.0f);
            GL.End();

            //face 2
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(0, 1.0f, 1.0f);
            GL.Vertex3(-1.0f, -1.0f, -1.0f);
            GL.Vertex3(1.0f, -1.0f, -1.0f);
            GL.Vertex3(1.0f, -1.0f, 1.0f);
            GL.Vertex3(-1.0f, -1.0f, 1.0f);
            GL.End();

            //face 3
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(1.0f, 1.0f, 0);
            GL.Vertex3(-1.0f, 1.0f, -1.0f);
            GL.Vertex3(-1.0f, -1.0f, -1.0f);
            GL.Vertex3(-1.0f, -1.0f, 1.0f);
            GL.Vertex3(-1.0f, 1.0f, 1.0f);
            GL.End();

            //face 4
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(0, 0, 1.0f);
            GL.Vertex3(1.0f, 1.0f, 1.0f);
            GL.Vertex3(1.0f, -1.0f, 1.0f);
            GL.Vertex3(1.0f, -1.0f, -1.0f);
            GL.Vertex3(1.0f, 1.0f, -1.0f);
            GL.End();

            //face 5
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(0, 1.0f, 0);
            GL.Vertex3(-1.0f, 1.0f, -1.0f);
            GL.Vertex3(-1.0f, 1.0f, 1.0f);
            GL.Vertex3(1.0f, 1.0f, 1.0f);
            GL.Vertex3(1.0f, 1.0f, -1.0f);
            GL.End();

            //face 6
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(255.0f, 0.0f, 0.0f);
            GL.Vertex3(-1.0f, 1.0f, 1.0f);
            GL.Vertex3(-1.0f, -1.0f, 1.0f);
            GL.Vertex3(1.0f, -1.0f, 1.0f);
            GL.Vertex3(1.0f, 1.0f, 1.0f);
            GL.End();


            //GL.Begin(PrimitiveType.Quads);

            //zoff += 0.001.0f;
            // front
            //GL.Color3(1.0f, 1.0f.0f, 0.0f); GL.Vertex3(0.0f        ,  0.0f     , zoff + 4.0f);
            //GL.Color3(1.0f, 0.0f, 0.0f); GL.Vertex3(1.0f.0f        ,  0.0f     , zoff + 4.0f);
            //GL.Color3(0.2f, 0.9f, 1.0f); GL.Vertex3(1.0f.0f        ,  1.0f     , zoff + 4.0f);
            //GL.Color3(0.2f, 0.9f, 1.0f); GL.Vertex3(0.0f           ,  1.0f     , zoff + 4.0f);

            // right
            //GL.Color3(1.0f, 1.0f, 0.0f); GL.Vertex3(1.0f        , 0.0f      , zoff + 4.0f);
            //GL.Color3(1.0f, 0.0f, 0.0f); GL.Vertex3(2.0f        , 0.0f      , zoff + 4.0f);
            //GL.Color3(0.2f, 0.9f, 1.0f); GL.Vertex3(2.0f        , 1.0f      , zoff + 4.0f);
            //GL.Color3(0.2f, 0.9f, 1.0f); GL.Vertex3(1.0f        , 1.0f      , zoff + 4.0f);

           //GL.End();

            SwapBuffers();
        }

        [STAThread]
        static void Main()
        {
            // The 'using' idiom guarantees proper resource cleanup.
            // We request 30 UpdateFrame events per second, and unlimited
            // RenderFrame events (as fast as the computer can handle).
            using (Game game = new Game())
            {
                game.Run(60.0);
            }
        }
    }
}