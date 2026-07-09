using ConsoleGameFramework.Core;
using ConsoleGameFramework.Models;
using ConsoleGameFramework.UI;
using System.Text;
using static ConsoleGameFramework.Models.MapTileType;

public class Labyrinth6FScene : SceneBase
{
    public override SceneKey Key => SceneKey.Labyrinth6FScene;
    private readonly MapTileType[,] originalMap = OriginalLabyrinthMapData.Labyrinth6FMap;
    private MapTileType[,] Labyrinth6FSceneMap;

    public Labyrinth6FScene()
    {
        Labyrinth6FSceneMap = (MapTileType[,])originalMap.Clone();
    }

    public override void Enter(GameContext context)
    {
        if (context.IsMonsterDefeated && context.BattleMapKey == Key)
        {
            Labyrinth6FSceneMap[context.BattleMonsterY, context.BattleMonsterX] = floor;
            context.IsMonsterDefeated = false;
        }
    }
    private int playerX = 3;
    private int playerY = 18;
    public override void Render(GameContext context)
    {
        Console.Clear();
        ConsoleUI.WriteTitle("미궁6층");
        MapRenderer.PrintMap(Labyrinth6FSceneMap, playerY, playerX);
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
        if (moveY >= Labyrinth6FSceneMap.GetLength(0)) moveY -= 1;
        if (moveX >= Labyrinth6FSceneMap.GetLength(1)) moveX -= 1;
        else if (key.Key == ConsoleKey.X)
        {
            context.Game.PushScene(SceneKey.MainMenu);
            return;
        }
        if (Labyrinth6FSceneMap[moveY, moveX] == hobgoblin)
        {
            context.BattleMapKey = Key;
            context.BattleMonsterY = moveY;
            context.BattleMonsterX = moveX;

            BattleManager.Instance.StartBattle(new Hobgoblin());
            context.Game.PushScene(SceneKey.Battle);
            return;
        }
        else if (Labyrinth6FSceneMap[moveY, moveX] == Down)
        {
            Labyrinth6FSceneMap = (MapTileType[,])originalMap.Clone();
            GoTo(context, SceneKey.Labyrinth7FScene);
        }
        else if (Labyrinth6FSceneMap[moveY, moveX] == Up)
        {
            Labyrinth6FSceneMap = (MapTileType[,])originalMap.Clone();
            GoTo(context, SceneKey.Labyrinth5FScene);
        }
        else if (Labyrinth6FSceneMap[moveY, moveX] != wall)
        {
            playerY = moveY;
            playerX = moveX;
        }
    }
}
    

