using ConsoleGameFramework.Core;
using ConsoleGameFramework.Models;
using ConsoleGameFramework.UI;
using System.Text;
using static ConsoleGameFramework.Models.MapTileType;

public class Labyrinth9FScene : SceneBase
{
    public override SceneKey Key => SceneKey.Labyrinth9FScene;
    private MapTileType[,] Labyrinth9FSceneMap = OriginalLabyrinthMapData.Labyrinth9FMap;
    private int playerX = 7;
    private int playerY = 13;
    public override void Render(GameContext context)
    {
        Console.Clear();
        ConsoleUI.WriteTitle("미궁9층");
        MapRenderer.PrintMap(Labyrinth9FSceneMap, playerY, playerX);
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
        if (moveY >= Labyrinth9FSceneMap.GetLength(0)) moveY -= 1;
        if (moveX >= Labyrinth9FSceneMap.GetLength(1)) moveX -= 1;
        else if (key.Key == ConsoleKey.X)
        {
            context.Game.PushScene(SceneKey.MainMenu);
            return;
        }
        if (Labyrinth9FSceneMap[moveY, moveX] == waterSpirit)
        {
            BattleManager.Instance.StartBattle(new WaterSpirit());
            context.Game.PushScene(SceneKey.Battle);
        }
        else if (Labyrinth9FSceneMap[moveY, moveX] == Down)
        {
            GoTo(context, SceneKey.Labyrinth10FScene);
        }
        else if (Labyrinth9FSceneMap[moveY, moveX] == Up)
        {
            GoTo(context, SceneKey.Labyrinth8FScene);
        }
        else if (Labyrinth9FSceneMap[moveY, moveX] != wall)
        {
            playerY = moveY;
            playerX = moveX;
        }
    }
}
    

