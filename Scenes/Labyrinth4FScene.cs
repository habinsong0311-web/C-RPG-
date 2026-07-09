using ConsoleGameFramework.Core;
using ConsoleGameFramework.Models;
using ConsoleGameFramework.UI;
using System.Text;
using static ConsoleGameFramework.Models.MapTileType;

public class Labyrinth4FScene : SceneBase
{
    public override SceneKey Key => SceneKey.Labyrinth4FScene;
    private readonly MapTileType[,] originalMap = OriginalLabyrinthMapData.Labyrinth4FMap;
    private MapTileType[,] Labyrinth4FSceneMap;

    public Labyrinth4FScene()
    {
        Labyrinth4FSceneMap = (MapTileType[,])originalMap.Clone();
    }

    public override void Enter(GameContext context)
    {
        if (context.IsMonsterDefeated && context.BattleMapKey == Key)
        {
            Labyrinth4FSceneMap[context.BattleMonsterY, context.BattleMonsterX] = floor;
            context.IsMonsterDefeated = false;
        }
    }
    private int playerX = 3;
    private int playerY = 18;
    public override void Render(GameContext context)
    {
        Console.Clear();
        ConsoleUI.WriteTitle("미궁4층");
        MapRenderer.PrintMap(Labyrinth4FSceneMap, playerY, playerX);
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
        if (moveY >= Labyrinth4FSceneMap.GetLength(0)) moveY -= 1;
        if (moveX >= Labyrinth4FSceneMap.GetLength(1)) moveX -= 1;
        else if (key.Key == ConsoleKey.X)
        {
            context.Game.PushScene(SceneKey.MainMenu);
            return;
        }
        if (Labyrinth4FSceneMap[moveY, moveX] == goblinMage)
        {
            context.BattleMapKey = Key;
            context.BattleMonsterY = moveY;
            context.BattleMonsterX = moveX;

            BattleManager.Instance.StartBattle(new GoblinMage());
            context.Game.PushScene(SceneKey.Battle);
            return;
        }
        else if (Labyrinth4FSceneMap[moveY, moveX] == Down)
        {
            Labyrinth4FSceneMap = (MapTileType[,])originalMap.Clone();
            GoTo(context, SceneKey.Labyrinth5FScene);
        }
        else if (Labyrinth4FSceneMap[moveY, moveX] == Up)
        {
            Labyrinth4FSceneMap = (MapTileType[,])originalMap.Clone();
            GoTo(context, SceneKey.Labyrinth3FScene);
        }
        else if (Labyrinth4FSceneMap[moveY, moveX] != wall)
        {
            playerY = moveY;
            playerX = moveX;
        }
    }
}
    

