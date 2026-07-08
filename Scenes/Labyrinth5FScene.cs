using ConsoleGameFramework.Core;
using ConsoleGameFramework.Models;
using ConsoleGameFramework.UI;
using System.Text;
using static ConsoleGameFramework.Models.MapTileType;

public class Labyrinth5FScene : SceneBase
{
    public override SceneKey Key => SceneKey.Labyrinth5FScene;
    private MapTileType[,] Labyrinth5FSceneMap = OriginalLabyrinthMapData.Labyrinth5FMap;
    private int playerX = 7;
    private int playerY = 13;
    public override void Render(GameContext context)
    {
        Console.Clear();
        ConsoleUI.WriteTitle("미궁5층");
        MapRenderer.PrintMap(Labyrinth5FSceneMap, playerY, playerX);
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
        if (moveY >= Labyrinth5FSceneMap.GetLength(0)) moveY -= 1;
        if (moveX >= Labyrinth5FSceneMap.GetLength(1)) moveX -= 1;
        else if (key.Key == ConsoleKey.X)
        {
            context.Game.PushScene(SceneKey.MainMenu);
            return;
        }
        if (Labyrinth5FSceneMap[moveY, moveX] == littleDevil)
        {
            BattleManager.Instance.StartBattle(new LittleDevil());
            context.Game.PushScene(SceneKey.Battle);
        }
        else if (Labyrinth5FSceneMap[moveY, moveX] == Down)
        {
            GoTo(context, SceneKey.Labyrinth6FScene);
        }
        else if (Labyrinth5FSceneMap[moveY, moveX] == Up)
        {
            GoTo(context, SceneKey.Labyrinth4FScene);
        }
        else if (Labyrinth5FSceneMap[moveY, moveX] != wall)
        {
            playerY = moveY;
            playerX = moveX;
        }
    }
}
    

