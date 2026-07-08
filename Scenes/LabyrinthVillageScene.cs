using ConsoleGameFramework.Core;
using ConsoleGameFramework.Models;
using ConsoleGameFramework.UI;
using System.Text;
using static ConsoleGameFramework.Models.MapTileType;

public class LabyrinthVillageScene : SceneBase
{
    public override SceneKey Key => SceneKey.LabyrinthVillage;
    private MapTileType[,] LabyrinthVillageMap =
    {
        { wall,wall,wall,wall,wall,wall,wall,LabyrinthIngress,wall,wall,wall,wall,wall,wall,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,wall,wall,wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,door,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        { wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall },
    };
    private int playerX = 4;
    private int playerY = 11;
    public override void Render(GameContext context)
    {
        Console.Clear();
        ConsoleUI.WriteTitle("미궁마을");
        MapRenderer.PrintMap(LabyrinthVillageMap, playerY, playerX);
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
        else if (key.Key == ConsoleKey.X)
        {
            context.Game.PushScene(SceneKey.MainMenu);
            return;
        }
        if (LabyrinthVillageMap[moveY, moveX] == door)
        {
            GoTo(context, SceneKey.playerHomeMap);
        }
        else if (LabyrinthVillageMap[moveY, moveX] == LabyrinthIngress)
        {

        }
        else if (LabyrinthVillageMap[moveY, moveX] != wall)
        {
            playerY = moveY;
            playerX = moveX;
        }
    }
}
