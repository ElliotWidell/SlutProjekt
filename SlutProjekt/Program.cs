using System;
using System.Collections.Generic;
using Raylib_cs;

namespace SlutProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            Raylib.InitWindow(1200, 800, "Zombie survival");
            Raylib.BeginDrawing();
            map();
            player();


            Console.ReadLine();
            Raylib.EndDrawing();


        }
        static void player()
        {
            int playerX = 600;
            int playerY = 400;
            Raylib.DrawCircle(playerX, playerY, 30, Color.BLUE);



        }

        static void map()
        {
            Raylib.DrawRectangle(0, 0, 1200, 800, Color.GREEN);


        }
    }
}
