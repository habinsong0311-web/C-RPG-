using ConsoleGameFramework.Core;
using ConsoleGameFramework.Models;
using ConsoleGameFramework.UI;
using System.Text;
using static ConsoleGameFramework.Models.MapTileType;

public class Labyrinth7FScene : SceneBase
{
    public override SceneKey Key => SceneKey.Labyrinth7FScene;
    private readonly MapTileType[,] originalMap = OriginalLabyrinthMapData.Labyrinth7FMap;
    private MapTileType[,] Labyrinth7FSceneMap;

    public Labyrinth7FScene()
    {
        Labyrinth7FSceneMap = (MapTileType[,])originalMap.Clone();
    }

    public override void Enter(GameContext context)
    {
        if (context.IsMonsterDefeated && context.BattleMapKey == Key)
        {
            Labyrinth7FSceneMap[context.BattleMonsterY, context.BattleMonsterX] = floor;
            context.IsMonsterDefeated = false;
        }
    }
    private int playerX = 3;
    private int playerY = 18;
    public override void Render(GameContext context)
    {
        Console.Clear();
        ConsoleUI.WriteTitle("미궁7층");
        MapRenderer.PrintMap(Labyrinth7FSceneMap, playerY, playerX);
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
        if (moveY >= Labyrinth7FSceneMap.GetLength(0)) moveY -= 1;
        if (moveX >= Labyrinth7FSceneMap.GetLength(1)) moveX -= 1;
        else if (key.Key == ConsoleKey.X)
        {
            context.Game.PushScene(SceneKey.MainMenu);
            return;
        }
        if (Labyrinth7FSceneMap[moveY, moveX] == orc)
        {
            context.BattleMapKey = Key;
            context.BattleMonsterY = moveY;
            context.BattleMonsterX = moveX;
            BattleManager.Instance.StartBattle(new Orc());
            context.Game.PushScene(SceneKey.Battle);
            return;
        }
        else if (Labyrinth7FSceneMap[moveY, moveX] == Down)
        {
            Labyrinth7FSceneMap = (MapTileType[,])originalMap.Clone();
            GoTo(context, SceneKey.Labyrinth8FScene);
        }
        else if (Labyrinth7FSceneMap[moveY, moveX] == Up)
        {
            Labyrinth7FSceneMap = (MapTileType[,])originalMap.Clone();
            GoTo(context, SceneKey.Labyrinth6FScene);
        }
        else if (Labyrinth7FSceneMap[moveY, moveX] != wall)
        {
            playerY = moveY;
            playerX = moveX;
        }
    }
}
    

