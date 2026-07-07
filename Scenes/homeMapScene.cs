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
        {wall,wall,wall,wall,wall,wall,wall,wall,wall,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,door },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,wall,wall,wall,wall,wall,wall,wall,wall,wall },
        };
    private int playerX = 1;
    private int playerY = 1;

    public override void Render(GameContext context)
    {
        Console.Clear();
        ConsoleUI.WriteTitle("플레이어의 집");
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
          
        else if (key.Key == ConsoleKey.X) Menu.Push(SceneKey.MainMenu);
        if (playerHomeMap[moveY, moveX] != wall)
        {
            playerY = moveY;
            playerX = moveX;
        }



    }




}



