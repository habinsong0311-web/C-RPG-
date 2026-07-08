using ConsoleGameFramework.Core;
using ConsoleGameFramework.Models;
using ConsoleGameFramework.UI;
using System.Text;
using static ConsoleGameFramework.Models.MapTileType;

public class Labyrinth8FScene : SceneBase
{
    public override SceneKey Key => SceneKey.Labyrinth8FScene;
    private MapTileType[,] Labyrinth8FSceneMap = OriginalLabyrinthMapData.Labyrinth8FMap;
    private int playerX = 7;
    private int playerY = 13;
    public override void Render(GameContext context)
    {
        Console.Clear();
        ConsoleUI.WriteTitle("미궁8층");
        MapRenderer.PrintMap(Labyrinth8FSceneMap, playerY, playerX);
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
        if (moveY >= Labyrinth8FSceneMap.GetLength(0)) moveY -= 1;
        if (moveX >= Labyrinth8FSceneMap.GetLength(1)) moveX -= 1;
        else if (key.Key == ConsoleKey.X)
        {
            context.Game.PushScene(SceneKey.MainMenu);
            return;
        }
        if (Labyrinth8FSceneMap[moveY, moveX] == gargoyle)
        {
            BattleManager.Instance.StartBattle(new Gargoyle());
            context.Game.PushScene(SceneKey.Battle);
        }
        else if (Labyrinth8FSceneMap[moveY, moveX] == Down)
        {
            GoTo(context, SceneKey.Labyrinth9FScene);
        }
        else if (Labyrinth8FSceneMap[moveY, moveX] == Up)
        {
            GoTo(context, SceneKey.Labyrinth7FScene);
        }
        else if (Labyrinth8FSceneMap[moveY, moveX] != wall)
        {
            playerY = moveY;
            playerX = moveX;
        }
    }
}
    

