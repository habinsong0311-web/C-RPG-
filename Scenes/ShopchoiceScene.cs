using ConsoleGameFramework.Core;
using ConsoleGameFramework.UI;
using System;

public class ShopchoiceScene : SceneBase
{
    public override SceneKey Key => SceneKey.Shopchoice;
    private static readonly List<MenuOption> mainMenu = new List<MenuOption>
    {
        new MenuOption(1,"장비 구매",""),
        new MenuOption(2,"소모품 구메",""),
        new MenuOption(3,"아이템 판매",""),

    };
    public override void Render(GameContext context)
    {
        Console.Clear();
        ConsoleUI.WriteTitle("상점", "X키 입력으로 되돌아가기");
        ConsoleUI.WriteMenu(mainMenu, "상점 선택");
    }
    public override void HandleInput(GameContext context)
    {
        string input = Console.ReadLine();
        if (input == "x" || input == "X")
        {
            context.Game.PopScene();
            return;
        }
        if (int.TryParse(input, out int choice))
            switch (choice)
            {

                case 1:
                    context.Game.PushScene(SceneKey.EquipmentShop);
                    return;
                case 2:
                    context.Game.PushScene(SceneKey.ConsumablesShop);
                    return;
                case 3:
                    context.Game.PushScene(SceneKey.SellShop);
                    return;
            }
    }
}

