using ConsoleGameFramework.Models;
using ConsoleGameFramework.Core;
using ConsoleGameFramework.UI;
using static ConsoleGameFramework.Models.MapTileType;
using System;
public static class OriginalLabyrinthMapData
{
    public static readonly MapTileType[,] Labyrinth1FMap = //1층
    {
        {wall,wall,wall,wall,wall,wall,wall,Down,wall,wall,wall,wall,wall,wall,wall},
        {wall,floor,slime,floor,floor,floor,floor,floor,floor,floor,floor,slime,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,slime,floor,floor,floor,floor,floor,floor,floor,slime,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,slime,floor,floor,floor,floor,floor,floor,floor,floor,slime,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,wall,wall,wall,wall,wall,wall,wall,Up,wall,wall,wall,wall,wall,wall},
    };
    public static readonly MapTileType[,] Labyrinth2FMap = //2층
    {
        {wall,wall,wall,wall,wall,wall,wall,Down,wall,wall,wall,wall,wall,wall,wall},
        {wall,floor,goblin,floor,floor,floor,floor,floor,floor,floor,floor,goblin,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,goblin,floor,floor,floor,floor,floor,floor,floor,goblin,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,goblin,floor,floor,floor,floor,floor,floor,floor,floor,goblin,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,wall,wall,wall,wall,wall,wall,wall,Up,wall,wall,wall,wall,wall,wall},
    };
    public static readonly MapTileType[,] Labyrinth3FMap = //3층
    {
        {wall,wall,wall,wall,wall,wall,wall,Down,wall,wall,wall,wall,wall,wall,wall},
        {wall,floor,skeleton,floor,floor,floor,floor,floor,floor,floor,floor,skeleton,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,skeleton,floor,floor,floor,floor,floor,floor,floor,skeleton,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,skeleton,floor,floor,floor,floor,floor,floor,floor,floor,skeleton,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,wall,wall,wall,wall,wall,wall,wall,Up,wall,wall,wall,wall,wall,wall},
    };
    public static readonly MapTileType[,] Labyrinth4FMap = //4층
    {
        {wall,wall,wall,wall,wall,wall,wall,Down,wall,wall,wall,wall,wall,wall,wall},
        {wall,floor,goblinMage,floor,floor,floor,floor,floor,floor,floor,floor,goblinMage,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,goblinMage,floor,floor,floor,floor,floor,floor,floor,goblinMage,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,goblinMage,floor,floor,floor,floor,floor,floor,floor,floor,goblinMage,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,wall,wall,wall,wall,wall,wall,wall,Up,wall,wall,wall,wall,wall,wall},
    };
    public static readonly MapTileType[,] Labyrinth5FMap = //5층
    {
        {wall,wall,wall,wall,wall,wall,wall,Down,wall,wall,wall,wall,wall,wall,wall},
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,littleDevil,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,wall,wall,wall,wall,wall,wall,wall,Up,wall,wall,wall,wall,wall,wall},
    };
    public static readonly MapTileType[,] Labyrinth6FMap = //6층
    {
        {wall,wall,wall,wall,wall,wall,wall,Down,wall,wall,wall,wall,wall,wall,wall},
        {wall,floor,hobgoblin,floor,floor,floor,floor,floor,floor,floor,floor,hobgoblin,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,hobgoblin,floor,floor,floor,floor,floor,floor,floor,hobgoblin,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,hobgoblin,floor,floor,floor,floor,floor,floor,floor,floor,hobgoblin,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,wall,wall,wall,wall,wall,wall,wall,Up,wall,wall,wall,wall,wall,wall},
    };
    public static readonly MapTileType[,] Labyrinth7FMap = //7층
    {
        {wall,wall,wall,wall,wall,wall,wall,Down,wall,wall,wall,wall,wall,wall,wall},
        {wall,floor,orc,floor,floor,floor,floor,floor,floor,floor,floor,orc,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,orc,floor,floor,floor,floor,floor,floor,floor,orc,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,orc,floor,floor,floor,floor,floor,floor,floor,floor,orc,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,wall,wall,wall,wall,wall,wall,wall,Up,wall,wall,wall,wall,wall,wall},
    };
    public static readonly MapTileType[,] Labyrinth8FMap = //8층
    {
        {wall,wall,wall,wall,wall,wall,wall,Down,wall,wall,wall,wall,wall,wall,wall},
        {wall,floor,gargoyle,floor,floor,floor,floor,floor,floor,floor,floor,gargoyle,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,gargoyle,floor,floor,floor,floor,floor,floor,floor,gargoyle,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,gargoyle,floor,floor,floor,floor,floor,floor,floor,floor,gargoyle,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,wall,wall,wall,wall,wall,wall,wall,Up,wall,wall,wall,wall,wall,wall},
    };
    public static readonly MapTileType[,] Labyrinth9FMap = //9층
    {
        {wall,wall,wall,wall,wall,wall,wall,Down,wall,wall,wall,wall,wall,wall,wall},
        {wall,floor,waterSpirit,floor,floor,floor,floor,floor,floor,floor,floor,waterSpirit,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,waterSpirit,floor,floor,floor,floor,floor,floor,floor,waterSpirit,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,waterSpirit,floor,floor,floor,floor,floor,floor,floor,floor,waterSpirit,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,wall,wall,wall,wall,wall,wall,wall,Up,wall,wall,wall,wall,wall,wall},
    };
    public static readonly MapTileType[,] Labyrinth10FMap = //10층
    {
        {wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall,wall},
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,gatekeeperGolem,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,floor,wall },
        {wall,wall,wall,wall,wall,wall,wall,wall,Up,wall,wall,wall,wall,wall,wall},
    };

}
