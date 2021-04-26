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
            int playerHP = 3;
            float damageTimer = 0;


            //enemy.X;


            Vector2 enemyVec = new Vector2(enemyX, enemyY);


            Raylib.InitWindow(1200, 800, "Zombie survival");
            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.SetTargetFPS(60);



                map();
                player(playerX, playerY);
                enemy(enemyVec);




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




                Vector2 playerVec = new Vector2(playerX, playerY);
                Vector2 difference = playerVec - enemyVec;
                difference = Vector2.Normalize(difference);
                enemyVec += difference * 1.5f;


                playerHP = health(playerVec, enemyVec, playerHP, damageTimer);













                Raylib.EndDrawing();
            }

        }
        static void player(int playerX, int playerY)
        {

            Raylib.DrawRectangle(playerX - 8, playerY - 60, 15, 50, Color.GRAY);
            Raylib.DrawCircle(playerX, playerY, 33, Color.BLUE);
            Raylib.DrawCircle(playerX + 12, playerY - 13, 10, Color.WHITE);
            Raylib.DrawCircle(playerX - 12, playerY - 13, 10, Color.WHITE);
            Raylib.DrawCircle(playerX + 12, playerY - 16, 5, Color.BLACK);
            Raylib.DrawCircle(playerX - 12, playerY - 16, 5, Color.BLACK);





        }

        static void map()
        {
            Raylib.DrawRectangle(0, 0, 1200, 800, Color.DARKGREEN);



        }

        static void enemy(Vector2 enemy)
        {

            Raylib.DrawRectangle((int)enemy.X + 10, (int)enemy.Y - 50, 10, 35, Color.GREEN);
            Raylib.DrawRectangle((int)enemy.X - 20, (int)enemy.Y - 50, 10, 35, Color.GREEN);
            Raylib.DrawCircle((int)enemy.X, (int)enemy.Y, 30, Color.GREEN);
            Raylib.DrawCircle((int)enemy.X + 12, (int)enemy.Y - 13, 10, Color.WHITE);
            Raylib.DrawCircle((int)enemy.X - 12, (int)enemy.Y - 13, 10, Color.WHITE);
            Raylib.DrawCircle((int)enemy.X + 12, (int)enemy.Y - 16, 5, Color.RED);
            Raylib.DrawCircle((int)enemy.X - 12, (int)enemy.Y - 16, 5, Color.RED);


        }

        static int health(Vector2 playerVec, Vector2 enemyVec, int playerHP, float damageTimer)
        {

            bool areOverlapping = Raylib.CheckCollisionCircles(playerVec, 33, enemyVec, 30);





            if (areOverlapping && damageTimer == 0)
            {
                playerHP = -1;

                damageTimer += Raylib.GetFrameTime();



            }


            if (damageTimer >= 20000)
            {
                damageTimer = 0;
            }



            if (playerHP <= 0)
            {
                Raylib.DrawRectangle(0, 0, 1200, 800, Color.RED);






            }

            if (playerHP == 2)
            {
                Raylib.DrawRectangle(0, 0, 1200, 800, Color.YELLOW);






            }

            return playerHP;


        }
    }
}
