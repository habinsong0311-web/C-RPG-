using ConsoleGameFramework.Core;
using ConsoleGameFramework.Models;
using ConsoleGameFramework.UI;
using System.Text;
using static ConsoleGameFramework.Models.MapTileType;

public class Labyrinth2FScene : SceneBase
{
    public override SceneKey Key => SceneKey.Labyrinth2FScene;
    private MapTileType[,] Labyrinth2FSceneMap = OriginalLabyrinthMapData.Labyrinth2FMap;
    private int playerX = 7;
    private int playerY = 13;
    public override void Render(GameContext context)
    {
        Console.Clear();
        ConsoleUI.WriteTitle("미궁2층");
        MapRenderer.PrintMap(Labyrinth2FSceneMap, playerY, playerX);
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
        if (moveY >= Labyrinth2FSceneMap.GetLength(0)) moveY -= 1;
        if (moveX >= Labyrinth2FSceneMap.GetLength(1)) moveX -= 1;
        else if (key.Key == ConsoleKey.X)
        {
            context.Game.PushScene(SceneKey.MainMenu);
            return;
        }
        if (Labyrinth2FSceneMap[moveY, moveX] == goblin)
        {
            BattleManager.Instance.StartBattle(new Goblin());
            context.Game.PushScene(SceneKey.Battle);
        }
        else if (Labyrinth2FSceneMap[moveY, moveX] == Down)
        {
            GoTo(context, SceneKey.Labyrinth3FScene);
        }
        else if (Labyrinth2FSceneMap[moveY, moveX] == Up)
        {
            GoTo(context, SceneKey.Labyrinth1FScene);
        }
        else if (Labyrinth2FSceneMap[moveY, moveX] != wall)
        {
            playerY = moveY;
            playerX = moveX;
        }
    }
}
    

