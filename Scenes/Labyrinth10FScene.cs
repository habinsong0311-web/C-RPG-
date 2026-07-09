using ConsoleGameFramework.Core;
using ConsoleGameFramework.Models;
using ConsoleGameFramework.UI;
using System.Text;
using static ConsoleGameFramework.Models.MapTileType;

public class Labyrinth10FScene : SceneBase
{
    public override SceneKey Key => SceneKey.Labyrinth10FScene;
    private readonly MapTileType[,] originalMap = OriginalLabyrinthMapData.Labyrinth10FMap;
    private MapTileType[,] Labyrinth10FSceneMap;

    public Labyrinth10FScene()
    {
        Labyrinth10FSceneMap = (MapTileType[,])originalMap.Clone();
    }

    public override void Enter(GameContext context)
    {
        if (context.IsMonsterDefeated && context.BattleMapKey == Key)
        {
            Labyrinth10FSceneMap[context.BattleMonsterY, context.BattleMonsterX] = floor;
            context.IsMonsterDefeated = false;
        }
    }
    private int playerX = 5;
    private int playerY = 9;
    public override void Render(GameContext context)
    {
        Console.Clear();
        ConsoleUI.WriteTitle("미궁10층");
        MapRenderer.PrintMap(Labyrinth10FSceneMap, playerY, playerX);
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
        if (moveY >= Labyrinth10FSceneMap.GetLength(0)) moveY -= 1;
        if (moveX >= Labyrinth10FSceneMap.GetLength(1)) moveX -= 1;
        else if (key.Key == ConsoleKey.X)
        {
            context.Game.PushScene(SceneKey.MainMenu);
            return;
        }
        if (Labyrinth10FSceneMap[moveY, moveX] == gatekeeperGolem)
        {
            context.BattleMapKey = Key;
            context.BattleMonsterY = moveY;
            context.BattleMonsterX = moveX;
            BattleManager.Instance.StartBattle(new GatekeeperGolem());
            context.Game.PushScene(SceneKey.Battle);
            return;
        }
        else if (Labyrinth10FSceneMap[moveY, moveX] == Up)
        {
            Labyrinth10FSceneMap = (MapTileType[,])originalMap.Clone();
            GoTo(context, SceneKey.Labyrinth9FScene);
        }
        else if (Labyrinth10FSceneMap[moveY, moveX] != wall)
        {
            playerY = moveY;
            playerX = moveX;
        }
    }
}
    

