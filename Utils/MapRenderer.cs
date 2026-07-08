using ConsoleGameFramework.Models;
using System;
using static ConsoleGameFramework.Models.MapTileType;
public class MapRenderer
{
    public static void PrintMap(MapTileType[,] map, int playerY, int playerX)
    {

        for (int Y = 0; Y < map.GetLength(0); Y++)
        {
            for (int X = 0; X < map.GetLength(1); X++)
            {
                if (Y == playerY && X == playerX)
                {
                    Console.Write("P");
                }
                else
                {
                    switch (map[Y, X])
                    {
                        case wall:
                            Console.Write("▣");
                            break;
                        case floor:
                            Console.Write(" ");
                            break;
                        case door:
                            Console.Write("▥");
                            break;
                        case bed:
                            Console.Write("▤ ");
                            break;
                        case fenceA:
                            Console.Write("ㅣ");
                            break;
                        case fenceB:
                            Console.Write("ㅡ");
                            break;
                        case LabyrinthIngress:
                            Console.Write("E");
                            break;
                        case Up:
                            Console.Write("U");
                            break;
                        case Down:
                            Console.Write("D");
                            break;
                        case monster:
                        case slime:
                        case goblin:
                        case skeleton:
                        case goblinMage:
                        case hobgoblin:
                        case orc:
                        case gargoyle:
                        case waterSpirit:
                            Console.Write("M");
                            break;
                        case dragon:
                        case littleDevil:
                        case gatekeeperGolem:
                            Console.Write("B");
                            break;

                    }

                }
                
            }
            Console.WriteLine();
        }
    }


}
