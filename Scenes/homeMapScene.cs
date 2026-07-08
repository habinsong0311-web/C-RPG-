using ConsoleGameFramework.Core;
using ConsoleGameFramework.Models;
using ConsoleGameFramework.UI;
using System.Text;
using static ConsoleGameFramework.Models.MapTileType;

public class playerHomeMapScene : SceneBase
{
    public override SceneKey Key => SceneKey.playerHomeMap;

    private MapTileType[,] playerHomeMap =
        {
        { fenceB,fenceB,fenceB,fenceB,fenceB,fenceB,fenceB,fenceB,fenceB,fenceB,fenceB,fenceB,fenceB,fenceB,fenceB },
        { wall,floor,floor,floor,wall,floor,floor,wall,wall,wall,wall,wall,wall,wall,wall },
        { wall,floor,floor,floor,wall,floor,floor,wall,wall,wall,wall,wall,wall,wall,wall },
        { wall,floor,floor,floor,floor,floor,floor,wall,wall,wall,wall,wall,wall,wall,wall },
        { wall,floor,floor,floor,wall,floor,floor,wall,wall,wall,wall,wall,wall,wall,wall },
        { wall,wall,wall,wall,wall,floor,floor,wall,wall,wall,wall,wall,wall,wall,wall },
        { wall,floor,floor,floor,wall,floor,floor,wall,wall,wall,wall,wall,wall,wall,wall },
        { wall,floor,floor,floor,wall,floor,floor,wall,wall,wall,wall,wall,wall,wall,wall },
        { wall,floor,floor,floor,floor,floor,floor,wall,wall,wall,wall,wall,wall,wall,wall },
        { wall,floor,floor,floor,wall,floor,floor,wall,wall,wall,wall,wall,wall,wall,wall },
        { wall,wall,wall,wall,wall,floor,floor,floor,floor,floor,fenceA,floor,floor,floor,wall },
        { wall,floor,floor,floor,wall,floor,floor,floor,floor,floor,fenceA,floor,floor,floor,wall },
        { wall,floor,floor,floor,wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        { wall,floor,floor,floor,floor,floor,floor,floor,floor,floor ,fenceA,floor,floor,floor,wall},
        { wall,floor,floor,floor,wall,floor,floor,floor,floor,floor,fenceA,floor,floor,floor,wall },
        { wall,wall,wall,wall,wall,wall,door,door,wall,wall,wall,wall,wall,wall,wall },
        };
    private int playerX = 2;
    private int playerY = 1;

    public override void Render(GameContext context)
    {
        Console.Clear();
        ConsoleUI.WriteTitle("여관");
        MapRenderer.PrintMap(playerHomeMap, playerY, playerX);
    }
    public override void HandleInput(GameContext context)
    {
        ConsoleKeyInfo key = Console.ReadKey();
        int moveY = playerY;
        int moveX = playerX;
        if (key.Key == ConsoleKey.UpArrow) moveY--;
        else if (key.Key == ConsoleKey.DownArrow) moveY++;
        else if (key.Key == ConsoleKey.LeftArrow) moveX--;
        else if (key.Key == ConsoleKey.RightArrow) moveX++;
        //else if (key.Key == ConsoleKey.X) GoTo(context, SceneKey.MainMenu);
        else if (key.Key == ConsoleKey.X)
        {
            context.Game.PushScene(SceneKey.MainMenu);
            return;
        }
        if(playerHomeMap[moveY, moveX] == door)
        {
            GoTo(context, SceneKey.LabyrinthVillage);
        }
        else if (playerHomeMap[moveY, moveX] != wall)
        {
            playerY = moveY;
            playerX = moveX;
        }



    }





}
//{
//    { wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall },
//        { wall,floor,floor,floor,wall,floor,floor,wall,wall,wall,wall,wall,wall,wall,wall },
//        { wall,floor,floor,floor,wall,floor,floor,wall,wall,wall,wall,wall,wall,wall,wall },
//        { wall,floor,floor,floor,floor,floor,floor,wall,wall,wall,wall,wall,wall,wall,wall },
//        { wall,floor,floor,floor,wall,floor,floor,wall,wall,wall,wall,wall,wall,wall,wall },
//        { wall,wall,wall,wall,wall,floor,floor,wall,wall,wall,wall,wall,wall,wall,wall },
//        { wall,floor,floor,floor,wall,floor,floor,wall,wall,wall,wall,wall,wall,wall,wall },
//        { wall,floor,floor,floor,wall,floor,floor,wall,wall,wall,wall,wall,wall,wall,wall },
//        { wall,floor,floor,floor,floor,floor,floor,wall,wall,wall,wall,wall,wall,wall,wall },
//        { wall,floor,floor,floor,wall,floor,floor,wall,wall,wall,wall,wall,wall,wall,wall },
//        { wall,wall,wall,wall,wall,floor,floor,floor,floor,floor,fenceA,floor,floor,floor,wall },
//        { wall,floor,floor,floor,wall,floor,floor,floor,floor,floor,fenceA,floor,floor,floor,wall },
//        { wall,floor,floor,floor,wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
//        { wall,floor,floor,floor,floor,floor,floor,floor,floor,floor ,fenceA,floor,floor,floor,wall},
//        { wall,floor,floor,floor,wall,floor,floor,floor,floor,floor,fenceA,floor,floor,floor,wall },
//        { wall,wall,wall,wall,wall,floor,floor,floor,floor,wall,wall,wall,wall,wall,wall },
//        }
//;


