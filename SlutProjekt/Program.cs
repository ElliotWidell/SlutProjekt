using System;
using Raylib_cs;
using System.Collections.Generic;


namespace SlutProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerX = 600;
            int playerY = 400;
            int enemyX = 100;
            int enemyY = 300;

            Raylib.InitWindow(1200, 800, "Zombie survival");
            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.SetTargetFPS(60);
                Raylib.DrawRectangle(0, 0, 1200, 800, Color.GREEN);


                map();
                //player();
                if (Raylib.IsKeyDown(KeyboardKey.KEY_D))
                {
                    playerX += 4;
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_W))
                {
                    playerY -= 4;
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_S))
                {
                    playerY += 4;
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_A))
                {
                    playerX -= 4;
                }

                Raylib.DrawCircle(playerX, playerY, 30, Color.BLUE);
                Raylib.DrawCircle(enemyX, enemyY, 30, Color.RED);



                Raylib.EndDrawing();
            }

        }
        static void player()
        {
            // int playerX = 600;
            // int playerY = 400;



            //Raylib.DrawCircle(playerX, playerY, 30, Color.BLUE);



        }

        static void map()
        {
            Raylib.DrawRectangle(0, 0, 1200, 800, Color.GREEN);



        }

        static void enemy()
        {


        }
    }
}
