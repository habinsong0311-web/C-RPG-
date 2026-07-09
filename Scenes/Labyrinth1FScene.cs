using ConsoleGameFramework.Core;
using ConsoleGameFramework.Models;
using ConsoleGameFramework.UI;
using System.Text;
using static ConsoleGameFramework.Models.MapTileType;

public class Labyrinth1FScene : SceneBase
{
    public override SceneKey Key => SceneKey.Labyrinth1FScene;
    private readonly MapTileType[,] originalMap = OriginalLabyrinthMapData.Labyrinth1FMap;
    private MapTileType[,] Labyrinth1FSceneMap;

    public Labyrinth1FScene()
    {
        Labyrinth1FSceneMap = (MapTileType[,])originalMap.Clone();
    }

    public override void Enter(GameContext context)
    {
        if (context.IsMonsterDefeated && context.BattleMapKey == Key)
        {
            Labyrinth1FSceneMap[context.BattleMonsterY, context.BattleMonsterX] = floor;
            context.IsMonsterDefeated = false;
        }
    }

    private int playerX = 2;
    private int playerY = 18;
    public override void Render(GameContext context)
    {
        Console.Clear();
        ConsoleUI.WriteTitle("미궁1층");
        MapRenderer.PrintMap(Labyrinth1FSceneMap, playerY, playerX);
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
        if (moveY >= Labyrinth1FSceneMap.GetLength(0)) moveY -= 1;
        if (moveX >= Labyrinth1FSceneMap.GetLength(1)) moveX -= 1;
        else if (key.Key == ConsoleKey.X)
        {
            context.Game.PushScene(SceneKey.MainMenu);
            return;
        }
        if (Labyrinth1FSceneMap[moveY, moveX] == slime)
        {
            context.BattleMapKey = Key;
            context.BattleMonsterY = moveY;
            context.BattleMonsterX = moveX;

            BattleManager.Instance.StartBattle(new Slime());
            context.Game.PushScene(SceneKey.Battle);
            return;
        }
        else if (Labyrinth1FSceneMap[moveY, moveX] == Down)
        {
            Labyrinth1FSceneMap = (MapTileType[,])originalMap.Clone();
            GoTo(context, SceneKey.Labyrinth2FScene);
        }
        else if (Labyrinth1FSceneMap[moveY, moveX] == Up)
        {
            Labyrinth1FSceneMap = (MapTileType[,])originalMap.Clone();
            GoTo(context, SceneKey.LabyrinthVillage);
        }
        else if (Labyrinth1FSceneMap[moveY, moveX] != wall)
        {
            playerY = moveY;
            playerX = moveX;
        }
    }
}
    

