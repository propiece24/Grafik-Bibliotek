using System;
using Raylib_cs;

namespace Grafik
{
    class Program
    {
        static void Main(string[] args)
        {
            
         Raylib.InitWindow(800, 600, "Hello Te");

         Color myColor = new Color(0, 255, 128, 255);

         float x = 0;
         float y = 0;
         
        while(!Raylib.WindowShouldClose())
        {

            if(Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
            {
                x += .1f;
            }
            if(Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
            {
                 x -= .1f;
            }
            if(Raylib.IsKeyDown(KeyboardKey.KEY_DOWN))
            {
               y += .1f;
            }
            if(Raylib.IsKeyDown(KeyboardKey.KEY_UP))
            {
               y -= .1f;
            }
           
         
         Raylib.BeginDrawing();

         Raylib.ClearBackground(myColor);

         Raylib.DrawRectangle((int)x,(int)y, 20, 20, Color.PINK);

         Console.WriteLine();

         Raylib.EndDrawing();

        }




        }
    }
}
