using ConsoleGameFramework.Core;
using ConsoleGameFramework.Models;
using ConsoleGameFramework.UI;
using System.Text;

public class ShopScene : SceneBase
{
    public override SceneKey Key => SceneKey.LabyrinthVillage;
    private static readonly List<MenuOption> buyMenu = new List<MenuOption>
    {
        new MenuOption(1,"철 검",""),
        new MenuOption(2,"철 방패",""),
        new MenuOption(2,"철 방패",""),
        new MenuOption(2,"철 방패",""),
        new MenuOption(2,"철 방패",""),
        new MenuOption(2,"철 방패",""),
        new MenuOption(2,"철 방패",""),
        new MenuOption(2,"철 방패",""),
    }
    public override void Render(GameContext context)
    {
        Console.Clear();
        ConsoleUI.WriteTitle("상점", "X키 입력으로 되돌아가기");

    }
    public override void HandleInput(GameContext context)
    { }
}
