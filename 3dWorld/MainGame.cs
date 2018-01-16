// C# example program to demonstrate OpenTK
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
using MainGame.components;
using FirstProjectOpenTK.components;
using FirstProjectOpenTK.components.loaders;
using System.Collections.Generic;
using FirstProjectOpenTK.components.World;
using System.Windows.Forms;
using System.Drawing;

namespace MainGame
{
    class Game : GameWindow
    {
        Vector3 _pos;
        World world;
        private bool _lockMouse;
        private MouseState _origCursorPosition;
        private MouseState _lastMousePos;
        private Vector3 _lookDir;
        private float _mouseSensitivity = 0.01f;
        private Matrix4 _viewMat;
        private Vector3 _up = Vector3.UnitY;
        private List<Block> Test;

        public Game()
            : base(800, 600, GraphicsMode.Default, "MineCraft")
        {
            Title += ": OpenGL Version: " + GL.GetString(StringName.Version);
            VSync = VSyncMode.On;
            world = new World();
        }
        
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            GL.ClearColor(0.1f, 0.2f, 0.5f, 0.0f);
            GL.Enable(EnableCap.DepthTest);
            Test = new List<Block>
            {
                new Block( new Vector3(0,0,0) ),
                new Block( new Vector3(0,0,1) ),
                new Block( new Vector3(1,0,0) ),
                new Block( new Vector3(1,0,1) ),
                new Block( new Vector3(2,0,0) ),
                new Block( new Vector3(2,1,1) ),
                new Block( new Vector3(3,0,0) ),
                new Block( new Vector3(3,0,1) ),
            };
            
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            GL.Viewport(ClientRectangle.X, ClientRectangle.Y, ClientRectangle.Width, ClientRectangle.Height);

            Matrix4 projection = Matrix4.CreatePerspectiveFieldOfView((float)Math.PI / 4, Width / (float)Height, 1f, 256.0f);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix(ref projection);
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {

            float moveSpeed = Keyboard[Key.Up] ? 0.9f : 0.4f;

            if (Keyboard[Key.Up])
            {
                _pos.X += (float)Math.Cos(_lookDir.X) * moveSpeed;
                _pos.Z += (float)Math.Sin(_lookDir.X) * moveSpeed;
            }

            if (Keyboard[Key.Left]) // FIXME: holding W + A gives extra speed (also, perhaps strafing should be slower?)
            {
                _pos.X -= (float)Math.Cos(_lookDir.X + Math.PI / 2) * moveSpeed;
                _pos.Z -= (float)Math.Sin(_lookDir.X + Math.PI / 2) * moveSpeed;
            }

            if (Keyboard[Key.Right])
            {
                _pos.X += (float)Math.Cos(_lookDir.X + Math.PI / 2) * moveSpeed;
                _pos.Z += (float)Math.Sin(_lookDir.X + Math.PI / 2) * moveSpeed;
            }

            if (Keyboard[Key.Down])
            {
                _pos.X -= (float)Math.Cos(_lookDir.X) * moveSpeed;
                _pos.Z -= (float)Math.Sin(_lookDir.X) * moveSpeed;
            }

            if (Keyboard[Key.Space])
            {
                _pos.Y += moveSpeed;
            }

            if (Keyboard[Key.ControlLeft])
            {
                _pos.Y -= moveSpeed;
            }

            if(Keyboard[Key.Escape])
            {
                if (_lockMouse) UnlockMouse();
                else Exit();
            }

            if (_lockMouse)
            {
                var x = OpenTK.Input.Mouse.GetCursorState().X - _lastMousePos.X;
                var y = OpenTK.Input.Mouse.GetCursorState().Y - _lastMousePos.Y;
                var mouseDelta = new Point( x , y);
                if (mouseDelta != Point.Empty)
                {
                    _lookDir.X += mouseDelta.X * _mouseSensitivity;
                    _lookDir.Y -= mouseDelta.Y * _mouseSensitivity;
                    ResetCursorPosition();
                }
            }

            var target = _pos + new Vector3((float)Math.Cos(_lookDir.X), (float)Math.Sin(_lookDir.Y / 2), (float)Math.Sin(_lookDir.X));
            _viewMat = Matrix4.LookAt(_pos, target, _up);
        }
        protected override void OnRenderFrame(FrameEventArgs e)
        {
            base.OnRenderFrame(e);

            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadMatrix(ref _viewMat);

            Title = $"(Vsync: {VSync}) FPS: {1f / e.Time:0}";
            world.DisplayTest(Test);

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

        protected override void OnMouseDown(MouseButtonEventArgs e)
        {
            base.OnMouseDown(e);
            if (!_lockMouse) LockMouse();

        }
        protected void ResetCursorPosition()
        {
            OpenTK.Input.Mouse.SetPosition(ClientRectangle.Width / 2, ClientRectangle.Height / 2);
            _lastMousePos = OpenTK.Input.Mouse.GetCursorState();
        }
        protected void LockMouse()
        {
            _lockMouse = true;
            _origCursorPosition = OpenTK.Input.Mouse.GetCursorState();
            CursorVisible = false;
            ResetCursorPosition();
        }
        protected void UnlockMouse()
        {
            _lockMouse = false;
            CursorVisible = true;
            OpenTK.Input.Mouse.SetPosition(_origCursorPosition.X, _origCursorPosition.Y);
        }
    }
}