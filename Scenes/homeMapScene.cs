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
        { wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall },
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
        if (moveY < 0) moveY = 0;
        if (moveX < 0) moveX = 0;
        if (moveY > playerHomeMap.GetLength(0)) moveY -= 1;
        if (moveX >= playerHomeMap.GetLength(1)) moveX -= 1;
        else if (key.Key == ConsoleKey.X)
        {
            context.Game.PushScene(SceneKey.MainMenu);
            return;
        }
        if (playerHomeMap[moveY, moveX] == door)
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


