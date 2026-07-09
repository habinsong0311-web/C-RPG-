using ConsoleGameFramework.Models;
using ConsoleGameFramework.Core;
using ConsoleGameFramework.UI;
using static ConsoleGameFramework.Models.MapTileType;
using System;
public static class OriginalLabyrinthMapData
{
    public static readonly MapTileType[,] Labyrinth1FMap = //1층
    {
    {wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall},
    {wall,floor,floor,floor,floor,floor,floor,floor,wall,wall,floor,floor,floor,floor,floor,floor,slime,Down,floor,wall},
    {wall,floor,floor,floor,floor,floor,floor,floor,wall,wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall},
    {wall,floor,wall,wall,wall,floor,floor,floor,floor,floor,floor,floor,floor,wall,wall,wall,floor,floor,floor,wall},
    {wall,floor,wall,wall,wall,floor,floor,slime,floor,floor,floor,floor,floor,wall,wall,wall,floor,floor,floor,wall},
    {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall},
    {wall,wall,wall,wall,floor,floor,wall,wall,wall,wall,wall,wall,wall,wall,floor,floor,wall,wall,wall,wall},
    {wall,wall,wall,wall,floor,floor,wall,wall,wall,wall,wall,wall,wall,wall,floor,floor,wall,wall,wall,wall},
    {wall,floor,floor,floor,floor,floor,floor,floor,floor,slime,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall},
    {wall,floor,floor,floor,floor,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,floor,floor,floor,floor,wall},
    {wall,floor,floor,floor,floor,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,floor,floor,floor,floor,wall},
    {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall},
    {wall,wall,wall,wall,floor,floor,wall,wall,wall,wall,wall,wall,wall,wall,floor,floor,wall,wall,wall,wall},
    {wall,wall,wall,wall,floor,floor,wall,wall,wall,wall,wall,wall,wall,wall,floor,floor,wall,wall,wall,wall},
    {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,slime,floor,floor,floor,floor,floor,floor,floor,floor,wall},
    {wall,floor,wall,wall,wall,floor,floor,floor,floor,floor,floor,floor,floor,wall,wall,wall,floor,floor,floor,wall},
    {wall,floor,wall,wall,wall,floor,floor,floor,slime,floor,floor,floor,floor,wall,wall,wall,floor,floor,floor,wall},
    {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall},
    {wall,Up,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,slime,floor,wall},
    {wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall}
    };
    public static readonly MapTileType[,] Labyrinth2FMap = //2층
    {
    {wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall},
    {wall,floor,floor,floor,floor,floor,wall,wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,Down,floor,wall},
    {wall,floor,floor,goblin,floor,floor,wall,wall,floor,floor,floor,floor,wall,wall,wall,floor,floor,floor,floor,wall},
    {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall,floor,floor,floor,wall,floor,floor,goblin,floor,wall},
    {wall,wall,wall,wall,floor,floor,wall,wall,wall,floor,wall,floor,wall,floor,wall,wall,wall,floor,floor,wall},
    {wall,floor,floor,floor,floor,floor,wall,floor,floor,floor,wall,floor,wall,floor,floor,floor,floor,floor,floor,wall},
    {wall,floor,wall,wall,wall,floor,wall,floor,wall,wall,wall,floor,wall,wall,wall,wall,wall,floor,floor,wall},
    {wall,floor,floor,floor,wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,goblin,wall,floor,floor,wall},
    {wall,wall,wall,floor,wall,wall,wall,wall,floor,floor,wall,wall,wall,wall,floor,floor,wall,floor,floor,wall},
    {wall,floor,floor,floor,floor,floor,floor,floor,floor,goblin,floor,floor,floor,floor,floor,floor,wall,floor,floor,wall},
    {wall,floor,wall,wall,wall,wall,wall,floor,wall,wall,wall,wall,wall,floor,wall,wall,wall,floor,floor,wall},
    {wall,floor,floor,floor,floor,floor,wall,floor,floor,floor,floor,floor,wall,floor,floor,floor,floor,floor,floor,wall},
    {wall,wall,wall,wall,floor,floor,wall,wall,wall,floor,wall,floor,wall,wall,wall,wall,wall,wall,floor,wall},
    {wall,floor,floor,floor,floor,floor,floor,floor,wall,floor,wall,floor,floor,floor,floor,goblin,floor,floor,floor,wall},
    {wall,floor,wall,wall,wall,wall,wall,floor,wall,floor,wall,wall,wall,wall,wall,wall,wall,floor,floor,wall},
    {wall,floor,floor,floor,floor,goblin,floor,floor,wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall},
    {wall,wall,wall,floor,wall,wall,wall,floor,wall,wall,wall,wall,wall,floor,wall,wall,wall,wall,floor,wall},
    {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall},
    {wall,Up,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall},
    {wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall}
    };
    public static readonly MapTileType[,] Labyrinth3FMap = //3층
    {
    {wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall},
    {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall,wall,floor,floor,floor,floor,floor,Down,floor,wall},
    {wall,floor,wall,wall,wall,wall,wall,floor,floor,floor,wall,wall,floor,floor,skeleton,floor,floor,floor,floor,wall},
    {wall,floor,wall,floor,floor,floor,wall,floor,wall,floor,floor,floor,floor,floor,wall,wall,wall,floor,floor,wall},
    {wall,floor,wall,floor,skeleton,floor,wall,floor,wall,wall,wall,wall,wall,floor,wall,floor,floor,floor,floor,wall},
    {wall,floor,floor,floor,floor,floor,wall,floor,floor,floor,floor,floor,wall,floor,wall,floor,wall,wall,wall,wall},
    {wall,wall,wall,wall,wall,floor,wall,wall,wall,wall,wall,floor,wall,floor,floor,floor,floor,floor,floor,wall},
    {wall,floor,floor,floor,floor,floor,floor,floor,floor,skeleton,wall,floor,wall,wall,wall,wall,wall,wall,floor,wall},
    {wall,floor,wall,wall,wall,wall,wall,wall,wall,floor,wall,floor,floor,floor,floor,floor,floor,wall,floor,wall},
    {wall,floor,floor,floor,floor,floor,floor,floor,wall,floor,floor,floor,wall,wall,wall,skeleton,floor,wall,floor,wall},
    {wall,wall,wall,floor,wall,wall,wall,floor,wall,wall,wall,floor,wall,floor,floor,floor,floor,wall,floor,wall},
    {wall,floor,floor,floor,wall,floor,floor,floor,floor,floor,wall,floor,wall,floor,wall,wall,wall,wall,floor,wall},
    {wall,floor,wall,wall,wall,floor,wall,wall,wall,floor,wall,floor,floor,floor,floor,floor,floor,floor,floor,wall},
    {wall,floor,floor,floor,floor,floor,wall,skeleton,floor,floor,wall,wall,wall,wall,wall,wall,wall,wall,floor,wall},
    {wall,wall,wall,wall,wall,floor,wall,floor,wall,wall,wall,floor,floor,floor,floor,floor,floor,wall,floor,wall},
    {wall,floor,floor,floor,floor,floor,wall,floor,floor,floor,floor,floor,wall,wall,wall,skeleton,floor,wall,floor,wall},
    {wall,floor,wall,wall,wall,wall,wall,wall,wall,wall,wall,floor,wall,floor,floor,floor,floor,floor,floor,wall},
    {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall,wall,wall,wall,floor,wall},
    {wall,Up,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall},
    {wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall}
    };
    public static readonly MapTileType[,] Labyrinth4FMap = //4층
    {
    {wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall},
    {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall,wall,floor,floor,floor,floor,floor,Down,floor,wall},
    {wall,floor,wall,wall,wall,wall,wall,floor,floor,floor,wall,wall,floor,floor,skeleton,floor,floor,floor,floor,wall},
    {wall,floor,wall,floor,floor,floor,wall,floor,wall,floor,floor,floor,floor,floor,wall,wall,wall,floor,floor,wall},
    {wall,floor,wall,floor,skeleton,floor,wall,floor,wall,wall,wall,wall,wall,floor,wall,floor,floor,floor,floor,wall},
    {wall,floor,floor,floor,floor,floor,wall,floor,floor,floor,floor,floor,wall,floor,wall,floor,wall,wall,wall,wall},
    {wall,wall,wall,wall,wall,floor,wall,wall,wall,wall,wall,floor,wall,floor,floor,floor,floor,floor,floor,wall},
    {wall,floor,floor,floor,floor,floor,floor,floor,floor,skeleton,wall,floor,wall,wall,wall,wall,wall,wall,floor,wall},
    {wall,floor,wall,wall,wall,wall,wall,wall,wall,floor,wall,floor,floor,floor,floor,floor,floor,wall,floor,wall},
    {wall,floor,floor,floor,floor,floor,floor,floor,wall,floor,floor,floor,wall,wall,wall,skeleton,floor,wall,floor,wall},
    {wall,wall,wall,floor,wall,wall,wall,floor,wall,wall,wall,floor,wall,floor,floor,floor,floor,wall,floor,wall},
    {wall,floor,floor,floor,wall,floor,floor,floor,floor,floor,wall,floor,wall,floor,wall,wall,wall,wall,floor,wall},
    {wall,floor,wall,wall,wall,floor,wall,wall,wall,floor,wall,floor,floor,floor,floor,floor,floor,floor,floor,wall},
    {wall,floor,floor,floor,floor,floor,wall,skeleton,floor,floor,wall,wall,wall,wall,wall,wall,wall,wall,floor,wall},
    {wall,wall,wall,wall,wall,floor,wall,floor,wall,wall,wall,floor,floor,floor,floor,floor,floor,wall,floor,wall},
    {wall,floor,floor,floor,floor,floor,wall,floor,floor,floor,floor,floor,wall,wall,wall,skeleton,floor,wall,floor,wall},
    {wall,floor,wall,wall,wall,wall,wall,wall,wall,wall,wall,floor,wall,floor,floor,floor,floor,floor,floor,wall},
    {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall,wall,wall,wall,floor,wall},
    {wall,Up,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall},
    {wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall}
    };
    public static readonly MapTileType[,] Labyrinth5FMap = //5층
    {
        {wall,wall,wall,wall,wall,Down,wall,wall,wall,wall,wall},
        {wall,floor,floor,floor,floor,littleDevil,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,wall,wall,wall,wall,Up,wall,wall,wall,wall,wall},
    };
    public static readonly MapTileType[,] Labyrinth6FMap = //6층
    {
    {wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall},
    {wall,floor,floor,floor,floor,floor,floor,floor,floor,wall,wall,floor,floor,floor,floor,floor,floor,Down,floor,wall},
    {wall,floor,floor,floor,floor,hobgoblin,floor,floor,floor,wall,wall,floor,floor,floor,floor,floor,floor,floor,floor,wall},
    {wall,floor,floor,wall,wall,wall,floor,floor,floor,floor,floor,floor,floor,wall,wall,wall,floor,floor,floor,wall},
    {wall,floor,floor,wall,wall,wall,floor,floor,hobgoblin,floor,floor,floor,floor,wall,wall,wall,floor,floor,floor,wall},
    {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall},
    {wall,wall,wall,wall,floor,floor,wall,wall,wall,wall,wall,wall,wall,wall,floor,floor,wall,wall,wall,wall},
    {wall,wall,wall,wall,floor,floor,wall,wall,wall,wall,wall,wall,wall,wall,floor,floor,wall,wall,wall,wall},
    {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,hobgoblin,floor,floor,floor,floor,floor,floor,floor,floor,wall},
    {wall,floor,floor,floor,floor,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,floor,floor,floor,floor,wall},
    {wall,floor,floor,floor,floor,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,floor,floor,floor,floor,wall},
    {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall},
    {wall,wall,wall,wall,floor,floor,wall,wall,wall,wall,wall,wall,wall,wall,floor,floor,wall,wall,wall,wall},
    {wall,wall,wall,wall,floor,floor,wall,wall,wall,wall,wall,wall,wall,wall,floor,floor,wall,wall,wall,wall},
    {wall,floor,floor,floor,floor,floor,floor,floor,floor,hobgoblin,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall},
    {wall,floor,floor,wall,wall,wall,floor,floor,floor,floor,floor,floor,floor,wall,wall,wall,floor,floor,floor,wall},
    {wall,floor,floor,wall,wall,wall,floor,floor,floor,floor,floor,hobgoblin,floor,wall,wall,wall,floor,floor,floor,wall},
    {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall},
    {wall,Up,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,hobgoblin,floor,floor,wall},
    {wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall}
    };
    
    public static readonly MapTileType[,] Labyrinth7FMap = //7층
    {
    {wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall},
    {wall,floor,floor,floor,floor,floor,floor,wall,wall,floor,floor,floor,floor,floor,floor,floor,floor,Down,floor,wall},
    {wall,floor,floor,orc,floor,floor,floor,wall,wall,floor,floor,floor,floor,floor,orc,floor,floor,floor,floor,wall},
    {wall,floor,floor,floor,floor,floor,floor,wall,wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall},
    {wall,wall,wall,wall,floor,floor,wall,wall,wall,wall,wall,wall,floor,floor,wall,wall,wall,wall,floor,wall},
    {wall,wall,wall,wall,floor,floor,wall,wall,wall,wall,wall,wall,floor,floor,wall,wall,wall,wall,floor,wall},
    {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall},
    {wall,floor,floor,wall,wall,wall,wall,floor,floor,orc,floor,floor,wall,wall,wall,wall,floor,floor,floor,wall},
    {wall,floor,floor,wall,wall,wall,wall,floor,floor,floor,floor,floor,wall,wall,wall,wall,floor,floor,floor,wall},
    {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall},
    {wall,wall,wall,wall,floor,floor,wall,wall,wall,wall,wall,wall,wall,wall,floor,floor,wall,wall,wall,wall},
    {wall,wall,wall,wall,floor,floor,wall,wall,wall,wall,wall,wall,wall,wall,floor,floor,wall,wall,wall,wall},
    {wall,floor,floor,floor,floor,floor,floor,floor,floor,orc,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall},
    {wall,floor,floor,wall,wall,wall,wall,floor,floor,floor,floor,floor,wall,wall,wall,wall,floor,floor,floor,wall},
    {wall,floor,floor,wall,wall,wall,wall,floor,floor,floor,floor,floor,wall,wall,wall,wall,floor,floor,floor,wall},
    {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall},
    {wall,wall,wall,wall,floor,floor,wall,wall,wall,wall,wall,wall,floor,floor,wall,wall,wall,wall,floor,wall},
    {wall,wall,wall,wall,floor,floor,wall,wall,wall,wall,wall,wall,floor,floor,wall,wall,wall,wall,floor,wall},
    {wall,Up,floor,floor,floor,floor,floor,orc,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall},
    {wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall}
    };
    public static readonly MapTileType[,] Labyrinth8FMap = //8층
    {
    {wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall},
    {wall,floor,floor,floor,floor,floor,floor,floor,floor,wall,wall,floor,floor,floor,floor,floor,floor,Down,floor,wall},
    {wall,floor,floor,gargoyle,floor,floor,floor,floor,floor,wall,wall,floor,floor,floor,floor,gargoyle,floor,floor,floor,wall},
    {wall,floor,floor,floor,floor,wall,wall,floor,floor,floor,floor,floor,floor,wall,wall,floor,floor,floor,floor,wall},
    {wall,floor,floor,floor,floor,wall,wall,floor,floor,floor,floor,floor,floor,wall,wall,floor,floor,floor,floor,wall},
    {wall,wall,wall,floor,floor,wall,wall,wall,wall,floor,floor,wall,wall,wall,wall,floor,floor,wall,wall,wall},
    {wall,wall,wall,floor,floor,wall,wall,wall,wall,floor,floor,wall,wall,wall,wall,floor,floor,wall,wall,wall},
    {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,gargoyle,floor,floor,floor,floor,floor,floor,floor,floor,wall},
    {wall,floor,floor,wall,wall,wall,wall,floor,floor,floor,floor,floor,wall,wall,wall,wall,floor,floor,floor,wall},
    {wall,floor,floor,wall,wall,wall,wall,floor,floor,wall,wall,floor,wall,wall,wall,wall,floor,floor,floor,wall},
    {wall,floor,floor,floor,floor,floor,floor,floor,floor,wall,wall,floor,floor,floor,floor,floor,floor,floor,floor,wall},
    {wall,wall,wall,wall,floor,floor,wall,wall,wall,wall,wall,wall,wall,wall,floor,floor,wall,wall,wall,wall},
    {wall,wall,wall,wall,floor,floor,wall,wall,wall,wall,wall,wall,wall,wall,floor,floor,wall,wall,wall,wall},
    {wall,floor,floor,floor,floor,floor,floor,gargoyle,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall},
    {wall,floor,floor,wall,wall,wall,wall,floor,floor,floor,wall,wall,wall,wall,wall,wall,floor,floor,floor,wall},
    {wall,floor,floor,wall,wall,wall,wall,floor,floor,floor,wall,wall,wall,wall,wall,wall,floor,floor,floor,wall},
    {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,gargoyle,floor,floor,floor,floor,floor,floor,wall},
    {wall,floor,floor,wall,wall,wall,wall,wall,wall,floor,floor,wall,wall,wall,wall,wall,wall,floor,floor,wall},
    {wall,Up,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,gargoyle,floor,wall},
    {wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall}
};
    public static readonly MapTileType[,] Labyrinth9FMap = //9층
    {
    {wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall},
    {wall,floor,floor,floor,floor,floor,floor,floor,wall,wall,floor,floor,floor,floor,floor,floor,floor,Down,floor,wall},
    {wall,floor,floor,waterSpirit,floor,floor,floor,floor,wall,wall,floor,floor,floor,floor,waterSpirit,floor,floor,floor,floor,wall},
    {wall,floor,floor,floor,floor,wall,wall,floor,floor,floor,floor,floor,floor,wall,wall,floor,floor,floor,floor,wall},
    {wall,floor,floor,floor,floor,wall,wall,floor,floor,floor,floor,floor,floor,wall,wall,floor,floor,floor,floor,wall},
    {wall,wall,wall,floor,floor,wall,wall,wall,wall,floor,floor,wall,wall,wall,wall,floor,floor,wall,wall,wall},
    {wall,wall,wall,floor,floor,wall,wall,wall,wall,floor,floor,wall,wall,wall,wall,floor,floor,wall,wall,wall},
    {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,waterSpirit,floor,floor,floor,floor,floor,floor,floor,floor,wall},
    {wall,floor,floor,wall,wall,wall,wall,floor,floor,floor,floor,floor,wall,wall,wall,wall,floor,floor,floor,wall},
    {wall,floor,floor,wall,wall,wall,wall,floor,floor,wall,wall,floor,wall,wall,wall,wall,floor,floor,floor,wall},
    {wall,floor,floor,floor,floor,floor,floor,floor,floor,wall,wall,floor,floor,floor,floor,floor,floor,floor,floor,wall},
    {wall,wall,wall,wall,floor,floor,wall,wall,wall,wall,wall,wall,wall,wall,floor,floor,wall,wall,wall,wall},
    {wall,wall,wall,wall,floor,floor,wall,wall,wall,wall,wall,wall,wall,wall,floor,floor,wall,wall,wall,wall},
    {wall,floor,floor,floor,floor,floor,floor,waterSpirit,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall},
    {wall,floor,floor,wall,wall,wall,wall,floor,floor,floor,wall,wall,wall,wall,wall,wall,floor,floor,floor,wall},
    {wall,floor,floor,wall,wall,wall,wall,floor,floor,floor,wall,wall,wall,wall,wall,wall,floor,floor,floor,wall},
    {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,waterSpirit,floor,floor,floor,floor,floor,floor,wall},
    {wall,floor,floor,wall,wall,wall,wall,wall,wall,floor,floor,wall,wall,wall,wall,wall,wall,floor,floor,wall},
    {wall,Up,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,waterSpirit,floor,wall},
    {wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall}
};
    public static readonly MapTileType[,] Labyrinth10FMap = //10층
    {
        {wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall},
        {wall,floor,floor,floor,floor,gatekeeperGolem,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,wall,wall,wall,wall,Up,wall,wall,wall,wall,wall},
    };
    

}
