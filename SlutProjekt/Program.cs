using System;
using Raylib_cs;
using System.Collections.Generic;
using System.Numerics;


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

            Vector2 player = new Vector2(playerX, playerY);
            Vector2 enemy = new Vector2(enemyX, enemyY);     //flytta ner
            Vector2 difference = enemy - player;
            difference = Vector2.Normalize(difference);
            enemy += difference;
            enemy.X




            Raylib.InitWindow(1200, 800, "Zombie survival");
            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.SetTargetFPS(60);



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






                Raylib.DrawRectangle(playerX - 8, playerY - 60, 15, 50, Color.GRAY);
                Raylib.DrawCircle(playerX, playerY, 33, Color.BLUE);
                Raylib.DrawCircle(playerX + 12, playerY - 13, 10, Color.WHITE);
                Raylib.DrawCircle(playerX - 12, playerY - 13, 10, Color.WHITE);
                Raylib.DrawCircle(playerX + 12, playerY - 16, 5, Color.BLACK);
                Raylib.DrawCircle(playerX - 12, playerY - 16, 5, Color.BLACK);



                Raylib.DrawRectangle(enemyX + 10, enemyY - 50, 10, 35, Color.GREEN);
                Raylib.DrawRectangle(enemyX - 20, enemyY - 50, 10, 35, Color.GREEN);
                Raylib.DrawCircle(enemyX, enemyY, 30, Color.GREEN);
                Raylib.DrawCircle(enemyX + 12, enemyY - 13, 10, Color.WHITE);
                Raylib.DrawCircle(enemyX - 12, enemyY - 13, 10, Color.WHITE);
                Raylib.DrawCircle(enemyX + 12, enemyY - 16, 5, Color.RED);
                Raylib.DrawCircle(enemyX - 12, enemyY - 16, 5, Color.RED);





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
            Raylib.DrawRectangle(0, 0, 1200, 800, Color.DARKGREEN);



        }

        static void enemy()
        {


        }
    }
}
